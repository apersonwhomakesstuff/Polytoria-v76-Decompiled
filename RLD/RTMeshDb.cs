namespace RLD;

public class RTMeshDb : Singleton<RTMeshDb>
{
	private Dictionary<Mesh, RTMesh> _meshes; //Field offset: 0x10

	public RTMeshDb() { }

	public bool Contains(RTMesh rtMesh) { }

	public bool Contains(Mesh unityMesh) { }

	private RTMesh CreateRTMesh(Mesh unityMesh) { }

	public RTMesh GetRTMesh(Mesh unityMesh) { }

	public void OnMeshWillBeDestroyed(Mesh unityMesh) { }

}

