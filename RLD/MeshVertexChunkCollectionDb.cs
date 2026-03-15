namespace RLD;

[DefaultMember("Item")]
public class MeshVertexChunkCollectionDb : Singleton<MeshVertexChunkCollectionDb>, IEnumerable<MeshVertexChunkCollection>, IEnumerable
{
	private List<MeshVertexChunkCollection> _vertexChunkCollections; //Field offset: 0x10
	private Dictionary<Mesh, MeshVertexChunkCollection> _meshToVChunkCollection; //Field offset: 0x18

	public int Count
	{
		 get { } //Length: 60
	}

	public MeshVertexChunkCollection Item
	{
		 get { } //Length: 81
	}

	public MeshVertexChunkCollection Item
	{
		 get { } //Length: 511
	}

	public MeshVertexChunkCollectionDb() { }

	private bool CreateMeshVertChunkCollection(Mesh mesh) { }

	public int get_Count() { }

	public MeshVertexChunkCollection get_Item(int collectionIndex) { }

	public MeshVertexChunkCollection get_Item(Mesh mesh) { }

	public override IEnumerator<MeshVertexChunkCollection> GetEnumerator() { }

	public bool HasChunkCollectionForMesh(Mesh mesh) { }

	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

