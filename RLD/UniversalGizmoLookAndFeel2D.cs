namespace RLD;

public class UniversalGizmoLookAndFeel2D : Settings
{
	[SerializeField]
	private UniversalGizmoSettingsCategory _displayCategory; //Field offset: 0x28
	[SerializeField]
	private GizmoPlaneSlider2DLookAndFeel _mvDblSliderLookAndFeel; //Field offset: 0x30
	[SerializeField]
	private GizmoLineSlider2DLookAndFeel[] _mvSglSliderLookAndFeel; //Field offset: 0x38
	[SerializeField]
	private bool _isMvDblSliderVisible; //Field offset: 0x40
	[SerializeField]
	private Boolean[] _mvSglSliderVis; //Field offset: 0x48
	[SerializeField]
	private Boolean[] _mvSglSliderCapVis; //Field offset: 0x50

	public UniversalGizmoSettingsCategory DisplayCategory
	{
		 get { } //Length: 4
		 set { } //Length: 4
	}

	public bool IsMvDblSliderVisible
	{
		 get { } //Length: 5
	}

	public float MvBoxSliderThickness
	{
		 get { } //Length: 49
	}

	public Color MvDblSliderBorderColor
	{
		 get { } //Length: 33
	}

	public float MvDblSliderCircleRadius
	{
		 get { } //Length: 28
	}

	public Color MvDblSliderColor
	{
		 get { } //Length: 33
	}

	public GizmoFillMode2D MvDblSliderFillMode
	{
		 get { } //Length: 26
	}

	public Color MvDblSliderHoveredBorderColor
	{
		 get { } //Length: 33
	}

	public Color MvDblSliderHoveredColor
	{
		 get { } //Length: 33
	}

	public GizmoPlane2DType MvDblSliderPlaneType
	{
		 get { } //Length: 26
	}

	public float MvDblSliderQuadHeight
	{
		 get { } //Length: 28
	}

	public float MvDblSliderQuadWidth
	{
		 get { } //Length: 28
	}

	public float MvScale
	{
		 get { } //Length: 49
	}

	public float MvSliderArrowCapBaseRadius
	{
		 get { } //Length: 58
	}

	public float MvSliderArrowCapHeight
	{
		 get { } //Length: 58
	}

	public GizmoFillMode2D MvSliderCapFillMode
	{
		 get { } //Length: 56
	}

	public GizmoCap2DType MvSliderCapType
	{
		 get { } //Length: 56
	}

	public float MvSliderCircleCapRadius
	{
		 get { } //Length: 58
	}

	public GizmoFillMode2D MvSliderFillMode
	{
		 get { } //Length: 47
	}

	public Color MvSliderHoveredBorderColor
	{
		 get { } //Length: 58
	}

	public Color MvSliderHoveredColor
	{
		 get { } //Length: 58
	}

	public float MvSliderLength
	{
		 get { } //Length: 49
	}

	public GizmoLine2DType MvSliderLineType
	{
		 get { } //Length: 47
	}

	public float MvSliderQuadCapHeight
	{
		 get { } //Length: 58
	}

	public float MvSliderQuadCapWidth
	{
		 get { } //Length: 58
	}

	public Color MvXBorderColor
	{
		 get { } //Length: 58
	}

	public Color MvXColor
	{
		 get { } //Length: 58
	}

	public Color MvYBorderColor
	{
		 get { } //Length: 58
	}

	public Color MvYColor
	{
		 get { } //Length: 58
	}

	public UniversalGizmoLookAndFeel2D() { }

	public void ConnectMvDblSliderLookAndFeel(GizmoPlaneSlider2D slider) { }

	public void ConnectMvSliderLookAndFeel(GizmoLineSlider2D slider, int axisIndex, AxisSign axisSign) { }

	public UniversalGizmoSettingsCategory get_DisplayCategory() { }

	public bool get_IsMvDblSliderVisible() { }

	public float get_MvBoxSliderThickness() { }

	public Color get_MvDblSliderBorderColor() { }

	public float get_MvDblSliderCircleRadius() { }

	public Color get_MvDblSliderColor() { }

	public GizmoFillMode2D get_MvDblSliderFillMode() { }

	public Color get_MvDblSliderHoveredBorderColor() { }

	public Color get_MvDblSliderHoveredColor() { }

	public GizmoPlane2DType get_MvDblSliderPlaneType() { }

	public float get_MvDblSliderQuadHeight() { }

	public float get_MvDblSliderQuadWidth() { }

	public float get_MvScale() { }

	public float get_MvSliderArrowCapBaseRadius() { }

	public float get_MvSliderArrowCapHeight() { }

	public GizmoFillMode2D get_MvSliderCapFillMode() { }

	public GizmoCap2DType get_MvSliderCapType() { }

	public float get_MvSliderCircleCapRadius() { }

	public GizmoFillMode2D get_MvSliderFillMode() { }

	public Color get_MvSliderHoveredBorderColor() { }

	public Color get_MvSliderHoveredColor() { }

	public float get_MvSliderLength() { }

	public GizmoLine2DType get_MvSliderLineType() { }

	public float get_MvSliderQuadCapHeight() { }

	public float get_MvSliderQuadCapWidth() { }

	public Color get_MvXBorderColor() { }

	public Color get_MvXColor() { }

	public Color get_MvYBorderColor() { }

	public Color get_MvYColor() { }

	private GizmoLineSlider2DLookAndFeel GetMvSliderLookAndFeel(int axisIndex, AxisSign axisSign) { }

	public void Inherit(MoveGizmoLookAndFeel2D lookAndFeel) { }

	public bool IsMvNegativeSliderCapVisible(int axisIndex) { }

	public bool IsMvNegativeSliderVisible(int axisIndex) { }

	public bool IsMvPositiveSliderCapVisible(int axisIndex) { }

	public bool IsMvPositiveSliderVisible(int axisIndex) { }

	public bool IsMvSliderCapVisible(int axisIndex, AxisSign axisSign) { }

	public bool IsMvSliderVisible(int axisIndex, AxisSign axisSign) { }

	public void set_DisplayCategory(UniversalGizmoSettingsCategory value) { }

	public void SetMvAxisBorderColor(int axisIndex, Color color) { }

	public void SetMvAxisColor(int axisIndex, Color color) { }

	public void SetMvBoxSliderThickness(float thickness) { }

	public void SetMvDblSliderBorderColor(Color color) { }

	public void SetMvDblSliderCircleRadius(float radius) { }

	public void SetMvDblSliderColor(Color color) { }

	public void SetMvDblSliderFillMode(GizmoFillMode2D fillMode) { }

	public void SetMvDblSliderHoveredBorderColor(Color color) { }

	public void SetMvDblSliderHoveredColor(Color color) { }

	public void SetMvDblSliderPlaneType(GizmoPlane2DType sliderType) { }

	public void SetMvDblSliderQuadHeight(float height) { }

	public void SetMvDblSliderQuadWidth(float width) { }

	public void SetMvDblSliderVisible(bool isVisible) { }

	public void SetMvScale(float scale) { }

	public void SetMvSliderArrowCapBaseRadius(float radius) { }

	public void SetMvSliderArrowCapHeight(float height) { }

	public void SetMvSliderCapFillMode(GizmoFillMode2D fillMode) { }

	public void SetMvSliderCapType(GizmoCap2DType capType) { }

	public void SetMvSliderCapVisible(int axisIndex, AxisSign axisSign, bool isVisible) { }

	public void SetMvSliderCircleCapRadius(float radius) { }

	public void SetMvSliderFillMode(GizmoFillMode2D fillMode) { }

	public void SetMvSliderHoveredBorderColor(Color color) { }

	public void SetMvSliderHoveredFillColor(Color color) { }

	public void SetMvSliderLength(float length) { }

	public void SetMvSliderLineType(GizmoLine2DType lineType) { }

	public void SetMvSliderQuadCapHeight(float height) { }

	public void SetMvSliderQuadCapWidth(float width) { }

	public void SetMvSliderVisible(int axisIndex, AxisSign axisSign, bool isVisible) { }

}

