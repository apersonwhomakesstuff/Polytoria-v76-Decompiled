namespace Polytoria.Datamodel.Proxies;

public class UILabelProxy : UIViewProxy
{
	private readonly UILabel uiLabel; //Field offset: 0x28

	public bool AutoSize
	{
		 get { } //Length: 30
		 set { } //Length: 30
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

	public Color OutlineColor
	{
		 get { } //Length: 36
		 set { } //Length: 44
	}

	public float OutlineWidth
	{
		 get { } //Length: 31
		 set { } //Length: 30
	}

	public string Text
	{
		 get { } //Length: 30
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
	public UILabelProxy(UILabel target) { }

	public bool get_AutoSize() { }

	public TextFontPreset get_Font() { }

	public float get_FontSize() { }

	public TextJustify get_JustifyText() { }

	public float get_MaxFontSize() { }

	public Color get_OutlineColor() { }

	public float get_OutlineWidth() { }

	public string get_Text() { }

	public Color get_TextColor() { }

	public TextVerticalAlign get_VerticalAlign() { }

	public void set_AutoSize(bool value) { }

	public void set_Font(TextFontPreset value) { }

	public void set_FontSize(float value) { }

	public void set_JustifyText(TextJustify value) { }

	public void set_MaxFontSize(float value) { }

	public void set_OutlineColor(Color value) { }

	public void set_OutlineWidth(float value) { }

	public void set_Text(string value) { }

	public void set_TextColor(Color value) { }

	public void set_VerticalAlign(TextVerticalAlign value) { }

}

