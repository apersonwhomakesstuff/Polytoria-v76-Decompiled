namespace Polytoria.Datamodel.Proxies;

public class ServerHiddenProxy : InstanceProxy
{
	private readonly ServerHidden serverHidden; //Field offset: 0x18

	[MoonSharpHidden]
	public ServerHiddenProxy(ServerHidden target) { }

}

