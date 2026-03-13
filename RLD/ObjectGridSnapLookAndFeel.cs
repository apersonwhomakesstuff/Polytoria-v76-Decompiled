using System;
using UnityEngine;

namespace RLD
{
	// Token: 0x020001D0 RID: 464
	[Serializable]
	public class ObjectGridSnapLookAndFeel : Settings
	{
		// Token: 0x17000694 RID: 1684
		// (get) Token: 0x06001434 RID: 5172 RVA: 0x00021DC4 File Offset: 0x0001FFC4
		// (set) Token: 0x06001435 RID: 5173 RVA: 0x000195E0 File Offset: 0x000177E0
		public PivotPointShapeType PivotShapeType
		{
			get
			{
				return PivotPointShapeType.Square;
			}
			set
			{
			}
		}

		// Token: 0x17000695 RID: 1685
		// (get) Token: 0x06001436 RID: 5174 RVA: 0x00021DDC File Offset: 0x0001FFDC
		// (set) Token: 0x06001437 RID: 5175 RVA: 0x000195E2 File Offset: 0x000177E2
		public Color PivotPointFillColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		// Token: 0x17000696 RID: 1686
		// (get) Token: 0x06001438 RID: 5176 RVA: 0x00021DF4 File Offset: 0x0001FFF4
		// (set) Token: 0x06001439 RID: 5177 RVA: 0x000195E4 File Offset: 0x000177E4
		public Color PivotPointBorderColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		// Token: 0x17000697 RID: 1687
		// (get) Token: 0x0600143A RID: 5178 RVA: 0x000195E6 File Offset: 0x000177E6
		// (set) Token: 0x0600143B RID: 5179 RVA: 0x000195ED File Offset: 0x000177ED
		public float PivotCircleRadius
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x17000698 RID: 1688
		// (get) Token: 0x0600143C RID: 5180 RVA: 0x000195EF File Offset: 0x000177EF
		// (set) Token: 0x0600143D RID: 5181 RVA: 0x000195F6 File Offset: 0x000177F6
		public float PivotSquareSideLength
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x17000699 RID: 1689
		// (get) Token: 0x0600143E RID: 5182 RVA: 0x000195F8 File Offset: 0x000177F8
		// (set) Token: 0x0600143F RID: 5183 RVA: 0x000195FB File Offset: 0x000177FB
		public bool DrawPivotBorder
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x1700069A RID: 1690
		// (get) Token: 0x06001440 RID: 5184 RVA: 0x00021E0C File Offset: 0x0002000C
		// (set) Token: 0x06001441 RID: 5185 RVA: 0x000195FD File Offset: 0x000177FD
		public Color BoxLineColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		// Token: 0x1700069B RID: 1691
		// (get) Token: 0x06001442 RID: 5186 RVA: 0x000195FF File Offset: 0x000177FF
		// (set) Token: 0x06001443 RID: 5187 RVA: 0x00019602 File Offset: 0x00017802
		public bool DrawBoxes
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x04000760 RID: 1888
		private PivotPointShapeType _pivotShapeType;

		// Token: 0x04000761 RID: 1889
		private Color _pivotPointFillColor;

		// Token: 0x04000762 RID: 1890
		private Color _pivotPointBorderColor;

		// Token: 0x04000763 RID: 1891
		private float _pivotCircleRadius;

		// Token: 0x04000764 RID: 1892
		private float _pivotSquareSideLength;

		// Token: 0x04000765 RID: 1893
		private bool _drawPivotBorder;

		// Token: 0x04000766 RID: 1894
		private Color _boxLineColor;

		// Token: 0x04000767 RID: 1895
		private bool _drawBoxes;
	}
}
