namespace RLD;

public struct AABB
{
	private Vector3 _size; //Field offset: 0x0
	private Vector3 _center; //Field offset: 0xC
	private bool _isValid; //Field offset: 0x18

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

	public Vector3 Max
	{
		 get { } //Length: 83
		 set { } //Length: 309
	}

	public Vector3 Min
	{
		 get { } //Length: 85
		 set { } //Length: 293
	}

	public Vector3 Size
	{
		 get { } //Length: 18
		 set { } //Length: 15
	}

	public AABB(Vector3 center, Vector3 size) { }

	public AABB(Bounds bounds) { }

	public AABB(IEnumerable<Vector3> pointCloud) { }

	public AABB(IEnumerable<Vector2> pointCloud) { }

	public bool ContainsPoint(Vector3 point) { }

	public void Encapsulate(AABB aabb) { }

	public void Encapsulate(IEnumerable<Vector3> points) { }

	public void Encapsulate(Vector3 point) { }

	public Vector3 get_Center() { }

	public Vector3 get_Extents() { }

	public bool get_IsValid() { }

	public Vector3 get_Max() { }

	public Vector3 get_Min() { }

	public Vector3 get_Size() { }

	public List<Vector3> GetCenterAndCornerPoints() { }

	public List<Vector3> GetCornerPoints() { }

	public static AABB GetInvalid() { }

	public List<Vector2> GetScreenCenterAndCornerPoints(Camera camera) { }

	public List<Vector2> GetScreenCornerPoints(Camera camera) { }

	public Rect GetScreenRectangle(Camera camera) { }

	public Matrix4x4 GetUnitBoxTransform() { }

	public void Inflate(float amount) { }

	public void Inflate(Vector3 amount) { }

	private void RecalculateCenterAndSize(Vector3 min, Vector3 max) { }

	public void set_Center(Vector3 value) { }

	public void set_Max(Vector3 value) { }

	public void set_Min(Vector3 value) { }

	public void set_Size(Vector3 value) { }

	public Bounds ToBounds() { }

	public void Transform(Matrix4x4 transformMatrix) { }

}

