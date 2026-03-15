namespace Polytoria.Datamodel.Proxies;

public class PlayerDefaultsProxy : InstanceProxy
{
	private readonly PlayerDefaults playerDefaults; //Field offset: 0x18

	public Color ChatColor
	{
		 get { } //Length: 36
		 set { } //Length: 44
	}

	public float JumpPower
	{
		 get { } //Length: 31
		 set { } //Length: 30
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

	public float RespawnTime
	{
		 get { } //Length: 31
		 set { } //Length: 30
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

	public float WalkSpeed
	{
		 get { } //Length: 31
		 set { } //Length: 30
	}

	[MoonSharpHidden]
	public PlayerDefaultsProxy(PlayerDefaults target) { }

	public Color get_ChatColor() { }

	public float get_JumpPower() { }

	public float get_MaxHealth() { }

	public float get_MaxStamina() { }

	public float get_RespawnTime() { }

	public float get_SprintSpeed() { }

	public float get_Stamina() { }

	public bool get_StaminaEnabled() { }

	public float get_StaminaRegen() { }

	public float get_WalkSpeed() { }

	public void set_ChatColor(Color value) { }

	public void set_JumpPower(float value) { }

	public void set_MaxHealth(float value) { }

	public void set_MaxStamina(float value) { }

	public void set_RespawnTime(float value) { }

	public void set_SprintSpeed(float value) { }

	public void set_Stamina(float value) { }

	public void set_StaminaEnabled(bool value) { }

	public void set_StaminaRegen(float value) { }

	public void set_WalkSpeed(float value) { }

}

