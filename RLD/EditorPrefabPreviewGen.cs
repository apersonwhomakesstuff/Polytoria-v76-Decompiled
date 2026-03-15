namespace RLD;

public class EditorPrefabPreviewGen
{
	private enum PreviewObjectType : int
	{
		Mesh = 1,
		Sprite = 2,
		Light = 3,
		ParticleSystem = 4,
		Other = 5,
	}

	private PrefabPreviewLookAndFeel _previewLookAndFeel; //Field offset: 0x10
	private QueryConfig _boundsQConfig; //Field offset: 0x18
	private Light _previewLight; //Field offset: 0x28
	private Camera _renderCamera; //Field offset: 0x30
	private bool _isGenSessionActive; //Field offset: 0x38
	private Dictionary<Light, Boolean> _lightToState; //Field offset: 0x40
	private GameObject _nonMeshPreviewObject; //Field offset: 0x48

	public EditorPrefabPreviewGen() { }

	public bool BeginGenSession(PrefabPreviewLookAndFeel previewLookAndFeel) { }

	private void CreateNonMeshPreviewObject() { }

	private bool CreatePreviewLight() { }

	private bool CreateRenderCamera() { }

	private void DisableSceneLights() { }

	public void EndGenSession() { }

	public Texture2D Generate(GameObject unityPrefab) { }

	private void RestoreSceneLights() { }

}

