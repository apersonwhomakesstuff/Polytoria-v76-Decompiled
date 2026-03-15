namespace RLD;

public class Object2ObjectSnapSettings : Settings
{
	[SerializeField]
	private int _snapDestinationLayers; //Field offset: 0x28
	[SerializeField]
	private bool _canClimbObjects; //Field offset: 0x2C
	[SerializeField]
	private float _snapRadius; //Field offset: 0x30

	public bool CanClimbObjects
	{
		 get { } //Length: 5
		 set { } //Length: 4
	}

	public int SnapDestinationLayers
	{
		 get { } //Length: 4
		 set { } //Length: 4
	}

	public float SnapRadius
	{
		 get { } //Length: 6
		 set { } //Length: 15
	}

	public Object2ObjectSnapSettings() { }

	public bool get_CanClimbObjects() { }

	public int get_SnapDestinationLayers() { }

	public float get_SnapRadius() { }

	public void set_CanClimbObjects(bool value) { }

	public void set_SnapDestinationLayers(int value) { }

	public void set_SnapRadius(float value) { }

}

