namespace RLD;

public class GizmoTransformAxisMap3D
{
	private Vector3 _freeAxis; //Field offset: 0x10
	private AxisDescriptor _mappedAxisDesc; //Field offset: 0x20
	private GizmoTransform _transform; //Field offset: 0x28

	public Vector3 Axis
	{
		 get { } //Length: 214
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

	public GizmoTransformAxisMap3D() { }

	public Vector3 get_Axis() { }

	public bool get_IsMapped() { }

	public AxisDescriptor get_MappedAxisDesc() { }

	public int get_MappedAxisIndex() { }

	public AxisSign get_MappedAxisSign() { }

	public GizmoTransform get_Transform() { }

	public void Map(GizmoTransform transform, int axisIndex, AxisSign axisSign) { }

	public void SetAxis(Vector3 axis) { }

	public void SetFreeAxis(Vector3 axis) { }

	public void SetMappedAxis(Vector3 axis) { }

	public void Unmap() { }

}

