namespace RLD;

public class ObjectExtrudeGizmoLookAndFeel3D : Settings
{
	[SerializeField]
	private Color _boxWireColor; //Field offset: 0x28
	[SerializeField]
	private GizmoLineSlider3DLookAndFeel[] _sglSlidersLookAndFeel; //Field offset: 0x38
	[SerializeField]
	private Boolean[] _extrudeSliderVis; //Field offset: 0x40

	public Color BoxWireColor
	{
		 get { } //Length: 11
	}

	public Color HoveredColor
	{
		 get { } //Length: 58
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
		 get { } //Length: 57
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

	public ObjectExtrudeGizmoLookAndFeel3D() { }

	public void ConnectSliderLookAndFeel(GizmoLineSlider3D slider, int axisIndex, AxisSign axisSign) { }

	public Color get_BoxWireColor() { }

	public Color get_HoveredColor() { }

	public float get_SliderBoxCapDepth() { }

	public float get_SliderBoxCapHeight() { }

	public float get_SliderBoxCapWidth() { }

	public GizmoFillMode3D get_SliderCapFillMode() { }

	public GizmoShadeMode get_SliderCapShadeMode() { }

	public GizmoCap3DType get_SliderCapType() { }

	public float get_SliderConeCapBaseRadius() { }

	public float get_SliderConeCapHeight() { }

	public float get_SliderPyramidCapDepth() { }

	public float get_SliderPyramidCapHeight() { }

	public float get_SliderPyramidCapWidth() { }

	public float get_SliderSphereCapRadius() { }

	public float get_SliderTriPrismCapDepth() { }

	public float get_SliderTriPrismCapHeight() { }

	public float get_SliderTriPrismCapWidth() { }

	public bool get_UseZoomFactor() { }

	public Color get_XColor() { }

	public Color get_YColor() { }

	public Color get_ZColor() { }

	private GizmoLineSlider3DLookAndFeel GetSglSliderLookAndFeel(int axisIndex, AxisSign axisSign) { }

	public bool IsExtrudeSliderVisible(int axisIndex, AxisSign axisSign) { }

	public void SetAxisColor(int axisIndex, Color color) { }

	public void SetBoxWireColor(Color color) { }

	public void SetExtrudeSliderVisible(int axisIndex, AxisSign axisSign, bool isVisible) { }

	public void SetHoveredColor(Color hoveredColor) { }

	public void SetSliderBoxCapDepth(float depth) { }

	public void SetSliderBoxCapHeight(float height) { }

	public void SetSliderBoxCapWidth(float width) { }

	public void SetSliderCapFillMode(GizmoFillMode3D fillMode) { }

	public void SetSliderCapShadeMode(GizmoShadeMode shadeMode) { }

	public void SetSliderCapType(GizmoCap3DType capType) { }

	public void SetSliderConeCapBaseRadius(float radius) { }

	public void SetSliderConeCapHeight(float height) { }

	public void SetSliderPyramidCapDepth(float depth) { }

	public void SetSliderPyramidCapHeight(float height) { }

	public void SetSliderPyramidCapWidth(float width) { }

	public void SetSliderSphereCapRadius(float radius) { }

	public void SetSliderTriPrismCapDepth(float depth) { }

	public void SetSliderTriPrismCapHeight(float height) { }

	public void SetSliderTriPrismCapWidth(float width) { }

	public void SetUseZoomFactor(bool useZoomFactor) { }

}

