using System;

namespace MoonSharp.Interpreter.Diagnostics.PerformanceCounters
{
	// Token: 0x020000F7 RID: 247
	internal interface IPerformanceStopwatch
	{
		// Token: 0x06000B2B RID: 2859
		IDisposable Start();

		// Token: 0x06000B2C RID: 2860
		PerformanceResult GetResult();
	}
}
