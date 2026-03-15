namespace RLD;

public class GizmoObjectVertexSnapSettings : Settings
{
	[SerializeField]
	private int _snapDestinationLayers; //Field offset: 0x28
	[SerializeField]
	private bool _canSnapToGrid; //Field offset: 0x2C
	[SerializeField]
	private bool _canSnapToObjectVerts; //Field offset: 0x2D

	public bool CanSnapToGrid
	{
		 get { } //Length: 5
		 set { } //Length: 4
	}

	public bool CanSnapToObjectVerts
	{
		 get { } //Length: 5
		 set { } //Length: 4
	}

	public int SnapDestinationLayers
	{
		 get { } //Length: 4
		 set { } //Length: 4
	}

	public GizmoObjectVertexSnapSettings() { }

	public bool get_CanSnapToGrid() { }

	public bool get_CanSnapToObjectVerts() { }

	public int get_SnapDestinationLayers() { }

	public bool IsLayerSnapDestination(int objectLayer) { }

	public void set_CanSnapToGrid(bool value) { }

	public void set_CanSnapToObjectVerts(bool value) { }

	public void set_SnapDestinationLayers(int value) { }

	public void SetLayerSnapDestination(int objectLayer, bool isSnapDestination) { }

	public void Transfer(GizmoObjectVertexSnapSettings destination) { }

}

