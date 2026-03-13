using System;

namespace RLD
{
	// Token: 0x0200010C RID: 268
	[Serializable]
	public class CameraSettings : Settings
	{
		// Token: 0x170004E8 RID: 1256
		// (get) Token: 0x06000E3B RID: 3643 RVA: 0x0001850D File Offset: 0x0001670D
		// (set) Token: 0x06000E3C RID: 3644 RVA: 0x00018510 File Offset: 0x00016710
		public bool CanProcessInput
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x04000509 RID: 1289
		private bool _canProcessInput;
	}
}
