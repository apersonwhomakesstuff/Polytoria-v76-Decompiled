namespace RLD;

public class UniversalGizmoSettings2D : Settings
{
	[SerializeField]
	private UniversalGizmoSettingsCategory _displayCategory; //Field offset: 0x28
	[SerializeField]
	private GizmoPlaneSlider2DSettings _mvDblSliderSettings; //Field offset: 0x30
	[SerializeField]
	private GizmoLineSlider2DSettings[] _mvSglSliderSettings; //Field offset: 0x38

	public UniversalGizmoSettingsCategory DisplayCategory
	{
		 get { } //Length: 4
		 set { } //Length: 4
	}

	public float MvBoxSliderHoverEps
	{
		 get { } //Length: 49
	}

	public float MvDragSensitivity
	{
		 get { } //Length: 28
	}

	public float MvLineSliderHoverEps
	{
		 get { } //Length: 49
	}

	public float MvXSnapStep
	{
		 get { } //Length: 28
	}

	public float MvYSnapStep
	{
		 get { } //Length: 28
	}

	public UniversalGizmoSettings2D() { }

	public void ConnectMvDblSliderSettings(GizmoPlaneSlider2D slider) { }

	public void ConnectMvSliderSettings(GizmoLineSlider2D slider, int axisIndex, AxisSign axisSign) { }

	public UniversalGizmoSettingsCategory get_DisplayCategory() { }

	public float get_MvBoxSliderHoverEps() { }

	public float get_MvDragSensitivity() { }

	public float get_MvLineSliderHoverEps() { }

	public float get_MvXSnapStep() { }

	public float get_MvYSnapStep() { }

	private GizmoLineSlider2DSettings GetMvSliderSettings(int axisIndex, AxisSign axisSign) { }

	public void Inherit(MoveGizmoSettings2D settings) { }

	public void set_DisplayCategory(UniversalGizmoSettingsCategory value) { }

	public void SetMvBoxSliderHoverEps(float eps) { }

	public void SetMvDragSensitivity(float sensitivity) { }

	public void SetMvLineSliderHoverEps(float eps) { }

	public void SetMvXSnapStep(float snapStep) { }

	public void SetMvYSnapStep(float snapStep) { }

}

