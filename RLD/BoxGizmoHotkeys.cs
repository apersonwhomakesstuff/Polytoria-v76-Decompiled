using System;

namespace RLD
{
	// Token: 0x02000081 RID: 129
	[Serializable]
	public class BoxGizmoHotkeys : Settings
	{
		// Token: 0x170001C2 RID: 450
		// (get) Token: 0x06000597 RID: 1431 RVA: 0x00016B4F File Offset: 0x00014D4F
		public Hotkeys EnableSnapping
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170001C3 RID: 451
		// (get) Token: 0x06000598 RID: 1432 RVA: 0x00016B52 File Offset: 0x00014D52
		public Hotkeys EnableCenterPivot
		{
			get
			{
				return null;
			}
		}

		// Token: 0x040001DF RID: 479
		private Hotkeys _enableSnapping;

		// Token: 0x040001E0 RID: 480
		private Hotkeys _enableCenterPivot;
	}
}
