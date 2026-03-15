namespace RLD;

public class GizmoSglAxisScaleDrag3D : GizmoPlaneDrag3D
{
	internal struct WorkData
	{
		public int AxisIndex; //Field offset: 0x0
		public Vector3 DragOrigin; //Field offset: 0x4
		public Vector3 Axis; //Field offset: 0x10
		public float SnapStep; //Field offset: 0x1C
		public float EntityScale; //Field offset: 0x20

	}

	private float _accumSnapDrag; //Field offset: 0x78
	private WorkData _workData; //Field offset: 0x7C
	private float _scale; //Field offset: 0xA0
	private float _relativeScale; //Field offset: 0xA4
	private float _totalScale; //Field offset: 0xA8

	public int AxisIndex
	{
		 get { } //Length: 4
	}

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

	public GizmoSglAxisScaleDrag3D() { }

	protected virtual Plane CalculateDragPlane() { }

	protected virtual void CalculateDragValues() { }

	public int get_AxisIndex() { }

	public virtual GizmoDragChannel get_DragChannel() { }

	public float get_RelativeScale() { }

	public float get_TotalScale() { }

	protected virtual void OnSessionEnd() { }

	public void SetWorkData(WorkData workData) { }

}

