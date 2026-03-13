using System;

namespace RLD
{
	// Token: 0x0200010B RID: 267
	[Serializable]
	public class CameraRotationSwitchSettings : Settings
	{
		// Token: 0x170004E5 RID: 1253
		// (get) Token: 0x06000E33 RID: 3635 RVA: 0x000204E4 File Offset: 0x0001E6E4
		// (set) Token: 0x06000E34 RID: 3636 RVA: 0x000184EF File Offset: 0x000166EF
		public CameraRotationSwitchMode SwitchMode
		{
			get
			{
				return CameraRotationSwitchMode.Constant;
			}
			set
			{
			}
		}

		// Token: 0x170004E6 RID: 1254
		// (get) Token: 0x06000E35 RID: 3637 RVA: 0x000184F1 File Offset: 0x000166F1
		// (set) Token: 0x06000E36 RID: 3638 RVA: 0x000184F8 File Offset: 0x000166F8
		public float ConstantSwitchDurationInSeconds
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x170004E7 RID: 1255
		// (get) Token: 0x06000E37 RID: 3639 RVA: 0x000184FA File Offset: 0x000166FA
		// (set) Token: 0x06000E38 RID: 3640 RVA: 0x00018501 File Offset: 0x00016701
		public float SmoothValue
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x04000505 RID: 1285
		private static readonly float _minConstantDuration;

		// Token: 0x04000506 RID: 1286
		private CameraRotationSwitchMode _switchMode;

		// Token: 0x04000507 RID: 1287
		private float _constantSwitchDurationInSeconds;

		// Token: 0x04000508 RID: 1288
		private float _smoothValue;
	}
}
