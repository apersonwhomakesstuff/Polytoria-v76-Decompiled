namespace RLD;

public class ObjectExtrudeGizmo : GizmoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Predicate<GameObject> <>9__61_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal bool <SetExtrudeTargets>b__61_0(GameObject item) { }

	}

	private struct HandleDragExtrudeData
	{
		public Vector3 ExtrudeDir; //Field offset: 0x0
		public Vector3 ExtrudeCenter; //Field offset: 0xC
		public int AxisIndex; //Field offset: 0x18

	}

	[CompilerGenerated]
	private ObjectExtrudeGizmoExtrudeUpdateHandler ExtrudeUpdate; //Field offset: 0x20
	private List<GameObject> _objectBuffer; //Field offset: 0x28
	private Vector3 _boxSize; //Field offset: 0x30
	private GizmoSpace _extrudeSpace; //Field offset: 0x3C
	private List<GameObject> _targetParents; //Field offset: 0x40
	private HashSet<GameObject> _ignoredParentObjects; //Field offset: 0x48
	private QueryConfig _boundsQConfig; //Field offset: 0x50
	private SceneOverlapFilter _sceneOverlapFilter; //Field offset: 0x60
	private ObjectExtrudeGizmoDragEnd _dragEndAction; //Field offset: 0x68
	private HandleDragExtrudeData _handleDragExtrData; //Field offset: 0x70
	private GizmoLineSlider3D _rightExtrude; //Field offset: 0x90
	private GizmoLineSlider3D _upExtrude; //Field offset: 0x98
	private GizmoLineSlider3D _frontExtrude; //Field offset: 0xA0
	private GizmoLineSlider3D _leftExtrude; //Field offset: 0xA8
	private GizmoLineSlider3D _bottomExtrude; //Field offset: 0xB0
	private GizmoLineSlider3D _backExtrude; //Field offset: 0xB8
	private GizmoLineSlider3DCollection _extrudeSliders; //Field offset: 0xC0
	[SerializeField]
	private ObjectExtrudeGizmoLookAndFeel3D _lookAndFeel3D; //Field offset: 0xC8
	private ObjectExtrudeGizmoLookAndFeel3D _sharedLookAndFeel3D; //Field offset: 0xD0
	[SerializeField]
	private ObjectExtrudeGizmoHotkeys _hotkeys; //Field offset: 0xD8
	private ObjectExtrudeGizmoHotkeys _sharedHotkeys; //Field offset: 0xE0

	public event ObjectExtrudeGizmoExtrudeUpdateHandler ExtrudeUpdate
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

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

	public Vector3 BoxSize
	{
		 get { } //Length: 19
	}

	public Vector3 BoxUp
	{
		 get { } //Length: 165
	}

	public GizmoSpace ExtrudeSpace
	{
		 get { } //Length: 4
	}

	public ObjectExtrudeGizmoHotkeys Hotkeys
	{
		 get { } //Length: 26
	}

	public ObjectExtrudeGizmoLookAndFeel3D LookAndFeel3D
	{
		 get { } //Length: 26
	}

	public int NumTargetParents
	{
		 get { } //Length: 60
	}

	public OBB OBB
	{
		 get { } //Length: 147
	}

	public ObjectExtrudeGizmoHotkeys SharedHotkeys
	{
		 get { } //Length: 8
		 set { } //Length: 19
	}

	public ObjectExtrudeGizmoLookAndFeel3D SharedLookAndFeel3D
	{
		 get { } //Length: 8
		 set { } //Length: 43
	}

	public ObjectExtrudeGizmo() { }

	[CompilerGenerated]
	public void add_ExtrudeUpdate(ObjectExtrudeGizmoExtrudeUpdateHandler value) { }

	public void FitBoxToTargets() { }

	public Vector3 get_BoxCenter() { }

	public Vector3 get_BoxLook() { }

	public Vector3 get_BoxRight() { }

	public Quaternion get_BoxRotation() { }

	public Vector3 get_BoxSize() { }

	public Vector3 get_BoxUp() { }

	public GizmoSpace get_ExtrudeSpace() { }

	public ObjectExtrudeGizmoHotkeys get_Hotkeys() { }

	public ObjectExtrudeGizmoLookAndFeel3D get_LookAndFeel3D() { }

	public int get_NumTargetParents() { }

	public OBB get_OBB() { }

	public ObjectExtrudeGizmoHotkeys get_SharedHotkeys() { }

	public ObjectExtrudeGizmoLookAndFeel3D get_SharedLookAndFeel3D() { }

	public bool IsBackExtrudeHandle(int handleId) { }

	public bool IsBottomExtrudeHandle(int handleId) { }

	public bool IsFrontExtrudeHandle(int handleId) { }

	public bool IsLeftExtrudeHandle(int handleId) { }

	public bool IsRightExtrudeHandle(int handleId) { }

	public bool IsTopExtrudeHandle(int handleId) { }

	public virtual void OnAttached() { }

	public virtual void OnDetached() { }

	public virtual void OnDisabled() { }

	public virtual void OnEnabled() { }

	public virtual void OnGizmoDragBegin(int handleId) { }

	public virtual void OnGizmoDragEnd(int handleId) { }

	public virtual void OnGizmoDragUpdate(int handleId) { }

	public virtual void OnGizmoEnabled() { }

	public virtual void OnGizmoRender(Camera camera) { }

	private void OnGizmoTransformChanged(GizmoTransform gizmoTransform, ChangeData changeData) { }

	public virtual void OnGizmoUpdateBegin() { }

	private void OnUndoRedoEnd(IUndoRedoAction action) { }

	public bool OwnsHandle(int handleId) { }

	[CompilerGenerated]
	public void remove_ExtrudeUpdate(ObjectExtrudeGizmoExtrudeUpdateHandler value) { }

	public void set_SharedHotkeys(ObjectExtrudeGizmoHotkeys value) { }

	public void set_SharedLookAndFeel3D(ObjectExtrudeGizmoLookAndFeel3D value) { }

	private void SetAABB(AABB aabb) { }

	public void SetExtrudeSpace(GizmoSpace extrudeSpace) { }

	public void SetExtrudeTargets(IEnumerable<GameObject> extrudeTargets) { }

	public void SetIgnoredParentObjects(IEnumerable<GameObject> ignoredParentObjects) { }

	private void SetOBB(OBB obb) { }

	private void SetupSharedLookAndFeel() { }

	private void UpdateExtrudeSliderTransforms() { }

	private void UpdateSnapSteps() { }

	private void ValidateBoxSize() { }

}

