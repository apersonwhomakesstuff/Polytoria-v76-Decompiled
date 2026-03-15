namespace RLD;

public class UniversalGizmo : GizmoBehaviour
{
	internal enum MvVertexSnapState : int
	{
		SelectingPivot = 0,
		Snapping = 1,
		Inactive = 2,
	}

	private GizmoLineSlider3D _mvPXSlider; //Field offset: 0x20
	private GizmoLineSlider3D _mvPYSlider; //Field offset: 0x28
	private GizmoLineSlider3D _mvPZSlider; //Field offset: 0x30
	private GizmoLineSlider3D _mvNXSlider; //Field offset: 0x38
	private GizmoLineSlider3D _mvNYSlider; //Field offset: 0x40
	private GizmoLineSlider3D _mvNZSlider; //Field offset: 0x48
	private GizmoLineSlider3DCollection _mvAxesSliders; //Field offset: 0x50
	private GizmoPlaneSlider3D _mvXYSlider; //Field offset: 0x58
	private GizmoPlaneSlider3D _mvYZSlider; //Field offset: 0x60
	private GizmoPlaneSlider3D _mvZXSlider; //Field offset: 0x68
	private GizmoPlaneSlider3DCollection _mvDblSliders; //Field offset: 0x70
	private bool _isMvVertexSnapEnabled; //Field offset: 0x78
	private GizmoCap2D _mvVertSnapCap; //Field offset: 0x80
	private GizmoObjectVertexSnapDrag3D _mvVertexSnapDrag; //Field offset: 0x88
	private Vector3 _mvPostVSnapPosRestore; //Field offset: 0x90
	private GizmoLineSlider2D _mvP2DModeXSlider; //Field offset: 0xA0
	private GizmoLineSlider2D _mvP2DModeYSlider; //Field offset: 0xA8
	private GizmoLineSlider2D _mvN2DModeXSlider; //Field offset: 0xB0
	private GizmoLineSlider2D _mvN2DModeYSlider; //Field offset: 0xB8
	private GizmoLineSlider2DCollection _mv2DModeSliders; //Field offset: 0xC0
	private GizmoPlaneSlider2D _mv2DModeDblSlider; //Field offset: 0xC8
	private GizmoPlaneSlider3D _rtXSlider; //Field offset: 0xD0
	private GizmoPlaneSlider3D _rtYSlider; //Field offset: 0xD8
	private GizmoPlaneSlider3D _rtZSlider; //Field offset: 0xE0
	private GizmoPlaneSlider3DCollection _rtAxesSliders; //Field offset: 0xE8
	private GizmoCap3D _rtMidCap; //Field offset: 0xF0
	private GizmoDblAxisRotationDrag3D _rtCamXYRotationDrag; //Field offset: 0xF8
	private GizmoPlaneSlider2D _rtCamLookSlider; //Field offset: 0x100
	private GizmoCap3D _scMidCap; //Field offset: 0x108
	private GizmoUniformScaleDrag3D _scUnformScaleDrag; //Field offset: 0x110
	private GizmoScaleGuide _scScaleGuide; //Field offset: 0x118
	private IEnumerable<GameObject> _scScaleGuideTargetObjects; //Field offset: 0x120
	private bool _is2DModeEnabled; //Field offset: 0x128
	[SerializeField]
	private UniversalGizmoSettings2D _settings2D; //Field offset: 0x130
	private UniversalGizmoSettings2D _sharedSettings2D; //Field offset: 0x138
	[SerializeField]
	private UniversalGizmoSettings3D _settings3D; //Field offset: 0x140
	private UniversalGizmoSettings3D _sharedSettings3D; //Field offset: 0x148
	[SerializeField]
	private UniversalGizmoLookAndFeel2D _lookAndFeel2D; //Field offset: 0x150
	private UniversalGizmoLookAndFeel2D _sharedLookAndFeel2D; //Field offset: 0x158
	[SerializeField]
	private UniversalGizmoLookAndFeel3D _lookAndFeel3D; //Field offset: 0x160
	private UniversalGizmoLookAndFeel3D _sharedLookAndFeel3D; //Field offset: 0x168
	[SerializeField]
	private UniversalGizmoHotkeys _hotkeys; //Field offset: 0x170
	private UniversalGizmoHotkeys _sharedHotkeys; //Field offset: 0x178
	[SerializeField]
	private bool _useSnapEnableHotkey; //Field offset: 0x180
	[SerializeField]
	private bool _useVertSnapEnableHotkey; //Field offset: 0x181
	[SerializeField]
	private bool _use2DModeEnableHotkey; //Field offset: 0x182

	public UniversalGizmoHotkeys Hotkeys
	{
		 get { } //Length: 26
	}

	public UniversalGizmoLookAndFeel2D LookAndFeel2D
	{
		 get { } //Length: 26
	}

	public UniversalGizmoLookAndFeel3D LookAndFeel3D
	{
		 get { } //Length: 26
	}

	public UniversalGizmoSettings2D Settings2D
	{
		 get { } //Length: 26
	}

	public UniversalGizmoSettings3D Settings3D
	{
		 get { } //Length: 26
	}

	public UniversalGizmoHotkeys SharedHotkeys
	{
		 get { } //Length: 8
		 set { } //Length: 19
	}

	public UniversalGizmoLookAndFeel2D SharedLookAndFeel2D
	{
		 get { } //Length: 8
		 set { } //Length: 43
	}

	public UniversalGizmoLookAndFeel3D SharedLookAndFeel3D
	{
		 get { } //Length: 8
		 set { } //Length: 43
	}

	public UniversalGizmoSettings2D SharedSettings2D
	{
		 get { } //Length: 8
		 set { } //Length: 43
	}

	public UniversalGizmoSettings3D SharedSettings3D
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
		 set { } //Length: 86
	}

	public UniversalGizmo() { }

	public UniversalGizmoHotkeys get_Hotkeys() { }

	public UniversalGizmoLookAndFeel2D get_LookAndFeel2D() { }

	public UniversalGizmoLookAndFeel3D get_LookAndFeel3D() { }

	public UniversalGizmoSettings2D get_Settings2D() { }

	public UniversalGizmoSettings3D get_Settings3D() { }

	public UniversalGizmoHotkeys get_SharedHotkeys() { }

	public UniversalGizmoLookAndFeel2D get_SharedLookAndFeel2D() { }

	public UniversalGizmoLookAndFeel3D get_SharedLookAndFeel3D() { }

	public UniversalGizmoSettings2D get_SharedSettings2D() { }

	public UniversalGizmoSettings3D get_SharedSettings3D() { }

	public bool get_Use2DModeEnableHotkey() { }

	public bool get_UseSnapEnableHotkey() { }

	public bool get_UseVertSnapEnableHotkey() { }

	public MvVertexSnapState GetMvVertexSnapState() { }

	public float GetMvZoomFactor(Vector3 position, Camera camera) { }

	public float GetMvZoomFactor(Vector3 position) { }

	public float GetRtZoomFactor(Vector3 position) { }

	public float GetRtZoomFactor(Vector3 position, Camera camera) { }

	public float GetScZoomFactor(Vector3 position, Camera camera) { }

	public float GetScZoomFactor(Vector3 position) { }

	private void Hide2DModeHandles() { }

	public bool IsDraggingMoveHandle() { }

	public bool IsDraggingRotationHandle() { }

	public bool IsDraggingScaleHandle() { }

	public bool IsMoveHandle(int handleId) { }

	public bool IsRotationHandle(int handleId) { }

	public bool IsScaleHandle(int handleId) { }

	public virtual void OnAttached() { }

	public virtual void OnDetached() { }

	public virtual void OnDisabled() { }

	public virtual void OnEnabled() { }

	public virtual void OnGizmoAttemptHandleDragBegin(int handleId) { }

	public virtual void OnGizmoDragBegin(int handleId) { }

	public virtual void OnGizmoDragEnd(int handleId) { }

	public virtual void OnGizmoDragUpdate(int handleId) { }

	public virtual void OnGizmoEnabled() { }

	public virtual void OnGizmoRender(Camera camera) { }

	private void OnGizmoTransformChanged(GizmoTransform transform, ChangeData changeData) { }

	public virtual void OnGizmoUpdateBegin() { }

	public bool OwnsHandle(int handleId) { }

	private void PlaceMvDblSlidersInSliderPlanes(Camera camera) { }

	public void set_SharedHotkeys(UniversalGizmoHotkeys value) { }

	public void set_SharedLookAndFeel2D(UniversalGizmoLookAndFeel2D value) { }

	public void set_SharedLookAndFeel3D(UniversalGizmoLookAndFeel3D value) { }

	public void set_SharedSettings2D(UniversalGizmoSettings2D value) { }

	public void set_SharedSettings3D(UniversalGizmoSettings3D value) { }

	public void set_Use2DModeEnableHotkey(bool value) { }

	public void set_UseSnapEnableHotkey(bool value) { }

	public void set_UseVertSnapEnableHotkey(bool value) { }

	public void Set2DModeEnabled(bool isEnabled) { }

	private void SetMoveHandlesVisible(bool visible) { }

	public void SetMvAxesLinesHoverable(bool hoverable) { }

	public void SetMvVertexSnapEnabled(bool isEnabled) { }

	public void SetMvVertexSnapTargetObjects(IEnumerable<GameObject> targetObjects) { }

	private void SetRotationHandlesVisible(bool visible) { }

	public void SetRtMidCapHoverable(bool hoverable) { }

	public void SetScaleGuideTargetObjects(IEnumerable<GameObject> targetObjects) { }

	private void SetScaleHandlesVisible(bool visible) { }

	public void SetSnapEnabled(bool isEnabled) { }

	private void SetupSharedLookAndFeel() { }

	private void SetupSharedSettings() { }

	private void Update2DGizmoPosition() { }

	private void Update2DModeHandlePositions() { }

	private void UpdateRtCamLookSlider(Camera camera) { }

}

