namespace RLD;

public class ScaleGizmoSettings3D : Settings
{
	[SerializeField]
	private float _uniformSnapStep; //Field offset: 0x28
	[SerializeField]
	private GizmoLineSlider3DSettings[] _sglSliderSettings; //Field offset: 0x30
	[SerializeField]
	private GizmoPlaneSlider3DSettings[] _dblSliderSettings; //Field offset: 0x38

	public float BoxSliderHoverEps
	{
		 get { } //Length: 49
	}

	public float CylinderSliderHoverEps
	{
		 get { } //Length: 49
	}

	public float DragSensitivity
	{
		 get { } //Length: 49
	}

	public float LineSliderHoverEps
	{
		 get { } //Length: 49
	}

	public float UniformSnapStep
	{
		 get { } //Length: 6
	}

	public float XSnapStep
	{
		 get { } //Length: 49
	}

	public float XYSnapStep
	{
		 get { } //Length: 49
	}

	public float YSnapStep
	{
		 get { } //Length: 49
	}

	public float YZSnapStep
	{
		 get { } //Length: 49
	}

	public float ZSnapStep
	{
		 get { } //Length: 49
	}

	public float ZXSnapStep
	{
		 get { } //Length: 49
	}

	public ScaleGizmoSettings3D() { }

	public void ConnectDblSliderSettings(GizmoPlaneSlider3D dblSlider, PlaneId planeId) { }

	public void ConnectSliderSettings(GizmoLineSlider3D slider, int axisIndex, AxisSign axisSign) { }

	public float get_BoxSliderHoverEps() { }

	public float get_CylinderSliderHoverEps() { }

	public float get_DragSensitivity() { }

	public float get_LineSliderHoverEps() { }

	public float get_UniformSnapStep() { }

	public float get_XSnapStep() { }

	public float get_XYSnapStep() { }

	public float get_YSnapStep() { }

	public float get_YZSnapStep() { }

	public float get_ZSnapStep() { }

	public float get_ZXSnapStep() { }

	private GizmoPlaneSlider3DSettings GetDblSliderSettings(PlaneId planeId) { }

	private GizmoLineSlider3DSettings GetSglSliderSettings(int axisIndex, AxisSign axisSign) { }

	public void SetBoxSliderHoverEps(float eps) { }

	public void SetCylinderSliderHoverEps(float eps) { }

	public void SetDragSensitivity(float sensitivity) { }

	public void SetLineSliderHoverEps(float eps) { }

	public void SetUniformScaleSnapStep(float snapStep) { }

	public void SetXSnapStep(float snapStep) { }

	public void SetXYSnapStep(float snapStep) { }

	public void SetYSnapStep(float snapStep) { }

	public void SetYZSnapStep(float snapStep) { }

	public void SetZSnapStep(float snapStep) { }

	public void SetZXSnapStep(float snapStep) { }

}

