namespace RLD;

public sealed class ObjectSelectionPreSelectCustomizeHandler : MulticastDelegate
{

	public ObjectSelectionPreSelectCustomizeHandler(object object, IntPtr method) { }

	public override IAsyncResult BeginInvoke(ObjectPreSelectCustomizeInfo customizeInfo, List<GameObject> toBeSelected, AsyncCallback callback, object object) { }

	public override void EndInvoke(IAsyncResult result) { }

	public override void Invoke(ObjectPreSelectCustomizeInfo customizeInfo, List<GameObject> toBeSelected) { }

}

