namespace RLD;

public class UniversalGizmoSettings3D : Settings
{
	[SerializeField]
	private UniversalGizmoSettingsCategory _displayCategory; //Field offset: 0x28
	[SerializeField]
	private GizmoObjectVertexSnapSettings _mvVertexSnapSettings; //Field offset: 0x30
	[SerializeField]
	private GizmoLineSlider3DSettings[] _mvSglSliderSettings; //Field offset: 0x38
	[SerializeField]
	private GizmoPlaneSlider3DSettings[] _mvDblSliderSettings; //Field offset: 0x40
	[SerializeField]
	private float _rtCamRightSnapStep; //Field offset: 0x48
	[SerializeField]
	private float _rtCamUpSnapStep; //Field offset: 0x4C
	[SerializeField]
	private GizmoPlaneSlider3DSettings[] _rtSliderSettings; //Field offset: 0x50
	[SerializeField]
	private GizmoPlaneSlider2DSettings _rtCamLookSliderSettings; //Field offset: 0x58
	[SerializeField]
	private float _scUniformSnapStep; //Field offset: 0x60
	[SerializeField]
	private GizmoLineSlider3DSettings[] _scSglSliderSettings; //Field offset: 0x68
	[SerializeField]
	private GizmoPlaneSlider3DSettings[] _scDblSliderSettings; //Field offset: 0x70

	public UniversalGizmoSettingsCategory DisplayCategory
	{
		 get { } //Length: 4
		 set { } //Length: 4
	}

	public float MvBoxSliderHoverEps
	{
		 get { } //Length: 49
	}

	public float MvCylinderSliderHoverEps
	{
		 get { } //Length: 49
	}

	public float MvDragSensitivity
	{
		 get { } //Length: 49
	}

	public float MvLineSliderHoverEps
	{
		 get { } //Length: 49
	}

	public float MvXSnapStep
	{
		 get { } //Length: 49
	}

	public float MvYSnapStep
	{
		 get { } //Length: 49
	}

	public float MvZSnapStep
	{
		 get { } //Length: 49
	}

	public float RtAxisLineHoverEps
	{
		 get { } //Length: 49
	}

	public float RtAxisTorusHoverEps
	{
		 get { } //Length: 49
	}

	public float RtCamLookLineHoverEps
	{
		 get { } //Length: 28
	}

	public float RtCamLookSnapStep
	{
		 get { } //Length: 28
	}

	public float RtCamLookThickHoverEps
	{
		 get { } //Length: 28
	}

	public float RtCamRightSnapStep
	{
		 get { } //Length: 6
	}

	public float RtCamUpSnapStep
	{
		 get { } //Length: 6
	}

	public bool RtCanHoverCulledPixels
	{
		 get { } //Length: 51
	}

	public float RtDragSensitivity
	{
		 get { } //Length: 49
	}

	public GizmoSnapMode RtSnapMode
	{
		 get { } //Length: 47
	}

	public float RtXSnapStep
	{
		 get { } //Length: 49
	}

	public float RtYSnapStep
	{
		 get { } //Length: 49
	}

	public float RtZSnapStep
	{
		 get { } //Length: 49
	}

	public float ScBoxSliderHoverEps
	{
		 get { } //Length: 49
	}

	public float ScCylinderSliderHoverEps
	{
		 get { } //Length: 49
	}

	public float ScDragSensitivity
	{
		 get { } //Length: 49
	}

	public float ScLineSliderHoverEps
	{
		 get { } //Length: 49
	}

	public float ScUniformSnapStep
	{
		 get { } //Length: 6
	}

	public float ScXSnapStep
	{
		 get { } //Length: 49
	}

	public float ScXYSnapStep
	{
		 get { } //Length: 49
	}

	public float ScYSnapStep
	{
		 get { } //Length: 49
	}

	public float ScYZSnapStep
	{
		 get { } //Length: 49
	}

	public float ScZSnapStep
	{
		 get { } //Length: 49
	}

	public float ScZXSnapStep
	{
		 get { } //Length: 49
	}

	public GizmoObjectVertexSnapSettings VertexSnapSettings
	{
		 get { } //Length: 95
	}

	public UniversalGizmoSettings3D() { }

	public void ConnectMvDblSliderSettings(GizmoPlaneSlider3D dblSlider, PlaneId planeId) { }

	public void ConnectMvSliderSettings(GizmoLineSlider3D slider, int axisIndex, AxisSign axisSign) { }

	public void ConnectRtCamLookSliderSettings(GizmoPlaneSlider2D slider) { }

	public void ConnectRtSliderSettings(GizmoPlaneSlider3D slider, int axisIndex) { }

	public void ConnectScDblSliderSettings(GizmoPlaneSlider3D dblSlider, PlaneId planeId) { }

	public void ConnectScSliderSettings(GizmoLineSlider3D slider, int axisIndex, AxisSign axisSign) { }

	public UniversalGizmoSettingsCategory get_DisplayCategory() { }

	public float get_MvBoxSliderHoverEps() { }

	public float get_MvCylinderSliderHoverEps() { }

	public float get_MvDragSensitivity() { }

	public float get_MvLineSliderHoverEps() { }

	public float get_MvXSnapStep() { }

	public float get_MvYSnapStep() { }

	public float get_MvZSnapStep() { }

	public float get_RtAxisLineHoverEps() { }

	public float get_RtAxisTorusHoverEps() { }

	public float get_RtCamLookLineHoverEps() { }

	public float get_RtCamLookSnapStep() { }

	public float get_RtCamLookThickHoverEps() { }

	public float get_RtCamRightSnapStep() { }

	public float get_RtCamUpSnapStep() { }

	public bool get_RtCanHoverCulledPixels() { }

	public float get_RtDragSensitivity() { }

	public GizmoSnapMode get_RtSnapMode() { }

	public float get_RtXSnapStep() { }

	public float get_RtYSnapStep() { }

	public float get_RtZSnapStep() { }

	public float get_ScBoxSliderHoverEps() { }

	public float get_ScCylinderSliderHoverEps() { }

	public float get_ScDragSensitivity() { }

	public float get_ScLineSliderHoverEps() { }

	public float get_ScUniformSnapStep() { }

	public float get_ScXSnapStep() { }

	public float get_ScXYSnapStep() { }

	public float get_ScYSnapStep() { }

	public float get_ScYZSnapStep() { }

	public float get_ScZSnapStep() { }

	public float get_ScZXSnapStep() { }

	public GizmoObjectVertexSnapSettings get_VertexSnapSettings() { }

	private GizmoPlaneSlider3DSettings GetMvDblSliderSettings(PlaneId planeId) { }

	private GizmoLineSlider3DSettings GetMvSglSliderSettings(int axisIndex, AxisSign axisSign) { }

	private GizmoPlaneSlider3DSettings GetScDblSliderSettings(PlaneId planeId) { }

	private GizmoLineSlider3DSettings GetScSglSliderSettings(int axisIndex, AxisSign axisSign) { }

	public void Inherit(MoveGizmoSettings3D settings) { }

	public void Inherit(ScaleGizmoSettings3D settings) { }

	public void Inherit(RotationGizmoSettings3D settings) { }

	public void set_DisplayCategory(UniversalGizmoSettingsCategory value) { }

	public void SetMvBoxSliderHoverEps(float eps) { }

	public void SetMvCylinderSliderHoverEps(float eps) { }

	public void SetMvDragSensitivity(float sensitivity) { }

	public void SetMvLineSliderHoverEps(float eps) { }

	public void SetMvXSnapStep(float snapStep) { }

	public void SetMvYSnapStep(float snapStep) { }

	public void SetMvZSnapStep(float snapStep) { }

	public void SetRtAxisLineHoverEps(float eps) { }

	public void SetRtAxisSnapStep(int axisIndex, float snapStep) { }

	public void SetRtAxisTorusHoverEps(float eps) { }

	public void SetRtCamLookLineHoverEps(float eps) { }

	public void SetRtCamLookSnapStep(float snapStep) { }

	public void SetRtCamLookThickHoverEps(float eps) { }

	public void SetRtCamRightSnapStep(float snapStep) { }

	public void SetRtCamUpSnapStep(float snapStep) { }

	public void SetRtCanHoverCulledPixels(bool canHover) { }

	public void SetRtDragSensitivity(float sensitivity) { }

	public void SetRtSnapMode(GizmoSnapMode snapMode) { }

	public void SetScBoxSliderHoverEps(float eps) { }

	public void SetScCylinderSliderHoverEps(float eps) { }

	public void SetScDragSensitivity(float sensitivity) { }

	public void SetScLineSliderHoverEps(float eps) { }

	public void SetScUniformScaleSnapStep(float snapStep) { }

	public void SetScXSnapStep(float snapStep) { }

	public void SetScXYSnapStep(float snapStep) { }

	public void SetScYSnapStep(float snapStep) { }

	public void SetScYZSnapStep(float snapStep) { }

	public void SetScZSnapStep(float snapStep) { }

	public void SetScZXSnapStep(float snapStep) { }

}

