namespace RLD;

public class ObjectExtrudeGizmoDragEnd : IUndoRedoAction
{
	private bool _wasExecuted; //Field offset: 0x10
	private bool _destroyClones; //Field offset: 0x11
	private List<GameObject> _targetParents; //Field offset: 0x18
	private List<LocalTransformSnapshot> _undoTargetSnapshots; //Field offset: 0x20
	private List<LocalTransformSnapshot> _redoTargetSnapshots; //Field offset: 0x28
	private List<GameObject> _extrudeClones; //Field offset: 0x30

	public int NumTargets
	{
		 get { } //Length: 60
	}

	public ObjectExtrudeGizmoDragEnd() { }

	public void AddExtrudeClone(GameObject extrudeClone) { }

	public void AddExtrudeClones(List<GameObject> extrudeClones) { }

	public override void Execute() { }

	public int get_NumTargets() { }

	public override void OnRemovedFromUndoRedoStack() { }

	public override void Redo() { }

	public void SetTargetParents(IEnumerable<GameObject> targetParents) { }

	public void TakeRedoTargetSnapshots() { }

	public void TakeUndoTargetSnapshots() { }

	public override void Undo() { }

}

