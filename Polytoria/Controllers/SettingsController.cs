namespace Polytoria.Controllers;

public class SettingsController : MonoBehaviour
{
	public static SettingsController instance; //Field offset: 0x0
	private const int DefaultQualityLevel = 5; //Field offset: 0x0
	private const int DefaultUISize = 2; //Field offset: 0x0
	private const float DefaultMouseSensitivity = 1; //Field offset: 0x0
	private const float DefaultMasterVolume = 1; //Field offset: 0x0
	[SerializeField]
	private RectTransform audioContainer; //Field offset: 0x20
	[SerializeField]
	private RectTransform graphicsContainer; //Field offset: 0x28
	[SerializeField]
	private RectTransform inputContainer; //Field offset: 0x30
	[SerializeField]
	private RectTransform miscContainer; //Field offset: 0x38
	[SerializeField]
	private PostProcessLayer postProcessLayer; //Field offset: 0x40
	public RectTransform[] containers; //Field offset: 0x48

	public SettingsController() { }

	private void Awake() { }

	public void Load() { }

	public void LoadSettings() { }

	private void ReloadAudioControls() { }

	private void ReloadControls() { }

	private void ReloadGraphicsControls() { }

	private void ReloadInputControls() { }

	private void ReloadMiscControls() { }

	public void SetAnisotropicFiltering(int anisotropicFiltering) { }

	public void SetAntiAliasing(int antiAliasing) { }

	public void SetDebugLogLength(string slength) { }

	public void SetFullscreen(bool fullscreen) { }

	public void SetMasterVolume(float volume) { }

	public void SetMouseSensitivity(float sensitivity) { }

	public void SetPixelLightCount(float pixelLightCount) { }

	public void SetPostProcessing(bool postProcessing) { }

	public void SetQualityLevel(int qualityLevel) { }

	public void SetSettingsCategory(int index) { }

	public void SetShadowDistance(float shadowDistance) { }

	public void SetShadowResolution(int shadowResolution) { }

	public void SetTextureQuality(int textureQuality) { }

	public void SetUISize(int sizeLevel) { }

	public void SetVSync(int vSync) { }

}

