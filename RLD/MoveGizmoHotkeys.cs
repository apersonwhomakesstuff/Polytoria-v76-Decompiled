using System;

namespace RLD
{
	// Token: 0x020000DB RID: 219
	[Serializable]
	public class MoveGizmoHotkeys : Settings
	{
		// Token: 0x170002F2 RID: 754
		// (get) Token: 0x06000933 RID: 2355 RVA: 0x0001760C File Offset: 0x0001580C
		public Hotkeys Enable2DMode
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170002F3 RID: 755
		// (get) Token: 0x06000934 RID: 2356 RVA: 0x0001760F File Offset: 0x0001580F
		public Hotkeys EnableSnapping
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170002F4 RID: 756
		// (get) Token: 0x06000935 RID: 2357 RVA: 0x00017612 File Offset: 0x00015812
		public Hotkeys EnableVertexSnapping
		{
			get
			{
				return null;
			}
		}

		// Token: 0x040003DC RID: 988
		private Hotkeys _enable2DMode;

		// Token: 0x040003DD RID: 989
		private Hotkeys _enableSnapping;

		// Token: 0x040003DE RID: 990
		private Hotkeys _enableVertexSnapping;
	}
}
