namespace RLD;

public class GizmoRATriangle3DBorder
{
	private GizmoPlaneSlider3D _planeSlider; //Field offset: 0x10
	private GizmoHandle _targetHandle; //Field offset: 0x18
	private RightAngTriangle3D _targetTriangle; //Field offset: 0x20
	private bool _isVisible; //Field offset: 0x28
	private bool _isHoverable; //Field offset: 0x29
	private int _borderTriangleIndex; //Field offset: 0x2C
	private RightAngTriangle3D _borderTriangle; //Field offset: 0x30
	private GizmoRATriangle3DBorderControllerData _controllerData; //Field offset: 0x38
	private IGizmoRATriangle3DBorderController[] _controllers; //Field offset: 0x40

	public Gizmo Gizmo
	{
		 get { } //Length: 27
	}

	public bool IsHoverable
	{
		 get { } //Length: 5
	}

	public bool IsVisible
	{
		 get { } //Length: 5
	}

	public GizmoRATriangle3DBorder(GizmoPlaneSlider3D planeSlider, GizmoHandle targetHandle, RightAngTriangle3D targetRiangle) { }

	public Gizmo get_Gizmo() { }

	public bool get_IsHoverable() { }

	public bool get_IsVisible() { }

	public float GetZoomFactor(Camera camera) { }

	private void OnGizmoPreUpdateBegin(Gizmo gizmo) { }

	public void OnTriangleShapeChanged() { }

	public void Render(Camera camera) { }

	public void SetHoverable(bool isHoverable) { }

	public void SetVisible(bool isVisible) { }

}

