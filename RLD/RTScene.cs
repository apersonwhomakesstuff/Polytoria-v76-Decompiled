namespace RLD;

public class RTScene : MonoSingleton<RTScene>
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Predicate<RaycastResult> <>9__26_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal bool <GetHoveredUIElements>b__26_0(RaycastResult item) { }

	}

	public SceneCanRenderCameraIconHandler CanRenderCameraIcon; //Field offset: 0x20
	private YesNoAnswer _yesNoAnswer; //Field offset: 0x28
	[SerializeField]
	private SceneSettings _settings; //Field offset: 0x30
	[SerializeField]
	private SceneLookAndFeel _lookAndFeel; //Field offset: 0x38
	private List<Camera> _iconRenderIgnoreCamera; //Field offset: 0x40
	private HashSet<GameObject> _ignoredRootObjects; //Field offset: 0x48
	private List<IHoverableSceneEntityContainer> _hoverableSceneEntityContainers; //Field offset: 0x50
	private SceneTree _sceneTree; //Field offset: 0x58
	private List<GameObject> _rootGameObjects; //Field offset: 0x60
	private List<Light> _lights; //Field offset: 0x68
	private List<ParticleSystem> _particleSystems; //Field offset: 0x70
	private List<Camera> _cameras; //Field offset: 0x78
	private List<GameObject> _childrenAndSelfBuffer; //Field offset: 0x80
	private List<GameObjectRayHit> _objectHitBuffer; //Field offset: 0x88

	public SceneLookAndFeel LookAndFeel
	{
		 get { } //Length: 5
	}

	public SceneSettings Settings
	{
		 get { } //Length: 95
	}

	public RTScene() { }

	public void AddIconRenderIgnoreCamera(Camera camera) { }

	public AABB CalculateBounds() { }

	public SceneLookAndFeel get_LookAndFeel() { }

	public SceneSettings get_Settings() { }

	public List<RaycastResult> GetHoveredUIElements() { }

	public GameObject[] GetSceneObjects() { }

	public bool IsAnySceneEntityHovered() { }

	public bool IsAnyUIElementHovered() { }

	public bool IsIconRenderIgnoreCamera(Camera camera) { }

	public void OnGameObjectWillBeDestroyed(GameObject gameObject) { }

	public bool OverlapBox(OBB obb, SceneOverlapFilter overlapFilter, List<GameObject> gameObjects) { }

	public bool OverlapBox(OBB obb, List<GameObject> gameObjects) { }

	public SceneRaycastHit Raycast(Ray ray, SceneRaycastPrecision rtRaycastPrecision, SceneRaycastFilter raycastFilter) { }

	public bool RaycastAllObjects(Ray ray, SceneRaycastPrecision rtRaycastPrecision, List<GameObjectRayHit> hits) { }

	public bool RaycastAllObjectsSorted(Ray ray, SceneRaycastPrecision raycastPresicion, List<GameObjectRayHit> hits) { }

	public bool RaycastAllObjectsSorted(Ray ray, SceneRaycastPrecision rtRaycastPrecision, SceneRaycastFilter raycastFilter, List<GameObjectRayHit> hits) { }

	public GameObjectRayHit RaycastMeshObject(Ray ray, GameObject meshObject) { }

	public GameObjectRayHit RaycastMeshObjectReverseIfFail(Ray ray, GameObject meshObject) { }

	public XZGridRayHit RaycastSceneGridIfVisible(Ray ray) { }

	public GameObjectRayHit RaycastSpriteObject(Ray ray, GameObject spriteObject) { }

	public void RegisterHoverableSceneEntityContainer(IHoverableSceneEntityContainer container) { }

	public void Render_SystemCall(Camera renderCamera) { }

	public void SetRootObjectIgnored(GameObject root, bool ignored) { }

	public void Update_SystemCall() { }

}

