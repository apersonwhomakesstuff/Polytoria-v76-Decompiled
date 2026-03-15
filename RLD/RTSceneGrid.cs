namespace RLD;

public class RTSceneGrid : MonoSingleton<RTSceneGrid>, IXZGrid
{
	private enum SnapToPointMode : int
	{
		Exact = 0,
		ClosestExtremity = 1,
	}

	[SerializeField]
	private SceneGridHotkeys _hotkeys; //Field offset: 0x20
	[SerializeField]
	private XZGridSettings _settings; //Field offset: 0x28
	[SerializeField]
	private XZGridLookAndFeel _lookAndFeel; //Field offset: 0x30
	private List<Camera> _renderIgnoreCameras; //Field offset: 0x38

	public SceneGridHotkeys Hotkeys
	{
		 get { } //Length: 5
	}

	public Vector3 Look
	{
		 get { } //Length: 231
	}

	public XZGridLookAndFeel LookAndFeel
	{
		 get { } //Length: 95
	}

	public Vector3 Normal
	{
		 get { } //Length: 231
	}

	public Vector3 Right
	{
		 get { } //Length: 231
	}

	public Quaternion Rotation
	{
		 get { } //Length: 117
	}

	public XZGridSettings Settings
	{
		 get { } //Length: 5
	}

	public override Matrix4x4 WorldMatrix
	{
		 get { } //Length: 391
	}

	public override Plane WorldPlane
	{
		 get { } //Length: 305
	}

	public float YOffset
	{
		 get { } //Length: 28
		 set { } //Length: 28
	}

	public RTSceneGrid() { }

	public void AddRenderIgnoreCamera(Camera camera) { }

	private float CalculateCellFadeZoom(Camera camera) { }

	public override XZGridCell CellFromWorldPoint(Vector3 worldPoint) { }

	public SceneGridHotkeys get_Hotkeys() { }

	public Vector3 get_Look() { }

	public XZGridLookAndFeel get_LookAndFeel() { }

	public Vector3 get_Normal() { }

	public Vector3 get_Right() { }

	public Quaternion get_Rotation() { }

	public XZGridSettings get_Settings() { }

	public override Matrix4x4 get_WorldMatrix() { }

	public override Plane get_WorldPlane() { }

	public float get_YOffset() { }

	private SceneRaycastHit GetSceneHitForGridSnap() { }

	public void Initialize_SystemCall() { }

	public bool IsRenderIgnoreCamera(Camera camera) { }

	private void MoveDown() { }

	private void MoveUp() { }

	private void OnInputDeviceDoubleTap(IInputDevice inputDevice, Vector2 position) { }

	public override bool Raycast(Ray ray, out float t) { }

	public void RemoveRenderIgnoreCamera(Camera camera) { }

	public void Render_SystemCall(Camera renderCamera) { }

	public void set_YOffset(float value) { }

	private void SnapToObjectHitPoint(GameObjectRayHit objectHit, SnapToPointMode snapMode) { }

	public void Update_SystemCall() { }

}

