namespace RLD;

public class PostObjectTransformsChangedAction : IUndoRedoAction
{
	private List<LocalTransformSnapshot> _preChangeTransformSnapshots; //Field offset: 0x10
	private List<LocalTransformSnapshot> _postChangeTransformSnapshots; //Field offset: 0x18

	public PostObjectTransformsChangedAction(List<LocalTransformSnapshot> preChangeTransformSnapshots, List<LocalTransformSnapshot> postChangeTransformSnapshots) { }

	public override void Execute() { }

	public override void OnRemovedFromUndoRedoStack() { }

	public override void Redo() { }

	public override void Undo() { }

}

