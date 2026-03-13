using System;

namespace RLD
{
	// Token: 0x02000083 RID: 131
	[Serializable]
	public class BoxGizmoSettings3D : Settings
	{
		// Token: 0x170001CF RID: 463
		// (get) Token: 0x060005B3 RID: 1459 RVA: 0x00016B97 File Offset: 0x00014D97
		public float XSnapStep
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x170001D0 RID: 464
		// (get) Token: 0x060005B4 RID: 1460 RVA: 0x00016B9E File Offset: 0x00014D9E
		public float YSnapStep
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x170001D1 RID: 465
		// (get) Token: 0x060005B5 RID: 1461 RVA: 0x00016BA5 File Offset: 0x00014DA5
		public float ZSnapStep
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x170001D2 RID: 466
		// (get) Token: 0x060005B6 RID: 1462 RVA: 0x00016BAC File Offset: 0x00014DAC
		public float DragSensitivity
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x060005B7 RID: 1463 RVA: 0x00016BB3 File Offset: 0x00014DB3
		public void SetXSnapStep(float snapStep)
		{
		}

		// Token: 0x060005B8 RID: 1464 RVA: 0x00016BB5 File Offset: 0x00014DB5
		public void SetYSnapStep(float snapStep)
		{
		}

		// Token: 0x060005B9 RID: 1465 RVA: 0x00016BB7 File Offset: 0x00014DB7
		public void SetZSnapStep(float snapStep)
		{
		}

		// Token: 0x060005BA RID: 1466 RVA: 0x00016BB9 File Offset: 0x00014DB9
		public void SetDragSensitivity(float sensitivity)
		{
		}

		// Token: 0x040001E3 RID: 483
		private float _xSnapStep;

		// Token: 0x040001E4 RID: 484
		private float _ySnapStep;

		// Token: 0x040001E5 RID: 485
		private float _zSnapStep;

		// Token: 0x040001E6 RID: 486
		private float _dragSensitivity;
	}
}
