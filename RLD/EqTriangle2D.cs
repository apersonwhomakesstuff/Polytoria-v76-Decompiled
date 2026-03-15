namespace RLD;

public class EqTriangle2D : Shape2D
{
	private float _sideLength; //Field offset: 0x10
	private float _rotationDegrees; //Field offset: 0x14
	private TriangleEpsilon _epsilon; //Field offset: 0x18
	private Vector2[] _points; //Field offset: 0x28
	private Vector2 _centroid; //Field offset: 0x30
	private bool _arePointsDirty; //Field offset: 0x38

	public float Altitude
	{
		 get { } //Length: 149
	}

	public float AreaEps
	{
		 get { } //Length: 6
		 set { } //Length: 12
	}

	public Vector2 Centroid
	{
		 get { } //Length: 19
		 set { } //Length: 165
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

	public static Vector2 ModelCentroid
	{
		 get { } //Length: 274
	}

	public static Vector2 ModelRight
	{
		 get { } //Length: 69
	}

	public static Vector2 ModelUp
	{
		 get { } //Length: 69
	}

	public Vector2 Right
	{
		 get { } //Length: 226
	}

	public Quaternion Rotation
	{
		 get { } //Length: 120
	}

	public float RotationDegrees
	{
		 get { } //Length: 6
		 set { } //Length: 6
	}

	public float SideLength
	{
		 get { } //Length: 6
		 set { } //Length: 17
	}

	public Vector2 Up
	{
		 get { } //Length: 226
	}

	public EqTriangle2D() { }

	public virtual bool ContainsPoint(Vector2 point) { }

	public float get_Altitude() { }

	public float get_AreaEps() { }

	public Vector2 get_Centroid() { }

	public float get_CentroidAltitude() { }

	public TriangleEpsilon get_Epsilon() { }

	public static Vector2 get_ModelCentroid() { }

	public static Vector2 get_ModelRight() { }

	public static Vector2 get_ModelUp() { }

	public Vector2 get_Right() { }

	public Quaternion get_Rotation() { }

	public float get_RotationDegrees() { }

	public float get_SideLength() { }

	public Vector2 get_Up() { }

	public Vector2 GetEdge(EqTriangleEdge edge) { }

	public Vector2 GetEdgeMidPoint(EqTriangleEdge edge) { }

	public virtual Rect GetEncapsulatingRect() { }

	public Vector2 GetPoint(EqTrianglePoint point) { }

	private void OnPointsFoundDirty() { }

	public virtual void RenderArea(Camera camera) { }

	public virtual void RenderBorder(Camera camera) { }

	public void set_AreaEps(float value) { }

	public void set_Centroid(Vector2 value) { }

	public void set_Epsilon(TriangleEpsilon value) { }

	public void set_RotationDegrees(float value) { }

	public void set_SideLength(float value) { }

	public void SetPoint(EqTrianglePoint point, Vector2 pointValue) { }

}

