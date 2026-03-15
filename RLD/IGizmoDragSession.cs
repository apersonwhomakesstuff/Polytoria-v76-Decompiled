namespace RLD;

public interface IGizmoDragSession
{

	public GizmoDragChannel DragChannel
	{
		 get { } //Length: 0
	}

	public bool IsActive
	{
		 get { } //Length: 0
	}

	public Vector3 RelativeDragOffset
	{
		 get { } //Length: 0
	}

	public Quaternion RelativeDragRotation
	{
		 get { } //Length: 0
	}

	public Vector3 RelativeDragScale
	{
		 get { } //Length: 0
	}

	public Vector3 TotalDragOffset
	{
		 get { } //Length: 0
	}

	public Quaternion TotalDragRotation
	{
		 get { } //Length: 0
	}

	public Vector3 TotalDragScale
	{
		 get { } //Length: 0
	}

	public void AddTargetTransform(GizmoTransform transform) { }

	public bool Begin() { }

	public bool ContainsTargetTransform(GizmoTransform transform) { }

	public void End() { }

	public GizmoDragChannel get_DragChannel() { }

	public bool get_IsActive() { }

	public Vector3 get_RelativeDragOffset() { }

	public Quaternion get_RelativeDragRotation() { }

	public Vector3 get_RelativeDragScale() { }

	public Vector3 get_TotalDragOffset() { }

	public Quaternion get_TotalDragRotation() { }

	public Vector3 get_TotalDragScale() { }

	public void RemoveTargetTransform(GizmoTransform transform) { }

	public bool Update() { }

}

