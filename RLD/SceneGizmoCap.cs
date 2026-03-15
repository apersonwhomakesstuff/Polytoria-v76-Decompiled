namespace RLD;

public abstract class SceneGizmoCap
{
	protected SceneGizmo _sceneGizmo; //Field offset: 0x10
	protected GizmoCap3D _cap; //Field offset: 0x18

	public int HandleId
	{
		 get { } //Length: 29
	}

	public Vector3 Position
	{
		 get { } //Length: 59
	}

	public SceneGizmoCap(SceneGizmo sceneGizmo, int capHandleId) { }

	public int get_HandleId() { }

	public Vector3 get_Position() { }

	public abstract void Render(Camera camera) { }

	public void SetHoverable(bool isHoverable) { }

}

