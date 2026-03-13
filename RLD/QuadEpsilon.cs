using System;
using UnityEngine;

namespace RLD
{
	// Token: 0x02000163 RID: 355
	public struct QuadEpsilon
	{
		// Token: 0x17000592 RID: 1426
		// (get) Token: 0x06001110 RID: 4368 RVA: 0x0002165C File Offset: 0x0001F85C
		// (set) Token: 0x06001111 RID: 4369 RVA: 0x00018C7D File Offset: 0x00016E7D
		public Vector2 SizeEps
		{
			get
			{
				return default(Vector2);
			}
			set
			{
			}
		}

		// Token: 0x17000593 RID: 1427
		// (get) Token: 0x06001112 RID: 4370 RVA: 0x00018C7F File Offset: 0x00016E7F
		// (set) Token: 0x06001113 RID: 4371 RVA: 0x00018C86 File Offset: 0x00016E86
		public float WidthEps
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x17000594 RID: 1428
		// (get) Token: 0x06001114 RID: 4372 RVA: 0x00018C88 File Offset: 0x00016E88
		// (set) Token: 0x06001115 RID: 4373 RVA: 0x00018C8F File Offset: 0x00016E8F
		public float HeightEps
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x17000595 RID: 1429
		// (get) Token: 0x06001116 RID: 4374 RVA: 0x00018C91 File Offset: 0x00016E91
		// (set) Token: 0x06001117 RID: 4375 RVA: 0x00018C98 File Offset: 0x00016E98
		public float ExtrudeEps
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x17000596 RID: 1430
		// (get) Token: 0x06001118 RID: 4376 RVA: 0x00018C9A File Offset: 0x00016E9A
		// (set) Token: 0x06001119 RID: 4377 RVA: 0x00018CA1 File Offset: 0x00016EA1
		public float WireEps
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x040005F4 RID: 1524
		private Vector2 _sizeEps;

		// Token: 0x040005F5 RID: 1525
		private float _extrudeEps;

		// Token: 0x040005F6 RID: 1526
		private float _wireEps;
	}
}
