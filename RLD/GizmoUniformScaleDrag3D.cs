namespace RLD;

public class GizmoUniformScaleDrag3D : GizmoPlaneDrag3D
{
	internal struct WorkData
	{
		public Vector3 CameraRight; //Field offset: 0x0
		public Vector3 CameraUp; //Field offset: 0xC
		public Vector3 DragOrigin; //Field offset: 0x18
		public float SnapStep; //Field offset: 0x24

	}

	private WorkData _workData; //Field offset: 0x78
	private Vector3 _planeAxis0; //Field offset: 0xA0
	private Vector3 _planeAxis1; //Field offset: 0xAC
	private float _accumSnapDrag; //Field offset: 0xB8
	private float _scale; //Field offset: 0xBC
	private float _relativeScale; //Field offset: 0xC0
	private float _totalScale; //Field offset: 0xC4
	private Vector3 _scaleDragAxis; //Field offset: 0xC8

	public virtual GizmoDragChannel DragChannel
	{
		 get { } //Length: 6
	}

	public float RelativeScale
	{
		 get { } //Length: 9
	}

	public float TotalScale
	{
		 get { } //Length: 9
	}

	public GizmoUniformScaleDrag3D() { }

	protected virtual Plane CalculateDragPlane() { }

	protected virtual void CalculateDragValues() { }

	public virtual GizmoDragChannel get_DragChannel() { }

	public float get_RelativeScale() { }

	public float get_TotalScale() { }

	protected virtual void OnSessionEnd() { }

	public void SetWorkData(WorkData workData) { }

}

