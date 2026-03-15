namespace RLD;

public class ColorTransition
{
	internal sealed class ColorTransitionBeginHandler : MulticastDelegate
	{

		public ColorTransitionBeginHandler(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(ColorTransition colorTransition, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(ColorTransition colorTransition) { }

	}

	internal sealed class ColorTransitionEndHandler : MulticastDelegate
	{

		public ColorTransitionEndHandler(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(ColorTransition colorTransition, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(ColorTransition colorTransition) { }

	}

	internal enum State : int
	{
		CompleteFadeIn = 0,
		CompleteFadeOut = 1,
		FadingIn = 2,
		FadingOut = 3,
		Ready = 4,
	}

	[CompilerGenerated]
	private ColorTransitionBeginHandler TransitionBegin; //Field offset: 0x10
	[CompilerGenerated]
	private ColorTransitionEndHandler TransitionEnd; //Field offset: 0x18
	private ColorRef _colorRef; //Field offset: 0x20
	private Color _fadeInColor; //Field offset: 0x28
	private Color _fadeOutColor; //Field offset: 0x38
	private State _state; //Field offset: 0x48
	private float _durationInSeconds; //Field offset: 0x4C
	private float _elapsedTimeInSeconds; //Field offset: 0x50
	private bool _isActive; //Field offset: 0x54

	public event ColorTransitionBeginHandler TransitionBegin
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public event ColorTransitionEndHandler TransitionEnd
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public float DurationInSeconds
	{
		 get { } //Length: 6
		 set { } //Length: 15
	}

	public Color FadeInColor
	{
		 get { } //Length: 11
		 set { } //Length: 8
	}

	public Color FadeOutColor
	{
		 get { } //Length: 11
		 set { } //Length: 8
	}

	public bool IsActive
	{
		 get { } //Length: 5
	}

	public State TransitionState
	{
		 get { } //Length: 4
	}

	public ColorTransition(ColorRef colorRef) { }

	[CompilerGenerated]
	public void add_TransitionBegin(ColorTransitionBeginHandler value) { }

	[CompilerGenerated]
	public void add_TransitionEnd(ColorTransitionEndHandler value) { }

	public void BeginFadeIn(bool startFromCurrentColor) { }

	public void BeginFadeOut(bool startFromCurrentColor) { }

	private void End() { }

	public float get_DurationInSeconds() { }

	public Color get_FadeInColor() { }

	public Color get_FadeOutColor() { }

	public bool get_IsActive() { }

	public State get_TransitionState() { }

	[CompilerGenerated]
	public void remove_TransitionBegin(ColorTransitionBeginHandler value) { }

	[CompilerGenerated]
	public void remove_TransitionEnd(ColorTransitionEndHandler value) { }

	public void set_DurationInSeconds(float value) { }

	public void set_FadeInColor(Color value) { }

	public void set_FadeOutColor(Color value) { }

	public void Update(float elapsedTime) { }

}

