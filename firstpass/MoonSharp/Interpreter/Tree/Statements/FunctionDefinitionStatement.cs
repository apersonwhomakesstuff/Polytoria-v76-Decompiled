using System;
using System.Collections.Generic;
using MoonSharp.Interpreter.Debugging;
using MoonSharp.Interpreter.Execution;
using MoonSharp.Interpreter.Execution.VM;
using MoonSharp.Interpreter.Tree.Expressions;

namespace MoonSharp.Interpreter.Tree.Statements
{
	// Token: 0x0200006C RID: 108
	internal class FunctionDefinitionStatement : Statement
	{
		// Token: 0x06000665 RID: 1637 RVA: 0x0000D3F5 File Offset: 0x0000B5F5
		public FunctionDefinitionStatement(ScriptLoadingContext lcontext, bool local, Token localToken) : base(null)
		{
		}

		// Token: 0x06000666 RID: 1638 RVA: 0x0000D3FE File Offset: 0x0000B5FE
		public override void Compile(ByteCode bc)
		{
		}

		// Token: 0x06000667 RID: 1639 RVA: 0x0000D400 File Offset: 0x0000B600
		private int SetMethod(ByteCode bc)
		{
			return 0;
		}

		// Token: 0x06000668 RID: 1640 RVA: 0x0000D403 File Offset: 0x0000B603
		private int SetFunction(ByteCode bc, int numPop)
		{
			return 0;
		}

		// Token: 0x04000276 RID: 630
		private SymbolRef m_FuncSymbol;

		// Token: 0x04000277 RID: 631
		private SourceRef m_SourceRef;

		// Token: 0x04000278 RID: 632
		private bool m_Local;

		// Token: 0x04000279 RID: 633
		private bool m_IsMethodCallingConvention;

		// Token: 0x0400027A RID: 634
		private string m_MethodName;

		// Token: 0x0400027B RID: 635
		private string m_FriendlyName;

		// Token: 0x0400027C RID: 636
		private List<string> m_TableAccessors;

		// Token: 0x0400027D RID: 637
		private FunctionDefinitionExpression m_FuncDef;

		// Token: 0x0200018D RID: 397
		private sealed class <>c__DisplayClass9_0
		{
			// Token: 0x06000F3D RID: 3901 RVA: 0x0000F41A File Offset: 0x0000D61A
			internal int <Compile>b__0()
			{
				return 0;
			}

			// Token: 0x06000F3E RID: 3902 RVA: 0x0000F41D File Offset: 0x0000D61D
			internal int <Compile>b__1()
			{
				return 0;
			}

			// Token: 0x06000F3F RID: 3903 RVA: 0x0000F420 File Offset: 0x0000D620
			internal int <Compile>b__2()
			{
				return 0;
			}

			// Token: 0x04000665 RID: 1637
			public FunctionDefinitionStatement <>4__this;

			// Token: 0x04000666 RID: 1638
			public ByteCode bc;
		}
	}
}
