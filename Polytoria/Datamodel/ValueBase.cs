namespace Polytoria.Datamodel;

public class ValueBase : Instance
{
	public LuaEvent Changed; //Field offset: 0xF8

	public ValueBase() { }

	protected void InvokeChanged() { }

	public virtual bool Weaved() { }

}

