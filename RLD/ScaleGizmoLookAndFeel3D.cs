namespace RLD;

public class ScaleGizmoLookAndFeel3D : Settings
{
	[SerializeField]
	private GizmoCap3DLookAndFeel _midCapLookAndFeel; //Field offset: 0x28
	[SerializeField]
	private Boolean[] _sglSliderVis; //Field offset: 0x30
	[SerializeField]
	private Boolean[] _sglSliderCapVis; //Field offset: 0x38
	[SerializeField]
	private Boolean[] _dblSliderVis; //Field offset: 0x40
	[SerializeField]
	private GizmoScaleGuideLookAndFeel _scaleGuideLookAndFeel; //Field offset: 0x48
	[SerializeField]
	private bool _isScaleGuideVisible; //Field offset: 0x50
	[SerializeField]
	private GizmoLineSlider3DLookAndFeel[] _sglSlidersLookAndFeel; //Field offset: 0x58
	[SerializeField]
	private GizmoPlaneSlider3DLookAndFeel[] _dblSlidersLookAndFeel; //Field offset: 0x60

	public float BoxSliderDepth
	{
		 get { } //Length: 49
	}

	public float BoxSliderHeight
	{
		 get { } //Length: 49
	}

	public float CylinderSliderRadius
	{
		 get { } //Length: 49
	}

	public float DblSliderFillAlpha
	{
		 get { } //Length: 49
	}

	public float DblSliderSize
	{
		 get { } //Length: 49
	}

	public Color HoveredColor
	{
		 get { } //Length: 58
	}

	public bool IsScaleGuideVisible
	{
		 get { } //Length: 5
	}

	public float MidCapBoxDepth
	{
		 get { } //Length: 28
	}

	public float MidCapBoxHeight
	{
		 get { } //Length: 28
	}

	public float MidCapBoxWidth
	{
		 get { } //Length: 28
	}

	public Color MidCapColor
	{
		 get { } //Length: 33
	}

	public GizmoFillMode3D MidCapFillMode
	{
		 get { } //Length: 26
	}

	public GizmoShadeMode MidCapShadeMode
	{
		 get { } //Length: 26
	}

	public float MidCapSphereRadius
	{
		 get { } //Length: 28
	}

	public GizmoCap3DType MidCapType
	{
		 get { } //Length: 26
	}

	public float Scale
	{
		 get { } //Length: 28
	}

	public float ScaleGuideAxisLength
	{
		 get { } //Length: 28
	}

	public float SliderBoxCapDepth
	{
		 get { } //Length: 58
	}

	public float SliderBoxCapHeight
	{
		 get { } //Length: 58
	}

	public float SliderBoxCapWidth
	{
		 get { } //Length: 58
	}

	public GizmoFillMode3D SliderCapFillMode
	{
		 get { } //Length: 56
	}

	public GizmoShadeMode SliderCapShadeMode
	{
		 get { } //Length: 56
	}

	public GizmoCap3DType SliderCapType
	{
		 get { } //Length: 56
	}

	public float SliderConeCapBaseRadius
	{
		 get { } //Length: 58
	}

	public float SliderConeCapHeight
	{
		 get { } //Length: 58
	}

	public GizmoFillMode3D SliderFillMode
	{
		 get { } //Length: 47
	}

	public float SliderLength
	{
		 get { } //Length: 49
	}

	public GizmoLine3DType SliderLineType
	{
		 get { } //Length: 47
	}

	public float SliderPyramidCapDepth
	{
		 get { } //Length: 58
	}

	public float SliderPyramidCapHeight
	{
		 get { } //Length: 58
	}

	public float SliderPyramidCapWidth
	{
		 get { } //Length: 58
	}

	public GizmoShadeMode SliderShadeMode
	{
		 get { } //Length: 47
	}

	public float SliderSphereCapRadius
	{
		 get { } //Length: 58
	}

	public float SliderTriPrismCapDepth
	{
		 get { } //Length: 58
	}

	public float SliderTriPrismCapHeight
	{
		 get { } //Length: 58
	}

	public float SliderTriPrismCapWidth
	{
		 get { } //Length: 58
	}

	public bool UseZoomFactor
	{
		 get { } //Length: 27
	}

	public Color XColor
	{
		 get { } //Length: 58
	}

	public Color YColor
	{
		 get { } //Length: 58
	}

	public Color ZColor
	{
		 get { } //Length: 58
	}

	public ScaleGizmoLookAndFeel3D() { }

	public void ConnectDblSliderLookAndFeel(GizmoPlaneSlider3D slider, PlaneId planeId) { }

	public void ConnectGizmoScaleGuideLookAndFeel(GizmoScaleGuide scaleGuide) { }

	public void ConnectMidCapLookAndFeel(GizmoCap3D cap) { }

	public void ConnectSliderLookAndFeel(GizmoLineSlider3D slider, int axisIndex, AxisSign axisSign) { }

	public float get_BoxSliderDepth() { }

	public float get_BoxSliderHeight() { }

	public float get_CylinderSliderRadius() { }

	public float get_DblSliderFillAlpha() { }

	public float get_DblSliderSize() { }

	public Color get_HoveredColor() { }

	public bool get_IsScaleGuideVisible() { }

	public float get_MidCapBoxDepth() { }

	public float get_MidCapBoxHeight() { }

	public float get_MidCapBoxWidth() { }

	public Color get_MidCapColor() { }

	public GizmoFillMode3D get_MidCapFillMode() { }

	public GizmoShadeMode get_MidCapShadeMode() { }

	public float get_MidCapSphereRadius() { }

	public GizmoCap3DType get_MidCapType() { }

	public float get_Scale() { }

	public float get_ScaleGuideAxisLength() { }

	public float get_SliderBoxCapDepth() { }

	public float get_SliderBoxCapHeight() { }

	public float get_SliderBoxCapWidth() { }

	public GizmoFillMode3D get_SliderCapFillMode() { }

	public GizmoShadeMode get_SliderCapShadeMode() { }

	public GizmoCap3DType get_SliderCapType() { }

	public float get_SliderConeCapBaseRadius() { }

	public float get_SliderConeCapHeight() { }

	public GizmoFillMode3D get_SliderFillMode() { }

	public float get_SliderLength() { }

	public GizmoLine3DType get_SliderLineType() { }

	public float get_SliderPyramidCapDepth() { }

	public float get_SliderPyramidCapHeight() { }

	public float get_SliderPyramidCapWidth() { }

	public GizmoShadeMode get_SliderShadeMode() { }

	public float get_SliderSphereCapRadius() { }

	public float get_SliderTriPrismCapDepth() { }

	public float get_SliderTriPrismCapHeight() { }

	public float get_SliderTriPrismCapWidth() { }

	public bool get_UseZoomFactor() { }

	public Color get_XColor() { }

	public Color get_YColor() { }

	public Color get_ZColor() { }

	public List<Enum> GetAllowedMidCapTypes() { }

	private GizmoPlaneSlider3DLookAndFeel GetDblSliderLookAndFeel(PlaneId planeId) { }

	private GizmoLineSlider3DLookAndFeel GetSglSliderLookAndFeel(int axisIndex, AxisSign axisSign) { }

	public bool IsDblSliderVisible(PlaneId planeId) { }

	public bool IsMidCapTypeAllowed(GizmoCap3DType capType) { }

	public bool IsNegativeSliderCapVisible(int axisIndex) { }

	public bool IsNegativeSliderVisible(int axisIndex) { }

	public bool IsPositiveSliderCapVisible(int axisIndex) { }

	public bool IsPositiveSliderVisible(int axisIndex) { }

	public bool IsSliderCapVisible(int axisIndex, AxisSign axisSign) { }

	public bool IsSliderVisible(int axisIndex, AxisSign axisSign) { }

	public void SetAxisColor(int axisIndex, Color color) { }

	public void SetBoxSliderDepth(float depth) { }

	public void SetBoxSliderHeight(float height) { }

	public void SetCylinderSliderRadius(float radius) { }

	public void SetDblSliderFillAlpha(float alpha) { }

	public void SetDblSliderSize(float size) { }

	public void SetDblSliderVisible(PlaneId planeId, bool isVisible) { }

	public void SetHoveredColor(Color hoveredColor) { }

	public void SetMidCapBoxDepth(float depth) { }

	public void SetMidCapBoxHeight(float height) { }

	public void SetMidCapBoxWidth(float width) { }

	public void SetMidCapColor(Color color) { }

	public void SetMidCapFillMode(GizmoFillMode3D fillMode) { }

	public void SetMidCapShadeMode(GizmoShadeMode shadeMode) { }

	public void SetMidCapSphereRadius(float radius) { }

	public void SetMidCapType(GizmoCap3DType capType) { }

	public void SetNegativeCapVisible(int axisIndex, bool isVisible) { }

	public void SetNegativeSliderVisible(int axisIndex, bool isVisible) { }

	public void SetPositiveCapVisible(int axisIndex, bool isVisible) { }

	public void SetPositiveSliderVisible(int axisIndex, bool isVisible) { }

	public void SetScale(float scale) { }

	public void SetScaleGuideAxisLength(float length) { }

	public void SetScaleGuideVisible(bool isVisible) { }

	public void SetSliderBoxCapDepth(float depth) { }

	public void SetSliderBoxCapHeight(float height) { }

	public void SetSliderBoxCapWidth(float width) { }

	public void SetSliderCapFillMode(GizmoFillMode3D fillMode) { }

	public void SetSliderCapShadeMode(GizmoShadeMode shadeMode) { }

	public void SetSliderCapType(GizmoCap3DType capType) { }

	public void SetSliderCapVisible(int axisIndex, AxisSign axisSign, bool isVisible) { }

	public void SetSliderConeCapBaseRadius(float radius) { }

	public void SetSliderConeCapHeight(float height) { }

	public void SetSliderFillMode(GizmoFillMode3D fillMode) { }

	public void SetSliderLength(float axisLength) { }

	public void SetSliderLineType(GizmoLine3DType lineType) { }

	public void SetSliderPyramidCapDepth(float depth) { }

	public void SetSliderPyramidCapHeight(float height) { }

	public void SetSliderPyramidCapWidth(float width) { }

	public void SetSliderShadeMode(GizmoShadeMode shadeMode) { }

	public void SetSliderSphereCapRadius(float radius) { }

	public void SetSliderTriPrismCapDepth(float depth) { }

	public void SetSliderTriPrismCapHeight(float height) { }

	public void SetSliderTriPrismCapWidth(float width) { }

	public void SetSliderVisible(int axisIndex, AxisSign axisSign, bool isVisible) { }

	public void SetUseZoomFactor(bool useZoomFactor) { }

}

