using System;

namespace RLD
{
	// Token: 0x0200015D RID: 349
	public struct SegmentEpsilon
	{
		// Token: 0x17000584 RID: 1412
		// (get) Token: 0x060010F4 RID: 4340 RVA: 0x00018BFF File Offset: 0x00016DFF
		// (set) Token: 0x060010F5 RID: 4341 RVA: 0x00018C06 File Offset: 0x00016E06
		public float RaycastEps
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x17000585 RID: 1413
		// (get) Token: 0x060010F6 RID: 4342 RVA: 0x00018C08 File Offset: 0x00016E08
		// (set) Token: 0x060010F7 RID: 4343 RVA: 0x00018C0F File Offset: 0x00016E0F
		public float PtOnSegmentEps
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x040005E6 RID: 1510
		private float _raycastEps;

		// Token: 0x040005E7 RID: 1511
		private float _ptOnSegmentEps;
	}
}
