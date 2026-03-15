namespace RLD;

public class PostObjectSpawnAction : IUndoRedoAction
{
	private bool _cleanupOnRemovedFromStack; //Field offset: 0x10
	private List<GameObject> _spawnedParents; //Field offset: 0x18

	public PostObjectSpawnAction(List<GameObject> spawnedParents) { }

	public override void Execute() { }

	public override void OnRemovedFromUndoRedoStack() { }

	public override void Redo() { }

	public override void Undo() { }

}

