using System;

namespace RLD
{
	// Token: 0x020000E7 RID: 231
	[Serializable]
	public class ScaleGizmoHotkeys : Settings
	{
		// Token: 0x1700039D RID: 925
		// (get) Token: 0x06000AF5 RID: 2805 RVA: 0x00017B14 File Offset: 0x00015D14
		public Hotkeys EnableSnapping
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700039E RID: 926
		// (get) Token: 0x06000AF6 RID: 2806 RVA: 0x00017B17 File Offset: 0x00015D17
		public Hotkeys ChangeMultiAxisMode
		{
			get
			{
				return null;
			}
		}

		// Token: 0x04000437 RID: 1079
		private Hotkeys _enableSnapping;

		// Token: 0x04000438 RID: 1080
		private Hotkeys _changeMultiAxisMode;
	}
}
