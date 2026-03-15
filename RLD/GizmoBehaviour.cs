namespace RLD;

public abstract class GizmoBehaviour : IGizmoBehaviour
{
	protected Gizmo _gizmo; //Field offset: 0x10
	protected bool _isEnabled; //Field offset: 0x18

	public override Gizmo Gizmo
	{
		 get { } //Length: 5
	}

	public override bool IsEnabled
	{
		 get { } //Length: 5
	}

	protected GizmoBehaviour() { }

	protected void CheckRequiredBehaviours(List<Type> reqBehaviourTypes) { }

	public override Gizmo get_Gizmo() { }

	public override bool get_IsEnabled() { }

	public override void Init_SystemCall(GizmoBehaviorInitParams initParams) { }

	public override void OnAttached() { }

	public override void OnDetached() { }

	public override void OnDisabled() { }

	public override void OnEnabled() { }

	public override void OnGizmoAttemptHandleDragBegin(int handleId) { }

	public override bool OnGizmoCanBeginDrag(int handleId) { }

	public override void OnGizmoDisabled() { }

	public override void OnGizmoDragBegin(int handleId) { }

	public override void OnGizmoDragEnd(int handleId) { }

	public override void OnGizmoDragUpdate(int handleId) { }

	public override void OnGizmoEnabled() { }

	public override void OnGizmoHandlePicked(int handleId) { }

	public override void OnGizmoHoverEnter(int handleId) { }

	public override void OnGizmoHoverExit(int handleId) { }

	public override void OnGizmoRender(Camera camera) { }

	public override void OnGizmoUpdateBegin() { }

	public override void OnGizmoUpdateEnd() { }

	public override void OnGUI() { }

	public override void SetEnabled(bool enabled) { }

	private void ThrowReqBehaviourExeception(Type reqBehaviorType) { }

}

