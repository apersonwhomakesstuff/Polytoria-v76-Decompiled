using System;
using MoonSharp.Interpreter.Debugging;
using MoonSharp.Interpreter.Execution;
using MoonSharp.Interpreter.Execution.VM;

namespace MoonSharp.Interpreter.Tree.Statements
{
	// Token: 0x02000071 RID: 113
	internal class ReturnStatement : Statement
	{
		// Token: 0x0600068E RID: 1678 RVA: 0x0000D4FD File Offset: 0x0000B6FD
		public ReturnStatement(ScriptLoadingContext lcontext, Expression e, SourceRef sref) : base(null)
		{
		}

		// Token: 0x0600068F RID: 1679 RVA: 0x0000D506 File Offset: 0x0000B706
		public ReturnStatement(ScriptLoadingContext lcontext) : base(null)
		{
		}

		// Token: 0x06000690 RID: 1680 RVA: 0x0000D50F File Offset: 0x0000B70F
		public override void Compile(ByteCode bc)
		{
		}

		// Token: 0x04000295 RID: 661
		private Expression m_Expression;

		// Token: 0x04000296 RID: 662
		private SourceRef m_Ref;
	}
}
