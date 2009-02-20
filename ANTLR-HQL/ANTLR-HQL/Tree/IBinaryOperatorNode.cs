﻿using Antlr.Runtime.Tree;

namespace NHibernate.Hql.Ast.ANTLR.Tree
{
	/// <summary>
	/// Contract for nodes representing binary operators.
	/// Author: Steve Ebersole
	/// Ported by: Steve Strong
	/// </summary>
	public interface IBinaryOperatorNode : IOperatorNode 
	{
		/// <summary>
		/// The left-hand operand of the operator.
		/// </summary>
		ITree LeftHandOperand
		{ 
			get;
		}

		/// <summary>
		/// The right-hand operand of the operator.
		/// </summary>
		ITree RightHandOperand
		{ 
			get;
		}
	}
}
