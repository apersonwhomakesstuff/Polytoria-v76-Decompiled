namespace RLD;

public class WorldTransformSnapshot
{
	private Vector3 _worldPosition; //Field offset: 0x10
	private Quaternion _worldRotation; //Field offset: 0x1C
	private Vector3 _worldScale; //Field offset: 0x2C

	public Vector3 WorldPosition
	{
		 get { } //Length: 19
	}

	public Quaternion WorldRotation
	{
		 get { } //Length: 11
	}

	public Vector3 WorldScale
	{
		 get { } //Length: 19
	}

	public WorldTransformSnapshot() { }

	public Vector3 get_WorldPosition() { }

	public Quaternion get_WorldRotation() { }

	public Vector3 get_WorldScale() { }

	public bool SameAs(Transform transform) { }

	public void Snaphot(Transform transform) { }

}

