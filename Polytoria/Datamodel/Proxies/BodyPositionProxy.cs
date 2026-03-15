namespace Polytoria.Datamodel.Proxies;

public class BodyPositionProxy : InstanceProxy
{
	private readonly BodyPosition bodyPosition; //Field offset: 0x18

	public float AcceptanceDistance
	{
		 get { } //Length: 31
		 set { } //Length: 30
	}

	public float Force
	{
		 get { } //Length: 31
		 set { } //Length: 30
	}

	public Vector3 TargetPosition
	{
		 get { } //Length: 47
		 set { } //Length: 53
	}

	[MoonSharpHidden]
	public BodyPositionProxy(BodyPosition target) { }

	public float get_AcceptanceDistance() { }

	public float get_Force() { }

	public Vector3 get_TargetPosition() { }

	public void set_AcceptanceDistance(float value) { }

	public void set_Force(float value) { }

	public void set_TargetPosition(Vector3 value) { }

}

