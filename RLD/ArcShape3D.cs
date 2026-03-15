namespace RLD;

public class ArcShape3D : Shape3D
{
	internal class WireRenderDescriptor
	{
		private WireRenderFlags _wireFlags; //Field offset: 0x10

		public WireRenderFlags WireFlags
		{
			 get { } //Length: 4
			 set { } //Length: 4
		}

		public WireRenderDescriptor() { }

		public WireRenderFlags get_WireFlags() { }

		public void set_WireFlags(WireRenderFlags value) { }

	}

	internal enum WireRenderFlags : int
	{
		None = 0,
		ExtremitiesBorder = 1,
		ArcBorder = 2,
		All = 3,
	}

	private WireRenderDescriptor _wireRenderDesc; //Field offset: 0x10
	private Vector3 _startPoint; //Field offset: 0x18
	private Vector3 _endPoint; //Field offset: 0x24
	private Vector3 _origin; //Field offset: 0x30
	private Plane _plane; //Field offset: 0x3C
	private float _radius; //Field offset: 0x4C
	private AABB _aabb; //Field offset: 0x50
	private float _degreeAngleFromStart; //Field offset: 0x6C
	private bool _forceShortestArc; //Field offset: 0x70
	private List<Vector3> _borderPoints; //Field offset: 0x78
	private int _numBorderPoints; //Field offset: 0x80
	private bool _areBorderPointsDirty; //Field offset: 0x84
	private ArcEpsilon _epsilon; //Field offset: 0x88
	private Shape3DRaycastMode _raycastMode; //Field offset: 0x94

	public float AbsDegreeAngleFromStart
	{
		 get { } //Length: 13
	}

	public float AreaEps
	{
		 get { } //Length: 9
		 set { } //Length: 15
	}

	public float DegreeAngleFromStart
	{
		 get { } //Length: 6
		 set { } //Length: 53
	}

	public Vector3 EndPoint
	{
		 get { } //Length: 19
	}

	public ArcEpsilon Epsilon
	{
		 get { } //Length: 25
		 set { } //Length: 22
	}

	public float ExtrudeEps
	{
		 get { } //Length: 9
		 set { } //Length: 15
	}

	public bool ForceShortestArc
	{
		 get { } //Length: 5
		 set { } //Length: 32
	}

	public Vector3 Normal
	{
		 get { } //Length: 19
	}

	public int NumBorderPoints
	{
		 get { } //Length: 7
		 set { } //Length: 26
	}

	public Vector3 Origin
	{
		 get { } //Length: 19
		 set { } //Length: 330
	}

	public Plane Plane
	{
		 get { } //Length: 11
	}

	public float Radius
	{
		 get { } //Length: 6
		 set { } //Length: 334
	}

	public Shape3DRaycastMode RaycastMode
	{
		 get { } //Length: 7
		 set { } //Length: 7
	}

	public Vector3 StartPoint
	{
		 get { } //Length: 19
	}

	public float WireEps
	{
		 get { } //Length: 9
		 set { } //Length: 15
	}

	public WireRenderDescriptor WireRenderDesc
	{
		 get { } //Length: 5
	}

	public ArcShape3D() { }

	private void CalculateEndPoint() { }

	public bool ContainsPoint(Vector3 point, bool checkOnPlane) { }

	public float get_AbsDegreeAngleFromStart() { }

	public float get_AreaEps() { }

	public float get_DegreeAngleFromStart() { }

	public Vector3 get_EndPoint() { }

	public ArcEpsilon get_Epsilon() { }

	public float get_ExtrudeEps() { }

	public bool get_ForceShortestArc() { }

	public Vector3 get_Normal() { }

	public int get_NumBorderPoints() { }

	public Vector3 get_Origin() { }

	public Plane get_Plane() { }

	public float get_Radius() { }

	public Shape3DRaycastMode get_RaycastMode() { }

	public Vector3 get_StartPoint() { }

	public float get_WireEps() { }

	public WireRenderDescriptor get_WireRenderDesc() { }

	public virtual AABB GetAABB() { }

	private void OnBorderPointsFoundDirty() { }

	public virtual bool Raycast(Ray ray, out float t) { }

	public virtual bool RaycastWire(Ray ray, out float t) { }

	public virtual void RenderSolid() { }

	public virtual void RenderWire() { }

	public void set_AreaEps(float value) { }

	public void set_DegreeAngleFromStart(float value) { }

	public void set_Epsilon(ArcEpsilon value) { }

	public void set_ExtrudeEps(float value) { }

	public void set_ForceShortestArc(bool value) { }

	public void set_NumBorderPoints(int value) { }

	public void set_Origin(Vector3 value) { }

	public void set_Radius(float value) { }

	public void set_RaycastMode(Shape3DRaycastMode value) { }

	public void set_WireEps(float value) { }

	public void SetArcData(Plane plane, Vector3 origin, Vector3 startPoint, float radius) { }

}

