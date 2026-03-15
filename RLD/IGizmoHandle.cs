namespace RLD;

public interface IGizmoHandle
{

	public IGizmoDragSession DragSession
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public Priority GenericHoverPriority
	{
		 get { } //Length: 0
	}

	public Gizmo Gizmo
	{
		 get { } //Length: 0
	}

	public bool Has2DShapes
	{
		 get { } //Length: 0
	}

	public bool Has3DShapes
	{
		 get { } //Length: 0
	}

	public Priority HoverPriority2D
	{
		 get { } //Length: 0
	}

	public Priority HoverPriority3D
	{
		 get { } //Length: 0
	}

	public int Id
	{
		 get { } //Length: 0
	}

	public bool Is2DHoverable
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public bool Is2DVisible
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public bool Is3DHoverable
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public bool Is3DVisible
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public int Num2DShapes
	{
		 get { } //Length: 0
	}

	public int Num3DShapes
	{
		 get { } //Length: 0
	}

	public int Add2DShape(Shape2D shape) { }

	public int Add3DShape(Shape3D shape) { }

	public bool Contains2DShape(Shape2D shape) { }

	public bool Contains3DShape(Shape3D shape) { }

	public IGizmoDragSession get_DragSession() { }

	public Priority get_GenericHoverPriority() { }

	public Gizmo get_Gizmo() { }

	public bool get_Has2DShapes() { }

	public bool get_Has3DShapes() { }

	public Priority get_HoverPriority2D() { }

	public Priority get_HoverPriority3D() { }

	public int get_Id() { }

	public bool get_Is2DHoverable() { }

	public bool get_Is2DVisible() { }

	public bool get_Is3DHoverable() { }

	public bool get_Is3DVisible() { }

	public int get_Num2DShapes() { }

	public int get_Num3DShapes() { }

	public Shape2D Get2DShape(int shapeIndex) { }

	public Shape3D Get3DShape(int shapeIndex) { }

	public GizmoHandleHoverData GetHoverData(Ray hoverRay) { }

	public float GetZoomFactor(Camera camera) { }

	public bool Is2DShapeVisible(int shapeIndex) { }

	public bool Is3DShapeVisible(int shapeIndex) { }

	public void Remove2DShape(Shape2D shape) { }

	public void Remove3DShape(Shape3D shape) { }

	public void Render2DSolid(Camera camera, int shapeIndex) { }

	public void Render2DSolid(Camera camera) { }

	public void Render2DWire(Camera camera) { }

	public void Render2DWire(Camera camera, int shapeIndex) { }

	public void Render3DSolid(int shapeIndex) { }

	public void Render3DSolid() { }

	public void Render3DWire(int shapeIndex) { }

	public void Render3DWire() { }

	public void set_DragSession(IGizmoDragSession value) { }

	public void set_Is2DHoverable(bool value) { }

	public void set_Is2DVisible(bool value) { }

	public void set_Is3DHoverable(bool value) { }

	public void set_Is3DVisible(bool value) { }

	public void Set2DShapeHoverable(int shapeIndex, bool isHoverable) { }

	public void Set2DShapeVisible(int shapeIndex, bool isVisible) { }

	public void Set3DShapeHoverable(int shapeIndex, bool isHoverable) { }

	public void Set3DShapeVisible(int shapeIndex, bool isVisible) { }

	public void SetAll2DShapesVisible(bool visible) { }

	public void SetAll3DShapesVisible(bool visible) { }

	public void SetHoverable(bool isHoverable) { }

	public void SetVisible(bool isVisible) { }

	public void SetZoomFactorTransform(GizmoTransform transform) { }

}

