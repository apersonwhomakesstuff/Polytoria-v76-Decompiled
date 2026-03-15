namespace Polytoria.Datamodel.Proxies;

public class Text3DProxy : DynamicInstanceProxy
{
	private readonly Text3D text3D; //Field offset: 0x20

	public Color Color
	{
		 get { } //Length: 51
		 set { } //Length: 44
	}

	public bool FaceCamera
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
		 get { } //Length: 29
		 set { } //Length: 30
	}

	public HorizontalAlignmentOptions HorizontalAlignment
	{
		 get { } //Length: 29
		 set { } //Length: 30
	}

	public string Text
	{
		 get { } //Length: 29
		 set { } //Length: 30
	}

	public VerticalAlignmentOptions VerticalAlignment
	{
		 get { } //Length: 29
		 set { } //Length: 30
	}

	[MoonSharpHidden]
	public Text3DProxy(Text3D target) { }

	public Color get_Color() { }

	public bool get_FaceCamera() { }

	public TextFontPreset get_Font() { }

	public float get_FontSize() { }

	public HorizontalAlignmentOptions get_HorizontalAlignment() { }

	public string get_Text() { }

	public VerticalAlignmentOptions get_VerticalAlignment() { }

	public void set_Color(Color value) { }

	public void set_FaceCamera(bool value) { }

	public void set_Font(TextFontPreset value) { }

	public void set_FontSize(float value) { }

	public void set_HorizontalAlignment(HorizontalAlignmentOptions value) { }

	public void set_Text(string value) { }

	public void set_VerticalAlignment(VerticalAlignmentOptions value) { }

}

