namespace RLD;

public class RTObjectSelection : MonoSingleton<RTObjectSelection>
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Predicate<GameObject> <>9__155_0; //Field offset: 0x8
		public static Predicate<GameObject> <>9__155_1; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal bool <RemoveNullAndInactiveObjectRefs>b__155_0(GameObject item) { }

		internal bool <RemoveNullAndInactiveObjectRefs>b__155_1(GameObject item) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass144_0
	{
		public RTObjectSelection <>4__this; //Field offset: 0x10
		public QueryConfig boundsQConfig; //Field offset: 0x18

		public <>c__DisplayClass144_0() { }

		internal bool <PerformMultiSelect>b__0(GameObject item) { }

	}

	private struct CyclicalClickSelectInfo
	{
		public int LastSelectedIndex; //Field offset: 0x0
		public GameObject LastPickedObject; //Field offset: 0x8

	}

	[Flags]
	private enum SelectRestrictFlags : int
	{
		None = 0,
		ObjectLayer = 1,
		ObjectType = 2,
		Object = 4,
		SelectionListener = 8,
		All = 15,
	}

	private static readonly int _objectPickDeviceBtnIndex; //Field offset: 0x0
	[CompilerGenerated]
	private ObjectSelectionManipSessionBeginHandler ManipSessionBegin; //Field offset: 0x20
	[CompilerGenerated]
	private ObjectSelectionManipSessionEndHandler ManipSessionEnd; //Field offset: 0x28
	[CompilerGenerated]
	private ObjectSelectionCanClickSelectDeselectHandler CanClickSelectDeselect; //Field offset: 0x30
	[CompilerGenerated]
	private ObjectSelectionCanMultiSelectDeselectHandler CanMultiSelectDeselect; //Field offset: 0x38
	[CompilerGenerated]
	private ObjectSelectionChangedHandler Changed; //Field offset: 0x40
	[CompilerGenerated]
	private ObjectSelectionWillBeDeletedHandler WillBeDeleted; //Field offset: 0x48
	[CompilerGenerated]
	private ObjectSelectionDeletedHandler Deleted; //Field offset: 0x50
	[CompilerGenerated]
	private ObjectSelectionWillBeDuplicatedHandler WillBeDuplicated; //Field offset: 0x58
	[CompilerGenerated]
	private ObjectSelectionDuplicatedHandler Duplicated; //Field offset: 0x60
	[CompilerGenerated]
	private ObjectSelectionRotatedHandler Rotated; //Field offset: 0x68
	[CompilerGenerated]
	private ObjectSelectionPreSelectCustomizeHandler PreSelectCustomize; //Field offset: 0x70
	[CompilerGenerated]
	private ObjectSelectionPreDeselectCustomizeHandler PreDeselectCustomize; //Field offset: 0x78
	[CompilerGenerated]
	private ObjectSelectionEnabled Enabled; //Field offset: 0x80
	[CompilerGenerated]
	private ObjectSelectionDisabled Disabled; //Field offset: 0x88
	private List<GameObject> _visibleObjectBuffer; //Field offset: 0x90
	private List<GameObject> _overlappedObjectBuffer; //Field offset: 0x98
	private List<GameObjectRayHit> _objectHitBuffer; //Field offset: 0xA0
	[SerializeField]
	private bool _isEnabled; //Field offset: 0xA8
	private List<Camera> _renderIgnoreCameras; //Field offset: 0xB0
	private List<GameObject> _selectedObjects; //Field offset: 0xB8
	private MultiSelectShape _multiSelectShape; //Field offset: 0xC0
	private ObjectSelectionSnapshot _multiSelectPreChangeSnapshot; //Field offset: 0xC8
	private bool _wasSelectionChangedViaMultiSelectShape; //Field offset: 0xD0
	private bool _willBeDeleted; //Field offset: 0xD1
	private bool _doingPreSelectCustomize; //Field offset: 0xD2
	private bool _doingPreDeselectCustomize; //Field offset: 0xD3
	private bool _firingSelectionChanged; //Field offset: 0xD4
	private ObjectSelectionManipSession _activeManipSession; //Field offset: 0xD8
	private CyclicalClickSelectInfo _cyclicalClickSelectInfo; //Field offset: 0xE0
	[SerializeField]
	private ObjectSelectionHotkeys _hotkeys; //Field offset: 0xF0
	[SerializeField]
	private ObjectSelectionSettings _settings; //Field offset: 0xF8
	[SerializeField]
	private ObjectSelectionLookAndFeel _lookAndFeel; //Field offset: 0x100
	[SerializeField]
	private ObjectSelectionRotationSettings _rotationSettings; //Field offset: 0x108
	[SerializeField]
	private ObjectSelectionRotationHotkeys _rotationHotkeys; //Field offset: 0x110
	private DeviceObjectGrabSession _grabSession; //Field offset: 0x118
	[SerializeField]
	private ObjectGrabSettings _grabSettings; //Field offset: 0x120
	[SerializeField]
	private ObjectGrabLookAndFeel _grabLookAndFeel; //Field offset: 0x128
	[SerializeField]
	private ObjectGrabHotkeys _grabHotkeys; //Field offset: 0x130
	private ObjectGridSnapSession _gridSnapSession; //Field offset: 0x138
	[SerializeField]
	private ObjectGridSnapLookAndFeel _gridSnapLookAndFeel; //Field offset: 0x140
	[SerializeField]
	private ObjectGridSnapHotkeys _gridSnapHotkeys; //Field offset: 0x148
	private Object2ObjectSnapSession _object2ObjectSnapSession; //Field offset: 0x150
	[SerializeField]
	private Object2ObjectSnapSettings _object2ObjectSnapSettings; //Field offset: 0x158
	[SerializeField]
	private Object2ObjectSnapHotkeys _object2ObjectSnapHotkeys; //Field offset: 0x160
	[SerializeField]
	private EditorToolbar _settingsToolbar; //Field offset: 0x168

	public event ObjectSelectionCanClickSelectDeselectHandler CanClickSelectDeselect
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public event ObjectSelectionCanMultiSelectDeselectHandler CanMultiSelectDeselect
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public event ObjectSelectionChangedHandler Changed
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public event ObjectSelectionDeletedHandler Deleted
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public event ObjectSelectionDisabled Disabled
	{
		[CompilerGenerated]
		 add { } //Length: 162
		[CompilerGenerated]
		 remove { } //Length: 162
	}

	public event ObjectSelectionDuplicatedHandler Duplicated
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public event ObjectSelectionEnabled Enabled
	{
		[CompilerGenerated]
		 add { } //Length: 162
		[CompilerGenerated]
		 remove { } //Length: 162
	}

	public event ObjectSelectionManipSessionBeginHandler ManipSessionBegin
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public event ObjectSelectionManipSessionEndHandler ManipSessionEnd
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public event ObjectSelectionPreDeselectCustomizeHandler PreDeselectCustomize
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public event ObjectSelectionPreSelectCustomizeHandler PreSelectCustomize
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public event ObjectSelectionRotatedHandler Rotated
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public event ObjectSelectionWillBeDeletedHandler WillBeDeleted
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public event ObjectSelectionWillBeDuplicatedHandler WillBeDuplicated
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public ObjectSelectionManipSession ActiveManipSession
	{
		 get { } //Length: 7
	}

	public ObjectGrabHotkeys GrabHotkeys
	{
		 get { } //Length: 8
	}

	public ObjectGrabLookAndFeel GrabLookAndFeel
	{
		 get { } //Length: 8
	}

	public ObjectGrabSettings GrabSettings
	{
		 get { } //Length: 8
	}

	public ObjectGridSnapHotkeys GridSnapHotkeys
	{
		 get { } //Length: 8
	}

	public ObjectGridSnapLookAndFeel GridSnapLookAndFeel
	{
		 get { } //Length: 8
	}

	public ObjectSelectionHotkeys Hotkeys
	{
		 get { } //Length: 8
	}

	public bool IsEnabled
	{
		 get { } //Length: 8
	}

	public bool IsGrabSessionActive
	{
		 get { } //Length: 11
	}

	public bool IsGridSnapSessionActive
	{
		 get { } //Length: 11
	}

	public bool IsManipSessionActive
	{
		 get { } //Length: 11
	}

	public bool IsMultiSelectShapeVisible
	{
		 get { } //Length: 30
	}

	public bool IsObject2ObjectSnapSessionActive
	{
		 get { } //Length: 11
	}

	public ObjectSelectionLookAndFeel LookAndFeel
	{
		 get { } //Length: 8
	}

	public int NumSelectedObjects
	{
		 get { } //Length: 63
	}

	public Object2ObjectSnapHotkeys Object2ObjectSnapHotkeys
	{
		 get { } //Length: 8
	}

	public Object2ObjectSnapSettings Object2ObjectSnapSettings
	{
		 get { } //Length: 8
	}

	public ObjectSelectionRotationHotkeys RotationHotkeys
	{
		 get { } //Length: 8
	}

	public ObjectSelectionRotationSettings RotationSettings
	{
		 get { } //Length: 8
	}

	public List<GameObject> SelectedObjects
	{
		 get { } //Length: 107
	}

	public ObjectSelectionSettings Settings
	{
		 get { } //Length: 8
	}

	public RTObjectSelection() { }

	[CompilerGenerated]
	public void add_CanClickSelectDeselect(ObjectSelectionCanClickSelectDeselectHandler value) { }

	[CompilerGenerated]
	public void add_CanMultiSelectDeselect(ObjectSelectionCanMultiSelectDeselectHandler value) { }

	[CompilerGenerated]
	public void add_Changed(ObjectSelectionChangedHandler value) { }

	[CompilerGenerated]
	public void add_Deleted(ObjectSelectionDeletedHandler value) { }

	[CompilerGenerated]
	public void add_Disabled(ObjectSelectionDisabled value) { }

	[CompilerGenerated]
	public void add_Duplicated(ObjectSelectionDuplicatedHandler value) { }

	[CompilerGenerated]
	public void add_Enabled(ObjectSelectionEnabled value) { }

	[CompilerGenerated]
	public void add_ManipSessionBegin(ObjectSelectionManipSessionBeginHandler value) { }

	[CompilerGenerated]
	public void add_ManipSessionEnd(ObjectSelectionManipSessionEndHandler value) { }

	[CompilerGenerated]
	public void add_PreDeselectCustomize(ObjectSelectionPreDeselectCustomizeHandler value) { }

	[CompilerGenerated]
	public void add_PreSelectCustomize(ObjectSelectionPreSelectCustomizeHandler value) { }

	[CompilerGenerated]
	public void add_Rotated(ObjectSelectionRotatedHandler value) { }

	[CompilerGenerated]
	public void add_WillBeDeleted(ObjectSelectionWillBeDeletedHandler value) { }

	[CompilerGenerated]
	public void add_WillBeDuplicated(ObjectSelectionWillBeDuplicatedHandler value) { }

	public void AddRenderIgnoreCamera(Camera camera) { }

	public void AppendObjects(List<GameObject> gameObjects, bool allowUndoRedo) { }

	public void AttachGizmoController(IObjectCollectionGizmoController gizmoController) { }

	public bool CanBeDeleted() { }

	public bool CanBeDuplicated() { }

	public bool CanBeModifiedByAPI() { }

	private bool CanSelectObject(GameObject gameObject, SelectRestrictFlags restrictFlags, ObjectSelectReason selectReason) { }

	public void ClearSelection(bool allowUndoRedo) { }

	private void ClearSelection(ObjectDeselectReason deselectReason) { }

	public void Delete() { }

	private void DeselectObject(GameObject gameObject, ObjectDeselectReason deselectReason) { }

	private List<GameObject> DoPreDeselectCustomize(List<GameObject> toBeDeselected, ObjectDeselectReason deselectReason) { }

	private ObjectPreSelectCustomizeInfo DoPreSelectCustomize(List<GameObject> toBeSelected, ObjectSelectReason selectReason) { }

	public ObjectSelectionDuplicationResult Duplicate() { }

	private List<GameObject> FilterByRestrictions(IEnumerable<GameObject> gameObjects, SelectRestrictFlags restrictFlags, ObjectSelectReason selectReason) { }

	private List<GameObjectRayHit> FilterByRestrictions(List<GameObjectRayHit> objectHits, SelectRestrictFlags restrictFlags) { }

	public void ForceDelete() { }

	public ObjectSelectionManipSession get_ActiveManipSession() { }

	public ObjectGrabHotkeys get_GrabHotkeys() { }

	public ObjectGrabLookAndFeel get_GrabLookAndFeel() { }

	public ObjectGrabSettings get_GrabSettings() { }

	public ObjectGridSnapHotkeys get_GridSnapHotkeys() { }

	public ObjectGridSnapLookAndFeel get_GridSnapLookAndFeel() { }

	public ObjectSelectionHotkeys get_Hotkeys() { }

	public bool get_IsEnabled() { }

	public bool get_IsGrabSessionActive() { }

	public bool get_IsGridSnapSessionActive() { }

	public bool get_IsManipSessionActive() { }

	public bool get_IsMultiSelectShapeVisible() { }

	public bool get_IsObject2ObjectSnapSessionActive() { }

	public ObjectSelectionLookAndFeel get_LookAndFeel() { }

	public int get_NumSelectedObjects() { }

	public Object2ObjectSnapHotkeys get_Object2ObjectSnapHotkeys() { }

	public Object2ObjectSnapSettings get_Object2ObjectSnapSettings() { }

	public ObjectSelectionRotationHotkeys get_RotationHotkeys() { }

	public ObjectSelectionRotationSettings get_RotationSettings() { }

	public List<GameObject> get_SelectedObjects() { }

	public ObjectSelectionSettings get_Settings() { }

	public AABB GetWorldAABB() { }

	private void HandleUndoRedo(ObjectSelectionSnapshot undoRedoSnapshot, bool isUndo) { }

	public void Initialize_SystemCall() { }

	public bool IsObjectSelected(GameObject gameObject) { }

	public bool IsRenderIgnoreCamera(Camera camera) { }

	public bool IsSelectionExactMatch(List<GameObject> gameObjectsToMatch) { }

	private void OnGrabSessionBegin() { }

	private void OnGrabSessionEnd() { }

	private void OnGridSnapSessionBegin() { }

	private void OnGridSnapSessionEnd() { }

	private void OnInputDevicePickButtonDown() { }

	private void OnInputDevicePickButtonUp() { }

	private void OnInputDeviceWasMoved() { }

	private void OnObject2ObjectSnapSessionBegin() { }

	private void OnObject2ObjectSnapSessionEnd() { }

	private void OnRedoEnd(IUndoRedoAction action) { }

	private void OnSelectionChanged(ObjectSelectionChangedEventArgs args) { }

	private void OnUndoEnd(IUndoRedoAction action) { }

	private void PerformClickSelect() { }

	private void PerformMultiSelect() { }

	[CompilerGenerated]
	public void remove_CanClickSelectDeselect(ObjectSelectionCanClickSelectDeselectHandler value) { }

	[CompilerGenerated]
	public void remove_CanMultiSelectDeselect(ObjectSelectionCanMultiSelectDeselectHandler value) { }

	[CompilerGenerated]
	public void remove_Changed(ObjectSelectionChangedHandler value) { }

	[CompilerGenerated]
	public void remove_Deleted(ObjectSelectionDeletedHandler value) { }

	[CompilerGenerated]
	public void remove_Disabled(ObjectSelectionDisabled value) { }

	[CompilerGenerated]
	public void remove_Duplicated(ObjectSelectionDuplicatedHandler value) { }

	[CompilerGenerated]
	public void remove_Enabled(ObjectSelectionEnabled value) { }

	[CompilerGenerated]
	public void remove_ManipSessionBegin(ObjectSelectionManipSessionBeginHandler value) { }

	[CompilerGenerated]
	public void remove_ManipSessionEnd(ObjectSelectionManipSessionEndHandler value) { }

	[CompilerGenerated]
	public void remove_PreDeselectCustomize(ObjectSelectionPreDeselectCustomizeHandler value) { }

	[CompilerGenerated]
	public void remove_PreSelectCustomize(ObjectSelectionPreSelectCustomizeHandler value) { }

	[CompilerGenerated]
	public void remove_Rotated(ObjectSelectionRotatedHandler value) { }

	[CompilerGenerated]
	public void remove_WillBeDeleted(ObjectSelectionWillBeDeletedHandler value) { }

	[CompilerGenerated]
	public void remove_WillBeDuplicated(ObjectSelectionWillBeDuplicatedHandler value) { }

	private void RemoveNullAndInactiveObjectRefs() { }

	public void RemoveObjects(List<GameObject> gameObjects, bool allowUndoRedo) { }

	public void RemoveRenderIgnoreCamera(Camera camera) { }

	public void Render_SystemCall(Camera renderCamera) { }

	public void Rotate(Axis axis, float rotationAngle, ObjectRotationPivot rotationPivot) { }

	private void SelectObject(GameObject gameObject, ObjectSelectReason selectReason) { }

	public void SetEnabled(bool isEnabled) { }

	public void SetRotation(Quaternion rotation) { }

	public void SetSelectedObjects(List<GameObject> gameObjects, bool allowUndoRedo) { }

	public void Update_SystemCall() { }

}

