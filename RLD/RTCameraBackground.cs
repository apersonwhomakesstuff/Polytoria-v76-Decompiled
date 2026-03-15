namespace RLD;

public class RTCameraBackground : MonoSingleton<RTCameraBackground>
{
	[SerializeField]
	private CameraBackgroundSettings _bkSettings; //Field offset: 0x20
	[SerializeField]
	private List<Camera> _renderIgnoreCameras; //Field offset: 0x28
	private Dictionary<Camera, CameraBackgroundSettings> _cameraToBkSettings; //Field offset: 0x30

	public CameraBackgroundSettings Settings
	{
		 get { } //Length: 5
	}

	public RTCameraBackground() { }

	public void AddRenderIgnoreCamera(Camera camera) { }

	public CameraBackgroundSettings get_Settings() { }

	public List<Camera> GetAllRenderIgnoreCameras() { }

	public bool IsRenderIgnoreCamera(Camera camera) { }

	public void RemoveRenderIgnoreCamera(Camera camera) { }

	public void Render_SystemCall(Camera renderCamera) { }

	public void SetCameraBkSettings(Camera camera, CameraBackgroundSettings bkSettings) { }

}

