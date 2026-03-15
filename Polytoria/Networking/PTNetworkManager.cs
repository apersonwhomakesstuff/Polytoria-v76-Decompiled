namespace Polytoria.Networking;

public class PTNetworkManager : NetworkManager
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<AuthUserData, Int32> <>9__42_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal int <GetConnectedUserIDs>b__42_0(AuthUserData i) { }

	}

	[CompilerGenerated]
	private sealed class <HeartbeatLoop>d__33 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public PTNetworkManager <>4__this; //Field offset: 0x20
		private UnityWebRequest <uwr>5__2; //Field offset: 0x28

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
		public <HeartbeatLoop>d__33(int <>1__state) { }

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

	[CompilerGenerated]
	private sealed class <LogEvent>d__32 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18

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
		public <LogEvent>d__32(int <>1__state) { }

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

	private enum ServerEventType : int
	{
		ServerStarted = 0,
		ServerStopped = 1,
		ClientConnected = 2,
		ClientDisconnected = 3,
	}

	public static PTNetworkManager instance; //Field offset: 0x0
	private Dictionary<Int32, AuthUserData> playerConnData; //Field offset: 0xB0
	private Dictionary<Int32, Player> playerPrefabs; //Field offset: 0xB8
	[Range(1, 60)]
	[SerializeField]
	private float serverHeartbeatRate; //Field offset: 0xC0
	[Range(1, 100)]
	[SerializeField]
	private int maxServerTimeout; //Field offset: 0xC4
	private int emptyServerPings; //Field offset: 0xC8

	public PTNetworkManager() { }

	public void AddUserForConnID(int connId, AuthUserData userData) { }

	public virtual void Awake() { }

	public void ClientConnected(int userID) { }

	public void ClientDisconnected(int userID) { }

	public virtual void ConfigureHeadlessFrameRate() { }

	public List<Int32> GetConnectedUserIDs() { }

	public Player GetPlayerPrefab(int connId) { }

	public AuthUserData GetUserDataFromConnID(int connId) { }

	[IteratorStateMachine(typeof(<HeartbeatLoop>d__33))]
	private IEnumerator HeartbeatLoop() { }

	public virtual void LateUpdate() { }

	[IteratorStateMachine(typeof(<LogEvent>d__32))]
	private IEnumerator LogEvent(ServerEventType eventType, Dictionary<String, String> data = null, bool shutdownOnComplete = false) { }

	public virtual void OnApplicationQuit() { }

	public virtual void OnClientChangeScene(string newSceneName, SceneOperation sceneOperation, bool customHandling) { }

	public virtual void OnClientConnect() { }

	public virtual void OnClientDisconnect() { }

	public virtual void OnClientError(TransportError transportError, string message) { }

	public virtual void OnClientNotReady() { }

	public virtual void OnClientSceneChanged() { }

	public virtual void OnDestroy() { }

	public virtual void OnServerAddPlayer(NetworkConnectionToClient conn) { }

	public virtual void OnServerChangeScene(string newSceneName) { }

	public virtual void OnServerConnect(NetworkConnectionToClient conn) { }

	public virtual void OnServerDisconnect(NetworkConnectionToClient conn) { }

	public virtual void OnServerError(NetworkConnectionToClient conn, TransportError transportError, string message) { }

	public virtual void OnServerReady(NetworkConnectionToClient conn) { }

	public virtual void OnServerSceneChanged(string sceneName) { }

	public virtual void OnStartClient() { }

	public virtual void OnStartHost() { }

	public virtual void OnStartServer() { }

	public virtual void OnStopClient() { }

	public virtual void OnStopHost() { }

	public virtual void OnStopServer() { }

	public virtual void OnValidate() { }

	public virtual void ServerChangeScene(string newSceneName) { }

	public void ShutdownServer() { }

	public virtual void Start() { }

}

