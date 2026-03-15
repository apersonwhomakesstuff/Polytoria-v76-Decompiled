namespace Polytoria.Datamodel;

public class Game : Instance
{
	[CompilerGenerated]
	private sealed class <WaitForGameLoad>d__29 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public Game <>4__this; //Field offset: 0x20
		private float <startTime>5__2; //Field offset: 0x28
		private float <timeout>5__3; //Field offset: 0x2C
		private int <lastInstances>5__4; //Field offset: 0x30
		private float <timeSinceChange>5__5; //Field offset: 0x34
		private float <minimumTime>5__6; //Field offset: 0x38

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
		public <WaitForGameLoad>d__29(int <>1__state) { }

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

	public static Game singleton; //Field offset: 0x0
	public static string GameName; //Field offset: 0x8
	[CompilerGenerated]
	private static Action GameLoadedLocally; //Field offset: 0x10
	[CompilerGenerated]
	private Action Loaded; //Field offset: 0xF8
	public LuaEvent Rendered; //Field offset: 0x100
	[SyncVar]
	private int gameID; //Field offset: 0x108
	[SyncVar]
	private int playersConnected; //Field offset: 0x10C
	[SyncVar]
	public int instanceCount; //Field offset: 0x110
	private int localInstanceCount; //Field offset: 0x114
	public bool isGameLoaded; //Field offset: 0x118

	public static event Action GameLoadedLocally
	{
		[CompilerGenerated]
		 add { } //Length: 184
		[CompilerGenerated]
		 remove { } //Length: 184
	}

	public event Action Loaded
	{
		[CompilerGenerated]
		 add { } //Length: 162
		[CompilerGenerated]
		 remove { } //Length: 162
	}

	public int GameID
	{
		 get { } //Length: 7
	}

	public int InstanceCount
	{
		 get { } //Length: 7
	}

	public int LocalInstanceCount
	{
		 get { } //Length: 7
	}

	public int NetworkgameID
	{
		 get { } //Length: 7
		 set { } //Length: 177
	}

	public int NetworkinstanceCount
	{
		 get { } //Length: 7
		 set { } //Length: 177
	}

	public int NetworkplayersConnected
	{
		 get { } //Length: 7
		 set { } //Length: 177
	}

	public int PlayersConnected
	{
		 get { } //Length: 7
	}

	public Game() { }

	[CompilerGenerated]
	public static void add_GameLoadedLocally(Action value) { }

	[CompilerGenerated]
	public void add_Loaded(Action value) { }

	protected virtual void Awake() { }

	public void BuildNavMesh() { }

	public virtual void DeserializeSyncVars(NetworkReader reader, bool initialState) { }

	public int get_GameID() { }

	public int get_InstanceCount() { }

	public int get_LocalInstanceCount() { }

	public int get_NetworkgameID() { }

	public int get_NetworkinstanceCount() { }

	public int get_NetworkplayersConnected() { }

	public int get_PlayersConnected() { }

	[MoonSharpHidden]
	public void InstanceAdded() { }

	[MoonSharpHidden]
	public void InstanceRemoved() { }

	public void InvokeLoaded() { }

	public void InvokeLoadedLocal() { }

	public virtual void OnStartServer() { }

	[CompilerGenerated]
	public static void remove_GameLoadedLocally(Action value) { }

	[CompilerGenerated]
	public void remove_Loaded(Action value) { }

	public virtual void SerializeSyncVars(NetworkWriter writer, bool forceAll) { }

	public void set_NetworkgameID(in int value) { }

	public void set_NetworkinstanceCount(in int value) { }

	public void set_NetworkplayersConnected(in int value) { }

	public void SetGameID(int id) { }

	protected virtual void Start() { }

	private void Update() { }

	[IteratorStateMachine(typeof(<WaitForGameLoad>d__29))]
	[MoonSharpHidden]
	public IEnumerator WaitForGameLoad() { }

	public virtual bool Weaved() { }

}

