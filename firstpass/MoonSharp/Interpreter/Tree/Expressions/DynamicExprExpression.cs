using System;
using MoonSharp.Interpreter.Execution;
using MoonSharp.Interpreter.Execution.VM;

namespace MoonSharp.Interpreter.Tree.Expressions
{
	// Token: 0x02000077 RID: 119
	internal class DynamicExprExpression : Expression
	{
		// Token: 0x060006AD RID: 1709 RVA: 0x0000D578 File Offset: 0x0000B778
		public DynamicExprExpression(Expression exp, ScriptLoadingContext lcontext) : base(null)
		{
		}

		// Token: 0x060006AE RID: 1710 RVA: 0x0000D581 File Offset: 0x0000B781
		public override DynValue Eval(ScriptExecutionContext context)
		{
			return null;
		}

		// Token: 0x060006AF RID: 1711 RVA: 0x0000D584 File Offset: 0x0000B784
		public override void Compile(ByteCode bc)
		{
		}

		// Token: 0x060006B0 RID: 1712 RVA: 0x0000D586 File Offset: 0x0000B786
		public override SymbolRef FindDynamic(ScriptExecutionContext context)
		{
			return null;
		}

		// Token: 0x040002AB RID: 683
		private Expression m_Exp;
	}
}
