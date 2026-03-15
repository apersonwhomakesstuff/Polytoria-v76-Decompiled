namespace Polytoria.Datamodel.Proxies.Services;

public class ChatServiceProxy
{
	private readonly ChatService chatService; //Field offset: 0x10

	[MoonSharpHidden]
	public ChatServiceProxy(ChatService target) { }

	public void BroadcastMessage(string message) { }

	public void UnicastMessage(string message, Player player) { }

}

