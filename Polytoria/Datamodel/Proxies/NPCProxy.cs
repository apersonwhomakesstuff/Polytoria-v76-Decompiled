namespace Polytoria.Datamodel.Proxies;

public class NPCProxy : DynamicInstanceProxy
{
	private readonly NPC npc; //Field offset: 0x20

	public bool Anchored
	{
		 get { } //Length: 30
		 set { } //Length: 30
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

	public bool Grounded
	{
		 get { } //Length: 30
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

	public Instance MoveTarget
	{
		 get { } //Length: 30
		 set { } //Length: 30
	}

	public float NavDestinationDistance
	{
		 get { } //Length: 29
	}

	public bool NavDestinationReached
	{
		 get { } //Length: 29
	}

	public bool NavDestinationValid
	{
		 get { } //Length: 29
	}

	public int PantsID
	{
		 get { } //Length: 29
		 set { } //Length: 30
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

	public int ShirtID
	{
		 get { } //Length: 29
		 set { } //Length: 30
	}

	public Color TorsoColor
	{
		 get { } //Length: 51
		 set { } //Length: 44
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
	public NPCProxy(NPC target) { }

	public void ClearAppearance() { }

	public void DropTool() { }

	public void EquipTool(Tool tool) { }

	public bool get_Anchored() { }

	public LuaEvent get_Died() { }

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

	public int get_PantsID() { }

	public Color get_RightArmColor() { }

	public Color get_RightLegColor() { }

	public int get_ShirtID() { }

	public Color get_TorsoColor() { }

	public Vector3 get_Velocity() { }

	public float get_WalkSpeed() { }

	public void Jump() { }

	public void LoadAppearance(int userID) { }

	public void Respawn() { }

	public void set_Anchored(bool value) { }

	public void set_FaceID(int value) { }

	public void set_HeadColor(Color value) { }

	public void set_Health(float value) { }

	public void set_JumpPower(float value) { }

	public void set_LeftArmColor(Color value) { }

	public void set_LeftLegColor(Color value) { }

	public void set_MaxHealth(float value) { }

	public void set_MoveTarget(Instance value) { }

	public void set_PantsID(int value) { }

	public void set_RightArmColor(Color value) { }

	public void set_RightLegColor(Color value) { }

	public void set_ShirtID(int value) { }

	public void set_TorsoColor(Color value) { }

	public void set_Velocity(Vector3 value) { }

	public void set_WalkSpeed(float value) { }

	public void SetNavDestination(Vector3 destination) { }

}

