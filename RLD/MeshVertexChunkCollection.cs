namespace RLD;

[DefaultMember("Item")]
public class MeshVertexChunkCollection : IEnumerable<MeshVertexChunk>, IEnumerable
{
	private struct VertexChunkIndices
	{
		private int _XIndex; //Field offset: 0x0
		private int _YIndex; //Field offset: 0x4
		private int _ZIndex; //Field offset: 0x8

		public int XIndex
		{
			 get { } //Length: 3
		}

		public int YIndex
		{
			 get { } //Length: 4
		}

		public int ZIndex
		{
			 get { } //Length: 4
		}

		public VertexChunkIndices(int xIndex, int yIndex, int zIndex) { }

		public int get_XIndex() { }

		public int get_YIndex() { }

		public int get_ZIndex() { }

	}

	private Mesh _mesh; //Field offset: 0x10
	private List<MeshVertexChunk> _vertexChunks; //Field offset: 0x18

	public int Count
	{
		 get { } //Length: 60
	}

	public MeshVertexChunk Item
	{
		 get { } //Length: 81
	}

	public MeshVertexChunkCollection() { }

	public bool FromMesh(Mesh mesh) { }

	public int get_Count() { }

	public MeshVertexChunk get_Item(int chunkIndex) { }

	public override IEnumerator<MeshVertexChunk> GetEnumerator() { }

	public List<MeshVertexChunk> GetWorldChunksHoveredByPoint(Vector3 hoverPoint, Matrix4x4 worldMtx, Camera camera) { }

	public MeshVertexChunk GetWorldVertChunkClosestToScreenPt(Vector2 screenPoint, Matrix4x4 worldMtx, Camera camera) { }

	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

