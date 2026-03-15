namespace RLD;

public class ArcShape2D : Shape2D
{
	internal class BorderRenderDescriptor
	{
		private BorderRenderFlags _borderFlags; //Field offset: 0x10

		public BorderRenderFlags BorderFlags
		{
			 get { } //Length: 4
			 set { } //Length: 4
		}

		public BorderRenderDescriptor() { }

		public BorderRenderFlags get_BorderFlags() { }

		public void set_BorderFlags(BorderRenderFlags value) { }

	}

	internal enum BorderRenderFlags : int
	{
		None = 0,
		ExtremitiesBorder = 1,
		ArcBorder = 2,
		All = 3,
	}

	private BorderRenderDescriptor _borderRenderDesc; //Field offset: 0x10
	private Rect _rect; //Field offset: 0x18
	private bool _forceShortestArc; //Field offset: 0x28
	private float _radius; //Field offset: 0x2C
	private Vector2 _origin; //Field offset: 0x30
	private Vector2 _startPoint; //Field offset: 0x38
	private Vector2 _endPoint; //Field offset: 0x40
	private List<Vector2> _borderPoints; //Field offset: 0x48
	private float _degreeAngleFromStart; //Field offset: 0x50
	private int _numBorderPoints; //Field offset: 0x54
	private bool _areBorderPointsDirty; //Field offset: 0x58
	private ArcEpsilon _epsilon; //Field offset: 0x5C

	public float AbsDegreeAngleFromStart
	{
		 get { } //Length: 13
	}

	public float AreaEps
	{
		 get { } //Length: 6
		 set { } //Length: 12
	}

	public BorderRenderDescriptor BorderRenderDesc
	{
		 get { } //Length: 5
	}

	public float DegreeAngleFromStart
	{
		 get { } //Length: 6
		 set { } //Length: 50
	}

	public Vector2 EndPoint
	{
		 get { } //Length: 19
	}

	public ArcEpsilon Epsilon
	{
		 get { } //Length: 19
		 set { } //Length: 16
	}

	public bool ForceShortestArc
	{
		 get { } //Length: 5
		 set { } //Length: 29
	}

	public int NumBorderPoints
	{
		 get { } //Length: 4
		 set { } //Length: 20
	}

	public Vector2 Origin
	{
		 get { } //Length: 19
		 set { } //Length: 140
	}

	public float Radius
	{
		 get { } //Length: 6
		 set { } //Length: 146
	}

	public Vector2 StartPoint
	{
		 get { } //Length: 19
	}

	public ArcShape2D() { }

	private void CalculateEndPoint() { }

	public virtual bool ContainsPoint(Vector2 point) { }

	public float get_AbsDegreeAngleFromStart() { }

	public float get_AreaEps() { }

	public BorderRenderDescriptor get_BorderRenderDesc() { }

	public float get_DegreeAngleFromStart() { }

	public Vector2 get_EndPoint() { }

	public ArcEpsilon get_Epsilon() { }

	public bool get_ForceShortestArc() { }

	public int get_NumBorderPoints() { }

	public Vector2 get_Origin() { }

	public float get_Radius() { }

	public Vector2 get_StartPoint() { }

	public virtual Rect GetEncapsulatingRect() { }

	private void OnBorderPointsFoundDirty() { }

	public virtual void RenderArea(Camera camera) { }

	public virtual void RenderBorder(Camera camera) { }

	public void set_AreaEps(float value) { }

	public void set_DegreeAngleFromStart(float value) { }

	public void set_Epsilon(ArcEpsilon value) { }

	public void set_ForceShortestArc(bool value) { }

	public void set_NumBorderPoints(int value) { }

	public void set_Origin(Vector2 value) { }

	public void set_Radius(float value) { }

	public void SetArcData(Vector2 startPoint, float radius) { }

}

