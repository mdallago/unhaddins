﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Antlr.Runtime.Tree;
using Antlr.Runtime;

namespace NHibernate.Hql.Ast.ANTLR
{
    public partial class HqlParser
    {
        /** True if this is a filter query (allow no FROM clause). **/
        private bool filter;

        private Logger log = new Logger();

        public void WeakKeywords()
        {
            int t = input.LA(1);

            switch (t)
            {
                case ORDER:
                case GROUP:
                    // Case 1: Multi token keywords GROUP BY and ORDER BY
                    // The next token ( LT(2) ) should be 'by'... otherwise, this is just an ident.
                    if (input.LA(2) != LITERAL_by)
                    {
                        input.LT(1).Type = IDENT;
                        if (log.isDebugEnabled())
                        {
                            log.debug("weakKeywords() : new LT(1) token - " + input.LT(1));
                        }
                    }
                    break;
                default:
                    // Case 2: The current token is after FROM and before '.'.
                    if (t != IDENT && input.LA(-1) == FROM && input.LA(2) == DOT)
                    {
                        HqlToken hqlToken = (HqlToken)input.LT(1);
                        if (hqlToken.PossibleId)
                        {
                            hqlToken.Type = IDENT;
                            if (log.isDebugEnabled())
                            {
                                log.debug("weakKeywords() : new LT(1) token - " + input.LT(1));
                            }
                        }
                    }
                    break;
            }
        }

        public ITree NegateNode(ITree node)
        {
            // TODO - copy code from HqlParser.java
            switch (node.Type)
            {
                case OR:
                    ITree andNode = (ITree)TreeAdaptor.Create(AND, "AND");
                    andNode.AddChild(NegateNode(node.GetChild(0)));
                    andNode.AddChild(NegateNode(node.GetChild(1)));
                    return andNode;
                // TODO - remaining cases here...
            }
            return node;
        }

        public ITree ProcessEqualityExpression(object o)
        {
            ITree x = o as ITree;

            if (x == null)
            {
                log.warn("processEqualityExpression() : No expression to process!");
                return null;
            }

            int type = x.Type;
            if (type == EQ || type == NE)
            {
                bool negated = type == NE;
                if (x.ChildCount == 2)
                {
                    ITree a = x.GetChild(0);
                    ITree b = x.GetChild(1);
                    // (EQ NULL b) => (IS_NULL b)
                    if (a.Type == NULL && b.Type != NULL)
                    {
                        return CreateIsNullParent(b, negated);
                    }
                    // (EQ a NULL) => (IS_NULL a)
                    else if (b.Type == NULL && a.Type != NULL)
                    {
                        return CreateIsNullParent(a, negated);
                    }
                    else if (b.Type == EMPTY)
                    {
                        return ProcessIsEmpty(a, negated);
                    }
                    else
                    {
                        return x;
                    }
                }
                else
                {
                    return x;
                }
            }
            else
            {
                return x;
            }
        }

        public void HandleDotIdent()
        {
            // This handles HHH-354, where there is a strange property name in a where clause.
            // If the lookahead contains a DOT then something that isn't an IDENT...
            if (input.LA(1) == DOT && input.LA(2) != IDENT)
            {
                // See if the second lookahed token can be an identifier.
                HqlToken t = (HqlToken)input.LT(2);
                if (t.PossibleId)
                {
                    // Set it!
                    input.LT(2).Type =IDENT;
                    if (log.isDebugEnabled())
                    {
                        log.debug("handleDotIdent() : new LT(2) token - " + input.LT(1));
                    }
                }
            }
        }

        private ITree CreateIsNullParent(ITree node, bool negated)
        {
            int type = negated ? IS_NOT_NULL : IS_NULL;
            String text = negated ? "is not null" : "is null";

            return (ITree) adaptor.BecomeRoot(adaptor.Create(type, text), node);
        }

        private ITree ProcessIsEmpty(ITree node, bool negated)
        {
            // NOTE: Because we're using ASTUtil.createParent(), the tree must be created from the bottom up.
            // IS EMPTY x => (EXISTS (QUERY (SELECT_FROM (FROM x) ) ) )

            ITree ast = CreateSubquery(node);

            ast = (ITree) adaptor.BecomeRoot(adaptor.Create(EXISTS, "exists"), ast);

            // Add NOT if it's negated.
            if (!negated)
            {
                ast = (ITree)adaptor.BecomeRoot(adaptor.Create(NOT, "not"), ast);
            }
            return ast;
        }

        private ITree CreateSubquery(ITree node)
        {
            return (ITree) adaptor.BecomeRoot(
                               adaptor.Create(QUERY, "QUERY"),
                               adaptor.BecomeRoot(
                                   adaptor.Create(SELECT_FROM, "SELECT_FROM"),
                                   adaptor.BecomeRoot(
                                       adaptor.Create(FROM, "FROM"),
                                       adaptor.Create(RANGE, "RANGE")))
                               );
        }

        public object ProcessMemberOf(object x, object y)
        {
            throw new NotImplementedException();
        }

        public HqlParser.identifier_return HandleIdentifierError(object o, object o2)
        {
            // TODO
            throw new NotImplementedException();
        }
    }
}
