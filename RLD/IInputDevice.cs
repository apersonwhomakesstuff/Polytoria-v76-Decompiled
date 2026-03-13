using System;
using UnityEngine;

namespace RLD
{
	// Token: 0x02000136 RID: 310
	public interface IInputDevice
	{
		// Token: 0x14000024 RID: 36
		// (add) Token: 0x06000FFB RID: 4091
		// (remove) Token: 0x06000FFC RID: 4092
		event InputDeviceDoubleTapHandler DoubleTap;

		// Token: 0x1700054C RID: 1356
		// (get) Token: 0x06000FFD RID: 4093
		bool DidDoubleTap { get; }

		// Token: 0x1700054D RID: 1357
		// (get) Token: 0x06000FFE RID: 4094
		// (set) Token: 0x06000FFF RID: 4095
		float DoubleTapDelay { get; set; }

		// Token: 0x1700054E RID: 1358
		// (get) Token: 0x06001000 RID: 4096
		InputDeviceType DeviceType { get; }

		// Token: 0x06001001 RID: 4097
		Ray GetRay(Camera camera);

		// Token: 0x06001002 RID: 4098
		Vector3 GetPositionYAxisUp();

		// Token: 0x06001003 RID: 4099
		bool HasPointer();

		// Token: 0x06001004 RID: 4100
		bool IsButtonPressed(int buttonIndex);

		// Token: 0x06001005 RID: 4101
		bool WasButtonPressedInCurrentFrame(int buttonIndex);

		// Token: 0x06001006 RID: 4102
		bool WasButtonReleasedInCurrentFrame(int buttonIndex);

		// Token: 0x06001007 RID: 4103
		bool WasMoved();

		// Token: 0x06001008 RID: 4104
		bool CreateDeltaCapture(Vector3 deltaOrigin, out int deltaCaptureId);

		// Token: 0x06001009 RID: 4105
		void RemoveDeltaCapture(int deltaCaptureId);

		// Token: 0x0600100A RID: 4106
		Vector3 GetCaptureDelta(int deltaCaptureId);

		// Token: 0x0600100B RID: 4107
		Vector3 GetFrameDelta();

		// Token: 0x0600100C RID: 4108
		void Update();
	}
}
