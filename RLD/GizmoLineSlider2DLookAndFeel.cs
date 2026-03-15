namespace RLD;

public class GizmoLineSlider2DLookAndFeel
{
	[SerializeField]
	private GizmoLine2DType _lineType; //Field offset: 0x10
	[SerializeField]
	private GizmoFillMode2D _fillMode; //Field offset: 0x14
	[SerializeField]
	private float _length; //Field offset: 0x18
	[SerializeField]
	private float _scale; //Field offset: 0x1C
	[SerializeField]
	private float _boxThickness; //Field offset: 0x20
	[SerializeField]
	private bool _isRotationArcVisible; //Field offset: 0x24
	[SerializeField]
	private Color _color; //Field offset: 0x28
	[SerializeField]
	private Color _hoveredColor; //Field offset: 0x38
	[SerializeField]
	private Color _borderColor; //Field offset: 0x48
	[SerializeField]
	private Color _hoveredBorderColor; //Field offset: 0x58
	[SerializeField]
	private GizmoRotationArc2DLookAndFeel _rotationArcLookAndFeel; //Field offset: 0x68
	[SerializeField]
	private GizmoCap2DLookAndFeel _capLookAndFeel; //Field offset: 0x70

	public Color BorderColor
	{
		 get { } //Length: 11
		 set { } //Length: 8
	}

	public float BoxThickness
	{
		 get { } //Length: 6
		 set { } //Length: 15
	}

	public GizmoCap2DLookAndFeel CapLookAndFeel
	{
		 get { } //Length: 5
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

	public float Length
	{
		 get { } //Length: 6
		 set { } //Length: 15
	}

	public GizmoLine2DType LineType
	{
		 get { } //Length: 4
		 set { } //Length: 4
	}

	public GizmoRotationArc2DLookAndFeel RotationArcLookAndFeel
	{
		 get { } //Length: 5
	}

	public float Scale
	{
		 get { } //Length: 6
		 set { } //Length: 15
	}

	public GizmoLineSlider2DLookAndFeel() { }

	public Color get_BorderColor() { }

	public float get_BoxThickness() { }

	public GizmoCap2DLookAndFeel get_CapLookAndFeel() { }

	public Color get_Color() { }

	public GizmoFillMode2D get_FillMode() { }

	public Color get_HoveredBorderColor() { }

	public Color get_HoveredColor() { }

	public bool get_IsRotationArcVisible() { }

	public float get_Length() { }

	public GizmoLine2DType get_LineType() { }

	public GizmoRotationArc2DLookAndFeel get_RotationArcLookAndFeel() { }

	public float get_Scale() { }

	public void set_BorderColor(Color value) { }

	public void set_BoxThickness(float value) { }

	public void set_Color(Color value) { }

	public void set_FillMode(GizmoFillMode2D value) { }

	public void set_HoveredBorderColor(Color value) { }

	public void set_HoveredColor(Color value) { }

	public void set_IsRotationArcVisible(bool value) { }

	public void set_Length(float value) { }

	public void set_LineType(GizmoLine2DType value) { }

	public void set_Scale(float value) { }

}

