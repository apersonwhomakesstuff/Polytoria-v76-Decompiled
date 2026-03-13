using System;

namespace Polytoria.Types
{
	// Token: 0x0200025D RID: 605
	public struct NumberRange
	{
		// Token: 0x06001A06 RID: 6662 RVA: 0x0001A415 File Offset: 0x00018615
		public NumberRange(float min, float max)
		{
			this.min = 0f;
			this.max = 0f;
		}

		// Token: 0x06001A07 RID: 6663 RVA: 0x0001A42D File Offset: 0x0001862D
		public float Lerp(float t)
		{
			return 0f;
		}

		// Token: 0x06001A08 RID: 6664 RVA: 0x00023C98 File Offset: 0x00021E98
		public static NumberRange New(float min, float max)
		{
			return default(NumberRange);
		}

		// Token: 0x0400099A RID: 2458
		public float min;

		// Token: 0x0400099B RID: 2459
		public float max;
	}
}
