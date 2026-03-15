namespace Polytoria.Datamodel.Proxies;

public class PlayersProxy : InstanceProxy
{
	private readonly Players players; //Field offset: 0x18

	public Player LocalPlayer
	{
		 get { } //Length: 30
	}

	[LuaEventParameter(typeof(Player), "player", False)]
	public LuaEvent PlayerAdded
	{
		 get { } //Length: 30
	}

	public bool PlayerCollisionEnabled
	{
		 get { } //Length: 30
		 set { } //Length: 30
	}

	[LuaEventParameter(typeof(Player), "player", False)]
	public LuaEvent PlayerRemoved
	{
		 get { } //Length: 30
	}

	[MoonSharpHidden]
	public PlayersProxy(Players target) { }

	public Player get_LocalPlayer() { }

	public LuaEvent get_PlayerAdded() { }

	public bool get_PlayerCollisionEnabled() { }

	public LuaEvent get_PlayerRemoved() { }

	public Player GetPlayer(string username) { }

	public Player GetPlayerByID(int id) { }

	public Player[] GetPlayers() { }

	public void set_PlayerCollisionEnabled(bool value) { }

}

