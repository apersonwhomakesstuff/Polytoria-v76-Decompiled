namespace Polytoria.Datamodel.Services;

public class DataStoreService : NetworkBehaviour
{
	[CompilerGenerated]
	private sealed class <DoLoadFromServer>d__20 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public GetDataStoreQueueEntry entry; //Field offset: 0x20
		public DataStoreService <>4__this; //Field offset: 0x28
		private Datastore <ds>5__2; //Field offset: 0x30
		private UnityWebRequest <uwr>5__3; //Field offset: 0x38

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
		public <DoLoadFromServer>d__20(int <>1__state) { }

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
	private sealed class <DoWriteToServer>d__22 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public object value; //Field offset: 0x20
		public string key; //Field offset: 0x28
		public Datastore ds; //Field offset: 0x30
		public Action<Boolean> callback; //Field offset: 0x38
		private UnityWebRequest <uwr>5__2; //Field offset: 0x40

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
		public <DoWriteToServer>d__22(int <>1__state) { }

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
	private static DataStoreService <Instance>k__BackingField; //Field offset: 0x0
	public int MaxReadRequestsPerMinute; //Field offset: 0x68
	public int ReadRequestsPerPlayerModifier; //Field offset: 0x6C
	public int MaxWriteRequestsPerMinute; //Field offset: 0x70
	public int WriteRequestsPerPlayerModifier; //Field offset: 0x74
	private Queue<GetDataStoreQueueEntry> getDataStoreQueue; //Field offset: 0x78
	private Dictionary<String, Datastore> datastores; //Field offset: 0x80
	private int readRequestsThisMinute; //Field offset: 0x88
	private int writeRequestThisMinute; //Field offset: 0x8C
	private int currentMinute; //Field offset: 0x90
	private bool isGettingDatastore; //Field offset: 0x94

	public private static DataStoreService Instance
	{
		[CompilerGenerated]
		 get { } //Length: 54
		[CompilerGenerated]
		private set { } //Length: 81
	}

	public DataStoreService() { }

	private void Awake() { }

	[IteratorStateMachine(typeof(<DoLoadFromServer>d__20))]
	private IEnumerator DoLoadFromServer(GetDataStoreQueueEntry entry) { }

	[IteratorStateMachine(typeof(<DoWriteToServer>d__22))]
	private IEnumerator DoWriteToServer(Datastore ds, string key, object value, Action<Boolean> callback) { }

	[CompilerGenerated]
	public static DataStoreService get_Instance() { }

	public Datastore GetDatastore(string key) { }

	public void LoadFromServer(Datastore ds, Action<Boolean> callback) { }

	[CompilerGenerated]
	private static void set_Instance(DataStoreService value) { }

	private void Update() { }

	public bool UseReadRequest() { }

	public bool UseWriteRequest() { }

	public virtual bool Weaved() { }

	public void WriteToServer(Datastore ds, string key, object value, Action<Boolean> callback) { }

}

