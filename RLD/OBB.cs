namespace RLD;

public struct OBB
{
	private Vector3 _size; //Field offset: 0x0
	private Vector3 _center; //Field offset: 0xC
	private Quaternion _rotation; //Field offset: 0x18
	private bool _isValid; //Field offset: 0x28

	public Vector3 Center
	{
		 get { } //Length: 19
		 set { } //Length: 16
	}

	public Vector3 Extents
	{
		 get { } //Length: 58
	}

	public bool IsValid
	{
		 get { } //Length: 5
	}

	public Vector3 Look
	{
		 get { } //Length: 135
	}

	public Vector3 Right
	{
		 get { } //Length: 135
	}

	public Quaternion Rotation
	{
		 get { } //Length: 11
		 set { } //Length: 8
	}

	public Matrix4x4 RotationMatrix
	{
		 get { } //Length: 260
	}

	public Vector3 Size
	{
		 get { } //Length: 18
		 set { } //Length: 15
	}

	public Vector3 Up
	{
		 get { } //Length: 135
	}

	public OBB(Quaternion rotation) { }

	public OBB(OBB copy) { }

	public OBB(AABB modelSpaceAABB, Transform worldTransform) { }

	public OBB(AABB aabb, Quaternion rotation) { }

	public OBB(AABB aabb) { }

	public OBB(Bounds bounds, Quaternion rotation) { }

	public OBB(Vector3 center, Quaternion rotation) { }

	public OBB(Vector3 center, Vector3 size, Quaternion rotation) { }

	public OBB(Vector3 center, Vector3 size) { }

	public void Encapsulate(OBB otherOBB) { }

	public Vector3 get_Center() { }

	public Vector3 get_Extents() { }

	public bool get_IsValid() { }

	public Vector3 get_Look() { }

	public Vector3 get_Right() { }

	public Quaternion get_Rotation() { }

	public Matrix4x4 get_RotationMatrix() { }

	public Vector3 get_Size() { }

	public Vector3 get_Up() { }

	public List<Vector3> GetCenterAndCornerPoints() { }

	public Vector3 GetClosestPoint(Vector3 point) { }

	public List<Vector3> GetCornerPoints() { }

	public static OBB GetInvalid() { }

	public Vector3 GetPointFaceNormal(Vector3 pointOnFace) { }

	public Matrix4x4 GetUnitBoxTransform() { }

	public void Inflate(float amount) { }

	public bool IntersectsOBB(OBB otherOBB) { }

	public bool IntersectsSphere(Sphere sphere) { }

	public void set_Center(Vector3 value) { }

	public void set_Rotation(Quaternion value) { }

	public void set_Size(Vector3 value) { }

}

