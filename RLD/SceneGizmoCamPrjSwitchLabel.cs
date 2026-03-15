namespace RLD;

public class SceneGizmoCamPrjSwitchLabel
{
	private SceneGizmo _sceneGizmo; //Field offset: 0x10
	private GizmoHandle _handle; //Field offset: 0x18
	private QuadShape2D _labelQuad; //Field offset: 0x20

	public GizmoHandle Handle
	{
		 get { } //Length: 5
	}

	public int Id
	{
		 get { } //Length: 26
	}

	public SceneGizmoCamPrjSwitchLabel(SceneGizmo sceneGizmo) { }

	public GizmoHandle get_Handle() { }

	public int get_Id() { }

	private void OnGizmoHandlePicked(Gizmo gizmo, int handleId) { }

	private void OnGizmoPreUpdateBegin(Gizmo gizmo) { }

	public void OnGUI() { }

	private void UpdateTransform() { }

}

