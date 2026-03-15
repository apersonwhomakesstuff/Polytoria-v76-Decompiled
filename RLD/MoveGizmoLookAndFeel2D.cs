namespace RLD;

public class MoveGizmoLookAndFeel2D : Settings
{
	[SerializeField]
	private GizmoPlaneSlider2DLookAndFeel _dblSliderLookAndFeel; //Field offset: 0x28
	[SerializeField]
	private GizmoLineSlider2DLookAndFeel[] _sglSliderLookAndFeel; //Field offset: 0x30
	[SerializeField]
	private bool _isDblSliderVisible; //Field offset: 0x38
	[SerializeField]
	private Boolean[] _sglSliderVis; //Field offset: 0x40
	[SerializeField]
	private Boolean[] _sglSliderCapVis; //Field offset: 0x48

	public float BoxSliderThickness
	{
		 get { } //Length: 49
	}

	public Color DblSliderBorderColor
	{
		 get { } //Length: 33
	}

	public float DblSliderCircleRadius
	{
		 get { } //Length: 28
	}

	public Color DblSliderColor
	{
		 get { } //Length: 33
	}

	public GizmoFillMode2D DblSliderFillMode
	{
		 get { } //Length: 26
	}

	public Color DblSliderHoveredBorderColor
	{
		 get { } //Length: 33
	}

	public Color DblSliderHoveredColor
	{
		 get { } //Length: 33
	}

	public GizmoPlane2DType DblSliderPlaneType
	{
		 get { } //Length: 26
	}

	public float DblSliderQuadHeight
	{
		 get { } //Length: 28
	}

	public float DblSliderQuadWidth
	{
		 get { } //Length: 28
	}

	public bool IsDblSliderVisible
	{
		 get { } //Length: 5
	}

	public float Scale
	{
		 get { } //Length: 49
	}

	public float SliderArrowCapBaseRadius
	{
		 get { } //Length: 58
	}

	public float SliderArrowCapHeight
	{
		 get { } //Length: 58
	}

	public GizmoFillMode2D SliderCapFillMode
	{
		 get { } //Length: 56
	}

	public GizmoCap2DType SliderCapType
	{
		 get { } //Length: 56
	}

	public float SliderCircleCapRadius
	{
		 get { } //Length: 58
	}

	public GizmoFillMode2D SliderFillMode
	{
		 get { } //Length: 47
	}

	public Color SliderHoveredBorderColor
	{
		 get { } //Length: 58
	}

	public Color SliderHoveredColor
	{
		 get { } //Length: 58
	}

	public float SliderLength
	{
		 get { } //Length: 49
	}

	public GizmoLine2DType SliderLineType
	{
		 get { } //Length: 47
	}

	public float SliderQuadCapHeight
	{
		 get { } //Length: 58
	}

	public float SliderQuadCapWidth
	{
		 get { } //Length: 58
	}

	public Color XBorderColor
	{
		 get { } //Length: 58
	}

	public Color XColor
	{
		 get { } //Length: 58
	}

	public Color YBorderColor
	{
		 get { } //Length: 58
	}

	public Color YColor
	{
		 get { } //Length: 58
	}

	public MoveGizmoLookAndFeel2D() { }

	public void ConnectDblSliderLookAndFeel(GizmoPlaneSlider2D slider) { }

	public void ConnectSliderLookAndFeel(GizmoLineSlider2D slider, int axisIndex, AxisSign axisSign) { }

	public float get_BoxSliderThickness() { }

	public Color get_DblSliderBorderColor() { }

	public float get_DblSliderCircleRadius() { }

	public Color get_DblSliderColor() { }

	public GizmoFillMode2D get_DblSliderFillMode() { }

	public Color get_DblSliderHoveredBorderColor() { }

	public Color get_DblSliderHoveredColor() { }

	public GizmoPlane2DType get_DblSliderPlaneType() { }

	public float get_DblSliderQuadHeight() { }

	public float get_DblSliderQuadWidth() { }

	public bool get_IsDblSliderVisible() { }

	public float get_Scale() { }

	public float get_SliderArrowCapBaseRadius() { }

	public float get_SliderArrowCapHeight() { }

	public GizmoFillMode2D get_SliderCapFillMode() { }

	public GizmoCap2DType get_SliderCapType() { }

	public float get_SliderCircleCapRadius() { }

	public GizmoFillMode2D get_SliderFillMode() { }

	public Color get_SliderHoveredBorderColor() { }

	public Color get_SliderHoveredColor() { }

	public float get_SliderLength() { }

	public GizmoLine2DType get_SliderLineType() { }

	public float get_SliderQuadCapHeight() { }

	public float get_SliderQuadCapWidth() { }

	public Color get_XBorderColor() { }

	public Color get_XColor() { }

	public Color get_YBorderColor() { }

	public Color get_YColor() { }

	public List<Enum> GetAllowedDblSliderPlaneTypes() { }

	private GizmoLineSlider2DLookAndFeel GetSliderLookAndFeel(int axisIndex, AxisSign axisSign) { }

	public bool IsDblSliderPlaneTypeAllowed(GizmoPlane2DType planeType) { }

	public bool IsNegativeSliderCapVisible(int axisIndex) { }

	public bool IsNegativeSliderVisible(int axisIndex) { }

	public bool IsPositiveSliderCapVisible(int axisIndex) { }

	public bool IsPositiveSliderVisible(int axisIndex) { }

	public bool IsSliderCapVisible(int axisIndex, AxisSign axisSign) { }

	public bool IsSliderVisible(int axisIndex, AxisSign axisSign) { }

	public void SetAxisBorderColor(int axisIndex, Color color) { }

	public void SetAxisColor(int axisIndex, Color color) { }

	public void SetBoxSliderThickness(float thickness) { }

	public void SetDblSliderBorderColor(Color color) { }

	public void SetDblSliderCircleRadius(float radius) { }

	public void SetDblSliderColor(Color color) { }

	public void SetDblSliderFillMode(GizmoFillMode2D fillMode) { }

	public void SetDblSliderHoveredBorderColor(Color color) { }

	public void SetDblSliderHoveredColor(Color color) { }

	public void SetDblSliderPlaneType(GizmoPlane2DType sliderType) { }

	public void SetDblSliderQuadHeight(float height) { }

	public void SetDblSliderQuadWidth(float width) { }

	public void SetDblSliderVisible(bool isVisible) { }

	public void SetScale(float scale) { }

	public void SetSliderArrowCapBaseRadius(float radius) { }

	public void SetSliderArrowCapHeight(float height) { }

	public void SetSliderCapFillMode(GizmoFillMode2D fillMode) { }

	public void SetSliderCapType(GizmoCap2DType capType) { }

	public void SetSliderCapVisible(int axisIndex, AxisSign axisSign, bool isVisible) { }

	public void SetSliderCircleCapRadius(float radius) { }

	public void SetSliderFillMode(GizmoFillMode2D fillMode) { }

	public void SetSliderHoveredBorderColor(Color color) { }

	public void SetSliderHoveredFillColor(Color color) { }

	public void SetSliderLength(float length) { }

	public void SetSliderLineType(GizmoLine2DType lineType) { }

	public void SetSliderQuadCapHeight(float height) { }

	public void SetSliderQuadCapWidth(float width) { }

	public void SetSliderVisible(int axisIndex, AxisSign axisSign, bool isVisible) { }

}

