namespace Polytoria.Datamodel.Proxies;

public class UIButtonProxy : UILabelProxy
{
	private readonly UIButton uiButton; //Field offset: 0x30

	public bool Interactable
	{
		 get { } //Length: 30
		 set { } //Length: 30
	}

	[MoonSharpHidden]
	public UIButtonProxy(UIButton target) { }

	public bool get_Interactable() { }

	public void set_Interactable(bool value) { }

}

