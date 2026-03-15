namespace Polytoria.Datamodel;

[Instantiatable]
public class UITextInput : UIView
{
	private TMP_InputField inputField; //Field offset: 0x1F8
	private TMP_Text placeholderText; //Field offset: 0x200
	public LuaEvent Changed; //Field offset: 0x208
	public LuaEvent Submitted; //Field offset: 0x210
	[SyncVar(hook = "SyncSetTextJustify")]
	private TextJustify justify; //Field offset: 0x218
	[SyncVar(hook = "SyncSetTextAlign")]
	private TextVerticalAlign verticalAlign; //Field offset: 0x21C
	[SyncVar(hook = "SyncSetFontSize")]
	private float fontSize; //Field offset: 0x220
	[SyncVar(hook = "SyncSetMaxFontSize")]
	private float maxFontSize; //Field offset: 0x224
	[SyncVar(hook = "SyncSetAutoSize")]
	private bool autoSize; //Field offset: 0x228
	[SyncVar(hook = "SyncSetText")]
	private string text; //Field offset: 0x230
	[SyncVar(hook = "SyncSetColor")]
	private Color textColor; //Field offset: 0x238
	[SyncVar(hook = "SyncSetFont")]
	private TextFontPreset font; //Field offset: 0x248
	[SyncVar(hook = "SyncSetPlaceholder")]
	private string placeholder; //Field offset: 0x250
	[SyncVar(hook = "SyncSetPlaceholderColor")]
	private Color placeholderColor; //Field offset: 0x258
	[SyncVar(hook = "SyncSetIsReadOnly")]
	private bool isReadOnly; //Field offset: 0x268
	[SyncVar(hook = "SyncSetIsMultiline")]
	private bool isMultiline; //Field offset: 0x269
	public Action<TextJustify, TextJustify> _Mirror_SyncVarHookDelegate_justify; //Field offset: 0x270
	public Action<TextVerticalAlign, TextVerticalAlign> _Mirror_SyncVarHookDelegate_verticalAlign; //Field offset: 0x278
	public Action<Single, Single> _Mirror_SyncVarHookDelegate_fontSize; //Field offset: 0x280
	public Action<Single, Single> _Mirror_SyncVarHookDelegate_maxFontSize; //Field offset: 0x288
	public Action<Boolean, Boolean> _Mirror_SyncVarHookDelegate_autoSize; //Field offset: 0x290
	public Action<String, String> _Mirror_SyncVarHookDelegate_text; //Field offset: 0x298
	public Action<Color, Color> _Mirror_SyncVarHookDelegate_textColor; //Field offset: 0x2A0
	public Action<TextFontPreset, TextFontPreset> _Mirror_SyncVarHookDelegate_font; //Field offset: 0x2A8
	public Action<String, String> _Mirror_SyncVarHookDelegate_placeholder; //Field offset: 0x2B0
	public Action<Color, Color> _Mirror_SyncVarHookDelegate_placeholderColor; //Field offset: 0x2B8
	public Action<Boolean, Boolean> _Mirror_SyncVarHookDelegate_isReadOnly; //Field offset: 0x2C0
	public Action<Boolean, Boolean> _Mirror_SyncVarHookDelegate_isMultiline; //Field offset: 0x2C8

	[Archivable]
	[CreatorProperty]
	public bool AutoSize
	{
		 get { } //Length: 8
		 set { } //Length: 174
	}

	[Archivable]
	[CreatorProperty]
	public TextFontPreset Font
	{
		 get { } //Length: 7
		 set { } //Length: 288
	}

	[Archivable]
	[CreatorProperty]
	public float FontSize
	{
		 get { } //Length: 9
		 set { } //Length: 239
	}

	public bool IsFocused
	{
		 get { } //Length: 33
	}

	[Archivable]
	[CreatorProperty]
	public bool IsMultiline
	{
		 get { } //Length: 8
		 set { } //Length: 142
	}

	[Archivable]
	[CreatorProperty]
	public bool IsReadOnly
	{
		 get { } //Length: 8
		 set { } //Length: 134
	}

	[Archivable]
	[CreatorProperty]
	public TextJustify JustifyText
	{
		 get { } //Length: 7
		 set { } //Length: 273
	}

	[Archivable]
	[CreatorProperty]
	public float MaxFontSize
	{
		 get { } //Length: 9
		 set { } //Length: 332
	}

	public bool NetworkautoSize
	{
		 get { } //Length: 8
		 set { } //Length: 104
	}

	public TextFontPreset Networkfont
	{
		 get { } //Length: 7
		 set { } //Length: 101
	}

	public float NetworkfontSize
	{
		 get { } //Length: 9
		 set { } //Length: 104
	}

	public bool NetworkisMultiline
	{
		 get { } //Length: 8
		 set { } //Length: 104
	}

	public bool NetworkisReadOnly
	{
		 get { } //Length: 8
		 set { } //Length: 104
	}

	public TextJustify Networkjustify
	{
		 get { } //Length: 7
		 set { } //Length: 101
	}

	public float NetworkmaxFontSize
	{
		 get { } //Length: 9
		 set { } //Length: 104
	}

	public string Networkplaceholder
	{
		 get { } //Length: 8
		 set { } //Length: 103
	}

	public Color NetworkplaceholderColor
	{
		 get { } //Length: 14
		 set { } //Length: 113
	}

	public string Networktext
	{
		 get { } //Length: 8
		 set { } //Length: 103
	}

	public Color NetworktextColor
	{
		 get { } //Length: 14
		 set { } //Length: 113
	}

	public TextVerticalAlign NetworkverticalAlign
	{
		 get { } //Length: 7
		 set { } //Length: 101
	}

	[Archivable]
	[CreatorProperty]
	public string Placeholder
	{
		 get { } //Length: 8
		 set { } //Length: 146
	}

	[Archivable]
	[CreatorProperty]
	public Color PlaceholderColor
	{
		 get { } //Length: 14
		 set { } //Length: 166
	}

	[Archivable]
	[CreatorProperty]
	public string Text
	{
		 get { } //Length: 33
		 set { } //Length: 143
	}

	[Archivable]
	[CreatorProperty]
	public Color TextColor
	{
		 get { } //Length: 14
		 set { } //Length: 191
	}

	[Archivable]
	[CreatorProperty]
	public TextVerticalAlign VerticalAlign
	{
		 get { } //Length: 7
		 set { } //Length: 243
	}

	public UITextInput() { }

	[CompilerGenerated]
	private void <Awake>b__67_0(string s) { }

	[CompilerGenerated]
	private void <Awake>b__67_1(string s) { }

	protected virtual void Awake() { }

	protected virtual void CopyProperties(Instance clone) { }

	public virtual void DeserializeSyncVars(NetworkReader reader, bool initialState) { }

	public void Focus() { }

	public bool get_AutoSize() { }

	public TextFontPreset get_Font() { }

	public float get_FontSize() { }

	public bool get_IsFocused() { }

	public bool get_IsMultiline() { }

	public bool get_IsReadOnly() { }

	public TextJustify get_JustifyText() { }

	public float get_MaxFontSize() { }

	public bool get_NetworkautoSize() { }

	public TextFontPreset get_Networkfont() { }

	public float get_NetworkfontSize() { }

	public bool get_NetworkisMultiline() { }

	public bool get_NetworkisReadOnly() { }

	public TextJustify get_Networkjustify() { }

	public float get_NetworkmaxFontSize() { }

	public string get_Networkplaceholder() { }

	public Color get_NetworkplaceholderColor() { }

	public string get_Networktext() { }

	public Color get_NetworktextColor() { }

	public TextVerticalAlign get_NetworkverticalAlign() { }

	public string get_Placeholder() { }

	public Color get_PlaceholderColor() { }

	public string get_Text() { }

	public Color get_TextColor() { }

	public TextVerticalAlign get_VerticalAlign() { }

	protected virtual void OnHide() { }

	protected virtual void OnShow() { }

	public virtual void SerializeSyncVars(NetworkWriter writer, bool forceAll) { }

	public void set_AutoSize(bool value) { }

	public void set_Font(TextFontPreset value) { }

	public void set_FontSize(float value) { }

	public void set_IsMultiline(bool value) { }

	public void set_IsReadOnly(bool value) { }

	public void set_JustifyText(TextJustify value) { }

	public void set_MaxFontSize(float value) { }

	public void set_NetworkautoSize(in bool value) { }

	public void set_Networkfont(in TextFontPreset value) { }

	public void set_NetworkfontSize(in float value) { }

	public void set_NetworkisMultiline(in bool value) { }

	public void set_NetworkisReadOnly(in bool value) { }

	public void set_Networkjustify(in TextJustify value) { }

	public void set_NetworkmaxFontSize(in float value) { }

	public void set_Networkplaceholder(in string value) { }

	public void set_NetworkplaceholderColor(in Color value) { }

	public void set_Networktext(in string value) { }

	public void set_NetworktextColor(in Color value) { }

	public void set_NetworkverticalAlign(in TextVerticalAlign value) { }

	public void set_Placeholder(string value) { }

	public void set_PlaceholderColor(Color value) { }

	public void set_Text(string value) { }

	public void set_TextColor(Color value) { }

	public void set_VerticalAlign(TextVerticalAlign value) { }

	protected virtual void Start() { }

	private void SyncSetAutoSize(bool oldValue, bool newValue) { }

	private void SyncSetColor(Color oldValue, Color newValue) { }

	private void SyncSetFont(TextFontPreset oldValue, TextFontPreset newValue) { }

	private void SyncSetFontSize(float oldValue, float newValue) { }

	private void SyncSetIsMultiline(bool oldValue, bool newValue) { }

	private void SyncSetIsReadOnly(bool oldValue, bool newValue) { }

	private void SyncSetMaxFontSize(float oldValue, float newValue) { }

	private void SyncSetPlaceholder(string oldValue, string newValue) { }

	private void SyncSetPlaceholderColor(Color oldValue, Color newValue) { }

	private void SyncSetText(string oldtext, string newtext) { }

	private void SyncSetTextAlign(TextVerticalAlign oldValue, TextVerticalAlign newValue) { }

	private void SyncSetTextJustify(TextJustify oldValue, TextJustify newValue) { }

	public virtual bool Weaved() { }

}

