namespace Polytoria.Datamodel;

[DefaultMember("Item")]
public class BaseScript : Instance
{
	[CompilerGenerated]
	private sealed class <<RpcRun>g__DelayedRun|18_0>d : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public BaseScript <>4__this; //Field offset: 0x20

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
		public <<RpcRun>g__DelayedRun|18_0>d(int <>1__state) { }

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

	public bool running; //Field offset: 0xF8
	private bool requestedRun; //Field offset: 0xF9
	private ScriptService scriptService; //Field offset: 0x100
	[MoonSharpHidden]
	[SyncVar]
	public string source; //Field offset: 0x108
	[MoonSharpHidden]
	public Script script; //Field offset: 0x110
	private DynValue updateFunc; //Field offset: 0x118
	private DynValue fixedUpdateFunc; //Field offset: 0x120

	public object Item
	{
		 get { } //Length: 42
		 set { } //Length: 42
	}

	public string Networksource
	{
		 get { } //Length: 8
		 set { } //Length: 180
	}

	[Archivable]
	[MoonSharpHidden]
	public string Source
	{
		 get { } //Length: 8
		 set { } //Length: 180
	}

	private static BaseScript() { }

	public BaseScript() { }

	[CompilerGenerated]
	private void <Awake>b__11_0() { }

	[CompilerGenerated]
	[IteratorStateMachine(typeof(<<RpcRun>g__DelayedRun|18_0>d))]
	private IEnumerator <RpcRun>g__DelayedRun|18_0() { }

	protected virtual void Awake() { }

	public void Call(string function, Object[] args) { }

	protected virtual void CopyProperties(Instance clone) { }

	public virtual void DeserializeSyncVars(NetworkReader reader, bool initialState) { }

	public void FixedUpdate() { }

	public object get_Item(string name) { }

	public string get_Networksource() { }

	public string get_Source() { }

	protected static void InvokeUserCode_RpcRun(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection) { }

	protected virtual void OnHide() { }

	protected virtual void OnNetworkStart() { }

	protected virtual void OnShow() { }

	public virtual void OnStartClient() { }

	protected virtual void PostClone() { }

	[ClientRpc]
	private void RpcRun() { }

	[MoonSharpHidden]
	public void Run() { }

	public virtual void SerializeSyncVars(NetworkWriter writer, bool forceAll) { }

	public void set_Item(string name, object value) { }

	public void set_Networksource(in string value) { }

	public void set_Source(string value) { }

	protected virtual void Start() { }

	public void Update() { }

	protected void UserCode_RpcRun() { }

	public virtual bool Weaved() { }

}

