namespace Polytoria.Datamodel.Proxies.Services;

public class InsertServiceProxy
{
	private readonly InsertService insertService; //Field offset: 0x10

	[MoonSharpHidden]
	public InsertServiceProxy(InsertService target) { }

	[LuaCallbackParameter("callback", typeof(Instance), "model", False)]
	public void Model(int id, DynValue callback = null) { }

}

