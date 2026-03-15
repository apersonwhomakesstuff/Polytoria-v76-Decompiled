namespace Polytoria.Lua;

[AttributeUsage(AttributeTargets::Method (64), AllowMultiple = True)]
public class LuaCallbackParameter : PropertyAttribute
{

	public LuaCallbackParameter(string callback, Type type, string name, bool nullable = false) { }

}

