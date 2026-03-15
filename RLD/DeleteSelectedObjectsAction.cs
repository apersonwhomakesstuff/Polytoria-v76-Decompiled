namespace RLD;

public class DeleteSelectedObjectsAction : IUndoRedoAction
{
	private List<GameObject> _selectedObjects; //Field offset: 0x10
	private List<GameObject> _deletedObjects; //Field offset: 0x18
	private ObjectSelectionSnapshot _preDeleteSnapshot; //Field offset: 0x20
	private ObjectSelectionSnapshot _postDeleteSnapshot; //Field offset: 0x28
	private bool _canDestroyObjects; //Field offset: 0x30

	public ObjectSelectionSnapshot PostDeleteSnapshot
	{
		 get { } //Length: 5
	}

	public ObjectSelectionSnapshot PreDeleteSnapshot
	{
		 get { } //Length: 5
	}

	public DeleteSelectedObjectsAction(List<GameObject> selectedObjects, ObjectSelectionSnapshot preDeleteSnapshot) { }

	public override void Execute() { }

	public ObjectSelectionSnapshot get_PostDeleteSnapshot() { }

	public ObjectSelectionSnapshot get_PreDeleteSnapshot() { }

	public override void OnRemovedFromUndoRedoStack() { }

	public override void Redo() { }

	public override void Undo() { }

}

