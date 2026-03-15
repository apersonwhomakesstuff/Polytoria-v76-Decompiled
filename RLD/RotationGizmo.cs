namespace RLD;

public class RotationGizmo : GizmoBehaviour
{
	private GizmoPlaneSlider3D _xSlider; //Field offset: 0x20
	private GizmoPlaneSlider3D _ySlider; //Field offset: 0x28
	private GizmoPlaneSlider3D _zSlider; //Field offset: 0x30
	private GizmoPlaneSlider3DCollection _axesSliders; //Field offset: 0x38
	private GizmoCap3D _midCap; //Field offset: 0x40
	private GizmoDblAxisRotationDrag3D _camXYRotationDrag; //Field offset: 0x48
	private GizmoPlaneSlider2D _camLookSlider; //Field offset: 0x50
	[SerializeField]
	private RotationGizmoHotkeys _hotkeys; //Field offset: 0x58
	[SerializeField]
	private RotationGizmoSettings3D _settings3D; //Field offset: 0x60
	[SerializeField]
	private RotationGizmoLookAndFeel3D _lookAndFeel3D; //Field offset: 0x68
	[SerializeField]
	private bool _useSnapEnableHotkey; //Field offset: 0x70
	private RotationGizmoHotkeys _sharedHotkeys; //Field offset: 0x78
	private RotationGizmoSettings3D _sharedSettings3D; //Field offset: 0x80
	private RotationGizmoLookAndFeel3D _sharedLookAndFeel3D; //Field offset: 0x88

	public RotationGizmoHotkeys Hotkeys
	{
		 get { } //Length: 17
	}

	public RotationGizmoLookAndFeel3D LookAndFeel3D
	{
		 get { } //Length: 23
	}

	public RotationGizmoSettings3D Settings3D
	{
		 get { } //Length: 23
	}

	public RotationGizmoHotkeys SharedHotkeys
	{
		 get { } //Length: 5
		 set { } //Length: 13
	}

	public RotationGizmoLookAndFeel3D SharedLookAndFeel3D
	{
		 get { } //Length: 8
		 set { } //Length: 43
	}

	public RotationGizmoSettings3D SharedSettings3D
	{
		 get { } //Length: 8
		 set { } //Length: 40
	}

	public bool UseSnapEnableHotkey
	{
		 get { } //Length: 5
		 set { } //Length: 4
	}

	public RotationGizmo() { }

	public RotationGizmoHotkeys get_Hotkeys() { }

	public RotationGizmoLookAndFeel3D get_LookAndFeel3D() { }

	public RotationGizmoSettings3D get_Settings3D() { }

	public RotationGizmoHotkeys get_SharedHotkeys() { }

	public RotationGizmoLookAndFeel3D get_SharedLookAndFeel3D() { }

	public RotationGizmoSettings3D get_SharedSettings3D() { }

	public bool get_UseSnapEnableHotkey() { }

	public float GetZoomFactor(Vector3 position, Camera camera) { }

	public float GetZoomFactor(Vector3 position) { }

	public virtual void OnAttached() { }

	public virtual void OnDetached() { }

	public virtual void OnDisabled() { }

	public virtual void OnEnabled() { }

	public virtual void OnGizmoAttemptHandleDragBegin(int handleId) { }

	public virtual void OnGizmoEnabled() { }

	public virtual void OnGizmoRender(Camera camera) { }

	private void OnGizmoTransformChanged(GizmoTransform gizmoTransform, ChangeData changeData) { }

	public virtual void OnGizmoUpdateBegin() { }

	public bool OwnsHandle(int handleId) { }

	public void set_SharedHotkeys(RotationGizmoHotkeys value) { }

	public void set_SharedLookAndFeel3D(RotationGizmoLookAndFeel3D value) { }

	public void set_SharedSettings3D(RotationGizmoSettings3D value) { }

	public void set_UseSnapEnableHotkey(bool value) { }

	public void SetMidCapHoverable(bool hoverable) { }

	public void SetSnapEnabled(bool isEnabled) { }

	private void SetupSharedLookAndFeel() { }

	private void SetupSharedSettings() { }

	private void UpdateCamLookSlider(Camera camera) { }

}

