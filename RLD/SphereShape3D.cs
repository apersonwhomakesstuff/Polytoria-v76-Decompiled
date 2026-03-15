namespace RLD;

public class SphereShape3D : Shape3D
{
	internal class WireRenderDescriptor
	{
		private WireRenderMode _wireMode; //Field offset: 0x10
		private int _numDetailAxialRings; //Field offset: 0x14
		private int _numDetailSliceRings; //Field offset: 0x18
		private float _radiusAdd; //Field offset: 0x1C

		public int NumDetailAxialRings
		{
			 get { } //Length: 4
			 set { } //Length: 16
		}

		public int NumDetailSliceRings
		{
			 get { } //Length: 4
			 set { } //Length: 13
		}

		public float RadiusAdd
		{
			 get { } //Length: 6
			 set { } //Length: 6
		}

		public WireRenderMode WireMode
		{
			 get { } //Length: 4
			 set { } //Length: 4
		}

		public WireRenderDescriptor() { }

		public int get_NumDetailAxialRings() { }

		public int get_NumDetailSliceRings() { }

		public float get_RadiusAdd() { }

		public WireRenderMode get_WireMode() { }

		public void set_NumDetailAxialRings(int value) { }

		public void set_NumDetailSliceRings(int value) { }

		public void set_RadiusAdd(float value) { }

		public void set_WireMode(WireRenderMode value) { }

	}

	internal enum WireRenderMode : int
	{
		Basic = 0,
		Detailed = 1,
	}

	private float _radius; //Field offset: 0x10
	private Vector3 _center; //Field offset: 0x14
	private Quaternion _rotation; //Field offset: 0x20
	private SphereEpsilon _epsilon; //Field offset: 0x30
	private WireRenderDescriptor _wireRenderDesc; //Field offset: 0x38

	public Vector3 Center
	{
		 get { } //Length: 19
		 set { } //Length: 16
	}

	public Vector3 CentralAxis
	{
		 get { } //Length: 135
	}

	public SphereEpsilon Epsilon
	{
		 get { } //Length: 174
		 set { } //Length: 4
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

	public float WireRadius
	{
		 get { } //Length: 33
	}

	public WireRenderDescriptor WireRenderDesc
	{
		 get { } //Length: 5
	}

	public SphereShape3D() { }

	public bool ContainsPoint(Vector3 point) { }

	public Vector3 get_Center() { }

	public Vector3 get_CentralAxis() { }

	public SphereEpsilon get_Epsilon() { }

	public Vector3 get_Look() { }

	public static Vector3 get_ModelCenter() { }

	public static Vector3 get_ModelLook() { }

	public static Vector3 get_ModelRight() { }

	public static Vector3 get_ModelUp() { }

	public float get_Radius() { }

	public float get_RadiusEps() { }

	public Vector3 get_Right() { }

	public Quaternion get_Rotation() { }

	public Vector3 get_Up() { }

	public float get_WireRadius() { }

	public WireRenderDescriptor get_WireRenderDesc() { }

	public virtual AABB GetAABB() { }

	public virtual bool Raycast(Ray ray, out float t) { }

	public virtual void RenderSolid() { }

	public virtual void RenderWire() { }

	public void set_Center(Vector3 value) { }

	public void set_Epsilon(SphereEpsilon value) { }

	public void set_Radius(float value) { }

	public void set_RadiusEps(float value) { }

	public void set_Rotation(Quaternion value) { }

}

