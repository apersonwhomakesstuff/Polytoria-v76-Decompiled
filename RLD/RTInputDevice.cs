using System;

namespace RLD
{
	// Token: 0x0200013C RID: 316
	public class RTInputDevice : MonoSingleton<RTInputDevice>
	{
		// Token: 0x17000556 RID: 1366
		// (get) Token: 0x06001034 RID: 4148 RVA: 0x000189DE File Offset: 0x00016BDE
		public IInputDevice Device
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000557 RID: 1367
		// (get) Token: 0x06001035 RID: 4149 RVA: 0x00020DE4 File Offset: 0x0001EFE4
		public InputDeviceType DeviceType
		{
			get
			{
				return InputDeviceType.Mouse;
			}
		}

		// Token: 0x06001036 RID: 4150 RVA: 0x000189E1 File Offset: 0x00016BE1
		public void Update_SystemCall()
		{
		}

		// Token: 0x06001037 RID: 4151 RVA: 0x000189E3 File Offset: 0x00016BE3
		private void Awake()
		{
		}

		// Token: 0x04000590 RID: 1424
		private IInputDevice _inputDevice;
	}
}
