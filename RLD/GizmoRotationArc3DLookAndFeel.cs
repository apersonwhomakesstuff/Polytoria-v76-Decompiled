using System;
using UnityEngine;

namespace RLD
{
	// Token: 0x020000D5 RID: 213
	[Serializable]
	public class GizmoRotationArc3DLookAndFeel
	{
		// Token: 0x170002D3 RID: 723
		// (get) Token: 0x060008E3 RID: 2275 RVA: 0x0001755A File Offset: 0x0001575A
		// (set) Token: 0x060008E4 RID: 2276 RVA: 0x0001755D File Offset: 0x0001575D
		public bool UseShortestRotation
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x170002D4 RID: 724
		// (get) Token: 0x060008E5 RID: 2277 RVA: 0x0001F4DC File Offset: 0x0001D6DC
		// (set) Token: 0x060008E6 RID: 2278 RVA: 0x0001755F File Offset: 0x0001575F
		public GizmoRotationArcFillFlags FillFlags
		{
			get
			{
				return GizmoRotationArcFillFlags.None;
			}
			set
			{
			}
		}

		// Token: 0x170002D5 RID: 725
		// (get) Token: 0x060008E7 RID: 2279 RVA: 0x0001F4F4 File Offset: 0x0001D6F4
		// (set) Token: 0x060008E8 RID: 2280 RVA: 0x00017561 File Offset: 0x00015761
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

		// Token: 0x170002D6 RID: 726
		// (get) Token: 0x060008E9 RID: 2281 RVA: 0x0001F50C File Offset: 0x0001D70C
		// (set) Token: 0x060008EA RID: 2282 RVA: 0x00017563 File Offset: 0x00015763
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

		// Token: 0x040003A4 RID: 932
		private bool _useShortestRotation;

		// Token: 0x040003A5 RID: 933
		private GizmoRotationArcFillFlags _fillFlags;

		// Token: 0x040003A6 RID: 934
		private Color _color;

		// Token: 0x040003A7 RID: 935
		private Color _borderColor;
	}
}
