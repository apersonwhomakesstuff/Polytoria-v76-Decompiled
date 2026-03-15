namespace RLD;

public abstract class GizmoLineSlider2DController : IGizmoLineSlider2DController
{
	protected GizmoLineSlider2DControllerData _data; //Field offset: 0x10

	public GizmoLineSlider2DController(GizmoLineSlider2DControllerData controllerData) { }

	public abstract void UpdateEpsilons() { }

	public abstract void UpdateHandles() { }

	public abstract void UpdateTransforms() { }

}

