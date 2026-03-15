namespace Polytoria.Controllers;

public class AbuseReportController : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <SubmitAbuseReport>d__6 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public string message; //Field offset: 0x20
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
		public <SubmitAbuseReport>d__6(int <>1__state) { }

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

	[SerializeField]
	private TMP_InputField input; //Field offset: 0x20
	[SerializeField]
	private RectTransform defaultPanel; //Field offset: 0x28
	[SerializeField]
	private RectTransform finishedPanel; //Field offset: 0x30

	public AbuseReportController() { }

	public void Cancel() { }

	public void Return() { }

	public void Submit() { }

	[IteratorStateMachine(typeof(<SubmitAbuseReport>d__6))]
	private IEnumerator SubmitAbuseReport(string message) { }

}

