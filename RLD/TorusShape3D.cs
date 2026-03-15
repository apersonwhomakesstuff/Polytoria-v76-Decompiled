namespace RLD;

public class TorusShape3D : Shape3D
{
	internal class WireRenderDescriptor
	{
		private WireRenderFlags _wireFlags; //Field offset: 0x10
		private int _numTubeSlices; //Field offset: 0x14
		private int _numAxialSlices; //Field offset: 0x18

		public int NumAxialSlices
		{
			 get { } //Length: 4
			 set { } //Length: 16
		}

		public int NumTubeSlices
		{
			 get { } //Length: 4
			 set { } //Length: 13
		}

		public WireRenderFlags WireFlags
		{
			 get { } //Length: 4
			 set { } //Length: 4
		}

		public WireRenderDescriptor() { }

		public int get_NumAxialSlices() { }

		public int get_NumTubeSlices() { }

		public WireRenderFlags get_WireFlags() { }

		public void set_NumAxialSlices(int value) { }

		public void set_NumTubeSlices(int value) { }

		public void set_WireFlags(WireRenderFlags value) { }

	}

	internal enum WireRenderFlags : int
	{
		None = 0,
		TubeSlices = 1,
		AxialSlices = 2,
		All = 3,
	}

	private float _coreRadius; //Field offset: 0x10
	private float _tubeRadius; //Field offset: 0x14
	private Vector3 _center; //Field offset: 0x18
	private Quaternion _rotation; //Field offset: 0x24
	private TorusEpsilon _epsilon; //Field offset: 0x34
	private WireRenderDescriptor _wireRenderDesc; //Field offset: 0x40

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

	public TorusEpsilon Epsilon
	{
		 get { } //Length: 19
		 set { } //Length: 16
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

	public float TubeRadius
	{
		 get { } //Length: 6
		 set { } //Length: 13
	}

	public float TubeRadiusEps
	{
		 get { } //Length: 6
		 set { } //Length: 12
	}

	public Vector3 Up
	{
		 get { } //Length: 135
	}

	public WireRenderDescriptor WireRenderDesc
	{
		 get { } //Length: 5
	}

	public TorusShape3D() { }

	public Vector3 get_Center() { }

	public float get_CoreRadius() { }

	public TorusEpsilon get_Epsilon() { }

	public Vector3 get_Look() { }

	public static Vector3 get_ModelCenter() { }

	public static Vector3 get_ModelLook() { }

	public static Vector3 get_ModelRight() { }

	public static Vector3 get_ModelUp() { }

	public Vector3 get_Right() { }

	public Quaternion get_Rotation() { }

	public float get_TubeRadius() { }

	public float get_TubeRadiusEps() { }

	public Vector3 get_Up() { }

	public WireRenderDescriptor get_WireRenderDesc() { }

	public virtual AABB GetAABB() { }

	public List<Vector3> GetHrzExtents() { }

	public virtual bool Raycast(Ray ray, out float t) { }

	public virtual void RenderSolid() { }

	public virtual void RenderWire() { }

	public void set_Center(Vector3 value) { }

	public void set_CoreRadius(float value) { }

	public void set_Epsilon(TorusEpsilon value) { }

	public void set_Rotation(Quaternion value) { }

	public void set_TubeRadius(float value) { }

	public void set_TubeRadiusEps(float value) { }

}

