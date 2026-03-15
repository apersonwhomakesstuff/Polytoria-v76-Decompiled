namespace RLD;

public class CircleShape3D : Shape3D
{
	private Vector3 _center; //Field offset: 0x10
	private float _radius; //Field offset: 0x1C
	private Quaternion _rotation; //Field offset: 0x20
	private CircleEpsilon _epsilon; //Field offset: 0x30
	private Shape3DRaycastMode _raycastMode; //Field offset: 0x3C

	public Vector3 Center
	{
		 get { } //Length: 19
		 set { } //Length: 16
	}

	public CircleEpsilon Epsilon
	{
		 get { } //Length: 19
		 set { } //Length: 16
	}

	public float ExtrudeEps
	{
		 get { } //Length: 6
		 set { } //Length: 12
	}

	public Vector3 Look
	{
		 get { } //Length: 135
	}

	public static Vector3 ModelCenter
	{
		 get { } //Length: 74
	}

	public static Vector3 ModelLook
	{
		 get { } //Length: 75
	}

	public static Vector3 ModelNormal
	{
		 get { } //Length: 75
	}

	public static Vector3 ModelRight
	{
		 get { } //Length: 75
	}

	public static Vector3 ModelUp
	{
		 get { } //Length: 75
	}

	public Vector3 Normal
	{
		 get { } //Length: 135
	}

	public float Radius
	{
		 get { } //Length: 6
		 set { } //Length: 13
	}

	public float RadiusEps
	{
		 get { } //Length: 6
		 set { } //Length: 12
	}

	public Shape3DRaycastMode RaycastMode
	{
		 get { } //Length: 4
		 set { } //Length: 4
	}

	public Vector3 Right
	{
		 get { } //Length: 135
	}

	public Quaternion Rotation
	{
		 get { } //Length: 11
		 set { } //Length: 8
	}

	public Vector3 Up
	{
		 get { } //Length: 135
	}

	public float WireEps
	{
		 get { } //Length: 6
		 set { } //Length: 12
	}

	public CircleShape3D() { }

	public void AlignNormal(Vector3 axis) { }

	public void AlignRight(Vector3 axis) { }

	public void AlignUp(Vector3 axis) { }

	public bool ContainsPoint(Vector3 point, bool checkOnPlane) { }

	public Vector3 get_Center() { }

	public CircleEpsilon get_Epsilon() { }

	public float get_ExtrudeEps() { }

	public Vector3 get_Look() { }

	public static Vector3 get_ModelCenter() { }

	public static Vector3 get_ModelLook() { }

	public static Vector3 get_ModelNormal() { }

	public static Vector3 get_ModelRight() { }

	public static Vector3 get_ModelUp() { }

	public Vector3 get_Normal() { }

	public float get_Radius() { }

	public float get_RadiusEps() { }

	public Shape3DRaycastMode get_RaycastMode() { }

	public Vector3 get_Right() { }

	public Quaternion get_Rotation() { }

	public Vector3 get_Up() { }

	public float get_WireEps() { }

	public virtual AABB GetAABB() { }

	public List<Vector3> GetExtentPoints() { }

	public virtual bool Raycast(Ray ray, out float t) { }

	public virtual bool RaycastWire(Ray ray, out float t) { }

	public virtual void RenderSolid() { }

	public virtual void RenderWire() { }

	public void set_Center(Vector3 value) { }

	public void set_Epsilon(CircleEpsilon value) { }

	public void set_ExtrudeEps(float value) { }

	public void set_Radius(float value) { }

	public void set_RadiusEps(float value) { }

	public void set_RaycastMode(Shape3DRaycastMode value) { }

	public void set_Rotation(Quaternion value) { }

	public void set_WireEps(float value) { }

}

