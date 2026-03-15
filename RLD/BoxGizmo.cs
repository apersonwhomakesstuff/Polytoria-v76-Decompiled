namespace RLD;

public class BoxGizmo : GizmoBehaviour
{
	internal enum Usage : int
	{
		Generic = 0,
		ObjectScale = 1,
	}

	private Usage _usage; //Field offset: 0x20
	private bool _isUsagePermanent; //Field offset: 0x24
	private Vector3 _boxSize; //Field offset: 0x28
	private GameObject _targetHierarchy; //Field offset: 0x38
	private Transform _targetHierarchyTransform; //Field offset: 0x40
	private LocalTransformSnapshot _dragBeginTargetTransformSnapshot; //Field offset: 0x48
	private GizmoCap2D _rightTick; //Field offset: 0x50
	private GizmoCap2D _topTick; //Field offset: 0x58
	private GizmoCap2D _backTick; //Field offset: 0x60
	private GizmoCap2D _leftTick; //Field offset: 0x68
	private GizmoCap2D _bottomTick; //Field offset: 0x70
	private GizmoCap2D _frontTick; //Field offset: 0x78
	private GizmoCap2DCollection _ticks; //Field offset: 0x80
	private bool _scaleFromCenter; //Field offset: 0x88
	private Vector3 _scalePivot; //Field offset: 0x8C
	private WorkData _scaleDragWorkData; //Field offset: 0x98
	private GizmoSglAxisScaleDrag3D _scaleDrag; //Field offset: 0xC0
	[SerializeField]
	private BoxGizmoSettings3D _settings3D; //Field offset: 0xC8
	private BoxGizmoSettings3D _sharedSettings3D; //Field offset: 0xD0
	[SerializeField]
	private BoxGizmoLookAndFeel3D _lookAndFeel3D; //Field offset: 0xD8
	private BoxGizmoLookAndFeel3D _sharedLookAndFeel3D; //Field offset: 0xE0
	private BoxGizmoHotkeys _hotkeys; //Field offset: 0xE8
	private BoxGizmoHotkeys _sharedHotkeys; //Field offset: 0xF0

	public Vector3 BoxCenter
	{
		 get { } //Length: 53
	}

	public Vector3 BoxLook
	{
		 get { } //Length: 165
	}

	public Vector3 BoxRight
	{
		 get { } //Length: 165
	}

	public Quaternion BoxRotation
	{
		 get { } //Length: 45
	}

	public Vector3 BoxUp
	{
		 get { } //Length: 165
	}

	public Usage BoxUsage
	{
		 get { } //Length: 4
	}

	public BoxGizmoHotkeys Hotkeys
	{
		 get { } //Length: 26
	}

	public bool IsUsagePermanent
	{
		 get { } //Length: 5
	}

	public BoxGizmoLookAndFeel3D LookAndFeel3D
	{
		 get { } //Length: 26
	}

	public BoxGizmoSettings3D Settings3D
	{
		 get { } //Length: 26
	}

	public BoxGizmoHotkeys SharedHotkeys
	{
		 get { } //Length: 8
		 set { } //Length: 19
	}

	public BoxGizmoLookAndFeel3D SharedLookAndFeel3D
	{
		 get { } //Length: 8
		 set { } //Length: 43
	}

	public BoxGizmoSettings3D SharedSettings3D
	{
		 get { } //Length: 8
		 set { } //Length: 19
	}

	public BoxGizmo() { }

	private OBB CalcTargetRootOBB(GameObject targetRoot) { }

	public bool FitBoxToTargetHierarchy() { }

	public Vector3 get_BoxCenter() { }

	public Vector3 get_BoxLook() { }

	public Vector3 get_BoxRight() { }

	public Quaternion get_BoxRotation() { }

	public Vector3 get_BoxUp() { }

	public Usage get_BoxUsage() { }

	public BoxGizmoHotkeys get_Hotkeys() { }

	public bool get_IsUsagePermanent() { }

	public BoxGizmoLookAndFeel3D get_LookAndFeel3D() { }

	public BoxGizmoSettings3D get_Settings3D() { }

	public BoxGizmoHotkeys get_SharedHotkeys() { }

	public BoxGizmoLookAndFeel3D get_SharedLookAndFeel3D() { }

	public BoxGizmoSettings3D get_SharedSettings3D() { }

	public bool IsXTick(int handleId) { }

	public bool IsYTick(int handleId) { }

	public bool IsZTick(int handleId) { }

	public void MakeUsagePermanent() { }

	public virtual void OnAttached() { }

	public virtual void OnDetached() { }

	public virtual void OnDisabled() { }

	public virtual void OnEnabled() { }

	public virtual void OnGizmoAttemptHandleDragBegin(int handleId) { }

	public virtual bool OnGizmoCanBeginDrag(int handleId) { }

	public virtual void OnGizmoDragEnd(int handleId) { }

	public virtual void OnGizmoDragUpdate(int handleId) { }

	public virtual void OnGizmoEnabled() { }

	public virtual void OnGizmoRender(Camera camera) { }

	private void OnGizmoTransformChanged(GizmoTransform gizmoTransform, ChangeData changeData) { }

	public virtual void OnGizmoUpdateBegin() { }

	private void OnUndoRedoEnd(IUndoRedoAction action) { }

	public bool OwnsHandle(int handleId) { }

	public void set_SharedHotkeys(BoxGizmoHotkeys value) { }

	public void set_SharedLookAndFeel3D(BoxGizmoLookAndFeel3D value) { }

	public void set_SharedSettings3D(BoxGizmoSettings3D value) { }

	public void SetSize(Vector3 size) { }

	public void SetSnapEnabled(bool isEnabled) { }

	public bool SetTargetHierarchy(GameObject targetHierarchy) { }

	private void SetupSharedLookAndFeel() { }

	private void SetupSharedSettings() { }

	public void SetUsage(Usage usage) { }

	private void UpdateTickPositions() { }

	private void ValidateBoxSize() { }

}

