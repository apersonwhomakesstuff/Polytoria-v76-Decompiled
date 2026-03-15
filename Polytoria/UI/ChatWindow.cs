namespace Polytoria.UI;

public class ChatWindow : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Action <>9__28_1; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal void <inactiveFade>b__28_1() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass28_0
	{
		public TMP_Text txt; //Field offset: 0x10

		public <>c__DisplayClass28_0() { }

		internal void <inactiveFade>b__0(float val) { }

	}

	[CompilerGenerated]
	private sealed class <inactiveFade>d__28 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public ChatMessageRef t; //Field offset: 0x20
		private <>c__DisplayClass28_0 <>8__1; //Field offset: 0x28

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
		public <inactiveFade>d__28(int <>1__state) { }

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

	private const float chatFadeTime = 0.3; //Field offset: 0x0
	private const float chatStayTime = 10; //Field offset: 0x0
	public static ChatWindow instance; //Field offset: 0x0
	private Image darken; //Field offset: 0x20
	private Scrollbar scrollbar; //Field offset: 0x28
	private Image focusImage; //Field offset: 0x30
	public TMP_InputField input; //Field offset: 0x38
	private ScrollRect scrollRect; //Field offset: 0x40
	private RectTransform chatMessage; //Field offset: 0x48
	[CompilerGenerated]
	private RectTransform <ChatContainer>k__BackingField; //Field offset: 0x50
	private ChatWindowState _state; //Field offset: 0x58
	private RectTransform PopContainer; //Field offset: 0x60
	public Vector2 normalSize; //Field offset: 0x68
	public Vector2 focusedSize; //Field offset: 0x70
	public float stateChangeCooldown; //Field offset: 0x78
	public float StateChangeRateLimit; //Field offset: 0x7C
	public UICommandList commandList; //Field offset: 0x80
	private List<ChatMessageRef> chatMessages; //Field offset: 0x88

	public private RectTransform ChatContainer
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 13
	}

	public bool Focused
	{
		 get { } //Length: 30
	}

	public ChatWindowState state
	{
		 get { } //Length: 4
		 set { } //Length: 1898
	}

	public ChatWindow() { }

	[CompilerGenerated]
	private void <set_state>b__22_0(float val) { }

	[CompilerGenerated]
	private void <set_state>b__22_1(float val) { }

	[CompilerGenerated]
	private void <set_state>b__22_2(float val) { }

	[CompilerGenerated]
	private void <set_state>b__22_3() { }

	[CompilerGenerated]
	private void <set_state>b__22_4(float val) { }

	[CompilerGenerated]
	private void <set_state>b__22_5() { }

	[CompilerGenerated]
	private void <set_state>b__22_6(float val) { }

	[CompilerGenerated]
	private void <Start>b__25_0(string <p0>) { }

	private void Awake() { }

	[CompilerGenerated]
	public RectTransform get_ChatContainer() { }

	public bool get_Focused() { }

	public ChatWindowState get_state() { }

	[IteratorStateMachine(typeof(<inactiveFade>d__28))]
	private IEnumerator inactiveFade(ChatMessageRef t) { }

	public void PushChat(string username, string message, Color usernameColor) { }

	private void scrollViewToBottom() { }

	[CompilerGenerated]
	private void set_ChatContainer(RectTransform value) { }

	public void set_state(ChatWindowState value) { }

	public void SetInactive() { }

	private void Start() { }

	public void ToggleFocused() { }

	private void Update() { }

}

