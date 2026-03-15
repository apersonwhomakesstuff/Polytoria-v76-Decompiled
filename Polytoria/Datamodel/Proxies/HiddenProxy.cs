namespace Polytoria.Datamodel.Proxies;

public class HiddenProxy : InstanceProxy
{
	private readonly Hidden hidden; //Field offset: 0x18

	[MoonSharpHidden]
	public HiddenProxy(Hidden target) { }

}

