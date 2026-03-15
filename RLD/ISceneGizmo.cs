namespace RLD;

public interface ISceneGizmo
{

	public Gizmo OwnerGizmo
	{
		 get { } //Length: 0
	}

	public Camera SceneCamera
	{
		 get { } //Length: 0
	}

	public Gizmo get_OwnerGizmo() { }

	public Camera get_SceneCamera() { }

}

