namespace RLD;

public class TriangPrismShape3D : Shape3D
{
	private Vector3 _baseCenter; //Field offset: 0x10
	private float _width; //Field offset: 0x1C
	private float _height; //Field offset: 0x20
	private float _depth; //Field offset: 0x24
	private Quaternion _rotation; //Field offset: 0x28
	private PrismEpsilon _epsilon; //Field offset: 0x38

	public Vector3 BaseCenter
	{
		 get { } //Length: 19
		 set { } //Length: 16
	}

	public Vector3 Center
	{
		 get { } //Length: 246
		 set { } //Length: 237
	}

	public Vector3 CentralAxis
	{
		 get { } //Length: 135
	}

	public float Depth
	{
		 get { } //Length: 6
		 set { } //Length: 13
	}

	public PrismEpsilon Epsilon
	{
		 get { } //Length: 4
		 set { } //Length: 4
	}

	public Vector3 FrontCenter
	{
		 get { } //Length: 457
		 set { } //Length: 415
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

	public Vector3 MidTip
	{
		 get { } //Length: 431
		 set { } //Length: 419
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

	public Vector3 TopCenter
	{
		 get { } //Length: 226
		 set { } //Length: 204
	}

	public Vector3 Up
	{
		 get { } //Length: 135
	}

	public float Width
	{
		 get { } //Length: 6
		 set { } //Length: 13
	}

	public TriangPrismShape3D() { }

	public void AlignDepth(Vector3 axis) { }

	public void AlignHeight(Vector3 axis) { }

	public void AlignWidth(Vector3 axis) { }

	public bool ContainsPoint(Vector3 point) { }

	public Vector3 get_BaseCenter() { }

	public Vector3 get_Center() { }

	public Vector3 get_CentralAxis() { }

	public float get_Depth() { }

	public PrismEpsilon get_Epsilon() { }

	public Vector3 get_FrontCenter() { }

	public float get_Height() { }

	public Vector3 get_Look() { }

	public Vector3 get_MidTip() { }

	public static Vector3 get_ModelBaseCenter() { }

	public static Vector3 get_ModelLook() { }

	public static Vector3 get_ModelRight() { }

	public static Vector3 get_ModelUp() { }

	public float get_PtContainEps() { }

	public Vector3 get_Right() { }

	public Quaternion get_Rotation() { }

	public Vector3 get_TopCenter() { }

	public Vector3 get_Up() { }

	public float get_Width() { }

	public virtual AABB GetAABB() { }

	public void MakeEquilateral(float sideLength) { }

	public virtual bool Raycast(Ray ray, out float t) { }

	public virtual void RenderSolid() { }

	public virtual void RenderWire() { }

	public void set_BaseCenter(Vector3 value) { }

	public void set_Center(Vector3 value) { }

	public void set_Depth(float value) { }

	public void set_Epsilon(PrismEpsilon value) { }

	public void set_FrontCenter(Vector3 value) { }

	public void set_Height(float value) { }

	public void set_MidTip(Vector3 value) { }

	public void set_PtContainEps(float value) { }

	public void set_Rotation(Quaternion value) { }

	public void set_TopCenter(Vector3 value) { }

	public void set_Width(float value) { }

}

