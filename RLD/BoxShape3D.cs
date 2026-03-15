namespace RLD;

public class BoxShape3D : Shape3D
{
	internal class WireRenderDescriptor
	{
		private float _cornerLinePercentage; //Field offset: 0x10
		private WireRenderMode _wireMode; //Field offset: 0x14

		public float CornerLinePercentage
		{
			 get { } //Length: 6
			 set { } //Length: 33
		}

		public WireRenderMode WireMode
		{
			 get { } //Length: 4
			 set { } //Length: 4
		}

		public WireRenderDescriptor() { }

		public float get_CornerLinePercentage() { }

		public WireRenderMode get_WireMode() { }

		public void set_CornerLinePercentage(float value) { }

		public void set_WireMode(WireRenderMode value) { }

	}

	internal enum WireRenderMode : int
	{
		Wire = 0,
		WireCorners = 1,
	}

	private WireRenderDescriptor _wireRenderDesc; //Field offset: 0x10
	private Vector3 _size; //Field offset: 0x18
	private Vector3 _center; //Field offset: 0x24
	private Quaternion _rotation; //Field offset: 0x30
	private BoxEpsilon _epsilon; //Field offset: 0x40

	public Vector3 Center
	{
		 get { } //Length: 19
		 set { } //Length: 16
	}

	public float Depth
	{
		 get { } //Length: 6
		 set { } //Length: 13
	}

	public float DepthEps
	{
		 get { } //Length: 11
		 set { } //Length: 12
	}

	public BoxEpsilon Epsilon
	{
		 get { } //Length: 19
		 set { } //Length: 16
	}

	public Vector3 Extents
	{
		 get { } //Length: 59
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

	public Vector3 Max
	{
		 get { } //Length: 84
		 set { } //Length: 206
	}

	public Vector3 Min
	{
		 get { } //Length: 86
		 set { } //Length: 203
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
		 set { } //Length: 48
	}

	public Vector3 Size
	{
		 get { } //Length: 19
		 set { } //Length: 65
	}

	public Vector3 SizeEps
	{
		 get { } //Length: 19
		 set { } //Length: 43
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

	public WireRenderDescriptor WireRenderDesc
	{
		 get { } //Length: 5
	}

	public BoxShape3D() { }

	public void AlignDepth(Vector3 axis) { }

	public void AlignHeight(Vector3 axis) { }

	public void AlignWidth(Vector3 axis) { }

	public bool ContainsPoint(Vector3 point) { }

	public void FromOBB(OBB obb) { }

	public Vector3 get_Center() { }

	public float get_Depth() { }

	public float get_DepthEps() { }

	public BoxEpsilon get_Epsilon() { }

	public Vector3 get_Extents() { }

	public float get_Height() { }

	public float get_HeightEps() { }

	public Vector3 get_Look() { }

	public Vector3 get_Max() { }

	public Vector3 get_Min() { }

	public static Vector3 get_ModelCenter() { }

	public static Vector3 get_ModelLook() { }

	public static Vector3 get_ModelRight() { }

	public static Vector3 get_ModelUp() { }

	public Vector3 get_Right() { }

	public Quaternion get_Rotation() { }

	public Vector3 get_Size() { }

	public Vector3 get_SizeEps() { }

	public Vector3 get_Up() { }

	public float get_Width() { }

	public float get_WidthEps() { }

	public WireRenderDescriptor get_WireRenderDesc() { }

	public virtual AABB GetAABB() { }

	public Vector3 GetFaceCenter(BoxFace boxFace) { }

	public OBB GetOBB() { }

	public float GetSizeAlongDirection(Vector3 direction) { }

	public virtual bool Raycast(Ray ray, out float t) { }

	public virtual void RenderSolid() { }

	public virtual void RenderWire() { }

	public void set_Center(Vector3 value) { }

	public void set_Depth(float value) { }

	public void set_DepthEps(float value) { }

	public void set_Epsilon(BoxEpsilon value) { }

	public void set_Height(float value) { }

	public void set_HeightEps(float value) { }

	public void set_Max(Vector3 value) { }

	public void set_Min(Vector3 value) { }

	public void set_Rotation(Quaternion value) { }

	public void set_Size(Vector3 value) { }

	public void set_SizeEps(Vector3 value) { }

	public void set_Width(float value) { }

	public void set_WidthEps(float value) { }

	public void SetFaceCenter(BoxFace boxFace, Vector3 newCenter) { }

}

