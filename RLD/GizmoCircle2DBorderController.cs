namespace RLD;

public abstract class GizmoCircle2DBorderController : IGizmoCircle2DBorderController
{
	protected GizmoCircle2DBorderControllerData _data; //Field offset: 0x10

	public GizmoCircle2DBorderController(GizmoCircle2DBorderControllerData data) { }

	public abstract void UpdateEpsilons() { }

	public abstract void UpdateHandles() { }

	public abstract void UpdateTransforms() { }

}

