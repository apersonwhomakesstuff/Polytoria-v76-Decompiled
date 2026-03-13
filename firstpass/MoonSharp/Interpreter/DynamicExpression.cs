using System;
using MoonSharp.Interpreter.Tree.Expressions;

namespace MoonSharp.Interpreter
{
	// Token: 0x02000044 RID: 68
	public class DynamicExpression : IScriptPrivateResource
	{
		// Token: 0x0600056C RID: 1388 RVA: 0x0000CEF1 File Offset: 0x0000B0F1
		internal DynamicExpression(Script S, string strExpr, DynamicExprExpression expr)
		{
		}

		// Token: 0x0600056D RID: 1389 RVA: 0x0000CEF9 File Offset: 0x0000B0F9
		internal DynamicExpression(Script S, string strExpr, DynValue constant)
		{
		}

		// Token: 0x0600056E RID: 1390 RVA: 0x0000CF01 File Offset: 0x0000B101
		public DynValue Evaluate(ScriptExecutionContext context = null)
		{
			return null;
		}

		// Token: 0x0600056F RID: 1391 RVA: 0x0000CF04 File Offset: 0x0000B104
		public SymbolRef FindSymbol(ScriptExecutionContext context)
		{
			return null;
		}

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x06000570 RID: 1392 RVA: 0x0000CF07 File Offset: 0x0000B107
		// (set) Token: 0x06000571 RID: 1393 RVA: 0x0000CF0F File Offset: 0x0000B10F
		public Script OwnerScript
		{
			get
			{
				return this.<OwnerScript>k__BackingField;
			}
			private set
			{
				this.<OwnerScript>k__BackingField = value;
			}
		}

		// Token: 0x06000572 RID: 1394 RVA: 0x0000CF18 File Offset: 0x0000B118
		public bool IsConstant()
		{
			return false;
		}

		// Token: 0x06000573 RID: 1395 RVA: 0x0000CF1B File Offset: 0x0000B11B
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000574 RID: 1396 RVA: 0x0000CF1E File Offset: 0x0000B11E
		public override bool Equals(object obj)
		{
			return false;
		}

		// Token: 0x040001B1 RID: 433
		private DynamicExprExpression m_Exp;

		// Token: 0x040001B2 RID: 434
		private DynValue m_Constant;

		// Token: 0x040001B3 RID: 435
		public readonly string ExpressionCode;

		// Token: 0x040001B4 RID: 436
		private Script <OwnerScript>k__BackingField;
	}
}
