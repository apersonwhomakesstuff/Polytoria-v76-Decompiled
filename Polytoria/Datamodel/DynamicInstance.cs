namespace Polytoria.Datamodel;

public class DynamicInstance : Instance
{
	private const float MIN_SIZE = 0.01; //Field offset: 0x0
	[Range(0.01, 1)]
	public float transformSyncInterval; //Field offset: 0xF8
	[Range(0, 2)]
	public float positionThreshold; //Field offset: 0xFC
	[Range(0, 2)]
	public float rotationThreshold; //Field offset: 0x100
	[Range(0, 2)]
	public float scaleThreshold; //Field offset: 0x104
	private Rigidbody _rb; //Field offset: 0x108
	[CompilerGenerated]
	private SyncMode <SyncMode>k__BackingField; //Field offset: 0x110
	[SerializeField]
	private bool syncVelocity; //Field offset: 0x114
	[SerializeField]
	private float velocitySensitivity; //Field offset: 0x118
	[SerializeField]
	private bool syncAngularVelocity; //Field offset: 0x11C
	[SerializeField]
	private float angularVelocitySensitivity; //Field offset: 0x120
	protected float timeAlive; //Field offset: 0x124
	private bool first; //Field offset: 0x128
	private bool requestedTransform; //Field offset: 0x129
	private double lastServerSendTime; //Field offset: 0x130
	[SyncVar(hook = "OnVelocityChanged")]
	private Vector3 _velocity; //Field offset: 0x138
	[SyncVar(hook = "OnAngularVelocityChanged")]
	private Vector3 _angularVelocity; //Field offset: 0x144
	[SyncVar(hook = "OnIsKinematicChanged")]
	private bool _isKinematic; //Field offset: 0x150
	[SyncVar(hook = "OnUseGravityChanged")]
	private bool _useGravity; //Field offset: 0x151
	[SyncVar(hook = "OnDragChanged")]
	private float _drag; //Field offset: 0x154
	[SyncVar(hook = "OnAngularDragChanged")]
	private float _angularDrag; //Field offset: 0x158
	private ClientSyncState previousValue; //Field offset: 0x15C
	private Vector3 lastPos; //Field offset: 0x184
	private Vector3 lastSize; //Field offset: 0x190
	private Quaternion lastRot; //Field offset: 0x19C
	private Vector3 serverPosition; //Field offset: 0x1AC
	private Vector3 serverSize; //Field offset: 0x1B8
	private Quaternion serverRotation; //Field offset: 0x1C4
	private bool isDirty; //Field offset: 0x1D4
	private bool isChildOfPlayerTool; //Field offset: 0x1D5
	private Players players; //Field offset: 0x1D8
	public Action<Vector3, Vector3> _Mirror_SyncVarHookDelegate__velocity; //Field offset: 0x1E0
	public Action<Vector3, Vector3> _Mirror_SyncVarHookDelegate__angularVelocity; //Field offset: 0x1E8
	public Action<Boolean, Boolean> _Mirror_SyncVarHookDelegate__isKinematic; //Field offset: 0x1F0
	public Action<Boolean, Boolean> _Mirror_SyncVarHookDelegate__useGravity; //Field offset: 0x1F8
	public Action<Single, Single> _Mirror_SyncVarHookDelegate__drag; //Field offset: 0x200
	public Action<Single, Single> _Mirror_SyncVarHookDelegate__angularDrag; //Field offset: 0x208

	protected override bool DoTransformSync
	{
		 get { } //Length: 131
	}

	public Vector3 Forward
	{
		 get { } //Length: 59
	}

	private bool IgnoreSync
	{
		private get { } //Length: 7
	}

	[Archivable]
	[CreatorProperty]
	public Vector3 LocalPosition
	{
		 get { } //Length: 59
		 set { } //Length: 53
	}

	[Archivable]
	public Quaternion LocalQuaternion
	{
		 get { } //Length: 51
		 set { } //Length: 44
	}

	[Archivable]
	[CreatorProperty]
	public Vector3 LocalRotation
	{
		 get { } //Length: 59
		 set { } //Length: 53
	}

	[Archivable]
	[CreatorProperty]
	public Vector3 LocalSize
	{
		 get { } //Length: 59
		 set { } //Length: 53
	}

	public float Network_angularDrag
	{
		 get { } //Length: 9
		 set { } //Length: 104
	}

	public Vector3 Network_angularVelocity
	{
		 get { } //Length: 25
		 set { } //Length: 122
	}

	public float Network_drag
	{
		 get { } //Length: 9
		 set { } //Length: 104
	}

	public bool Network_isKinematic
	{
		 get { } //Length: 8
		 set { } //Length: 104
	}

	public bool Network_useGravity
	{
		 get { } //Length: 8
		 set { } //Length: 104
	}

	public Vector3 Network_velocity
	{
		 get { } //Length: 25
		 set { } //Length: 122
	}

	[Archivable]
	[CreatorProperty]
	public Vector3 Position
	{
		 get { } //Length: 59
		 set { } //Length: 53
	}

	[Archivable]
	public Quaternion Quaternion
	{
		 get { } //Length: 51
		 set { } //Length: 44
	}

	public Vector3 Right
	{
		 get { } //Length: 59
	}

	[Archivable]
	[CreatorProperty]
	public Vector3 Rotation
	{
		 get { } //Length: 59
		 set { } //Length: 53
	}

	[Archivable]
	[CreatorProperty]
	public Vector3 Size
	{
		 get { } //Length: 59
		 set { } //Length: 355
	}

	[MoonSharpHidden]
	public SyncMode SyncMode
	{
		[CompilerGenerated]
		 get { } //Length: 7
		[CompilerGenerated]
		 set { } //Length: 7
	}

	public Vector3 Up
	{
		 get { } //Length: 59
	}

	private static DynamicInstance() { }

	public DynamicInstance() { }

	[CompilerGenerated]
	private void <Awake>b__74_0() { }

	public void ApplyTransform() { }

	protected virtual void Awake() { }

	private void CacheTransform() { }

	public void CheckIfChildOfPlayerTool() { }

	[Command(requiresAuthority = False)]
	private void CmdRequestTransform(NetworkConnectionToClient sender = null) { }

	protected virtual void CopyProperties(Instance clone) { }

	public virtual void DeserializeSyncVars(NetworkReader reader, bool initialState) { }

	protected override bool get_DoTransformSync() { }

	public Vector3 get_Forward() { }

	private bool get_IgnoreSync() { }

	public Vector3 get_LocalPosition() { }

	public Quaternion get_LocalQuaternion() { }

	public Vector3 get_LocalRotation() { }

	public Vector3 get_LocalSize() { }

	public float get_Network_angularDrag() { }

	public Vector3 get_Network_angularVelocity() { }

	public float get_Network_drag() { }

	public bool get_Network_isKinematic() { }

	public bool get_Network_useGravity() { }

	public Vector3 get_Network_velocity() { }

	public Vector3 get_Position() { }

	public Quaternion get_Quaternion() { }

	public Vector3 get_Right() { }

	public Vector3 get_Rotation() { }

	public Vector3 get_Size() { }

	[CompilerGenerated]
	public SyncMode get_SyncMode() { }

	public Vector3 get_Up() { }

	private bool HasTransformChanged() { }

	public Vector3 InverseTransformDirection(Vector3 direction) { }

	public Vector3 InverseTransformPoint(Vector3 point) { }

	public Vector3 InverseTransformVector(Vector3 vector) { }

	protected static void InvokeUserCode_CmdRequestTransform__NetworkConnectionToClient(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection) { }

	protected static void InvokeUserCode_RpcSyncTransform__Vector3__Quaternion__Vector3(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection) { }

	protected static void InvokeUserCode_SetTransformTargetRpc__NetworkConnection__Vector3__Quaternion__Vector3(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection) { }

	public void LookAt(DynamicInstance target) { }

	public void LookAt(Vector3 target) { }

	public void LookAt(Vector3 target, Vector3 worldUp) { }

	private void OnAngularDragChanged(float _, float newValue) { }

	private void OnAngularVelocityChanged(Vector3 _, Vector3 newValue) { }

	protected virtual void OnDestroy() { }

	private void OnDragChanged(float _, float newValue) { }

	private void OnGameLoadedLocally() { }

	private void OnIsKinematicChanged(bool _, bool newValue) { }

	public virtual void OnStartClient() { }

	private void OnUseGravityChanged(bool _, bool newValue) { }

	private void OnVelocityChanged(Vector3 _, Vector3 newValue) { }

	private void RequestTransform() { }

	public void Rotate(Vector3 eulerAngles) { }

	public void RotateAround(Vector3 point, Vector3 axis, float angle) { }

	[ClientRpc(includeOwner = False)]
	protected void RpcSyncTransform(Vector3 position, Quaternion rotation, Vector3 size) { }

	public virtual void SerializeSyncVars(NetworkWriter writer, bool forceAll) { }

	public void set_LocalPosition(Vector3 value) { }

	public void set_LocalQuaternion(Quaternion value) { }

	public void set_LocalRotation(Vector3 value) { }

	public void set_LocalSize(Vector3 value) { }

	public void set_Network_angularDrag(in float value) { }

	public void set_Network_angularVelocity(in Vector3 value) { }

	public void set_Network_drag(in float value) { }

	public void set_Network_isKinematic(in bool value) { }

	public void set_Network_useGravity(in bool value) { }

	public void set_Network_velocity(in Vector3 value) { }

	public void set_Position(Vector3 value) { }

	public void set_Quaternion(Quaternion value) { }

	public void set_Rotation(Vector3 value) { }

	public void set_Size(Vector3 value) { }

	[CompilerGenerated]
	public void set_SyncMode(SyncMode value) { }

	[TargetRpc]
	private void SetTransformTargetRpc(NetworkConnection target, Vector3 position, Quaternion rotation, Vector3 size) { }

	protected virtual void Start() { }

	private void SyncPhysics() { }

	[MoonSharpHidden]
	public void SyncTransformRecursively() { }

	public Vector3 TransformDirection(Vector3 direction) { }

	public Vector3 TransformPoint(Vector3 point) { }

	public Vector3 TransformVector(Vector3 vector) { }

	public void Translate(Vector3 translation) { }

	protected override void Update() { }

	private void UpdateClient() { }

	private void UpdateServer() { }

	private void UpdateTransform() { }

	protected void UserCode_CmdRequestTransform__NetworkConnectionToClient(NetworkConnectionToClient sender) { }

	protected void UserCode_RpcSyncTransform__Vector3__Quaternion__Vector3(Vector3 position, Quaternion rotation, Vector3 size) { }

	protected void UserCode_SetTransformTargetRpc__NetworkConnection__Vector3__Quaternion__Vector3(NetworkConnection target, Vector3 position, Quaternion rotation, Vector3 size) { }

	public virtual bool Weaved() { }

}

