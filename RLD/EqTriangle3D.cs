namespace RLD;

public class EqTriangle3D : Shape3D
{
	private float _sideLength; //Field offset: 0x10
	private Quaternion _rotation; //Field offset: 0x14
	private TriangleEpsilon _epsilon; //Field offset: 0x24
	private Vector3[] _points; //Field offset: 0x30
	private Vector3 _centroid; //Field offset: 0x38
	private bool _arePointsDirty; //Field offset: 0x44

	public float Altitude
	{
		 get { } //Length: 149
	}

	public float AreaEps
	{
		 get { } //Length: 6
		 set { } //Length: 12
	}

	public Vector3 Centroid
	{
		 get { } //Length: 19
		 set { } //Length: 260
	}

	public float CentroidAltitude
	{
		 get { } //Length: 157
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

	public static Vector3 ModelCentroid
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

	public Vector3 Normal
	{
		 get { } //Length: 135
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

	public float SideLength
	{
		 get { } //Length: 6
		 set { } //Length: 17
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

	public EqTriangle3D() { }

	public void AlignNormal(Vector3 axis) { }

	public void AlignRight(Vector3 axis) { }

	public void AlignUp(Vector3 axis) { }

	public float get_Altitude() { }

	public float get_AreaEps() { }

	public Vector3 get_Centroid() { }

	public float get_CentroidAltitude() { }

	public TriangleEpsilon get_Epsilon() { }

	public float get_ExtrudeEps() { }

	public Vector3 get_Look() { }

	public static Vector3 get_ModelCentroid() { }

	public static Vector3 get_ModelLook() { }

	public static Vector3 get_ModelRight() { }

	public static Vector3 get_ModelUp() { }

	public Vector3 get_Normal() { }

	public Vector3 get_Right() { }

	public Quaternion get_Rotation() { }

	public float get_SideLength() { }

	public Vector3 get_Up() { }

	public float get_WireEps() { }

	public virtual AABB GetAABB() { }

	public Vector3 GetEdge(EqTriangleEdge edge) { }

	public Vector3 GetEdgeMidPoint(EqTriangleEdge edge) { }

	public Vector3 GetPoint(EqTrianglePoint point) { }

	private void OnPointsFoundDirty() { }

	public virtual bool Raycast(Ray ray, out float t) { }

	public virtual bool RaycastWire(Ray ray, out float t) { }

	public virtual void RenderSolid() { }

	public virtual void RenderWire() { }

	public void set_AreaEps(float value) { }

	public void set_Centroid(Vector3 value) { }

	public void set_Epsilon(TriangleEpsilon value) { }

	public void set_ExtrudeEps(float value) { }

	public void set_Rotation(Quaternion value) { }

	public void set_SideLength(float value) { }

	public void set_WireEps(float value) { }

	public void SetPoint(EqTrianglePoint point, Vector3 pointValue) { }

}

