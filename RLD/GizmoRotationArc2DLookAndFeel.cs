using System;
using UnityEngine;

namespace RLD
{
	// Token: 0x020000D3 RID: 211
	[Serializable]
	public class GizmoRotationArc2DLookAndFeel
	{
		// Token: 0x170002CD RID: 717
		// (get) Token: 0x060008D3 RID: 2259 RVA: 0x00017529 File Offset: 0x00015729
		// (set) Token: 0x060008D4 RID: 2260 RVA: 0x0001752C File Offset: 0x0001572C
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

		// Token: 0x170002CE RID: 718
		// (get) Token: 0x060008D5 RID: 2261 RVA: 0x0001F494 File Offset: 0x0001D694
		// (set) Token: 0x060008D6 RID: 2262 RVA: 0x0001752E File Offset: 0x0001572E
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

		// Token: 0x170002CF RID: 719
		// (get) Token: 0x060008D7 RID: 2263 RVA: 0x0001F4AC File Offset: 0x0001D6AC
		// (set) Token: 0x060008D8 RID: 2264 RVA: 0x00017530 File Offset: 0x00015730
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

		// Token: 0x170002D0 RID: 720
		// (get) Token: 0x060008D9 RID: 2265 RVA: 0x0001F4C4 File Offset: 0x0001D6C4
		// (set) Token: 0x060008DA RID: 2266 RVA: 0x00017532 File Offset: 0x00015732
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

		// Token: 0x0400039F RID: 927
		private bool _useShortestRotation;

		// Token: 0x040003A0 RID: 928
		private GizmoRotationArcFillFlags _fillFlags;

		// Token: 0x040003A1 RID: 929
		private Color _color;

		// Token: 0x040003A2 RID: 930
		private Color _borderColor;
	}
}
