namespace RLD;

public class GizmoBoxCap3DController : GizmoCap3DController
{

	public GizmoBoxCap3DController(GizmoCap3DControllerData controllerData) { }

	public virtual void CapSlider3D(Vector3 sliderDirection, Vector3 sliderEndPt, float zoomFactor) { }

	public virtual void CapSlider3DInvert(Vector3 sliderDirection, Vector3 sliderEndPt, float zoomFactor) { }

	public virtual float GetSliderAlignedRealLength(float zoomFactor) { }

	public virtual void UpdateHandles() { }

	public virtual void UpdateTransforms(float zoomFactor) { }

}

