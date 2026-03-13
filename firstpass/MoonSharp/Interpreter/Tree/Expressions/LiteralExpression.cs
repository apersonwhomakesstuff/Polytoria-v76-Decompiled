using System;
using MoonSharp.Interpreter.Execution;
using MoonSharp.Interpreter.Execution.VM;

namespace MoonSharp.Interpreter.Tree.Expressions
{
	// Token: 0x0200007C RID: 124
	internal class LiteralExpression : Expression
	{
		// Token: 0x170000E8 RID: 232
		// (get) Token: 0x060006CB RID: 1739 RVA: 0x0000D607 File Offset: 0x0000B807
		public DynValue Value
		{
			get
			{
				return null;
			}
		}

		// Token: 0x060006CC RID: 1740 RVA: 0x0000D60A File Offset: 0x0000B80A
		public LiteralExpression(ScriptLoadingContext lcontext, DynValue value) : base(null)
		{
		}

		// Token: 0x060006CD RID: 1741 RVA: 0x0000D613 File Offset: 0x0000B813
		public LiteralExpression(ScriptLoadingContext lcontext, Token t) : base(null)
		{
		}

		// Token: 0x060006CE RID: 1742 RVA: 0x0000D61C File Offset: 0x0000B81C
		public override void Compile(ByteCode bc)
		{
		}

		// Token: 0x060006CF RID: 1743 RVA: 0x0000D61E File Offset: 0x0000B81E
		public override DynValue Eval(ScriptExecutionContext context)
		{
			return null;
		}

		// Token: 0x040002BF RID: 703
		private DynValue m_Value;
	}
}
