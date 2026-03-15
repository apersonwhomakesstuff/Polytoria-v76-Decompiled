namespace Polytoria.Datamodel.Proxies;

public class ToolProxy : DynamicInstanceProxy
{
	private readonly Tool tool; //Field offset: 0x20

	public LuaEvent Activated
	{
		 get { } //Length: 30
	}

	public LuaEvent Deactivated
	{
		 get { } //Length: 30
	}

	public bool Droppable
	{
		 get { } //Length: 30
		 set { } //Length: 30
	}

	public LuaEvent Equipped
	{
		 get { } //Length: 30
	}

	public LuaEvent Unequipped
	{
		 get { } //Length: 30
	}

	[MoonSharpHidden]
	public ToolProxy(Tool target) { }

	public LuaEvent get_Activated() { }

	public LuaEvent get_Deactivated() { }

	public bool get_Droppable() { }

	public LuaEvent get_Equipped() { }

	public LuaEvent get_Unequipped() { }

	public void Play(string anim) { }

	public void set_Droppable(bool value) { }

}

