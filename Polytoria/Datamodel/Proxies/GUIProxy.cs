namespace Polytoria.Datamodel.Proxies;

public class GUIProxy : InstanceProxy
{
	private readonly GUI gui; //Field offset: 0x18

	public bool Visible
	{
		 get { } //Length: 30
		 set { } //Length: 30
	}

	[MoonSharpHidden]
	public GUIProxy(GUI target) { }

	public bool get_Visible() { }

	public void set_Visible(bool value) { }

}

