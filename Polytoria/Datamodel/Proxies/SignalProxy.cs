namespace Polytoria.Datamodel.Proxies;

public class SignalProxy : InstanceProxy
{
	private readonly Signal signal; //Field offset: 0x18

	public LuaEvent Invoked
	{
		 get { } //Length: 30
	}

	[MoonSharpHidden]
	public SignalProxy(Signal target) { }

	public LuaEvent get_Invoked() { }

	public void Invoke(Object[] par) { }

}

