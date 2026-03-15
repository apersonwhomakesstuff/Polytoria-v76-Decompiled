namespace RLD;

public class GizmoQuadPlaneSlider3DController : GizmoPlaneSlider3DController
{

	public GizmoQuadPlaneSlider3DController(GizmoPlaneSlider3DControllerData controllerData) { }

	public virtual void UpdateEpsilons(float zoomFactor) { }

	public virtual void UpdateHandles() { }

	public virtual void UpdateTransforms(float zoomFactor) { }

}

