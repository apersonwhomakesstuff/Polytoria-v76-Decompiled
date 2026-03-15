namespace RLD;

public abstract class GizmoQuad2DBorderController : IGizmoQuad2DBorderController
{
	protected GizmoQuad2DBorderControllerData _data; //Field offset: 0x10

	public GizmoQuad2DBorderController(GizmoQuad2DBorderControllerData data) { }

	public abstract void UpdateEpsilons() { }

	public abstract void UpdateHandles() { }

	public abstract void UpdateTransforms() { }

}

