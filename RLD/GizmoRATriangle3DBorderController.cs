namespace RLD;

public abstract class GizmoRATriangle3DBorderController : IGizmoRATriangle3DBorderController
{
	protected GizmoRATriangle3DBorderControllerData _data; //Field offset: 0x10

	public GizmoRATriangle3DBorderController(GizmoRATriangle3DBorderControllerData controllerData) { }

	public abstract void UpdateEpsilons(float zoomFactor) { }

	public abstract void UpdateHandles() { }

	public abstract void UpdateTransforms(float zoomFactor) { }

}

