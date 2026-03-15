namespace RLD;

public class GizmoDblAxisRotationDrag3D : GizmoScreenDrag
{
	internal struct WorkData
	{
		public Vector2 ScreenAxis0; //Field offset: 0x0
		public Vector2 ScreenAxis1; //Field offset: 0x8
		public Vector3 Axis0; //Field offset: 0x10
		public Vector3 Axis1; //Field offset: 0x1C
		public GizmoSnapMode SnapMode; //Field offset: 0x28
		public float SnapStep0; //Field offset: 0x2C
		public float SnapStep1; //Field offset: 0x30

	}

	private WorkData _workData; //Field offset: 0x78
	private bool _adjustRotationForAbsSnap; //Field offset: 0xAC
	private float _accumSnapDrag0; //Field offset: 0xB0
	private float _accumSnapDrag1; //Field offset: 0xB4
	private float _relativeRotation0; //Field offset: 0xB8
	private float _relativeRotation1; //Field offset: 0xBC
	private float _totalRotation0; //Field offset: 0xC0
	private float _totalRotation1; //Field offset: 0xC4

	public virtual GizmoDragChannel DragChannel
	{
		 get { } //Length: 6
	}

	public float RelativeRotation0
	{
		 get { } //Length: 9
	}

	public float RelativeRotation1
	{
		 get { } //Length: 9
	}

	public float TotalRotation0
	{
		 get { } //Length: 9
	}

	public float TotalRotation1
	{
		 get { } //Length: 9
	}

	public GizmoDblAxisRotationDrag3D() { }

	protected virtual void CalculateDragValues() { }

	public virtual GizmoDragChannel get_DragChannel() { }

	public float get_RelativeRotation0() { }

	public float get_RelativeRotation1() { }

	public float get_TotalRotation0() { }

	public float get_TotalRotation1() { }

	protected virtual void OnSessionEnd() { }

	public void SetWorkData(WorkData workData) { }

}

