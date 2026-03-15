namespace Polytoria.Datamodel;

public class PlayerDefaults : Instance
{
	[SyncVar]
	private float maxHealth; //Field offset: 0xF8
	[SyncVar]
	private float walkSpeed; //Field offset: 0xFC
	[SyncVar]
	private float sprintSpeed; //Field offset: 0x100
	[SyncVar]
	private bool staminaEnabled; //Field offset: 0x104
	[SyncVar]
	private float stamina; //Field offset: 0x108
	[SyncVar]
	private float maxStamina; //Field offset: 0x10C
	[SyncVar]
	private float staminaRegen; //Field offset: 0x110
	[SyncVar]
	private float jumpPower; //Field offset: 0x114
	[SyncVar]
	private float respawnTime; //Field offset: 0x118
	[SyncVar]
	private Color chatColor; //Field offset: 0x11C

	[Archivable]
	[CreatorProperty]
	public Color ChatColor
	{
		 get { } //Length: 14
		 set { } //Length: 202
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
	public float MaxHealth
	{
		 get { } //Length: 9
		 set { } //Length: 180
	}

	[Archivable]
	[CreatorProperty]
	public float MaxStamina
	{
		 get { } //Length: 9
		 set { } //Length: 180
	}

	public Color NetworkchatColor
	{
		 get { } //Length: 14
		 set { } //Length: 202
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

	public float NetworkwalkSpeed
	{
		 get { } //Length: 9
		 set { } //Length: 180
	}

	[Archivable]
	[CreatorProperty]
	public float RespawnTime
	{
		 get { } //Length: 9
		 set { } //Length: 180
	}

	[Archivable]
	[CreatorProperty]
	public float SprintSpeed
	{
		 get { } //Length: 9
		 set { } //Length: 180
	}

	[Archivable]
	[CreatorProperty]
	public float Stamina
	{
		 get { } //Length: 9
		 set { } //Length: 180
	}

	[Archivable]
	[CreatorProperty]
	public bool StaminaEnabled
	{
		 get { } //Length: 8
		 set { } //Length: 182
	}

	[Archivable]
	[CreatorProperty]
	public float StaminaRegen
	{
		 get { } //Length: 9
		 set { } //Length: 180
	}

	[Archivable]
	[CreatorProperty]
	public float WalkSpeed
	{
		 get { } //Length: 9
		 set { } //Length: 180
	}

	private static PlayerDefaults() { }

	public PlayerDefaults() { }

	protected virtual void Awake() { }

	[Command(requiresAuthority = False)]
	private void CmdLoadDefaults(Player player) { }

	public virtual void DeserializeSyncVars(NetworkReader reader, bool initialState) { }

	public Color get_ChatColor() { }

	public float get_JumpPower() { }

	public float get_MaxHealth() { }

	public float get_MaxStamina() { }

	public Color get_NetworkchatColor() { }

	public float get_NetworkjumpPower() { }

	public float get_NetworkmaxHealth() { }

	public float get_NetworkmaxStamina() { }

	public float get_NetworkrespawnTime() { }

	public float get_NetworksprintSpeed() { }

	public float get_Networkstamina() { }

	public bool get_NetworkstaminaEnabled() { }

	public float get_NetworkstaminaRegen() { }

	public float get_NetworkwalkSpeed() { }

	public float get_RespawnTime() { }

	public float get_SprintSpeed() { }

	public float get_Stamina() { }

	public bool get_StaminaEnabled() { }

	public float get_StaminaRegen() { }

	public float get_WalkSpeed() { }

	protected static void InvokeUserCode_CmdLoadDefaults__Player(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection) { }

	public void LoadDefaults(Player player) { }

	public virtual void SerializeSyncVars(NetworkWriter writer, bool forceAll) { }

	public void set_ChatColor(Color value) { }

	public void set_JumpPower(float value) { }

	public void set_MaxHealth(float value) { }

	public void set_MaxStamina(float value) { }

	public void set_NetworkchatColor(in Color value) { }

	public void set_NetworkjumpPower(in float value) { }

	public void set_NetworkmaxHealth(in float value) { }

	public void set_NetworkmaxStamina(in float value) { }

	public void set_NetworkrespawnTime(in float value) { }

	public void set_NetworksprintSpeed(in float value) { }

	public void set_Networkstamina(in float value) { }

	public void set_NetworkstaminaEnabled(in bool value) { }

	public void set_NetworkstaminaRegen(in float value) { }

	public void set_NetworkwalkSpeed(in float value) { }

	public void set_RespawnTime(float value) { }

	public void set_SprintSpeed(float value) { }

	public void set_Stamina(float value) { }

	public void set_StaminaEnabled(bool value) { }

	public void set_StaminaRegen(float value) { }

	public void set_WalkSpeed(float value) { }

	protected virtual void Start() { }

	protected void UserCode_CmdLoadDefaults__Player(Player player) { }

	public virtual bool Weaved() { }

}

