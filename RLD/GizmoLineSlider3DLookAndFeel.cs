namespace RLD;

public class GizmoLineSlider3DLookAndFeel
{
	[SerializeField]
	private GizmoShadeMode _shadeMode; //Field offset: 0x10
	[SerializeField]
	private GizmoLine3DType _lineType; //Field offset: 0x14
	[SerializeField]
	private GizmoFillMode3D _fillMode; //Field offset: 0x18
	[SerializeField]
	private float _length; //Field offset: 0x1C
	[SerializeField]
	private float _scale; //Field offset: 0x20
	[SerializeField]
	private bool _useZoomFactor; //Field offset: 0x24
	[SerializeField]
	private float _boxHeight; //Field offset: 0x28
	[SerializeField]
	private float _boxDepth; //Field offset: 0x2C
	[SerializeField]
	private float _cylinderRadius; //Field offset: 0x30
	[SerializeField]
	private bool _isRotationArcVisible; //Field offset: 0x34
	[SerializeField]
	private GizmoRotationArc3DLookAndFeel _rotationArcLookAndFeel; //Field offset: 0x38
	[SerializeField]
	private Color _color; //Field offset: 0x40
	[SerializeField]
	private Color _hoveredColor; //Field offset: 0x50
	[SerializeField]
	private GizmoCap3DLookAndFeel _capLookAndFeel; //Field offset: 0x60

	public float BoxDepth
	{
		 get { } //Length: 6
		 set { } //Length: 15
	}

	public float BoxHeight
	{
		 get { } //Length: 6
		 set { } //Length: 15
	}

	public GizmoCap3DLookAndFeel CapLookAndFeel
	{
		 get { } //Length: 5
	}

	public Color Color
	{
		 get { } //Length: 11
		 set { } //Length: 8
	}

	public float CylinderRadius
	{
		 get { } //Length: 6
		 set { } //Length: 15
	}

	public GizmoFillMode3D FillMode
	{
		 get { } //Length: 4
		 set { } //Length: 4
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

	public float Length
	{
		 get { } //Length: 6
		 set { } //Length: 15
	}

	public GizmoLine3DType LineType
	{
		 get { } //Length: 4
		 set { } //Length: 4
	}

	public GizmoRotationArc3DLookAndFeel RotationArcLookAndFeel
	{
		 get { } //Length: 5
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

	public GizmoLineSlider3DLookAndFeel() { }

	public float get_BoxDepth() { }

	public float get_BoxHeight() { }

	public GizmoCap3DLookAndFeel get_CapLookAndFeel() { }

	public Color get_Color() { }

	public float get_CylinderRadius() { }

	public GizmoFillMode3D get_FillMode() { }

	public Color get_HoveredColor() { }

	public bool get_IsRotationArcVisible() { }

	public float get_Length() { }

	public GizmoLine3DType get_LineType() { }

	public GizmoRotationArc3DLookAndFeel get_RotationArcLookAndFeel() { }

	public float get_Scale() { }

	public GizmoShadeMode get_ShadeMode() { }

	public bool get_UseZoomFactor() { }

	public void set_BoxDepth(float value) { }

	public void set_BoxHeight(float value) { }

	public void set_Color(Color value) { }

	public void set_CylinderRadius(float value) { }

	public void set_FillMode(GizmoFillMode3D value) { }

	public void set_HoveredColor(Color value) { }

	public void set_IsRotationArcVisible(bool value) { }

	public void set_Length(float value) { }

	public void set_LineType(GizmoLine3DType value) { }

	public void set_Scale(float value) { }

	public void set_ShadeMode(GizmoShadeMode value) { }

	public void set_UseZoomFactor(bool value) { }

}

