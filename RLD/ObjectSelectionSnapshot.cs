namespace RLD;

public class ObjectSelectionSnapshot
{
	private List<GameObject> _snapshotObjects; //Field offset: 0x10
	private ObjectSelectionGizmosSnapshot _gizmosSnapshot; //Field offset: 0x18

	public ObjectSelectionGizmosSnapshot GizmosSnapshot
	{
		 get { } //Length: 111
	}

	public int NumObjects
	{
		 get { } //Length: 60
	}

	public List<GameObject> SnapshotObjects
	{
		 get { } //Length: 104
	}

	public ObjectSelectionSnapshot() { }

	public ObjectSelectionSnapshot(ObjectSelectionSnapshot copy) { }

	public ObjectSelectionGizmosSnapshot get_GizmosSnapshot() { }

	public int get_NumObjects() { }

	public List<GameObject> get_SnapshotObjects() { }

	public void Snapshot() { }

}

