namespace RLD;

public class GizmoHandleHoverData
{
	private int _handleId; //Field offset: 0x10
	private Gizmo _gizmo; //Field offset: 0x18
	private GizmoDimension _handleDimension; //Field offset: 0x20
	private Ray _hoverRay; //Field offset: 0x24
	private Vector3 _hoverPoint; //Field offset: 0x3C
	private float _hoverEnter3D; //Field offset: 0x48

	public Gizmo Gizmo
	{
		 get { } //Length: 5
	}

	public GizmoDimension HandleDimension
	{
		 get { } //Length: 4
	}

	public int HandleId
	{
		 get { } //Length: 4
	}

	public float HoverEnter3D
	{
		 get { } //Length: 6
	}

	public Vector3 HoverPoint
	{
		 get { } //Length: 19
	}

	public Ray HoverRay
	{
		 get { } //Length: 21
	}

	public GizmoHandleHoverData(Ray hoverRay, IGizmoHandle gizmoHandle, float hoverEnter3D) { }

	public GizmoHandleHoverData(Ray hoverRay, IGizmoHandle gizmoHandle, Vector2 hoverPt2D) { }

	public Gizmo get_Gizmo() { }

	public GizmoDimension get_HandleDimension() { }

	public int get_HandleId() { }

	public float get_HoverEnter3D() { }

	public Vector3 get_HoverPoint() { }

	public Ray get_HoverRay() { }

}

