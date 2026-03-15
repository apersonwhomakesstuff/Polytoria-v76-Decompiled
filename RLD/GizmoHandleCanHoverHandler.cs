namespace RLD;

public sealed class GizmoHandleCanHoverHandler : MulticastDelegate
{

	public GizmoHandleCanHoverHandler(object object, IntPtr method) { }

	public override IAsyncResult BeginInvoke(int handleId, Gizmo ownerGizmo, GizmoHandleHoverData handleHoverData, YesNoAnswer answer, AsyncCallback callback, object object) { }

	public override void EndInvoke(IAsyncResult result) { }

	public override void Invoke(int handleId, Gizmo ownerGizmo, GizmoHandleHoverData handleHoverData, YesNoAnswer answer) { }

}

