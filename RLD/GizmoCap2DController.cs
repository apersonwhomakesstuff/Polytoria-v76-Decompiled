namespace RLD;

public abstract class GizmoCap2DController : IGizmoCap2DController
{
	protected GizmoCap2DControllerData _data; //Field offset: 0x10

	public GizmoCap2DController(GizmoCap2DControllerData controllerData) { }

	public abstract void CapSlider2D(Vector2 sliderDirection, Vector2 sliderEndPt) { }

	public abstract void CapSlider2DInvert(Vector2 sliderDirection, Vector2 sliderEndPt) { }

	public abstract float GetSliderAlignedRealLength() { }

	public abstract void UpdateHandles() { }

	public abstract void UpdateTransforms() { }

}

