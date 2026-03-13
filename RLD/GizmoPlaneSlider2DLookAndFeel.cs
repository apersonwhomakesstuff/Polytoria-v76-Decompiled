using System;
using UnityEngine;

namespace RLD
{
	// Token: 0x02000092 RID: 146
	[Serializable]
	public class GizmoPlaneSlider2DLookAndFeel
	{
		// Token: 0x17000221 RID: 545
		// (get) Token: 0x06000689 RID: 1673 RVA: 0x0001EF84 File Offset: 0x0001D184
		// (set) Token: 0x0600068A RID: 1674 RVA: 0x00016E0C File Offset: 0x0001500C
		public GizmoFillMode2D FillMode
		{
			get
			{
				return GizmoFillMode2D.Filled;
			}
			set
			{
			}
		}

		// Token: 0x17000222 RID: 546
		// (get) Token: 0x0600068B RID: 1675 RVA: 0x0001EF9C File Offset: 0x0001D19C
		// (set) Token: 0x0600068C RID: 1676 RVA: 0x00016E0E File Offset: 0x0001500E
		public GizmoPlane2DType PlaneType
		{
			get
			{
				return GizmoPlane2DType.Quad;
			}
			set
			{
			}
		}

		// Token: 0x17000223 RID: 547
		// (get) Token: 0x0600068D RID: 1677 RVA: 0x00016E10 File Offset: 0x00015010
		// (set) Token: 0x0600068E RID: 1678 RVA: 0x00016E17 File Offset: 0x00015017
		public float Scale
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x17000224 RID: 548
		// (get) Token: 0x0600068F RID: 1679 RVA: 0x00016E19 File Offset: 0x00015019
		// (set) Token: 0x06000690 RID: 1680 RVA: 0x00016E20 File Offset: 0x00015020
		public float QuadWidth
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x17000225 RID: 549
		// (get) Token: 0x06000691 RID: 1681 RVA: 0x00016E22 File Offset: 0x00015022
		// (set) Token: 0x06000692 RID: 1682 RVA: 0x00016E29 File Offset: 0x00015029
		public float QuadHeight
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x17000226 RID: 550
		// (get) Token: 0x06000693 RID: 1683 RVA: 0x00016E2B File Offset: 0x0001502B
		// (set) Token: 0x06000694 RID: 1684 RVA: 0x00016E32 File Offset: 0x00015032
		public float CircleRadius
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x17000227 RID: 551
		// (get) Token: 0x06000695 RID: 1685 RVA: 0x00016E34 File Offset: 0x00015034
		// (set) Token: 0x06000696 RID: 1686 RVA: 0x00016E37 File Offset: 0x00015037
		public bool IsRotationArcVisible
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x17000228 RID: 552
		// (get) Token: 0x06000697 RID: 1687 RVA: 0x00016E39 File Offset: 0x00015039
		public GizmoRotationArc2DLookAndFeel RotationArcLookAndFeel
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000229 RID: 553
		// (get) Token: 0x06000698 RID: 1688 RVA: 0x0001EFB4 File Offset: 0x0001D1B4
		// (set) Token: 0x06000699 RID: 1689 RVA: 0x00016E3C File Offset: 0x0001503C
		public Color Color
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		// Token: 0x1700022A RID: 554
		// (get) Token: 0x0600069A RID: 1690 RVA: 0x0001EFCC File Offset: 0x0001D1CC
		// (set) Token: 0x0600069B RID: 1691 RVA: 0x00016E3E File Offset: 0x0001503E
		public Color HoveredColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		// Token: 0x1700022B RID: 555
		// (get) Token: 0x0600069C RID: 1692 RVA: 0x0001EFE4 File Offset: 0x0001D1E4
		// (set) Token: 0x0600069D RID: 1693 RVA: 0x00016E40 File Offset: 0x00015040
		public Color BorderColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		// Token: 0x1700022C RID: 556
		// (get) Token: 0x0600069E RID: 1694 RVA: 0x0001EFFC File Offset: 0x0001D1FC
		// (set) Token: 0x0600069F RID: 1695 RVA: 0x00016E42 File Offset: 0x00015042
		public Color HoveredBorderColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		// Token: 0x1700022D RID: 557
		// (get) Token: 0x060006A0 RID: 1696 RVA: 0x0001F014 File Offset: 0x0001D214
		// (set) Token: 0x060006A1 RID: 1697 RVA: 0x00016E44 File Offset: 0x00015044
		public GizmoQuad2DBorderType QuadBorderType
		{
			get
			{
				return GizmoQuad2DBorderType.Thin;
			}
			set
			{
			}
		}

		// Token: 0x1700022E RID: 558
		// (get) Token: 0x060006A2 RID: 1698 RVA: 0x0001F02C File Offset: 0x0001D22C
		// (set) Token: 0x060006A3 RID: 1699 RVA: 0x00016E46 File Offset: 0x00015046
		public GizmoCircle2DBorderType CircleBorderType
		{
			get
			{
				return GizmoCircle2DBorderType.Thin;
			}
			set
			{
			}
		}

		// Token: 0x1700022F RID: 559
		// (get) Token: 0x060006A4 RID: 1700 RVA: 0x0001F044 File Offset: 0x0001D244
		// (set) Token: 0x060006A5 RID: 1701 RVA: 0x00016E48 File Offset: 0x00015048
		public GizmoPolygon2DBorderType PolygonBorderType
		{
			get
			{
				return GizmoPolygon2DBorderType.Thin;
			}
			set
			{
			}
		}

		// Token: 0x17000230 RID: 560
		// (get) Token: 0x060006A6 RID: 1702 RVA: 0x00016E4A File Offset: 0x0001504A
		// (set) Token: 0x060006A7 RID: 1703 RVA: 0x00016E51 File Offset: 0x00015051
		public float BorderPolyThickness
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x0400024C RID: 588
		private GizmoFillMode2D _fillMode;

		// Token: 0x0400024D RID: 589
		private GizmoPlane2DType _planeType;

		// Token: 0x0400024E RID: 590
		private float _scale;

		// Token: 0x0400024F RID: 591
		private float _quadWidth;

		// Token: 0x04000250 RID: 592
		private float _quadHeight;

		// Token: 0x04000251 RID: 593
		private float _circleRadius;

		// Token: 0x04000252 RID: 594
		private bool _isRotationArcVisible;

		// Token: 0x04000253 RID: 595
		private GizmoRotationArc2DLookAndFeel _rotationArcLookAndFeel;

		// Token: 0x04000254 RID: 596
		private Color _color;

		// Token: 0x04000255 RID: 597
		private Color _hoveredColor;

		// Token: 0x04000256 RID: 598
		private Color _borderColor;

		// Token: 0x04000257 RID: 599
		private Color _hoveredBorderColor;

		// Token: 0x04000258 RID: 600
		private GizmoQuad2DBorderType _quadBorderType;

		// Token: 0x04000259 RID: 601
		private GizmoCircle2DBorderType _circleBorderType;

		// Token: 0x0400025A RID: 602
		private GizmoPolygon2DBorderType _polygonBorderType;

		// Token: 0x0400025B RID: 603
		private float _borderPolyThickness;
	}
}
