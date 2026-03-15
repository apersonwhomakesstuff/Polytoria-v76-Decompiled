namespace Polytoria.Datamodel;

public class Camera : DynamicInstance
{
	public static float sensitivityModifier; //Field offset: 0x0
	public static Camera Instance; //Field offset: 0x8
	public static LayerMask clipIgnoreLayers; //Field offset: 0x10
	public static List<MeshRenderer> disableOnFirstPerson; //Field offset: 0x18
	private Camera cam; //Field offset: 0x210
	private Transform target; //Field offset: 0x218
	private float distance; //Field offset: 0x220
	private float distanceLerp; //Field offset: 0x224
	private float xSpeed; //Field offset: 0x228
	private float ySpeed; //Field offset: 0x22C
	private float yMinLimit; //Field offset: 0x230
	private float yMaxLimit; //Field offset: 0x234
	private float distanceMax; //Field offset: 0x238
	private float minDist; //Field offset: 0x23C
	private float maxDist; //Field offset: 0x240
	private bool clipThroughWalls; //Field offset: 0x244
	private float scrollSensitivity; //Field offset: 0x248
	private float flySpeed; //Field offset: 0x24C
	private float fastFlySpeed; //Field offset: 0x250
	private float freeLookSensitivity; //Field offset: 0x254
	private float x; //Field offset: 0x258
	private float y; //Field offset: 0x25C
	private bool init; //Field offset: 0x260
	private bool wasLocked; //Field offset: 0x261
	private bool looking; //Field offset: 0x262
	private bool locked; //Field offset: 0x263
	private bool wasFirstPerson; //Field offset: 0x264
	[CompilerGenerated]
	private CameraMode <Mode>k__BackingField; //Field offset: 0x268
	[CompilerGenerated]
	private float <LerpSpeed>k__BackingField; //Field offset: 0x26C
	[CompilerGenerated]
	private bool <FollowLerp>k__BackingField; //Field offset: 0x270
	[CompilerGenerated]
	private bool <CanLock>k__BackingField; //Field offset: 0x271
	[CompilerGenerated]
	private bool <CtrlLocked>k__BackingField; //Field offset: 0x272
	[CompilerGenerated]
	private float <SensitivityMultiplier>k__BackingField; //Field offset: 0x274
	[CompilerGenerated]
	private Vector3 <PositionOffset>k__BackingField; //Field offset: 0x278
	[CompilerGenerated]
	private Vector3 <RotationOffset>k__BackingField; //Field offset: 0x284
	private int lastDisableFPCount; //Field offset: 0x290
	private DynamicInstance followTargetInstance; //Field offset: 0x298
	private Transform followTargetTransform; //Field offset: 0x2A0

	[Archivable]
	[CreatorProperty]
	public bool CanLock
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 7
	}

	[Archivable]
	[CreatorProperty]
	public bool ClipThroughWalls
	{
		 get { } //Length: 8
		 set { } //Length: 7
	}

	public bool CtrlLocked
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 7
	}

	public float Distance
	{
		 get { } //Length: 9
		 set { } //Length: 9
	}

	private bool DoLerp
	{
		private get { } //Length: 29
	}

	protected virtual bool DoTransformSync
	{
		 get { } //Length: 3
	}

	public float FastFlySpeed
	{
		 get { } //Length: 9
		 set { } //Length: 9
	}

	public float FlySpeed
	{
		 get { } //Length: 9
		 set { } //Length: 9
	}

	public bool FollowLerp
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 7
	}

	public DynamicInstance FollowTarget
	{
		 get { } //Length: 8
		 set { } //Length: 257
	}

	[Archivable]
	[CreatorProperty]
	public float FOV
	{
		 get { } //Length: 32
		 set { } //Length: 33
	}

	public float FreeLookSensitivity
	{
		 get { } //Length: 9
		 set { } //Length: 9
	}

	public float HorizontalSpeed
	{
		 get { } //Length: 9
		 set { } //Length: 9
	}

	public bool IsFirstPerson
	{
		 get { } //Length: 24
	}

	public float LerpSpeed
	{
		[CompilerGenerated]
		 get { } //Length: 9
		[CompilerGenerated]
		 set { } //Length: 9
	}

	[Archivable]
	[CreatorProperty]
	public float MaxDistance
	{
		 get { } //Length: 9
		 set { } //Length: 9
	}

	[Archivable]
	[CreatorProperty]
	public float MinDistance
	{
		 get { } //Length: 9
		 set { } //Length: 9
	}

	[Archivable]
	[CreatorProperty]
	public CameraMode Mode
	{
		[CompilerGenerated]
		 get { } //Length: 7
		[CompilerGenerated]
		 set { } //Length: 7
	}

	[Archivable]
	[CreatorProperty]
	public bool Orthographic
	{
		 get { } //Length: 32
		 set { } //Length: 33
	}

	[Archivable]
	[CreatorProperty]
	public float OrthographicSize
	{
		 get { } //Length: 32
		 set { } //Length: 33
	}

	[Archivable]
	[CreatorProperty]
	public Vector3 PositionOffset
	{
		[CompilerGenerated]
		 get { } //Length: 25
		[CompilerGenerated]
		 set { } //Length: 22
	}

	[Archivable]
	[CreatorProperty]
	public Vector3 RotationOffset
	{
		[CompilerGenerated]
		 get { } //Length: 25
		[CompilerGenerated]
		 set { } //Length: 22
	}

	public float ScrollSensitivity
	{
		 get { } //Length: 9
		 set { } //Length: 9
	}

	public float SensitivityMultiplier
	{
		[CompilerGenerated]
		 get { } //Length: 9
		[CompilerGenerated]
		 set { } //Length: 9
	}

	public float VerticalSpeed
	{
		 get { } //Length: 9
		 set { } //Length: 9
	}

	private static Camera() { }

	public Camera() { }

	private void ApplyCameraTransform(Transform followTarget) { }

	protected virtual void Awake() { }

	private void CalculateWallClipping(Transform followTarget) { }

	private static float ClampAngle(float angle, float min, float max) { }

	private void ClampDistance() { }

	[CompilerGenerated]
	public bool get_CanLock() { }

	public bool get_ClipThroughWalls() { }

	[CompilerGenerated]
	public bool get_CtrlLocked() { }

	public float get_Distance() { }

	private bool get_DoLerp() { }

	protected virtual bool get_DoTransformSync() { }

	public float get_FastFlySpeed() { }

	public float get_FlySpeed() { }

	[CompilerGenerated]
	public bool get_FollowLerp() { }

	public DynamicInstance get_FollowTarget() { }

	public float get_FOV() { }

	public float get_FreeLookSensitivity() { }

	public float get_HorizontalSpeed() { }

	public bool get_IsFirstPerson() { }

	[CompilerGenerated]
	public float get_LerpSpeed() { }

	public float get_MaxDistance() { }

	public float get_MinDistance() { }

	[CompilerGenerated]
	public CameraMode get_Mode() { }

	public bool get_Orthographic() { }

	public float get_OrthographicSize() { }

	[CompilerGenerated]
	public Vector3 get_PositionOffset() { }

	[CompilerGenerated]
	public Vector3 get_RotationOffset() { }

	public float get_ScrollSensitivity() { }

	[CompilerGenerated]
	public float get_SensitivityMultiplier() { }

	public float get_VerticalSpeed() { }

	private void HandleCameraRotation() { }

	private void HandleCursorLocking() { }

	private void HandleFirstPersonRendering() { }

	private void HandleFreeLook() { }

	private void HandleFreeLookToggle() { }

	private void HandleFreeMovement() { }

	private void HandleFreeZoom() { }

	private void HandleLockInput() { }

	private float HandleScrollInput() { }

	private void HandleScrollZoom(float scroll) { }

	private void LateUpdate() { }

	private void OnDisable() { }

	[CompilerGenerated]
	public void set_CanLock(bool value) { }

	public void set_ClipThroughWalls(bool value) { }

	[CompilerGenerated]
	public void set_CtrlLocked(bool value) { }

	public void set_Distance(float value) { }

	public void set_FastFlySpeed(float value) { }

	public void set_FlySpeed(float value) { }

	[CompilerGenerated]
	public void set_FollowLerp(bool value) { }

	public void set_FollowTarget(DynamicInstance value) { }

	public void set_FOV(float value) { }

	public void set_FreeLookSensitivity(float value) { }

	public void set_HorizontalSpeed(float value) { }

	[CompilerGenerated]
	public void set_LerpSpeed(float value) { }

	public void set_MaxDistance(float value) { }

	public void set_MinDistance(float value) { }

	[CompilerGenerated]
	public void set_Mode(CameraMode value) { }

	public void set_Orthographic(bool value) { }

	public void set_OrthographicSize(float value) { }

	[CompilerGenerated]
	public void set_PositionOffset(Vector3 value) { }

	[CompilerGenerated]
	public void set_RotationOffset(Vector3 value) { }

	public void set_ScrollSensitivity(float value) { }

	[CompilerGenerated]
	public void set_SensitivityMultiplier(float value) { }

	public void set_VerticalSpeed(float value) { }

	[MoonSharpHidden]
	private void SetFollowTarget(DynamicInstance instance) { }

	[MoonSharpHidden]
	public void SetTarget(Transform target) { }

	private bool ShouldProcessCameraInput() { }

	protected virtual void Start() { }

	private void StartLooking() { }

	private void StopLooking() { }

	private void UpdateFollow() { }

	private void UpdateFollowMode(Transform followTarget) { }

	private void UpdateFollowTarget() { }

	private void UpdateFree() { }

	public virtual bool Weaved() { }

}

