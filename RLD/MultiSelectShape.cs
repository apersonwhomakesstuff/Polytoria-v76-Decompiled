namespace RLD;

public class MultiSelectShape
{
	private Rect _enclosingRect; //Field offset: 0x10
	private bool _isVisible; //Field offset: 0x20
	private int _minSize; //Field offset: 0x24

	public Rect EnclosingRect
	{
		 get { } //Length: 11
	}

	public bool IsVisible
	{
		 get { } //Length: 5
		 set { } //Length: 4
	}

	public int MinSize
	{
		 get { } //Length: 4
		 set { } //Length: 16
	}

	public MultiSelectShape() { }

	public Rect get_EnclosingRect() { }

	public bool get_IsVisible() { }

	public int get_MinSize() { }

	public void GetOverlappedObjects(List<GameObject> gameObjects, Camera camera, QueryConfig boundsQConfig, MultiSelectOverlapMode overlapMode, List<GameObject> overlappedObjects) { }

	private bool IsBigEnoughForOverlap() { }

	public bool OverlapsObject(GameObject gameObject, Camera camera, QueryConfig boundsQConfig, MultiSelectOverlapMode overlapMode) { }

	public void Render(Color fillColor, Color borderColor, Camera camera) { }

	public void set_IsVisible(bool value) { }

	public void set_MinSize(int value) { }

	public void SetEnclosingRectBottomRightPoint(Vector2 bottomRightPoint) { }

	public void SetEnclosingRectTopLeftPoint(Vector2 topLeftPoint) { }

}

