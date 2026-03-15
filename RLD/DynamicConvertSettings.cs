namespace RLD;

public class DynamicConvertSettings : Settings
{
	private Rect _prefabFolderDropRect; //Field offset: 0x28
	[SerializeField]
	private GameObjectType _convertableObjectTypes; //Field offset: 0x38
	[SerializeField]
	private string _prefabFolder; //Field offset: 0x40
	[SerializeField]
	private bool _processPrefabSubfolders; //Field offset: 0x48

	public GameObjectType ConvertableObjectTypes
	{
		 get { } //Length: 4
		 set { } //Length: 4
	}

	public string PrefabFolder
	{
		 get { } //Length: 5
		 set { } //Length: 19
	}

	public Rect PrefabFolderDropRect
	{
		 get { } //Length: 11
	}

	public bool ProcessPrefabSubfolders
	{
		 get { } //Length: 5
		 set { } //Length: 4
	}

	public DynamicConvertSettings() { }

	public GameObjectType get_ConvertableObjectTypes() { }

	public string get_PrefabFolder() { }

	public Rect get_PrefabFolderDropRect() { }

	public bool get_ProcessPrefabSubfolders() { }

	public void set_ConvertableObjectTypes(GameObjectType value) { }

	public void set_PrefabFolder(string value) { }

	public void set_ProcessPrefabSubfolders(bool value) { }

}

