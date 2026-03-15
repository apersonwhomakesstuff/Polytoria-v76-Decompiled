namespace RLD;

public class GizmoCirclePlaneSlider3DController : GizmoPlaneSlider3DController
{

	public GizmoCirclePlaneSlider3DController(GizmoPlaneSlider3DControllerData controllerData) { }

	public virtual void UpdateEpsilons(float zoomFactor) { }

	public virtual void UpdateHandles() { }

	public virtual void UpdateTransforms(float zoomFactor) { }

}

