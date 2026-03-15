namespace Polytoria.Controllers;

public class MeshPartLoadController : MonoBehaviour
{
	[CompilerGenerated]
	private struct <GetMeshUrlAsync>d__17 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<String> <>t__builder; //Field offset: 0x8
		public int assetID; //Field offset: 0x20
		private HttpClient <client>5__2; //Field offset: 0x28
		private TaskAwaiter<HttpResponseMessage> <>u__1; //Field offset: 0x30
		private TaskAwaiter<String> <>u__2; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ImportMeshAsync>d__18 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<GameObject> <>t__builder; //Field offset: 0x8
		public MeshPartLoadController <>4__this; //Field offset: 0x20
		public string meshUrl; //Field offset: 0x28
		public MeshPartLoadRequest request; //Field offset: 0x30
		private TaskAwaiter<Boolean> <>u__1; //Field offset: 0x48
		private GameObject <loadedObject>5__2; //Field offset: 0x50

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <LoadMeshAsync>d__15 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public MeshPartLoadController <>4__this; //Field offset: 0x20
		public MeshPartLoadRequest request; //Field offset: 0x28
		private GameObject <loadedObject>5__2; //Field offset: 0x40
		private TaskAwaiter<String> <>u__1; //Field offset: 0x48
		private TaskAwaiter<GameObject> <>u__2; //Field offset: 0x50

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	public static MeshPartLoadController Instance; //Field offset: 0x0
	private Queue<MeshPartLoadRequest> loadQueue; //Field offset: 0x20
	private GameObject meshStorage; //Field offset: 0x28
	private bool loading; //Field offset: 0x30
	[SerializeField]
	private ImportSettings importSettings; //Field offset: 0x38
	[SerializeField]
	private InstantiationSettings instantiationSettings; //Field offset: 0x40
	[CompilerGenerated]
	private GltfImport <Importer>k__BackingField; //Field offset: 0x48
	private ConsoleLogger logger; //Field offset: 0x50

	public GltfImport Importer
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 13
	}

	public MeshPartLoadController() { }

	private void AdjustLoadedObjectBounds(GameObject loadedObject) { }

	private void AttachLoadedObjectToMeshPart(MeshPartLoadRequest request, GameObject loadedObject) { }

	private void Awake() { }

	private void CacheLoadedObject(int assetID, GameObject loadedObject) { }

	private void ClearExistingChildren(MeshPart meshPart) { }

	private void EnableRenderers(GameObject obj, bool enabled) { }

	private GameObject FindInCache(int assetID) { }

	[CompilerGenerated]
	public GltfImport get_Importer() { }

	[AsyncStateMachine(typeof(<GetMeshUrlAsync>d__17))]
	private Task<String> GetMeshUrlAsync(int assetID) { }

	[AsyncStateMachine(typeof(<ImportMeshAsync>d__18))]
	private Task<GameObject> ImportMeshAsync(MeshPartLoadRequest request, string meshUrl) { }

	public void LoadMesh(MeshPartLoadRequest request) { }

	[AsyncStateMachine(typeof(<LoadMeshAsync>d__15))]
	private Task LoadMeshAsync(MeshPartLoadRequest request) { }

	private void ProcessLoadedObject(MeshPartLoadRequest request, GameObject loadedObject) { }

	[CompilerGenerated]
	protected void set_Importer(GltfImport value) { }

	private void Start() { }

	private void Update() { }

}

