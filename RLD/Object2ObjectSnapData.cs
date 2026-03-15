namespace RLD;

public class Object2ObjectSnapData
{
	private GameObject _gameObject; //Field offset: 0x10
	private AABB[] _snapAreaBounds; //Field offset: 0x18
	private BoxFaceAreaDesc[] _snapAreaDesc; //Field offset: 0x20
	private List<Vector3> _vertsBuffer; //Field offset: 0x28

	public Object2ObjectSnapData() { }

	private List<AABB> BuildVertOverlapAABBs(GameObject gameObject, Sprite sprite, RTMesh rtMesh) { }

	public List<OBB> GetAllWorldSnapAreaBounds() { }

	public OBB GetWorldSnapAreaBounds(BoxFace boxFace) { }

	public BoxFaceAreaDesc GetWorldSnapAreaDesc(BoxFace boxFace) { }

	public bool Initialize(GameObject gameObject) { }

}

