namespace RLD;

public class GizmoArrowCap2DController : GizmoCap2DController
{

	public GizmoArrowCap2DController(GizmoCap2DControllerData controllerData) { }

	public virtual void CapSlider2D(Vector2 sliderDirection, Vector2 sliderEndPt) { }

	public virtual void CapSlider2DInvert(Vector2 sliderDirection, Vector2 sliderEndPt) { }

	public virtual float GetSliderAlignedRealLength() { }

	public virtual void UpdateHandles() { }

	public virtual void UpdateTransforms() { }

}

