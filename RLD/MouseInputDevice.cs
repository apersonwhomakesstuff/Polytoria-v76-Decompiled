namespace RLD;

public class MouseInputDevice : InputDeviceBase
{
	private Vector3 _frameDelta; //Field offset: 0x30
	private Vector3 _mousePosInLastFrame; //Field offset: 0x3C

	public virtual InputDeviceType DeviceType
	{
		 get { } //Length: 3
	}

	public MouseInputDevice() { }

	public virtual InputDeviceType get_DeviceType() { }

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

