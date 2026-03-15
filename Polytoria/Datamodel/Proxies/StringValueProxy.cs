namespace Polytoria.Datamodel.Proxies;

public class StringValueProxy : ValueBaseProxy
{
	private readonly StringValue stringValue; //Field offset: 0x20

	public string Value
	{
		 get { } //Length: 30
		 set { } //Length: 30
	}

	[MoonSharpHidden]
	public StringValueProxy(StringValue target) { }

	public string get_Value() { }

	public void set_Value(string value) { }

}

