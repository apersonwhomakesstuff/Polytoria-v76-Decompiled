namespace RLD;

public class GizmoBoxLineSlider3DController : GizmoLineSlider3DController
{

	public GizmoBoxLineSlider3DController(GizmoLineSlider3DControllerData controllerData) { }

	public virtual float GetRealSizeAlongDirection(Vector3 direction, float zoomFactor) { }

	public virtual void UpdateEpsilons(float zoomFactor) { }

	public virtual void UpdateHandles() { }

	public virtual void UpdateTransforms(float zoomFactor) { }

}

