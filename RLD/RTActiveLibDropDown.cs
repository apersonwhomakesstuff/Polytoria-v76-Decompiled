namespace RLD;

public class RTActiveLibDropDown : MonoBehaviour
{
	private Dropdown _dropDown; //Field offset: 0x20
	private List<UnityAction`1<Int32>> _valueChangedListeners; //Field offset: 0x28

	public int ActiveLibIndex
	{
		 get { } //Length: 29
	}

	public RTActiveLibDropDown() { }

	public void AddValueChangedListener(UnityAction<Int32> listener) { }

	private void Awake() { }

	public void ClearLibs() { }

	public int get_ActiveLibIndex() { }

	public void SetActiveLibIndex(int activeLibIndex) { }

	public void SyncWithLibDb() { }

}

