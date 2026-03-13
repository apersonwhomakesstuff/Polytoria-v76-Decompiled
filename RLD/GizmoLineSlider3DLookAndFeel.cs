using System;
using UnityEngine;

namespace RLD
{
	// Token: 0x0200009F RID: 159
	[Serializable]
	public class GizmoLineSlider3DLookAndFeel
	{
		// Token: 0x17000258 RID: 600
		// (get) Token: 0x0600073A RID: 1850 RVA: 0x0001F17C File Offset: 0x0001D37C
		// (set) Token: 0x0600073B RID: 1851 RVA: 0x00017024 File Offset: 0x00015224
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

		// Token: 0x17000259 RID: 601
		// (get) Token: 0x0600073C RID: 1852 RVA: 0x0001F194 File Offset: 0x0001D394
		// (set) Token: 0x0600073D RID: 1853 RVA: 0x00017026 File Offset: 0x00015226
		public GizmoLine3DType LineType
		{
			get
			{
				return GizmoLine3DType.Thin;
			}
			set
			{
			}
		}

		// Token: 0x1700025A RID: 602
		// (get) Token: 0x0600073E RID: 1854 RVA: 0x0001F1AC File Offset: 0x0001D3AC
		// (set) Token: 0x0600073F RID: 1855 RVA: 0x00017028 File Offset: 0x00015228
		public GizmoFillMode3D FillMode
		{
			get
			{
				return GizmoFillMode3D.Filled;
			}
			set
			{
			}
		}

		// Token: 0x1700025B RID: 603
		// (get) Token: 0x06000740 RID: 1856 RVA: 0x0001702A File Offset: 0x0001522A
		// (set) Token: 0x06000741 RID: 1857 RVA: 0x00017031 File Offset: 0x00015231
		public float Length
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x1700025C RID: 604
		// (get) Token: 0x06000742 RID: 1858 RVA: 0x00017033 File Offset: 0x00015233
		// (set) Token: 0x06000743 RID: 1859 RVA: 0x0001703A File Offset: 0x0001523A
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

		// Token: 0x1700025D RID: 605
		// (get) Token: 0x06000744 RID: 1860 RVA: 0x0001703C File Offset: 0x0001523C
		// (set) Token: 0x06000745 RID: 1861 RVA: 0x0001703F File Offset: 0x0001523F
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

		// Token: 0x1700025E RID: 606
		// (get) Token: 0x06000746 RID: 1862 RVA: 0x00017041 File Offset: 0x00015241
		// (set) Token: 0x06000747 RID: 1863 RVA: 0x00017044 File Offset: 0x00015244
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

		// Token: 0x1700025F RID: 607
		// (get) Token: 0x06000748 RID: 1864 RVA: 0x00017046 File Offset: 0x00015246
		public GizmoRotationArc3DLookAndFeel RotationArcLookAndFeel
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000260 RID: 608
		// (get) Token: 0x06000749 RID: 1865 RVA: 0x00017049 File Offset: 0x00015249
		public GizmoCap3DLookAndFeel CapLookAndFeel
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000261 RID: 609
		// (get) Token: 0x0600074A RID: 1866 RVA: 0x0001704C File Offset: 0x0001524C
		// (set) Token: 0x0600074B RID: 1867 RVA: 0x00017053 File Offset: 0x00015253
		public float BoxHeight
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x17000262 RID: 610
		// (get) Token: 0x0600074C RID: 1868 RVA: 0x00017055 File Offset: 0x00015255
		// (set) Token: 0x0600074D RID: 1869 RVA: 0x0001705C File Offset: 0x0001525C
		public float BoxDepth
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x17000263 RID: 611
		// (get) Token: 0x0600074E RID: 1870 RVA: 0x0001705E File Offset: 0x0001525E
		// (set) Token: 0x0600074F RID: 1871 RVA: 0x00017065 File Offset: 0x00015265
		public float CylinderRadius
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x17000264 RID: 612
		// (get) Token: 0x06000750 RID: 1872 RVA: 0x0001F1C4 File Offset: 0x0001D3C4
		// (set) Token: 0x06000751 RID: 1873 RVA: 0x00017067 File Offset: 0x00015267
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

		// Token: 0x17000265 RID: 613
		// (get) Token: 0x06000752 RID: 1874 RVA: 0x0001F1DC File Offset: 0x0001D3DC
		// (set) Token: 0x06000753 RID: 1875 RVA: 0x00017069 File Offset: 0x00015269
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

		// Token: 0x04000293 RID: 659
		private GizmoShadeMode _shadeMode;

		// Token: 0x04000294 RID: 660
		private GizmoLine3DType _lineType;

		// Token: 0x04000295 RID: 661
		private GizmoFillMode3D _fillMode;

		// Token: 0x04000296 RID: 662
		private float _length;

		// Token: 0x04000297 RID: 663
		private float _scale;

		// Token: 0x04000298 RID: 664
		private bool _useZoomFactor;

		// Token: 0x04000299 RID: 665
		private float _boxHeight;

		// Token: 0x0400029A RID: 666
		private float _boxDepth;

		// Token: 0x0400029B RID: 667
		private float _cylinderRadius;

		// Token: 0x0400029C RID: 668
		private bool _isRotationArcVisible;

		// Token: 0x0400029D RID: 669
		private GizmoRotationArc3DLookAndFeel _rotationArcLookAndFeel;

		// Token: 0x0400029E RID: 670
		private Color _color;

		// Token: 0x0400029F RID: 671
		private Color _hoveredColor;

		// Token: 0x040002A0 RID: 672
		private GizmoCap3DLookAndFeel _capLookAndFeel;
	}
}
