using System;
using MoonSharp.Interpreter.Debugging;
using MoonSharp.Interpreter.Execution;
using MoonSharp.Interpreter.Execution.VM;

namespace MoonSharp.Interpreter.Tree.Statements
{
	// Token: 0x02000065 RID: 101
	internal class BreakStatement : Statement
	{
		// Token: 0x06000655 RID: 1621 RVA: 0x0000D3A3 File Offset: 0x0000B5A3
		public BreakStatement(ScriptLoadingContext lcontext) : base(null)
		{
		}

		// Token: 0x06000656 RID: 1622 RVA: 0x0000D3AC File Offset: 0x0000B5AC
		public override void Compile(ByteCode bc)
		{
		}

		// Token: 0x04000260 RID: 608
		private SourceRef m_Ref;
	}
}
