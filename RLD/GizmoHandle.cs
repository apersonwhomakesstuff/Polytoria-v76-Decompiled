namespace RLD;

public class GizmoHandle : IGizmoHandle
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass62_0
	{
		public Shape3D shape; //Field offset: 0x10

		public <>c__DisplayClass62_0() { }

		internal bool <Contains3DShape>b__0(GizmoHandleShape3D item) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass63_0
	{
		public Shape2D shape; //Field offset: 0x10

		public <>c__DisplayClass63_0() { }

		internal bool <Contains2DShape>b__0(GizmoHandleShape2D item) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass66_0
	{
		public Shape3D shape; //Field offset: 0x10

		public <>c__DisplayClass66_0() { }

		internal bool <Remove3DShape>b__0(GizmoHandleShape3D item) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass67_0
	{
		public Shape2D shape; //Field offset: 0x10

		public <>c__DisplayClass67_0() { }

		internal bool <Remove2DShape>b__0(GizmoHandleShape2D item) { }

	}

	public GizmoHandleCanHoverHandler CanHover; //Field offset: 0x10
	private int _id; //Field offset: 0x18
	private Gizmo _gizmo; //Field offset: 0x20
	private GizmoTransform _zoomFactorTransform; //Field offset: 0x28
	private Priority _genericHoverPriority; //Field offset: 0x30
	private Priority _hoverPriority2D; //Field offset: 0x38
	private Priority _hoverPriority3D; //Field offset: 0x40
	private List<GizmoHandleShape3D> _3DShapes; //Field offset: 0x48
	private List<GizmoHandleShape2D> _2DShapes; //Field offset: 0x50
	[CompilerGenerated]
	private IGizmoDragSession <DragSession>k__BackingField; //Field offset: 0x58
	[CompilerGenerated]
	private bool <Is2DHoverable>k__BackingField; //Field offset: 0x60
	[CompilerGenerated]
	private bool <Is3DHoverable>k__BackingField; //Field offset: 0x61
	[CompilerGenerated]
	private bool <Is2DVisible>k__BackingField; //Field offset: 0x62
	[CompilerGenerated]
	private bool <Is3DVisible>k__BackingField; //Field offset: 0x63

	public override IGizmoDragSession DragSession
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 13
	}

	public override Priority GenericHoverPriority
	{
		 get { } //Length: 95
	}

	public override Gizmo Gizmo
	{
		 get { } //Length: 5
	}

	public override bool Has2DShapes
	{
		 get { } //Length: 64
	}

	public override bool Has3DShapes
	{
		 get { } //Length: 64
	}

	public override Priority HoverPriority2D
	{
		 get { } //Length: 5
	}

	public override Priority HoverPriority3D
	{
		 get { } //Length: 5
	}

	public override int Id
	{
		 get { } //Length: 4
	}

	public override bool Is2DHoverable
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public override bool Is2DVisible
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public override bool Is3DHoverable
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public override bool Is3DVisible
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public override int Num2DShapes
	{
		 get { } //Length: 60
	}

	public override int Num3DShapes
	{
		 get { } //Length: 60
	}

	public GizmoHandle(Gizmo gizmo, int id) { }

	public override int Add2DShape(Shape2D shape) { }

	public override int Add3DShape(Shape3D shape) { }

	public override bool Contains2DShape(Shape2D shape) { }

	public override bool Contains3DShape(Shape3D shape) { }

	[CompilerGenerated]
	public override IGizmoDragSession get_DragSession() { }

	public override Priority get_GenericHoverPriority() { }

	public override Gizmo get_Gizmo() { }

	public override bool get_Has2DShapes() { }

	public override bool get_Has3DShapes() { }

	public override Priority get_HoverPriority2D() { }

	public override Priority get_HoverPriority3D() { }

	public override int get_Id() { }

	[CompilerGenerated]
	public override bool get_Is2DHoverable() { }

	[CompilerGenerated]
	public override bool get_Is2DVisible() { }

	[CompilerGenerated]
	public override bool get_Is3DHoverable() { }

	[CompilerGenerated]
	public override bool get_Is3DVisible() { }

	public override int get_Num2DShapes() { }

	public override int get_Num3DShapes() { }

	public override Shape2D Get2DShape(int shapeIndex) { }

	public override Shape3D Get3DShape(int shapeIndex) { }

	public override GizmoHandleHoverData GetHoverData(Ray hoverRay) { }

	public override float GetZoomFactor(Camera camera) { }

	public override bool Is2DShapeVisible(int shapeIndex) { }

	public override bool Is3DShapeVisible(int shapeIndex) { }

	public override void Remove2DShape(Shape2D shape) { }

	public override void Remove3DShape(Shape3D shape) { }

	public override void Render2DSolid(Camera camera, int shapeIndex) { }

	public override void Render2DSolid(Camera camera) { }

	public override void Render2DWire(Camera camera) { }

	public override void Render2DWire(Camera camera, int shapeIndex) { }

	public override void Render3DSolid(int shapeIndex) { }

	public override void Render3DSolid() { }

	public override void Render3DWire(int shapeIndex) { }

	public override void Render3DWire() { }

	[CompilerGenerated]
	public override void set_DragSession(IGizmoDragSession value) { }

	[CompilerGenerated]
	public override void set_Is2DHoverable(bool value) { }

	[CompilerGenerated]
	public override void set_Is2DVisible(bool value) { }

	[CompilerGenerated]
	public override void set_Is3DHoverable(bool value) { }

	[CompilerGenerated]
	public override void set_Is3DVisible(bool value) { }

	public override void Set2DShapeHoverable(int shapeIndex, bool isHoverable) { }

	public override void Set2DShapeVisible(int shapeIndex, bool isVisible) { }

	public override void Set3DShapeHoverable(int shapeIndex, bool isHoverable) { }

	public override void Set3DShapeVisible(int shapeIndex, bool isVisible) { }

	public override void SetAll2DShapesVisible(bool visible) { }

	public override void SetAll3DShapesVisible(bool visible) { }

	public override void SetHoverable(bool isHoverable) { }

	public override void SetVisible(bool isVisible) { }

	public override void SetZoomFactorTransform(GizmoTransform transform) { }

}

