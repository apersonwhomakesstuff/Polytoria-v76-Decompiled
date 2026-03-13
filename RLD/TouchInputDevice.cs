using System;
using UnityEngine;

namespace RLD
{
	// Token: 0x0200013D RID: 317
	public class TouchInputDevice : InputDeviceBase
	{
		// Token: 0x17000558 RID: 1368
		// (get) Token: 0x06001039 RID: 4153 RVA: 0x000189ED File Offset: 0x00016BED
		public int MaxNumberOfTouches
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x17000559 RID: 1369
		// (get) Token: 0x0600103A RID: 4154 RVA: 0x000189F0 File Offset: 0x00016BF0
		public int TouchCount
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x1700055A RID: 1370
		// (get) Token: 0x0600103B RID: 4155 RVA: 0x00020DFC File Offset: 0x0001EFFC
		public override InputDeviceType DeviceType
		{
			get
			{
				return InputDeviceType.Mouse;
			}
		}

		// Token: 0x0600103C RID: 4156 RVA: 0x000189F3 File Offset: 0x00016BF3
		public TouchInputDevice(int maxNumberOfTouches)
		{
		}

		// Token: 0x0600103D RID: 4157 RVA: 0x00020E14 File Offset: 0x0001F014
		public override Vector3 GetFrameDelta()
		{
			return default(Vector3);
		}

		// Token: 0x0600103E RID: 4158 RVA: 0x00020E2C File Offset: 0x0001F02C
		public override Ray GetRay(Camera camera)
		{
			return default(Ray);
		}

		// Token: 0x0600103F RID: 4159 RVA: 0x00020E44 File Offset: 0x0001F044
		public override Vector3 GetPositionYAxisUp()
		{
			return default(Vector3);
		}

		// Token: 0x06001040 RID: 4160 RVA: 0x000189FB File Offset: 0x00016BFB
		public override bool HasPointer()
		{
			return false;
		}

		// Token: 0x06001041 RID: 4161 RVA: 0x000189FE File Offset: 0x00016BFE
		public override bool IsButtonPressed(int buttonIndex)
		{
			return false;
		}

		// Token: 0x06001042 RID: 4162 RVA: 0x00018A01 File Offset: 0x00016C01
		public override bool WasButtonPressedInCurrentFrame(int buttonIndex)
		{
			return false;
		}

		// Token: 0x06001043 RID: 4163 RVA: 0x00018A04 File Offset: 0x00016C04
		public override bool WasButtonReleasedInCurrentFrame(int buttonIndex)
		{
			return false;
		}

		// Token: 0x06001044 RID: 4164 RVA: 0x00018A07 File Offset: 0x00016C07
		public override bool WasMoved()
		{
			return false;
		}

		// Token: 0x06001045 RID: 4165 RVA: 0x00018A0A File Offset: 0x00016C0A
		protected override void UpateFrameDeltas()
		{
		}

		// Token: 0x04000591 RID: 1425
		private int _maxNumberOfTouches;
	}
}
