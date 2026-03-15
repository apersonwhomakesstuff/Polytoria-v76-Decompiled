namespace RLD;

public class InputDeviceScreenDragSession
{
	private Vector2 _dragPoint; //Field offset: 0x10
	private Vector2 _dragDelta; //Field offset: 0x18
	private Vector2 _accumDrag; //Field offset: 0x20
	private IInputDevice _inputDevice; //Field offset: 0x28
	private bool _isActive; //Field offset: 0x30

	public Vector2 AccumDrag
	{
		 get { } //Length: 19
	}

	public Vector2 DragDelta
	{
		 get { } //Length: 19
	}

	public Vector2 DragPoint
	{
		 get { } //Length: 19
	}

	public bool IsActive
	{
		 get { } //Length: 5
	}

	public InputDeviceScreenDragSession(IInputDevice inputDevice) { }

	public bool Begin() { }

	public void End() { }

	public Vector2 get_AccumDrag() { }

	public Vector2 get_DragDelta() { }

	public Vector2 get_DragPoint() { }

	public bool get_IsActive() { }

	public bool Update() { }

	private bool UpdateDragPoint() { }

}

