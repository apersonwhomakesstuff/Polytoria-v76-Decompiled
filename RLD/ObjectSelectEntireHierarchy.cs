namespace RLD;

public class ObjectSelectEntireHierarchy : Singleton<ObjectSelectEntireHierarchy>
{
	private bool _isActive; //Field offset: 0x10
	private bool _ignoreObjectGroups; //Field offset: 0x11

	public bool IgnoreObjectGroups
	{
		 get { } //Length: 5
		 set { } //Length: 4
	}

	public ObjectSelectEntireHierarchy() { }

	public bool get_IgnoreObjectGroups() { }

	private Transform GetFurthestParentNotGroup(GameObject gameObj) { }

	private void OnPreDeselectCustomize(ObjectPreDeselectCustomizeInfo customizeInfo, List<GameObject> toBeDeselected) { }

	private void OnPreSelectCustomize(ObjectPreSelectCustomizeInfo customizeInfo, List<GameObject> toBeSelected) { }

	public void set_IgnoreObjectGroups(bool value) { }

	public void SetActive(bool isActive) { }

}

