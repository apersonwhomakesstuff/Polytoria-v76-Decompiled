namespace RLD;

public class SceneGizmo : GizmoBehaviour, ISceneGizmo
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass20_0
	{
		public Vector3 cameraPos; //Field offset: 0x10

		public <>c__DisplayClass20_0() { }

		internal int <OnGizmoRender>b__0(SceneGizmoCap h0, SceneGizmoCap h1) { }

	}

	private SceneGizmoCamPrjSwitchLabel _camPrjSwitchLabel; //Field offset: 0x20
	private SceneGizmoMidCap _midAxisHandle; //Field offset: 0x28
	private SceneGizmoAxisCap[] _axesHandles; //Field offset: 0x30
	private List<SceneGizmoCap> _renderSortedHandles; //Field offset: 0x38
	private RTSceneGizmoCamera _sceneGizmoCamera; //Field offset: 0x40
	[SerializeField]
	private SceneGizmoLookAndFeel _lookAndFeel; //Field offset: 0x48
	[SerializeField]
	private SceneGizmoLookAndFeel _sharedLookAndFeel; //Field offset: 0x50

	public SceneGizmoLookAndFeel LookAndFeel
	{
		 get { } //Length: 17
	}

	public override Gizmo OwnerGizmo
	{
		 get { } //Length: 5
	}

	public override Camera SceneCamera
	{
		 get { } //Length: 27
	}

	public RTSceneGizmoCamera SceneGizmoCamera
	{
		 get { } //Length: 5
	}

	public SceneGizmoLookAndFeel SharedLookAndFeel
	{
		 get { } //Length: 5
		 set { } //Length: 13
	}

	public SceneGizmo() { }

	public SceneGizmoLookAndFeel get_LookAndFeel() { }

	public override Gizmo get_OwnerGizmo() { }

	public override Camera get_SceneCamera() { }

	public RTSceneGizmoCamera get_SceneGizmoCamera() { }

	public SceneGizmoLookAndFeel get_SharedLookAndFeel() { }

	public virtual void OnAttached() { }

	public virtual void OnGizmoRender(Camera camera) { }

	public virtual void OnGUI() { }

	public void set_SharedLookAndFeel(SceneGizmoLookAndFeel value) { }

}

