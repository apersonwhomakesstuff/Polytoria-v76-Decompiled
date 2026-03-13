using System;
using UnityEngine;

namespace RLD
{
	// Token: 0x02000137 RID: 311
	public abstract class InputDeviceBase : IInputDevice
	{
		// Token: 0x14000025 RID: 37
		// (add) Token: 0x0600100D RID: 4109 RVA: 0x0001898C File Offset: 0x00016B8C
		// (remove) Token: 0x0600100E RID: 4110 RVA: 0x0001898E File Offset: 0x00016B8E
		public event InputDeviceDoubleTapHandler DoubleTap
		{
			add
			{
			}
			remove
			{
			}
		}

		// Token: 0x1700054F RID: 1359
		// (get) Token: 0x0600100F RID: 4111 RVA: 0x00018990 File Offset: 0x00016B90
		public bool DidDoubleTap
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000550 RID: 1360
		// (get) Token: 0x06001010 RID: 4112 RVA: 0x00018993 File Offset: 0x00016B93
		// (set) Token: 0x06001011 RID: 4113 RVA: 0x0001899A File Offset: 0x00016B9A
		public float DoubleTapDelay
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x17000551 RID: 1361
		// (get) Token: 0x06001012 RID: 4114
		public abstract InputDeviceType DeviceType { get; }

		// Token: 0x06001013 RID: 4115 RVA: 0x0001899C File Offset: 0x00016B9C
		public InputDeviceBase()
		{
		}

		// Token: 0x06001014 RID: 4116 RVA: 0x000189A4 File Offset: 0x00016BA4
		public void SetMaxNumDeltaCaptures(int maxNumDeltaCaptures)
		{
		}

		// Token: 0x06001015 RID: 4117 RVA: 0x000189A6 File Offset: 0x00016BA6
		public bool CreateDeltaCapture(Vector3 deltaOrigin, out int deltaCaptureId)
		{
			deltaCaptureId = 0;
			return false;
		}

		// Token: 0x06001016 RID: 4118 RVA: 0x000189B0 File Offset: 0x00016BB0
		public void RemoveDeltaCapture(int deltaCaptureId)
		{
		}

		// Token: 0x06001017 RID: 4119 RVA: 0x00020D3C File Offset: 0x0001EF3C
		public Vector3 GetCaptureDelta(int deltaCaptureId)
		{
			return default(Vector3);
		}

		// Token: 0x06001018 RID: 4120
		public abstract Vector3 GetFrameDelta();

		// Token: 0x06001019 RID: 4121
		public abstract Ray GetRay(Camera camera);

		// Token: 0x0600101A RID: 4122
		public abstract Vector3 GetPositionYAxisUp();

		// Token: 0x0600101B RID: 4123
		public abstract bool HasPointer();

		// Token: 0x0600101C RID: 4124
		public abstract bool IsButtonPressed(int buttonIndex);

		// Token: 0x0600101D RID: 4125
		public abstract bool WasButtonPressedInCurrentFrame(int buttonIndex);

		// Token: 0x0600101E RID: 4126
		public abstract bool WasButtonReleasedInCurrentFrame(int buttonIndex);

		// Token: 0x0600101F RID: 4127
		public abstract bool WasMoved();

		// Token: 0x06001020 RID: 4128 RVA: 0x000189B2 File Offset: 0x00016BB2
		public void Update()
		{
		}

		// Token: 0x06001021 RID: 4129
		protected abstract void UpateFrameDeltas();

		// Token: 0x06001022 RID: 4130 RVA: 0x000189B4 File Offset: 0x00016BB4
		private void UpdateDeltaCaptures()
		{
		}

		// Token: 0x06001023 RID: 4131 RVA: 0x000189B6 File Offset: 0x00016BB6
		private void DetectAndHandleDoubleTap()
		{
		}

		// Token: 0x0400057D RID: 1405
		private float _doubleTapDelay;

		// Token: 0x0400057E RID: 1406
		private float _lastTapTime;

		// Token: 0x0400057F RID: 1407
		private bool _didDoubleTap;

		// Token: 0x04000580 RID: 1408
		private int _maxNumDeltaCaptures;

		// Token: 0x04000581 RID: 1409
		private InputDeviceDeltaCapture[] _deltaCaptures;
	}
}
