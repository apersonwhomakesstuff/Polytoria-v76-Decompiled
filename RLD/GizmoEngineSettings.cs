namespace RLD;

public class GizmoEngineSettings : Settings
{
	[SerializeField]
	private bool _enableGizmoSorting; //Field offset: 0x28

	public bool EnableGizmoSorting
	{
		 get { } //Length: 5
		 set { } //Length: 4
	}

	public GizmoEngineSettings() { }

	public bool get_EnableGizmoSorting() { }

	public void set_EnableGizmoSorting(bool value) { }

}

