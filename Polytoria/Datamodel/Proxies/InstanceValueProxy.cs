namespace Polytoria.Datamodel.Proxies;

public class InstanceValueProxy : ValueBaseProxy
{
	private readonly InstanceValue instanceValue; //Field offset: 0x20

	public Instance Value
	{
		 get { } //Length: 29
		 set { } //Length: 30
	}

	[MoonSharpHidden]
	public InstanceValueProxy(InstanceValue target) { }

	public Instance get_Value() { }

	public void set_Value(Instance value) { }

}

