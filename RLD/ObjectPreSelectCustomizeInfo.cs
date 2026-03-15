namespace RLD;

public class ObjectPreSelectCustomizeInfo
{
	private List<GameObject> _toBeSelected; //Field offset: 0x10
	private ObjectSelectReason _selectRason; //Field offset: 0x18

	public ObjectSelectReason SelectReason
	{
		 get { } //Length: 4
	}

	public List<GameObject> ToBeSelected
	{
		 get { } //Length: 104
	}

	public int ToBeSelectedCount
	{
		 get { } //Length: 60
	}

	public ObjectPreSelectCustomizeInfo(List<GameObject> toBeSelected, ObjectSelectReason selectReason) { }

	public ObjectSelectReason get_SelectReason() { }

	public List<GameObject> get_ToBeSelected() { }

	public int get_ToBeSelectedCount() { }

	public void IgnoreThese(IEnumerable<GameObject> toBeIgnored) { }

	public void SelectThese(IEnumerable<GameObject> toBeSelected) { }

}

