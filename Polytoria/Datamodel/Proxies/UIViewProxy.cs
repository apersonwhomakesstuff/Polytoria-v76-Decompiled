namespace Polytoria.Datamodel.Proxies;

public class UIViewProxy : UIFieldProxy
{
	private readonly UIView uiView; //Field offset: 0x20

	public Color BorderColor
	{
		 get { } //Length: 36
		 set { } //Length: 44
	}

	public float BorderWidth
	{
		 get { } //Length: 31
		 set { } //Length: 30
	}

	public Color Color
	{
		 get { } //Length: 36
		 set { } //Length: 44
	}

	public float CornerRadius
	{
		 get { } //Length: 31
		 set { } //Length: 30
	}

	[MoonSharpHidden]
	public UIViewProxy(UIView target) { }

	public Color get_BorderColor() { }

	public float get_BorderWidth() { }

	public Color get_Color() { }

	public float get_CornerRadius() { }

	public void set_BorderColor(Color value) { }

	public void set_BorderWidth(float value) { }

	public void set_Color(Color value) { }

	public void set_CornerRadius(float value) { }

}

