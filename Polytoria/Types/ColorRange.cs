using System;
using UnityEngine;

namespace Polytoria.Types
{
	// Token: 0x02000259 RID: 601
	public struct ColorRange
	{
		// Token: 0x06001A00 RID: 6656 RVA: 0x00023C3C File Offset: 0x00021E3C
		public ColorRange(Color min, Color max)
		{
			this.min = default(Color);
			this.max = default(Color);
		}

		// Token: 0x06001A01 RID: 6657 RVA: 0x00023C68 File Offset: 0x00021E68
		public Color Lerp(float t)
		{
			return default(Color);
		}

		// Token: 0x06001A02 RID: 6658 RVA: 0x00023C80 File Offset: 0x00021E80
		public static ColorRange New(Color min, Color max)
		{
			return default(ColorRange);
		}

		// Token: 0x04000993 RID: 2451
		public Color min;

		// Token: 0x04000994 RID: 2452
		public Color max;
	}
}
