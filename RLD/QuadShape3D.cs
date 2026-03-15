namespace RLD;

public class QuadShape3D : Shape3D
{
	[Flags]
	internal enum WireEdgeFlags : int
	{
		None = 0,
		Top = 1,
		Right = 2,
		Bottom = 4,
		Left = 8,
		All = 15,
	}

	internal class WireRenderDescriptor
	{
		private WireEdgeFlags _wireEdgeFlags; //Field offset: 0x10

		public WireEdgeFlags WireEdgeFlags
		{
			 get { } //Length: 4
			 set { } //Length: 4
		}

		public WireRenderDescriptor() { }

		public WireEdgeFlags get_WireEdgeFlags() { }

		public void set_WireEdgeFlags(WireEdgeFlags value) { }

	}

	private Shape3DRaycastMode _raycastMode; //Field offset: 0x10
	private Vector3 _center; //Field offset: 0x14
	private Vector2 _size; //Field offset: 0x20
	private Quaternion _rotation; //Field offset: 0x28
	private QuadEpsilon _epsilon; //Field offset: 0x38
	private WireRenderDescriptor _wireRenderDesc; //Field offset: 0x48

	public Vector3 Center
	{
		 get { } //Length: 19
		 set { } //Length: 16
	}

	public QuadEpsilon Epsilon
	{
		 get { } //Length: 11
		 set { } //Length: 8
	}

	public float ExtrudeEps
	{
		 get { } //Length: 6
		 set { } //Length: 12
	}

	public float Height
	{
		 get { } //Length: 6
		 set { } //Length: 13
	}

	public float HeightEps
	{
		 get { } //Length: 11
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

	public Vector2 Size
	{
		 get { } //Length: 19
		 set { } //Length: 59
	}

	public Vector2 SizeEps
	{
		 get { } //Length: 19
		 set { } //Length: 12
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

	public float WidthEps
	{
		 get { } //Length: 11
		 set { } //Length: 12
	}

	public float WireEps
	{
		 get { } //Length: 6
		 set { } //Length: 12
	}

	public WireRenderDescriptor WireRenderDesc
	{
		 get { } //Length: 5
	}

	public QuadShape3D() { }

	public void AlignNormal(Vector3 axis) { }

	public void AlignRight(Vector3 axis) { }

	public void AlignUp(Vector3 axis) { }

	public bool ContainsPoint(Vector3 point, bool checkOnPlane) { }

	public Vector3 get_Center() { }

	public QuadEpsilon get_Epsilon() { }

	public float get_ExtrudeEps() { }

	public float get_Height() { }

	public float get_HeightEps() { }

	public Vector3 get_Look() { }

	public static Vector3 get_ModelCenter() { }

	public static Vector3 get_ModelLook() { }

	public static Vector3 get_ModelNormal() { }

	public static Vector3 get_ModelRight() { }

	public static Vector3 get_ModelUp() { }

	public Vector3 get_Normal() { }

	public Shape3DRaycastMode get_RaycastMode() { }

	public Vector3 get_Right() { }

	public Quaternion get_Rotation() { }

	public Vector2 get_Size() { }

	public Vector2 get_SizeEps() { }

	public Vector3 get_Up() { }

	public float get_Width() { }

	public float get_WidthEps() { }

	public float get_WireEps() { }

	public WireRenderDescriptor get_WireRenderDesc() { }

	public virtual AABB GetAABB() { }

	public List<Vector3> GetCornerPoints() { }

	public Vector3 GetCornerPosition(QuadCorner quadCorner) { }

	public List<Vector3> GetCorners() { }

	public virtual bool Raycast(Ray ray, out float t) { }

	public virtual bool RaycastWire(Ray ray, out float t) { }

	public virtual void RenderSolid() { }

	public virtual void RenderWire() { }

	public void set_Center(Vector3 value) { }

	public void set_Epsilon(QuadEpsilon value) { }

	public void set_ExtrudeEps(float value) { }

	public void set_Height(float value) { }

	public void set_HeightEps(float value) { }

	public void set_RaycastMode(Shape3DRaycastMode value) { }

	public void set_Rotation(Quaternion value) { }

	public void set_Size(Vector2 value) { }

	public void set_SizeEps(Vector2 value) { }

	public void set_Width(float value) { }

	public void set_WidthEps(float value) { }

	public void set_WireEps(float value) { }

	public void SetCornerPointPosition(QuadCorner quadCorner, Vector3 position) { }

}

