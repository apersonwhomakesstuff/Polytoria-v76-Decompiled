using System;
using System.Collections.Generic;
using MoonSharp.Interpreter.Execution;
using MoonSharp.Interpreter.Execution.VM;

namespace MoonSharp.Interpreter.Tree.Statements
{
	// Token: 0x02000067 RID: 103
	internal class CompositeStatement : Statement
	{
		// Token: 0x0600065A RID: 1626 RVA: 0x0000D3BC File Offset: 0x0000B5BC
		public CompositeStatement(ScriptLoadingContext lcontext) : base(null)
		{
		}

		// Token: 0x0600065B RID: 1627 RVA: 0x0000D3C5 File Offset: 0x0000B5C5
		public override void Compile(ByteCode bc)
		{
		}

		// Token: 0x04000265 RID: 613
		private List<Statement> m_Statements;
	}
}
