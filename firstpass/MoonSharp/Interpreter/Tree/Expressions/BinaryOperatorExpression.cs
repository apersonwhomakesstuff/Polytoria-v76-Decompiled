using System;
using MoonSharp.Interpreter.Execution;
using MoonSharp.Interpreter.Execution.VM;

namespace MoonSharp.Interpreter.Tree.Expressions
{
	// Token: 0x02000076 RID: 118
	internal class BinaryOperatorExpression : Expression
	{
		// Token: 0x0600069C RID: 1692 RVA: 0x0000D541 File Offset: 0x0000B741
		public static object BeginOperatorChain()
		{
			return null;
		}

		// Token: 0x0600069D RID: 1693 RVA: 0x0000D544 File Offset: 0x0000B744
		public static void AddExpressionToChain(object chain, Expression exp)
		{
		}

		// Token: 0x0600069E RID: 1694 RVA: 0x0000D546 File Offset: 0x0000B746
		public static void AddOperatorToChain(object chain, Token op)
		{
		}

		// Token: 0x0600069F RID: 1695 RVA: 0x0000D548 File Offset: 0x0000B748
		public static Expression CommitOperatorChain(object chain, ScriptLoadingContext lcontext)
		{
			return null;
		}

		// Token: 0x060006A0 RID: 1696 RVA: 0x0000D54B File Offset: 0x0000B74B
		public static Expression CreatePowerExpression(Expression op1, Expression op2, ScriptLoadingContext lcontext)
		{
			return null;
		}

		// Token: 0x060006A1 RID: 1697 RVA: 0x0000D54E File Offset: 0x0000B74E
		private static void AddNode(BinaryOperatorExpression.LinkedList list, BinaryOperatorExpression.Node node)
		{
		}

		// Token: 0x060006A2 RID: 1698 RVA: 0x0000D550 File Offset: 0x0000B750
		private static Expression CreateSubTree(BinaryOperatorExpression.LinkedList list, ScriptLoadingContext lcontext)
		{
			return null;
		}

		// Token: 0x060006A3 RID: 1699 RVA: 0x0000D553 File Offset: 0x0000B753
		private static BinaryOperatorExpression.Node PrioritizeLeftAssociative(BinaryOperatorExpression.Node nodes, ScriptLoadingContext lcontext, BinaryOperatorExpression.Operator operatorsToFind)
		{
			return null;
		}

		// Token: 0x060006A4 RID: 1700 RVA: 0x0000D556 File Offset: 0x0000B756
		private static BinaryOperatorExpression.Node PrioritizeRightAssociative(BinaryOperatorExpression.Node nodes, ScriptLoadingContext lcontext, BinaryOperatorExpression.Operator operatorsToFind)
		{
			return null;
		}

		// Token: 0x060006A5 RID: 1701 RVA: 0x000102E0 File Offset: 0x0000E4E0
		private static BinaryOperatorExpression.Operator ParseBinaryOperator(Token token)
		{
			return BinaryOperatorExpression.Operator.NotAnOperator;
		}

		// Token: 0x060006A6 RID: 1702 RVA: 0x0000D559 File Offset: 0x0000B759
		private BinaryOperatorExpression(Expression exp1, Expression exp2, BinaryOperatorExpression.Operator op, ScriptLoadingContext lcontext) : base(null)
		{
		}

		// Token: 0x060006A7 RID: 1703 RVA: 0x0000D562 File Offset: 0x0000B762
		private static bool ShouldInvertBoolean(BinaryOperatorExpression.Operator op)
		{
			return false;
		}

		// Token: 0x060006A8 RID: 1704 RVA: 0x000102F8 File Offset: 0x0000E4F8
		private static OpCode OperatorToOpCode(BinaryOperatorExpression.Operator op)
		{
			return OpCode.Nop;
		}

		// Token: 0x060006A9 RID: 1705 RVA: 0x0000D565 File Offset: 0x0000B765
		public override void Compile(ByteCode bc)
		{
		}

		// Token: 0x060006AA RID: 1706 RVA: 0x0000D567 File Offset: 0x0000B767
		public override DynValue Eval(ScriptExecutionContext context)
		{
			return null;
		}

		// Token: 0x060006AB RID: 1707 RVA: 0x0000D56A File Offset: 0x0000B76A
		private double EvalArithmetic(DynValue v1, DynValue v2)
		{
			return 0.0;
		}

		// Token: 0x060006AC RID: 1708 RVA: 0x0000D575 File Offset: 0x0000B775
		private bool EvalComparison(DynValue l, DynValue r, BinaryOperatorExpression.Operator op)
		{
			return false;
		}

		// Token: 0x040002A1 RID: 673
		private const BinaryOperatorExpression.Operator POWER = BinaryOperatorExpression.Operator.Power;

		// Token: 0x040002A2 RID: 674
		private const BinaryOperatorExpression.Operator MUL_DIV_MOD = (BinaryOperatorExpression.Operator)28672;

		// Token: 0x040002A3 RID: 675
		private const BinaryOperatorExpression.Operator ADD_SUB = (BinaryOperatorExpression.Operator)1536;

		// Token: 0x040002A4 RID: 676
		private const BinaryOperatorExpression.Operator STRCAT = BinaryOperatorExpression.Operator.StrConcat;

		// Token: 0x040002A5 RID: 677
		private const BinaryOperatorExpression.Operator COMPARES = (BinaryOperatorExpression.Operator)252;

		// Token: 0x040002A6 RID: 678
		private const BinaryOperatorExpression.Operator LOGIC_AND = BinaryOperatorExpression.Operator.And;

		// Token: 0x040002A7 RID: 679
		private const BinaryOperatorExpression.Operator LOGIC_OR = BinaryOperatorExpression.Operator.Or;

		// Token: 0x040002A8 RID: 680
		private Expression m_Exp1;

		// Token: 0x040002A9 RID: 681
		private Expression m_Exp2;

		// Token: 0x040002AA RID: 682
		private BinaryOperatorExpression.Operator m_Operator;

		// Token: 0x0200018F RID: 399
		private enum Operator
		{
			// Token: 0x0400066C RID: 1644
			NotAnOperator,
			// Token: 0x0400066D RID: 1645
			Or,
			// Token: 0x0400066E RID: 1646
			And,
			// Token: 0x0400066F RID: 1647
			Less = 4,
			// Token: 0x04000670 RID: 1648
			Greater = 8,
			// Token: 0x04000671 RID: 1649
			LessOrEqual = 16,
			// Token: 0x04000672 RID: 1650
			GreaterOrEqual = 32,
			// Token: 0x04000673 RID: 1651
			NotEqual = 64,
			// Token: 0x04000674 RID: 1652
			Equal = 128,
			// Token: 0x04000675 RID: 1653
			StrConcat = 256,
			// Token: 0x04000676 RID: 1654
			Add = 512,
			// Token: 0x04000677 RID: 1655
			Sub = 1024,
			// Token: 0x04000678 RID: 1656
			Mul = 4096,
			// Token: 0x04000679 RID: 1657
			Div = 8192,
			// Token: 0x0400067A RID: 1658
			Mod = 16384,
			// Token: 0x0400067B RID: 1659
			Power = 32768
		}

		// Token: 0x02000190 RID: 400
		private class Node
		{
			// Token: 0x0400067C RID: 1660
			public Expression Expr;

			// Token: 0x0400067D RID: 1661
			public BinaryOperatorExpression.Operator Op;

			// Token: 0x0400067E RID: 1662
			public BinaryOperatorExpression.Node Prev;

			// Token: 0x0400067F RID: 1663
			public BinaryOperatorExpression.Node Next;
		}

		// Token: 0x02000191 RID: 401
		private class LinkedList
		{
			// Token: 0x04000680 RID: 1664
			public BinaryOperatorExpression.Node Nodes;

			// Token: 0x04000681 RID: 1665
			public BinaryOperatorExpression.Node Last;

			// Token: 0x04000682 RID: 1666
			public BinaryOperatorExpression.Operator OperatorMask;
		}
	}
}
