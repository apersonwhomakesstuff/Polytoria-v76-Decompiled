namespace RLD;

public interface IInputDevice
{

	public event InputDeviceDoubleTapHandler DoubleTap
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public InputDeviceType DeviceType
	{
		 get { } //Length: 0
	}

	public bool DidDoubleTap
	{
		 get { } //Length: 0
	}

	public float DoubleTapDelay
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	[CompilerGenerated]
	public void add_DoubleTap(InputDeviceDoubleTapHandler value) { }

	public bool CreateDeltaCapture(Vector3 deltaOrigin, out int deltaCaptureId) { }

	public InputDeviceType get_DeviceType() { }

	public bool get_DidDoubleTap() { }

	public float get_DoubleTapDelay() { }

	public Vector3 GetCaptureDelta(int deltaCaptureId) { }

	public Vector3 GetFrameDelta() { }

	public Vector3 GetPositionYAxisUp() { }

	public Ray GetRay(Camera camera) { }

	public bool HasPointer() { }

	public bool IsButtonPressed(int buttonIndex) { }

	[CompilerGenerated]
	public void remove_DoubleTap(InputDeviceDoubleTapHandler value) { }

	public void RemoveDeltaCapture(int deltaCaptureId) { }

	public void set_DoubleTapDelay(float value) { }

	public void Update() { }

	public bool WasButtonPressedInCurrentFrame(int buttonIndex) { }

	public bool WasButtonReleasedInCurrentFrame(int buttonIndex) { }

	public bool WasMoved() { }

}

