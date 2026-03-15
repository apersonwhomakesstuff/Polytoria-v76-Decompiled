namespace RLD;

public class MeshTree
{
	private RTMesh _mesh; //Field offset: 0x10
	private SphereTree<MeshTriangle> _tree; //Field offset: 0x18
	private List<SphereTreeNode`1<MeshTriangle>> _nodeBuffer; //Field offset: 0x20
	private List<SphereTreeNodeRayHit`1<MeshTriangle>> _nodeHitBuffer; //Field offset: 0x28
	private HashSet<Int32> _vertexIndexSet; //Field offset: 0x30
	private bool _isBuilt; //Field offset: 0x38

	public bool IsBuilt
	{
		 get { } //Length: 5
	}

	public MeshTree(RTMesh mesh) { }

	public void Build() { }

	public void DebugDraw() { }

	public bool get_IsBuilt() { }

	public bool OverlapModelVerts(OBB modelOBB, List<Vector3> verts) { }

	public bool OverlapVerts(OBB obb, MeshTransform meshTransform, List<Vector3> verts) { }

	public MeshRayHit RaycastClosest(Ray ray, Matrix4x4 meshTransform) { }

}

