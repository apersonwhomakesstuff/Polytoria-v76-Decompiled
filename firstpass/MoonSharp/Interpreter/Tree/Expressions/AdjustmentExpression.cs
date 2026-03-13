using System;
using MoonSharp.Interpreter.Execution;
using MoonSharp.Interpreter.Execution.VM;

namespace MoonSharp.Interpreter.Tree.Expressions
{
	// Token: 0x02000075 RID: 117
	internal class AdjustmentExpression : Expression
	{
		// Token: 0x06000699 RID: 1689 RVA: 0x0000D533 File Offset: 0x0000B733
		public AdjustmentExpression(ScriptLoadingContext lcontext, Expression exp) : base(null)
		{
		}

		// Token: 0x0600069A RID: 1690 RVA: 0x0000D53C File Offset: 0x0000B73C
		public override void Compile(ByteCode bc)
		{
		}

		// Token: 0x0600069B RID: 1691 RVA: 0x0000D53E File Offset: 0x0000B73E
		public override DynValue Eval(ScriptExecutionContext context)
		{
			return null;
		}

		// Token: 0x040002A0 RID: 672
		private Expression expression;
	}
}
