namespace RLD;

public class GizmoDblAxisOffsetDrag3D : GizmoPlaneDrag3D
{
	internal struct WorkData
	{
		public Vector3 DragOrigin; //Field offset: 0x0
		public Vector3 Axis0; //Field offset: 0xC
		public Vector3 Axis1; //Field offset: 0x18
		public float SnapStep0; //Field offset: 0x24
		public float SnapStep1; //Field offset: 0x28

	}

	private float _accumSnapDrag0; //Field offset: 0x78
	private float _accumSnapDrag1; //Field offset: 0x7C
	private WorkData _workData; //Field offset: 0x80

	public virtual GizmoDragChannel DragChannel
	{
		 get { } //Length: 6
	}

	public GizmoDblAxisOffsetDrag3D() { }

	protected virtual Plane CalculateDragPlane() { }

	protected virtual void CalculateDragValues() { }

	public virtual GizmoDragChannel get_DragChannel() { }

	protected virtual void OnSessionEnd() { }

	public void SetWorkData(WorkData workData) { }

}

