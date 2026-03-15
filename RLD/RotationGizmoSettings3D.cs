namespace RLD;

public class RotationGizmoSettings3D : Settings
{
	[SerializeField]
	private float _camRightSnapStep; //Field offset: 0x28
	[SerializeField]
	private float _camUpSnapStep; //Field offset: 0x2C
	[SerializeField]
	private GizmoPlaneSlider3DSettings[] _sliderSettings; //Field offset: 0x30
	[SerializeField]
	private GizmoPlaneSlider2DSettings _camLookSliderSettings; //Field offset: 0x38

	public float AxisLineHoverEps
	{
		 get { } //Length: 49
	}

	public float AxisTorusHoverEps
	{
		 get { } //Length: 49
	}

	public float CamLookLineHoverEps
	{
		 get { } //Length: 28
	}

	public float CamLookSnapStep
	{
		 get { } //Length: 28
	}

	public float CamLookThickHoverEps
	{
		 get { } //Length: 28
	}

	public float CamRightSnapStep
	{
		 get { } //Length: 6
	}

	public float CamUpSnapStep
	{
		 get { } //Length: 6
	}

	public bool CanHoverCulledPixels
	{
		 get { } //Length: 51
	}

	public float DragSensitivity
	{
		 get { } //Length: 49
	}

	public GizmoSnapMode SnapMode
	{
		 get { } //Length: 47
	}

	public float XSnapStep
	{
		 get { } //Length: 49
	}

	public float YSnapStep
	{
		 get { } //Length: 49
	}

	public float ZSnapStep
	{
		 get { } //Length: 49
	}

	public RotationGizmoSettings3D() { }

	public void ConnectCamLookSliderSettings(GizmoPlaneSlider2D slider) { }

	public void ConnectSliderSettings(GizmoPlaneSlider3D slider, int axisIndex) { }

	public float get_AxisLineHoverEps() { }

	public float get_AxisTorusHoverEps() { }

	public float get_CamLookLineHoverEps() { }

	public float get_CamLookSnapStep() { }

	public float get_CamLookThickHoverEps() { }

	public float get_CamRightSnapStep() { }

	public float get_CamUpSnapStep() { }

	public bool get_CanHoverCulledPixels() { }

	public float get_DragSensitivity() { }

	public GizmoSnapMode get_SnapMode() { }

	public float get_XSnapStep() { }

	public float get_YSnapStep() { }

	public float get_ZSnapStep() { }

	public void SetAxisLineHoverEps(float eps) { }

	public void SetAxisSnapStep(int axisIndex, float snapStep) { }

	public void SetAxisTorusHoverEps(float eps) { }

	public void SetCamLookLineHoverEps(float eps) { }

	public void SetCamLookSnapStep(float snapStep) { }

	public void SetCamLookThickHoverEps(float eps) { }

	public void SetCamRightSnapStep(float snapStep) { }

	public void SetCamUpSnapStep(float snapStep) { }

	public void SetCanHoverCulledPixels(bool canHover) { }

	public void SetDragSensitivity(float sensitivity) { }

	public void SetSnapMode(GizmoSnapMode snapMode) { }

}

