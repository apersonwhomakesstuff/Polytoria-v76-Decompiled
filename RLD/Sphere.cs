namespace RLD;

public struct Sphere
{
	private Vector3 _center; //Field offset: 0x0
	private float _radius; //Field offset: 0xC

	public Vector3 Center
	{
		 get { } //Length: 18
		 set { } //Length: 15
	}

	public float Radius
	{
		 get { } //Length: 6
		 set { } //Length: 15
	}

	public Sphere(Vector3 center, float radius) { }

	public Sphere(AABB aabb) { }

	public Sphere(IEnumerable<Vector3> pointCloud) { }

	public bool ContainsPoint(Vector3 point) { }

	public void Encapsulate(Sphere sphere) { }

	public Vector3 get_Center() { }

	public float get_Radius() { }

	public List<Vector3> GetRightUpExtents(Vector3 right, Vector3 up) { }

	public void set_Center(Vector3 value) { }

	public void set_Radius(float value) { }

}

