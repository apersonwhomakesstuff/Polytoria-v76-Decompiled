using System;

namespace RLD
{
	// Token: 0x020001AE RID: 430
	[Serializable]
	public class SceneGridHotkeys : Settings
	{
		// Token: 0x17000628 RID: 1576
		// (get) Token: 0x0600130E RID: 4878 RVA: 0x0001929E File Offset: 0x0001749E
		public Hotkeys GridUp
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000629 RID: 1577
		// (get) Token: 0x0600130F RID: 4879 RVA: 0x000192A1 File Offset: 0x000174A1
		public Hotkeys GridDown
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700062A RID: 1578
		// (get) Token: 0x06001310 RID: 4880 RVA: 0x000192A4 File Offset: 0x000174A4
		public Hotkeys SnapToCursorPickPoint
		{
			get
			{
				return null;
			}
		}

		// Token: 0x040006CB RID: 1739
		private Hotkeys _gridUp;

		// Token: 0x040006CC RID: 1740
		private Hotkeys _gridDown;

		// Token: 0x040006CD RID: 1741
		private Hotkeys _snapToCursorPickPoint;
	}
}
