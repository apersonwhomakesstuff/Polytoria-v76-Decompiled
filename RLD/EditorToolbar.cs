using System;
using UnityEngine;

namespace RLD
{
	// Token: 0x02000119 RID: 281
	[Serializable]
	public class EditorToolbar
	{
		// Token: 0x1700052B RID: 1323
		// (get) Token: 0x06000EFC RID: 3836 RVA: 0x000186F4 File Offset: 0x000168F4
		public int ActiveTabIndex
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x1700052C RID: 1324
		// (get) Token: 0x06000EFD RID: 3837 RVA: 0x000186F7 File Offset: 0x000168F7
		public EditorToolbarTab ActiveTab
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700052D RID: 1325
		// (get) Token: 0x06000EFE RID: 3838 RVA: 0x000207CC File Offset: 0x0001E9CC
		// (set) Token: 0x06000EFF RID: 3839 RVA: 0x000186FA File Offset: 0x000168FA
		public Color ActiveTabColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		// Token: 0x1700052E RID: 1326
		// (get) Token: 0x06000F00 RID: 3840 RVA: 0x000186FC File Offset: 0x000168FC
		// (set) Token: 0x06000F01 RID: 3841 RVA: 0x000186FF File Offset: 0x000168FF
		public int NumTabsPerRow
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x1700052F RID: 1327
		// (get) Token: 0x06000F02 RID: 3842 RVA: 0x00018701 File Offset: 0x00016901
		public int NumTabs
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x06000F03 RID: 3843 RVA: 0x00018704 File Offset: 0x00016904
		public EditorToolbar(EditorToolbarTab[] tabs, int numTabsPerRow, Color activeTabColor)
		{
		}

		// Token: 0x06000F04 RID: 3844 RVA: 0x0001870C File Offset: 0x0001690C
		public EditorToolbarTab GetTabByIndex(int tabIndex)
		{
			return null;
		}

		// Token: 0x0400054C RID: 1356
		private Color _activeTabColor;

		// Token: 0x0400054D RID: 1357
		private int _numTabsPerRow;

		// Token: 0x0400054E RID: 1358
		private EditorToolbarTab[] _tabs;

		// Token: 0x0400054F RID: 1359
		private int _activeTabIndex;
	}
}
