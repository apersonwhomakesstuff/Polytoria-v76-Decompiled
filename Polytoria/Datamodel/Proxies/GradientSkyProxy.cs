namespace Polytoria.Datamodel.Proxies;

public class GradientSkyProxy : SkyBaseProxy
{
	private readonly GradientSky gradientSky; //Field offset: 0x20

	public Color HorizonLineColor
	{
		 get { } //Length: 36
		 set { } //Length: 44
	}

	public float HorizonLineContribution
	{
		 get { } //Length: 31
		 set { } //Length: 30
	}

	public float HorizonLineExponent
	{
		 get { } //Length: 31
		 set { } //Length: 30
	}

	public Color SkyGradientBottom
	{
		 get { } //Length: 36
		 set { } //Length: 44
	}

	public float SkyGradientExponent
	{
		 get { } //Length: 31
		 set { } //Length: 30
	}

	public Color SkyGradientTop
	{
		 get { } //Length: 36
		 set { } //Length: 44
	}

	public Color SunDiscColor
	{
		 get { } //Length: 36
		 set { } //Length: 44
	}

	public float SunDiscExponent
	{
		 get { } //Length: 31
		 set { } //Length: 30
	}

	public float SunDiscMultiplier
	{
		 get { } //Length: 31
		 set { } //Length: 30
	}

	public Color SunHaloColor
	{
		 get { } //Length: 36
		 set { } //Length: 44
	}

	public float SunHaloContribution
	{
		 get { } //Length: 31
		 set { } //Length: 30
	}

	public float SunHaloExponent
	{
		 get { } //Length: 31
		 set { } //Length: 30
	}

	[MoonSharpHidden]
	public GradientSkyProxy(GradientSky target) { }

	public Color get_HorizonLineColor() { }

	public float get_HorizonLineContribution() { }

	public float get_HorizonLineExponent() { }

	public Color get_SkyGradientBottom() { }

	public float get_SkyGradientExponent() { }

	public Color get_SkyGradientTop() { }

	public Color get_SunDiscColor() { }

	public float get_SunDiscExponent() { }

	public float get_SunDiscMultiplier() { }

	public Color get_SunHaloColor() { }

	public float get_SunHaloContribution() { }

	public float get_SunHaloExponent() { }

	public void set_HorizonLineColor(Color value) { }

	public void set_HorizonLineContribution(float value) { }

	public void set_HorizonLineExponent(float value) { }

	public void set_SkyGradientBottom(Color value) { }

	public void set_SkyGradientExponent(float value) { }

	public void set_SkyGradientTop(Color value) { }

	public void set_SunDiscColor(Color value) { }

	public void set_SunDiscExponent(float value) { }

	public void set_SunDiscMultiplier(float value) { }

	public void set_SunHaloColor(Color value) { }

	public void set_SunHaloContribution(float value) { }

	public void set_SunHaloExponent(float value) { }

}

