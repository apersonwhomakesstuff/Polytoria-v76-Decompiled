using System;
using UnityEngine;

namespace RLD
{
	// Token: 0x02000210 RID: 528
	[Serializable]
	public class PrefabPreviewLookAndFeel : Settings
	{
		// Token: 0x17000804 RID: 2052
		// (get) Token: 0x060017DD RID: 6109 RVA: 0x00023A14 File Offset: 0x00021C14
		// (set) Token: 0x060017DE RID: 6110 RVA: 0x00019E6E File Offset: 0x0001806E
		public Color BkColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		// Token: 0x17000805 RID: 2053
		// (get) Token: 0x060017DF RID: 6111 RVA: 0x00019E70 File Offset: 0x00018070
		// (set) Token: 0x060017E0 RID: 6112 RVA: 0x00019E73 File Offset: 0x00018073
		public int PreviewWidth
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x17000806 RID: 2054
		// (get) Token: 0x060017E1 RID: 6113 RVA: 0x00019E75 File Offset: 0x00018075
		// (set) Token: 0x060017E2 RID: 6114 RVA: 0x00019E78 File Offset: 0x00018078
		public int PreviewHeight
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x17000807 RID: 2055
		// (get) Token: 0x060017E3 RID: 6115 RVA: 0x00019E7A File Offset: 0x0001807A
		// (set) Token: 0x060017E4 RID: 6116 RVA: 0x00019E81 File Offset: 0x00018081
		public float LightIntensity
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x04000854 RID: 2132
		private static readonly float _minBkAlpha;

		// Token: 0x04000855 RID: 2133
		private Color _bkColor;

		// Token: 0x04000856 RID: 2134
		private int _previewWidth;

		// Token: 0x04000857 RID: 2135
		private int _previewHeight;

		// Token: 0x04000858 RID: 2136
		private float _lightIntensity;
	}
}
