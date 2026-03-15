namespace RLD;

public class ConeShape3D : Shape3D
{
	internal class WireRenderDescriptor
	{
		private WireRenderMode _wireMode; //Field offset: 0x10
		private int _numDetailAxialRings; //Field offset: 0x14
		private int _numDetailAxialSegments; //Field offset: 0x18

		public int NumDetailAxialRings
		{
			 get { } //Length: 4
			 set { } //Length: 16
		}

		public int NumDetailAxialSegments
		{
			 get { } //Length: 4
			 set { } //Length: 16
		}

		public WireRenderMode WireMode
		{
			 get { } //Length: 4
			 set { } //Length: 4
		}

		public WireRenderDescriptor() { }

		public int get_NumDetailAxialRings() { }

		public int get_NumDetailAxialSegments() { }

		public WireRenderMode get_WireMode() { }

		public void set_NumDetailAxialRings(int value) { }

		public void set_NumDetailAxialSegments(int value) { }

		public void set_WireMode(WireRenderMode value) { }

	}

	internal enum WireRenderMode : int
	{
		Basic = 0,
		Detailed = 1,
	}

	private WireRenderDescriptor _wireRenderDesc; //Field offset: 0x10
	private Vector3 _baseCenter; //Field offset: 0x18
	private Quaternion _rotation; //Field offset: 0x24
	private float _baseRadius; //Field offset: 0x34
	private float _height; //Field offset: 0x38
	private ConeEpsilon _epsilon; //Field offset: 0x3C

	public Vector3 BaseCenter
	{
		 get { } //Length: 19
		 set { } //Length: 16
	}

	public float BaseRadius
	{
		 get { } //Length: 6
		 set { } //Length: 13
	}

	public Vector3 CentralAxis
	{
		 get { } //Length: 135
	}

	public ConeEpsilon Epsilon
	{
		 get { } //Length: 19
		 set { } //Length: 5
	}

	public float Height
	{
		 get { } //Length: 6
		 set { } //Length: 13
	}

	public float HrzEps
	{
		 get { } //Length: 6
		 set { } //Length: 12
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

	public float VertEps
	{
		 get { } //Length: 6
		 set { } //Length: 12
	}

	public WireRenderDescriptor WireRenderDesc
	{
		 get { } //Length: 5
	}

	public ConeShape3D() { }

	public void AlignTip(Vector3 axis) { }

	public bool ContainsPoint(Vector3 point) { }

	public Vector3 get_BaseCenter() { }

	public float get_BaseRadius() { }

	public Vector3 get_CentralAxis() { }

	public ConeEpsilon get_Epsilon() { }

	public float get_Height() { }

	public float get_HrzEps() { }

	public Vector3 get_Look() { }

	public static Vector3 get_ModelBaseCenter() { }

	public static Vector3 get_ModelLook() { }

	public static Vector3 get_ModelRight() { }

	public static Vector3 get_ModelUp() { }

	public Vector3 get_Right() { }

	public Quaternion get_Rotation() { }

	public Vector3 get_Tip() { }

	public Vector3 get_Up() { }

	public float get_VertEps() { }

	public WireRenderDescriptor get_WireRenderDesc() { }

	public virtual AABB GetAABB() { }

	public List<Vector3> GetBaseExtents() { }

	public virtual bool Raycast(Ray ray, out float t) { }

	public virtual void RenderSolid() { }

	public virtual void RenderWire() { }

	public void set_BaseCenter(Vector3 value) { }

	public void set_BaseRadius(float value) { }

	public void set_Epsilon(ConeEpsilon value) { }

	public void set_Height(float value) { }

	public void set_HrzEps(float value) { }

	public void set_Rotation(Quaternion value) { }

	public void set_Tip(Vector3 value) { }

	public void set_VertEps(float value) { }

}

