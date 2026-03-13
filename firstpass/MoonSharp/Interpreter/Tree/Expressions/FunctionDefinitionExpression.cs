using System;
using System.Collections.Generic;
using MoonSharp.Interpreter.Debugging;
using MoonSharp.Interpreter.Execution;
using MoonSharp.Interpreter.Execution.VM;

namespace MoonSharp.Interpreter.Tree.Expressions
{
	// Token: 0x0200007A RID: 122
	internal class FunctionDefinitionExpression : Expression, IClosureBuilder
	{
		// Token: 0x060006BA RID: 1722 RVA: 0x0000D5B9 File Offset: 0x0000B7B9
		public FunctionDefinitionExpression(ScriptLoadingContext lcontext, bool usesGlobalEnv) : base(null)
		{
		}

		// Token: 0x060006BB RID: 1723 RVA: 0x0000D5C2 File Offset: 0x0000B7C2
		public FunctionDefinitionExpression(ScriptLoadingContext lcontext, bool pushSelfParam, bool isLambda) : base(null)
		{
		}

		// Token: 0x060006BC RID: 1724 RVA: 0x0000D5CB File Offset: 0x0000B7CB
		private FunctionDefinitionExpression(ScriptLoadingContext lcontext, bool pushSelfParam, bool usesGlobalEnv, bool isLambda) : base(null)
		{
		}

		// Token: 0x060006BD RID: 1725 RVA: 0x0000D5D4 File Offset: 0x0000B7D4
		private Statement CreateLambdaBody(ScriptLoadingContext lcontext)
		{
			return null;
		}

		// Token: 0x060006BE RID: 1726 RVA: 0x0000D5D7 File Offset: 0x0000B7D7
		private Statement CreateBody(ScriptLoadingContext lcontext)
		{
			return null;
		}

		// Token: 0x060006BF RID: 1727 RVA: 0x0000D5DA File Offset: 0x0000B7DA
		private List<string> BuildParamList(ScriptLoadingContext lcontext, bool pushSelfParam, Token openBracketToken, bool isLambda)
		{
			return null;
		}

		// Token: 0x060006C0 RID: 1728 RVA: 0x0000D5DD File Offset: 0x0000B7DD
		private SymbolRef[] DefineArguments(List<string> paramnames, ScriptLoadingContext lcontext)
		{
			return null;
		}

		// Token: 0x060006C1 RID: 1729 RVA: 0x0000D5E0 File Offset: 0x0000B7E0
		public SymbolRef CreateUpvalue(BuildTimeScope scope, SymbolRef symbol)
		{
			return null;
		}

		// Token: 0x060006C2 RID: 1730 RVA: 0x0000D5E3 File Offset: 0x0000B7E3
		public override DynValue Eval(ScriptExecutionContext context)
		{
			return null;
		}

		// Token: 0x060006C3 RID: 1731 RVA: 0x0000D5E6 File Offset: 0x0000B7E6
		public int CompileBody(ByteCode bc, string friendlyName)
		{
			return 0;
		}

		// Token: 0x060006C4 RID: 1732 RVA: 0x0000D5E9 File Offset: 0x0000B7E9
		public int Compile(ByteCode bc, Func<int> afterDecl, string friendlyName)
		{
			return 0;
		}

		// Token: 0x060006C5 RID: 1733 RVA: 0x0000D5EC File Offset: 0x0000B7EC
		public override void Compile(ByteCode bc)
		{
		}

		// Token: 0x040002B2 RID: 690
		private SymbolRef[] m_ParamNames;

		// Token: 0x040002B3 RID: 691
		private Statement m_Statement;

		// Token: 0x040002B4 RID: 692
		private RuntimeScopeFrame m_StackFrame;

		// Token: 0x040002B5 RID: 693
		private List<SymbolRef> m_Closure;

		// Token: 0x040002B6 RID: 694
		private bool m_HasVarArgs;

		// Token: 0x040002B7 RID: 695
		private Instruction m_ClosureInstruction;

		// Token: 0x040002B8 RID: 696
		private bool m_UsesGlobalEnv;

		// Token: 0x040002B9 RID: 697
		private SymbolRef m_Env;

		// Token: 0x040002BA RID: 698
		private SourceRef m_Begin;

		// Token: 0x040002BB RID: 699
		private SourceRef m_End;

		// Token: 0x02000192 RID: 402
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06000F45 RID: 3909 RVA: 0x0000F445 File Offset: 0x0000D645
			internal int <Compile>b__21_0()
			{
				return 0;
			}

			// Token: 0x04000683 RID: 1667
			public static readonly FunctionDefinitionExpression.<>c <>9;

			// Token: 0x04000684 RID: 1668
			public static Func<int> <>9__21_0;
		}
	}
}
