namespace Polytoria.Datamodel.Proxies;

public class ProceduralSkyProxy : SkyBaseProxy
{
	private readonly ProceduralSky proceduralSky; //Field offset: 0x20

	public float AtmosphereThickness
	{
		 get { } //Length: 31
		 set { } //Length: 30
	}

	public float Exposure
	{
		 get { } //Length: 31
		 set { } //Length: 30
	}

	public Color GroundColor
	{
		 get { } //Length: 36
		 set { } //Length: 44
	}

	public Color SkyTint
	{
		 get { } //Length: 36
		 set { } //Length: 44
	}

	public float SunSize
	{
		 get { } //Length: 31
		 set { } //Length: 30
	}

	public float SunSizeConvergence
	{
		 get { } //Length: 31
		 set { } //Length: 30
	}

	[MoonSharpHidden]
	public ProceduralSkyProxy(ProceduralSky target) { }

	public float get_AtmosphereThickness() { }

	public float get_Exposure() { }

	public Color get_GroundColor() { }

	public Color get_SkyTint() { }

	public float get_SunSize() { }

	public float get_SunSizeConvergence() { }

	public void set_AtmosphereThickness(float value) { }

	public void set_Exposure(float value) { }

	public void set_GroundColor(Color value) { }

	public void set_SkyTint(Color value) { }

	public void set_SunSize(float value) { }

	public void set_SunSizeConvergence(float value) { }

}

