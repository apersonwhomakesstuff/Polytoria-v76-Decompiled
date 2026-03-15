namespace Polytoria.Datamodel.Proxies;

public class GameProxy : InstanceProxy
{
	private readonly Game game; //Field offset: 0x18

	public int GameID
	{
		 get { } //Length: 29
	}

	public int InstanceCount
	{
		 get { } //Length: 29
	}

	public int LocalInstanceCount
	{
		 get { } //Length: 29
	}

	public int PlayersConnected
	{
		 get { } //Length: 29
	}

	[LuaEventParameter(typeof(float), "deltaTime", False)]
	public LuaEvent Rendered
	{
		 get { } //Length: 30
	}

	[MoonSharpHidden]
	public GameProxy(Game target) { }

	public int get_GameID() { }

	public int get_InstanceCount() { }

	public int get_LocalInstanceCount() { }

	public int get_PlayersConnected() { }

	public LuaEvent get_Rendered() { }

}

