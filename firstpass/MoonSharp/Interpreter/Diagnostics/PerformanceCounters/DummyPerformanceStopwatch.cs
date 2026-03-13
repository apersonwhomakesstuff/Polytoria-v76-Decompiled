using System;

namespace MoonSharp.Interpreter.Diagnostics.PerformanceCounters
{
	// Token: 0x020000F5 RID: 245
	internal class DummyPerformanceStopwatch : IPerformanceStopwatch, IDisposable
	{
		// Token: 0x06000B22 RID: 2850 RVA: 0x0000E793 File Offset: 0x0000C993
		private DummyPerformanceStopwatch()
		{
		}

		// Token: 0x06000B23 RID: 2851 RVA: 0x0000E79B File Offset: 0x0000C99B
		public IDisposable Start()
		{
			return null;
		}

		// Token: 0x06000B24 RID: 2852 RVA: 0x0000E79E File Offset: 0x0000C99E
		public PerformanceResult GetResult()
		{
			return null;
		}

		// Token: 0x06000B25 RID: 2853 RVA: 0x0000E7A1 File Offset: 0x0000C9A1
		public void Dispose()
		{
		}

		// Token: 0x04000462 RID: 1122
		public static DummyPerformanceStopwatch Instance;

		// Token: 0x04000463 RID: 1123
		private PerformanceResult m_Result;
	}
}
