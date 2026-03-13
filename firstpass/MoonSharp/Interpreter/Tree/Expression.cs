using System;
using System.Collections.Generic;
using MoonSharp.Interpreter.Execution;

namespace MoonSharp.Interpreter.Tree
{
	// Token: 0x0200005A RID: 90
	internal abstract class Expression : NodeBase
	{
		// Token: 0x06000605 RID: 1541 RVA: 0x0000D246 File Offset: 0x0000B446
		public Expression(ScriptLoadingContext lcontext) : base(null)
		{
		}

		// Token: 0x06000606 RID: 1542 RVA: 0x0000D24F File Offset: 0x0000B44F
		public virtual string GetFriendlyDebugName()
		{
			return null;
		}

		// Token: 0x06000607 RID: 1543
		public abstract DynValue Eval(ScriptExecutionContext context);

		// Token: 0x06000608 RID: 1544 RVA: 0x0000D252 File Offset: 0x0000B452
		public virtual SymbolRef FindDynamic(ScriptExecutionContext context)
		{
			return null;
		}

		// Token: 0x06000609 RID: 1545 RVA: 0x0000D255 File Offset: 0x0000B455
		internal static List<Expression> ExprListAfterFirstExpr(ScriptLoadingContext lcontext, Expression expr1)
		{
			return null;
		}

		// Token: 0x0600060A RID: 1546 RVA: 0x0000D258 File Offset: 0x0000B458
		internal static List<Expression> ExprList(ScriptLoadingContext lcontext)
		{
			return null;
		}

		// Token: 0x0600060B RID: 1547 RVA: 0x0000D25B File Offset: 0x0000B45B
		internal static Expression Expr(ScriptLoadingContext lcontext)
		{
			return null;
		}

		// Token: 0x0600060C RID: 1548 RVA: 0x0000D25E File Offset: 0x0000B45E
		internal static Expression SubExpr(ScriptLoadingContext lcontext, bool isPrimary)
		{
			return null;
		}

		// Token: 0x0600060D RID: 1549 RVA: 0x0000D261 File Offset: 0x0000B461
		internal static Expression SimpleExp(ScriptLoadingContext lcontext)
		{
			return null;
		}

		// Token: 0x0600060E RID: 1550 RVA: 0x0000D264 File Offset: 0x0000B464
		internal static Expression PrimaryExp(ScriptLoadingContext lcontext)
		{
			return null;
		}

		// Token: 0x0600060F RID: 1551 RVA: 0x0000D267 File Offset: 0x0000B467
		private static Expression PrefixExp(ScriptLoadingContext lcontext)
		{
			return null;
		}
	}
}
