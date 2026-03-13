using System;

namespace RLD
{
	// Token: 0x02000093 RID: 147
	[Serializable]
	public class GizmoPlaneSlider2DSettings
	{
		// Token: 0x17000231 RID: 561
		// (get) Token: 0x060006A9 RID: 1705 RVA: 0x00016E5B File Offset: 0x0001505B
		// (set) Token: 0x060006AA RID: 1706 RVA: 0x00016E62 File Offset: 0x00015062
		public float AreaHoverEps
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x17000232 RID: 562
		// (get) Token: 0x060006AB RID: 1707 RVA: 0x00016E64 File Offset: 0x00015064
		// (set) Token: 0x060006AC RID: 1708 RVA: 0x00016E6B File Offset: 0x0001506B
		public float BorderLineHoverEps
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x17000233 RID: 563
		// (get) Token: 0x060006AD RID: 1709 RVA: 0x00016E6D File Offset: 0x0001506D
		// (set) Token: 0x060006AE RID: 1710 RVA: 0x00016E74 File Offset: 0x00015074
		public float ThickBorderPolyHoverEps
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x17000234 RID: 564
		// (get) Token: 0x060006AF RID: 1711 RVA: 0x00016E76 File Offset: 0x00015076
		// (set) Token: 0x060006B0 RID: 1712 RVA: 0x00016E7D File Offset: 0x0001507D
		public float OffsetSnapStepRight
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x17000235 RID: 565
		// (get) Token: 0x060006B1 RID: 1713 RVA: 0x00016E7F File Offset: 0x0001507F
		// (set) Token: 0x060006B2 RID: 1714 RVA: 0x00016E86 File Offset: 0x00015086
		public float OffsetSnapStepUp
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x17000236 RID: 566
		// (get) Token: 0x060006B3 RID: 1715 RVA: 0x00016E88 File Offset: 0x00015088
		// (set) Token: 0x060006B4 RID: 1716 RVA: 0x00016E8F File Offset: 0x0001508F
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

		// Token: 0x17000237 RID: 567
		// (get) Token: 0x060006B5 RID: 1717 RVA: 0x0001F05C File Offset: 0x0001D25C
		// (set) Token: 0x060006B6 RID: 1718 RVA: 0x00016E91 File Offset: 0x00015091
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

		// Token: 0x17000238 RID: 568
		// (get) Token: 0x060006B7 RID: 1719 RVA: 0x00016E93 File Offset: 0x00015093
		// (set) Token: 0x060006B8 RID: 1720 RVA: 0x00016E9A File Offset: 0x0001509A
		public float ScaleSnapStepRight
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x17000239 RID: 569
		// (get) Token: 0x060006B9 RID: 1721 RVA: 0x00016E9C File Offset: 0x0001509C
		// (set) Token: 0x060006BA RID: 1722 RVA: 0x00016EA3 File Offset: 0x000150A3
		public float ScaleSnapStepUp
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x1700023A RID: 570
		// (get) Token: 0x060006BB RID: 1723 RVA: 0x00016EA5 File Offset: 0x000150A5
		// (set) Token: 0x060006BC RID: 1724 RVA: 0x00016EAC File Offset: 0x000150AC
		public float ProportionalScaleSnapStep
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x1700023B RID: 571
		// (get) Token: 0x060006BD RID: 1725 RVA: 0x00016EAE File Offset: 0x000150AE
		// (set) Token: 0x060006BE RID: 1726 RVA: 0x00016EB5 File Offset: 0x000150B5
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

		// Token: 0x1700023C RID: 572
		// (get) Token: 0x060006BF RID: 1727 RVA: 0x00016EB7 File Offset: 0x000150B7
		// (set) Token: 0x060006C0 RID: 1728 RVA: 0x00016EBE File Offset: 0x000150BE
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

		// Token: 0x1700023D RID: 573
		// (get) Token: 0x060006C1 RID: 1729 RVA: 0x00016EC0 File Offset: 0x000150C0
		// (set) Token: 0x060006C2 RID: 1730 RVA: 0x00016EC7 File Offset: 0x000150C7
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

		// Token: 0x0400025C RID: 604
		private float _areaHoverEps;

		// Token: 0x0400025D RID: 605
		private float _borderLineHoverEps;

		// Token: 0x0400025E RID: 606
		private float _thickBorderPolyHoverEps;

		// Token: 0x0400025F RID: 607
		private float _offsetSnapStepRight;

		// Token: 0x04000260 RID: 608
		private float _offsetSnapStepUp;

		// Token: 0x04000261 RID: 609
		private float _rotationSnapStep;

		// Token: 0x04000262 RID: 610
		private GizmoSnapMode _rotationSnapMode;

		// Token: 0x04000263 RID: 611
		private float _scaleSnapStepRight;

		// Token: 0x04000264 RID: 612
		private float _scaleSnapStepUp;

		// Token: 0x04000265 RID: 613
		private float _proportionalScaleSnapStep;

		// Token: 0x04000266 RID: 614
		private float _offsetSensitivity;

		// Token: 0x04000267 RID: 615
		private float _rotationSensitivity;

		// Token: 0x04000268 RID: 616
		private float _scaleSensitivity;
	}
}
