namespace RLD;

public class GizmoCirclePlaneSlider2DController : GizmoPlaneSlider2DController
{

	public GizmoCirclePlaneSlider2DController(GizmoPlaneSlider2DControllerData controllerData) { }

	public virtual Vector2 GetRealExtentPoint(Shape2DExtentPoint extentPt) { }

	public virtual void UpdateEpsilons() { }

	public virtual void UpdateHandles() { }

	public virtual void UpdateTransforms() { }

}

