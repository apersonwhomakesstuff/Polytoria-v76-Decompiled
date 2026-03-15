namespace RLD;

public class MeshTransform
{
	private Vector3 _position; //Field offset: 0x10
	private Quaternion _rotation; //Field offset: 0x1C
	private Vector3 _scale; //Field offset: 0x2C

	public Vector3 Position
	{
		 get { } //Length: 19
	}

	public Quaternion Rotation
	{
		 get { } //Length: 11
	}

	public Vector3 Scale
	{
		 get { } //Length: 19
	}

	public MeshTransform(Vector3 position, Quaternion rotation, Vector3 scale) { }

	public MeshTransform(Transform transform) { }

	public Vector3 get_Position() { }

	public Quaternion get_Rotation() { }

	public Vector3 get_Scale() { }

	public OBB InverseTransformOBB(OBB obb) { }

	public Vector3 InverseTransformPoint(Vector3 point) { }

	public Vector3 TransformPoint(Vector3 point) { }

}

