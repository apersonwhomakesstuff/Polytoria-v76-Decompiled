namespace RLD;

public class CameraViewVolume
{
	internal enum VPlane : int
	{
		Left = 0,
		Right = 1,
		Bottom = 2,
		Top = 3,
		Near = 4,
		Far = 5,
	}

	internal enum VPoint : int
	{
		NearTopLeft = 0,
		NearTopRight = 1,
		NearBottomRight = 2,
		NearBottomLeft = 3,
		FarTopLeft = 4,
		FarTopRight = 5,
		FarBottomRight = 6,
		FarBottomLeft = 7,
	}

	private const int _numWorldPoints = 8; //Field offset: 0x0
	private const int _numWorldPlanes = 6; //Field offset: 0x0
	private Vector3[] _worldPoints; //Field offset: 0x10
	private Plane[] _worldPlanes; //Field offset: 0x18
	private Vector2 _farPlaneSize; //Field offset: 0x20
	private Vector2 _nearPlaneSize; //Field offset: 0x28
	private AABB _worldAABB; //Field offset: 0x30
	private OBB _worldOBB; //Field offset: 0x4C

	public Plane BottomPlane
	{
		 get { } //Length: 45
	}

	public Vector3 FarBottomLeft
	{
		 get { } //Length: 53
	}

	public Vector3 FarBottomRight
	{
		 get { } //Length: 53
	}

	public Plane FarPlane
	{
		 get { } //Length: 45
	}

	public Vector2 FarPlaneSize
	{
		 get { } //Length: 19
	}

	public Vector3 FarTopLeft
	{
		 get { } //Length: 53
	}

	public Vector3 FarTopRight
	{
		 get { } //Length: 53
	}

	public Plane LeftPlane
	{
		 get { } //Length: 45
	}

	public Vector3 NearBottomLeft
	{
		 get { } //Length: 53
	}

	public Vector3 NearBottomRight
	{
		 get { } //Length: 53
	}

	public Plane NearPlane
	{
		 get { } //Length: 45
	}

	public Vector2 NearPlaneSize
	{
		 get { } //Length: 19
	}

	public Vector3 NearTopLeft
	{
		 get { } //Length: 53
	}

	public Vector3 NearTopRight
	{
		 get { } //Length: 53
	}

	public Plane RightPlane
	{
		 get { } //Length: 45
	}

	public Plane TopPlane
	{
		 get { } //Length: 45
	}

	public AABB WorldAABB
	{
		 get { } //Length: 27
	}

	public OBB WorldOBB
	{
		 get { } //Length: 35
	}

	public CameraViewVolume(Camera camera) { }

	public CameraViewVolume() { }

	private void CalculateWorldPoints(Camera camera) { }

	public static bool CheckAABB(Camera camera, AABB aabb) { }

	public bool CheckAABB(AABB aabb) { }

	public static bool CheckAABB(Camera camera, AABB aabb, Plane[] cameraWorldPlanes) { }

	public void FromCamera(Camera camera) { }

	public Plane get_BottomPlane() { }

	public Vector3 get_FarBottomLeft() { }

	public Vector3 get_FarBottomRight() { }

	public Plane get_FarPlane() { }

	public Vector2 get_FarPlaneSize() { }

	public Vector3 get_FarTopLeft() { }

	public Vector3 get_FarTopRight() { }

	public Plane get_LeftPlane() { }

	public Vector3 get_NearBottomLeft() { }

	public Vector3 get_NearBottomRight() { }

	public Plane get_NearPlane() { }

	public Vector2 get_NearPlaneSize() { }

	public Vector3 get_NearTopLeft() { }

	public Vector3 get_NearTopRight() { }

	public Plane get_RightPlane() { }

	public Plane get_TopPlane() { }

	public AABB get_WorldAABB() { }

	public OBB get_WorldOBB() { }

	public static Plane[] GetCameraWorldPlanes(Camera camera) { }

	public List<Vector3> GetNearPlanePoints() { }

}

