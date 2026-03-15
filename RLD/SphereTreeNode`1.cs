namespace RLD;

public class SphereTreeNode
{
	private SphereTreeNode<T> _stackTop; //Field offset: 0x0
	private SphereTreeNode<T> _stackPrevious; //Field offset: 0x0
	private Sphere _sphere; //Field offset: 0x0
	private T _data; //Field offset: 0x0
	private SphereTreeNode<T> _parent; //Field offset: 0x0
	private SphereTreeNode<T>[] _children; //Field offset: 0x0
	private int _numChildren; //Field offset: 0x0

	public Vector3 Center
	{
		 get { } //Length: 19
		 set { } //Length: 16
	}

	public SphereTreeNode<T>[] Children
	{
		 get { } //Length: 5
	}

	public T Data
	{
		 get { } //Length: 95
		 set { } //Length: 13
	}

	public bool IsLeaf
	{
		 get { } //Length: 9
	}

	public int NumChildren
	{
		 get { } //Length: 4
	}

	public SphereTreeNode<T> Parent
	{
		 get { } //Length: 5
	}

	public float Radius
	{
		 get { } //Length: 6
		 set { } //Length: 12
	}

	public Sphere Sphere
	{
		 get { } //Length: 11
		 set { } //Length: 8
	}

	public SphereTreeNode<T> StackTop
	{
		 get { } //Length: 5
	}

	public SphereTreeNode`1() { }

	public SphereTreeNode`1(T data, Sphere sphere) { }

	public SphereTreeNode<T> ClosestChild(SphereTreeNode<T> node) { }

	public void DebugDraw() { }

	public void EncapsulateChildrenBottomUp() { }

	public Vector3 get_Center() { }

	public SphereTreeNode<T>[] get_Children() { }

	public T get_Data() { }

	public bool get_IsLeaf() { }

	public int get_NumChildren() { }

	public SphereTreeNode<T> get_Parent() { }

	public float get_Radius() { }

	public Sphere get_Sphere() { }

	public SphereTreeNode<T> get_StackTop() { }

	public bool IsOutsideParent() { }

	public void set_Center(Vector3 value) { }

	public void set_Data(T value) { }

	public void set_Radius(float value) { }

	public void set_Sphere(Sphere value) { }

	public void SetParent(SphereTreeNode<T> newParent) { }

	public SphereTreeNode<T> StackPop() { }

	public void StackPush(SphereTreeNode<T> node) { }

}

