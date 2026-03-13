using System;

namespace RLD
{
	// Token: 0x02000145 RID: 325
	public struct PlaneDescriptor
	{
		// Token: 0x17000570 RID: 1392
		// (get) Token: 0x06001094 RID: 4244 RVA: 0x00021400 File Offset: 0x0001F600
		public PlaneId Id
		{
			get
			{
				return PlaneId.XY;
			}
		}

		// Token: 0x17000571 RID: 1393
		// (get) Token: 0x06001095 RID: 4245 RVA: 0x00021418 File Offset: 0x0001F618
		public PlaneQuadrantId Quadrant
		{
			get
			{
				return PlaneQuadrantId.First;
			}
		}

		// Token: 0x17000572 RID: 1394
		// (get) Token: 0x06001096 RID: 4246 RVA: 0x00021430 File Offset: 0x0001F630
		public AxisSign FirstAxisSign
		{
			get
			{
				return AxisSign.Positive;
			}
		}

		// Token: 0x17000573 RID: 1395
		// (get) Token: 0x06001097 RID: 4247 RVA: 0x00021448 File Offset: 0x0001F648
		public AxisSign SecondAxisSign
		{
			get
			{
				return AxisSign.Positive;
			}
		}

		// Token: 0x17000574 RID: 1396
		// (get) Token: 0x06001098 RID: 4248 RVA: 0x00018A92 File Offset: 0x00016C92
		public int FirstAxisIndex
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x17000575 RID: 1397
		// (get) Token: 0x06001099 RID: 4249 RVA: 0x00018A95 File Offset: 0x00016C95
		public int SecondAxisIndex
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x17000576 RID: 1398
		// (get) Token: 0x0600109A RID: 4250 RVA: 0x00018A98 File Offset: 0x00016C98
		public AxisDescriptor FirstAxisDescriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000577 RID: 1399
		// (get) Token: 0x0600109B RID: 4251 RVA: 0x00018A9B File Offset: 0x00016C9B
		public AxisDescriptor SecondAxisDescriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x0600109C RID: 4252 RVA: 0x00021460 File Offset: 0x0001F660
		public PlaneDescriptor(PlaneId planeId, PlaneQuadrantId planeQuadrant)
		{
			this._id = PlaneId.XY;
			this._quadrant = PlaneQuadrantId.First;
			this._firstAxisDescriptor = null;
			this._secondAxisDescriptor = null;
		}

		// Token: 0x040005A4 RID: 1444
		private PlaneId _id;

		// Token: 0x040005A5 RID: 1445
		private PlaneQuadrantId _quadrant;

		// Token: 0x040005A6 RID: 1446
		private AxisDescriptor _firstAxisDescriptor;

		// Token: 0x040005A7 RID: 1447
		private AxisDescriptor _secondAxisDescriptor;
	}
}
