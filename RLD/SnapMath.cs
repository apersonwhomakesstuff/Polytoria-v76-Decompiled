using System;

namespace RLD
{
	// Token: 0x02000178 RID: 376
	public static class SnapMath
	{
		// Token: 0x06001165 RID: 4453 RVA: 0x0002171C File Offset: 0x0001F91C
		public static NumSnapSteps CalculateNumSnapSteps(float snapStep, float total)
		{
			return default(NumSnapSteps);
		}

		// Token: 0x06001166 RID: 4454 RVA: 0x00018E0A File Offset: 0x0001700A
		public static bool CanExtractSnap(float snapStep, float accumulated)
		{
			return false;
		}

		// Token: 0x06001167 RID: 4455 RVA: 0x00018E0D File Offset: 0x0001700D
		public static float ExtractSnap(float snapStep, ref float accumulated)
		{
			return 0f;
		}

		// Token: 0x06001168 RID: 4456 RVA: 0x00018E14 File Offset: 0x00017014
		public static float ExtractSnap(float snapStep, float accumulated)
		{
			return 0f;
		}
	}
}
