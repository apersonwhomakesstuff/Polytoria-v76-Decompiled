namespace RLD;

public class GizmoSglAxisRotationDrag3D : GizmoScreenDrag
{
	internal struct WorkData
	{
		public Vector3 RotationPlanePos; //Field offset: 0x0
		public Vector3 Axis; //Field offset: 0xC
		public GizmoSnapMode SnapMode; //Field offset: 0x18
		public float SnapStep; //Field offset: 0x1C

	}

	private float _accumSnapDrag; //Field offset: 0x78
	private Plane _rotationPlane; //Field offset: 0x7C
	private Vector3 _screenDragCircleTangent; //Field offset: 0x8C
	private WorkData _workData; //Field offset: 0x98
	private bool _adjustRotationForAbsSnap; //Field offset: 0xB8
	private float _relativeRotation; //Field offset: 0xBC
	private float _totalRotation; //Field offset: 0xC0

	public virtual GizmoDragChannel DragChannel
	{
		 get { } //Length: 6
	}

	public float RelativeRotation
	{
		 get { } //Length: 9
	}

	public Plane RotationPlane
	{
		 get { } //Length: 11
	}

	public float TotalRotation
	{
		 get { } //Length: 9
	}

	public GizmoSglAxisRotationDrag3D() { }

	protected virtual void CalculateDragValues() { }

	public virtual GizmoDragChannel get_DragChannel() { }

	public float get_RelativeRotation() { }

	public Plane get_RotationPlane() { }

	public float get_TotalRotation() { }

	protected virtual void OnSessionBegin() { }

	protected virtual void OnSessionEnd() { }

	public void SetWorkData(WorkData workData) { }

}

