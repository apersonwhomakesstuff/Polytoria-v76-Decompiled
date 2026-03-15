namespace RLD;

public class SphereTree
{
	private SphereTreeNode<T> _root; //Field offset: 0x0

	public SphereTree`1() { }

	public SphereTreeNode<T> AddNode(T nodeData, Sphere sphere) { }

	public void DebugDraw() { }

	private void InsertNode(SphereTreeNode<T> node) { }

	public void OnNodeSphereUpdated(SphereTreeNode<T> node) { }

	public bool OverlapBox(OBB box, List<SphereTreeNode`1<T>> nodes) { }

	public bool RaycastAll(Ray ray, List<SphereTreeNodeRayHit`1<T>> hits) { }

	public void RemoveNode(SphereTreeNode<T> node) { }

}

