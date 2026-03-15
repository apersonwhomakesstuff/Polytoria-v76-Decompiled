namespace Polytoria.Datamodel.Proxies;

public class PlayerGUIProxy : InstanceProxy
{
	private readonly PlayerGUI playerGUI; //Field offset: 0x18

	public bool Interactable
	{
		 get { } //Length: 30
		 set { } //Length: 30
	}

	public float Opacity
	{
		 get { } //Length: 31
		 set { } //Length: 30
	}

	[MoonSharpHidden]
	public PlayerGUIProxy(PlayerGUI target) { }

	public bool get_Interactable() { }

	public float get_Opacity() { }

	public void set_Interactable(bool value) { }

	public void set_Opacity(float value) { }

}

