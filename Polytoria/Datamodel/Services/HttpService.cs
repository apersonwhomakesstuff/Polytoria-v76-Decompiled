namespace Polytoria.Datamodel.Services;

public class HttpService : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <DoRequest>d__11 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public string url; //Field offset: 0x20
		public string method; //Field offset: 0x28
		public string body; //Field offset: 0x30
		public Table headers; //Field offset: 0x38
		public DynValue callback; //Field offset: 0x40
		private UnityWebRequest <uwr>5__2; //Field offset: 0x48

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
		public <DoRequest>d__11(int <>1__state) { }

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

	public static HttpService instance; //Field offset: 0x0
	private static int maxRequestsPerMinute; //Field offset: 0x8
	private static int requestsThisMinute; //Field offset: 0xC
	private static int currentMinute; //Field offset: 0x10

	private static HttpService() { }

	public HttpService() { }

	private void Awake() { }

	public static void Delete(string url, DynValue callback = null, Table headers = null) { }

	[IteratorStateMachine(typeof(<DoRequest>d__11))]
	private static IEnumerator DoRequest(string method, string url, string body = null, DynValue callback = null, Table headers = null) { }

	public static void Get(string url, DynValue callback = null, Table headers = null) { }

	public static void Patch(string url, string body, DynValue callback = null, Table headers = null) { }

	public static void Post(string url, string body, DynValue callback = null, Table headers = null) { }

	public static void Put(string url, string body, DynValue callback = null, Table headers = null) { }

	private static bool RateLimit(DynValue callback = null) { }

}

