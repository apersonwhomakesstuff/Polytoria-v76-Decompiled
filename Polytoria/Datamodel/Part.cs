namespace Polytoria.Datamodel;

[Instantiatable]
public class Part : DynamicInstance
{
	public static float MaterialUVScale; //Field offset: 0x0
	private static Dictionary<PartShape, Mesh> shapeMeshes; //Field offset: 0x8
	protected bool isSpawnCached; //Field offset: 0x210
	[SyncVar(hook = "OnIsSpawnChanged")]
	protected bool isSpawn; //Field offset: 0x211
	[SyncVar(hook = "OnAnchoredChanged")]
	protected bool anchored; //Field offset: 0x212
	[SyncVar(hook = "OnCanCollideChanged")]
	protected bool canCollide; //Field offset: 0x213
	[SyncVar(hook = "OnColorChange")]
	protected Color color; //Field offset: 0x214
	[SyncVar(hook = "OnShapeChange")]
	protected PartShape shape; //Field offset: 0x224
	[SyncVar(hook = "OnMaterialChange")]
	protected PartMaterial material; //Field offset: 0x228
	[SyncVar(hook = "SetVelocity")]
	private Vector3 velocity; //Field offset: 0x22C
	[SyncVar(hook = "OnCastShadowsChanged")]
	private bool castShadows; //Field offset: 0x238
	[SyncVar(hook = "OnDragChanged")]
	private float drag; //Field offset: 0x23C
	[SyncVar(hook = "OnAngularDragChanged")]
	private float angularDrag; //Field offset: 0x240
	[SyncVar(hook = "OnUseGravityChanged")]
	private bool useGravity; //Field offset: 0x244
	[SyncVar(hook = "OnBouncinessChanged")]
	private float bounciness; //Field offset: 0x248
	[SyncVar(hook = "OnFrictionChanged")]
	private float friction; //Field offset: 0x24C
	[SyncVar(hook = "OnFrictionCombineChanged")]
	private PhysicsMaterialCombine frictionCombine; //Field offset: 0x250
	[SyncVar(hook = "OnBounceCombineChanged")]
	private PhysicsMaterialCombine bounceCombine; //Field offset: 0x254
	private MaterialPropertyBlock materialPropertyBlock; //Field offset: 0x258
	private Renderer _renderer; //Field offset: 0x260
	[SyncVar(hook = "SetMass")]
	private float mass; //Field offset: 0x268
	private Vector3 lastScale; //Field offset: 0x26C
	private Environment environment; //Field offset: 0x278
	public Action<Boolean, Boolean> _Mirror_SyncVarHookDelegate_isSpawn; //Field offset: 0x280
	public Action<Boolean, Boolean> _Mirror_SyncVarHookDelegate_anchored; //Field offset: 0x288
	public Action<Boolean, Boolean> _Mirror_SyncVarHookDelegate_canCollide; //Field offset: 0x290
	public Action<Color, Color> _Mirror_SyncVarHookDelegate_color; //Field offset: 0x298
	public Action<PartShape, PartShape> _Mirror_SyncVarHookDelegate_shape; //Field offset: 0x2A0
	public Action<PartMaterial, PartMaterial> _Mirror_SyncVarHookDelegate_material; //Field offset: 0x2A8
	public Action<Vector3, Vector3> _Mirror_SyncVarHookDelegate_velocity; //Field offset: 0x2B0
	public Action<Boolean, Boolean> _Mirror_SyncVarHookDelegate_castShadows; //Field offset: 0x2B8
	public Action<Single, Single> _Mirror_SyncVarHookDelegate_drag; //Field offset: 0x2C0
	public Action<Single, Single> _Mirror_SyncVarHookDelegate_angularDrag; //Field offset: 0x2C8
	public Action<Boolean, Boolean> _Mirror_SyncVarHookDelegate_useGravity; //Field offset: 0x2D0
	public Action<Single, Single> _Mirror_SyncVarHookDelegate_bounciness; //Field offset: 0x2D8
	public Action<Single, Single> _Mirror_SyncVarHookDelegate_friction; //Field offset: 0x2E0
	public Action<PhysicsMaterialCombine, PhysicsMaterialCombine> _Mirror_SyncVarHookDelegate_frictionCombine; //Field offset: 0x2E8
	public Action<PhysicsMaterialCombine, PhysicsMaterialCombine> _Mirror_SyncVarHookDelegate_bounceCombine; //Field offset: 0x2F0
	public Action<Single, Single> _Mirror_SyncVarHookDelegate_mass; //Field offset: 0x2F8

	[Archivable]
	[CreatorProperty]
	public bool Anchored
	{
		 get { } //Length: 8
		 set { } //Length: 1075
	}

	[Archivable]
	[CreatorProperty]
	public float AngularDrag
	{
		 get { } //Length: 136
		 set { } //Length: 568
	}

	public Vector3 AngularVelocity
	{
		 get { } //Length: 206
		 set { } //Length: 163
	}

	[Archivable]
	[CreatorProperty]
	public PhysicsMaterialCombine BounceCombine
	{
		 get { } //Length: 210
		 set { } //Length: 711
	}

	[Archivable]
	[CreatorProperty]
	public float Bounciness
	{
		 get { } //Length: 211
		 set { } //Length: 716
	}

	[Archivable]
	[CreatorProperty]
	public bool CanCollide
	{
		 get { } //Length: 8
		 set { } //Length: 794
	}

	[Archivable]
	[CreatorProperty]
	public bool CastShadows
	{
		 get { } //Length: 8
		 set { } //Length: 230
	}

	[Archivable]
	[CreatorProperty]
	public Color Color
	{
		 get { } //Length: 14
		 set { } //Length: 556
	}

	[Archivable]
	[CreatorProperty]
	public float Drag
	{
		 get { } //Length: 136
		 set { } //Length: 568
	}

	[Archivable]
	[CreatorProperty]
	public float Friction
	{
		 get { } //Length: 216
		 set { } //Length: 730
	}

	[Archivable]
	[CreatorProperty]
	public PhysicsMaterialCombine FrictionCombine
	{
		 get { } //Length: 210
		 set { } //Length: 711
	}

	[Archivable]
	[CreatorProperty]
	public bool IsSpawn
	{
		 get { } //Length: 8
		 set { } //Length: 479
	}

	[Archivable]
	[CreatorProperty]
	public float Mass
	{
		 get { } //Length: 155
		 set { } //Length: 230
	}

	[Archivable]
	[CreatorProperty]
	public PartMaterial Material
	{
		 get { } //Length: 7
		 set { } //Length: 675
	}

	public bool Networkanchored
	{
		 get { } //Length: 8
		 set { } //Length: 104
	}

	public float NetworkangularDrag
	{
		 get { } //Length: 9
		 set { } //Length: 104
	}

	public PhysicsMaterialCombine NetworkbounceCombine
	{
		 get { } //Length: 7
		 set { } //Length: 101
	}

	public float Networkbounciness
	{
		 get { } //Length: 9
		 set { } //Length: 104
	}

	public bool NetworkcanCollide
	{
		 get { } //Length: 8
		 set { } //Length: 104
	}

	public bool NetworkcastShadows
	{
		 get { } //Length: 8
		 set { } //Length: 104
	}

	public Color Networkcolor
	{
		 get { } //Length: 14
		 set { } //Length: 113
	}

	public float Networkdrag
	{
		 get { } //Length: 9
		 set { } //Length: 104
	}

	public float Networkfriction
	{
		 get { } //Length: 9
		 set { } //Length: 104
	}

	public PhysicsMaterialCombine NetworkfrictionCombine
	{
		 get { } //Length: 7
		 set { } //Length: 101
	}

	public bool NetworkisSpawn
	{
		 get { } //Length: 8
		 set { } //Length: 104
	}

	public float Networkmass
	{
		 get { } //Length: 9
		 set { } //Length: 104
	}

	public PartMaterial Networkmaterial
	{
		 get { } //Length: 7
		 set { } //Length: 101
	}

	public PartShape Networkshape
	{
		 get { } //Length: 7
		 set { } //Length: 101
	}

	public bool NetworkuseGravity
	{
		 get { } //Length: 8
		 set { } //Length: 104
	}

	public Vector3 Networkvelocity
	{
		 get { } //Length: 25
		 set { } //Length: 122
	}

	[Archivable]
	[CreatorProperty]
	public PartShape Shape
	{
		 get { } //Length: 7
		 set { } //Length: 1638
	}

	[Archivable]
	[CreatorProperty]
	public bool UseGravity
	{
		 get { } //Length: 8
		 set { } //Length: 571
	}

	[Archivable]
	[CreatorProperty]
	public Vector3 Velocity
	{
		 get { } //Length: 242
		 set { } //Length: 267
	}

	private static Part() { }

	public Part() { }

	public void AddForce(Vector3 force, ForceMode mode) { }

	public void AddForceAtPosition(Vector3 force, Vector3 position, ForceMode mode) { }

	public void AddRelativeForce(Vector3 force, ForceMode mode) { }

	public void AddRelativeTorque(Vector3 torque, ForceMode mode) { }

	public void AddTorque(Vector3 torque, ForceMode mode) { }

	protected virtual void Awake() { }

	protected virtual void CopyProperties(Instance clone) { }

	public virtual void DeserializeSyncVars(NetworkReader reader, bool initialState) { }

	public bool get_Anchored() { }

	public float get_AngularDrag() { }

	public Vector3 get_AngularVelocity() { }

	public PhysicsMaterialCombine get_BounceCombine() { }

	public float get_Bounciness() { }

	public bool get_CanCollide() { }

	public bool get_CastShadows() { }

	public Color get_Color() { }

	public float get_Drag() { }

	public float get_Friction() { }

	public PhysicsMaterialCombine get_FrictionCombine() { }

	public bool get_IsSpawn() { }

	public float get_Mass() { }

	public PartMaterial get_Material() { }

	public bool get_Networkanchored() { }

	public float get_NetworkangularDrag() { }

	public PhysicsMaterialCombine get_NetworkbounceCombine() { }

	public float get_Networkbounciness() { }

	public bool get_NetworkcanCollide() { }

	public bool get_NetworkcastShadows() { }

	public Color get_Networkcolor() { }

	public float get_Networkdrag() { }

	public float get_Networkfriction() { }

	public PhysicsMaterialCombine get_NetworkfrictionCombine() { }

	public bool get_NetworkisSpawn() { }

	public float get_Networkmass() { }

	public PartMaterial get_Networkmaterial() { }

	public PartShape get_Networkshape() { }

	public bool get_NetworkuseGravity() { }

	public Vector3 get_Networkvelocity() { }

	public PartShape get_Shape() { }

	public bool get_UseGravity() { }

	public Vector3 get_Velocity() { }

	protected static void InvokeUserCode_RpcSetAnchored__Boolean(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection) { }

	protected static void InvokeUserCode_RpcSetAngularDrag__Single(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection) { }

	protected static void InvokeUserCode_RpcSetBounceCombine__PhysicsMaterialCombine(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection) { }

	protected static void InvokeUserCode_RpcSetBounciness__Single(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection) { }

	protected static void InvokeUserCode_RpcSetCanCollide__Boolean(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection) { }

	protected static void InvokeUserCode_RpcSetDrag__Single(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection) { }

	protected static void InvokeUserCode_RpcSetFriction__Single(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection) { }

	protected static void InvokeUserCode_RpcSetFrictionCombine__PhysicsMaterialCombine(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection) { }

	protected static void InvokeUserCode_RpcSetMaterial__PartMaterial(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection) { }

	protected static void InvokeUserCode_RpcSetShape__PartShape(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection) { }

	protected static void InvokeUserCode_RpcSetSpawn__Boolean(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection) { }

	protected static void InvokeUserCode_RpcSetUseGravity__Boolean(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection) { }

	public void MovePosition(Vector3 pos) { }

	public void MoveRotation(Vector3 rot) { }

	private void OnAnchoredChanged(bool old, bool value) { }

	private void OnAngularDragChanged(float old, float value) { }

	private void OnBounceCombineChanged(PhysicsMaterialCombine old, PhysicsMaterialCombine value) { }

	private void OnBouncinessChanged(float old, float value) { }

	private void OnCanCollideChanged(bool old, bool value) { }

	private void OnCastShadowsChanged(bool old, bool value) { }

	private void OnColorChange(Color oldColor, Color newColor) { }

	protected virtual void OnDestroy() { }

	private void OnDragChanged(float old, float value) { }

	private void OnFrictionChanged(float old, float value) { }

	private void OnFrictionCombineChanged(PhysicsMaterialCombine old, PhysicsMaterialCombine value) { }

	protected virtual void OnHide() { }

	private void OnIsSpawnChanged(bool old, bool value) { }

	private void OnMaterialChange(PartMaterial old, PartMaterial value) { }

	protected virtual void OnNetworkStart() { }

	private void OnShapeChange(PartShape old, PartShape value) { }

	protected virtual void OnShow() { }

	private void OnUseGravityChanged(bool old, bool value) { }

	[ClientRpc]
	private void RpcSetAnchored(bool anchored) { }

	[ClientRpc]
	private void RpcSetAngularDrag(float d) { }

	[ClientRpc]
	private void RpcSetBounceCombine(PhysicsMaterialCombine c) { }

	[ClientRpc]
	private void RpcSetBounciness(float b) { }

	[ClientRpc]
	protected void RpcSetCanCollide(bool canCollide) { }

	[ClientRpc]
	private void RpcSetDrag(float d) { }

	[ClientRpc]
	private void RpcSetFriction(float f) { }

	[ClientRpc]
	private void RpcSetFrictionCombine(PhysicsMaterialCombine c) { }

	[ClientRpc]
	private void RpcSetMaterial(PartMaterial material) { }

	[ClientRpc]
	private void RpcSetShape(PartShape shape) { }

	[ClientRpc]
	private void RpcSetSpawn(bool spawn) { }

	[ClientRpc]
	private void RpcSetUseGravity(bool g) { }

	public virtual void SerializeSyncVars(NetworkWriter writer, bool forceAll) { }

	public void set_Anchored(bool value) { }

	public void set_AngularDrag(float value) { }

	public void set_AngularVelocity(Vector3 value) { }

	public void set_BounceCombine(PhysicsMaterialCombine value) { }

	public void set_Bounciness(float value) { }

	public void set_CanCollide(bool value) { }

	public void set_CastShadows(bool value) { }

	public void set_Color(Color value) { }

	public void set_Drag(float value) { }

	public void set_Friction(float value) { }

	public void set_FrictionCombine(PhysicsMaterialCombine value) { }

	public void set_IsSpawn(bool value) { }

	public void set_Mass(float value) { }

	public void set_Material(PartMaterial value) { }

	public void set_Networkanchored(in bool value) { }

	public void set_NetworkangularDrag(in float value) { }

	public void set_NetworkbounceCombine(in PhysicsMaterialCombine value) { }

	public void set_Networkbounciness(in float value) { }

	public void set_NetworkcanCollide(in bool value) { }

	public void set_NetworkcastShadows(in bool value) { }

	public void set_Networkcolor(in Color value) { }

	public void set_Networkdrag(in float value) { }

	public void set_Networkfriction(in float value) { }

	public void set_NetworkfrictionCombine(in PhysicsMaterialCombine value) { }

	public void set_NetworkisSpawn(in bool value) { }

	public void set_Networkmass(in float value) { }

	public void set_Networkmaterial(in PartMaterial value) { }

	public void set_Networkshape(in PartShape value) { }

	public void set_NetworkuseGravity(in bool value) { }

	public void set_Networkvelocity(in Vector3 value) { }

	public void set_Shape(PartShape value) { }

	public void set_UseGravity(bool value) { }

	public void set_Velocity(Vector3 value) { }

	private void SetMass(float oldMass, float newMass) { }

	private void SetVelocity(Vector3 oldVelocity, Vector3 newVelocity) { }

	protected virtual void Start() { }

	protected virtual void Update() { }

	private void UpdateMaterial() { }

	protected void UserCode_RpcSetAnchored__Boolean(bool anchored) { }

	protected void UserCode_RpcSetAngularDrag__Single(float d) { }

	protected void UserCode_RpcSetBounceCombine__PhysicsMaterialCombine(PhysicsMaterialCombine c) { }

	protected void UserCode_RpcSetBounciness__Single(float b) { }

	protected void UserCode_RpcSetCanCollide__Boolean(bool canCollide) { }

	protected void UserCode_RpcSetDrag__Single(float d) { }

	protected void UserCode_RpcSetFriction__Single(float f) { }

	protected void UserCode_RpcSetFrictionCombine__PhysicsMaterialCombine(PhysicsMaterialCombine c) { }

	protected void UserCode_RpcSetMaterial__PartMaterial(PartMaterial material) { }

	protected void UserCode_RpcSetShape__PartShape(PartShape shape) { }

	protected void UserCode_RpcSetSpawn__Boolean(bool spawn) { }

	protected void UserCode_RpcSetUseGravity__Boolean(bool g) { }

	public virtual bool Weaved() { }

}

