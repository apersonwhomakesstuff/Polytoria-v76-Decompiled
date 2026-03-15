namespace RLD;

public class MoveGizmo : GizmoBehaviour
{
	internal enum VertexSnapState : int
	{
		SelectingPivot = 0,
		Snapping = 1,
		Inactive = 2,
	}

	private GizmoLineSlider3D _pXSlider; //Field offset: 0x20
	private GizmoLineSlider3D _pYSlider; //Field offset: 0x28
	private GizmoLineSlider3D _pZSlider; //Field offset: 0x30
	private GizmoLineSlider3D _nXSlider; //Field offset: 0x38
	private GizmoLineSlider3D _nYSlider; //Field offset: 0x40
	private GizmoLineSlider3D _nZSlider; //Field offset: 0x48
	private GizmoLineSlider3DCollection _axesSliders; //Field offset: 0x50
	private GizmoPlaneSlider3D _xySlider; //Field offset: 0x58
	private GizmoPlaneSlider3D _yzSlider; //Field offset: 0x60
	private GizmoPlaneSlider3D _zxSlider; //Field offset: 0x68
	private GizmoPlaneSlider3DCollection _dblSliders; //Field offset: 0x70
	private GizmoCap3D _midCap; //Field offset: 0x78
	private bool _isVertexSnapEnabled; //Field offset: 0x80
	private GizmoCap2D _vertSnapCap; //Field offset: 0x88
	private GizmoObjectVertexSnapDrag3D _vertexSnapDrag; //Field offset: 0x90
	private Vector3 _postVSnapPosRestore; //Field offset: 0x98
	private bool _is2DModeEnabled; //Field offset: 0xA4
	private GizmoLineSlider2D _p2DModeXSlider; //Field offset: 0xA8
	private GizmoLineSlider2D _p2DModeYSlider; //Field offset: 0xB0
	private GizmoLineSlider2D _n2DModeXSlider; //Field offset: 0xB8
	private GizmoLineSlider2D _n2DModeYSlider; //Field offset: 0xC0
	private GizmoLineSlider2DCollection _2DModeSliders; //Field offset: 0xC8
	private GizmoPlaneSlider2D _2DModeDblSlider; //Field offset: 0xD0
	[SerializeField]
	private bool _useSnapEnableHotkey; //Field offset: 0xD8
	[SerializeField]
	private bool _useVertSnapEnableHotkey; //Field offset: 0xD9
	[SerializeField]
	private bool _use2DModeEnableHotkey; //Field offset: 0xDA
	[SerializeField]
	private MoveGizmoHotkeys _hotkeys; //Field offset: 0xE0
	[SerializeField]
	private MoveGizmoSettings2D _settings2D; //Field offset: 0xE8
	[SerializeField]
	private MoveGizmoSettings3D _settings3D; //Field offset: 0xF0
	[SerializeField]
	private MoveGizmoLookAndFeel2D _lookAndFeel2D; //Field offset: 0xF8
	[SerializeField]
	private MoveGizmoLookAndFeel3D _lookAndFeel3D; //Field offset: 0x100
	private MoveGizmoHotkeys _sharedHotkeys; //Field offset: 0x108
	private MoveGizmoSettings2D _sharedSettings2D; //Field offset: 0x110
	private MoveGizmoSettings3D _sharedSettings3D; //Field offset: 0x118
	private MoveGizmoLookAndFeel2D _sharedLookAndFeel2D; //Field offset: 0x120
	private MoveGizmoLookAndFeel3D _sharedLookAndFeel3D; //Field offset: 0x128

	public MoveGizmoHotkeys Hotkeys
	{
		 get { } //Length: 26
	}

	public MoveGizmoLookAndFeel2D LookAndFeel2D
	{
		 get { } //Length: 26
	}

	public MoveGizmoLookAndFeel3D LookAndFeel3D
	{
		 get { } //Length: 26
	}

	public MoveGizmoSettings2D Settings2D
	{
		 get { } //Length: 26
	}

	public MoveGizmoSettings3D Settings3D
	{
		 get { } //Length: 26
	}

	public MoveGizmoHotkeys SharedHotkeys
	{
		 get { } //Length: 8
		 set { } //Length: 19
	}

	public MoveGizmoLookAndFeel2D SharedLookAndFeel2D
	{
		 get { } //Length: 8
		 set { } //Length: 43
	}

	public MoveGizmoLookAndFeel3D SharedLookAndFeel3D
	{
		 get { } //Length: 8
		 set { } //Length: 43
	}

	public MoveGizmoSettings2D SharedSettings2D
	{
		 get { } //Length: 8
		 set { } //Length: 43
	}

	public MoveGizmoSettings3D SharedSettings3D
	{
		 get { } //Length: 8
		 set { } //Length: 43
	}

	public bool Use2DModeEnableHotkey
	{
		 get { } //Length: 8
		 set { } //Length: 7
	}

	public bool UseSnapEnableHotkey
	{
		 get { } //Length: 8
		 set { } //Length: 7
	}

	public bool UseVertSnapEnableHotkey
	{
		 get { } //Length: 8
		 set { } //Length: 7
	}

	public MoveGizmo() { }

	public MoveGizmoHotkeys get_Hotkeys() { }

	public MoveGizmoLookAndFeel2D get_LookAndFeel2D() { }

	public MoveGizmoLookAndFeel3D get_LookAndFeel3D() { }

	public MoveGizmoSettings2D get_Settings2D() { }

	public MoveGizmoSettings3D get_Settings3D() { }

	public MoveGizmoHotkeys get_SharedHotkeys() { }

	public MoveGizmoLookAndFeel2D get_SharedLookAndFeel2D() { }

	public MoveGizmoLookAndFeel3D get_SharedLookAndFeel3D() { }

	public MoveGizmoSettings2D get_SharedSettings2D() { }

	public MoveGizmoSettings3D get_SharedSettings3D() { }

	public bool get_Use2DModeEnableHotkey() { }

	public bool get_UseSnapEnableHotkey() { }

	public bool get_UseVertSnapEnableHotkey() { }

	public VertexSnapState GetVertexSnapState() { }

	public float GetZoomFactor(Vector3 position, Camera camera) { }

	public float GetZoomFactor(Vector3 position) { }

	private void Hide2DModeHandles() { }

	public virtual void OnAttached() { }

	public virtual void OnDetached() { }

	public virtual void OnDisabled() { }

	public virtual void OnEnabled() { }

	public virtual void OnGizmoDragUpdate(int handleId) { }

	public virtual void OnGizmoEnabled() { }

	public virtual void OnGizmoRender(Camera camera) { }

	private void OnGizmoTransformChanged(GizmoTransform transform, ChangeData changeData) { }

	public virtual void OnGizmoUpdateBegin() { }

	public bool OwnsHandle(int handleId) { }

	private void PlaceDblSlidersInSliderPlanes(Camera camera) { }

	public void set_SharedHotkeys(MoveGizmoHotkeys value) { }

	public void set_SharedLookAndFeel2D(MoveGizmoLookAndFeel2D value) { }

	public void set_SharedLookAndFeel3D(MoveGizmoLookAndFeel3D value) { }

	public void set_SharedSettings2D(MoveGizmoSettings2D value) { }

	public void set_SharedSettings3D(MoveGizmoSettings3D value) { }

	public void set_Use2DModeEnableHotkey(bool value) { }

	public void set_UseSnapEnableHotkey(bool value) { }

	public void set_UseVertSnapEnableHotkey(bool value) { }

	public void Set2DModeEnabled(bool isEnabled) { }

	public void SetAxesLinesHoverable(bool hoverable) { }

	public void SetSnapEnabled(bool isEnabled) { }

	private void SetupSharedLookAndFeel() { }

	private void SetupSharedSettings() { }

	public void SetVertexSnapEnabled(bool isEnabled) { }

	public void SetVertexSnapTargetObjects(IEnumerable<GameObject> targetObjects) { }

	private void Update2DGizmoPosition() { }

	private void Update2DModeHandlePositions() { }

}

