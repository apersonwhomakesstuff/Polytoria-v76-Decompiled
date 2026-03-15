namespace Polytoria.Datamodel;

public class UIHVLayout : UIField
{
	protected HorizontalOrVerticalLayoutGroup layoutGroup; //Field offset: 0x198
	[SyncVar(hook = "SyncSpacing")]
	protected float spacing; //Field offset: 0x1A0
	[SyncVar(hook = "SyncChildControlWidth")]
	protected bool childControlWidth; //Field offset: 0x1A4
	[SyncVar(hook = "SyncChildControlHeight")]
	protected bool childControlHeight; //Field offset: 0x1A5
	[SyncVar(hook = "SyncChildScaleWidth")]
	protected bool childScaleWidth; //Field offset: 0x1A6
	[SyncVar(hook = "SyncChildScaleHeight")]
	protected bool childScaleHeight; //Field offset: 0x1A7
	[SyncVar(hook = "SyncChildForceExpandWidth")]
	protected bool childForceExpandWidth; //Field offset: 0x1A8
	[SyncVar(hook = "SyncChildForceExpandHeight")]
	protected bool childForceExpandHeight; //Field offset: 0x1A9
	[SyncVar(hook = "SyncPaddingLeft")]
	protected int paddingLeft; //Field offset: 0x1AC
	[SyncVar(hook = "SyncPaddingRight")]
	protected int paddingRight; //Field offset: 0x1B0
	[SyncVar(hook = "SyncPaddingTop")]
	protected int paddingTop; //Field offset: 0x1B4
	[SyncVar(hook = "SyncPaddingBottom")]
	protected int paddingBottom; //Field offset: 0x1B8
	[SyncVar(hook = "SyncChildAlignment")]
	protected TextAnchor childAlignment; //Field offset: 0x1BC
	[SyncVar(hook = "SyncReverseAlignment")]
	protected bool reverseAlignment; //Field offset: 0x1C0
	public Action<Single, Single> _Mirror_SyncVarHookDelegate_spacing; //Field offset: 0x1C8
	public Action<Boolean, Boolean> _Mirror_SyncVarHookDelegate_childControlWidth; //Field offset: 0x1D0
	public Action<Boolean, Boolean> _Mirror_SyncVarHookDelegate_childControlHeight; //Field offset: 0x1D8
	public Action<Boolean, Boolean> _Mirror_SyncVarHookDelegate_childScaleWidth; //Field offset: 0x1E0
	public Action<Boolean, Boolean> _Mirror_SyncVarHookDelegate_childScaleHeight; //Field offset: 0x1E8
	public Action<Boolean, Boolean> _Mirror_SyncVarHookDelegate_childForceExpandWidth; //Field offset: 0x1F0
	public Action<Boolean, Boolean> _Mirror_SyncVarHookDelegate_childForceExpandHeight; //Field offset: 0x1F8
	public Action<Int32, Int32> _Mirror_SyncVarHookDelegate_paddingLeft; //Field offset: 0x200
	public Action<Int32, Int32> _Mirror_SyncVarHookDelegate_paddingRight; //Field offset: 0x208
	public Action<Int32, Int32> _Mirror_SyncVarHookDelegate_paddingTop; //Field offset: 0x210
	public Action<Int32, Int32> _Mirror_SyncVarHookDelegate_paddingBottom; //Field offset: 0x218
	public Action<TextAnchor, TextAnchor> _Mirror_SyncVarHookDelegate_childAlignment; //Field offset: 0x220
	public Action<Boolean, Boolean> _Mirror_SyncVarHookDelegate_reverseAlignment; //Field offset: 0x228

	[Archivable]
	[CreatorProperty]
	public TextAnchor ChildAlignment
	{
		 get { } //Length: 7
		 set { } //Length: 127
	}

	[Archivable]
	[CreatorProperty]
	public bool ChildControlHeight
	{
		 get { } //Length: 8
		 set { } //Length: 132
	}

	[Archivable]
	[CreatorProperty]
	public bool ChildControlWidth
	{
		 get { } //Length: 8
		 set { } //Length: 132
	}

	[Archivable]
	[CreatorProperty]
	public bool ChildForceExpandHeight
	{
		 get { } //Length: 8
		 set { } //Length: 132
	}

	[Archivable]
	[CreatorProperty]
	public bool ChildForceExpandWidth
	{
		 get { } //Length: 8
		 set { } //Length: 132
	}

	[Archivable]
	[CreatorProperty]
	public bool ChildScaleHeight
	{
		 get { } //Length: 8
		 set { } //Length: 132
	}

	[Archivable]
	[CreatorProperty]
	public bool ChildScaleWidth
	{
		 get { } //Length: 8
		 set { } //Length: 132
	}

	public TextAnchor NetworkchildAlignment
	{
		 get { } //Length: 7
		 set { } //Length: 101
	}

	public bool NetworkchildControlHeight
	{
		 get { } //Length: 8
		 set { } //Length: 104
	}

	public bool NetworkchildControlWidth
	{
		 get { } //Length: 8
		 set { } //Length: 104
	}

	public bool NetworkchildForceExpandHeight
	{
		 get { } //Length: 8
		 set { } //Length: 104
	}

	public bool NetworkchildForceExpandWidth
	{
		 get { } //Length: 8
		 set { } //Length: 104
	}

	public bool NetworkchildScaleHeight
	{
		 get { } //Length: 8
		 set { } //Length: 104
	}

	public bool NetworkchildScaleWidth
	{
		 get { } //Length: 8
		 set { } //Length: 104
	}

	public int NetworkpaddingBottom
	{
		 get { } //Length: 7
		 set { } //Length: 101
	}

	public int NetworkpaddingLeft
	{
		 get { } //Length: 7
		 set { } //Length: 101
	}

	public int NetworkpaddingRight
	{
		 get { } //Length: 7
		 set { } //Length: 101
	}

	public int NetworkpaddingTop
	{
		 get { } //Length: 7
		 set { } //Length: 101
	}

	public bool NetworkreverseAlignment
	{
		 get { } //Length: 8
		 set { } //Length: 104
	}

	public float Networkspacing
	{
		 get { } //Length: 9
		 set { } //Length: 104
	}

	[Archivable]
	[CreatorProperty]
	public int PaddingBottom
	{
		 get { } //Length: 7
		 set { } //Length: 136
	}

	[Archivable]
	[CreatorProperty]
	public int PaddingLeft
	{
		 get { } //Length: 7
		 set { } //Length: 136
	}

	[Archivable]
	[CreatorProperty]
	public int PaddingRight
	{
		 get { } //Length: 7
		 set { } //Length: 136
	}

	[Archivable]
	[CreatorProperty]
	public int PaddingTop
	{
		 get { } //Length: 7
		 set { } //Length: 136
	}

	[Archivable]
	[CreatorProperty]
	public bool ReverseAlignment
	{
		 get { } //Length: 8
		 set { } //Length: 132
	}

	[Archivable]
	[CreatorProperty]
	public float Spacing
	{
		 get { } //Length: 9
		 set { } //Length: 131
	}

	public UIHVLayout() { }

	protected virtual void CopyProperties(Instance clone) { }

	public virtual void DeserializeSyncVars(NetworkReader reader, bool initialState) { }

	public TextAnchor get_ChildAlignment() { }

	public bool get_ChildControlHeight() { }

	public bool get_ChildControlWidth() { }

	public bool get_ChildForceExpandHeight() { }

	public bool get_ChildForceExpandWidth() { }

	public bool get_ChildScaleHeight() { }

	public bool get_ChildScaleWidth() { }

	public TextAnchor get_NetworkchildAlignment() { }

	public bool get_NetworkchildControlHeight() { }

	public bool get_NetworkchildControlWidth() { }

	public bool get_NetworkchildForceExpandHeight() { }

	public bool get_NetworkchildForceExpandWidth() { }

	public bool get_NetworkchildScaleHeight() { }

	public bool get_NetworkchildScaleWidth() { }

	public int get_NetworkpaddingBottom() { }

	public int get_NetworkpaddingLeft() { }

	public int get_NetworkpaddingRight() { }

	public int get_NetworkpaddingTop() { }

	public bool get_NetworkreverseAlignment() { }

	public float get_Networkspacing() { }

	public int get_PaddingBottom() { }

	public int get_PaddingLeft() { }

	public int get_PaddingRight() { }

	public int get_PaddingTop() { }

	public bool get_ReverseAlignment() { }

	public float get_Spacing() { }

	private void LateUpdate() { }

	public virtual void SerializeSyncVars(NetworkWriter writer, bool forceAll) { }

	public void set_ChildAlignment(TextAnchor value) { }

	public void set_ChildControlHeight(bool value) { }

	public void set_ChildControlWidth(bool value) { }

	public void set_ChildForceExpandHeight(bool value) { }

	public void set_ChildForceExpandWidth(bool value) { }

	public void set_ChildScaleHeight(bool value) { }

	public void set_ChildScaleWidth(bool value) { }

	public void set_NetworkchildAlignment(in TextAnchor value) { }

	public void set_NetworkchildControlHeight(in bool value) { }

	public void set_NetworkchildControlWidth(in bool value) { }

	public void set_NetworkchildForceExpandHeight(in bool value) { }

	public void set_NetworkchildForceExpandWidth(in bool value) { }

	public void set_NetworkchildScaleHeight(in bool value) { }

	public void set_NetworkchildScaleWidth(in bool value) { }

	public void set_NetworkpaddingBottom(in int value) { }

	public void set_NetworkpaddingLeft(in int value) { }

	public void set_NetworkpaddingRight(in int value) { }

	public void set_NetworkpaddingTop(in int value) { }

	public void set_NetworkreverseAlignment(in bool value) { }

	public void set_Networkspacing(in float value) { }

	public void set_PaddingBottom(int value) { }

	public void set_PaddingLeft(int value) { }

	public void set_PaddingRight(int value) { }

	public void set_PaddingTop(int value) { }

	public void set_ReverseAlignment(bool value) { }

	public void set_Spacing(float value) { }

	protected virtual void Start() { }

	private void SyncChildAlignment(TextAnchor oldValue, TextAnchor newValue) { }

	private void SyncChildControlHeight(bool oldValue, bool newValue) { }

	private void SyncChildControlWidth(bool oldValue, bool newValue) { }

	private void SyncChildForceExpandHeight(bool oldValue, bool newValue) { }

	private void SyncChildForceExpandWidth(bool oldValue, bool newValue) { }

	private void SyncChildScaleHeight(bool oldValue, bool newValue) { }

	private void SyncChildScaleWidth(bool oldValue, bool newValue) { }

	private void SyncPaddingBottom(int oldValue, int newValue) { }

	private void SyncPaddingLeft(int oldValue, int newValue) { }

	private void SyncPaddingRight(int oldValue, int newValue) { }

	private void SyncPaddingTop(int oldValue, int newValue) { }

	private void SyncReverseAlignment(bool oldValue, bool newValue) { }

	private void SyncSpacing(float oldValue, float newValue) { }

	public virtual bool Weaved() { }

}

