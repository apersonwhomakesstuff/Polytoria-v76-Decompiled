namespace RLD;

public class PrefabSpawnSnap : MonoBehaviour
{
	private bool _isSnapSessionActive; //Field offset: 0x20
	private GameObject _targetHierarchy; //Field offset: 0x28
	private SnapConfig _snapConfig; //Field offset: 0x30
	private int _objectSurfaceLayers; //Field offset: 0x70

	public PrefabSpawnSnap() { }

	private void Awake() { }

	private void BeginSnapSession(GameObject targetHierarchy) { }

	private void EndSnapSession() { }

	private bool EvaluateSessionEndCondition() { }

	private void OnAppInitialized() { }

	private void OnCanChangeObjectSelection(YesNoAnswer answer) { }

	private void OnInputDeviceMoved(IInputDevice inputDevice) { }

	private void OnPrefabSpawned(RTPrefab prefab, GameObject spawnedObject) { }

	private void Update() { }

}

