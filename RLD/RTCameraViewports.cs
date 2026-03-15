namespace RLD;

public class RTCameraViewports : Singleton<RTCameraViewports>
{
	internal sealed class CameraAddedHandler : MulticastDelegate
	{

		public CameraAddedHandler(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(Camera camera, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(Camera camera) { }

	}

	internal sealed class CameraRemovedHandler : MulticastDelegate
	{

		public CameraRemovedHandler(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(Camera camera, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(Camera camera) { }

	}

	internal sealed class FocusCameraChangedHandler : MulticastDelegate
	{

		public FocusCameraChangedHandler(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(Camera oldFocusCam, Camera newFocusCam, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(Camera oldFocusCam, Camera newFocusCam) { }

	}

	[CompilerGenerated]
	private CameraAddedHandler CameraAdded; //Field offset: 0x10
	[CompilerGenerated]
	private CameraRemovedHandler CameraRemoved; //Field offset: 0x18
	[CompilerGenerated]
	private FocusCameraChangedHandler FocusCameraChanged; //Field offset: 0x20
	private List<Camera> _cameras; //Field offset: 0x28

	public event CameraAddedHandler CameraAdded
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public event CameraRemovedHandler CameraRemoved
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public event FocusCameraChangedHandler FocusCameraChanged
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public Camera FocusCamera
	{
		 get { } //Length: 96
	}

	public int NumCameras
	{
		 get { } //Length: 60
	}

	public RTCameraViewports() { }

	[CompilerGenerated]
	public void add_CameraAdded(CameraAddedHandler value) { }

	[CompilerGenerated]
	public void add_CameraRemoved(CameraRemovedHandler value) { }

	[CompilerGenerated]
	public void add_FocusCameraChanged(FocusCameraChangedHandler value) { }

	public void AddCamera(Camera camera, Rect normViewRect) { }

	public void AddCamera(Camera camera) { }

	public bool ContainsCamera(Camera camera) { }

	public Camera get_FocusCamera() { }

	public int get_NumCameras() { }

	[CompilerGenerated]
	public void remove_CameraAdded(CameraAddedHandler value) { }

	[CompilerGenerated]
	public void remove_CameraRemoved(CameraRemovedHandler value) { }

	[CompilerGenerated]
	public void remove_FocusCameraChanged(FocusCameraChangedHandler value) { }

	public void RemoveCamera(Camera camera) { }

	public void SetFocusCamera(int cameraIndex) { }

	public void SetFocusCamera(Camera camera) { }

}

