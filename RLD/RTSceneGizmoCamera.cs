namespace RLD;

public class RTSceneGizmoCamera : MonoBehaviour
{
	private Camera _camera; //Field offset: 0x20
	private Transform _transform; //Field offset: 0x28
	private Vector3 _lookAtPoint; //Field offset: 0x30
	private float _fieldOfView; //Field offset: 0x3C
	private float _orthoSize; //Field offset: 0x40
	private float _offsetFromFocusPt; //Field offset: 0x44
	private Camera _sceneCamera; //Field offset: 0x48
	private ISceneGizmoCamViewportUpdater _viewportUpdater; //Field offset: 0x50

	public Camera Camera
	{
		 get { } //Length: 5
	}

	public Vector3 Look
	{
		 get { } //Length: 59
	}

	public Vector3 LookAtPoint
	{
		 get { } //Length: 19
	}

	public Vector3 Right
	{
		 get { } //Length: 59
	}

	public Camera SceneCamera
	{
		 get { } //Length: 5
		 set { } //Length: 213
	}

	public Vector3 Up
	{
		 get { } //Length: 59
	}

	public ISceneGizmoCamViewportUpdater ViewportUpdater
	{
		 get { } //Length: 5
		 set { } //Length: 19
	}

	public Vector3 WorldPosition
	{
		 get { } //Length: 59
		 set { } //Length: 53
	}

	public Quaternion WorldRotation
	{
		 get { } //Length: 51
		 set { } //Length: 44
	}

	public RTSceneGizmoCamera() { }

	private void Awake() { }

	public Camera get_Camera() { }

	public Vector3 get_Look() { }

	public Vector3 get_LookAtPoint() { }

	public Vector3 get_Right() { }

	public Camera get_SceneCamera() { }

	public Vector3 get_Up() { }

	public ISceneGizmoCamViewportUpdater get_ViewportUpdater() { }

	public Vector3 get_WorldPosition() { }

	public Quaternion get_WorldRotation() { }

	public void set_SceneCamera(Camera value) { }

	public void set_ViewportUpdater(ISceneGizmoCamViewportUpdater value) { }

	public void set_WorldPosition(Vector3 value) { }

	public void set_WorldRotation(Quaternion value) { }

	private void Start() { }

	public void Update_SystemCall() { }

}

