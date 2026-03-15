namespace Polytoria.Lua;

public class LuaEvent
{
	private List<DynValue> callbacks; //Field offset: 0x10

	public LuaEvent() { }

	public void Connect(DynValue func) { }

	public void Disconnect(DynValue func) { }

	[MoonSharpHidden]
	public void Invoke(Object[] par) { }

}

