using System;

namespace RLD
{
	// Token: 0x020000A0 RID: 160
	[Serializable]
	public class GizmoLineSlider3DSettings
	{
		// Token: 0x17000266 RID: 614
		// (get) Token: 0x06000755 RID: 1877 RVA: 0x00017073 File Offset: 0x00015273
		// (set) Token: 0x06000756 RID: 1878 RVA: 0x0001707A File Offset: 0x0001527A
		public float LineHoverEps
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x17000267 RID: 615
		// (get) Token: 0x06000757 RID: 1879 RVA: 0x0001707C File Offset: 0x0001527C
		// (set) Token: 0x06000758 RID: 1880 RVA: 0x00017083 File Offset: 0x00015283
		public float BoxHoverEps
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x17000268 RID: 616
		// (get) Token: 0x06000759 RID: 1881 RVA: 0x00017085 File Offset: 0x00015285
		// (set) Token: 0x0600075A RID: 1882 RVA: 0x0001708C File Offset: 0x0001528C
		public float CylinderHoverEps
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x17000269 RID: 617
		// (get) Token: 0x0600075B RID: 1883 RVA: 0x0001708E File Offset: 0x0001528E
		// (set) Token: 0x0600075C RID: 1884 RVA: 0x00017095 File Offset: 0x00015295
		public float OffsetSnapStep
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x1700026A RID: 618
		// (get) Token: 0x0600075D RID: 1885 RVA: 0x00017097 File Offset: 0x00015297
		// (set) Token: 0x0600075E RID: 1886 RVA: 0x0001709E File Offset: 0x0001529E
		public float RotationSnapStep
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x1700026B RID: 619
		// (get) Token: 0x0600075F RID: 1887 RVA: 0x0001F1F4 File Offset: 0x0001D3F4
		// (set) Token: 0x06000760 RID: 1888 RVA: 0x000170A0 File Offset: 0x000152A0
		public GizmoSnapMode RotationSnapMode
		{
			get
			{
				return GizmoSnapMode.Relative;
			}
			set
			{
			}
		}

		// Token: 0x1700026C RID: 620
		// (get) Token: 0x06000761 RID: 1889 RVA: 0x000170A2 File Offset: 0x000152A2
		// (set) Token: 0x06000762 RID: 1890 RVA: 0x000170A9 File Offset: 0x000152A9
		public float ScaleSnapStep
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x1700026D RID: 621
		// (get) Token: 0x06000763 RID: 1891 RVA: 0x000170AB File Offset: 0x000152AB
		// (set) Token: 0x06000764 RID: 1892 RVA: 0x000170B2 File Offset: 0x000152B2
		public float OffsetSensitivity
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x1700026E RID: 622
		// (get) Token: 0x06000765 RID: 1893 RVA: 0x000170B4 File Offset: 0x000152B4
		// (set) Token: 0x06000766 RID: 1894 RVA: 0x000170BB File Offset: 0x000152BB
		public float RotationSensitivity
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x1700026F RID: 623
		// (get) Token: 0x06000767 RID: 1895 RVA: 0x000170BD File Offset: 0x000152BD
		// (set) Token: 0x06000768 RID: 1896 RVA: 0x000170C4 File Offset: 0x000152C4
		public float ScaleSensitivity
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x040002A1 RID: 673
		private float _lineHoverEps;

		// Token: 0x040002A2 RID: 674
		private float _boxHoverEps;

		// Token: 0x040002A3 RID: 675
		private float _cylinderHoverEps;

		// Token: 0x040002A4 RID: 676
		private float _offsetSnapStep;

		// Token: 0x040002A5 RID: 677
		private float _rotationSnapStep;

		// Token: 0x040002A6 RID: 678
		private GizmoSnapMode _rotationSnapMode;

		// Token: 0x040002A7 RID: 679
		private float _scaleSnapStep;

		// Token: 0x040002A8 RID: 680
		private float _offsetSensitivity;

		// Token: 0x040002A9 RID: 681
		private float _rotationSensitivity;

		// Token: 0x040002AA RID: 682
		private float _scaleSensitivity;
	}
}
