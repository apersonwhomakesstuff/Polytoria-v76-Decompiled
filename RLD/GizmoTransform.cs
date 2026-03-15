namespace RLD;

public class GizmoTransform
{
	internal struct ChangeData
	{
		public ChangeReason ChangeReason; //Field offset: 0x0
		public GizmoDimension TRSDimension; //Field offset: 0x4

		public ChangeData(ChangeReason changeReason, GizmoDimension trsDimension) { }

	}

	internal enum ChangeReason : int
	{
		TRSChange = 0,
		ParentChange = 1,
	}

	[CompilerGenerated]
	private GizmoEntityTransformChangedHandler Changed; //Field offset: 0x10
	private bool _firingChanged3DEvent; //Field offset: 0x18
	private bool _firingChanged2DEvent; //Field offset: 0x19
	private Vector3 _position3D; //Field offset: 0x1C
	private Vector3 _localPosition3D; //Field offset: 0x28
	private Quaternion _rotation3D; //Field offset: 0x34
	private Quaternion _localRotation3D; //Field offset: 0x44
	private Vector2 _position2D; //Field offset: 0x54
	private Vector2 _localPosition2D; //Field offset: 0x5C
	private float _rotation2DDegrees; //Field offset: 0x64
	private Quaternion _rotation2D; //Field offset: 0x68
	private float _localRotation2DDegrees; //Field offset: 0x78
	private Quaternion _localRotation2D; //Field offset: 0x7C
	private Vector3[] _axes3D; //Field offset: 0x90
	private Vector2[] _axes2D; //Field offset: 0x98
	private GizmoTransform _parent; //Field offset: 0xA0
	private List<GizmoTransform> _children; //Field offset: 0xA8

	public event GizmoEntityTransformChangedHandler Changed
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public bool CanChange2D
	{
		 get { } //Length: 8
	}

	public bool CanChange3D
	{
		 get { } //Length: 8
	}

	public List<GizmoTransform> Children
	{
		 get { } //Length: 107
	}

	public Vector2 LocalPosition2D
	{
		 get { } //Length: 19
		 set { } //Length: 377
	}

	public Vector3 LocalPosition3D
	{
		 get { } //Length: 19
		 set { } //Length: 395
	}

	public Quaternion LocalRotation2D
	{
		 get { } //Length: 11
	}

	public float LocalRotation2DDegrees
	{
		 get { } //Length: 6
		 set { } //Length: 183
	}

	public Quaternion LocalRotation3D
	{
		 get { } //Length: 11
		 set { } //Length: 388
	}

	public Vector3 Look3D
	{
		 get { } //Length: 56
	}

	public int NumChildren
	{
		 get { } //Length: 63
	}

	public GizmoTransform Parent
	{
		 get { } //Length: 8
	}

	public Vector2 Position2D
	{
		 get { } //Length: 19
		 set { } //Length: 406
	}

	public Vector3 Position3D
	{
		 get { } //Length: 19
		 set { } //Length: 450
	}

	public Vector2 Right2D
	{
		 get { } //Length: 56
	}

	public Vector3 Right3D
	{
		 get { } //Length: 56
	}

	public Quaternion Rotation2D
	{
		 get { } //Length: 11
	}

	public float Rotation2DDegrees
	{
		 get { } //Length: 6
		 set { } //Length: 27
	}

	public Quaternion Rotation3D
	{
		 get { } //Length: 11
		 set { } //Length: 388
	}

	public Vector2 Up2D
	{
		 get { } //Length: 56
	}

	public Vector3 Up3D
	{
		 get { } //Length: 56
	}

	public GizmoTransform() { }

	[CompilerGenerated]
	public void add_Changed(GizmoEntityTransformChangedHandler value) { }

	public void AlignAxis2D(int axisIndex, AxisSign axisSign, Vector2 axis) { }

	public void AlignAxis3D(int axisIndex, AxisSign axisSign, Vector3 axis) { }

	private void ChangeLocalPosition2D(Vector2 localPosition) { }

	private void ChangeLocalPosition3D(Vector3 localPosition) { }

	private void ChangeLocalRotation2D(Quaternion localRotation) { }

	private void ChangeLocalRotation2D(float localRotation) { }

	private void ChangeLocalRotation3D(Quaternion localRotation) { }

	private void ChangePosition2D(Vector2 position) { }

	private void ChangePosition3D(Vector3 position) { }

	private void ChangeRotation2D(float rotation) { }

	private void ChangeRotation2D(Quaternion rotation) { }

	private void ChangeRotation3D(Quaternion rotation) { }

	public static List<GizmoTransform> FilterParentsOnly(IEnumerable<GizmoTransform> transforms) { }

	public bool get_CanChange2D() { }

	public bool get_CanChange3D() { }

	public List<GizmoTransform> get_Children() { }

	public Vector2 get_LocalPosition2D() { }

	public Vector3 get_LocalPosition3D() { }

	public Quaternion get_LocalRotation2D() { }

	public float get_LocalRotation2DDegrees() { }

	public Quaternion get_LocalRotation3D() { }

	public Vector3 get_Look3D() { }

	public int get_NumChildren() { }

	public GizmoTransform get_Parent() { }

	public Vector2 get_Position2D() { }

	public Vector3 get_Position3D() { }

	public Vector2 get_Right2D() { }

	public Vector3 get_Right3D() { }

	public Quaternion get_Rotation2D() { }

	public float get_Rotation2DDegrees() { }

	public Quaternion get_Rotation3D() { }

	public Vector2 get_Up2D() { }

	public Vector3 get_Up3D() { }

	public PlaneQuadrantId Get3DQuadrantFacingCamera(PlaneId planeId, Camera camera) { }

	public Vector2[] GetAxes2D() { }

	public Vector3[] GetAxes3D() { }

	public Vector2 GetAxis2D(int axisIndex, AxisSign axisSign) { }

	public Vector2 GetAxis2D(AxisDescriptor axisDesc) { }

	public Vector3 GetAxis3D(int axisIndex, AxisSign axisSign) { }

	public Vector3 GetAxis3D(AxisDescriptor axisDesc) { }

	public Plane GetPlane3D(PlaneDescriptor planeDesc) { }

	public Plane GetPlane3D(PlaneId planeId, PlaneQuadrantId planeQuadrantId) { }

	public Vector2 InverseTransformNormal2D(Vector2 normal) { }

	public Vector3 InverseTransformNormal3D(Vector3 normal) { }

	public Vector2 InverseTransformPoint2D(Vector2 point) { }

	public Vector3 InverseTransformPoint3D(Vector3 point) { }

	public bool IsChildOf(GizmoTransform transform) { }

	private void OnChanged(ChangeData changeData) { }

	private void OnLocalPosition2DChanged() { }

	private void OnLocalPosition3DChanged() { }

	private void OnLocalRotation2DChanged() { }

	private void OnLocalRotation3DChanged() { }

	private void OnParentChanged() { }

	private void OnPosition2DChanged() { }

	private void OnPosition3DChanged() { }

	private void OnRotation2DChanged() { }

	private void OnRotation3DChanged() { }

	[CompilerGenerated]
	public void remove_Changed(GizmoEntityTransformChangedHandler value) { }

	public void Rotate2D(Quaternion rotation) { }

	public void Rotate2D(float rotation) { }

	public void Rotate3D(Quaternion rotation) { }

	public void set_LocalPosition2D(Vector2 value) { }

	public void set_LocalPosition3D(Vector3 value) { }

	public void set_LocalRotation2DDegrees(float value) { }

	public void set_LocalRotation3D(Quaternion value) { }

	public void set_Position2D(Vector2 value) { }

	public void set_Position3D(Vector3 value) { }

	public void set_Rotation2DDegrees(float value) { }

	public void set_Rotation3D(Quaternion value) { }

	public void SetParent(GizmoTransform newParent) { }

	public Vector2 TransformNormal2D(Vector2 normal) { }

	public Vector3 TransformNormal3D(Vector3 normal) { }

	public Vector2 TransformPoint2D(Vector2 point) { }

	public Vector3 TransformPoint3D(Vector3 point) { }

	public Vector2 TransformVector2D(Vector2 vec) { }

	public Vector3 TransformVector3D(Vector3 vec) { }

	private void Update2DAxes() { }

	private void Update3DAxes() { }

	private void UpdateChildTransforms2D() { }

	private void UpdateChildTransforms3D() { }

}

