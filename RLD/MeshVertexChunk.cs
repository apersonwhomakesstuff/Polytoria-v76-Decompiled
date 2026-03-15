namespace RLD;

[DefaultMember("Item")]
public class MeshVertexChunk : IEnumerable<Vector3>, IEnumerable
{
	private List<Vector3> _modelSpaceVerts; //Field offset: 0x10
	private AABB _modelSpaceAABB; //Field offset: 0x18
	private Mesh _mesh; //Field offset: 0x38

	public Vector3 Item
	{
		 get { } //Length: 122
	}

	public Mesh Mesh
	{
		 get { } //Length: 5
	}

	public AABB ModelSpaceAABB
	{
		 get { } //Length: 27
	}

	public int VertexCount
	{
		 get { } //Length: 60
	}

	public MeshVertexChunk(List<Vector3> modelSpaceVerts, Mesh mesh) { }

	public Vector3 get_Item(int vertexIndex) { }

	public Mesh get_Mesh() { }

	public AABB get_ModelSpaceAABB() { }

	public int get_VertexCount() { }

	public override IEnumerator<Vector3> GetEnumerator() { }

	public Vector3 GetWorldVertClosestToScreenPt(Vector2 screenPoint, Matrix4x4 worldMtx, Camera camera) { }

	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

