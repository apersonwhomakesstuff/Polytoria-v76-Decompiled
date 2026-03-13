using System;

namespace RLD
{
	// Token: 0x02000164 RID: 356
	public struct TriangleEpsilon
	{
		// Token: 0x17000597 RID: 1431
		// (get) Token: 0x0600111A RID: 4378 RVA: 0x00018CA3 File Offset: 0x00016EA3
		// (set) Token: 0x0600111B RID: 4379 RVA: 0x00018CAA File Offset: 0x00016EAA
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

		// Token: 0x17000598 RID: 1432
		// (get) Token: 0x0600111C RID: 4380 RVA: 0x00018CAC File Offset: 0x00016EAC
		// (set) Token: 0x0600111D RID: 4381 RVA: 0x00018CB3 File Offset: 0x00016EB3
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

		// Token: 0x17000599 RID: 1433
		// (get) Token: 0x0600111E RID: 4382 RVA: 0x00018CB5 File Offset: 0x00016EB5
		// (set) Token: 0x0600111F RID: 4383 RVA: 0x00018CBC File Offset: 0x00016EBC
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

		// Token: 0x040005F7 RID: 1527
		private float _areaEps;

		// Token: 0x040005F8 RID: 1528
		private float _extrudeEps;

		// Token: 0x040005F9 RID: 1529
		private float _wireEps;
	}
}
