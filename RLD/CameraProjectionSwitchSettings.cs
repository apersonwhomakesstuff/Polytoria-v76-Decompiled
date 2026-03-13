using System;

namespace RLD
{
	// Token: 0x02000109 RID: 265
	[Serializable]
	public class CameraProjectionSwitchSettings : Settings
	{
		// Token: 0x170004E3 RID: 1251
		// (get) Token: 0x06000E2E RID: 3630 RVA: 0x000204CC File Offset: 0x0001E6CC
		// (set) Token: 0x06000E2F RID: 3631 RVA: 0x000184DC File Offset: 0x000166DC
		public CameraProjectionSwitchMode SwitchMode
		{
			get
			{
				return CameraProjectionSwitchMode.Transition;
			}
			set
			{
			}
		}

		// Token: 0x170004E4 RID: 1252
		// (get) Token: 0x06000E30 RID: 3632 RVA: 0x000184DE File Offset: 0x000166DE
		// (set) Token: 0x06000E31 RID: 3633 RVA: 0x000184E5 File Offset: 0x000166E5
		public float TransitionDurationInSeconds
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x040004FF RID: 1279
		private CameraProjectionSwitchMode _switchMode;

		// Token: 0x04000500 RID: 1280
		private float _transitionDurationInSeconds;
	}
}
