using System;
using System.Diagnostics;

namespace MoonSharp.Interpreter.Diagnostics.PerformanceCounters
{
	// Token: 0x020000F8 RID: 248
	internal class PerformanceStopwatch : IDisposable, IPerformanceStopwatch
	{
		// Token: 0x06000B2D RID: 2861 RVA: 0x0000E7B5 File Offset: 0x0000C9B5
		public PerformanceStopwatch(PerformanceCounter perfcounter)
		{
		}

		// Token: 0x06000B2E RID: 2862 RVA: 0x0000E7BD File Offset: 0x0000C9BD
		public IDisposable Start()
		{
			return null;
		}

		// Token: 0x06000B2F RID: 2863 RVA: 0x0000E7C0 File Offset: 0x0000C9C0
		public void Dispose()
		{
		}

		// Token: 0x06000B30 RID: 2864 RVA: 0x0000E7C2 File Offset: 0x0000C9C2
		public PerformanceResult GetResult()
		{
			return null;
		}

		// Token: 0x04000467 RID: 1127
		private Stopwatch m_Stopwatch;

		// Token: 0x04000468 RID: 1128
		private int m_Count;

		// Token: 0x04000469 RID: 1129
		private int m_Reentrant;

		// Token: 0x0400046A RID: 1130
		private PerformanceCounter m_Counter;
	}
}
