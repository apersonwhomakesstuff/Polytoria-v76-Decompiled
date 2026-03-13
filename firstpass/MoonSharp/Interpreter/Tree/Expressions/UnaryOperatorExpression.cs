using System;
using MoonSharp.Interpreter.Execution;
using MoonSharp.Interpreter.Execution.VM;

namespace MoonSharp.Interpreter.Tree.Expressions
{
	// Token: 0x0200007F RID: 127
	internal class UnaryOperatorExpression : Expression
	{
		// Token: 0x060006DC RID: 1756 RVA: 0x0000D651 File Offset: 0x0000B851
		public UnaryOperatorExpression(ScriptLoadingContext lcontext, Expression subExpression, Token unaryOpToken) : base(null)
		{
		}

		// Token: 0x060006DD RID: 1757 RVA: 0x0000D65A File Offset: 0x0000B85A
		public override void Compile(ByteCode bc)
		{
		}

		// Token: 0x060006DE RID: 1758 RVA: 0x0000D65C File Offset: 0x0000B85C
		public override DynValue Eval(ScriptExecutionContext context)
		{
			return null;
		}

		// Token: 0x040002C5 RID: 709
		private Expression m_Exp;

		// Token: 0x040002C6 RID: 710
		private string m_OpText;
	}
}
