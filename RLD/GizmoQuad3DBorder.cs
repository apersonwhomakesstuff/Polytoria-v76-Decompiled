namespace RLD;

public class GizmoQuad3DBorder
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass39_0
	{
		public GizmoQuad3DBorder <>4__this; //Field offset: 0x10
		public Vector3 camPos; //Field offset: 0x18

		public <>c__DisplayClass39_0() { }

		internal int <Render>b__0(int i0, int i1) { }

	}

	private GizmoPlaneSlider3D _planeSlider; //Field offset: 0x10
	private GizmoHandle _targetHandle; //Field offset: 0x18
	private QuadShape3D _targetQuad; //Field offset: 0x20
	private bool _isVisible; //Field offset: 0x28
	private bool _isHoverable; //Field offset: 0x29
	private int _borderQuadIndex; //Field offset: 0x2C
	private QuadShape3D _borderQuad; //Field offset: 0x30
	private int _topBoxIndex; //Field offset: 0x38
	private BoxShape3D _topBox; //Field offset: 0x40
	private int _rightBoxIndex; //Field offset: 0x48
	private BoxShape3D _rightBox; //Field offset: 0x50
	private int _bottomBoxIndex; //Field offset: 0x58
	private BoxShape3D _bottomBox; //Field offset: 0x60
	private int _leftBoxIndex; //Field offset: 0x68
	private BoxShape3D _leftBox; //Field offset: 0x70
	private int _topLeftBoxIndex; //Field offset: 0x78
	private BoxShape3D _topLeftBox; //Field offset: 0x80
	private int _topRightBoxIndex; //Field offset: 0x88
	private BoxShape3D _topRightBox; //Field offset: 0x90
	private int _bottomRightBoxIndex; //Field offset: 0x98
	private BoxShape3D _bottomRightBox; //Field offset: 0xA0
	private int _bottomLeftBoxIndex; //Field offset: 0xA8
	private BoxShape3D _bottomLeftBox; //Field offset: 0xB0
	private List<Int32> _sortedBoxIndices; //Field offset: 0xB8
	private GizmoQuad3DBorderControllerData _controllerData; //Field offset: 0xC0
	private IGizmoQuad3DBorderController[] _controllers; //Field offset: 0xC8

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

	public GizmoQuad3DBorder(GizmoPlaneSlider3D planeSlider, GizmoHandle targetHandle, QuadShape3D targetQuad) { }

	public Gizmo get_Gizmo() { }

	public bool get_IsHoverable() { }

	public bool get_IsVisible() { }

	public float GetRealBoxDepth(float zoomFactor) { }

	public float GetRealBoxHeight(float zoomFactor) { }

	public float GetZoomFactor(Camera camera) { }

	private void OnGizmoPreUpdateBegin(Gizmo gizmo) { }

	public void OnQuadShapeChanged() { }

	public void Render(Camera camera) { }

	public void SetHoverable(bool isHoverable) { }

	public void SetVisible(bool isVisible) { }

}

