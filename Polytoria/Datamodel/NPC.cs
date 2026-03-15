namespace Polytoria.Datamodel;

[Instantiatable]
public class NPC : DynamicInstance, IToolHolder
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<Collider, Boolean> <>9__110_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal bool <IsGrounded>b__110_0(Collider i) { }

	}

	[SerializeField]
	private LayerMask ignoreLayer; //Field offset: 0x210
	[SerializeField]
	private GameObject head; //Field offset: 0x218
	[SerializeField]
	private GameObject torso; //Field offset: 0x220
	[SerializeField]
	private GameObject leftArm; //Field offset: 0x228
	[SerializeField]
	private GameObject rightArm; //Field offset: 0x230
	[SerializeField]
	private GameObject leftLeg; //Field offset: 0x238
	[SerializeField]
	private GameObject rightLeg; //Field offset: 0x240
	[SerializeField]
	private List<Rigidbody> deathBodyParts; //Field offset: 0x248
	[SerializeField]
	private Transform toolAttachPoint; //Field offset: 0x250
	[SyncVar]
	private float maxHealth; //Field offset: 0x258
	[SyncVar]
	private float health; //Field offset: 0x25C
	[SyncVar]
	private float walkSpeed; //Field offset: 0x260
	[SyncVar]
	private float jumpPower; //Field offset: 0x264
	private int shirtID; //Field offset: 0x268
	private int pantsID; //Field offset: 0x26C
	private int faceID; //Field offset: 0x270
	[SyncVar]
	private bool anchored; //Field offset: 0x274
	[SyncVar]
	private bool grounded; //Field offset: 0x275
	private Rigidbody rb; //Field offset: 0x278
	private Collider col; //Field offset: 0x280
	private Animator anim; //Field offset: 0x288
	private NetworkAnimator netAnim; //Field offset: 0x290
	private NPCAppearance appearance; //Field offset: 0x298
	private NavMeshAgent agent; //Field offset: 0x2A0
	public float maxStepHeight; //Field offset: 0x2A8
	public float stepSearchOvershoot; //Field offset: 0x2AC
	private PhysicsMaterial airMaterial; //Field offset: 0x2B0
	private PhysicsMaterial groundMaterial; //Field offset: 0x2B8
	private float jumpCooldown; //Field offset: 0x2C0
	private List<ContactPoint> allCPs; //Field offset: 0x2C8
	private Vector3 lastVelocity; //Field offset: 0x2D0
	private Dictionary<Rigidbody, Vector3> defaultBodyPartPos; //Field offset: 0x2E0
	private Instance moveTarget; //Field offset: 0x2E8
	public LuaEvent Died; //Field offset: 0x2F0
	private bool isDead; //Field offset: 0x2F8

	[Archivable]
	[CreatorProperty]
	public bool Anchored
	{
		 get { } //Length: 8
		 set { } //Length: 741
	}

	[Archivable]
	[CreatorProperty]
	public int FaceID
	{
		 get { } //Length: 7
		 set { } //Length: 559
	}

	public bool Grounded
	{
		 get { } //Length: 8
	}

	[Archivable]
	[CreatorProperty]
	public Color HeadColor
	{
		 get { } //Length: 147
		 set { } //Length: 179
	}

	[Archivable]
	[CreatorProperty]
	public float Health
	{
		 get { } //Length: 9
		 set { } //Length: 180
	}

	[Archivable]
	[CreatorProperty]
	public float JumpPower
	{
		 get { } //Length: 9
		 set { } //Length: 180
	}

	[Archivable]
	[CreatorProperty]
	public Color LeftArmColor
	{
		 get { } //Length: 147
		 set { } //Length: 179
	}

	[Archivable]
	[CreatorProperty]
	public Color LeftLegColor
	{
		 get { } //Length: 147
		 set { } //Length: 179
	}

	[Archivable]
	[CreatorProperty]
	public float MaxHealth
	{
		 get { } //Length: 9
		 set { } //Length: 180
	}

	public Instance MoveTarget
	{
		 get { } //Length: 8
		 set { } //Length: 60
	}

	public float NavDestinationDistance
	{
		 get { } //Length: 139
	}

	public bool NavDestinationReached
	{
		 get { } //Length: 145
	}

	public bool NavDestinationValid
	{
		 get { } //Length: 219
	}

	public bool Networkanchored
	{
		 get { } //Length: 8
		 set { } //Length: 182
	}

	public bool Networkgrounded
	{
		 get { } //Length: 8
		 set { } //Length: 182
	}

	public float Networkhealth
	{
		 get { } //Length: 9
		 set { } //Length: 180
	}

	public float NetworkjumpPower
	{
		 get { } //Length: 9
		 set { } //Length: 180
	}

	public float NetworkmaxHealth
	{
		 get { } //Length: 9
		 set { } //Length: 180
	}

	public float NetworkwalkSpeed
	{
		 get { } //Length: 9
		 set { } //Length: 180
	}

	[Archivable]
	[CreatorProperty]
	public int PantsID
	{
		 get { } //Length: 7
		 set { } //Length: 633
	}

	[Archivable]
	[CreatorProperty]
	public Color RightArmColor
	{
		 get { } //Length: 147
		 set { } //Length: 179
	}

	[Archivable]
	[CreatorProperty]
	public Color RightLegColor
	{
		 get { } //Length: 147
		 set { } //Length: 179
	}

	[Archivable]
	[CreatorProperty]
	public int ShirtID
	{
		 get { } //Length: 7
		 set { } //Length: 723
	}

	[MoonSharpHidden]
	public override Transform ToolAttachmentPoint
	{
		 get { } //Length: 8
	}

	[Archivable]
	[CreatorProperty]
	public Color TorsoColor
	{
		 get { } //Length: 147
		 set { } //Length: 179
	}

	[Archivable]
	[CreatorProperty]
	public Vector3 Velocity
	{
		 get { } //Length: 62
		 set { } //Length: 56
	}

	[Archivable]
	[CreatorProperty]
	public float WalkSpeed
	{
		 get { } //Length: 9
		 set { } //Length: 663
	}

	private static NPC() { }

	public NPC() { }

	[CompilerGenerated]
	private void <OnNetworkStart>g__onLoad|95_0() { }

	[CompilerGenerated]
	private void <set_FaceID>b__85_0(ImageCacheKey key, ImageCacheEntry entry) { }

	[CompilerGenerated]
	private void <set_PantsID>b__82_0(ImageCacheKey key, ImageCacheEntry entry) { }

	[CompilerGenerated]
	private void <set_ShirtID>b__79_0(ImageCacheKey key, ImageCacheEntry entry) { }

	protected virtual void Awake() { }

	public void ClearAppearance() { }

	protected virtual void CopyProperties(Instance clone) { }

	public virtual void DeserializeSyncVars(NetworkReader reader, bool initialState) { }

	private void Die() { }

	public void DropTool() { }

	public void EquipTool(Tool tool) { }

	private bool FindGround(out ContactPoint groundCP, List<ContactPoint> allCPs) { }

	private bool FindStep(out Vector3 stepUpOffset, List<ContactPoint> allCPs, ContactPoint groundCP, Vector3 currVelocity) { }

	private void FixedUpdate() { }

	public bool get_Anchored() { }

	public int get_FaceID() { }

	public bool get_Grounded() { }

	public Color get_HeadColor() { }

	public float get_Health() { }

	public float get_JumpPower() { }

	public Color get_LeftArmColor() { }

	public Color get_LeftLegColor() { }

	public float get_MaxHealth() { }

	public Instance get_MoveTarget() { }

	public float get_NavDestinationDistance() { }

	public bool get_NavDestinationReached() { }

	public bool get_NavDestinationValid() { }

	public bool get_Networkanchored() { }

	public bool get_Networkgrounded() { }

	public float get_Networkhealth() { }

	public float get_NetworkjumpPower() { }

	public float get_NetworkmaxHealth() { }

	public float get_NetworkwalkSpeed() { }

	public int get_PantsID() { }

	public Color get_RightArmColor() { }

	public Color get_RightLegColor() { }

	public int get_ShirtID() { }

	public override Transform get_ToolAttachmentPoint() { }

	public Color get_TorsoColor() { }

	public Vector3 get_Velocity() { }

	public float get_WalkSpeed() { }

	public Tool GetEquippedTool() { }

	protected static void InvokeUserCode_PlayAnimTargetRpc__String(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection) { }

	protected static void InvokeUserCode_RpcJumpSound(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection) { }

	protected static void InvokeUserCode_RpcSetAnchored__Boolean(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection) { }

	protected static void InvokeUserCode_RpcSetAnimatorActive__Boolean(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection) { }

	protected static void InvokeUserCode_RpcSetWalkSpeed__Single(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection) { }

	private bool IsGrounded() { }

	public void Jump() { }

	public void LoadAppearance(int userID) { }

	private void MoveDirection(Vector3 dir) { }

	private void OnCollisionStay(Collision col) { }

	protected virtual void OnHide() { }

	protected virtual void OnNetworkStart() { }

	protected virtual void OnShow() { }

	public virtual void OnStartClient() { }

	[MoonSharpHidden]
	public override void PlayAnim(string _anim) { }

	[MoonSharpHidden]
	[TargetRpc]
	public override void PlayAnimTargetRpc(string _anim) { }

	private bool ResolveStepUp(out Vector3 stepUpOffset, ContactPoint stepTestCP, ContactPoint groundCP) { }

	public void Respawn() { }

	[ClientRpc]
	private void RpcJumpSound() { }

	[ClientRpc]
	private void RpcSetAnchored(bool a) { }

	[ClientRpc]
	private void RpcSetAnimatorActive(bool active) { }

	[ClientRpc]
	private void RpcSetWalkSpeed(float walkSpeed) { }

	public virtual void SerializeSyncVars(NetworkWriter writer, bool forceAll) { }

	public void set_Anchored(bool value) { }

	public void set_FaceID(int value) { }

	public void set_HeadColor(Color value) { }

	public void set_Health(float value) { }

	public void set_JumpPower(float value) { }

	public void set_LeftArmColor(Color value) { }

	public void set_LeftLegColor(Color value) { }

	public void set_MaxHealth(float value) { }

	public void set_MoveTarget(Instance value) { }

	public void set_Networkanchored(in bool value) { }

	public void set_Networkgrounded(in bool value) { }

	public void set_Networkhealth(in float value) { }

	public void set_NetworkjumpPower(in float value) { }

	public void set_NetworkmaxHealth(in float value) { }

	public void set_NetworkwalkSpeed(in float value) { }

	public void set_PantsID(int value) { }

	public void set_RightArmColor(Color value) { }

	public void set_RightLegColor(Color value) { }

	public void set_ShirtID(int value) { }

	public void set_TorsoColor(Color value) { }

	public void set_Velocity(Vector3 value) { }

	public void set_WalkSpeed(float value) { }

	private void SetAnimatorActive(bool active) { }

	public void SetNavDestination(Vector3 pos) { }

	protected virtual void Start() { }

	protected virtual void Update() { }

	protected override void UserCode_PlayAnimTargetRpc__String(string _anim) { }

	protected void UserCode_RpcJumpSound() { }

	protected void UserCode_RpcSetAnchored__Boolean(bool a) { }

	protected void UserCode_RpcSetAnimatorActive__Boolean(bool active) { }

	protected void UserCode_RpcSetWalkSpeed__Single(float walkSpeed) { }

	public virtual bool Weaved() { }

}

