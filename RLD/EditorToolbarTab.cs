using System;
using System.Collections.Generic;

namespace RLD
{
	// Token: 0x0200011A RID: 282
	[Serializable]
	public class EditorToolbarTab
	{
		// Token: 0x06000F05 RID: 3845 RVA: 0x0001870F File Offset: 0x0001690F
		public EditorToolbarTab(string text, string tooltip)
		{
		}

		// Token: 0x17000530 RID: 1328
		// (get) Token: 0x06000F06 RID: 3846 RVA: 0x00018717 File Offset: 0x00016917
		// (set) Token: 0x06000F07 RID: 3847 RVA: 0x0001871A File Offset: 0x0001691A
		public string Tooltip
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x17000531 RID: 1329
		// (get) Token: 0x06000F08 RID: 3848 RVA: 0x0001871C File Offset: 0x0001691C
		// (set) Token: 0x06000F09 RID: 3849 RVA: 0x0001871F File Offset: 0x0001691F
		public string Text
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x17000532 RID: 1330
		// (get) Token: 0x06000F0A RID: 3850 RVA: 0x00018721 File Offset: 0x00016921
		// (set) Token: 0x06000F0B RID: 3851 RVA: 0x00018724 File Offset: 0x00016924
		public EditorToolbar TargetToolbar
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x17000533 RID: 1331
		// (get) Token: 0x06000F0C RID: 3852 RVA: 0x00018726 File Offset: 0x00016926
		public int NumTargetSettings
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x06000F0D RID: 3853 RVA: 0x00018729 File Offset: 0x00016929
		public void AddTargetSettings(Settings targetSettings)
		{
		}

		// Token: 0x04000550 RID: 1360
		private string _tooltip;

		// Token: 0x04000551 RID: 1361
		private string _text;

		// Token: 0x04000552 RID: 1362
		[NonSerialized]
		private EditorToolbar _targetToolbar;

		// Token: 0x04000553 RID: 1363
		[NonSerialized]
		private List<Settings> _targetSettings;
	}
}
