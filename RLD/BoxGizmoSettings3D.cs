namespace RLD;

public class BoxGizmoSettings3D : Settings
{
	[SerializeField]
	private float _xSnapStep; //Field offset: 0x28
	[SerializeField]
	private float _ySnapStep; //Field offset: 0x2C
	[SerializeField]
	private float _zSnapStep; //Field offset: 0x30
	[SerializeField]
	private float _dragSensitivity; //Field offset: 0x34

	public float DragSensitivity
	{
		 get { } //Length: 6
	}

	public float XSnapStep
	{
		 get { } //Length: 6
	}

	public float YSnapStep
	{
		 get { } //Length: 6
	}

	public float ZSnapStep
	{
		 get { } //Length: 6
	}

	public BoxGizmoSettings3D() { }

	public float get_DragSensitivity() { }

	public float get_XSnapStep() { }

	public float get_YSnapStep() { }

	public float get_ZSnapStep() { }

	public void SetDragSensitivity(float sensitivity) { }

	public void SetXSnapStep(float snapStep) { }

	public void SetYSnapStep(float snapStep) { }

	public void SetZSnapStep(float snapStep) { }

}

