namespace RLD;

public class PolygonShape2D : Shape2D
{
	internal class BorderRenderDescriptor
	{
		private Shape2DBorderType _borderType; //Field offset: 0x10
		private float _thickness; //Field offset: 0x14
		private Shape2DBorderDirection _direction; //Field offset: 0x18
		private ThickBorderFillMode _fillMode; //Field offset: 0x1C

		public Shape2DBorderType BorderType
		{
			 get { } //Length: 4
			 set { } //Length: 4
		}

		public Shape2DBorderDirection Direction
		{
			 get { } //Length: 4
			 set { } //Length: 4
		}

		public ThickBorderFillMode FillMode
		{
			 get { } //Length: 4
			 set { } //Length: 4
		}

		public float Thickness
		{
			 get { } //Length: 6
			 set { } //Length: 13
		}

		public BorderRenderDescriptor() { }

		public Shape2DBorderType get_BorderType() { }

		public Shape2DBorderDirection get_Direction() { }

		public ThickBorderFillMode get_FillMode() { }

		public float get_Thickness() { }

		public void set_BorderType(Shape2DBorderType value) { }

		public void set_Direction(Shape2DBorderDirection value) { }

		public void set_FillMode(ThickBorderFillMode value) { }

		public void set_Thickness(float value) { }

	}

	internal enum ThickBorderFillMode : int
	{
		Filled = 0,
		Border = 1,
	}

	private Rect _rect; //Field offset: 0x10
	private bool _isRectDirty; //Field offset: 0x20
	private bool _isClosed; //Field offset: 0x21
	private List<Vector2> _cwPolyPoints; //Field offset: 0x28
	private List<Vector2> _thickCwBorderPoints; //Field offset: 0x30
	private bool _isThickBorderDirty; //Field offset: 0x38
	private PolygonEpsilon _epsilon; //Field offset: 0x3C
	private Shape2DPtContainMode _ptContainMode; //Field offset: 0x4C
	private BorderRenderDescriptor _borderRenderDesc; //Field offset: 0x50

	public float AreaEps
	{
		 get { } //Length: 6
		 set { } //Length: 12
	}

	public BorderRenderDescriptor BorderRenderDesc
	{
		 get { } //Length: 5
	}

	public PolygonEpsilon Epsilon
	{
		 get { } //Length: 11
		 set { } //Length: 8
	}

	public bool IsClosed
	{
		 get { } //Length: 5
	}

	public int NumPoints
	{
		 get { } //Length: 60
	}

	public Shape2DPtContainMode PtContainMode
	{
		 get { } //Length: 4
		 set { } //Length: 4
	}

	public float ThickWireEps
	{
		 get { } //Length: 6
		 set { } //Length: 12
	}

	public float WireEps
	{
		 get { } //Length: 6
		 set { } //Length: 12
	}

	public PolygonShape2D() { }

	private void CalculateRect() { }

	private void CalculateThickBorderPoints() { }

	public virtual bool ContainsPoint(Vector2 point) { }

	public void CopyPoints(PolygonShape2D sourcePoly) { }

	public float get_AreaEps() { }

	public BorderRenderDescriptor get_BorderRenderDesc() { }

	public PolygonEpsilon get_Epsilon() { }

	public bool get_IsClosed() { }

	public int get_NumPoints() { }

	public Shape2DPtContainMode get_PtContainMode() { }

	public float get_ThickWireEps() { }

	public float get_WireEps() { }

	public virtual Rect GetEncapsulatingRect() { }

	public Vector2 GetExtentPoint(Shape2DExtentPoint extentPt) { }

	public List<Vector2> GetPoints() { }

	public void MakeSphereBorder(Vector3 sphereCenter, float sphereRadius, int numPoints, Camera camera) { }

	public virtual void RenderArea(Camera camera) { }

	public virtual void RenderBorder(Camera camera) { }

	public void set_AreaEps(float value) { }

	public void set_Epsilon(PolygonEpsilon value) { }

	public void set_PtContainMode(Shape2DPtContainMode value) { }

	public void set_ThickWireEps(float value) { }

	public void set_WireEps(float value) { }

	public void SetClockwisePoints(List<Vector2> cwBorderPoints, bool isClosed) { }

}

