using System;

namespace RLD
{
	// Token: 0x020000EB RID: 235
	[Serializable]
	public class UniversalGizmoHotkeys : Settings
	{
		// Token: 0x170003DF RID: 991
		// (get) Token: 0x06000BB9 RID: 3001 RVA: 0x00017D88 File Offset: 0x00015F88
		public Hotkeys Enable2DMode
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170003E0 RID: 992
		// (get) Token: 0x06000BBA RID: 3002 RVA: 0x00017D8B File Offset: 0x00015F8B
		public Hotkeys EnableSnapping
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170003E1 RID: 993
		// (get) Token: 0x06000BBB RID: 3003 RVA: 0x00017D8E File Offset: 0x00015F8E
		public Hotkeys EnableVertexSnapping
		{
			get
			{
				return null;
			}
		}

		// Token: 0x04000472 RID: 1138
		private Hotkeys _enable2DMode;

		// Token: 0x04000473 RID: 1139
		private Hotkeys _enableSnapping;

		// Token: 0x04000474 RID: 1140
		private Hotkeys _enableVertexSnapping;
	}
}
