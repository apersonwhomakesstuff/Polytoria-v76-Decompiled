namespace Polytoria.Datamodel.Proxies;

public class NumberValueProxy : ValueBaseProxy
{
	private readonly NumberValue numberValue; //Field offset: 0x20

	public float Value
	{
		 get { } //Length: 31
		 set { } //Length: 30
	}

	[MoonSharpHidden]
	public NumberValueProxy(NumberValue target) { }

	public float get_Value() { }

	public void set_Value(float value) { }

}

