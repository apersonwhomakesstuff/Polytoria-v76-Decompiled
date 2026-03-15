namespace Polytoria.Datamodel.Proxies;

public class ValueBaseProxy : InstanceProxy
{
	private readonly ValueBase valueBase; //Field offset: 0x18

	public LuaEvent Changed
	{
		 get { } //Length: 30
	}

	[MoonSharpHidden]
	public ValueBaseProxy(ValueBase target) { }

	public LuaEvent get_Changed() { }

}

