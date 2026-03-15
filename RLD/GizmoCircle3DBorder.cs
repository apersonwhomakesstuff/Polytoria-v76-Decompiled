namespace RLD;

public class GizmoCircle3DBorder
{
	private GizmoPlaneSlider3D _planeSlider; //Field offset: 0x10
	private GizmoHandle _targetHandle; //Field offset: 0x18
	private CircleShape3D _targetCircle; //Field offset: 0x20
	private bool _isVisible; //Field offset: 0x28
	private bool _isHoverable; //Field offset: 0x29
	private int _borderCircleIndex; //Field offset: 0x2C
	private int _borderTorusIndex; //Field offset: 0x30
	private int _borderCylTorusIndex; //Field offset: 0x34
	private CircleShape3D _borderCircle; //Field offset: 0x38
	private TorusShape3D _borderTorus; //Field offset: 0x40
	private CylTorusShape3D _borderCylTorus; //Field offset: 0x48
	private GizmoCircle3DBorderControllerData _controllerData; //Field offset: 0x50
	private IGizmoCircle3DBorderController[] _controllers; //Field offset: 0x58

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

	public GizmoCircle3DBorder(GizmoPlaneSlider3D planeSlider, GizmoHandle targetHandle, CircleShape3D targetCircle) { }

	public Gizmo get_Gizmo() { }

	public bool get_IsHoverable() { }

	public bool get_IsVisible() { }

	public float GetRealCylTorusHeight(float zoomFactor) { }

	public float GetRealCylTorusWidth(float zoomFactor) { }

	public float GetRealTorusThickness(float zoomFactor) { }

	public float GetZoomFactor(Camera camera) { }

	public void OnCircleShapeChanged() { }

	private void OnGizmoPreUpdateBegin(Gizmo gizmo) { }

	public void Render(Camera camera) { }

	public void SetHoverable(bool isHoverable) { }

	public void SetVisible(bool isVisible) { }

}

