namespace Polytoria.Datamodel;

[Instantiatable]
public class Signal : Instance
{
	public LuaEvent Invoked; //Field offset: 0xF8

	public Signal() { }

	public void Invoke(Object[] par) { }

	public virtual bool Weaved() { }

}

