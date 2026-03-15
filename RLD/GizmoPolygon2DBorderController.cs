namespace RLD;

public abstract class GizmoPolygon2DBorderController : IGizmoPolygon2DBorderController
{
	protected GizmoPolygon2DBorderControllerData _data; //Field offset: 0x10

	public GizmoPolygon2DBorderController(GizmoPolygon2DBorderControllerData data) { }

	public abstract void UpdateEpsilons() { }

	public abstract void UpdateHandles() { }

	public abstract void UpdateTransforms() { }

}

