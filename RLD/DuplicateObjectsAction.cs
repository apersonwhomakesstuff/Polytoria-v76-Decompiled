namespace RLD;

public class DuplicateObjectsAction : IUndoRedoAction
{
	private List<GameObject> _rootsToDuplicate; //Field offset: 0x10
	private List<GameObject> _duplicateResult; //Field offset: 0x18
	private bool _cleanupOnRemovedFromStack; //Field offset: 0x20

	public List<GameObject> DuplicateResult
	{
		 get { } //Length: 104
	}

	public DuplicateObjectsAction(List<GameObject> rootsToDuplicate) { }

	public override void Execute() { }

	public List<GameObject> get_DuplicateResult() { }

	public override void OnRemovedFromUndoRedoStack() { }

	public override void Redo() { }

	public override void Undo() { }

}

