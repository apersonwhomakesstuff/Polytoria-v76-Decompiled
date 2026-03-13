using System;
using UnityEngine;

namespace RLD
{
	// Token: 0x0200013B RID: 315
	public class MouseInputDevice : InputDeviceBase
	{
		// Token: 0x17000555 RID: 1365
		// (get) Token: 0x06001029 RID: 4137 RVA: 0x00020D84 File Offset: 0x0001EF84
		public override InputDeviceType DeviceType
		{
			get
			{
				return InputDeviceType.Mouse;
			}
		}

		// Token: 0x0600102B RID: 4139 RVA: 0x00020D9C File Offset: 0x0001EF9C
		public override Vector3 GetFrameDelta()
		{
			return default(Vector3);
		}

		// Token: 0x0600102C RID: 4140 RVA: 0x00020DB4 File Offset: 0x0001EFB4
		public override Ray GetRay(Camera camera)
		{
			return default(Ray);
		}

		// Token: 0x0600102D RID: 4141 RVA: 0x00020DCC File Offset: 0x0001EFCC
		public override Vector3 GetPositionYAxisUp()
		{
			return default(Vector3);
		}

		// Token: 0x0600102E RID: 4142 RVA: 0x000189CD File Offset: 0x00016BCD
		public override bool HasPointer()
		{
			return false;
		}

		// Token: 0x0600102F RID: 4143 RVA: 0x000189D0 File Offset: 0x00016BD0
		public override bool IsButtonPressed(int buttonIndex)
		{
			return false;
		}

		// Token: 0x06001030 RID: 4144 RVA: 0x000189D3 File Offset: 0x00016BD3
		public override bool WasButtonPressedInCurrentFrame(int buttonIndex)
		{
			return false;
		}

		// Token: 0x06001031 RID: 4145 RVA: 0x000189D6 File Offset: 0x00016BD6
		public override bool WasButtonReleasedInCurrentFrame(int buttonIndex)
		{
			return false;
		}

		// Token: 0x06001032 RID: 4146 RVA: 0x000189D9 File Offset: 0x00016BD9
		public override bool WasMoved()
		{
			return false;
		}

		// Token: 0x06001033 RID: 4147 RVA: 0x000189DC File Offset: 0x00016BDC
		protected override void UpateFrameDeltas()
		{
		}

		// Token: 0x0400058E RID: 1422
		private Vector3 _frameDelta;

		// Token: 0x0400058F RID: 1423
		private Vector3 _mousePosInLastFrame;
	}
}
