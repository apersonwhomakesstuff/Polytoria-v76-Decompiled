namespace RLD;

public abstract class GizmoPlaneSlider2DController : IGizmoPlaneSlider2DController
{
	protected GizmoPlaneSlider2DControllerData _data; //Field offset: 0x10

	public GizmoPlaneSlider2DController(GizmoPlaneSlider2DControllerData controllerData) { }

	public abstract Vector2 GetRealExtentPoint(Shape2DExtentPoint extentPt) { }

	public abstract void UpdateEpsilons() { }

	public abstract void UpdateHandles() { }

	public abstract void UpdateTransforms() { }

}

