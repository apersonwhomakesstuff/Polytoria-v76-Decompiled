using System;
using MoonSharp.Interpreter.Execution;
using MoonSharp.Interpreter.Execution.VM;
using MoonSharp.Interpreter.Tree.Expressions;

namespace MoonSharp.Interpreter.Tree.Statements
{
	// Token: 0x0200006B RID: 107
	internal class FunctionCallStatement : Statement
	{
		// Token: 0x06000662 RID: 1634 RVA: 0x0000D3E8 File Offset: 0x0000B5E8
		public FunctionCallStatement(ScriptLoadingContext lcontext, FunctionCallExpression functionCallExpression) : base(null)
		{
		}

		// Token: 0x06000663 RID: 1635 RVA: 0x0000D3F1 File Offset: 0x0000B5F1
		public override void Compile(ByteCode bc)
		{
		}

		// Token: 0x06000664 RID: 1636 RVA: 0x0000D3F3 File Offset: 0x0000B5F3
		private void RemoveBreakpointStop(Instruction instruction)
		{
		}

		// Token: 0x04000275 RID: 629
		private FunctionCallExpression m_FunctionCallExpression;
	}
}
