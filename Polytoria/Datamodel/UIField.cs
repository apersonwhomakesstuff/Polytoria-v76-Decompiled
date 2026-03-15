namespace Polytoria.Datamodel;

[Instantiatable]
public class UIField : Instance, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler, IPointerDownHandler, IPointerUpHandler
{
	public LuaEvent MouseUp; //Field offset: 0xF8
	public LuaEvent MouseDown; //Field offset: 0x100
	[SyncVar(hook = "SyncSetPositionOffset")]
	private Vector2 positionOffset; //Field offset: 0x108
	[SyncVar(hook = "SyncSetSizeOffset")]
	private Vector2 sizeOffset; //Field offset: 0x110
	[SyncVar(hook = "SyncSetPositionRelative")]
	private Vector2 positionRelative; //Field offset: 0x118
	[SyncVar(hook = "SyncSetSizeRelative")]
	private Vector2 sizeRelative; //Field offset: 0x120
	[SyncVar(hook = "SyncSetRotation")]
	private float rotation; //Field offset: 0x128
	[SyncVar(hook = "SyncSetPivotPoint")]
	private Vector2 pivotPoint; //Field offset: 0x12C
	[SyncVar(hook = "SyncSetVisible")]
	private bool visible; //Field offset: 0x134
	[SyncVar(hook = "SyncSetClipDescendants")]
	private bool clipDescendants; //Field offset: 0x135
	private RectTransform parentRect; //Field offset: 0x138
	private RectTransform recttransform; //Field offset: 0x140
	private SoftMask mask; //Field offset: 0x148
	private bool hasHVLayoutParent; //Field offset: 0x150
	public Action<Vector2, Vector2> _Mirror_SyncVarHookDelegate_positionOffset; //Field offset: 0x158
	public Action<Vector2, Vector2> _Mirror_SyncVarHookDelegate_sizeOffset; //Field offset: 0x160
	public Action<Vector2, Vector2> _Mirror_SyncVarHookDelegate_positionRelative; //Field offset: 0x168
	public Action<Vector2, Vector2> _Mirror_SyncVarHookDelegate_sizeRelative; //Field offset: 0x170
	public Action<Single, Single> _Mirror_SyncVarHookDelegate_rotation; //Field offset: 0x178
	public Action<Vector2, Vector2> _Mirror_SyncVarHookDelegate_pivotPoint; //Field offset: 0x180
	public Action<Boolean, Boolean> _Mirror_SyncVarHookDelegate_visible; //Field offset: 0x188
	public Action<Boolean, Boolean> _Mirror_SyncVarHookDelegate_clipDescendants; //Field offset: 0x190

	[Archivable]
	[CreatorProperty]
	public bool ClipDescendants
	{
		 get { } //Length: 8
		 set { } //Length: 219
	}

	public bool NetworkclipDescendants
	{
		 get { } //Length: 8
		 set { } //Length: 104
	}

	public Vector2 NetworkpivotPoint
	{
		 get { } //Length: 25
		 set { } //Length: 108
	}

	public Vector2 NetworkpositionOffset
	{
		 get { } //Length: 25
		 set { } //Length: 108
	}

	public Vector2 NetworkpositionRelative
	{
		 get { } //Length: 25
		 set { } //Length: 108
	}

	public float Networkrotation
	{
		 get { } //Length: 9
		 set { } //Length: 104
	}

	public Vector2 NetworksizeOffset
	{
		 get { } //Length: 25
		 set { } //Length: 108
	}

	public Vector2 NetworksizeRelative
	{
		 get { } //Length: 25
		 set { } //Length: 108
	}

	public bool Networkvisible
	{
		 get { } //Length: 8
		 set { } //Length: 104
	}

	[Archivable]
	[CreatorProperty]
	public Vector2 PivotPoint
	{
		 get { } //Length: 39
		 set { } //Length: 149
	}

	[Archivable]
	[CreatorProperty]
	public Vector2 PositionOffset
	{
		 get { } //Length: 25
		 set { } //Length: 108
	}

	[Archivable]
	[CreatorProperty]
	public Vector2 PositionRelative
	{
		 get { } //Length: 25
		 set { } //Length: 108
	}

	[Archivable]
	[CreatorProperty]
	public float Rotation
	{
		 get { } //Length: 47
		 set { } //Length: 169
	}

	[Archivable]
	[CreatorProperty]
	public Vector2 SizeOffset
	{
		 get { } //Length: 25
		 set { } //Length: 108
	}

	[Archivable]
	[CreatorProperty]
	public Vector2 SizeRelative
	{
		 get { } //Length: 25
		 set { } //Length: 108
	}

	[Archivable]
	[CreatorProperty]
	public bool Visible
	{
		 get { } //Length: 8
		 set { } //Length: 122
	}

	public UIField() { }

	[CompilerGenerated]
	private void <Awake>b__46_0() { }

	protected virtual void Awake() { }

	protected virtual void CopyProperties(Instance clone) { }

	public virtual void DeserializeSyncVars(NetworkReader reader, bool initialState) { }

	public bool get_ClipDescendants() { }

	public bool get_NetworkclipDescendants() { }

	public Vector2 get_NetworkpivotPoint() { }

	public Vector2 get_NetworkpositionOffset() { }

	public Vector2 get_NetworkpositionRelative() { }

	public float get_Networkrotation() { }

	public Vector2 get_NetworksizeOffset() { }

	public Vector2 get_NetworksizeRelative() { }

	public bool get_Networkvisible() { }

	public Vector2 get_PivotPoint() { }

	public Vector2 get_PositionOffset() { }

	public Vector2 get_PositionRelative() { }

	public float get_Rotation() { }

	public Vector2 get_SizeOffset() { }

	public Vector2 get_SizeRelative() { }

	public bool get_Visible() { }

	protected virtual void OnHide() { }

	public override void OnPointerDown(PointerEventData eventData) { }

	public override void OnPointerEnter(PointerEventData eventData) { }

	public override void OnPointerExit(PointerEventData eventData) { }

	public override void OnPointerUp(PointerEventData eventData) { }

	protected virtual void OnShow() { }

	public virtual void SerializeSyncVars(NetworkWriter writer, bool forceAll) { }

	public void set_ClipDescendants(bool value) { }

	public void set_NetworkclipDescendants(in bool value) { }

	public void set_NetworkpivotPoint(in Vector2 value) { }

	public void set_NetworkpositionOffset(in Vector2 value) { }

	public void set_NetworkpositionRelative(in Vector2 value) { }

	public void set_Networkrotation(in float value) { }

	public void set_NetworksizeOffset(in Vector2 value) { }

	public void set_NetworksizeRelative(in Vector2 value) { }

	public void set_Networkvisible(in bool value) { }

	public void set_PivotPoint(Vector2 value) { }

	public void set_PositionOffset(Vector2 value) { }

	public void set_PositionRelative(Vector2 value) { }

	public void set_Rotation(float value) { }

	public void set_SizeOffset(Vector2 value) { }

	public void set_SizeRelative(Vector2 value) { }

	public void set_Visible(bool value) { }

	protected virtual void Start() { }

	private void SyncSetClipDescendants(bool oldValue, bool newValue) { }

	private void SyncSetPivotPoint(Vector2 oldValue, Vector2 newValue) { }

	private void SyncSetPositionOffset(Vector2 oldValue, Vector2 newValue) { }

	private void SyncSetPositionRelative(Vector2 oldValue, Vector2 newValue) { }

	private void SyncSetRotation(float oldValue, float newValue) { }

	private void SyncSetSizeOffset(Vector2 oldValue, Vector2 newValue) { }

	private void SyncSetSizeRelative(Vector2 oldValue, Vector2 newValue) { }

	private void SyncSetVisible(bool oldValue, bool newValue) { }

	private void Update() { }

	private void UpdateVisibility() { }

	public virtual bool Weaved() { }

}

