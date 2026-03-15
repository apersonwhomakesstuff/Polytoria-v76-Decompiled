namespace RLD;

public sealed class CanUndoRedoHandler : MulticastDelegate
{

	public CanUndoRedoHandler(object object, IntPtr method) { }

	public override IAsyncResult BeginInvoke(UndoRedoOpType undoRedoOpType, YesNoAnswer answer, AsyncCallback callback, object object) { }

	public override void EndInvoke(IAsyncResult result) { }

	public override void Invoke(UndoRedoOpType undoRedoOpType, YesNoAnswer answer) { }

}

