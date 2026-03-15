namespace RLD;

public class RTObjectSelectionGizmos : MonoSingleton<RTObjectSelectionGizmos>, IObjectCollectionGizmoController
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass101_0
	{
		public Gizmo gizmo; //Field offset: 0x10

		public <>c__DisplayClass101_0() { }

		internal bool <GetGizmoId>b__0(ObjectSelectionGizmo item) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass102_0
	{
		public int id; //Field offset: 0x10

		public <>c__DisplayClass102_0() { }

		internal bool <GetTransformGizmoById>b__0(ObjectSelectionGizmo item) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass119_0
	{
		public int gizmoId; //Field offset: 0x10

		public <>c__DisplayClass119_0() { }

		internal bool <IsGizmoRegistered>b__0(ObjectSelectionGizmo item) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass120_0
	{
		public Gizmo gizmo; //Field offset: 0x10

		public <>c__DisplayClass120_0() { }

		internal bool <IsGizmoRegistered>b__0(ObjectSelectionGizmo item) { }

	}

	private class ObjectSelectionGizmo
	{
		private int _id; //Field offset: 0x10
		private Gizmo _gizmo; //Field offset: 0x18
		private BoxGizmo _boxScaleGizmo; //Field offset: 0x20
		private ObjectTransformGizmo _transformGizmo; //Field offset: 0x28
		private ObjectExtrudeGizmo _extrudeGizmo; //Field offset: 0x30
		private bool _isUsable; //Field offset: 0x38

		public BoxGizmo BoxScaleGizmo
		{
			 get { } //Length: 5
		}

		public ObjectExtrudeGizmo ExtrudeGizmo
		{
			 get { } //Length: 95
		}

		public Gizmo Gizmo
		{
			 get { } //Length: 5
		}

		public int Id
		{
			 get { } //Length: 4
		}

		public bool IsBoxScaleGizmo
		{
			 get { } //Length: 9
		}

		public bool IsExtrudeGizmo
		{
			 get { } //Length: 9
		}

		public bool IsTransformGizmo
		{
			 get { } //Length: 9
		}

		public bool IsUsable
		{
			 get { } //Length: 5
			 set { } //Length: 4
		}

		public ObjectTransformGizmo TransformGizmo
		{
			 get { } //Length: 5
		}

		public ObjectSelectionGizmo(int id, Gizmo gizmo) { }

		public BoxGizmo get_BoxScaleGizmo() { }

		public ObjectExtrudeGizmo get_ExtrudeGizmo() { }

		public Gizmo get_Gizmo() { }

		public int get_Id() { }

		public bool get_IsBoxScaleGizmo() { }

		public bool get_IsExtrudeGizmo() { }

		public bool get_IsTransformGizmo() { }

		public bool get_IsUsable() { }

		public ObjectTransformGizmo get_TransformGizmo() { }

		public void set_IsUsable(bool value) { }

	}

	[SerializeField]
	private EditorToolbar _mainToolbar; //Field offset: 0x20
	[SerializeField]
	private UniversalGizmoConfig _universalGizmoConfig; //Field offset: 0x28
	private GizmoCollectionEnabledStateSnapshot _gizmosEnabledStateSnapshot; //Field offset: 0x30
	private List<ObjectSelectionGizmo> _allGizmos; //Field offset: 0x38
	private List<ObjectTransformGizmo> _objectTransformGizmos; //Field offset: 0x40
	private int _workGizmoId; //Field offset: 0x48
	private ObjectSelectionGizmo _workGizmo; //Field offset: 0x50
	private bool _areGizmosVisible; //Field offset: 0x58
	private GizmoSpace _transformSpace; //Field offset: 0x5C
	private GameObject _pivotObject; //Field offset: 0x60
	private IEnumerable<GameObject> _targetObjectCollection; //Field offset: 0x68
	[SerializeField]
	private ObjectSelectionGizmosHotkeys _hotkeys; //Field offset: 0x70
	[SerializeField]
	private MoveGizmoSettings2D _moveGizmoSettings2D; //Field offset: 0x78
	[SerializeField]
	private MoveGizmoSettings3D _moveGizmoSettings3D; //Field offset: 0x80
	[SerializeField]
	private MoveGizmoLookAndFeel2D _moveGizmoLookAndFeel2D; //Field offset: 0x88
	[SerializeField]
	private MoveGizmoLookAndFeel3D _moveGizmoLookAndFeel3D; //Field offset: 0x90
	[SerializeField]
	private MoveGizmoHotkeys _moveGizmoHotkeys; //Field offset: 0x98
	[SerializeField]
	private ObjectTransformGizmoSettings _objectMoveGizmoSettings; //Field offset: 0xA0
	[SerializeField]
	private RotationGizmoSettings3D _rotationGizmoSettings3D; //Field offset: 0xA8
	[SerializeField]
	private RotationGizmoLookAndFeel3D _rotationGizmoLookAndFeel3D; //Field offset: 0xB0
	[SerializeField]
	private RotationGizmoHotkeys _rotationGizmoHotkeys; //Field offset: 0xB8
	[SerializeField]
	private ObjectTransformGizmoSettings _objectRotationGizmoSettings; //Field offset: 0xC0
	[SerializeField]
	private ScaleGizmoSettings3D _scaleGizmoSettings3D; //Field offset: 0xC8
	[SerializeField]
	private ScaleGizmoLookAndFeel3D _scaleGizmoLookAndFeel3D; //Field offset: 0xD0
	[SerializeField]
	private ScaleGizmoHotkeys _scaleGizmoHotkeys; //Field offset: 0xD8
	[SerializeField]
	private ObjectTransformGizmoSettings _objectScaleGizmoSettings; //Field offset: 0xE0
	[SerializeField]
	private UniversalGizmoSettings2D _universalGizmoSettings2D; //Field offset: 0xE8
	[SerializeField]
	private UniversalGizmoSettings3D _universalGizmoSettings3D; //Field offset: 0xF0
	[SerializeField]
	private UniversalGizmoLookAndFeel2D _universalGizmoLookAndFeel2D; //Field offset: 0xF8
	[SerializeField]
	private UniversalGizmoLookAndFeel3D _universalGizmoLookAndFeel3D; //Field offset: 0x100
	[SerializeField]
	private UniversalGizmoHotkeys _universalGizmoHotkeys; //Field offset: 0x108
	[SerializeField]
	private ObjectTransformGizmoSettings _objectUniversalGizmoSettings; //Field offset: 0x110
	[SerializeField]
	private BoxGizmoSettings3D _boxScaleGizmoSettings3D; //Field offset: 0x118
	[SerializeField]
	private BoxGizmoLookAndFeel3D _boxScaleGizmoLookAndFeel3D; //Field offset: 0x120
	[SerializeField]
	private BoxGizmoHotkeys _boxScaleGizmoHotkeys; //Field offset: 0x128
	[SerializeField]
	private ObjectExtrudeGizmoLookAndFeel3D _extrudeGizmoLookAndFeel3D; //Field offset: 0x130
	[SerializeField]
	private ObjectExtrudeGizmoHotkeys _extrudeGizmoHotkeys; //Field offset: 0x138

	public bool AreGizmosVisible
	{
		 get { } //Length: 5
	}

	public BoxGizmoHotkeys BoxScaleGizmoHotkeys
	{
		 get { } //Length: 8
	}

	public BoxGizmoLookAndFeel3D BoxScaleGizmoLookAndFeel3D
	{
		 get { } //Length: 8
	}

	public BoxGizmoSettings3D BoxScaleGizmoSettings3D
	{
		 get { } //Length: 8
	}

	public ObjectExtrudeGizmoLookAndFeel3D ExtrudeGizmoLookAndFeel3D
	{
		 get { } //Length: 8
	}

	public ObjectExtrudeGizmoHotkeys ExtrudeGozmoHotkeys
	{
		 get { } //Length: 8
	}

	public ObjectSelectionGizmosHotkeys Hotkeys
	{
		 get { } //Length: 5
	}

	public MoveGizmoHotkeys MoveGizmoHotkeys
	{
		 get { } //Length: 8
	}

	public MoveGizmoLookAndFeel2D MoveGizmoLookAndFeel2D
	{
		 get { } //Length: 8
	}

	public MoveGizmoLookAndFeel3D MoveGizmoLookAndFeel3D
	{
		 get { } //Length: 8
	}

	public MoveGizmoSettings2D MoveGizmoSettings2D
	{
		 get { } //Length: 5
	}

	public MoveGizmoSettings3D MoveGizmoSettings3D
	{
		 get { } //Length: 8
	}

	public ObjectTransformGizmoSettings ObjectMoveGizmoSettings
	{
		 get { } //Length: 8
	}

	public ObjectTransformGizmoSettings ObjectRotationGizmoSettings
	{
		 get { } //Length: 8
	}

	public ObjectTransformGizmoSettings ObjectScaleGizmoSettings
	{
		 get { } //Length: 8
	}

	public ObjectTransformGizmoSettings ObjectUniversalGizmoSettings
	{
		 get { } //Length: 8
	}

	public GameObject PivotObject
	{
		 get { } //Length: 5
	}

	public RotationGizmoHotkeys RotationGizmoHotkeys
	{
		 get { } //Length: 8
	}

	public RotationGizmoLookAndFeel3D RotationGizmoLookAndFeel3D
	{
		 get { } //Length: 8
	}

	public RotationGizmoSettings3D RotationGizmoSettings3D
	{
		 get { } //Length: 8
	}

	public ScaleGizmoHotkeys ScaleGizmoHotkeys
	{
		 get { } //Length: 8
	}

	public ScaleGizmoLookAndFeel3D ScaleGizmoLookAndFeel3D
	{
		 get { } //Length: 8
	}

	public ScaleGizmoSettings3D ScaleGizmoSettings3D
	{
		 get { } //Length: 8
	}

	public UniversalGizmoHotkeys UniversalGizmoHotkeys
	{
		 get { } //Length: 8
	}

	public UniversalGizmoLookAndFeel2D UniversalGizmoLookAndFeel2D
	{
		 get { } //Length: 8
	}

	public UniversalGizmoLookAndFeel3D UniversalGizmoLookAndFeel3D
	{
		 get { } //Length: 8
	}

	public UniversalGizmoSettings2D UniversalGizmoSettings2D
	{
		 get { } //Length: 8
	}

	public UniversalGizmoSettings3D UniversalGizmoSettings3D
	{
		 get { } //Length: 8
	}

	public Gizmo WorkGizmo
	{
		 get { } //Length: 27
	}

	public RTObjectSelectionGizmos() { }

	public bool get_AreGizmosVisible() { }

	public BoxGizmoHotkeys get_BoxScaleGizmoHotkeys() { }

	public BoxGizmoLookAndFeel3D get_BoxScaleGizmoLookAndFeel3D() { }

	public BoxGizmoSettings3D get_BoxScaleGizmoSettings3D() { }

	public ObjectExtrudeGizmoLookAndFeel3D get_ExtrudeGizmoLookAndFeel3D() { }

	public ObjectExtrudeGizmoHotkeys get_ExtrudeGozmoHotkeys() { }

	public ObjectSelectionGizmosHotkeys get_Hotkeys() { }

	public MoveGizmoHotkeys get_MoveGizmoHotkeys() { }

	public MoveGizmoLookAndFeel2D get_MoveGizmoLookAndFeel2D() { }

	public MoveGizmoLookAndFeel3D get_MoveGizmoLookAndFeel3D() { }

	public MoveGizmoSettings2D get_MoveGizmoSettings2D() { }

	public MoveGizmoSettings3D get_MoveGizmoSettings3D() { }

	public ObjectTransformGizmoSettings get_ObjectMoveGizmoSettings() { }

	public ObjectTransformGizmoSettings get_ObjectRotationGizmoSettings() { }

	public ObjectTransformGizmoSettings get_ObjectScaleGizmoSettings() { }

	public ObjectTransformGizmoSettings get_ObjectUniversalGizmoSettings() { }

	public GameObject get_PivotObject() { }

	public RotationGizmoHotkeys get_RotationGizmoHotkeys() { }

	public RotationGizmoLookAndFeel3D get_RotationGizmoLookAndFeel3D() { }

	public RotationGizmoSettings3D get_RotationGizmoSettings3D() { }

	public ScaleGizmoHotkeys get_ScaleGizmoHotkeys() { }

	public ScaleGizmoLookAndFeel3D get_ScaleGizmoLookAndFeel3D() { }

	public ScaleGizmoSettings3D get_ScaleGizmoSettings3D() { }

	public UniversalGizmoHotkeys get_UniversalGizmoHotkeys() { }

	public UniversalGizmoLookAndFeel2D get_UniversalGizmoLookAndFeel2D() { }

	public UniversalGizmoLookAndFeel3D get_UniversalGizmoLookAndFeel3D() { }

	public UniversalGizmoSettings2D get_UniversalGizmoSettings2D() { }

	public UniversalGizmoSettings3D get_UniversalGizmoSettings3D() { }

	public Gizmo get_WorkGizmo() { }

	public List<Gizmo> GetAllGizmos() { }

	public Gizmo GetGizmoById(int gizmoId) { }

	public int GetGizmoId(Gizmo gizmo) { }

	private ObjectSelectionGizmo GetObjectSelectionGizmo(Gizmo gizmo) { }

	private ObjectSelectionGizmo GetObjectSelectionGizmo(int id) { }

	public ObjectTransformGizmo GetTransformGizmoById(int id) { }

	public void Initialize_SystemCall() { }

	private bool IsGizmoRegistered(Gizmo gizmo) { }

	private bool IsGizmoRegistered(int gizmoId) { }

	private void OnGizmoPostEnabled(Gizmo gizmo) { }

	private void OnObjectSelectionChanged(ObjectSelectionChangedEventArgs args) { }

	private void OnObjectSelectionDisabled() { }

	private void OnObjectSelectionEnabled() { }

	private void OnObjectSelectionManipSessionBegin(ObjectSelectionManipSession manipSession) { }

	private void OnObjectSelectionManipSessionEnd(ObjectSelectionManipSession manipSession) { }

	private void OnObjectSelectionRotated() { }

	private void OnTargetObjectGroupUpdated() { }

	private void OnUndoRedo(IUndoRedoAction action) { }

	private bool RegisterGizmo(int gizmoId, Gizmo gizmo) { }

	public void SetGizmosVisisble(bool visible) { }

	public void SetGizmoUsable(int gizmoId, bool isUsable) { }

	public override void SetTargetObjectCollection(IEnumerable<GameObject> targetObjectCollection) { }

	public void SetTransformPivot(GizmoObjectTransformPivot transformPivot) { }

	public void SetTransformSpace(GizmoSpace transformSpace) { }

	public void SetWorkGizmo(int gizmoId) { }

	public void Update_SystemCall() { }

}

