namespace RLD;

public class ObjectTransformGizmo : GizmoBehaviour
{
	[Flags]
	internal enum Channels : int
	{
		None = 0,
		Position = 1,
		Rotation = 2,
		Scale = 4,
		All = 7,
	}

	internal class ObjectRestrictions
	{
		private Boolean[] _moveAxesMask; //Field offset: 0x10
		private Boolean[] _scaleAxesMask; //Field offset: 0x18
		private HashSet<Int32> _handleMask; //Field offset: 0x20

		public ObjectRestrictions() { }

		public Vector3 AdjustMoveVector(Vector3 moveVector) { }

		public Vector3 AdjustScaleVector(Vector3 scaleVector) { }

		public bool CanMoveAlongAllAxes() { }

		public bool CanMoveAlongAxis(int axisIndex) { }

		public bool CanScaleAlongAllAxes() { }

		public bool CanScaleAlongAxis(int axisIndex) { }

		public bool IsAffectedByHandle(int handleId) { }

		public void SetCanMoveAlongAxis(int axisIndex, bool canMove) { }

		public void SetCanScaleAlongAxis(int axisIndex, bool canScale) { }

		public void SetIsAffectedByHandle(int handleId, bool isAffected) { }

	}

	private enum TargetObjectMode : int
	{
		Multiple = 0,
		Single = 1,
	}

	private TargetObjectMode _targetObjectMode; //Field offset: 0x20
	private Channels _transformChannelFlags; //Field offset: 0x24
	private IEnumerable<GameObject> _targetObjects; //Field offset: 0x28
	private GameObject _targetPivotObject; //Field offset: 0x30
	private List<LocalTransformSnapshot> _preTransformSnapshots; //Field offset: 0x38
	private List<GameObject> _transformableParents; //Field offset: 0x40
	private AABB _targetGroupAABBOnDragBegin; //Field offset: 0x48
	private GizmoSpace _transformSpace; //Field offset: 0x64
	private bool _isTransformSpacePermanent; //Field offset: 0x68
	private GizmoObjectTransformPivot _transformPivot; //Field offset: 0x6C
	private bool _isTransformPivotPermanent; //Field offset: 0x70
	private bool _scaleConstraintEnabled; //Field offset: 0x71
	private Vector3 _minPositiveScale; //Field offset: 0x74
	private Vector3 _customWorldPivot; //Field offset: 0x80
	private Dictionary<GameObject, Vector3> _objectToCustomLocalPivot; //Field offset: 0x90
	private Dictionary<GameObject, ObjectRestrictions> _objectToRestrictions; //Field offset: 0x98
	[SerializeField]
	private ObjectTransformGizmoSettings _settings; //Field offset: 0xA0
	private ObjectTransformGizmoSettings _sharedSettings; //Field offset: 0xA8

	public bool CanAffectPosition
	{
		 get { } //Length: 7
	}

	public bool CanAffectRotation
	{
		 get { } //Length: 8
	}

	public bool CanAffectScale
	{
		 get { } //Length: 8
	}

	public Vector3 CustomWorldPivot
	{
		 get { } //Length: 25
	}

	public bool IsTransformPivotPermanent
	{
		 get { } //Length: 5
	}

	public bool IsTransformSpacePermanent
	{
		 get { } //Length: 5
	}

	public Vector3 MinPositiveScale
	{
		 get { } //Length: 19
		 set { } //Length: 99
	}

	public bool ScaleConstraintEnabled
	{
		 get { } //Length: 5
		 set { } //Length: 4
	}

	public ObjectTransformGizmoSettings Settings
	{
		 get { } //Length: 26
	}

	public ObjectTransformGizmoSettings SharedSettings
	{
		 get { } //Length: 8
		 set { } //Length: 19
	}

	public Channels TransformChannelFlags
	{
		 get { } //Length: 4
	}

	public GizmoObjectTransformPivot TransformPivot
	{
		 get { } //Length: 4
	}

	public GizmoSpace TransformSpace
	{
		 get { } //Length: 4
	}

	public ObjectTransformGizmo() { }

	public bool ContainsRestrictionsForObject(GameObject targetObject) { }

	public bool get_CanAffectPosition() { }

	public bool get_CanAffectRotation() { }

	public bool get_CanAffectScale() { }

	public Vector3 get_CustomWorldPivot() { }

	public bool get_IsTransformPivotPermanent() { }

	public bool get_IsTransformSpacePermanent() { }

	public Vector3 get_MinPositiveScale() { }

	public bool get_ScaleConstraintEnabled() { }

	public ObjectTransformGizmoSettings get_Settings() { }

	public ObjectTransformGizmoSettings get_SharedSettings() { }

	public Channels get_TransformChannelFlags() { }

	public GizmoObjectTransformPivot get_TransformPivot() { }

	public GizmoSpace get_TransformSpace() { }

	public int GetNumTransformableParentObjects() { }

	private QueryConfig GetObjectBoundsQConfig() { }

	public Vector3 GetObjectCustomLocalPivot(GameObject gameObj) { }

	public ObjectRestrictions GetObjectRestrictions(GameObject targetObject) { }

	public AABB GetTargetObjectGroupWorldAABB() { }

	private List<GameObject> GetTransformableParentObjects() { }

	public void MakeTransformPivotPermanent() { }

	public void MakeTransformSpacePermanent() { }

	private void MoveObject(GameObject gameObject, Vector3 moveVector) { }

	private void MoveObjects(Vector3 moveVector) { }

	public virtual void OnAttached() { }

	public virtual void OnDetached() { }

	public virtual void OnGizmoDragBegin(int handleId) { }

	public virtual void OnGizmoDragEnd(int handleId) { }

	public virtual void OnGizmoDragUpdate(int handleId) { }

	private void OnUndoRedoEnd(IUndoRedoAction action) { }

	public void RefreshPosition() { }

	public void RefreshPositionAndRotation() { }

	public void RefreshRotation() { }

	public void RegisterObjectRestrictions(List<GameObject> targetObjects, ObjectRestrictions restrictions) { }

	public void RegisterObjectRestrictions(GameObject targetObject, ObjectRestrictions restrictions) { }

	private void RotateObject(GameObject gameObject, Quaternion rotation, Vector3 rotationPivot) { }

	private void RotateObjects(Quaternion rotation) { }

	private void ScaleObject(GameObject gameObject, Vector3 scalePivot) { }

	private void ScaleObjects() { }

	public void set_MinPositiveScale(Vector3 value) { }

	public void set_ScaleConstraintEnabled(bool value) { }

	public void set_SharedSettings(ObjectTransformGizmoSettings value) { }

	public void SetCanAffectPosition(bool affectPosition) { }

	public void SetCanAffectRotation(bool affectRotation) { }

	public void SetCanAffectScale(bool affectScale) { }

	public void SetCustomWorldPivot(Vector3 pivot) { }

	public void SetObjectCustomLocalPivot(GameObject gameObj, Vector3 pivot) { }

	public void SetTargetObject(GameObject targetObject) { }

	public void SetTargetObjects(IEnumerable<GameObject> targetObjects) { }

	public void SetTargetPivotObject(GameObject targetPivotObject) { }

	public void SetTransformChannelFlags(Channels flags) { }

	public void SetTransformPivot(GizmoObjectTransformPivot transformPivot) { }

	public void SetTransformSpace(GizmoSpace transformSpace) { }

	public void UnregisterObjectRestrictions(GameObject targetObject) { }

}

