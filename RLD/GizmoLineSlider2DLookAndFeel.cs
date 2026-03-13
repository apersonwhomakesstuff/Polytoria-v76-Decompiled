using System;
using UnityEngine;

namespace RLD
{
	// Token: 0x02000089 RID: 137
	[Serializable]
	public class GizmoLineSlider2DLookAndFeel
	{
		// Token: 0x170001EF RID: 495
		// (get) Token: 0x0600060F RID: 1551 RVA: 0x0001EDA4 File Offset: 0x0001CFA4
		// (set) Token: 0x06000610 RID: 1552 RVA: 0x00016CA8 File Offset: 0x00014EA8
		public GizmoLine2DType LineType
		{
			get
			{
				return GizmoLine2DType.Thin;
			}
			set
			{
			}
		}

		// Token: 0x170001F0 RID: 496
		// (get) Token: 0x06000611 RID: 1553 RVA: 0x0001EDBC File Offset: 0x0001CFBC
		// (set) Token: 0x06000612 RID: 1554 RVA: 0x00016CAA File Offset: 0x00014EAA
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

		// Token: 0x170001F1 RID: 497
		// (get) Token: 0x06000613 RID: 1555 RVA: 0x00016CAC File Offset: 0x00014EAC
		// (set) Token: 0x06000614 RID: 1556 RVA: 0x00016CB3 File Offset: 0x00014EB3
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

		// Token: 0x170001F2 RID: 498
		// (get) Token: 0x06000615 RID: 1557 RVA: 0x00016CB5 File Offset: 0x00014EB5
		// (set) Token: 0x06000616 RID: 1558 RVA: 0x00016CBC File Offset: 0x00014EBC
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

		// Token: 0x170001F3 RID: 499
		// (get) Token: 0x06000617 RID: 1559 RVA: 0x00016CBE File Offset: 0x00014EBE
		public GizmoCap2DLookAndFeel CapLookAndFeel
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170001F4 RID: 500
		// (get) Token: 0x06000618 RID: 1560 RVA: 0x00016CC1 File Offset: 0x00014EC1
		// (set) Token: 0x06000619 RID: 1561 RVA: 0x00016CC8 File Offset: 0x00014EC8
		public float BoxThickness
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x170001F5 RID: 501
		// (get) Token: 0x0600061A RID: 1562 RVA: 0x00016CCA File Offset: 0x00014ECA
		// (set) Token: 0x0600061B RID: 1563 RVA: 0x00016CCD File Offset: 0x00014ECD
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

		// Token: 0x170001F6 RID: 502
		// (get) Token: 0x0600061C RID: 1564 RVA: 0x0001EDD4 File Offset: 0x0001CFD4
		// (set) Token: 0x0600061D RID: 1565 RVA: 0x00016CCF File Offset: 0x00014ECF
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

		// Token: 0x170001F7 RID: 503
		// (get) Token: 0x0600061E RID: 1566 RVA: 0x0001EDEC File Offset: 0x0001CFEC
		// (set) Token: 0x0600061F RID: 1567 RVA: 0x00016CD1 File Offset: 0x00014ED1
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

		// Token: 0x170001F8 RID: 504
		// (get) Token: 0x06000620 RID: 1568 RVA: 0x0001EE04 File Offset: 0x0001D004
		// (set) Token: 0x06000621 RID: 1569 RVA: 0x00016CD3 File Offset: 0x00014ED3
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

		// Token: 0x170001F9 RID: 505
		// (get) Token: 0x06000622 RID: 1570 RVA: 0x0001EE1C File Offset: 0x0001D01C
		// (set) Token: 0x06000623 RID: 1571 RVA: 0x00016CD5 File Offset: 0x00014ED5
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

		// Token: 0x170001FA RID: 506
		// (get) Token: 0x06000624 RID: 1572 RVA: 0x00016CD7 File Offset: 0x00014ED7
		public GizmoRotationArc2DLookAndFeel RotationArcLookAndFeel
		{
			get
			{
				return null;
			}
		}

		// Token: 0x0400020A RID: 522
		private GizmoLine2DType _lineType;

		// Token: 0x0400020B RID: 523
		private GizmoFillMode2D _fillMode;

		// Token: 0x0400020C RID: 524
		private float _length;

		// Token: 0x0400020D RID: 525
		private float _scale;

		// Token: 0x0400020E RID: 526
		private float _boxThickness;

		// Token: 0x0400020F RID: 527
		private bool _isRotationArcVisible;

		// Token: 0x04000210 RID: 528
		private Color _color;

		// Token: 0x04000211 RID: 529
		private Color _hoveredColor;

		// Token: 0x04000212 RID: 530
		private Color _borderColor;

		// Token: 0x04000213 RID: 531
		private Color _hoveredBorderColor;

		// Token: 0x04000214 RID: 532
		private GizmoRotationArc2DLookAndFeel _rotationArcLookAndFeel;

		// Token: 0x04000215 RID: 533
		private GizmoCap2DLookAndFeel _capLookAndFeel;
	}
}
