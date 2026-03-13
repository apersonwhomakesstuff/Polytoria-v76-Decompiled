using System;
using System.Diagnostics;

namespace MoonSharp.Interpreter.Diagnostics.PerformanceCounters
{
	// Token: 0x020000F6 RID: 246
	internal class GlobalPerformanceStopwatch : IPerformanceStopwatch
	{
		// Token: 0x06000B27 RID: 2855 RVA: 0x0000E7A5 File Offset: 0x0000C9A5
		public GlobalPerformanceStopwatch(PerformanceCounter perfcounter)
		{
		}

		// Token: 0x06000B28 RID: 2856 RVA: 0x0000E7AD File Offset: 0x0000C9AD
		private void SignalStopwatchTerminated(Stopwatch sw)
		{
		}

		// Token: 0x06000B29 RID: 2857 RVA: 0x0000E7AF File Offset: 0x0000C9AF
		public IDisposable Start()
		{
			return null;
		}

		// Token: 0x06000B2A RID: 2858 RVA: 0x0000E7B2 File Offset: 0x0000C9B2
		public PerformanceResult GetResult()
		{
			return null;
		}

		// Token: 0x04000464 RID: 1124
		private int m_Count;

		// Token: 0x04000465 RID: 1125
		private long m_Elapsed;

		// Token: 0x04000466 RID: 1126
		private PerformanceCounter m_Counter;

		// Token: 0x020001CB RID: 459
		private class GlobalPerformanceStopwatch_StopwatchObject : IDisposable
		{
			// Token: 0x06001027 RID: 4135 RVA: 0x0000F6C8 File Offset: 0x0000D8C8
			public GlobalPerformanceStopwatch_StopwatchObject(GlobalPerformanceStopwatch parent)
			{
			}

			// Token: 0x06001028 RID: 4136 RVA: 0x0000F6D0 File Offset: 0x0000D8D0
			public void Dispose()
			{
			}

			// Token: 0x0400070F RID: 1807
			private Stopwatch m_Stopwatch;

			// Token: 0x04000710 RID: 1808
			private GlobalPerformanceStopwatch m_Parent;
		}
	}
}
