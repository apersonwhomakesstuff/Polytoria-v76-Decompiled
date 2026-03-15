namespace Polytoria.Datamodel.Proxies;

public class SeatProxy : PartProxy
{
	private readonly Seat seat; //Field offset: 0x28

	public Player Occupant
	{
		 get { } //Length: 29
	}

	[LuaEventParameter(typeof(Player), "occupant", False)]
	public LuaEvent Sat
	{
		 get { } //Length: 30
	}

	[LuaEventParameter(typeof(Player), "occupant", False)]
	public LuaEvent Vacated
	{
		 get { } //Length: 30
	}

	[MoonSharpHidden]
	public SeatProxy(Seat target) { }

	public Player get_Occupant() { }

	public LuaEvent get_Sat() { }

	public LuaEvent get_Vacated() { }

}

