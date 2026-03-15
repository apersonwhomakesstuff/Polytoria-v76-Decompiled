namespace Polytoria.Lua;

[AttributeUsage(AttributeTargets::Property (128), AllowMultiple = True)]
public class LuaEventParameter : PropertyAttribute
{

	public LuaEventParameter(Type type, string name, bool nullable = false) { }

}

