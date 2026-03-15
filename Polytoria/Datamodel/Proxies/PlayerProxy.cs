namespace Polytoria.Datamodel.Proxies;

public class PlayerProxy : InstanceProxy
{
	private readonly Player player; //Field offset: 0x18

	public bool Anchored
	{
		 get { } //Length: 30
		 set { } //Length: 30
	}

	public bool CanMove
	{
		 get { } //Length: 30
		 set { } //Length: 30
	}

	public Color ChatColor
	{
		 get { } //Length: 36
		 set { } //Length: 44
	}

	[LuaEventParameter(typeof(string), "message", False)]
	[LuaEventParameter(typeof(PlayerChatEvent), "event", False)]
	public LuaEvent Chatted
	{
		 get { } //Length: 30
	}

	public LuaEvent Died
	{
		 get { } //Length: 30
	}

	public int FaceID
	{
		 get { } //Length: 29
		 set { } //Length: 30
	}

	public Vector3 Forward
	{
		 get { } //Length: 59
	}

	public Color HeadColor
	{
		 get { } //Length: 51
		 set { } //Length: 44
	}

	public float Health
	{
		 get { } //Length: 31
		 set { } //Length: 30
	}

	public bool IsAdmin
	{
		 get { } //Length: 30
	}

	public bool IsCreator
	{
		 get { } //Length: 30
	}

	public bool IsInputFocused
	{
		 get { } //Length: 29
	}

	public float JumpPower
	{
		 get { } //Length: 31
		 set { } //Length: 30
	}

	public Color LeftArmColor
	{
		 get { } //Length: 51
		 set { } //Length: 44
	}

	public Color LeftLegColor
	{
		 get { } //Length: 51
		 set { } //Length: 44
	}

	public float MaxHealth
	{
		 get { } //Length: 31
		 set { } //Length: 30
	}

	public float MaxStamina
	{
		 get { } //Length: 31
		 set { } //Length: 30
	}

	public int PantsID
	{
		 get { } //Length: 29
		 set { } //Length: 30
	}

	public Vector3 Position
	{
		 get { } //Length: 59
		 set { } //Length: 53
	}

	public LuaEvent Respawned
	{
		 get { } //Length: 30
	}

	public float RespawnTime
	{
		 get { } //Length: 31
		 set { } //Length: 30
	}

	public Vector3 Right
	{
		 get { } //Length: 59
	}

	public Color RightArmColor
	{
		 get { } //Length: 51
		 set { } //Length: 44
	}

	public Color RightLegColor
	{
		 get { } //Length: 51
		 set { } //Length: 44
	}

	public Vector3 Rotation
	{
		 get { } //Length: 59
		 set { } //Length: 53
	}

	public int ShirtID
	{
		 get { } //Length: 29
		 set { } //Length: 30
	}

	public Seat SittingIn
	{
		 get { } //Length: 29
	}

	public Vector3 Size
	{
		 get { } //Length: 59
		 set { } //Length: 53
	}

	public float SprintSpeed
	{
		 get { } //Length: 31
		 set { } //Length: 30
	}

	public float Stamina
	{
		 get { } //Length: 31
		 set { } //Length: 30
	}

	public bool StaminaEnabled
	{
		 get { } //Length: 30
		 set { } //Length: 30
	}

	public float StaminaRegen
	{
		 get { } //Length: 31
		 set { } //Length: 30
	}

	public Color TorsoColor
	{
		 get { } //Length: 51
		 set { } //Length: 44
	}

	public int UserID
	{
		 get { } //Length: 29
	}

	public Vector3 Velocity
	{
		 get { } //Length: 59
		 set { } //Length: 53
	}

	public float WalkSpeed
	{
		 get { } //Length: 31
		 set { } //Length: 30
	}

	[MoonSharpHidden]
	public PlayerProxy(Player target) { }

	public void ClearAppearance() { }

	public bool get_Anchored() { }

	public bool get_CanMove() { }

	public Color get_ChatColor() { }

	public LuaEvent get_Chatted() { }

	public LuaEvent get_Died() { }

	public int get_FaceID() { }

	public Vector3 get_Forward() { }

	public Color get_HeadColor() { }

	public float get_Health() { }

	public bool get_IsAdmin() { }

	public bool get_IsCreator() { }

	public bool get_IsInputFocused() { }

	public float get_JumpPower() { }

	public Color get_LeftArmColor() { }

	public Color get_LeftLegColor() { }

	public float get_MaxHealth() { }

	public float get_MaxStamina() { }

	public int get_PantsID() { }

	public Vector3 get_Position() { }

	public LuaEvent get_Respawned() { }

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

	public Color get_TorsoColor() { }

	public int get_UserID() { }

	public Vector3 get_Velocity() { }

	public float get_WalkSpeed() { }

	public Vector3 InverseTransformDirection(Vector3 direction) { }

	public Vector3 InverseTransformPoint(Vector3 point) { }

	public Vector3 InverseTransformVector(Vector3 vector) { }

	public void Kick(string reason = "You have been kicked from the server.") { }

	public void LoadAppearance(int userID) { }

	public void LookAt(Vector3 lookTarget) { }

	public void LookAt(Vector3 lookTarget, Vector3 worldUp) { }

	public void LookAt(DynamicInstance instance) { }

	[LuaCallbackParameter("callback", typeof(bool), "success", False)]
	[LuaCallbackParameter("callback", typeof(bool), "owned", False)]
	public void OwnsItem(int assetId, DynValue callback) { }

	public void ResetAppearance() { }

	public void Respawn() { }

	public void Rotate(Vector3 eulerAngles) { }

	public void RotateAround(Vector3 point, Vector3 axis, float angle) { }

	public void set_Anchored(bool value) { }

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

	public void set_Velocity(Vector3 value) { }

	public void set_WalkSpeed(float value) { }

	public void Sit(Seat seat) { }

	public Vector3 TransformDirection(Vector3 direction) { }

	public Vector3 TransformPoint(Vector3 point) { }

	public Vector3 TransformVector(Vector3 vector) { }

	public void Translate(Vector3 translation) { }

	public void Unsit(bool addForce = true) { }

}

