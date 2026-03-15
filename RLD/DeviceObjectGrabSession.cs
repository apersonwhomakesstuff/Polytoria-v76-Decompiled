namespace RLD;

public class DeviceObjectGrabSession
{
	private struct GrabSurfaceInfo
	{
		public GrabSurfaceType SurfaceType; //Field offset: 0x0
		public Vector3 AnchorPoint; //Field offset: 0x4
		public Vector3 AnchorNormal; //Field offset: 0x10
		public Plane AnchorPlane; //Field offset: 0x1C
		public SceneRaycastHit SceneRaycastHit; //Field offset: 0x30

	}

	internal enum GrabSurfaceType : int
	{
		Invalid = 0,
		Mesh = 1,
		SphericalMesh = 2,
		UnityTerrain = 3,
		TerrainMesh = 4,
		Grid = 5,
	}

	private class GrabTarget
	{
		private GameObject _gameObject; //Field offset: 0x10
		private Transform _transform; //Field offset: 0x18
		public Vector3 AnchorVector; //Field offset: 0x20
		public Vector3 WorldScaleSnapshot; //Field offset: 0x2C
		public Vector3 AnchorVectorSnapshot; //Field offset: 0x38
		public Plane SittingPlane; //Field offset: 0x44
		public Vector3 SittingPoint; //Field offset: 0x54
		public float OffsetFromSurface; //Field offset: 0x60

		public GameObject GameObject
		{
			 get { } //Length: 5
		}

		public Transform Transform
		{
			 get { } //Length: 5
		}

		public GrabTarget(GameObject parentObject) { }

		public GameObject get_GameObject() { }

		public Transform get_Transform() { }

	}

	private enum State : int
	{
		Inactive = 0,
		ActiveSnapToSurface = 1,
		ActiveRotate = 2,
		ActiveRotateAroundAnchor = 3,
		ActiveScale = 4,
		ActiveOffsetFromSurface = 5,
		ActiveAnchorAdjust = 6,
		ActiveOffsetFromAnchor = 7,
	}

	[CompilerGenerated]
	private ObjectGrabSessionBeginHandler SessionBegin; //Field offset: 0x10
	[CompilerGenerated]
	private ObjectGrabSessionEndHandler SessionEnd; //Field offset: 0x18
	private State _state; //Field offset: 0x20
	private ObjectGrabSettings _sharedSettings; //Field offset: 0x28
	private ObjectGrabHotkeys _sharedHotkeys; //Field offset: 0x30
	private ObjectGrabLookAndFeel _sharedLookAndFeel; //Field offset: 0x38
	private List<GameObject> _targetParents; //Field offset: 0x40
	private List<GrabTarget> _grabTargets; //Field offset: 0x48
	private GrabSurfaceInfo _grabSurfaceInfo; //Field offset: 0x50
	private int _deltaCaptureId; //Field offset: 0x88
	private TransformAxis[] _possibleAlignmentAxes; //Field offset: 0x90
	private List<LocalTransformSnapshot> _preTargetTransformSnapshots; //Field offset: 0x98

	public event ObjectGrabSessionBeginHandler SessionBegin
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public event ObjectGrabSessionEndHandler SessionEnd
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public bool IsActive
	{
		 get { } //Length: 8
	}

	public ObjectGrabHotkeys SharedHotkeys
	{
		 get { } //Length: 95
		 set { } //Length: 19
	}

	public ObjectGrabLookAndFeel SharedLookAndFeel
	{
		 get { } //Length: 5
		 set { } //Length: 19
	}

	public ObjectGrabSettings SharedSettings
	{
		 get { } //Length: 5
		 set { } //Length: 19
	}

	public DeviceObjectGrabSession() { }

	[CompilerGenerated]
	public void add_SessionBegin(ObjectGrabSessionBeginHandler value) { }

	[CompilerGenerated]
	public void add_SessionEnd(ObjectGrabSessionEndHandler value) { }

	private bool Begin(IEnumerable<GameObject> targetObjects) { }

	private void CalculateGrabTargetsAnchorVectors() { }

	public void End() { }

	public bool get_IsActive() { }

	public ObjectGrabHotkeys get_SharedHotkeys() { }

	public ObjectGrabLookAndFeel get_SharedLookAndFeel() { }

	public ObjectGrabSettings get_SharedSettings() { }

	private QueryConfig GetObjectBoundsQConfig() { }

	private bool IdentifyGrabSurface() { }

	private bool IdentifyGrabTargets(IEnumerable<GameObject> targetObjects) { }

	private void OffsetTargetsFromAnchor() { }

	private void OffsetTargetsFromSurface() { }

	[CompilerGenerated]
	public void remove_SessionBegin(ObjectGrabSessionBeginHandler value) { }

	[CompilerGenerated]
	public void remove_SessionEnd(ObjectGrabSessionEndHandler value) { }

	public void Render(Camera renderCamera) { }

	private void RotateTargets() { }

	private void RotateTargetsAroundAnchor() { }

	private void ScaleTargets() { }

	public void set_SharedHotkeys(ObjectGrabHotkeys value) { }

	public void set_SharedLookAndFeel(ObjectGrabLookAndFeel value) { }

	public void set_SharedSettings(ObjectGrabSettings value) { }

	private void SnapTargetsToSurface() { }

	private void StoreGrabTargetsAnchorVectorSnapshots() { }

	private void StoreGrabTargetsWorldScaleSnapshots() { }

	private void SwitchToNextAlignmentAxis() { }

	public void Update(IEnumerable<GameObject> targetObjects) { }

}

