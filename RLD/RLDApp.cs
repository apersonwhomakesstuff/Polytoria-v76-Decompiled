namespace RLD;

public class RLDApp : MonoSingleton<RLDApp>, IRLDApplication
{
	[CompilerGenerated]
	private RLDAppInitializedHandler Initialized; //Field offset: 0x20
	private Camera _renderCamera; //Field offset: 0x28
	private RenderPipelineId _renderPipelineId; //Field offset: 0x30
	[HideInInspector]
	[SerializeField]
	private DynamicConvertSettings _dynamicConvertSettings; //Field offset: 0x38

	public event RLDAppInitializedHandler Initialized
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public DynamicConvertSettings DynamicConvertSettings
	{
		 get { } //Length: 5
	}

	public Camera RenderCamera
	{
		 get { } //Length: 5
	}

	public RenderPipelineId RenderPipelineId
	{
		 get { } //Length: 174
	}

	public RLDApp() { }

	[CompilerGenerated]
	public void add_Initialized(RLDAppInitializedHandler value) { }

	private void DetectRenderPipeline() { }

	public DynamicConvertSettings get_DynamicConvertSettings() { }

	public Camera get_RenderCamera() { }

	public RenderPipelineId get_RenderPipelineId() { }

	private void OnBeginCameraRendering(ScriptableRenderContext context, Camera camera) { }

	private void OnCanCameraProcessInput(YesNoAnswer answer) { }

	private void OnCanCameraUseScrollWheel(YesNoAnswer answer) { }

	private void OnCanDoGizmoHoverUpdate(YesNoAnswer answer) { }

	private void OnCanObjectSelectionClickAndMultiSelectDeselect(YesNoAnswer answer) { }

	private void OnCanUndoRedo(UndoRedoOpType undoRedoOpType, YesNoAnswer answer) { }

	private void OnDisable() { }

	private void OnEndCameraRendering(ScriptableRenderContext context, Camera camera) { }

	private void OnRenderObject() { }

	private void OnSceneCanRenderCameraIcon(Camera camera, YesNoAnswer answer) { }

	private void OnViewportCameraRemoved(Camera camera) { }

	private void OnViewportsCameraAdded(Camera camera) { }

	[CompilerGenerated]
	public void remove_Initialized(RLDAppInitializedHandler value) { }

	private void Start() { }

	private void Update() { }

}

