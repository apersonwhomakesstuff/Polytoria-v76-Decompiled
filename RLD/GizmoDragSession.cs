namespace RLD;

public abstract class GizmoDragSession : IGizmoDragSession
{
	private List<GizmoTransform> _targetTransforms; //Field offset: 0x10
	protected Vector3 _totalDragOffset; //Field offset: 0x18
	protected Quaternion _totalDragRotation; //Field offset: 0x24
	protected Vector3 _totalDragScale; //Field offset: 0x34
	protected Vector3 _relativeDragOffset; //Field offset: 0x40
	protected Quaternion _relativeDragRotation; //Field offset: 0x4C
	protected Vector3 _relativeDragScale; //Field offset: 0x5C

	public abstract GizmoDragChannel DragChannel
	{
		 get { } //Length: 0
	}

	public abstract bool IsActive
	{
		 get { } //Length: 0
	}

	public int NumTargetTransforms
	{
		 get { } //Length: 60
	}

	public override Vector3 RelativeDragOffset
	{
		 get { } //Length: 19
	}

	public override Quaternion RelativeDragRotation
	{
		 get { } //Length: 11
	}

	public override Vector3 RelativeDragScale
	{
		 get { } //Length: 19
	}

	public override Vector3 TotalDragOffset
	{
		 get { } //Length: 19
	}

	public override Quaternion TotalDragRotation
	{
		 get { } //Length: 11
	}

	public override Vector3 TotalDragScale
	{
		 get { } //Length: 19
	}

	protected GizmoDragSession() { }

	public override void AddTargetTransform(GizmoTransform transform) { }

	protected void ApplyDrag() { }

	public override bool Begin() { }

	protected abstract void CalculateDragValues() { }

	protected override bool CanBegin() { }

	public override bool ContainsTargetTransform(GizmoTransform transform) { }

	protected abstract bool DoBeginSession() { }

	protected abstract void DoEndSession() { }

	protected abstract bool DoUpdateSession() { }

	public override void End() { }

	public abstract GizmoDragChannel get_DragChannel() { }

	public abstract bool get_IsActive() { }

	public int get_NumTargetTransforms() { }

	public override Vector3 get_RelativeDragOffset() { }

	public override Quaternion get_RelativeDragRotation() { }

	public override Vector3 get_RelativeDragScale() { }

	public override Vector3 get_TotalDragOffset() { }

	public override Quaternion get_TotalDragRotation() { }

	public override Vector3 get_TotalDragScale() { }

	protected override void OnSessionBegin() { }

	protected override void OnSessionEnd() { }

	public override void RemoveTargetTransform(GizmoTransform transform) { }

	public override bool Update() { }

}

