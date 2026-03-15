namespace RLD;

public class XZGridRayHit
{
	private XZGridCell _hitCell; //Field offset: 0x10
	private Vector3 _hitPoint; //Field offset: 0x18
	private float _hitEnter; //Field offset: 0x24
	private Vector3 _hitNormal; //Field offset: 0x28
	private Plane _hitPlane; //Field offset: 0x34

	public XZGridCell HitCell
	{
		 get { } //Length: 5
	}

	public float HitEnter
	{
		 get { } //Length: 6
	}

	public Vector3 HitNormal
	{
		 get { } //Length: 19
	}

	public Plane HitPlane
	{
		 get { } //Length: 11
	}

	public Vector3 HitPoint
	{
		 get { } //Length: 19
	}

	public XZGridRayHit(Ray ray, XZGridCell hitCell, float hitEnter) { }

	public XZGridCell get_HitCell() { }

	public float get_HitEnter() { }

	public Vector3 get_HitNormal() { }

	public Plane get_HitPlane() { }

	public Vector3 get_HitPoint() { }

}

