using System;

namespace RLD
{
	// Token: 0x02000162 RID: 354
	public struct PolygonEpsilon
	{
		// Token: 0x1700058E RID: 1422
		// (get) Token: 0x06001108 RID: 4360 RVA: 0x00018C59 File Offset: 0x00016E59
		// (set) Token: 0x06001109 RID: 4361 RVA: 0x00018C60 File Offset: 0x00016E60
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

		// Token: 0x1700058F RID: 1423
		// (get) Token: 0x0600110A RID: 4362 RVA: 0x00018C62 File Offset: 0x00016E62
		// (set) Token: 0x0600110B RID: 4363 RVA: 0x00018C69 File Offset: 0x00016E69
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

		// Token: 0x17000590 RID: 1424
		// (get) Token: 0x0600110C RID: 4364 RVA: 0x00018C6B File Offset: 0x00016E6B
		// (set) Token: 0x0600110D RID: 4365 RVA: 0x00018C72 File Offset: 0x00016E72
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

		// Token: 0x17000591 RID: 1425
		// (get) Token: 0x0600110E RID: 4366 RVA: 0x00018C74 File Offset: 0x00016E74
		// (set) Token: 0x0600110F RID: 4367 RVA: 0x00018C7B File Offset: 0x00016E7B
		public float ThickWireEps
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x040005F0 RID: 1520
		private float _areaEps;

		// Token: 0x040005F1 RID: 1521
		private float _extrudeEps;

		// Token: 0x040005F2 RID: 1522
		private float _wireEps;

		// Token: 0x040005F3 RID: 1523
		private float _thickWireEps;
	}
}
