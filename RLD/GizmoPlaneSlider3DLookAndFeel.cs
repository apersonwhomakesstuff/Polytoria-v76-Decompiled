namespace RLD;

public class GizmoPlaneSlider3DLookAndFeel
{
	[SerializeField]
	private GizmoPlane3DType _planeType; //Field offset: 0x10
	[SerializeField]
	private float _scale; //Field offset: 0x14
	[SerializeField]
	private bool _useZoomFactor; //Field offset: 0x18
	[SerializeField]
	private float _quadWidth; //Field offset: 0x1C
	[SerializeField]
	private float _quadHeight; //Field offset: 0x20
	[SerializeField]
	private float _raTriangleXLength; //Field offset: 0x24
	[SerializeField]
	private float _raTriangleYLength; //Field offset: 0x28
	[SerializeField]
	private float _circleRadius; //Field offset: 0x2C
	[SerializeField]
	private float _borderBoxHeight; //Field offset: 0x30
	[SerializeField]
	private float _borderBoxDepth; //Field offset: 0x34
	[SerializeField]
	private float _borderTorusThickness; //Field offset: 0x38
	[SerializeField]
	private int _numBorderTorusWireAxialSlices; //Field offset: 0x3C
	[SerializeField]
	private float _borderCylTorusWidth; //Field offset: 0x40
	[SerializeField]
	private float _borderCylTorusHeight; //Field offset: 0x44
	[SerializeField]
	private GizmoShadeMode _shadeMode; //Field offset: 0x48
	[SerializeField]
	private Color _color; //Field offset: 0x4C
	[SerializeField]
	private Color _hoveredColor; //Field offset: 0x5C
	[SerializeField]
	private Color _borderColor; //Field offset: 0x6C
	[SerializeField]
	private Color _hoveredBorderColor; //Field offset: 0x7C
	[SerializeField]
	private float _borderCircleCullAlphaScale; //Field offset: 0x8C
	[SerializeField]
	private GizmoShadeMode _borderShadeMode; //Field offset: 0x90
	[SerializeField]
	private GizmoFillMode3D _borderFillMode; //Field offset: 0x94
	[SerializeField]
	private GizmoQuad3DBorderType _quadBorderType; //Field offset: 0x98
	[SerializeField]
	private GizmoRATriangle3DBorderType _raTriangleBorderType; //Field offset: 0x9C
	[SerializeField]
	private GizmoCircle3DBorderType _circleBorderType; //Field offset: 0xA0
	[SerializeField]
	private bool _isRotationArcVisible; //Field offset: 0xA4
	[SerializeField]
	private GizmoRotationArc3DLookAndFeel _rotationArcLookAndFeel; //Field offset: 0xA8

	public float BorderBoxDepth
	{
		 get { } //Length: 6
		 set { } //Length: 15
	}

	public float BorderBoxHeight
	{
		 get { } //Length: 6
		 set { } //Length: 15
	}

	public float BorderCircleCullAlphaScale
	{
		 get { } //Length: 9
		 set { } //Length: 39
	}

	public Color BorderColor
	{
		 get { } //Length: 11
		 set { } //Length: 8
	}

	public float BorderCylTorusHeight
	{
		 get { } //Length: 6
		 set { } //Length: 15
	}

	public float BorderCylTorusWidth
	{
		 get { } //Length: 6
		 set { } //Length: 15
	}

	public GizmoFillMode3D BorderFillMode
	{
		 get { } //Length: 7
		 set { } //Length: 7
	}

	public GizmoShadeMode BorderShadeMode
	{
		 get { } //Length: 7
		 set { } //Length: 7
	}

	public float BorderTorusThickness
	{
		 get { } //Length: 6
		 set { } //Length: 15
	}

	public GizmoCircle3DBorderType CircleBorderType
	{
		 get { } //Length: 7
		 set { } //Length: 7
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
		 get { } //Length: 8
		 set { } //Length: 7
	}

	public int NumBorderTorusWireAxialSlices
	{
		 get { } //Length: 4
		 set { } //Length: 16
	}

	public GizmoPlane3DType PlaneType
	{
		 get { } //Length: 4
		 set { } //Length: 4
	}

	public GizmoQuad3DBorderType QuadBorderType
	{
		 get { } //Length: 7
		 set { } //Length: 7
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

	public GizmoRATriangle3DBorderType RATriangleBorderType
	{
		 get { } //Length: 7
		 set { } //Length: 7
	}

	public float RATriangleXLength
	{
		 get { } //Length: 6
		 set { } //Length: 15
	}

	public float RATriangleYLength
	{
		 get { } //Length: 6
		 set { } //Length: 15
	}

	public GizmoRotationArc3DLookAndFeel RotationArcLookAndFeel
	{
		 get { } //Length: 8
	}

	public float Scale
	{
		 get { } //Length: 6
		 set { } //Length: 15
	}

	public GizmoShadeMode ShadeMode
	{
		 get { } //Length: 4
		 set { } //Length: 4
	}

	public bool UseZoomFactor
	{
		 get { } //Length: 5
		 set { } //Length: 4
	}

	public GizmoPlaneSlider3DLookAndFeel() { }

	public float get_BorderBoxDepth() { }

	public float get_BorderBoxHeight() { }

	public float get_BorderCircleCullAlphaScale() { }

	public Color get_BorderColor() { }

	public float get_BorderCylTorusHeight() { }

	public float get_BorderCylTorusWidth() { }

	public GizmoFillMode3D get_BorderFillMode() { }

	public GizmoShadeMode get_BorderShadeMode() { }

	public float get_BorderTorusThickness() { }

	public GizmoCircle3DBorderType get_CircleBorderType() { }

	public float get_CircleRadius() { }

	public Color get_Color() { }

	public Color get_HoveredBorderColor() { }

	public Color get_HoveredColor() { }

	public bool get_IsRotationArcVisible() { }

	public int get_NumBorderTorusWireAxialSlices() { }

	public GizmoPlane3DType get_PlaneType() { }

	public GizmoQuad3DBorderType get_QuadBorderType() { }

	public float get_QuadHeight() { }

	public float get_QuadWidth() { }

	public GizmoRATriangle3DBorderType get_RATriangleBorderType() { }

	public float get_RATriangleXLength() { }

	public float get_RATriangleYLength() { }

	public GizmoRotationArc3DLookAndFeel get_RotationArcLookAndFeel() { }

	public float get_Scale() { }

	public GizmoShadeMode get_ShadeMode() { }

	public bool get_UseZoomFactor() { }

	public void set_BorderBoxDepth(float value) { }

	public void set_BorderBoxHeight(float value) { }

	public void set_BorderCircleCullAlphaScale(float value) { }

	public void set_BorderColor(Color value) { }

	public void set_BorderCylTorusHeight(float value) { }

	public void set_BorderCylTorusWidth(float value) { }

	public void set_BorderFillMode(GizmoFillMode3D value) { }

	public void set_BorderShadeMode(GizmoShadeMode value) { }

	public void set_BorderTorusThickness(float value) { }

	public void set_CircleBorderType(GizmoCircle3DBorderType value) { }

	public void set_CircleRadius(float value) { }

	public void set_Color(Color value) { }

	public void set_HoveredBorderColor(Color value) { }

	public void set_HoveredColor(Color value) { }

	public void set_IsRotationArcVisible(bool value) { }

	public void set_NumBorderTorusWireAxialSlices(int value) { }

	public void set_PlaneType(GizmoPlane3DType value) { }

	public void set_QuadBorderType(GizmoQuad3DBorderType value) { }

	public void set_QuadHeight(float value) { }

	public void set_QuadWidth(float value) { }

	public void set_RATriangleBorderType(GizmoRATriangle3DBorderType value) { }

	public void set_RATriangleXLength(float value) { }

	public void set_RATriangleYLength(float value) { }

	public void set_Scale(float value) { }

	public void set_ShadeMode(GizmoShadeMode value) { }

	public void set_UseZoomFactor(bool value) { }

}

