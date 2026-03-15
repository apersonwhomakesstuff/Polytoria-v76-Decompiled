namespace RLD;

public interface IGizmoCap3DController
{

	public void CapSlider3D(Vector3 sliderDirection, Vector3 sliderEndPt, float zoomFactor) { }

	public void CapSlider3DInvert(Vector3 sliderDirection, Vector3 sliderEndPt, float zoomFactor) { }

	public float GetSliderAlignedRealLength(float zoomFactor) { }

	public void UpdateHandles() { }

	public void UpdateTransforms(float zoomFactor) { }

}

