namespace RLD;

public class CameraPrjSwitchTransition
{
	[CompilerGenerated]
	private sealed class <DoTransition>d__41 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public CameraPrjSwitchTransition <>4__this; //Field offset: 0x20
		private float <frustumHeight>5__2; //Field offset: 0x28
		private float <targetFOV>5__3; //Field offset: 0x2C
		private float <invDuration>5__4; //Field offset: 0x30
		private float <fovSpeed>5__5; //Field offset: 0x34
		private Transform <_targetTransform>5__6; //Field offset: 0x38

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
		public <DoTransition>d__41(int <>1__state) { }

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

	internal enum Type : int
	{
		None = 0,
		ToOrtho = 1,
		ToPerspective = 2,
	}

	[CompilerGenerated]
	private CameraProjectionSwitchBeginHandler TransitionBegin; //Field offset: 0x10
	[CompilerGenerated]
	private CameraProjectionSwitchUpdateHandler TransitionUpdate; //Field offset: 0x18
	[CompilerGenerated]
	private CameraProjectionSwitchBeginHandler TransitionEnd; //Field offset: 0x20
	private IEnumerator _transitionCrtn; //Field offset: 0x28
	private MonoBehaviour _targetMono; //Field offset: 0x30
	private Camera _targetCamera; //Field offset: 0x38
	private float _camFieldOfView; //Field offset: 0x40
	private Vector3 _camFocusPoint; //Field offset: 0x44
	private Vector3 _camRestorePosition; //Field offset: 0x50
	private Type _transitionType; //Field offset: 0x5C
	private float _durationInSeconds; //Field offset: 0x60
	private float _progress; //Field offset: 0x64

	public event CameraProjectionSwitchBeginHandler TransitionBegin
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public event CameraProjectionSwitchBeginHandler TransitionEnd
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public event CameraProjectionSwitchUpdateHandler TransitionUpdate
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public float CamFieldOfView
	{
		 get { } //Length: 6
		 set { } //Length: 19
	}

	public Vector3 CamFocusPoint
	{
		 get { } //Length: 19
		 set { } //Length: 22
	}

	public float DurationInSeconds
	{
		 get { } //Length: 6
		 set { } //Length: 31
	}

	public bool IsActive
	{
		 get { } //Length: 8
	}

	public float Progress
	{
		 get { } //Length: 6
	}

	public Camera TargetCamera
	{
		 get { } //Length: 5
		 set { } //Length: 115
	}

	public MonoBehaviour TargetMono
	{
		 get { } //Length: 95
		 set { } //Length: 115
	}

	public Type TransitionType
	{
		 get { } //Length: 4
	}

	public CameraPrjSwitchTransition() { }

	[CompilerGenerated]
	public void add_TransitionBegin(CameraProjectionSwitchBeginHandler value) { }

	[CompilerGenerated]
	public void add_TransitionEnd(CameraProjectionSwitchBeginHandler value) { }

	[CompilerGenerated]
	public void add_TransitionUpdate(CameraProjectionSwitchUpdateHandler value) { }

	public void Begin() { }

	[IteratorStateMachine(typeof(<DoTransition>d__41))]
	private IEnumerator DoTransition() { }

	public float get_CamFieldOfView() { }

	public Vector3 get_CamFocusPoint() { }

	public float get_DurationInSeconds() { }

	public bool get_IsActive() { }

	public float get_Progress() { }

	public Camera get_TargetCamera() { }

	public MonoBehaviour get_TargetMono() { }

	public Type get_TransitionType() { }

	[CompilerGenerated]
	public void remove_TransitionBegin(CameraProjectionSwitchBeginHandler value) { }

	[CompilerGenerated]
	public void remove_TransitionEnd(CameraProjectionSwitchBeginHandler value) { }

	[CompilerGenerated]
	public void remove_TransitionUpdate(CameraProjectionSwitchUpdateHandler value) { }

	public void set_CamFieldOfView(float value) { }

	public void set_CamFocusPoint(Vector3 value) { }

	public void set_DurationInSeconds(float value) { }

	public void set_TargetCamera(Camera value) { }

	public void set_TargetMono(MonoBehaviour value) { }

}

