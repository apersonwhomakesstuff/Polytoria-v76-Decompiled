namespace Polytoria.Datamodel.Proxies;

public class RemoveEventProxy : InstanceProxy
{
	private readonly RemoteEvent remoteEvent; //Field offset: 0x18

	[LuaEventParameter(typeof(Player), "sender", False)]
	[LuaEventParameter(typeof(object), "value", False)]
	public LuaEvent Invoked
	{
		 get { } //Length: 30
	}

	[MoonSharpHidden]
	public RemoveEventProxy(RemoteEvent target) { }

	public LuaEvent get_Invoked() { }

	public void Invoke(string val) { }

	public void Invoke(bool val) { }

	public void Invoke(float val) { }

	public void Invoke(int val) { }

	public void Invoke(Vector3 val) { }

	public void Invoke(Color val) { }

	public void Invoke(Instance val) { }

}

