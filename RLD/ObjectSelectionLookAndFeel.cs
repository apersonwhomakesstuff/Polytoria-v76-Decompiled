using System;
using UnityEngine;

namespace RLD
{
	// Token: 0x02000220 RID: 544
	[Serializable]
	public class ObjectSelectionLookAndFeel : Settings
	{
		// Token: 0x17000829 RID: 2089
		// (get) Token: 0x06001829 RID: 6185 RVA: 0x00019F4E File Offset: 0x0001814E
		// (set) Token: 0x0600182A RID: 6186 RVA: 0x00019F51 File Offset: 0x00018151
		public bool DrawHighlight
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x1700082A RID: 2090
		// (get) Token: 0x0600182B RID: 6187 RVA: 0x00023A74 File Offset: 0x00021C74
		// (set) Token: 0x0600182C RID: 6188 RVA: 0x00019F53 File Offset: 0x00018153
		public SelectionBoxBorderStyle SelBoxBorderStyle
		{
			get
			{
				return SelectionBoxBorderStyle.FullWire;
			}
			set
			{
			}
		}

		// Token: 0x1700082B RID: 2091
		// (get) Token: 0x0600182D RID: 6189 RVA: 0x00019F55 File Offset: 0x00018155
		// (set) Token: 0x0600182E RID: 6190 RVA: 0x00019F5C File Offset: 0x0001815C
		public float WireCornerLinePercentage
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x1700082C RID: 2092
		// (get) Token: 0x0600182F RID: 6191 RVA: 0x00023A8C File Offset: 0x00021C8C
		// (set) Token: 0x06001830 RID: 6192 RVA: 0x00019F5E File Offset: 0x0001815E
		public SelectionBoxRenderMode SelBoxRenderMode
		{
			get
			{
				return SelectionBoxRenderMode.PerObject;
			}
			set
			{
			}
		}

		// Token: 0x1700082D RID: 2093
		// (get) Token: 0x06001831 RID: 6193 RVA: 0x00023AA4 File Offset: 0x00021CA4
		// (set) Token: 0x06001832 RID: 6194 RVA: 0x00019F60 File Offset: 0x00018160
		public Color SelectionBoxBorderColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		// Token: 0x1700082E RID: 2094
		// (get) Token: 0x06001833 RID: 6195 RVA: 0x00019F62 File Offset: 0x00018162
		// (set) Token: 0x06001834 RID: 6196 RVA: 0x00019F69 File Offset: 0x00018169
		public float SelectionBoxInflateAmount
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x1700082F RID: 2095
		// (get) Token: 0x06001835 RID: 6197 RVA: 0x00023ABC File Offset: 0x00021CBC
		// (set) Token: 0x06001836 RID: 6198 RVA: 0x00019F6B File Offset: 0x0001816B
		public Color SelectionRectBorderColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		// Token: 0x17000830 RID: 2096
		// (get) Token: 0x06001837 RID: 6199 RVA: 0x00023AD4 File Offset: 0x00021CD4
		// (set) Token: 0x06001838 RID: 6200 RVA: 0x00019F6D File Offset: 0x0001816D
		public Color SelectionRectFillColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		// Token: 0x0400087D RID: 2173
		private bool _drawHighlight;

		// Token: 0x0400087E RID: 2174
		private SelectionBoxBorderStyle _selectionBoxBorderStyle;

		// Token: 0x0400087F RID: 2175
		private float _wireCornerLinePercentage;

		// Token: 0x04000880 RID: 2176
		private SelectionBoxRenderMode _selectionBoxRenderMode;

		// Token: 0x04000881 RID: 2177
		private Color _selectionBoxBorderColor;

		// Token: 0x04000882 RID: 2178
		private float _selectionBoxInflateAmount;

		// Token: 0x04000883 RID: 2179
		private Color _selectionRectBorderColor;

		// Token: 0x04000884 RID: 2180
		private Color _selectionRectFillColor;
	}
}
