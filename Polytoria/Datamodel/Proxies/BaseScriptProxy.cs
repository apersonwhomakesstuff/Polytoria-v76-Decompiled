namespace Polytoria.Datamodel.Proxies;

[DefaultMember("Item")]
public class BaseScriptProxy : InstanceProxy
{
	private readonly BaseScript baseScript; //Field offset: 0x18

	public object Item
	{
		 get { } //Length: 30
		 set { } //Length: 30
	}

	[MoonSharpHidden]
	public BaseScriptProxy(BaseScript target) { }

	public void Call(string function, Object[] args) { }

	public object get_Item(string name) { }

	public void set_Item(string name, object value) { }

}

