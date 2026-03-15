namespace RLD;

public interface IUndoRedoAction
{

	public void Execute() { }

	public void OnRemovedFromUndoRedoStack() { }

	public void Redo() { }

	public void Undo() { }

}

