using System;
using MoonSharp.Interpreter.Debugging;
using MoonSharp.Interpreter.Execution;
using MoonSharp.Interpreter.Execution.VM;
using MoonSharp.Interpreter.Tree.Expressions;

namespace MoonSharp.Interpreter.Tree.Statements
{
	// Token: 0x02000069 RID: 105
	internal class ForEachLoopStatement : Statement
	{
		// Token: 0x0600065E RID: 1630 RVA: 0x0000D3D2 File Offset: 0x0000B5D2
		public ForEachLoopStatement(ScriptLoadingContext lcontext, Token firstNameToken, Token forToken) : base(null)
		{
		}

		// Token: 0x0600065F RID: 1631 RVA: 0x0000D3DB File Offset: 0x0000B5DB
		public override void Compile(ByteCode bc)
		{
		}

		// Token: 0x04000266 RID: 614
		private RuntimeScopeBlock m_StackFrame;

		// Token: 0x04000267 RID: 615
		private SymbolRef[] m_Names;

		// Token: 0x04000268 RID: 616
		private IVariable[] m_NameExps;

		// Token: 0x04000269 RID: 617
		private Expression m_RValues;

		// Token: 0x0400026A RID: 618
		private Statement m_Block;

		// Token: 0x0400026B RID: 619
		private SourceRef m_RefFor;

		// Token: 0x0400026C RID: 620
		private SourceRef m_RefEnd;

		// Token: 0x0200018C RID: 396
		private sealed class <>c__DisplayClass7_0
		{
			// Token: 0x06000F3A RID: 3898 RVA: 0x0000F40C File Offset: 0x0000D60C
			internal SymbolRef <.ctor>b__0(string n)
			{
				return null;
			}

			// Token: 0x06000F3B RID: 3899 RVA: 0x0000F40F File Offset: 0x0000D60F
			internal SymbolRefExpression <.ctor>b__1(SymbolRef s)
			{
				return null;
			}

			// Token: 0x04000664 RID: 1636
			public ScriptLoadingContext lcontext;
		}
	}
}
