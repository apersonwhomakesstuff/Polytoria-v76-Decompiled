using System;
using System.Collections.Generic;
using MoonSharp.Interpreter.Execution;
using MoonSharp.Interpreter.Execution.VM;

namespace MoonSharp.Interpreter.Tree.Expressions
{
	// Token: 0x02000078 RID: 120
	internal class ExprListExpression : Expression
	{
		// Token: 0x060006B1 RID: 1713 RVA: 0x0000D589 File Offset: 0x0000B789
		public ExprListExpression(List<Expression> exps, ScriptLoadingContext lcontext) : base(null)
		{
		}

		// Token: 0x060006B2 RID: 1714 RVA: 0x0000D592 File Offset: 0x0000B792
		public Expression[] GetExpressions()
		{
			return null;
		}

		// Token: 0x060006B3 RID: 1715 RVA: 0x0000D595 File Offset: 0x0000B795
		public override void Compile(ByteCode bc)
		{
		}

		// Token: 0x060006B4 RID: 1716 RVA: 0x0000D597 File Offset: 0x0000B797
		public override DynValue Eval(ScriptExecutionContext context)
		{
			return null;
		}

		// Token: 0x040002AC RID: 684
		private List<Expression> expressions;
	}
}
