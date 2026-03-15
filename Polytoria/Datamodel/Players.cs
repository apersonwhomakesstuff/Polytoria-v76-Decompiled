namespace Polytoria.Datamodel;

public class Players : Instance
{
	[CompilerGenerated]
	private sealed class <DelayedPlayerAddEvent>d__15 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public Players <>4__this; //Field offset: 0x20
		public Player player; //Field offset: 0x28

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
		public <DelayedPlayerAddEvent>d__15(int <>1__state) { }

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

	public LuaEvent PlayerAdded; //Field offset: 0xF8
	public LuaEvent PlayerRemoved; //Field offset: 0x100
	private Player _localPlayer; //Field offset: 0x108
	[SyncVar]
	private bool playerCollisions; //Field offset: 0x110

	public Player LocalPlayer
	{
		 get { } //Length: 8
	}

	public bool NetworkplayerCollisions
	{
		 get { } //Length: 8
		 set { } //Length: 182
	}

	[Archivable]
	[CreatorProperty]
	public bool PlayerCollisionEnabled
	{
		 get { } //Length: 8
		 set { } //Length: 697
	}

	private static Players() { }

	public Players() { }

	[MoonSharpHidden]
	public void AddPlayer(Player player) { }

	protected virtual void Awake() { }

	[IteratorStateMachine(typeof(<DelayedPlayerAddEvent>d__15))]
	private IEnumerator DelayedPlayerAddEvent(Player player) { }

	public virtual void DeserializeSyncVars(NetworkReader reader, bool initialState) { }

	public Player get_LocalPlayer() { }

	public bool get_NetworkplayerCollisions() { }

	public bool get_PlayerCollisionEnabled() { }

	public Player GetPlayer(string username) { }

	public Player GetPlayerByID(int id) { }

	public Player[] GetPlayers() { }

	protected static void InvokeUserCode_PlayerAddedClientRpc__Player(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection) { }

	protected static void InvokeUserCode_PlayerRemovedClientRpc__String(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection) { }

	protected static void InvokeUserCode_RpcSetPlayerCollisions__Boolean(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection) { }

	[MoonSharpHidden]
	public void NotifyPlayerDestroyed(Player player) { }

	[ClientRpc]
	private void PlayerAddedClientRpc(Player p) { }

	[ClientRpc]
	private void PlayerRemovedClientRpc(string name) { }

	[ClientRpc]
	private void RpcSetPlayerCollisions(bool enabled) { }

	public virtual void SerializeSyncVars(NetworkWriter writer, bool forceAll) { }

	public void set_NetworkplayerCollisions(in bool value) { }

	public void set_PlayerCollisionEnabled(bool value) { }

	[MoonSharpHidden]
	public void SetLocalPlayer(Player player) { }

	protected virtual void Start() { }

	protected void UserCode_PlayerAddedClientRpc__Player(Player p) { }

	protected void UserCode_PlayerRemovedClientRpc__String(string name) { }

	protected void UserCode_RpcSetPlayerCollisions__Boolean(bool enabled) { }

	public virtual bool Weaved() { }

}

