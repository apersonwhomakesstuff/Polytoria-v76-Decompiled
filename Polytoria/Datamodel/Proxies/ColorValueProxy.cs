namespace Polytoria.Datamodel.Proxies;

public class ColorValueProxy : ValueBaseProxy
{
	private readonly ColorValue colorValue; //Field offset: 0x20

	public Color Value
	{
		 get { } //Length: 36
		 set { } //Length: 44
	}

	[MoonSharpHidden]
	public ColorValueProxy(ColorValue target) { }

	public Color get_Value() { }

	public void set_Value(Color value) { }

}

