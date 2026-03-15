namespace RLD;

public sealed class RedoEndHandler : MulticastDelegate
{

	public RedoEndHandler(object object, IntPtr method) { }

	public override IAsyncResult BeginInvoke(IUndoRedoAction action, AsyncCallback callback, object object) { }

	public override void EndInvoke(IAsyncResult result) { }

	public override void Invoke(IUndoRedoAction action) { }

}

