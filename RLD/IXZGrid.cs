namespace RLD;

public interface IXZGrid
{

	public Matrix4x4 WorldMatrix
	{
		 get { } //Length: 0
	}

	public Plane WorldPlane
	{
		 get { } //Length: 0
	}

	public XZGridCell CellFromWorldPoint(Vector3 worldPoint) { }

	public Matrix4x4 get_WorldMatrix() { }

	public Plane get_WorldPlane() { }

	public bool Raycast(Ray ray, out float t) { }

}

