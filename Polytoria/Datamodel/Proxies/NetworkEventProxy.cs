namespace Polytoria.Datamodel.Proxies;

public class NetworkEventProxy : InstanceProxy
{
	private readonly NetworkEvent networkEvent; //Field offset: 0x18

	[LuaEventParameter((Type) null, "sender", False)]
	[LuaEventParameter(typeof(NetMessage), "message", False)]
	public LuaEvent InvokedClient
	{
		 get { } //Length: 30
	}

	[LuaEventParameter(typeof(Player), "sender", False)]
	[LuaEventParameter(typeof(NetMessage), "message", False)]
	public LuaEvent InvokedServer
	{
		 get { } //Length: 30
	}

	[MoonSharpHidden]
	public NetworkEventProxy(NetworkEvent target) { }

	public LuaEvent get_InvokedClient() { }

	public LuaEvent get_InvokedServer() { }

	public void InvokeClient(NetMessage msg, Player player) { }

	public void InvokeClients(NetMessage msg) { }

	public void InvokeServer(NetMessage msg) { }

}

