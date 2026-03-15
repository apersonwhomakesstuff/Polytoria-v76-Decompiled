namespace Polytoria.Datamodel.Proxies;

public class Vector3ValueProxy : ValueBaseProxy
{
	private readonly Vector3Value vector3Value; //Field offset: 0x20

	public Vector3 Value
	{
		 get { } //Length: 47
		 set { } //Length: 2292
	}

	[MoonSharpHidden]
	public Vector3ValueProxy(Vector3Value target) { }

	public Vector3 get_Value() { }

	public void set_Value(Vector3 value) { }

}

