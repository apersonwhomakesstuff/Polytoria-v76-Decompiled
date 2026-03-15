namespace RLD;

public interface IGizmoBehaviour
{

	public Gizmo Gizmo
	{
		 get { } //Length: 0
	}

	public bool IsEnabled
	{
		 get { } //Length: 0
	}

	public Gizmo get_Gizmo() { }

	public bool get_IsEnabled() { }

	public void Init_SystemCall(GizmoBehaviorInitParams initParams) { }

	public void OnAttached() { }

	public void OnDetached() { }

	public void OnDisabled() { }

	public void OnEnabled() { }

	public void OnGizmoAttemptHandleDragBegin(int handleId) { }

	public bool OnGizmoCanBeginDrag(int handleId) { }

	public void OnGizmoDisabled() { }

	public void OnGizmoDragBegin(int handleId) { }

	public void OnGizmoDragEnd(int handleId) { }

	public void OnGizmoDragUpdate(int handleId) { }

	public void OnGizmoEnabled() { }

	public void OnGizmoHandlePicked(int handleId) { }

	public void OnGizmoHoverEnter(int handleId) { }

	public void OnGizmoHoverExit(int handleId) { }

	public void OnGizmoRender(Camera camera) { }

	public void OnGizmoUpdateBegin() { }

	public void OnGizmoUpdateEnd() { }

	public void OnGUI() { }

	public void SetEnabled(bool enabled) { }

}

