namespace RLD;

public class RTGizmosEngine : MonoSingleton<RTGizmosEngine>, IHoverableSceneEntityContainer
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass56_0
	{
		public Gizmo gizmo; //Field offset: 0x10
		public Vector3 screenRayOrigin; //Field offset: 0x18

		public <>c__DisplayClass56_0() { }

		internal int <GetGizmoHandleHoverData>b__0(GizmoHandleHoverData h0, GizmoHandleHoverData h1) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass57_0
	{
		public Vector3 camPos; //Field offset: 0x10

		public <>c__DisplayClass57_0() { }

		internal int <Render_SystemCall>b__0(Gizmo g0, Gizmo g1) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass58_0
	{
		public Vector3 inputDevicePos; //Field offset: 0x10
		public Ray hoverRay; //Field offset: 0x1C

		public <>c__DisplayClass58_0() { }

		internal int <SortHandleHoverDataCollection>b__0(GizmoHandleHoverData h0, GizmoHandleHoverData h1) { }

	}

	[CompilerGenerated]
	private GizmoEngineCanDoHoverUpdateHandler CanDoHoverUpdate; //Field offset: 0x20
	[SerializeField]
	private EditorToolbar _mainToolbar; //Field offset: 0x28
	[SerializeField]
	private GizmoEngineSettings _settings; //Field offset: 0x30
	private GizmosEnginePipelineStage _pipelineStage; //Field offset: 0x38
	private Gizmo _draggedGizmo; //Field offset: 0x40
	private bool _justReleasedDrag; //Field offset: 0x48
	private Gizmo _hoveredGizmo; //Field offset: 0x50
	private GizmoHoverInfo _gizmoHoverInfo; //Field offset: 0x58
	private List<Gizmo> _gizmos; //Field offset: 0x70
	private List<ISceneGizmo> _sceneGizmos; //Field offset: 0x78
	private List<RTSceneGizmoCamera> _sceneGizmoCameras; //Field offset: 0x80
	private List<Camera> _renderCameras; //Field offset: 0x88
	[SerializeField]
	private SceneGizmoLookAndFeel _sharedSceneGizmoLookAndFeel; //Field offset: 0x90

	public event GizmoEngineCanDoHoverUpdateHandler CanDoHoverUpdate
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public Gizmo DraggedGizmo
	{
		 get { } //Length: 5
	}

	public override bool HasHoveredSceneEntity
	{
		 get { } //Length: 9
	}

	public Gizmo HoveredGizmo
	{
		 get { } //Length: 5
	}

	public bool IsAnyGizmoHovered
	{
		 get { } //Length: 9
	}

	public bool JustReleasedDrag
	{
		 get { } //Length: 5
	}

	public int NumRenderCameras
	{
		 get { } //Length: 63
	}

	public GizmosEnginePipelineStage PipelineStage
	{
		 get { } //Length: 4
	}

	public Camera RenderStageCamera
	{
		 get { } //Length: 96
	}

	public GizmoEngineSettings Settings
	{
		 get { } //Length: 95
	}

	public SceneGizmoLookAndFeel SharedSceneGizmoLookAndFeel
	{
		 get { } //Length: 8
	}

	public RTGizmosEngine() { }

	[CompilerGenerated]
	public void add_CanDoHoverUpdate(GizmoEngineCanDoHoverUpdateHandler value) { }

	public void AddRenderCamera(Camera camera) { }

	public BoxGizmo CreateBoxGizmo() { }

	public Gizmo CreateGizmo() { }

	public MoveGizmo CreateMoveGizmo() { }

	public BoxGizmo CreateObjectBoxScaleGizmo() { }

	public ObjectExtrudeGizmo CreateObjectExtrudeGizmo() { }

	public ObjectTransformGizmo CreateObjectMoveGizmo() { }

	public ObjectTransformGizmo CreateObjectRotationGizmo() { }

	public ObjectTransformGizmo CreateObjectScaleGizmo() { }

	public ObjectTransformGizmo CreateObjectUniversalGizmo() { }

	public RotationGizmo CreateRotationGizmo() { }

	public ScaleGizmo CreateScaleGizmo() { }

	public SceneGizmo CreateSceneGizmo(Camera sceneCamera) { }

	public RTSceneGizmoCamera CreateSceneGizmoCamera(Camera sceneCamera, ISceneGizmoCamViewportUpdater viewportUpdater) { }

	public UniversalGizmo CreateUniversalGizmo() { }

	public Gizmo get_DraggedGizmo() { }

	public override bool get_HasHoveredSceneEntity() { }

	public Gizmo get_HoveredGizmo() { }

	public bool get_IsAnyGizmoHovered() { }

	public bool get_JustReleasedDrag() { }

	public int get_NumRenderCameras() { }

	public GizmosEnginePipelineStage get_PipelineStage() { }

	public Camera get_RenderStageCamera() { }

	public GizmoEngineSettings get_Settings() { }

	public SceneGizmoLookAndFeel get_SharedSceneGizmoLookAndFeel() { }

	public GizmoHandleHoverData GetGizmoHandleHoverData(Gizmo gizmo) { }

	public ISceneGizmo GetSceneGizmoByCamera(Camera sceneCamera) { }

	public bool IsRenderCamera(Camera camera) { }

	public bool IsSceneGizmoCamera(Camera camera) { }

	private void OnGizmoDragBegin(Gizmo gizmo, int handleId) { }

	private void OnGizmoDragEnd(Gizmo gizmo, int handleId) { }

	private void OnGUI() { }

	private void RegisterGizmo(Gizmo gizmo) { }

	[CompilerGenerated]
	public void remove_CanDoHoverUpdate(GizmoEngineCanDoHoverUpdateHandler value) { }

	public void RemoveGizmo(Gizmo gizmo) { }

	public void RemoveRenderCamera(Camera camera) { }

	public void Render_SystemCall(Camera renderCamera) { }

	private void SortHandleHoverDataCollection(List<GizmoHandleHoverData> hoverDataCollection, Vector3 inputDevicePos) { }

	private void UnregisterGizmo(Gizmo gizmo) { }

	public void Update_SystemCall() { }

}

