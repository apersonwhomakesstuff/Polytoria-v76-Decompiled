using System;
using UnityEngine;

namespace RLD
{
	// Token: 0x020001B0 RID: 432
	[Serializable]
	public class XZGridLookAndFeel : Settings
	{
		// Token: 0x17000631 RID: 1585
		// (get) Token: 0x0600131B RID: 4891 RVA: 0x00021B6C File Offset: 0x0001FD6C
		// (set) Token: 0x0600131C RID: 4892 RVA: 0x000192C6 File Offset: 0x000174C6
		public Color LineColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		// Token: 0x17000632 RID: 1586
		// (get) Token: 0x0600131D RID: 4893 RVA: 0x000192C8 File Offset: 0x000174C8
		// (set) Token: 0x0600131E RID: 4894 RVA: 0x000192CB File Offset: 0x000174CB
		public bool UseCellFading
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x040006D3 RID: 1747
		private Color _lineColor;

		// Token: 0x040006D4 RID: 1748
		private bool _useCellFading;
	}
}
