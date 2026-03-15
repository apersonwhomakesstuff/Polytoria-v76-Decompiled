namespace RLD;

public class ScaleGizmo : GizmoBehaviour
{
	private GizmoLineSlider3D _pstvXSlider; //Field offset: 0x20
	private GizmoLineSlider3D _pstvYSlider; //Field offset: 0x28
	private GizmoLineSlider3D _pstvZSlider; //Field offset: 0x30
	private GizmoLineSlider3D _negXSlider; //Field offset: 0x38
	private GizmoLineSlider3D _negYSlider; //Field offset: 0x40
	private GizmoLineSlider3D _negZSlider; //Field offset: 0x48
	private GizmoLineSlider3DCollection _axesSliders; //Field offset: 0x50
	private GizmoMultiAxisScaleMode _multiAxisScaleMode; //Field offset: 0x58
	private GizmoPlaneSlider3D _xySlider; //Field offset: 0x60
	private GizmoPlaneSlider3D _yzSlider; //Field offset: 0x68
	private GizmoPlaneSlider3D _zxSlider; //Field offset: 0x70
	private GizmoPlaneSlider3DCollection _dblSliders; //Field offset: 0x78
	private GizmoCap3D _midCap; //Field offset: 0x80
	private GizmoUniformScaleDrag3D _unformScaleDrag; //Field offset: 0x88
	private GizmoScaleGuide _scaleGuide; //Field offset: 0x90
	private IEnumerable<GameObject> _scaleGuideTargetObjects; //Field offset: 0x98
	[SerializeField]
	private ScaleGizmoLookAndFeel3D _lookAndFeel3D; //Field offset: 0xA0
	[SerializeField]
	private ScaleGizmoSettings3D _settings3D; //Field offset: 0xA8
	[SerializeField]
	private ScaleGizmoHotkeys _hotkeys; //Field offset: 0xB0
	[SerializeField]
	private bool _useSnapEnableHotkey; //Field offset: 0xB8
	[SerializeField]
	private bool _useMultiAxisScaleModeHotkey; //Field offset: 0xB9
	private ScaleGizmoLookAndFeel3D _sharedLookAndFeel3D; //Field offset: 0xC0
	private ScaleGizmoSettings3D _sharedSettings3D; //Field offset: 0xC8
	private ScaleGizmoHotkeys _sharedHotkeys; //Field offset: 0xD0

	public ScaleGizmoHotkeys Hotkeys
	{
		 get { } //Length: 26
	}

	public ScaleGizmoLookAndFeel3D LookAndFeel3D
	{
		 get { } //Length: 26
	}

	public GizmoMultiAxisScaleMode MultiAxisScaleMode
	{
		 get { } //Length: 4
	}

	public ScaleGizmoSettings3D Settings3D
	{
		 get { } //Length: 26
	}

	public ScaleGizmoHotkeys SharedHotkeys
	{
		 get { } //Length: 8
		 set { } //Length: 109
	}

	public ScaleGizmoLookAndFeel3D SharedLookAndFeel3D
	{
		 get { } //Length: 8
		 set { } //Length: 43
	}

	public ScaleGizmoSettings3D SharedSettings3D
	{
		 get { } //Length: 8
		 set { } //Length: 43
	}

	public bool UseMultiAxisScaleModeHotkey
	{
		 get { } //Length: 8
		 set { } //Length: 7
	}

	public bool UseSnapEnableHotkey
	{
		 get { } //Length: 8
		 set { } //Length: 7
	}

	public ScaleGizmo() { }

	public ScaleGizmoHotkeys get_Hotkeys() { }

	public ScaleGizmoLookAndFeel3D get_LookAndFeel3D() { }

	public GizmoMultiAxisScaleMode get_MultiAxisScaleMode() { }

	public ScaleGizmoSettings3D get_Settings3D() { }

	public ScaleGizmoHotkeys get_SharedHotkeys() { }

	public ScaleGizmoLookAndFeel3D get_SharedLookAndFeel3D() { }

	public ScaleGizmoSettings3D get_SharedSettings3D() { }

	public bool get_UseMultiAxisScaleModeHotkey() { }

	public bool get_UseSnapEnableHotkey() { }

	public float GetZoomFactor(Vector3 position, Camera camera) { }

	public float GetZoomFactor(Vector3 position) { }

	public virtual void OnAttached() { }

	public virtual void OnGizmoAttemptHandleDragBegin(int handleId) { }

	public virtual void OnGizmoEnabled() { }

	public virtual void OnGizmoRender(Camera camera) { }

	public virtual void OnGizmoUpdateBegin() { }

	public bool OwnsHandle(int handleId) { }

	private void PlaceDblSlidersInSliderPlanes(Camera camera) { }

	public void set_SharedHotkeys(ScaleGizmoHotkeys value) { }

	public void set_SharedLookAndFeel3D(ScaleGizmoLookAndFeel3D value) { }

	public void set_SharedSettings3D(ScaleGizmoSettings3D value) { }

	public void set_UseMultiAxisScaleModeHotkey(bool value) { }

	public void set_UseSnapEnableHotkey(bool value) { }

	public void SetAxesLinesHoverable(bool hoverable) { }

	public void SetMultiAxisScaleMode(GizmoMultiAxisScaleMode scaleMode) { }

	public void SetScaleGuideTargetObjects(IEnumerable<GameObject> targetObjects) { }

	public void SetSnapEnabled(bool isEnabled) { }

	private void SetupSharedLookAndFeel() { }

	private void SetupSharedSettings() { }

}

