namespace RLD;

public class MeshRayHit
{
	private int _hitTriangleIndex; //Field offset: 0x10
	private Vector3 _hitPoint; //Field offset: 0x14
	private float _hitEnter; //Field offset: 0x20
	private Vector3 _hitNormal; //Field offset: 0x24

	public float HitEnter
	{
		 get { } //Length: 6
	}

	public Vector3 HitNormal
	{
		 get { } //Length: 19
	}

	public Vector3 HitPoint
	{
		 get { } //Length: 19
	}

	public int HitTriangleIndex
	{
		 get { } //Length: 4
	}

	public MeshRayHit(Ray ray, int hitTriangleIndex, float hitEnter, Vector3 hitNormal) { }

	public float get_HitEnter() { }

	public Vector3 get_HitNormal() { }

	public Vector3 get_HitPoint() { }

	public int get_HitTriangleIndex() { }

}

