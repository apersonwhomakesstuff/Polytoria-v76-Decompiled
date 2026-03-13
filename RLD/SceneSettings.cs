using System;

namespace RLD
{
	// Token: 0x020001BE RID: 446
	[Serializable]
	public class SceneSettings : Settings
	{
		// Token: 0x1700065A RID: 1626
		// (get) Token: 0x06001380 RID: 4992 RVA: 0x00021C44 File Offset: 0x0001FE44
		// (set) Token: 0x06001381 RID: 4993 RVA: 0x00019405 File Offset: 0x00017605
		public ScenePhysicsMode PhysicsMode
		{
			get
			{
				return (ScenePhysicsMode)0;
			}
			set
			{
			}
		}

		// Token: 0x1700065B RID: 1627
		// (get) Token: 0x06001382 RID: 4994 RVA: 0x00019407 File Offset: 0x00017607
		// (set) Token: 0x06001383 RID: 4995 RVA: 0x0001940E File Offset: 0x0001760E
		public float NoVolumeObjectSize
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x0400070A RID: 1802
		private ScenePhysicsMode _physicsMode;

		// Token: 0x0400070B RID: 1803
		private float _noVolumeObjectSize;
	}
}
