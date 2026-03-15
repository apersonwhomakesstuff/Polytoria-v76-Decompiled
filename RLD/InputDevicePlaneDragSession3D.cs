namespace RLD;

public class InputDevicePlaneDragSession3D
{
	private Plane _plane; //Field offset: 0x10
	private Camera _raycastCamera; //Field offset: 0x20
	private Vector3 _dragPoint; //Field offset: 0x28
	private Vector3 _dragDelta; //Field offset: 0x34
	private Vector3 _accumDrag; //Field offset: 0x40
	private IInputDevice _inputDevice; //Field offset: 0x50
	private bool _isActive; //Field offset: 0x58

	public Vector3 AccumDrag
	{
		 get { } //Length: 19
	}

	public Vector3 DragDelta
	{
		 get { } //Length: 19
	}

	public Vector3 DragPoint
	{
		 get { } //Length: 19
	}

	public bool IsActive
	{
		 get { } //Length: 5
	}

	public Plane Plane
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	public Camera RaycastCamera
	{
		 get { } //Length: 5
		 set { } //Length: 20
	}

	public InputDevicePlaneDragSession3D(IInputDevice inputDevice, Camera raycastCamera) { }

	public bool Begin() { }

	public void End() { }

	public Vector3 get_AccumDrag() { }

	public Vector3 get_DragDelta() { }

	public Vector3 get_DragPoint() { }

	public bool get_IsActive() { }

	public Plane get_Plane() { }

	public Camera get_RaycastCamera() { }

	public void set_Plane(Plane value) { }

	public void set_RaycastCamera(Camera value) { }

	public bool Update() { }

	private bool UpdateDragPoint() { }

}

