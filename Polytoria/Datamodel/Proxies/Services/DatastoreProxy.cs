namespace Polytoria.Datamodel.Proxies.Services;

public class DatastoreProxy
{
	private readonly Datastore datastore; //Field offset: 0x10

	public string Key
	{
		 get { } //Length: 27
	}

	public LuaEvent Loaded
	{
		 get { } //Length: 27
	}

	public bool Loading
	{
		 get { } //Length: 27
	}

	[MoonSharpHidden]
	public DatastoreProxy(Datastore target) { }

	[LuaCallbackParameter("callback", typeof(object), "value", True)]
	[LuaCallbackParameter("callback", typeof(bool), "success", False)]
	[LuaCallbackParameter("callback", typeof(string), "error", True)]
	public void Get(string key, DynValue callback) { }

	public string get_Key() { }

	public LuaEvent get_Loaded() { }

	public bool get_Loading() { }

	[LuaCallbackParameter("callback", typeof(bool), "success", False)]
	[LuaCallbackParameter("callback", typeof(string), "error", True)]
	public void Remove(string key, DynValue callback = null) { }

	[LuaCallbackParameter("callback", typeof(bool), "success", False)]
	[LuaCallbackParameter("callback", typeof(string), "error", True)]
	public void Set(string key, DynValue value, DynValue callback = null) { }

}

