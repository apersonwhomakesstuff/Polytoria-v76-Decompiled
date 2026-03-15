namespace Polytoria.Datamodel.Proxies;

public class SunLightProxy : DynamicInstanceProxy
{
	private readonly SunLight sunLight; //Field offset: 0x20

	public float Brightness
	{
		 get { } //Length: 31
		 set { } //Length: 30
	}

	public Color Color
	{
		 get { } //Length: 36
		 set { } //Length: 44
	}

	public bool Shadows
	{
		 get { } //Length: 30
		 set { } //Length: 30
	}

	[MoonSharpHidden]
	public SunLightProxy(SunLight target) { }

	public float get_Brightness() { }

	public Color get_Color() { }

	public bool get_Shadows() { }

	public void set_Brightness(float value) { }

	public void set_Color(Color value) { }

	public void set_Shadows(bool value) { }

}

