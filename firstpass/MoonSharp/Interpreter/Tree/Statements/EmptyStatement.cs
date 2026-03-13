using System;
using MoonSharp.Interpreter.Execution;
using MoonSharp.Interpreter.Execution.VM;

namespace MoonSharp.Interpreter.Tree.Statements
{
	// Token: 0x02000068 RID: 104
	internal class EmptyStatement : Statement
	{
		// Token: 0x0600065C RID: 1628 RVA: 0x0000D3C7 File Offset: 0x0000B5C7
		public EmptyStatement(ScriptLoadingContext lcontext) : base(null)
		{
		}

		// Token: 0x0600065D RID: 1629 RVA: 0x0000D3D0 File Offset: 0x0000B5D0
		public override void Compile(ByteCode bc)
		{
		}
	}
}
