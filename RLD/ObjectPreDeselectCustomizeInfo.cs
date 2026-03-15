namespace RLD;

public class ObjectPreDeselectCustomizeInfo
{
	private List<GameObject> _toBeDeselected; //Field offset: 0x10
	private ObjectDeselectReason _deselectReason; //Field offset: 0x18

	public ObjectDeselectReason DeselectReason
	{
		 get { } //Length: 4
	}

	public List<GameObject> ToBeDeselected
	{
		 get { } //Length: 104
	}

	public int ToBeDeselectedCount
	{
		 get { } //Length: 60
	}

	public ObjectPreDeselectCustomizeInfo(List<GameObject> toBeDeselected, ObjectDeselectReason deselectReason) { }

	public void DeselectThese(IEnumerable<GameObject> toBeDeselected) { }

	public ObjectDeselectReason get_DeselectReason() { }

	public List<GameObject> get_ToBeDeselected() { }

	public int get_ToBeDeselectedCount() { }

	public void IgnoreThese(IEnumerable<GameObject> toBeIgnored) { }

}

