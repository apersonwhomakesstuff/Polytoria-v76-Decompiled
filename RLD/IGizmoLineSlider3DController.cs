namespace RLD;

public interface IGizmoLineSlider3DController
{

	public float GetRealSizeAlongDirection(Vector3 direction, float zoomFactor) { }

	public void UpdateEpsilons(float zoomFactor) { }

	public void UpdateHandles() { }

	public void UpdateTransforms(float zoomFactor) { }

}

