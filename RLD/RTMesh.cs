namespace RLD;

public class RTMesh
{
	private Mesh _unityMesh; //Field offset: 0x10
	private Vector3[] _vertices; //Field offset: 0x18
	private Int32[] _vertIndices; //Field offset: 0x20
	private int _numTriangles; //Field offset: 0x28
	private AABB _aabb; //Field offset: 0x2C
	private MeshTree _meshTree; //Field offset: 0x48

	public AABB AABB
	{
		 get { } //Length: 27
	}

	public bool IsTreeBuilt
	{
		 get { } //Length: 27
	}

	public int NumTriangles
	{
		 get { } //Length: 4
	}

	public Mesh UnityMesh
	{
		 get { } //Length: 5
	}

	public RTMesh(Mesh unityMesh) { }

	public void BuildTree() { }

	public static RTMesh Create(Mesh unityMesh) { }

	public void DebugDrawTree() { }

	public AABB get_AABB() { }

	public bool get_IsTreeBuilt() { }

	public int get_NumTriangles() { }

	public Mesh get_UnityMesh() { }

	public MeshTriangle GetTriangle(int triangleIndex) { }

	public bool OverlapModelVerts(OBB modelOBB, List<Vector3> verts) { }

	public bool OverlapModelVerts(AABB modelAABB, List<Vector3> verts) { }

	public bool OverlapVerts(OBB obb, Transform meshObjectTransform, List<Vector3> verts) { }

	public MeshRayHit Raycast(Ray ray, Matrix4x4 meshTransform) { }

}

