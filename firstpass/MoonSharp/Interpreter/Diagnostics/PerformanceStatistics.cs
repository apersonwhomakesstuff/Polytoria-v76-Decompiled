using System;
using MoonSharp.Interpreter.Diagnostics.PerformanceCounters;

namespace MoonSharp.Interpreter.Diagnostics
{
	// Token: 0x020000F3 RID: 243
	public class PerformanceStatistics
	{
		// Token: 0x17000192 RID: 402
		// (get) Token: 0x06000B1A RID: 2842 RVA: 0x0000E778 File Offset: 0x0000C978
		// (set) Token: 0x06000B1B RID: 2843 RVA: 0x0000E77B File Offset: 0x0000C97B
		public bool Enabled
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x06000B1C RID: 2844 RVA: 0x0000E77D File Offset: 0x0000C97D
		public PerformanceResult GetPerformanceCounterResult(PerformanceCounter pc)
		{
			return null;
		}

		// Token: 0x06000B1D RID: 2845 RVA: 0x0000E780 File Offset: 0x0000C980
		internal IDisposable StartStopwatch(PerformanceCounter pc)
		{
			return null;
		}

		// Token: 0x06000B1E RID: 2846 RVA: 0x0000E783 File Offset: 0x0000C983
		internal static IDisposable StartGlobalStopwatch(PerformanceCounter pc)
		{
			return null;
		}

		// Token: 0x06000B1F RID: 2847 RVA: 0x0000E786 File Offset: 0x0000C986
		public string GetPerformanceLog()
		{
			return null;
		}

		// Token: 0x0400045F RID: 1119
		private IPerformanceStopwatch[] m_Stopwatches;

		// Token: 0x04000460 RID: 1120
		private static IPerformanceStopwatch[] m_GlobalStopwatches;

		// Token: 0x04000461 RID: 1121
		private bool m_Enabled;
	}
}
