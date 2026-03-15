namespace RLD;

public class PostGizmoTransformsChangedAction : IUndoRedoAction
{
	private List<LocalGizmoTransformSnapshot> _preChangeTransformSnapshots; //Field offset: 0x10
	private List<LocalGizmoTransformSnapshot> _postChangeTransformSnapshots; //Field offset: 0x18

	public PostGizmoTransformsChangedAction(List<LocalGizmoTransformSnapshot> preChangeTransformSnapshots, List<LocalGizmoTransformSnapshot> postChangeTransformSnapshots) { }

	public override void Execute() { }

	public override void OnRemovedFromUndoRedoStack() { }

	public override void Redo() { }

	public override void Undo() { }

}

