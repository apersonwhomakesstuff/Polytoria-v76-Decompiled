namespace RLD;

public abstract class GizmoCircle3DBorderController : IGizmoCircle3DBorderController
{
	protected GizmoCircle3DBorderControllerData _data; //Field offset: 0x10

	public GizmoCircle3DBorderController(GizmoCircle3DBorderControllerData controllerData) { }

	public abstract void UpdateEpsilons(float zoomFactor) { }

	public abstract void UpdateHandles() { }

	public abstract void UpdateTransforms(float zoomFactor) { }

}

