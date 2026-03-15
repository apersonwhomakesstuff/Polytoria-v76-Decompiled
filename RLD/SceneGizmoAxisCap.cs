namespace RLD;

public class SceneGizmoAxisCap : SceneGizmoCap
{
	private AxisDescriptor _axisDesc; //Field offset: 0x20
	private BoxFace _midAxisBoxFace; //Field offset: 0x28
	private GizmoTransform _zoomFactorTransform; //Field offset: 0x30
	private ColorRef _color; //Field offset: 0x38
	private ColorTransition _colorTransition; //Field offset: 0x40
	private Texture2D _labelTexture; //Field offset: 0x48

	public SceneGizmoAxisCap(SceneGizmo sceneGizmo, int id, AxisDescriptor gizmoAxisDesc) { }

	private void OnGizmoHandlePicked(Gizmo gizmo, int handleId) { }

	private void OnGizmoPreUpdateBegin(Gizmo gizmo) { }

	public virtual void Render(Camera camera) { }

	private void UpdateColor() { }

	private void UpdateHoverPermission() { }

	private void UpdateTransform(Camera camera) { }

}

