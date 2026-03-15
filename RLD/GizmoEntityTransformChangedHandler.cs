namespace RLD;

public sealed class GizmoEntityTransformChangedHandler : MulticastDelegate
{

	public GizmoEntityTransformChangedHandler(object object, IntPtr method) { }

	public override IAsyncResult BeginInvoke(GizmoTransform transform, ChangeData changeData, AsyncCallback callback, object object) { }

	public override void EndInvoke(IAsyncResult result) { }

	public override void Invoke(GizmoTransform transform, ChangeData changeData) { }

}

