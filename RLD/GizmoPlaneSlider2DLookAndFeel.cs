namespace RLD;

public class GizmoPlaneSlider2DLookAndFeel
{
	[SerializeField]
	private GizmoFillMode2D _fillMode; //Field offset: 0x10
	[SerializeField]
	private GizmoPlane2DType _planeType; //Field offset: 0x14
	[SerializeField]
	private float _scale; //Field offset: 0x18
	[SerializeField]
	private float _quadWidth; //Field offset: 0x1C
	[SerializeField]
	private float _quadHeight; //Field offset: 0x20
	[SerializeField]
	private float _circleRadius; //Field offset: 0x24
	[SerializeField]
	private bool _isRotationArcVisible; //Field offset: 0x28
	[SerializeField]
	private GizmoRotationArc2DLookAndFeel _rotationArcLookAndFeel; //Field offset: 0x30
	[SerializeField]
	private Color _color; //Field offset: 0x38
	[SerializeField]
	private Color _hoveredColor; //Field offset: 0x48
	[SerializeField]
	private Color _borderColor; //Field offset: 0x58
	[SerializeField]
	private Color _hoveredBorderColor; //Field offset: 0x68
	[SerializeField]
	private GizmoQuad2DBorderType _quadBorderType; //Field offset: 0x78
	[SerializeField]
	private GizmoCircle2DBorderType _circleBorderType; //Field offset: 0x7C
	[SerializeField]
	private GizmoPolygon2DBorderType _polygonBorderType; //Field offset: 0x80
	[SerializeField]
	private float _borderPolyThickness; //Field offset: 0x84

	public Color BorderColor
	{
		 get { } //Length: 11
		 set { } //Length: 8
	}

	public float BorderPolyThickness
	{
		 get { } //Length: 9
		 set { } //Length: 18
	}

	public GizmoCircle2DBorderType CircleBorderType
	{
		 get { } //Length: 4
		 set { } //Length: 4
	}

	public float CircleRadius
	{
		 get { } //Length: 6
		 set { } //Length: 15
	}

	public Color Color
	{
		 get { } //Length: 11
		 set { } //Length: 8
	}

	public GizmoFillMode2D FillMode
	{
		 get { } //Length: 4
		 set { } //Length: 4
	}

	public Color HoveredBorderColor
	{
		 get { } //Length: 11
		 set { } //Length: 8
	}

	public Color HoveredColor
	{
		 get { } //Length: 11
		 set { } //Length: 8
	}

	public bool IsRotationArcVisible
	{
		 get { } //Length: 5
		 set { } //Length: 4
	}

	public GizmoPlane2DType PlaneType
	{
		 get { } //Length: 4
		 set { } //Length: 4
	}

	public GizmoPolygon2DBorderType PolygonBorderType
	{
		 get { } //Length: 7
		 set { } //Length: 7
	}

	public GizmoQuad2DBorderType QuadBorderType
	{
		 get { } //Length: 4
		 set { } //Length: 4
	}

	public float QuadHeight
	{
		 get { } //Length: 6
		 set { } //Length: 15
	}

	public float QuadWidth
	{
		 get { } //Length: 6
		 set { } //Length: 15
	}

	public GizmoRotationArc2DLookAndFeel RotationArcLookAndFeel
	{
		 get { } //Length: 95
	}

	public float Scale
	{
		 get { } //Length: 6
		 set { } //Length: 15
	}

	public GizmoPlaneSlider2DLookAndFeel() { }

	public Color get_BorderColor() { }

	public float get_BorderPolyThickness() { }

	public GizmoCircle2DBorderType get_CircleBorderType() { }

	public float get_CircleRadius() { }

	public Color get_Color() { }

	public GizmoFillMode2D get_FillMode() { }

	public Color get_HoveredBorderColor() { }

	public Color get_HoveredColor() { }

	public bool get_IsRotationArcVisible() { }

	public GizmoPlane2DType get_PlaneType() { }

	public GizmoPolygon2DBorderType get_PolygonBorderType() { }

	public GizmoQuad2DBorderType get_QuadBorderType() { }

	public float get_QuadHeight() { }

	public float get_QuadWidth() { }

	public GizmoRotationArc2DLookAndFeel get_RotationArcLookAndFeel() { }

	public float get_Scale() { }

	public void set_BorderColor(Color value) { }

	public void set_BorderPolyThickness(float value) { }

	public void set_CircleBorderType(GizmoCircle2DBorderType value) { }

	public void set_CircleRadius(float value) { }

	public void set_Color(Color value) { }

	public void set_FillMode(GizmoFillMode2D value) { }

	public void set_HoveredBorderColor(Color value) { }

	public void set_HoveredColor(Color value) { }

	public void set_IsRotationArcVisible(bool value) { }

	public void set_PlaneType(GizmoPlane2DType value) { }

	public void set_PolygonBorderType(GizmoPolygon2DBorderType value) { }

	public void set_QuadBorderType(GizmoQuad2DBorderType value) { }

	public void set_QuadHeight(float value) { }

	public void set_QuadWidth(float value) { }

	public void set_Scale(float value) { }

}

