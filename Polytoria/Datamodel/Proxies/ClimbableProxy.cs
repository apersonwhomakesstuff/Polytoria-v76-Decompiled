namespace Polytoria.Datamodel.Proxies;

public class ClimbableProxy : PartProxy
{
	private readonly Climbable climbable; //Field offset: 0x28

	public float ClimbSpeed
	{
		 get { } //Length: 31
		 set { } //Length: 30
	}

	[MoonSharpHidden]
	public ClimbableProxy(Climbable target) { }

	public float get_ClimbSpeed() { }

	public void set_ClimbSpeed(float value) { }

}

