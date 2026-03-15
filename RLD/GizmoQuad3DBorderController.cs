namespace RLD;

public abstract class GizmoQuad3DBorderController : IGizmoQuad3DBorderController
{
	protected GizmoQuad3DBorderControllerData _data; //Field offset: 0x10

	public GizmoQuad3DBorderController(GizmoQuad3DBorderControllerData data) { }

	public abstract void UpdateEpsilons(float zoomFactor) { }

	public abstract void UpdateHandles() { }

	public abstract void UpdateTransforms(float zoomFactor) { }

}

