using System;
using System.Collections.Generic;
using MoonSharp.Interpreter.Debugging;
using MoonSharp.Interpreter.Execution;
using MoonSharp.Interpreter.Execution.VM;

namespace MoonSharp.Interpreter.Tree.Statements
{
	// Token: 0x0200006E RID: 110
	internal class IfStatement : Statement
	{
		// Token: 0x06000677 RID: 1655 RVA: 0x0000D46A File Offset: 0x0000B66A
		public IfStatement(ScriptLoadingContext lcontext) : base(null)
		{
		}

		// Token: 0x06000678 RID: 1656 RVA: 0x0000D473 File Offset: 0x0000B673
		private IfStatement.IfBlock CreateIfBlock(ScriptLoadingContext lcontext)
		{
			return null;
		}

		// Token: 0x06000679 RID: 1657 RVA: 0x0000D476 File Offset: 0x0000B676
		private IfStatement.IfBlock CreateElseBlock(ScriptLoadingContext lcontext)
		{
			return null;
		}

		// Token: 0x0600067A RID: 1658 RVA: 0x0000D479 File Offset: 0x0000B679
		public override void Compile(ByteCode bc)
		{
		}

		// Token: 0x04000285 RID: 645
		private List<IfStatement.IfBlock> m_Ifs;

		// Token: 0x04000286 RID: 646
		private IfStatement.IfBlock m_Else;

		// Token: 0x04000287 RID: 647
		private SourceRef m_End;

		// Token: 0x0200018E RID: 398
		private class IfBlock
		{
			// Token: 0x04000667 RID: 1639
			public Expression Exp;

			// Token: 0x04000668 RID: 1640
			public Statement Block;

			// Token: 0x04000669 RID: 1641
			public RuntimeScopeBlock StackFrame;

			// Token: 0x0400066A RID: 1642
			public SourceRef Source;
		}
	}
}
