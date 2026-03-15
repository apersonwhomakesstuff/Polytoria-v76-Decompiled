namespace Polytoria.Datamodel;

[Instantiatable]
[RequireComponent(typeof(ParticleSystem))]
public class Particles : DynamicInstance
{
	private ParticleSystem particles; //Field offset: 0x210
	[SyncVar(hook = "OnImageIDChanged")]
	private string imageID; //Field offset: 0x218
	[SyncVar(hook = "OnImageTypeChanged")]
	private ImageType imageType; //Field offset: 0x220
	[SyncVar(hook = "OnColorChanged")]
	private ColorRange color; //Field offset: 0x224
	[SyncVar(hook = "OnColorModeChanged")]
	private ParticleColorMode colorMode; //Field offset: 0x244
	[SyncVar(hook = "OnLifetimeChanged")]
	private NumberRange lifetime; //Field offset: 0x248
	[SyncVar(hook = "OnSizeOverLifetimeChanged")]
	private NumberRange sizeOverLifetime; //Field offset: 0x250
	[SyncVar(hook = "OnSpeedChanged")]
	private NumberRange speed; //Field offset: 0x258
	[SyncVar(hook = "OnEmissionRateChanged")]
	private int emissionRate; //Field offset: 0x260
	[SyncVar(hook = "OnMaxParticlesChanged")]
	private int maxParticles; //Field offset: 0x264
	[SyncVar(hook = "OnGravityChanged")]
	private float gravity; //Field offset: 0x268
	[SyncVar(hook = "OnSimulationSpaceChanged")]
	private ParticleSimulationSpace simulationSpace; //Field offset: 0x26C
	[SyncVar(hook = "OnStartRotationChanged")]
	private NumberRange startRotation; //Field offset: 0x270
	[SyncVar(hook = "OnAngularVelocityChanged")]
	private NumberRange angularVelocity; //Field offset: 0x278
	[SyncVar(hook = "OnAutoplayChanged")]
	private bool autoplay; //Field offset: 0x280
	[SyncVar(hook = "OnLoopChanged")]
	private bool loop; //Field offset: 0x281
	[SyncVar(hook = "OnDurationChanged")]
	private float duration; //Field offset: 0x284
	[SyncVar(hook = "OnShapeChanged")]
	private ParticleShape shape; //Field offset: 0x288
	[SyncVar(hook = "OnShapeRadiusChanged")]
	private float shapeRadius; //Field offset: 0x28C
	[SyncVar(hook = "OnShapeAngleChanged")]
	private float shapeAngle; //Field offset: 0x290
	[SyncVar(hook = "OnShapeScaleChanged")]
	private Vector3 shapeScale; //Field offset: 0x294
	private ImageCacheKey lastCacheKey; //Field offset: 0x2A0
	private ImageCacheEntry currentEntry; //Field offset: 0x2B8
	public Action<String, String> _Mirror_SyncVarHookDelegate_imageID; //Field offset: 0x2C0
	public Action<ImageType, ImageType> _Mirror_SyncVarHookDelegate_imageType; //Field offset: 0x2C8
	public Action<ColorRange, ColorRange> _Mirror_SyncVarHookDelegate_color; //Field offset: 0x2D0
	public Action<ParticleColorMode, ParticleColorMode> _Mirror_SyncVarHookDelegate_colorMode; //Field offset: 0x2D8
	public Action<NumberRange, NumberRange> _Mirror_SyncVarHookDelegate_lifetime; //Field offset: 0x2E0
	public Action<NumberRange, NumberRange> _Mirror_SyncVarHookDelegate_sizeOverLifetime; //Field offset: 0x2E8
	public Action<NumberRange, NumberRange> _Mirror_SyncVarHookDelegate_speed; //Field offset: 0x2F0
	public Action<Int32, Int32> _Mirror_SyncVarHookDelegate_emissionRate; //Field offset: 0x2F8
	public Action<Int32, Int32> _Mirror_SyncVarHookDelegate_maxParticles; //Field offset: 0x300
	public Action<Single, Single> _Mirror_SyncVarHookDelegate_gravity; //Field offset: 0x308
	public Action<ParticleSimulationSpace, ParticleSimulationSpace> _Mirror_SyncVarHookDelegate_simulationSpace; //Field offset: 0x310
	public Action<NumberRange, NumberRange> _Mirror_SyncVarHookDelegate_startRotation; //Field offset: 0x318
	public Action<NumberRange, NumberRange> _Mirror_SyncVarHookDelegate_angularVelocity; //Field offset: 0x320
	public Action<Boolean, Boolean> _Mirror_SyncVarHookDelegate_autoplay; //Field offset: 0x328
	public Action<Boolean, Boolean> _Mirror_SyncVarHookDelegate_loop; //Field offset: 0x330
	public Action<Single, Single> _Mirror_SyncVarHookDelegate_duration; //Field offset: 0x338
	public Action<ParticleShape, ParticleShape> _Mirror_SyncVarHookDelegate_shape; //Field offset: 0x340
	public Action<Single, Single> _Mirror_SyncVarHookDelegate_shapeRadius; //Field offset: 0x348
	public Action<Single, Single> _Mirror_SyncVarHookDelegate_shapeAngle; //Field offset: 0x350
	public Action<Vector3, Vector3> _Mirror_SyncVarHookDelegate_shapeScale; //Field offset: 0x358

	[Archivable]
	[CreatorProperty]
	public NumberRange AngularVelocity
	{
		 get { } //Length: 25
		 set { } //Length: 229
	}

	[Archivable]
	[CreatorProperty]
	public bool Autoplay
	{
		 get { } //Length: 8
		 set { } //Length: 175
	}

	[Archivable]
	[CreatorProperty]
	public ColorRange Color
	{
		 get { } //Length: 25
		 set { } //Length: 1003
	}

	[Archivable]
	[CreatorProperty]
	public ParticleColorMode ColorMode
	{
		 get { } //Length: 7
		 set { } //Length: 306
	}

	[Archivable]
	[CreatorProperty]
	public float Duration
	{
		 get { } //Length: 9
		 set { } //Length: 154
	}

	[Archivable]
	[CreatorProperty]
	public int EmissionRate
	{
		 get { } //Length: 7
		 set { } //Length: 198
	}

	[Archivable]
	[CreatorProperty]
	public float Gravity
	{
		 get { } //Length: 9
		 set { } //Length: 201
	}

	[Archivable]
	[CreatorProperty]
	public string ImageID
	{
		 get { } //Length: 8
		 set { } //Length: 112
	}

	[Archivable]
	[CreatorProperty]
	public ImageType ImageType
	{
		 get { } //Length: 7
		 set { } //Length: 110
	}

	public bool IsPaused
	{
		 get { } //Length: 32
	}

	public bool IsPlaying
	{
		 get { } //Length: 32
	}

	public bool IsStopped
	{
		 get { } //Length: 32
	}

	[Archivable]
	[CreatorProperty]
	public NumberRange Lifetime
	{
		 get { } //Length: 25
		 set { } //Length: 229
	}

	[Archivable]
	[CreatorProperty]
	public bool Loop
	{
		 get { } //Length: 8
		 set { } //Length: 153
	}

	[Archivable]
	[CreatorProperty]
	public int MaxParticles
	{
		 get { } //Length: 7
		 set { } //Length: 149
	}

	public NumberRange NetworkangularVelocity
	{
		 get { } //Length: 25
		 set { } //Length: 108
	}

	public bool Networkautoplay
	{
		 get { } //Length: 8
		 set { } //Length: 104
	}

	public ColorRange Networkcolor
	{
		 get { } //Length: 25
		 set { } //Length: 437
	}

	public ParticleColorMode NetworkcolorMode
	{
		 get { } //Length: 7
		 set { } //Length: 101
	}

	public float Networkduration
	{
		 get { } //Length: 9
		 set { } //Length: 104
	}

	public int NetworkemissionRate
	{
		 get { } //Length: 7
		 set { } //Length: 101
	}

	public float Networkgravity
	{
		 get { } //Length: 9
		 set { } //Length: 104
	}

	public string NetworkimageID
	{
		 get { } //Length: 8
		 set { } //Length: 103
	}

	public ImageType NetworkimageType
	{
		 get { } //Length: 7
		 set { } //Length: 101
	}

	public NumberRange Networklifetime
	{
		 get { } //Length: 25
		 set { } //Length: 108
	}

	public bool Networkloop
	{
		 get { } //Length: 8
		 set { } //Length: 104
	}

	public int NetworkmaxParticles
	{
		 get { } //Length: 7
		 set { } //Length: 101
	}

	public ParticleShape Networkshape
	{
		 get { } //Length: 7
		 set { } //Length: 101
	}

	public float NetworkshapeAngle
	{
		 get { } //Length: 9
		 set { } //Length: 104
	}

	public float NetworkshapeRadius
	{
		 get { } //Length: 9
		 set { } //Length: 104
	}

	public Vector3 NetworkshapeScale
	{
		 get { } //Length: 25
		 set { } //Length: 122
	}

	public ParticleSimulationSpace NetworksimulationSpace
	{
		 get { } //Length: 7
		 set { } //Length: 101
	}

	public NumberRange NetworksizeOverLifetime
	{
		 get { } //Length: 25
		 set { } //Length: 108
	}

	public NumberRange Networkspeed
	{
		 get { } //Length: 25
		 set { } //Length: 108
	}

	public NumberRange NetworkstartRotation
	{
		 get { } //Length: 25
		 set { } //Length: 108
	}

	public int ParticleCount
	{
		 get { } //Length: 32
	}

	[Archivable]
	[CreatorProperty]
	public ParticleShape Shape
	{
		 get { } //Length: 7
		 set { } //Length: 140
	}

	[Archivable]
	[CreatorProperty]
	public float ShapeAngle
	{
		 get { } //Length: 9
		 set { } //Length: 154
	}

	[Archivable]
	[CreatorProperty]
	public float ShapeRadius
	{
		 get { } //Length: 9
		 set { } //Length: 154
	}

	[Archivable]
	[CreatorProperty]
	public Vector3 ShapeScale
	{
		 get { } //Length: 25
		 set { } //Length: 193
	}

	[Archivable]
	[CreatorProperty]
	public ParticleSimulationSpace SimulationSpace
	{
		 get { } //Length: 7
		 set { } //Length: 167
	}

	[Archivable]
	[CreatorProperty]
	public NumberRange SizeOverLifetime
	{
		 get { } //Length: 25
		 set { } //Length: 444
	}

	[Archivable]
	[CreatorProperty]
	public NumberRange Speed
	{
		 get { } //Length: 25
		 set { } //Length: 229
	}

	[Archivable]
	[CreatorProperty]
	public NumberRange StartRotation
	{
		 get { } //Length: 25
		 set { } //Length: 229
	}

	public float Time
	{
		 get { } //Length: 32
	}

	public float TotalTime
	{
		 get { } //Length: 32
	}

	private static Particles() { }

	public Particles() { }

	[CompilerGenerated]
	private void <GetImage>b__98_0(ImageCacheKey key, ImageCacheEntry entry) { }

	protected virtual void Awake() { }

	public void Clear() { }

	protected virtual void CopyProperties(Instance clone) { }

	public virtual void DeserializeSyncVars(NetworkReader reader, bool initialState) { }

	public void Emit(int count) { }

	public NumberRange get_AngularVelocity() { }

	public bool get_Autoplay() { }

	public ColorRange get_Color() { }

	public ParticleColorMode get_ColorMode() { }

	public float get_Duration() { }

	public int get_EmissionRate() { }

	public float get_Gravity() { }

	public string get_ImageID() { }

	public ImageType get_ImageType() { }

	public bool get_IsPaused() { }

	public bool get_IsPlaying() { }

	public bool get_IsStopped() { }

	public NumberRange get_Lifetime() { }

	public bool get_Loop() { }

	public int get_MaxParticles() { }

	public NumberRange get_NetworkangularVelocity() { }

	public bool get_Networkautoplay() { }

	public ColorRange get_Networkcolor() { }

	public ParticleColorMode get_NetworkcolorMode() { }

	public float get_Networkduration() { }

	public int get_NetworkemissionRate() { }

	public float get_Networkgravity() { }

	public string get_NetworkimageID() { }

	public ImageType get_NetworkimageType() { }

	public NumberRange get_Networklifetime() { }

	public bool get_Networkloop() { }

	public int get_NetworkmaxParticles() { }

	public ParticleShape get_Networkshape() { }

	public float get_NetworkshapeAngle() { }

	public float get_NetworkshapeRadius() { }

	public Vector3 get_NetworkshapeScale() { }

	public ParticleSimulationSpace get_NetworksimulationSpace() { }

	public NumberRange get_NetworksizeOverLifetime() { }

	public NumberRange get_Networkspeed() { }

	public NumberRange get_NetworkstartRotation() { }

	public int get_ParticleCount() { }

	public ParticleShape get_Shape() { }

	public float get_ShapeAngle() { }

	public float get_ShapeRadius() { }

	public Vector3 get_ShapeScale() { }

	public ParticleSimulationSpace get_SimulationSpace() { }

	public NumberRange get_SizeOverLifetime() { }

	public NumberRange get_Speed() { }

	public NumberRange get_StartRotation() { }

	public float get_Time() { }

	public float get_TotalTime() { }

	private void GetImage() { }

	protected static void InvokeUserCode_RpcClear(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection) { }

	protected static void InvokeUserCode_RpcEmit__Int32(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection) { }

	protected static void InvokeUserCode_RpcPause(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection) { }

	protected static void InvokeUserCode_RpcPlay(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection) { }

	protected static void InvokeUserCode_RpcSimulate__Single(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection) { }

	protected static void InvokeUserCode_RpcStop(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection) { }

	private void OnAngularVelocityChanged(NumberRange oldAngularVelocity, NumberRange newAngularVelocity) { }

	private void OnAutoplayChanged(bool oldVal, bool newVal) { }

	private void OnColorChanged(ColorRange oldColor, ColorRange newColor) { }

	private void OnColorModeChanged(ParticleColorMode oldColorMode, ParticleColorMode newColorMode) { }

	private void OnDurationChanged(float oldDuration, float newDuration) { }

	private void OnEmissionRateChanged(int oldEmissionRate, int newEmissionRate) { }

	private void OnGravityChanged(float oldGravity, float newGravity) { }

	protected virtual void OnHide() { }

	private void OnImageIDChanged(string oldID, string newID) { }

	private void OnImageTypeChanged(ImageType oldType, ImageType newType) { }

	private void OnLifetimeChanged(NumberRange oldLifetime, NumberRange newLifetime) { }

	private void OnLoopChanged(bool oldLoop, bool newLoop) { }

	private void OnMaxParticlesChanged(int oldMaxParticles, int newMaxParticles) { }

	private void OnShapeAngleChanged(float oldAngle, float newAngle) { }

	private void OnShapeChanged(ParticleShape oldShape, ParticleShape newShape) { }

	private void OnShapeRadiusChanged(float oldRadius, float newRadius) { }

	private void OnShapeScaleChanged(Vector3 oldScale, Vector3 newScale) { }

	protected virtual void OnShow() { }

	private void OnSimulationSpaceChanged(ParticleSimulationSpace oldSimulationSpace, ParticleSimulationSpace newSimulationSpace) { }

	private void OnSizeOverLifetimeChanged(NumberRange oldSizeOverLifetime, NumberRange newSizeOverLifetime) { }

	private void OnSpeedChanged(NumberRange oldSpeed, NumberRange newSpeed) { }

	private void OnStartRotationChanged(NumberRange oldStartRotation, NumberRange newStartRotation) { }

	public void Pause() { }

	public void Play() { }

	[ClientRpc]
	private void RpcClear() { }

	[ClientRpc]
	private void RpcEmit(int count) { }

	[ClientRpc]
	private void RpcPause() { }

	[ClientRpc]
	private void RpcPlay() { }

	[ClientRpc]
	private void RpcSimulate(float time) { }

	[ClientRpc]
	private void RpcStop() { }

	public virtual void SerializeSyncVars(NetworkWriter writer, bool forceAll) { }

	public void set_AngularVelocity(NumberRange value) { }

	public void set_Autoplay(bool value) { }

	public void set_Color(ColorRange value) { }

	public void set_ColorMode(ParticleColorMode value) { }

	public void set_Duration(float value) { }

	public void set_EmissionRate(int value) { }

	public void set_Gravity(float value) { }

	public void set_ImageID(string value) { }

	public void set_ImageType(ImageType value) { }

	public void set_Lifetime(NumberRange value) { }

	public void set_Loop(bool value) { }

	public void set_MaxParticles(int value) { }

	public void set_NetworkangularVelocity(in NumberRange value) { }

	public void set_Networkautoplay(in bool value) { }

	public void set_Networkcolor(in ColorRange value) { }

	public void set_NetworkcolorMode(in ParticleColorMode value) { }

	public void set_Networkduration(in float value) { }

	public void set_NetworkemissionRate(in int value) { }

	public void set_Networkgravity(in float value) { }

	public void set_NetworkimageID(in string value) { }

	public void set_NetworkimageType(in ImageType value) { }

	public void set_Networklifetime(in NumberRange value) { }

	public void set_Networkloop(in bool value) { }

	public void set_NetworkmaxParticles(in int value) { }

	public void set_Networkshape(in ParticleShape value) { }

	public void set_NetworkshapeAngle(in float value) { }

	public void set_NetworkshapeRadius(in float value) { }

	public void set_NetworkshapeScale(in Vector3 value) { }

	public void set_NetworksimulationSpace(in ParticleSimulationSpace value) { }

	public void set_NetworksizeOverLifetime(in NumberRange value) { }

	public void set_Networkspeed(in NumberRange value) { }

	public void set_NetworkstartRotation(in NumberRange value) { }

	public void set_Shape(ParticleShape value) { }

	public void set_ShapeAngle(float value) { }

	public void set_ShapeRadius(float value) { }

	public void set_ShapeScale(Vector3 value) { }

	public void set_SimulationSpace(ParticleSimulationSpace value) { }

	public void set_SizeOverLifetime(NumberRange value) { }

	public void set_Speed(NumberRange value) { }

	public void set_StartRotation(NumberRange value) { }

	public void Simulate(float time) { }

	public void Stop() { }

	protected void UserCode_RpcClear() { }

	protected void UserCode_RpcEmit__Int32(int count) { }

	protected void UserCode_RpcPause() { }

	protected void UserCode_RpcPlay() { }

	protected void UserCode_RpcSimulate__Single(float time) { }

	protected void UserCode_RpcStop() { }

	public virtual bool Weaved() { }

}

