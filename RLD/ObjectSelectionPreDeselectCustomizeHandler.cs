namespace RLD;

public sealed class ObjectSelectionPreDeselectCustomizeHandler : MulticastDelegate
{

	public ObjectSelectionPreDeselectCustomizeHandler(object object, IntPtr method) { }

	public override IAsyncResult BeginInvoke(ObjectPreDeselectCustomizeInfo customizeInfo, List<GameObject> toBeDeselected, AsyncCallback callback, object object) { }

	public override void EndInvoke(IAsyncResult result) { }

	public override void Invoke(ObjectPreDeselectCustomizeInfo customizeInfo, List<GameObject> toBeDeselected) { }

}

