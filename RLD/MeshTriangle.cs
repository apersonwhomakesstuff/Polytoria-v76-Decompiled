namespace RLD;

public class MeshTriangle
{
	private Vector3[] _vertices; //Field offset: 0x10
	private Vector3 _normal; //Field offset: 0x18
	private int _triangleIndex; //Field offset: 0x24
	private Int32[] _vertIndices; //Field offset: 0x28

	public Vector3 Normal
	{
		 get { } //Length: 19
	}

	public int TriangleIndex
	{
		 get { } //Length: 4
	}

	public Vector3 Vertex0
	{
		 get { } //Length: 53
	}

	public Vector3 Vertex1
	{
		 get { } //Length: 53
	}

	public Vector3 Vertex2
	{
		 get { } //Length: 53
	}

	public Vector3[] Vertices
	{
		 get { } //Length: 78
	}

	public int VertIndex0
	{
		 get { } //Length: 38
	}

	public int VertIndex1
	{
		 get { } //Length: 38
	}

	public int VertIndex2
	{
		 get { } //Length: 38
	}

	public Int32[] VertIndices
	{
		 get { } //Length: 78
	}

	public MeshTriangle(Vector3[] vertices, int triangleIndex, int vertIndex0, int vertIndex1, int vertIndex2) { }

	public Vector3 get_Normal() { }

	public int get_TriangleIndex() { }

	public Vector3 get_Vertex0() { }

	public Vector3 get_Vertex1() { }

	public Vector3 get_Vertex2() { }

	public Vector3[] get_Vertices() { }

	public int get_VertIndex0() { }

	public int get_VertIndex1() { }

	public int get_VertIndex2() { }

	public Int32[] get_VertIndices() { }

	public int GetVertIndex(int arrayIndex) { }

}

