using System;
using System.Collections.Generic;
using MoonSharp.Interpreter.Execution;
using MoonSharp.Interpreter.Execution.VM;

namespace MoonSharp.Interpreter.Tree.Expressions
{
	// Token: 0x0200007E RID: 126
	internal class TableConstructor : Expression
	{
		// Token: 0x060006D6 RID: 1750 RVA: 0x0000D63D File Offset: 0x0000B83D
		public TableConstructor(ScriptLoadingContext lcontext, bool shared) : base(null)
		{
		}

		// Token: 0x060006D7 RID: 1751 RVA: 0x0000D646 File Offset: 0x0000B846
		private void MapField(ScriptLoadingContext lcontext)
		{
		}

		// Token: 0x060006D8 RID: 1752 RVA: 0x0000D648 File Offset: 0x0000B848
		private void StructField(ScriptLoadingContext lcontext)
		{
		}

		// Token: 0x060006D9 RID: 1753 RVA: 0x0000D64A File Offset: 0x0000B84A
		private void ArrayField(ScriptLoadingContext lcontext)
		{
		}

		// Token: 0x060006DA RID: 1754 RVA: 0x0000D64C File Offset: 0x0000B84C
		public override void Compile(ByteCode bc)
		{
		}

		// Token: 0x060006DB RID: 1755 RVA: 0x0000D64E File Offset: 0x0000B84E
		public override DynValue Eval(ScriptExecutionContext context)
		{
			return null;
		}

		// Token: 0x040002C2 RID: 706
		private bool m_Shared;

		// Token: 0x040002C3 RID: 707
		private List<Expression> m_PositionalValues;

		// Token: 0x040002C4 RID: 708
		private List<KeyValuePair<Expression, Expression>> m_CtorArgs;
	}
}
