namespace RLD;

public class RotationGizmoLookAndFeel3D : Settings
{
	[SerializeField]
	private bool _isMidCapVisible; //Field offset: 0x28
	[SerializeField]
	private GizmoCap3DLookAndFeel _midCapLookAndFeel; //Field offset: 0x30
	[SerializeField]
	private Boolean[] _axesVis; //Field offset: 0x38
	[SerializeField]
	private GizmoPlaneSlider3DLookAndFeel[] _axesLookAndFeel; //Field offset: 0x40
	[SerializeField]
	private bool _isCamLookSliderVisible; //Field offset: 0x48
	[SerializeField]
	private float _camLookSliderRadiusOffset; //Field offset: 0x4C
	[SerializeField]
	private GizmoPlaneSlider2DLookAndFeel _camLookSliderLookAndFeel; //Field offset: 0x50

	public GizmoFillMode3D AxisBorderFillMode
	{
		 get { } //Length: 50
	}

	public GizmoCircle3DBorderType AxisBorderType
	{
		 get { } //Length: 50
	}

	public float AxisCullAlphaScale
	{
		 get { } //Length: 52
	}

	public float AxisCylTorusHeight
	{
		 get { } //Length: 49
	}

	public float AxisCylTorusWidth
	{
		 get { } //Length: 49
	}

	public float AxisTorusThickness
	{
		 get { } //Length: 49
	}

	public Color CamLookSliderBorderColor
	{
		 get { } //Length: 33
	}

	public Color CamLookSliderHoveredBorderColor
	{
		 get { } //Length: 33
	}

	public float CamLookSliderPolyBorderThickness
	{
		 get { } //Length: 31
	}

	public GizmoPolygon2DBorderType CamLookSliderPolyBorderType
	{
		 get { } //Length: 29
	}

	public float CamLookSliderRadiusOffset
	{
		 get { } //Length: 6
	}

	public Color HoveredColor
	{
		 get { } //Length: 58
	}

	public Color HoveredMidCapColor
	{
		 get { } //Length: 33
	}

	public bool IsCamLookSliderVisible
	{
		 get { } //Length: 5
	}

	public bool IsMidCapBorderVisible
	{
		 get { } //Length: 27
	}

	public bool IsMidCapVisible
	{
		 get { } //Length: 5
	}

	public bool IsRotationArcVisible
	{
		 get { } //Length: 51
	}

	public Color MidCapBorderColor
	{
		 get { } //Length: 33
	}

	public Color MidCapColor
	{
		 get { } //Length: 33
	}

	public int NumAxisTorusWireAxialSlices
	{
		 get { } //Length: 47
	}

	public float Radius
	{
		 get { } //Length: 28
	}

	public Color RotationArcBorderColor
	{
		 get { } //Length: 70
	}

	public Color RotationArcColor
	{
		 get { } //Length: 70
	}

	public float Scale
	{
		 get { } //Length: 28
	}

	public GizmoShadeMode ShadeMode
	{
		 get { } //Length: 26
	}

	public bool UseShortestRotationArc
	{
		 get { } //Length: 60
	}

	public bool UseZoomFactor
	{
		 get { } //Length: 27
	}

	public Color XBorderColor
	{
		 get { } //Length: 58
	}

	public Color YBorderColor
	{
		 get { } //Length: 58
	}

	public Color ZBorderColor
	{
		 get { } //Length: 58
	}

	public RotationGizmoLookAndFeel3D() { }

	public void ConnectCamLookSliderLookAndFeel(GizmoPlaneSlider2D slider) { }

	public void ConnectMidCapLookAndFeel(GizmoCap3D cap) { }

	public void ConnectSliderLookAndFeel(GizmoPlaneSlider3D slider, int axisIndex) { }

	public GizmoFillMode3D get_AxisBorderFillMode() { }

	public GizmoCircle3DBorderType get_AxisBorderType() { }

	public float get_AxisCullAlphaScale() { }

	public float get_AxisCylTorusHeight() { }

	public float get_AxisCylTorusWidth() { }

	public float get_AxisTorusThickness() { }

	public Color get_CamLookSliderBorderColor() { }

	public Color get_CamLookSliderHoveredBorderColor() { }

	public float get_CamLookSliderPolyBorderThickness() { }

	public GizmoPolygon2DBorderType get_CamLookSliderPolyBorderType() { }

	public float get_CamLookSliderRadiusOffset() { }

	public Color get_HoveredColor() { }

	public Color get_HoveredMidCapColor() { }

	public bool get_IsCamLookSliderVisible() { }

	public bool get_IsMidCapBorderVisible() { }

	public bool get_IsMidCapVisible() { }

	public bool get_IsRotationArcVisible() { }

	public Color get_MidCapBorderColor() { }

	public Color get_MidCapColor() { }

	public int get_NumAxisTorusWireAxialSlices() { }

	public float get_Radius() { }

	public Color get_RotationArcBorderColor() { }

	public Color get_RotationArcColor() { }

	public float get_Scale() { }

	public GizmoShadeMode get_ShadeMode() { }

	public bool get_UseShortestRotationArc() { }

	public bool get_UseZoomFactor() { }

	public Color get_XBorderColor() { }

	public Color get_YBorderColor() { }

	public Color get_ZBorderColor() { }

	public bool IsAxisVisible(int axisIndex) { }

	public void SetAxisBorderColor(int axisIndex, Color color) { }

	public void SetAxisBorderCullAlphaScale(float scale) { }

	public void SetAxisBorderFillMode(GizmoFillMode3D fillMode) { }

	public void SetAxisBorderType(GizmoCircle3DBorderType borderType) { }

	public void SetAxisCylTorusHeight(float height) { }

	public void SetAxisCylTorusWidth(float width) { }

	public void SetAxisTorusThickness(float thickness) { }

	public void SetAxisVisible(int axisIndex, bool isVisible) { }

	public void SetCamLookSliderBorderColor(Color color) { }

	public void SetCamLookSliderHoveredBorderColor(Color color) { }

	public void SetCamLookSliderPolyBorderThickness(float thickness) { }

	public void SetCamLookSliderPolyBorderType(GizmoPolygon2DBorderType polyBorderType) { }

	public void SetCamLookSliderRadiusOffset(float offset) { }

	public void SetCamLookSliderVisible(bool isVisible) { }

	public void SetHoveredColor(Color hoveredColor) { }

	public void SetHoveredMidCapColor(Color color) { }

	public void SetMidCapBorderColor(Color color) { }

	public void SetMidCapBorderVisible(bool isVisible) { }

	public void SetMidCapColor(Color color) { }

	public void SetMidCapVisible(bool isVisible) { }

	public void SetNumAxisTorusWireAxialSlices(int numSlices) { }

	public void SetRadius(float radius) { }

	public void SetRotationArcBorderColor(Color color) { }

	public void SetRotationArcColor(Color color) { }

	public void SetRotationArcVisible(bool isVisible) { }

	public void SetScale(float scale) { }

	public void SetShadeMode(GizmoShadeMode shadeMode) { }

	public void SetUseShortestRotationArc(bool useShortest) { }

	public void SetUseZoomFactor(bool useZoomFactor) { }

}

