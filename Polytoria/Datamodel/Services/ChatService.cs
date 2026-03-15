namespace Polytoria.Datamodel.Services;

public class ChatService : NetworkBehaviour
{
	[CompilerGenerated]
	private sealed class <LogChatMessage>d__9 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public ChatService <>4__this; //Field offset: 0x20
		public int userId; //Field offset: 0x28
		public string message; //Field offset: 0x30
		private UnityWebRequest <uwr>5__2; //Field offset: 0x38

		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		[DebuggerHidden]
		public <LogChatMessage>d__9(int <>1__state) { }

		private void <>m__Finally1() { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	public const int MaxMessageLength = 128; //Field offset: 0x0
	public static ChatService Instance; //Field offset: 0x0
	private Players _players; //Field offset: 0x68

	private static ChatService() { }

	public ChatService() { }

	private void Awake() { }

	public void BroadcastMessage(string message) { }

	[Command(requiresAuthority = False)]
	private void CmdSendChat(string message, NetworkConnectionToClient sender = null) { }

	private void DoSendChat(string message, Color color, Player player) { }

	private string FilterChatExploits(string message) { }

	[MoonSharpHidden]
	public void Invoke(string methodName, float time) { }

	[MoonSharpHidden]
	public void InvokeRepeating(string methodName, float time, float repeatRate) { }

	protected static void InvokeUserCode_CmdSendChat__String__NetworkConnectionToClient(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection) { }

	protected static void InvokeUserCode_SendChatClientRpc__String__String__Color__Player(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection) { }

	protected static void InvokeUserCode_SendChatTargetRpc__NetworkConnection__String__String__Color(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection) { }

	[IteratorStateMachine(typeof(<LogChatMessage>d__9))]
	private IEnumerator LogChatMessage(int userId, string message) { }

	[MoonSharpHidden]
	public void SendChat(string message) { }

	[ClientRpc]
	private void SendChatClientRpc(string message, string username, Color color, Player player) { }

	[TargetRpc]
	private void SendChatTargetRpc(NetworkConnection target, string message, string username, Color color) { }

	public void UnicastMessage(string message, Player player) { }

	protected void UserCode_CmdSendChat__String__NetworkConnectionToClient(string message, NetworkConnectionToClient sender) { }

	protected void UserCode_SendChatClientRpc__String__String__Color__Player(string message, string username, Color color, Player player) { }

	protected void UserCode_SendChatTargetRpc__NetworkConnection__String__String__Color(NetworkConnection target, string message, string username, Color color) { }

	public virtual bool Weaved() { }

}

