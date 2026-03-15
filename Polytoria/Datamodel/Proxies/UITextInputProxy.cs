namespace Polytoria.Datamodel.Proxies;

public class UITextInputProxy : UIViewProxy
{
	private readonly UITextInput uiTextInput; //Field offset: 0x28

	public bool AutoSize
	{
		 get { } //Length: 30
		 set { } //Length: 30
	}

	[LuaEventParameter(typeof(string), "value", False)]
	public LuaEvent Changed
	{
		 get { } //Length: 30
	}

	public TextFontPreset Font
	{
		 get { } //Length: 29
		 set { } //Length: 30
	}

	public float FontSize
	{
		 get { } //Length: 31
		 set { } //Length: 30
	}

	public bool IsFocused
	{
		 get { } //Length: 29
	}

	public bool IsMultiline
	{
		 get { } //Length: 30
		 set { } //Length: 30
	}

	public bool IsReadOnly
	{
		 get { } //Length: 30
		 set { } //Length: 30
	}

	public TextJustify JustifyText
	{
		 get { } //Length: 29
		 set { } //Length: 30
	}

	public float MaxFontSize
	{
		 get { } //Length: 31
		 set { } //Length: 30
	}

	public string Placeholder
	{
		 get { } //Length: 30
		 set { } //Length: 30
	}

	public Color PlaceholderColor
	{
		 get { } //Length: 36
		 set { } //Length: 44
	}

	[LuaEventParameter(typeof(string), "value", False)]
	public LuaEvent Submitted
	{
		 get { } //Length: 30
	}

	public string Text
	{
		 get { } //Length: 29
		 set { } //Length: 30
	}

	public Color TextColor
	{
		 get { } //Length: 36
		 set { } //Length: 44
	}

	public TextVerticalAlign VerticalAlign
	{
		 get { } //Length: 29
		 set { } //Length: 30
	}

	[MoonSharpHidden]
	public UITextInputProxy(UITextInput target) { }

	public void Focus() { }

	public bool get_AutoSize() { }

	public LuaEvent get_Changed() { }

	public TextFontPreset get_Font() { }

	public float get_FontSize() { }

	public bool get_IsFocused() { }

	public bool get_IsMultiline() { }

	public bool get_IsReadOnly() { }

	public TextJustify get_JustifyText() { }

	public float get_MaxFontSize() { }

	public string get_Placeholder() { }

	public Color get_PlaceholderColor() { }

	public LuaEvent get_Submitted() { }

	public string get_Text() { }

	public Color get_TextColor() { }

	public TextVerticalAlign get_VerticalAlign() { }

	public void set_AutoSize(bool value) { }

	public void set_Font(TextFontPreset value) { }

	public void set_FontSize(float value) { }

	public void set_IsMultiline(bool value) { }

	public void set_IsReadOnly(bool value) { }

	public void set_JustifyText(TextJustify value) { }

	public void set_MaxFontSize(float value) { }

	public void set_Placeholder(string value) { }

	public void set_PlaceholderColor(Color value) { }

	public void set_Text(string value) { }

	public void set_TextColor(Color value) { }

	public void set_VerticalAlign(TextVerticalAlign value) { }

}

