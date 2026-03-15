namespace RLD;

public class MoveGizmoSettings2D : Settings
{
	[SerializeField]
	private GizmoPlaneSlider2DSettings _dblSliderSettings; //Field offset: 0x28
	[SerializeField]
	private GizmoLineSlider2DSettings[] _sglSliderSettings; //Field offset: 0x30

	public float BoxSliderHoverEps
	{
		 get { } //Length: 49
	}

	public float DragSensitivity
	{
		 get { } //Length: 28
	}

	public float LineSliderHoverEps
	{
		 get { } //Length: 49
	}

	public float XSnapStep
	{
		 get { } //Length: 28
	}

	public float YSnapStep
	{
		 get { } //Length: 28
	}

	public MoveGizmoSettings2D() { }

	public void ConnectDblSliderSettings(GizmoPlaneSlider2D slider) { }

	public void ConnectSliderSettings(GizmoLineSlider2D slider, int axisIndex, AxisSign axisSign) { }

	public float get_BoxSliderHoverEps() { }

	public float get_DragSensitivity() { }

	public float get_LineSliderHoverEps() { }

	public float get_XSnapStep() { }

	public float get_YSnapStep() { }

	private GizmoLineSlider2DSettings GetSliderSettings(int axisIndex, AxisSign axisSign) { }

	public void SetBoxSliderHoverEps(float eps) { }

	public void SetDragSensitivity(float sensitivity) { }

	public void SetLineSliderHoverEps(float eps) { }

	public void SetXSnapStep(float snapStep) { }

	public void SetYSnapStep(float snapStep) { }

}

