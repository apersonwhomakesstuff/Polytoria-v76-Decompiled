using System;

namespace RLD
{
	// Token: 0x02000160 RID: 352
	public struct ArcEpsilon
	{
		// Token: 0x17000588 RID: 1416
		// (get) Token: 0x060010FC RID: 4348 RVA: 0x00018C23 File Offset: 0x00016E23
		// (set) Token: 0x060010FD RID: 4349 RVA: 0x00018C2A File Offset: 0x00016E2A
		public float AreaEps
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x17000589 RID: 1417
		// (get) Token: 0x060010FE RID: 4350 RVA: 0x00018C2C File Offset: 0x00016E2C
		// (set) Token: 0x060010FF RID: 4351 RVA: 0x00018C33 File Offset: 0x00016E33
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

		// Token: 0x1700058A RID: 1418
		// (get) Token: 0x06001100 RID: 4352 RVA: 0x00018C35 File Offset: 0x00016E35
		// (set) Token: 0x06001101 RID: 4353 RVA: 0x00018C3C File Offset: 0x00016E3C
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

		// Token: 0x040005EA RID: 1514
		private float _areaEps;

		// Token: 0x040005EB RID: 1515
		private float _extrudeEps;

		// Token: 0x040005EC RID: 1516
		private float _wireEps;
	}
}
