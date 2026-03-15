namespace RLD;

public abstract class InputDeviceBase : IInputDevice
{
	[CompilerGenerated]
	private InputDeviceDoubleTapHandler DoubleTap; //Field offset: 0x10
	private float _doubleTapDelay; //Field offset: 0x18
	private float _lastTapTime; //Field offset: 0x1C
	private bool _didDoubleTap; //Field offset: 0x20
	private int _maxNumDeltaCaptures; //Field offset: 0x24
	private InputDeviceDeltaCapture[] _deltaCaptures; //Field offset: 0x28

	public override event InputDeviceDoubleTapHandler DoubleTap
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public abstract InputDeviceType DeviceType
	{
		 get { } //Length: 0
	}

	public override bool DidDoubleTap
	{
		 get { } //Length: 5
	}

	public override float DoubleTapDelay
	{
		 get { } //Length: 6
		 set { } //Length: 15
	}

	public InputDeviceBase() { }

	[CompilerGenerated]
	public override void add_DoubleTap(InputDeviceDoubleTapHandler value) { }

	public override bool CreateDeltaCapture(Vector3 deltaOrigin, out int deltaCaptureId) { }

	private void DetectAndHandleDoubleTap() { }

	public abstract InputDeviceType get_DeviceType() { }

	public override bool get_DidDoubleTap() { }

	public override float get_DoubleTapDelay() { }

	public override Vector3 GetCaptureDelta(int deltaCaptureId) { }

	public abstract Vector3 GetFrameDelta() { }

	public abstract Vector3 GetPositionYAxisUp() { }

	public abstract Ray GetRay(Camera camera) { }

	public abstract bool HasPointer() { }

	public abstract bool IsButtonPressed(int buttonIndex) { }

	[CompilerGenerated]
	public override void remove_DoubleTap(InputDeviceDoubleTapHandler value) { }

	public override void RemoveDeltaCapture(int deltaCaptureId) { }

	public override void set_DoubleTapDelay(float value) { }

	public void SetMaxNumDeltaCaptures(int maxNumDeltaCaptures) { }

	protected abstract void UpateFrameDeltas() { }

	public override void Update() { }

	private void UpdateDeltaCaptures() { }

	public abstract bool WasButtonPressedInCurrentFrame(int buttonIndex) { }

	public abstract bool WasButtonReleasedInCurrentFrame(int buttonIndex) { }

	public abstract bool WasMoved() { }

}

