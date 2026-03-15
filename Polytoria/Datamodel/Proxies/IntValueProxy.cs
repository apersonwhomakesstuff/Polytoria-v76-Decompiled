namespace Polytoria.Datamodel.Proxies;

public class IntValueProxy : ValueBaseProxy
{
	private readonly IntValue intValue; //Field offset: 0x20

	public int Value
	{
		 get { } //Length: 29
		 set { } //Length: 30
	}

	[MoonSharpHidden]
	public IntValueProxy(IntValue target) { }

	public int get_Value() { }

	public void set_Value(int value) { }

}

