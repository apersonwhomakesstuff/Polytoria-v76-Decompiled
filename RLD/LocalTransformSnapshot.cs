namespace RLD;

public class LocalTransformSnapshot
{
	private Transform _transform; //Field offset: 0x10
	private Transform _parentTransform; //Field offset: 0x18
	private Vector3 _localPosition; //Field offset: 0x20
	private Quaternion _localRotation; //Field offset: 0x2C
	private Vector3 _localScale; //Field offset: 0x3C

	public Transform Transform
	{
		 get { } //Length: 5
	}

	public LocalTransformSnapshot() { }

	public void Apply() { }

	public Transform get_Transform() { }

	public static List<LocalTransformSnapshot> GetSnapshotCollection(IEnumerable<GameObject> gameObjects) { }

	public bool SameAs(Transform transform) { }

	public void Snapshot(Transform transform) { }

}

