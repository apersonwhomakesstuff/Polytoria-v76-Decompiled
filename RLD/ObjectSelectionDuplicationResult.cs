namespace RLD;

public class ObjectSelectionDuplicationResult
{
	private List<GameObject> _duplicateParents; //Field offset: 0x10

	public List<GameObject> DuplicateParents
	{
		 get { } //Length: 104
	}

	public int NumDuplicateParents
	{
		 get { } //Length: 60
	}

	public ObjectSelectionDuplicationResult(List<GameObject> duplicatedParents) { }

	public List<GameObject> get_DuplicateParents() { }

	public int get_NumDuplicateParents() { }

	public GameObject GetParentByIndex(int index) { }

}

