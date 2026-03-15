namespace Polytoria.Datamodel.Proxies;

public class LightingProxy : InstanceProxy
{
	private readonly Lighting lighting; //Field offset: 0x18

	public Color AmbientColor
	{
		 get { } //Length: 51
		 set { } //Length: 44
	}

	public AmbientSource AmbientSource
	{
		 get { } //Length: 29
		 set { } //Length: 30
	}

	public bool Shadows
	{
		 get { } //Length: 29
		 set { } //Length: 30
	}

	public float SunBrightness
	{
		 get { } //Length: 29
		 set { } //Length: 30
	}

	public Color SunColor
	{
		 get { } //Length: 51
		 set { } //Length: 44
	}

	[MoonSharpHidden]
	public LightingProxy(Lighting target) { }

	public Color get_AmbientColor() { }

	public AmbientSource get_AmbientSource() { }

	public bool get_Shadows() { }

	public float get_SunBrightness() { }

	public Color get_SunColor() { }

	public void set_AmbientColor(Color value) { }

	public void set_AmbientSource(AmbientSource value) { }

	public void set_Shadows(bool value) { }

	public void set_SunBrightness(float value) { }

	public void set_SunColor(Color value) { }

}

