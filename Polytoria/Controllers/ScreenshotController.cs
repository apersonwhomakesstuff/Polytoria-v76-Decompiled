namespace Polytoria.Controllers;

public class ScreenshotController : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <DoPublishScreenshot>d__27 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public ScreenshotController <>4__this; //Field offset: 0x20
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
		public <DoPublishScreenshot>d__27(int <>1__state) { }

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
	private sealed class <DoScreenshot>d__24 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public bool hideUI; //Field offset: 0x20
		public ScreenshotController <>4__this; //Field offset: 0x28
		private string <path>5__2; //Field offset: 0x30
		private string <filename>5__3; //Field offset: 0x38

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
		public <DoScreenshot>d__24(int <>1__state) { }

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
	private static ScreenshotController <instance>k__BackingField; //Field offset: 0x0
	[SerializeField]
	private RectTransform toast; //Field offset: 0x20
	[SerializeField]
	private RectTransform publishModal; //Field offset: 0x28
	[SerializeField]
	public TMP_InputField captionInput; //Field offset: 0x30
	[SerializeField]
	private Button publishButton; //Field offset: 0x38
	[SerializeField]
	private TMP_Text publishError; //Field offset: 0x40
	private float toastDuration; //Field offset: 0x48
	private float toastTimer; //Field offset: 0x4C
	private bool toastActive; //Field offset: 0x50
	private string screenshotPath; //Field offset: 0x58
	private Sprite lastScreenshot; //Field offset: 0x60
	private string passphrase; //Field offset: 0x68
	private Byte[] screenshotBytes; //Field offset: 0x70

	public bool Focused
	{
		 get { } //Length: 123
	}

	public private static ScreenshotController instance
	{
		[CompilerGenerated]
		 get { } //Length: 54
		[CompilerGenerated]
		private set { } //Length: 81
	}

	public ScreenshotController() { }

	[CompilerGenerated]
	private void <Start>b__19_0() { }

	private void Awake() { }

	[IteratorStateMachine(typeof(<DoPublishScreenshot>d__27))]
	private IEnumerator DoPublishScreenshot() { }

	[IteratorStateMachine(typeof(<DoScreenshot>d__24))]
	private IEnumerator DoScreenshot(bool hideUI) { }

	public bool get_Focused() { }

	[CompilerGenerated]
	public static ScreenshotController get_instance() { }

	private void HideToast() { }

	public void OpenScreenshot() { }

	public void PublishScreenshot() { }

	public void Screenshot(bool hideUI) { }

	[CompilerGenerated]
	private static void set_instance(ScreenshotController value) { }

	private void ShowToast() { }

	private void Start() { }

	private void Update() { }

}

