using System;
using UnityEngine;

namespace RLD
{
	// Token: 0x020000A9 RID: 169
	[Serializable]
	public class GizmoPlaneSlider3DLookAndFeel
	{
		// Token: 0x1700028F RID: 655
		// (get) Token: 0x060007D1 RID: 2001 RVA: 0x0001F35C File Offset: 0x0001D55C
		// (set) Token: 0x060007D2 RID: 2002 RVA: 0x000171EC File Offset: 0x000153EC
		public GizmoShadeMode ShadeMode
		{
			get
			{
				return GizmoShadeMode.Lit;
			}
			set
			{
			}
		}

		// Token: 0x17000290 RID: 656
		// (get) Token: 0x060007D3 RID: 2003 RVA: 0x0001F374 File Offset: 0x0001D574
		// (set) Token: 0x060007D4 RID: 2004 RVA: 0x000171EE File Offset: 0x000153EE
		public GizmoPlane3DType PlaneType
		{
			get
			{
				return GizmoPlane3DType.Quad;
			}
			set
			{
			}
		}

		// Token: 0x17000291 RID: 657
		// (get) Token: 0x060007D5 RID: 2005 RVA: 0x000171F0 File Offset: 0x000153F0
		// (set) Token: 0x060007D6 RID: 2006 RVA: 0x000171F7 File Offset: 0x000153F7
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

		// Token: 0x17000292 RID: 658
		// (get) Token: 0x060007D7 RID: 2007 RVA: 0x000171F9 File Offset: 0x000153F9
		// (set) Token: 0x060007D8 RID: 2008 RVA: 0x000171FC File Offset: 0x000153FC
		public bool UseZoomFactor
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x17000293 RID: 659
		// (get) Token: 0x060007D9 RID: 2009 RVA: 0x000171FE File Offset: 0x000153FE
		// (set) Token: 0x060007DA RID: 2010 RVA: 0x00017205 File Offset: 0x00015405
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

		// Token: 0x17000294 RID: 660
		// (get) Token: 0x060007DB RID: 2011 RVA: 0x00017207 File Offset: 0x00015407
		// (set) Token: 0x060007DC RID: 2012 RVA: 0x0001720E File Offset: 0x0001540E
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

		// Token: 0x17000295 RID: 661
		// (get) Token: 0x060007DD RID: 2013 RVA: 0x00017210 File Offset: 0x00015410
		// (set) Token: 0x060007DE RID: 2014 RVA: 0x00017217 File Offset: 0x00015417
		public float RATriangleXLength
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x17000296 RID: 662
		// (get) Token: 0x060007DF RID: 2015 RVA: 0x00017219 File Offset: 0x00015419
		// (set) Token: 0x060007E0 RID: 2016 RVA: 0x00017220 File Offset: 0x00015420
		public float RATriangleYLength
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x17000297 RID: 663
		// (get) Token: 0x060007E1 RID: 2017 RVA: 0x00017222 File Offset: 0x00015422
		// (set) Token: 0x060007E2 RID: 2018 RVA: 0x00017229 File Offset: 0x00015429
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

		// Token: 0x17000298 RID: 664
		// (get) Token: 0x060007E3 RID: 2019 RVA: 0x0001722B File Offset: 0x0001542B
		// (set) Token: 0x060007E4 RID: 2020 RVA: 0x00017232 File Offset: 0x00015432
		public float BorderCircleCullAlphaScale
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x17000299 RID: 665
		// (get) Token: 0x060007E5 RID: 2021 RVA: 0x00017234 File Offset: 0x00015434
		// (set) Token: 0x060007E6 RID: 2022 RVA: 0x0001723B File Offset: 0x0001543B
		public float BorderBoxHeight
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x1700029A RID: 666
		// (get) Token: 0x060007E7 RID: 2023 RVA: 0x0001723D File Offset: 0x0001543D
		// (set) Token: 0x060007E8 RID: 2024 RVA: 0x00017244 File Offset: 0x00015444
		public float BorderBoxDepth
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x1700029B RID: 667
		// (get) Token: 0x060007E9 RID: 2025 RVA: 0x00017246 File Offset: 0x00015446
		// (set) Token: 0x060007EA RID: 2026 RVA: 0x0001724D File Offset: 0x0001544D
		public float BorderTorusThickness
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x1700029C RID: 668
		// (get) Token: 0x060007EB RID: 2027 RVA: 0x0001724F File Offset: 0x0001544F
		// (set) Token: 0x060007EC RID: 2028 RVA: 0x00017256 File Offset: 0x00015456
		public float BorderCylTorusWidth
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x1700029D RID: 669
		// (get) Token: 0x060007ED RID: 2029 RVA: 0x00017258 File Offset: 0x00015458
		// (set) Token: 0x060007EE RID: 2030 RVA: 0x0001725F File Offset: 0x0001545F
		public float BorderCylTorusHeight
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x1700029E RID: 670
		// (get) Token: 0x060007EF RID: 2031 RVA: 0x00017261 File Offset: 0x00015461
		// (set) Token: 0x060007F0 RID: 2032 RVA: 0x00017264 File Offset: 0x00015464
		public int NumBorderTorusWireAxialSlices
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x1700029F RID: 671
		// (get) Token: 0x060007F1 RID: 2033 RVA: 0x0001F38C File Offset: 0x0001D58C
		// (set) Token: 0x060007F2 RID: 2034 RVA: 0x00017266 File Offset: 0x00015466
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

		// Token: 0x170002A0 RID: 672
		// (get) Token: 0x060007F3 RID: 2035 RVA: 0x0001F3A4 File Offset: 0x0001D5A4
		// (set) Token: 0x060007F4 RID: 2036 RVA: 0x00017268 File Offset: 0x00015468
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

		// Token: 0x170002A1 RID: 673
		// (get) Token: 0x060007F5 RID: 2037 RVA: 0x0001F3BC File Offset: 0x0001D5BC
		// (set) Token: 0x060007F6 RID: 2038 RVA: 0x0001726A File Offset: 0x0001546A
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

		// Token: 0x170002A2 RID: 674
		// (get) Token: 0x060007F7 RID: 2039 RVA: 0x0001F3D4 File Offset: 0x0001D5D4
		// (set) Token: 0x060007F8 RID: 2040 RVA: 0x0001726C File Offset: 0x0001546C
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

		// Token: 0x170002A3 RID: 675
		// (get) Token: 0x060007F9 RID: 2041 RVA: 0x0001F3EC File Offset: 0x0001D5EC
		// (set) Token: 0x060007FA RID: 2042 RVA: 0x0001726E File Offset: 0x0001546E
		public GizmoShadeMode BorderShadeMode
		{
			get
			{
				return GizmoShadeMode.Lit;
			}
			set
			{
			}
		}

		// Token: 0x170002A4 RID: 676
		// (get) Token: 0x060007FB RID: 2043 RVA: 0x0001F404 File Offset: 0x0001D604
		// (set) Token: 0x060007FC RID: 2044 RVA: 0x00017270 File Offset: 0x00015470
		public GizmoFillMode3D BorderFillMode
		{
			get
			{
				return GizmoFillMode3D.Filled;
			}
			set
			{
			}
		}

		// Token: 0x170002A5 RID: 677
		// (get) Token: 0x060007FD RID: 2045 RVA: 0x0001F41C File Offset: 0x0001D61C
		// (set) Token: 0x060007FE RID: 2046 RVA: 0x00017272 File Offset: 0x00015472
		public GizmoQuad3DBorderType QuadBorderType
		{
			get
			{
				return GizmoQuad3DBorderType.Thin;
			}
			set
			{
			}
		}

		// Token: 0x170002A6 RID: 678
		// (get) Token: 0x060007FF RID: 2047 RVA: 0x0001F434 File Offset: 0x0001D634
		// (set) Token: 0x06000800 RID: 2048 RVA: 0x00017274 File Offset: 0x00015474
		public GizmoCircle3DBorderType CircleBorderType
		{
			get
			{
				return GizmoCircle3DBorderType.Thin;
			}
			set
			{
			}
		}

		// Token: 0x170002A7 RID: 679
		// (get) Token: 0x06000801 RID: 2049 RVA: 0x0001F44C File Offset: 0x0001D64C
		// (set) Token: 0x06000802 RID: 2050 RVA: 0x00017276 File Offset: 0x00015476
		public GizmoRATriangle3DBorderType RATriangleBorderType
		{
			get
			{
				return GizmoRATriangle3DBorderType.Thin;
			}
			set
			{
			}
		}

		// Token: 0x170002A8 RID: 680
		// (get) Token: 0x06000803 RID: 2051 RVA: 0x00017278 File Offset: 0x00015478
		// (set) Token: 0x06000804 RID: 2052 RVA: 0x0001727B File Offset: 0x0001547B
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

		// Token: 0x170002A9 RID: 681
		// (get) Token: 0x06000805 RID: 2053 RVA: 0x0001727D File Offset: 0x0001547D
		public GizmoRotationArc3DLookAndFeel RotationArcLookAndFeel
		{
			get
			{
				return null;
			}
		}

		// Token: 0x040002D8 RID: 728
		private GizmoPlane3DType _planeType;

		// Token: 0x040002D9 RID: 729
		private float _scale;

		// Token: 0x040002DA RID: 730
		private bool _useZoomFactor;

		// Token: 0x040002DB RID: 731
		private float _quadWidth;

		// Token: 0x040002DC RID: 732
		private float _quadHeight;

		// Token: 0x040002DD RID: 733
		private float _raTriangleXLength;

		// Token: 0x040002DE RID: 734
		private float _raTriangleYLength;

		// Token: 0x040002DF RID: 735
		private float _circleRadius;

		// Token: 0x040002E0 RID: 736
		private float _borderBoxHeight;

		// Token: 0x040002E1 RID: 737
		private float _borderBoxDepth;

		// Token: 0x040002E2 RID: 738
		private float _borderTorusThickness;

		// Token: 0x040002E3 RID: 739
		private int _numBorderTorusWireAxialSlices;

		// Token: 0x040002E4 RID: 740
		private float _borderCylTorusWidth;

		// Token: 0x040002E5 RID: 741
		private float _borderCylTorusHeight;

		// Token: 0x040002E6 RID: 742
		private GizmoShadeMode _shadeMode;

		// Token: 0x040002E7 RID: 743
		private Color _color;

		// Token: 0x040002E8 RID: 744
		private Color _hoveredColor;

		// Token: 0x040002E9 RID: 745
		private Color _borderColor;

		// Token: 0x040002EA RID: 746
		private Color _hoveredBorderColor;

		// Token: 0x040002EB RID: 747
		private float _borderCircleCullAlphaScale;

		// Token: 0x040002EC RID: 748
		private GizmoShadeMode _borderShadeMode;

		// Token: 0x040002ED RID: 749
		private GizmoFillMode3D _borderFillMode;

		// Token: 0x040002EE RID: 750
		private GizmoQuad3DBorderType _quadBorderType;

		// Token: 0x040002EF RID: 751
		private GizmoRATriangle3DBorderType _raTriangleBorderType;

		// Token: 0x040002F0 RID: 752
		private GizmoCircle3DBorderType _circleBorderType;

		// Token: 0x040002F1 RID: 753
		private bool _isRotationArcVisible;

		// Token: 0x040002F2 RID: 754
		private GizmoRotationArc3DLookAndFeel _rotationArcLookAndFeel;
	}
}
