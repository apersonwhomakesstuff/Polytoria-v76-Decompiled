namespace RLD;

public class ObjectSelectionChangedEventArgs
{
	private ObjectSelectReason _selectReason; //Field offset: 0x10
	private List<GameObject> _objectsWhichWereSelected; //Field offset: 0x18
	private ObjectDeselectReason _deselectReason; //Field offset: 0x20
	private List<GameObject> _objectsWhichWereDeselected; //Field offset: 0x28
	private ObjectSelectionSnapshot _undoRedoSnapshot; //Field offset: 0x30

	public ObjectDeselectReason DeselectReason
	{
		 get { } //Length: 4
	}

	public int NumObjectsDeselected
	{
		 get { } //Length: 60
	}

	public int NumObjectsSelected
	{
		 get { } //Length: 60
	}

	public List<GameObject> ObjectsWhichWereDeselected
	{
		 get { } //Length: 104
	}

	public List<GameObject> ObjectsWhichWereSelected
	{
		 get { } //Length: 104
	}

	public ObjectSelectReason SelectReason
	{
		 get { } //Length: 4
	}

	public ObjectSelectionSnapshot UndoRedoSnapshot
	{
		 get { } //Length: 95
	}

	public ObjectSelectionChangedEventArgs(ObjectSelectReason selectReason, List<GameObject> objectsWhichWereSelected, ObjectDeselectReason deselectReason, List<GameObject> objectsWhichWereDeselected, ObjectSelectionSnapshot undoRedoSnapshot = null) { }

	public ObjectDeselectReason get_DeselectReason() { }

	public int get_NumObjectsDeselected() { }

	public int get_NumObjectsSelected() { }

	public List<GameObject> get_ObjectsWhichWereDeselected() { }

	public List<GameObject> get_ObjectsWhichWereSelected() { }

	public ObjectSelectReason get_SelectReason() { }

	public ObjectSelectionSnapshot get_UndoRedoSnapshot() { }

}

