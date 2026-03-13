using System;

namespace MoonSharp.Interpreter.CoreLib
{
	// Token: 0x0200010C RID: 268
	public class DynamicModule
	{
		// Token: 0x06000C05 RID: 3077 RVA: 0x0000EB74 File Offset: 0x0000CD74
		public static void MoonSharpInit(Table globalTable, Table stringTable)
		{
		}

		// Token: 0x06000C06 RID: 3078 RVA: 0x0000EB76 File Offset: 0x0000CD76
		public static DynValue eval(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		// Token: 0x06000C07 RID: 3079 RVA: 0x0000EB79 File Offset: 0x0000CD79
		public static DynValue prepare(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		// Token: 0x020001D0 RID: 464
		private class DynamicExprWrapper
		{
			// Token: 0x0400072D RID: 1837
			public DynamicExpression Expr;
		}
	}
}
