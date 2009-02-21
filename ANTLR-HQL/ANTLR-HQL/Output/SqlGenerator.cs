// $ANTLR 3.1.1 /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g 2009-02-20 14:14:14
// The variable 'variable' is assigned but its value is never used.
#pragma warning disable 168, 219
// Unreachable code detected.
#pragma warning disable 162
namespace  NHibernate.Hql.Ast.ANTLR 
{

using System;
using Antlr.Runtime;
using Antlr.Runtime.Tree;using IList 		= System.Collections.IList;
using ArrayList 	= System.Collections.ArrayList;
using Stack 		= Antlr.Runtime.Collections.StackList;

using IDictionary	= System.Collections.IDictionary;
using Hashtable 	= System.Collections.Hashtable;


/**
 * SQL Generator Tree Parser, providing SQL rendering of SQL ASTs produced by the previous phase, HqlSqlWalker.  All
 * syntax decoration such as extra spaces, lack of spaces, extra parens, etc. should be added by this class.
 * <br>
 * This grammar processes the HQL/SQL AST and produces an SQL string.  The intent is to move dialect-specific
 * code into a sub-class that will override some of the methods, just like the other two grammars in this system.
 * @author Joshua Davis (joshua@hibernate.org)
 */
public partial class SqlGenerator : TreeParser
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
		"'descending'", 
		"FROM_FRAGMENT", 
		"IMPLIED_FROM", 
		"JOIN_FRAGMENT", 
		"SELECT_CLAUSE", 
		"LEFT_OUTER", 
		"RIGHT_OUTER", 
		"ALIAS_REF", 
		"PROPERTY_REF", 
		"SQL_TOKEN", 
		"SELECT_COLUMNS", 
		"SELECT_EXPR", 
		"THETA_JOINS", 
		"FILTERS", 
		"METHOD_NAME", 
		"NAMED_PARAM", 
		"BOGUS", 
		"QUOTED_STRING"
    };

    public const int COMMA = 98;
    public const int EXISTS = 19;
    public const int EXPR_LIST = 73;
    public const int FETCH = 21;
    public const int MINUS = 110;
    public const int AS = 7;
    public const int END = 56;
    public const int INTO = 30;
    public const int NAMED_PARAM = 142;
    public const int FROM_FRAGMENT = 128;
    public const int FALSE = 20;
    public const int ELEMENTS = 17;
    public const int THEN = 58;
    public const int FILTERS = 140;
    public const int ALIAS = 70;
    public const int ALIAS_REF = 134;
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
    public const int RIGHT_OUTER = 133;
    public const int BETWEEN = 10;
    public const int NUM_INT = 93;
    public const int SQL_TOKEN = 136;
    public const int LEFT_OUTER = 132;
    public const int BOTH = 62;
    public const int METHOD_NAME = 141;
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
    public const int NEW = 37;
    public const int EQ = 99;
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
    public const int THETA_JOINS = 139;
    public const int IMPLIED_FROM = 129;
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
    public const int SELECT_EXPR = 138;
    public const int OR = 40;
    public const int JOIN_FRAGMENT = 130;
    public const int FULL = 23;
    public const int INDICES = 27;
    public const int IS_NULL = 78;
    public const int GROUP = 24;
    public const int T__127 = 127;
    public const int ESCAPE = 18;
    public const int PARAM = 116;
    public const int INDEX_OP = 76;
    public const int ID_LETTER = 120;
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
    public const int PROPERTY_REF = 135;
    public const int CLASS = 11;
    public const int SOME = 47;
    public const int SELECT_COLUMNS = 137;
    public const int EXPONENT = 123;
    public const int ID_START_LETTER = 119;
    public const int BOGUS = 143;
    public const int QUOTED_STRING = 144;
    public const int EOF = -1;
    public const int CLOSE = 101;
    public const int AVG = 9;
    public const int SELECT_CLAUSE = 131;
    public const int STAR = 111;
    public const int NOT = 38;
    public const int JAVA_CONSTANT = 97;

    // delegates
    // delegators



        public SqlGenerator(ITreeNodeStream input)
    		: this(input, new RecognizerSharedState()) {
        }

        public SqlGenerator(ITreeNodeStream input, RecognizerSharedState state)
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
		get { return SqlGenerator.tokenNames; }
    }

    override public string GrammarFileName {
		get { return "/Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g"; }
    }


    public class statement_return : TreeRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "statement"
    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:22:1: statement : ( selectStatement | updateStatement | deleteStatement | insertStatement );
    public SqlGenerator.statement_return statement() // throws RecognitionException [1]
    {   
        SqlGenerator.statement_return retval = new SqlGenerator.statement_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        CommonTree _first_0 = null;
        CommonTree _last = null;

        SqlGenerator.selectStatement_return selectStatement1 = default(SqlGenerator.selectStatement_return);

        SqlGenerator.updateStatement_return updateStatement2 = default(SqlGenerator.updateStatement_return);

        SqlGenerator.deleteStatement_return deleteStatement3 = default(SqlGenerator.deleteStatement_return);

        SqlGenerator.insertStatement_return insertStatement4 = default(SqlGenerator.insertStatement_return);



        try 
    	{
            // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:23:2: ( selectStatement | updateStatement | deleteStatement | insertStatement )
            int alt1 = 4;
            switch ( input.LA(1) ) 
            {
            case SELECT:
            	{
                alt1 = 1;
                }
                break;
            case UPDATE:
            	{
                alt1 = 2;
                }
                break;
            case DELETE:
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
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    NoViableAltException nvae_d1s0 =
            	        new NoViableAltException("", 1, 0, input);

            	    throw nvae_d1s0;
            }

            switch (alt1) 
            {
                case 1 :
                    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:23:4: selectStatement
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	_last = (CommonTree)input.LT(1);
                    	PushFollow(FOLLOW_selectStatement_in_statement51);
                    	selectStatement1 = selectStatement();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking==0 ) 
                    	adaptor.AddChild(root_0, selectStatement1.Tree);

                    	if ( state.backtracking==0 ) {
                    	}
                    }
                    break;
                case 2 :
                    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:24:4: updateStatement
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	_last = (CommonTree)input.LT(1);
                    	PushFollow(FOLLOW_updateStatement_in_statement56);
                    	updateStatement2 = updateStatement();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking==0 ) 
                    	adaptor.AddChild(root_0, updateStatement2.Tree);

                    	if ( state.backtracking==0 ) {
                    	}
                    }
                    break;
                case 3 :
                    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:25:4: deleteStatement
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	_last = (CommonTree)input.LT(1);
                    	PushFollow(FOLLOW_deleteStatement_in_statement61);
                    	deleteStatement3 = deleteStatement();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking==0 ) 
                    	adaptor.AddChild(root_0, deleteStatement3.Tree);

                    	if ( state.backtracking==0 ) {
                    	}
                    }
                    break;
                case 4 :
                    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:26:4: insertStatement
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	_last = (CommonTree)input.LT(1);
                    	PushFollow(FOLLOW_insertStatement_in_statement66);
                    	insertStatement4 = insertStatement();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking==0 ) 
                    	adaptor.AddChild(root_0, insertStatement4.Tree);

                    	if ( state.backtracking==0 ) {
                    	}
                    }
                    break;

            }
            if ( state.backtracking==0 )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            }
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "statement"

    public class selectStatement_return : TreeRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "selectStatement"
    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:29:1: selectStatement : ^( SELECT selectClause from ( ^( WHERE whereExpr ) )? ( ^( GROUP groupExprs ( ^( HAVING booleanExpr[false] ) )? ) )? ( ^( ORDER orderExprs ) )? ) ;
    public SqlGenerator.selectStatement_return selectStatement() // throws RecognitionException [1]
    {   
        SqlGenerator.selectStatement_return retval = new SqlGenerator.selectStatement_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        CommonTree _first_0 = null;
        CommonTree _last = null;

        CommonTree SELECT5 = null;
        CommonTree WHERE8 = null;
        CommonTree GROUP10 = null;
        CommonTree HAVING12 = null;
        CommonTree ORDER14 = null;
        SqlGenerator.selectClause_return selectClause6 = default(SqlGenerator.selectClause_return);

        SqlGenerator.from_return from7 = default(SqlGenerator.from_return);

        SqlGenerator.whereExpr_return whereExpr9 = default(SqlGenerator.whereExpr_return);

        SqlGenerator.groupExprs_return groupExprs11 = default(SqlGenerator.groupExprs_return);

        SqlGenerator.booleanExpr_return booleanExpr13 = default(SqlGenerator.booleanExpr_return);

        SqlGenerator.orderExprs_return orderExprs15 = default(SqlGenerator.orderExprs_return);


        CommonTree SELECT5_tree=null;
        CommonTree WHERE8_tree=null;
        CommonTree GROUP10_tree=null;
        CommonTree HAVING12_tree=null;
        CommonTree ORDER14_tree=null;

        try 
    	{
            // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:30:2: ( ^( SELECT selectClause from ( ^( WHERE whereExpr ) )? ( ^( GROUP groupExprs ( ^( HAVING booleanExpr[false] ) )? ) )? ( ^( ORDER orderExprs ) )? ) )
            // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:30:4: ^( SELECT selectClause from ( ^( WHERE whereExpr ) )? ( ^( GROUP groupExprs ( ^( HAVING booleanExpr[false] ) )? ) )? ( ^( ORDER orderExprs ) )? )
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	_last = (CommonTree)input.LT(1);
            	{
            	CommonTree _save_last_1 = _last;
            	CommonTree _first_1 = null;
            	CommonTree root_1 = (CommonTree)adaptor.GetNilNode();_last = (CommonTree)input.LT(1);
            	SELECT5=(CommonTree)Match(input,SELECT,FOLLOW_SELECT_in_selectStatement78); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{SELECT5_tree = (CommonTree)adaptor.DupNode(SELECT5);

            		root_1 = (CommonTree)adaptor.BecomeRoot(SELECT5_tree, root_1);
            	}

            	if ( state.backtracking == 0 ) 
            	{
            	   Out("select "); 
            	}

            	Match(input, Token.DOWN, null); if (state.failed) return retval;
            	_last = (CommonTree)input.LT(1);
            	PushFollow(FOLLOW_selectClause_in_selectStatement84);
            	selectClause6 = selectClause();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) 
            	adaptor.AddChild(root_1, selectClause6.Tree);
            	_last = (CommonTree)input.LT(1);
            	PushFollow(FOLLOW_from_in_selectStatement88);
            	from7 = from();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) 
            	adaptor.AddChild(root_1, from7.Tree);
            	// /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:33:3: ( ^( WHERE whereExpr ) )?
            	int alt2 = 2;
            	int LA2_0 = input.LA(1);

            	if ( (LA2_0 == WHERE) )
            	{
            	    alt2 = 1;
            	}
            	switch (alt2) 
            	{
            	    case 1 :
            	        // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:33:5: ^( WHERE whereExpr )
            	        {
            	        	_last = (CommonTree)input.LT(1);
            	        	{
            	        	CommonTree _save_last_2 = _last;
            	        	CommonTree _first_2 = null;
            	        	CommonTree root_2 = (CommonTree)adaptor.GetNilNode();_last = (CommonTree)input.LT(1);
            	        	WHERE8=(CommonTree)Match(input,WHERE,FOLLOW_WHERE_in_selectStatement95); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{WHERE8_tree = (CommonTree)adaptor.DupNode(WHERE8);

            	        		root_2 = (CommonTree)adaptor.BecomeRoot(WHERE8_tree, root_2);
            	        	}

            	        	if ( state.backtracking == 0 ) 
            	        	{
            	        	   Out(" where "); 
            	        	}

            	        	Match(input, Token.DOWN, null); if (state.failed) return retval;
            	        	_last = (CommonTree)input.LT(1);
            	        	PushFollow(FOLLOW_whereExpr_in_selectStatement99);
            	        	whereExpr9 = whereExpr();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking==0 ) 
            	        	adaptor.AddChild(root_2, whereExpr9.Tree);

            	        	Match(input, Token.UP, null); if (state.failed) return retval;adaptor.AddChild(root_1, root_2);_last = _save_last_2;
            	        	}


            	        	if ( state.backtracking==0 ) {
            	        	}
            	        }
            	        break;

            	}

            	// /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:34:3: ( ^( GROUP groupExprs ( ^( HAVING booleanExpr[false] ) )? ) )?
            	int alt4 = 2;
            	int LA4_0 = input.LA(1);

            	if ( (LA4_0 == GROUP) )
            	{
            	    alt4 = 1;
            	}
            	switch (alt4) 
            	{
            	    case 1 :
            	        // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:34:5: ^( GROUP groupExprs ( ^( HAVING booleanExpr[false] ) )? )
            	        {
            	        	_last = (CommonTree)input.LT(1);
            	        	{
            	        	CommonTree _save_last_2 = _last;
            	        	CommonTree _first_2 = null;
            	        	CommonTree root_2 = (CommonTree)adaptor.GetNilNode();_last = (CommonTree)input.LT(1);
            	        	GROUP10=(CommonTree)Match(input,GROUP,FOLLOW_GROUP_in_selectStatement111); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{GROUP10_tree = (CommonTree)adaptor.DupNode(GROUP10);

            	        		root_2 = (CommonTree)adaptor.BecomeRoot(GROUP10_tree, root_2);
            	        	}

            	        	if ( state.backtracking == 0 ) 
            	        	{
            	        	   Out(" group by "); 
            	        	}

            	        	Match(input, Token.DOWN, null); if (state.failed) return retval;
            	        	_last = (CommonTree)input.LT(1);
            	        	PushFollow(FOLLOW_groupExprs_in_selectStatement115);
            	        	groupExprs11 = groupExprs();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking==0 ) 
            	        	adaptor.AddChild(root_2, groupExprs11.Tree);
            	        	// /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:34:47: ( ^( HAVING booleanExpr[false] ) )?
            	        	int alt3 = 2;
            	        	int LA3_0 = input.LA(1);

            	        	if ( (LA3_0 == HAVING) )
            	        	{
            	        	    alt3 = 1;
            	        	}
            	        	switch (alt3) 
            	        	{
            	        	    case 1 :
            	        	        // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:34:49: ^( HAVING booleanExpr[false] )
            	        	        {
            	        	        	_last = (CommonTree)input.LT(1);
            	        	        	{
            	        	        	CommonTree _save_last_3 = _last;
            	        	        	CommonTree _first_3 = null;
            	        	        	CommonTree root_3 = (CommonTree)adaptor.GetNilNode();_last = (CommonTree)input.LT(1);
            	        	        	HAVING12=(CommonTree)Match(input,HAVING,FOLLOW_HAVING_in_selectStatement120); if (state.failed) return retval;
            	        	        	if ( state.backtracking == 0 )
            	        	        	{HAVING12_tree = (CommonTree)adaptor.DupNode(HAVING12);

            	        	        		root_3 = (CommonTree)adaptor.BecomeRoot(HAVING12_tree, root_3);
            	        	        	}

            	        	        	if ( state.backtracking == 0 ) 
            	        	        	{
            	        	        	   Out(" having "); 
            	        	        	}

            	        	        	Match(input, Token.DOWN, null); if (state.failed) return retval;
            	        	        	_last = (CommonTree)input.LT(1);
            	        	        	PushFollow(FOLLOW_booleanExpr_in_selectStatement124);
            	        	        	booleanExpr13 = booleanExpr(false);
            	        	        	state.followingStackPointer--;
            	        	        	if (state.failed) return retval;
            	        	        	if ( state.backtracking==0 ) 
            	        	        	adaptor.AddChild(root_3, booleanExpr13.Tree);

            	        	        	Match(input, Token.UP, null); if (state.failed) return retval;adaptor.AddChild(root_2, root_3);_last = _save_last_3;
            	        	        	}


            	        	        	if ( state.backtracking==0 ) {
            	        	        	}
            	        	        }
            	        	        break;

            	        	}


            	        	Match(input, Token.UP, null); if (state.failed) return retval;adaptor.AddChild(root_1, root_2);_last = _save_last_2;
            	        	}


            	        	if ( state.backtracking==0 ) {
            	        	}
            	        }
            	        break;

            	}

            	// /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:35:3: ( ^( ORDER orderExprs ) )?
            	int alt5 = 2;
            	int LA5_0 = input.LA(1);

            	if ( (LA5_0 == ORDER) )
            	{
            	    alt5 = 1;
            	}
            	switch (alt5) 
            	{
            	    case 1 :
            	        // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:35:5: ^( ORDER orderExprs )
            	        {
            	        	_last = (CommonTree)input.LT(1);
            	        	{
            	        	CommonTree _save_last_2 = _last;
            	        	CommonTree _first_2 = null;
            	        	CommonTree root_2 = (CommonTree)adaptor.GetNilNode();_last = (CommonTree)input.LT(1);
            	        	ORDER14=(CommonTree)Match(input,ORDER,FOLLOW_ORDER_in_selectStatement141); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{ORDER14_tree = (CommonTree)adaptor.DupNode(ORDER14);

            	        		root_2 = (CommonTree)adaptor.BecomeRoot(ORDER14_tree, root_2);
            	        	}

            	        	if ( state.backtracking == 0 ) 
            	        	{
            	        	   Out(" order by "); 
            	        	}

            	        	Match(input, Token.DOWN, null); if (state.failed) return retval;
            	        	_last = (CommonTree)input.LT(1);
            	        	PushFollow(FOLLOW_orderExprs_in_selectStatement145);
            	        	orderExprs15 = orderExprs();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking==0 ) 
            	        	adaptor.AddChild(root_2, orderExprs15.Tree);

            	        	Match(input, Token.UP, null); if (state.failed) return retval;adaptor.AddChild(root_1, root_2);_last = _save_last_2;
            	        	}


            	        	if ( state.backtracking==0 ) {
            	        	}
            	        }
            	        break;

            	}


            	Match(input, Token.UP, null); if (state.failed) return retval;adaptor.AddChild(root_0, root_1);_last = _save_last_1;
            	}


            	if ( state.backtracking==0 ) {
            	}
            }

            if ( state.backtracking==0 )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            }
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "selectStatement"

    public class updateStatement_return : TreeRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "updateStatement"
    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:42:1: updateStatement : ^( UPDATE ^( FROM fromTable ) setClause ( whereClause )? ) ;
    public SqlGenerator.updateStatement_return updateStatement() // throws RecognitionException [1]
    {   
        SqlGenerator.updateStatement_return retval = new SqlGenerator.updateStatement_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        CommonTree _first_0 = null;
        CommonTree _last = null;

        CommonTree UPDATE16 = null;
        CommonTree FROM17 = null;
        SqlGenerator.fromTable_return fromTable18 = default(SqlGenerator.fromTable_return);

        SqlGenerator.setClause_return setClause19 = default(SqlGenerator.setClause_return);

        SqlGenerator.whereClause_return whereClause20 = default(SqlGenerator.whereClause_return);


        CommonTree UPDATE16_tree=null;
        CommonTree FROM17_tree=null;

        try 
    	{
            // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:43:2: ( ^( UPDATE ^( FROM fromTable ) setClause ( whereClause )? ) )
            // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:43:4: ^( UPDATE ^( FROM fromTable ) setClause ( whereClause )? )
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	_last = (CommonTree)input.LT(1);
            	{
            	CommonTree _save_last_1 = _last;
            	CommonTree _first_1 = null;
            	CommonTree root_1 = (CommonTree)adaptor.GetNilNode();_last = (CommonTree)input.LT(1);
            	UPDATE16=(CommonTree)Match(input,UPDATE,FOLLOW_UPDATE_in_updateStatement168); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{UPDATE16_tree = (CommonTree)adaptor.DupNode(UPDATE16);

            		root_1 = (CommonTree)adaptor.BecomeRoot(UPDATE16_tree, root_1);
            	}

            	if ( state.backtracking == 0 ) 
            	{
            	   Out("update "); 
            	}

            	Match(input, Token.DOWN, null); if (state.failed) return retval;
            	_last = (CommonTree)input.LT(1);
            	{
            	CommonTree _save_last_2 = _last;
            	CommonTree _first_2 = null;
            	CommonTree root_2 = (CommonTree)adaptor.GetNilNode();_last = (CommonTree)input.LT(1);
            	FROM17=(CommonTree)Match(input,FROM,FOLLOW_FROM_in_updateStatement176); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{FROM17_tree = (CommonTree)adaptor.DupNode(FROM17);

            		root_2 = (CommonTree)adaptor.BecomeRoot(FROM17_tree, root_2);
            	}


            	Match(input, Token.DOWN, null); if (state.failed) return retval;
            	_last = (CommonTree)input.LT(1);
            	PushFollow(FOLLOW_fromTable_in_updateStatement178);
            	fromTable18 = fromTable();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) 
            	adaptor.AddChild(root_2, fromTable18.Tree);

            	Match(input, Token.UP, null); if (state.failed) return retval;adaptor.AddChild(root_1, root_2);_last = _save_last_2;
            	}

            	_last = (CommonTree)input.LT(1);
            	PushFollow(FOLLOW_setClause_in_updateStatement184);
            	setClause19 = setClause();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) 
            	adaptor.AddChild(root_1, setClause19.Tree);
            	// /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:46:3: ( whereClause )?
            	int alt6 = 2;
            	int LA6_0 = input.LA(1);

            	if ( (LA6_0 == WHERE) )
            	{
            	    alt6 = 1;
            	}
            	switch (alt6) 
            	{
            	    case 1 :
            	        // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:46:4: whereClause
            	        {
            	        	_last = (CommonTree)input.LT(1);
            	        	PushFollow(FOLLOW_whereClause_in_updateStatement189);
            	        	whereClause20 = whereClause();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking==0 ) 
            	        	adaptor.AddChild(root_1, whereClause20.Tree);

            	        	if ( state.backtracking==0 ) {
            	        	}
            	        }
            	        break;

            	}


            	Match(input, Token.UP, null); if (state.failed) return retval;adaptor.AddChild(root_0, root_1);_last = _save_last_1;
            	}


            	if ( state.backtracking==0 ) {
            	}
            }

            if ( state.backtracking==0 )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            }
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "updateStatement"

    public class deleteStatement_return : TreeRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "deleteStatement"
    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:50:1: deleteStatement : ^( DELETE from ( whereClause )? ) ;
    public SqlGenerator.deleteStatement_return deleteStatement() // throws RecognitionException [1]
    {   
        SqlGenerator.deleteStatement_return retval = new SqlGenerator.deleteStatement_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        CommonTree _first_0 = null;
        CommonTree _last = null;

        CommonTree DELETE21 = null;
        SqlGenerator.from_return from22 = default(SqlGenerator.from_return);

        SqlGenerator.whereClause_return whereClause23 = default(SqlGenerator.whereClause_return);


        CommonTree DELETE21_tree=null;

        try 
    	{
            // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:52:2: ( ^( DELETE from ( whereClause )? ) )
            // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:52:4: ^( DELETE from ( whereClause )? )
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	_last = (CommonTree)input.LT(1);
            	{
            	CommonTree _save_last_1 = _last;
            	CommonTree _first_1 = null;
            	CommonTree root_1 = (CommonTree)adaptor.GetNilNode();_last = (CommonTree)input.LT(1);
            	DELETE21=(CommonTree)Match(input,DELETE,FOLLOW_DELETE_in_deleteStatement208); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{DELETE21_tree = (CommonTree)adaptor.DupNode(DELETE21);

            		root_1 = (CommonTree)adaptor.BecomeRoot(DELETE21_tree, root_1);
            	}

            	if ( state.backtracking == 0 ) 
            	{
            	   Out("delete"); 
            	}

            	Match(input, Token.DOWN, null); if (state.failed) return retval;
            	_last = (CommonTree)input.LT(1);
            	PushFollow(FOLLOW_from_in_deleteStatement214);
            	from22 = from();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) 
            	adaptor.AddChild(root_1, from22.Tree);
            	// /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:54:3: ( whereClause )?
            	int alt7 = 2;
            	int LA7_0 = input.LA(1);

            	if ( (LA7_0 == WHERE) )
            	{
            	    alt7 = 1;
            	}
            	switch (alt7) 
            	{
            	    case 1 :
            	        // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:54:4: whereClause
            	        {
            	        	_last = (CommonTree)input.LT(1);
            	        	PushFollow(FOLLOW_whereClause_in_deleteStatement219);
            	        	whereClause23 = whereClause();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking==0 ) 
            	        	adaptor.AddChild(root_1, whereClause23.Tree);

            	        	if ( state.backtracking==0 ) {
            	        	}
            	        }
            	        break;

            	}


            	Match(input, Token.UP, null); if (state.failed) return retval;adaptor.AddChild(root_0, root_1);_last = _save_last_1;
            	}


            	if ( state.backtracking==0 ) {
            	}
            }

            if ( state.backtracking==0 )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            }
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "deleteStatement"

    public class insertStatement_return : TreeRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "insertStatement"
    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:58:1: insertStatement : ^( INSERT i= INTO selectStatement ) ;
    public SqlGenerator.insertStatement_return insertStatement() // throws RecognitionException [1]
    {   
        SqlGenerator.insertStatement_return retval = new SqlGenerator.insertStatement_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        CommonTree _first_0 = null;
        CommonTree _last = null;

        CommonTree i = null;
        CommonTree INSERT24 = null;
        SqlGenerator.selectStatement_return selectStatement25 = default(SqlGenerator.selectStatement_return);


        CommonTree i_tree=null;
        CommonTree INSERT24_tree=null;

        try 
    	{
            // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:59:2: ( ^( INSERT i= INTO selectStatement ) )
            // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:59:4: ^( INSERT i= INTO selectStatement )
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	_last = (CommonTree)input.LT(1);
            	{
            	CommonTree _save_last_1 = _last;
            	CommonTree _first_1 = null;
            	CommonTree root_1 = (CommonTree)adaptor.GetNilNode();_last = (CommonTree)input.LT(1);
            	INSERT24=(CommonTree)Match(input,INSERT,FOLLOW_INSERT_in_insertStatement236); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{INSERT24_tree = (CommonTree)adaptor.DupNode(INSERT24);

            		root_1 = (CommonTree)adaptor.BecomeRoot(INSERT24_tree, root_1);
            	}

            	if ( state.backtracking == 0 ) 
            	{
            	   Out( "insert " ); 
            	}

            	Match(input, Token.DOWN, null); if (state.failed) return retval;
            	_last = (CommonTree)input.LT(1);
            	i=(CommonTree)Match(input,INTO,FOLLOW_INTO_in_insertStatement244); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{i_tree = (CommonTree)adaptor.DupNode(i);

            		adaptor.AddChild(root_1, i_tree);
            	}
            	if ( state.backtracking == 0 ) 
            	{
            	   Out( i ); Out( " " ); 
            	}
            	_last = (CommonTree)input.LT(1);
            	PushFollow(FOLLOW_selectStatement_in_insertStatement250);
            	selectStatement25 = selectStatement();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) 
            	adaptor.AddChild(root_1, selectStatement25.Tree);

            	Match(input, Token.UP, null); if (state.failed) return retval;adaptor.AddChild(root_0, root_1);_last = _save_last_1;
            	}


            	if ( state.backtracking==0 ) {
            	}
            }

            if ( state.backtracking==0 )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            }
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "insertStatement"

    public class setClause_return : TreeRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "setClause"
    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:65:1: setClause : ^( SET comparisonExpr[false] ( comparisonExpr[false] )* ) ;
    public SqlGenerator.setClause_return setClause() // throws RecognitionException [1]
    {   
        SqlGenerator.setClause_return retval = new SqlGenerator.setClause_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        CommonTree _first_0 = null;
        CommonTree _last = null;

        CommonTree SET26 = null;
        SqlGenerator.comparisonExpr_return comparisonExpr27 = default(SqlGenerator.comparisonExpr_return);

        SqlGenerator.comparisonExpr_return comparisonExpr28 = default(SqlGenerator.comparisonExpr_return);


        CommonTree SET26_tree=null;

        try 
    	{
            // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:68:2: ( ^( SET comparisonExpr[false] ( comparisonExpr[false] )* ) )
            // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:68:4: ^( SET comparisonExpr[false] ( comparisonExpr[false] )* )
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	_last = (CommonTree)input.LT(1);
            	{
            	CommonTree _save_last_1 = _last;
            	CommonTree _first_1 = null;
            	CommonTree root_1 = (CommonTree)adaptor.GetNilNode();_last = (CommonTree)input.LT(1);
            	SET26=(CommonTree)Match(input,SET,FOLLOW_SET_in_setClause270); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{SET26_tree = (CommonTree)adaptor.DupNode(SET26);

            		root_1 = (CommonTree)adaptor.BecomeRoot(SET26_tree, root_1);
            	}

            	if ( state.backtracking == 0 ) 
            	{
            	   Out(" set "); 
            	}

            	Match(input, Token.DOWN, null); if (state.failed) return retval;
            	_last = (CommonTree)input.LT(1);
            	PushFollow(FOLLOW_comparisonExpr_in_setClause274);
            	comparisonExpr27 = comparisonExpr(false);
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) 
            	adaptor.AddChild(root_1, comparisonExpr27.Tree);
            	// /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:68:51: ( comparisonExpr[false] )*
            	do 
            	{
            	    int alt8 = 2;
            	    int LA8_0 = input.LA(1);

            	    if ( (LA8_0 == BETWEEN || LA8_0 == EXISTS || LA8_0 == IN || LA8_0 == LIKE || (LA8_0 >= IS_NOT_NULL && LA8_0 <= IS_NULL) || (LA8_0 >= NOT_BETWEEN && LA8_0 <= NOT_LIKE) || LA8_0 == EQ || LA8_0 == NE || (LA8_0 >= LT && LA8_0 <= GE)) )
            	    {
            	        alt8 = 1;
            	    }


            	    switch (alt8) 
            		{
            			case 1 :
            			    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:68:53: comparisonExpr[false]
            			    {
            			    	if ( state.backtracking == 0 ) 
            			    	{
            			    	   Out(", "); 
            			    	}
            			    	_last = (CommonTree)input.LT(1);
            			    	PushFollow(FOLLOW_comparisonExpr_in_setClause281);
            			    	comparisonExpr28 = comparisonExpr(false);
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking==0 ) 
            			    	adaptor.AddChild(root_1, comparisonExpr28.Tree);

            			    	if ( state.backtracking==0 ) {
            			    	}
            			    }
            			    break;

            			default:
            			    goto loop8;
            	    }
            	} while (true);

            	loop8:
            		;	// Stops C# compiler whining that label 'loop8' has no statements


            	Match(input, Token.UP, null); if (state.failed) return retval;adaptor.AddChild(root_0, root_1);_last = _save_last_1;
            	}


            	if ( state.backtracking==0 ) {
            	}
            }

            if ( state.backtracking==0 )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            }
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "setClause"

    public class whereClause_return : TreeRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "whereClause"
    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:71:1: whereClause : ^( WHERE whereClauseExpr ) ;
    public SqlGenerator.whereClause_return whereClause() // throws RecognitionException [1]
    {   
        SqlGenerator.whereClause_return retval = new SqlGenerator.whereClause_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        CommonTree _first_0 = null;
        CommonTree _last = null;

        CommonTree WHERE29 = null;
        SqlGenerator.whereClauseExpr_return whereClauseExpr30 = default(SqlGenerator.whereClauseExpr_return);


        CommonTree WHERE29_tree=null;

        try 
    	{
            // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:72:2: ( ^( WHERE whereClauseExpr ) )
            // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:72:4: ^( WHERE whereClauseExpr )
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	_last = (CommonTree)input.LT(1);
            	{
            	CommonTree _save_last_1 = _last;
            	CommonTree _first_1 = null;
            	CommonTree root_1 = (CommonTree)adaptor.GetNilNode();_last = (CommonTree)input.LT(1);
            	WHERE29=(CommonTree)Match(input,WHERE,FOLLOW_WHERE_in_whereClause299); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{WHERE29_tree = (CommonTree)adaptor.DupNode(WHERE29);

            		root_1 = (CommonTree)adaptor.BecomeRoot(WHERE29_tree, root_1);
            	}

            	if ( state.backtracking == 0 ) 
            	{
            	   Out(" where "); 
            	}

            	Match(input, Token.DOWN, null); if (state.failed) return retval;
            	_last = (CommonTree)input.LT(1);
            	PushFollow(FOLLOW_whereClauseExpr_in_whereClause303);
            	whereClauseExpr30 = whereClauseExpr();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) 
            	adaptor.AddChild(root_1, whereClauseExpr30.Tree);

            	Match(input, Token.UP, null); if (state.failed) return retval;adaptor.AddChild(root_0, root_1);_last = _save_last_1;
            	}


            	if ( state.backtracking==0 ) {
            	}
            }

            if ( state.backtracking==0 )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            }
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "whereClause"

    public class whereClauseExpr_return : TreeRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "whereClauseExpr"
    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:75:1: whereClauseExpr : ( ( SQL_TOKEN )=> conditionList | booleanExpr[ false ] );
    public SqlGenerator.whereClauseExpr_return whereClauseExpr() // throws RecognitionException [1]
    {   
        SqlGenerator.whereClauseExpr_return retval = new SqlGenerator.whereClauseExpr_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        CommonTree _first_0 = null;
        CommonTree _last = null;

        SqlGenerator.conditionList_return conditionList31 = default(SqlGenerator.conditionList_return);

        SqlGenerator.booleanExpr_return booleanExpr32 = default(SqlGenerator.booleanExpr_return);



        try 
    	{
            // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:76:2: ( ( SQL_TOKEN )=> conditionList | booleanExpr[ false ] )
            int alt9 = 2;
            int LA9_0 = input.LA(1);

            if ( (LA9_0 == SQL_TOKEN) )
            {
                int LA9_1 = input.LA(2);

                if ( (synpred1_SqlGenerator()) )
                {
                    alt9 = 1;
                }
                else if ( (true) )
                {
                    alt9 = 2;
                }
                else 
                {
                    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                    NoViableAltException nvae_d9s1 =
                        new NoViableAltException("", 9, 1, input);

                    throw nvae_d9s1;
                }
            }
            else if ( (LA9_0 == AND || LA9_0 == BETWEEN || LA9_0 == EXISTS || LA9_0 == IN || LA9_0 == LIKE || LA9_0 == NOT || LA9_0 == OR || (LA9_0 >= IS_NOT_NULL && LA9_0 <= IS_NULL) || (LA9_0 >= NOT_BETWEEN && LA9_0 <= NOT_LIKE) || LA9_0 == EQ || LA9_0 == NE || (LA9_0 >= LT && LA9_0 <= GE)) )
            {
                alt9 = 2;
            }
            else 
            {
                if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                NoViableAltException nvae_d9s0 =
                    new NoViableAltException("", 9, 0, input);

                throw nvae_d9s0;
            }
            switch (alt9) 
            {
                case 1 :
                    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:76:4: ( SQL_TOKEN )=> conditionList
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	_last = (CommonTree)input.LT(1);
                    	PushFollow(FOLLOW_conditionList_in_whereClauseExpr322);
                    	conditionList31 = conditionList();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking==0 ) 
                    	adaptor.AddChild(root_0, conditionList31.Tree);

                    	if ( state.backtracking==0 ) {
                    	}
                    }
                    break;
                case 2 :
                    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:77:4: booleanExpr[ false ]
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	_last = (CommonTree)input.LT(1);
                    	PushFollow(FOLLOW_booleanExpr_in_whereClauseExpr327);
                    	booleanExpr32 = booleanExpr(false);
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking==0 ) 
                    	adaptor.AddChild(root_0, booleanExpr32.Tree);

                    	if ( state.backtracking==0 ) {
                    	}
                    }
                    break;

            }
            if ( state.backtracking==0 )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            }
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "whereClauseExpr"

    public class orderExprs_return : TreeRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "orderExprs"
    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:80:1: orderExprs : ( expr ) (dir= orderDirection )? ( orderExprs )? ;
    public SqlGenerator.orderExprs_return orderExprs() // throws RecognitionException [1]
    {   
        SqlGenerator.orderExprs_return retval = new SqlGenerator.orderExprs_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        CommonTree _first_0 = null;
        CommonTree _last = null;

        SqlGenerator.orderDirection_return dir = default(SqlGenerator.orderDirection_return);

        SqlGenerator.expr_return expr33 = default(SqlGenerator.expr_return);

        SqlGenerator.orderExprs_return orderExprs34 = default(SqlGenerator.orderExprs_return);



        try 
    	{
            // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:82:2: ( ( expr ) (dir= orderDirection )? ( orderExprs )? )
            // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:82:4: ( expr ) (dir= orderDirection )? ( orderExprs )?
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	// /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:82:4: ( expr )
            	// /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:82:6: expr
            	{
            		_last = (CommonTree)input.LT(1);
            		PushFollow(FOLLOW_expr_in_orderExprs343);
            		expr33 = expr();
            		state.followingStackPointer--;
            		if (state.failed) return retval;
            		if ( state.backtracking==0 ) 
            		adaptor.AddChild(root_0, expr33.Tree);

            		if ( state.backtracking==0 ) {
            		}
            	}

            	// /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:82:13: (dir= orderDirection )?
            	int alt10 = 2;
            	int LA10_0 = input.LA(1);

            	if ( (LA10_0 == ASCENDING || LA10_0 == DESCENDING) )
            	{
            	    alt10 = 1;
            	}
            	switch (alt10) 
            	{
            	    case 1 :
            	        // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:82:14: dir= orderDirection
            	        {
            	        	_last = (CommonTree)input.LT(1);
            	        	PushFollow(FOLLOW_orderDirection_in_orderExprs350);
            	        	dir = orderDirection();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking==0 ) 
            	        	adaptor.AddChild(root_0, dir.Tree);
            	        	if ( state.backtracking == 0 ) 
            	        	{
            	        	   Out(" "); Out(((dir != null) ? ((CommonTree)dir.Tree) : null)); 
            	        	}

            	        	if ( state.backtracking==0 ) {
            	        	}
            	        }
            	        break;

            	}

            	// /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:82:65: ( orderExprs )?
            	int alt11 = 2;
            	int LA11_0 = input.LA(1);

            	if ( ((LA11_0 >= ALL && LA11_0 <= ANY) || LA11_0 == COUNT || LA11_0 == DOT || LA11_0 == FALSE || LA11_0 == NULL || LA11_0 == SELECT || LA11_0 == SOME || LA11_0 == TRUE || LA11_0 == CASE || LA11_0 == AGGREGATE || LA11_0 == CASE2 || LA11_0 == INDEX_OP || LA11_0 == METHOD_CALL || LA11_0 == UNARY_MINUS || LA11_0 == VECTOR_EXPR || (LA11_0 >= CONSTANT && LA11_0 <= JAVA_CONSTANT) || (LA11_0 >= PLUS && LA11_0 <= DIV) || LA11_0 == PARAM || LA11_0 == IDENT || LA11_0 == ALIAS_REF || LA11_0 == SQL_TOKEN || LA11_0 == NAMED_PARAM || LA11_0 == QUOTED_STRING) )
            	{
            	    alt11 = 1;
            	}
            	switch (alt11) 
            	{
            	    case 1 :
            	        // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:82:67: orderExprs
            	        {
            	        	if ( state.backtracking == 0 ) 
            	        	{
            	        	  Out(", "); 
            	        	}
            	        	_last = (CommonTree)input.LT(1);
            	        	PushFollow(FOLLOW_orderExprs_in_orderExprs360);
            	        	orderExprs34 = orderExprs();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking==0 ) 
            	        	adaptor.AddChild(root_0, orderExprs34.Tree);

            	        	if ( state.backtracking==0 ) {
            	        	}
            	        }
            	        break;

            	}


            	if ( state.backtracking==0 ) {
            	}
            }

            if ( state.backtracking==0 )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            }
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "orderExprs"

    public class groupExprs_return : TreeRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "groupExprs"
    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:85:1: groupExprs : expr ( groupExprs )? ;
    public SqlGenerator.groupExprs_return groupExprs() // throws RecognitionException [1]
    {   
        SqlGenerator.groupExprs_return retval = new SqlGenerator.groupExprs_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        CommonTree _first_0 = null;
        CommonTree _last = null;

        SqlGenerator.expr_return expr35 = default(SqlGenerator.expr_return);

        SqlGenerator.groupExprs_return groupExprs36 = default(SqlGenerator.groupExprs_return);



        try 
    	{
            // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:87:2: ( expr ( groupExprs )? )
            // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:87:4: expr ( groupExprs )?
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	_last = (CommonTree)input.LT(1);
            	PushFollow(FOLLOW_expr_in_groupExprs375);
            	expr35 = expr();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) 
            	adaptor.AddChild(root_0, expr35.Tree);
            	// /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:87:9: ( groupExprs )?
            	int alt12 = 2;
            	int LA12_0 = input.LA(1);

            	if ( ((LA12_0 >= ALL && LA12_0 <= ANY) || LA12_0 == COUNT || LA12_0 == DOT || LA12_0 == FALSE || LA12_0 == NULL || LA12_0 == SELECT || LA12_0 == SOME || LA12_0 == TRUE || LA12_0 == CASE || LA12_0 == AGGREGATE || LA12_0 == CASE2 || LA12_0 == INDEX_OP || LA12_0 == METHOD_CALL || LA12_0 == UNARY_MINUS || LA12_0 == VECTOR_EXPR || (LA12_0 >= CONSTANT && LA12_0 <= JAVA_CONSTANT) || (LA12_0 >= PLUS && LA12_0 <= DIV) || LA12_0 == PARAM || LA12_0 == IDENT || LA12_0 == ALIAS_REF || LA12_0 == SQL_TOKEN || LA12_0 == NAMED_PARAM || LA12_0 == QUOTED_STRING) )
            	{
            	    alt12 = 1;
            	}
            	switch (alt12) 
            	{
            	    case 1 :
            	        // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:87:11: groupExprs
            	        {
            	        	if ( state.backtracking == 0 ) 
            	        	{
            	        	  Out(" , "); 
            	        	}
            	        	_last = (CommonTree)input.LT(1);
            	        	PushFollow(FOLLOW_groupExprs_in_groupExprs381);
            	        	groupExprs36 = groupExprs();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking==0 ) 
            	        	adaptor.AddChild(root_0, groupExprs36.Tree);

            	        	if ( state.backtracking==0 ) {
            	        	}
            	        }
            	        break;

            	}


            	if ( state.backtracking==0 ) {
            	}
            }

            if ( state.backtracking==0 )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            }
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "groupExprs"

    public class orderDirection_return : TreeRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "orderDirection"
    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:90:1: orderDirection : ( ASCENDING | DESCENDING );
    public SqlGenerator.orderDirection_return orderDirection() // throws RecognitionException [1]
    {   
        SqlGenerator.orderDirection_return retval = new SqlGenerator.orderDirection_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        CommonTree _first_0 = null;
        CommonTree _last = null;

        CommonTree set37 = null;

        CommonTree set37_tree=null;

        try 
    	{
            // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:91:2: ( ASCENDING | DESCENDING )
            // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	_last = (CommonTree)input.LT(1);
            	set37 = (CommonTree)input.LT(1);
            	if ( input.LA(1) == ASCENDING || input.LA(1) == DESCENDING ) 
            	{
            	    input.Consume();

            	    if ( state.backtracking==0 ) {
            	    set37_tree = (CommonTree)adaptor.DupNode(set37);

            	    adaptor.AddChild(root_0, set37_tree);
            	    }
            	    state.errorRecovery = false;state.failed = false;
            	}
            	else 
            	{
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	    throw mse;
            	}

            	if ( state.backtracking==0 ) {
            	} 

            }

            if ( state.backtracking==0 )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            }
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "orderDirection"

    public class whereExpr_return : TreeRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "whereExpr"
    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:95:1: whereExpr : ( filters ( thetaJoins )? ( booleanExpr[ true ] )? | thetaJoins ( booleanExpr[ true ] )? | booleanExpr[false] );
    public SqlGenerator.whereExpr_return whereExpr() // throws RecognitionException [1]
    {   
        SqlGenerator.whereExpr_return retval = new SqlGenerator.whereExpr_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        CommonTree _first_0 = null;
        CommonTree _last = null;

        SqlGenerator.filters_return filters38 = default(SqlGenerator.filters_return);

        SqlGenerator.thetaJoins_return thetaJoins39 = default(SqlGenerator.thetaJoins_return);

        SqlGenerator.booleanExpr_return booleanExpr40 = default(SqlGenerator.booleanExpr_return);

        SqlGenerator.thetaJoins_return thetaJoins41 = default(SqlGenerator.thetaJoins_return);

        SqlGenerator.booleanExpr_return booleanExpr42 = default(SqlGenerator.booleanExpr_return);

        SqlGenerator.booleanExpr_return booleanExpr43 = default(SqlGenerator.booleanExpr_return);



        try 
    	{
            // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:99:2: ( filters ( thetaJoins )? ( booleanExpr[ true ] )? | thetaJoins ( booleanExpr[ true ] )? | booleanExpr[false] )
            int alt16 = 3;
            switch ( input.LA(1) ) 
            {
            case FILTERS:
            	{
                alt16 = 1;
                }
                break;
            case THETA_JOINS:
            	{
                alt16 = 2;
                }
                break;
            case AND:
            case BETWEEN:
            case EXISTS:
            case IN:
            case LIKE:
            case NOT:
            case OR:
            case IS_NOT_NULL:
            case IS_NULL:
            case NOT_BETWEEN:
            case NOT_IN:
            case NOT_LIKE:
            case EQ:
            case NE:
            case LT:
            case GT:
            case LE:
            case GE:
            case SQL_TOKEN:
            	{
                alt16 = 3;
                }
                break;
            	default:
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    NoViableAltException nvae_d16s0 =
            	        new NoViableAltException("", 16, 0, input);

            	    throw nvae_d16s0;
            }

            switch (alt16) 
            {
                case 1 :
                    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:99:4: filters ( thetaJoins )? ( booleanExpr[ true ] )?
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	_last = (CommonTree)input.LT(1);
                    	PushFollow(FOLLOW_filters_in_whereExpr416);
                    	filters38 = filters();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking==0 ) 
                    	adaptor.AddChild(root_0, filters38.Tree);
                    	// /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:100:3: ( thetaJoins )?
                    	int alt13 = 2;
                    	int LA13_0 = input.LA(1);

                    	if ( (LA13_0 == THETA_JOINS) )
                    	{
                    	    alt13 = 1;
                    	}
                    	switch (alt13) 
                    	{
                    	    case 1 :
                    	        // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:100:5: thetaJoins
                    	        {
                    	        	if ( state.backtracking == 0 ) 
                    	        	{
                    	        	   Out(" and "); 
                    	        	}
                    	        	_last = (CommonTree)input.LT(1);
                    	        	PushFollow(FOLLOW_thetaJoins_in_whereExpr424);
                    	        	thetaJoins39 = thetaJoins();
                    	        	state.followingStackPointer--;
                    	        	if (state.failed) return retval;
                    	        	if ( state.backtracking==0 ) 
                    	        	adaptor.AddChild(root_0, thetaJoins39.Tree);

                    	        	if ( state.backtracking==0 ) {
                    	        	}
                    	        }
                    	        break;

                    	}

                    	// /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:101:3: ( booleanExpr[ true ] )?
                    	int alt14 = 2;
                    	int LA14_0 = input.LA(1);

                    	if ( (LA14_0 == AND || LA14_0 == BETWEEN || LA14_0 == EXISTS || LA14_0 == IN || LA14_0 == LIKE || LA14_0 == NOT || LA14_0 == OR || (LA14_0 >= IS_NOT_NULL && LA14_0 <= IS_NULL) || (LA14_0 >= NOT_BETWEEN && LA14_0 <= NOT_LIKE) || LA14_0 == EQ || LA14_0 == NE || (LA14_0 >= LT && LA14_0 <= GE) || LA14_0 == SQL_TOKEN) )
                    	{
                    	    alt14 = 1;
                    	}
                    	switch (alt14) 
                    	{
                    	    case 1 :
                    	        // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:101:5: booleanExpr[ true ]
                    	        {
                    	        	if ( state.backtracking == 0 ) 
                    	        	{
                    	        	   Out(" and "); 
                    	        	}
                    	        	_last = (CommonTree)input.LT(1);
                    	        	PushFollow(FOLLOW_booleanExpr_in_whereExpr435);
                    	        	booleanExpr40 = booleanExpr(true);
                    	        	state.followingStackPointer--;
                    	        	if (state.failed) return retval;
                    	        	if ( state.backtracking==0 ) 
                    	        	adaptor.AddChild(root_0, booleanExpr40.Tree);

                    	        	if ( state.backtracking==0 ) {
                    	        	}
                    	        }
                    	        break;

                    	}


                    	if ( state.backtracking==0 ) {
                    	}
                    }
                    break;
                case 2 :
                    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:102:4: thetaJoins ( booleanExpr[ true ] )?
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	_last = (CommonTree)input.LT(1);
                    	PushFollow(FOLLOW_thetaJoins_in_whereExpr445);
                    	thetaJoins41 = thetaJoins();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking==0 ) 
                    	adaptor.AddChild(root_0, thetaJoins41.Tree);
                    	// /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:103:3: ( booleanExpr[ true ] )?
                    	int alt15 = 2;
                    	int LA15_0 = input.LA(1);

                    	if ( (LA15_0 == AND || LA15_0 == BETWEEN || LA15_0 == EXISTS || LA15_0 == IN || LA15_0 == LIKE || LA15_0 == NOT || LA15_0 == OR || (LA15_0 >= IS_NOT_NULL && LA15_0 <= IS_NULL) || (LA15_0 >= NOT_BETWEEN && LA15_0 <= NOT_LIKE) || LA15_0 == EQ || LA15_0 == NE || (LA15_0 >= LT && LA15_0 <= GE) || LA15_0 == SQL_TOKEN) )
                    	{
                    	    alt15 = 1;
                    	}
                    	switch (alt15) 
                    	{
                    	    case 1 :
                    	        // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:103:5: booleanExpr[ true ]
                    	        {
                    	        	if ( state.backtracking == 0 ) 
                    	        	{
                    	        	   Out(" and "); 
                    	        	}
                    	        	_last = (CommonTree)input.LT(1);
                    	        	PushFollow(FOLLOW_booleanExpr_in_whereExpr453);
                    	        	booleanExpr42 = booleanExpr(true);
                    	        	state.followingStackPointer--;
                    	        	if (state.failed) return retval;
                    	        	if ( state.backtracking==0 ) 
                    	        	adaptor.AddChild(root_0, booleanExpr42.Tree);

                    	        	if ( state.backtracking==0 ) {
                    	        	}
                    	        }
                    	        break;

                    	}


                    	if ( state.backtracking==0 ) {
                    	}
                    }
                    break;
                case 3 :
                    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:104:4: booleanExpr[false]
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	_last = (CommonTree)input.LT(1);
                    	PushFollow(FOLLOW_booleanExpr_in_whereExpr464);
                    	booleanExpr43 = booleanExpr(false);
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking==0 ) 
                    	adaptor.AddChild(root_0, booleanExpr43.Tree);

                    	if ( state.backtracking==0 ) {
                    	}
                    }
                    break;

            }
            if ( state.backtracking==0 )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            }
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "whereExpr"

    public class filters_return : TreeRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "filters"
    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:107:1: filters : ^( FILTERS conditionList ) ;
    public SqlGenerator.filters_return filters() // throws RecognitionException [1]
    {   
        SqlGenerator.filters_return retval = new SqlGenerator.filters_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        CommonTree _first_0 = null;
        CommonTree _last = null;

        CommonTree FILTERS44 = null;
        SqlGenerator.conditionList_return conditionList45 = default(SqlGenerator.conditionList_return);


        CommonTree FILTERS44_tree=null;

        try 
    	{
            // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:108:2: ( ^( FILTERS conditionList ) )
            // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:108:4: ^( FILTERS conditionList )
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	_last = (CommonTree)input.LT(1);
            	{
            	CommonTree _save_last_1 = _last;
            	CommonTree _first_1 = null;
            	CommonTree root_1 = (CommonTree)adaptor.GetNilNode();_last = (CommonTree)input.LT(1);
            	FILTERS44=(CommonTree)Match(input,FILTERS,FOLLOW_FILTERS_in_filters477); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{FILTERS44_tree = (CommonTree)adaptor.DupNode(FILTERS44);

            		root_1 = (CommonTree)adaptor.BecomeRoot(FILTERS44_tree, root_1);
            	}


            	Match(input, Token.DOWN, null); if (state.failed) return retval;
            	_last = (CommonTree)input.LT(1);
            	PushFollow(FOLLOW_conditionList_in_filters479);
            	conditionList45 = conditionList();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) 
            	adaptor.AddChild(root_1, conditionList45.Tree);

            	Match(input, Token.UP, null); if (state.failed) return retval;adaptor.AddChild(root_0, root_1);_last = _save_last_1;
            	}


            	if ( state.backtracking==0 ) {
            	}
            }

            if ( state.backtracking==0 )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            }
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "filters"

    public class thetaJoins_return : TreeRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "thetaJoins"
    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:111:1: thetaJoins : ^( THETA_JOINS conditionList ) ;
    public SqlGenerator.thetaJoins_return thetaJoins() // throws RecognitionException [1]
    {   
        SqlGenerator.thetaJoins_return retval = new SqlGenerator.thetaJoins_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        CommonTree _first_0 = null;
        CommonTree _last = null;

        CommonTree THETA_JOINS46 = null;
        SqlGenerator.conditionList_return conditionList47 = default(SqlGenerator.conditionList_return);


        CommonTree THETA_JOINS46_tree=null;

        try 
    	{
            // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:112:2: ( ^( THETA_JOINS conditionList ) )
            // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:112:4: ^( THETA_JOINS conditionList )
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	_last = (CommonTree)input.LT(1);
            	{
            	CommonTree _save_last_1 = _last;
            	CommonTree _first_1 = null;
            	CommonTree root_1 = (CommonTree)adaptor.GetNilNode();_last = (CommonTree)input.LT(1);
            	THETA_JOINS46=(CommonTree)Match(input,THETA_JOINS,FOLLOW_THETA_JOINS_in_thetaJoins493); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{THETA_JOINS46_tree = (CommonTree)adaptor.DupNode(THETA_JOINS46);

            		root_1 = (CommonTree)adaptor.BecomeRoot(THETA_JOINS46_tree, root_1);
            	}


            	Match(input, Token.DOWN, null); if (state.failed) return retval;
            	_last = (CommonTree)input.LT(1);
            	PushFollow(FOLLOW_conditionList_in_thetaJoins495);
            	conditionList47 = conditionList();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) 
            	adaptor.AddChild(root_1, conditionList47.Tree);

            	Match(input, Token.UP, null); if (state.failed) return retval;adaptor.AddChild(root_0, root_1);_last = _save_last_1;
            	}


            	if ( state.backtracking==0 ) {
            	}
            }

            if ( state.backtracking==0 )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            }
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "thetaJoins"

    public class conditionList_return : TreeRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "conditionList"
    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:115:1: conditionList : sqlToken ( conditionList )? ;
    public SqlGenerator.conditionList_return conditionList() // throws RecognitionException [1]
    {   
        SqlGenerator.conditionList_return retval = new SqlGenerator.conditionList_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        CommonTree _first_0 = null;
        CommonTree _last = null;

        SqlGenerator.sqlToken_return sqlToken48 = default(SqlGenerator.sqlToken_return);

        SqlGenerator.conditionList_return conditionList49 = default(SqlGenerator.conditionList_return);



        try 
    	{
            // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:116:2: ( sqlToken ( conditionList )? )
            // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:116:4: sqlToken ( conditionList )?
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	_last = (CommonTree)input.LT(1);
            	PushFollow(FOLLOW_sqlToken_in_conditionList508);
            	sqlToken48 = sqlToken();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) 
            	adaptor.AddChild(root_0, sqlToken48.Tree);
            	// /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:116:13: ( conditionList )?
            	int alt17 = 2;
            	int LA17_0 = input.LA(1);

            	if ( (LA17_0 == SQL_TOKEN) )
            	{
            	    alt17 = 1;
            	}
            	switch (alt17) 
            	{
            	    case 1 :
            	        // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:116:15: conditionList
            	        {
            	        	if ( state.backtracking == 0 ) 
            	        	{
            	        	   Out(" and "); 
            	        	}
            	        	_last = (CommonTree)input.LT(1);
            	        	PushFollow(FOLLOW_conditionList_in_conditionList514);
            	        	conditionList49 = conditionList();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking==0 ) 
            	        	adaptor.AddChild(root_0, conditionList49.Tree);

            	        	if ( state.backtracking==0 ) {
            	        	}
            	        }
            	        break;

            	}


            	if ( state.backtracking==0 ) {
            	}
            }

            if ( state.backtracking==0 )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            }
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "conditionList"

    public class selectClause_return : TreeRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "selectClause"
    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:119:1: selectClause : ^( SELECT_CLAUSE ( distinctOrAll )? ( selectColumn )+ ) ;
    public SqlGenerator.selectClause_return selectClause() // throws RecognitionException [1]
    {   
        SqlGenerator.selectClause_return retval = new SqlGenerator.selectClause_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        CommonTree _first_0 = null;
        CommonTree _last = null;

        CommonTree SELECT_CLAUSE50 = null;
        SqlGenerator.distinctOrAll_return distinctOrAll51 = default(SqlGenerator.distinctOrAll_return);

        SqlGenerator.selectColumn_return selectColumn52 = default(SqlGenerator.selectColumn_return);


        CommonTree SELECT_CLAUSE50_tree=null;

        try 
    	{
            // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:120:2: ( ^( SELECT_CLAUSE ( distinctOrAll )? ( selectColumn )+ ) )
            // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:120:4: ^( SELECT_CLAUSE ( distinctOrAll )? ( selectColumn )+ )
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	_last = (CommonTree)input.LT(1);
            	{
            	CommonTree _save_last_1 = _last;
            	CommonTree _first_1 = null;
            	CommonTree root_1 = (CommonTree)adaptor.GetNilNode();_last = (CommonTree)input.LT(1);
            	SELECT_CLAUSE50=(CommonTree)Match(input,SELECT_CLAUSE,FOLLOW_SELECT_CLAUSE_in_selectClause529); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{SELECT_CLAUSE50_tree = (CommonTree)adaptor.DupNode(SELECT_CLAUSE50);

            		root_1 = (CommonTree)adaptor.BecomeRoot(SELECT_CLAUSE50_tree, root_1);
            	}


            	Match(input, Token.DOWN, null); if (state.failed) return retval;
            	// /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:120:20: ( distinctOrAll )?
            	int alt18 = 2;
            	int LA18_0 = input.LA(1);

            	if ( (LA18_0 == ALL || LA18_0 == DISTINCT) )
            	{
            	    alt18 = 1;
            	}
            	switch (alt18) 
            	{
            	    case 1 :
            	        // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:120:21: distinctOrAll
            	        {
            	        	_last = (CommonTree)input.LT(1);
            	        	PushFollow(FOLLOW_distinctOrAll_in_selectClause532);
            	        	distinctOrAll51 = distinctOrAll();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking==0 ) 
            	        	adaptor.AddChild(root_1, distinctOrAll51.Tree);

            	        	if ( state.backtracking==0 ) {
            	        	}
            	        }
            	        break;

            	}

            	// /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:120:37: ( selectColumn )+
            	int cnt19 = 0;
            	do 
            	{
            	    int alt19 = 2;
            	    int LA19_0 = input.LA(1);

            	    if ( (LA19_0 == COUNT || LA19_0 == DOT || LA19_0 == FALSE || LA19_0 == SELECT || LA19_0 == TRUE || LA19_0 == CASE || LA19_0 == AGGREGATE || (LA19_0 >= CONSTRUCTOR && LA19_0 <= CASE2) || LA19_0 == METHOD_CALL || LA19_0 == UNARY_MINUS || (LA19_0 >= CONSTANT && LA19_0 <= JAVA_CONSTANT) || (LA19_0 >= PLUS && LA19_0 <= DIV) || LA19_0 == PARAM || LA19_0 == IDENT || LA19_0 == ALIAS_REF || LA19_0 == SQL_TOKEN || LA19_0 == SELECT_EXPR || LA19_0 == QUOTED_STRING) )
            	    {
            	        alt19 = 1;
            	    }


            	    switch (alt19) 
            		{
            			case 1 :
            			    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:120:39: selectColumn
            			    {
            			    	_last = (CommonTree)input.LT(1);
            			    	PushFollow(FOLLOW_selectColumn_in_selectClause538);
            			    	selectColumn52 = selectColumn();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking==0 ) 
            			    	adaptor.AddChild(root_1, selectColumn52.Tree);

            			    	if ( state.backtracking==0 ) {
            			    	}
            			    }
            			    break;

            			default:
            			    if ( cnt19 >= 1 ) goto loop19;
            			    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            		            EarlyExitException eee =
            		                new EarlyExitException(19, input);
            		            throw eee;
            	    }
            	    cnt19++;
            	} while (true);

            	loop19:
            		;	// Stops C# compiler whinging that label 'loop19' has no statements


            	Match(input, Token.UP, null); if (state.failed) return retval;adaptor.AddChild(root_0, root_1);_last = _save_last_1;
            	}


            	if ( state.backtracking==0 ) {
            	}
            }

            if ( state.backtracking==0 )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            }
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "selectClause"

    public class selectColumn_return : TreeRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "selectColumn"
    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:123:1: selectColumn : p= selectExpr (sc= SELECT_COLUMNS )? ;
    public SqlGenerator.selectColumn_return selectColumn() // throws RecognitionException [1]
    {   
        SqlGenerator.selectColumn_return retval = new SqlGenerator.selectColumn_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        CommonTree _first_0 = null;
        CommonTree _last = null;

        CommonTree sc = null;
        SqlGenerator.selectExpr_return p = default(SqlGenerator.selectExpr_return);


        CommonTree sc_tree=null;

        try 
    	{
            // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:124:2: (p= selectExpr (sc= SELECT_COLUMNS )? )
            // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:124:4: p= selectExpr (sc= SELECT_COLUMNS )?
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	_last = (CommonTree)input.LT(1);
            	PushFollow(FOLLOW_selectExpr_in_selectColumn556);
            	p = selectExpr();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) 
            	adaptor.AddChild(root_0, p.Tree);
            	// /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:124:17: (sc= SELECT_COLUMNS )?
            	int alt20 = 2;
            	int LA20_0 = input.LA(1);

            	if ( (LA20_0 == SELECT_COLUMNS) )
            	{
            	    alt20 = 1;
            	}
            	switch (alt20) 
            	{
            	    case 1 :
            	        // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:124:18: sc= SELECT_COLUMNS
            	        {
            	        	_last = (CommonTree)input.LT(1);
            	        	sc=(CommonTree)Match(input,SELECT_COLUMNS,FOLLOW_SELECT_COLUMNS_in_selectColumn561); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{sc_tree = (CommonTree)adaptor.DupNode(sc);

            	        		adaptor.AddChild(root_0, sc_tree);
            	        	}
            	        	if ( state.backtracking == 0 ) 
            	        	{
            	        	   Out(sc); 
            	        	}

            	        	if ( state.backtracking==0 ) {
            	        	}
            	        }
            	        break;

            	}

            	if ( state.backtracking == 0 ) 
            	{
            	   separator( (sc != null) ? sc : ((p != null) ? ((CommonTree)p.Tree) : null) ,", "); 
            	}

            	if ( state.backtracking==0 ) {
            	}
            }

            if ( state.backtracking==0 )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            }
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "selectColumn"

    public class selectExpr_return : TreeRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "selectExpr"
    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:127:1: selectExpr : (e= selectAtom | count | ^( CONSTRUCTOR ( DOT | IDENT ) ( selectColumn )+ ) | methodCall | aggregate | c= constant | arithmeticExpr | param= PARAM | selectStatement );
    public SqlGenerator.selectExpr_return selectExpr() // throws RecognitionException [1]
    {   
        SqlGenerator.selectExpr_return retval = new SqlGenerator.selectExpr_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        CommonTree _first_0 = null;
        CommonTree _last = null;

        CommonTree param = null;
        CommonTree CONSTRUCTOR54 = null;
        CommonTree set55 = null;
        SqlGenerator.selectAtom_return e = default(SqlGenerator.selectAtom_return);

        SqlGenerator.constant_return c = default(SqlGenerator.constant_return);

        SqlGenerator.count_return count53 = default(SqlGenerator.count_return);

        SqlGenerator.selectColumn_return selectColumn56 = default(SqlGenerator.selectColumn_return);

        SqlGenerator.methodCall_return methodCall57 = default(SqlGenerator.methodCall_return);

        SqlGenerator.aggregate_return aggregate58 = default(SqlGenerator.aggregate_return);

        SqlGenerator.arithmeticExpr_return arithmeticExpr59 = default(SqlGenerator.arithmeticExpr_return);

        SqlGenerator.selectStatement_return selectStatement60 = default(SqlGenerator.selectStatement_return);


        CommonTree param_tree=null;
        CommonTree CONSTRUCTOR54_tree=null;
        CommonTree set55_tree=null;

        try 
    	{
            // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:128:2: (e= selectAtom | count | ^( CONSTRUCTOR ( DOT | IDENT ) ( selectColumn )+ ) | methodCall | aggregate | c= constant | arithmeticExpr | param= PARAM | selectStatement )
            int alt22 = 9;
            switch ( input.LA(1) ) 
            {
            case DOT:
            case ALIAS_REF:
            case SQL_TOKEN:
            case SELECT_EXPR:
            	{
                alt22 = 1;
                }
                break;
            case COUNT:
            	{
                alt22 = 2;
                }
                break;
            case CONSTRUCTOR:
            	{
                alt22 = 3;
                }
                break;
            case METHOD_CALL:
            	{
                alt22 = 4;
                }
                break;
            case AGGREGATE:
            	{
                alt22 = 5;
                }
                break;
            case FALSE:
            case TRUE:
            case CONSTANT:
            case NUM_INT:
            case NUM_DOUBLE:
            case NUM_FLOAT:
            case NUM_LONG:
            case JAVA_CONSTANT:
            case IDENT:
            case QUOTED_STRING:
            	{
                alt22 = 6;
                }
                break;
            case CASE:
            case CASE2:
            case UNARY_MINUS:
            case PLUS:
            case MINUS:
            case STAR:
            case DIV:
            	{
                alt22 = 7;
                }
                break;
            case PARAM:
            	{
                alt22 = 8;
                }
                break;
            case SELECT:
            	{
                alt22 = 9;
                }
                break;
            	default:
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    NoViableAltException nvae_d22s0 =
            	        new NoViableAltException("", 22, 0, input);

            	    throw nvae_d22s0;
            }

            switch (alt22) 
            {
                case 1 :
                    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:128:4: e= selectAtom
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	_last = (CommonTree)input.LT(1);
                    	PushFollow(FOLLOW_selectAtom_in_selectExpr581);
                    	e = selectAtom();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking==0 ) 
                    	adaptor.AddChild(root_0, e.Tree);
                    	if ( state.backtracking == 0 ) 
                    	{
                    	   Out(((e != null) ? ((CommonTree)e.Tree) : null)); 
                    	}

                    	if ( state.backtracking==0 ) {
                    	}
                    }
                    break;
                case 2 :
                    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:129:4: count
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	_last = (CommonTree)input.LT(1);
                    	PushFollow(FOLLOW_count_in_selectExpr588);
                    	count53 = count();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking==0 ) 
                    	adaptor.AddChild(root_0, count53.Tree);

                    	if ( state.backtracking==0 ) {
                    	}
                    }
                    break;
                case 3 :
                    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:130:4: ^( CONSTRUCTOR ( DOT | IDENT ) ( selectColumn )+ )
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	_last = (CommonTree)input.LT(1);
                    	{
                    	CommonTree _save_last_1 = _last;
                    	CommonTree _first_1 = null;
                    	CommonTree root_1 = (CommonTree)adaptor.GetNilNode();_last = (CommonTree)input.LT(1);
                    	CONSTRUCTOR54=(CommonTree)Match(input,CONSTRUCTOR,FOLLOW_CONSTRUCTOR_in_selectExpr594); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{CONSTRUCTOR54_tree = (CommonTree)adaptor.DupNode(CONSTRUCTOR54);

                    		root_1 = (CommonTree)adaptor.BecomeRoot(CONSTRUCTOR54_tree, root_1);
                    	}


                    	Match(input, Token.DOWN, null); if (state.failed) return retval;
                    	_last = (CommonTree)input.LT(1);
                    	set55 = (CommonTree)input.LT(1);
                    	if ( input.LA(1) == DOT || input.LA(1) == IDENT ) 
                    	{
                    	    input.Consume();

                    	    if ( state.backtracking==0 ) {
                    	    set55_tree = (CommonTree)adaptor.DupNode(set55);

                    	    adaptor.AddChild(root_1, set55_tree);
                    	    }
                    	    state.errorRecovery = false;state.failed = false;
                    	}
                    	else 
                    	{
                    	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                    	    MismatchedSetException mse = new MismatchedSetException(null,input);
                    	    throw mse;
                    	}

                    	// /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:130:32: ( selectColumn )+
                    	int cnt21 = 0;
                    	do 
                    	{
                    	    int alt21 = 2;
                    	    int LA21_0 = input.LA(1);

                    	    if ( (LA21_0 == COUNT || LA21_0 == DOT || LA21_0 == FALSE || LA21_0 == SELECT || LA21_0 == TRUE || LA21_0 == CASE || LA21_0 == AGGREGATE || (LA21_0 >= CONSTRUCTOR && LA21_0 <= CASE2) || LA21_0 == METHOD_CALL || LA21_0 == UNARY_MINUS || (LA21_0 >= CONSTANT && LA21_0 <= JAVA_CONSTANT) || (LA21_0 >= PLUS && LA21_0 <= DIV) || LA21_0 == PARAM || LA21_0 == IDENT || LA21_0 == ALIAS_REF || LA21_0 == SQL_TOKEN || LA21_0 == SELECT_EXPR || LA21_0 == QUOTED_STRING) )
                    	    {
                    	        alt21 = 1;
                    	    }


                    	    switch (alt21) 
                    		{
                    			case 1 :
                    			    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:130:34: selectColumn
                    			    {
                    			    	_last = (CommonTree)input.LT(1);
                    			    	PushFollow(FOLLOW_selectColumn_in_selectExpr606);
                    			    	selectColumn56 = selectColumn();
                    			    	state.followingStackPointer--;
                    			    	if (state.failed) return retval;
                    			    	if ( state.backtracking==0 ) 
                    			    	adaptor.AddChild(root_1, selectColumn56.Tree);

                    			    	if ( state.backtracking==0 ) {
                    			    	}
                    			    }
                    			    break;

                    			default:
                    			    if ( cnt21 >= 1 ) goto loop21;
                    			    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                    		            EarlyExitException eee =
                    		                new EarlyExitException(21, input);
                    		            throw eee;
                    	    }
                    	    cnt21++;
                    	} while (true);

                    	loop21:
                    		;	// Stops C# compiler whinging that label 'loop21' has no statements


                    	Match(input, Token.UP, null); if (state.failed) return retval;adaptor.AddChild(root_0, root_1);_last = _save_last_1;
                    	}


                    	if ( state.backtracking==0 ) {
                    	}
                    }
                    break;
                case 4 :
                    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:131:4: methodCall
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	_last = (CommonTree)input.LT(1);
                    	PushFollow(FOLLOW_methodCall_in_selectExpr616);
                    	methodCall57 = methodCall();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking==0 ) 
                    	adaptor.AddChild(root_0, methodCall57.Tree);

                    	if ( state.backtracking==0 ) {
                    	}
                    }
                    break;
                case 5 :
                    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:132:4: aggregate
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	_last = (CommonTree)input.LT(1);
                    	PushFollow(FOLLOW_aggregate_in_selectExpr621);
                    	aggregate58 = aggregate();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking==0 ) 
                    	adaptor.AddChild(root_0, aggregate58.Tree);

                    	if ( state.backtracking==0 ) {
                    	}
                    }
                    break;
                case 6 :
                    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:133:4: c= constant
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	_last = (CommonTree)input.LT(1);
                    	PushFollow(FOLLOW_constant_in_selectExpr628);
                    	c = constant();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking==0 ) 
                    	adaptor.AddChild(root_0, c.Tree);
                    	if ( state.backtracking == 0 ) 
                    	{
                    	   Out(((c != null) ? ((CommonTree)c.Tree) : null)); 
                    	}

                    	if ( state.backtracking==0 ) {
                    	}
                    }
                    break;
                case 7 :
                    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:134:4: arithmeticExpr
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	_last = (CommonTree)input.LT(1);
                    	PushFollow(FOLLOW_arithmeticExpr_in_selectExpr635);
                    	arithmeticExpr59 = arithmeticExpr();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking==0 ) 
                    	adaptor.AddChild(root_0, arithmeticExpr59.Tree);

                    	if ( state.backtracking==0 ) {
                    	}
                    }
                    break;
                case 8 :
                    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:135:4: param= PARAM
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	_last = (CommonTree)input.LT(1);
                    	param=(CommonTree)Match(input,PARAM,FOLLOW_PARAM_in_selectExpr642); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{param_tree = (CommonTree)adaptor.DupNode(param);

                    		adaptor.AddChild(root_0, param_tree);
                    	}
                    	if ( state.backtracking == 0 ) 
                    	{
                    	   Out(param); 
                    	}

                    	if ( state.backtracking==0 ) {
                    	}
                    }
                    break;
                case 9 :
                    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:137:4: selectStatement
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	if ( state.backtracking == 0 ) 
                    	{
                    	   Out("("); 
                    	}
                    	_last = (CommonTree)input.LT(1);
                    	PushFollow(FOLLOW_selectStatement_in_selectExpr652);
                    	selectStatement60 = selectStatement();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking==0 ) 
                    	adaptor.AddChild(root_0, selectStatement60.Tree);
                    	if ( state.backtracking == 0 ) 
                    	{
                    	   Out(")"); 
                    	}

                    	if ( state.backtracking==0 ) {
                    	}
                    }
                    break;

            }
            if ( state.backtracking==0 )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            }
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "selectExpr"

    public class count_return : TreeRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "count"
    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:140:1: count : ^( COUNT ( distinctOrAll )? countExpr ) ;
    public SqlGenerator.count_return count() // throws RecognitionException [1]
    {   
        SqlGenerator.count_return retval = new SqlGenerator.count_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        CommonTree _first_0 = null;
        CommonTree _last = null;

        CommonTree COUNT61 = null;
        SqlGenerator.distinctOrAll_return distinctOrAll62 = default(SqlGenerator.distinctOrAll_return);

        SqlGenerator.countExpr_return countExpr63 = default(SqlGenerator.countExpr_return);


        CommonTree COUNT61_tree=null;

        try 
    	{
            // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:141:2: ( ^( COUNT ( distinctOrAll )? countExpr ) )
            // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:141:4: ^( COUNT ( distinctOrAll )? countExpr )
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	_last = (CommonTree)input.LT(1);
            	{
            	CommonTree _save_last_1 = _last;
            	CommonTree _first_1 = null;
            	CommonTree root_1 = (CommonTree)adaptor.GetNilNode();_last = (CommonTree)input.LT(1);
            	COUNT61=(CommonTree)Match(input,COUNT,FOLLOW_COUNT_in_count666); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{COUNT61_tree = (CommonTree)adaptor.DupNode(COUNT61);

            		root_1 = (CommonTree)adaptor.BecomeRoot(COUNT61_tree, root_1);
            	}

            	if ( state.backtracking == 0 ) 
            	{
            	   Out("count("); 
            	}

            	Match(input, Token.DOWN, null); if (state.failed) return retval;
            	// /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:141:32: ( distinctOrAll )?
            	int alt23 = 2;
            	int LA23_0 = input.LA(1);

            	if ( (LA23_0 == ALL || LA23_0 == DISTINCT) )
            	{
            	    alt23 = 1;
            	}
            	switch (alt23) 
            	{
            	    case 1 :
            	        // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:141:34: distinctOrAll
            	        {
            	        	_last = (CommonTree)input.LT(1);
            	        	PushFollow(FOLLOW_distinctOrAll_in_count673);
            	        	distinctOrAll62 = distinctOrAll();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking==0 ) 
            	        	adaptor.AddChild(root_1, distinctOrAll62.Tree);

            	        	if ( state.backtracking==0 ) {
            	        	}
            	        }
            	        break;

            	}

            	_last = (CommonTree)input.LT(1);
            	PushFollow(FOLLOW_countExpr_in_count679);
            	countExpr63 = countExpr();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) 
            	adaptor.AddChild(root_1, countExpr63.Tree);
            	if ( state.backtracking == 0 ) 
            	{
            	   Out(")"); 
            	}

            	Match(input, Token.UP, null); if (state.failed) return retval;adaptor.AddChild(root_0, root_1);_last = _save_last_1;
            	}


            	if ( state.backtracking==0 ) {
            	}
            }

            if ( state.backtracking==0 )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            }
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "count"

    public class distinctOrAll_return : TreeRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "distinctOrAll"
    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:144:1: distinctOrAll : ( DISTINCT | ALL );
    public SqlGenerator.distinctOrAll_return distinctOrAll() // throws RecognitionException [1]
    {   
        SqlGenerator.distinctOrAll_return retval = new SqlGenerator.distinctOrAll_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        CommonTree _first_0 = null;
        CommonTree _last = null;

        CommonTree DISTINCT64 = null;
        CommonTree ALL65 = null;

        CommonTree DISTINCT64_tree=null;
        CommonTree ALL65_tree=null;

        try 
    	{
            // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:145:2: ( DISTINCT | ALL )
            int alt24 = 2;
            int LA24_0 = input.LA(1);

            if ( (LA24_0 == DISTINCT) )
            {
                alt24 = 1;
            }
            else if ( (LA24_0 == ALL) )
            {
                alt24 = 2;
            }
            else 
            {
                if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                NoViableAltException nvae_d24s0 =
                    new NoViableAltException("", 24, 0, input);

                throw nvae_d24s0;
            }
            switch (alt24) 
            {
                case 1 :
                    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:145:4: DISTINCT
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	_last = (CommonTree)input.LT(1);
                    	DISTINCT64=(CommonTree)Match(input,DISTINCT,FOLLOW_DISTINCT_in_distinctOrAll694); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{DISTINCT64_tree = (CommonTree)adaptor.DupNode(DISTINCT64);

                    		adaptor.AddChild(root_0, DISTINCT64_tree);
                    	}
                    	if ( state.backtracking == 0 ) 
                    	{
                    	   Out("distinct "); 
                    	}

                    	if ( state.backtracking==0 ) {
                    	}
                    }
                    break;
                case 2 :
                    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:146:4: ALL
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	_last = (CommonTree)input.LT(1);
                    	ALL65=(CommonTree)Match(input,ALL,FOLLOW_ALL_in_distinctOrAll701); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{ALL65_tree = (CommonTree)adaptor.DupNode(ALL65);

                    		adaptor.AddChild(root_0, ALL65_tree);
                    	}
                    	if ( state.backtracking == 0 ) 
                    	{
                    	   Out("all "); 
                    	}

                    	if ( state.backtracking==0 ) {
                    	}
                    }
                    break;

            }
            if ( state.backtracking==0 )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            }
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "distinctOrAll"

    public class countExpr_return : TreeRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "countExpr"
    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:149:1: countExpr : ( ROW_STAR | simpleExpr );
    public SqlGenerator.countExpr_return countExpr() // throws RecognitionException [1]
    {   
        SqlGenerator.countExpr_return retval = new SqlGenerator.countExpr_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        CommonTree _first_0 = null;
        CommonTree _last = null;

        CommonTree ROW_STAR66 = null;
        SqlGenerator.simpleExpr_return simpleExpr67 = default(SqlGenerator.simpleExpr_return);


        CommonTree ROW_STAR66_tree=null;

        try 
    	{
            // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:151:2: ( ROW_STAR | simpleExpr )
            int alt25 = 2;
            int LA25_0 = input.LA(1);

            if ( (LA25_0 == ROW_STAR) )
            {
                alt25 = 1;
            }
            else if ( (LA25_0 == COUNT || LA25_0 == DOT || LA25_0 == FALSE || LA25_0 == NULL || LA25_0 == TRUE || LA25_0 == CASE || LA25_0 == AGGREGATE || LA25_0 == CASE2 || LA25_0 == INDEX_OP || LA25_0 == METHOD_CALL || LA25_0 == UNARY_MINUS || (LA25_0 >= CONSTANT && LA25_0 <= JAVA_CONSTANT) || (LA25_0 >= PLUS && LA25_0 <= DIV) || LA25_0 == PARAM || LA25_0 == IDENT || LA25_0 == ALIAS_REF || LA25_0 == SQL_TOKEN || LA25_0 == NAMED_PARAM || LA25_0 == QUOTED_STRING) )
            {
                alt25 = 2;
            }
            else 
            {
                if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                NoViableAltException nvae_d25s0 =
                    new NoViableAltException("", 25, 0, input);

                throw nvae_d25s0;
            }
            switch (alt25) 
            {
                case 1 :
                    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:151:4: ROW_STAR
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	_last = (CommonTree)input.LT(1);
                    	ROW_STAR66=(CommonTree)Match(input,ROW_STAR,FOLLOW_ROW_STAR_in_countExpr716); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{ROW_STAR66_tree = (CommonTree)adaptor.DupNode(ROW_STAR66);

                    		adaptor.AddChild(root_0, ROW_STAR66_tree);
                    	}
                    	if ( state.backtracking == 0 ) 
                    	{
                    	   Out("*"); 
                    	}

                    	if ( state.backtracking==0 ) {
                    	}
                    }
                    break;
                case 2 :
                    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:152:4: simpleExpr
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	_last = (CommonTree)input.LT(1);
                    	PushFollow(FOLLOW_simpleExpr_in_countExpr723);
                    	simpleExpr67 = simpleExpr();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking==0 ) 
                    	adaptor.AddChild(root_0, simpleExpr67.Tree);

                    	if ( state.backtracking==0 ) {
                    	}
                    }
                    break;

            }
            if ( state.backtracking==0 )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            }
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "countExpr"

    public class selectAtom_return : TreeRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "selectAtom"
    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:155:1: selectAtom : ( DOT | SQL_TOKEN | ALIAS_REF | SELECT_EXPR );
    public SqlGenerator.selectAtom_return selectAtom() // throws RecognitionException [1]
    {   
        SqlGenerator.selectAtom_return retval = new SqlGenerator.selectAtom_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        CommonTree _first_0 = null;
        CommonTree _last = null;

        CommonTree set68 = null;

        CommonTree set68_tree=null;

        try 
    	{
            // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:156:2: ( DOT | SQL_TOKEN | ALIAS_REF | SELECT_EXPR )
            // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	_last = (CommonTree)input.LT(1);
            	set68 = (CommonTree)input.LT(1);
            	if ( input.LA(1) == DOT || input.LA(1) == ALIAS_REF || input.LA(1) == SQL_TOKEN || input.LA(1) == SELECT_EXPR ) 
            	{
            	    input.Consume();

            	    if ( state.backtracking==0 ) {
            	    set68_tree = (CommonTree)adaptor.DupNode(set68);

            	    adaptor.AddChild(root_0, set68_tree);
            	    }
            	    state.errorRecovery = false;state.failed = false;
            	}
            	else 
            	{
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	    throw mse;
            	}

            	if ( state.backtracking==0 ) {
            	} 

            }

            if ( state.backtracking==0 )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            }
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "selectAtom"

    public class from_return : TreeRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "from"
    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:167:1: from : ^(f= FROM ( fromTable )* ) ;
    public SqlGenerator.from_return from() // throws RecognitionException [1]
    {   
        SqlGenerator.from_return retval = new SqlGenerator.from_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        CommonTree _first_0 = null;
        CommonTree _last = null;

        CommonTree f = null;
        SqlGenerator.fromTable_return fromTable69 = default(SqlGenerator.fromTable_return);


        CommonTree f_tree=null;

        try 
    	{
            // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:168:2: ( ^(f= FROM ( fromTable )* ) )
            // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:168:4: ^(f= FROM ( fromTable )* )
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	_last = (CommonTree)input.LT(1);
            	{
            	CommonTree _save_last_1 = _last;
            	CommonTree _first_1 = null;
            	CommonTree root_1 = (CommonTree)adaptor.GetNilNode();_last = (CommonTree)input.LT(1);
            	f=(CommonTree)Match(input,FROM,FOLLOW_FROM_in_from768); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{f_tree = (CommonTree)adaptor.DupNode(f);

            		root_1 = (CommonTree)adaptor.BecomeRoot(f_tree, root_1);
            	}

            	if ( state.backtracking == 0 ) 
            	{
            	   Out(" from "); 
            	}

            	if ( input.LA(1) == Token.DOWN )
            	{
            	    Match(input, Token.DOWN, null); if (state.failed) return retval;
            	    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:169:3: ( fromTable )*
            	    do 
            	    {
            	        int alt26 = 2;
            	        int LA26_0 = input.LA(1);

            	        if ( (LA26_0 == FROM_FRAGMENT || LA26_0 == JOIN_FRAGMENT) )
            	        {
            	            alt26 = 1;
            	        }


            	        switch (alt26) 
            	    	{
            	    		case 1 :
            	    		    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:169:4: fromTable
            	    		    {
            	    		    	_last = (CommonTree)input.LT(1);
            	    		    	PushFollow(FOLLOW_fromTable_in_from775);
            	    		    	fromTable69 = fromTable();
            	    		    	state.followingStackPointer--;
            	    		    	if (state.failed) return retval;
            	    		    	if ( state.backtracking==0 ) 
            	    		    	adaptor.AddChild(root_1, fromTable69.Tree);

            	    		    	if ( state.backtracking==0 ) {
            	    		    	}
            	    		    }
            	    		    break;

            	    		default:
            	    		    goto loop26;
            	        }
            	    } while (true);

            	    loop26:
            	    	;	// Stops C# compiler whining that label 'loop26' has no statements


            	    Match(input, Token.UP, null); if (state.failed) return retval;
            	}adaptor.AddChild(root_0, root_1);_last = _save_last_1;
            	}


            	if ( state.backtracking==0 ) {
            	}
            }

            if ( state.backtracking==0 )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            }
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "from"

    public class fromTable_return : TreeRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "fromTable"
    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:172:1: fromTable : ( ^(a= FROM_FRAGMENT ( tableJoin[ a ] )* ) | ^(b= JOIN_FRAGMENT ( tableJoin[ b ] )* ) );
    public SqlGenerator.fromTable_return fromTable() // throws RecognitionException [1]
    {   
        SqlGenerator.fromTable_return retval = new SqlGenerator.fromTable_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        CommonTree _first_0 = null;
        CommonTree _last = null;

        CommonTree a = null;
        CommonTree b = null;
        SqlGenerator.tableJoin_return tableJoin70 = default(SqlGenerator.tableJoin_return);

        SqlGenerator.tableJoin_return tableJoin71 = default(SqlGenerator.tableJoin_return);


        CommonTree a_tree=null;
        CommonTree b_tree=null;

        try 
    	{
            // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:174:2: ( ^(a= FROM_FRAGMENT ( tableJoin[ a ] )* ) | ^(b= JOIN_FRAGMENT ( tableJoin[ b ] )* ) )
            int alt29 = 2;
            int LA29_0 = input.LA(1);

            if ( (LA29_0 == FROM_FRAGMENT) )
            {
                alt29 = 1;
            }
            else if ( (LA29_0 == JOIN_FRAGMENT) )
            {
                alt29 = 2;
            }
            else 
            {
                if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                NoViableAltException nvae_d29s0 =
                    new NoViableAltException("", 29, 0, input);

                throw nvae_d29s0;
            }
            switch (alt29) 
            {
                case 1 :
                    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:174:4: ^(a= FROM_FRAGMENT ( tableJoin[ a ] )* )
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	_last = (CommonTree)input.LT(1);
                    	{
                    	CommonTree _save_last_1 = _last;
                    	CommonTree _first_1 = null;
                    	CommonTree root_1 = (CommonTree)adaptor.GetNilNode();_last = (CommonTree)input.LT(1);
                    	a=(CommonTree)Match(input,FROM_FRAGMENT,FOLLOW_FROM_FRAGMENT_in_fromTable796); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{a_tree = (CommonTree)adaptor.DupNode(a);

                    		root_1 = (CommonTree)adaptor.BecomeRoot(a_tree, root_1);
                    	}

                    	if ( state.backtracking == 0 ) 
                    	{
                    	   Out(a); 
                    	}

                    	if ( input.LA(1) == Token.DOWN )
                    	{
                    	    Match(input, Token.DOWN, null); if (state.failed) return retval;
                    	    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:174:36: ( tableJoin[ a ] )*
                    	    do 
                    	    {
                    	        int alt27 = 2;
                    	        int LA27_0 = input.LA(1);

                    	        if ( (LA27_0 == FROM_FRAGMENT || LA27_0 == JOIN_FRAGMENT) )
                    	        {
                    	            alt27 = 1;
                    	        }


                    	        switch (alt27) 
                    	    	{
                    	    		case 1 :
                    	    		    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:174:37: tableJoin[ a ]
                    	    		    {
                    	    		    	_last = (CommonTree)input.LT(1);
                    	    		    	PushFollow(FOLLOW_tableJoin_in_fromTable802);
                    	    		    	tableJoin70 = tableJoin(a);
                    	    		    	state.followingStackPointer--;
                    	    		    	if (state.failed) return retval;
                    	    		    	if ( state.backtracking==0 ) 
                    	    		    	adaptor.AddChild(root_1, tableJoin70.Tree);

                    	    		    	if ( state.backtracking==0 ) {
                    	    		    	}
                    	    		    }
                    	    		    break;

                    	    		default:
                    	    		    goto loop27;
                    	        }
                    	    } while (true);

                    	    loop27:
                    	    	;	// Stops C# compiler whining that label 'loop27' has no statements

                    	    if ( state.backtracking == 0 ) 
                    	    {
                    	       fromFragmentSeparator(a); 
                    	    }

                    	    Match(input, Token.UP, null); if (state.failed) return retval;
                    	}adaptor.AddChild(root_0, root_1);_last = _save_last_1;
                    	}


                    	if ( state.backtracking==0 ) {
                    	}
                    }
                    break;
                case 2 :
                    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:175:4: ^(b= JOIN_FRAGMENT ( tableJoin[ b ] )* )
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	_last = (CommonTree)input.LT(1);
                    	{
                    	CommonTree _save_last_1 = _last;
                    	CommonTree _first_1 = null;
                    	CommonTree root_1 = (CommonTree)adaptor.GetNilNode();_last = (CommonTree)input.LT(1);
                    	b=(CommonTree)Match(input,JOIN_FRAGMENT,FOLLOW_JOIN_FRAGMENT_in_fromTable819); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{b_tree = (CommonTree)adaptor.DupNode(b);

                    		root_1 = (CommonTree)adaptor.BecomeRoot(b_tree, root_1);
                    	}

                    	if ( state.backtracking == 0 ) 
                    	{
                    	   Out(b); 
                    	}

                    	if ( input.LA(1) == Token.DOWN )
                    	{
                    	    Match(input, Token.DOWN, null); if (state.failed) return retval;
                    	    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:175:36: ( tableJoin[ b ] )*
                    	    do 
                    	    {
                    	        int alt28 = 2;
                    	        int LA28_0 = input.LA(1);

                    	        if ( (LA28_0 == FROM_FRAGMENT || LA28_0 == JOIN_FRAGMENT) )
                    	        {
                    	            alt28 = 1;
                    	        }


                    	        switch (alt28) 
                    	    	{
                    	    		case 1 :
                    	    		    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:175:37: tableJoin[ b ]
                    	    		    {
                    	    		    	_last = (CommonTree)input.LT(1);
                    	    		    	PushFollow(FOLLOW_tableJoin_in_fromTable825);
                    	    		    	tableJoin71 = tableJoin(b);
                    	    		    	state.followingStackPointer--;
                    	    		    	if (state.failed) return retval;
                    	    		    	if ( state.backtracking==0 ) 
                    	    		    	adaptor.AddChild(root_1, tableJoin71.Tree);

                    	    		    	if ( state.backtracking==0 ) {
                    	    		    	}
                    	    		    }
                    	    		    break;

                    	    		default:
                    	    		    goto loop28;
                    	        }
                    	    } while (true);

                    	    loop28:
                    	    	;	// Stops C# compiler whining that label 'loop28' has no statements

                    	    if ( state.backtracking == 0 ) 
                    	    {
                    	       fromFragmentSeparator(b); 
                    	    }

                    	    Match(input, Token.UP, null); if (state.failed) return retval;
                    	}adaptor.AddChild(root_0, root_1);_last = _save_last_1;
                    	}


                    	if ( state.backtracking==0 ) {
                    	}
                    }
                    break;

            }
            if ( state.backtracking==0 )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            }
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "fromTable"

    public class tableJoin_return : TreeRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "tableJoin"
    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:178:1: tableJoin[ ITree parent ] : ( ^(c= JOIN_FRAGMENT ( tableJoin[ c ] )* ) | ^(d= FROM_FRAGMENT ( tableJoin[ d ] )* ) );
    public SqlGenerator.tableJoin_return tableJoin(ITree parent) // throws RecognitionException [1]
    {   
        SqlGenerator.tableJoin_return retval = new SqlGenerator.tableJoin_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        CommonTree _first_0 = null;
        CommonTree _last = null;

        CommonTree c = null;
        CommonTree d = null;
        SqlGenerator.tableJoin_return tableJoin72 = default(SqlGenerator.tableJoin_return);

        SqlGenerator.tableJoin_return tableJoin73 = default(SqlGenerator.tableJoin_return);


        CommonTree c_tree=null;
        CommonTree d_tree=null;

        try 
    	{
            // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:179:2: ( ^(c= JOIN_FRAGMENT ( tableJoin[ c ] )* ) | ^(d= FROM_FRAGMENT ( tableJoin[ d ] )* ) )
            int alt32 = 2;
            int LA32_0 = input.LA(1);

            if ( (LA32_0 == JOIN_FRAGMENT) )
            {
                alt32 = 1;
            }
            else if ( (LA32_0 == FROM_FRAGMENT) )
            {
                alt32 = 2;
            }
            else 
            {
                if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                NoViableAltException nvae_d32s0 =
                    new NoViableAltException("", 32, 0, input);

                throw nvae_d32s0;
            }
            switch (alt32) 
            {
                case 1 :
                    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:179:4: ^(c= JOIN_FRAGMENT ( tableJoin[ c ] )* )
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	_last = (CommonTree)input.LT(1);
                    	{
                    	CommonTree _save_last_1 = _last;
                    	CommonTree _first_1 = null;
                    	CommonTree root_1 = (CommonTree)adaptor.GetNilNode();_last = (CommonTree)input.LT(1);
                    	c=(CommonTree)Match(input,JOIN_FRAGMENT,FOLLOW_JOIN_FRAGMENT_in_tableJoin850); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{c_tree = (CommonTree)adaptor.DupNode(c);

                    		root_1 = (CommonTree)adaptor.BecomeRoot(c_tree, root_1);
                    	}

                    	if ( state.backtracking == 0 ) 
                    	{
                    	   Out(" "); Out(c); 
                    	}

                    	if ( input.LA(1) == Token.DOWN )
                    	{
                    	    Match(input, Token.DOWN, null); if (state.failed) return retval;
                    	    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:179:46: ( tableJoin[ c ] )*
                    	    do 
                    	    {
                    	        int alt30 = 2;
                    	        int LA30_0 = input.LA(1);

                    	        if ( (LA30_0 == FROM_FRAGMENT || LA30_0 == JOIN_FRAGMENT) )
                    	        {
                    	            alt30 = 1;
                    	        }


                    	        switch (alt30) 
                    	    	{
                    	    		case 1 :
                    	    		    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:179:47: tableJoin[ c ]
                    	    		    {
                    	    		    	_last = (CommonTree)input.LT(1);
                    	    		    	PushFollow(FOLLOW_tableJoin_in_tableJoin855);
                    	    		    	tableJoin72 = tableJoin(c);
                    	    		    	state.followingStackPointer--;
                    	    		    	if (state.failed) return retval;
                    	    		    	if ( state.backtracking==0 ) 
                    	    		    	adaptor.AddChild(root_1, tableJoin72.Tree);

                    	    		    	if ( state.backtracking==0 ) {
                    	    		    	}
                    	    		    }
                    	    		    break;

                    	    		default:
                    	    		    goto loop30;
                    	        }
                    	    } while (true);

                    	    loop30:
                    	    	;	// Stops C# compiler whining that label 'loop30' has no statements


                    	    Match(input, Token.UP, null); if (state.failed) return retval;
                    	}adaptor.AddChild(root_0, root_1);_last = _save_last_1;
                    	}


                    	if ( state.backtracking==0 ) {
                    	}
                    }
                    break;
                case 2 :
                    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:180:4: ^(d= FROM_FRAGMENT ( tableJoin[ d ] )* )
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	_last = (CommonTree)input.LT(1);
                    	{
                    	CommonTree _save_last_1 = _last;
                    	CommonTree _first_1 = null;
                    	CommonTree root_1 = (CommonTree)adaptor.GetNilNode();_last = (CommonTree)input.LT(1);
                    	d=(CommonTree)Match(input,FROM_FRAGMENT,FOLLOW_FROM_FRAGMENT_in_tableJoin871); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{d_tree = (CommonTree)adaptor.DupNode(d);

                    		root_1 = (CommonTree)adaptor.BecomeRoot(d_tree, root_1);
                    	}

                    	if ( state.backtracking == 0 ) 
                    	{
                    	   nestedFromFragment(d,parent); 
                    	}

                    	if ( input.LA(1) == Token.DOWN )
                    	{
                    	    Match(input, Token.DOWN, null); if (state.failed) return retval;
                    	    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:180:58: ( tableJoin[ d ] )*
                    	    do 
                    	    {
                    	        int alt31 = 2;
                    	        int LA31_0 = input.LA(1);

                    	        if ( (LA31_0 == FROM_FRAGMENT || LA31_0 == JOIN_FRAGMENT) )
                    	        {
                    	            alt31 = 1;
                    	        }


                    	        switch (alt31) 
                    	    	{
                    	    		case 1 :
                    	    		    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:180:59: tableJoin[ d ]
                    	    		    {
                    	    		    	_last = (CommonTree)input.LT(1);
                    	    		    	PushFollow(FOLLOW_tableJoin_in_tableJoin876);
                    	    		    	tableJoin73 = tableJoin(d);
                    	    		    	state.followingStackPointer--;
                    	    		    	if (state.failed) return retval;
                    	    		    	if ( state.backtracking==0 ) 
                    	    		    	adaptor.AddChild(root_1, tableJoin73.Tree);

                    	    		    	if ( state.backtracking==0 ) {
                    	    		    	}
                    	    		    }
                    	    		    break;

                    	    		default:
                    	    		    goto loop31;
                    	        }
                    	    } while (true);

                    	    loop31:
                    	    	;	// Stops C# compiler whining that label 'loop31' has no statements


                    	    Match(input, Token.UP, null); if (state.failed) return retval;
                    	}adaptor.AddChild(root_0, root_1);_last = _save_last_1;
                    	}


                    	if ( state.backtracking==0 ) {
                    	}
                    }
                    break;

            }
            if ( state.backtracking==0 )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            }
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "tableJoin"

    public class booleanOp_return : TreeRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "booleanOp"
    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:183:1: booleanOp[ bool parens ] : ( ^( AND booleanExpr[true] booleanExpr[true] ) | ^( OR booleanExpr[false] booleanExpr[false] ) | ^( NOT booleanExpr[false] ) );
    public SqlGenerator.booleanOp_return booleanOp(bool parens) // throws RecognitionException [1]
    {   
        SqlGenerator.booleanOp_return retval = new SqlGenerator.booleanOp_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        CommonTree _first_0 = null;
        CommonTree _last = null;

        CommonTree AND74 = null;
        CommonTree OR77 = null;
        CommonTree NOT80 = null;
        SqlGenerator.booleanExpr_return booleanExpr75 = default(SqlGenerator.booleanExpr_return);

        SqlGenerator.booleanExpr_return booleanExpr76 = default(SqlGenerator.booleanExpr_return);

        SqlGenerator.booleanExpr_return booleanExpr78 = default(SqlGenerator.booleanExpr_return);

        SqlGenerator.booleanExpr_return booleanExpr79 = default(SqlGenerator.booleanExpr_return);

        SqlGenerator.booleanExpr_return booleanExpr81 = default(SqlGenerator.booleanExpr_return);


        CommonTree AND74_tree=null;
        CommonTree OR77_tree=null;
        CommonTree NOT80_tree=null;

        try 
    	{
            // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:184:2: ( ^( AND booleanExpr[true] booleanExpr[true] ) | ^( OR booleanExpr[false] booleanExpr[false] ) | ^( NOT booleanExpr[false] ) )
            int alt33 = 3;
            switch ( input.LA(1) ) 
            {
            case AND:
            	{
                alt33 = 1;
                }
                break;
            case OR:
            	{
                alt33 = 2;
                }
                break;
            case NOT:
            	{
                alt33 = 3;
                }
                break;
            	default:
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    NoViableAltException nvae_d33s0 =
            	        new NoViableAltException("", 33, 0, input);

            	    throw nvae_d33s0;
            }

            switch (alt33) 
            {
                case 1 :
                    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:184:4: ^( AND booleanExpr[true] booleanExpr[true] )
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	_last = (CommonTree)input.LT(1);
                    	{
                    	CommonTree _save_last_1 = _last;
                    	CommonTree _first_1 = null;
                    	CommonTree root_1 = (CommonTree)adaptor.GetNilNode();_last = (CommonTree)input.LT(1);
                    	AND74=(CommonTree)Match(input,AND,FOLLOW_AND_in_booleanOp896); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{AND74_tree = (CommonTree)adaptor.DupNode(AND74);

                    		root_1 = (CommonTree)adaptor.BecomeRoot(AND74_tree, root_1);
                    	}


                    	Match(input, Token.DOWN, null); if (state.failed) return retval;
                    	_last = (CommonTree)input.LT(1);
                    	PushFollow(FOLLOW_booleanExpr_in_booleanOp898);
                    	booleanExpr75 = booleanExpr(true);
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking==0 ) 
                    	adaptor.AddChild(root_1, booleanExpr75.Tree);
                    	if ( state.backtracking == 0 ) 
                    	{
                    	   Out(" and "); 
                    	}
                    	_last = (CommonTree)input.LT(1);
                    	PushFollow(FOLLOW_booleanExpr_in_booleanOp903);
                    	booleanExpr76 = booleanExpr(true);
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking==0 ) 
                    	adaptor.AddChild(root_1, booleanExpr76.Tree);

                    	Match(input, Token.UP, null); if (state.failed) return retval;adaptor.AddChild(root_0, root_1);_last = _save_last_1;
                    	}


                    	if ( state.backtracking==0 ) {
                    	}
                    }
                    break;
                case 2 :
                    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:185:4: ^( OR booleanExpr[false] booleanExpr[false] )
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	_last = (CommonTree)input.LT(1);
                    	{
                    	CommonTree _save_last_1 = _last;
                    	CommonTree _first_1 = null;
                    	CommonTree root_1 = (CommonTree)adaptor.GetNilNode();_last = (CommonTree)input.LT(1);
                    	OR77=(CommonTree)Match(input,OR,FOLLOW_OR_in_booleanOp911); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{OR77_tree = (CommonTree)adaptor.DupNode(OR77);

                    		root_1 = (CommonTree)adaptor.BecomeRoot(OR77_tree, root_1);
                    	}

                    	if ( state.backtracking == 0 ) 
                    	{
                    	   if (parens) Out("("); 
                    	}

                    	Match(input, Token.DOWN, null); if (state.failed) return retval;
                    	_last = (CommonTree)input.LT(1);
                    	PushFollow(FOLLOW_booleanExpr_in_booleanOp915);
                    	booleanExpr78 = booleanExpr(false);
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking==0 ) 
                    	adaptor.AddChild(root_1, booleanExpr78.Tree);
                    	if ( state.backtracking == 0 ) 
                    	{
                    	   Out(" or "); 
                    	}
                    	_last = (CommonTree)input.LT(1);
                    	PushFollow(FOLLOW_booleanExpr_in_booleanOp920);
                    	booleanExpr79 = booleanExpr(false);
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking==0 ) 
                    	adaptor.AddChild(root_1, booleanExpr79.Tree);
                    	if ( state.backtracking == 0 ) 
                    	{
                    	   if (parens) Out(")"); 
                    	}

                    	Match(input, Token.UP, null); if (state.failed) return retval;adaptor.AddChild(root_0, root_1);_last = _save_last_1;
                    	}


                    	if ( state.backtracking==0 ) {
                    	}
                    }
                    break;
                case 3 :
                    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:186:4: ^( NOT booleanExpr[false] )
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	_last = (CommonTree)input.LT(1);
                    	{
                    	CommonTree _save_last_1 = _last;
                    	CommonTree _first_1 = null;
                    	CommonTree root_1 = (CommonTree)adaptor.GetNilNode();_last = (CommonTree)input.LT(1);
                    	NOT80=(CommonTree)Match(input,NOT,FOLLOW_NOT_in_booleanOp930); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{NOT80_tree = (CommonTree)adaptor.DupNode(NOT80);

                    		root_1 = (CommonTree)adaptor.BecomeRoot(NOT80_tree, root_1);
                    	}

                    	if ( state.backtracking == 0 ) 
                    	{
                    	   Out(" not ("); 
                    	}

                    	Match(input, Token.DOWN, null); if (state.failed) return retval;
                    	_last = (CommonTree)input.LT(1);
                    	PushFollow(FOLLOW_booleanExpr_in_booleanOp934);
                    	booleanExpr81 = booleanExpr(false);
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking==0 ) 
                    	adaptor.AddChild(root_1, booleanExpr81.Tree);
                    	if ( state.backtracking == 0 ) 
                    	{
                    	   Out(")"); 
                    	}

                    	Match(input, Token.UP, null); if (state.failed) return retval;adaptor.AddChild(root_0, root_1);_last = _save_last_1;
                    	}


                    	if ( state.backtracking==0 ) {
                    	}
                    }
                    break;

            }
            if ( state.backtracking==0 )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            }
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "booleanOp"

    public class booleanExpr_return : TreeRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "booleanExpr"
    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:189:1: booleanExpr[ bool parens ] : ( booleanOp[ parens ] | comparisonExpr[ parens ] | st= SQL_TOKEN );
    public SqlGenerator.booleanExpr_return booleanExpr(bool parens) // throws RecognitionException [1]
    {   
        SqlGenerator.booleanExpr_return retval = new SqlGenerator.booleanExpr_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        CommonTree _first_0 = null;
        CommonTree _last = null;

        CommonTree st = null;
        SqlGenerator.booleanOp_return booleanOp82 = default(SqlGenerator.booleanOp_return);

        SqlGenerator.comparisonExpr_return comparisonExpr83 = default(SqlGenerator.comparisonExpr_return);


        CommonTree st_tree=null;

        try 
    	{
            // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:190:2: ( booleanOp[ parens ] | comparisonExpr[ parens ] | st= SQL_TOKEN )
            int alt34 = 3;
            switch ( input.LA(1) ) 
            {
            case AND:
            case NOT:
            case OR:
            	{
                alt34 = 1;
                }
                break;
            case BETWEEN:
            case EXISTS:
            case IN:
            case LIKE:
            case IS_NOT_NULL:
            case IS_NULL:
            case NOT_BETWEEN:
            case NOT_IN:
            case NOT_LIKE:
            case EQ:
            case NE:
            case LT:
            case GT:
            case LE:
            case GE:
            	{
                alt34 = 2;
                }
                break;
            case SQL_TOKEN:
            	{
                alt34 = 3;
                }
                break;
            	default:
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    NoViableAltException nvae_d34s0 =
            	        new NoViableAltException("", 34, 0, input);

            	    throw nvae_d34s0;
            }

            switch (alt34) 
            {
                case 1 :
                    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:190:4: booleanOp[ parens ]
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	_last = (CommonTree)input.LT(1);
                    	PushFollow(FOLLOW_booleanOp_in_booleanExpr951);
                    	booleanOp82 = booleanOp(parens);
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking==0 ) 
                    	adaptor.AddChild(root_0, booleanOp82.Tree);

                    	if ( state.backtracking==0 ) {
                    	}
                    }
                    break;
                case 2 :
                    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:191:4: comparisonExpr[ parens ]
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	_last = (CommonTree)input.LT(1);
                    	PushFollow(FOLLOW_comparisonExpr_in_booleanExpr958);
                    	comparisonExpr83 = comparisonExpr(parens);
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking==0 ) 
                    	adaptor.AddChild(root_0, comparisonExpr83.Tree);

                    	if ( state.backtracking==0 ) {
                    	}
                    }
                    break;
                case 3 :
                    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:192:4: st= SQL_TOKEN
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	_last = (CommonTree)input.LT(1);
                    	st=(CommonTree)Match(input,SQL_TOKEN,FOLLOW_SQL_TOKEN_in_booleanExpr967); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{st_tree = (CommonTree)adaptor.DupNode(st);

                    		adaptor.AddChild(root_0, st_tree);
                    	}
                    	if ( state.backtracking == 0 ) 
                    	{
                    	   Out(st); 
                    	}

                    	if ( state.backtracking==0 ) {
                    	}
                    }
                    break;

            }
            if ( state.backtracking==0 )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            }
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "booleanExpr"

    public class comparisonExpr_return : TreeRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "comparisonExpr"
    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:195:1: comparisonExpr[ bool parens ] : ( binaryComparisonExpression | exoticComparisonExpression );
    public SqlGenerator.comparisonExpr_return comparisonExpr(bool parens) // throws RecognitionException [1]
    {   
        SqlGenerator.comparisonExpr_return retval = new SqlGenerator.comparisonExpr_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        CommonTree _first_0 = null;
        CommonTree _last = null;

        SqlGenerator.binaryComparisonExpression_return binaryComparisonExpression84 = default(SqlGenerator.binaryComparisonExpression_return);

        SqlGenerator.exoticComparisonExpression_return exoticComparisonExpression85 = default(SqlGenerator.exoticComparisonExpression_return);



        try 
    	{
            // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:196:2: ( binaryComparisonExpression | exoticComparisonExpression )
            int alt35 = 2;
            int LA35_0 = input.LA(1);

            if ( (LA35_0 == EQ || LA35_0 == NE || (LA35_0 >= LT && LA35_0 <= GE)) )
            {
                alt35 = 1;
            }
            else if ( (LA35_0 == BETWEEN || LA35_0 == EXISTS || LA35_0 == IN || LA35_0 == LIKE || (LA35_0 >= IS_NOT_NULL && LA35_0 <= IS_NULL) || (LA35_0 >= NOT_BETWEEN && LA35_0 <= NOT_LIKE)) )
            {
                alt35 = 2;
            }
            else 
            {
                if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                NoViableAltException nvae_d35s0 =
                    new NoViableAltException("", 35, 0, input);

                throw nvae_d35s0;
            }
            switch (alt35) 
            {
                case 1 :
                    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:196:4: binaryComparisonExpression
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	_last = (CommonTree)input.LT(1);
                    	PushFollow(FOLLOW_binaryComparisonExpression_in_comparisonExpr983);
                    	binaryComparisonExpression84 = binaryComparisonExpression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking==0 ) 
                    	adaptor.AddChild(root_0, binaryComparisonExpression84.Tree);

                    	if ( state.backtracking==0 ) {
                    	}
                    }
                    break;
                case 2 :
                    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:197:4: exoticComparisonExpression
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	if ( state.backtracking == 0 ) 
                    	{
                    	   if (parens) Out("("); 
                    	}
                    	_last = (CommonTree)input.LT(1);
                    	PushFollow(FOLLOW_exoticComparisonExpression_in_comparisonExpr990);
                    	exoticComparisonExpression85 = exoticComparisonExpression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking==0 ) 
                    	adaptor.AddChild(root_0, exoticComparisonExpression85.Tree);
                    	if ( state.backtracking == 0 ) 
                    	{
                    	   if (parens) Out(")"); 
                    	}

                    	if ( state.backtracking==0 ) {
                    	}
                    }
                    break;

            }
            if ( state.backtracking==0 )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            }
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "comparisonExpr"

    public class binaryComparisonExpression_return : TreeRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "binaryComparisonExpression"
    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:200:1: binaryComparisonExpression : ( ^( EQ expr expr ) | ^( NE expr expr ) | ^( GT expr expr ) | ^( GE expr expr ) | ^( LT expr expr ) | ^( LE expr expr ) );
    public SqlGenerator.binaryComparisonExpression_return binaryComparisonExpression() // throws RecognitionException [1]
    {   
        SqlGenerator.binaryComparisonExpression_return retval = new SqlGenerator.binaryComparisonExpression_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        CommonTree _first_0 = null;
        CommonTree _last = null;

        CommonTree EQ86 = null;
        CommonTree NE89 = null;
        CommonTree GT92 = null;
        CommonTree GE95 = null;
        CommonTree LT98 = null;
        CommonTree LE101 = null;
        SqlGenerator.expr_return expr87 = default(SqlGenerator.expr_return);

        SqlGenerator.expr_return expr88 = default(SqlGenerator.expr_return);

        SqlGenerator.expr_return expr90 = default(SqlGenerator.expr_return);

        SqlGenerator.expr_return expr91 = default(SqlGenerator.expr_return);

        SqlGenerator.expr_return expr93 = default(SqlGenerator.expr_return);

        SqlGenerator.expr_return expr94 = default(SqlGenerator.expr_return);

        SqlGenerator.expr_return expr96 = default(SqlGenerator.expr_return);

        SqlGenerator.expr_return expr97 = default(SqlGenerator.expr_return);

        SqlGenerator.expr_return expr99 = default(SqlGenerator.expr_return);

        SqlGenerator.expr_return expr100 = default(SqlGenerator.expr_return);

        SqlGenerator.expr_return expr102 = default(SqlGenerator.expr_return);

        SqlGenerator.expr_return expr103 = default(SqlGenerator.expr_return);


        CommonTree EQ86_tree=null;
        CommonTree NE89_tree=null;
        CommonTree GT92_tree=null;
        CommonTree GE95_tree=null;
        CommonTree LT98_tree=null;
        CommonTree LE101_tree=null;

        try 
    	{
            // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:201:2: ( ^( EQ expr expr ) | ^( NE expr expr ) | ^( GT expr expr ) | ^( GE expr expr ) | ^( LT expr expr ) | ^( LE expr expr ) )
            int alt36 = 6;
            switch ( input.LA(1) ) 
            {
            case EQ:
            	{
                alt36 = 1;
                }
                break;
            case NE:
            	{
                alt36 = 2;
                }
                break;
            case GT:
            	{
                alt36 = 3;
                }
                break;
            case GE:
            	{
                alt36 = 4;
                }
                break;
            case LT:
            	{
                alt36 = 5;
                }
                break;
            case LE:
            	{
                alt36 = 6;
                }
                break;
            	default:
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    NoViableAltException nvae_d36s0 =
            	        new NoViableAltException("", 36, 0, input);

            	    throw nvae_d36s0;
            }

            switch (alt36) 
            {
                case 1 :
                    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:201:4: ^( EQ expr expr )
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	_last = (CommonTree)input.LT(1);
                    	{
                    	CommonTree _save_last_1 = _last;
                    	CommonTree _first_1 = null;
                    	CommonTree root_1 = (CommonTree)adaptor.GetNilNode();_last = (CommonTree)input.LT(1);
                    	EQ86=(CommonTree)Match(input,EQ,FOLLOW_EQ_in_binaryComparisonExpression1005); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{EQ86_tree = (CommonTree)adaptor.DupNode(EQ86);

                    		root_1 = (CommonTree)adaptor.BecomeRoot(EQ86_tree, root_1);
                    	}


                    	Match(input, Token.DOWN, null); if (state.failed) return retval;
                    	_last = (CommonTree)input.LT(1);
                    	PushFollow(FOLLOW_expr_in_binaryComparisonExpression1007);
                    	expr87 = expr();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking==0 ) 
                    	adaptor.AddChild(root_1, expr87.Tree);
                    	if ( state.backtracking == 0 ) 
                    	{
                    	   Out("="); 
                    	}
                    	_last = (CommonTree)input.LT(1);
                    	PushFollow(FOLLOW_expr_in_binaryComparisonExpression1011);
                    	expr88 = expr();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking==0 ) 
                    	adaptor.AddChild(root_1, expr88.Tree);

                    	Match(input, Token.UP, null); if (state.failed) return retval;adaptor.AddChild(root_0, root_1);_last = _save_last_1;
                    	}


                    	if ( state.backtracking==0 ) {
                    	}
                    }
                    break;
                case 2 :
                    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:202:4: ^( NE expr expr )
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	_last = (CommonTree)input.LT(1);
                    	{
                    	CommonTree _save_last_1 = _last;
                    	CommonTree _first_1 = null;
                    	CommonTree root_1 = (CommonTree)adaptor.GetNilNode();_last = (CommonTree)input.LT(1);
                    	NE89=(CommonTree)Match(input,NE,FOLLOW_NE_in_binaryComparisonExpression1018); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{NE89_tree = (CommonTree)adaptor.DupNode(NE89);

                    		root_1 = (CommonTree)adaptor.BecomeRoot(NE89_tree, root_1);
                    	}


                    	Match(input, Token.DOWN, null); if (state.failed) return retval;
                    	_last = (CommonTree)input.LT(1);
                    	PushFollow(FOLLOW_expr_in_binaryComparisonExpression1020);
                    	expr90 = expr();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking==0 ) 
                    	adaptor.AddChild(root_1, expr90.Tree);
                    	if ( state.backtracking == 0 ) 
                    	{
                    	   Out("<>"); 
                    	}
                    	_last = (CommonTree)input.LT(1);
                    	PushFollow(FOLLOW_expr_in_binaryComparisonExpression1024);
                    	expr91 = expr();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking==0 ) 
                    	adaptor.AddChild(root_1, expr91.Tree);

                    	Match(input, Token.UP, null); if (state.failed) return retval;adaptor.AddChild(root_0, root_1);_last = _save_last_1;
                    	}


                    	if ( state.backtracking==0 ) {
                    	}
                    }
                    break;
                case 3 :
                    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:203:4: ^( GT expr expr )
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	_last = (CommonTree)input.LT(1);
                    	{
                    	CommonTree _save_last_1 = _last;
                    	CommonTree _first_1 = null;
                    	CommonTree root_1 = (CommonTree)adaptor.GetNilNode();_last = (CommonTree)input.LT(1);
                    	GT92=(CommonTree)Match(input,GT,FOLLOW_GT_in_binaryComparisonExpression1031); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{GT92_tree = (CommonTree)adaptor.DupNode(GT92);

                    		root_1 = (CommonTree)adaptor.BecomeRoot(GT92_tree, root_1);
                    	}


                    	Match(input, Token.DOWN, null); if (state.failed) return retval;
                    	_last = (CommonTree)input.LT(1);
                    	PushFollow(FOLLOW_expr_in_binaryComparisonExpression1033);
                    	expr93 = expr();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking==0 ) 
                    	adaptor.AddChild(root_1, expr93.Tree);
                    	if ( state.backtracking == 0 ) 
                    	{
                    	   Out(">"); 
                    	}
                    	_last = (CommonTree)input.LT(1);
                    	PushFollow(FOLLOW_expr_in_binaryComparisonExpression1037);
                    	expr94 = expr();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking==0 ) 
                    	adaptor.AddChild(root_1, expr94.Tree);

                    	Match(input, Token.UP, null); if (state.failed) return retval;adaptor.AddChild(root_0, root_1);_last = _save_last_1;
                    	}


                    	if ( state.backtracking==0 ) {
                    	}
                    }
                    break;
                case 4 :
                    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:204:4: ^( GE expr expr )
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	_last = (CommonTree)input.LT(1);
                    	{
                    	CommonTree _save_last_1 = _last;
                    	CommonTree _first_1 = null;
                    	CommonTree root_1 = (CommonTree)adaptor.GetNilNode();_last = (CommonTree)input.LT(1);
                    	GE95=(CommonTree)Match(input,GE,FOLLOW_GE_in_binaryComparisonExpression1044); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{GE95_tree = (CommonTree)adaptor.DupNode(GE95);

                    		root_1 = (CommonTree)adaptor.BecomeRoot(GE95_tree, root_1);
                    	}


                    	Match(input, Token.DOWN, null); if (state.failed) return retval;
                    	_last = (CommonTree)input.LT(1);
                    	PushFollow(FOLLOW_expr_in_binaryComparisonExpression1046);
                    	expr96 = expr();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking==0 ) 
                    	adaptor.AddChild(root_1, expr96.Tree);
                    	if ( state.backtracking == 0 ) 
                    	{
                    	   Out(">="); 
                    	}
                    	_last = (CommonTree)input.LT(1);
                    	PushFollow(FOLLOW_expr_in_binaryComparisonExpression1050);
                    	expr97 = expr();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking==0 ) 
                    	adaptor.AddChild(root_1, expr97.Tree);

                    	Match(input, Token.UP, null); if (state.failed) return retval;adaptor.AddChild(root_0, root_1);_last = _save_last_1;
                    	}


                    	if ( state.backtracking==0 ) {
                    	}
                    }
                    break;
                case 5 :
                    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:205:4: ^( LT expr expr )
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	_last = (CommonTree)input.LT(1);
                    	{
                    	CommonTree _save_last_1 = _last;
                    	CommonTree _first_1 = null;
                    	CommonTree root_1 = (CommonTree)adaptor.GetNilNode();_last = (CommonTree)input.LT(1);
                    	LT98=(CommonTree)Match(input,LT,FOLLOW_LT_in_binaryComparisonExpression1057); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{LT98_tree = (CommonTree)adaptor.DupNode(LT98);

                    		root_1 = (CommonTree)adaptor.BecomeRoot(LT98_tree, root_1);
                    	}


                    	Match(input, Token.DOWN, null); if (state.failed) return retval;
                    	_last = (CommonTree)input.LT(1);
                    	PushFollow(FOLLOW_expr_in_binaryComparisonExpression1059);
                    	expr99 = expr();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking==0 ) 
                    	adaptor.AddChild(root_1, expr99.Tree);
                    	if ( state.backtracking == 0 ) 
                    	{
                    	   Out("<"); 
                    	}
                    	_last = (CommonTree)input.LT(1);
                    	PushFollow(FOLLOW_expr_in_binaryComparisonExpression1063);
                    	expr100 = expr();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking==0 ) 
                    	adaptor.AddChild(root_1, expr100.Tree);

                    	Match(input, Token.UP, null); if (state.failed) return retval;adaptor.AddChild(root_0, root_1);_last = _save_last_1;
                    	}


                    	if ( state.backtracking==0 ) {
                    	}
                    }
                    break;
                case 6 :
                    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:206:4: ^( LE expr expr )
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	_last = (CommonTree)input.LT(1);
                    	{
                    	CommonTree _save_last_1 = _last;
                    	CommonTree _first_1 = null;
                    	CommonTree root_1 = (CommonTree)adaptor.GetNilNode();_last = (CommonTree)input.LT(1);
                    	LE101=(CommonTree)Match(input,LE,FOLLOW_LE_in_binaryComparisonExpression1070); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{LE101_tree = (CommonTree)adaptor.DupNode(LE101);

                    		root_1 = (CommonTree)adaptor.BecomeRoot(LE101_tree, root_1);
                    	}


                    	Match(input, Token.DOWN, null); if (state.failed) return retval;
                    	_last = (CommonTree)input.LT(1);
                    	PushFollow(FOLLOW_expr_in_binaryComparisonExpression1072);
                    	expr102 = expr();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking==0 ) 
                    	adaptor.AddChild(root_1, expr102.Tree);
                    	if ( state.backtracking == 0 ) 
                    	{
                    	   Out("<="); 
                    	}
                    	_last = (CommonTree)input.LT(1);
                    	PushFollow(FOLLOW_expr_in_binaryComparisonExpression1076);
                    	expr103 = expr();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking==0 ) 
                    	adaptor.AddChild(root_1, expr103.Tree);

                    	Match(input, Token.UP, null); if (state.failed) return retval;adaptor.AddChild(root_0, root_1);_last = _save_last_1;
                    	}


                    	if ( state.backtracking==0 ) {
                    	}
                    }
                    break;

            }
            if ( state.backtracking==0 )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            }
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "binaryComparisonExpression"

    public class exoticComparisonExpression_return : TreeRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "exoticComparisonExpression"
    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:209:1: exoticComparisonExpression : ( ^( LIKE expr expr likeEscape ) | ^( NOT_LIKE expr expr likeEscape ) | ^( BETWEEN expr expr expr ) | ^( NOT_BETWEEN expr expr expr ) | ^( IN expr inList ) | ^( NOT_IN expr inList ) | ^( EXISTS quantified ) | ^( IS_NULL expr ) | ^( IS_NOT_NULL expr ) );
    public SqlGenerator.exoticComparisonExpression_return exoticComparisonExpression() // throws RecognitionException [1]
    {   
        SqlGenerator.exoticComparisonExpression_return retval = new SqlGenerator.exoticComparisonExpression_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        CommonTree _first_0 = null;
        CommonTree _last = null;

        CommonTree LIKE104 = null;
        CommonTree NOT_LIKE108 = null;
        CommonTree BETWEEN112 = null;
        CommonTree NOT_BETWEEN116 = null;
        CommonTree IN120 = null;
        CommonTree NOT_IN123 = null;
        CommonTree EXISTS126 = null;
        CommonTree IS_NULL128 = null;
        CommonTree IS_NOT_NULL130 = null;
        SqlGenerator.expr_return expr105 = default(SqlGenerator.expr_return);

        SqlGenerator.expr_return expr106 = default(SqlGenerator.expr_return);

        SqlGenerator.likeEscape_return likeEscape107 = default(SqlGenerator.likeEscape_return);

        SqlGenerator.expr_return expr109 = default(SqlGenerator.expr_return);

        SqlGenerator.expr_return expr110 = default(SqlGenerator.expr_return);

        SqlGenerator.likeEscape_return likeEscape111 = default(SqlGenerator.likeEscape_return);

        SqlGenerator.expr_return expr113 = default(SqlGenerator.expr_return);

        SqlGenerator.expr_return expr114 = default(SqlGenerator.expr_return);

        SqlGenerator.expr_return expr115 = default(SqlGenerator.expr_return);

        SqlGenerator.expr_return expr117 = default(SqlGenerator.expr_return);

        SqlGenerator.expr_return expr118 = default(SqlGenerator.expr_return);

        SqlGenerator.expr_return expr119 = default(SqlGenerator.expr_return);

        SqlGenerator.expr_return expr121 = default(SqlGenerator.expr_return);

        SqlGenerator.inList_return inList122 = default(SqlGenerator.inList_return);

        SqlGenerator.expr_return expr124 = default(SqlGenerator.expr_return);

        SqlGenerator.inList_return inList125 = default(SqlGenerator.inList_return);

        SqlGenerator.quantified_return quantified127 = default(SqlGenerator.quantified_return);

        SqlGenerator.expr_return expr129 = default(SqlGenerator.expr_return);

        SqlGenerator.expr_return expr131 = default(SqlGenerator.expr_return);


        CommonTree LIKE104_tree=null;
        CommonTree NOT_LIKE108_tree=null;
        CommonTree BETWEEN112_tree=null;
        CommonTree NOT_BETWEEN116_tree=null;
        CommonTree IN120_tree=null;
        CommonTree NOT_IN123_tree=null;
        CommonTree EXISTS126_tree=null;
        CommonTree IS_NULL128_tree=null;
        CommonTree IS_NOT_NULL130_tree=null;

        try 
    	{
            // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:210:2: ( ^( LIKE expr expr likeEscape ) | ^( NOT_LIKE expr expr likeEscape ) | ^( BETWEEN expr expr expr ) | ^( NOT_BETWEEN expr expr expr ) | ^( IN expr inList ) | ^( NOT_IN expr inList ) | ^( EXISTS quantified ) | ^( IS_NULL expr ) | ^( IS_NOT_NULL expr ) )
            int alt37 = 9;
            switch ( input.LA(1) ) 
            {
            case LIKE:
            	{
                alt37 = 1;
                }
                break;
            case NOT_LIKE:
            	{
                alt37 = 2;
                }
                break;
            case BETWEEN:
            	{
                alt37 = 3;
                }
                break;
            case NOT_BETWEEN:
            	{
                alt37 = 4;
                }
                break;
            case IN:
            	{
                alt37 = 5;
                }
                break;
            case NOT_IN:
            	{
                alt37 = 6;
                }
                break;
            case EXISTS:
            	{
                alt37 = 7;
                }
                break;
            case IS_NULL:
            	{
                alt37 = 8;
                }
                break;
            case IS_NOT_NULL:
            	{
                alt37 = 9;
                }
                break;
            	default:
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    NoViableAltException nvae_d37s0 =
            	        new NoViableAltException("", 37, 0, input);

            	    throw nvae_d37s0;
            }

            switch (alt37) 
            {
                case 1 :
                    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:210:4: ^( LIKE expr expr likeEscape )
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	_last = (CommonTree)input.LT(1);
                    	{
                    	CommonTree _save_last_1 = _last;
                    	CommonTree _first_1 = null;
                    	CommonTree root_1 = (CommonTree)adaptor.GetNilNode();_last = (CommonTree)input.LT(1);
                    	LIKE104=(CommonTree)Match(input,LIKE,FOLLOW_LIKE_in_exoticComparisonExpression1090); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{LIKE104_tree = (CommonTree)adaptor.DupNode(LIKE104);

                    		root_1 = (CommonTree)adaptor.BecomeRoot(LIKE104_tree, root_1);
                    	}


                    	Match(input, Token.DOWN, null); if (state.failed) return retval;
                    	_last = (CommonTree)input.LT(1);
                    	PushFollow(FOLLOW_expr_in_exoticComparisonExpression1092);
                    	expr105 = expr();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking==0 ) 
                    	adaptor.AddChild(root_1, expr105.Tree);
                    	if ( state.backtracking == 0 ) 
                    	{
                    	   Out(" like "); 
                    	}
                    	_last = (CommonTree)input.LT(1);
                    	PushFollow(FOLLOW_expr_in_exoticComparisonExpression1096);
                    	expr106 = expr();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking==0 ) 
                    	adaptor.AddChild(root_1, expr106.Tree);
                    	_last = (CommonTree)input.LT(1);
                    	PushFollow(FOLLOW_likeEscape_in_exoticComparisonExpression1098);
                    	likeEscape107 = likeEscape();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking==0 ) 
                    	adaptor.AddChild(root_1, likeEscape107.Tree);

                    	Match(input, Token.UP, null); if (state.failed) return retval;adaptor.AddChild(root_0, root_1);_last = _save_last_1;
                    	}


                    	if ( state.backtracking==0 ) {
                    	}
                    }
                    break;
                case 2 :
                    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:211:4: ^( NOT_LIKE expr expr likeEscape )
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	_last = (CommonTree)input.LT(1);
                    	{
                    	CommonTree _save_last_1 = _last;
                    	CommonTree _first_1 = null;
                    	CommonTree root_1 = (CommonTree)adaptor.GetNilNode();_last = (CommonTree)input.LT(1);
                    	NOT_LIKE108=(CommonTree)Match(input,NOT_LIKE,FOLLOW_NOT_LIKE_in_exoticComparisonExpression1106); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{NOT_LIKE108_tree = (CommonTree)adaptor.DupNode(NOT_LIKE108);

                    		root_1 = (CommonTree)adaptor.BecomeRoot(NOT_LIKE108_tree, root_1);
                    	}


                    	Match(input, Token.DOWN, null); if (state.failed) return retval;
                    	_last = (CommonTree)input.LT(1);
                    	PushFollow(FOLLOW_expr_in_exoticComparisonExpression1108);
                    	expr109 = expr();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking==0 ) 
                    	adaptor.AddChild(root_1, expr109.Tree);
                    	if ( state.backtracking == 0 ) 
                    	{
                    	   Out(" not like "); 
                    	}
                    	_last = (CommonTree)input.LT(1);
                    	PushFollow(FOLLOW_expr_in_exoticComparisonExpression1112);
                    	expr110 = expr();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking==0 ) 
                    	adaptor.AddChild(root_1, expr110.Tree);
                    	_last = (CommonTree)input.LT(1);
                    	PushFollow(FOLLOW_likeEscape_in_exoticComparisonExpression1114);
                    	likeEscape111 = likeEscape();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking==0 ) 
                    	adaptor.AddChild(root_1, likeEscape111.Tree);

                    	Match(input, Token.UP, null); if (state.failed) return retval;adaptor.AddChild(root_0, root_1);_last = _save_last_1;
                    	}


                    	if ( state.backtracking==0 ) {
                    	}
                    }
                    break;
                case 3 :
                    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:212:4: ^( BETWEEN expr expr expr )
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	_last = (CommonTree)input.LT(1);
                    	{
                    	CommonTree _save_last_1 = _last;
                    	CommonTree _first_1 = null;
                    	CommonTree root_1 = (CommonTree)adaptor.GetNilNode();_last = (CommonTree)input.LT(1);
                    	BETWEEN112=(CommonTree)Match(input,BETWEEN,FOLLOW_BETWEEN_in_exoticComparisonExpression1121); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{BETWEEN112_tree = (CommonTree)adaptor.DupNode(BETWEEN112);

                    		root_1 = (CommonTree)adaptor.BecomeRoot(BETWEEN112_tree, root_1);
                    	}


                    	Match(input, Token.DOWN, null); if (state.failed) return retval;
                    	_last = (CommonTree)input.LT(1);
                    	PushFollow(FOLLOW_expr_in_exoticComparisonExpression1123);
                    	expr113 = expr();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking==0 ) 
                    	adaptor.AddChild(root_1, expr113.Tree);
                    	if ( state.backtracking == 0 ) 
                    	{
                    	   Out(" between "); 
                    	}
                    	_last = (CommonTree)input.LT(1);
                    	PushFollow(FOLLOW_expr_in_exoticComparisonExpression1127);
                    	expr114 = expr();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking==0 ) 
                    	adaptor.AddChild(root_1, expr114.Tree);
                    	if ( state.backtracking == 0 ) 
                    	{
                    	   Out(" and "); 
                    	}
                    	_last = (CommonTree)input.LT(1);
                    	PushFollow(FOLLOW_expr_in_exoticComparisonExpression1131);
                    	expr115 = expr();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking==0 ) 
                    	adaptor.AddChild(root_1, expr115.Tree);

                    	Match(input, Token.UP, null); if (state.failed) return retval;adaptor.AddChild(root_0, root_1);_last = _save_last_1;
                    	}


                    	if ( state.backtracking==0 ) {
                    	}
                    }
                    break;
                case 4 :
                    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:213:4: ^( NOT_BETWEEN expr expr expr )
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	_last = (CommonTree)input.LT(1);
                    	{
                    	CommonTree _save_last_1 = _last;
                    	CommonTree _first_1 = null;
                    	CommonTree root_1 = (CommonTree)adaptor.GetNilNode();_last = (CommonTree)input.LT(1);
                    	NOT_BETWEEN116=(CommonTree)Match(input,NOT_BETWEEN,FOLLOW_NOT_BETWEEN_in_exoticComparisonExpression1138); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{NOT_BETWEEN116_tree = (CommonTree)adaptor.DupNode(NOT_BETWEEN116);

                    		root_1 = (CommonTree)adaptor.BecomeRoot(NOT_BETWEEN116_tree, root_1);
                    	}


                    	Match(input, Token.DOWN, null); if (state.failed) return retval;
                    	_last = (CommonTree)input.LT(1);
                    	PushFollow(FOLLOW_expr_in_exoticComparisonExpression1140);
                    	expr117 = expr();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking==0 ) 
                    	adaptor.AddChild(root_1, expr117.Tree);
                    	if ( state.backtracking == 0 ) 
                    	{
                    	   Out(" not between "); 
                    	}
                    	_last = (CommonTree)input.LT(1);
                    	PushFollow(FOLLOW_expr_in_exoticComparisonExpression1144);
                    	expr118 = expr();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking==0 ) 
                    	adaptor.AddChild(root_1, expr118.Tree);
                    	if ( state.backtracking == 0 ) 
                    	{
                    	   Out(" and "); 
                    	}
                    	_last = (CommonTree)input.LT(1);
                    	PushFollow(FOLLOW_expr_in_exoticComparisonExpression1148);
                    	expr119 = expr();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking==0 ) 
                    	adaptor.AddChild(root_1, expr119.Tree);

                    	Match(input, Token.UP, null); if (state.failed) return retval;adaptor.AddChild(root_0, root_1);_last = _save_last_1;
                    	}


                    	if ( state.backtracking==0 ) {
                    	}
                    }
                    break;
                case 5 :
                    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:214:4: ^( IN expr inList )
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	_last = (CommonTree)input.LT(1);
                    	{
                    	CommonTree _save_last_1 = _last;
                    	CommonTree _first_1 = null;
                    	CommonTree root_1 = (CommonTree)adaptor.GetNilNode();_last = (CommonTree)input.LT(1);
                    	IN120=(CommonTree)Match(input,IN,FOLLOW_IN_in_exoticComparisonExpression1155); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{IN120_tree = (CommonTree)adaptor.DupNode(IN120);

                    		root_1 = (CommonTree)adaptor.BecomeRoot(IN120_tree, root_1);
                    	}


                    	Match(input, Token.DOWN, null); if (state.failed) return retval;
                    	_last = (CommonTree)input.LT(1);
                    	PushFollow(FOLLOW_expr_in_exoticComparisonExpression1157);
                    	expr121 = expr();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking==0 ) 
                    	adaptor.AddChild(root_1, expr121.Tree);
                    	if ( state.backtracking == 0 ) 
                    	{
                    	   Out(" in"); 
                    	}
                    	_last = (CommonTree)input.LT(1);
                    	PushFollow(FOLLOW_inList_in_exoticComparisonExpression1161);
                    	inList122 = inList();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking==0 ) 
                    	adaptor.AddChild(root_1, inList122.Tree);

                    	Match(input, Token.UP, null); if (state.failed) return retval;adaptor.AddChild(root_0, root_1);_last = _save_last_1;
                    	}


                    	if ( state.backtracking==0 ) {
                    	}
                    }
                    break;
                case 6 :
                    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:215:4: ^( NOT_IN expr inList )
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	_last = (CommonTree)input.LT(1);
                    	{
                    	CommonTree _save_last_1 = _last;
                    	CommonTree _first_1 = null;
                    	CommonTree root_1 = (CommonTree)adaptor.GetNilNode();_last = (CommonTree)input.LT(1);
                    	NOT_IN123=(CommonTree)Match(input,NOT_IN,FOLLOW_NOT_IN_in_exoticComparisonExpression1169); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{NOT_IN123_tree = (CommonTree)adaptor.DupNode(NOT_IN123);

                    		root_1 = (CommonTree)adaptor.BecomeRoot(NOT_IN123_tree, root_1);
                    	}


                    	Match(input, Token.DOWN, null); if (state.failed) return retval;
                    	_last = (CommonTree)input.LT(1);
                    	PushFollow(FOLLOW_expr_in_exoticComparisonExpression1171);
                    	expr124 = expr();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking==0 ) 
                    	adaptor.AddChild(root_1, expr124.Tree);
                    	if ( state.backtracking == 0 ) 
                    	{
                    	   Out(" not in "); 
                    	}
                    	_last = (CommonTree)input.LT(1);
                    	PushFollow(FOLLOW_inList_in_exoticComparisonExpression1175);
                    	inList125 = inList();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking==0 ) 
                    	adaptor.AddChild(root_1, inList125.Tree);

                    	Match(input, Token.UP, null); if (state.failed) return retval;adaptor.AddChild(root_0, root_1);_last = _save_last_1;
                    	}


                    	if ( state.backtracking==0 ) {
                    	}
                    }
                    break;
                case 7 :
                    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:216:4: ^( EXISTS quantified )
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	_last = (CommonTree)input.LT(1);
                    	{
                    	CommonTree _save_last_1 = _last;
                    	CommonTree _first_1 = null;
                    	CommonTree root_1 = (CommonTree)adaptor.GetNilNode();_last = (CommonTree)input.LT(1);
                    	EXISTS126=(CommonTree)Match(input,EXISTS,FOLLOW_EXISTS_in_exoticComparisonExpression1183); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{EXISTS126_tree = (CommonTree)adaptor.DupNode(EXISTS126);

                    		root_1 = (CommonTree)adaptor.BecomeRoot(EXISTS126_tree, root_1);
                    	}

                    	if ( state.backtracking == 0 ) 
                    	{
                    	   optionalSpace(); Out("exists "); 
                    	}

                    	Match(input, Token.DOWN, null); if (state.failed) return retval;
                    	_last = (CommonTree)input.LT(1);
                    	PushFollow(FOLLOW_quantified_in_exoticComparisonExpression1187);
                    	quantified127 = quantified();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking==0 ) 
                    	adaptor.AddChild(root_1, quantified127.Tree);

                    	Match(input, Token.UP, null); if (state.failed) return retval;adaptor.AddChild(root_0, root_1);_last = _save_last_1;
                    	}


                    	if ( state.backtracking==0 ) {
                    	}
                    }
                    break;
                case 8 :
                    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:217:4: ^( IS_NULL expr )
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	_last = (CommonTree)input.LT(1);
                    	{
                    	CommonTree _save_last_1 = _last;
                    	CommonTree _first_1 = null;
                    	CommonTree root_1 = (CommonTree)adaptor.GetNilNode();_last = (CommonTree)input.LT(1);
                    	IS_NULL128=(CommonTree)Match(input,IS_NULL,FOLLOW_IS_NULL_in_exoticComparisonExpression1195); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{IS_NULL128_tree = (CommonTree)adaptor.DupNode(IS_NULL128);

                    		root_1 = (CommonTree)adaptor.BecomeRoot(IS_NULL128_tree, root_1);
                    	}


                    	Match(input, Token.DOWN, null); if (state.failed) return retval;
                    	_last = (CommonTree)input.LT(1);
                    	PushFollow(FOLLOW_expr_in_exoticComparisonExpression1197);
                    	expr129 = expr();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking==0 ) 
                    	adaptor.AddChild(root_1, expr129.Tree);

                    	Match(input, Token.UP, null); if (state.failed) return retval;adaptor.AddChild(root_0, root_1);_last = _save_last_1;
                    	}

                    	if ( state.backtracking == 0 ) 
                    	{
                    	   Out(" is null"); 
                    	}

                    	if ( state.backtracking==0 ) {
                    	}
                    }
                    break;
                case 9 :
                    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:218:4: ^( IS_NOT_NULL expr )
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	_last = (CommonTree)input.LT(1);
                    	{
                    	CommonTree _save_last_1 = _last;
                    	CommonTree _first_1 = null;
                    	CommonTree root_1 = (CommonTree)adaptor.GetNilNode();_last = (CommonTree)input.LT(1);
                    	IS_NOT_NULL130=(CommonTree)Match(input,IS_NOT_NULL,FOLLOW_IS_NOT_NULL_in_exoticComparisonExpression1206); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{IS_NOT_NULL130_tree = (CommonTree)adaptor.DupNode(IS_NOT_NULL130);

                    		root_1 = (CommonTree)adaptor.BecomeRoot(IS_NOT_NULL130_tree, root_1);
                    	}


                    	Match(input, Token.DOWN, null); if (state.failed) return retval;
                    	_last = (CommonTree)input.LT(1);
                    	PushFollow(FOLLOW_expr_in_exoticComparisonExpression1208);
                    	expr131 = expr();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking==0 ) 
                    	adaptor.AddChild(root_1, expr131.Tree);

                    	Match(input, Token.UP, null); if (state.failed) return retval;adaptor.AddChild(root_0, root_1);_last = _save_last_1;
                    	}

                    	if ( state.backtracking == 0 ) 
                    	{
                    	   Out(" is not null"); 
                    	}

                    	if ( state.backtracking==0 ) {
                    	}
                    }
                    break;

            }
            if ( state.backtracking==0 )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            }
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "exoticComparisonExpression"

    public class likeEscape_return : TreeRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "likeEscape"
    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:221:1: likeEscape : ( ^( ESCAPE expr ) )? ;
    public SqlGenerator.likeEscape_return likeEscape() // throws RecognitionException [1]
    {   
        SqlGenerator.likeEscape_return retval = new SqlGenerator.likeEscape_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        CommonTree _first_0 = null;
        CommonTree _last = null;

        CommonTree ESCAPE132 = null;
        SqlGenerator.expr_return expr133 = default(SqlGenerator.expr_return);


        CommonTree ESCAPE132_tree=null;

        try 
    	{
            // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:222:2: ( ( ^( ESCAPE expr ) )? )
            // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:222:4: ( ^( ESCAPE expr ) )?
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	// /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:222:4: ( ^( ESCAPE expr ) )?
            	int alt38 = 2;
            	int LA38_0 = input.LA(1);

            	if ( (LA38_0 == ESCAPE) )
            	{
            	    alt38 = 1;
            	}
            	switch (alt38) 
            	{
            	    case 1 :
            	        // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:222:6: ^( ESCAPE expr )
            	        {
            	        	_last = (CommonTree)input.LT(1);
            	        	{
            	        	CommonTree _save_last_1 = _last;
            	        	CommonTree _first_1 = null;
            	        	CommonTree root_1 = (CommonTree)adaptor.GetNilNode();_last = (CommonTree)input.LT(1);
            	        	ESCAPE132=(CommonTree)Match(input,ESCAPE,FOLLOW_ESCAPE_in_likeEscape1225); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{ESCAPE132_tree = (CommonTree)adaptor.DupNode(ESCAPE132);

            	        		root_1 = (CommonTree)adaptor.BecomeRoot(ESCAPE132_tree, root_1);
            	        	}

            	        	if ( state.backtracking == 0 ) 
            	        	{
            	        	   Out(" escape "); 
            	        	}

            	        	Match(input, Token.DOWN, null); if (state.failed) return retval;
            	        	_last = (CommonTree)input.LT(1);
            	        	PushFollow(FOLLOW_expr_in_likeEscape1229);
            	        	expr133 = expr();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking==0 ) 
            	        	adaptor.AddChild(root_1, expr133.Tree);

            	        	Match(input, Token.UP, null); if (state.failed) return retval;adaptor.AddChild(root_0, root_1);_last = _save_last_1;
            	        	}


            	        	if ( state.backtracking==0 ) {
            	        	}
            	        }
            	        break;

            	}


            	if ( state.backtracking==0 ) {
            	}
            }

            if ( state.backtracking==0 )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            }
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "likeEscape"

    public class inList_return : TreeRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "inList"
    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:225:1: inList : ^( IN_LIST ( parenSelect | simpleExprList ) ) ;
    public SqlGenerator.inList_return inList() // throws RecognitionException [1]
    {   
        SqlGenerator.inList_return retval = new SqlGenerator.inList_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        CommonTree _first_0 = null;
        CommonTree _last = null;

        CommonTree IN_LIST134 = null;
        SqlGenerator.parenSelect_return parenSelect135 = default(SqlGenerator.parenSelect_return);

        SqlGenerator.simpleExprList_return simpleExprList136 = default(SqlGenerator.simpleExprList_return);


        CommonTree IN_LIST134_tree=null;

        try 
    	{
            // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:226:2: ( ^( IN_LIST ( parenSelect | simpleExprList ) ) )
            // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:226:4: ^( IN_LIST ( parenSelect | simpleExprList ) )
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	_last = (CommonTree)input.LT(1);
            	{
            	CommonTree _save_last_1 = _last;
            	CommonTree _first_1 = null;
            	CommonTree root_1 = (CommonTree)adaptor.GetNilNode();_last = (CommonTree)input.LT(1);
            	IN_LIST134=(CommonTree)Match(input,IN_LIST,FOLLOW_IN_LIST_in_inList1245); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{IN_LIST134_tree = (CommonTree)adaptor.DupNode(IN_LIST134);

            		root_1 = (CommonTree)adaptor.BecomeRoot(IN_LIST134_tree, root_1);
            	}

            	if ( state.backtracking == 0 ) 
            	{
            	   Out(" "); 
            	}

            	if ( input.LA(1) == Token.DOWN )
            	{
            	    Match(input, Token.DOWN, null); if (state.failed) return retval;
            	    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:226:28: ( parenSelect | simpleExprList )
            	    int alt39 = 2;
            	    int LA39_0 = input.LA(1);

            	    if ( (LA39_0 == SELECT) )
            	    {
            	        alt39 = 1;
            	    }
            	    else if ( (LA39_0 == UP || LA39_0 == COUNT || LA39_0 == DOT || LA39_0 == FALSE || LA39_0 == NULL || LA39_0 == TRUE || LA39_0 == CASE || LA39_0 == AGGREGATE || LA39_0 == CASE2 || LA39_0 == INDEX_OP || LA39_0 == METHOD_CALL || LA39_0 == UNARY_MINUS || (LA39_0 >= CONSTANT && LA39_0 <= JAVA_CONSTANT) || (LA39_0 >= PLUS && LA39_0 <= DIV) || LA39_0 == PARAM || LA39_0 == IDENT || LA39_0 == ALIAS_REF || LA39_0 == SQL_TOKEN || LA39_0 == NAMED_PARAM || LA39_0 == QUOTED_STRING) )
            	    {
            	        alt39 = 2;
            	    }
            	    else 
            	    {
            	        if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	        NoViableAltException nvae_d39s0 =
            	            new NoViableAltException("", 39, 0, input);

            	        throw nvae_d39s0;
            	    }
            	    switch (alt39) 
            	    {
            	        case 1 :
            	            // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:226:30: parenSelect
            	            {
            	            	_last = (CommonTree)input.LT(1);
            	            	PushFollow(FOLLOW_parenSelect_in_inList1251);
            	            	parenSelect135 = parenSelect();
            	            	state.followingStackPointer--;
            	            	if (state.failed) return retval;
            	            	if ( state.backtracking==0 ) 
            	            	adaptor.AddChild(root_1, parenSelect135.Tree);

            	            	if ( state.backtracking==0 ) {
            	            	}
            	            }
            	            break;
            	        case 2 :
            	            // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:226:44: simpleExprList
            	            {
            	            	_last = (CommonTree)input.LT(1);
            	            	PushFollow(FOLLOW_simpleExprList_in_inList1255);
            	            	simpleExprList136 = simpleExprList();
            	            	state.followingStackPointer--;
            	            	if (state.failed) return retval;
            	            	if ( state.backtracking==0 ) 
            	            	adaptor.AddChild(root_1, simpleExprList136.Tree);

            	            	if ( state.backtracking==0 ) {
            	            	}
            	            }
            	            break;

            	    }


            	    Match(input, Token.UP, null); if (state.failed) return retval;
            	}adaptor.AddChild(root_0, root_1);_last = _save_last_1;
            	}


            	if ( state.backtracking==0 ) {
            	}
            }

            if ( state.backtracking==0 )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            }
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "inList"

    public class simpleExprList_return : TreeRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "simpleExprList"
    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:229:1: simpleExprList : (e= simpleExpr )* ;
    public SqlGenerator.simpleExprList_return simpleExprList() // throws RecognitionException [1]
    {   
        SqlGenerator.simpleExprList_return retval = new SqlGenerator.simpleExprList_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        CommonTree _first_0 = null;
        CommonTree _last = null;

        SqlGenerator.simpleExpr_return e = default(SqlGenerator.simpleExpr_return);



        try 
    	{
            // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:230:2: ( (e= simpleExpr )* )
            // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:230:4: (e= simpleExpr )*
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	if ( state.backtracking == 0 ) 
            	{
            	   Out("("); 
            	}
            	// /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:230:18: (e= simpleExpr )*
            	do 
            	{
            	    int alt40 = 2;
            	    int LA40_0 = input.LA(1);

            	    if ( (LA40_0 == COUNT || LA40_0 == DOT || LA40_0 == FALSE || LA40_0 == NULL || LA40_0 == TRUE || LA40_0 == CASE || LA40_0 == AGGREGATE || LA40_0 == CASE2 || LA40_0 == INDEX_OP || LA40_0 == METHOD_CALL || LA40_0 == UNARY_MINUS || (LA40_0 >= CONSTANT && LA40_0 <= JAVA_CONSTANT) || (LA40_0 >= PLUS && LA40_0 <= DIV) || LA40_0 == PARAM || LA40_0 == IDENT || LA40_0 == ALIAS_REF || LA40_0 == SQL_TOKEN || LA40_0 == NAMED_PARAM || LA40_0 == QUOTED_STRING) )
            	    {
            	        alt40 = 1;
            	    }


            	    switch (alt40) 
            		{
            			case 1 :
            			    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:230:19: e= simpleExpr
            			    {
            			    	_last = (CommonTree)input.LT(1);
            			    	PushFollow(FOLLOW_simpleExpr_in_simpleExprList1276);
            			    	e = simpleExpr();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking==0 ) 
            			    	adaptor.AddChild(root_0, e.Tree);
            			    	if ( state.backtracking == 0 ) 
            			    	{
            			    	   separator(((e != null) ? ((CommonTree)e.Tree) : null)," , "); 
            			    	}

            			    	if ( state.backtracking==0 ) {
            			    	}
            			    }
            			    break;

            			default:
            			    goto loop40;
            	    }
            	} while (true);

            	loop40:
            		;	// Stops C# compiler whining that label 'loop40' has no statements

            	if ( state.backtracking == 0 ) 
            	{
            	   Out(")"); 
            	}

            	if ( state.backtracking==0 ) {
            	}
            }

            if ( state.backtracking==0 )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            }
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "simpleExprList"

    public class expr_return : TreeRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "expr"
    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:234:1: expr : ( simpleExpr | ^( VECTOR_EXPR (e= expr )* ) | parenSelect | ^( ANY quantified ) | ^( ALL quantified ) | ^( SOME quantified ) );
    public SqlGenerator.expr_return expr() // throws RecognitionException [1]
    {   
        SqlGenerator.expr_return retval = new SqlGenerator.expr_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        CommonTree _first_0 = null;
        CommonTree _last = null;

        CommonTree VECTOR_EXPR138 = null;
        CommonTree ANY140 = null;
        CommonTree ALL142 = null;
        CommonTree SOME144 = null;
        SqlGenerator.expr_return e = default(SqlGenerator.expr_return);

        SqlGenerator.simpleExpr_return simpleExpr137 = default(SqlGenerator.simpleExpr_return);

        SqlGenerator.parenSelect_return parenSelect139 = default(SqlGenerator.parenSelect_return);

        SqlGenerator.quantified_return quantified141 = default(SqlGenerator.quantified_return);

        SqlGenerator.quantified_return quantified143 = default(SqlGenerator.quantified_return);

        SqlGenerator.quantified_return quantified145 = default(SqlGenerator.quantified_return);


        CommonTree VECTOR_EXPR138_tree=null;
        CommonTree ANY140_tree=null;
        CommonTree ALL142_tree=null;
        CommonTree SOME144_tree=null;

        try 
    	{
            // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:235:2: ( simpleExpr | ^( VECTOR_EXPR (e= expr )* ) | parenSelect | ^( ANY quantified ) | ^( ALL quantified ) | ^( SOME quantified ) )
            int alt42 = 6;
            switch ( input.LA(1) ) 
            {
            case COUNT:
            case DOT:
            case FALSE:
            case NULL:
            case TRUE:
            case CASE:
            case AGGREGATE:
            case CASE2:
            case INDEX_OP:
            case METHOD_CALL:
            case UNARY_MINUS:
            case CONSTANT:
            case NUM_INT:
            case NUM_DOUBLE:
            case NUM_FLOAT:
            case NUM_LONG:
            case JAVA_CONSTANT:
            case PLUS:
            case MINUS:
            case STAR:
            case DIV:
            case PARAM:
            case IDENT:
            case ALIAS_REF:
            case SQL_TOKEN:
            case NAMED_PARAM:
            case QUOTED_STRING:
            	{
                alt42 = 1;
                }
                break;
            case VECTOR_EXPR:
            	{
                alt42 = 2;
                }
                break;
            case SELECT:
            	{
                alt42 = 3;
                }
                break;
            case ANY:
            	{
                alt42 = 4;
                }
                break;
            case ALL:
            	{
                alt42 = 5;
                }
                break;
            case SOME:
            	{
                alt42 = 6;
                }
                break;
            	default:
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    NoViableAltException nvae_d42s0 =
            	        new NoViableAltException("", 42, 0, input);

            	    throw nvae_d42s0;
            }

            switch (alt42) 
            {
                case 1 :
                    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:235:4: simpleExpr
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	_last = (CommonTree)input.LT(1);
                    	PushFollow(FOLLOW_simpleExpr_in_expr1295);
                    	simpleExpr137 = simpleExpr();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking==0 ) 
                    	adaptor.AddChild(root_0, simpleExpr137.Tree);

                    	if ( state.backtracking==0 ) {
                    	}
                    }
                    break;
                case 2 :
                    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:236:4: ^( VECTOR_EXPR (e= expr )* )
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	_last = (CommonTree)input.LT(1);
                    	{
                    	CommonTree _save_last_1 = _last;
                    	CommonTree _first_1 = null;
                    	CommonTree root_1 = (CommonTree)adaptor.GetNilNode();_last = (CommonTree)input.LT(1);
                    	VECTOR_EXPR138=(CommonTree)Match(input,VECTOR_EXPR,FOLLOW_VECTOR_EXPR_in_expr1302); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{VECTOR_EXPR138_tree = (CommonTree)adaptor.DupNode(VECTOR_EXPR138);

                    		root_1 = (CommonTree)adaptor.BecomeRoot(VECTOR_EXPR138_tree, root_1);
                    	}

                    	if ( state.backtracking == 0 ) 
                    	{
                    	   Out("("); 
                    	}

                    	if ( input.LA(1) == Token.DOWN )
                    	{
                    	    Match(input, Token.DOWN, null); if (state.failed) return retval;
                    	    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:236:33: (e= expr )*
                    	    do 
                    	    {
                    	        int alt41 = 2;
                    	        int LA41_0 = input.LA(1);

                    	        if ( ((LA41_0 >= ALL && LA41_0 <= ANY) || LA41_0 == COUNT || LA41_0 == DOT || LA41_0 == FALSE || LA41_0 == NULL || LA41_0 == SELECT || LA41_0 == SOME || LA41_0 == TRUE || LA41_0 == CASE || LA41_0 == AGGREGATE || LA41_0 == CASE2 || LA41_0 == INDEX_OP || LA41_0 == METHOD_CALL || LA41_0 == UNARY_MINUS || LA41_0 == VECTOR_EXPR || (LA41_0 >= CONSTANT && LA41_0 <= JAVA_CONSTANT) || (LA41_0 >= PLUS && LA41_0 <= DIV) || LA41_0 == PARAM || LA41_0 == IDENT || LA41_0 == ALIAS_REF || LA41_0 == SQL_TOKEN || LA41_0 == NAMED_PARAM || LA41_0 == QUOTED_STRING) )
                    	        {
                    	            alt41 = 1;
                    	        }


                    	        switch (alt41) 
                    	    	{
                    	    		case 1 :
                    	    		    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:236:34: e= expr
                    	    		    {
                    	    		    	_last = (CommonTree)input.LT(1);
                    	    		    	PushFollow(FOLLOW_expr_in_expr1309);
                    	    		    	e = expr();
                    	    		    	state.followingStackPointer--;
                    	    		    	if (state.failed) return retval;
                    	    		    	if ( state.backtracking==0 ) 
                    	    		    	adaptor.AddChild(root_1, e.Tree);
                    	    		    	if ( state.backtracking == 0 ) 
                    	    		    	{
                    	    		    	   separator(((e != null) ? ((CommonTree)e.Tree) : null)," , "); 
                    	    		    	}

                    	    		    	if ( state.backtracking==0 ) {
                    	    		    	}
                    	    		    }
                    	    		    break;

                    	    		default:
                    	    		    goto loop41;
                    	        }
                    	    } while (true);

                    	    loop41:
                    	    	;	// Stops C# compiler whining that label 'loop41' has no statements

                    	    if ( state.backtracking == 0 ) 
                    	    {
                    	       Out(")"); 
                    	    }

                    	    Match(input, Token.UP, null); if (state.failed) return retval;
                    	}adaptor.AddChild(root_0, root_1);_last = _save_last_1;
                    	}


                    	if ( state.backtracking==0 ) {
                    	}
                    }
                    break;
                case 3 :
                    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:237:4: parenSelect
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	_last = (CommonTree)input.LT(1);
                    	PushFollow(FOLLOW_parenSelect_in_expr1324);
                    	parenSelect139 = parenSelect();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking==0 ) 
                    	adaptor.AddChild(root_0, parenSelect139.Tree);

                    	if ( state.backtracking==0 ) {
                    	}
                    }
                    break;
                case 4 :
                    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:238:4: ^( ANY quantified )
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	_last = (CommonTree)input.LT(1);
                    	{
                    	CommonTree _save_last_1 = _last;
                    	CommonTree _first_1 = null;
                    	CommonTree root_1 = (CommonTree)adaptor.GetNilNode();_last = (CommonTree)input.LT(1);
                    	ANY140=(CommonTree)Match(input,ANY,FOLLOW_ANY_in_expr1330); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{ANY140_tree = (CommonTree)adaptor.DupNode(ANY140);

                    		root_1 = (CommonTree)adaptor.BecomeRoot(ANY140_tree, root_1);
                    	}

                    	if ( state.backtracking == 0 ) 
                    	{
                    	   Out("any "); 
                    	}

                    	Match(input, Token.DOWN, null); if (state.failed) return retval;
                    	_last = (CommonTree)input.LT(1);
                    	PushFollow(FOLLOW_quantified_in_expr1334);
                    	quantified141 = quantified();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking==0 ) 
                    	adaptor.AddChild(root_1, quantified141.Tree);

                    	Match(input, Token.UP, null); if (state.failed) return retval;adaptor.AddChild(root_0, root_1);_last = _save_last_1;
                    	}


                    	if ( state.backtracking==0 ) {
                    	}
                    }
                    break;
                case 5 :
                    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:239:4: ^( ALL quantified )
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	_last = (CommonTree)input.LT(1);
                    	{
                    	CommonTree _save_last_1 = _last;
                    	CommonTree _first_1 = null;
                    	CommonTree root_1 = (CommonTree)adaptor.GetNilNode();_last = (CommonTree)input.LT(1);
                    	ALL142=(CommonTree)Match(input,ALL,FOLLOW_ALL_in_expr1342); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{ALL142_tree = (CommonTree)adaptor.DupNode(ALL142);

                    		root_1 = (CommonTree)adaptor.BecomeRoot(ALL142_tree, root_1);
                    	}

                    	if ( state.backtracking == 0 ) 
                    	{
                    	   Out("all "); 
                    	}

                    	Match(input, Token.DOWN, null); if (state.failed) return retval;
                    	_last = (CommonTree)input.LT(1);
                    	PushFollow(FOLLOW_quantified_in_expr1346);
                    	quantified143 = quantified();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking==0 ) 
                    	adaptor.AddChild(root_1, quantified143.Tree);

                    	Match(input, Token.UP, null); if (state.failed) return retval;adaptor.AddChild(root_0, root_1);_last = _save_last_1;
                    	}


                    	if ( state.backtracking==0 ) {
                    	}
                    }
                    break;
                case 6 :
                    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:240:4: ^( SOME quantified )
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	_last = (CommonTree)input.LT(1);
                    	{
                    	CommonTree _save_last_1 = _last;
                    	CommonTree _first_1 = null;
                    	CommonTree root_1 = (CommonTree)adaptor.GetNilNode();_last = (CommonTree)input.LT(1);
                    	SOME144=(CommonTree)Match(input,SOME,FOLLOW_SOME_in_expr1354); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{SOME144_tree = (CommonTree)adaptor.DupNode(SOME144);

                    		root_1 = (CommonTree)adaptor.BecomeRoot(SOME144_tree, root_1);
                    	}

                    	if ( state.backtracking == 0 ) 
                    	{
                    	   Out("some "); 
                    	}

                    	Match(input, Token.DOWN, null); if (state.failed) return retval;
                    	_last = (CommonTree)input.LT(1);
                    	PushFollow(FOLLOW_quantified_in_expr1358);
                    	quantified145 = quantified();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking==0 ) 
                    	adaptor.AddChild(root_1, quantified145.Tree);

                    	Match(input, Token.UP, null); if (state.failed) return retval;adaptor.AddChild(root_0, root_1);_last = _save_last_1;
                    	}


                    	if ( state.backtracking==0 ) {
                    	}
                    }
                    break;

            }
            if ( state.backtracking==0 )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            }
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "expr"

    public class quantified_return : TreeRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "quantified"
    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:243:1: quantified : ( sqlToken | selectStatement ) ;
    public SqlGenerator.quantified_return quantified() // throws RecognitionException [1]
    {   
        SqlGenerator.quantified_return retval = new SqlGenerator.quantified_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        CommonTree _first_0 = null;
        CommonTree _last = null;

        SqlGenerator.sqlToken_return sqlToken146 = default(SqlGenerator.sqlToken_return);

        SqlGenerator.selectStatement_return selectStatement147 = default(SqlGenerator.selectStatement_return);



        try 
    	{
            // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:244:2: ( ( sqlToken | selectStatement ) )
            // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:244:4: ( sqlToken | selectStatement )
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	if ( state.backtracking == 0 ) 
            	{
            	   Out("("); 
            	}
            	// /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:244:18: ( sqlToken | selectStatement )
            	int alt43 = 2;
            	int LA43_0 = input.LA(1);

            	if ( (LA43_0 == SQL_TOKEN) )
            	{
            	    alt43 = 1;
            	}
            	else if ( (LA43_0 == SELECT) )
            	{
            	    alt43 = 2;
            	}
            	else 
            	{
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    NoViableAltException nvae_d43s0 =
            	        new NoViableAltException("", 43, 0, input);

            	    throw nvae_d43s0;
            	}
            	switch (alt43) 
            	{
            	    case 1 :
            	        // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:244:20: sqlToken
            	        {
            	        	_last = (CommonTree)input.LT(1);
            	        	PushFollow(FOLLOW_sqlToken_in_quantified1376);
            	        	sqlToken146 = sqlToken();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking==0 ) 
            	        	adaptor.AddChild(root_0, sqlToken146.Tree);

            	        	if ( state.backtracking==0 ) {
            	        	}
            	        }
            	        break;
            	    case 2 :
            	        // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:244:31: selectStatement
            	        {
            	        	_last = (CommonTree)input.LT(1);
            	        	PushFollow(FOLLOW_selectStatement_in_quantified1380);
            	        	selectStatement147 = selectStatement();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking==0 ) 
            	        	adaptor.AddChild(root_0, selectStatement147.Tree);

            	        	if ( state.backtracking==0 ) {
            	        	}
            	        }
            	        break;

            	}

            	if ( state.backtracking == 0 ) 
            	{
            	   Out(")"); 
            	}

            	if ( state.backtracking==0 ) {
            	}
            }

            if ( state.backtracking==0 )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            }
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "quantified"

    public class parenSelect_return : TreeRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "parenSelect"
    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:247:1: parenSelect : selectStatement ;
    public SqlGenerator.parenSelect_return parenSelect() // throws RecognitionException [1]
    {   
        SqlGenerator.parenSelect_return retval = new SqlGenerator.parenSelect_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        CommonTree _first_0 = null;
        CommonTree _last = null;

        SqlGenerator.selectStatement_return selectStatement148 = default(SqlGenerator.selectStatement_return);



        try 
    	{
            // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:248:2: ( selectStatement )
            // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:248:4: selectStatement
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	if ( state.backtracking == 0 ) 
            	{
            	   Out("("); 
            	}
            	_last = (CommonTree)input.LT(1);
            	PushFollow(FOLLOW_selectStatement_in_parenSelect1399);
            	selectStatement148 = selectStatement();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) 
            	adaptor.AddChild(root_0, selectStatement148.Tree);
            	if ( state.backtracking == 0 ) 
            	{
            	   Out(")"); 
            	}

            	if ( state.backtracking==0 ) {
            	}
            }

            if ( state.backtracking==0 )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            }
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "parenSelect"

    public class simpleExpr_return : TreeRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "simpleExpr"
    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:251:1: simpleExpr : (c= constant | NULL | addrExpr | sqlToken | aggregate | methodCall | count | parameter | arithmeticExpr );
    public SqlGenerator.simpleExpr_return simpleExpr() // throws RecognitionException [1]
    {   
        SqlGenerator.simpleExpr_return retval = new SqlGenerator.simpleExpr_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        CommonTree _first_0 = null;
        CommonTree _last = null;

        CommonTree NULL149 = null;
        SqlGenerator.constant_return c = default(SqlGenerator.constant_return);

        SqlGenerator.addrExpr_return addrExpr150 = default(SqlGenerator.addrExpr_return);

        SqlGenerator.sqlToken_return sqlToken151 = default(SqlGenerator.sqlToken_return);

        SqlGenerator.aggregate_return aggregate152 = default(SqlGenerator.aggregate_return);

        SqlGenerator.methodCall_return methodCall153 = default(SqlGenerator.methodCall_return);

        SqlGenerator.count_return count154 = default(SqlGenerator.count_return);

        SqlGenerator.parameter_return parameter155 = default(SqlGenerator.parameter_return);

        SqlGenerator.arithmeticExpr_return arithmeticExpr156 = default(SqlGenerator.arithmeticExpr_return);


        CommonTree NULL149_tree=null;

        try 
    	{
            // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:252:2: (c= constant | NULL | addrExpr | sqlToken | aggregate | methodCall | count | parameter | arithmeticExpr )
            int alt44 = 9;
            switch ( input.LA(1) ) 
            {
            case FALSE:
            case TRUE:
            case CONSTANT:
            case NUM_INT:
            case NUM_DOUBLE:
            case NUM_FLOAT:
            case NUM_LONG:
            case JAVA_CONSTANT:
            case IDENT:
            case QUOTED_STRING:
            	{
                alt44 = 1;
                }
                break;
            case NULL:
            	{
                alt44 = 2;
                }
                break;
            case DOT:
            case INDEX_OP:
            case ALIAS_REF:
            	{
                alt44 = 3;
                }
                break;
            case SQL_TOKEN:
            	{
                alt44 = 4;
                }
                break;
            case AGGREGATE:
            	{
                alt44 = 5;
                }
                break;
            case METHOD_CALL:
            	{
                alt44 = 6;
                }
                break;
            case COUNT:
            	{
                alt44 = 7;
                }
                break;
            case PARAM:
            case NAMED_PARAM:
            	{
                alt44 = 8;
                }
                break;
            case CASE:
            case CASE2:
            case UNARY_MINUS:
            case PLUS:
            case MINUS:
            case STAR:
            case DIV:
            	{
                alt44 = 9;
                }
                break;
            	default:
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    NoViableAltException nvae_d44s0 =
            	        new NoViableAltException("", 44, 0, input);

            	    throw nvae_d44s0;
            }

            switch (alt44) 
            {
                case 1 :
                    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:252:4: c= constant
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	_last = (CommonTree)input.LT(1);
                    	PushFollow(FOLLOW_constant_in_simpleExpr1415);
                    	c = constant();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking==0 ) 
                    	adaptor.AddChild(root_0, c.Tree);
                    	if ( state.backtracking == 0 ) 
                    	{
                    	   Out(((c != null) ? ((CommonTree)c.Tree) : null)); 
                    	}

                    	if ( state.backtracking==0 ) {
                    	}
                    }
                    break;
                case 2 :
                    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:253:4: NULL
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	_last = (CommonTree)input.LT(1);
                    	NULL149=(CommonTree)Match(input,NULL,FOLLOW_NULL_in_simpleExpr1422); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{NULL149_tree = (CommonTree)adaptor.DupNode(NULL149);

                    		adaptor.AddChild(root_0, NULL149_tree);
                    	}
                    	if ( state.backtracking == 0 ) 
                    	{
                    	   Out("null"); 
                    	}

                    	if ( state.backtracking==0 ) {
                    	}
                    }
                    break;
                case 3 :
                    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:254:4: addrExpr
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	_last = (CommonTree)input.LT(1);
                    	PushFollow(FOLLOW_addrExpr_in_simpleExpr1429);
                    	addrExpr150 = addrExpr();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking==0 ) 
                    	adaptor.AddChild(root_0, addrExpr150.Tree);

                    	if ( state.backtracking==0 ) {
                    	}
                    }
                    break;
                case 4 :
                    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:255:4: sqlToken
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	_last = (CommonTree)input.LT(1);
                    	PushFollow(FOLLOW_sqlToken_in_simpleExpr1434);
                    	sqlToken151 = sqlToken();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking==0 ) 
                    	adaptor.AddChild(root_0, sqlToken151.Tree);

                    	if ( state.backtracking==0 ) {
                    	}
                    }
                    break;
                case 5 :
                    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:256:4: aggregate
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	_last = (CommonTree)input.LT(1);
                    	PushFollow(FOLLOW_aggregate_in_simpleExpr1439);
                    	aggregate152 = aggregate();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking==0 ) 
                    	adaptor.AddChild(root_0, aggregate152.Tree);

                    	if ( state.backtracking==0 ) {
                    	}
                    }
                    break;
                case 6 :
                    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:257:4: methodCall
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	_last = (CommonTree)input.LT(1);
                    	PushFollow(FOLLOW_methodCall_in_simpleExpr1444);
                    	methodCall153 = methodCall();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking==0 ) 
                    	adaptor.AddChild(root_0, methodCall153.Tree);

                    	if ( state.backtracking==0 ) {
                    	}
                    }
                    break;
                case 7 :
                    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:258:4: count
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	_last = (CommonTree)input.LT(1);
                    	PushFollow(FOLLOW_count_in_simpleExpr1449);
                    	count154 = count();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking==0 ) 
                    	adaptor.AddChild(root_0, count154.Tree);

                    	if ( state.backtracking==0 ) {
                    	}
                    }
                    break;
                case 8 :
                    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:259:4: parameter
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	_last = (CommonTree)input.LT(1);
                    	PushFollow(FOLLOW_parameter_in_simpleExpr1454);
                    	parameter155 = parameter();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking==0 ) 
                    	adaptor.AddChild(root_0, parameter155.Tree);

                    	if ( state.backtracking==0 ) {
                    	}
                    }
                    break;
                case 9 :
                    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:260:4: arithmeticExpr
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	_last = (CommonTree)input.LT(1);
                    	PushFollow(FOLLOW_arithmeticExpr_in_simpleExpr1459);
                    	arithmeticExpr156 = arithmeticExpr();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking==0 ) 
                    	adaptor.AddChild(root_0, arithmeticExpr156.Tree);

                    	if ( state.backtracking==0 ) {
                    	}
                    }
                    break;

            }
            if ( state.backtracking==0 )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            }
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "simpleExpr"

    public class constant_return : TreeRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "constant"
    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:263:1: constant : ( NUM_DOUBLE | NUM_FLOAT | NUM_INT | NUM_LONG | QUOTED_STRING | CONSTANT | JAVA_CONSTANT | TRUE | FALSE | IDENT );
    public SqlGenerator.constant_return constant() // throws RecognitionException [1]
    {   
        SqlGenerator.constant_return retval = new SqlGenerator.constant_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        CommonTree _first_0 = null;
        CommonTree _last = null;

        CommonTree set157 = null;

        CommonTree set157_tree=null;

        try 
    	{
            // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:264:2: ( NUM_DOUBLE | NUM_FLOAT | NUM_INT | NUM_LONG | QUOTED_STRING | CONSTANT | JAVA_CONSTANT | TRUE | FALSE | IDENT )
            // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	_last = (CommonTree)input.LT(1);
            	set157 = (CommonTree)input.LT(1);
            	if ( input.LA(1) == FALSE || input.LA(1) == TRUE || (input.LA(1) >= CONSTANT && input.LA(1) <= JAVA_CONSTANT) || input.LA(1) == IDENT || input.LA(1) == QUOTED_STRING ) 
            	{
            	    input.Consume();

            	    if ( state.backtracking==0 ) {
            	    set157_tree = (CommonTree)adaptor.DupNode(set157);

            	    adaptor.AddChild(root_0, set157_tree);
            	    }
            	    state.errorRecovery = false;state.failed = false;
            	}
            	else 
            	{
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	    throw mse;
            	}

            	if ( state.backtracking==0 ) {
            	} 

            }

            if ( state.backtracking==0 )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            }
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "constant"

    public class arithmeticExpr_return : TreeRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "arithmeticExpr"
    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:276:1: arithmeticExpr : ( additiveExpr | multiplicativeExpr | ^( UNARY_MINUS expr ) | caseExpr );
    public SqlGenerator.arithmeticExpr_return arithmeticExpr() // throws RecognitionException [1]
    {   
        SqlGenerator.arithmeticExpr_return retval = new SqlGenerator.arithmeticExpr_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        CommonTree _first_0 = null;
        CommonTree _last = null;

        CommonTree UNARY_MINUS160 = null;
        SqlGenerator.additiveExpr_return additiveExpr158 = default(SqlGenerator.additiveExpr_return);

        SqlGenerator.multiplicativeExpr_return multiplicativeExpr159 = default(SqlGenerator.multiplicativeExpr_return);

        SqlGenerator.expr_return expr161 = default(SqlGenerator.expr_return);

        SqlGenerator.caseExpr_return caseExpr162 = default(SqlGenerator.caseExpr_return);


        CommonTree UNARY_MINUS160_tree=null;

        try 
    	{
            // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:277:2: ( additiveExpr | multiplicativeExpr | ^( UNARY_MINUS expr ) | caseExpr )
            int alt45 = 4;
            switch ( input.LA(1) ) 
            {
            case PLUS:
            case MINUS:
            	{
                alt45 = 1;
                }
                break;
            case STAR:
            case DIV:
            	{
                alt45 = 2;
                }
                break;
            case UNARY_MINUS:
            	{
                alt45 = 3;
                }
                break;
            case CASE:
            case CASE2:
            	{
                alt45 = 4;
                }
                break;
            	default:
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    NoViableAltException nvae_d45s0 =
            	        new NoViableAltException("", 45, 0, input);

            	    throw nvae_d45s0;
            }

            switch (alt45) 
            {
                case 1 :
                    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:277:4: additiveExpr
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	_last = (CommonTree)input.LT(1);
                    	PushFollow(FOLLOW_additiveExpr_in_arithmeticExpr1528);
                    	additiveExpr158 = additiveExpr();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking==0 ) 
                    	adaptor.AddChild(root_0, additiveExpr158.Tree);

                    	if ( state.backtracking==0 ) {
                    	}
                    }
                    break;
                case 2 :
                    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:278:4: multiplicativeExpr
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	_last = (CommonTree)input.LT(1);
                    	PushFollow(FOLLOW_multiplicativeExpr_in_arithmeticExpr1533);
                    	multiplicativeExpr159 = multiplicativeExpr();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking==0 ) 
                    	adaptor.AddChild(root_0, multiplicativeExpr159.Tree);

                    	if ( state.backtracking==0 ) {
                    	}
                    }
                    break;
                case 3 :
                    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:280:4: ^( UNARY_MINUS expr )
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	_last = (CommonTree)input.LT(1);
                    	{
                    	CommonTree _save_last_1 = _last;
                    	CommonTree _first_1 = null;
                    	CommonTree root_1 = (CommonTree)adaptor.GetNilNode();_last = (CommonTree)input.LT(1);
                    	UNARY_MINUS160=(CommonTree)Match(input,UNARY_MINUS,FOLLOW_UNARY_MINUS_in_arithmeticExpr1540); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{UNARY_MINUS160_tree = (CommonTree)adaptor.DupNode(UNARY_MINUS160);

                    		root_1 = (CommonTree)adaptor.BecomeRoot(UNARY_MINUS160_tree, root_1);
                    	}

                    	if ( state.backtracking == 0 ) 
                    	{
                    	   Out("-"); 
                    	}

                    	Match(input, Token.DOWN, null); if (state.failed) return retval;
                    	_last = (CommonTree)input.LT(1);
                    	PushFollow(FOLLOW_expr_in_arithmeticExpr1544);
                    	expr161 = expr();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking==0 ) 
                    	adaptor.AddChild(root_1, expr161.Tree);

                    	Match(input, Token.UP, null); if (state.failed) return retval;adaptor.AddChild(root_0, root_1);_last = _save_last_1;
                    	}


                    	if ( state.backtracking==0 ) {
                    	}
                    }
                    break;
                case 4 :
                    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:281:4: caseExpr
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	_last = (CommonTree)input.LT(1);
                    	PushFollow(FOLLOW_caseExpr_in_arithmeticExpr1550);
                    	caseExpr162 = caseExpr();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking==0 ) 
                    	adaptor.AddChild(root_0, caseExpr162.Tree);

                    	if ( state.backtracking==0 ) {
                    	}
                    }
                    break;

            }
            if ( state.backtracking==0 )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            }
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "arithmeticExpr"

    public class additiveExpr_return : TreeRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "additiveExpr"
    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:284:1: additiveExpr : ( ^( PLUS expr expr ) | ^( MINUS expr nestedExprAfterMinusDiv ) );
    public SqlGenerator.additiveExpr_return additiveExpr() // throws RecognitionException [1]
    {   
        SqlGenerator.additiveExpr_return retval = new SqlGenerator.additiveExpr_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        CommonTree _first_0 = null;
        CommonTree _last = null;

        CommonTree PLUS163 = null;
        CommonTree MINUS166 = null;
        SqlGenerator.expr_return expr164 = default(SqlGenerator.expr_return);

        SqlGenerator.expr_return expr165 = default(SqlGenerator.expr_return);

        SqlGenerator.expr_return expr167 = default(SqlGenerator.expr_return);

        SqlGenerator.nestedExprAfterMinusDiv_return nestedExprAfterMinusDiv168 = default(SqlGenerator.nestedExprAfterMinusDiv_return);


        CommonTree PLUS163_tree=null;
        CommonTree MINUS166_tree=null;

        try 
    	{
            // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:285:2: ( ^( PLUS expr expr ) | ^( MINUS expr nestedExprAfterMinusDiv ) )
            int alt46 = 2;
            int LA46_0 = input.LA(1);

            if ( (LA46_0 == PLUS) )
            {
                alt46 = 1;
            }
            else if ( (LA46_0 == MINUS) )
            {
                alt46 = 2;
            }
            else 
            {
                if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                NoViableAltException nvae_d46s0 =
                    new NoViableAltException("", 46, 0, input);

                throw nvae_d46s0;
            }
            switch (alt46) 
            {
                case 1 :
                    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:285:4: ^( PLUS expr expr )
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	_last = (CommonTree)input.LT(1);
                    	{
                    	CommonTree _save_last_1 = _last;
                    	CommonTree _first_1 = null;
                    	CommonTree root_1 = (CommonTree)adaptor.GetNilNode();_last = (CommonTree)input.LT(1);
                    	PLUS163=(CommonTree)Match(input,PLUS,FOLLOW_PLUS_in_additiveExpr1562); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{PLUS163_tree = (CommonTree)adaptor.DupNode(PLUS163);

                    		root_1 = (CommonTree)adaptor.BecomeRoot(PLUS163_tree, root_1);
                    	}


                    	Match(input, Token.DOWN, null); if (state.failed) return retval;
                    	_last = (CommonTree)input.LT(1);
                    	PushFollow(FOLLOW_expr_in_additiveExpr1564);
                    	expr164 = expr();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking==0 ) 
                    	adaptor.AddChild(root_1, expr164.Tree);
                    	if ( state.backtracking == 0 ) 
                    	{
                    	   Out("+"); 
                    	}
                    	_last = (CommonTree)input.LT(1);
                    	PushFollow(FOLLOW_expr_in_additiveExpr1568);
                    	expr165 = expr();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking==0 ) 
                    	adaptor.AddChild(root_1, expr165.Tree);

                    	Match(input, Token.UP, null); if (state.failed) return retval;adaptor.AddChild(root_0, root_1);_last = _save_last_1;
                    	}


                    	if ( state.backtracking==0 ) {
                    	}
                    }
                    break;
                case 2 :
                    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:286:4: ^( MINUS expr nestedExprAfterMinusDiv )
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	_last = (CommonTree)input.LT(1);
                    	{
                    	CommonTree _save_last_1 = _last;
                    	CommonTree _first_1 = null;
                    	CommonTree root_1 = (CommonTree)adaptor.GetNilNode();_last = (CommonTree)input.LT(1);
                    	MINUS166=(CommonTree)Match(input,MINUS,FOLLOW_MINUS_in_additiveExpr1575); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{MINUS166_tree = (CommonTree)adaptor.DupNode(MINUS166);

                    		root_1 = (CommonTree)adaptor.BecomeRoot(MINUS166_tree, root_1);
                    	}


                    	Match(input, Token.DOWN, null); if (state.failed) return retval;
                    	_last = (CommonTree)input.LT(1);
                    	PushFollow(FOLLOW_expr_in_additiveExpr1577);
                    	expr167 = expr();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking==0 ) 
                    	adaptor.AddChild(root_1, expr167.Tree);
                    	if ( state.backtracking == 0 ) 
                    	{
                    	   Out("-"); 
                    	}
                    	_last = (CommonTree)input.LT(1);
                    	PushFollow(FOLLOW_nestedExprAfterMinusDiv_in_additiveExpr1581);
                    	nestedExprAfterMinusDiv168 = nestedExprAfterMinusDiv();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking==0 ) 
                    	adaptor.AddChild(root_1, nestedExprAfterMinusDiv168.Tree);

                    	Match(input, Token.UP, null); if (state.failed) return retval;adaptor.AddChild(root_0, root_1);_last = _save_last_1;
                    	}


                    	if ( state.backtracking==0 ) {
                    	}
                    }
                    break;

            }
            if ( state.backtracking==0 )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            }
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "additiveExpr"

    public class multiplicativeExpr_return : TreeRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "multiplicativeExpr"
    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:289:1: multiplicativeExpr : ( ^( STAR nestedExpr nestedExpr ) | ^( DIV nestedExpr nestedExprAfterMinusDiv ) );
    public SqlGenerator.multiplicativeExpr_return multiplicativeExpr() // throws RecognitionException [1]
    {   
        SqlGenerator.multiplicativeExpr_return retval = new SqlGenerator.multiplicativeExpr_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        CommonTree _first_0 = null;
        CommonTree _last = null;

        CommonTree STAR169 = null;
        CommonTree DIV172 = null;
        SqlGenerator.nestedExpr_return nestedExpr170 = default(SqlGenerator.nestedExpr_return);

        SqlGenerator.nestedExpr_return nestedExpr171 = default(SqlGenerator.nestedExpr_return);

        SqlGenerator.nestedExpr_return nestedExpr173 = default(SqlGenerator.nestedExpr_return);

        SqlGenerator.nestedExprAfterMinusDiv_return nestedExprAfterMinusDiv174 = default(SqlGenerator.nestedExprAfterMinusDiv_return);


        CommonTree STAR169_tree=null;
        CommonTree DIV172_tree=null;

        try 
    	{
            // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:290:2: ( ^( STAR nestedExpr nestedExpr ) | ^( DIV nestedExpr nestedExprAfterMinusDiv ) )
            int alt47 = 2;
            int LA47_0 = input.LA(1);

            if ( (LA47_0 == STAR) )
            {
                alt47 = 1;
            }
            else if ( (LA47_0 == DIV) )
            {
                alt47 = 2;
            }
            else 
            {
                if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                NoViableAltException nvae_d47s0 =
                    new NoViableAltException("", 47, 0, input);

                throw nvae_d47s0;
            }
            switch (alt47) 
            {
                case 1 :
                    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:290:4: ^( STAR nestedExpr nestedExpr )
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	_last = (CommonTree)input.LT(1);
                    	{
                    	CommonTree _save_last_1 = _last;
                    	CommonTree _first_1 = null;
                    	CommonTree root_1 = (CommonTree)adaptor.GetNilNode();_last = (CommonTree)input.LT(1);
                    	STAR169=(CommonTree)Match(input,STAR,FOLLOW_STAR_in_multiplicativeExpr1594); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{STAR169_tree = (CommonTree)adaptor.DupNode(STAR169);

                    		root_1 = (CommonTree)adaptor.BecomeRoot(STAR169_tree, root_1);
                    	}


                    	Match(input, Token.DOWN, null); if (state.failed) return retval;
                    	_last = (CommonTree)input.LT(1);
                    	PushFollow(FOLLOW_nestedExpr_in_multiplicativeExpr1596);
                    	nestedExpr170 = nestedExpr();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking==0 ) 
                    	adaptor.AddChild(root_1, nestedExpr170.Tree);
                    	if ( state.backtracking == 0 ) 
                    	{
                    	   Out("*"); 
                    	}
                    	_last = (CommonTree)input.LT(1);
                    	PushFollow(FOLLOW_nestedExpr_in_multiplicativeExpr1600);
                    	nestedExpr171 = nestedExpr();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking==0 ) 
                    	adaptor.AddChild(root_1, nestedExpr171.Tree);

                    	Match(input, Token.UP, null); if (state.failed) return retval;adaptor.AddChild(root_0, root_1);_last = _save_last_1;
                    	}


                    	if ( state.backtracking==0 ) {
                    	}
                    }
                    break;
                case 2 :
                    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:291:4: ^( DIV nestedExpr nestedExprAfterMinusDiv )
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	_last = (CommonTree)input.LT(1);
                    	{
                    	CommonTree _save_last_1 = _last;
                    	CommonTree _first_1 = null;
                    	CommonTree root_1 = (CommonTree)adaptor.GetNilNode();_last = (CommonTree)input.LT(1);
                    	DIV172=(CommonTree)Match(input,DIV,FOLLOW_DIV_in_multiplicativeExpr1607); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{DIV172_tree = (CommonTree)adaptor.DupNode(DIV172);

                    		root_1 = (CommonTree)adaptor.BecomeRoot(DIV172_tree, root_1);
                    	}


                    	Match(input, Token.DOWN, null); if (state.failed) return retval;
                    	_last = (CommonTree)input.LT(1);
                    	PushFollow(FOLLOW_nestedExpr_in_multiplicativeExpr1609);
                    	nestedExpr173 = nestedExpr();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking==0 ) 
                    	adaptor.AddChild(root_1, nestedExpr173.Tree);
                    	if ( state.backtracking == 0 ) 
                    	{
                    	   Out("/"); 
                    	}
                    	_last = (CommonTree)input.LT(1);
                    	PushFollow(FOLLOW_nestedExprAfterMinusDiv_in_multiplicativeExpr1613);
                    	nestedExprAfterMinusDiv174 = nestedExprAfterMinusDiv();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking==0 ) 
                    	adaptor.AddChild(root_1, nestedExprAfterMinusDiv174.Tree);

                    	Match(input, Token.UP, null); if (state.failed) return retval;adaptor.AddChild(root_0, root_1);_last = _save_last_1;
                    	}


                    	if ( state.backtracking==0 ) {
                    	}
                    }
                    break;

            }
            if ( state.backtracking==0 )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            }
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "multiplicativeExpr"

    public class nestedExpr_return : TreeRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "nestedExpr"
    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:294:1: nestedExpr : ( ( additiveExpr )=> additiveExpr | expr );
    public SqlGenerator.nestedExpr_return nestedExpr() // throws RecognitionException [1]
    {   
        SqlGenerator.nestedExpr_return retval = new SqlGenerator.nestedExpr_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        CommonTree _first_0 = null;
        CommonTree _last = null;

        SqlGenerator.additiveExpr_return additiveExpr175 = default(SqlGenerator.additiveExpr_return);

        SqlGenerator.expr_return expr176 = default(SqlGenerator.expr_return);



        try 
    	{
            // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:296:2: ( ( additiveExpr )=> additiveExpr | expr )
            int alt48 = 2;
            alt48 = dfa48.Predict(input);
            switch (alt48) 
            {
                case 1 :
                    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:296:4: ( additiveExpr )=> additiveExpr
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	if ( state.backtracking == 0 ) 
                    	{
                    	   Out("("); 
                    	}
                    	_last = (CommonTree)input.LT(1);
                    	PushFollow(FOLLOW_additiveExpr_in_nestedExpr1635);
                    	additiveExpr175 = additiveExpr();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking==0 ) 
                    	adaptor.AddChild(root_0, additiveExpr175.Tree);
                    	if ( state.backtracking == 0 ) 
                    	{
                    	   Out(")"); 
                    	}

                    	if ( state.backtracking==0 ) {
                    	}
                    }
                    break;
                case 2 :
                    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:297:4: expr
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	_last = (CommonTree)input.LT(1);
                    	PushFollow(FOLLOW_expr_in_nestedExpr1642);
                    	expr176 = expr();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking==0 ) 
                    	adaptor.AddChild(root_0, expr176.Tree);

                    	if ( state.backtracking==0 ) {
                    	}
                    }
                    break;

            }
            if ( state.backtracking==0 )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            }
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "nestedExpr"

    public class nestedExprAfterMinusDiv_return : TreeRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "nestedExprAfterMinusDiv"
    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:300:1: nestedExprAfterMinusDiv : ( ( arithmeticExpr )=> arithmeticExpr | expr );
    public SqlGenerator.nestedExprAfterMinusDiv_return nestedExprAfterMinusDiv() // throws RecognitionException [1]
    {   
        SqlGenerator.nestedExprAfterMinusDiv_return retval = new SqlGenerator.nestedExprAfterMinusDiv_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        CommonTree _first_0 = null;
        CommonTree _last = null;

        SqlGenerator.arithmeticExpr_return arithmeticExpr177 = default(SqlGenerator.arithmeticExpr_return);

        SqlGenerator.expr_return expr178 = default(SqlGenerator.expr_return);



        try 
    	{
            // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:302:2: ( ( arithmeticExpr )=> arithmeticExpr | expr )
            int alt49 = 2;
            alt49 = dfa49.Predict(input);
            switch (alt49) 
            {
                case 1 :
                    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:302:4: ( arithmeticExpr )=> arithmeticExpr
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	if ( state.backtracking == 0 ) 
                    	{
                    	   Out("("); 
                    	}
                    	_last = (CommonTree)input.LT(1);
                    	PushFollow(FOLLOW_arithmeticExpr_in_nestedExprAfterMinusDiv1664);
                    	arithmeticExpr177 = arithmeticExpr();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking==0 ) 
                    	adaptor.AddChild(root_0, arithmeticExpr177.Tree);
                    	if ( state.backtracking == 0 ) 
                    	{
                    	   Out(")"); 
                    	}

                    	if ( state.backtracking==0 ) {
                    	}
                    }
                    break;
                case 2 :
                    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:303:4: expr
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	_last = (CommonTree)input.LT(1);
                    	PushFollow(FOLLOW_expr_in_nestedExprAfterMinusDiv1671);
                    	expr178 = expr();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking==0 ) 
                    	adaptor.AddChild(root_0, expr178.Tree);

                    	if ( state.backtracking==0 ) {
                    	}
                    }
                    break;

            }
            if ( state.backtracking==0 )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            }
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "nestedExprAfterMinusDiv"

    public class caseExpr_return : TreeRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "caseExpr"
    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:306:1: caseExpr : ( ^( CASE ( ^( WHEN booleanExpr[false] expr ) )+ ( ^( ELSE expr ) )? ) | ^( CASE2 expr ( ^( WHEN expr expr ) )+ ( ^( ELSE expr ) )? ) );
    public SqlGenerator.caseExpr_return caseExpr() // throws RecognitionException [1]
    {   
        SqlGenerator.caseExpr_return retval = new SqlGenerator.caseExpr_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        CommonTree _first_0 = null;
        CommonTree _last = null;

        CommonTree CASE179 = null;
        CommonTree WHEN180 = null;
        CommonTree ELSE183 = null;
        CommonTree CASE2185 = null;
        CommonTree WHEN187 = null;
        CommonTree ELSE190 = null;
        SqlGenerator.booleanExpr_return booleanExpr181 = default(SqlGenerator.booleanExpr_return);

        SqlGenerator.expr_return expr182 = default(SqlGenerator.expr_return);

        SqlGenerator.expr_return expr184 = default(SqlGenerator.expr_return);

        SqlGenerator.expr_return expr186 = default(SqlGenerator.expr_return);

        SqlGenerator.expr_return expr188 = default(SqlGenerator.expr_return);

        SqlGenerator.expr_return expr189 = default(SqlGenerator.expr_return);

        SqlGenerator.expr_return expr191 = default(SqlGenerator.expr_return);


        CommonTree CASE179_tree=null;
        CommonTree WHEN180_tree=null;
        CommonTree ELSE183_tree=null;
        CommonTree CASE2185_tree=null;
        CommonTree WHEN187_tree=null;
        CommonTree ELSE190_tree=null;

        try 
    	{
            // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:307:2: ( ^( CASE ( ^( WHEN booleanExpr[false] expr ) )+ ( ^( ELSE expr ) )? ) | ^( CASE2 expr ( ^( WHEN expr expr ) )+ ( ^( ELSE expr ) )? ) )
            int alt54 = 2;
            int LA54_0 = input.LA(1);

            if ( (LA54_0 == CASE) )
            {
                alt54 = 1;
            }
            else if ( (LA54_0 == CASE2) )
            {
                alt54 = 2;
            }
            else 
            {
                if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                NoViableAltException nvae_d54s0 =
                    new NoViableAltException("", 54, 0, input);

                throw nvae_d54s0;
            }
            switch (alt54) 
            {
                case 1 :
                    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:307:4: ^( CASE ( ^( WHEN booleanExpr[false] expr ) )+ ( ^( ELSE expr ) )? )
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	_last = (CommonTree)input.LT(1);
                    	{
                    	CommonTree _save_last_1 = _last;
                    	CommonTree _first_1 = null;
                    	CommonTree root_1 = (CommonTree)adaptor.GetNilNode();_last = (CommonTree)input.LT(1);
                    	CASE179=(CommonTree)Match(input,CASE,FOLLOW_CASE_in_caseExpr1683); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{CASE179_tree = (CommonTree)adaptor.DupNode(CASE179);

                    		root_1 = (CommonTree)adaptor.BecomeRoot(CASE179_tree, root_1);
                    	}

                    	if ( state.backtracking == 0 ) 
                    	{
                    	   Out("case"); 
                    	}

                    	Match(input, Token.DOWN, null); if (state.failed) return retval;
                    	// /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:308:3: ( ^( WHEN booleanExpr[false] expr ) )+
                    	int cnt50 = 0;
                    	do 
                    	{
                    	    int alt50 = 2;
                    	    int LA50_0 = input.LA(1);

                    	    if ( (LA50_0 == WHEN) )
                    	    {
                    	        alt50 = 1;
                    	    }


                    	    switch (alt50) 
                    		{
                    			case 1 :
                    			    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:308:5: ^( WHEN booleanExpr[false] expr )
                    			    {
                    			    	_last = (CommonTree)input.LT(1);
                    			    	{
                    			    	CommonTree _save_last_2 = _last;
                    			    	CommonTree _first_2 = null;
                    			    	CommonTree root_2 = (CommonTree)adaptor.GetNilNode();_last = (CommonTree)input.LT(1);
                    			    	WHEN180=(CommonTree)Match(input,WHEN,FOLLOW_WHEN_in_caseExpr1693); if (state.failed) return retval;
                    			    	if ( state.backtracking == 0 )
                    			    	{WHEN180_tree = (CommonTree)adaptor.DupNode(WHEN180);

                    			    		root_2 = (CommonTree)adaptor.BecomeRoot(WHEN180_tree, root_2);
                    			    	}

                    			    	if ( state.backtracking == 0 ) 
                    			    	{
                    			    	   Out( " when "); 
                    			    	}

                    			    	Match(input, Token.DOWN, null); if (state.failed) return retval;
                    			    	_last = (CommonTree)input.LT(1);
                    			    	PushFollow(FOLLOW_booleanExpr_in_caseExpr1697);
                    			    	booleanExpr181 = booleanExpr(false);
                    			    	state.followingStackPointer--;
                    			    	if (state.failed) return retval;
                    			    	if ( state.backtracking==0 ) 
                    			    	adaptor.AddChild(root_2, booleanExpr181.Tree);
                    			    	if ( state.backtracking == 0 ) 
                    			    	{
                    			    	   Out(" then "); 
                    			    	}
                    			    	_last = (CommonTree)input.LT(1);
                    			    	PushFollow(FOLLOW_expr_in_caseExpr1702);
                    			    	expr182 = expr();
                    			    	state.followingStackPointer--;
                    			    	if (state.failed) return retval;
                    			    	if ( state.backtracking==0 ) 
                    			    	adaptor.AddChild(root_2, expr182.Tree);

                    			    	Match(input, Token.UP, null); if (state.failed) return retval;adaptor.AddChild(root_1, root_2);_last = _save_last_2;
                    			    	}


                    			    	if ( state.backtracking==0 ) {
                    			    	}
                    			    }
                    			    break;

                    			default:
                    			    if ( cnt50 >= 1 ) goto loop50;
                    			    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                    		            EarlyExitException eee =
                    		                new EarlyExitException(50, input);
                    		            throw eee;
                    	    }
                    	    cnt50++;
                    	} while (true);

                    	loop50:
                    		;	// Stops C# compiler whinging that label 'loop50' has no statements

                    	// /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:309:3: ( ^( ELSE expr ) )?
                    	int alt51 = 2;
                    	int LA51_0 = input.LA(1);

                    	if ( (LA51_0 == ELSE) )
                    	{
                    	    alt51 = 1;
                    	}
                    	switch (alt51) 
                    	{
                    	    case 1 :
                    	        // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:309:5: ^( ELSE expr )
                    	        {
                    	        	_last = (CommonTree)input.LT(1);
                    	        	{
                    	        	CommonTree _save_last_2 = _last;
                    	        	CommonTree _first_2 = null;
                    	        	CommonTree root_2 = (CommonTree)adaptor.GetNilNode();_last = (CommonTree)input.LT(1);
                    	        	ELSE183=(CommonTree)Match(input,ELSE,FOLLOW_ELSE_in_caseExpr1714); if (state.failed) return retval;
                    	        	if ( state.backtracking == 0 )
                    	        	{ELSE183_tree = (CommonTree)adaptor.DupNode(ELSE183);

                    	        		root_2 = (CommonTree)adaptor.BecomeRoot(ELSE183_tree, root_2);
                    	        	}

                    	        	if ( state.backtracking == 0 ) 
                    	        	{
                    	        	   Out(" else "); 
                    	        	}

                    	        	Match(input, Token.DOWN, null); if (state.failed) return retval;
                    	        	_last = (CommonTree)input.LT(1);
                    	        	PushFollow(FOLLOW_expr_in_caseExpr1718);
                    	        	expr184 = expr();
                    	        	state.followingStackPointer--;
                    	        	if (state.failed) return retval;
                    	        	if ( state.backtracking==0 ) 
                    	        	adaptor.AddChild(root_2, expr184.Tree);

                    	        	Match(input, Token.UP, null); if (state.failed) return retval;adaptor.AddChild(root_1, root_2);_last = _save_last_2;
                    	        	}


                    	        	if ( state.backtracking==0 ) {
                    	        	}
                    	        }
                    	        break;

                    	}

                    	if ( state.backtracking == 0 ) 
                    	{
                    	   Out(" end"); 
                    	}

                    	Match(input, Token.UP, null); if (state.failed) return retval;adaptor.AddChild(root_0, root_1);_last = _save_last_1;
                    	}


                    	if ( state.backtracking==0 ) {
                    	}
                    }
                    break;
                case 2 :
                    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:311:4: ^( CASE2 expr ( ^( WHEN expr expr ) )+ ( ^( ELSE expr ) )? )
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	_last = (CommonTree)input.LT(1);
                    	{
                    	CommonTree _save_last_1 = _last;
                    	CommonTree _first_1 = null;
                    	CommonTree root_1 = (CommonTree)adaptor.GetNilNode();_last = (CommonTree)input.LT(1);
                    	CASE2185=(CommonTree)Match(input,CASE2,FOLLOW_CASE2_in_caseExpr1734); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{CASE2185_tree = (CommonTree)adaptor.DupNode(CASE2185);

                    		root_1 = (CommonTree)adaptor.BecomeRoot(CASE2185_tree, root_1);
                    	}

                    	if ( state.backtracking == 0 ) 
                    	{
                    	   Out("case "); 
                    	}

                    	Match(input, Token.DOWN, null); if (state.failed) return retval;
                    	_last = (CommonTree)input.LT(1);
                    	PushFollow(FOLLOW_expr_in_caseExpr1738);
                    	expr186 = expr();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking==0 ) 
                    	adaptor.AddChild(root_1, expr186.Tree);
                    	// /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:312:3: ( ^( WHEN expr expr ) )+
                    	int cnt52 = 0;
                    	do 
                    	{
                    	    int alt52 = 2;
                    	    int LA52_0 = input.LA(1);

                    	    if ( (LA52_0 == WHEN) )
                    	    {
                    	        alt52 = 1;
                    	    }


                    	    switch (alt52) 
                    		{
                    			case 1 :
                    			    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:312:5: ^( WHEN expr expr )
                    			    {
                    			    	_last = (CommonTree)input.LT(1);
                    			    	{
                    			    	CommonTree _save_last_2 = _last;
                    			    	CommonTree _first_2 = null;
                    			    	CommonTree root_2 = (CommonTree)adaptor.GetNilNode();_last = (CommonTree)input.LT(1);
                    			    	WHEN187=(CommonTree)Match(input,WHEN,FOLLOW_WHEN_in_caseExpr1745); if (state.failed) return retval;
                    			    	if ( state.backtracking == 0 )
                    			    	{WHEN187_tree = (CommonTree)adaptor.DupNode(WHEN187);

                    			    		root_2 = (CommonTree)adaptor.BecomeRoot(WHEN187_tree, root_2);
                    			    	}

                    			    	if ( state.backtracking == 0 ) 
                    			    	{
                    			    	   Out( " when "); 
                    			    	}

                    			    	Match(input, Token.DOWN, null); if (state.failed) return retval;
                    			    	_last = (CommonTree)input.LT(1);
                    			    	PushFollow(FOLLOW_expr_in_caseExpr1749);
                    			    	expr188 = expr();
                    			    	state.followingStackPointer--;
                    			    	if (state.failed) return retval;
                    			    	if ( state.backtracking==0 ) 
                    			    	adaptor.AddChild(root_2, expr188.Tree);
                    			    	if ( state.backtracking == 0 ) 
                    			    	{
                    			    	   Out(" then "); 
                    			    	}
                    			    	_last = (CommonTree)input.LT(1);
                    			    	PushFollow(FOLLOW_expr_in_caseExpr1753);
                    			    	expr189 = expr();
                    			    	state.followingStackPointer--;
                    			    	if (state.failed) return retval;
                    			    	if ( state.backtracking==0 ) 
                    			    	adaptor.AddChild(root_2, expr189.Tree);

                    			    	Match(input, Token.UP, null); if (state.failed) return retval;adaptor.AddChild(root_1, root_2);_last = _save_last_2;
                    			    	}


                    			    	if ( state.backtracking==0 ) {
                    			    	}
                    			    }
                    			    break;

                    			default:
                    			    if ( cnt52 >= 1 ) goto loop52;
                    			    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                    		            EarlyExitException eee =
                    		                new EarlyExitException(52, input);
                    		            throw eee;
                    	    }
                    	    cnt52++;
                    	} while (true);

                    	loop52:
                    		;	// Stops C# compiler whinging that label 'loop52' has no statements

                    	// /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:313:3: ( ^( ELSE expr ) )?
                    	int alt53 = 2;
                    	int LA53_0 = input.LA(1);

                    	if ( (LA53_0 == ELSE) )
                    	{
                    	    alt53 = 1;
                    	}
                    	switch (alt53) 
                    	{
                    	    case 1 :
                    	        // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:313:5: ^( ELSE expr )
                    	        {
                    	        	_last = (CommonTree)input.LT(1);
                    	        	{
                    	        	CommonTree _save_last_2 = _last;
                    	        	CommonTree _first_2 = null;
                    	        	CommonTree root_2 = (CommonTree)adaptor.GetNilNode();_last = (CommonTree)input.LT(1);
                    	        	ELSE190=(CommonTree)Match(input,ELSE,FOLLOW_ELSE_in_caseExpr1765); if (state.failed) return retval;
                    	        	if ( state.backtracking == 0 )
                    	        	{ELSE190_tree = (CommonTree)adaptor.DupNode(ELSE190);

                    	        		root_2 = (CommonTree)adaptor.BecomeRoot(ELSE190_tree, root_2);
                    	        	}

                    	        	if ( state.backtracking == 0 ) 
                    	        	{
                    	        	   Out(" else "); 
                    	        	}

                    	        	Match(input, Token.DOWN, null); if (state.failed) return retval;
                    	        	_last = (CommonTree)input.LT(1);
                    	        	PushFollow(FOLLOW_expr_in_caseExpr1769);
                    	        	expr191 = expr();
                    	        	state.followingStackPointer--;
                    	        	if (state.failed) return retval;
                    	        	if ( state.backtracking==0 ) 
                    	        	adaptor.AddChild(root_2, expr191.Tree);

                    	        	Match(input, Token.UP, null); if (state.failed) return retval;adaptor.AddChild(root_1, root_2);_last = _save_last_2;
                    	        	}


                    	        	if ( state.backtracking==0 ) {
                    	        	}
                    	        }
                    	        break;

                    	}

                    	if ( state.backtracking == 0 ) 
                    	{
                    	   Out(" end"); 
                    	}

                    	Match(input, Token.UP, null); if (state.failed) return retval;adaptor.AddChild(root_0, root_1);_last = _save_last_1;
                    	}


                    	if ( state.backtracking==0 ) {
                    	}
                    }
                    break;

            }
            if ( state.backtracking==0 )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            }
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "caseExpr"

    public class aggregate_return : TreeRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "aggregate"
    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:317:1: aggregate : ^(a= AGGREGATE expr ) ;
    public SqlGenerator.aggregate_return aggregate() // throws RecognitionException [1]
    {   
        SqlGenerator.aggregate_return retval = new SqlGenerator.aggregate_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        CommonTree _first_0 = null;
        CommonTree _last = null;

        CommonTree a = null;
        SqlGenerator.expr_return expr192 = default(SqlGenerator.expr_return);


        CommonTree a_tree=null;

        try 
    	{
            // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:318:2: ( ^(a= AGGREGATE expr ) )
            // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:318:4: ^(a= AGGREGATE expr )
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	_last = (CommonTree)input.LT(1);
            	{
            	CommonTree _save_last_1 = _last;
            	CommonTree _first_1 = null;
            	CommonTree root_1 = (CommonTree)adaptor.GetNilNode();_last = (CommonTree)input.LT(1);
            	a=(CommonTree)Match(input,AGGREGATE,FOLLOW_AGGREGATE_in_aggregate1793); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{a_tree = (CommonTree)adaptor.DupNode(a);

            		root_1 = (CommonTree)adaptor.BecomeRoot(a_tree, root_1);
            	}

            	if ( state.backtracking == 0 ) 
            	{
            	   Out(a); Out("("); 
            	}

            	Match(input, Token.DOWN, null); if (state.failed) return retval;
            	_last = (CommonTree)input.LT(1);
            	PushFollow(FOLLOW_expr_in_aggregate1798);
            	expr192 = expr();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) 
            	adaptor.AddChild(root_1, expr192.Tree);
            	if ( state.backtracking == 0 ) 
            	{
            	   Out(")"); 
            	}

            	Match(input, Token.UP, null); if (state.failed) return retval;adaptor.AddChild(root_0, root_1);_last = _save_last_1;
            	}


            	if ( state.backtracking==0 ) {
            	}
            }

            if ( state.backtracking==0 )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            }
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "aggregate"

    public class methodCall_return : TreeRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "methodCall"
    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:322:1: methodCall : ^(m= METHOD_CALL i= METHOD_NAME ( ^( EXPR_LIST ( arguments )? ) )? ) ;
    public SqlGenerator.methodCall_return methodCall() // throws RecognitionException [1]
    {   
        SqlGenerator.methodCall_return retval = new SqlGenerator.methodCall_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        CommonTree _first_0 = null;
        CommonTree _last = null;

        CommonTree m = null;
        CommonTree i = null;
        CommonTree EXPR_LIST193 = null;
        SqlGenerator.arguments_return arguments194 = default(SqlGenerator.arguments_return);


        CommonTree m_tree=null;
        CommonTree i_tree=null;
        CommonTree EXPR_LIST193_tree=null;

        try 
    	{
            // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:323:2: ( ^(m= METHOD_CALL i= METHOD_NAME ( ^( EXPR_LIST ( arguments )? ) )? ) )
            // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:323:4: ^(m= METHOD_CALL i= METHOD_NAME ( ^( EXPR_LIST ( arguments )? ) )? )
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	_last = (CommonTree)input.LT(1);
            	{
            	CommonTree _save_last_1 = _last;
            	CommonTree _first_1 = null;
            	CommonTree root_1 = (CommonTree)adaptor.GetNilNode();_last = (CommonTree)input.LT(1);
            	m=(CommonTree)Match(input,METHOD_CALL,FOLLOW_METHOD_CALL_in_methodCall1817); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{m_tree = (CommonTree)adaptor.DupNode(m);

            		root_1 = (CommonTree)adaptor.BecomeRoot(m_tree, root_1);
            	}


            	Match(input, Token.DOWN, null); if (state.failed) return retval;
            	_last = (CommonTree)input.LT(1);
            	i=(CommonTree)Match(input,METHOD_NAME,FOLLOW_METHOD_NAME_in_methodCall1821); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{i_tree = (CommonTree)adaptor.DupNode(i);

            		adaptor.AddChild(root_1, i_tree);
            	}
            	if ( state.backtracking == 0 ) 
            	{
            	   beginFunctionTemplate(m,i); 
            	}
            	// /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:324:3: ( ^( EXPR_LIST ( arguments )? ) )?
            	int alt56 = 2;
            	int LA56_0 = input.LA(1);

            	if ( (LA56_0 == EXPR_LIST) )
            	{
            	    alt56 = 1;
            	}
            	switch (alt56) 
            	{
            	    case 1 :
            	        // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:324:5: ^( EXPR_LIST ( arguments )? )
            	        {
            	        	_last = (CommonTree)input.LT(1);
            	        	{
            	        	CommonTree _save_last_2 = _last;
            	        	CommonTree _first_2 = null;
            	        	CommonTree root_2 = (CommonTree)adaptor.GetNilNode();_last = (CommonTree)input.LT(1);
            	        	EXPR_LIST193=(CommonTree)Match(input,EXPR_LIST,FOLLOW_EXPR_LIST_in_methodCall1830); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{EXPR_LIST193_tree = (CommonTree)adaptor.DupNode(EXPR_LIST193);

            	        		root_2 = (CommonTree)adaptor.BecomeRoot(EXPR_LIST193_tree, root_2);
            	        	}


            	        	if ( input.LA(1) == Token.DOWN )
            	        	{
            	        	    Match(input, Token.DOWN, null); if (state.failed) return retval;
            	        	    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:324:17: ( arguments )?
            	        	    int alt55 = 2;
            	        	    int LA55_0 = input.LA(1);

            	        	    if ( ((LA55_0 >= ALL && LA55_0 <= ANY) || LA55_0 == COUNT || LA55_0 == DOT || LA55_0 == FALSE || LA55_0 == NULL || LA55_0 == SELECT || LA55_0 == SOME || LA55_0 == TRUE || LA55_0 == CASE || LA55_0 == AGGREGATE || LA55_0 == CASE2 || LA55_0 == INDEX_OP || LA55_0 == METHOD_CALL || LA55_0 == UNARY_MINUS || LA55_0 == VECTOR_EXPR || (LA55_0 >= CONSTANT && LA55_0 <= JAVA_CONSTANT) || (LA55_0 >= PLUS && LA55_0 <= DIV) || LA55_0 == PARAM || LA55_0 == IDENT || LA55_0 == ALIAS_REF || LA55_0 == SQL_TOKEN || LA55_0 == NAMED_PARAM || LA55_0 == QUOTED_STRING) )
            	        	    {
            	        	        alt55 = 1;
            	        	    }
            	        	    switch (alt55) 
            	        	    {
            	        	        case 1 :
            	        	            // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:324:18: arguments
            	        	            {
            	        	            	_last = (CommonTree)input.LT(1);
            	        	            	PushFollow(FOLLOW_arguments_in_methodCall1833);
            	        	            	arguments194 = arguments();
            	        	            	state.followingStackPointer--;
            	        	            	if (state.failed) return retval;
            	        	            	if ( state.backtracking==0 ) 
            	        	            	adaptor.AddChild(root_2, arguments194.Tree);

            	        	            	if ( state.backtracking==0 ) {
            	        	            	}
            	        	            }
            	        	            break;

            	        	    }


            	        	    Match(input, Token.UP, null); if (state.failed) return retval;
            	        	}adaptor.AddChild(root_1, root_2);_last = _save_last_2;
            	        	}


            	        	if ( state.backtracking==0 ) {
            	        	}
            	        }
            	        break;

            	}

            	if ( state.backtracking == 0 ) 
            	{
            	   endFunctionTemplate(m); 
            	}

            	Match(input, Token.UP, null); if (state.failed) return retval;adaptor.AddChild(root_0, root_1);_last = _save_last_1;
            	}


            	if ( state.backtracking==0 ) {
            	}
            }

            if ( state.backtracking==0 )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            }
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "methodCall"

    public class arguments_return : TreeRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "arguments"
    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:328:1: arguments : expr ( expr )* ;
    public SqlGenerator.arguments_return arguments() // throws RecognitionException [1]
    {   
        SqlGenerator.arguments_return retval = new SqlGenerator.arguments_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        CommonTree _first_0 = null;
        CommonTree _last = null;

        SqlGenerator.expr_return expr195 = default(SqlGenerator.expr_return);

        SqlGenerator.expr_return expr196 = default(SqlGenerator.expr_return);



        try 
    	{
            // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:329:2: ( expr ( expr )* )
            // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:329:4: expr ( expr )*
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	_last = (CommonTree)input.LT(1);
            	PushFollow(FOLLOW_expr_in_arguments1857);
            	expr195 = expr();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) 
            	adaptor.AddChild(root_0, expr195.Tree);
            	// /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:329:9: ( expr )*
            	do 
            	{
            	    int alt57 = 2;
            	    int LA57_0 = input.LA(1);

            	    if ( ((LA57_0 >= ALL && LA57_0 <= ANY) || LA57_0 == COUNT || LA57_0 == DOT || LA57_0 == FALSE || LA57_0 == NULL || LA57_0 == SELECT || LA57_0 == SOME || LA57_0 == TRUE || LA57_0 == CASE || LA57_0 == AGGREGATE || LA57_0 == CASE2 || LA57_0 == INDEX_OP || LA57_0 == METHOD_CALL || LA57_0 == UNARY_MINUS || LA57_0 == VECTOR_EXPR || (LA57_0 >= CONSTANT && LA57_0 <= JAVA_CONSTANT) || (LA57_0 >= PLUS && LA57_0 <= DIV) || LA57_0 == PARAM || LA57_0 == IDENT || LA57_0 == ALIAS_REF || LA57_0 == SQL_TOKEN || LA57_0 == NAMED_PARAM || LA57_0 == QUOTED_STRING) )
            	    {
            	        alt57 = 1;
            	    }


            	    switch (alt57) 
            		{
            			case 1 :
            			    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:329:11: expr
            			    {
            			    	if ( state.backtracking == 0 ) 
            			    	{
            			    	   commaBetweenParameters(", "); 
            			    	}
            			    	_last = (CommonTree)input.LT(1);
            			    	PushFollow(FOLLOW_expr_in_arguments1863);
            			    	expr196 = expr();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking==0 ) 
            			    	adaptor.AddChild(root_0, expr196.Tree);

            			    	if ( state.backtracking==0 ) {
            			    	}
            			    }
            			    break;

            			default:
            			    goto loop57;
            	    }
            	} while (true);

            	loop57:
            		;	// Stops C# compiler whining that label 'loop57' has no statements


            	if ( state.backtracking==0 ) {
            	}
            }

            if ( state.backtracking==0 )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            }
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "arguments"

    public class parameter_return : TreeRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "parameter"
    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:332:1: parameter : (n= NAMED_PARAM | p= PARAM );
    public SqlGenerator.parameter_return parameter() // throws RecognitionException [1]
    {   
        SqlGenerator.parameter_return retval = new SqlGenerator.parameter_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        CommonTree _first_0 = null;
        CommonTree _last = null;

        CommonTree n = null;
        CommonTree p = null;

        CommonTree n_tree=null;
        CommonTree p_tree=null;

        try 
    	{
            // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:333:2: (n= NAMED_PARAM | p= PARAM )
            int alt58 = 2;
            int LA58_0 = input.LA(1);

            if ( (LA58_0 == NAMED_PARAM) )
            {
                alt58 = 1;
            }
            else if ( (LA58_0 == PARAM) )
            {
                alt58 = 2;
            }
            else 
            {
                if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                NoViableAltException nvae_d58s0 =
                    new NoViableAltException("", 58, 0, input);

                throw nvae_d58s0;
            }
            switch (alt58) 
            {
                case 1 :
                    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:333:4: n= NAMED_PARAM
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	_last = (CommonTree)input.LT(1);
                    	n=(CommonTree)Match(input,NAMED_PARAM,FOLLOW_NAMED_PARAM_in_parameter1879); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{n_tree = (CommonTree)adaptor.DupNode(n);

                    		adaptor.AddChild(root_0, n_tree);
                    	}
                    	if ( state.backtracking == 0 ) 
                    	{
                    	   Out(n); 
                    	}

                    	if ( state.backtracking==0 ) {
                    	}
                    }
                    break;
                case 2 :
                    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:334:4: p= PARAM
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	_last = (CommonTree)input.LT(1);
                    	p=(CommonTree)Match(input,PARAM,FOLLOW_PARAM_in_parameter1888); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{p_tree = (CommonTree)adaptor.DupNode(p);

                    		adaptor.AddChild(root_0, p_tree);
                    	}
                    	if ( state.backtracking == 0 ) 
                    	{
                    	   Out(p); 
                    	}

                    	if ( state.backtracking==0 ) {
                    	}
                    }
                    break;

            }
            if ( state.backtracking==0 )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            }
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "parameter"

    public class addrExpr_return : TreeRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "addrExpr"
    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:337:1: addrExpr : ( ^(r= DOT . . ) | i= ALIAS_REF | j= INDEX_OP );
    public SqlGenerator.addrExpr_return addrExpr() // throws RecognitionException [1]
    {   
        SqlGenerator.addrExpr_return retval = new SqlGenerator.addrExpr_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        CommonTree _first_0 = null;
        CommonTree _last = null;

        CommonTree r = null;
        CommonTree i = null;
        CommonTree j = null;
        CommonTree wildcard197 = null;
        CommonTree wildcard198 = null;

        CommonTree r_tree=null;
        CommonTree i_tree=null;
        CommonTree j_tree=null;
        CommonTree wildcard197_tree=null;
        CommonTree wildcard198_tree=null;

        try 
    	{
            // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:338:2: ( ^(r= DOT . . ) | i= ALIAS_REF | j= INDEX_OP )
            int alt59 = 3;
            switch ( input.LA(1) ) 
            {
            case DOT:
            	{
                alt59 = 1;
                }
                break;
            case ALIAS_REF:
            	{
                alt59 = 2;
                }
                break;
            case INDEX_OP:
            	{
                alt59 = 3;
                }
                break;
            	default:
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    NoViableAltException nvae_d59s0 =
            	        new NoViableAltException("", 59, 0, input);

            	    throw nvae_d59s0;
            }

            switch (alt59) 
            {
                case 1 :
                    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:338:4: ^(r= DOT . . )
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	_last = (CommonTree)input.LT(1);
                    	{
                    	CommonTree _save_last_1 = _last;
                    	CommonTree _first_1 = null;
                    	CommonTree root_1 = (CommonTree)adaptor.GetNilNode();_last = (CommonTree)input.LT(1);
                    	r=(CommonTree)Match(input,DOT,FOLLOW_DOT_in_addrExpr1904); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{r_tree = (CommonTree)adaptor.DupNode(r);

                    		root_1 = (CommonTree)adaptor.BecomeRoot(r_tree, root_1);
                    	}


                    	Match(input, Token.DOWN, null); if (state.failed) return retval;
                    	wildcard197 = (CommonTree)input.LT(1);
                    	MatchAny(input); if (state.failed) return retval;
                    	wildcard198 = (CommonTree)input.LT(1);
                    	MatchAny(input); if (state.failed) return retval;

                    	Match(input, Token.UP, null); if (state.failed) return retval;adaptor.AddChild(root_0, root_1);_last = _save_last_1;
                    	}

                    	if ( state.backtracking == 0 ) 
                    	{
                    	   Out(r); 
                    	}

                    	if ( state.backtracking==0 ) {
                    	}
                    }
                    break;
                case 2 :
                    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:339:4: i= ALIAS_REF
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	_last = (CommonTree)input.LT(1);
                    	i=(CommonTree)Match(input,ALIAS_REF,FOLLOW_ALIAS_REF_in_addrExpr1918); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{i_tree = (CommonTree)adaptor.DupNode(i);

                    		adaptor.AddChild(root_0, i_tree);
                    	}
                    	if ( state.backtracking == 0 ) 
                    	{
                    	   Out(i); 
                    	}

                    	if ( state.backtracking==0 ) {
                    	}
                    }
                    break;
                case 3 :
                    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:340:4: j= INDEX_OP
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	_last = (CommonTree)input.LT(1);
                    	j=(CommonTree)Match(input,INDEX_OP,FOLLOW_INDEX_OP_in_addrExpr1927); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{j_tree = (CommonTree)adaptor.DupNode(j);

                    		adaptor.AddChild(root_0, j_tree);
                    	}
                    	if ( state.backtracking == 0 ) 
                    	{
                    	   Out(j); 
                    	}

                    	if ( state.backtracking==0 ) {
                    	}
                    }
                    break;

            }
            if ( state.backtracking==0 )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            }
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "addrExpr"

    public class sqlToken_return : TreeRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "sqlToken"
    // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:343:1: sqlToken : t= SQL_TOKEN ;
    public SqlGenerator.sqlToken_return sqlToken() // throws RecognitionException [1]
    {   
        SqlGenerator.sqlToken_return retval = new SqlGenerator.sqlToken_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        CommonTree _first_0 = null;
        CommonTree _last = null;

        CommonTree t = null;

        CommonTree t_tree=null;

        try 
    	{
            // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:344:2: (t= SQL_TOKEN )
            // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:344:4: t= SQL_TOKEN
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	_last = (CommonTree)input.LT(1);
            	t=(CommonTree)Match(input,SQL_TOKEN,FOLLOW_SQL_TOKEN_in_sqlToken1942); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{t_tree = (CommonTree)adaptor.DupNode(t);

            		adaptor.AddChild(root_0, t_tree);
            	}
            	if ( state.backtracking == 0 ) 
            	{
            	   Out(t); 
            	}

            	if ( state.backtracking==0 ) {
            	}
            }

            if ( state.backtracking==0 )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            }
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "sqlToken"

    // $ANTLR start "synpred1_SqlGenerator"
    public void synpred1_SqlGenerator_fragment() {
        // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:76:4: ( SQL_TOKEN )
        // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:76:5: SQL_TOKEN
        {
        	Match(input,SQL_TOKEN,FOLLOW_SQL_TOKEN_in_synpred1_SqlGenerator317); if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred1_SqlGenerator"

    // $ANTLR start "synpred2_SqlGenerator"
    public void synpred2_SqlGenerator_fragment() {
        // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:296:4: ( additiveExpr )
        // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:296:5: additiveExpr
        {
        	PushFollow(FOLLOW_additiveExpr_in_synpred2_SqlGenerator1628);
        	additiveExpr();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred2_SqlGenerator"

    // $ANTLR start "synpred3_SqlGenerator"
    public void synpred3_SqlGenerator_fragment() {
        // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:302:4: ( arithmeticExpr )
        // /Users/Steve/Projects/uNhAddins/Trunk/ANTLR-HQL/ANTLR-HQL/SqlGenerator.g:302:5: arithmeticExpr
        {
        	PushFollow(FOLLOW_arithmeticExpr_in_synpred3_SqlGenerator1657);
        	arithmeticExpr();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred3_SqlGenerator"

    // Delegated rules

   	public bool synpred2_SqlGenerator() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred2_SqlGenerator_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred1_SqlGenerator() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred1_SqlGenerator_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred3_SqlGenerator() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred3_SqlGenerator_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}


   	protected DFA48 dfa48;
   	protected DFA49 dfa49;
	private void InitializeCyclicDFAs()
	{
    	this.dfa48 = new DFA48(this);
    	this.dfa49 = new DFA49(this);
	    this.dfa48.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA48_SpecialStateTransition);
	    this.dfa49.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA49_SpecialStateTransition);
	}

    const string DFA48_eotS =
        "\x19\uffff";
    const string DFA48_eofS =
        "\x19\uffff";
    const string DFA48_minS =
        "\x01\x04\x02\x00\x16\uffff";
    const string DFA48_maxS =
        "\x01\u0090\x02\x00\x16\uffff";
    const string DFA48_acceptS =
        "\x03\uffff\x01\x02\x14\uffff\x01\x01";
    const string DFA48_specialS =
        "\x01\uffff\x01\x00\x01\x01\x16\uffff}>";
    static readonly string[] DFA48_transitionS = {
            "\x02\x03\x06\uffff\x01\x03\x02\uffff\x01\x03\x04\uffff\x01\x03"+
            "\x12\uffff\x01\x03\x05\uffff\x01\x03\x01\uffff\x01\x03\x01\uffff"+
            "\x01\x03\x05\uffff\x01\x03\x0d\uffff\x01\x03\x02\uffff\x01\x03"+
            "\x03\uffff\x01\x03\x02\uffff\x01\x03\x08\uffff\x01\x03\x01\uffff"+
            "\x01\x03\x01\uffff\x06\x03\x0b\uffff\x01\x01\x01\x02\x02\x03"+
            "\x03\uffff\x01\x03\x01\uffff\x01\x03\x0f\uffff\x01\x03\x01\uffff"+
            "\x01\x03\x05\uffff\x01\x03\x01\uffff\x01\x03",
            "\x01\uffff",
            "\x01\uffff",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            ""
    };

    static readonly short[] DFA48_eot = DFA.UnpackEncodedString(DFA48_eotS);
    static readonly short[] DFA48_eof = DFA.UnpackEncodedString(DFA48_eofS);
    static readonly char[] DFA48_min = DFA.UnpackEncodedStringToUnsignedChars(DFA48_minS);
    static readonly char[] DFA48_max = DFA.UnpackEncodedStringToUnsignedChars(DFA48_maxS);
    static readonly short[] DFA48_accept = DFA.UnpackEncodedString(DFA48_acceptS);
    static readonly short[] DFA48_special = DFA.UnpackEncodedString(DFA48_specialS);
    static readonly short[][] DFA48_transition = DFA.UnpackEncodedStringArray(DFA48_transitionS);

    protected class DFA48 : DFA
    {
        public DFA48(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 48;
            this.eot = DFA48_eot;
            this.eof = DFA48_eof;
            this.min = DFA48_min;
            this.max = DFA48_max;
            this.accept = DFA48_accept;
            this.special = DFA48_special;
            this.transition = DFA48_transition;

        }

        override public string Description
        {
            get { return "294:1: nestedExpr : ( ( additiveExpr )=> additiveExpr | expr );"; }
        }

    }


    protected internal int DFA48_SpecialStateTransition(DFA dfa, int s, IIntStream _input) //throws NoViableAltException
    {
            ITreeNodeStream input = (ITreeNodeStream)_input;
    	int _s = s;
        switch ( s )
        {
               	case 0 : 
                   	int LA48_1 = input.LA(1);

                   	 
                   	int index48_1 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred2_SqlGenerator()) ) { s = 24; }

                   	else if ( (true) ) { s = 3; }

                   	 
                   	input.Seek(index48_1);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 1 : 
                   	int LA48_2 = input.LA(1);

                   	 
                   	int index48_2 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred2_SqlGenerator()) ) { s = 24; }

                   	else if ( (true) ) { s = 3; }

                   	 
                   	input.Seek(index48_2);
                   	if ( s >= 0 ) return s;
                   	break;
        }
        if (state.backtracking > 0) {state.failed = true; return -1;}
        NoViableAltException nvae =
            new NoViableAltException(dfa.Description, 48, _s, input);
        dfa.Error(nvae);
        throw nvae;
    }
    const string DFA49_eotS =
        "\x19\uffff";
    const string DFA49_eofS =
        "\x19\uffff";
    const string DFA49_minS =
        "\x01\x04\x07\x00\x11\uffff";
    const string DFA49_maxS =
        "\x01\u0090\x07\x00\x11\uffff";
    const string DFA49_acceptS =
        "\x08\uffff\x01\x02\x0f\uffff\x01\x01";
    const string DFA49_specialS =
        "\x01\uffff\x01\x00\x01\x01\x01\x02\x01\x03\x01\x04\x01\x05\x01\x06"+
        "\x11\uffff}>";
    static readonly string[] DFA49_transitionS = {
            "\x02\x08\x06\uffff\x01\x08\x02\uffff\x01\x08\x04\uffff\x01\x08"+
            "\x12\uffff\x01\x08\x05\uffff\x01\x08\x01\uffff\x01\x08\x01\uffff"+
            "\x01\x08\x05\uffff\x01\x06\x0d\uffff\x01\x08\x02\uffff\x01\x07"+
            "\x03\uffff\x01\x08\x02\uffff\x01\x08\x08\uffff\x01\x05\x01\uffff"+
            "\x01\x08\x01\uffff\x06\x08\x0b\uffff\x01\x01\x01\x02\x01\x03"+
            "\x01\x04\x03\uffff\x01\x08\x01\uffff\x01\x08\x0f\uffff\x01\x08"+
            "\x01\uffff\x01\x08\x05\uffff\x01\x08\x01\uffff\x01\x08",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            ""
    };

    static readonly short[] DFA49_eot = DFA.UnpackEncodedString(DFA49_eotS);
    static readonly short[] DFA49_eof = DFA.UnpackEncodedString(DFA49_eofS);
    static readonly char[] DFA49_min = DFA.UnpackEncodedStringToUnsignedChars(DFA49_minS);
    static readonly char[] DFA49_max = DFA.UnpackEncodedStringToUnsignedChars(DFA49_maxS);
    static readonly short[] DFA49_accept = DFA.UnpackEncodedString(DFA49_acceptS);
    static readonly short[] DFA49_special = DFA.UnpackEncodedString(DFA49_specialS);
    static readonly short[][] DFA49_transition = DFA.UnpackEncodedStringArray(DFA49_transitionS);

    protected class DFA49 : DFA
    {
        public DFA49(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 49;
            this.eot = DFA49_eot;
            this.eof = DFA49_eof;
            this.min = DFA49_min;
            this.max = DFA49_max;
            this.accept = DFA49_accept;
            this.special = DFA49_special;
            this.transition = DFA49_transition;

        }

        override public string Description
        {
            get { return "300:1: nestedExprAfterMinusDiv : ( ( arithmeticExpr )=> arithmeticExpr | expr );"; }
        }

    }


    protected internal int DFA49_SpecialStateTransition(DFA dfa, int s, IIntStream _input) //throws NoViableAltException
    {
            ITreeNodeStream input = (ITreeNodeStream)_input;
    	int _s = s;
        switch ( s )
        {
               	case 0 : 
                   	int LA49_1 = input.LA(1);

                   	 
                   	int index49_1 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred3_SqlGenerator()) ) { s = 24; }

                   	else if ( (true) ) { s = 8; }

                   	 
                   	input.Seek(index49_1);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 1 : 
                   	int LA49_2 = input.LA(1);

                   	 
                   	int index49_2 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred3_SqlGenerator()) ) { s = 24; }

                   	else if ( (true) ) { s = 8; }

                   	 
                   	input.Seek(index49_2);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 2 : 
                   	int LA49_3 = input.LA(1);

                   	 
                   	int index49_3 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred3_SqlGenerator()) ) { s = 24; }

                   	else if ( (true) ) { s = 8; }

                   	 
                   	input.Seek(index49_3);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 3 : 
                   	int LA49_4 = input.LA(1);

                   	 
                   	int index49_4 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred3_SqlGenerator()) ) { s = 24; }

                   	else if ( (true) ) { s = 8; }

                   	 
                   	input.Seek(index49_4);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 4 : 
                   	int LA49_5 = input.LA(1);

                   	 
                   	int index49_5 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred3_SqlGenerator()) ) { s = 24; }

                   	else if ( (true) ) { s = 8; }

                   	 
                   	input.Seek(index49_5);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 5 : 
                   	int LA49_6 = input.LA(1);

                   	 
                   	int index49_6 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred3_SqlGenerator()) ) { s = 24; }

                   	else if ( (true) ) { s = 8; }

                   	 
                   	input.Seek(index49_6);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 6 : 
                   	int LA49_7 = input.LA(1);

                   	 
                   	int index49_7 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred3_SqlGenerator()) ) { s = 24; }

                   	else if ( (true) ) { s = 8; }

                   	 
                   	input.Seek(index49_7);
                   	if ( s >= 0 ) return s;
                   	break;
        }
        if (state.backtracking > 0) {state.failed = true; return -1;}
        NoViableAltException nvae =
            new NoViableAltException(dfa.Description, 49, _s, input);
        dfa.Error(nvae);
        throw nvae;
    }
 

    public static readonly BitSet FOLLOW_selectStatement_in_statement51 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_updateStatement_in_statement56 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_deleteStatement_in_statement61 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_insertStatement_in_statement66 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_SELECT_in_selectStatement78 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_selectClause_in_selectStatement84 = new BitSet(new ulong[]{0x0000000000400000UL});
    public static readonly BitSet FOLLOW_from_in_selectStatement88 = new BitSet(new ulong[]{0x0020020001000008UL});
    public static readonly BitSet FOLLOW_WHERE_in_selectStatement95 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_whereExpr_in_selectStatement99 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_GROUP_in_selectStatement111 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_groupExprs_in_selectStatement115 = new BitSet(new ulong[]{0x0000000002000008UL});
    public static readonly BitSet FOLLOW_HAVING_in_selectStatement120 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_booleanExpr_in_selectStatement124 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_ORDER_in_selectStatement141 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_orderExprs_in_selectStatement145 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_UPDATE_in_updateStatement168 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_FROM_in_updateStatement176 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_fromTable_in_updateStatement178 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_setClause_in_updateStatement184 = new BitSet(new ulong[]{0x0020000000000008UL});
    public static readonly BitSet FOLLOW_whereClause_in_updateStatement189 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_DELETE_in_deleteStatement208 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_from_in_deleteStatement214 = new BitSet(new ulong[]{0x0020000000000008UL});
    public static readonly BitSet FOLLOW_whereClause_in_deleteStatement219 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_INSERT_in_insertStatement236 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_INTO_in_insertStatement244 = new BitSet(new ulong[]{0x0000200000000000UL});
    public static readonly BitSet FOLLOW_selectStatement_in_insertStatement250 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_SET_in_setClause270 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_comparisonExpr_in_setClause274 = new BitSet(new ulong[]{0x0000000404080408UL,0x00000F4800076000UL});
    public static readonly BitSet FOLLOW_comparisonExpr_in_setClause281 = new BitSet(new ulong[]{0x0000000404080408UL,0x00000F4800076000UL});
    public static readonly BitSet FOLLOW_WHERE_in_whereClause299 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_whereClauseExpr_in_whereClause303 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_conditionList_in_whereClauseExpr322 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_booleanExpr_in_whereClauseExpr327 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_expr_in_orderExprs343 = new BitSet(new ulong[]{0x0082A0800010D132UL,0x0051E003F5009120UL,0x0000000000014140UL});
    public static readonly BitSet FOLLOW_orderDirection_in_orderExprs350 = new BitSet(new ulong[]{0x0082A08000109032UL,0x0051E003F5009120UL,0x0000000000014140UL});
    public static readonly BitSet FOLLOW_orderExprs_in_orderExprs360 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_expr_in_groupExprs375 = new BitSet(new ulong[]{0x0082A08000109032UL,0x0051E003F5009120UL,0x0000000000014140UL});
    public static readonly BitSet FOLLOW_groupExprs_in_groupExprs381 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_orderDirection0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_filters_in_whereExpr416 = new BitSet(new ulong[]{0x0000014404080442UL,0x00000F4800076000UL,0x0000000000000900UL});
    public static readonly BitSet FOLLOW_thetaJoins_in_whereExpr424 = new BitSet(new ulong[]{0x0000014404080442UL,0x00000F4800076000UL,0x0000000000000100UL});
    public static readonly BitSet FOLLOW_booleanExpr_in_whereExpr435 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_thetaJoins_in_whereExpr445 = new BitSet(new ulong[]{0x0000014404080442UL,0x00000F4800076000UL,0x0000000000000100UL});
    public static readonly BitSet FOLLOW_booleanExpr_in_whereExpr453 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_booleanExpr_in_whereExpr464 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_FILTERS_in_filters477 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_conditionList_in_filters479 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_THETA_JOINS_in_thetaJoins493 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_conditionList_in_thetaJoins495 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_sqlToken_in_conditionList508 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000000UL,0x0000000000000100UL});
    public static readonly BitSet FOLLOW_conditionList_in_conditionList514 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_SELECT_CLAUSE_in_selectClause529 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_distinctOrAll_in_selectClause532 = new BitSet(new ulong[]{0x0082208000109000UL,0x0051E003F10091A0UL,0x0000000000014540UL});
    public static readonly BitSet FOLLOW_selectColumn_in_selectClause538 = new BitSet(new ulong[]{0x0082208000109008UL,0x0051E003F10091A0UL,0x0000000000014540UL});
    public static readonly BitSet FOLLOW_selectExpr_in_selectColumn556 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000000UL,0x0000000000000200UL});
    public static readonly BitSet FOLLOW_SELECT_COLUMNS_in_selectColumn561 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_selectAtom_in_selectExpr581 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_count_in_selectExpr588 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_CONSTRUCTOR_in_selectExpr594 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_set_in_selectExpr596 = new BitSet(new ulong[]{0x0082208000109000UL,0x0051E003F10091A0UL,0x0000000000014540UL});
    public static readonly BitSet FOLLOW_selectColumn_in_selectExpr606 = new BitSet(new ulong[]{0x0082208000109008UL,0x0051E003F10091A0UL,0x0000000000014540UL});
    public static readonly BitSet FOLLOW_methodCall_in_selectExpr616 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_aggregate_in_selectExpr621 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_constant_in_selectExpr628 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_arithmeticExpr_in_selectExpr635 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_PARAM_in_selectExpr642 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_selectStatement_in_selectExpr652 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_COUNT_in_count666 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_distinctOrAll_in_count673 = new BitSet(new ulong[]{0x0082008000109000UL,0x0051E003F1409120UL,0x0000000000014140UL});
    public static readonly BitSet FOLLOW_countExpr_in_count679 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_DISTINCT_in_distinctOrAll694 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ALL_in_distinctOrAll701 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ROW_STAR_in_countExpr716 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_simpleExpr_in_countExpr723 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_selectAtom0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_FROM_in_from768 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_fromTable_in_from775 = new BitSet(new ulong[]{0x0000000000000008UL,0x0000000000000000UL,0x0000000000000005UL});
    public static readonly BitSet FOLLOW_FROM_FRAGMENT_in_fromTable796 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_tableJoin_in_fromTable802 = new BitSet(new ulong[]{0x0000000000000008UL,0x0000000000000000UL,0x0000000000000005UL});
    public static readonly BitSet FOLLOW_JOIN_FRAGMENT_in_fromTable819 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_tableJoin_in_fromTable825 = new BitSet(new ulong[]{0x0000000000000008UL,0x0000000000000000UL,0x0000000000000005UL});
    public static readonly BitSet FOLLOW_JOIN_FRAGMENT_in_tableJoin850 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_tableJoin_in_tableJoin855 = new BitSet(new ulong[]{0x0000000000000008UL,0x0000000000000000UL,0x0000000000000005UL});
    public static readonly BitSet FOLLOW_FROM_FRAGMENT_in_tableJoin871 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_tableJoin_in_tableJoin876 = new BitSet(new ulong[]{0x0000000000000008UL,0x0000000000000000UL,0x0000000000000005UL});
    public static readonly BitSet FOLLOW_AND_in_booleanOp896 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_booleanExpr_in_booleanOp898 = new BitSet(new ulong[]{0x0000014404080440UL,0x00000F4800076000UL,0x0000000000000100UL});
    public static readonly BitSet FOLLOW_booleanExpr_in_booleanOp903 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_OR_in_booleanOp911 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_booleanExpr_in_booleanOp915 = new BitSet(new ulong[]{0x0000014404080440UL,0x00000F4800076000UL,0x0000000000000100UL});
    public static readonly BitSet FOLLOW_booleanExpr_in_booleanOp920 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_NOT_in_booleanOp930 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_booleanExpr_in_booleanOp934 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_booleanOp_in_booleanExpr951 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_comparisonExpr_in_booleanExpr958 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_SQL_TOKEN_in_booleanExpr967 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_binaryComparisonExpression_in_comparisonExpr983 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_exoticComparisonExpression_in_comparisonExpr990 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_EQ_in_binaryComparisonExpression1005 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expr_in_binaryComparisonExpression1007 = new BitSet(new ulong[]{0x0082A08000109030UL,0x0051E003F5009120UL,0x0000000000014140UL});
    public static readonly BitSet FOLLOW_expr_in_binaryComparisonExpression1011 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_NE_in_binaryComparisonExpression1018 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expr_in_binaryComparisonExpression1020 = new BitSet(new ulong[]{0x0082A08000109030UL,0x0051E003F5009120UL,0x0000000000014140UL});
    public static readonly BitSet FOLLOW_expr_in_binaryComparisonExpression1024 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_GT_in_binaryComparisonExpression1031 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expr_in_binaryComparisonExpression1033 = new BitSet(new ulong[]{0x0082A08000109030UL,0x0051E003F5009120UL,0x0000000000014140UL});
    public static readonly BitSet FOLLOW_expr_in_binaryComparisonExpression1037 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_GE_in_binaryComparisonExpression1044 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expr_in_binaryComparisonExpression1046 = new BitSet(new ulong[]{0x0082A08000109030UL,0x0051E003F5009120UL,0x0000000000014140UL});
    public static readonly BitSet FOLLOW_expr_in_binaryComparisonExpression1050 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_LT_in_binaryComparisonExpression1057 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expr_in_binaryComparisonExpression1059 = new BitSet(new ulong[]{0x0082A08000109030UL,0x0051E003F5009120UL,0x0000000000014140UL});
    public static readonly BitSet FOLLOW_expr_in_binaryComparisonExpression1063 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_LE_in_binaryComparisonExpression1070 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expr_in_binaryComparisonExpression1072 = new BitSet(new ulong[]{0x0082A08000109030UL,0x0051E003F5009120UL,0x0000000000014140UL});
    public static readonly BitSet FOLLOW_expr_in_binaryComparisonExpression1076 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_LIKE_in_exoticComparisonExpression1090 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expr_in_exoticComparisonExpression1092 = new BitSet(new ulong[]{0x0082A08000109030UL,0x0051E003F5009120UL,0x0000000000014140UL});
    public static readonly BitSet FOLLOW_expr_in_exoticComparisonExpression1096 = new BitSet(new ulong[]{0x0000000000040008UL});
    public static readonly BitSet FOLLOW_likeEscape_in_exoticComparisonExpression1098 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_NOT_LIKE_in_exoticComparisonExpression1106 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expr_in_exoticComparisonExpression1108 = new BitSet(new ulong[]{0x0082A08000109030UL,0x0051E003F5009120UL,0x0000000000014140UL});
    public static readonly BitSet FOLLOW_expr_in_exoticComparisonExpression1112 = new BitSet(new ulong[]{0x0000000000040008UL});
    public static readonly BitSet FOLLOW_likeEscape_in_exoticComparisonExpression1114 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_BETWEEN_in_exoticComparisonExpression1121 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expr_in_exoticComparisonExpression1123 = new BitSet(new ulong[]{0x0082A08000109030UL,0x0051E003F5009120UL,0x0000000000014140UL});
    public static readonly BitSet FOLLOW_expr_in_exoticComparisonExpression1127 = new BitSet(new ulong[]{0x0082A08000109030UL,0x0051E003F5009120UL,0x0000000000014140UL});
    public static readonly BitSet FOLLOW_expr_in_exoticComparisonExpression1131 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_NOT_BETWEEN_in_exoticComparisonExpression1138 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expr_in_exoticComparisonExpression1140 = new BitSet(new ulong[]{0x0082A08000109030UL,0x0051E003F5009120UL,0x0000000000014140UL});
    public static readonly BitSet FOLLOW_expr_in_exoticComparisonExpression1144 = new BitSet(new ulong[]{0x0082A08000109030UL,0x0051E003F5009120UL,0x0000000000014140UL});
    public static readonly BitSet FOLLOW_expr_in_exoticComparisonExpression1148 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_IN_in_exoticComparisonExpression1155 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expr_in_exoticComparisonExpression1157 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000800UL});
    public static readonly BitSet FOLLOW_inList_in_exoticComparisonExpression1161 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_NOT_IN_in_exoticComparisonExpression1169 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expr_in_exoticComparisonExpression1171 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000800UL});
    public static readonly BitSet FOLLOW_inList_in_exoticComparisonExpression1175 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_EXISTS_in_exoticComparisonExpression1183 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_quantified_in_exoticComparisonExpression1187 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_IS_NULL_in_exoticComparisonExpression1195 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expr_in_exoticComparisonExpression1197 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_IS_NOT_NULL_in_exoticComparisonExpression1206 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expr_in_exoticComparisonExpression1208 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_ESCAPE_in_likeEscape1225 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expr_in_likeEscape1229 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_IN_LIST_in_inList1245 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_parenSelect_in_inList1251 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_simpleExprList_in_inList1255 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_simpleExpr_in_simpleExprList1276 = new BitSet(new ulong[]{0x0082008000109002UL,0x0051E003F1009120UL,0x0000000000014140UL});
    public static readonly BitSet FOLLOW_simpleExpr_in_expr1295 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_VECTOR_EXPR_in_expr1302 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expr_in_expr1309 = new BitSet(new ulong[]{0x0082A08000109038UL,0x0051E003F5009120UL,0x0000000000014140UL});
    public static readonly BitSet FOLLOW_parenSelect_in_expr1324 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ANY_in_expr1330 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_quantified_in_expr1334 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_ALL_in_expr1342 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_quantified_in_expr1346 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_SOME_in_expr1354 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_quantified_in_expr1358 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_sqlToken_in_quantified1376 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_selectStatement_in_quantified1380 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_selectStatement_in_parenSelect1399 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_constant_in_simpleExpr1415 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_NULL_in_simpleExpr1422 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_addrExpr_in_simpleExpr1429 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_sqlToken_in_simpleExpr1434 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_aggregate_in_simpleExpr1439 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_methodCall_in_simpleExpr1444 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_count_in_simpleExpr1449 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_parameter_in_simpleExpr1454 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_arithmeticExpr_in_simpleExpr1459 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_constant0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_additiveExpr_in_arithmeticExpr1528 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_multiplicativeExpr_in_arithmeticExpr1533 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_UNARY_MINUS_in_arithmeticExpr1540 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expr_in_arithmeticExpr1544 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_caseExpr_in_arithmeticExpr1550 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_PLUS_in_additiveExpr1562 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expr_in_additiveExpr1564 = new BitSet(new ulong[]{0x0082A08000109030UL,0x0051E003F5009120UL,0x0000000000014140UL});
    public static readonly BitSet FOLLOW_expr_in_additiveExpr1568 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_MINUS_in_additiveExpr1575 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expr_in_additiveExpr1577 = new BitSet(new ulong[]{0x0082A08000109030UL,0x0051E003F5009120UL,0x0000000000014140UL});
    public static readonly BitSet FOLLOW_nestedExprAfterMinusDiv_in_additiveExpr1581 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_STAR_in_multiplicativeExpr1594 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_nestedExpr_in_multiplicativeExpr1596 = new BitSet(new ulong[]{0x0082A08000109030UL,0x0051E003F5009120UL,0x0000000000014140UL});
    public static readonly BitSet FOLLOW_nestedExpr_in_multiplicativeExpr1600 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_DIV_in_multiplicativeExpr1607 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_nestedExpr_in_multiplicativeExpr1609 = new BitSet(new ulong[]{0x0082A08000109030UL,0x0051E003F5009120UL,0x0000000000014140UL});
    public static readonly BitSet FOLLOW_nestedExprAfterMinusDiv_in_multiplicativeExpr1613 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_additiveExpr_in_nestedExpr1635 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_expr_in_nestedExpr1642 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_arithmeticExpr_in_nestedExprAfterMinusDiv1664 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_expr_in_nestedExprAfterMinusDiv1671 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_CASE_in_caseExpr1683 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_WHEN_in_caseExpr1693 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_booleanExpr_in_caseExpr1697 = new BitSet(new ulong[]{0x0082A08000109030UL,0x0051E003F5009120UL,0x0000000000014140UL});
    public static readonly BitSet FOLLOW_expr_in_caseExpr1702 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_ELSE_in_caseExpr1714 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expr_in_caseExpr1718 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_CASE2_in_caseExpr1734 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expr_in_caseExpr1738 = new BitSet(new ulong[]{0x0800000000000000UL});
    public static readonly BitSet FOLLOW_WHEN_in_caseExpr1745 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expr_in_caseExpr1749 = new BitSet(new ulong[]{0x0082A08000109030UL,0x0051E003F5009120UL,0x0000000000014140UL});
    public static readonly BitSet FOLLOW_expr_in_caseExpr1753 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_ELSE_in_caseExpr1765 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expr_in_caseExpr1769 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_AGGREGATE_in_aggregate1793 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expr_in_aggregate1798 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_METHOD_CALL_in_methodCall1817 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_METHOD_NAME_in_methodCall1821 = new BitSet(new ulong[]{0x0000000000000008UL,0x0000000000000200UL});
    public static readonly BitSet FOLLOW_EXPR_LIST_in_methodCall1830 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_arguments_in_methodCall1833 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_expr_in_arguments1857 = new BitSet(new ulong[]{0x0082A08000109032UL,0x0051E003F5009120UL,0x0000000000014140UL});
    public static readonly BitSet FOLLOW_expr_in_arguments1863 = new BitSet(new ulong[]{0x0082A08000109032UL,0x0051E003F5009120UL,0x0000000000014140UL});
    public static readonly BitSet FOLLOW_NAMED_PARAM_in_parameter1879 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_PARAM_in_parameter1888 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_DOT_in_addrExpr1904 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_ALIAS_REF_in_addrExpr1918 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_INDEX_OP_in_addrExpr1927 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_SQL_TOKEN_in_sqlToken1942 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_SQL_TOKEN_in_synpred1_SqlGenerator317 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_additiveExpr_in_synpred2_SqlGenerator1628 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_arithmeticExpr_in_synpred3_SqlGenerator1657 = new BitSet(new ulong[]{0x0000000000000002UL});

}
}