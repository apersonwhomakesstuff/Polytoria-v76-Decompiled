namespace Polytoria.Networking;

public class PTAuthenticator : NetworkAuthenticator
{
	[CompilerGenerated]
	private sealed class <DelayedDisconnect>d__6 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public float waitTime; //Field offset: 0x20
		public NetworkConnectionToClient conn; //Field offset: 0x28

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
		public <DelayedDisconnect>d__6(int <>1__state) { }

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
	private sealed class <ValidateToken>d__5 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public AuthRequestMessage msg; //Field offset: 0x20
		public NetworkConnectionToClient conn; //Field offset: 0x30
		public PTAuthenticator <>4__this; //Field offset: 0x38
		private AuthResponseMessage <authResponseMessage>5__2; //Field offset: 0x40
		private bool <approve>5__3; //Field offset: 0x58
		private JSONNode <tokenData>5__4; //Field offset: 0x60
		private UnityWebRequest <uwr>5__5; //Field offset: 0x68

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
		public <ValidateToken>d__5(int <>1__state) { }

		private void <>m__Finally1() { }

		private void <>m__Finally2() { }

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

	internal struct AuthRequestMessage : NetworkMessage
	{
		public string clientToken; //Field offset: 0x0
		public int localUserId; //Field offset: 0x8

	}

	internal struct AuthResponseMessage : NetworkMessage
	{
		public byte code; //Field offset: 0x0
		public string message; //Field offset: 0x8
		public int instanceCount; //Field offset: 0x10

	}


	public PTAuthenticator() { }

	[IteratorStateMachine(typeof(<DelayedDisconnect>d__6))]
	public IEnumerator DelayedDisconnect(NetworkConnectionToClient conn, float waitTime) { }

	public void OnAuthRequestMessage(NetworkConnectionToClient conn, AuthRequestMessage msg) { }

	public void OnAuthResponseMessage(AuthResponseMessage msg) { }

	public virtual void OnClientAuthenticate() { }

	public virtual void OnServerAuthenticate(NetworkConnectionToClient conn) { }

	public virtual void OnStartClient() { }

	public virtual void OnStartServer() { }

	[IteratorStateMachine(typeof(<ValidateToken>d__5))]
	public IEnumerator ValidateToken(NetworkConnectionToClient conn, AuthRequestMessage msg) { }

}

