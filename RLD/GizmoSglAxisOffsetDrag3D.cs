namespace RLD;

public class GizmoSglAxisOffsetDrag3D : GizmoPlaneDrag3D
{
	internal struct WorkData
	{
		public Vector3 DragOrigin; //Field offset: 0x0
		public Vector3 Axis; //Field offset: 0xC
		public float SnapStep; //Field offset: 0x18

	}

	private float _accumSnapDrag; //Field offset: 0x78
	private WorkData _workData; //Field offset: 0x7C

	public Vector3 Axis
	{
		 get { } //Length: 25
	}

	public virtual GizmoDragChannel DragChannel
	{
		 get { } //Length: 6
	}

	public GizmoSglAxisOffsetDrag3D() { }

	protected virtual Plane CalculateDragPlane() { }

	protected virtual void CalculateDragValues() { }

	public Vector3 get_Axis() { }

	public virtual GizmoDragChannel get_DragChannel() { }

	protected virtual void OnSessionEnd() { }

	public void SetWorkData(WorkData workData) { }

}

