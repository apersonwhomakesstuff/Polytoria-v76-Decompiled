namespace RLD;

public class MoveGizmoSettings3D : Settings
{
	[SerializeField]
	private GizmoObjectVertexSnapSettings _vertexSnapSettings; //Field offset: 0x28
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

	public GizmoObjectVertexSnapSettings VertexSnapSettings
	{
		 get { } //Length: 5
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

	public MoveGizmoSettings3D() { }

	public void ConnectDblSliderSettings(GizmoPlaneSlider3D dblSlider, PlaneId planeId) { }

	public void ConnectSliderSettings(GizmoLineSlider3D slider, int axisIndex, AxisSign axisSign) { }

	public float get_BoxSliderHoverEps() { }

	public float get_CylinderSliderHoverEps() { }

	public float get_DragSensitivity() { }

	public float get_LineSliderHoverEps() { }

	public GizmoObjectVertexSnapSettings get_VertexSnapSettings() { }

	public float get_XSnapStep() { }

	public float get_YSnapStep() { }

	public float get_ZSnapStep() { }

	private GizmoPlaneSlider3DSettings GetDblSliderSettings(PlaneId planeId) { }

	private GizmoLineSlider3DSettings GetSglSliderSettings(int axisIndex, AxisSign axisSign) { }

	public void SetBoxSliderHoverEps(float eps) { }

	public void SetCylinderSliderHoverEps(float eps) { }

	public void SetDragSensitivity(float sensitivity) { }

	public void SetLineSliderHoverEps(float eps) { }

	public void SetXSnapStep(float snapStep) { }

	public void SetYSnapStep(float snapStep) { }

	public void SetZSnapStep(float snapStep) { }

}

