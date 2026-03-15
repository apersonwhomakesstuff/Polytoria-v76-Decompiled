namespace RLD;

public class SphereTreeNodeRayHit
{
	private SphereTreeNode<T> _hitNode; //Field offset: 0x0
	private Vector3 _hitPoint; //Field offset: 0x0
	private float _hitEnter; //Field offset: 0x0

	public float HitEnter
	{
		 get { } //Length: 6
	}

	public SphereTreeNode<T> HitNode
	{
		 get { } //Length: 5
	}

	public Vector3 HitPoint
	{
		 get { } //Length: 19
	}

	public SphereTreeNodeRayHit`1(Ray ray, SphereTreeNode<T> hitNode, float hitEnter) { }

	public float get_HitEnter() { }

	public SphereTreeNode<T> get_HitNode() { }

	public Vector3 get_HitPoint() { }

}

