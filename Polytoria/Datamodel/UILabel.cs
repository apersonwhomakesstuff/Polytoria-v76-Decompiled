namespace Polytoria.Datamodel;

[Instantiatable]
public class UILabel : UIView
{
	public const float FONT_SCALE = 1.5; //Field offset: 0x0
	private TMP_Text tmp; //Field offset: 0x1F8
	[SyncVar(hook = "SyncSetTextJustify")]
	private TextJustify justify; //Field offset: 0x200
	[SyncVar(hook = "SyncSetTextAlign")]
	private TextVerticalAlign verticalAlign; //Field offset: 0x204
	[SyncVar(hook = "SyncSetFontSize")]
	private float fontSize; //Field offset: 0x208
	[SyncVar(hook = "SyncSetMaxFontSize")]
	private float maxFontSize; //Field offset: 0x20C
	[SyncVar(hook = "SyncSetAutoSize")]
	private bool autoSize; //Field offset: 0x210
	[SyncVar(hook = "SyncSetText")]
	private string text; //Field offset: 0x218
	[SyncVar(hook = "SyncSetColor")]
	private Color textColor; //Field offset: 0x220
	[SyncVar(hook = "SyncSetFont")]
	private TextFontPreset font; //Field offset: 0x230
	[SyncVar(hook = "SyncSetOutlineColor")]
	private Color outlineColor; //Field offset: 0x234
	[SyncVar(hook = "SyncSetOutlineWidth")]
	private float outlineWidth; //Field offset: 0x244
	public Action<TextJustify, TextJustify> _Mirror_SyncVarHookDelegate_justify; //Field offset: 0x248
	public Action<TextVerticalAlign, TextVerticalAlign> _Mirror_SyncVarHookDelegate_verticalAlign; //Field offset: 0x250
	public Action<Single, Single> _Mirror_SyncVarHookDelegate_fontSize; //Field offset: 0x258
	public Action<Single, Single> _Mirror_SyncVarHookDelegate_maxFontSize; //Field offset: 0x260
	public Action<Boolean, Boolean> _Mirror_SyncVarHookDelegate_autoSize; //Field offset: 0x268
	public Action<String, String> _Mirror_SyncVarHookDelegate_text; //Field offset: 0x270
	public Action<Color, Color> _Mirror_SyncVarHookDelegate_textColor; //Field offset: 0x278
	public Action<TextFontPreset, TextFontPreset> _Mirror_SyncVarHookDelegate_font; //Field offset: 0x280
	public Action<Color, Color> _Mirror_SyncVarHookDelegate_outlineColor; //Field offset: 0x288
	public Action<Single, Single> _Mirror_SyncVarHookDelegate_outlineWidth; //Field offset: 0x290

	[Archivable]
	[CreatorProperty]
	public bool AutoSize
	{
		 get { } //Length: 8
		 set { } //Length: 135
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
		 set { } //Length: 175
	}

	[Archivable]
	[CreatorProperty]
	public TextJustify JustifyText
	{
		 get { } //Length: 7
		 set { } //Length: 209
	}

	[Archivable]
	[CreatorProperty]
	public float MaxFontSize
	{
		 get { } //Length: 9
		 set { } //Length: 188
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

	public Color NetworkoutlineColor
	{
		 get { } //Length: 14
		 set { } //Length: 113
	}

	public float NetworkoutlineWidth
	{
		 get { } //Length: 9
		 set { } //Length: 104
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
	public Color OutlineColor
	{
		 get { } //Length: 14
		 set { } //Length: 122
	}

	[Archivable]
	[CreatorProperty]
	public float OutlineWidth
	{
		 get { } //Length: 9
		 set { } //Length: 142
	}

	[Archivable]
	[CreatorProperty]
	public string Text
	{
		 get { } //Length: 8
		 set { } //Length: 155
	}

	[Archivable]
	[CreatorProperty]
	public Color TextColor
	{
		 get { } //Length: 14
		 set { } //Length: 175
	}

	[Archivable]
	[CreatorProperty]
	public TextVerticalAlign VerticalAlign
	{
		 get { } //Length: 7
		 set { } //Length: 177
	}

	public UILabel() { }

	protected virtual void Awake() { }

	protected virtual void CopyProperties(Instance clone) { }

	public virtual void DeserializeSyncVars(NetworkReader reader, bool initialState) { }

	public bool get_AutoSize() { }

	public TextFontPreset get_Font() { }

	public float get_FontSize() { }

	public TextJustify get_JustifyText() { }

	public float get_MaxFontSize() { }

	public bool get_NetworkautoSize() { }

	public TextFontPreset get_Networkfont() { }

	public float get_NetworkfontSize() { }

	public TextJustify get_Networkjustify() { }

	public float get_NetworkmaxFontSize() { }

	public Color get_NetworkoutlineColor() { }

	public float get_NetworkoutlineWidth() { }

	public string get_Networktext() { }

	public Color get_NetworktextColor() { }

	public TextVerticalAlign get_NetworkverticalAlign() { }

	public Color get_OutlineColor() { }

	public float get_OutlineWidth() { }

	public string get_Text() { }

	public Color get_TextColor() { }

	public TextVerticalAlign get_VerticalAlign() { }

	protected virtual void OnDestroy() { }

	protected virtual void OnHide() { }

	protected virtual void OnShow() { }

	public virtual void SerializeSyncVars(NetworkWriter writer, bool forceAll) { }

	public void set_AutoSize(bool value) { }

	public void set_Font(TextFontPreset value) { }

	public void set_FontSize(float value) { }

	public void set_JustifyText(TextJustify value) { }

	public void set_MaxFontSize(float value) { }

	public void set_NetworkautoSize(in bool value) { }

	public void set_Networkfont(in TextFontPreset value) { }

	public void set_NetworkfontSize(in float value) { }

	public void set_Networkjustify(in TextJustify value) { }

	public void set_NetworkmaxFontSize(in float value) { }

	public void set_NetworkoutlineColor(in Color value) { }

	public void set_NetworkoutlineWidth(in float value) { }

	public void set_Networktext(in string value) { }

	public void set_NetworktextColor(in Color value) { }

	public void set_NetworkverticalAlign(in TextVerticalAlign value) { }

	public void set_OutlineColor(Color value) { }

	public void set_OutlineWidth(float value) { }

	public void set_Text(string value) { }

	public void set_TextColor(Color value) { }

	public void set_VerticalAlign(TextVerticalAlign value) { }

	protected virtual void Start() { }

	private void SyncSetAutoSize(bool oldValue, bool newValue) { }

	private void SyncSetColor(Color oldValue, Color newValue) { }

	private void SyncSetFont(TextFontPreset oldValue, TextFontPreset newValue) { }

	private void SyncSetFontSize(float oldValue, float newValue) { }

	private void SyncSetMaxFontSize(float oldValue, float newValue) { }

	private void SyncSetOutlineColor(Color oldValue, Color newValue) { }

	private void SyncSetOutlineWidth(float oldValue, float newValue) { }

	private void SyncSetText(string oldtext, string newtext) { }

	private void SyncSetTextAlign(TextVerticalAlign oldValue, TextVerticalAlign newValue) { }

	private void SyncSetTextJustify(TextJustify oldValue, TextJustify newValue) { }

	private void UpdateOutline() { }

	public virtual bool Weaved() { }

}

