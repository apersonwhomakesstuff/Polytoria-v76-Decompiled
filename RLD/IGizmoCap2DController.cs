namespace RLD;

public interface IGizmoCap2DController
{

	public void CapSlider2D(Vector2 sliderDirection, Vector2 sliderEndPt) { }

	public void CapSlider2DInvert(Vector2 sliderDirection, Vector2 sliderEndPt) { }

	public float GetSliderAlignedRealLength() { }

	public void UpdateHandles() { }

	public void UpdateTransforms() { }

}

