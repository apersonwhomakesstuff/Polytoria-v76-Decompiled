namespace Polytoria.Datamodel;

[RequireComponent(typeof(ParentConstraint))]
public class Player : Instance, IToolHolder
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<Collider, Boolean> <>9__213_0; //Field offset: 0x8
		public static Func<Collider, Instance> <>9__213_1; //Field offset: 0x10
		public static Func<Collider, Boolean> <>9__227_0; //Field offset: 0x18

		private static <>c() { }

		public <>c() { }

		internal bool <DoFootstep>b__213_0(Collider i) { }

		internal Instance <DoFootstep>b__213_1(Collider i) { }

		internal bool <IsGrounded>b__227_0(Collider i) { }

	}

	[CompilerGenerated]
	private sealed class <CheckOwnsItemFromAPI>d__208 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public DynValue callback; //Field offset: 0x20
		public int assetId; //Field offset: 0x28
		public Player <>4__this; //Field offset: 0x30
		private ScriptService <ss>5__2; //Field offset: 0x38
		private UnityWebRequest <uwr>5__3; //Field offset: 0x40

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
		public <CheckOwnsItemFromAPI>d__208(int <>1__state) { }

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
	private sealed class <DelayedDisconnect>d__239 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public Player <>4__this; //Field offset: 0x20

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
		public <DelayedDisconnect>d__239(int <>1__state) { }

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
	private sealed class <DiscordLoop>d__197 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18

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
		public <DiscordLoop>d__197(int <>1__state) { }

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
	private sealed class <DoDie>d__222 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public Player <>4__this; //Field offset: 0x20

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
		public <DoDie>d__222(int <>1__state) { }

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
	private sealed class <LoadMetadata>d__207 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public Player <>4__this; //Field offset: 0x20
		public string authToken; //Field offset: 0x28
		private UnityWebRequest <uwr>5__2; //Field offset: 0x30

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
		public <LoadMetadata>d__207(int <>1__state) { }

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
	private sealed class <PostPlayerLoad>d__196 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public Player <>4__this; //Field offset: 0x20

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
		public <PostPlayerLoad>d__196(int <>1__state) { }

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
	private sealed class <StopScream>d__211 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public Player <>4__this; //Field offset: 0x20

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
		public <StopScream>d__211(int <>1__state) { }

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

	public static bool kicked; //Field offset: 0x0
	private const float footstepInterval = 0.3; //Field offset: 0x0
	private static readonly int maxRequestsPerMin; //Field offset: 0x4
	private static readonly int hatCheckCacheLength; //Field offset: 0x8
	private static FootstepCollection footstepSounds; //Field offset: 0x10
	private static Dictionary<Int32, Int32> assetCheckCounts; //Field offset: 0x18
	private readonly Array keyCodes; //Field offset: 0xF8
	private float footstepTimer; //Field offset: 0x100
	private int footstepIndex; //Field offset: 0x104
	private AudioSource footstepPlayer; //Field offset: 0x108
	private ParentConstraint parentConstraint; //Field offset: 0x110
	private float maxHealth; //Field offset: 0x118
	[SyncVar]
	private float walkSpeed; //Field offset: 0x11C
	[SyncVar]
	private float sprintSpeed; //Field offset: 0x120
	[SyncVar]
	private float health; //Field offset: 0x124
	[SerializeField]
	private bool isSprinting; //Field offset: 0x128
	[SerializeField]
	private bool sprintExhausted; //Field offset: 0x129
	[SerializeField]
	[SyncVar]
	private bool staminaEnabled; //Field offset: 0x12A
	[SerializeField]
	[SyncVar]
	private float stamina; //Field offset: 0x12C
	[SerializeField]
	[SyncVar]
	private float maxStamina; //Field offset: 0x130
	[SerializeField]
	[SyncVar]
	private float staminaRegen; //Field offset: 0x134
	[SerializeField]
	private float jumpPower; //Field offset: 0x138
	[SyncVar]
	private float respawnTime; //Field offset: 0x13C
	[SyncVar]
	private int userID; //Field offset: 0x140
	[SyncVar]
	private bool loaded; //Field offset: 0x144
	[SyncVar]
	private bool isCreator; //Field offset: 0x145
	[SyncVar]
	private bool isAdmin; //Field offset: 0x146
	[SyncVar]
	private Color chatColor; //Field offset: 0x148
	[SyncVar]
	private string avatarHash; //Field offset: 0x158
	[SyncVar]
	private bool canMove; //Field offset: 0x160
	[SyncVar]
	private bool anchored; //Field offset: 0x161
	[SyncVar]
	public string LeaderboardBadgeId; //Field offset: 0x168
	[SyncVar]
	public bool canChat; //Field offset: 0x170
	[SyncVar]
	public bool isAgeRestricted; //Field offset: 0x171
	[SerializeField]
	private float turnSmoothing; //Field offset: 0x174
	[SerializeField]
	private LayerMask ignoreLayer; //Field offset: 0x178
	[SerializeField]
	private Animator anim; //Field offset: 0x180
	[SerializeField]
	private Rigidbody rb; //Field offset: 0x188
	[SerializeField]
	private List<MeshRenderer> disableOnFP; //Field offset: 0x190
	[SerializeField]
	private List<Rigidbody> deathBodyParts; //Field offset: 0x198
	[SerializeField]
	private Transform toolAttachPoint; //Field offset: 0x1A0
	[SerializeField]
	private Transform camAttachment; //Field offset: 0x1A8
	private int shirtID; //Field offset: 0x1B0
	private int pantsID; //Field offset: 0x1B4
	private int faceID; //Field offset: 0x1B8
	private float coyoteTime; //Field offset: 0x1BC
	private float coyoteTimer; //Field offset: 0x1C0
	private Collider col; //Field offset: 0x1C8
	private PhysicsMaterial airMaterial; //Field offset: 0x1D0
	private PhysicsMaterial groundMaterial; //Field offset: 0x1D8
	private Dictionary<Rigidbody, Vector3> defaultBodyPartPos; //Field offset: 0x1E0
	private Transform head; //Field offset: 0x1E8
	private Transform leftArm; //Field offset: 0x1F0
	private Transform rightArm; //Field offset: 0x1F8
	private Transform torso; //Field offset: 0x200
	private Transform leftLeg; //Field offset: 0x208
	private Transform rightLeg; //Field offset: 0x210
	private NetworkAnimator netAnim; //Field offset: 0x218
	public float maxStepHeight; //Field offset: 0x220
	public float stepSearchOvershoot; //Field offset: 0x224
	private List<ContactPoint> allCPs; //Field offset: 0x228
	private Vector3 lastVelocity; //Field offset: 0x230
	private float afkTimer; //Field offset: 0x23C
	private float maxAfkTime; //Field offset: 0x240
	private bool isDead; //Field offset: 0x244
	private float jumpCooldown; //Field offset: 0x248
	private float currentSpeed; //Field offset: 0x24C
	private TMP_Text nametag; //Field offset: 0x250
	private Vector3 oldPos; //Field offset: 0x258
	[SyncVar]
	private Seat sittingIn; //Field offset: 0x268
	public LuaEvent Chatted; //Field offset: 0x270
	public LuaEvent Died; //Field offset: 0x278
	public LuaEvent Respawned; //Field offset: 0x280
	private Environment _env; //Field offset: 0x288
	private Dictionary<Int32, Boolean> assetOwnCache; //Field offset: 0x290
	private Dictionary<Int32, Int32> assetCacheCheckTimes; //Field offset: 0x298
	private float defaultFov; //Field offset: 0x2A0
	private float sprintFov; //Field offset: 0x2A4
	private AppearanceLoaderBase appearance; //Field offset: 0x2A8
	private Camera cam; //Field offset: 0x2B0
	private bool climbing; //Field offset: 0x2B8
	private bool isEmote; //Field offset: 0x2B9
	protected NetworkBehaviourSyncVar ___sittingInNetId; //Field offset: 0x2BC

	public bool Anchored
	{
		 get { } //Length: 8
		 set { } //Length: 546
	}

	public string AvatarHash
	{
		 get { } //Length: 8
	}

	private Camera Camera
	{
		private get { } //Length: 8
		private set { } //Length: 357
	}

	public bool CanMove
	{
		 get { } //Length: 8
		 set { } //Length: 522
	}

	public Color ChatColor
	{
		 get { } //Length: 14
		 set { } //Length: 552
	}

	[Archivable]
	[CreatorProperty]
	public int FaceID
	{
		 get { } //Length: 7
		 set { } //Length: 559
	}

	public Vector3 Forward
	{
		 get { } //Length: 71
	}

	[Archivable]
	[CreatorProperty]
	public Color HeadColor
	{
		 get { } //Length: 147
		 set { } //Length: 179
	}

	[CreatorProperty]
	public float Health
	{
		 get { } //Length: 9
		 set { } //Length: 447
	}

	public bool IsAdmin
	{
		 get { } //Length: 8
	}

	public bool IsCreator
	{
		 get { } //Length: 8
	}

	public bool IsInputFocused
	{
		 get { } //Length: 64
	}

	[MoonSharpHidden]
	public bool IsLoaded
	{
		 get { } //Length: 8
	}

	[MoonSharpHidden]
	public bool IsLocalPlayer
	{
		 get { } //Length: 107
	}

	private bool IsMovementAllowed
	{
		private get { } //Length: 362
	}

	private bool IsSitting
	{
		private get { } //Length: 136
	}

	[CreatorProperty]
	public float JumpPower
	{
		 get { } //Length: 9
		 set { } //Length: 382
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

	[CreatorProperty]
	public float MaxHealth
	{
		 get { } //Length: 9
		 set { } //Length: 382
	}

	[CreatorProperty]
	public float MaxStamina
	{
		 get { } //Length: 9
		 set { } //Length: 527
	}

	public bool Networkanchored
	{
		 get { } //Length: 8
		 set { } //Length: 182
	}

	public string NetworkavatarHash
	{
		 get { } //Length: 8
		 set { } //Length: 180
	}

	public bool NetworkcanChat
	{
		 get { } //Length: 8
		 set { } //Length: 182
	}

	public bool NetworkcanMove
	{
		 get { } //Length: 8
		 set { } //Length: 182
	}

	public Color NetworkchatColor
	{
		 get { } //Length: 14
		 set { } //Length: 202
	}

	public float Networkhealth
	{
		 get { } //Length: 9
		 set { } //Length: 180
	}

	public bool NetworkisAdmin
	{
		 get { } //Length: 8
		 set { } //Length: 182
	}

	public bool NetworkisAgeRestricted
	{
		 get { } //Length: 8
		 set { } //Length: 182
	}

	public bool NetworkisCreator
	{
		 get { } //Length: 8
		 set { } //Length: 182
	}

	public string NetworkLeaderboardBadgeId
	{
		 get { } //Length: 8
		 set { } //Length: 180
	}

	public bool Networkloaded
	{
		 get { } //Length: 8
		 set { } //Length: 182
	}

	public float NetworkmaxStamina
	{
		 get { } //Length: 9
		 set { } //Length: 180
	}

	public float NetworkrespawnTime
	{
		 get { } //Length: 9
		 set { } //Length: 180
	}

	public Seat NetworksittingIn
	{
		 get { } //Length: 71
		 set { } //Length: 200
	}

	public float NetworksprintSpeed
	{
		 get { } //Length: 9
		 set { } //Length: 180
	}

	public float Networkstamina
	{
		 get { } //Length: 9
		 set { } //Length: 180
	}

	public bool NetworkstaminaEnabled
	{
		 get { } //Length: 8
		 set { } //Length: 182
	}

	public float NetworkstaminaRegen
	{
		 get { } //Length: 9
		 set { } //Length: 180
	}

	public int NetworkuserID
	{
		 get { } //Length: 7
		 set { } //Length: 177
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

	[CreatorProperty]
	public Vector3 Position
	{
		 get { } //Length: 71
		 set { } //Length: 295
	}

	[CreatorProperty]
	public float RespawnTime
	{
		 get { } //Length: 9
		 set { } //Length: 519
	}

	public Vector3 Right
	{
		 get { } //Length: 71
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

	[CreatorProperty]
	public Vector3 Rotation
	{
		 get { } //Length: 71
		 set { } //Length: 162
	}

	[Archivable]
	[CreatorProperty]
	public int ShirtID
	{
		 get { } //Length: 7
		 set { } //Length: 723
	}

	public Seat SittingIn
	{
		 get { } //Length: 71
	}

	[CreatorProperty]
	public Vector3 Size
	{
		 get { } //Length: 71
		 set { } //Length: 162
	}

	[CreatorProperty]
	public float SprintSpeed
	{
		 get { } //Length: 9
		 set { } //Length: 527
	}

	[CreatorProperty]
	public float Stamina
	{
		 get { } //Length: 9
		 set { } //Length: 400
	}

	[CreatorProperty]
	public bool StaminaEnabled
	{
		 get { } //Length: 8
		 set { } //Length: 529
	}

	[CreatorProperty]
	public float StaminaRegen
	{
		 get { } //Length: 9
		 set { } //Length: 527
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

	[CreatorProperty]
	public private int UserID
	{
		 get { } //Length: 7
		private set { } //Length: 177
	}

	public Vector3 Velocity
	{
		 get { } //Length: 62
		 set { } //Length: 56
	}

	[CreatorProperty]
	public float WalkSpeed
	{
		 get { } //Length: 9
		 set { } //Length: 575
	}

	private static Player() { }

	public Player() { }

	[CompilerGenerated]
	private bool <IsGrounded>b__227_1(Collider i) { }

	[CompilerGenerated]
	private void <set_FaceID>b__171_0(ImageCacheKey key, ImageCacheEntry entry) { }

	[CompilerGenerated]
	private void <set_PantsID>b__168_0(ImageCacheKey key, ImageCacheEntry entry) { }

	[CompilerGenerated]
	private void <set_ShirtID>b__165_0(ImageCacheKey key, ImageCacheEntry entry) { }

	[CompilerGenerated]
	private void <Start>b__189_0() { }

	[CompilerGenerated]
	private void <Start>b__189_1(string <p0>) { }

	[CompilerGenerated]
	private void <Start>b__189_2() { }

	[CompilerGenerated]
	private void <UpdateFov>b__234_0(float fov) { }

	[CompilerGenerated]
	private void <UpdateFov>b__234_1(float fov) { }

	protected virtual void Awake() { }

	[IteratorStateMachine(typeof(<CheckOwnsItemFromAPI>d__208))]
	private IEnumerator CheckOwnsItemFromAPI(int assetId, DynValue callback) { }

	public void ClearAppearance() { }

	[Command]
	private void CmdDied() { }

	[Command]
	private void CmdDropTools() { }

	[Command]
	private void CmdJumpSound() { }

	[Command]
	private void CmdNotifyRespawn() { }

	[Command]
	private void CmdSetHealth(float health) { }

	[Command]
	[MoonSharpHidden]
	public void CmdSetSittingIn(Seat seat) { }

	[Command]
	private void CmdTouched(GameObject other) { }

	[Command]
	private void CmdTouchEnded(GameObject other) { }

	[IteratorStateMachine(typeof(<DelayedDisconnect>d__239))]
	private IEnumerator DelayedDisconnect() { }

	public virtual void DeserializeSyncVars(NetworkReader reader, bool initialState) { }

	private void Die() { }

	[IteratorStateMachine(typeof(<DiscordLoop>d__197))]
	private IEnumerator DiscordLoop() { }

	[IteratorStateMachine(typeof(<DoDie>d__222))]
	private IEnumerator DoDie() { }

	private void DoDropTools() { }

	private void DoFootstep() { }

	private void DoJumpSound() { }

	private void DropTools() { }

	[Command]
	[MoonSharpHidden]
	public void EquipTool(Tool tool) { }

	private bool FindGround(out ContactPoint groundCP, List<ContactPoint> allCPs) { }

	private bool FindStep(out Vector3 stepUpOffset, List<ContactPoint> allCPs, ContactPoint groundCP, Vector3 currVelocity) { }

	private void FixedUpdate() { }

	public bool get_Anchored() { }

	public string get_AvatarHash() { }

	private Camera get_Camera() { }

	public bool get_CanMove() { }

	public Color get_ChatColor() { }

	public int get_FaceID() { }

	public Vector3 get_Forward() { }

	public Color get_HeadColor() { }

	public float get_Health() { }

	public bool get_IsAdmin() { }

	public bool get_IsCreator() { }

	public bool get_IsInputFocused() { }

	public bool get_IsLoaded() { }

	public bool get_IsLocalPlayer() { }

	private bool get_IsMovementAllowed() { }

	private bool get_IsSitting() { }

	public float get_JumpPower() { }

	public Color get_LeftArmColor() { }

	public Color get_LeftLegColor() { }

	public float get_MaxHealth() { }

	public float get_MaxStamina() { }

	public bool get_Networkanchored() { }

	public string get_NetworkavatarHash() { }

	public bool get_NetworkcanChat() { }

	public bool get_NetworkcanMove() { }

	public Color get_NetworkchatColor() { }

	public float get_Networkhealth() { }

	public bool get_NetworkisAdmin() { }

	public bool get_NetworkisAgeRestricted() { }

	public bool get_NetworkisCreator() { }

	public string get_NetworkLeaderboardBadgeId() { }

	public bool get_Networkloaded() { }

	public float get_NetworkmaxStamina() { }

	public float get_NetworkrespawnTime() { }

	public Seat get_NetworksittingIn() { }

	public float get_NetworksprintSpeed() { }

	public float get_Networkstamina() { }

	public bool get_NetworkstaminaEnabled() { }

	public float get_NetworkstaminaRegen() { }

	public int get_NetworkuserID() { }

	public float get_NetworkwalkSpeed() { }

	public int get_PantsID() { }

	public Vector3 get_Position() { }

	public float get_RespawnTime() { }

	public Vector3 get_Right() { }

	public Color get_RightArmColor() { }

	public Color get_RightLegColor() { }

	public Vector3 get_Rotation() { }

	public int get_ShirtID() { }

	public Seat get_SittingIn() { }

	public Vector3 get_Size() { }

	public float get_SprintSpeed() { }

	public float get_Stamina() { }

	public bool get_StaminaEnabled() { }

	public float get_StaminaRegen() { }

	public override Transform get_ToolAttachmentPoint() { }

	public Color get_TorsoColor() { }

	public int get_UserID() { }

	public Vector3 get_Velocity() { }

	public float get_WalkSpeed() { }

	public Vector3 InverseTransformDirection(Vector3 direction) { }

	public Vector3 InverseTransformPoint(Vector3 point) { }

	public Vector3 InverseTransformVector(Vector3 vector) { }

	protected static void InvokeUserCode_CmdDied(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection) { }

	protected static void InvokeUserCode_CmdDropTools(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection) { }

	protected static void InvokeUserCode_CmdJumpSound(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection) { }

	protected static void InvokeUserCode_CmdNotifyRespawn(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection) { }

	protected static void InvokeUserCode_CmdSetHealth__Single(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection) { }

	protected static void InvokeUserCode_CmdSetSittingIn__Seat(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection) { }

	protected static void InvokeUserCode_CmdTouched__GameObject(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection) { }

	protected static void InvokeUserCode_CmdTouchEnded__GameObject(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection) { }

	protected static void InvokeUserCode_EquipTool__Tool(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection) { }

	protected static void InvokeUserCode_NotifyJoin(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection) { }

	protected static void InvokeUserCode_PlayAnimTargetRpc__String(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection) { }

	protected static void InvokeUserCode_RpcJumpSound(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection) { }

	protected static void InvokeUserCode_RpcSetAnchored__Boolean(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection) { }

	protected static void InvokeUserCode_RpcSetAnimatorActive__Boolean(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection) { }

	protected static void InvokeUserCode_RpcSetCanMove__Boolean(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection) { }

	protected static void InvokeUserCode_RpcSetChatColor__Color(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection) { }

	protected static void InvokeUserCode_RpcSetColor__BodyPart__Color(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection) { }

	protected static void InvokeUserCode_RpcSetHealth__Single(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection) { }

	protected static void InvokeUserCode_RpcSetJumpPower__Single(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection) { }

	protected static void InvokeUserCode_RpcSetMaxHealth__Single(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection) { }

	protected static void InvokeUserCode_RpcSetMaxStamina__Single(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection) { }

	protected static void InvokeUserCode_RpcSetRespawnTime__Single(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection) { }

	protected static void InvokeUserCode_RpcSetSprintSpeed__Single(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection) { }

	protected static void InvokeUserCode_RpcSetStamina__Single(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection) { }

	protected static void InvokeUserCode_RpcSetStaminaEnabled__Boolean(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection) { }

	protected static void InvokeUserCode_RpcSetStaminaRegen__Single(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection) { }

	protected static void InvokeUserCode_RpcSetWalkSpeed__Single(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection) { }

	protected static void InvokeUserCode_SendDisconnectMessageTargetRpc__String(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection) { }

	protected static void InvokeUserCode_SetTransformAttrTargetRpc__String__Vector3(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection) { }

	protected static void InvokeUserCode_TargetSetPosition__Vector3(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection) { }

	protected static void InvokeUserCode_UnsitTargetRpc__Boolean(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection) { }

	private bool IsGrounded() { }

	public void Kick(string reason = "You have been kicked from the server.") { }

	public void LoadAppearance(int userID) { }

	[IteratorStateMachine(typeof(<LoadMetadata>d__207))]
	private IEnumerator LoadMetadata(string authToken) { }

	public void LookAt(Vector3 target, Vector3 worldUp) { }

	public void LookAt(Vector3 target) { }

	public void LookAt(DynamicInstance target) { }

	private void Move(float hor, float ver) { }

	[Command]
	private void NotifyJoin() { }

	protected virtual void OnCollisionEnter(Collision collision) { }

	protected virtual void OnCollisionExit(Collision col) { }

	private void OnCollisionStay(Collision col) { }

	protected virtual void OnTriggerEnter(Collider collider) { }

	protected virtual void OnTriggerExit(Collider collider) { }

	public void OwnsItem(int assetId, DynValue callback) { }

	[MoonSharpHidden]
	public override void PlayAnim(string _anim) { }

	[MoonSharpHidden]
	[TargetRpc]
	public override void PlayAnimTargetRpc(string _anim) { }

	[IteratorStateMachine(typeof(<PostPlayerLoad>d__196))]
	private IEnumerator PostPlayerLoad() { }

	private bool PressingMovementKeys() { }

	public void ResetAppearance() { }

	private bool ResolveStepUp(out Vector3 stepUpOffset, ContactPoint stepTestCP, ContactPoint groundCP) { }

	public void Respawn() { }

	public void Rotate(Vector3 eulerAngles) { }

	public void RotateAround(Vector3 point, Vector3 axis, float angle) { }

	[ClientRpc]
	private void RpcJumpSound() { }

	[ClientRpc]
	private void RpcSetAnchored(bool anchored) { }

	[ClientRpc]
	private void RpcSetAnimatorActive(bool active) { }

	[ClientRpc]
	private void RpcSetCanMove(bool canMove) { }

	[ClientRpc]
	private void RpcSetChatColor(Color col) { }

	[ClientRpc]
	private void RpcSetColor(BodyPart bodyPart, Color color) { }

	[ClientRpc]
	private void RpcSetHealth(float health) { }

	[ClientRpc]
	private void RpcSetJumpPower(float jumpPower) { }

	[ClientRpc]
	private void RpcSetMaxHealth(float maxHealth) { }

	[ClientRpc]
	private void RpcSetMaxStamina(float val) { }

	[ClientRpc]
	private void RpcSetRespawnTime(float time) { }

	[ClientRpc]
	private void RpcSetSprintSpeed(float sprintSpeed) { }

	[ClientRpc]
	private void RpcSetStamina(float val) { }

	[ClientRpc]
	private void RpcSetStaminaEnabled(bool val) { }

	[ClientRpc]
	private void RpcSetStaminaRegen(float val) { }

	[ClientRpc]
	private void RpcSetWalkSpeed(float walkSpeed) { }

	private void SendChat() { }

	[TargetRpc]
	private void SendDisconnectMessageTargetRpc(string message) { }

	public virtual void SerializeSyncVars(NetworkWriter writer, bool forceAll) { }

	private void ServerRespawn() { }

	public void set_Anchored(bool value) { }

	private void set_Camera(Camera value) { }

	public void set_CanMove(bool value) { }

	public void set_ChatColor(Color value) { }

	public void set_FaceID(int value) { }

	public void set_HeadColor(Color value) { }

	public void set_Health(float value) { }

	public void set_JumpPower(float value) { }

	public void set_LeftArmColor(Color value) { }

	public void set_LeftLegColor(Color value) { }

	public void set_MaxHealth(float value) { }

	public void set_MaxStamina(float value) { }

	public void set_Networkanchored(in bool value) { }

	public void set_NetworkavatarHash(in string value) { }

	public void set_NetworkcanChat(in bool value) { }

	public void set_NetworkcanMove(in bool value) { }

	public void set_NetworkchatColor(in Color value) { }

	public void set_Networkhealth(in float value) { }

	public void set_NetworkisAdmin(in bool value) { }

	public void set_NetworkisAgeRestricted(in bool value) { }

	public void set_NetworkisCreator(in bool value) { }

	public void set_NetworkLeaderboardBadgeId(in string value) { }

	public void set_Networkloaded(in bool value) { }

	public void set_NetworkmaxStamina(in float value) { }

	public void set_NetworkrespawnTime(in float value) { }

	public void set_NetworksittingIn(in Seat value) { }

	public void set_NetworksprintSpeed(in float value) { }

	public void set_Networkstamina(in float value) { }

	public void set_NetworkstaminaEnabled(in bool value) { }

	public void set_NetworkstaminaRegen(in float value) { }

	public void set_NetworkuserID(in int value) { }

	public void set_NetworkwalkSpeed(in float value) { }

	public void set_PantsID(int value) { }

	public void set_Position(Vector3 value) { }

	public void set_RespawnTime(float value) { }

	public void set_RightArmColor(Color value) { }

	public void set_RightLegColor(Color value) { }

	public void set_Rotation(Vector3 value) { }

	public void set_ShirtID(int value) { }

	public void set_Size(Vector3 value) { }

	public void set_SprintSpeed(float value) { }

	public void set_Stamina(float value) { }

	public void set_StaminaEnabled(bool value) { }

	public void set_StaminaRegen(float value) { }

	public void set_TorsoColor(Color value) { }

	private void set_UserID(int value) { }

	public void set_Velocity(Vector3 value) { }

	public void set_WalkSpeed(float value) { }

	private void SetChildLayers(Transform root, LayerMask layer) { }

	[MoonSharpHidden]
	public void SetLoaded(string authToken) { }

	private void SetSittingIn(Seat seat) { }

	[MoonSharpHidden]
	[TargetRpc]
	public void SetTransformAttrTargetRpc(string attr, Vector3 value) { }

	[MoonSharpHidden]
	public void SetUserID(int userID) { }

	public void Sit(Seat seat) { }

	protected virtual void Start() { }

	[IteratorStateMachine(typeof(<StopScream>d__211))]
	private IEnumerator StopScream() { }

	[MoonSharpHidden]
	[TargetRpc]
	public void TargetSetPosition(Vector3 pos) { }

	public Vector3 TransformDirection(Vector3 direction) { }

	public Vector3 TransformPoint(Vector3 point) { }

	public Vector3 TransformVector(Vector3 vector) { }

	public void Translate(Vector3 translation) { }

	public void Unsit(bool addForce = true) { }

	[TargetRpc]
	private void UnsitTargetRpc(bool addForce) { }

	private void Update() { }

	private void UpdateFootsteps() { }

	private void UpdateFov(bool sprinting) { }

	protected void UserCode_CmdDied() { }

	protected void UserCode_CmdDropTools() { }

	protected void UserCode_CmdJumpSound() { }

	protected void UserCode_CmdNotifyRespawn() { }

	protected void UserCode_CmdSetHealth__Single(float health) { }

	protected void UserCode_CmdSetSittingIn__Seat(Seat seat) { }

	protected void UserCode_CmdTouched__GameObject(GameObject other) { }

	protected void UserCode_CmdTouchEnded__GameObject(GameObject other) { }

	protected void UserCode_EquipTool__Tool(Tool tool) { }

	protected void UserCode_NotifyJoin() { }

	protected override void UserCode_PlayAnimTargetRpc__String(string _anim) { }

	protected void UserCode_RpcJumpSound() { }

	protected void UserCode_RpcSetAnchored__Boolean(bool anchored) { }

	protected void UserCode_RpcSetAnimatorActive__Boolean(bool active) { }

	protected void UserCode_RpcSetCanMove__Boolean(bool canMove) { }

	protected void UserCode_RpcSetChatColor__Color(Color col) { }

	protected void UserCode_RpcSetColor__BodyPart__Color(BodyPart bodyPart, Color color) { }

	protected void UserCode_RpcSetHealth__Single(float health) { }

	protected void UserCode_RpcSetJumpPower__Single(float jumpPower) { }

	protected void UserCode_RpcSetMaxHealth__Single(float maxHealth) { }

	protected void UserCode_RpcSetMaxStamina__Single(float val) { }

	protected void UserCode_RpcSetRespawnTime__Single(float time) { }

	protected void UserCode_RpcSetSprintSpeed__Single(float sprintSpeed) { }

	protected void UserCode_RpcSetStamina__Single(float val) { }

	protected void UserCode_RpcSetStaminaEnabled__Boolean(bool val) { }

	protected void UserCode_RpcSetStaminaRegen__Single(float val) { }

	protected void UserCode_RpcSetWalkSpeed__Single(float walkSpeed) { }

	protected void UserCode_SendDisconnectMessageTargetRpc__String(string message) { }

	protected void UserCode_SetTransformAttrTargetRpc__String__Vector3(string attr, Vector3 value) { }

	protected void UserCode_TargetSetPosition__Vector3(Vector3 pos) { }

	protected void UserCode_UnsitTargetRpc__Boolean(bool addForce) { }

	public virtual bool Weaved() { }

}

