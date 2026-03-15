namespace Polytoria.Datamodel.Proxies;

public class SpotlightProxy : DynamicInstanceProxy
{
	private readonly Spotlight spotlight; //Field offset: 0x20

	public float Angle
	{
		 get { } //Length: 29
		 set { } //Length: 30
	}

	public float Brightness
	{
		 get { } //Length: 29
		 set { } //Length: 30
	}

	public Color Color
	{
		 get { } //Length: 51
		 set { } //Length: 44
	}

	public float Range
	{
		 get { } //Length: 29
		 set { } //Length: 30
	}

	public bool Shadows
	{
		 get { } //Length: 29
		 set { } //Length: 30
	}

	[MoonSharpHidden]
	public SpotlightProxy(Spotlight target) { }

	public float get_Angle() { }

	public float get_Brightness() { }

	public Color get_Color() { }

	public float get_Range() { }

	public bool get_Shadows() { }

	public void set_Angle(float value) { }

	public void set_Brightness(float value) { }

	public void set_Color(Color value) { }

	public void set_Range(float value) { }

	public void set_Shadows(bool value) { }

}

