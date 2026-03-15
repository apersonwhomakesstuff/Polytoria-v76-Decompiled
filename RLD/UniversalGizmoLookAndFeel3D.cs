namespace RLD;

public class UniversalGizmoLookAndFeel3D : Settings
{
	[SerializeField]
	private UniversalGizmoSettingsCategory _displayCategory; //Field offset: 0x28
	[SerializeField]
	private GizmoCap2DLookAndFeel _mvVertSnapCapLookAndFeel; //Field offset: 0x30
	[SerializeField]
	private Boolean[] _mvSglSliderVis; //Field offset: 0x38
	[SerializeField]
	private Boolean[] _mvSglSliderCapVis; //Field offset: 0x40
	[SerializeField]
	private Boolean[] _mvDblSliderVis; //Field offset: 0x48
	[SerializeField]
	private GizmoLineSlider3DLookAndFeel[] _mvSglSlidersLookAndFeel; //Field offset: 0x50
	[SerializeField]
	private GizmoPlaneSlider3DLookAndFeel[] _mvDblSlidersLookAndFeel; //Field offset: 0x58
	[SerializeField]
	private bool _isRtMidCapVisible; //Field offset: 0x60
	[SerializeField]
	private GizmoCap3DLookAndFeel _rtMidCapLookAndFeel; //Field offset: 0x68
	[SerializeField]
	private Boolean[] _rtAxesVis; //Field offset: 0x70
	[SerializeField]
	private GizmoPlaneSlider3DLookAndFeel[] _rtAxesLookAndFeel; //Field offset: 0x78
	[SerializeField]
	private bool _isRtCamLookSliderVisible; //Field offset: 0x80
	[SerializeField]
	private float _rtCamLookSliderRadiusOffset; //Field offset: 0x84
	[SerializeField]
	private GizmoPlaneSlider2DLookAndFeel _rtCamLookSliderLookAndFeel; //Field offset: 0x88
	[SerializeField]
	private GizmoCap3DLookAndFeel _scMidCapLookAndFeel; //Field offset: 0x90
	[SerializeField]
	private Boolean[] _scSglSliderVis; //Field offset: 0x98
	[SerializeField]
	private Boolean[] _scSglSliderCapVis; //Field offset: 0xA0
	[SerializeField]
	private Boolean[] _scDblSliderVis; //Field offset: 0xA8
	[SerializeField]
	private bool _isScMidCapVisible; //Field offset: 0xB0
	[SerializeField]
	private GizmoScaleGuideLookAndFeel _scScaleGuideLookAndFeel; //Field offset: 0xB8
	[SerializeField]
	private bool _isScScaleGuideVisible; //Field offset: 0xC0
	[SerializeField]
	private GizmoLineSlider3DLookAndFeel[] _scSglSlidersLookAndFeel; //Field offset: 0xC8
	[SerializeField]
	private GizmoPlaneSlider3DLookAndFeel[] _scDblSlidersLookAndFeel; //Field offset: 0xD0

	public UniversalGizmoSettingsCategory DisplayCategory
	{
		 get { } //Length: 4
		 set { } //Length: 4
	}

	public bool IsRtCamLookSliderVisible
	{
		 get { } //Length: 8
	}

	public bool IsRtMidCapBorderVisible
	{
		 get { } //Length: 27
	}

	public bool IsRtMidCapVisible
	{
		 get { } //Length: 5
	}

	public bool IsRtRotationArcVisible
	{
		 get { } //Length: 51
	}

	public bool IsScMidCapVisible
	{
		 get { } //Length: 8
	}

	public bool IsScScaleGuideVisible
	{
		 get { } //Length: 8
	}

	public float MvBoxSliderDepth
	{
		 get { } //Length: 49
	}

	public float MvBoxSliderHeight
	{
		 get { } //Length: 49
	}

	public float MvCylinderSliderRadius
	{
		 get { } //Length: 49
	}

	public float MvDblSliderBorderBoxDepth
	{
		 get { } //Length: 49
	}

	public float MvDblSliderBorderBoxHeight
	{
		 get { } //Length: 49
	}

	public GizmoFillMode3D MvDblSliderBorderFillMode
	{
		 get { } //Length: 50
	}

	public GizmoShadeMode MvDblSliderBorderShadeMode
	{
		 get { } //Length: 50
	}

	public GizmoQuad3DBorderType MvDblSliderBorderType
	{
		 get { } //Length: 50
	}

	public float MvDblSliderFillAlpha
	{
		 get { } //Length: 49
	}

	public float MvDblSliderSize
	{
		 get { } //Length: 49
	}

	public Color MvHoveredColor
	{
		 get { } //Length: 58
	}

	public Color MvNXColor
	{
		 get { } //Length: 58
	}

	public Color MvNYColor
	{
		 get { } //Length: 58
	}

	public Color MvNZColor
	{
		 get { } //Length: 58
	}

	public Color MvPXColor
	{
		 get { } //Length: 58
	}

	public Color MvPYColor
	{
		 get { } //Length: 58
	}

	public Color MvPZColor
	{
		 get { } //Length: 58
	}

	public float MvScale
	{
		 get { } //Length: 49
	}

	public float MvSliderBoxCapDepth
	{
		 get { } //Length: 58
	}

	public float MvSliderBoxCapHeight
	{
		 get { } //Length: 58
	}

	public float MvSliderBoxCapWidth
	{
		 get { } //Length: 58
	}

	public GizmoFillMode3D MvSliderCapFillMode
	{
		 get { } //Length: 56
	}

	public GizmoShadeMode MvSliderCapShadeMode
	{
		 get { } //Length: 56
	}

	public GizmoCap3DType MvSliderCapType
	{
		 get { } //Length: 56
	}

	public float MvSliderConeCapBaseRadius
	{
		 get { } //Length: 58
	}

	public float MvSliderConeCapHeight
	{
		 get { } //Length: 58
	}

	public GizmoFillMode3D MvSliderFillMode
	{
		 get { } //Length: 47
	}

	public float MvSliderLength
	{
		 get { } //Length: 49
	}

	public GizmoLine3DType MvSliderLineType
	{
		 get { } //Length: 47
	}

	public float MvSliderPyramidCapDepth
	{
		 get { } //Length: 58
	}

	public float MvSliderPyramidCapHeight
	{
		 get { } //Length: 58
	}

	public float MvSliderPyramidCapWidth
	{
		 get { } //Length: 58
	}

	public GizmoShadeMode MvSliderShadeMode
	{
		 get { } //Length: 47
	}

	public float MvSliderSphereCapRadius
	{
		 get { } //Length: 58
	}

	public float MvSliderTriPrismCapDepth
	{
		 get { } //Length: 58
	}

	public float MvSliderTriPrismCapHeight
	{
		 get { } //Length: 58
	}

	public float MvSliderTriPrismCapWidth
	{
		 get { } //Length: 58
	}

	public bool MvUseZoomFactor
	{
		 get { } //Length: 48
	}

	public Color MvVertSnapCapBorderColor
	{
		 get { } //Length: 33
	}

	public float MvVertSnapCapCircleRadius
	{
		 get { } //Length: 28
	}

	public Color MvVertSnapCapColor
	{
		 get { } //Length: 33
	}

	public GizmoFillMode2D MvVertSnapCapFillMode
	{
		 get { } //Length: 26
	}

	public Color MvVertSnapCapHoveredBorderColor
	{
		 get { } //Length: 33
	}

	public Color MvVertSnapCapHoveredColor
	{
		 get { } //Length: 33
	}

	public float MvVertSnapCapQuadHeight
	{
		 get { } //Length: 28
	}

	public float MvVertSnapCapQuadWidth
	{
		 get { } //Length: 28
	}

	public GizmoCap2DType MvVertSnapCapType
	{
		 get { } //Length: 26
	}

	public GizmoFillMode3D RtAxisBorderFillMode
	{
		 get { } //Length: 50
	}

	public GizmoCircle3DBorderType RtAxisBorderType
	{
		 get { } //Length: 50
	}

	public float RtAxisCullAlphaScale
	{
		 get { } //Length: 52
	}

	public float RtAxisCylTorusHeight
	{
		 get { } //Length: 49
	}

	public float RtAxisCylTorusWidth
	{
		 get { } //Length: 49
	}

	public float RtAxisTorusThickness
	{
		 get { } //Length: 49
	}

	public Color RtCamLookSliderBorderColor
	{
		 get { } //Length: 36
	}

	public Color RtCamLookSliderHoveredBorderColor
	{
		 get { } //Length: 36
	}

	public float RtCamLookSliderPolyBorderThickness
	{
		 get { } //Length: 34
	}

	public GizmoPolygon2DBorderType RtCamLookSliderPolyBorderType
	{
		 get { } //Length: 32
	}

	public float RtCamLookSliderRadiusOffset
	{
		 get { } //Length: 9
	}

	public Color RtHoveredColor
	{
		 get { } //Length: 58
	}

	public Color RtHoveredMidCapColor
	{
		 get { } //Length: 33
	}

	public Color RtMidCapColor
	{
		 get { } //Length: 33
	}

	public int RtNumAxisTorusWireAxialSlices
	{
		 get { } //Length: 47
	}

	public float RtRadius
	{
		 get { } //Length: 28
	}

	public Color RtRotationArcBorderColor
	{
		 get { } //Length: 70
	}

	public Color RtRotationArcColor
	{
		 get { } //Length: 70
	}

	public float RtScale
	{
		 get { } //Length: 28
	}

	public GizmoShadeMode RtShadeMode
	{
		 get { } //Length: 26
	}

	public bool RtUseShortestRotationArc
	{
		 get { } //Length: 60
	}

	public bool RtUseZoomFactor
	{
		 get { } //Length: 27
	}

	public Color RtXBorderColor
	{
		 get { } //Length: 58
	}

	public Color RtYBorderColor
	{
		 get { } //Length: 58
	}

	public Color RtZBorderColor
	{
		 get { } //Length: 58
	}

	public float ScBoxSliderDepth
	{
		 get { } //Length: 52
	}

	public float ScBoxSliderHeight
	{
		 get { } //Length: 52
	}

	public float ScCylinderSliderRadius
	{
		 get { } //Length: 52
	}

	public float ScDblSliderFillAlpha
	{
		 get { } //Length: 52
	}

	public float ScDblSliderSize
	{
		 get { } //Length: 52
	}

	public Color ScHoveredColor
	{
		 get { } //Length: 61
	}

	public float ScMidCapBoxDepth
	{
		 get { } //Length: 31
	}

	public float ScMidCapBoxHeight
	{
		 get { } //Length: 31
	}

	public float ScMidCapBoxWidth
	{
		 get { } //Length: 31
	}

	public Color ScMidCapColor
	{
		 get { } //Length: 36
	}

	public GizmoFillMode3D ScMidCapFillMode
	{
		 get { } //Length: 29
	}

	public GizmoShadeMode ScMidCapShadeMode
	{
		 get { } //Length: 29
	}

	public float ScMidCapSphereRadius
	{
		 get { } //Length: 31
	}

	public GizmoCap3DType ScMidCapType
	{
		 get { } //Length: 29
	}

	public Color ScNXColor
	{
		 get { } //Length: 61
	}

	public Color ScNYColor
	{
		 get { } //Length: 61
	}

	public Color ScNZColor
	{
		 get { } //Length: 61
	}

	public Color ScPXColor
	{
		 get { } //Length: 61
	}

	public Color ScPYColor
	{
		 get { } //Length: 61
	}

	public Color ScPZColor
	{
		 get { } //Length: 61
	}

	public float ScScale
	{
		 get { } //Length: 31
	}

	public float ScScaleGuideAxisLength
	{
		 get { } //Length: 31
	}

	public float ScSliderBoxCapDepth
	{
		 get { } //Length: 61
	}

	public float ScSliderBoxCapHeight
	{
		 get { } //Length: 61
	}

	public float ScSliderBoxCapWidth
	{
		 get { } //Length: 61
	}

	public GizmoFillMode3D ScSliderCapFillMode
	{
		 get { } //Length: 59
	}

	public GizmoShadeMode ScSliderCapShadeMode
	{
		 get { } //Length: 59
	}

	public GizmoCap3DType ScSliderCapType
	{
		 get { } //Length: 59
	}

	public float ScSliderConeCapBaseRadius
	{
		 get { } //Length: 61
	}

	public float ScSliderConeCapHeight
	{
		 get { } //Length: 61
	}

	public GizmoFillMode3D ScSliderFillMode
	{
		 get { } //Length: 50
	}

	public float ScSliderLength
	{
		 get { } //Length: 52
	}

	public GizmoLine3DType ScSliderLineType
	{
		 get { } //Length: 50
	}

	public float ScSliderPyramidCapDepth
	{
		 get { } //Length: 61
	}

	public float ScSliderPyramidCapHeight
	{
		 get { } //Length: 61
	}

	public float ScSliderPyramidCapWidth
	{
		 get { } //Length: 61
	}

	public GizmoShadeMode ScSliderShadeMode
	{
		 get { } //Length: 50
	}

	public float ScSliderSphereCapRadius
	{
		 get { } //Length: 61
	}

	public float ScSliderTriPrismCapDepth
	{
		 get { } //Length: 61
	}

	public float ScSliderTriPrismCapHeight
	{
		 get { } //Length: 61
	}

	public float ScSliderTriPrismCapWidth
	{
		 get { } //Length: 61
	}

	public bool ScUseZoomFactor
	{
		 get { } //Length: 30
	}

	public UniversalGizmoLookAndFeel3D() { }

	public void ConnectMvDblSliderLookAndFeel(GizmoPlaneSlider3D dblSlider, PlaneId planeId) { }

	public void ConnectMvSliderLookAndFeel(GizmoLineSlider3D slider, int axisIndex, AxisSign axisSign) { }

	public void ConnectMvVertSnapCapLookAndFeel(GizmoCap2D vertSnapCap) { }

	public void ConnectRtCamLookSliderLookAndFeel(GizmoPlaneSlider2D slider) { }

	public void ConnectRtMidCapLookAndFeel(GizmoCap3D cap) { }

	public void ConnectRtSliderLookAndFeel(GizmoPlaneSlider3D slider, int axisIndex) { }

	public void ConnectScDblSliderLookAndFeel(GizmoPlaneSlider3D slider, PlaneId planeId) { }

	public void ConnectScGizmoScaleGuideLookAndFeel(GizmoScaleGuide scaleGuide) { }

	public void ConnectScMidCapLookAndFeel(GizmoCap3D cap) { }

	public void ConnectScSliderLookAndFeel(GizmoLineSlider3D slider, int axisIndex, AxisSign axisSign) { }

	public UniversalGizmoSettingsCategory get_DisplayCategory() { }

	public bool get_IsRtCamLookSliderVisible() { }

	public bool get_IsRtMidCapBorderVisible() { }

	public bool get_IsRtMidCapVisible() { }

	public bool get_IsRtRotationArcVisible() { }

	public bool get_IsScMidCapVisible() { }

	public bool get_IsScScaleGuideVisible() { }

	public float get_MvBoxSliderDepth() { }

	public float get_MvBoxSliderHeight() { }

	public float get_MvCylinderSliderRadius() { }

	public float get_MvDblSliderBorderBoxDepth() { }

	public float get_MvDblSliderBorderBoxHeight() { }

	public GizmoFillMode3D get_MvDblSliderBorderFillMode() { }

	public GizmoShadeMode get_MvDblSliderBorderShadeMode() { }

	public GizmoQuad3DBorderType get_MvDblSliderBorderType() { }

	public float get_MvDblSliderFillAlpha() { }

	public float get_MvDblSliderSize() { }

	public Color get_MvHoveredColor() { }

	public Color get_MvNXColor() { }

	public Color get_MvNYColor() { }

	public Color get_MvNZColor() { }

	public Color get_MvPXColor() { }

	public Color get_MvPYColor() { }

	public Color get_MvPZColor() { }

	public float get_MvScale() { }

	public float get_MvSliderBoxCapDepth() { }

	public float get_MvSliderBoxCapHeight() { }

	public float get_MvSliderBoxCapWidth() { }

	public GizmoFillMode3D get_MvSliderCapFillMode() { }

	public GizmoShadeMode get_MvSliderCapShadeMode() { }

	public GizmoCap3DType get_MvSliderCapType() { }

	public float get_MvSliderConeCapBaseRadius() { }

	public float get_MvSliderConeCapHeight() { }

	public GizmoFillMode3D get_MvSliderFillMode() { }

	public float get_MvSliderLength() { }

	public GizmoLine3DType get_MvSliderLineType() { }

	public float get_MvSliderPyramidCapDepth() { }

	public float get_MvSliderPyramidCapHeight() { }

	public float get_MvSliderPyramidCapWidth() { }

	public GizmoShadeMode get_MvSliderShadeMode() { }

	public float get_MvSliderSphereCapRadius() { }

	public float get_MvSliderTriPrismCapDepth() { }

	public float get_MvSliderTriPrismCapHeight() { }

	public float get_MvSliderTriPrismCapWidth() { }

	public bool get_MvUseZoomFactor() { }

	public Color get_MvVertSnapCapBorderColor() { }

	public float get_MvVertSnapCapCircleRadius() { }

	public Color get_MvVertSnapCapColor() { }

	public GizmoFillMode2D get_MvVertSnapCapFillMode() { }

	public Color get_MvVertSnapCapHoveredBorderColor() { }

	public Color get_MvVertSnapCapHoveredColor() { }

	public float get_MvVertSnapCapQuadHeight() { }

	public float get_MvVertSnapCapQuadWidth() { }

	public GizmoCap2DType get_MvVertSnapCapType() { }

	public GizmoFillMode3D get_RtAxisBorderFillMode() { }

	public GizmoCircle3DBorderType get_RtAxisBorderType() { }

	public float get_RtAxisCullAlphaScale() { }

	public float get_RtAxisCylTorusHeight() { }

	public float get_RtAxisCylTorusWidth() { }

	public float get_RtAxisTorusThickness() { }

	public Color get_RtCamLookSliderBorderColor() { }

	public Color get_RtCamLookSliderHoveredBorderColor() { }

	public float get_RtCamLookSliderPolyBorderThickness() { }

	public GizmoPolygon2DBorderType get_RtCamLookSliderPolyBorderType() { }

	public float get_RtCamLookSliderRadiusOffset() { }

	public Color get_RtHoveredColor() { }

	public Color get_RtHoveredMidCapColor() { }

	public Color get_RtMidCapColor() { }

	public int get_RtNumAxisTorusWireAxialSlices() { }

	public float get_RtRadius() { }

	public Color get_RtRotationArcBorderColor() { }

	public Color get_RtRotationArcColor() { }

	public float get_RtScale() { }

	public GizmoShadeMode get_RtShadeMode() { }

	public bool get_RtUseShortestRotationArc() { }

	public bool get_RtUseZoomFactor() { }

	public Color get_RtXBorderColor() { }

	public Color get_RtYBorderColor() { }

	public Color get_RtZBorderColor() { }

	public float get_ScBoxSliderDepth() { }

	public float get_ScBoxSliderHeight() { }

	public float get_ScCylinderSliderRadius() { }

	public float get_ScDblSliderFillAlpha() { }

	public float get_ScDblSliderSize() { }

	public Color get_ScHoveredColor() { }

	public float get_ScMidCapBoxDepth() { }

	public float get_ScMidCapBoxHeight() { }

	public float get_ScMidCapBoxWidth() { }

	public Color get_ScMidCapColor() { }

	public GizmoFillMode3D get_ScMidCapFillMode() { }

	public GizmoShadeMode get_ScMidCapShadeMode() { }

	public float get_ScMidCapSphereRadius() { }

	public GizmoCap3DType get_ScMidCapType() { }

	public Color get_ScNXColor() { }

	public Color get_ScNYColor() { }

	public Color get_ScNZColor() { }

	public Color get_ScPXColor() { }

	public Color get_ScPYColor() { }

	public Color get_ScPZColor() { }

	public float get_ScScale() { }

	public float get_ScScaleGuideAxisLength() { }

	public float get_ScSliderBoxCapDepth() { }

	public float get_ScSliderBoxCapHeight() { }

	public float get_ScSliderBoxCapWidth() { }

	public GizmoFillMode3D get_ScSliderCapFillMode() { }

	public GizmoShadeMode get_ScSliderCapShadeMode() { }

	public GizmoCap3DType get_ScSliderCapType() { }

	public float get_ScSliderConeCapBaseRadius() { }

	public float get_ScSliderConeCapHeight() { }

	public GizmoFillMode3D get_ScSliderFillMode() { }

	public float get_ScSliderLength() { }

	public GizmoLine3DType get_ScSliderLineType() { }

	public float get_ScSliderPyramidCapDepth() { }

	public float get_ScSliderPyramidCapHeight() { }

	public float get_ScSliderPyramidCapWidth() { }

	public GizmoShadeMode get_ScSliderShadeMode() { }

	public float get_ScSliderSphereCapRadius() { }

	public float get_ScSliderTriPrismCapDepth() { }

	public float get_ScSliderTriPrismCapHeight() { }

	public float get_ScSliderTriPrismCapWidth() { }

	public bool get_ScUseZoomFactor() { }

	public List<Enum> GetAllowedMvVertSnapCapTypes() { }

	public List<Enum> GetAllowedScMidCapTypes() { }

	private GizmoPlaneSlider3DLookAndFeel GetMvDblSliderLookAndFeel(PlaneId planeId) { }

	private GizmoLineSlider3DLookAndFeel GetMvSglSliderLookAndFeel(int axisIndex, AxisSign axisSign) { }

	private GizmoPlaneSlider3DLookAndFeel GetScDblSliderLookAndFeel(PlaneId planeId) { }

	private GizmoLineSlider3DLookAndFeel GetScSglSliderLookAndFeel(int axisIndex, AxisSign axisSign) { }

	public void Inherit(MoveGizmoLookAndFeel3D lookAndFeel) { }

	public void Inherit(RotationGizmoLookAndFeel3D lookAndFeel) { }

	public void Inherit(ScaleGizmoLookAndFeel3D lookAndFeel) { }

	public bool IsMvDblSliderVisible(PlaneId planeId) { }

	public bool IsMvNegativeSliderCapVisible(int axisIndex) { }

	public bool IsMvNegativeSliderVisible(int axisIndex) { }

	public bool IsMvPositiveSliderCapVisible(int axisIndex) { }

	public bool IsMvPositiveSliderVisible(int axisIndex) { }

	public bool IsMvSliderCapVisible(int axisIndex, AxisSign axisSign) { }

	public bool IsMvSliderVisible(int axisIndex, AxisSign axisSign) { }

	public bool IsMvVertSnapCapTypeAllowed(GizmoCap2DType capType) { }

	public bool IsRtAxisVisible(int axisIndex) { }

	public bool IsScDblSliderVisible(PlaneId planeId) { }

	public bool IsScMidCapTypeAllowed(GizmoCap3DType capType) { }

	public bool IsScNegativeSliderCapVisible(int axisIndex) { }

	public bool IsScNegativeSliderVisible(int axisIndex) { }

	public bool IsScPositiveSliderCapVisible(int axisIndex) { }

	public bool IsScPositiveSliderVisible(int axisIndex) { }

	public bool IsScSliderCapVisible(int axisIndex, AxisSign axisSign) { }

	public bool IsScSliderVisible(int axisIndex, AxisSign axisSign) { }

	public void set_DisplayCategory(UniversalGizmoSettingsCategory value) { }

	public void SetMvAxisColor(int axisIndex, Color color) { }

	public void SetMvBoxSliderDepth(float depth) { }

	public void SetMvBoxSliderHeight(float height) { }

	public void SetMvCylinderSliderRadius(float radius) { }

	public void SetMvDblSliderBorderBoxDepth(float depth) { }

	public void SetMvDblSliderBorderBoxHeight(float height) { }

	public void SetMvDblSliderBorderFillMode(GizmoFillMode3D fillMode) { }

	public void SetMvDblSliderBorderShadeMode(GizmoShadeMode shadeMode) { }

	public void SetMvDblSliderBorderType(GizmoQuad3DBorderType borderType) { }

	public void SetMvDblSliderFillAlpha(float alpha) { }

	public void SetMvDblSliderSize(float size) { }

	public void SetMvDblSliderVisible(PlaneId planeId, bool isVisible) { }

	public void SetMvHoveredColor(Color hoveredColor) { }

	public void SetMvNegativeSliderCapVisible(int axisIndex, bool isVisible) { }

	public void SetMvNegativeSliderVisible(int axisIndex, bool isVisible) { }

	public void SetMvPositiveSliderCapVisible(int axisIndex, bool isVisible) { }

	public void SetMvPositiveSliderVisible(int axisIndex, bool isVisible) { }

	public void SetMvScale(float scale) { }

	public void SetMvSliderBoxCapDepth(float depth) { }

	public void SetMvSliderBoxCapHeight(float height) { }

	public void SetMvSliderBoxCapWidth(float width) { }

	public void SetMvSliderCapFillMode(GizmoFillMode3D fillMode) { }

	public void SetMvSliderCapShadeMode(GizmoShadeMode shadeMode) { }

	public void SetMvSliderCapType(GizmoCap3DType capType) { }

	public void SetMvSliderCapVisible(int axisIndex, AxisSign axisSign, bool isVisible) { }

	public void SetMvSliderConeCapBaseRadius(float radius) { }

	public void SetMvSliderConeCapHeight(float height) { }

	public void SetMvSliderFillMode(GizmoFillMode3D fillMode) { }

	public void SetMvSliderLength(float axisLength) { }

	public void SetMvSliderLineType(GizmoLine3DType lineType) { }

	public void SetMvSliderPyramidCapDepth(float depth) { }

	public void SetMvSliderPyramidCapHeight(float height) { }

	public void SetMvSliderPyramidCapWidth(float width) { }

	public void SetMvSliderShadeMode(GizmoShadeMode shadeMode) { }

	public void SetMvSliderSphereCapRadius(float radius) { }

	public void SetMvSliderTriPrismCapDepth(float depth) { }

	public void SetMvSliderTriPrismCapHeight(float height) { }

	public void SetMvSliderTriPrismCapWidth(float width) { }

	public void SetMvSliderVisible(int axisIndex, AxisSign axisSign, bool isVisible) { }

	public void SetMvUseZoomFactor(bool useZoomFactor) { }

	public void SetMvVertSnapCapBorderColor(Color color) { }

	public void SetMvVertSnapCapCircleRadius(float radius) { }

	public void SetMvVertSnapCapColor(Color color) { }

	public void SetMvVertSnapCapFillMode(GizmoFillMode2D fillMode) { }

	public void SetMvVertSnapCapHoveredBorderColor(Color color) { }

	public void SetMvVertSnapCapHoveredColor(Color color) { }

	public void SetMvVertSnapCapQuadHeight(float height) { }

	public void SetMvVertSnapCapQuadWidth(float width) { }

	public void SetMvVertSnapCapType(GizmoCap2DType capType) { }

	public void SetRtAxisBorderColor(int axisIndex, Color color) { }

	public void SetRtAxisBorderCullAlphaScale(float scale) { }

	public void SetRtAxisBorderFillMode(GizmoFillMode3D fillMode) { }

	public void SetRtAxisBorderType(GizmoCircle3DBorderType borderType) { }

	public void SetRtAxisCylTorusHeight(float height) { }

	public void SetRtAxisCylTorusWidth(float width) { }

	public void SetRtAxisTorusThickness(float thickness) { }

	public void SetRtAxisVisible(int axisIndex, bool isVisible) { }

	public void SetRtCamLookSliderBorderColor(Color color) { }

	public void SetRtCamLookSliderHoveredBorderColor(Color color) { }

	public void SetRtCamLookSliderPolyBorderThickness(float thickness) { }

	public void SetRtCamLookSliderPolyBorderType(GizmoPolygon2DBorderType polyBorderType) { }

	public void SetRtCamLookSliderRadiusOffset(float offset) { }

	public void SetRtCamLookSliderVisible(bool isVisible) { }

	public void SetRtHoveredColor(Color hoveredColor) { }

	public void SetRtHoveredMidCapColor(Color color) { }

	public void SetRtMidCapBorderColor(Color color) { }

	public void SetRtMidCapBorderVisible(bool isVisible) { }

	public void SetRtMidCapColor(Color color) { }

	public void SetRtMidCapVisible(bool isVisible) { }

	public void SetRtNumAxisTorusWireAxialSlices(int numSlices) { }

	public void SetRtRadius(float radius) { }

	public void SetRtRotationArcBorderColor(Color color) { }

	public void SetRtRotationArcColor(Color color) { }

	public void SetRtRotationArcVisible(bool isVisible) { }

	public void SetRtScale(float scale) { }

	public void SetRtShadeMode(GizmoShadeMode shadeMode) { }

	public void SetRtUseShortestRotationArc(bool useShortest) { }

	public void SetRtUseZoomFactor(bool useZoomFactor) { }

	public void SetScAxisColor(int axisIndex, Color color) { }

	public void SetScBoxSliderDepth(float depth) { }

	public void SetScBoxSliderHeight(float height) { }

	public void SetScCylinderSliderRadius(float radius) { }

	public void SetScDblSliderFillAlpha(float alpha) { }

	public void SetScDblSliderSize(float size) { }

	public void SetScDblSliderVisible(PlaneId planeId, bool isVisible) { }

	public void SetScHoveredColor(Color hoveredColor) { }

	public void SetScMidCapBoxDepth(float depth) { }

	public void SetScMidCapBoxHeight(float height) { }

	public void SetScMidCapBoxWidth(float width) { }

	public void SetScMidCapColor(Color color) { }

	public void SetScMidCapFillMode(GizmoFillMode3D fillMode) { }

	public void SetScMidCapShadeMode(GizmoShadeMode shadeMode) { }

	public void SetScMidCapSphereRadius(float radius) { }

	public void SetScMidCapType(GizmoCap3DType capType) { }

	public void SetScMidCapVisible(bool visible) { }

	public void SetScNegativeSliderCapVisible(int axisIndex, bool isVisible) { }

	public void SetScNegativeSliderVisible(int axisIndex, bool isVisible) { }

	public void SetScPositiveSliderCapVisible(int axisIndex, bool isVisible) { }

	public void SetScPositiveSliderVisible(int axisIndex, bool isVisible) { }

	public void SetScScale(float scale) { }

	public void SetScScaleGuideAxisLength(float length) { }

	public void SetScScaleGuideVisible(bool isVisible) { }

	public void SetScSliderBoxCapDepth(float depth) { }

	public void SetScSliderBoxCapHeight(float height) { }

	public void SetScSliderBoxCapWidth(float width) { }

	public void SetScSliderCapFillMode(GizmoFillMode3D fillMode) { }

	public void SetScSliderCapShadeMode(GizmoShadeMode shadeMode) { }

	public void SetScSliderCapType(GizmoCap3DType capType) { }

	public void SetScSliderCapVisible(int axisIndex, AxisSign axisSign, bool isVisible) { }

	public void SetScSliderConeCapBaseRadius(float radius) { }

	public void SetScSliderConeCapHeight(float height) { }

	public void SetScSliderFillMode(GizmoFillMode3D fillMode) { }

	public void SetScSliderLength(float axisLength) { }

	public void SetScSliderLineType(GizmoLine3DType lineType) { }

	public void SetScSliderPyramidCapDepth(float depth) { }

	public void SetScSliderPyramidCapHeight(float height) { }

	public void SetScSliderPyramidCapWidth(float width) { }

	public void SetScSliderShadeMode(GizmoShadeMode shadeMode) { }

	public void SetScSliderSphereCapRadius(float radius) { }

	public void SetScSliderTriPrismCapDepth(float depth) { }

	public void SetScSliderTriPrismCapHeight(float height) { }

	public void SetScSliderTriPrismCapWidth(float width) { }

	public void SetScSliderVisible(int axisIndex, AxisSign axisSign, bool isVisible) { }

	public void SetScUseZoomFactor(bool useZoomFactor) { }

}

