namespace RLD;

public abstract class GizmoPlaneSlider3DController : IGizmoPlaneSlider3DController
{
	protected GizmoPlaneSlider3DControllerData _data; //Field offset: 0x10

	public GizmoPlaneSlider3DController(GizmoPlaneSlider3DControllerData controllerData) { }

	public abstract void UpdateEpsilons(float zoomFactor) { }

	public abstract void UpdateHandles() { }

	public abstract void UpdateTransforms(float zoomFactor) { }

}

