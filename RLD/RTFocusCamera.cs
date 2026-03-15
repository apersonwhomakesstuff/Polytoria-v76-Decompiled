namespace RLD;

public class RTFocusCamera : MonoSingleton<RTFocusCamera>
{
	[CompilerGenerated]
	private sealed class <DoConstantFocus>d__134 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public RTFocusCamera <>4__this; //Field offset: 0x20
		public Data focusData; //Field offset: 0x28
		private float <targetOrthoSize>5__2; //Field offset: 0x30
		private Vector3 <camMoveDir>5__3; //Field offset: 0x34
		private float <distanceToTravel>5__4; //Field offset: 0x40
		private float <initialCamOrthoSize>5__5; //Field offset: 0x44

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
		public <DoConstantFocus>d__134(int <>1__state) { }

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
	private sealed class <DoConstantRotationSwitch>d__132 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public RTFocusCamera <>4__this; //Field offset: 0x20
		public Quaternion targetRotation; //Field offset: 0x28
		private Quaternion <sourceRotation>5__2; //Field offset: 0x38
		private float <elapsedTime>5__3; //Field offset: 0x48

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
		public <DoConstantRotationSwitch>d__132(int <>1__state) { }

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
	private sealed class <DoSmoothFocus>d__135 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public RTFocusCamera <>4__this; //Field offset: 0x20
		public Data focusData; //Field offset: 0x28
		private float <targetOrthoSize>5__2; //Field offset: 0x30
		private Vector3 <camMoveDir>5__3; //Field offset: 0x34
		private float <elapsedTime>5__4; //Field offset: 0x40

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
		public <DoSmoothFocus>d__135(int <>1__state) { }

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
	private sealed class <DoSmoothLookAround>d__129 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public RTFocusCamera <>4__this; //Field offset: 0x20
		public float deviceAxisX; //Field offset: 0x28
		public float deviceAxisY; //Field offset: 0x2C
		private Vector2 <rotationAmount>5__2; //Field offset: 0x30

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
		public <DoSmoothLookAround>d__129(int <>1__state) { }

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
	private sealed class <DoSmoothOrbit>d__130 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public RTFocusCamera <>4__this; //Field offset: 0x20
		public float deviceAxisX; //Field offset: 0x28
		public float deviceAxisY; //Field offset: 0x2C
		private Vector2 <rotationAmount>5__2; //Field offset: 0x30

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
		public <DoSmoothOrbit>d__130(int <>1__state) { }

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
	private sealed class <DoSmoothPan>d__128 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public RTFocusCamera <>4__this; //Field offset: 0x20
		public float deviceAxisX; //Field offset: 0x28
		public float deviceAxisY; //Field offset: 0x2C
		private Vector2 <panAmount>5__2; //Field offset: 0x30

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
		public <DoSmoothPan>d__128(int <>1__state) { }

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
	private sealed class <DoSmoothRotationSwitch>d__133 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public RTFocusCamera <>4__this; //Field offset: 0x20
		public Quaternion targetRotation; //Field offset: 0x28

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
		public <DoSmoothRotationSwitch>d__133(int <>1__state) { }

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
	private sealed class <DoSmoothZoom>d__131 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public RTFocusCamera <>4__this; //Field offset: 0x20
		public float deviceScroll; //Field offset: 0x28
		private float <zoomAmount>5__2; //Field offset: 0x2C

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
		public <DoSmoothZoom>d__131(int <>1__state) { }

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

	private enum MoveDirection : int
	{
		Left = 0,
		Right = 1,
		Up = 2,
		Down = 3,
		Forward = 4,
		Backwards = 5,
	}

	[CompilerGenerated]
	private CameraProjectionSwitchBeginHandler PrjSwitchTransitionBegin; //Field offset: 0x20
	[CompilerGenerated]
	private CameraProjectionSwitchUpdateHandler PrjSwitchTransitionUpdate; //Field offset: 0x28
	[CompilerGenerated]
	private CameraProjectionSwitchBeginHandler PrjSwitchTransitionEnd; //Field offset: 0x30
	[CompilerGenerated]
	private CameraCanProcessInputHandler CanProcessInput; //Field offset: 0x38
	[CompilerGenerated]
	private CameraCanUseScrollWheelHandler CanUseScrollWheel; //Field offset: 0x40
	[SerializeField]
	private Camera _targetCamera; //Field offset: 0x48
	private Transform _targetTransform; //Field offset: 0x50
	[SerializeField]
	private float _fieldOfView; //Field offset: 0x58
	private WorldTransformSnapshot _worldTransformSnapshot; //Field offset: 0x60
	private CameraPrjSwitchTransition _prjSwitchTranstion; //Field offset: 0x68
	private bool _isDoingFocus; //Field offset: 0x70
	private IEnumerator _focusCrtn; //Field offset: 0x78
	private bool _isDoingRotationSwitch; //Field offset: 0x80
	private IEnumerator _genricCamTransformCrtn; //Field offset: 0x88
	private bool _isObjectVisibilityDirty; //Field offset: 0x90
	private List<GameObject> _visibleObjects; //Field offset: 0x98
	private float _focusPointOffset; //Field offset: 0xA0
	private Vector3 _lastFocusPoint; //Field offset: 0xA4
	private Boolean[] _moveDirFlags; //Field offset: 0xB0
	private float _currentAcceleration; //Field offset: 0xB8
	[SerializeField]
	private CameraSettings _settings; //Field offset: 0xC0
	[SerializeField]
	private CameraMoveSettings _moveSettings; //Field offset: 0xC8
	[SerializeField]
	private CameraPanSettings _panSettings; //Field offset: 0xD0
	[SerializeField]
	private CameraLookAroundSettings _lookAroundSettings; //Field offset: 0xD8
	[SerializeField]
	private CameraOrbitSettings _orbitSettings; //Field offset: 0xE0
	[SerializeField]
	private CameraZoomSettings _zoomSettings; //Field offset: 0xE8
	[SerializeField]
	private CameraFocusSettings _focusSettings; //Field offset: 0xF0
	[SerializeField]
	private CameraRotationSwitchSettings _rotationSwitchSettings; //Field offset: 0xF8
	[SerializeField]
	private CameraProjectionSwitchSettings _projectionSwitchSettings; //Field offset: 0x100
	[SerializeField]
	private CameraHotkeys _hotkeys; //Field offset: 0x108

	public event CameraCanProcessInputHandler CanProcessInput
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public event CameraCanUseScrollWheelHandler CanUseScrollWheel
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public event CameraProjectionSwitchBeginHandler PrjSwitchTransitionBegin
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public event CameraProjectionSwitchBeginHandler PrjSwitchTransitionEnd
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public event CameraProjectionSwitchUpdateHandler PrjSwitchTransitionUpdate
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public CameraFocusSettings FocusSettings
	{
		 get { } //Length: 8
	}

	public CameraHotkeys Hotkeys
	{
		 get { } //Length: 8
	}

	public bool IsDoingFocus
	{
		 get { } //Length: 5
	}

	public bool IsDoingProjectionSwitch
	{
		 get { } //Length: 30
	}

	public bool IsDoingRotationSwitch
	{
		 get { } //Length: 8
	}

	public bool IsMovingBackwards
	{
		 get { } //Length: 45
	}

	public bool IsMovingDown
	{
		 get { } //Length: 45
	}

	public bool IsMovingForward
	{
		 get { } //Length: 45
	}

	public bool IsMovingLeft
	{
		 get { } //Length: 45
	}

	public bool IsMovingRight
	{
		 get { } //Length: 45
	}

	public bool IsMovingUp
	{
		 get { } //Length: 45
	}

	public Vector3 Look
	{
		 get { } //Length: 59
	}

	public CameraLookAroundSettings LookAroundSettings
	{
		 get { } //Length: 8
	}

	public CameraMoveSettings MoveSettings
	{
		 get { } //Length: 8
	}

	public CameraOrbitSettings OrbitSettings
	{
		 get { } //Length: 8
	}

	public CameraPanSettings PanSettings
	{
		 get { } //Length: 8
	}

	public float PrjSwitchDurationInSeconds
	{
		 get { } //Length: 31
	}

	public float PrjSwitchProgress
	{
		 get { } //Length: 28
	}

	public Type PrjSwitchTransitionType
	{
		 get { } //Length: 26
	}

	public CameraProjectionSwitchSettings ProjectionSwitchSettings
	{
		 get { } //Length: 8
	}

	public Vector3 Right
	{
		 get { } //Length: 59
	}

	public CameraRotationSwitchSettings RotationSwitchSettings
	{
		 get { } //Length: 8
	}

	public CameraSettings Settings
	{
		 get { } //Length: 8
	}

	public Camera TargetCamera
	{
		 get { } //Length: 5
	}

	public Vector3 Up
	{
		 get { } //Length: 59
	}

	public Vector3 WorldPosition
	{
		 get { } //Length: 59
		 set { } //Length: 217
	}

	public Quaternion WorldRotation
	{
		 get { } //Length: 51
		 set { } //Length: 44
	}

	public CameraZoomSettings ZoomSettings
	{
		 get { } //Length: 8
	}

	public RTFocusCamera() { }

	[CompilerGenerated]
	public void add_CanProcessInput(CameraCanProcessInputHandler value) { }

	[CompilerGenerated]
	public void add_CanUseScrollWheel(CameraCanUseScrollWheelHandler value) { }

	[CompilerGenerated]
	public void add_PrjSwitchTransitionBegin(CameraProjectionSwitchBeginHandler value) { }

	[CompilerGenerated]
	public void add_PrjSwitchTransitionEnd(CameraProjectionSwitchBeginHandler value) { }

	[CompilerGenerated]
	public void add_PrjSwitchTransitionUpdate(CameraProjectionSwitchUpdateHandler value) { }

	private void AdjustOrthoSizeForFocusPt() { }

	private void Awake() { }

	private Vector2 CalculateLookAroundRotation(float deviceAxisX, float deviceAxisY) { }

	private Vector2 CalculateOrbitRotation(float deviceAxisX, float deviceAxisY) { }

	private Vector2 CalculatePanAmount(float deviceAxisX, float deviceAxisY) { }

	private float CalculateScrollZoomAmount(float deviceScroll) { }

	private bool CanCameraProcessInput() { }

	private bool CanUseMouseScrollWheel() { }

	[IteratorStateMachine(typeof(<DoConstantFocus>d__134))]
	private IEnumerator DoConstantFocus(Data focusData) { }

	[IteratorStateMachine(typeof(<DoConstantRotationSwitch>d__132))]
	private IEnumerator DoConstantRotationSwitch(Quaternion targetRotation) { }

	[IteratorStateMachine(typeof(<DoSmoothFocus>d__135))]
	private IEnumerator DoSmoothFocus(Data focusData) { }

	[IteratorStateMachine(typeof(<DoSmoothLookAround>d__129))]
	private IEnumerator DoSmoothLookAround(float deviceAxisX, float deviceAxisY) { }

	[IteratorStateMachine(typeof(<DoSmoothOrbit>d__130))]
	private IEnumerator DoSmoothOrbit(float deviceAxisX, float deviceAxisY) { }

	[IteratorStateMachine(typeof(<DoSmoothPan>d__128))]
	private IEnumerator DoSmoothPan(float deviceAxisX, float deviceAxisY) { }

	[IteratorStateMachine(typeof(<DoSmoothRotationSwitch>d__133))]
	private IEnumerator DoSmoothRotationSwitch(Quaternion targetRotation) { }

	[IteratorStateMachine(typeof(<DoSmoothZoom>d__131))]
	private IEnumerator DoSmoothZoom(float deviceScroll) { }

	public void Focus(AABB focusAABB) { }

	public CameraFocusSettings get_FocusSettings() { }

	public CameraHotkeys get_Hotkeys() { }

	public bool get_IsDoingFocus() { }

	public bool get_IsDoingProjectionSwitch() { }

	public bool get_IsDoingRotationSwitch() { }

	public bool get_IsMovingBackwards() { }

	public bool get_IsMovingDown() { }

	public bool get_IsMovingForward() { }

	public bool get_IsMovingLeft() { }

	public bool get_IsMovingRight() { }

	public bool get_IsMovingUp() { }

	public Vector3 get_Look() { }

	public CameraLookAroundSettings get_LookAroundSettings() { }

	public CameraMoveSettings get_MoveSettings() { }

	public CameraOrbitSettings get_OrbitSettings() { }

	public CameraPanSettings get_PanSettings() { }

	public float get_PrjSwitchDurationInSeconds() { }

	public float get_PrjSwitchProgress() { }

	public Type get_PrjSwitchTransitionType() { }

	public CameraProjectionSwitchSettings get_ProjectionSwitchSettings() { }

	public Vector3 get_Right() { }

	public CameraRotationSwitchSettings get_RotationSwitchSettings() { }

	public CameraSettings get_Settings() { }

	public Camera get_TargetCamera() { }

	public Vector3 get_Up() { }

	public Vector3 get_WorldPosition() { }

	public Quaternion get_WorldRotation() { }

	public CameraZoomSettings get_ZoomSettings() { }

	private Vector3 GetFocusPoint() { }

	public void GetVisibleObjects(List<GameObject> visibleObjects) { }

	private void HandleMouseAndKeyboardInput() { }

	public bool IsViewportHoveredByDevice() { }

	public void LookAround(float degreesLocalX, float degreesWorldY) { }

	private void OnPrjSwitchTransitionBegin(Type transitionType) { }

	private void OnPrjSwitchTransitionEnd(Type transitionType) { }

	private void OnPrjSwitchTransitionUpate(Type transitionType) { }

	private void Orbit(float degreesLocalX, float degreesWorldY) { }

	private void Pan(Vector2 panAmount) { }

	private void PerformInstantFocus(Data focusData) { }

	private void PerformInstantProjectionSwitch() { }

	public void PerformProjectionSwitch() { }

	public void PerformRotationSwitch(Quaternion targetRotation) { }

	[CompilerGenerated]
	public void remove_CanProcessInput(CameraCanProcessInputHandler value) { }

	[CompilerGenerated]
	public void remove_CanUseScrollWheel(CameraCanUseScrollWheelHandler value) { }

	[CompilerGenerated]
	public void remove_PrjSwitchTransitionBegin(CameraProjectionSwitchBeginHandler value) { }

	[CompilerGenerated]
	public void remove_PrjSwitchTransitionEnd(CameraProjectionSwitchBeginHandler value) { }

	[CompilerGenerated]
	public void remove_PrjSwitchTransitionUpdate(CameraProjectionSwitchUpdateHandler value) { }

	public void set_WorldPosition(Vector3 value) { }

	public void set_WorldRotation(Quaternion value) { }

	public void SetFieldOfView(float fov) { }

	private void SetFocusPoint(Vector3 focusPoint) { }

	public void SetObjectVisibilityDirty() { }

	public void SetTargetCamera(Camera camera) { }

	private void Start() { }

	private void StopCamTransform() { }

	private void StopFocus() { }

	public void Update_SystemCall() { }

	private void Zoom(float zoomAmount) { }

}

