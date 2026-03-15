namespace RLD;

public class GizmoTorusCircle3DBorderController : GizmoCircle3DBorderController
{

	public GizmoTorusCircle3DBorderController(GizmoCircle3DBorderControllerData controllerData) { }

	public float GetTorusCoreRadius(float zoomFactor) { }

	public virtual void UpdateEpsilons(float zoomFactor) { }

	public virtual void UpdateHandles() { }

	public virtual void UpdateTransforms(float zoomFactor) { }

}

