namespace Polytoria.Controllers;

public class NetworkController : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <PlaySolo>d__9 : IEnumerator<Object>, IEnumerator, IDisposable
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
		public <PlaySolo>d__9(int <>1__state) { }

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
	private sealed class <StartClient>d__8 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public NetworkController <>4__this; //Field offset: 0x20
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
		public <StartClient>d__8(int <>1__state) { }

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

	public static NetworkController singleton; //Field offset: 0x0
	private string passphrase; //Field offset: 0x20
	[CompilerGenerated]
	private int <PlaceID>k__BackingField; //Field offset: 0x28

	public private int PlaceID
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public NetworkController() { }

	private void Awake() { }

	[CompilerGenerated]
	public int get_PlaceID() { }

	[IteratorStateMachine(typeof(<PlaySolo>d__9))]
	private IEnumerator PlaySolo() { }

	[CompilerGenerated]
	private void set_PlaceID(int value) { }

	private void Start() { }

	[IteratorStateMachine(typeof(<StartClient>d__8))]
	private IEnumerator StartClient() { }

	private void Update() { }

}

