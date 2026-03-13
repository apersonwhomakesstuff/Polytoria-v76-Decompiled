using System;
using MoonSharp.Interpreter.Execution;
using MoonSharp.Interpreter.Execution.VM;

namespace MoonSharp.Interpreter.Tree.Statements
{
	// Token: 0x02000066 RID: 102
	internal class ChunkStatement : Statement, IClosureBuilder
	{
		// Token: 0x06000657 RID: 1623 RVA: 0x0000D3AE File Offset: 0x0000B5AE
		public ChunkStatement(ScriptLoadingContext lcontext) : base(null)
		{
		}

		// Token: 0x06000658 RID: 1624 RVA: 0x0000D3B7 File Offset: 0x0000B5B7
		public override void Compile(ByteCode bc)
		{
		}

		// Token: 0x06000659 RID: 1625 RVA: 0x0000D3B9 File Offset: 0x0000B5B9
		public SymbolRef CreateUpvalue(BuildTimeScope scope, SymbolRef symbol)
		{
			return null;
		}

		// Token: 0x04000261 RID: 609
		private Statement m_Block;

		// Token: 0x04000262 RID: 610
		private RuntimeScopeFrame m_StackFrame;

		// Token: 0x04000263 RID: 611
		private SymbolRef m_Env;

		// Token: 0x04000264 RID: 612
		private SymbolRef m_VarArgs;
	}
}
