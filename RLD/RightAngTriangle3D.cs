namespace RLD;

public class RightAngTriangle3D : Shape3D
{
	private Vector3 _rightAngleCorner; //Field offset: 0x10
	private float _XLength; //Field offset: 0x1C
	private float _YLength; //Field offset: 0x20
	private AxisSign _XLengthSign; //Field offset: 0x24
	private AxisSign _YLengthSign; //Field offset: 0x28
	private Quaternion _rotation; //Field offset: 0x2C
	private TriangleEpsilon _epsilon; //Field offset: 0x3C
	private Shape3DRaycastMode _raycastMode; //Field offset: 0x48

	public float AreaEps
	{
		 get { } //Length: 6
		 set { } //Length: 12
	}

	public TriangleEpsilon Epsilon
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

	public static Vector3 ModelRightAngleCorner
	{
		 get { } //Length: 74
	}

	public static Vector3 ModelUp
	{
		 get { } //Length: 75
	}

	public Vector3 Normal
	{
		 get { } //Length: 135
	}

	public Plane Plane
	{
		 get { } //Length: 317
	}

	public Shape3DRaycastMode RaycastMode
	{
		 get { } //Length: 4
		 set { } //Length: 4
	}

	public float RealXLength
	{
		 get { } //Length: 34
	}

	public float RealYLength
	{
		 get { } //Length: 34
	}

	public Vector3 Right
	{
		 get { } //Length: 135
	}

	public Vector3 RightAngleCorner
	{
		 get { } //Length: 19
		 set { } //Length: 16
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

	public float XLength
	{
		 get { } //Length: 6
		 set { } //Length: 13
	}

	public AxisSign XLengthSign
	{
		 get { } //Length: 4
		 set { } //Length: 4
	}

	public float YLength
	{
		 get { } //Length: 6
		 set { } //Length: 13
	}

	public AxisSign YLengthSign
	{
		 get { } //Length: 4
		 set { } //Length: 4
	}

	public RightAngTriangle3D() { }

	public void AlignNormal(Vector3 axis) { }

	public void AlignRight(Vector3 axis) { }

	public void AlignUp(Vector3 axis) { }

	public bool ContainsPoint(Vector3 point, bool checkOnPlane) { }

	public float get_AreaEps() { }

	public TriangleEpsilon get_Epsilon() { }

	public float get_ExtrudeEps() { }

	public Vector3 get_Look() { }

	public static Vector3 get_ModelLook() { }

	public static Vector3 get_ModelNormal() { }

	public static Vector3 get_ModelRight() { }

	public static Vector3 get_ModelRightAngleCorner() { }

	public static Vector3 get_ModelUp() { }

	public Vector3 get_Normal() { }

	public Plane get_Plane() { }

	public Shape3DRaycastMode get_RaycastMode() { }

	public float get_RealXLength() { }

	public float get_RealYLength() { }

	public Vector3 get_Right() { }

	public Vector3 get_RightAngleCorner() { }

	public Quaternion get_Rotation() { }

	public Vector3 get_Up() { }

	public float get_WireEps() { }

	public float get_XLength() { }

	public AxisSign get_XLengthSign() { }

	public float get_YLength() { }

	public AxisSign get_YLengthSign() { }

	public virtual AABB GetAABB() { }

	public List<Vector3> GetPoints() { }

	public virtual bool Raycast(Ray ray, out float t) { }

	public virtual bool RaycastWire(Ray ray, out float t) { }

	public virtual void RenderSolid() { }

	public virtual void RenderWire() { }

	public void set_AreaEps(float value) { }

	public void set_Epsilon(TriangleEpsilon value) { }

	public void set_ExtrudeEps(float value) { }

	public void set_RaycastMode(Shape3DRaycastMode value) { }

	public void set_RightAngleCorner(Vector3 value) { }

	public void set_Rotation(Quaternion value) { }

	public void set_WireEps(float value) { }

	public void set_XLength(float value) { }

	public void set_XLengthSign(AxisSign value) { }

	public void set_YLength(float value) { }

	public void set_YLengthSign(AxisSign value) { }

}

