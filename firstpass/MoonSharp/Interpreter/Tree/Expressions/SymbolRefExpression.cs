using System;
using MoonSharp.Interpreter.Execution;
using MoonSharp.Interpreter.Execution.VM;

namespace MoonSharp.Interpreter.Tree.Expressions
{
	// Token: 0x0200007D RID: 125
	internal class SymbolRefExpression : Expression, IVariable
	{
		// Token: 0x060006D0 RID: 1744 RVA: 0x0000D621 File Offset: 0x0000B821
		public SymbolRefExpression(Token T, ScriptLoadingContext lcontext) : base(null)
		{
		}

		// Token: 0x060006D1 RID: 1745 RVA: 0x0000D62A File Offset: 0x0000B82A
		public SymbolRefExpression(ScriptLoadingContext lcontext, SymbolRef refr) : base(null)
		{
		}

		// Token: 0x060006D2 RID: 1746 RVA: 0x0000D633 File Offset: 0x0000B833
		public override void Compile(ByteCode bc)
		{
		}

		// Token: 0x060006D3 RID: 1747 RVA: 0x0000D635 File Offset: 0x0000B835
		public void CompileAssignment(ByteCode bc, int stackofs, int tupleidx)
		{
		}

		// Token: 0x060006D4 RID: 1748 RVA: 0x0000D637 File Offset: 0x0000B837
		public override DynValue Eval(ScriptExecutionContext context)
		{
			return null;
		}

		// Token: 0x060006D5 RID: 1749 RVA: 0x0000D63A File Offset: 0x0000B83A
		public override SymbolRef FindDynamic(ScriptExecutionContext context)
		{
			return null;
		}

		// Token: 0x040002C0 RID: 704
		private SymbolRef m_Ref;

		// Token: 0x040002C1 RID: 705
		private string m_VarName;
	}
}
