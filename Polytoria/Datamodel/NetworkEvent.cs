namespace Polytoria.Datamodel;

[Instantiatable]
public class NetworkEvent : Instance
{
	public LuaEvent InvokedServer; //Field offset: 0xF8
	public LuaEvent InvokedClient; //Field offset: 0x100

	private static NetworkEvent() { }

	public NetworkEvent() { }

	public void InvokeClient(NetMessage msg, Player player) { }

	[ClientRpc]
	private void InvokeClientRpc(NetMessage msg) { }

	public void InvokeClients(NetMessage msg) { }

	[Command(requiresAuthority = False)]
	private void InvokeCmd(NetMessage msg, NetworkConnectionToClient sender = null) { }

	public void InvokeServer(NetMessage msg) { }

	[TargetRpc]
	private void InvokeTargetRpc(NetworkConnection target, NetMessage msg) { }

	protected static void InvokeUserCode_InvokeClientRpc__NetMessage(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection) { }

	protected static void InvokeUserCode_InvokeCmd__NetMessage__NetworkConnectionToClient(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection) { }

	protected static void InvokeUserCode_InvokeTargetRpc__NetworkConnection__NetMessage(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection) { }

	protected void UserCode_InvokeClientRpc__NetMessage(NetMessage msg) { }

	protected void UserCode_InvokeCmd__NetMessage__NetworkConnectionToClient(NetMessage msg, NetworkConnectionToClient sender) { }

	protected void UserCode_InvokeTargetRpc__NetworkConnection__NetMessage(NetworkConnection target, NetMessage msg) { }

	public virtual bool Weaved() { }

}

