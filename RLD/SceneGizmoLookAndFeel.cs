namespace RLD;

public class SceneGizmoLookAndFeel : Settings
{
	private static readonly float _baseScreenSize; //Field offset: 0x0
	private static readonly float _invBaseScreenSize; //Field offset: 0x4
	[SerializeField]
	private GizmoCap3DLookAndFeel _midCapLookAndFeel; //Field offset: 0x28
	[SerializeField]
	private GizmoCap3DLookAndFeel[] _axesCapsLookAndFeel; //Field offset: 0x30
	[SerializeField]
	private SceneGizmoScreenCorner _screenCorner; //Field offset: 0x38
	[SerializeField]
	private Vector2 _screenOffset; //Field offset: 0x3C
	[SerializeField]
	private float _screenSize; //Field offset: 0x44
	[SerializeField]
	private Color _axesLabelTint; //Field offset: 0x48
	[SerializeField]
	private Color _camPrjSwitchLabelTint; //Field offset: 0x58
	[SerializeField]
	private bool _isCamPrjSwitchLabelVisible; //Field offset: 0x68

	public GizmoCap3DType AxesCapType
	{
		 get { } //Length: 47
	}

	public Color AxesLabelTint
	{
		 get { } //Length: 11
		 set { } //Length: 8
	}

	public float AxisCamAlignFadeOutAlpha
	{
		 get { } //Length: 4
	}

	public float AxisCamAlignFadeOutDuration
	{
		 get { } //Length: 9
	}

	public float AxisCamAlignFadeOutThreshold
	{
		 get { } //Length: 9
	}

	private GizmoCap3DLookAndFeel AxisCapLookAndFeel
	{
		private get { } //Length: 39
	}

	public float AxisConeHeight
	{
		 get { } //Length: 128
	}

	public float AxisConeRadius
	{
		 get { } //Length: 128
	}

	public float AxisLabelScreenSize
	{
		 get { } //Length: 112
	}

	public float AxisPyramidDepth
	{
		 get { } //Length: 128
	}

	public float AxisPyramidHeight
	{
		 get { } //Length: 128
	}

	public float AxisPyramidWidth
	{
		 get { } //Length: 128
	}

	public Texture2D CamOrthoModeLabelTexture
	{
		 get { } //Length: 101
	}

	public Texture2D CamPerspModeLabelTexture
	{
		 get { } //Length: 101
	}

	public Color CamPrjSwitchLabelTint
	{
		 get { } //Length: 11
		 set { } //Length: 8
	}

	public Color HoveredColor
	{
		 get { } //Length: 58
	}

	public bool IsCamPrjSwitchLabelVisible
	{
		 get { } //Length: 5
		 set { } //Length: 4
	}

	public float MidCapBoxSize
	{
		 get { } //Length: 112
	}

	public float MidCapSphereRadius
	{
		 get { } //Length: 112
	}

	public GizmoCap3DType MidCapType
	{
		 get { } //Length: 26
	}

	public SceneGizmoScreenCorner ScreenCorner
	{
		 get { } //Length: 4
		 set { } //Length: 4
	}

	public Vector2 ScreenOffset
	{
		 get { } //Length: 19
		 set { } //Length: 5
	}

	public float ScreenSize
	{
		 get { } //Length: 6
		 set { } //Length: 26
	}

	private static SceneGizmoLookAndFeel() { }

	public SceneGizmoLookAndFeel() { }

	public Vector2 CalculateMaxPrjSwitchLabelRectSize() { }

	public void ConnectAxisCapLookAndFeel(GizmoCap3D axisCap, int axisIndex, AxisSign axisSign) { }

	public void ConnectMidCapLookAndFeel(GizmoCap3D midCap) { }

	public GizmoCap3DType get_AxesCapType() { }

	public Color get_AxesLabelTint() { }

	public float get_AxisCamAlignFadeOutAlpha() { }

	public float get_AxisCamAlignFadeOutDuration() { }

	public float get_AxisCamAlignFadeOutThreshold() { }

	private GizmoCap3DLookAndFeel get_AxisCapLookAndFeel() { }

	public float get_AxisConeHeight() { }

	public float get_AxisConeRadius() { }

	public float get_AxisLabelScreenSize() { }

	public float get_AxisPyramidDepth() { }

	public float get_AxisPyramidHeight() { }

	public float get_AxisPyramidWidth() { }

	public Texture2D get_CamOrthoModeLabelTexture() { }

	public Texture2D get_CamPerspModeLabelTexture() { }

	public Color get_CamPrjSwitchLabelTint() { }

	public Color get_HoveredColor() { }

	public bool get_IsCamPrjSwitchLabelVisible() { }

	public float get_MidCapBoxSize() { }

	public float get_MidCapSphereRadius() { }

	public GizmoCap3DType get_MidCapType() { }

	public SceneGizmoScreenCorner get_ScreenCorner() { }

	public Vector2 get_ScreenOffset() { }

	public float get_ScreenSize() { }

	public List<Enum> GetAllowedAxesCapTypes() { }

	public List<Enum> GetAllowedMidCapTypes() { }

	public float GetAxesLabelWorldSize(Camera gizmoCam, Vector3 labelWorldPos) { }

	public Color GetAxisCapColor(int axisIndex, AxisSign axisSign) { }

	private GizmoCap3DLookAndFeel GetAxisCapLookAndFeel(int axisIndex, AxisSign axisSign) { }

	public bool IsAxisCapTypeAllowed(GizmoCap3DType capType) { }

	public bool IsMidCapTypeAllowed(GizmoCap3DType capType) { }

	private void OnScreenSizeChanged() { }

	public void set_AxesLabelTint(Color value) { }

	public void set_CamPrjSwitchLabelTint(Color value) { }

	public void set_IsCamPrjSwitchLabelVisible(bool value) { }

	public void set_ScreenCorner(SceneGizmoScreenCorner value) { }

	public void set_ScreenOffset(Vector2 value) { }

	public void set_ScreenSize(float value) { }

	public void SetAxisCapColor(Color color, int axisIndex, AxisSign axisSign) { }

	public void SetAxisCapFillMode(GizmoFillMode3D fillMode) { }

	public void SetAxisCapShadeMode(GizmoShadeMode shadeMode) { }

	public void SetAxisCapType(GizmoCap3DType capType) { }

	public void SetHoveredColor(Color hoveredColor) { }

	public void SetMidCapColor(Color color) { }

	public void SetMidCapFillMode(GizmoFillMode3D fillMode) { }

	public void SetMidCapShadeMode(GizmoShadeMode shadeMode) { }

	public void SetMidCapType(GizmoCap3DType capType) { }

}

