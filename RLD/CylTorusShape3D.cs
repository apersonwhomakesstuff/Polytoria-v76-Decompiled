namespace RLD;

public class CylTorusShape3D : Shape3D
{
	private float _coreRadius; //Field offset: 0x10
	private float _hrzRadius; //Field offset: 0x14
	private float _vertRadius; //Field offset: 0x18
	private Vector3 _center; //Field offset: 0x1C
	private Quaternion _rotation; //Field offset: 0x28
	private TorusEpsilon _epsilon; //Field offset: 0x38

	public Vector3 Bottom
	{
		 get { } //Length: 234
		 set { } //Length: 202
	}

	public Vector3 Center
	{
		 get { } //Length: 19
		 set { } //Length: 16
	}

	public float CoreRadius
	{
		 get { } //Length: 6
		 set { } //Length: 13
	}

	public float CylHrzRadiusEps
	{
		 get { } //Length: 6
		 set { } //Length: 19
	}

	public float CylVertRadiusEps
	{
		 get { } //Length: 6
		 set { } //Length: 19
	}

	public TorusEpsilon Epsilon
	{
		 get { } //Length: 19
		 set { } //Length: 16
	}

	public float HrzRadius
	{
		 get { } //Length: 6
		 set { } //Length: 13
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

	public static Vector3 ModelRight
	{
		 get { } //Length: 75
	}

	public static Vector3 ModelUp
	{
		 get { } //Length: 75
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

	public Vector3 Top
	{
		 get { } //Length: 226
		 set { } //Length: 204
	}

	public Vector3 Up
	{
		 get { } //Length: 135
	}

	public float VertRadius
	{
		 get { } //Length: 6
		 set { } //Length: 13
	}

	public CylTorusShape3D() { }

	public Vector3 get_Bottom() { }

	public Vector3 get_Center() { }

	public float get_CoreRadius() { }

	public float get_CylHrzRadiusEps() { }

	public float get_CylVertRadiusEps() { }

	public TorusEpsilon get_Epsilon() { }

	public float get_HrzRadius() { }

	public Vector3 get_Look() { }

	public static Vector3 get_ModelCenter() { }

	public static Vector3 get_ModelLook() { }

	public static Vector3 get_ModelRight() { }

	public static Vector3 get_ModelUp() { }

	public Vector3 get_Right() { }

	public Quaternion get_Rotation() { }

	public Vector3 get_Top() { }

	public Vector3 get_Up() { }

	public float get_VertRadius() { }

	public virtual AABB GetAABB() { }

	public List<Vector3> GetHrzExtents() { }

	public virtual bool Raycast(Ray ray, out float t) { }

	public virtual void RenderSolid() { }

	public virtual void RenderWire() { }

	public void set_Bottom(Vector3 value) { }

	public void set_Center(Vector3 value) { }

	public void set_CoreRadius(float value) { }

	public void set_CylHrzRadiusEps(float value) { }

	public void set_CylVertRadiusEps(float value) { }

	public void set_Epsilon(TorusEpsilon value) { }

	public void set_HrzRadius(float value) { }

	public void set_Rotation(Quaternion value) { }

	public void set_Top(Vector3 value) { }

	public void set_VertRadius(float value) { }

}

