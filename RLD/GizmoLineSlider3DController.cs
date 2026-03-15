namespace RLD;

public abstract class GizmoLineSlider3DController : IGizmoLineSlider3DController
{
	protected GizmoLineSlider3DControllerData _data; //Field offset: 0x10

	public GizmoLineSlider3DController(GizmoLineSlider3DControllerData controllerData) { }

	public abstract float GetRealSizeAlongDirection(Vector3 direction, float zoomFactor) { }

	public abstract void UpdateEpsilons(float zoomFactor) { }

	public abstract void UpdateHandles() { }

	public abstract void UpdateTransforms(float zoomFactor) { }

}

