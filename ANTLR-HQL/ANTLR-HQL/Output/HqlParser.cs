// $ANTLR 3.1.2 /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g 2009-03-26 11:29:13

// The variable 'variable' is assigned but its value is never used.
#pragma warning disable 168, 219
// Unreachable code detected.
#pragma warning disable 162
namespace  NHibernate.Hql.Ast.ANTLR 
{

using NHibernate.Hql.Ast.ANTLR.Tree;


using System;
using Antlr.Runtime;
using IList 		= System.Collections.IList;
using ArrayList 	= System.Collections.ArrayList;
using Stack 		= Antlr.Runtime.Collections.StackList;



using Antlr.Runtime.Tree;

public partial class HqlParser : Parser
{
    public static readonly string[] tokenNames = new string[] 
	{
        "<invalid>", 
		"<EOR>", 
		"<DOWN>", 
		"<UP>", 
		"ALL", 
		"ANY", 
		"AND", 
		"AS", 
		"ASCENDING", 
		"AVG", 
		"BETWEEN", 
		"CLASS", 
		"COUNT", 
		"DELETE", 
		"DESCENDING", 
		"DOT", 
		"DISTINCT", 
		"ELEMENTS", 
		"ESCAPE", 
		"EXISTS", 
		"FALSE", 
		"FETCH", 
		"FROM", 
		"FULL", 
		"GROUP", 
		"HAVING", 
		"IN", 
		"INDICES", 
		"INNER", 
		"INSERT", 
		"INTO", 
		"IS", 
		"JOIN", 
		"LEFT", 
		"LIKE", 
		"MAX", 
		"MIN", 
		"NEW", 
		"NOT", 
		"NULL", 
		"OR", 
		"ORDER", 
		"OUTER", 
		"PROPERTIES", 
		"RIGHT", 
		"SELECT", 
		"SET", 
		"SOME", 
		"SUM", 
		"TRUE", 
		"UNION", 
		"UPDATE", 
		"VERSIONED", 
		"WHERE", 
		"LITERAL_by", 
		"CASE", 
		"END", 
		"ELSE", 
		"THEN", 
		"WHEN", 
		"ON", 
		"WITH", 
		"BOTH", 
		"EMPTY", 
		"LEADING", 
		"MEMBER", 
		"OBJECT", 
		"OF", 
		"TRAILING", 
		"AGGREGATE", 
		"ALIAS", 
		"CONSTRUCTOR", 
		"CASE2", 
		"EXPR_LIST", 
		"FILTER_ENTITY", 
		"IN_LIST", 
		"INDEX_OP", 
		"IS_NOT_NULL", 
		"IS_NULL", 
		"METHOD_CALL", 
		"NOT_BETWEEN", 
		"NOT_IN", 
		"NOT_LIKE", 
		"ORDER_ELEMENT", 
		"QUERY", 
		"RANGE", 
		"ROW_STAR", 
		"SELECT_FROM", 
		"UNARY_MINUS", 
		"UNARY_PLUS", 
		"VECTOR_EXPR", 
		"WEIRD_IDENT", 
		"CONSTANT", 
		"NUM_INT", 
		"NUM_DOUBLE", 
		"NUM_FLOAT", 
		"NUM_LONG", 
		"JAVA_CONSTANT", 
		"COMMA", 
		"EQ", 
		"OPEN", 
		"CLOSE", 
		"NE", 
		"SQL_NE", 
		"LT", 
		"GT", 
		"LE", 
		"GE", 
		"CONCAT", 
		"PLUS", 
		"MINUS", 
		"STAR", 
		"DIV", 
		"OPEN_BRACKET", 
		"CLOSE_BRACKET", 
		"COLON", 
		"PARAM", 
		"QUOTED_String", 
		"IDENT", 
		"ID_START_LETTER", 
		"ID_LETTER", 
		"ESCqs", 
		"WS", 
		"EXPONENT", 
		"FLOAT_SUFFIX", 
		"HEX_DIGIT", 
		"'ascending'", 
		"'descending'"
    };

    public const int COMMA = 98;
    public const int EXISTS = 19;
    public const int EXPR_LIST = 73;
    public const int FETCH = 21;
    public const int MINUS = 110;
    public const int AS = 7;
    public const int END = 56;
    public const int INTO = 30;
    public const int FALSE = 20;
    public const int ELEMENTS = 17;
    public const int THEN = 58;
    public const int ALIAS = 70;
    public const int ON = 60;
    public const int DOT = 15;
    public const int ORDER = 41;
    public const int AND = 6;
    public const int CONSTANT = 92;
    public const int RIGHT = 44;
    public const int METHOD_CALL = 79;
    public const int UNARY_MINUS = 88;
    public const int CONCAT = 108;
    public const int PROPERTIES = 43;
    public const int SELECT = 45;
    public const int LE = 106;
    public const int BETWEEN = 10;
    public const int NUM_INT = 93;
    public const int BOTH = 62;
    public const int PLUS = 109;
    public const int VERSIONED = 52;
    public const int MEMBER = 65;
    public const int UNION = 50;
    public const int DISTINCT = 16;
    public const int RANGE = 85;
    public const int FILTER_ENTITY = 74;
    public const int IDENT = 118;
    public const int WHEN = 59;
    public const int DESCENDING = 14;
    public const int WS = 122;
    public const int EQ = 99;
    public const int NEW = 37;
    public const int LT = 104;
    public const int ESCqs = 121;
    public const int OF = 67;
    public const int UPDATE = 51;
    public const int SELECT_FROM = 87;
    public const int LITERAL_by = 54;
    public const int FLOAT_SUFFIX = 124;
    public const int ANY = 5;
    public const int UNARY_PLUS = 89;
    public const int NUM_FLOAT = 95;
    public const int GE = 107;
    public const int CASE = 55;
    public const int OPEN_BRACKET = 113;
    public const int ELSE = 57;
    public const int OPEN = 100;
    public const int COUNT = 12;
    public const int NULL = 39;
    public const int COLON = 115;
    public const int DIV = 112;
    public const int HAVING = 25;
    public const int ALL = 4;
    public const int SET = 46;
    public const int INSERT = 29;
    public const int TRUE = 49;
    public const int CASE2 = 72;
    public const int IS_NOT_NULL = 77;
    public const int WHERE = 53;
    public const int AGGREGATE = 69;
    public const int VECTOR_EXPR = 90;
    public const int LEADING = 64;
    public const int CLOSE_BRACKET = 114;
    public const int NUM_DOUBLE = 94;
    public const int T__126 = 126;
    public const int INNER = 28;
    public const int QUERY = 84;
    public const int ORDER_ELEMENT = 83;
    public const int OR = 40;
    public const int FULL = 23;
    public const int INDICES = 27;
    public const int IS_NULL = 78;
    public const int GROUP = 24;
    public const int ESCAPE = 18;
    public const int T__127 = 127;
    public const int PARAM = 116;
    public const int ID_LETTER = 120;
    public const int INDEX_OP = 76;
    public const int HEX_DIGIT = 125;
    public const int LEFT = 33;
    public const int TRAILING = 68;
    public const int JOIN = 32;
    public const int NOT_BETWEEN = 80;
    public const int SUM = 48;
    public const int ROW_STAR = 86;
    public const int OUTER = 42;
    public const int FROM = 22;
    public const int NOT_IN = 81;
    public const int DELETE = 13;
    public const int OBJECT = 66;
    public const int MAX = 35;
    public const int QUOTED_String = 117;
    public const int EMPTY = 63;
    public const int NOT_LIKE = 82;
    public const int ASCENDING = 8;
    public const int NUM_LONG = 96;
    public const int IS = 31;
    public const int SQL_NE = 103;
    public const int IN_LIST = 75;
    public const int WEIRD_IDENT = 91;
    public const int GT = 105;
    public const int NE = 102;
    public const int MIN = 36;
    public const int LIKE = 34;
    public const int WITH = 61;
    public const int IN = 26;
    public const int CONSTRUCTOR = 71;
    public const int CLASS = 11;
    public const int SOME = 47;
    public const int EXPONENT = 123;
    public const int ID_START_LETTER = 119;
    public const int EOF = -1;
    public const int CLOSE = 101;
    public const int AVG = 9;
    public const int STAR = 111;
    public const int NOT = 38;
    public const int JAVA_CONSTANT = 97;

    // delegates
    // delegators



        public HqlParser(ITokenStream input)
    		: this(input, new RecognizerSharedState()) {
        }

        public HqlParser(ITokenStream input, RecognizerSharedState state)
    		: base(input, state) {
            InitializeCyclicDFAs();

             
        }
        
    protected ITreeAdaptor adaptor = new CommonTreeAdaptor();

    public ITreeAdaptor TreeAdaptor
    {
        get { return this.adaptor; }
        set {
    	this.adaptor = value;
    	}
    }

    override public string[] TokenNames {
		get { return HqlParser.tokenNames; }
    }

    override public string GrammarFileName {
		get { return "/Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g"; }
    }


    public class statement_return : ParserRuleReturnScope
    {
        private IASTNode tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (IASTNode) value; }
        }
    };

    // $ANTLR start "statement"
    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:141:1: statement : ( updateStatement | deleteStatement | selectStatement | insertStatement ) ;
    public HqlParser.statement_return statement() // throws RecognitionException [1]
    {   
        HqlParser.statement_return retval = new HqlParser.statement_return();
        retval.Start = input.LT(1);

        IASTNode root_0 = null;

        HqlParser.updateStatement_return updateStatement1 = default(HqlParser.updateStatement_return);

        HqlParser.deleteStatement_return deleteStatement2 = default(HqlParser.deleteStatement_return);

        HqlParser.selectStatement_return selectStatement3 = default(HqlParser.selectStatement_return);

        HqlParser.insertStatement_return insertStatement4 = default(HqlParser.insertStatement_return);



        try 
    	{
            // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:142:2: ( ( updateStatement | deleteStatement | selectStatement | insertStatement ) )
            // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:142:4: ( updateStatement | deleteStatement | selectStatement | insertStatement )
            {
            	root_0 = (IASTNode)adaptor.GetNilNode();

            	// /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:142:4: ( updateStatement | deleteStatement | selectStatement | insertStatement )
            	int alt1 = 4;
            	switch ( input.LA(1) ) 
            	{
            	case UPDATE:
            		{
            	    alt1 = 1;
            	    }
            	    break;
            	case DELETE:
            		{
            	    alt1 = 2;
            	    }
            	    break;
            	case EOF:
            	case FROM:
            	case GROUP:
            	case ORDER:
            	case SELECT:
            	case UNION:
            	case WHERE:
            	case CLOSE:
            		{
            	    alt1 = 3;
            	    }
            	    break;
            	case INSERT:
            		{
            	    alt1 = 4;
            	    }
            	    break;
            		default:
            		    NoViableAltException nvae_d1s0 =
            		        new NoViableAltException("", 1, 0, input);

            		    throw nvae_d1s0;
            	}

            	switch (alt1) 
            	{
            	    case 1 :
            	        // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:142:6: updateStatement
            	        {
            	        	PushFollow(FOLLOW_updateStatement_in_statement597);
            	        	updateStatement1 = updateStatement();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, updateStatement1.Tree);

            	        }
            	        break;
            	    case 2 :
            	        // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:142:24: deleteStatement
            	        {
            	        	PushFollow(FOLLOW_deleteStatement_in_statement601);
            	        	deleteStatement2 = deleteStatement();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, deleteStatement2.Tree);

            	        }
            	        break;
            	    case 3 :
            	        // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:142:42: selectStatement
            	        {
            	        	PushFollow(FOLLOW_selectStatement_in_statement605);
            	        	selectStatement3 = selectStatement();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, selectStatement3.Tree);

            	        }
            	        break;
            	    case 4 :
            	        // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:142:60: insertStatement
            	        {
            	        	PushFollow(FOLLOW_insertStatement_in_statement609);
            	        	insertStatement4 = insertStatement();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, insertStatement4.Tree);

            	        }
            	        break;

            	}


            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (IASTNode)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (IASTNode)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "statement"

    public class updateStatement_return : ParserRuleReturnScope
    {
        private IASTNode tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (IASTNode) value; }
        }
    };

    // $ANTLR start "updateStatement"
    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:145:1: updateStatement : UPDATE ( VERSIONED )? optionalFromTokenFromClause setClause ( whereClause )? ;
    public HqlParser.updateStatement_return updateStatement() // throws RecognitionException [1]
    {   
        HqlParser.updateStatement_return retval = new HqlParser.updateStatement_return();
        retval.Start = input.LT(1);

        IASTNode root_0 = null;

        IToken UPDATE5 = null;
        IToken VERSIONED6 = null;
        HqlParser.optionalFromTokenFromClause_return optionalFromTokenFromClause7 = default(HqlParser.optionalFromTokenFromClause_return);

        HqlParser.setClause_return setClause8 = default(HqlParser.setClause_return);

        HqlParser.whereClause_return whereClause9 = default(HqlParser.whereClause_return);


        IASTNode UPDATE5_tree=null;
        IASTNode VERSIONED6_tree=null;

        try 
    	{
            // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:146:2: ( UPDATE ( VERSIONED )? optionalFromTokenFromClause setClause ( whereClause )? )
            // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:146:4: UPDATE ( VERSIONED )? optionalFromTokenFromClause setClause ( whereClause )?
            {
            	root_0 = (IASTNode)adaptor.GetNilNode();

            	UPDATE5=(IToken)Match(input,UPDATE,FOLLOW_UPDATE_in_updateStatement622); 
            		UPDATE5_tree = (IASTNode)adaptor.Create(UPDATE5);
            		root_0 = (IASTNode)adaptor.BecomeRoot(UPDATE5_tree, root_0);

            	// /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:146:12: ( VERSIONED )?
            	int alt2 = 2;
            	int LA2_0 = input.LA(1);

            	if ( (LA2_0 == VERSIONED) )
            	{
            	    alt2 = 1;
            	}
            	switch (alt2) 
            	{
            	    case 1 :
            	        // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:146:13: VERSIONED
            	        {
            	        	VERSIONED6=(IToken)Match(input,VERSIONED,FOLLOW_VERSIONED_in_updateStatement626); 
            	        		VERSIONED6_tree = (IASTNode)adaptor.Create(VERSIONED6);
            	        		adaptor.AddChild(root_0, VERSIONED6_tree);


            	        }
            	        break;

            	}

            	PushFollow(FOLLOW_optionalFromTokenFromClause_in_updateStatement632);
            	optionalFromTokenFromClause7 = optionalFromTokenFromClause();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, optionalFromTokenFromClause7.Tree);
            	PushFollow(FOLLOW_setClause_in_updateStatement636);
            	setClause8 = setClause();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, setClause8.Tree);
            	// /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:149:3: ( whereClause )?
            	int alt3 = 2;
            	int LA3_0 = input.LA(1);

            	if ( (LA3_0 == WHERE) )
            	{
            	    alt3 = 1;
            	}
            	switch (alt3) 
            	{
            	    case 1 :
            	        // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:149:4: whereClause
            	        {
            	        	PushFollow(FOLLOW_whereClause_in_updateStatement641);
            	        	whereClause9 = whereClause();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, whereClause9.Tree);

            	        }
            	        break;

            	}


            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (IASTNode)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (IASTNode)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "updateStatement"

    public class setClause_return : ParserRuleReturnScope
    {
        private IASTNode tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (IASTNode) value; }
        }
    };

    // $ANTLR start "setClause"
    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:152:1: setClause : ( SET assignment ( COMMA assignment )* ) ;
    public HqlParser.setClause_return setClause() // throws RecognitionException [1]
    {   
        HqlParser.setClause_return retval = new HqlParser.setClause_return();
        retval.Start = input.LT(1);

        IASTNode root_0 = null;

        IToken SET10 = null;
        IToken COMMA12 = null;
        HqlParser.assignment_return assignment11 = default(HqlParser.assignment_return);

        HqlParser.assignment_return assignment13 = default(HqlParser.assignment_return);


        IASTNode SET10_tree=null;
        IASTNode COMMA12_tree=null;

        try 
    	{
            // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:153:2: ( ( SET assignment ( COMMA assignment )* ) )
            // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:153:4: ( SET assignment ( COMMA assignment )* )
            {
            	root_0 = (IASTNode)adaptor.GetNilNode();

            	// /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:153:4: ( SET assignment ( COMMA assignment )* )
            	// /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:153:5: SET assignment ( COMMA assignment )*
            	{
            		SET10=(IToken)Match(input,SET,FOLLOW_SET_in_setClause655); 
            			SET10_tree = (IASTNode)adaptor.Create(SET10);
            			root_0 = (IASTNode)adaptor.BecomeRoot(SET10_tree, root_0);

            		PushFollow(FOLLOW_assignment_in_setClause658);
            		assignment11 = assignment();
            		state.followingStackPointer--;

            		adaptor.AddChild(root_0, assignment11.Tree);
            		// /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:153:21: ( COMMA assignment )*
            		do 
            		{
            		    int alt4 = 2;
            		    int LA4_0 = input.LA(1);

            		    if ( (LA4_0 == COMMA) )
            		    {
            		        alt4 = 1;
            		    }


            		    switch (alt4) 
            			{
            				case 1 :
            				    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:153:22: COMMA assignment
            				    {
            				    	COMMA12=(IToken)Match(input,COMMA,FOLLOW_COMMA_in_setClause661); 
            				    	PushFollow(FOLLOW_assignment_in_setClause664);
            				    	assignment13 = assignment();
            				    	state.followingStackPointer--;

            				    	adaptor.AddChild(root_0, assignment13.Tree);

            				    }
            				    break;

            				default:
            				    goto loop4;
            		    }
            		} while (true);

            		loop4:
            			;	// Stops C# compiler whining that label 'loop4' has no statements


            	}


            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (IASTNode)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (IASTNode)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "setClause"

    public class assignment_return : ParserRuleReturnScope
    {
        private IASTNode tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (IASTNode) value; }
        }
    };

    // $ANTLR start "assignment"
    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:156:1: assignment : stateField EQ newValue ;
    public HqlParser.assignment_return assignment() // throws RecognitionException [1]
    {   
        HqlParser.assignment_return retval = new HqlParser.assignment_return();
        retval.Start = input.LT(1);

        IASTNode root_0 = null;

        IToken EQ15 = null;
        HqlParser.stateField_return stateField14 = default(HqlParser.stateField_return);

        HqlParser.newValue_return newValue16 = default(HqlParser.newValue_return);


        IASTNode EQ15_tree=null;

        try 
    	{
            // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:157:2: ( stateField EQ newValue )
            // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:157:4: stateField EQ newValue
            {
            	root_0 = (IASTNode)adaptor.GetNilNode();

            	PushFollow(FOLLOW_stateField_in_assignment678);
            	stateField14 = stateField();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, stateField14.Tree);
            	EQ15=(IToken)Match(input,EQ,FOLLOW_EQ_in_assignment680); 
            		EQ15_tree = (IASTNode)adaptor.Create(EQ15);
            		root_0 = (IASTNode)adaptor.BecomeRoot(EQ15_tree, root_0);

            	PushFollow(FOLLOW_newValue_in_assignment683);
            	newValue16 = newValue();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, newValue16.Tree);

            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (IASTNode)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (IASTNode)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "assignment"

    public class stateField_return : ParserRuleReturnScope
    {
        private IASTNode tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (IASTNode) value; }
        }
    };

    // $ANTLR start "stateField"
    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:162:1: stateField : path ;
    public HqlParser.stateField_return stateField() // throws RecognitionException [1]
    {   
        HqlParser.stateField_return retval = new HqlParser.stateField_return();
        retval.Start = input.LT(1);

        IASTNode root_0 = null;

        HqlParser.path_return path17 = default(HqlParser.path_return);



        try 
    	{
            // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:163:2: ( path )
            // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:163:4: path
            {
            	root_0 = (IASTNode)adaptor.GetNilNode();

            	PushFollow(FOLLOW_path_in_stateField696);
            	path17 = path();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, path17.Tree);

            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (IASTNode)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (IASTNode)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "stateField"

    public class newValue_return : ParserRuleReturnScope
    {
        private IASTNode tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (IASTNode) value; }
        }
    };

    // $ANTLR start "newValue"
    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:168:1: newValue : concatenation ;
    public HqlParser.newValue_return newValue() // throws RecognitionException [1]
    {   
        HqlParser.newValue_return retval = new HqlParser.newValue_return();
        retval.Start = input.LT(1);

        IASTNode root_0 = null;

        HqlParser.concatenation_return concatenation18 = default(HqlParser.concatenation_return);



        try 
    	{
            // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:169:2: ( concatenation )
            // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:169:4: concatenation
            {
            	root_0 = (IASTNode)adaptor.GetNilNode();

            	PushFollow(FOLLOW_concatenation_in_newValue709);
            	concatenation18 = concatenation();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, concatenation18.Tree);

            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (IASTNode)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (IASTNode)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "newValue"

    public class deleteStatement_return : ParserRuleReturnScope
    {
        private IASTNode tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (IASTNode) value; }
        }
    };

    // $ANTLR start "deleteStatement"
    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:172:1: deleteStatement : DELETE ( optionalFromTokenFromClause ) ( whereClause )? ;
    public HqlParser.deleteStatement_return deleteStatement() // throws RecognitionException [1]
    {   
        HqlParser.deleteStatement_return retval = new HqlParser.deleteStatement_return();
        retval.Start = input.LT(1);

        IASTNode root_0 = null;

        IToken DELETE19 = null;
        HqlParser.optionalFromTokenFromClause_return optionalFromTokenFromClause20 = default(HqlParser.optionalFromTokenFromClause_return);

        HqlParser.whereClause_return whereClause21 = default(HqlParser.whereClause_return);


        IASTNode DELETE19_tree=null;

        try 
    	{
            // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:173:2: ( DELETE ( optionalFromTokenFromClause ) ( whereClause )? )
            // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:173:4: DELETE ( optionalFromTokenFromClause ) ( whereClause )?
            {
            	root_0 = (IASTNode)adaptor.GetNilNode();

            	DELETE19=(IToken)Match(input,DELETE,FOLLOW_DELETE_in_deleteStatement720); 
            		DELETE19_tree = (IASTNode)adaptor.Create(DELETE19);
            		root_0 = (IASTNode)adaptor.BecomeRoot(DELETE19_tree, root_0);

            	// /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:174:3: ( optionalFromTokenFromClause )
            	// /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:174:4: optionalFromTokenFromClause
            	{
            		PushFollow(FOLLOW_optionalFromTokenFromClause_in_deleteStatement726);
            		optionalFromTokenFromClause20 = optionalFromTokenFromClause();
            		state.followingStackPointer--;

            		adaptor.AddChild(root_0, optionalFromTokenFromClause20.Tree);

            	}

            	// /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:175:3: ( whereClause )?
            	int alt5 = 2;
            	int LA5_0 = input.LA(1);

            	if ( (LA5_0 == WHERE) )
            	{
            	    alt5 = 1;
            	}
            	switch (alt5) 
            	{
            	    case 1 :
            	        // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:175:4: whereClause
            	        {
            	        	PushFollow(FOLLOW_whereClause_in_deleteStatement732);
            	        	whereClause21 = whereClause();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, whereClause21.Tree);

            	        }
            	        break;

            	}


            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (IASTNode)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (IASTNode)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "deleteStatement"

    public class optionalFromTokenFromClause_return : ParserRuleReturnScope
    {
        private IASTNode tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (IASTNode) value; }
        }
    };

    // $ANTLR start "optionalFromTokenFromClause"
    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:180:1: optionalFromTokenFromClause : optionalFromTokenFromClause2 path ( asAlias )? -> ^( FROM ^( RANGE path ( asAlias )? ) ) ;
    public HqlParser.optionalFromTokenFromClause_return optionalFromTokenFromClause() // throws RecognitionException [1]
    {   
        HqlParser.optionalFromTokenFromClause_return retval = new HqlParser.optionalFromTokenFromClause_return();
        retval.Start = input.LT(1);

        IASTNode root_0 = null;

        HqlParser.optionalFromTokenFromClause2_return optionalFromTokenFromClause222 = default(HqlParser.optionalFromTokenFromClause2_return);

        HqlParser.path_return path23 = default(HqlParser.path_return);

        HqlParser.asAlias_return asAlias24 = default(HqlParser.asAlias_return);


        RewriteRuleSubtreeStream stream_path = new RewriteRuleSubtreeStream(adaptor,"rule path");
        RewriteRuleSubtreeStream stream_asAlias = new RewriteRuleSubtreeStream(adaptor,"rule asAlias");
        RewriteRuleSubtreeStream stream_optionalFromTokenFromClause2 = new RewriteRuleSubtreeStream(adaptor,"rule optionalFromTokenFromClause2");
        try 
    	{
            // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:181:2: ( optionalFromTokenFromClause2 path ( asAlias )? -> ^( FROM ^( RANGE path ( asAlias )? ) ) )
            // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:181:4: optionalFromTokenFromClause2 path ( asAlias )?
            {
            	PushFollow(FOLLOW_optionalFromTokenFromClause2_in_optionalFromTokenFromClause747);
            	optionalFromTokenFromClause222 = optionalFromTokenFromClause2();
            	state.followingStackPointer--;

            	stream_optionalFromTokenFromClause2.Add(optionalFromTokenFromClause222.Tree);
            	PushFollow(FOLLOW_path_in_optionalFromTokenFromClause749);
            	path23 = path();
            	state.followingStackPointer--;

            	stream_path.Add(path23.Tree);
            	// /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:181:38: ( asAlias )?
            	int alt6 = 2;
            	int LA6_0 = input.LA(1);

            	if ( (LA6_0 == AS || LA6_0 == IDENT) )
            	{
            	    alt6 = 1;
            	}
            	switch (alt6) 
            	{
            	    case 1 :
            	        // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:181:39: asAlias
            	        {
            	        	PushFollow(FOLLOW_asAlias_in_optionalFromTokenFromClause752);
            	        	asAlias24 = asAlias();
            	        	state.followingStackPointer--;

            	        	stream_asAlias.Add(asAlias24.Tree);

            	        }
            	        break;

            	}



            	// AST REWRITE
            	// elements:          path, asAlias
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (IASTNode)adaptor.GetNilNode();
            	// 182:3: -> ^( FROM ^( RANGE path ( asAlias )? ) )
            	{
            	    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:182:6: ^( FROM ^( RANGE path ( asAlias )? ) )
            	    {
            	    IASTNode root_1 = (IASTNode)adaptor.GetNilNode();
            	    root_1 = (IASTNode)adaptor.BecomeRoot((IASTNode)adaptor.Create(FROM, "FROM"), root_1);

            	    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:182:13: ^( RANGE path ( asAlias )? )
            	    {
            	    IASTNode root_2 = (IASTNode)adaptor.GetNilNode();
            	    root_2 = (IASTNode)adaptor.BecomeRoot((IASTNode)adaptor.Create(RANGE, "RANGE"), root_2);

            	    adaptor.AddChild(root_2, stream_path.NextTree());
            	    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:182:26: ( asAlias )?
            	    if ( stream_asAlias.HasNext() )
            	    {
            	        adaptor.AddChild(root_2, stream_asAlias.NextTree());

            	    }
            	    stream_asAlias.Reset();

            	    adaptor.AddChild(root_1, root_2);
            	    }

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;
            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (IASTNode)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (IASTNode)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "optionalFromTokenFromClause"

    public class optionalFromTokenFromClause2_return : ParserRuleReturnScope
    {
        private IASTNode tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (IASTNode) value; }
        }
    };

    // $ANTLR start "optionalFromTokenFromClause2"
    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:185:1: optionalFromTokenFromClause2 : ( FROM )? ;
    public HqlParser.optionalFromTokenFromClause2_return optionalFromTokenFromClause2() // throws RecognitionException [1]
    {   
        HqlParser.optionalFromTokenFromClause2_return retval = new HqlParser.optionalFromTokenFromClause2_return();
        retval.Start = input.LT(1);

        IASTNode root_0 = null;

        IToken FROM25 = null;

        IASTNode FROM25_tree=null;

        try 
    	{
            // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:186:2: ( ( FROM )? )
            // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:186:4: ( FROM )?
            {
            	root_0 = (IASTNode)adaptor.GetNilNode();

            	// /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:186:4: ( FROM )?
            	int alt7 = 2;
            	int LA7_0 = input.LA(1);

            	if ( (LA7_0 == FROM) )
            	{
            	    alt7 = 1;
            	}
            	switch (alt7) 
            	{
            	    case 1 :
            	        // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:186:4: FROM
            	        {
            	        	FROM25=(IToken)Match(input,FROM,FOLLOW_FROM_in_optionalFromTokenFromClause2783); 
            	        		FROM25_tree = (IASTNode)adaptor.Create(FROM25);
            	        		adaptor.AddChild(root_0, FROM25_tree);


            	        }
            	        break;

            	}


            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (IASTNode)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (IASTNode)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "optionalFromTokenFromClause2"

    public class selectStatement_return : ParserRuleReturnScope
    {
        private IASTNode tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (IASTNode) value; }
        }
    };

    // $ANTLR start "selectStatement"
    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:196:1: selectStatement : q= queryRule -> ^( QUERY[\"query\"] $q) ;
    public HqlParser.selectStatement_return selectStatement() // throws RecognitionException [1]
    {   
        HqlParser.selectStatement_return retval = new HqlParser.selectStatement_return();
        retval.Start = input.LT(1);

        IASTNode root_0 = null;

        HqlParser.queryRule_return q = default(HqlParser.queryRule_return);


        RewriteRuleSubtreeStream stream_queryRule = new RewriteRuleSubtreeStream(adaptor,"rule queryRule");
        try 
    	{
            // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:197:2: (q= queryRule -> ^( QUERY[\"query\"] $q) )
            // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:197:4: q= queryRule
            {
            	PushFollow(FOLLOW_queryRule_in_selectStatement798);
            	q = queryRule();
            	state.followingStackPointer--;

            	stream_queryRule.Add(q.Tree);


            	// AST REWRITE
            	// elements:          q
            	// token labels:      
            	// rule labels:       retval, q
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);
            	RewriteRuleSubtreeStream stream_q = new RewriteRuleSubtreeStream(adaptor, "rule q", q!=null ? q.Tree : null);

            	root_0 = (IASTNode)adaptor.GetNilNode();
            	// 198:2: -> ^( QUERY[\"query\"] $q)
            	{
            	    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:198:5: ^( QUERY[\"query\"] $q)
            	    {
            	    IASTNode root_1 = (IASTNode)adaptor.GetNilNode();
            	    root_1 = (IASTNode)adaptor.BecomeRoot((IASTNode)adaptor.Create(QUERY, "query"), root_1);

            	    adaptor.AddChild(root_1, stream_q.NextTree());

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;
            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (IASTNode)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (IASTNode)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "selectStatement"

    public class insertStatement_return : ParserRuleReturnScope
    {
        private IASTNode tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (IASTNode) value; }
        }
    };

    // $ANTLR start "insertStatement"
    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:201:1: insertStatement : INSERT intoClause selectStatement ;
    public HqlParser.insertStatement_return insertStatement() // throws RecognitionException [1]
    {   
        HqlParser.insertStatement_return retval = new HqlParser.insertStatement_return();
        retval.Start = input.LT(1);

        IASTNode root_0 = null;

        IToken INSERT26 = null;
        HqlParser.intoClause_return intoClause27 = default(HqlParser.intoClause_return);

        HqlParser.selectStatement_return selectStatement28 = default(HqlParser.selectStatement_return);


        IASTNode INSERT26_tree=null;

        try 
    	{
            // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:205:2: ( INSERT intoClause selectStatement )
            // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:205:4: INSERT intoClause selectStatement
            {
            	root_0 = (IASTNode)adaptor.GetNilNode();

            	INSERT26=(IToken)Match(input,INSERT,FOLLOW_INSERT_in_insertStatement827); 
            		INSERT26_tree = (IASTNode)adaptor.Create(INSERT26);
            		root_0 = (IASTNode)adaptor.BecomeRoot(INSERT26_tree, root_0);

            	PushFollow(FOLLOW_intoClause_in_insertStatement830);
            	intoClause27 = intoClause();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, intoClause27.Tree);
            	PushFollow(FOLLOW_selectStatement_in_insertStatement832);
            	selectStatement28 = selectStatement();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, selectStatement28.Tree);

            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (IASTNode)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (IASTNode)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "insertStatement"

    public class intoClause_return : ParserRuleReturnScope
    {
        private IASTNode tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (IASTNode) value; }
        }
    };

    // $ANTLR start "intoClause"
    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:208:1: intoClause : INTO path insertablePropertySpec ;
    public HqlParser.intoClause_return intoClause() // throws RecognitionException [1]
    {   
        HqlParser.intoClause_return retval = new HqlParser.intoClause_return();
        retval.Start = input.LT(1);

        IASTNode root_0 = null;

        IToken INTO29 = null;
        HqlParser.path_return path30 = default(HqlParser.path_return);

        HqlParser.insertablePropertySpec_return insertablePropertySpec31 = default(HqlParser.insertablePropertySpec_return);


        IASTNode INTO29_tree=null;

        try 
    	{
            // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:209:2: ( INTO path insertablePropertySpec )
            // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:209:4: INTO path insertablePropertySpec
            {
            	root_0 = (IASTNode)adaptor.GetNilNode();

            	INTO29=(IToken)Match(input,INTO,FOLLOW_INTO_in_intoClause843); 
            		INTO29_tree = (IASTNode)adaptor.Create(INTO29);
            		root_0 = (IASTNode)adaptor.BecomeRoot(INTO29_tree, root_0);

            	PushFollow(FOLLOW_path_in_intoClause846);
            	path30 = path();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, path30.Tree);
            	 WeakKeywords(); 
            	PushFollow(FOLLOW_insertablePropertySpec_in_intoClause850);
            	insertablePropertySpec31 = insertablePropertySpec();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, insertablePropertySpec31.Tree);

            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (IASTNode)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (IASTNode)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "intoClause"

    public class insertablePropertySpec_return : ParserRuleReturnScope
    {
        private IASTNode tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (IASTNode) value; }
        }
    };

    // $ANTLR start "insertablePropertySpec"
    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:220:1: insertablePropertySpec : OPEN primaryExpression ( COMMA primaryExpression )* CLOSE -> ^( RANGE[\"column-spec\"] ( primaryExpression )* ) ;
    public HqlParser.insertablePropertySpec_return insertablePropertySpec() // throws RecognitionException [1]
    {   
        HqlParser.insertablePropertySpec_return retval = new HqlParser.insertablePropertySpec_return();
        retval.Start = input.LT(1);

        IASTNode root_0 = null;

        IToken OPEN32 = null;
        IToken COMMA34 = null;
        IToken CLOSE36 = null;
        HqlParser.primaryExpression_return primaryExpression33 = default(HqlParser.primaryExpression_return);

        HqlParser.primaryExpression_return primaryExpression35 = default(HqlParser.primaryExpression_return);


        IASTNode OPEN32_tree=null;
        IASTNode COMMA34_tree=null;
        IASTNode CLOSE36_tree=null;
        RewriteRuleTokenStream stream_COMMA = new RewriteRuleTokenStream(adaptor,"token COMMA");
        RewriteRuleTokenStream stream_CLOSE = new RewriteRuleTokenStream(adaptor,"token CLOSE");
        RewriteRuleTokenStream stream_OPEN = new RewriteRuleTokenStream(adaptor,"token OPEN");
        RewriteRuleSubtreeStream stream_primaryExpression = new RewriteRuleSubtreeStream(adaptor,"rule primaryExpression");
        try 
    	{
            // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:221:2: ( OPEN primaryExpression ( COMMA primaryExpression )* CLOSE -> ^( RANGE[\"column-spec\"] ( primaryExpression )* ) )
            // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:221:4: OPEN primaryExpression ( COMMA primaryExpression )* CLOSE
            {
            	OPEN32=(IToken)Match(input,OPEN,FOLLOW_OPEN_in_insertablePropertySpec862);  
            	stream_OPEN.Add(OPEN32);

            	PushFollow(FOLLOW_primaryExpression_in_insertablePropertySpec864);
            	primaryExpression33 = primaryExpression();
            	state.followingStackPointer--;

            	stream_primaryExpression.Add(primaryExpression33.Tree);
            	// /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:221:27: ( COMMA primaryExpression )*
            	do 
            	{
            	    int alt8 = 2;
            	    int LA8_0 = input.LA(1);

            	    if ( (LA8_0 == COMMA) )
            	    {
            	        alt8 = 1;
            	    }


            	    switch (alt8) 
            		{
            			case 1 :
            			    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:221:29: COMMA primaryExpression
            			    {
            			    	COMMA34=(IToken)Match(input,COMMA,FOLLOW_COMMA_in_insertablePropertySpec868);  
            			    	stream_COMMA.Add(COMMA34);

            			    	PushFollow(FOLLOW_primaryExpression_in_insertablePropertySpec870);
            			    	primaryExpression35 = primaryExpression();
            			    	state.followingStackPointer--;

            			    	stream_primaryExpression.Add(primaryExpression35.Tree);

            			    }
            			    break;

            			default:
            			    goto loop8;
            	    }
            	} while (true);

            	loop8:
            		;	// Stops C# compiler whining that label 'loop8' has no statements

            	CLOSE36=(IToken)Match(input,CLOSE,FOLLOW_CLOSE_in_insertablePropertySpec875);  
            	stream_CLOSE.Add(CLOSE36);



            	// AST REWRITE
            	// elements:          primaryExpression
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (IASTNode)adaptor.GetNilNode();
            	// 222:3: -> ^( RANGE[\"column-spec\"] ( primaryExpression )* )
            	{
            	    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:222:6: ^( RANGE[\"column-spec\"] ( primaryExpression )* )
            	    {
            	    IASTNode root_1 = (IASTNode)adaptor.GetNilNode();
            	    root_1 = (IASTNode)adaptor.BecomeRoot((IASTNode)adaptor.Create(RANGE, "column-spec"), root_1);

            	    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:222:29: ( primaryExpression )*
            	    while ( stream_primaryExpression.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_primaryExpression.NextTree());

            	    }
            	    stream_primaryExpression.Reset();

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;
            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (IASTNode)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (IASTNode)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "insertablePropertySpec"

    public class union_return : ParserRuleReturnScope
    {
        private IASTNode tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (IASTNode) value; }
        }
    };

    // $ANTLR start "union"
    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:225:1: union : queryRule ( UNION queryRule )* ;
    public HqlParser.union_return union() // throws RecognitionException [1]
    {   
        HqlParser.union_return retval = new HqlParser.union_return();
        retval.Start = input.LT(1);

        IASTNode root_0 = null;

        IToken UNION38 = null;
        HqlParser.queryRule_return queryRule37 = default(HqlParser.queryRule_return);

        HqlParser.queryRule_return queryRule39 = default(HqlParser.queryRule_return);


        IASTNode UNION38_tree=null;

        try 
    	{
            // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:226:2: ( queryRule ( UNION queryRule )* )
            // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:226:4: queryRule ( UNION queryRule )*
            {
            	root_0 = (IASTNode)adaptor.GetNilNode();

            	PushFollow(FOLLOW_queryRule_in_union898);
            	queryRule37 = queryRule();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, queryRule37.Tree);
            	// /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:226:14: ( UNION queryRule )*
            	do 
            	{
            	    int alt9 = 2;
            	    int LA9_0 = input.LA(1);

            	    if ( (LA9_0 == UNION) )
            	    {
            	        alt9 = 1;
            	    }


            	    switch (alt9) 
            		{
            			case 1 :
            			    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:226:15: UNION queryRule
            			    {
            			    	UNION38=(IToken)Match(input,UNION,FOLLOW_UNION_in_union901); 
            			    		UNION38_tree = (IASTNode)adaptor.Create(UNION38);
            			    		adaptor.AddChild(root_0, UNION38_tree);

            			    	PushFollow(FOLLOW_queryRule_in_union903);
            			    	queryRule39 = queryRule();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, queryRule39.Tree);

            			    }
            			    break;

            			default:
            			    goto loop9;
            	    }
            	} while (true);

            	loop9:
            		;	// Stops C# compiler whining that label 'loop9' has no statements


            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (IASTNode)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (IASTNode)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "union"

    public class queryRule_return : ParserRuleReturnScope
    {
        private IASTNode tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (IASTNode) value; }
        }
    };

    // $ANTLR start "queryRule"
    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:232:1: queryRule : selectFrom ( whereClause )? ( groupByClause )? ( orderByClause )? ;
    public HqlParser.queryRule_return queryRule() // throws RecognitionException [1]
    {   
        HqlParser.queryRule_return retval = new HqlParser.queryRule_return();
        retval.Start = input.LT(1);

        IASTNode root_0 = null;

        HqlParser.selectFrom_return selectFrom40 = default(HqlParser.selectFrom_return);

        HqlParser.whereClause_return whereClause41 = default(HqlParser.whereClause_return);

        HqlParser.groupByClause_return groupByClause42 = default(HqlParser.groupByClause_return);

        HqlParser.orderByClause_return orderByClause43 = default(HqlParser.orderByClause_return);



        try 
    	{
            // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:233:2: ( selectFrom ( whereClause )? ( groupByClause )? ( orderByClause )? )
            // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:233:4: selectFrom ( whereClause )? ( groupByClause )? ( orderByClause )?
            {
            	root_0 = (IASTNode)adaptor.GetNilNode();

            	PushFollow(FOLLOW_selectFrom_in_queryRule919);
            	selectFrom40 = selectFrom();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, selectFrom40.Tree);
            	// /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:234:3: ( whereClause )?
            	int alt10 = 2;
            	int LA10_0 = input.LA(1);

            	if ( (LA10_0 == WHERE) )
            	{
            	    alt10 = 1;
            	}
            	switch (alt10) 
            	{
            	    case 1 :
            	        // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:234:4: whereClause
            	        {
            	        	PushFollow(FOLLOW_whereClause_in_queryRule924);
            	        	whereClause41 = whereClause();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, whereClause41.Tree);

            	        }
            	        break;

            	}

            	// /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:235:3: ( groupByClause )?
            	int alt11 = 2;
            	int LA11_0 = input.LA(1);

            	if ( (LA11_0 == GROUP) )
            	{
            	    alt11 = 1;
            	}
            	switch (alt11) 
            	{
            	    case 1 :
            	        // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:235:4: groupByClause
            	        {
            	        	PushFollow(FOLLOW_groupByClause_in_queryRule931);
            	        	groupByClause42 = groupByClause();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, groupByClause42.Tree);

            	        }
            	        break;

            	}

            	// /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:236:3: ( orderByClause )?
            	int alt12 = 2;
            	int LA12_0 = input.LA(1);

            	if ( (LA12_0 == ORDER) )
            	{
            	    alt12 = 1;
            	}
            	switch (alt12) 
            	{
            	    case 1 :
            	        // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:236:4: orderByClause
            	        {
            	        	PushFollow(FOLLOW_orderByClause_in_queryRule938);
            	        	orderByClause43 = orderByClause();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, orderByClause43.Tree);

            	        }
            	        break;

            	}


            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (IASTNode)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (IASTNode)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "queryRule"

    public class selectFrom_return : ParserRuleReturnScope
    {
        private IASTNode tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (IASTNode) value; }
        }
    };

    // $ANTLR start "selectFrom"
    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:261:1: selectFrom : (s= selectClause )? (f= fromClause )? -> {$f.tree == null && filter}? ^( SELECT_FROM FROM[\"{filter-implied FROM}\"] ) -> ^( SELECT_FROM ( fromClause )? ( selectClause )? ) ;
    public HqlParser.selectFrom_return selectFrom() // throws RecognitionException [1]
    {   
        HqlParser.selectFrom_return retval = new HqlParser.selectFrom_return();
        retval.Start = input.LT(1);

        IASTNode root_0 = null;

        HqlParser.selectClause_return s = default(HqlParser.selectClause_return);

        HqlParser.fromClause_return f = default(HqlParser.fromClause_return);


        RewriteRuleSubtreeStream stream_selectClause = new RewriteRuleSubtreeStream(adaptor,"rule selectClause");
        RewriteRuleSubtreeStream stream_fromClause = new RewriteRuleSubtreeStream(adaptor,"rule fromClause");
        try 
    	{
            // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:262:2: ( (s= selectClause )? (f= fromClause )? -> {$f.tree == null && filter}? ^( SELECT_FROM FROM[\"{filter-implied FROM}\"] ) -> ^( SELECT_FROM ( fromClause )? ( selectClause )? ) )
            // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:262:5: (s= selectClause )? (f= fromClause )?
            {
            	// /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:262:5: (s= selectClause )?
            	int alt13 = 2;
            	int LA13_0 = input.LA(1);

            	if ( (LA13_0 == SELECT) )
            	{
            	    alt13 = 1;
            	}
            	switch (alt13) 
            	{
            	    case 1 :
            	        // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:262:6: s= selectClause
            	        {
            	        	PushFollow(FOLLOW_selectClause_in_selectFrom959);
            	        	s = selectClause();
            	        	state.followingStackPointer--;

            	        	stream_selectClause.Add(s.Tree);

            	        }
            	        break;

            	}

            	// /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:262:23: (f= fromClause )?
            	int alt14 = 2;
            	int LA14_0 = input.LA(1);

            	if ( (LA14_0 == FROM) )
            	{
            	    alt14 = 1;
            	}
            	switch (alt14) 
            	{
            	    case 1 :
            	        // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:262:24: f= fromClause
            	        {
            	        	PushFollow(FOLLOW_fromClause_in_selectFrom966);
            	        	f = fromClause();
            	        	state.followingStackPointer--;

            	        	stream_fromClause.Add(f.Tree);

            	        }
            	        break;

            	}


            				if (((f != null) ? ((IASTNode)f.Tree) : null) == null && !filter) 
            					throw new RecognitionException("FROM expected (non-filter queries must contain a FROM clause)");
            			


            	// AST REWRITE
            	// elements:          fromClause, selectClause
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (IASTNode)adaptor.GetNilNode();
            	// 267:3: -> {$f.tree == null && filter}? ^( SELECT_FROM FROM[\"{filter-implied FROM}\"] )
            	if (((f != null) ? ((IASTNode)f.Tree) : null) == null && filter)
            	{
            	    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:267:35: ^( SELECT_FROM FROM[\"{filter-implied FROM}\"] )
            	    {
            	    IASTNode root_1 = (IASTNode)adaptor.GetNilNode();
            	    root_1 = (IASTNode)adaptor.BecomeRoot((IASTNode)adaptor.Create(SELECT_FROM, "SELECT_FROM"), root_1);

            	    adaptor.AddChild(root_1, (IASTNode)adaptor.Create(FROM, "{filter-implied FROM}"));

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}
            	else // 268:3: -> ^( SELECT_FROM ( fromClause )? ( selectClause )? )
            	{
            	    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:268:6: ^( SELECT_FROM ( fromClause )? ( selectClause )? )
            	    {
            	    IASTNode root_1 = (IASTNode)adaptor.GetNilNode();
            	    root_1 = (IASTNode)adaptor.BecomeRoot((IASTNode)adaptor.Create(SELECT_FROM, "SELECT_FROM"), root_1);

            	    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:268:20: ( fromClause )?
            	    if ( stream_fromClause.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_fromClause.NextTree());

            	    }
            	    stream_fromClause.Reset();
            	    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:268:32: ( selectClause )?
            	    if ( stream_selectClause.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_selectClause.NextTree());

            	    }
            	    stream_selectClause.Reset();

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;
            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (IASTNode)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (IASTNode)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "selectFrom"

    public class selectClause_return : ParserRuleReturnScope
    {
        private IASTNode tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (IASTNode) value; }
        }
    };

    // $ANTLR start "selectClause"
    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:276:1: selectClause : SELECT ( DISTINCT )? ( selectedPropertiesList | newExpression | selectObject ) ;
    public HqlParser.selectClause_return selectClause() // throws RecognitionException [1]
    {   
        HqlParser.selectClause_return retval = new HqlParser.selectClause_return();
        retval.Start = input.LT(1);

        IASTNode root_0 = null;

        IToken SELECT44 = null;
        IToken DISTINCT45 = null;
        HqlParser.selectedPropertiesList_return selectedPropertiesList46 = default(HqlParser.selectedPropertiesList_return);

        HqlParser.newExpression_return newExpression47 = default(HqlParser.newExpression_return);

        HqlParser.selectObject_return selectObject48 = default(HqlParser.selectObject_return);


        IASTNode SELECT44_tree=null;
        IASTNode DISTINCT45_tree=null;

        try 
    	{
            // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:277:2: ( SELECT ( DISTINCT )? ( selectedPropertiesList | newExpression | selectObject ) )
            // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:277:4: SELECT ( DISTINCT )? ( selectedPropertiesList | newExpression | selectObject )
            {
            	root_0 = (IASTNode)adaptor.GetNilNode();

            	SELECT44=(IToken)Match(input,SELECT,FOLLOW_SELECT_in_selectClause1016); 
            		SELECT44_tree = (IASTNode)adaptor.Create(SELECT44);
            		root_0 = (IASTNode)adaptor.BecomeRoot(SELECT44_tree, root_0);

            	 WeakKeywords(); 
            	// /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:279:3: ( DISTINCT )?
            	int alt15 = 2;
            	int LA15_0 = input.LA(1);

            	if ( (LA15_0 == DISTINCT) )
            	{
            	    alt15 = 1;
            	}
            	switch (alt15) 
            	{
            	    case 1 :
            	        // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:279:4: DISTINCT
            	        {
            	        	DISTINCT45=(IToken)Match(input,DISTINCT,FOLLOW_DISTINCT_in_selectClause1028); 
            	        		DISTINCT45_tree = (IASTNode)adaptor.Create(DISTINCT45);
            	        		adaptor.AddChild(root_0, DISTINCT45_tree);


            	        }
            	        break;

            	}

            	// /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:279:15: ( selectedPropertiesList | newExpression | selectObject )
            	int alt16 = 3;
            	switch ( input.LA(1) ) 
            	{
            	case ALL:
            	case ANY:
            	case AVG:
            	case COUNT:
            	case ELEMENTS:
            	case EXISTS:
            	case FALSE:
            	case INDICES:
            	case MAX:
            	case MIN:
            	case NOT:
            	case NULL:
            	case SOME:
            	case SUM:
            	case TRUE:
            	case CASE:
            	case EMPTY:
            	case NUM_INT:
            	case NUM_DOUBLE:
            	case NUM_FLOAT:
            	case NUM_LONG:
            	case OPEN:
            	case PLUS:
            	case MINUS:
            	case COLON:
            	case PARAM:
            	case QUOTED_String:
            	case IDENT:
            		{
            	    alt16 = 1;
            	    }
            	    break;
            	case NEW:
            		{
            	    alt16 = 2;
            	    }
            	    break;
            	case OBJECT:
            		{
            	    alt16 = 3;
            	    }
            	    break;
            		default:
            		    NoViableAltException nvae_d16s0 =
            		        new NoViableAltException("", 16, 0, input);

            		    throw nvae_d16s0;
            	}

            	switch (alt16) 
            	{
            	    case 1 :
            	        // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:279:17: selectedPropertiesList
            	        {
            	        	PushFollow(FOLLOW_selectedPropertiesList_in_selectClause1034);
            	        	selectedPropertiesList46 = selectedPropertiesList();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, selectedPropertiesList46.Tree);

            	        }
            	        break;
            	    case 2 :
            	        // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:279:42: newExpression
            	        {
            	        	PushFollow(FOLLOW_newExpression_in_selectClause1038);
            	        	newExpression47 = newExpression();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, newExpression47.Tree);

            	        }
            	        break;
            	    case 3 :
            	        // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:279:58: selectObject
            	        {
            	        	PushFollow(FOLLOW_selectObject_in_selectClause1042);
            	        	selectObject48 = selectObject();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, selectObject48.Tree);

            	        }
            	        break;

            	}


            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (IASTNode)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (IASTNode)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "selectClause"

    public class newExpression_return : ParserRuleReturnScope
    {
        private IASTNode tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (IASTNode) value; }
        }
    };

    // $ANTLR start "newExpression"
    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:288:1: newExpression : ( NEW path ) op= OPEN selectedPropertiesList CLOSE -> ^( CONSTRUCTOR[$op] path selectedPropertiesList ) ;
    public HqlParser.newExpression_return newExpression() // throws RecognitionException [1]
    {   
        HqlParser.newExpression_return retval = new HqlParser.newExpression_return();
        retval.Start = input.LT(1);

        IASTNode root_0 = null;

        IToken op = null;
        IToken NEW49 = null;
        IToken CLOSE52 = null;
        HqlParser.path_return path50 = default(HqlParser.path_return);

        HqlParser.selectedPropertiesList_return selectedPropertiesList51 = default(HqlParser.selectedPropertiesList_return);


        IASTNode op_tree=null;
        IASTNode NEW49_tree=null;
        IASTNode CLOSE52_tree=null;
        RewriteRuleTokenStream stream_CLOSE = new RewriteRuleTokenStream(adaptor,"token CLOSE");
        RewriteRuleTokenStream stream_OPEN = new RewriteRuleTokenStream(adaptor,"token OPEN");
        RewriteRuleTokenStream stream_NEW = new RewriteRuleTokenStream(adaptor,"token NEW");
        RewriteRuleSubtreeStream stream_selectedPropertiesList = new RewriteRuleSubtreeStream(adaptor,"rule selectedPropertiesList");
        RewriteRuleSubtreeStream stream_path = new RewriteRuleSubtreeStream(adaptor,"rule path");
        try 
    	{
            // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:289:2: ( ( NEW path ) op= OPEN selectedPropertiesList CLOSE -> ^( CONSTRUCTOR[$op] path selectedPropertiesList ) )
            // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:289:4: ( NEW path ) op= OPEN selectedPropertiesList CLOSE
            {
            	// /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:289:4: ( NEW path )
            	// /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:289:5: NEW path
            	{
            		NEW49=(IToken)Match(input,NEW,FOLLOW_NEW_in_newExpression1058);  
            		stream_NEW.Add(NEW49);

            		PushFollow(FOLLOW_path_in_newExpression1060);
            		path50 = path();
            		state.followingStackPointer--;

            		stream_path.Add(path50.Tree);

            	}

            	op=(IToken)Match(input,OPEN,FOLLOW_OPEN_in_newExpression1065);  
            	stream_OPEN.Add(op);

            	PushFollow(FOLLOW_selectedPropertiesList_in_newExpression1067);
            	selectedPropertiesList51 = selectedPropertiesList();
            	state.followingStackPointer--;

            	stream_selectedPropertiesList.Add(selectedPropertiesList51.Tree);
            	CLOSE52=(IToken)Match(input,CLOSE,FOLLOW_CLOSE_in_newExpression1069);  
            	stream_CLOSE.Add(CLOSE52);



            	// AST REWRITE
            	// elements:          selectedPropertiesList, path
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (IASTNode)adaptor.GetNilNode();
            	// 290:3: -> ^( CONSTRUCTOR[$op] path selectedPropertiesList )
            	{
            	    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:290:6: ^( CONSTRUCTOR[$op] path selectedPropertiesList )
            	    {
            	    IASTNode root_1 = (IASTNode)adaptor.GetNilNode();
            	    root_1 = (IASTNode)adaptor.BecomeRoot((IASTNode)adaptor.Create(CONSTRUCTOR, op), root_1);

            	    adaptor.AddChild(root_1, stream_path.NextTree());
            	    adaptor.AddChild(root_1, stream_selectedPropertiesList.NextTree());

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;
            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (IASTNode)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (IASTNode)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "newExpression"

    public class selectObject_return : ParserRuleReturnScope
    {
        private IASTNode tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (IASTNode) value; }
        }
    };

    // $ANTLR start "selectObject"
    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:293:1: selectObject : OBJECT OPEN identifier CLOSE ;
    public HqlParser.selectObject_return selectObject() // throws RecognitionException [1]
    {   
        HqlParser.selectObject_return retval = new HqlParser.selectObject_return();
        retval.Start = input.LT(1);

        IASTNode root_0 = null;

        IToken OBJECT53 = null;
        IToken OPEN54 = null;
        IToken CLOSE56 = null;
        HqlParser.identifier_return identifier55 = default(HqlParser.identifier_return);


        IASTNode OBJECT53_tree=null;
        IASTNode OPEN54_tree=null;
        IASTNode CLOSE56_tree=null;

        try 
    	{
            // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:294:4: ( OBJECT OPEN identifier CLOSE )
            // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:294:6: OBJECT OPEN identifier CLOSE
            {
            	root_0 = (IASTNode)adaptor.GetNilNode();

            	OBJECT53=(IToken)Match(input,OBJECT,FOLLOW_OBJECT_in_selectObject1095); 
            		OBJECT53_tree = (IASTNode)adaptor.Create(OBJECT53);
            		root_0 = (IASTNode)adaptor.BecomeRoot(OBJECT53_tree, root_0);

            	OPEN54=(IToken)Match(input,OPEN,FOLLOW_OPEN_in_selectObject1098); 
            	PushFollow(FOLLOW_identifier_in_selectObject1101);
            	identifier55 = identifier();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, identifier55.Tree);
            	CLOSE56=(IToken)Match(input,CLOSE,FOLLOW_CLOSE_in_selectObject1103); 

            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (IASTNode)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (IASTNode)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "selectObject"

    public class fromClause_return : ParserRuleReturnScope
    {
        private IASTNode tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (IASTNode) value; }
        }
    };

    // $ANTLR start "fromClause"
    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:304:1: fromClause : FROM fromRange ( fromJoin | COMMA fromRange )* ;
    public HqlParser.fromClause_return fromClause() // throws RecognitionException [1]
    {   
        HqlParser.fromClause_return retval = new HqlParser.fromClause_return();
        retval.Start = input.LT(1);

        IASTNode root_0 = null;

        IToken FROM57 = null;
        IToken COMMA60 = null;
        HqlParser.fromRange_return fromRange58 = default(HqlParser.fromRange_return);

        HqlParser.fromJoin_return fromJoin59 = default(HqlParser.fromJoin_return);

        HqlParser.fromRange_return fromRange61 = default(HqlParser.fromRange_return);


        IASTNode FROM57_tree=null;
        IASTNode COMMA60_tree=null;

        try 
    	{
            // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:305:2: ( FROM fromRange ( fromJoin | COMMA fromRange )* )
            // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:305:4: FROM fromRange ( fromJoin | COMMA fromRange )*
            {
            	root_0 = (IASTNode)adaptor.GetNilNode();

            	FROM57=(IToken)Match(input,FROM,FOLLOW_FROM_in_fromClause1124); 
            		FROM57_tree = (IASTNode)adaptor.Create(FROM57);
            		root_0 = (IASTNode)adaptor.BecomeRoot(FROM57_tree, root_0);

            	 WeakKeywords(); 
            	PushFollow(FOLLOW_fromRange_in_fromClause1129);
            	fromRange58 = fromRange();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, fromRange58.Tree);
            	// /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:305:40: ( fromJoin | COMMA fromRange )*
            	do 
            	{
            	    int alt17 = 3;
            	    int LA17_0 = input.LA(1);

            	    if ( (LA17_0 == FULL || LA17_0 == INNER || (LA17_0 >= JOIN && LA17_0 <= LEFT) || LA17_0 == RIGHT) )
            	    {
            	        alt17 = 1;
            	    }
            	    else if ( (LA17_0 == COMMA) )
            	    {
            	        alt17 = 2;
            	    }


            	    switch (alt17) 
            		{
            			case 1 :
            			    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:305:42: fromJoin
            			    {
            			    	PushFollow(FOLLOW_fromJoin_in_fromClause1133);
            			    	fromJoin59 = fromJoin();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, fromJoin59.Tree);

            			    }
            			    break;
            			case 2 :
            			    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:305:53: COMMA fromRange
            			    {
            			    	COMMA60=(IToken)Match(input,COMMA,FOLLOW_COMMA_in_fromClause1137); 
            			    	 WeakKeywords(); 
            			    	PushFollow(FOLLOW_fromRange_in_fromClause1142);
            			    	fromRange61 = fromRange();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, fromRange61.Tree);

            			    }
            			    break;

            			default:
            			    goto loop17;
            	    }
            	} while (true);

            	loop17:
            		;	// Stops C# compiler whining that label 'loop17' has no statements


            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (IASTNode)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (IASTNode)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "fromClause"

    public class fromJoin_return : ParserRuleReturnScope
    {
        private IASTNode tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (IASTNode) value; }
        }
    };

    // $ANTLR start "fromJoin"
    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:311:1: fromJoin : ( ( ( LEFT | RIGHT ) ( OUTER )? ) | FULL | INNER )? JOIN ( FETCH )? path ( asAlias )? ( propertyFetch )? ( withClause )? ;
    public HqlParser.fromJoin_return fromJoin() // throws RecognitionException [1]
    {   
        HqlParser.fromJoin_return retval = new HqlParser.fromJoin_return();
        retval.Start = input.LT(1);

        IASTNode root_0 = null;

        IToken set62 = null;
        IToken OUTER63 = null;
        IToken FULL64 = null;
        IToken INNER65 = null;
        IToken JOIN66 = null;
        IToken FETCH67 = null;
        HqlParser.path_return path68 = default(HqlParser.path_return);

        HqlParser.asAlias_return asAlias69 = default(HqlParser.asAlias_return);

        HqlParser.propertyFetch_return propertyFetch70 = default(HqlParser.propertyFetch_return);

        HqlParser.withClause_return withClause71 = default(HqlParser.withClause_return);


        IASTNode set62_tree=null;
        IASTNode OUTER63_tree=null;
        IASTNode FULL64_tree=null;
        IASTNode INNER65_tree=null;
        IASTNode JOIN66_tree=null;
        IASTNode FETCH67_tree=null;

        try 
    	{
            // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:312:2: ( ( ( ( LEFT | RIGHT ) ( OUTER )? ) | FULL | INNER )? JOIN ( FETCH )? path ( asAlias )? ( propertyFetch )? ( withClause )? )
            // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:312:4: ( ( ( LEFT | RIGHT ) ( OUTER )? ) | FULL | INNER )? JOIN ( FETCH )? path ( asAlias )? ( propertyFetch )? ( withClause )?
            {
            	root_0 = (IASTNode)adaptor.GetNilNode();

            	// /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:312:4: ( ( ( LEFT | RIGHT ) ( OUTER )? ) | FULL | INNER )?
            	int alt19 = 4;
            	switch ( input.LA(1) ) 
            	{
            	    case LEFT:
            	    case RIGHT:
            	    	{
            	        alt19 = 1;
            	        }
            	        break;
            	    case FULL:
            	    	{
            	        alt19 = 2;
            	        }
            	        break;
            	    case INNER:
            	    	{
            	        alt19 = 3;
            	        }
            	        break;
            	}

            	switch (alt19) 
            	{
            	    case 1 :
            	        // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:312:6: ( ( LEFT | RIGHT ) ( OUTER )? )
            	        {
            	        	// /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:312:6: ( ( LEFT | RIGHT ) ( OUTER )? )
            	        	// /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:312:8: ( LEFT | RIGHT ) ( OUTER )?
            	        	{
            	        		set62 = (IToken)input.LT(1);
            	        		if ( input.LA(1) == LEFT || input.LA(1) == RIGHT ) 
            	        		{
            	        		    input.Consume();
            	        		    adaptor.AddChild(root_0, (IASTNode)adaptor.Create(set62));
            	        		    state.errorRecovery = false;
            	        		}
            	        		else 
            	        		{
            	        		    MismatchedSetException mse = new MismatchedSetException(null,input);
            	        		    throw mse;
            	        		}

            	        		// /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:312:25: ( OUTER )?
            	        		int alt18 = 2;
            	        		int LA18_0 = input.LA(1);

            	        		if ( (LA18_0 == OUTER) )
            	        		{
            	        		    alt18 = 1;
            	        		}
            	        		switch (alt18) 
            	        		{
            	        		    case 1 :
            	        		        // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:312:26: OUTER
            	        		        {
            	        		        	OUTER63=(IToken)Match(input,OUTER,FOLLOW_OUTER_in_fromJoin1174); 
            	        		        		OUTER63_tree = (IASTNode)adaptor.Create(OUTER63);
            	        		        		adaptor.AddChild(root_0, OUTER63_tree);


            	        		        }
            	        		        break;

            	        		}


            	        	}


            	        }
            	        break;
            	    case 2 :
            	        // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:312:38: FULL
            	        {
            	        	FULL64=(IToken)Match(input,FULL,FOLLOW_FULL_in_fromJoin1182); 
            	        		FULL64_tree = (IASTNode)adaptor.Create(FULL64);
            	        		adaptor.AddChild(root_0, FULL64_tree);


            	        }
            	        break;
            	    case 3 :
            	        // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:312:45: INNER
            	        {
            	        	INNER65=(IToken)Match(input,INNER,FOLLOW_INNER_in_fromJoin1186); 
            	        		INNER65_tree = (IASTNode)adaptor.Create(INNER65);
            	        		adaptor.AddChild(root_0, INNER65_tree);


            	        }
            	        break;

            	}

            	JOIN66=(IToken)Match(input,JOIN,FOLLOW_JOIN_in_fromJoin1191); 
            		JOIN66_tree = (IASTNode)adaptor.Create(JOIN66);
            		root_0 = (IASTNode)adaptor.BecomeRoot(JOIN66_tree, root_0);

            	// /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:312:60: ( FETCH )?
            	int alt20 = 2;
            	int LA20_0 = input.LA(1);

            	if ( (LA20_0 == FETCH) )
            	{
            	    alt20 = 1;
            	}
            	switch (alt20) 
            	{
            	    case 1 :
            	        // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:312:61: FETCH
            	        {
            	        	FETCH67=(IToken)Match(input,FETCH,FOLLOW_FETCH_in_fromJoin1195); 
            	        		FETCH67_tree = (IASTNode)adaptor.Create(FETCH67);
            	        		adaptor.AddChild(root_0, FETCH67_tree);


            	        }
            	        break;

            	}

            	PushFollow(FOLLOW_path_in_fromJoin1203);
            	path68 = path();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, path68.Tree);
            	// /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:313:9: ( asAlias )?
            	int alt21 = 2;
            	int LA21_0 = input.LA(1);

            	if ( (LA21_0 == AS || LA21_0 == IDENT) )
            	{
            	    alt21 = 1;
            	}
            	switch (alt21) 
            	{
            	    case 1 :
            	        // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:313:10: asAlias
            	        {
            	        	PushFollow(FOLLOW_asAlias_in_fromJoin1206);
            	        	asAlias69 = asAlias();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, asAlias69.Tree);

            	        }
            	        break;

            	}

            	// /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:313:20: ( propertyFetch )?
            	int alt22 = 2;
            	int LA22_0 = input.LA(1);

            	if ( (LA22_0 == FETCH) )
            	{
            	    alt22 = 1;
            	}
            	switch (alt22) 
            	{
            	    case 1 :
            	        // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:313:21: propertyFetch
            	        {
            	        	PushFollow(FOLLOW_propertyFetch_in_fromJoin1211);
            	        	propertyFetch70 = propertyFetch();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, propertyFetch70.Tree);

            	        }
            	        break;

            	}

            	// /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:313:37: ( withClause )?
            	int alt23 = 2;
            	int LA23_0 = input.LA(1);

            	if ( (LA23_0 == WITH) )
            	{
            	    alt23 = 1;
            	}
            	switch (alt23) 
            	{
            	    case 1 :
            	        // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:313:38: withClause
            	        {
            	        	PushFollow(FOLLOW_withClause_in_fromJoin1216);
            	        	withClause71 = withClause();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, withClause71.Tree);

            	        }
            	        break;

            	}


            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (IASTNode)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (IASTNode)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "fromJoin"

    public class withClause_return : ParserRuleReturnScope
    {
        private IASTNode tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (IASTNode) value; }
        }
    };

    // $ANTLR start "withClause"
    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:316:1: withClause : WITH logicalExpression ;
    public HqlParser.withClause_return withClause() // throws RecognitionException [1]
    {   
        HqlParser.withClause_return retval = new HqlParser.withClause_return();
        retval.Start = input.LT(1);

        IASTNode root_0 = null;

        IToken WITH72 = null;
        HqlParser.logicalExpression_return logicalExpression73 = default(HqlParser.logicalExpression_return);


        IASTNode WITH72_tree=null;

        try 
    	{
            // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:317:2: ( WITH logicalExpression )
            // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:317:4: WITH logicalExpression
            {
            	root_0 = (IASTNode)adaptor.GetNilNode();

            	WITH72=(IToken)Match(input,WITH,FOLLOW_WITH_in_withClause1229); 
            		WITH72_tree = (IASTNode)adaptor.Create(WITH72);
            		root_0 = (IASTNode)adaptor.BecomeRoot(WITH72_tree, root_0);

            	PushFollow(FOLLOW_logicalExpression_in_withClause1232);
            	logicalExpression73 = logicalExpression();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, logicalExpression73.Tree);

            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (IASTNode)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (IASTNode)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "withClause"

    public class fromRange_return : ParserRuleReturnScope
    {
        private IASTNode tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (IASTNode) value; }
        }
    };

    // $ANTLR start "fromRange"
    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:320:1: fromRange : ( fromClassOrOuterQueryPath | inClassDeclaration | inCollectionDeclaration | inCollectionElementsDeclaration );
    public HqlParser.fromRange_return fromRange() // throws RecognitionException [1]
    {   
        HqlParser.fromRange_return retval = new HqlParser.fromRange_return();
        retval.Start = input.LT(1);

        IASTNode root_0 = null;

        HqlParser.fromClassOrOuterQueryPath_return fromClassOrOuterQueryPath74 = default(HqlParser.fromClassOrOuterQueryPath_return);

        HqlParser.inClassDeclaration_return inClassDeclaration75 = default(HqlParser.inClassDeclaration_return);

        HqlParser.inCollectionDeclaration_return inCollectionDeclaration76 = default(HqlParser.inCollectionDeclaration_return);

        HqlParser.inCollectionElementsDeclaration_return inCollectionElementsDeclaration77 = default(HqlParser.inCollectionElementsDeclaration_return);



        try 
    	{
            // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:321:2: ( fromClassOrOuterQueryPath | inClassDeclaration | inCollectionDeclaration | inCollectionElementsDeclaration )
            int alt24 = 4;
            int LA24_0 = input.LA(1);

            if ( (LA24_0 == IDENT) )
            {
                int LA24_1 = input.LA(2);

                if ( (LA24_1 == IN) )
                {
                    int LA24_3 = input.LA(3);

                    if ( (LA24_3 == ELEMENTS || LA24_3 == IDENT) )
                    {
                        alt24 = 4;
                    }
                    else if ( (LA24_3 == CLASS) )
                    {
                        alt24 = 2;
                    }
                    else 
                    {
                        NoViableAltException nvae_d24s3 =
                            new NoViableAltException("", 24, 3, input);

                        throw nvae_d24s3;
                    }
                }
                else if ( (LA24_1 == EOF || LA24_1 == AS || LA24_1 == DOT || LA24_1 == FETCH || (LA24_1 >= FULL && LA24_1 <= GROUP) || LA24_1 == INNER || (LA24_1 >= JOIN && LA24_1 <= LEFT) || LA24_1 == ORDER || LA24_1 == RIGHT || LA24_1 == UNION || LA24_1 == WHERE || LA24_1 == COMMA || LA24_1 == CLOSE || LA24_1 == IDENT) )
                {
                    alt24 = 1;
                }
                else 
                {
                    NoViableAltException nvae_d24s1 =
                        new NoViableAltException("", 24, 1, input);

                    throw nvae_d24s1;
                }
            }
            else if ( (LA24_0 == IN) )
            {
                alt24 = 3;
            }
            else 
            {
                NoViableAltException nvae_d24s0 =
                    new NoViableAltException("", 24, 0, input);

                throw nvae_d24s0;
            }
            switch (alt24) 
            {
                case 1 :
                    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:321:4: fromClassOrOuterQueryPath
                    {
                    	root_0 = (IASTNode)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_fromClassOrOuterQueryPath_in_fromRange1243);
                    	fromClassOrOuterQueryPath74 = fromClassOrOuterQueryPath();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, fromClassOrOuterQueryPath74.Tree);

                    }
                    break;
                case 2 :
                    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:322:4: inClassDeclaration
                    {
                    	root_0 = (IASTNode)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_inClassDeclaration_in_fromRange1248);
                    	inClassDeclaration75 = inClassDeclaration();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, inClassDeclaration75.Tree);

                    }
                    break;
                case 3 :
                    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:323:4: inCollectionDeclaration
                    {
                    	root_0 = (IASTNode)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_inCollectionDeclaration_in_fromRange1253);
                    	inCollectionDeclaration76 = inCollectionDeclaration();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, inCollectionDeclaration76.Tree);

                    }
                    break;
                case 4 :
                    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:324:4: inCollectionElementsDeclaration
                    {
                    	root_0 = (IASTNode)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_inCollectionElementsDeclaration_in_fromRange1258);
                    	inCollectionElementsDeclaration77 = inCollectionElementsDeclaration();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, inCollectionElementsDeclaration77.Tree);

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            	retval.Tree = (IASTNode)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (IASTNode)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "fromRange"

    public class fromClassOrOuterQueryPath_return : ParserRuleReturnScope
    {
        private IASTNode tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (IASTNode) value; }
        }
    };

    // $ANTLR start "fromClassOrOuterQueryPath"
    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:336:1: fromClassOrOuterQueryPath : path ( asAlias )? ( propertyFetch )? -> ^( RANGE path ( asAlias )? ( propertyFetch )? ) ;
    public HqlParser.fromClassOrOuterQueryPath_return fromClassOrOuterQueryPath() // throws RecognitionException [1]
    {   
        HqlParser.fromClassOrOuterQueryPath_return retval = new HqlParser.fromClassOrOuterQueryPath_return();
        retval.Start = input.LT(1);

        IASTNode root_0 = null;

        HqlParser.path_return path78 = default(HqlParser.path_return);

        HqlParser.asAlias_return asAlias79 = default(HqlParser.asAlias_return);

        HqlParser.propertyFetch_return propertyFetch80 = default(HqlParser.propertyFetch_return);


        RewriteRuleSubtreeStream stream_path = new RewriteRuleSubtreeStream(adaptor,"rule path");
        RewriteRuleSubtreeStream stream_propertyFetch = new RewriteRuleSubtreeStream(adaptor,"rule propertyFetch");
        RewriteRuleSubtreeStream stream_asAlias = new RewriteRuleSubtreeStream(adaptor,"rule asAlias");
        try 
    	{
            // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:337:2: ( path ( asAlias )? ( propertyFetch )? -> ^( RANGE path ( asAlias )? ( propertyFetch )? ) )
            // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:337:4: path ( asAlias )? ( propertyFetch )?
            {
            	PushFollow(FOLLOW_path_in_fromClassOrOuterQueryPath1273);
            	path78 = path();
            	state.followingStackPointer--;

            	stream_path.Add(path78.Tree);
            	 WeakKeywords(); 
            	// /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:337:29: ( asAlias )?
            	int alt25 = 2;
            	int LA25_0 = input.LA(1);

            	if ( (LA25_0 == AS || LA25_0 == IDENT) )
            	{
            	    alt25 = 1;
            	}
            	switch (alt25) 
            	{
            	    case 1 :
            	        // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:337:30: asAlias
            	        {
            	        	PushFollow(FOLLOW_asAlias_in_fromClassOrOuterQueryPath1278);
            	        	asAlias79 = asAlias();
            	        	state.followingStackPointer--;

            	        	stream_asAlias.Add(asAlias79.Tree);

            	        }
            	        break;

            	}

            	// /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:337:40: ( propertyFetch )?
            	int alt26 = 2;
            	int LA26_0 = input.LA(1);

            	if ( (LA26_0 == FETCH) )
            	{
            	    alt26 = 1;
            	}
            	switch (alt26) 
            	{
            	    case 1 :
            	        // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:337:41: propertyFetch
            	        {
            	        	PushFollow(FOLLOW_propertyFetch_in_fromClassOrOuterQueryPath1283);
            	        	propertyFetch80 = propertyFetch();
            	        	state.followingStackPointer--;

            	        	stream_propertyFetch.Add(propertyFetch80.Tree);

            	        }
            	        break;

            	}



            	// AST REWRITE
            	// elements:          propertyFetch, asAlias, path
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (IASTNode)adaptor.GetNilNode();
            	// 338:3: -> ^( RANGE path ( asAlias )? ( propertyFetch )? )
            	{
            	    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:338:6: ^( RANGE path ( asAlias )? ( propertyFetch )? )
            	    {
            	    IASTNode root_1 = (IASTNode)adaptor.GetNilNode();
            	    root_1 = (IASTNode)adaptor.BecomeRoot((IASTNode)adaptor.Create(RANGE, "RANGE"), root_1);

            	    adaptor.AddChild(root_1, stream_path.NextTree());
            	    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:338:19: ( asAlias )?
            	    if ( stream_asAlias.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_asAlias.NextTree());

            	    }
            	    stream_asAlias.Reset();
            	    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:338:28: ( propertyFetch )?
            	    if ( stream_propertyFetch.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_propertyFetch.NextTree());

            	    }
            	    stream_propertyFetch.Reset();

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;
            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (IASTNode)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (IASTNode)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "fromClassOrOuterQueryPath"

    public class inClassDeclaration_return : ParserRuleReturnScope
    {
        private IASTNode tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (IASTNode) value; }
        }
    };

    // $ANTLR start "inClassDeclaration"
    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:350:1: inClassDeclaration : alias IN CLASS path -> ^( RANGE path alias ) ;
    public HqlParser.inClassDeclaration_return inClassDeclaration() // throws RecognitionException [1]
    {   
        HqlParser.inClassDeclaration_return retval = new HqlParser.inClassDeclaration_return();
        retval.Start = input.LT(1);

        IASTNode root_0 = null;

        IToken IN82 = null;
        IToken CLASS83 = null;
        HqlParser.alias_return alias81 = default(HqlParser.alias_return);

        HqlParser.path_return path84 = default(HqlParser.path_return);


        IASTNode IN82_tree=null;
        IASTNode CLASS83_tree=null;
        RewriteRuleTokenStream stream_CLASS = new RewriteRuleTokenStream(adaptor,"token CLASS");
        RewriteRuleTokenStream stream_IN = new RewriteRuleTokenStream(adaptor,"token IN");
        RewriteRuleSubtreeStream stream_path = new RewriteRuleSubtreeStream(adaptor,"rule path");
        RewriteRuleSubtreeStream stream_alias = new RewriteRuleSubtreeStream(adaptor,"rule alias");
        try 
    	{
            // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:351:2: ( alias IN CLASS path -> ^( RANGE path alias ) )
            // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:351:4: alias IN CLASS path
            {
            	PushFollow(FOLLOW_alias_in_inClassDeclaration1316);
            	alias81 = alias();
            	state.followingStackPointer--;

            	stream_alias.Add(alias81.Tree);
            	IN82=(IToken)Match(input,IN,FOLLOW_IN_in_inClassDeclaration1318);  
            	stream_IN.Add(IN82);

            	CLASS83=(IToken)Match(input,CLASS,FOLLOW_CLASS_in_inClassDeclaration1320);  
            	stream_CLASS.Add(CLASS83);

            	PushFollow(FOLLOW_path_in_inClassDeclaration1322);
            	path84 = path();
            	state.followingStackPointer--;

            	stream_path.Add(path84.Tree);


            	// AST REWRITE
            	// elements:          alias, path
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (IASTNode)adaptor.GetNilNode();
            	// 352:3: -> ^( RANGE path alias )
            	{
            	    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:352:6: ^( RANGE path alias )
            	    {
            	    IASTNode root_1 = (IASTNode)adaptor.GetNilNode();
            	    root_1 = (IASTNode)adaptor.BecomeRoot((IASTNode)adaptor.Create(RANGE, "RANGE"), root_1);

            	    adaptor.AddChild(root_1, stream_path.NextTree());
            	    adaptor.AddChild(root_1, stream_alias.NextTree());

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;
            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (IASTNode)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (IASTNode)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "inClassDeclaration"

    public class inCollectionDeclaration_return : ParserRuleReturnScope
    {
        private IASTNode tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (IASTNode) value; }
        }
    };

    // $ANTLR start "inCollectionDeclaration"
    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:364:1: inCollectionDeclaration : IN OPEN path CLOSE alias -> ^( JOIN[\"join\"] INNER[\"inner\"] path alias ) ;
    public HqlParser.inCollectionDeclaration_return inCollectionDeclaration() // throws RecognitionException [1]
    {   
        HqlParser.inCollectionDeclaration_return retval = new HqlParser.inCollectionDeclaration_return();
        retval.Start = input.LT(1);

        IASTNode root_0 = null;

        IToken IN85 = null;
        IToken OPEN86 = null;
        IToken CLOSE88 = null;
        HqlParser.path_return path87 = default(HqlParser.path_return);

        HqlParser.alias_return alias89 = default(HqlParser.alias_return);


        IASTNode IN85_tree=null;
        IASTNode OPEN86_tree=null;
        IASTNode CLOSE88_tree=null;
        RewriteRuleTokenStream stream_CLOSE = new RewriteRuleTokenStream(adaptor,"token CLOSE");
        RewriteRuleTokenStream stream_OPEN = new RewriteRuleTokenStream(adaptor,"token OPEN");
        RewriteRuleTokenStream stream_IN = new RewriteRuleTokenStream(adaptor,"token IN");
        RewriteRuleSubtreeStream stream_path = new RewriteRuleSubtreeStream(adaptor,"rule path");
        RewriteRuleSubtreeStream stream_alias = new RewriteRuleSubtreeStream(adaptor,"rule alias");
        try 
    	{
            // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:365:5: ( IN OPEN path CLOSE alias -> ^( JOIN[\"join\"] INNER[\"inner\"] path alias ) )
            // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:365:7: IN OPEN path CLOSE alias
            {
            	IN85=(IToken)Match(input,IN,FOLLOW_IN_in_inCollectionDeclaration1353);  
            	stream_IN.Add(IN85);

            	OPEN86=(IToken)Match(input,OPEN,FOLLOW_OPEN_in_inCollectionDeclaration1355);  
            	stream_OPEN.Add(OPEN86);

            	PushFollow(FOLLOW_path_in_inCollectionDeclaration1357);
            	path87 = path();
            	state.followingStackPointer--;

            	stream_path.Add(path87.Tree);
            	CLOSE88=(IToken)Match(input,CLOSE,FOLLOW_CLOSE_in_inCollectionDeclaration1359);  
            	stream_CLOSE.Add(CLOSE88);

            	PushFollow(FOLLOW_alias_in_inCollectionDeclaration1361);
            	alias89 = alias();
            	state.followingStackPointer--;

            	stream_alias.Add(alias89.Tree);


            	// AST REWRITE
            	// elements:          path, alias
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (IASTNode)adaptor.GetNilNode();
            	// 366:6: -> ^( JOIN[\"join\"] INNER[\"inner\"] path alias )
            	{
            	    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:366:9: ^( JOIN[\"join\"] INNER[\"inner\"] path alias )
            	    {
            	    IASTNode root_1 = (IASTNode)adaptor.GetNilNode();
            	    root_1 = (IASTNode)adaptor.BecomeRoot((IASTNode)adaptor.Create(JOIN, "join"), root_1);

            	    adaptor.AddChild(root_1, (IASTNode)adaptor.Create(INNER, "inner"));
            	    adaptor.AddChild(root_1, stream_path.NextTree());
            	    adaptor.AddChild(root_1, stream_alias.NextTree());

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;
            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (IASTNode)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (IASTNode)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "inCollectionDeclaration"

    public class inCollectionElementsDeclaration_return : ParserRuleReturnScope
    {
        private IASTNode tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (IASTNode) value; }
        }
    };

    // $ANTLR start "inCollectionElementsDeclaration"
    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:378:1: inCollectionElementsDeclaration : ( alias IN ELEMENTS OPEN path CLOSE -> ^( JOIN[\"join\"] INNER[\"inner\"] path alias ) | alias IN path DOT ELEMENTS -> ^( JOIN[\"join\"] INNER[\"inner\"] path alias ) );
    public HqlParser.inCollectionElementsDeclaration_return inCollectionElementsDeclaration() // throws RecognitionException [1]
    {   
        HqlParser.inCollectionElementsDeclaration_return retval = new HqlParser.inCollectionElementsDeclaration_return();
        retval.Start = input.LT(1);

        IASTNode root_0 = null;

        IToken IN91 = null;
        IToken ELEMENTS92 = null;
        IToken OPEN93 = null;
        IToken CLOSE95 = null;
        IToken IN97 = null;
        IToken DOT99 = null;
        IToken ELEMENTS100 = null;
        HqlParser.alias_return alias90 = default(HqlParser.alias_return);

        HqlParser.path_return path94 = default(HqlParser.path_return);

        HqlParser.alias_return alias96 = default(HqlParser.alias_return);

        HqlParser.path_return path98 = default(HqlParser.path_return);


        IASTNode IN91_tree=null;
        IASTNode ELEMENTS92_tree=null;
        IASTNode OPEN93_tree=null;
        IASTNode CLOSE95_tree=null;
        IASTNode IN97_tree=null;
        IASTNode DOT99_tree=null;
        IASTNode ELEMENTS100_tree=null;
        RewriteRuleTokenStream stream_CLOSE = new RewriteRuleTokenStream(adaptor,"token CLOSE");
        RewriteRuleTokenStream stream_ELEMENTS = new RewriteRuleTokenStream(adaptor,"token ELEMENTS");
        RewriteRuleTokenStream stream_OPEN = new RewriteRuleTokenStream(adaptor,"token OPEN");
        RewriteRuleTokenStream stream_DOT = new RewriteRuleTokenStream(adaptor,"token DOT");
        RewriteRuleTokenStream stream_IN = new RewriteRuleTokenStream(adaptor,"token IN");
        RewriteRuleSubtreeStream stream_path = new RewriteRuleSubtreeStream(adaptor,"rule path");
        RewriteRuleSubtreeStream stream_alias = new RewriteRuleSubtreeStream(adaptor,"rule alias");
        try 
    	{
            // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:379:2: ( alias IN ELEMENTS OPEN path CLOSE -> ^( JOIN[\"join\"] INNER[\"inner\"] path alias ) | alias IN path DOT ELEMENTS -> ^( JOIN[\"join\"] INNER[\"inner\"] path alias ) )
            int alt27 = 2;
            int LA27_0 = input.LA(1);

            if ( (LA27_0 == IDENT) )
            {
                int LA27_1 = input.LA(2);

                if ( (LA27_1 == IN) )
                {
                    int LA27_2 = input.LA(3);

                    if ( (LA27_2 == ELEMENTS) )
                    {
                        alt27 = 1;
                    }
                    else if ( (LA27_2 == IDENT) )
                    {
                        alt27 = 2;
                    }
                    else 
                    {
                        NoViableAltException nvae_d27s2 =
                            new NoViableAltException("", 27, 2, input);

                        throw nvae_d27s2;
                    }
                }
                else 
                {
                    NoViableAltException nvae_d27s1 =
                        new NoViableAltException("", 27, 1, input);

                    throw nvae_d27s1;
                }
            }
            else 
            {
                NoViableAltException nvae_d27s0 =
                    new NoViableAltException("", 27, 0, input);

                throw nvae_d27s0;
            }
            switch (alt27) 
            {
                case 1 :
                    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:379:4: alias IN ELEMENTS OPEN path CLOSE
                    {
                    	PushFollow(FOLLOW_alias_in_inCollectionElementsDeclaration1399);
                    	alias90 = alias();
                    	state.followingStackPointer--;

                    	stream_alias.Add(alias90.Tree);
                    	IN91=(IToken)Match(input,IN,FOLLOW_IN_in_inCollectionElementsDeclaration1401);  
                    	stream_IN.Add(IN91);

                    	ELEMENTS92=(IToken)Match(input,ELEMENTS,FOLLOW_ELEMENTS_in_inCollectionElementsDeclaration1403);  
                    	stream_ELEMENTS.Add(ELEMENTS92);

                    	OPEN93=(IToken)Match(input,OPEN,FOLLOW_OPEN_in_inCollectionElementsDeclaration1405);  
                    	stream_OPEN.Add(OPEN93);

                    	PushFollow(FOLLOW_path_in_inCollectionElementsDeclaration1407);
                    	path94 = path();
                    	state.followingStackPointer--;

                    	stream_path.Add(path94.Tree);
                    	CLOSE95=(IToken)Match(input,CLOSE,FOLLOW_CLOSE_in_inCollectionElementsDeclaration1409);  
                    	stream_CLOSE.Add(CLOSE95);



                    	// AST REWRITE
                    	// elements:          alias, path
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (IASTNode)adaptor.GetNilNode();
                    	// 380:3: -> ^( JOIN[\"join\"] INNER[\"inner\"] path alias )
                    	{
                    	    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:380:6: ^( JOIN[\"join\"] INNER[\"inner\"] path alias )
                    	    {
                    	    IASTNode root_1 = (IASTNode)adaptor.GetNilNode();
                    	    root_1 = (IASTNode)adaptor.BecomeRoot((IASTNode)adaptor.Create(JOIN, "join"), root_1);

                    	    adaptor.AddChild(root_1, (IASTNode)adaptor.Create(INNER, "inner"));
                    	    adaptor.AddChild(root_1, stream_path.NextTree());
                    	    adaptor.AddChild(root_1, stream_alias.NextTree());

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;
                    }
                    break;
                case 2 :
                    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:381:4: alias IN path DOT ELEMENTS
                    {
                    	PushFollow(FOLLOW_alias_in_inCollectionElementsDeclaration1431);
                    	alias96 = alias();
                    	state.followingStackPointer--;

                    	stream_alias.Add(alias96.Tree);
                    	IN97=(IToken)Match(input,IN,FOLLOW_IN_in_inCollectionElementsDeclaration1433);  
                    	stream_IN.Add(IN97);

                    	PushFollow(FOLLOW_path_in_inCollectionElementsDeclaration1435);
                    	path98 = path();
                    	state.followingStackPointer--;

                    	stream_path.Add(path98.Tree);
                    	DOT99=(IToken)Match(input,DOT,FOLLOW_DOT_in_inCollectionElementsDeclaration1437);  
                    	stream_DOT.Add(DOT99);

                    	ELEMENTS100=(IToken)Match(input,ELEMENTS,FOLLOW_ELEMENTS_in_inCollectionElementsDeclaration1439);  
                    	stream_ELEMENTS.Add(ELEMENTS100);



                    	// AST REWRITE
                    	// elements:          path, alias
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (IASTNode)adaptor.GetNilNode();
                    	// 382:3: -> ^( JOIN[\"join\"] INNER[\"inner\"] path alias )
                    	{
                    	    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:382:6: ^( JOIN[\"join\"] INNER[\"inner\"] path alias )
                    	    {
                    	    IASTNode root_1 = (IASTNode)adaptor.GetNilNode();
                    	    root_1 = (IASTNode)adaptor.BecomeRoot((IASTNode)adaptor.Create(JOIN, "join"), root_1);

                    	    adaptor.AddChild(root_1, (IASTNode)adaptor.Create(INNER, "inner"));
                    	    adaptor.AddChild(root_1, stream_path.NextTree());
                    	    adaptor.AddChild(root_1, stream_alias.NextTree());

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;
                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            	retval.Tree = (IASTNode)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (IASTNode)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "inCollectionElementsDeclaration"

    public class asAlias_return : ParserRuleReturnScope
    {
        private IASTNode tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (IASTNode) value; }
        }
    };

    // $ANTLR start "asAlias"
    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:386:1: asAlias : ( AS )? alias ;
    public HqlParser.asAlias_return asAlias() // throws RecognitionException [1]
    {   
        HqlParser.asAlias_return retval = new HqlParser.asAlias_return();
        retval.Start = input.LT(1);

        IASTNode root_0 = null;

        IToken AS101 = null;
        HqlParser.alias_return alias102 = default(HqlParser.alias_return);


        IASTNode AS101_tree=null;

        try 
    	{
            // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:387:2: ( ( AS )? alias )
            // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:387:4: ( AS )? alias
            {
            	root_0 = (IASTNode)adaptor.GetNilNode();

            	// /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:387:4: ( AS )?
            	int alt28 = 2;
            	int LA28_0 = input.LA(1);

            	if ( (LA28_0 == AS) )
            	{
            	    alt28 = 1;
            	}
            	switch (alt28) 
            	{
            	    case 1 :
            	        // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:387:5: AS
            	        {
            	        	AS101=(IToken)Match(input,AS,FOLLOW_AS_in_asAlias1471); 

            	        }
            	        break;

            	}

            	PushFollow(FOLLOW_alias_in_asAlias1476);
            	alias102 = alias();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, alias102.Tree);

            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (IASTNode)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (IASTNode)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "asAlias"

    public class alias_return : ParserRuleReturnScope
    {
        private IASTNode tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (IASTNode) value; }
        }
    };

    // $ANTLR start "alias"
    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:397:1: alias : i= identifier -> ^( ALIAS[$i.start] ) ;
    public HqlParser.alias_return alias() // throws RecognitionException [1]
    {   
        HqlParser.alias_return retval = new HqlParser.alias_return();
        retval.Start = input.LT(1);

        IASTNode root_0 = null;

        HqlParser.identifier_return i = default(HqlParser.identifier_return);


        RewriteRuleSubtreeStream stream_identifier = new RewriteRuleSubtreeStream(adaptor,"rule identifier");
        try 
    	{
            // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:398:2: (i= identifier -> ^( ALIAS[$i.start] ) )
            // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:398:4: i= identifier
            {
            	PushFollow(FOLLOW_identifier_in_alias1492);
            	i = identifier();
            	state.followingStackPointer--;

            	stream_identifier.Add(i.Tree);


            	// AST REWRITE
            	// elements:          
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (IASTNode)adaptor.GetNilNode();
            	// 399:2: -> ^( ALIAS[$i.start] )
            	{
            	    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:399:5: ^( ALIAS[$i.start] )
            	    {
            	    IASTNode root_1 = (IASTNode)adaptor.GetNilNode();
            	    root_1 = (IASTNode)adaptor.BecomeRoot((IASTNode)adaptor.Create(ALIAS, ((i != null) ? ((IToken)i.Start) : null)), root_1);

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;
            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (IASTNode)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (IASTNode)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "alias"

    public class propertyFetch_return : ParserRuleReturnScope
    {
        private IASTNode tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (IASTNode) value; }
        }
    };

    // $ANTLR start "propertyFetch"
    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:402:1: propertyFetch : FETCH ALL PROPERTIES ;
    public HqlParser.propertyFetch_return propertyFetch() // throws RecognitionException [1]
    {   
        HqlParser.propertyFetch_return retval = new HqlParser.propertyFetch_return();
        retval.Start = input.LT(1);

        IASTNode root_0 = null;

        IToken FETCH103 = null;
        IToken ALL104 = null;
        IToken PROPERTIES105 = null;

        IASTNode FETCH103_tree=null;
        IASTNode ALL104_tree=null;
        IASTNode PROPERTIES105_tree=null;

        try 
    	{
            // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:403:2: ( FETCH ALL PROPERTIES )
            // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:403:4: FETCH ALL PROPERTIES
            {
            	root_0 = (IASTNode)adaptor.GetNilNode();

            	FETCH103=(IToken)Match(input,FETCH,FOLLOW_FETCH_in_propertyFetch1511); 
            		FETCH103_tree = (IASTNode)adaptor.Create(FETCH103);
            		adaptor.AddChild(root_0, FETCH103_tree);

            	ALL104=(IToken)Match(input,ALL,FOLLOW_ALL_in_propertyFetch1513); 
            	PROPERTIES105=(IToken)Match(input,PROPERTIES,FOLLOW_PROPERTIES_in_propertyFetch1516); 

            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (IASTNode)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (IASTNode)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "propertyFetch"

    public class groupByClause_return : ParserRuleReturnScope
    {
        private IASTNode tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (IASTNode) value; }
        }
    };

    // $ANTLR start "groupByClause"
    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:409:1: groupByClause : GROUP 'by' expression ( COMMA expression )* ( havingClause )? ;
    public HqlParser.groupByClause_return groupByClause() // throws RecognitionException [1]
    {   
        HqlParser.groupByClause_return retval = new HqlParser.groupByClause_return();
        retval.Start = input.LT(1);

        IASTNode root_0 = null;

        IToken GROUP106 = null;
        IToken string_literal107 = null;
        IToken COMMA109 = null;
        HqlParser.expression_return expression108 = default(HqlParser.expression_return);

        HqlParser.expression_return expression110 = default(HqlParser.expression_return);

        HqlParser.havingClause_return havingClause111 = default(HqlParser.havingClause_return);


        IASTNode GROUP106_tree=null;
        IASTNode string_literal107_tree=null;
        IASTNode COMMA109_tree=null;

        try 
    	{
            // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:410:2: ( GROUP 'by' expression ( COMMA expression )* ( havingClause )? )
            // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:410:4: GROUP 'by' expression ( COMMA expression )* ( havingClause )?
            {
            	root_0 = (IASTNode)adaptor.GetNilNode();

            	GROUP106=(IToken)Match(input,GROUP,FOLLOW_GROUP_in_groupByClause1531); 
            		GROUP106_tree = (IASTNode)adaptor.Create(GROUP106);
            		root_0 = (IASTNode)adaptor.BecomeRoot(GROUP106_tree, root_0);

            	string_literal107=(IToken)Match(input,LITERAL_by,FOLLOW_LITERAL_by_in_groupByClause1537); 
            	PushFollow(FOLLOW_expression_in_groupByClause1540);
            	expression108 = expression();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, expression108.Tree);
            	// /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:411:20: ( COMMA expression )*
            	do 
            	{
            	    int alt29 = 2;
            	    int LA29_0 = input.LA(1);

            	    if ( (LA29_0 == COMMA) )
            	    {
            	        alt29 = 1;
            	    }


            	    switch (alt29) 
            		{
            			case 1 :
            			    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:411:22: COMMA expression
            			    {
            			    	COMMA109=(IToken)Match(input,COMMA,FOLLOW_COMMA_in_groupByClause1544); 
            			    	PushFollow(FOLLOW_expression_in_groupByClause1547);
            			    	expression110 = expression();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, expression110.Tree);

            			    }
            			    break;

            			default:
            			    goto loop29;
            	    }
            	} while (true);

            	loop29:
            		;	// Stops C# compiler whining that label 'loop29' has no statements

            	// /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:412:3: ( havingClause )?
            	int alt30 = 2;
            	int LA30_0 = input.LA(1);

            	if ( (LA30_0 == HAVING) )
            	{
            	    alt30 = 1;
            	}
            	switch (alt30) 
            	{
            	    case 1 :
            	        // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:412:4: havingClause
            	        {
            	        	PushFollow(FOLLOW_havingClause_in_groupByClause1555);
            	        	havingClause111 = havingClause();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, havingClause111.Tree);

            	        }
            	        break;

            	}


            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (IASTNode)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (IASTNode)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "groupByClause"

    public class orderByClause_return : ParserRuleReturnScope
    {
        private IASTNode tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (IASTNode) value; }
        }
    };

    // $ANTLR start "orderByClause"
    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:418:1: orderByClause : ORDER 'by' orderElement ( COMMA orderElement )* ;
    public HqlParser.orderByClause_return orderByClause() // throws RecognitionException [1]
    {   
        HqlParser.orderByClause_return retval = new HqlParser.orderByClause_return();
        retval.Start = input.LT(1);

        IASTNode root_0 = null;

        IToken ORDER112 = null;
        IToken string_literal113 = null;
        IToken COMMA115 = null;
        HqlParser.orderElement_return orderElement114 = default(HqlParser.orderElement_return);

        HqlParser.orderElement_return orderElement116 = default(HqlParser.orderElement_return);


        IASTNode ORDER112_tree=null;
        IASTNode string_literal113_tree=null;
        IASTNode COMMA115_tree=null;

        try 
    	{
            // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:419:2: ( ORDER 'by' orderElement ( COMMA orderElement )* )
            // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:419:4: ORDER 'by' orderElement ( COMMA orderElement )*
            {
            	root_0 = (IASTNode)adaptor.GetNilNode();

            	ORDER112=(IToken)Match(input,ORDER,FOLLOW_ORDER_in_orderByClause1571); 
            		ORDER112_tree = (IASTNode)adaptor.Create(ORDER112);
            		root_0 = (IASTNode)adaptor.BecomeRoot(ORDER112_tree, root_0);

            	string_literal113=(IToken)Match(input,LITERAL_by,FOLLOW_LITERAL_by_in_orderByClause1574); 
            	PushFollow(FOLLOW_orderElement_in_orderByClause1577);
            	orderElement114 = orderElement();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, orderElement114.Tree);
            	// /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:419:30: ( COMMA orderElement )*
            	do 
            	{
            	    int alt31 = 2;
            	    int LA31_0 = input.LA(1);

            	    if ( (LA31_0 == COMMA) )
            	    {
            	        alt31 = 1;
            	    }


            	    switch (alt31) 
            		{
            			case 1 :
            			    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:419:32: COMMA orderElement
            			    {
            			    	COMMA115=(IToken)Match(input,COMMA,FOLLOW_COMMA_in_orderByClause1581); 
            			    	PushFollow(FOLLOW_orderElement_in_orderByClause1584);
            			    	orderElement116 = orderElement();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, orderElement116.Tree);

            			    }
            			    break;

            			default:
            			    goto loop31;
            	    }
            	} while (true);

            	loop31:
            		;	// Stops C# compiler whining that label 'loop31' has no statements


            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (IASTNode)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (IASTNode)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "orderByClause"

    public class orderElement_return : ParserRuleReturnScope
    {
        private IASTNode tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (IASTNode) value; }
        }
    };

    // $ANTLR start "orderElement"
    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:422:1: orderElement : expression ( ascendingOrDescending )? ;
    public HqlParser.orderElement_return orderElement() // throws RecognitionException [1]
    {   
        HqlParser.orderElement_return retval = new HqlParser.orderElement_return();
        retval.Start = input.LT(1);

        IASTNode root_0 = null;

        HqlParser.expression_return expression117 = default(HqlParser.expression_return);

        HqlParser.ascendingOrDescending_return ascendingOrDescending118 = default(HqlParser.ascendingOrDescending_return);



        try 
    	{
            // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:423:2: ( expression ( ascendingOrDescending )? )
            // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:423:4: expression ( ascendingOrDescending )?
            {
            	root_0 = (IASTNode)adaptor.GetNilNode();

            	PushFollow(FOLLOW_expression_in_orderElement1598);
            	expression117 = expression();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, expression117.Tree);
            	// /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:423:15: ( ascendingOrDescending )?
            	int alt32 = 2;
            	int LA32_0 = input.LA(1);

            	if ( (LA32_0 == ASCENDING || LA32_0 == DESCENDING || (LA32_0 >= 126 && LA32_0 <= 127)) )
            	{
            	    alt32 = 1;
            	}
            	switch (alt32) 
            	{
            	    case 1 :
            	        // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:423:17: ascendingOrDescending
            	        {
            	        	PushFollow(FOLLOW_ascendingOrDescending_in_orderElement1602);
            	        	ascendingOrDescending118 = ascendingOrDescending();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, ascendingOrDescending118.Tree);

            	        }
            	        break;

            	}


            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (IASTNode)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (IASTNode)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "orderElement"

    public class ascendingOrDescending_return : ParserRuleReturnScope
    {
        private IASTNode tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (IASTNode) value; }
        }
    };

    // $ANTLR start "ascendingOrDescending"
    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:426:1: ascendingOrDescending : ( (a= 'asc' | a= 'ascending' ) -> ^( ASCENDING[$a.Text] ) | (d= 'desc' | d= 'descending' ) -> ^( DESCENDING[$d.Text] ) );
    public HqlParser.ascendingOrDescending_return ascendingOrDescending() // throws RecognitionException [1]
    {   
        HqlParser.ascendingOrDescending_return retval = new HqlParser.ascendingOrDescending_return();
        retval.Start = input.LT(1);

        IASTNode root_0 = null;

        IToken a = null;
        IToken d = null;

        IASTNode a_tree=null;
        IASTNode d_tree=null;
        RewriteRuleTokenStream stream_127 = new RewriteRuleTokenStream(adaptor,"token 127");
        RewriteRuleTokenStream stream_ASCENDING = new RewriteRuleTokenStream(adaptor,"token ASCENDING");
        RewriteRuleTokenStream stream_DESCENDING = new RewriteRuleTokenStream(adaptor,"token DESCENDING");
        RewriteRuleTokenStream stream_126 = new RewriteRuleTokenStream(adaptor,"token 126");

        try 
    	{
            // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:427:2: ( (a= 'asc' | a= 'ascending' ) -> ^( ASCENDING[$a.Text] ) | (d= 'desc' | d= 'descending' ) -> ^( DESCENDING[$d.Text] ) )
            int alt35 = 2;
            int LA35_0 = input.LA(1);

            if ( (LA35_0 == ASCENDING || LA35_0 == 126) )
            {
                alt35 = 1;
            }
            else if ( (LA35_0 == DESCENDING || LA35_0 == 127) )
            {
                alt35 = 2;
            }
            else 
            {
                NoViableAltException nvae_d35s0 =
                    new NoViableAltException("", 35, 0, input);

                throw nvae_d35s0;
            }
            switch (alt35) 
            {
                case 1 :
                    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:427:4: (a= 'asc' | a= 'ascending' )
                    {
                    	// /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:427:4: (a= 'asc' | a= 'ascending' )
                    	int alt33 = 2;
                    	int LA33_0 = input.LA(1);

                    	if ( (LA33_0 == ASCENDING) )
                    	{
                    	    alt33 = 1;
                    	}
                    	else if ( (LA33_0 == 126) )
                    	{
                    	    alt33 = 2;
                    	}
                    	else 
                    	{
                    	    NoViableAltException nvae_d33s0 =
                    	        new NoViableAltException("", 33, 0, input);

                    	    throw nvae_d33s0;
                    	}
                    	switch (alt33) 
                    	{
                    	    case 1 :
                    	        // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:427:6: a= 'asc'
                    	        {
                    	        	a=(IToken)Match(input,ASCENDING,FOLLOW_ASCENDING_in_ascendingOrDescending1620);  
                    	        	stream_ASCENDING.Add(a);


                    	        }
                    	        break;
                    	    case 2 :
                    	        // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:427:16: a= 'ascending'
                    	        {
                    	        	a=(IToken)Match(input,126,FOLLOW_126_in_ascendingOrDescending1626);  
                    	        	stream_126.Add(a);


                    	        }
                    	        break;

                    	}



                    	// AST REWRITE
                    	// elements:          
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (IASTNode)adaptor.GetNilNode();
                    	// 428:3: -> ^( ASCENDING[$a.Text] )
                    	{
                    	    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:428:6: ^( ASCENDING[$a.Text] )
                    	    {
                    	    IASTNode root_1 = (IASTNode)adaptor.GetNilNode();
                    	    root_1 = (IASTNode)adaptor.BecomeRoot((IASTNode)adaptor.Create(ASCENDING, a.Text), root_1);

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;
                    }
                    break;
                case 2 :
                    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:429:4: (d= 'desc' | d= 'descending' )
                    {
                    	// /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:429:4: (d= 'desc' | d= 'descending' )
                    	int alt34 = 2;
                    	int LA34_0 = input.LA(1);

                    	if ( (LA34_0 == DESCENDING) )
                    	{
                    	    alt34 = 1;
                    	}
                    	else if ( (LA34_0 == 127) )
                    	{
                    	    alt34 = 2;
                    	}
                    	else 
                    	{
                    	    NoViableAltException nvae_d34s0 =
                    	        new NoViableAltException("", 34, 0, input);

                    	    throw nvae_d34s0;
                    	}
                    	switch (alt34) 
                    	{
                    	    case 1 :
                    	        // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:429:6: d= 'desc'
                    	        {
                    	        	d=(IToken)Match(input,DESCENDING,FOLLOW_DESCENDING_in_ascendingOrDescending1646);  
                    	        	stream_DESCENDING.Add(d);


                    	        }
                    	        break;
                    	    case 2 :
                    	        // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:429:17: d= 'descending'
                    	        {
                    	        	d=(IToken)Match(input,127,FOLLOW_127_in_ascendingOrDescending1652);  
                    	        	stream_127.Add(d);


                    	        }
                    	        break;

                    	}



                    	// AST REWRITE
                    	// elements:          
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (IASTNode)adaptor.GetNilNode();
                    	// 430:3: -> ^( DESCENDING[$d.Text] )
                    	{
                    	    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:430:6: ^( DESCENDING[$d.Text] )
                    	    {
                    	    IASTNode root_1 = (IASTNode)adaptor.GetNilNode();
                    	    root_1 = (IASTNode)adaptor.BecomeRoot((IASTNode)adaptor.Create(DESCENDING, d.Text), root_1);

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;
                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            	retval.Tree = (IASTNode)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (IASTNode)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "ascendingOrDescending"

    public class havingClause_return : ParserRuleReturnScope
    {
        private IASTNode tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (IASTNode) value; }
        }
    };

    // $ANTLR start "havingClause"
    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:436:1: havingClause : HAVING logicalExpression ;
    public HqlParser.havingClause_return havingClause() // throws RecognitionException [1]
    {   
        HqlParser.havingClause_return retval = new HqlParser.havingClause_return();
        retval.Start = input.LT(1);

        IASTNode root_0 = null;

        IToken HAVING119 = null;
        HqlParser.logicalExpression_return logicalExpression120 = default(HqlParser.logicalExpression_return);


        IASTNode HAVING119_tree=null;

        try 
    	{
            // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:437:2: ( HAVING logicalExpression )
            // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:437:4: HAVING logicalExpression
            {
            	root_0 = (IASTNode)adaptor.GetNilNode();

            	HAVING119=(IToken)Match(input,HAVING,FOLLOW_HAVING_in_havingClause1676); 
            		HAVING119_tree = (IASTNode)adaptor.Create(HAVING119);
            		root_0 = (IASTNode)adaptor.BecomeRoot(HAVING119_tree, root_0);

            	PushFollow(FOLLOW_logicalExpression_in_havingClause1679);
            	logicalExpression120 = logicalExpression();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, logicalExpression120.Tree);

            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (IASTNode)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (IASTNode)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "havingClause"

    public class whereClause_return : ParserRuleReturnScope
    {
        private IASTNode tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (IASTNode) value; }
        }
    };

    // $ANTLR start "whereClause"
    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:443:1: whereClause : WHERE logicalExpression ;
    public HqlParser.whereClause_return whereClause() // throws RecognitionException [1]
    {   
        HqlParser.whereClause_return retval = new HqlParser.whereClause_return();
        retval.Start = input.LT(1);

        IASTNode root_0 = null;

        IToken WHERE121 = null;
        HqlParser.logicalExpression_return logicalExpression122 = default(HqlParser.logicalExpression_return);


        IASTNode WHERE121_tree=null;

        try 
    	{
            // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:444:2: ( WHERE logicalExpression )
            // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:444:4: WHERE logicalExpression
            {
            	root_0 = (IASTNode)adaptor.GetNilNode();

            	WHERE121=(IToken)Match(input,WHERE,FOLLOW_WHERE_in_whereClause1693); 
            		WHERE121_tree = (IASTNode)adaptor.Create(WHERE121);
            		root_0 = (IASTNode)adaptor.BecomeRoot(WHERE121_tree, root_0);

            	PushFollow(FOLLOW_logicalExpression_in_whereClause1696);
            	logicalExpression122 = logicalExpression();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, logicalExpression122.Tree);

            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (IASTNode)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (IASTNode)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "whereClause"

    public class selectedPropertiesList_return : ParserRuleReturnScope
    {
        private IASTNode tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (IASTNode) value; }
        }
    };

    // $ANTLR start "selectedPropertiesList"
    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:450:1: selectedPropertiesList : aliasedExpression ( COMMA aliasedExpression )* ;
    public HqlParser.selectedPropertiesList_return selectedPropertiesList() // throws RecognitionException [1]
    {   
        HqlParser.selectedPropertiesList_return retval = new HqlParser.selectedPropertiesList_return();
        retval.Start = input.LT(1);

        IASTNode root_0 = null;

        IToken COMMA124 = null;
        HqlParser.aliasedExpression_return aliasedExpression123 = default(HqlParser.aliasedExpression_return);

        HqlParser.aliasedExpression_return aliasedExpression125 = default(HqlParser.aliasedExpression_return);


        IASTNode COMMA124_tree=null;

        try 
    	{
            // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:451:2: ( aliasedExpression ( COMMA aliasedExpression )* )
            // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:451:4: aliasedExpression ( COMMA aliasedExpression )*
            {
            	root_0 = (IASTNode)adaptor.GetNilNode();

            	PushFollow(FOLLOW_aliasedExpression_in_selectedPropertiesList1710);
            	aliasedExpression123 = aliasedExpression();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, aliasedExpression123.Tree);
            	// /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:451:22: ( COMMA aliasedExpression )*
            	do 
            	{
            	    int alt36 = 2;
            	    int LA36_0 = input.LA(1);

            	    if ( (LA36_0 == COMMA) )
            	    {
            	        alt36 = 1;
            	    }


            	    switch (alt36) 
            		{
            			case 1 :
            			    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:451:24: COMMA aliasedExpression
            			    {
            			    	COMMA124=(IToken)Match(input,COMMA,FOLLOW_COMMA_in_selectedPropertiesList1714); 
            			    	PushFollow(FOLLOW_aliasedExpression_in_selectedPropertiesList1717);
            			    	aliasedExpression125 = aliasedExpression();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, aliasedExpression125.Tree);

            			    }
            			    break;

            			default:
            			    goto loop36;
            	    }
            	} while (true);

            	loop36:
            		;	// Stops C# compiler whining that label 'loop36' has no statements


            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (IASTNode)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (IASTNode)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "selectedPropertiesList"

    public class aliasedExpression_return : ParserRuleReturnScope
    {
        private IASTNode tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (IASTNode) value; }
        }
    };

    // $ANTLR start "aliasedExpression"
    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:454:1: aliasedExpression : expression ( AS identifier )? ;
    public HqlParser.aliasedExpression_return aliasedExpression() // throws RecognitionException [1]
    {   
        HqlParser.aliasedExpression_return retval = new HqlParser.aliasedExpression_return();
        retval.Start = input.LT(1);

        IASTNode root_0 = null;

        IToken AS127 = null;
        HqlParser.expression_return expression126 = default(HqlParser.expression_return);

        HqlParser.identifier_return identifier128 = default(HqlParser.identifier_return);


        IASTNode AS127_tree=null;

        try 
    	{
            // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:455:2: ( expression ( AS identifier )? )
            // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:455:4: expression ( AS identifier )?
            {
            	root_0 = (IASTNode)adaptor.GetNilNode();

            	PushFollow(FOLLOW_expression_in_aliasedExpression1732);
            	expression126 = expression();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, expression126.Tree);
            	// /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:455:15: ( AS identifier )?
            	int alt37 = 2;
            	int LA37_0 = input.LA(1);

            	if ( (LA37_0 == AS) )
            	{
            	    alt37 = 1;
            	}
            	switch (alt37) 
            	{
            	    case 1 :
            	        // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:455:17: AS identifier
            	        {
            	        	AS127=(IToken)Match(input,AS,FOLLOW_AS_in_aliasedExpression1736); 
            	        		AS127_tree = (IASTNode)adaptor.Create(AS127);
            	        		root_0 = (IASTNode)adaptor.BecomeRoot(AS127_tree, root_0);

            	        	PushFollow(FOLLOW_identifier_in_aliasedExpression1739);
            	        	identifier128 = identifier();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, identifier128.Tree);

            	        }
            	        break;

            	}


            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (IASTNode)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (IASTNode)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "aliasedExpression"

    public class logicalExpression_return : ParserRuleReturnScope
    {
        private IASTNode tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (IASTNode) value; }
        }
    };

    // $ANTLR start "logicalExpression"
    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:482:1: logicalExpression : expression ;
    public HqlParser.logicalExpression_return logicalExpression() // throws RecognitionException [1]
    {   
        HqlParser.logicalExpression_return retval = new HqlParser.logicalExpression_return();
        retval.Start = input.LT(1);

        IASTNode root_0 = null;

        HqlParser.expression_return expression129 = default(HqlParser.expression_return);



        try 
    	{
            // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:483:2: ( expression )
            // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:483:4: expression
            {
            	root_0 = (IASTNode)adaptor.GetNilNode();

            	PushFollow(FOLLOW_expression_in_logicalExpression1777);
            	expression129 = expression();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, expression129.Tree);

            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (IASTNode)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (IASTNode)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "logicalExpression"

    public class expression_return : ParserRuleReturnScope
    {
        private IASTNode tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (IASTNode) value; }
        }
    };

    // $ANTLR start "expression"
    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:487:1: expression : logicalOrExpression ;
    public HqlParser.expression_return expression() // throws RecognitionException [1]
    {   
        HqlParser.expression_return retval = new HqlParser.expression_return();
        retval.Start = input.LT(1);

        IASTNode root_0 = null;

        HqlParser.logicalOrExpression_return logicalOrExpression130 = default(HqlParser.logicalOrExpression_return);



        try 
    	{
            // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:488:2: ( logicalOrExpression )
            // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:488:4: logicalOrExpression
            {
            	root_0 = (IASTNode)adaptor.GetNilNode();

            	PushFollow(FOLLOW_logicalOrExpression_in_expression1789);
            	logicalOrExpression130 = logicalOrExpression();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, logicalOrExpression130.Tree);

            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (IASTNode)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (IASTNode)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "expression"

    public class logicalOrExpression_return : ParserRuleReturnScope
    {
        private IASTNode tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (IASTNode) value; }
        }
    };

    // $ANTLR start "logicalOrExpression"
    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:492:1: logicalOrExpression : logicalAndExpression ( OR logicalAndExpression )* ;
    public HqlParser.logicalOrExpression_return logicalOrExpression() // throws RecognitionException [1]
    {   
        HqlParser.logicalOrExpression_return retval = new HqlParser.logicalOrExpression_return();
        retval.Start = input.LT(1);

        IASTNode root_0 = null;

        IToken OR132 = null;
        HqlParser.logicalAndExpression_return logicalAndExpression131 = default(HqlParser.logicalAndExpression_return);

        HqlParser.logicalAndExpression_return logicalAndExpression133 = default(HqlParser.logicalAndExpression_return);


        IASTNode OR132_tree=null;

        try 
    	{
            // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:493:2: ( logicalAndExpression ( OR logicalAndExpression )* )
            // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:493:4: logicalAndExpression ( OR logicalAndExpression )*
            {
            	root_0 = (IASTNode)adaptor.GetNilNode();

            	PushFollow(FOLLOW_logicalAndExpression_in_logicalOrExpression1801);
            	logicalAndExpression131 = logicalAndExpression();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, logicalAndExpression131.Tree);
            	// /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:493:25: ( OR logicalAndExpression )*
            	do 
            	{
            	    int alt38 = 2;
            	    int LA38_0 = input.LA(1);

            	    if ( (LA38_0 == OR) )
            	    {
            	        alt38 = 1;
            	    }


            	    switch (alt38) 
            		{
            			case 1 :
            			    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:493:27: OR logicalAndExpression
            			    {
            			    	OR132=(IToken)Match(input,OR,FOLLOW_OR_in_logicalOrExpression1805); 
            			    		OR132_tree = (IASTNode)adaptor.Create(OR132);
            			    		root_0 = (IASTNode)adaptor.BecomeRoot(OR132_tree, root_0);

            			    	PushFollow(FOLLOW_logicalAndExpression_in_logicalOrExpression1808);
            			    	logicalAndExpression133 = logicalAndExpression();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, logicalAndExpression133.Tree);

            			    }
            			    break;

            			default:
            			    goto loop38;
            	    }
            	} while (true);

            	loop38:
            		;	// Stops C# compiler whining that label 'loop38' has no statements


            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (IASTNode)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (IASTNode)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "logicalOrExpression"

    public class logicalAndExpression_return : ParserRuleReturnScope
    {
        private IASTNode tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (IASTNode) value; }
        }
    };

    // $ANTLR start "logicalAndExpression"
    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:497:1: logicalAndExpression : negatedExpression ( AND negatedExpression )* ;
    public HqlParser.logicalAndExpression_return logicalAndExpression() // throws RecognitionException [1]
    {   
        HqlParser.logicalAndExpression_return retval = new HqlParser.logicalAndExpression_return();
        retval.Start = input.LT(1);

        IASTNode root_0 = null;

        IToken AND135 = null;
        HqlParser.negatedExpression_return negatedExpression134 = default(HqlParser.negatedExpression_return);

        HqlParser.negatedExpression_return negatedExpression136 = default(HqlParser.negatedExpression_return);


        IASTNode AND135_tree=null;

        try 
    	{
            // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:498:2: ( negatedExpression ( AND negatedExpression )* )
            // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:498:4: negatedExpression ( AND negatedExpression )*
            {
            	root_0 = (IASTNode)adaptor.GetNilNode();

            	PushFollow(FOLLOW_negatedExpression_in_logicalAndExpression1823);
            	negatedExpression134 = negatedExpression();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, negatedExpression134.Tree);
            	// /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:498:22: ( AND negatedExpression )*
            	do 
            	{
            	    int alt39 = 2;
            	    int LA39_0 = input.LA(1);

            	    if ( (LA39_0 == AND) )
            	    {
            	        alt39 = 1;
            	    }


            	    switch (alt39) 
            		{
            			case 1 :
            			    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:498:24: AND negatedExpression
            			    {
            			    	AND135=(IToken)Match(input,AND,FOLLOW_AND_in_logicalAndExpression1827); 
            			    		AND135_tree = (IASTNode)adaptor.Create(AND135);
            			    		root_0 = (IASTNode)adaptor.BecomeRoot(AND135_tree, root_0);

            			    	PushFollow(FOLLOW_negatedExpression_in_logicalAndExpression1830);
            			    	negatedExpression136 = negatedExpression();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, negatedExpression136.Tree);

            			    }
            			    break;

            			default:
            			    goto loop39;
            	    }
            	} while (true);

            	loop39:
            		;	// Stops C# compiler whining that label 'loop39' has no statements


            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (IASTNode)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (IASTNode)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "logicalAndExpression"

    public class negatedExpression_return : ParserRuleReturnScope
    {
        private IASTNode tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (IASTNode) value; }
        }
    };

    // $ANTLR start "negatedExpression"
    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:512:1: negatedExpression : ( NOT x= negatedExpression -> ^() | equalityExpression -> ^( equalityExpression ) );
    public HqlParser.negatedExpression_return negatedExpression() // throws RecognitionException [1]
    {   
        HqlParser.negatedExpression_return retval = new HqlParser.negatedExpression_return();
        retval.Start = input.LT(1);

        IASTNode root_0 = null;

        IToken NOT137 = null;
        HqlParser.negatedExpression_return x = default(HqlParser.negatedExpression_return);

        HqlParser.equalityExpression_return equalityExpression138 = default(HqlParser.equalityExpression_return);


        IASTNode NOT137_tree=null;
        RewriteRuleTokenStream stream_NOT = new RewriteRuleTokenStream(adaptor,"token NOT");
        RewriteRuleSubtreeStream stream_negatedExpression = new RewriteRuleSubtreeStream(adaptor,"rule negatedExpression");
        RewriteRuleSubtreeStream stream_equalityExpression = new RewriteRuleSubtreeStream(adaptor,"rule equalityExpression");
         WeakKeywords(); 
        try 
    	{
            // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:514:2: ( NOT x= negatedExpression -> ^() | equalityExpression -> ^( equalityExpression ) )
            int alt40 = 2;
            int LA40_0 = input.LA(1);

            if ( (LA40_0 == NOT) )
            {
                alt40 = 1;
            }
            else if ( ((LA40_0 >= ALL && LA40_0 <= ANY) || LA40_0 == AVG || LA40_0 == COUNT || LA40_0 == ELEMENTS || (LA40_0 >= EXISTS && LA40_0 <= FALSE) || LA40_0 == INDICES || (LA40_0 >= MAX && LA40_0 <= MIN) || LA40_0 == NULL || (LA40_0 >= SOME && LA40_0 <= TRUE) || LA40_0 == CASE || LA40_0 == EMPTY || (LA40_0 >= NUM_INT && LA40_0 <= NUM_LONG) || LA40_0 == OPEN || (LA40_0 >= PLUS && LA40_0 <= MINUS) || (LA40_0 >= COLON && LA40_0 <= IDENT)) )
            {
                alt40 = 2;
            }
            else 
            {
                NoViableAltException nvae_d40s0 =
                    new NoViableAltException("", 40, 0, input);

                throw nvae_d40s0;
            }
            switch (alt40) 
            {
                case 1 :
                    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:514:4: NOT x= negatedExpression
                    {
                    	NOT137=(IToken)Match(input,NOT,FOLLOW_NOT_in_negatedExpression1854);  
                    	stream_NOT.Add(NOT137);

                    	PushFollow(FOLLOW_negatedExpression_in_negatedExpression1858);
                    	x = negatedExpression();
                    	state.followingStackPointer--;

                    	stream_negatedExpression.Add(x.Tree);


                    	// AST REWRITE
                    	// elements:          
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (IASTNode)adaptor.GetNilNode();
                    	// 515:3: -> ^()
                    	{
                    	    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:515:6: ^()
                    	    {
                    	    IASTNode root_1 = (IASTNode)adaptor.GetNilNode();
                    	    root_1 = (IASTNode)adaptor.BecomeRoot(NegateNode(((x != null) ? ((IASTNode)x.Tree) : null)), root_1);

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;
                    }
                    break;
                case 2 :
                    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:516:4: equalityExpression
                    {
                    	PushFollow(FOLLOW_equalityExpression_in_negatedExpression1871);
                    	equalityExpression138 = equalityExpression();
                    	state.followingStackPointer--;

                    	stream_equalityExpression.Add(equalityExpression138.Tree);


                    	// AST REWRITE
                    	// elements:          equalityExpression
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (IASTNode)adaptor.GetNilNode();
                    	// 517:3: -> ^( equalityExpression )
                    	{
                    	    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:517:6: ^( equalityExpression )
                    	    {
                    	    IASTNode root_1 = (IASTNode)adaptor.GetNilNode();
                    	    root_1 = (IASTNode)adaptor.BecomeRoot(stream_equalityExpression.NextNode(), root_1);

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;
                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            	retval.Tree = (IASTNode)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (IASTNode)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "negatedExpression"

    public class equalityExpression_return : ParserRuleReturnScope
    {
        private IASTNode tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (IASTNode) value; }
        }
    };

    // $ANTLR start "equalityExpression"
    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:538:1: equalityExpression : x= relationalExpression ( ( EQ | isx= IS ( NOT )? | NE | ne= SQL_NE ) y= relationalExpression )* ;
    public HqlParser.equalityExpression_return equalityExpression() // throws RecognitionException [1]
    {   
        HqlParser.equalityExpression_return retval = new HqlParser.equalityExpression_return();
        retval.Start = input.LT(1);

        IASTNode root_0 = null;

        IToken isx = null;
        IToken ne = null;
        IToken EQ139 = null;
        IToken NOT140 = null;
        IToken NE141 = null;
        HqlParser.relationalExpression_return x = default(HqlParser.relationalExpression_return);

        HqlParser.relationalExpression_return y = default(HqlParser.relationalExpression_return);


        IASTNode isx_tree=null;
        IASTNode ne_tree=null;
        IASTNode EQ139_tree=null;
        IASTNode NOT140_tree=null;
        IASTNode NE141_tree=null;

        try 
    	{
            // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:543:2: (x= relationalExpression ( ( EQ | isx= IS ( NOT )? | NE | ne= SQL_NE ) y= relationalExpression )* )
            // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:543:4: x= relationalExpression ( ( EQ | isx= IS ( NOT )? | NE | ne= SQL_NE ) y= relationalExpression )*
            {
            	root_0 = (IASTNode)adaptor.GetNilNode();

            	PushFollow(FOLLOW_relationalExpression_in_equalityExpression1903);
            	x = relationalExpression();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, x.Tree);
            	// /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:543:27: ( ( EQ | isx= IS ( NOT )? | NE | ne= SQL_NE ) y= relationalExpression )*
            	do 
            	{
            	    int alt43 = 2;
            	    int LA43_0 = input.LA(1);

            	    if ( (LA43_0 == IS || LA43_0 == EQ || (LA43_0 >= NE && LA43_0 <= SQL_NE)) )
            	    {
            	        alt43 = 1;
            	    }


            	    switch (alt43) 
            		{
            			case 1 :
            			    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:544:3: ( EQ | isx= IS ( NOT )? | NE | ne= SQL_NE ) y= relationalExpression
            			    {
            			    	// /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:544:3: ( EQ | isx= IS ( NOT )? | NE | ne= SQL_NE )
            			    	int alt42 = 4;
            			    	switch ( input.LA(1) ) 
            			    	{
            			    	case EQ:
            			    		{
            			    	    alt42 = 1;
            			    	    }
            			    	    break;
            			    	case IS:
            			    		{
            			    	    alt42 = 2;
            			    	    }
            			    	    break;
            			    	case NE:
            			    		{
            			    	    alt42 = 3;
            			    	    }
            			    	    break;
            			    	case SQL_NE:
            			    		{
            			    	    alt42 = 4;
            			    	    }
            			    	    break;
            			    		default:
            			    		    NoViableAltException nvae_d42s0 =
            			    		        new NoViableAltException("", 42, 0, input);

            			    		    throw nvae_d42s0;
            			    	}

            			    	switch (alt42) 
            			    	{
            			    	    case 1 :
            			    	        // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:544:5: EQ
            			    	        {
            			    	        	EQ139=(IToken)Match(input,EQ,FOLLOW_EQ_in_equalityExpression1911); 
            			    	        		EQ139_tree = (IASTNode)adaptor.Create(EQ139);
            			    	        		root_0 = (IASTNode)adaptor.BecomeRoot(EQ139_tree, root_0);


            			    	        }
            			    	        break;
            			    	    case 2 :
            			    	        // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:545:5: isx= IS ( NOT )?
            			    	        {
            			    	        	isx=(IToken)Match(input,IS,FOLLOW_IS_in_equalityExpression1920); 
            			    	        		isx_tree = (IASTNode)adaptor.Create(isx);
            			    	        		root_0 = (IASTNode)adaptor.BecomeRoot(isx_tree, root_0);

            			    	        	 isx.Type = EQ; 
            			    	        	// /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:545:33: ( NOT )?
            			    	        	int alt41 = 2;
            			    	        	int LA41_0 = input.LA(1);

            			    	        	if ( (LA41_0 == NOT) )
            			    	        	{
            			    	        	    alt41 = 1;
            			    	        	}
            			    	        	switch (alt41) 
            			    	        	{
            			    	        	    case 1 :
            			    	        	        // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:545:34: NOT
            			    	        	        {
            			    	        	        	NOT140=(IToken)Match(input,NOT,FOLLOW_NOT_in_equalityExpression1926); 
            			    	        	        	 isx.Type =NE; 

            			    	        	        }
            			    	        	        break;

            			    	        	}


            			    	        }
            			    	        break;
            			    	    case 3 :
            			    	        // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:546:5: NE
            			    	        {
            			    	        	NE141=(IToken)Match(input,NE,FOLLOW_NE_in_equalityExpression1938); 
            			    	        		NE141_tree = (IASTNode)adaptor.Create(NE141);
            			    	        		root_0 = (IASTNode)adaptor.BecomeRoot(NE141_tree, root_0);


            			    	        }
            			    	        break;
            			    	    case 4 :
            			    	        // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:547:5: ne= SQL_NE
            			    	        {
            			    	        	ne=(IToken)Match(input,SQL_NE,FOLLOW_SQL_NE_in_equalityExpression1947); 
            			    	        		ne_tree = (IASTNode)adaptor.Create(ne);
            			    	        		root_0 = (IASTNode)adaptor.BecomeRoot(ne_tree, root_0);

            			    	        	 ne.Type = NE; 

            			    	        }
            			    	        break;

            			    	}

            			    	PushFollow(FOLLOW_relationalExpression_in_equalityExpression1958);
            			    	y = relationalExpression();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, y.Tree);

            			    }
            			    break;

            			default:
            			    goto loop43;
            	    }
            	} while (true);

            	loop43:
            		;	// Stops C# compiler whining that label 'loop43' has no statements


            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (IASTNode)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);

            			// Post process the equality expression to clean up 'is null', etc.
            			retval.Tree =  ProcessEqualityExpression(((IASTNode)retval.Tree));
            		
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (IASTNode)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "equalityExpression"

    public class relationalExpression_return : ParserRuleReturnScope
    {
        private IASTNode tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (IASTNode) value; }
        }
    };

    // $ANTLR start "relationalExpression"
    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:585:1: relationalExpression : concatenation ( ( ( ( LT | GT | LE | GE ) additiveExpression )* ) | (n= NOT )? ( (i= IN inList ) | (b= BETWEEN betweenList ) | (l= LIKE concatenation likeEscape ) | ( MEMBER ( OF )? p= path ) ) ) ;
    public HqlParser.relationalExpression_return relationalExpression() // throws RecognitionException [1]
    {   
        HqlParser.relationalExpression_return retval = new HqlParser.relationalExpression_return();
        retval.Start = input.LT(1);

        IASTNode root_0 = null;

        IToken n = null;
        IToken i = null;
        IToken b = null;
        IToken l = null;
        IToken LT143 = null;
        IToken GT144 = null;
        IToken LE145 = null;
        IToken GE146 = null;
        IToken MEMBER152 = null;
        IToken OF153 = null;
        HqlParser.path_return p = default(HqlParser.path_return);

        HqlParser.concatenation_return concatenation142 = default(HqlParser.concatenation_return);

        HqlParser.additiveExpression_return additiveExpression147 = default(HqlParser.additiveExpression_return);

        HqlParser.inList_return inList148 = default(HqlParser.inList_return);

        HqlParser.betweenList_return betweenList149 = default(HqlParser.betweenList_return);

        HqlParser.concatenation_return concatenation150 = default(HqlParser.concatenation_return);

        HqlParser.likeEscape_return likeEscape151 = default(HqlParser.likeEscape_return);


        IASTNode n_tree=null;
        IASTNode i_tree=null;
        IASTNode b_tree=null;
        IASTNode l_tree=null;
        IASTNode LT143_tree=null;
        IASTNode GT144_tree=null;
        IASTNode LE145_tree=null;
        IASTNode GE146_tree=null;
        IASTNode MEMBER152_tree=null;
        IASTNode OF153_tree=null;

        try 
    	{
            // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:586:2: ( concatenation ( ( ( ( LT | GT | LE | GE ) additiveExpression )* ) | (n= NOT )? ( (i= IN inList ) | (b= BETWEEN betweenList ) | (l= LIKE concatenation likeEscape ) | ( MEMBER ( OF )? p= path ) ) ) )
            // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:586:4: concatenation ( ( ( ( LT | GT | LE | GE ) additiveExpression )* ) | (n= NOT )? ( (i= IN inList ) | (b= BETWEEN betweenList ) | (l= LIKE concatenation likeEscape ) | ( MEMBER ( OF )? p= path ) ) )
            {
            	root_0 = (IASTNode)adaptor.GetNilNode();

            	PushFollow(FOLLOW_concatenation_in_relationalExpression1977);
            	concatenation142 = concatenation();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, concatenation142.Tree);
            	// /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:586:18: ( ( ( ( LT | GT | LE | GE ) additiveExpression )* ) | (n= NOT )? ( (i= IN inList ) | (b= BETWEEN betweenList ) | (l= LIKE concatenation likeEscape ) | ( MEMBER ( OF )? p= path ) ) )
            	int alt49 = 2;
            	int LA49_0 = input.LA(1);

            	if ( (LA49_0 == EOF || (LA49_0 >= AND && LA49_0 <= ASCENDING) || LA49_0 == DESCENDING || (LA49_0 >= FROM && LA49_0 <= HAVING) || LA49_0 == INNER || (LA49_0 >= IS && LA49_0 <= LEFT) || (LA49_0 >= OR && LA49_0 <= ORDER) || LA49_0 == RIGHT || LA49_0 == UNION || LA49_0 == WHERE || LA49_0 == THEN || (LA49_0 >= COMMA && LA49_0 <= EQ) || (LA49_0 >= CLOSE && LA49_0 <= GE) || LA49_0 == CLOSE_BRACKET || (LA49_0 >= 126 && LA49_0 <= 127)) )
            	{
            	    alt49 = 1;
            	}
            	else if ( (LA49_0 == BETWEEN || LA49_0 == IN || LA49_0 == LIKE || LA49_0 == NOT || LA49_0 == MEMBER) )
            	{
            	    alt49 = 2;
            	}
            	else 
            	{
            	    NoViableAltException nvae_d49s0 =
            	        new NoViableAltException("", 49, 0, input);

            	    throw nvae_d49s0;
            	}
            	switch (alt49) 
            	{
            	    case 1 :
            	        // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:587:3: ( ( ( LT | GT | LE | GE ) additiveExpression )* )
            	        {
            	        	// /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:587:3: ( ( ( LT | GT | LE | GE ) additiveExpression )* )
            	        	// /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:587:5: ( ( LT | GT | LE | GE ) additiveExpression )*
            	        	{
            	        		// /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:587:5: ( ( LT | GT | LE | GE ) additiveExpression )*
            	        		do 
            	        		{
            	        		    int alt45 = 2;
            	        		    int LA45_0 = input.LA(1);

            	        		    if ( ((LA45_0 >= LT && LA45_0 <= GE)) )
            	        		    {
            	        		        alt45 = 1;
            	        		    }


            	        		    switch (alt45) 
            	        			{
            	        				case 1 :
            	        				    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:587:7: ( LT | GT | LE | GE ) additiveExpression
            	        				    {
            	        				    	// /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:587:7: ( LT | GT | LE | GE )
            	        				    	int alt44 = 4;
            	        				    	switch ( input.LA(1) ) 
            	        				    	{
            	        				    	case LT:
            	        				    		{
            	        				    	    alt44 = 1;
            	        				    	    }
            	        				    	    break;
            	        				    	case GT:
            	        				    		{
            	        				    	    alt44 = 2;
            	        				    	    }
            	        				    	    break;
            	        				    	case LE:
            	        				    		{
            	        				    	    alt44 = 3;
            	        				    	    }
            	        				    	    break;
            	        				    	case GE:
            	        				    		{
            	        				    	    alt44 = 4;
            	        				    	    }
            	        				    	    break;
            	        				    		default:
            	        				    		    NoViableAltException nvae_d44s0 =
            	        				    		        new NoViableAltException("", 44, 0, input);

            	        				    		    throw nvae_d44s0;
            	        				    	}

            	        				    	switch (alt44) 
            	        				    	{
            	        				    	    case 1 :
            	        				    	        // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:587:9: LT
            	        				    	        {
            	        				    	        	LT143=(IToken)Match(input,LT,FOLLOW_LT_in_relationalExpression1989); 
            	        				    	        		LT143_tree = (IASTNode)adaptor.Create(LT143);
            	        				    	        		root_0 = (IASTNode)adaptor.BecomeRoot(LT143_tree, root_0);


            	        				    	        }
            	        				    	        break;
            	        				    	    case 2 :
            	        				    	        // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:587:15: GT
            	        				    	        {
            	        				    	        	GT144=(IToken)Match(input,GT,FOLLOW_GT_in_relationalExpression1994); 
            	        				    	        		GT144_tree = (IASTNode)adaptor.Create(GT144);
            	        				    	        		root_0 = (IASTNode)adaptor.BecomeRoot(GT144_tree, root_0);


            	        				    	        }
            	        				    	        break;
            	        				    	    case 3 :
            	        				    	        // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:587:21: LE
            	        				    	        {
            	        				    	        	LE145=(IToken)Match(input,LE,FOLLOW_LE_in_relationalExpression1999); 
            	        				    	        		LE145_tree = (IASTNode)adaptor.Create(LE145);
            	        				    	        		root_0 = (IASTNode)adaptor.BecomeRoot(LE145_tree, root_0);


            	        				    	        }
            	        				    	        break;
            	        				    	    case 4 :
            	        				    	        // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:587:27: GE
            	        				    	        {
            	        				    	        	GE146=(IToken)Match(input,GE,FOLLOW_GE_in_relationalExpression2004); 
            	        				    	        		GE146_tree = (IASTNode)adaptor.Create(GE146);
            	        				    	        		root_0 = (IASTNode)adaptor.BecomeRoot(GE146_tree, root_0);


            	        				    	        }
            	        				    	        break;

            	        				    	}

            	        				    	PushFollow(FOLLOW_additiveExpression_in_relationalExpression2009);
            	        				    	additiveExpression147 = additiveExpression();
            	        				    	state.followingStackPointer--;

            	        				    	adaptor.AddChild(root_0, additiveExpression147.Tree);

            	        				    }
            	        				    break;

            	        				default:
            	        				    goto loop45;
            	        		    }
            	        		} while (true);

            	        		loop45:
            	        			;	// Stops C# compiler whining that label 'loop45' has no statements


            	        	}


            	        }
            	        break;
            	    case 2 :
            	        // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:589:5: (n= NOT )? ( (i= IN inList ) | (b= BETWEEN betweenList ) | (l= LIKE concatenation likeEscape ) | ( MEMBER ( OF )? p= path ) )
            	        {
            	        	// /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:589:5: (n= NOT )?
            	        	int alt46 = 2;
            	        	int LA46_0 = input.LA(1);

            	        	if ( (LA46_0 == NOT) )
            	        	{
            	        	    alt46 = 1;
            	        	}
            	        	switch (alt46) 
            	        	{
            	        	    case 1 :
            	        	        // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:589:6: n= NOT
            	        	        {
            	        	        	n=(IToken)Match(input,NOT,FOLLOW_NOT_in_relationalExpression2026); 

            	        	        }
            	        	        break;

            	        	}

            	        	// /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:589:15: ( (i= IN inList ) | (b= BETWEEN betweenList ) | (l= LIKE concatenation likeEscape ) | ( MEMBER ( OF )? p= path ) )
            	        	int alt48 = 4;
            	        	switch ( input.LA(1) ) 
            	        	{
            	        	case IN:
            	        		{
            	        	    alt48 = 1;
            	        	    }
            	        	    break;
            	        	case BETWEEN:
            	        		{
            	        	    alt48 = 2;
            	        	    }
            	        	    break;
            	        	case LIKE:
            	        		{
            	        	    alt48 = 3;
            	        	    }
            	        	    break;
            	        	case MEMBER:
            	        		{
            	        	    alt48 = 4;
            	        	    }
            	        	    break;
            	        		default:
            	        		    NoViableAltException nvae_d48s0 =
            	        		        new NoViableAltException("", 48, 0, input);

            	        		    throw nvae_d48s0;
            	        	}

            	        	switch (alt48) 
            	        	{
            	        	    case 1 :
            	        	        // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:592:4: (i= IN inList )
            	        	        {
            	        	        	// /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:592:4: (i= IN inList )
            	        	        	// /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:592:5: i= IN inList
            	        	        	{
            	        	        		i=(IToken)Match(input,IN,FOLLOW_IN_in_relationalExpression2047); 
            	        	        			i_tree = (IASTNode)adaptor.Create(i);
            	        	        			root_0 = (IASTNode)adaptor.BecomeRoot(i_tree, root_0);


            	        	        							i.Type = (n == null) ? IN : NOT_IN;
            	        	        							i.Text = (n == null) ? "in" : "not in";
            	        	        						
            	        	        		PushFollow(FOLLOW_inList_in_relationalExpression2056);
            	        	        		inList148 = inList();
            	        	        		state.followingStackPointer--;

            	        	        		adaptor.AddChild(root_0, inList148.Tree);

            	        	        	}


            	        	        }
            	        	        break;
            	        	    case 2 :
            	        	        // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:597:6: (b= BETWEEN betweenList )
            	        	        {
            	        	        	// /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:597:6: (b= BETWEEN betweenList )
            	        	        	// /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:597:7: b= BETWEEN betweenList
            	        	        	{
            	        	        		b=(IToken)Match(input,BETWEEN,FOLLOW_BETWEEN_in_relationalExpression2067); 
            	        	        			b_tree = (IASTNode)adaptor.Create(b);
            	        	        			root_0 = (IASTNode)adaptor.BecomeRoot(b_tree, root_0);


            	        	        							b.Type = (n == null) ? BETWEEN : NOT_BETWEEN;
            	        	        							b.Text = (n == null) ? "between" : "not between";
            	        	        						
            	        	        		PushFollow(FOLLOW_betweenList_in_relationalExpression2076);
            	        	        		betweenList149 = betweenList();
            	        	        		state.followingStackPointer--;

            	        	        		adaptor.AddChild(root_0, betweenList149.Tree);

            	        	        	}


            	        	        }
            	        	        break;
            	        	    case 3 :
            	        	        // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:602:6: (l= LIKE concatenation likeEscape )
            	        	        {
            	        	        	// /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:602:6: (l= LIKE concatenation likeEscape )
            	        	        	// /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:602:7: l= LIKE concatenation likeEscape
            	        	        	{
            	        	        		l=(IToken)Match(input,LIKE,FOLLOW_LIKE_in_relationalExpression2088); 
            	        	        			l_tree = (IASTNode)adaptor.Create(l);
            	        	        			root_0 = (IASTNode)adaptor.BecomeRoot(l_tree, root_0);


            	        	        							l.Type = (n == null) ? LIKE : NOT_LIKE;
            	        	        							l.Text = (n == null) ? "like" : "not like";
            	        	        						
            	        	        		PushFollow(FOLLOW_concatenation_in_relationalExpression2097);
            	        	        		concatenation150 = concatenation();
            	        	        		state.followingStackPointer--;

            	        	        		adaptor.AddChild(root_0, concatenation150.Tree);
            	        	        		PushFollow(FOLLOW_likeEscape_in_relationalExpression2099);
            	        	        		likeEscape151 = likeEscape();
            	        	        		state.followingStackPointer--;

            	        	        		adaptor.AddChild(root_0, likeEscape151.Tree);

            	        	        	}


            	        	        }
            	        	        break;
            	        	    case 4 :
            	        	        // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:607:6: ( MEMBER ( OF )? p= path )
            	        	        {
            	        	        	// /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:607:6: ( MEMBER ( OF )? p= path )
            	        	        	// /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:607:7: MEMBER ( OF )? p= path
            	        	        	{
            	        	        		MEMBER152=(IToken)Match(input,MEMBER,FOLLOW_MEMBER_in_relationalExpression2108); 
            	        	        		// /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:607:15: ( OF )?
            	        	        		int alt47 = 2;
            	        	        		int LA47_0 = input.LA(1);

            	        	        		if ( (LA47_0 == OF) )
            	        	        		{
            	        	        		    alt47 = 1;
            	        	        		}
            	        	        		switch (alt47) 
            	        	        		{
            	        	        		    case 1 :
            	        	        		        // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:607:16: OF
            	        	        		        {
            	        	        		        	OF153=(IToken)Match(input,OF,FOLLOW_OF_in_relationalExpression2112); 

            	        	        		        }
            	        	        		        break;

            	        	        		}

            	        	        		PushFollow(FOLLOW_path_in_relationalExpression2119);
            	        	        		p = path();
            	        	        		state.followingStackPointer--;


            	        	        						root_0 = ProcessMemberOf(n,((p != null) ? ((IASTNode)p.Tree) : null), root_0);
            	        	        					  

            	        	        	}


            	        	        }
            	        	        break;

            	        	}


            	        }
            	        break;

            	}


            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (IASTNode)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (IASTNode)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "relationalExpression"

    public class likeEscape_return : ParserRuleReturnScope
    {
        private IASTNode tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (IASTNode) value; }
        }
    };

    // $ANTLR start "likeEscape"
    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:614:1: likeEscape : ( ESCAPE concatenation )? ;
    public HqlParser.likeEscape_return likeEscape() // throws RecognitionException [1]
    {   
        HqlParser.likeEscape_return retval = new HqlParser.likeEscape_return();
        retval.Start = input.LT(1);

        IASTNode root_0 = null;

        IToken ESCAPE154 = null;
        HqlParser.concatenation_return concatenation155 = default(HqlParser.concatenation_return);


        IASTNode ESCAPE154_tree=null;

        try 
    	{
            // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:615:2: ( ( ESCAPE concatenation )? )
            // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:615:4: ( ESCAPE concatenation )?
            {
            	root_0 = (IASTNode)adaptor.GetNilNode();

            	// /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:615:4: ( ESCAPE concatenation )?
            	int alt50 = 2;
            	int LA50_0 = input.LA(1);

            	if ( (LA50_0 == ESCAPE) )
            	{
            	    alt50 = 1;
            	}
            	switch (alt50) 
            	{
            	    case 1 :
            	        // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:615:5: ESCAPE concatenation
            	        {
            	        	ESCAPE154=(IToken)Match(input,ESCAPE,FOLLOW_ESCAPE_in_likeEscape2146); 
            	        		ESCAPE154_tree = (IASTNode)adaptor.Create(ESCAPE154);
            	        		root_0 = (IASTNode)adaptor.BecomeRoot(ESCAPE154_tree, root_0);

            	        	PushFollow(FOLLOW_concatenation_in_likeEscape2149);
            	        	concatenation155 = concatenation();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, concatenation155.Tree);

            	        }
            	        break;

            	}


            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (IASTNode)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (IASTNode)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "likeEscape"

    public class inList_return : ParserRuleReturnScope
    {
        private IASTNode tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (IASTNode) value; }
        }
    };

    // $ANTLR start "inList"
    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:625:1: inList : compoundExpr -> ^( IN_LIST[\"inList\"] compoundExpr ) ;
    public HqlParser.inList_return inList() // throws RecognitionException [1]
    {   
        HqlParser.inList_return retval = new HqlParser.inList_return();
        retval.Start = input.LT(1);

        IASTNode root_0 = null;

        HqlParser.compoundExpr_return compoundExpr156 = default(HqlParser.compoundExpr_return);


        RewriteRuleSubtreeStream stream_compoundExpr = new RewriteRuleSubtreeStream(adaptor,"rule compoundExpr");
        try 
    	{
            // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:626:2: ( compoundExpr -> ^( IN_LIST[\"inList\"] compoundExpr ) )
            // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:626:4: compoundExpr
            {
            	PushFollow(FOLLOW_compoundExpr_in_inList2164);
            	compoundExpr156 = compoundExpr();
            	state.followingStackPointer--;

            	stream_compoundExpr.Add(compoundExpr156.Tree);


            	// AST REWRITE
            	// elements:          compoundExpr
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (IASTNode)adaptor.GetNilNode();
            	// 627:2: -> ^( IN_LIST[\"inList\"] compoundExpr )
            	{
            	    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:627:5: ^( IN_LIST[\"inList\"] compoundExpr )
            	    {
            	    IASTNode root_1 = (IASTNode)adaptor.GetNilNode();
            	    root_1 = (IASTNode)adaptor.BecomeRoot((IASTNode)adaptor.Create(IN_LIST, "inList"), root_1);

            	    adaptor.AddChild(root_1, stream_compoundExpr.NextTree());

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;
            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (IASTNode)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (IASTNode)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "inList"

    public class betweenList_return : ParserRuleReturnScope
    {
        private IASTNode tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (IASTNode) value; }
        }
    };

    // $ANTLR start "betweenList"
    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:630:1: betweenList : concatenation AND concatenation ;
    public HqlParser.betweenList_return betweenList() // throws RecognitionException [1]
    {   
        HqlParser.betweenList_return retval = new HqlParser.betweenList_return();
        retval.Start = input.LT(1);

        IASTNode root_0 = null;

        IToken AND158 = null;
        HqlParser.concatenation_return concatenation157 = default(HqlParser.concatenation_return);

        HqlParser.concatenation_return concatenation159 = default(HqlParser.concatenation_return);


        IASTNode AND158_tree=null;

        try 
    	{
            // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:631:2: ( concatenation AND concatenation )
            // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:631:4: concatenation AND concatenation
            {
            	root_0 = (IASTNode)adaptor.GetNilNode();

            	PushFollow(FOLLOW_concatenation_in_betweenList2185);
            	concatenation157 = concatenation();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, concatenation157.Tree);
            	AND158=(IToken)Match(input,AND,FOLLOW_AND_in_betweenList2187); 
            	PushFollow(FOLLOW_concatenation_in_betweenList2190);
            	concatenation159 = concatenation();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, concatenation159.Tree);

            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (IASTNode)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (IASTNode)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "betweenList"

    public class concatenation_return : ParserRuleReturnScope
    {
        private IASTNode tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (IASTNode) value; }
        }
    };

    // $ANTLR start "concatenation"
    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:635:1: concatenation : a= additiveExpression (c= CONCAT additiveExpression ( CONCAT additiveExpression )* )? ;
    public HqlParser.concatenation_return concatenation() // throws RecognitionException [1]
    {   
        HqlParser.concatenation_return retval = new HqlParser.concatenation_return();
        retval.Start = input.LT(1);

        IASTNode root_0 = null;

        IToken c = null;
        IToken CONCAT161 = null;
        HqlParser.additiveExpression_return a = default(HqlParser.additiveExpression_return);

        HqlParser.additiveExpression_return additiveExpression160 = default(HqlParser.additiveExpression_return);

        HqlParser.additiveExpression_return additiveExpression162 = default(HqlParser.additiveExpression_return);


        IASTNode c_tree=null;
        IASTNode CONCAT161_tree=null;

        try 
    	{
            // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:646:2: (a= additiveExpression (c= CONCAT additiveExpression ( CONCAT additiveExpression )* )? )
            // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:646:4: a= additiveExpression (c= CONCAT additiveExpression ( CONCAT additiveExpression )* )?
            {
            	root_0 = (IASTNode)adaptor.GetNilNode();

            	PushFollow(FOLLOW_additiveExpression_in_concatenation2209);
            	a = additiveExpression();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, a.Tree);
            	// /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:647:2: (c= CONCAT additiveExpression ( CONCAT additiveExpression )* )?
            	int alt52 = 2;
            	int LA52_0 = input.LA(1);

            	if ( (LA52_0 == CONCAT) )
            	{
            	    alt52 = 1;
            	}
            	switch (alt52) 
            	{
            	    case 1 :
            	        // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:647:4: c= CONCAT additiveExpression ( CONCAT additiveExpression )*
            	        {
            	        	c=(IToken)Match(input,CONCAT,FOLLOW_CONCAT_in_concatenation2217); 
            	        		c_tree = (IASTNode)adaptor.Create(c);
            	        		root_0 = (IASTNode)adaptor.BecomeRoot(c_tree, root_0);

            	        	 c.Type = EXPR_LIST; c.Text = "concatList"; 
            	        	PushFollow(FOLLOW_additiveExpression_in_concatenation2226);
            	        	additiveExpression160 = additiveExpression();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, additiveExpression160.Tree);
            	        	// /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:649:4: ( CONCAT additiveExpression )*
            	        	do 
            	        	{
            	        	    int alt51 = 2;
            	        	    int LA51_0 = input.LA(1);

            	        	    if ( (LA51_0 == CONCAT) )
            	        	    {
            	        	        alt51 = 1;
            	        	    }


            	        	    switch (alt51) 
            	        		{
            	        			case 1 :
            	        			    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:649:6: CONCAT additiveExpression
            	        			    {
            	        			    	CONCAT161=(IToken)Match(input,CONCAT,FOLLOW_CONCAT_in_concatenation2233); 
            	        			    	PushFollow(FOLLOW_additiveExpression_in_concatenation2236);
            	        			    	additiveExpression162 = additiveExpression();
            	        			    	state.followingStackPointer--;

            	        			    	adaptor.AddChild(root_0, additiveExpression162.Tree);

            	        			    }
            	        			    break;

            	        			default:
            	        			    goto loop51;
            	        	    }
            	        	} while (true);

            	        	loop51:
            	        		;	// Stops C# compiler whining that label 'loop51' has no statements


            	        }
            	        break;

            	}


            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (IASTNode)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);

               if (c != null)
               {
                  IASTNode mc = (IASTNode) adaptor.Create(METHOD_CALL, "||");
                  IASTNode concat = (IASTNode) adaptor.Create(IDENT, "concat");
                  mc.AddChild(concat);
                  mc.AddChild((IASTNode) retval.Tree);
                  retval.Tree = mc;
               }

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (IASTNode)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "concatenation"

    public class additiveExpression_return : ParserRuleReturnScope
    {
        private IASTNode tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (IASTNode) value; }
        }
    };

    // $ANTLR start "additiveExpression"
    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:654:1: additiveExpression : multiplyExpression ( ( PLUS | MINUS ) multiplyExpression )* ;
    public HqlParser.additiveExpression_return additiveExpression() // throws RecognitionException [1]
    {   
        HqlParser.additiveExpression_return retval = new HqlParser.additiveExpression_return();
        retval.Start = input.LT(1);

        IASTNode root_0 = null;

        IToken PLUS164 = null;
        IToken MINUS165 = null;
        HqlParser.multiplyExpression_return multiplyExpression163 = default(HqlParser.multiplyExpression_return);

        HqlParser.multiplyExpression_return multiplyExpression166 = default(HqlParser.multiplyExpression_return);


        IASTNode PLUS164_tree=null;
        IASTNode MINUS165_tree=null;

        try 
    	{
            // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:655:2: ( multiplyExpression ( ( PLUS | MINUS ) multiplyExpression )* )
            // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:655:4: multiplyExpression ( ( PLUS | MINUS ) multiplyExpression )*
            {
            	root_0 = (IASTNode)adaptor.GetNilNode();

            	PushFollow(FOLLOW_multiplyExpression_in_additiveExpression2258);
            	multiplyExpression163 = multiplyExpression();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, multiplyExpression163.Tree);
            	// /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:655:23: ( ( PLUS | MINUS ) multiplyExpression )*
            	do 
            	{
            	    int alt54 = 2;
            	    int LA54_0 = input.LA(1);

            	    if ( ((LA54_0 >= PLUS && LA54_0 <= MINUS)) )
            	    {
            	        alt54 = 1;
            	    }


            	    switch (alt54) 
            		{
            			case 1 :
            			    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:655:25: ( PLUS | MINUS ) multiplyExpression
            			    {
            			    	// /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:655:25: ( PLUS | MINUS )
            			    	int alt53 = 2;
            			    	int LA53_0 = input.LA(1);

            			    	if ( (LA53_0 == PLUS) )
            			    	{
            			    	    alt53 = 1;
            			    	}
            			    	else if ( (LA53_0 == MINUS) )
            			    	{
            			    	    alt53 = 2;
            			    	}
            			    	else 
            			    	{
            			    	    NoViableAltException nvae_d53s0 =
            			    	        new NoViableAltException("", 53, 0, input);

            			    	    throw nvae_d53s0;
            			    	}
            			    	switch (alt53) 
            			    	{
            			    	    case 1 :
            			    	        // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:655:27: PLUS
            			    	        {
            			    	        	PLUS164=(IToken)Match(input,PLUS,FOLLOW_PLUS_in_additiveExpression2264); 
            			    	        		PLUS164_tree = (IASTNode)adaptor.Create(PLUS164);
            			    	        		root_0 = (IASTNode)adaptor.BecomeRoot(PLUS164_tree, root_0);


            			    	        }
            			    	        break;
            			    	    case 2 :
            			    	        // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:655:35: MINUS
            			    	        {
            			    	        	MINUS165=(IToken)Match(input,MINUS,FOLLOW_MINUS_in_additiveExpression2269); 
            			    	        		MINUS165_tree = (IASTNode)adaptor.Create(MINUS165);
            			    	        		root_0 = (IASTNode)adaptor.BecomeRoot(MINUS165_tree, root_0);


            			    	        }
            			    	        break;

            			    	}

            			    	PushFollow(FOLLOW_multiplyExpression_in_additiveExpression2274);
            			    	multiplyExpression166 = multiplyExpression();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, multiplyExpression166.Tree);

            			    }
            			    break;

            			default:
            			    goto loop54;
            	    }
            	} while (true);

            	loop54:
            		;	// Stops C# compiler whining that label 'loop54' has no statements


            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (IASTNode)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (IASTNode)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "additiveExpression"

    public class multiplyExpression_return : ParserRuleReturnScope
    {
        private IASTNode tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (IASTNode) value; }
        }
    };

    // $ANTLR start "multiplyExpression"
    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:659:1: multiplyExpression : unaryExpression ( ( STAR | DIV ) unaryExpression )* ;
    public HqlParser.multiplyExpression_return multiplyExpression() // throws RecognitionException [1]
    {   
        HqlParser.multiplyExpression_return retval = new HqlParser.multiplyExpression_return();
        retval.Start = input.LT(1);

        IASTNode root_0 = null;

        IToken STAR168 = null;
        IToken DIV169 = null;
        HqlParser.unaryExpression_return unaryExpression167 = default(HqlParser.unaryExpression_return);

        HqlParser.unaryExpression_return unaryExpression170 = default(HqlParser.unaryExpression_return);


        IASTNode STAR168_tree=null;
        IASTNode DIV169_tree=null;

        try 
    	{
            // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:660:2: ( unaryExpression ( ( STAR | DIV ) unaryExpression )* )
            // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:660:4: unaryExpression ( ( STAR | DIV ) unaryExpression )*
            {
            	root_0 = (IASTNode)adaptor.GetNilNode();

            	PushFollow(FOLLOW_unaryExpression_in_multiplyExpression2289);
            	unaryExpression167 = unaryExpression();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, unaryExpression167.Tree);
            	// /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:660:20: ( ( STAR | DIV ) unaryExpression )*
            	do 
            	{
            	    int alt56 = 2;
            	    int LA56_0 = input.LA(1);

            	    if ( ((LA56_0 >= STAR && LA56_0 <= DIV)) )
            	    {
            	        alt56 = 1;
            	    }


            	    switch (alt56) 
            		{
            			case 1 :
            			    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:660:22: ( STAR | DIV ) unaryExpression
            			    {
            			    	// /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:660:22: ( STAR | DIV )
            			    	int alt55 = 2;
            			    	int LA55_0 = input.LA(1);

            			    	if ( (LA55_0 == STAR) )
            			    	{
            			    	    alt55 = 1;
            			    	}
            			    	else if ( (LA55_0 == DIV) )
            			    	{
            			    	    alt55 = 2;
            			    	}
            			    	else 
            			    	{
            			    	    NoViableAltException nvae_d55s0 =
            			    	        new NoViableAltException("", 55, 0, input);

            			    	    throw nvae_d55s0;
            			    	}
            			    	switch (alt55) 
            			    	{
            			    	    case 1 :
            			    	        // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:660:24: STAR
            			    	        {
            			    	        	STAR168=(IToken)Match(input,STAR,FOLLOW_STAR_in_multiplyExpression2295); 
            			    	        		STAR168_tree = (IASTNode)adaptor.Create(STAR168);
            			    	        		root_0 = (IASTNode)adaptor.BecomeRoot(STAR168_tree, root_0);


            			    	        }
            			    	        break;
            			    	    case 2 :
            			    	        // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:660:32: DIV
            			    	        {
            			    	        	DIV169=(IToken)Match(input,DIV,FOLLOW_DIV_in_multiplyExpression2300); 
            			    	        		DIV169_tree = (IASTNode)adaptor.Create(DIV169);
            			    	        		root_0 = (IASTNode)adaptor.BecomeRoot(DIV169_tree, root_0);


            			    	        }
            			    	        break;

            			    	}

            			    	PushFollow(FOLLOW_unaryExpression_in_multiplyExpression2305);
            			    	unaryExpression170 = unaryExpression();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, unaryExpression170.Tree);

            			    }
            			    break;

            			default:
            			    goto loop56;
            	    }
            	} while (true);

            	loop56:
            		;	// Stops C# compiler whining that label 'loop56' has no statements


            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (IASTNode)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (IASTNode)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "multiplyExpression"

    public class unaryExpression_return : ParserRuleReturnScope
    {
        private IASTNode tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (IASTNode) value; }
        }
    };

    // $ANTLR start "unaryExpression"
    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:674:1: unaryExpression : (m= MINUS mu= unaryExpression -> ^( UNARY_MINUS[$m] $mu) | p= PLUS pu= unaryExpression -> ^( UNARY_PLUS[$p] $pu) | c= caseExpression -> ^( $c) | q= quantifiedExpression -> ^( $q) | a= atom -> ^( $a) );
    public HqlParser.unaryExpression_return unaryExpression() // throws RecognitionException [1]
    {   
        HqlParser.unaryExpression_return retval = new HqlParser.unaryExpression_return();
        retval.Start = input.LT(1);

        IASTNode root_0 = null;

        IToken m = null;
        IToken p = null;
        HqlParser.unaryExpression_return mu = default(HqlParser.unaryExpression_return);

        HqlParser.unaryExpression_return pu = default(HqlParser.unaryExpression_return);

        HqlParser.caseExpression_return c = default(HqlParser.caseExpression_return);

        HqlParser.quantifiedExpression_return q = default(HqlParser.quantifiedExpression_return);

        HqlParser.atom_return a = default(HqlParser.atom_return);


        IASTNode m_tree=null;
        IASTNode p_tree=null;
        RewriteRuleTokenStream stream_MINUS = new RewriteRuleTokenStream(adaptor,"token MINUS");
        RewriteRuleTokenStream stream_PLUS = new RewriteRuleTokenStream(adaptor,"token PLUS");
        RewriteRuleSubtreeStream stream_unaryExpression = new RewriteRuleSubtreeStream(adaptor,"rule unaryExpression");
        RewriteRuleSubtreeStream stream_atom = new RewriteRuleSubtreeStream(adaptor,"rule atom");
        RewriteRuleSubtreeStream stream_quantifiedExpression = new RewriteRuleSubtreeStream(adaptor,"rule quantifiedExpression");
        RewriteRuleSubtreeStream stream_caseExpression = new RewriteRuleSubtreeStream(adaptor,"rule caseExpression");
        try 
    	{
            // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:675:2: (m= MINUS mu= unaryExpression -> ^( UNARY_MINUS[$m] $mu) | p= PLUS pu= unaryExpression -> ^( UNARY_PLUS[$p] $pu) | c= caseExpression -> ^( $c) | q= quantifiedExpression -> ^( $q) | a= atom -> ^( $a) )
            int alt57 = 5;
            switch ( input.LA(1) ) 
            {
            case MINUS:
            	{
                alt57 = 1;
                }
                break;
            case PLUS:
            	{
                alt57 = 2;
                }
                break;
            case CASE:
            	{
                alt57 = 3;
                }
                break;
            case ALL:
            case ANY:
            case EXISTS:
            case SOME:
            	{
                alt57 = 4;
                }
                break;
            case AVG:
            case COUNT:
            case ELEMENTS:
            case FALSE:
            case INDICES:
            case MAX:
            case MIN:
            case NULL:
            case SUM:
            case TRUE:
            case EMPTY:
            case NUM_INT:
            case NUM_DOUBLE:
            case NUM_FLOAT:
            case NUM_LONG:
            case OPEN:
            case COLON:
            case PARAM:
            case QUOTED_String:
            case IDENT:
            	{
                alt57 = 5;
                }
                break;
            	default:
            	    NoViableAltException nvae_d57s0 =
            	        new NoViableAltException("", 57, 0, input);

            	    throw nvae_d57s0;
            }

            switch (alt57) 
            {
                case 1 :
                    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:675:4: m= MINUS mu= unaryExpression
                    {
                    	m=(IToken)Match(input,MINUS,FOLLOW_MINUS_in_unaryExpression2325);  
                    	stream_MINUS.Add(m);

                    	PushFollow(FOLLOW_unaryExpression_in_unaryExpression2329);
                    	mu = unaryExpression();
                    	state.followingStackPointer--;

                    	stream_unaryExpression.Add(mu.Tree);


                    	// AST REWRITE
                    	// elements:          mu
                    	// token labels:      
                    	// rule labels:       mu, retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_mu = new RewriteRuleSubtreeStream(adaptor, "rule mu", mu!=null ? mu.Tree : null);
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (IASTNode)adaptor.GetNilNode();
                    	// 675:31: -> ^( UNARY_MINUS[$m] $mu)
                    	{
                    	    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:675:34: ^( UNARY_MINUS[$m] $mu)
                    	    {
                    	    IASTNode root_1 = (IASTNode)adaptor.GetNilNode();
                    	    root_1 = (IASTNode)adaptor.BecomeRoot((IASTNode)adaptor.Create(UNARY_MINUS, m), root_1);

                    	    adaptor.AddChild(root_1, stream_mu.NextTree());

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;
                    }
                    break;
                case 2 :
                    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:676:4: p= PLUS pu= unaryExpression
                    {
                    	p=(IToken)Match(input,PLUS,FOLLOW_PLUS_in_unaryExpression2346);  
                    	stream_PLUS.Add(p);

                    	PushFollow(FOLLOW_unaryExpression_in_unaryExpression2350);
                    	pu = unaryExpression();
                    	state.followingStackPointer--;

                    	stream_unaryExpression.Add(pu.Tree);


                    	// AST REWRITE
                    	// elements:          pu
                    	// token labels:      
                    	// rule labels:       pu, retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_pu = new RewriteRuleSubtreeStream(adaptor, "rule pu", pu!=null ? pu.Tree : null);
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (IASTNode)adaptor.GetNilNode();
                    	// 676:30: -> ^( UNARY_PLUS[$p] $pu)
                    	{
                    	    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:676:33: ^( UNARY_PLUS[$p] $pu)
                    	    {
                    	    IASTNode root_1 = (IASTNode)adaptor.GetNilNode();
                    	    root_1 = (IASTNode)adaptor.BecomeRoot((IASTNode)adaptor.Create(UNARY_PLUS, p), root_1);

                    	    adaptor.AddChild(root_1, stream_pu.NextTree());

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;
                    }
                    break;
                case 3 :
                    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:677:4: c= caseExpression
                    {
                    	PushFollow(FOLLOW_caseExpression_in_unaryExpression2367);
                    	c = caseExpression();
                    	state.followingStackPointer--;

                    	stream_caseExpression.Add(c.Tree);


                    	// AST REWRITE
                    	// elements:          c
                    	// token labels:      
                    	// rule labels:       c, retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_c = new RewriteRuleSubtreeStream(adaptor, "rule c", c!=null ? c.Tree : null);
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (IASTNode)adaptor.GetNilNode();
                    	// 677:21: -> ^( $c)
                    	{
                    	    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:677:24: ^( $c)
                    	    {
                    	    IASTNode root_1 = (IASTNode)adaptor.GetNilNode();
                    	    root_1 = (IASTNode)adaptor.BecomeRoot(stream_c.NextNode(), root_1);

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;
                    }
                    break;
                case 4 :
                    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:678:4: q= quantifiedExpression
                    {
                    	PushFollow(FOLLOW_quantifiedExpression_in_unaryExpression2381);
                    	q = quantifiedExpression();
                    	state.followingStackPointer--;

                    	stream_quantifiedExpression.Add(q.Tree);


                    	// AST REWRITE
                    	// elements:          q
                    	// token labels:      
                    	// rule labels:       retval, q
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);
                    	RewriteRuleSubtreeStream stream_q = new RewriteRuleSubtreeStream(adaptor, "rule q", q!=null ? q.Tree : null);

                    	root_0 = (IASTNode)adaptor.GetNilNode();
                    	// 678:27: -> ^( $q)
                    	{
                    	    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:678:30: ^( $q)
                    	    {
                    	    IASTNode root_1 = (IASTNode)adaptor.GetNilNode();
                    	    root_1 = (IASTNode)adaptor.BecomeRoot(stream_q.NextNode(), root_1);

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;
                    }
                    break;
                case 5 :
                    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:679:4: a= atom
                    {
                    	PushFollow(FOLLOW_atom_in_unaryExpression2396);
                    	a = atom();
                    	state.followingStackPointer--;

                    	stream_atom.Add(a.Tree);


                    	// AST REWRITE
                    	// elements:          a
                    	// token labels:      
                    	// rule labels:       a, retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_a = new RewriteRuleSubtreeStream(adaptor, "rule a", a!=null ? a.Tree : null);
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (IASTNode)adaptor.GetNilNode();
                    	// 679:11: -> ^( $a)
                    	{
                    	    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:679:14: ^( $a)
                    	    {
                    	    IASTNode root_1 = (IASTNode)adaptor.GetNilNode();
                    	    root_1 = (IASTNode)adaptor.BecomeRoot(stream_a.NextNode(), root_1);

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;
                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            	retval.Tree = (IASTNode)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (IASTNode)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "unaryExpression"

    public class caseExpression_return : ParserRuleReturnScope
    {
        private IASTNode tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (IASTNode) value; }
        }
    };

    // $ANTLR start "caseExpression"
    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:690:1: caseExpression : ( CASE ( whenClause )+ ( elseClause )? END -> ^( CASE whenClause ( elseClause )? ) | CASE unaryExpression ( altWhenClause )+ ( elseClause )? END -> ^( CASE2 unaryExpression ( altWhenClause )+ ( elseClause )? ) );
    public HqlParser.caseExpression_return caseExpression() // throws RecognitionException [1]
    {   
        HqlParser.caseExpression_return retval = new HqlParser.caseExpression_return();
        retval.Start = input.LT(1);

        IASTNode root_0 = null;

        IToken CASE171 = null;
        IToken END174 = null;
        IToken CASE175 = null;
        IToken END179 = null;
        HqlParser.whenClause_return whenClause172 = default(HqlParser.whenClause_return);

        HqlParser.elseClause_return elseClause173 = default(HqlParser.elseClause_return);

        HqlParser.unaryExpression_return unaryExpression176 = default(HqlParser.unaryExpression_return);

        HqlParser.altWhenClause_return altWhenClause177 = default(HqlParser.altWhenClause_return);

        HqlParser.elseClause_return elseClause178 = default(HqlParser.elseClause_return);


        IASTNode CASE171_tree=null;
        IASTNode END174_tree=null;
        IASTNode CASE175_tree=null;
        IASTNode END179_tree=null;
        RewriteRuleTokenStream stream_CASE = new RewriteRuleTokenStream(adaptor,"token CASE");
        RewriteRuleTokenStream stream_END = new RewriteRuleTokenStream(adaptor,"token END");
        RewriteRuleSubtreeStream stream_unaryExpression = new RewriteRuleSubtreeStream(adaptor,"rule unaryExpression");
        RewriteRuleSubtreeStream stream_whenClause = new RewriteRuleSubtreeStream(adaptor,"rule whenClause");
        RewriteRuleSubtreeStream stream_elseClause = new RewriteRuleSubtreeStream(adaptor,"rule elseClause");
        RewriteRuleSubtreeStream stream_altWhenClause = new RewriteRuleSubtreeStream(adaptor,"rule altWhenClause");
        try 
    	{
            // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:691:2: ( CASE ( whenClause )+ ( elseClause )? END -> ^( CASE whenClause ( elseClause )? ) | CASE unaryExpression ( altWhenClause )+ ( elseClause )? END -> ^( CASE2 unaryExpression ( altWhenClause )+ ( elseClause )? ) )
            int alt62 = 2;
            int LA62_0 = input.LA(1);

            if ( (LA62_0 == CASE) )
            {
                int LA62_1 = input.LA(2);

                if ( ((LA62_1 >= ALL && LA62_1 <= ANY) || LA62_1 == AVG || LA62_1 == COUNT || LA62_1 == ELEMENTS || (LA62_1 >= EXISTS && LA62_1 <= FALSE) || LA62_1 == INDICES || (LA62_1 >= MAX && LA62_1 <= MIN) || LA62_1 == NULL || (LA62_1 >= SOME && LA62_1 <= TRUE) || LA62_1 == CASE || LA62_1 == EMPTY || (LA62_1 >= NUM_INT && LA62_1 <= NUM_LONG) || LA62_1 == OPEN || (LA62_1 >= PLUS && LA62_1 <= MINUS) || (LA62_1 >= COLON && LA62_1 <= IDENT)) )
                {
                    alt62 = 2;
                }
                else if ( (LA62_1 == WHEN) )
                {
                    alt62 = 1;
                }
                else 
                {
                    NoViableAltException nvae_d62s1 =
                        new NoViableAltException("", 62, 1, input);

                    throw nvae_d62s1;
                }
            }
            else 
            {
                NoViableAltException nvae_d62s0 =
                    new NoViableAltException("", 62, 0, input);

                throw nvae_d62s0;
            }
            switch (alt62) 
            {
                case 1 :
                    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:691:4: CASE ( whenClause )+ ( elseClause )? END
                    {
                    	CASE171=(IToken)Match(input,CASE,FOLLOW_CASE_in_caseExpression2418);  
                    	stream_CASE.Add(CASE171);

                    	// /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:691:9: ( whenClause )+
                    	int cnt58 = 0;
                    	do 
                    	{
                    	    int alt58 = 2;
                    	    int LA58_0 = input.LA(1);

                    	    if ( (LA58_0 == WHEN) )
                    	    {
                    	        alt58 = 1;
                    	    }


                    	    switch (alt58) 
                    		{
                    			case 1 :
                    			    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:691:10: whenClause
                    			    {
                    			    	PushFollow(FOLLOW_whenClause_in_caseExpression2421);
                    			    	whenClause172 = whenClause();
                    			    	state.followingStackPointer--;

                    			    	stream_whenClause.Add(whenClause172.Tree);

                    			    }
                    			    break;

                    			default:
                    			    if ( cnt58 >= 1 ) goto loop58;
                    		            EarlyExitException eee58 =
                    		                new EarlyExitException(58, input);
                    		            throw eee58;
                    	    }
                    	    cnt58++;
                    	} while (true);

                    	loop58:
                    		;	// Stops C# compiler whinging that label 'loop58' has no statements

                    	// /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:691:23: ( elseClause )?
                    	int alt59 = 2;
                    	int LA59_0 = input.LA(1);

                    	if ( (LA59_0 == ELSE) )
                    	{
                    	    alt59 = 1;
                    	}
                    	switch (alt59) 
                    	{
                    	    case 1 :
                    	        // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:691:24: elseClause
                    	        {
                    	        	PushFollow(FOLLOW_elseClause_in_caseExpression2426);
                    	        	elseClause173 = elseClause();
                    	        	state.followingStackPointer--;

                    	        	stream_elseClause.Add(elseClause173.Tree);

                    	        }
                    	        break;

                    	}

                    	END174=(IToken)Match(input,END,FOLLOW_END_in_caseExpression2430);  
                    	stream_END.Add(END174);



                    	// AST REWRITE
                    	// elements:          whenClause, elseClause, CASE
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (IASTNode)adaptor.GetNilNode();
                    	// 692:3: -> ^( CASE whenClause ( elseClause )? )
                    	{
                    	    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:692:6: ^( CASE whenClause ( elseClause )? )
                    	    {
                    	    IASTNode root_1 = (IASTNode)adaptor.GetNilNode();
                    	    root_1 = (IASTNode)adaptor.BecomeRoot(stream_CASE.NextNode(), root_1);

                    	    adaptor.AddChild(root_1, stream_whenClause.NextTree());
                    	    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:692:24: ( elseClause )?
                    	    if ( stream_elseClause.HasNext() )
                    	    {
                    	        adaptor.AddChild(root_1, stream_elseClause.NextTree());

                    	    }
                    	    stream_elseClause.Reset();

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;
                    }
                    break;
                case 2 :
                    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:693:4: CASE unaryExpression ( altWhenClause )+ ( elseClause )? END
                    {
                    	CASE175=(IToken)Match(input,CASE,FOLLOW_CASE_in_caseExpression2449);  
                    	stream_CASE.Add(CASE175);

                    	PushFollow(FOLLOW_unaryExpression_in_caseExpression2451);
                    	unaryExpression176 = unaryExpression();
                    	state.followingStackPointer--;

                    	stream_unaryExpression.Add(unaryExpression176.Tree);
                    	// /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:693:25: ( altWhenClause )+
                    	int cnt60 = 0;
                    	do 
                    	{
                    	    int alt60 = 2;
                    	    int LA60_0 = input.LA(1);

                    	    if ( (LA60_0 == WHEN) )
                    	    {
                    	        alt60 = 1;
                    	    }


                    	    switch (alt60) 
                    		{
                    			case 1 :
                    			    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:693:26: altWhenClause
                    			    {
                    			    	PushFollow(FOLLOW_altWhenClause_in_caseExpression2454);
                    			    	altWhenClause177 = altWhenClause();
                    			    	state.followingStackPointer--;

                    			    	stream_altWhenClause.Add(altWhenClause177.Tree);

                    			    }
                    			    break;

                    			default:
                    			    if ( cnt60 >= 1 ) goto loop60;
                    		            EarlyExitException eee60 =
                    		                new EarlyExitException(60, input);
                    		            throw eee60;
                    	    }
                    	    cnt60++;
                    	} while (true);

                    	loop60:
                    		;	// Stops C# compiler whinging that label 'loop60' has no statements

                    	// /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:693:42: ( elseClause )?
                    	int alt61 = 2;
                    	int LA61_0 = input.LA(1);

                    	if ( (LA61_0 == ELSE) )
                    	{
                    	    alt61 = 1;
                    	}
                    	switch (alt61) 
                    	{
                    	    case 1 :
                    	        // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:693:43: elseClause
                    	        {
                    	        	PushFollow(FOLLOW_elseClause_in_caseExpression2459);
                    	        	elseClause178 = elseClause();
                    	        	state.followingStackPointer--;

                    	        	stream_elseClause.Add(elseClause178.Tree);

                    	        }
                    	        break;

                    	}

                    	END179=(IToken)Match(input,END,FOLLOW_END_in_caseExpression2463);  
                    	stream_END.Add(END179);



                    	// AST REWRITE
                    	// elements:          altWhenClause, unaryExpression, elseClause
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (IASTNode)adaptor.GetNilNode();
                    	// 694:3: -> ^( CASE2 unaryExpression ( altWhenClause )+ ( elseClause )? )
                    	{
                    	    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:694:6: ^( CASE2 unaryExpression ( altWhenClause )+ ( elseClause )? )
                    	    {
                    	    IASTNode root_1 = (IASTNode)adaptor.GetNilNode();
                    	    root_1 = (IASTNode)adaptor.BecomeRoot((IASTNode)adaptor.Create(CASE2, "CASE2"), root_1);

                    	    adaptor.AddChild(root_1, stream_unaryExpression.NextTree());
                    	    if ( !(stream_altWhenClause.HasNext()) ) {
                    	        throw new RewriteEarlyExitException();
                    	    }
                    	    while ( stream_altWhenClause.HasNext() )
                    	    {
                    	        adaptor.AddChild(root_1, stream_altWhenClause.NextTree());

                    	    }
                    	    stream_altWhenClause.Reset();
                    	    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:694:45: ( elseClause )?
                    	    if ( stream_elseClause.HasNext() )
                    	    {
                    	        adaptor.AddChild(root_1, stream_elseClause.NextTree());

                    	    }
                    	    stream_elseClause.Reset();

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;
                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            	retval.Tree = (IASTNode)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (IASTNode)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "caseExpression"

    public class whenClause_return : ParserRuleReturnScope
    {
        private IASTNode tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (IASTNode) value; }
        }
    };

    // $ANTLR start "whenClause"
    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:697:1: whenClause : ( WHEN logicalExpression THEN unaryExpression ) ;
    public HqlParser.whenClause_return whenClause() // throws RecognitionException [1]
    {   
        HqlParser.whenClause_return retval = new HqlParser.whenClause_return();
        retval.Start = input.LT(1);

        IASTNode root_0 = null;

        IToken WHEN180 = null;
        IToken THEN182 = null;
        HqlParser.logicalExpression_return logicalExpression181 = default(HqlParser.logicalExpression_return);

        HqlParser.unaryExpression_return unaryExpression183 = default(HqlParser.unaryExpression_return);


        IASTNode WHEN180_tree=null;
        IASTNode THEN182_tree=null;

        try 
    	{
            // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:698:2: ( ( WHEN logicalExpression THEN unaryExpression ) )
            // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:698:4: ( WHEN logicalExpression THEN unaryExpression )
            {
            	root_0 = (IASTNode)adaptor.GetNilNode();

            	// /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:698:4: ( WHEN logicalExpression THEN unaryExpression )
            	// /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:698:5: WHEN logicalExpression THEN unaryExpression
            	{
            		WHEN180=(IToken)Match(input,WHEN,FOLLOW_WHEN_in_whenClause2492); 
            			WHEN180_tree = (IASTNode)adaptor.Create(WHEN180);
            			root_0 = (IASTNode)adaptor.BecomeRoot(WHEN180_tree, root_0);

            		PushFollow(FOLLOW_logicalExpression_in_whenClause2495);
            		logicalExpression181 = logicalExpression();
            		state.followingStackPointer--;

            		adaptor.AddChild(root_0, logicalExpression181.Tree);
            		THEN182=(IToken)Match(input,THEN,FOLLOW_THEN_in_whenClause2497); 
            		PushFollow(FOLLOW_unaryExpression_in_whenClause2500);
            		unaryExpression183 = unaryExpression();
            		state.followingStackPointer--;

            		adaptor.AddChild(root_0, unaryExpression183.Tree);

            	}


            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (IASTNode)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (IASTNode)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "whenClause"

    public class altWhenClause_return : ParserRuleReturnScope
    {
        private IASTNode tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (IASTNode) value; }
        }
    };

    // $ANTLR start "altWhenClause"
    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:701:1: altWhenClause : ( WHEN unaryExpression THEN unaryExpression ) ;
    public HqlParser.altWhenClause_return altWhenClause() // throws RecognitionException [1]
    {   
        HqlParser.altWhenClause_return retval = new HqlParser.altWhenClause_return();
        retval.Start = input.LT(1);

        IASTNode root_0 = null;

        IToken WHEN184 = null;
        IToken THEN186 = null;
        HqlParser.unaryExpression_return unaryExpression185 = default(HqlParser.unaryExpression_return);

        HqlParser.unaryExpression_return unaryExpression187 = default(HqlParser.unaryExpression_return);


        IASTNode WHEN184_tree=null;
        IASTNode THEN186_tree=null;

        try 
    	{
            // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:702:2: ( ( WHEN unaryExpression THEN unaryExpression ) )
            // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:702:4: ( WHEN unaryExpression THEN unaryExpression )
            {
            	root_0 = (IASTNode)adaptor.GetNilNode();

            	// /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:702:4: ( WHEN unaryExpression THEN unaryExpression )
            	// /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:702:5: WHEN unaryExpression THEN unaryExpression
            	{
            		WHEN184=(IToken)Match(input,WHEN,FOLLOW_WHEN_in_altWhenClause2514); 
            			WHEN184_tree = (IASTNode)adaptor.Create(WHEN184);
            			root_0 = (IASTNode)adaptor.BecomeRoot(WHEN184_tree, root_0);

            		PushFollow(FOLLOW_unaryExpression_in_altWhenClause2517);
            		unaryExpression185 = unaryExpression();
            		state.followingStackPointer--;

            		adaptor.AddChild(root_0, unaryExpression185.Tree);
            		THEN186=(IToken)Match(input,THEN,FOLLOW_THEN_in_altWhenClause2519); 
            		PushFollow(FOLLOW_unaryExpression_in_altWhenClause2522);
            		unaryExpression187 = unaryExpression();
            		state.followingStackPointer--;

            		adaptor.AddChild(root_0, unaryExpression187.Tree);

            	}


            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (IASTNode)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (IASTNode)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "altWhenClause"

    public class elseClause_return : ParserRuleReturnScope
    {
        private IASTNode tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (IASTNode) value; }
        }
    };

    // $ANTLR start "elseClause"
    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:705:1: elseClause : ( ELSE unaryExpression ) ;
    public HqlParser.elseClause_return elseClause() // throws RecognitionException [1]
    {   
        HqlParser.elseClause_return retval = new HqlParser.elseClause_return();
        retval.Start = input.LT(1);

        IASTNode root_0 = null;

        IToken ELSE188 = null;
        HqlParser.unaryExpression_return unaryExpression189 = default(HqlParser.unaryExpression_return);


        IASTNode ELSE188_tree=null;

        try 
    	{
            // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:706:2: ( ( ELSE unaryExpression ) )
            // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:706:4: ( ELSE unaryExpression )
            {
            	root_0 = (IASTNode)adaptor.GetNilNode();

            	// /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:706:4: ( ELSE unaryExpression )
            	// /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:706:5: ELSE unaryExpression
            	{
            		ELSE188=(IToken)Match(input,ELSE,FOLLOW_ELSE_in_elseClause2536); 
            			ELSE188_tree = (IASTNode)adaptor.Create(ELSE188);
            			root_0 = (IASTNode)adaptor.BecomeRoot(ELSE188_tree, root_0);

            		PushFollow(FOLLOW_unaryExpression_in_elseClause2539);
            		unaryExpression189 = unaryExpression();
            		state.followingStackPointer--;

            		adaptor.AddChild(root_0, unaryExpression189.Tree);

            	}


            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (IASTNode)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (IASTNode)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "elseClause"

    public class quantifiedExpression_return : ParserRuleReturnScope
    {
        private IASTNode tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (IASTNode) value; }
        }
    };

    // $ANTLR start "quantifiedExpression"
    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:709:1: quantifiedExpression : ( SOME | EXISTS | ALL | ANY ) ( identifier | collectionExpr | ( OPEN ( subQuery ) CLOSE ) ) ;
    public HqlParser.quantifiedExpression_return quantifiedExpression() // throws RecognitionException [1]
    {   
        HqlParser.quantifiedExpression_return retval = new HqlParser.quantifiedExpression_return();
        retval.Start = input.LT(1);

        IASTNode root_0 = null;

        IToken SOME190 = null;
        IToken EXISTS191 = null;
        IToken ALL192 = null;
        IToken ANY193 = null;
        IToken OPEN196 = null;
        IToken CLOSE198 = null;
        HqlParser.identifier_return identifier194 = default(HqlParser.identifier_return);

        HqlParser.collectionExpr_return collectionExpr195 = default(HqlParser.collectionExpr_return);

        HqlParser.subQuery_return subQuery197 = default(HqlParser.subQuery_return);


        IASTNode SOME190_tree=null;
        IASTNode EXISTS191_tree=null;
        IASTNode ALL192_tree=null;
        IASTNode ANY193_tree=null;
        IASTNode OPEN196_tree=null;
        IASTNode CLOSE198_tree=null;

        try 
    	{
            // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:710:2: ( ( SOME | EXISTS | ALL | ANY ) ( identifier | collectionExpr | ( OPEN ( subQuery ) CLOSE ) ) )
            // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:710:4: ( SOME | EXISTS | ALL | ANY ) ( identifier | collectionExpr | ( OPEN ( subQuery ) CLOSE ) )
            {
            	root_0 = (IASTNode)adaptor.GetNilNode();

            	// /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:710:4: ( SOME | EXISTS | ALL | ANY )
            	int alt63 = 4;
            	switch ( input.LA(1) ) 
            	{
            	case SOME:
            		{
            	    alt63 = 1;
            	    }
            	    break;
            	case EXISTS:
            		{
            	    alt63 = 2;
            	    }
            	    break;
            	case ALL:
            		{
            	    alt63 = 3;
            	    }
            	    break;
            	case ANY:
            		{
            	    alt63 = 4;
            	    }
            	    break;
            		default:
            		    NoViableAltException nvae_d63s0 =
            		        new NoViableAltException("", 63, 0, input);

            		    throw nvae_d63s0;
            	}

            	switch (alt63) 
            	{
            	    case 1 :
            	        // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:710:6: SOME
            	        {
            	        	SOME190=(IToken)Match(input,SOME,FOLLOW_SOME_in_quantifiedExpression2554); 
            	        		SOME190_tree = (IASTNode)adaptor.Create(SOME190);
            	        		root_0 = (IASTNode)adaptor.BecomeRoot(SOME190_tree, root_0);


            	        }
            	        break;
            	    case 2 :
            	        // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:710:14: EXISTS
            	        {
            	        	EXISTS191=(IToken)Match(input,EXISTS,FOLLOW_EXISTS_in_quantifiedExpression2559); 
            	        		EXISTS191_tree = (IASTNode)adaptor.Create(EXISTS191);
            	        		root_0 = (IASTNode)adaptor.BecomeRoot(EXISTS191_tree, root_0);


            	        }
            	        break;
            	    case 3 :
            	        // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:710:24: ALL
            	        {
            	        	ALL192=(IToken)Match(input,ALL,FOLLOW_ALL_in_quantifiedExpression2564); 
            	        		ALL192_tree = (IASTNode)adaptor.Create(ALL192);
            	        		root_0 = (IASTNode)adaptor.BecomeRoot(ALL192_tree, root_0);


            	        }
            	        break;
            	    case 4 :
            	        // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:710:31: ANY
            	        {
            	        	ANY193=(IToken)Match(input,ANY,FOLLOW_ANY_in_quantifiedExpression2569); 
            	        		ANY193_tree = (IASTNode)adaptor.Create(ANY193);
            	        		root_0 = (IASTNode)adaptor.BecomeRoot(ANY193_tree, root_0);


            	        }
            	        break;

            	}

            	// /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:711:2: ( identifier | collectionExpr | ( OPEN ( subQuery ) CLOSE ) )
            	int alt64 = 3;
            	switch ( input.LA(1) ) 
            	{
            	case IDENT:
            		{
            	    int LA64_1 = input.LA(2);

            	    if ( (LA64_1 == EOF || (LA64_1 >= AND && LA64_1 <= ASCENDING) || LA64_1 == BETWEEN || LA64_1 == DESCENDING || LA64_1 == ESCAPE || (LA64_1 >= FROM && LA64_1 <= IN) || LA64_1 == INNER || (LA64_1 >= IS && LA64_1 <= LIKE) || LA64_1 == NOT || (LA64_1 >= OR && LA64_1 <= ORDER) || LA64_1 == RIGHT || LA64_1 == UNION || LA64_1 == WHERE || (LA64_1 >= END && LA64_1 <= WHEN) || LA64_1 == MEMBER || (LA64_1 >= COMMA && LA64_1 <= EQ) || (LA64_1 >= CLOSE && LA64_1 <= DIV) || LA64_1 == CLOSE_BRACKET || (LA64_1 >= 126 && LA64_1 <= 127)) )
            	    {
            	        alt64 = 1;
            	    }
            	    else if ( (LA64_1 == DOT) )
            	    {
            	        alt64 = 2;
            	    }
            	    else 
            	    {
            	        NoViableAltException nvae_d64s1 =
            	            new NoViableAltException("", 64, 1, input);

            	        throw nvae_d64s1;
            	    }
            	    }
            	    break;
            	case ELEMENTS:
            	case INDICES:
            		{
            	    alt64 = 2;
            	    }
            	    break;
            	case OPEN:
            		{
            	    alt64 = 3;
            	    }
            	    break;
            		default:
            		    NoViableAltException nvae_d64s0 =
            		        new NoViableAltException("", 64, 0, input);

            		    throw nvae_d64s0;
            	}

            	switch (alt64) 
            	{
            	    case 1 :
            	        // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:711:4: identifier
            	        {
            	        	PushFollow(FOLLOW_identifier_in_quantifiedExpression2578);
            	        	identifier194 = identifier();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, identifier194.Tree);

            	        }
            	        break;
            	    case 2 :
            	        // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:711:17: collectionExpr
            	        {
            	        	PushFollow(FOLLOW_collectionExpr_in_quantifiedExpression2582);
            	        	collectionExpr195 = collectionExpr();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, collectionExpr195.Tree);

            	        }
            	        break;
            	    case 3 :
            	        // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:711:34: ( OPEN ( subQuery ) CLOSE )
            	        {
            	        	// /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:711:34: ( OPEN ( subQuery ) CLOSE )
            	        	// /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:711:35: OPEN ( subQuery ) CLOSE
            	        	{
            	        		OPEN196=(IToken)Match(input,OPEN,FOLLOW_OPEN_in_quantifiedExpression2587); 
            	        		// /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:711:41: ( subQuery )
            	        		// /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:711:43: subQuery
            	        		{
            	        			PushFollow(FOLLOW_subQuery_in_quantifiedExpression2592);
            	        			subQuery197 = subQuery();
            	        			state.followingStackPointer--;

            	        			adaptor.AddChild(root_0, subQuery197.Tree);

            	        		}

            	        		CLOSE198=(IToken)Match(input,CLOSE,FOLLOW_CLOSE_in_quantifiedExpression2596); 

            	        	}


            	        }
            	        break;

            	}


            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (IASTNode)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (IASTNode)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "quantifiedExpression"

    public class atom_return : ParserRuleReturnScope
    {
        private IASTNode tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (IASTNode) value; }
        }
    };

    // $ANTLR start "atom"
    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:729:1: atom : primaryExpression ( DOT identifier ( options {greedy=true; } : (op= OPEN exprList CLOSE ) )? | lb= OPEN_BRACKET expression CLOSE_BRACKET )* ;
    public HqlParser.atom_return atom() // throws RecognitionException [1]
    {   
        HqlParser.atom_return retval = new HqlParser.atom_return();
        retval.Start = input.LT(1);

        IASTNode root_0 = null;

        IToken op = null;
        IToken lb = null;
        IToken DOT200 = null;
        IToken CLOSE203 = null;
        IToken CLOSE_BRACKET205 = null;
        HqlParser.primaryExpression_return primaryExpression199 = default(HqlParser.primaryExpression_return);

        HqlParser.identifier_return identifier201 = default(HqlParser.identifier_return);

        HqlParser.exprList_return exprList202 = default(HqlParser.exprList_return);

        HqlParser.expression_return expression204 = default(HqlParser.expression_return);


        IASTNode op_tree=null;
        IASTNode lb_tree=null;
        IASTNode DOT200_tree=null;
        IASTNode CLOSE203_tree=null;
        IASTNode CLOSE_BRACKET205_tree=null;

        try 
    	{
            // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:730:3: ( primaryExpression ( DOT identifier ( options {greedy=true; } : (op= OPEN exprList CLOSE ) )? | lb= OPEN_BRACKET expression CLOSE_BRACKET )* )
            // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:730:5: primaryExpression ( DOT identifier ( options {greedy=true; } : (op= OPEN exprList CLOSE ) )? | lb= OPEN_BRACKET expression CLOSE_BRACKET )*
            {
            	root_0 = (IASTNode)adaptor.GetNilNode();

            	PushFollow(FOLLOW_primaryExpression_in_atom2617);
            	primaryExpression199 = primaryExpression();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, primaryExpression199.Tree);
            	// /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:731:3: ( DOT identifier ( options {greedy=true; } : (op= OPEN exprList CLOSE ) )? | lb= OPEN_BRACKET expression CLOSE_BRACKET )*
            	do 
            	{
            	    int alt66 = 3;
            	    int LA66_0 = input.LA(1);

            	    if ( (LA66_0 == DOT) )
            	    {
            	        alt66 = 1;
            	    }
            	    else if ( (LA66_0 == OPEN_BRACKET) )
            	    {
            	        alt66 = 2;
            	    }


            	    switch (alt66) 
            		{
            			case 1 :
            			    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:732:4: DOT identifier ( options {greedy=true; } : (op= OPEN exprList CLOSE ) )?
            			    {
            			    	DOT200=(IToken)Match(input,DOT,FOLLOW_DOT_in_atom2626); 
            			    		DOT200_tree = (IASTNode)adaptor.Create(DOT200);
            			    		root_0 = (IASTNode)adaptor.BecomeRoot(DOT200_tree, root_0);

            			    	PushFollow(FOLLOW_identifier_in_atom2629);
            			    	identifier201 = identifier();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, identifier201.Tree);
            			    	// /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:733:5: ( options {greedy=true; } : (op= OPEN exprList CLOSE ) )?
            			    	int alt65 = 2;
            			    	int LA65_0 = input.LA(1);

            			    	if ( (LA65_0 == OPEN) )
            			    	{
            			    	    alt65 = 1;
            			    	}
            			    	switch (alt65) 
            			    	{
            			    	    case 1 :
            			    	        // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:734:6: (op= OPEN exprList CLOSE )
            			    	        {
            			    	        	// /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:734:6: (op= OPEN exprList CLOSE )
            			    	        	// /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:734:8: op= OPEN exprList CLOSE
            			    	        	{
            			    	        		op=(IToken)Match(input,OPEN,FOLLOW_OPEN_in_atom2657); 
            			    	        			op_tree = (IASTNode)adaptor.Create(op);
            			    	        			root_0 = (IASTNode)adaptor.BecomeRoot(op_tree, root_0);

            			    	        		op.Type = METHOD_CALL; 
            			    	        		PushFollow(FOLLOW_exprList_in_atom2662);
            			    	        		exprList202 = exprList();
            			    	        		state.followingStackPointer--;

            			    	        		adaptor.AddChild(root_0, exprList202.Tree);
            			    	        		CLOSE203=(IToken)Match(input,CLOSE,FOLLOW_CLOSE_in_atom2664); 

            			    	        	}


            			    	        }
            			    	        break;

            			    	}


            			    }
            			    break;
            			case 2 :
            			    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:735:5: lb= OPEN_BRACKET expression CLOSE_BRACKET
            			    {
            			    	lb=(IToken)Match(input,OPEN_BRACKET,FOLLOW_OPEN_BRACKET_in_atom2678); 
            			    		lb_tree = (IASTNode)adaptor.Create(lb);
            			    		root_0 = (IASTNode)adaptor.BecomeRoot(lb_tree, root_0);

            			    	lb.Type = INDEX_OP; 
            			    	PushFollow(FOLLOW_expression_in_atom2683);
            			    	expression204 = expression();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, expression204.Tree);
            			    	CLOSE_BRACKET205=(IToken)Match(input,CLOSE_BRACKET,FOLLOW_CLOSE_BRACKET_in_atom2685); 

            			    }
            			    break;

            			default:
            			    goto loop66;
            	    }
            	} while (true);

            	loop66:
            		;	// Stops C# compiler whining that label 'loop66' has no statements


            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (IASTNode)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (IASTNode)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "atom"

    public class primaryExpression_return : ParserRuleReturnScope
    {
        private IASTNode tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (IASTNode) value; }
        }
    };

    // $ANTLR start "primaryExpression"
    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:740:1: primaryExpression : ( identPrimary ( options {greedy=true; } : DOT 'class' )? | constant | COLON identifier | OPEN ( expressionOrVector | subQuery ) CLOSE | PARAM ( NUM_INT )? );
    public HqlParser.primaryExpression_return primaryExpression() // throws RecognitionException [1]
    {   
        HqlParser.primaryExpression_return retval = new HqlParser.primaryExpression_return();
        retval.Start = input.LT(1);

        IASTNode root_0 = null;

        IToken DOT207 = null;
        IToken string_literal208 = null;
        IToken COLON210 = null;
        IToken OPEN212 = null;
        IToken CLOSE215 = null;
        IToken PARAM216 = null;
        IToken NUM_INT217 = null;
        HqlParser.identPrimary_return identPrimary206 = default(HqlParser.identPrimary_return);

        HqlParser.constant_return constant209 = default(HqlParser.constant_return);

        HqlParser.identifier_return identifier211 = default(HqlParser.identifier_return);

        HqlParser.expressionOrVector_return expressionOrVector213 = default(HqlParser.expressionOrVector_return);

        HqlParser.subQuery_return subQuery214 = default(HqlParser.subQuery_return);


        IASTNode DOT207_tree=null;
        IASTNode string_literal208_tree=null;
        IASTNode COLON210_tree=null;
        IASTNode OPEN212_tree=null;
        IASTNode CLOSE215_tree=null;
        IASTNode PARAM216_tree=null;
        IASTNode NUM_INT217_tree=null;

        try 
    	{
            // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:741:2: ( identPrimary ( options {greedy=true; } : DOT 'class' )? | constant | COLON identifier | OPEN ( expressionOrVector | subQuery ) CLOSE | PARAM ( NUM_INT )? )
            int alt70 = 5;
            switch ( input.LA(1) ) 
            {
            case AVG:
            case COUNT:
            case ELEMENTS:
            case INDICES:
            case MAX:
            case MIN:
            case SUM:
            case IDENT:
            	{
                alt70 = 1;
                }
                break;
            case FALSE:
            case NULL:
            case TRUE:
            case EMPTY:
            case NUM_INT:
            case NUM_DOUBLE:
            case NUM_FLOAT:
            case NUM_LONG:
            case QUOTED_String:
            	{
                alt70 = 2;
                }
                break;
            case COLON:
            	{
                alt70 = 3;
                }
                break;
            case OPEN:
            	{
                alt70 = 4;
                }
                break;
            case PARAM:
            	{
                alt70 = 5;
                }
                break;
            	default:
            	    NoViableAltException nvae_d70s0 =
            	        new NoViableAltException("", 70, 0, input);

            	    throw nvae_d70s0;
            }

            switch (alt70) 
            {
                case 1 :
                    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:741:6: identPrimary ( options {greedy=true; } : DOT 'class' )?
                    {
                    	root_0 = (IASTNode)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_identPrimary_in_primaryExpression2705);
                    	identPrimary206 = identPrimary();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, identPrimary206.Tree);
                    	// /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:741:19: ( options {greedy=true; } : DOT 'class' )?
                    	int alt67 = 2;
                    	int LA67_0 = input.LA(1);

                    	if ( (LA67_0 == DOT) )
                    	{
                    	    int LA67_1 = input.LA(2);

                    	    if ( (LA67_1 == CLASS) )
                    	    {
                    	        alt67 = 1;
                    	    }
                    	}
                    	switch (alt67) 
                    	{
                    	    case 1 :
                    	        // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:741:46: DOT 'class'
                    	        {
                    	        	DOT207=(IToken)Match(input,DOT,FOLLOW_DOT_in_primaryExpression2718); 
                    	        		DOT207_tree = (IASTNode)adaptor.Create(DOT207);
                    	        		root_0 = (IASTNode)adaptor.BecomeRoot(DOT207_tree, root_0);

                    	        	string_literal208=(IToken)Match(input,CLASS,FOLLOW_CLASS_in_primaryExpression2721); 
                    	        		string_literal208_tree = (IASTNode)adaptor.Create(string_literal208);
                    	        		adaptor.AddChild(root_0, string_literal208_tree);


                    	        }
                    	        break;

                    	}


                    }
                    break;
                case 2 :
                    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:742:6: constant
                    {
                    	root_0 = (IASTNode)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_constant_in_primaryExpression2731);
                    	constant209 = constant();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, constant209.Tree);

                    }
                    break;
                case 3 :
                    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:743:6: COLON identifier
                    {
                    	root_0 = (IASTNode)adaptor.GetNilNode();

                    	COLON210=(IToken)Match(input,COLON,FOLLOW_COLON_in_primaryExpression2738); 
                    		COLON210_tree = (IASTNode)adaptor.Create(COLON210);
                    		root_0 = (IASTNode)adaptor.BecomeRoot(COLON210_tree, root_0);

                    	PushFollow(FOLLOW_identifier_in_primaryExpression2741);
                    	identifier211 = identifier();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, identifier211.Tree);

                    }
                    break;
                case 4 :
                    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:745:6: OPEN ( expressionOrVector | subQuery ) CLOSE
                    {
                    	root_0 = (IASTNode)adaptor.GetNilNode();

                    	OPEN212=(IToken)Match(input,OPEN,FOLLOW_OPEN_in_primaryExpression2750); 
                    	// /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:745:12: ( expressionOrVector | subQuery )
                    	int alt68 = 2;
                    	int LA68_0 = input.LA(1);

                    	if ( ((LA68_0 >= ALL && LA68_0 <= ANY) || LA68_0 == AVG || LA68_0 == COUNT || LA68_0 == ELEMENTS || (LA68_0 >= EXISTS && LA68_0 <= FALSE) || LA68_0 == INDICES || (LA68_0 >= MAX && LA68_0 <= MIN) || (LA68_0 >= NOT && LA68_0 <= NULL) || (LA68_0 >= SOME && LA68_0 <= TRUE) || LA68_0 == CASE || LA68_0 == EMPTY || (LA68_0 >= NUM_INT && LA68_0 <= NUM_LONG) || LA68_0 == OPEN || (LA68_0 >= PLUS && LA68_0 <= MINUS) || (LA68_0 >= COLON && LA68_0 <= IDENT)) )
                    	{
                    	    alt68 = 1;
                    	}
                    	else if ( (LA68_0 == EOF || LA68_0 == FROM || LA68_0 == GROUP || LA68_0 == ORDER || LA68_0 == SELECT || LA68_0 == UNION || LA68_0 == WHERE || LA68_0 == CLOSE) )
                    	{
                    	    alt68 = 2;
                    	}
                    	else 
                    	{
                    	    NoViableAltException nvae_d68s0 =
                    	        new NoViableAltException("", 68, 0, input);

                    	    throw nvae_d68s0;
                    	}
                    	switch (alt68) 
                    	{
                    	    case 1 :
                    	        // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:745:13: expressionOrVector
                    	        {
                    	        	PushFollow(FOLLOW_expressionOrVector_in_primaryExpression2754);
                    	        	expressionOrVector213 = expressionOrVector();
                    	        	state.followingStackPointer--;

                    	        	adaptor.AddChild(root_0, expressionOrVector213.Tree);

                    	        }
                    	        break;
                    	    case 2 :
                    	        // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:745:34: subQuery
                    	        {
                    	        	PushFollow(FOLLOW_subQuery_in_primaryExpression2758);
                    	        	subQuery214 = subQuery();
                    	        	state.followingStackPointer--;

                    	        	adaptor.AddChild(root_0, subQuery214.Tree);

                    	        }
                    	        break;

                    	}

                    	CLOSE215=(IToken)Match(input,CLOSE,FOLLOW_CLOSE_in_primaryExpression2761); 

                    }
                    break;
                case 5 :
                    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:746:6: PARAM ( NUM_INT )?
                    {
                    	root_0 = (IASTNode)adaptor.GetNilNode();

                    	PARAM216=(IToken)Match(input,PARAM,FOLLOW_PARAM_in_primaryExpression2769); 
                    		PARAM216_tree = (IASTNode)adaptor.Create(PARAM216);
                    		root_0 = (IASTNode)adaptor.BecomeRoot(PARAM216_tree, root_0);

                    	// /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:746:13: ( NUM_INT )?
                    	int alt69 = 2;
                    	int LA69_0 = input.LA(1);

                    	if ( (LA69_0 == NUM_INT) )
                    	{
                    	    alt69 = 1;
                    	}
                    	switch (alt69) 
                    	{
                    	    case 1 :
                    	        // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:746:14: NUM_INT
                    	        {
                    	        	NUM_INT217=(IToken)Match(input,NUM_INT,FOLLOW_NUM_INT_in_primaryExpression2773); 
                    	        		NUM_INT217_tree = (IASTNode)adaptor.Create(NUM_INT217);
                    	        		adaptor.AddChild(root_0, NUM_INT217_tree);


                    	        }
                    	        break;

                    	}


                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            	retval.Tree = (IASTNode)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (IASTNode)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "primaryExpression"

    public class expressionOrVector_return : ParserRuleReturnScope
    {
        private IASTNode tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (IASTNode) value; }
        }
    };

    // $ANTLR start "expressionOrVector"
    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:763:1: expressionOrVector : e= expression (v= vectorExpr )? -> {v != null}? ^( VECTOR_EXPR[\"{vector}\"] $e $v) -> ^( $e) ;
    public HqlParser.expressionOrVector_return expressionOrVector() // throws RecognitionException [1]
    {   
        HqlParser.expressionOrVector_return retval = new HqlParser.expressionOrVector_return();
        retval.Start = input.LT(1);

        IASTNode root_0 = null;

        HqlParser.expression_return e = default(HqlParser.expression_return);

        HqlParser.vectorExpr_return v = default(HqlParser.vectorExpr_return);


        RewriteRuleSubtreeStream stream_vectorExpr = new RewriteRuleSubtreeStream(adaptor,"rule vectorExpr");
        RewriteRuleSubtreeStream stream_expression = new RewriteRuleSubtreeStream(adaptor,"rule expression");
        try 
    	{
            // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:764:2: (e= expression (v= vectorExpr )? -> {v != null}? ^( VECTOR_EXPR[\"{vector}\"] $e $v) -> ^( $e) )
            // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:764:4: e= expression (v= vectorExpr )?
            {
            	PushFollow(FOLLOW_expression_in_expressionOrVector2793);
            	e = expression();
            	state.followingStackPointer--;

            	stream_expression.Add(e.Tree);
            	// /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:764:17: (v= vectorExpr )?
            	int alt71 = 2;
            	int LA71_0 = input.LA(1);

            	if ( (LA71_0 == COMMA) )
            	{
            	    alt71 = 1;
            	}
            	switch (alt71) 
            	{
            	    case 1 :
            	        // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:764:19: v= vectorExpr
            	        {
            	        	PushFollow(FOLLOW_vectorExpr_in_expressionOrVector2799);
            	        	v = vectorExpr();
            	        	state.followingStackPointer--;

            	        	stream_vectorExpr.Add(v.Tree);

            	        }
            	        break;

            	}



            	// AST REWRITE
            	// elements:          e, e, v
            	// token labels:      
            	// rule labels:       retval, v, e
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);
            	RewriteRuleSubtreeStream stream_v = new RewriteRuleSubtreeStream(adaptor, "rule v", v!=null ? v.Tree : null);
            	RewriteRuleSubtreeStream stream_e = new RewriteRuleSubtreeStream(adaptor, "rule e", e!=null ? e.Tree : null);

            	root_0 = (IASTNode)adaptor.GetNilNode();
            	// 765:2: -> {v != null}? ^( VECTOR_EXPR[\"{vector}\"] $e $v)
            	if (v != null)
            	{
            	    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:765:18: ^( VECTOR_EXPR[\"{vector}\"] $e $v)
            	    {
            	    IASTNode root_1 = (IASTNode)adaptor.GetNilNode();
            	    root_1 = (IASTNode)adaptor.BecomeRoot((IASTNode)adaptor.Create(VECTOR_EXPR, "{vector}"), root_1);

            	    adaptor.AddChild(root_1, stream_e.NextTree());
            	    adaptor.AddChild(root_1, stream_v.NextTree());

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}
            	else // 766:2: -> ^( $e)
            	{
            	    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:766:5: ^( $e)
            	    {
            	    IASTNode root_1 = (IASTNode)adaptor.GetNilNode();
            	    root_1 = (IASTNode)adaptor.BecomeRoot(stream_e.NextNode(), root_1);

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;
            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (IASTNode)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (IASTNode)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "expressionOrVector"

    public class vectorExpr_return : ParserRuleReturnScope
    {
        private IASTNode tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (IASTNode) value; }
        }
    };

    // $ANTLR start "vectorExpr"
    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:769:1: vectorExpr : COMMA expression ( COMMA expression )* ;
    public HqlParser.vectorExpr_return vectorExpr() // throws RecognitionException [1]
    {   
        HqlParser.vectorExpr_return retval = new HqlParser.vectorExpr_return();
        retval.Start = input.LT(1);

        IASTNode root_0 = null;

        IToken COMMA218 = null;
        IToken COMMA220 = null;
        HqlParser.expression_return expression219 = default(HqlParser.expression_return);

        HqlParser.expression_return expression221 = default(HqlParser.expression_return);


        IASTNode COMMA218_tree=null;
        IASTNode COMMA220_tree=null;

        try 
    	{
            // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:770:2: ( COMMA expression ( COMMA expression )* )
            // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:770:4: COMMA expression ( COMMA expression )*
            {
            	root_0 = (IASTNode)adaptor.GetNilNode();

            	COMMA218=(IToken)Match(input,COMMA,FOLLOW_COMMA_in_vectorExpr2838); 
            	PushFollow(FOLLOW_expression_in_vectorExpr2841);
            	expression219 = expression();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, expression219.Tree);
            	// /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:770:22: ( COMMA expression )*
            	do 
            	{
            	    int alt72 = 2;
            	    int LA72_0 = input.LA(1);

            	    if ( (LA72_0 == COMMA) )
            	    {
            	        alt72 = 1;
            	    }


            	    switch (alt72) 
            		{
            			case 1 :
            			    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:770:23: COMMA expression
            			    {
            			    	COMMA220=(IToken)Match(input,COMMA,FOLLOW_COMMA_in_vectorExpr2844); 
            			    	PushFollow(FOLLOW_expression_in_vectorExpr2847);
            			    	expression221 = expression();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, expression221.Tree);

            			    }
            			    break;

            			default:
            			    goto loop72;
            	    }
            	} while (true);

            	loop72:
            		;	// Stops C# compiler whining that label 'loop72' has no statements


            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (IASTNode)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (IASTNode)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "vectorExpr"

    public class identPrimary_return : ParserRuleReturnScope
    {
        private IASTNode tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (IASTNode) value; }
        }
    };

    // $ANTLR start "identPrimary"
    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:788:1: identPrimary : ( identifier ( options {greedy=true; } : DOT ( identifier | o= OBJECT ) )* ( (op= OPEN exprList CLOSE ) )? | aggregate );
    public HqlParser.identPrimary_return identPrimary() // throws RecognitionException [1]
    {   
        HqlParser.identPrimary_return retval = new HqlParser.identPrimary_return();
        retval.Start = input.LT(1);

        IASTNode root_0 = null;

        IToken o = null;
        IToken op = null;
        IToken DOT223 = null;
        IToken CLOSE226 = null;
        HqlParser.identifier_return identifier222 = default(HqlParser.identifier_return);

        HqlParser.identifier_return identifier224 = default(HqlParser.identifier_return);

        HqlParser.exprList_return exprList225 = default(HqlParser.exprList_return);

        HqlParser.aggregate_return aggregate227 = default(HqlParser.aggregate_return);


        IASTNode o_tree=null;
        IASTNode op_tree=null;
        IASTNode DOT223_tree=null;
        IASTNode CLOSE226_tree=null;


        HandleDotIdent2();

        try 
    	{
            // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:792:2: ( identifier ( options {greedy=true; } : DOT ( identifier | o= OBJECT ) )* ( (op= OPEN exprList CLOSE ) )? | aggregate )
            int alt76 = 2;
            alt76 = dfa76.Predict(input);
            switch (alt76) 
            {
                case 1 :
                    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:792:4: identifier ( options {greedy=true; } : DOT ( identifier | o= OBJECT ) )* ( (op= OPEN exprList CLOSE ) )?
                    {
                    	root_0 = (IASTNode)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_identifier_in_identPrimary2870);
                    	identifier222 = identifier();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, identifier222.Tree);
                    	 HandleDotIdent(); 
                    	// /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:793:4: ( options {greedy=true; } : DOT ( identifier | o= OBJECT ) )*
                    	do 
                    	{
                    	    int alt74 = 2;
                    	    int LA74_0 = input.LA(1);

                    	    if ( (LA74_0 == DOT) )
                    	    {
                    	        int LA74_2 = input.LA(2);

                    	        if ( (LA74_2 == OBJECT || LA74_2 == IDENT) )
                    	        {
                    	            alt74 = 1;
                    	        }


                    	    }


                    	    switch (alt74) 
                    		{
                    			case 1 :
                    			    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:793:31: DOT ( identifier | o= OBJECT )
                    			    {
                    			    	DOT223=(IToken)Match(input,DOT,FOLLOW_DOT_in_identPrimary2888); 
                    			    		DOT223_tree = (IASTNode)adaptor.Create(DOT223);
                    			    		root_0 = (IASTNode)adaptor.BecomeRoot(DOT223_tree, root_0);

                    			    	// /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:793:36: ( identifier | o= OBJECT )
                    			    	int alt73 = 2;
                    			    	int LA73_0 = input.LA(1);

                    			    	if ( (LA73_0 == IDENT) )
                    			    	{
                    			    	    alt73 = 1;
                    			    	}
                    			    	else if ( (LA73_0 == OBJECT) )
                    			    	{
                    			    	    alt73 = 2;
                    			    	}
                    			    	else 
                    			    	{
                    			    	    NoViableAltException nvae_d73s0 =
                    			    	        new NoViableAltException("", 73, 0, input);

                    			    	    throw nvae_d73s0;
                    			    	}
                    			    	switch (alt73) 
                    			    	{
                    			    	    case 1 :
                    			    	        // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:793:38: identifier
                    			    	        {
                    			    	        	PushFollow(FOLLOW_identifier_in_identPrimary2893);
                    			    	        	identifier224 = identifier();
                    			    	        	state.followingStackPointer--;

                    			    	        	adaptor.AddChild(root_0, identifier224.Tree);

                    			    	        }
                    			    	        break;
                    			    	    case 2 :
                    			    	        // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:793:51: o= OBJECT
                    			    	        {
                    			    	        	o=(IToken)Match(input,OBJECT,FOLLOW_OBJECT_in_identPrimary2899); 
                    			    	        		o_tree = (IASTNode)adaptor.Create(o);
                    			    	        		adaptor.AddChild(root_0, o_tree);

                    			    	        	 o.Type = IDENT; 

                    			    	        }
                    			    	        break;

                    			    	}


                    			    }
                    			    break;

                    			default:
                    			    goto loop74;
                    	    }
                    	} while (true);

                    	loop74:
                    		;	// Stops C# compiler whining that label 'loop74' has no statements

                    	// /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:794:4: ( (op= OPEN exprList CLOSE ) )?
                    	int alt75 = 2;
                    	int LA75_0 = input.LA(1);

                    	if ( (LA75_0 == OPEN) )
                    	{
                    	    alt75 = 1;
                    	}
                    	switch (alt75) 
                    	{
                    	    case 1 :
                    	        // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:794:6: (op= OPEN exprList CLOSE )
                    	        {
                    	        	// /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:794:6: (op= OPEN exprList CLOSE )
                    	        	// /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:794:8: op= OPEN exprList CLOSE
                    	        	{
                    	        		op=(IToken)Match(input,OPEN,FOLLOW_OPEN_in_identPrimary2917); 
                    	        			op_tree = (IASTNode)adaptor.Create(op);
                    	        			root_0 = (IASTNode)adaptor.BecomeRoot(op_tree, root_0);

                    	        		 op.Type = METHOD_CALL;
                    	        		PushFollow(FOLLOW_exprList_in_identPrimary2922);
                    	        		exprList225 = exprList();
                    	        		state.followingStackPointer--;

                    	        		adaptor.AddChild(root_0, exprList225.Tree);
                    	        		CLOSE226=(IToken)Match(input,CLOSE,FOLLOW_CLOSE_in_identPrimary2924); 

                    	        	}


                    	        }
                    	        break;

                    	}


                    }
                    break;
                case 2 :
                    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:797:4: aggregate
                    {
                    	root_0 = (IASTNode)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_aggregate_in_identPrimary2940);
                    	aggregate227 = aggregate();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, aggregate227.Tree);

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            	retval.Tree = (IASTNode)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (IASTNode)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "identPrimary"

    public class aggregate_return : ParserRuleReturnScope
    {
        private IASTNode tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (IASTNode) value; }
        }
    };

    // $ANTLR start "aggregate"
    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:814:1: aggregate : ( (op= SUM | op= AVG | op= MAX | op= MIN ) OPEN additiveExpression CLOSE -> ^( AGGREGATE[$op] additiveExpression ) | COUNT OPEN (s= STAR | p= aggregateDistinctAll ) CLOSE -> {s == null}? ^( COUNT $p) -> ^( COUNT ^( ROW_STAR[\"*\"] ) ) | collectionExpr );
    public HqlParser.aggregate_return aggregate() // throws RecognitionException [1]
    {   
        HqlParser.aggregate_return retval = new HqlParser.aggregate_return();
        retval.Start = input.LT(1);

        IASTNode root_0 = null;

        IToken op = null;
        IToken s = null;
        IToken OPEN228 = null;
        IToken CLOSE230 = null;
        IToken COUNT231 = null;
        IToken OPEN232 = null;
        IToken CLOSE233 = null;
        HqlParser.aggregateDistinctAll_return p = default(HqlParser.aggregateDistinctAll_return);

        HqlParser.additiveExpression_return additiveExpression229 = default(HqlParser.additiveExpression_return);

        HqlParser.collectionExpr_return collectionExpr234 = default(HqlParser.collectionExpr_return);


        IASTNode op_tree=null;
        IASTNode s_tree=null;
        IASTNode OPEN228_tree=null;
        IASTNode CLOSE230_tree=null;
        IASTNode COUNT231_tree=null;
        IASTNode OPEN232_tree=null;
        IASTNode CLOSE233_tree=null;
        RewriteRuleTokenStream stream_CLOSE = new RewriteRuleTokenStream(adaptor,"token CLOSE");
        RewriteRuleTokenStream stream_AVG = new RewriteRuleTokenStream(adaptor,"token AVG");
        RewriteRuleTokenStream stream_MAX = new RewriteRuleTokenStream(adaptor,"token MAX");
        RewriteRuleTokenStream stream_MIN = new RewriteRuleTokenStream(adaptor,"token MIN");
        RewriteRuleTokenStream stream_STAR = new RewriteRuleTokenStream(adaptor,"token STAR");
        RewriteRuleTokenStream stream_SUM = new RewriteRuleTokenStream(adaptor,"token SUM");
        RewriteRuleTokenStream stream_OPEN = new RewriteRuleTokenStream(adaptor,"token OPEN");
        RewriteRuleTokenStream stream_COUNT = new RewriteRuleTokenStream(adaptor,"token COUNT");
        RewriteRuleSubtreeStream stream_aggregateDistinctAll = new RewriteRuleSubtreeStream(adaptor,"rule aggregateDistinctAll");
        RewriteRuleSubtreeStream stream_additiveExpression = new RewriteRuleSubtreeStream(adaptor,"rule additiveExpression");
        try 
    	{
            // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:815:2: ( (op= SUM | op= AVG | op= MAX | op= MIN ) OPEN additiveExpression CLOSE -> ^( AGGREGATE[$op] additiveExpression ) | COUNT OPEN (s= STAR | p= aggregateDistinctAll ) CLOSE -> {s == null}? ^( COUNT $p) -> ^( COUNT ^( ROW_STAR[\"*\"] ) ) | collectionExpr )
            int alt79 = 3;
            switch ( input.LA(1) ) 
            {
            case AVG:
            case MAX:
            case MIN:
            case SUM:
            	{
                alt79 = 1;
                }
                break;
            case COUNT:
            	{
                alt79 = 2;
                }
                break;
            case ELEMENTS:
            case INDICES:
            case IDENT:
            	{
                alt79 = 3;
                }
                break;
            	default:
            	    NoViableAltException nvae_d79s0 =
            	        new NoViableAltException("", 79, 0, input);

            	    throw nvae_d79s0;
            }

            switch (alt79) 
            {
                case 1 :
                    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:815:4: (op= SUM | op= AVG | op= MAX | op= MIN ) OPEN additiveExpression CLOSE
                    {
                    	// /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:815:4: (op= SUM | op= AVG | op= MAX | op= MIN )
                    	int alt77 = 4;
                    	switch ( input.LA(1) ) 
                    	{
                    	case SUM:
                    		{
                    	    alt77 = 1;
                    	    }
                    	    break;
                    	case AVG:
                    		{
                    	    alt77 = 2;
                    	    }
                    	    break;
                    	case MAX:
                    		{
                    	    alt77 = 3;
                    	    }
                    	    break;
                    	case MIN:
                    		{
                    	    alt77 = 4;
                    	    }
                    	    break;
                    		default:
                    		    NoViableAltException nvae_d77s0 =
                    		        new NoViableAltException("", 77, 0, input);

                    		    throw nvae_d77s0;
                    	}

                    	switch (alt77) 
                    	{
                    	    case 1 :
                    	        // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:815:6: op= SUM
                    	        {
                    	        	op=(IToken)Match(input,SUM,FOLLOW_SUM_in_aggregate2963);  
                    	        	stream_SUM.Add(op);


                    	        }
                    	        break;
                    	    case 2 :
                    	        // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:815:15: op= AVG
                    	        {
                    	        	op=(IToken)Match(input,AVG,FOLLOW_AVG_in_aggregate2969);  
                    	        	stream_AVG.Add(op);


                    	        }
                    	        break;
                    	    case 3 :
                    	        // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:815:24: op= MAX
                    	        {
                    	        	op=(IToken)Match(input,MAX,FOLLOW_MAX_in_aggregate2975);  
                    	        	stream_MAX.Add(op);


                    	        }
                    	        break;
                    	    case 4 :
                    	        // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:815:33: op= MIN
                    	        {
                    	        	op=(IToken)Match(input,MIN,FOLLOW_MIN_in_aggregate2981);  
                    	        	stream_MIN.Add(op);


                    	        }
                    	        break;

                    	}

                    	OPEN228=(IToken)Match(input,OPEN,FOLLOW_OPEN_in_aggregate2985);  
                    	stream_OPEN.Add(OPEN228);

                    	PushFollow(FOLLOW_additiveExpression_in_aggregate2987);
                    	additiveExpression229 = additiveExpression();
                    	state.followingStackPointer--;

                    	stream_additiveExpression.Add(additiveExpression229.Tree);
                    	CLOSE230=(IToken)Match(input,CLOSE,FOLLOW_CLOSE_in_aggregate2989);  
                    	stream_CLOSE.Add(CLOSE230);



                    	// AST REWRITE
                    	// elements:          additiveExpression
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (IASTNode)adaptor.GetNilNode();
                    	// 816:3: -> ^( AGGREGATE[$op] additiveExpression )
                    	{
                    	    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:816:6: ^( AGGREGATE[$op] additiveExpression )
                    	    {
                    	    IASTNode root_1 = (IASTNode)adaptor.GetNilNode();
                    	    root_1 = (IASTNode)adaptor.BecomeRoot((IASTNode)adaptor.Create(AGGREGATE, op), root_1);

                    	    adaptor.AddChild(root_1, stream_additiveExpression.NextTree());

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;
                    }
                    break;
                case 2 :
                    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:818:5: COUNT OPEN (s= STAR | p= aggregateDistinctAll ) CLOSE
                    {
                    	COUNT231=(IToken)Match(input,COUNT,FOLLOW_COUNT_in_aggregate3008);  
                    	stream_COUNT.Add(COUNT231);

                    	OPEN232=(IToken)Match(input,OPEN,FOLLOW_OPEN_in_aggregate3010);  
                    	stream_OPEN.Add(OPEN232);

                    	// /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:818:16: (s= STAR | p= aggregateDistinctAll )
                    	int alt78 = 2;
                    	int LA78_0 = input.LA(1);

                    	if ( (LA78_0 == STAR) )
                    	{
                    	    alt78 = 1;
                    	}
                    	else if ( (LA78_0 == ALL || (LA78_0 >= DISTINCT && LA78_0 <= ELEMENTS) || LA78_0 == INDICES || LA78_0 == IDENT) )
                    	{
                    	    alt78 = 2;
                    	}
                    	else 
                    	{
                    	    NoViableAltException nvae_d78s0 =
                    	        new NoViableAltException("", 78, 0, input);

                    	    throw nvae_d78s0;
                    	}
                    	switch (alt78) 
                    	{
                    	    case 1 :
                    	        // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:818:18: s= STAR
                    	        {
                    	        	s=(IToken)Match(input,STAR,FOLLOW_STAR_in_aggregate3016);  
                    	        	stream_STAR.Add(s);


                    	        }
                    	        break;
                    	    case 2 :
                    	        // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:818:27: p= aggregateDistinctAll
                    	        {
                    	        	PushFollow(FOLLOW_aggregateDistinctAll_in_aggregate3022);
                    	        	p = aggregateDistinctAll();
                    	        	state.followingStackPointer--;

                    	        	stream_aggregateDistinctAll.Add(p.Tree);

                    	        }
                    	        break;

                    	}

                    	CLOSE233=(IToken)Match(input,CLOSE,FOLLOW_CLOSE_in_aggregate3026);  
                    	stream_CLOSE.Add(CLOSE233);



                    	// AST REWRITE
                    	// elements:          p, COUNT, COUNT
                    	// token labels:      
                    	// rule labels:       p, retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_p = new RewriteRuleSubtreeStream(adaptor, "rule p", p!=null ? p.Tree : null);
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (IASTNode)adaptor.GetNilNode();
                    	// 819:3: -> {s == null}? ^( COUNT $p)
                    	if (s == null)
                    	{
                    	    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:819:19: ^( COUNT $p)
                    	    {
                    	    IASTNode root_1 = (IASTNode)adaptor.GetNilNode();
                    	    root_1 = (IASTNode)adaptor.BecomeRoot(stream_COUNT.NextNode(), root_1);

                    	    adaptor.AddChild(root_1, stream_p.NextTree());

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}
                    	else // 820:3: -> ^( COUNT ^( ROW_STAR[\"*\"] ) )
                    	{
                    	    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:820:6: ^( COUNT ^( ROW_STAR[\"*\"] ) )
                    	    {
                    	    IASTNode root_1 = (IASTNode)adaptor.GetNilNode();
                    	    root_1 = (IASTNode)adaptor.BecomeRoot(stream_COUNT.NextNode(), root_1);

                    	    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:820:14: ^( ROW_STAR[\"*\"] )
                    	    {
                    	    IASTNode root_2 = (IASTNode)adaptor.GetNilNode();
                    	    root_2 = (IASTNode)adaptor.BecomeRoot((IASTNode)adaptor.Create(ROW_STAR, "*"), root_2);

                    	    adaptor.AddChild(root_1, root_2);
                    	    }

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;
                    }
                    break;
                case 3 :
                    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:821:5: collectionExpr
                    {
                    	root_0 = (IASTNode)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_collectionExpr_in_aggregate3058);
                    	collectionExpr234 = collectionExpr();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, collectionExpr234.Tree);

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            	retval.Tree = (IASTNode)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (IASTNode)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "aggregate"

    public class aggregateDistinctAll_return : ParserRuleReturnScope
    {
        private IASTNode tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (IASTNode) value; }
        }
    };

    // $ANTLR start "aggregateDistinctAll"
    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:824:1: aggregateDistinctAll : ( ( DISTINCT | ALL )? ( path | collectionExpr ) ) ;
    public HqlParser.aggregateDistinctAll_return aggregateDistinctAll() // throws RecognitionException [1]
    {   
        HqlParser.aggregateDistinctAll_return retval = new HqlParser.aggregateDistinctAll_return();
        retval.Start = input.LT(1);

        IASTNode root_0 = null;

        IToken set235 = null;
        HqlParser.path_return path236 = default(HqlParser.path_return);

        HqlParser.collectionExpr_return collectionExpr237 = default(HqlParser.collectionExpr_return);


        IASTNode set235_tree=null;

        try 
    	{
            // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:825:2: ( ( ( DISTINCT | ALL )? ( path | collectionExpr ) ) )
            // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:825:4: ( ( DISTINCT | ALL )? ( path | collectionExpr ) )
            {
            	root_0 = (IASTNode)adaptor.GetNilNode();

            	// /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:825:4: ( ( DISTINCT | ALL )? ( path | collectionExpr ) )
            	// /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:825:6: ( DISTINCT | ALL )? ( path | collectionExpr )
            	{
            		// /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:825:6: ( DISTINCT | ALL )?
            		int alt80 = 2;
            		int LA80_0 = input.LA(1);

            		if ( (LA80_0 == ALL || LA80_0 == DISTINCT) )
            		{
            		    alt80 = 1;
            		}
            		switch (alt80) 
            		{
            		    case 1 :
            		        // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:
            		        {
            		        	set235 = (IToken)input.LT(1);
            		        	if ( input.LA(1) == ALL || input.LA(1) == DISTINCT ) 
            		        	{
            		        	    input.Consume();
            		        	    adaptor.AddChild(root_0, (IASTNode)adaptor.Create(set235));
            		        	    state.errorRecovery = false;
            		        	}
            		        	else 
            		        	{
            		        	    MismatchedSetException mse = new MismatchedSetException(null,input);
            		        	    throw mse;
            		        	}


            		        }
            		        break;

            		}

            		// /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:825:26: ( path | collectionExpr )
            		int alt81 = 2;
            		alt81 = dfa81.Predict(input);
            		switch (alt81) 
            		{
            		    case 1 :
            		        // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:825:28: path
            		        {
            		        	PushFollow(FOLLOW_path_in_aggregateDistinctAll3084);
            		        	path236 = path();
            		        	state.followingStackPointer--;

            		        	adaptor.AddChild(root_0, path236.Tree);

            		        }
            		        break;
            		    case 2 :
            		        // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:825:35: collectionExpr
            		        {
            		        	PushFollow(FOLLOW_collectionExpr_in_aggregateDistinctAll3088);
            		        	collectionExpr237 = collectionExpr();
            		        	state.followingStackPointer--;

            		        	adaptor.AddChild(root_0, collectionExpr237.Tree);

            		        }
            		        break;

            		}


            	}


            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (IASTNode)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (IASTNode)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "aggregateDistinctAll"

    public class collectionExpr_return : ParserRuleReturnScope
    {
        private IASTNode tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (IASTNode) value; }
        }
    };

    // $ANTLR start "collectionExpr"
    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:830:1: collectionExpr : ( ( ELEMENTS | INDICES ) OPEN path CLOSE | path DOT ELEMENTS );
    public HqlParser.collectionExpr_return collectionExpr() // throws RecognitionException [1]
    {   
        HqlParser.collectionExpr_return retval = new HqlParser.collectionExpr_return();
        retval.Start = input.LT(1);

        IASTNode root_0 = null;

        IToken ELEMENTS238 = null;
        IToken INDICES239 = null;
        IToken OPEN240 = null;
        IToken CLOSE242 = null;
        IToken DOT244 = null;
        IToken ELEMENTS245 = null;
        HqlParser.path_return path241 = default(HqlParser.path_return);

        HqlParser.path_return path243 = default(HqlParser.path_return);


        IASTNode ELEMENTS238_tree=null;
        IASTNode INDICES239_tree=null;
        IASTNode OPEN240_tree=null;
        IASTNode CLOSE242_tree=null;
        IASTNode DOT244_tree=null;
        IASTNode ELEMENTS245_tree=null;

        try 
    	{
            // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:831:2: ( ( ELEMENTS | INDICES ) OPEN path CLOSE | path DOT ELEMENTS )
            int alt83 = 2;
            int LA83_0 = input.LA(1);

            if ( (LA83_0 == ELEMENTS || LA83_0 == INDICES) )
            {
                alt83 = 1;
            }
            else if ( (LA83_0 == IDENT) )
            {
                alt83 = 2;
            }
            else 
            {
                NoViableAltException nvae_d83s0 =
                    new NoViableAltException("", 83, 0, input);

                throw nvae_d83s0;
            }
            switch (alt83) 
            {
                case 1 :
                    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:831:4: ( ELEMENTS | INDICES ) OPEN path CLOSE
                    {
                    	root_0 = (IASTNode)adaptor.GetNilNode();

                    	// /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:831:4: ( ELEMENTS | INDICES )
                    	int alt82 = 2;
                    	int LA82_0 = input.LA(1);

                    	if ( (LA82_0 == ELEMENTS) )
                    	{
                    	    alt82 = 1;
                    	}
                    	else if ( (LA82_0 == INDICES) )
                    	{
                    	    alt82 = 2;
                    	}
                    	else 
                    	{
                    	    NoViableAltException nvae_d82s0 =
                    	        new NoViableAltException("", 82, 0, input);

                    	    throw nvae_d82s0;
                    	}
                    	switch (alt82) 
                    	{
                    	    case 1 :
                    	        // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:831:5: ELEMENTS
                    	        {
                    	        	ELEMENTS238=(IToken)Match(input,ELEMENTS,FOLLOW_ELEMENTS_in_collectionExpr3107); 
                    	        		ELEMENTS238_tree = (IASTNode)adaptor.Create(ELEMENTS238);
                    	        		root_0 = (IASTNode)adaptor.BecomeRoot(ELEMENTS238_tree, root_0);


                    	        }
                    	        break;
                    	    case 2 :
                    	        // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:831:17: INDICES
                    	        {
                    	        	INDICES239=(IToken)Match(input,INDICES,FOLLOW_INDICES_in_collectionExpr3112); 
                    	        		INDICES239_tree = (IASTNode)adaptor.Create(INDICES239);
                    	        		root_0 = (IASTNode)adaptor.BecomeRoot(INDICES239_tree, root_0);


                    	        }
                    	        break;

                    	}

                    	OPEN240=(IToken)Match(input,OPEN,FOLLOW_OPEN_in_collectionExpr3116); 
                    	PushFollow(FOLLOW_path_in_collectionExpr3119);
                    	path241 = path();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, path241.Tree);
                    	CLOSE242=(IToken)Match(input,CLOSE,FOLLOW_CLOSE_in_collectionExpr3121); 

                    }
                    break;
                case 2 :
                    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:832:4: path DOT ELEMENTS
                    {
                    	root_0 = (IASTNode)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_path_in_collectionExpr3127);
                    	path243 = path();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, path243.Tree);
                    	DOT244=(IToken)Match(input,DOT,FOLLOW_DOT_in_collectionExpr3129); 
                    	ELEMENTS245=(IToken)Match(input,ELEMENTS,FOLLOW_ELEMENTS_in_collectionExpr3132); 
                    		ELEMENTS245_tree = (IASTNode)adaptor.Create(ELEMENTS245);
                    		root_0 = (IASTNode)adaptor.BecomeRoot(ELEMENTS245_tree, root_0);


                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            	retval.Tree = (IASTNode)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (IASTNode)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "collectionExpr"

    public class compoundExpr_return : ParserRuleReturnScope
    {
        private IASTNode tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (IASTNode) value; }
        }
    };

    // $ANTLR start "compoundExpr"
    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:836:1: compoundExpr : ( collectionExpr | path | ( OPEN ( ( expression ( COMMA expression )* ) | subQuery ) CLOSE ) );
    public HqlParser.compoundExpr_return compoundExpr() // throws RecognitionException [1]
    {   
        HqlParser.compoundExpr_return retval = new HqlParser.compoundExpr_return();
        retval.Start = input.LT(1);

        IASTNode root_0 = null;

        IToken OPEN248 = null;
        IToken COMMA250 = null;
        IToken CLOSE253 = null;
        HqlParser.collectionExpr_return collectionExpr246 = default(HqlParser.collectionExpr_return);

        HqlParser.path_return path247 = default(HqlParser.path_return);

        HqlParser.expression_return expression249 = default(HqlParser.expression_return);

        HqlParser.expression_return expression251 = default(HqlParser.expression_return);

        HqlParser.subQuery_return subQuery252 = default(HqlParser.subQuery_return);


        IASTNode OPEN248_tree=null;
        IASTNode COMMA250_tree=null;
        IASTNode CLOSE253_tree=null;

        try 
    	{
            // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:837:2: ( collectionExpr | path | ( OPEN ( ( expression ( COMMA expression )* ) | subQuery ) CLOSE ) )
            int alt86 = 3;
            alt86 = dfa86.Predict(input);
            switch (alt86) 
            {
                case 1 :
                    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:837:4: collectionExpr
                    {
                    	root_0 = (IASTNode)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_collectionExpr_in_compoundExpr3188);
                    	collectionExpr246 = collectionExpr();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, collectionExpr246.Tree);

                    }
                    break;
                case 2 :
                    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:838:4: path
                    {
                    	root_0 = (IASTNode)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_path_in_compoundExpr3193);
                    	path247 = path();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, path247.Tree);

                    }
                    break;
                case 3 :
                    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:839:4: ( OPEN ( ( expression ( COMMA expression )* ) | subQuery ) CLOSE )
                    {
                    	root_0 = (IASTNode)adaptor.GetNilNode();

                    	// /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:839:4: ( OPEN ( ( expression ( COMMA expression )* ) | subQuery ) CLOSE )
                    	// /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:839:5: OPEN ( ( expression ( COMMA expression )* ) | subQuery ) CLOSE
                    	{
                    		OPEN248=(IToken)Match(input,OPEN,FOLLOW_OPEN_in_compoundExpr3199); 
                    		// /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:839:11: ( ( expression ( COMMA expression )* ) | subQuery )
                    		int alt85 = 2;
                    		int LA85_0 = input.LA(1);

                    		if ( ((LA85_0 >= ALL && LA85_0 <= ANY) || LA85_0 == AVG || LA85_0 == COUNT || LA85_0 == ELEMENTS || (LA85_0 >= EXISTS && LA85_0 <= FALSE) || LA85_0 == INDICES || (LA85_0 >= MAX && LA85_0 <= MIN) || (LA85_0 >= NOT && LA85_0 <= NULL) || (LA85_0 >= SOME && LA85_0 <= TRUE) || LA85_0 == CASE || LA85_0 == EMPTY || (LA85_0 >= NUM_INT && LA85_0 <= NUM_LONG) || LA85_0 == OPEN || (LA85_0 >= PLUS && LA85_0 <= MINUS) || (LA85_0 >= COLON && LA85_0 <= IDENT)) )
                    		{
                    		    alt85 = 1;
                    		}
                    		else if ( (LA85_0 == EOF || LA85_0 == FROM || LA85_0 == GROUP || LA85_0 == ORDER || LA85_0 == SELECT || LA85_0 == UNION || LA85_0 == WHERE || LA85_0 == CLOSE) )
                    		{
                    		    alt85 = 2;
                    		}
                    		else 
                    		{
                    		    NoViableAltException nvae_d85s0 =
                    		        new NoViableAltException("", 85, 0, input);

                    		    throw nvae_d85s0;
                    		}
                    		switch (alt85) 
                    		{
                    		    case 1 :
                    		        // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:839:13: ( expression ( COMMA expression )* )
                    		        {
                    		        	// /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:839:13: ( expression ( COMMA expression )* )
                    		        	// /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:839:14: expression ( COMMA expression )*
                    		        	{
                    		        		PushFollow(FOLLOW_expression_in_compoundExpr3205);
                    		        		expression249 = expression();
                    		        		state.followingStackPointer--;

                    		        		adaptor.AddChild(root_0, expression249.Tree);
                    		        		// /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:839:25: ( COMMA expression )*
                    		        		do 
                    		        		{
                    		        		    int alt84 = 2;
                    		        		    int LA84_0 = input.LA(1);

                    		        		    if ( (LA84_0 == COMMA) )
                    		        		    {
                    		        		        alt84 = 1;
                    		        		    }


                    		        		    switch (alt84) 
                    		        			{
                    		        				case 1 :
                    		        				    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:839:26: COMMA expression
                    		        				    {
                    		        				    	COMMA250=(IToken)Match(input,COMMA,FOLLOW_COMMA_in_compoundExpr3208); 
                    		        				    	PushFollow(FOLLOW_expression_in_compoundExpr3211);
                    		        				    	expression251 = expression();
                    		        				    	state.followingStackPointer--;

                    		        				    	adaptor.AddChild(root_0, expression251.Tree);

                    		        				    }
                    		        				    break;

                    		        				default:
                    		        				    goto loop84;
                    		        		    }
                    		        		} while (true);

                    		        		loop84:
                    		        			;	// Stops C# compiler whining that label 'loop84' has no statements


                    		        	}


                    		        }
                    		        break;
                    		    case 2 :
                    		        // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:839:49: subQuery
                    		        {
                    		        	PushFollow(FOLLOW_subQuery_in_compoundExpr3218);
                    		        	subQuery252 = subQuery();
                    		        	state.followingStackPointer--;

                    		        	adaptor.AddChild(root_0, subQuery252.Tree);

                    		        }
                    		        break;

                    		}

                    		CLOSE253=(IToken)Match(input,CLOSE,FOLLOW_CLOSE_in_compoundExpr3222); 

                    	}


                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            	retval.Tree = (IASTNode)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (IASTNode)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "compoundExpr"

    public class subQuery_return : ParserRuleReturnScope
    {
        private IASTNode tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (IASTNode) value; }
        }
    };

    // $ANTLR start "subQuery"
    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:849:1: subQuery : union -> ^( QUERY[\"query\"] union ) ;
    public HqlParser.subQuery_return subQuery() // throws RecognitionException [1]
    {   
        HqlParser.subQuery_return retval = new HqlParser.subQuery_return();
        retval.Start = input.LT(1);

        IASTNode root_0 = null;

        HqlParser.union_return union254 = default(HqlParser.union_return);


        RewriteRuleSubtreeStream stream_union = new RewriteRuleSubtreeStream(adaptor,"rule union");
        try 
    	{
            // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:850:2: ( union -> ^( QUERY[\"query\"] union ) )
            // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:850:4: union
            {
            	PushFollow(FOLLOW_union_in_subQuery3237);
            	union254 = union();
            	state.followingStackPointer--;

            	stream_union.Add(union254.Tree);


            	// AST REWRITE
            	// elements:          union
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (IASTNode)adaptor.GetNilNode();
            	// 851:2: -> ^( QUERY[\"query\"] union )
            	{
            	    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:851:5: ^( QUERY[\"query\"] union )
            	    {
            	    IASTNode root_1 = (IASTNode)adaptor.GetNilNode();
            	    root_1 = (IASTNode)adaptor.BecomeRoot((IASTNode)adaptor.Create(QUERY, "query"), root_1);

            	    adaptor.AddChild(root_1, stream_union.NextTree());

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;
            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (IASTNode)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (IASTNode)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "subQuery"

    public class exprList_return : ParserRuleReturnScope
    {
        private IASTNode tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (IASTNode) value; }
        }
    };

    // $ANTLR start "exprList"
    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:854:1: exprList : ( TRAILING | LEADING | BOTH )? ( expression ( ( COMMA expression )+ | f= FROM expression | AS identifier )? | f2= FROM expression )? ;
    public HqlParser.exprList_return exprList() // throws RecognitionException [1]
    {   
        HqlParser.exprList_return retval = new HqlParser.exprList_return();
        retval.Start = input.LT(1);

        IASTNode root_0 = null;

        IToken f = null;
        IToken f2 = null;
        IToken TRAILING255 = null;
        IToken LEADING256 = null;
        IToken BOTH257 = null;
        IToken COMMA259 = null;
        IToken AS262 = null;
        HqlParser.expression_return expression258 = default(HqlParser.expression_return);

        HqlParser.expression_return expression260 = default(HqlParser.expression_return);

        HqlParser.expression_return expression261 = default(HqlParser.expression_return);

        HqlParser.identifier_return identifier263 = default(HqlParser.identifier_return);

        HqlParser.expression_return expression264 = default(HqlParser.expression_return);


        IASTNode f_tree=null;
        IASTNode f2_tree=null;
        IASTNode TRAILING255_tree=null;
        IASTNode LEADING256_tree=null;
        IASTNode BOTH257_tree=null;
        IASTNode COMMA259_tree=null;
        IASTNode AS262_tree=null;

        try 
    	{
            // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:860:2: ( ( TRAILING | LEADING | BOTH )? ( expression ( ( COMMA expression )+ | f= FROM expression | AS identifier )? | f2= FROM expression )? )
            // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:860:4: ( TRAILING | LEADING | BOTH )? ( expression ( ( COMMA expression )+ | f= FROM expression | AS identifier )? | f2= FROM expression )?
            {
            	root_0 = (IASTNode)adaptor.GetNilNode();

            	// /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:860:4: ( TRAILING | LEADING | BOTH )?
            	int alt87 = 4;
            	switch ( input.LA(1) ) 
            	{
            	    case TRAILING:
            	    	{
            	        alt87 = 1;
            	        }
            	        break;
            	    case LEADING:
            	    	{
            	        alt87 = 2;
            	        }
            	        break;
            	    case BOTH:
            	    	{
            	        alt87 = 3;
            	        }
            	        break;
            	}

            	switch (alt87) 
            	{
            	    case 1 :
            	        // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:860:5: TRAILING
            	        {
            	        	TRAILING255=(IToken)Match(input,TRAILING,FOLLOW_TRAILING_in_exprList3264); 
            	        		TRAILING255_tree = (IASTNode)adaptor.Create(TRAILING255);
            	        		adaptor.AddChild(root_0, TRAILING255_tree);

            	        	TRAILING255.Type = IDENT;

            	        }
            	        break;
            	    case 2 :
            	        // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:861:10: LEADING
            	        {
            	        	LEADING256=(IToken)Match(input,LEADING,FOLLOW_LEADING_in_exprList3277); 
            	        		LEADING256_tree = (IASTNode)adaptor.Create(LEADING256);
            	        		adaptor.AddChild(root_0, LEADING256_tree);

            	        	LEADING256.Type = IDENT;

            	        }
            	        break;
            	    case 3 :
            	        // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:862:10: BOTH
            	        {
            	        	BOTH257=(IToken)Match(input,BOTH,FOLLOW_BOTH_in_exprList3290); 
            	        		BOTH257_tree = (IASTNode)adaptor.Create(BOTH257);
            	        		adaptor.AddChild(root_0, BOTH257_tree);

            	        	BOTH257.Type = IDENT;

            	        }
            	        break;

            	}

            	// /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:864:4: ( expression ( ( COMMA expression )+ | f= FROM expression | AS identifier )? | f2= FROM expression )?
            	int alt90 = 3;
            	int LA90_0 = input.LA(1);

            	if ( ((LA90_0 >= ALL && LA90_0 <= ANY) || LA90_0 == AVG || LA90_0 == COUNT || LA90_0 == ELEMENTS || (LA90_0 >= EXISTS && LA90_0 <= FALSE) || LA90_0 == INDICES || (LA90_0 >= MAX && LA90_0 <= MIN) || (LA90_0 >= NOT && LA90_0 <= NULL) || (LA90_0 >= SOME && LA90_0 <= TRUE) || LA90_0 == CASE || LA90_0 == EMPTY || (LA90_0 >= NUM_INT && LA90_0 <= NUM_LONG) || LA90_0 == OPEN || (LA90_0 >= PLUS && LA90_0 <= MINUS) || (LA90_0 >= COLON && LA90_0 <= IDENT)) )
            	{
            	    alt90 = 1;
            	}
            	else if ( (LA90_0 == FROM) )
            	{
            	    alt90 = 2;
            	}
            	switch (alt90) 
            	{
            	    case 1 :
            	        // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:865:5: expression ( ( COMMA expression )+ | f= FROM expression | AS identifier )?
            	        {
            	        	PushFollow(FOLLOW_expression_in_exprList3314);
            	        	expression258 = expression();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, expression258.Tree);
            	        	// /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:865:16: ( ( COMMA expression )+ | f= FROM expression | AS identifier )?
            	        	int alt89 = 4;
            	        	switch ( input.LA(1) ) 
            	        	{
            	        	    case COMMA:
            	        	    	{
            	        	        alt89 = 1;
            	        	        }
            	        	        break;
            	        	    case FROM:
            	        	    	{
            	        	        alt89 = 2;
            	        	        }
            	        	        break;
            	        	    case AS:
            	        	    	{
            	        	        alt89 = 3;
            	        	        }
            	        	        break;
            	        	}

            	        	switch (alt89) 
            	        	{
            	        	    case 1 :
            	        	        // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:865:18: ( COMMA expression )+
            	        	        {
            	        	        	// /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:865:18: ( COMMA expression )+
            	        	        	int cnt88 = 0;
            	        	        	do 
            	        	        	{
            	        	        	    int alt88 = 2;
            	        	        	    int LA88_0 = input.LA(1);

            	        	        	    if ( (LA88_0 == COMMA) )
            	        	        	    {
            	        	        	        alt88 = 1;
            	        	        	    }


            	        	        	    switch (alt88) 
            	        	        		{
            	        	        			case 1 :
            	        	        			    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:865:19: COMMA expression
            	        	        			    {
            	        	        			    	COMMA259=(IToken)Match(input,COMMA,FOLLOW_COMMA_in_exprList3319); 
            	        	        			    	PushFollow(FOLLOW_expression_in_exprList3322);
            	        	        			    	expression260 = expression();
            	        	        			    	state.followingStackPointer--;

            	        	        			    	adaptor.AddChild(root_0, expression260.Tree);

            	        	        			    }
            	        	        			    break;

            	        	        			default:
            	        	        			    if ( cnt88 >= 1 ) goto loop88;
            	        	        		            EarlyExitException eee88 =
            	        	        		                new EarlyExitException(88, input);
            	        	        		            throw eee88;
            	        	        	    }
            	        	        	    cnt88++;
            	        	        	} while (true);

            	        	        	loop88:
            	        	        		;	// Stops C# compiler whinging that label 'loop88' has no statements


            	        	        }
            	        	        break;
            	        	    case 2 :
            	        	        // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:866:9: f= FROM expression
            	        	        {
            	        	        	f=(IToken)Match(input,FROM,FOLLOW_FROM_in_exprList3337); 
            	        	        		f_tree = (IASTNode)adaptor.Create(f);
            	        	        		adaptor.AddChild(root_0, f_tree);

            	        	        	PushFollow(FOLLOW_expression_in_exprList3339);
            	        	        	expression261 = expression();
            	        	        	state.followingStackPointer--;

            	        	        	adaptor.AddChild(root_0, expression261.Tree);
            	        	        	f.Type = IDENT;

            	        	        }
            	        	        break;
            	        	    case 3 :
            	        	        // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:867:9: AS identifier
            	        	        {
            	        	        	AS262=(IToken)Match(input,AS,FOLLOW_AS_in_exprList3351); 
            	        	        	PushFollow(FOLLOW_identifier_in_exprList3354);
            	        	        	identifier263 = identifier();
            	        	        	state.followingStackPointer--;

            	        	        	adaptor.AddChild(root_0, identifier263.Tree);

            	        	        }
            	        	        break;

            	        	}


            	        }
            	        break;
            	    case 2 :
            	        // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:868:7: f2= FROM expression
            	        {
            	        	f2=(IToken)Match(input,FROM,FOLLOW_FROM_in_exprList3368); 
            	        		f2_tree = (IASTNode)adaptor.Create(f2);
            	        		adaptor.AddChild(root_0, f2_tree);

            	        	PushFollow(FOLLOW_expression_in_exprList3370);
            	        	expression264 = expression();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, expression264.Tree);
            	        	f2.Type = IDENT;

            	        }
            	        break;

            	}


            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (IASTNode)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);

               IASTNode root = (IASTNode) adaptor.Create(EXPR_LIST, "exprList");
               root.AddChild((IASTNode)retval.Tree);
               retval.Tree = root;

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (IASTNode)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "exprList"

    public class constant_return : ParserRuleReturnScope
    {
        private IASTNode tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (IASTNode) value; }
        }
    };

    // $ANTLR start "constant"
    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:872:1: constant : ( NUM_INT | NUM_FLOAT | NUM_LONG | NUM_DOUBLE | QUOTED_String | NULL | TRUE | FALSE | EMPTY );
    public HqlParser.constant_return constant() // throws RecognitionException [1]
    {   
        HqlParser.constant_return retval = new HqlParser.constant_return();
        retval.Start = input.LT(1);

        IASTNode root_0 = null;

        IToken set265 = null;

        IASTNode set265_tree=null;

        try 
    	{
            // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:873:2: ( NUM_INT | NUM_FLOAT | NUM_LONG | NUM_DOUBLE | QUOTED_String | NULL | TRUE | FALSE | EMPTY )
            // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:
            {
            	root_0 = (IASTNode)adaptor.GetNilNode();

            	set265 = (IToken)input.LT(1);
            	if ( input.LA(1) == FALSE || input.LA(1) == NULL || input.LA(1) == TRUE || input.LA(1) == EMPTY || (input.LA(1) >= NUM_INT && input.LA(1) <= NUM_LONG) || input.LA(1) == QUOTED_String ) 
            	{
            	    input.Consume();
            	    adaptor.AddChild(root_0, (IASTNode)adaptor.Create(set265));
            	    state.errorRecovery = false;
            	}
            	else 
            	{
            	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	    throw mse;
            	}


            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (IASTNode)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (IASTNode)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "constant"

    public class path_return : ParserRuleReturnScope
    {
        private IASTNode tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (IASTNode) value; }
        }
    };

    // $ANTLR start "path"
    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:890:1: path : identifier ( DOT identifier )* ;
    public HqlParser.path_return path() // throws RecognitionException [1]
    {   
        HqlParser.path_return retval = new HqlParser.path_return();
        retval.Start = input.LT(1);

        IASTNode root_0 = null;

        IToken DOT267 = null;
        HqlParser.identifier_return identifier266 = default(HqlParser.identifier_return);

        HqlParser.identifier_return identifier268 = default(HqlParser.identifier_return);


        IASTNode DOT267_tree=null;


        HandleDotIdent2();

        try 
    	{
            // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:894:2: ( identifier ( DOT identifier )* )
            // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:894:4: identifier ( DOT identifier )*
            {
            	root_0 = (IASTNode)adaptor.GetNilNode();

            	PushFollow(FOLLOW_identifier_in_path3451);
            	identifier266 = identifier();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, identifier266.Tree);
            	// /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:894:15: ( DOT identifier )*
            	do 
            	{
            	    int alt91 = 2;
            	    int LA91_0 = input.LA(1);

            	    if ( (LA91_0 == DOT) )
            	    {
            	        int LA91_2 = input.LA(2);

            	        if ( (LA91_2 == IDENT) )
            	        {
            	            alt91 = 1;
            	        }


            	    }


            	    switch (alt91) 
            		{
            			case 1 :
            			    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:894:17: DOT identifier
            			    {
            			    	DOT267=(IToken)Match(input,DOT,FOLLOW_DOT_in_path3455); 
            			    		DOT267_tree = (IASTNode)adaptor.Create(DOT267);
            			    		root_0 = (IASTNode)adaptor.BecomeRoot(DOT267_tree, root_0);

            			    	 WeakKeywords(); 
            			    	PushFollow(FOLLOW_identifier_in_path3460);
            			    	identifier268 = identifier();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, identifier268.Tree);

            			    }
            			    break;

            			default:
            			    goto loop91;
            	    }
            	} while (true);

            	loop91:
            		;	// Stops C# compiler whining that label 'loop91' has no statements


            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (IASTNode)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (IASTNode)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "path"

    public class identifier_return : ParserRuleReturnScope
    {
        private IASTNode tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (IASTNode) value; }
        }
    };

    // $ANTLR start "identifier"
    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:899:1: identifier : IDENT ;
    public HqlParser.identifier_return identifier() // throws RecognitionException [1]
    {   
        HqlParser.identifier_return retval = new HqlParser.identifier_return();
        retval.Start = input.LT(1);

        IASTNode root_0 = null;

        IToken IDENT269 = null;

        IASTNode IDENT269_tree=null;

        try 
    	{
            // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:900:2: ( IDENT )
            // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/Hql.g:900:4: IDENT
            {
            	root_0 = (IASTNode)adaptor.GetNilNode();

            	IDENT269=(IToken)Match(input,IDENT,FOLLOW_IDENT_in_identifier3476); 
            		IDENT269_tree = (IASTNode)adaptor.Create(IDENT269);
            		adaptor.AddChild(root_0, IDENT269_tree);


            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (IASTNode)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException ex) 
        {

            		retval.Tree = HandleIdentifierError(input.LT(1),ex);
            	
        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "identifier"

    // Delegated rules


   	protected DFA76 dfa76;
   	protected DFA81 dfa81;
   	protected DFA86 dfa86;
	private void InitializeCyclicDFAs()
	{
    	this.dfa76 = new DFA76(this);
    	this.dfa81 = new DFA81(this);
    	this.dfa86 = new DFA86(this);



	}

    const string DFA76_eotS =
        "\x06\uffff";
    const string DFA76_eofS =
        "\x01\uffff\x01\x04\x03\uffff\x01\x04";
    const string DFA76_minS =
        "\x01\x09\x01\x06\x01\uffff\x01\x0b\x01\uffff\x01\x06";
    const string DFA76_maxS =
        "\x01\x76\x01\x7f\x01\uffff\x01\x76\x01\uffff\x01\x7f";
    const string DFA76_acceptS =
        "\x02\uffff\x01\x02\x01\uffff\x01\x01\x01\uffff";
    const string DFA76_specialS =
        "\x06\uffff}>";
    static readonly string[] DFA76_transitionS = {
            "\x01\x02\x02\uffff\x01\x02\x04\uffff\x01\x02\x09\uffff\x01\x02"+
            "\x07\uffff\x02\x02\x0b\uffff\x01\x02\x45\uffff\x01\x01",
            "\x03\x04\x01\uffff\x01\x04\x03\uffff\x01\x04\x01\x03\x02\uffff"+
            "\x01\x04\x03\uffff\x05\x04\x01\uffff\x01\x04\x02\uffff\x04\x04"+
            "\x03\uffff\x01\x04\x01\uffff\x02\x04\x02\uffff\x01\x04\x05\uffff"+
            "\x01\x04\x02\uffff\x01\x04\x02\uffff\x04\x04\x05\uffff\x01\x04"+
            "\x20\uffff\x11\x04\x0b\uffff\x02\x04",
            "",
            "\x01\x04\x05\uffff\x01\x02\x30\uffff\x01\x04\x33\uffff\x01"+
            "\x05",
            "",
            "\x03\x04\x01\uffff\x01\x04\x03\uffff\x01\x04\x01\x03\x02\uffff"+
            "\x01\x04\x03\uffff\x05\x04\x01\uffff\x01\x04\x02\uffff\x04\x04"+
            "\x03\uffff\x01\x04\x01\uffff\x02\x04\x02\uffff\x01\x04\x05\uffff"+
            "\x01\x04\x02\uffff\x01\x04\x02\uffff\x04\x04\x05\uffff\x01\x04"+
            "\x20\uffff\x11\x04\x0b\uffff\x02\x04"
    };

    static readonly short[] DFA76_eot = DFA.UnpackEncodedString(DFA76_eotS);
    static readonly short[] DFA76_eof = DFA.UnpackEncodedString(DFA76_eofS);
    static readonly char[] DFA76_min = DFA.UnpackEncodedStringToUnsignedChars(DFA76_minS);
    static readonly char[] DFA76_max = DFA.UnpackEncodedStringToUnsignedChars(DFA76_maxS);
    static readonly short[] DFA76_accept = DFA.UnpackEncodedString(DFA76_acceptS);
    static readonly short[] DFA76_special = DFA.UnpackEncodedString(DFA76_specialS);
    static readonly short[][] DFA76_transition = DFA.UnpackEncodedStringArray(DFA76_transitionS);

    protected class DFA76 : DFA
    {
        public DFA76(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 76;
            this.eot = DFA76_eot;
            this.eof = DFA76_eof;
            this.min = DFA76_min;
            this.max = DFA76_max;
            this.accept = DFA76_accept;
            this.special = DFA76_special;
            this.transition = DFA76_transition;

        }

        override public string Description
        {
            get { return "788:1: identPrimary : ( identifier ( options {greedy=true; } : DOT ( identifier | o= OBJECT ) )* ( (op= OPEN exprList CLOSE ) )? | aggregate );"; }
        }

    }

    const string DFA81_eotS =
        "\x06\uffff";
    const string DFA81_eofS =
        "\x06\uffff";
    const string DFA81_minS =
        "\x01\x11\x01\x0f\x01\uffff\x01\x11\x01\uffff\x01\x0f";
    const string DFA81_maxS =
        "\x01\x76\x01\x65\x01\uffff\x01\x76\x01\uffff\x01\x65";
    const string DFA81_acceptS =
        "\x02\uffff\x01\x02\x01\uffff\x01\x01\x01\uffff";
    const string DFA81_specialS =
        "\x06\uffff}>";
    static readonly string[] DFA81_transitionS = {
            "\x01\x02\x09\uffff\x01\x02\x5a\uffff\x01\x01",
            "\x01\x03\x55\uffff\x01\x04",
            "",
            "\x01\x02\x64\uffff\x01\x05",
            "",
            "\x01\x03\x55\uffff\x01\x04"
    };

    static readonly short[] DFA81_eot = DFA.UnpackEncodedString(DFA81_eotS);
    static readonly short[] DFA81_eof = DFA.UnpackEncodedString(DFA81_eofS);
    static readonly char[] DFA81_min = DFA.UnpackEncodedStringToUnsignedChars(DFA81_minS);
    static readonly char[] DFA81_max = DFA.UnpackEncodedStringToUnsignedChars(DFA81_maxS);
    static readonly short[] DFA81_accept = DFA.UnpackEncodedString(DFA81_acceptS);
    static readonly short[] DFA81_special = DFA.UnpackEncodedString(DFA81_specialS);
    static readonly short[][] DFA81_transition = DFA.UnpackEncodedStringArray(DFA81_transitionS);

    protected class DFA81 : DFA
    {
        public DFA81(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 81;
            this.eot = DFA81_eot;
            this.eof = DFA81_eof;
            this.min = DFA81_min;
            this.max = DFA81_max;
            this.accept = DFA81_accept;
            this.special = DFA81_special;
            this.transition = DFA81_transition;

        }

        override public string Description
        {
            get { return "825:26: ( path | collectionExpr )"; }
        }

    }

    const string DFA86_eotS =
        "\x07\uffff";
    const string DFA86_eofS =
        "\x02\uffff\x01\x05\x03\uffff\x01\x05";
    const string DFA86_minS =
        "\x01\x11\x01\uffff\x01\x06\x01\uffff\x01\x11\x01\uffff\x01\x06";
    const string DFA86_maxS =
        "\x01\x76\x01\uffff\x01\x7f\x01\uffff\x01\x76\x01\uffff\x01\x7f";
    const string DFA86_acceptS =
        "\x01\uffff\x01\x01\x01\uffff\x01\x03\x01\uffff\x01\x02\x01\uffff";
    const string DFA86_specialS =
        "\x07\uffff}>";
    static readonly string[] DFA86_transitionS = {
            "\x01\x01\x09\uffff\x01\x01\x48\uffff\x01\x03\x11\uffff\x01\x02",
            "",
            "\x03\x05\x05\uffff\x01\x05\x01\x04\x06\uffff\x04\x05\x02\uffff"+
            "\x01\x05\x02\uffff\x03\x05\x06\uffff\x02\x05\x02\uffff\x01\x05"+
            "\x05\uffff\x01\x05\x02\uffff\x01\x05\x04\uffff\x01\x05\x27\uffff"+
            "\x02\x05\x01\uffff\x03\x05\x0a\uffff\x01\x05\x0b\uffff\x02\x05",
            "",
            "\x01\x01\x64\uffff\x01\x06",
            "",
            "\x03\x05\x05\uffff\x01\x05\x01\x04\x06\uffff\x04\x05\x02\uffff"+
            "\x01\x05\x02\uffff\x03\x05\x06\uffff\x02\x05\x02\uffff\x01\x05"+
            "\x05\uffff\x01\x05\x02\uffff\x01\x05\x04\uffff\x01\x05\x27\uffff"+
            "\x02\x05\x01\uffff\x03\x05\x0a\uffff\x01\x05\x0b\uffff\x02\x05"
    };

    static readonly short[] DFA86_eot = DFA.UnpackEncodedString(DFA86_eotS);
    static readonly short[] DFA86_eof = DFA.UnpackEncodedString(DFA86_eofS);
    static readonly char[] DFA86_min = DFA.UnpackEncodedStringToUnsignedChars(DFA86_minS);
    static readonly char[] DFA86_max = DFA.UnpackEncodedStringToUnsignedChars(DFA86_maxS);
    static readonly short[] DFA86_accept = DFA.UnpackEncodedString(DFA86_acceptS);
    static readonly short[] DFA86_special = DFA.UnpackEncodedString(DFA86_specialS);
    static readonly short[][] DFA86_transition = DFA.UnpackEncodedStringArray(DFA86_transitionS);

    protected class DFA86 : DFA
    {
        public DFA86(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 86;
            this.eot = DFA86_eot;
            this.eof = DFA86_eof;
            this.min = DFA86_min;
            this.max = DFA86_max;
            this.accept = DFA86_accept;
            this.special = DFA86_special;
            this.transition = DFA86_transition;

        }

        override public string Description
        {
            get { return "836:1: compoundExpr : ( collectionExpr | path | ( OPEN ( ( expression ( COMMA expression )* ) | subQuery ) CLOSE ) );"; }
        }

    }

 

    public static readonly BitSet FOLLOW_updateStatement_in_statement597 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_deleteStatement_in_statement601 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_selectStatement_in_statement605 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_insertStatement_in_statement609 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_UPDATE_in_updateStatement622 = new BitSet(new ulong[]{0x0010000000400000UL,0x0040000000000000UL});
    public static readonly BitSet FOLLOW_VERSIONED_in_updateStatement626 = new BitSet(new ulong[]{0x0010000000400000UL,0x0040000000000000UL});
    public static readonly BitSet FOLLOW_optionalFromTokenFromClause_in_updateStatement632 = new BitSet(new ulong[]{0x0000400000000000UL});
    public static readonly BitSet FOLLOW_setClause_in_updateStatement636 = new BitSet(new ulong[]{0x0020000000000002UL});
    public static readonly BitSet FOLLOW_whereClause_in_updateStatement641 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_SET_in_setClause655 = new BitSet(new ulong[]{0x0010000000400000UL,0x0040000000000000UL});
    public static readonly BitSet FOLLOW_assignment_in_setClause658 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000400000000UL});
    public static readonly BitSet FOLLOW_COMMA_in_setClause661 = new BitSet(new ulong[]{0x0010000000400000UL,0x0040000000000000UL});
    public static readonly BitSet FOLLOW_assignment_in_setClause664 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000400000000UL});
    public static readonly BitSet FOLLOW_stateField_in_assignment678 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000800000000UL});
    public static readonly BitSet FOLLOW_EQ_in_assignment680 = new BitSet(new ulong[]{0x80938098085A1230UL,0x00786011E0000000UL});
    public static readonly BitSet FOLLOW_newValue_in_assignment683 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_path_in_stateField696 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_concatenation_in_newValue709 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_DELETE_in_deleteStatement720 = new BitSet(new ulong[]{0x0010000000400000UL,0x0040000000000000UL});
    public static readonly BitSet FOLLOW_optionalFromTokenFromClause_in_deleteStatement726 = new BitSet(new ulong[]{0x0020000000000002UL});
    public static readonly BitSet FOLLOW_whereClause_in_deleteStatement732 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_optionalFromTokenFromClause2_in_optionalFromTokenFromClause747 = new BitSet(new ulong[]{0x0010000000400000UL,0x0040000000000000UL});
    public static readonly BitSet FOLLOW_path_in_optionalFromTokenFromClause749 = new BitSet(new ulong[]{0x0010000000400082UL,0x0040000000000000UL});
    public static readonly BitSet FOLLOW_asAlias_in_optionalFromTokenFromClause752 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_FROM_in_optionalFromTokenFromClause2783 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_queryRule_in_selectStatement798 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_INSERT_in_insertStatement827 = new BitSet(new ulong[]{0x0000000040000000UL});
    public static readonly BitSet FOLLOW_intoClause_in_insertStatement830 = new BitSet(new ulong[]{0x0020220001400000UL});
    public static readonly BitSet FOLLOW_selectStatement_in_insertStatement832 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_INTO_in_intoClause843 = new BitSet(new ulong[]{0x0010000000400000UL,0x0040000000000000UL});
    public static readonly BitSet FOLLOW_path_in_intoClause846 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000001000000000UL});
    public static readonly BitSet FOLLOW_insertablePropertySpec_in_intoClause850 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_OPEN_in_insertablePropertySpec862 = new BitSet(new ulong[]{0x80938098085A1230UL,0x00786011E0000000UL});
    public static readonly BitSet FOLLOW_primaryExpression_in_insertablePropertySpec864 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000002400000000UL});
    public static readonly BitSet FOLLOW_COMMA_in_insertablePropertySpec868 = new BitSet(new ulong[]{0x80938098085A1230UL,0x00786011E0000000UL});
    public static readonly BitSet FOLLOW_primaryExpression_in_insertablePropertySpec870 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000002400000000UL});
    public static readonly BitSet FOLLOW_CLOSE_in_insertablePropertySpec875 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_queryRule_in_union898 = new BitSet(new ulong[]{0x0004000000000002UL});
    public static readonly BitSet FOLLOW_UNION_in_union901 = new BitSet(new ulong[]{0x0020220001400000UL});
    public static readonly BitSet FOLLOW_queryRule_in_union903 = new BitSet(new ulong[]{0x0004000000000002UL});
    public static readonly BitSet FOLLOW_selectFrom_in_queryRule919 = new BitSet(new ulong[]{0x0020020001000002UL});
    public static readonly BitSet FOLLOW_whereClause_in_queryRule924 = new BitSet(new ulong[]{0x0000020001000002UL});
    public static readonly BitSet FOLLOW_groupByClause_in_queryRule931 = new BitSet(new ulong[]{0x0000020000000002UL});
    public static readonly BitSet FOLLOW_orderByClause_in_queryRule938 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_selectClause_in_selectFrom959 = new BitSet(new ulong[]{0x0000000000400002UL});
    public static readonly BitSet FOLLOW_fromClause_in_selectFrom966 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_SELECT_in_selectClause1016 = new BitSet(new ulong[]{0x809380F8085B1230UL,0x00786011E0000004UL});
    public static readonly BitSet FOLLOW_DISTINCT_in_selectClause1028 = new BitSet(new ulong[]{0x809380F8085B1230UL,0x00786011E0000004UL});
    public static readonly BitSet FOLLOW_selectedPropertiesList_in_selectClause1034 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_newExpression_in_selectClause1038 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_selectObject_in_selectClause1042 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_NEW_in_newExpression1058 = new BitSet(new ulong[]{0x0010000000400000UL,0x0040000000000000UL});
    public static readonly BitSet FOLLOW_path_in_newExpression1060 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000001000000000UL});
    public static readonly BitSet FOLLOW_OPEN_in_newExpression1065 = new BitSet(new ulong[]{0x809380D8085A1230UL,0x00786011E0000000UL});
    public static readonly BitSet FOLLOW_selectedPropertiesList_in_newExpression1067 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000002000000000UL});
    public static readonly BitSet FOLLOW_CLOSE_in_newExpression1069 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_OBJECT_in_selectObject1095 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000001000000000UL});
    public static readonly BitSet FOLLOW_OPEN_in_selectObject1098 = new BitSet(new ulong[]{0x0010000000400000UL,0x0040000000000000UL});
    public static readonly BitSet FOLLOW_identifier_in_selectObject1101 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000002000000000UL});
    public static readonly BitSet FOLLOW_CLOSE_in_selectObject1103 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_FROM_in_fromClause1124 = new BitSet(new ulong[]{0x0010000004400080UL,0x0040000000000000UL});
    public static readonly BitSet FOLLOW_fromRange_in_fromClause1129 = new BitSet(new ulong[]{0x0000100310800002UL,0x0000000400000000UL});
    public static readonly BitSet FOLLOW_fromJoin_in_fromClause1133 = new BitSet(new ulong[]{0x0000100310800002UL,0x0000000400000000UL});
    public static readonly BitSet FOLLOW_COMMA_in_fromClause1137 = new BitSet(new ulong[]{0x0010000004400080UL,0x0040000000000000UL});
    public static readonly BitSet FOLLOW_fromRange_in_fromClause1142 = new BitSet(new ulong[]{0x0000100310800002UL,0x0000000400000000UL});
    public static readonly BitSet FOLLOW_set_in_fromJoin1163 = new BitSet(new ulong[]{0x0000040100000000UL});
    public static readonly BitSet FOLLOW_OUTER_in_fromJoin1174 = new BitSet(new ulong[]{0x0000000100000000UL});
    public static readonly BitSet FOLLOW_FULL_in_fromJoin1182 = new BitSet(new ulong[]{0x0000000100000000UL});
    public static readonly BitSet FOLLOW_INNER_in_fromJoin1186 = new BitSet(new ulong[]{0x0000000100000000UL});
    public static readonly BitSet FOLLOW_JOIN_in_fromJoin1191 = new BitSet(new ulong[]{0x0010000000600000UL,0x0040000000000000UL});
    public static readonly BitSet FOLLOW_FETCH_in_fromJoin1195 = new BitSet(new ulong[]{0x0010000000400000UL,0x0040000000000000UL});
    public static readonly BitSet FOLLOW_path_in_fromJoin1203 = new BitSet(new ulong[]{0x2010000000600082UL,0x0040000000000000UL});
    public static readonly BitSet FOLLOW_asAlias_in_fromJoin1206 = new BitSet(new ulong[]{0x2000000000200002UL});
    public static readonly BitSet FOLLOW_propertyFetch_in_fromJoin1211 = new BitSet(new ulong[]{0x2000000000000002UL});
    public static readonly BitSet FOLLOW_withClause_in_fromJoin1216 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_WITH_in_withClause1229 = new BitSet(new ulong[]{0x809380D8085A1230UL,0x00786011E0000000UL});
    public static readonly BitSet FOLLOW_logicalExpression_in_withClause1232 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_fromClassOrOuterQueryPath_in_fromRange1243 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_inClassDeclaration_in_fromRange1248 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_inCollectionDeclaration_in_fromRange1253 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_inCollectionElementsDeclaration_in_fromRange1258 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_path_in_fromClassOrOuterQueryPath1273 = new BitSet(new ulong[]{0x0010000000600082UL,0x0040000000000000UL});
    public static readonly BitSet FOLLOW_asAlias_in_fromClassOrOuterQueryPath1278 = new BitSet(new ulong[]{0x0000000000200002UL});
    public static readonly BitSet FOLLOW_propertyFetch_in_fromClassOrOuterQueryPath1283 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_alias_in_inClassDeclaration1316 = new BitSet(new ulong[]{0x0000000004000000UL});
    public static readonly BitSet FOLLOW_IN_in_inClassDeclaration1318 = new BitSet(new ulong[]{0x0000000000000800UL});
    public static readonly BitSet FOLLOW_CLASS_in_inClassDeclaration1320 = new BitSet(new ulong[]{0x0010000000400000UL,0x0040000000000000UL});
    public static readonly BitSet FOLLOW_path_in_inClassDeclaration1322 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_IN_in_inCollectionDeclaration1353 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000001000000000UL});
    public static readonly BitSet FOLLOW_OPEN_in_inCollectionDeclaration1355 = new BitSet(new ulong[]{0x0010000000400000UL,0x0040000000000000UL});
    public static readonly BitSet FOLLOW_path_in_inCollectionDeclaration1357 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000002000000000UL});
    public static readonly BitSet FOLLOW_CLOSE_in_inCollectionDeclaration1359 = new BitSet(new ulong[]{0x0010000000400080UL,0x0040000000000000UL});
    public static readonly BitSet FOLLOW_alias_in_inCollectionDeclaration1361 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_alias_in_inCollectionElementsDeclaration1399 = new BitSet(new ulong[]{0x0000000004000000UL});
    public static readonly BitSet FOLLOW_IN_in_inCollectionElementsDeclaration1401 = new BitSet(new ulong[]{0x0000000000020000UL});
    public static readonly BitSet FOLLOW_ELEMENTS_in_inCollectionElementsDeclaration1403 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000001000000000UL});
    public static readonly BitSet FOLLOW_OPEN_in_inCollectionElementsDeclaration1405 = new BitSet(new ulong[]{0x0010000000400000UL,0x0040000000000000UL});
    public static readonly BitSet FOLLOW_path_in_inCollectionElementsDeclaration1407 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000002000000000UL});
    public static readonly BitSet FOLLOW_CLOSE_in_inCollectionElementsDeclaration1409 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_alias_in_inCollectionElementsDeclaration1431 = new BitSet(new ulong[]{0x0000000004000000UL});
    public static readonly BitSet FOLLOW_IN_in_inCollectionElementsDeclaration1433 = new BitSet(new ulong[]{0x0010000000400000UL,0x0040000000000000UL});
    public static readonly BitSet FOLLOW_path_in_inCollectionElementsDeclaration1435 = new BitSet(new ulong[]{0x0000000000008000UL});
    public static readonly BitSet FOLLOW_DOT_in_inCollectionElementsDeclaration1437 = new BitSet(new ulong[]{0x0000000000020000UL});
    public static readonly BitSet FOLLOW_ELEMENTS_in_inCollectionElementsDeclaration1439 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_AS_in_asAlias1471 = new BitSet(new ulong[]{0x0010000000400080UL,0x0040000000000000UL});
    public static readonly BitSet FOLLOW_alias_in_asAlias1476 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_identifier_in_alias1492 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_FETCH_in_propertyFetch1511 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_ALL_in_propertyFetch1513 = new BitSet(new ulong[]{0x0000080000000000UL});
    public static readonly BitSet FOLLOW_PROPERTIES_in_propertyFetch1516 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_GROUP_in_groupByClause1531 = new BitSet(new ulong[]{0x0040000000000000UL});
    public static readonly BitSet FOLLOW_LITERAL_by_in_groupByClause1537 = new BitSet(new ulong[]{0x809380D8085A1230UL,0x00786011E0000000UL});
    public static readonly BitSet FOLLOW_expression_in_groupByClause1540 = new BitSet(new ulong[]{0x0000000002000002UL,0x0000000400000000UL});
    public static readonly BitSet FOLLOW_COMMA_in_groupByClause1544 = new BitSet(new ulong[]{0x809380D8085A1230UL,0x00786011E0000000UL});
    public static readonly BitSet FOLLOW_expression_in_groupByClause1547 = new BitSet(new ulong[]{0x0000000002000002UL,0x0000000400000000UL});
    public static readonly BitSet FOLLOW_havingClause_in_groupByClause1555 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ORDER_in_orderByClause1571 = new BitSet(new ulong[]{0x0040000000000000UL});
    public static readonly BitSet FOLLOW_LITERAL_by_in_orderByClause1574 = new BitSet(new ulong[]{0x809380D8085A1230UL,0x00786011E0000000UL});
    public static readonly BitSet FOLLOW_orderElement_in_orderByClause1577 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000400000000UL});
    public static readonly BitSet FOLLOW_COMMA_in_orderByClause1581 = new BitSet(new ulong[]{0x809380D8085A1230UL,0x00786011E0000000UL});
    public static readonly BitSet FOLLOW_orderElement_in_orderByClause1584 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000400000000UL});
    public static readonly BitSet FOLLOW_expression_in_orderElement1598 = new BitSet(new ulong[]{0x0000000000004102UL,0xC000000000000000UL});
    public static readonly BitSet FOLLOW_ascendingOrDescending_in_orderElement1602 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ASCENDING_in_ascendingOrDescending1620 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_126_in_ascendingOrDescending1626 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_DESCENDING_in_ascendingOrDescending1646 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_127_in_ascendingOrDescending1652 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_HAVING_in_havingClause1676 = new BitSet(new ulong[]{0x809380D8085A1230UL,0x00786011E0000000UL});
    public static readonly BitSet FOLLOW_logicalExpression_in_havingClause1679 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_WHERE_in_whereClause1693 = new BitSet(new ulong[]{0x809380D8085A1230UL,0x00786011E0000000UL});
    public static readonly BitSet FOLLOW_logicalExpression_in_whereClause1696 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_aliasedExpression_in_selectedPropertiesList1710 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000400000000UL});
    public static readonly BitSet FOLLOW_COMMA_in_selectedPropertiesList1714 = new BitSet(new ulong[]{0x809380D8085A1230UL,0x00786011E0000000UL});
    public static readonly BitSet FOLLOW_aliasedExpression_in_selectedPropertiesList1717 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000400000000UL});
    public static readonly BitSet FOLLOW_expression_in_aliasedExpression1732 = new BitSet(new ulong[]{0x0000000000000082UL});
    public static readonly BitSet FOLLOW_AS_in_aliasedExpression1736 = new BitSet(new ulong[]{0x0010000000400000UL,0x0040000000000000UL});
    public static readonly BitSet FOLLOW_identifier_in_aliasedExpression1739 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_expression_in_logicalExpression1777 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_logicalOrExpression_in_expression1789 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_logicalAndExpression_in_logicalOrExpression1801 = new BitSet(new ulong[]{0x0000010000000002UL});
    public static readonly BitSet FOLLOW_OR_in_logicalOrExpression1805 = new BitSet(new ulong[]{0x809380D8085A1230UL,0x00786011E0000000UL});
    public static readonly BitSet FOLLOW_logicalAndExpression_in_logicalOrExpression1808 = new BitSet(new ulong[]{0x0000010000000002UL});
    public static readonly BitSet FOLLOW_negatedExpression_in_logicalAndExpression1823 = new BitSet(new ulong[]{0x0000000000000042UL});
    public static readonly BitSet FOLLOW_AND_in_logicalAndExpression1827 = new BitSet(new ulong[]{0x809380D8085A1230UL,0x00786011E0000000UL});
    public static readonly BitSet FOLLOW_negatedExpression_in_logicalAndExpression1830 = new BitSet(new ulong[]{0x0000000000000042UL});
    public static readonly BitSet FOLLOW_NOT_in_negatedExpression1854 = new BitSet(new ulong[]{0x809380D8085A1230UL,0x00786011E0000000UL});
    public static readonly BitSet FOLLOW_negatedExpression_in_negatedExpression1858 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_equalityExpression_in_negatedExpression1871 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_relationalExpression_in_equalityExpression1903 = new BitSet(new ulong[]{0x0000000080000002UL,0x000000C800000000UL});
    public static readonly BitSet FOLLOW_EQ_in_equalityExpression1911 = new BitSet(new ulong[]{0x809380D8085A1230UL,0x00786011E0000000UL});
    public static readonly BitSet FOLLOW_IS_in_equalityExpression1920 = new BitSet(new ulong[]{0x809380D8085A1230UL,0x00786011E0000000UL});
    public static readonly BitSet FOLLOW_NOT_in_equalityExpression1926 = new BitSet(new ulong[]{0x809380D8085A1230UL,0x00786011E0000000UL});
    public static readonly BitSet FOLLOW_NE_in_equalityExpression1938 = new BitSet(new ulong[]{0x809380D8085A1230UL,0x00786011E0000000UL});
    public static readonly BitSet FOLLOW_SQL_NE_in_equalityExpression1947 = new BitSet(new ulong[]{0x809380D8085A1230UL,0x00786011E0000000UL});
    public static readonly BitSet FOLLOW_relationalExpression_in_equalityExpression1958 = new BitSet(new ulong[]{0x0000000080000002UL,0x000000C800000000UL});
    public static readonly BitSet FOLLOW_concatenation_in_relationalExpression1977 = new BitSet(new ulong[]{0x0000004404000402UL,0x00000F0000000002UL});
    public static readonly BitSet FOLLOW_LT_in_relationalExpression1989 = new BitSet(new ulong[]{0x80938098085A1230UL,0x00786011E0000000UL});
    public static readonly BitSet FOLLOW_GT_in_relationalExpression1994 = new BitSet(new ulong[]{0x80938098085A1230UL,0x00786011E0000000UL});
    public static readonly BitSet FOLLOW_LE_in_relationalExpression1999 = new BitSet(new ulong[]{0x80938098085A1230UL,0x00786011E0000000UL});
    public static readonly BitSet FOLLOW_GE_in_relationalExpression2004 = new BitSet(new ulong[]{0x80938098085A1230UL,0x00786011E0000000UL});
    public static readonly BitSet FOLLOW_additiveExpression_in_relationalExpression2009 = new BitSet(new ulong[]{0x0000000000000002UL,0x00000F0000000000UL});
    public static readonly BitSet FOLLOW_NOT_in_relationalExpression2026 = new BitSet(new ulong[]{0x0000000404000400UL,0x0000000000000002UL});
    public static readonly BitSet FOLLOW_IN_in_relationalExpression2047 = new BitSet(new ulong[]{0x0011001808421200UL,0x0040001000000000UL});
    public static readonly BitSet FOLLOW_inList_in_relationalExpression2056 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_BETWEEN_in_relationalExpression2067 = new BitSet(new ulong[]{0x80938098085A1230UL,0x00786011E0000000UL});
    public static readonly BitSet FOLLOW_betweenList_in_relationalExpression2076 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LIKE_in_relationalExpression2088 = new BitSet(new ulong[]{0x80938098085A1230UL,0x00786011E0000000UL});
    public static readonly BitSet FOLLOW_concatenation_in_relationalExpression2097 = new BitSet(new ulong[]{0x0000000000040000UL});
    public static readonly BitSet FOLLOW_likeEscape_in_relationalExpression2099 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_MEMBER_in_relationalExpression2108 = new BitSet(new ulong[]{0x0010000000400000UL,0x0040000000000008UL});
    public static readonly BitSet FOLLOW_OF_in_relationalExpression2112 = new BitSet(new ulong[]{0x0010000000400000UL,0x0040000000000000UL});
    public static readonly BitSet FOLLOW_path_in_relationalExpression2119 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ESCAPE_in_likeEscape2146 = new BitSet(new ulong[]{0x80938098085A1230UL,0x00786011E0000000UL});
    public static readonly BitSet FOLLOW_concatenation_in_likeEscape2149 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_compoundExpr_in_inList2164 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_concatenation_in_betweenList2185 = new BitSet(new ulong[]{0x0000000000000040UL});
    public static readonly BitSet FOLLOW_AND_in_betweenList2187 = new BitSet(new ulong[]{0x80938098085A1230UL,0x00786011E0000000UL});
    public static readonly BitSet FOLLOW_concatenation_in_betweenList2190 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_additiveExpression_in_concatenation2209 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000100000000000UL});
    public static readonly BitSet FOLLOW_CONCAT_in_concatenation2217 = new BitSet(new ulong[]{0x80938098085A1230UL,0x00786011E0000000UL});
    public static readonly BitSet FOLLOW_additiveExpression_in_concatenation2226 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000100000000000UL});
    public static readonly BitSet FOLLOW_CONCAT_in_concatenation2233 = new BitSet(new ulong[]{0x80938098085A1230UL,0x00786011E0000000UL});
    public static readonly BitSet FOLLOW_additiveExpression_in_concatenation2236 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000100000000000UL});
    public static readonly BitSet FOLLOW_multiplyExpression_in_additiveExpression2258 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000600000000000UL});
    public static readonly BitSet FOLLOW_PLUS_in_additiveExpression2264 = new BitSet(new ulong[]{0x80938098085A1230UL,0x00786011E0000000UL});
    public static readonly BitSet FOLLOW_MINUS_in_additiveExpression2269 = new BitSet(new ulong[]{0x80938098085A1230UL,0x00786011E0000000UL});
    public static readonly BitSet FOLLOW_multiplyExpression_in_additiveExpression2274 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000600000000000UL});
    public static readonly BitSet FOLLOW_unaryExpression_in_multiplyExpression2289 = new BitSet(new ulong[]{0x0000000000000002UL,0x0001800000000000UL});
    public static readonly BitSet FOLLOW_STAR_in_multiplyExpression2295 = new BitSet(new ulong[]{0x80938098085A1230UL,0x00786011E0000000UL});
    public static readonly BitSet FOLLOW_DIV_in_multiplyExpression2300 = new BitSet(new ulong[]{0x80938098085A1230UL,0x00786011E0000000UL});
    public static readonly BitSet FOLLOW_unaryExpression_in_multiplyExpression2305 = new BitSet(new ulong[]{0x0000000000000002UL,0x0001800000000000UL});
    public static readonly BitSet FOLLOW_MINUS_in_unaryExpression2325 = new BitSet(new ulong[]{0x80938098085A1230UL,0x00786011E0000000UL});
    public static readonly BitSet FOLLOW_unaryExpression_in_unaryExpression2329 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_PLUS_in_unaryExpression2346 = new BitSet(new ulong[]{0x80938098085A1230UL,0x00786011E0000000UL});
    public static readonly BitSet FOLLOW_unaryExpression_in_unaryExpression2350 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_caseExpression_in_unaryExpression2367 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_quantifiedExpression_in_unaryExpression2381 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_atom_in_unaryExpression2396 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_CASE_in_caseExpression2418 = new BitSet(new ulong[]{0x0800000000000000UL});
    public static readonly BitSet FOLLOW_whenClause_in_caseExpression2421 = new BitSet(new ulong[]{0x0B00000000000000UL});
    public static readonly BitSet FOLLOW_elseClause_in_caseExpression2426 = new BitSet(new ulong[]{0x0100000000000000UL});
    public static readonly BitSet FOLLOW_END_in_caseExpression2430 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_CASE_in_caseExpression2449 = new BitSet(new ulong[]{0x80938098085A1230UL,0x00786011E0000000UL});
    public static readonly BitSet FOLLOW_unaryExpression_in_caseExpression2451 = new BitSet(new ulong[]{0x0800000000000000UL});
    public static readonly BitSet FOLLOW_altWhenClause_in_caseExpression2454 = new BitSet(new ulong[]{0x0B00000000000000UL});
    public static readonly BitSet FOLLOW_elseClause_in_caseExpression2459 = new BitSet(new ulong[]{0x0100000000000000UL});
    public static readonly BitSet FOLLOW_END_in_caseExpression2463 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_WHEN_in_whenClause2492 = new BitSet(new ulong[]{0x809380D8085A1230UL,0x00786011E0000000UL});
    public static readonly BitSet FOLLOW_logicalExpression_in_whenClause2495 = new BitSet(new ulong[]{0x0400000000000000UL});
    public static readonly BitSet FOLLOW_THEN_in_whenClause2497 = new BitSet(new ulong[]{0x80938098085A1230UL,0x00786011E0000000UL});
    public static readonly BitSet FOLLOW_unaryExpression_in_whenClause2500 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_WHEN_in_altWhenClause2514 = new BitSet(new ulong[]{0x80938098085A1230UL,0x00786011E0000000UL});
    public static readonly BitSet FOLLOW_unaryExpression_in_altWhenClause2517 = new BitSet(new ulong[]{0x0400000000000000UL});
    public static readonly BitSet FOLLOW_THEN_in_altWhenClause2519 = new BitSet(new ulong[]{0x80938098085A1230UL,0x00786011E0000000UL});
    public static readonly BitSet FOLLOW_unaryExpression_in_altWhenClause2522 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ELSE_in_elseClause2536 = new BitSet(new ulong[]{0x80938098085A1230UL,0x00786011E0000000UL});
    public static readonly BitSet FOLLOW_unaryExpression_in_elseClause2539 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_SOME_in_quantifiedExpression2554 = new BitSet(new ulong[]{0x0011001808421200UL,0x0040001000000000UL});
    public static readonly BitSet FOLLOW_EXISTS_in_quantifiedExpression2559 = new BitSet(new ulong[]{0x0011001808421200UL,0x0040001000000000UL});
    public static readonly BitSet FOLLOW_ALL_in_quantifiedExpression2564 = new BitSet(new ulong[]{0x0011001808421200UL,0x0040001000000000UL});
    public static readonly BitSet FOLLOW_ANY_in_quantifiedExpression2569 = new BitSet(new ulong[]{0x0011001808421200UL,0x0040001000000000UL});
    public static readonly BitSet FOLLOW_identifier_in_quantifiedExpression2578 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_collectionExpr_in_quantifiedExpression2582 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_OPEN_in_quantifiedExpression2587 = new BitSet(new ulong[]{0x0020220001400000UL});
    public static readonly BitSet FOLLOW_subQuery_in_quantifiedExpression2592 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000002000000000UL});
    public static readonly BitSet FOLLOW_CLOSE_in_quantifiedExpression2596 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_primaryExpression_in_atom2617 = new BitSet(new ulong[]{0x0000000000008002UL,0x0002000000000000UL});
    public static readonly BitSet FOLLOW_DOT_in_atom2626 = new BitSet(new ulong[]{0x0010000000400000UL,0x0040000000000000UL});
    public static readonly BitSet FOLLOW_identifier_in_atom2629 = new BitSet(new ulong[]{0x0000000000008002UL,0x0002001000000000UL});
    public static readonly BitSet FOLLOW_OPEN_in_atom2657 = new BitSet(new ulong[]{0xC09380D8085A1230UL,0x00786031E0000011UL});
    public static readonly BitSet FOLLOW_exprList_in_atom2662 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000002000000000UL});
    public static readonly BitSet FOLLOW_CLOSE_in_atom2664 = new BitSet(new ulong[]{0x0000000000008002UL,0x0002000000000000UL});
    public static readonly BitSet FOLLOW_OPEN_BRACKET_in_atom2678 = new BitSet(new ulong[]{0x809380D8085A1230UL,0x00786011E0000000UL});
    public static readonly BitSet FOLLOW_expression_in_atom2683 = new BitSet(new ulong[]{0x0000000000000000UL,0x0004000000000000UL});
    public static readonly BitSet FOLLOW_CLOSE_BRACKET_in_atom2685 = new BitSet(new ulong[]{0x0000000000008002UL,0x0002000000000000UL});
    public static readonly BitSet FOLLOW_identPrimary_in_primaryExpression2705 = new BitSet(new ulong[]{0x0000000000008002UL});
    public static readonly BitSet FOLLOW_DOT_in_primaryExpression2718 = new BitSet(new ulong[]{0x0000000000000800UL});
    public static readonly BitSet FOLLOW_CLASS_in_primaryExpression2721 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_constant_in_primaryExpression2731 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_COLON_in_primaryExpression2738 = new BitSet(new ulong[]{0x0010000000400000UL,0x0040000000000000UL});
    public static readonly BitSet FOLLOW_identifier_in_primaryExpression2741 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_OPEN_in_primaryExpression2750 = new BitSet(new ulong[]{0x80B3A2D8095A1230UL,0x00786011E0000000UL});
    public static readonly BitSet FOLLOW_expressionOrVector_in_primaryExpression2754 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000002000000000UL});
    public static readonly BitSet FOLLOW_subQuery_in_primaryExpression2758 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000002000000000UL});
    public static readonly BitSet FOLLOW_CLOSE_in_primaryExpression2761 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_PARAM_in_primaryExpression2769 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000020000000UL});
    public static readonly BitSet FOLLOW_NUM_INT_in_primaryExpression2773 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_expression_in_expressionOrVector2793 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000400000000UL});
    public static readonly BitSet FOLLOW_vectorExpr_in_expressionOrVector2799 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_COMMA_in_vectorExpr2838 = new BitSet(new ulong[]{0x809380D8085A1230UL,0x00786011E0000000UL});
    public static readonly BitSet FOLLOW_expression_in_vectorExpr2841 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000400000000UL});
    public static readonly BitSet FOLLOW_COMMA_in_vectorExpr2844 = new BitSet(new ulong[]{0x809380D8085A1230UL,0x00786011E0000000UL});
    public static readonly BitSet FOLLOW_expression_in_vectorExpr2847 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000400000000UL});
    public static readonly BitSet FOLLOW_identifier_in_identPrimary2870 = new BitSet(new ulong[]{0x0000000000008002UL,0x0000001000000000UL});
    public static readonly BitSet FOLLOW_DOT_in_identPrimary2888 = new BitSet(new ulong[]{0x0010000000400000UL,0x0040000000000004UL});
    public static readonly BitSet FOLLOW_identifier_in_identPrimary2893 = new BitSet(new ulong[]{0x0000000000008002UL,0x0000001000000000UL});
    public static readonly BitSet FOLLOW_OBJECT_in_identPrimary2899 = new BitSet(new ulong[]{0x0000000000008002UL,0x0000001000000000UL});
    public static readonly BitSet FOLLOW_OPEN_in_identPrimary2917 = new BitSet(new ulong[]{0xC09380D8085A1230UL,0x00786031E0000011UL});
    public static readonly BitSet FOLLOW_exprList_in_identPrimary2922 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000002000000000UL});
    public static readonly BitSet FOLLOW_CLOSE_in_identPrimary2924 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_aggregate_in_identPrimary2940 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_SUM_in_aggregate2963 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000001000000000UL});
    public static readonly BitSet FOLLOW_AVG_in_aggregate2969 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000001000000000UL});
    public static readonly BitSet FOLLOW_MAX_in_aggregate2975 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000001000000000UL});
    public static readonly BitSet FOLLOW_MIN_in_aggregate2981 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000001000000000UL});
    public static readonly BitSet FOLLOW_OPEN_in_aggregate2985 = new BitSet(new ulong[]{0x80938098085A1230UL,0x00786011E0000000UL});
    public static readonly BitSet FOLLOW_additiveExpression_in_aggregate2987 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000002000000000UL});
    public static readonly BitSet FOLLOW_CLOSE_in_aggregate2989 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_COUNT_in_aggregate3008 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000001000000000UL});
    public static readonly BitSet FOLLOW_OPEN_in_aggregate3010 = new BitSet(new ulong[]{0x0011001808431210UL,0x0040800000000000UL});
    public static readonly BitSet FOLLOW_STAR_in_aggregate3016 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000002000000000UL});
    public static readonly BitSet FOLLOW_aggregateDistinctAll_in_aggregate3022 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000002000000000UL});
    public static readonly BitSet FOLLOW_CLOSE_in_aggregate3026 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_collectionExpr_in_aggregate3058 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_aggregateDistinctAll3071 = new BitSet(new ulong[]{0x0011001808421200UL,0x0040000000000000UL});
    public static readonly BitSet FOLLOW_path_in_aggregateDistinctAll3084 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_collectionExpr_in_aggregateDistinctAll3088 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ELEMENTS_in_collectionExpr3107 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000001000000000UL});
    public static readonly BitSet FOLLOW_INDICES_in_collectionExpr3112 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000001000000000UL});
    public static readonly BitSet FOLLOW_OPEN_in_collectionExpr3116 = new BitSet(new ulong[]{0x0010000000400000UL,0x0040000000000000UL});
    public static readonly BitSet FOLLOW_path_in_collectionExpr3119 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000002000000000UL});
    public static readonly BitSet FOLLOW_CLOSE_in_collectionExpr3121 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_path_in_collectionExpr3127 = new BitSet(new ulong[]{0x0000000000008000UL});
    public static readonly BitSet FOLLOW_DOT_in_collectionExpr3129 = new BitSet(new ulong[]{0x0000000000020000UL});
    public static readonly BitSet FOLLOW_ELEMENTS_in_collectionExpr3132 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_collectionExpr_in_compoundExpr3188 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_path_in_compoundExpr3193 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_OPEN_in_compoundExpr3199 = new BitSet(new ulong[]{0x80B3A2D8095A1230UL,0x00786011E0000000UL});
    public static readonly BitSet FOLLOW_expression_in_compoundExpr3205 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000002400000000UL});
    public static readonly BitSet FOLLOW_COMMA_in_compoundExpr3208 = new BitSet(new ulong[]{0x809380D8085A1230UL,0x00786011E0000000UL});
    public static readonly BitSet FOLLOW_expression_in_compoundExpr3211 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000002400000000UL});
    public static readonly BitSet FOLLOW_subQuery_in_compoundExpr3218 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000002000000000UL});
    public static readonly BitSet FOLLOW_CLOSE_in_compoundExpr3222 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_union_in_subQuery3237 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_TRAILING_in_exprList3264 = new BitSet(new ulong[]{0x809380D8085A1232UL,0x00786011E0000000UL});
    public static readonly BitSet FOLLOW_LEADING_in_exprList3277 = new BitSet(new ulong[]{0x809380D8085A1232UL,0x00786011E0000000UL});
    public static readonly BitSet FOLLOW_BOTH_in_exprList3290 = new BitSet(new ulong[]{0x809380D8085A1232UL,0x00786011E0000000UL});
    public static readonly BitSet FOLLOW_expression_in_exprList3314 = new BitSet(new ulong[]{0x0000000000400082UL,0x0000000400000000UL});
    public static readonly BitSet FOLLOW_COMMA_in_exprList3319 = new BitSet(new ulong[]{0x809380D8085A1230UL,0x00786011E0000000UL});
    public static readonly BitSet FOLLOW_expression_in_exprList3322 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000400000000UL});
    public static readonly BitSet FOLLOW_FROM_in_exprList3337 = new BitSet(new ulong[]{0x809380D8085A1230UL,0x00786011E0000000UL});
    public static readonly BitSet FOLLOW_expression_in_exprList3339 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_AS_in_exprList3351 = new BitSet(new ulong[]{0x0010000000400000UL,0x0040000000000000UL});
    public static readonly BitSet FOLLOW_identifier_in_exprList3354 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_FROM_in_exprList3368 = new BitSet(new ulong[]{0x809380D8085A1230UL,0x00786011E0000000UL});
    public static readonly BitSet FOLLOW_expression_in_exprList3370 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_constant0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_identifier_in_path3451 = new BitSet(new ulong[]{0x0000000000008002UL});
    public static readonly BitSet FOLLOW_DOT_in_path3455 = new BitSet(new ulong[]{0x0010000000400000UL,0x0040000000000000UL});
    public static readonly BitSet FOLLOW_identifier_in_path3460 = new BitSet(new ulong[]{0x0000000000008002UL});
    public static readonly BitSet FOLLOW_IDENT_in_identifier3476 = new BitSet(new ulong[]{0x0000000000000002UL});

}
}