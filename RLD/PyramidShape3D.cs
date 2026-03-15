namespace RLD;

public class PyramidShape3D : Shape3D
{
	private Vector3 _baseCenter; //Field offset: 0x10
	private float _baseWidth; //Field offset: 0x1C
	private float _baseDepth; //Field offset: 0x20
	private float _height; //Field offset: 0x24
	private Quaternion _rotation; //Field offset: 0x28
	private PyramidEpsilon _epsilon; //Field offset: 0x38

	public Vector3 BaseCenter
	{
		 get { } //Length: 19
		 set { } //Length: 16
	}

	public float BaseDepth
	{
		 get { } //Length: 6
		 set { } //Length: 13
	}

	public float BaseWidth
	{
		 get { } //Length: 6
		 set { } //Length: 13
	}

	public Vector3 CentralAxis
	{
		 get { } //Length: 135
	}

	public PyramidEpsilon Epsilon
	{
		 get { } //Length: 4
		 set { } //Length: 4
	}

	public float Height
	{
		 get { } //Length: 6
		 set { } //Length: 13
	}

	public Vector3 Look
	{
		 get { } //Length: 135
	}

	public static Vector3 ModelBaseCenter
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

	public float PtContainEps
	{
		 get { } //Length: 6
		 set { } //Length: 12
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

	public Vector3 Tip
	{
		 get { } //Length: 226
		 set { } //Length: 204
	}

	public Vector3 Up
	{
		 get { } //Length: 135
	}

	public PyramidShape3D() { }

	public bool ContainsPoint(Vector3 point) { }

	public Vector3 get_BaseCenter() { }

	public float get_BaseDepth() { }

	public float get_BaseWidth() { }

	public Vector3 get_CentralAxis() { }

	public PyramidEpsilon get_Epsilon() { }

	public float get_Height() { }

	public Vector3 get_Look() { }

	public static Vector3 get_ModelBaseCenter() { }

	public static Vector3 get_ModelLook() { }

	public static Vector3 get_ModelRight() { }

	public static Vector3 get_ModelUp() { }

	public float get_PtContainEps() { }

	public Vector3 get_Right() { }

	public Quaternion get_Rotation() { }

	public Vector3 get_Tip() { }

	public Vector3 get_Up() { }

	public virtual AABB GetAABB() { }

	public List<Vector3> GetBaseCornerPoints() { }

	public void PointTipAlongAxis(Vector3 axis) { }

	public virtual bool Raycast(Ray ray, out float t) { }

	public virtual void RenderSolid() { }

	public virtual void RenderWire() { }

	public void set_BaseCenter(Vector3 value) { }

	public void set_BaseDepth(float value) { }

	public void set_BaseWidth(float value) { }

	public void set_Epsilon(PyramidEpsilon value) { }

	public void set_Height(float value) { }

	public void set_PtContainEps(float value) { }

	public void set_Rotation(Quaternion value) { }

	public void set_Tip(Vector3 value) { }

}

