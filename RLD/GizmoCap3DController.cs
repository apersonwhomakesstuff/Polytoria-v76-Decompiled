namespace RLD;

public abstract class GizmoCap3DController : IGizmoCap3DController
{
	protected GizmoCap3DControllerData _data; //Field offset: 0x10

	public GizmoCap3DController(GizmoCap3DControllerData controllerData) { }

	public abstract void CapSlider3D(Vector3 sliderDirection, Vector3 sliderEndPt, float zoomFactor) { }

	public abstract void CapSlider3DInvert(Vector3 sliderDirection, Vector3 sliderEndPt, float zoomFactor) { }

	public abstract float GetSliderAlignedRealLength(float zoomFactor) { }

	public abstract void UpdateHandles() { }

	public abstract void UpdateTransforms(float zoomFactor) { }

}

