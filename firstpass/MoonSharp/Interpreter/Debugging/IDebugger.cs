using System;
using System.Collections.Generic;

namespace MoonSharp.Interpreter.Debugging
{
	// Token: 0x020000FC RID: 252
	public interface IDebugger
	{
		// Token: 0x06000B44 RID: 2884
		DebuggerCaps GetDebuggerCaps();

		// Token: 0x06000B45 RID: 2885
		void SetDebugService(DebugService debugService);

		// Token: 0x06000B46 RID: 2886
		void SetSourceCode(SourceCode sourceCode);

		// Token: 0x06000B47 RID: 2887
		void SetByteCode(string[] byteCode);

		// Token: 0x06000B48 RID: 2888
		bool IsPauseRequested();

		// Token: 0x06000B49 RID: 2889
		bool SignalRuntimeException(ScriptRuntimeException ex);

		// Token: 0x06000B4A RID: 2890
		DebuggerAction GetAction(int ip, SourceRef sourceref);

		// Token: 0x06000B4B RID: 2891
		void SignalExecutionEnded();

		// Token: 0x06000B4C RID: 2892
		void Update(WatchType watchType, IEnumerable<WatchItem> items);

		// Token: 0x06000B4D RID: 2893
		List<DynamicExpression> GetWatchItems();

		// Token: 0x06000B4E RID: 2894
		void RefreshBreakpoints(IEnumerable<SourceRef> refs);
	}
}
