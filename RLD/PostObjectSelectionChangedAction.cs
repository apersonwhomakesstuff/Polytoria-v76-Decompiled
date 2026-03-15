namespace RLD;

public class PostObjectSelectionChangedAction : IUndoRedoAction
{
	private ObjectSelectionSnapshot _preChangeSnapshot; //Field offset: 0x10
	private ObjectSelectionSnapshot _postChangeSnapshot; //Field offset: 0x18

	public ObjectSelectionSnapshot PostChangeSnapshot
	{
		 get { } //Length: 5
	}

	public ObjectSelectionSnapshot PreChangeSnapshot
	{
		 get { } //Length: 5
	}

	public PostObjectSelectionChangedAction(ObjectSelectionSnapshot preChangeSnapshot, ObjectSelectionSnapshot postChangeSnapshot) { }

	public override void Execute() { }

	public ObjectSelectionSnapshot get_PostChangeSnapshot() { }

	public ObjectSelectionSnapshot get_PreChangeSnapshot() { }

	public override void OnRemovedFromUndoRedoStack() { }

	public override void Redo() { }

	public override void Undo() { }

}

