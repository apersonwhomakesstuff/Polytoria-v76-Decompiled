namespace RLD;

public class TouchInputDevice : InputDeviceBase
{
	private int _maxNumberOfTouches; //Field offset: 0x30

	public virtual InputDeviceType DeviceType
	{
		 get { } //Length: 6
	}

	public int MaxNumberOfTouches
	{
		 get { } //Length: 174
	}

	public int TouchCount
	{
		 get { } //Length: 7
	}

	public TouchInputDevice(int maxNumberOfTouches) { }

	public virtual InputDeviceType get_DeviceType() { }

	public int get_MaxNumberOfTouches() { }

	public int get_TouchCount() { }

	public virtual Vector3 GetFrameDelta() { }

	public virtual Vector3 GetPositionYAxisUp() { }

	public virtual Ray GetRay(Camera camera) { }

	public virtual bool HasPointer() { }

	public virtual bool IsButtonPressed(int buttonIndex) { }

	protected virtual void UpateFrameDeltas() { }

	public virtual bool WasButtonPressedInCurrentFrame(int buttonIndex) { }

	public virtual bool WasButtonReleasedInCurrentFrame(int buttonIndex) { }

	public virtual bool WasMoved() { }

}

