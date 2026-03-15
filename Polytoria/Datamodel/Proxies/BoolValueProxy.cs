namespace Polytoria.Datamodel.Proxies;

public class BoolValueProxy : ValueBaseProxy
{
	private readonly BoolValue boolValue; //Field offset: 0x20

	public bool Value
	{
		 get { } //Length: 30
		 set { } //Length: 30
	}

	[MoonSharpHidden]
	public BoolValueProxy(BoolValue target) { }

	public bool get_Value() { }

	public void set_Value(bool value) { }

}

