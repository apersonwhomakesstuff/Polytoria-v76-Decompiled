namespace RLD;

public class GizmoDblAxisScaleDrag3D : GizmoPlaneDrag3D
{
	internal struct WorkData
	{
		public int AxisIndex0; //Field offset: 0x0
		public int AxisIndex1; //Field offset: 0x4
		public Vector3 DragOrigin; //Field offset: 0x8
		public Vector3 Axis0; //Field offset: 0x14
		public Vector3 Axis1; //Field offset: 0x20
		public float SnapStep; //Field offset: 0x2C

	}

	private WorkData _workData; //Field offset: 0x78
	private float _accumSnapDrag0; //Field offset: 0xA8
	private float _accumSnapDrag1; //Field offset: 0xAC
	private float _scale0; //Field offset: 0xB0
	private float _scale1; //Field offset: 0xB4
	private float _relativeScale0; //Field offset: 0xB8
	private float _relativeScale1; //Field offset: 0xBC
	private float _totalScale0; //Field offset: 0xC0
	private float _totalScale1; //Field offset: 0xC4
	private Vector3 _scaleDragAxis; //Field offset: 0xC8

	public int AxisIndex0
	{
		 get { } //Length: 4
	}

	public int AxisIndex1
	{
		 get { } //Length: 4
	}

	public virtual GizmoDragChannel DragChannel
	{
		 get { } //Length: 6
	}

	public float RelativeScale0
	{
		 get { } //Length: 9
	}

	public float RelativeScale1
	{
		 get { } //Length: 9
	}

	public float TotalScale0
	{
		 get { } //Length: 9
	}

	public float TotalScale1
	{
		 get { } //Length: 9
	}

	public GizmoDblAxisScaleDrag3D() { }

	protected virtual Plane CalculateDragPlane() { }

	protected virtual void CalculateDragValues() { }

	public int get_AxisIndex0() { }

	public int get_AxisIndex1() { }

	public virtual GizmoDragChannel get_DragChannel() { }

	public float get_RelativeScale0() { }

	public float get_RelativeScale1() { }

	public float get_TotalScale0() { }

	public float get_TotalScale1() { }

	protected virtual void OnSessionEnd() { }

	public void SetWorkData(WorkData workData) { }

}

