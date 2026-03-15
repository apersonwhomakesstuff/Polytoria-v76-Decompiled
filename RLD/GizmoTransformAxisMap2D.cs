namespace RLD;

public class GizmoTransformAxisMap2D
{
	private Vector2 _freeAxis; //Field offset: 0x10
	private AxisDescriptor _mappedAxisDesc; //Field offset: 0x18
	private GizmoTransform _transform; //Field offset: 0x20

	public Vector2 Axis
	{
		 get { } //Length: 157
	}

	public bool IsMapped
	{
		 get { } //Length: 9
	}

	public AxisDescriptor MappedAxisDesc
	{
		 get { } //Length: 5
	}

	public int MappedAxisIndex
	{
		 get { } //Length: 26
	}

	public AxisSign MappedAxisSign
	{
		 get { } //Length: 26
	}

	public GizmoTransform Transform
	{
		 get { } //Length: 5
	}

	public GizmoTransformAxisMap2D() { }

	public Vector2 get_Axis() { }

	public bool get_IsMapped() { }

	public AxisDescriptor get_MappedAxisDesc() { }

	public int get_MappedAxisIndex() { }

	public AxisSign get_MappedAxisSign() { }

	public GizmoTransform get_Transform() { }

	public void Map(GizmoTransform transform, int axisIndex, AxisSign axisSign) { }

	public void SetAxis(Vector2 axis) { }

	public void SetFreeAxis(Vector2 axis) { }

	public void SetMappedAxis(Vector2 axis) { }

	public void Unmap() { }

}

