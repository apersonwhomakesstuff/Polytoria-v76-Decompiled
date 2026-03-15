namespace RLD;

public class ObjectSelectionSettings : Settings
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Predicate<GameObject> <>9__45_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal bool <RemoveNullObjectRefs>b__45_0(GameObject item) { }

	}

	[SerializeField]
	private MultiSelectOverlapMode _multiSelectOverlapMode; //Field offset: 0x28
	[SerializeField]
	private GameObjectType _selectableObjectTypes; //Field offset: 0x2C
	[SerializeField]
	private int _selectableLayers; //Field offset: 0x30
	[SerializeField]
	private int _duplicatableLayers; //Field offset: 0x34
	[SerializeField]
	private int _deletableLayers; //Field offset: 0x38
	private HashSet<GameObject> _nonSelectableObjects; //Field offset: 0x40
	private HashSet<Camera> _nonSelectableCameras; //Field offset: 0x48
	[SerializeField]
	private bool _canClickSelect; //Field offset: 0x50
	[SerializeField]
	private bool _enableCyclicalClickSelect; //Field offset: 0x51
	[SerializeField]
	private bool _canMultiSelect; //Field offset: 0x52
	[SerializeField]
	private int _minMultiSelectSize; //Field offset: 0x54

	public bool CanClickSelect
	{
		 get { } //Length: 5
		 set { } //Length: 4
	}

	public bool CanMultiSelect
	{
		 get { } //Length: 5
		 set { } //Length: 4
	}

	public int DeletableLayers
	{
		 get { } //Length: 4
		 set { } //Length: 4
	}

	public int DuplicatableLayers
	{
		 get { } //Length: 4
		 set { } //Length: 4
	}

	public bool EnableCyclicalClickSelect
	{
		 get { } //Length: 5
		 set { } //Length: 4
	}

	public int MinMultiSelectSize
	{
		 get { } //Length: 4
		 set { } //Length: 16
	}

	public MultiSelectOverlapMode MultiSelectOverlapMode
	{
		 get { } //Length: 4
		 set { } //Length: 4
	}

	public int SelectableLayers
	{
		 get { } //Length: 174
		 set { } //Length: 4
	}

	public ObjectSelectionSettings() { }

	public bool get_CanClickSelect() { }

	public bool get_CanMultiSelect() { }

	public int get_DeletableLayers() { }

	public int get_DuplicatableLayers() { }

	public bool get_EnableCyclicalClickSelect() { }

	public int get_MinMultiSelectSize() { }

	public MultiSelectOverlapMode get_MultiSelectOverlapMode() { }

	public int get_SelectableLayers() { }

	public bool IsCameraSelectable(Camera camera) { }

	public bool IsObjectLayerDeletable(int objectLayer) { }

	public bool IsObjectLayerDuplicatable(int objectLayer) { }

	public bool IsObjectLayerSelectable(int objectLayer) { }

	public bool IsObjectSelectable(GameObject gameObject) { }

	public bool IsObjectTypeSelectable(GameObjectType gameObjectType) { }

	public void RemoveNullObjectRefs() { }

	public void set_CanClickSelect(bool value) { }

	public void set_CanMultiSelect(bool value) { }

	public void set_DeletableLayers(int value) { }

	public void set_DuplicatableLayers(int value) { }

	public void set_EnableCyclicalClickSelect(bool value) { }

	public void set_MinMultiSelectSize(int value) { }

	public void set_MultiSelectOverlapMode(MultiSelectOverlapMode value) { }

	public void set_SelectableLayers(int value) { }

	public void SetCameraCollectionSelectable(List<Camera> cameraCollection, bool areSelectable) { }

	public void SetCameraSelectable(Camera camera, bool isSelectable) { }

	public void SetObjectCollectionSelectable(List<GameObject> gameObjectCollection, bool areSelectable) { }

	public void SetObjectLayerDuplicatable(int objectLayer, bool isDuplicatable) { }

	public void SetObjectLayerSelectable(int objectLayer, bool isSelectable) { }

	public void SetObjectSelectable(GameObject gameObject, bool isSelectable) { }

	public void SetObjectTypeSelectable(GameObjectType gameObjectType, bool isSelectable) { }

}

