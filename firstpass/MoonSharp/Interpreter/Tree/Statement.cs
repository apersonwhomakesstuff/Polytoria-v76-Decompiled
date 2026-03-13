using System;
using MoonSharp.Interpreter.Execution;

namespace MoonSharp.Interpreter.Tree
{
	// Token: 0x02000063 RID: 99
	internal abstract class Statement : NodeBase
	{
		// Token: 0x0600064E RID: 1614 RVA: 0x0000D376 File Offset: 0x0000B576
		public Statement(ScriptLoadingContext lcontext) : base(null)
		{
		}

		// Token: 0x0600064F RID: 1615 RVA: 0x0000D37F File Offset: 0x0000B57F
		protected static Statement CreateStatement(ScriptLoadingContext lcontext, out bool forceLast)
		{
			forceLast = default(bool);
			return null;
		}

		// Token: 0x06000650 RID: 1616 RVA: 0x0000D389 File Offset: 0x0000B589
		private static Statement DispatchForLoopStatement(ScriptLoadingContext lcontext)
		{
			return null;
		}
	}
}
