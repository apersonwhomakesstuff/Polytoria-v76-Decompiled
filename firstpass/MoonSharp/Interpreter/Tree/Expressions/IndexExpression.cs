using System;
using MoonSharp.Interpreter.Execution;
using MoonSharp.Interpreter.Execution.VM;

namespace MoonSharp.Interpreter.Tree.Expressions
{
	// Token: 0x0200007B RID: 123
	internal class IndexExpression : Expression, IVariable
	{
		// Token: 0x060006C6 RID: 1734 RVA: 0x0000D5EE File Offset: 0x0000B7EE
		public IndexExpression(Expression baseExp, Expression indexExp, ScriptLoadingContext lcontext) : base(null)
		{
		}

		// Token: 0x060006C7 RID: 1735 RVA: 0x0000D5F7 File Offset: 0x0000B7F7
		public IndexExpression(Expression baseExp, string name, ScriptLoadingContext lcontext) : base(null)
		{
		}

		// Token: 0x060006C8 RID: 1736 RVA: 0x0000D600 File Offset: 0x0000B800
		public override void Compile(ByteCode bc)
		{
		}

		// Token: 0x060006C9 RID: 1737 RVA: 0x0000D602 File Offset: 0x0000B802
		public void CompileAssignment(ByteCode bc, int stackofs, int tupleidx)
		{
		}

		// Token: 0x060006CA RID: 1738 RVA: 0x0000D604 File Offset: 0x0000B804
		public override DynValue Eval(ScriptExecutionContext context)
		{
			return null;
		}

		// Token: 0x040002BC RID: 700
		private Expression m_BaseExp;

		// Token: 0x040002BD RID: 701
		private Expression m_IndexExp;

		// Token: 0x040002BE RID: 702
		private string m_Name;
	}
}
