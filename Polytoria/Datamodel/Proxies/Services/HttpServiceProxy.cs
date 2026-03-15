namespace Polytoria.Datamodel.Proxies.Services;

public class HttpServiceProxy
{
	private readonly HttpService httpService; //Field offset: 0x10

	[MoonSharpHidden]
	public HttpServiceProxy(HttpService target) { }

	[LuaCallbackParameter("callback", typeof(string), "data", True)]
	[LuaCallbackParameter("callback", typeof(bool), "error", False)]
	[LuaCallbackParameter("callback", typeof(string), "message", True)]
	public static void Delete(string url, DynValue callback = null, Table headers = null) { }

	[LuaCallbackParameter("callback", typeof(string), "data", True)]
	[LuaCallbackParameter("callback", typeof(bool), "error", False)]
	[LuaCallbackParameter("callback", typeof(string), "message", True)]
	public static void Get(string url, DynValue callback = null, Table headers = null) { }

	[LuaCallbackParameter("callback", typeof(string), "data", True)]
	[LuaCallbackParameter("callback", typeof(bool), "error", False)]
	[LuaCallbackParameter("callback", typeof(string), "message", True)]
	public static void Patch(string url, string body, DynValue callback = null, Table headers = null) { }

	[LuaCallbackParameter("callback", typeof(string), "data", True)]
	[LuaCallbackParameter("callback", typeof(bool), "error", False)]
	[LuaCallbackParameter("callback", typeof(string), "message", True)]
	public static void Post(string url, string body, DynValue callback = null, Table headers = null) { }

	[LuaCallbackParameter("callback", typeof(string), "data", True)]
	[LuaCallbackParameter("callback", typeof(bool), "error", False)]
	[LuaCallbackParameter("callback", typeof(string), "message", True)]
	public static void Put(string url, string body, DynValue callback = null, Table headers = null) { }

}

