namespace RLD;

public class RTCustomObjectInteractionSettings : Settings
{
	[SerializeField]
	private Vector3 _noVolumeObjectSize; //Field offset: 0x28

	public Vector3 NoVolumeObjectSize
	{
		 get { } //Length: 19
		 set { } //Length: 179
	}

	public RTCustomObjectInteractionSettings() { }

	public Vector3 get_NoVolumeObjectSize() { }

	public void set_NoVolumeObjectSize(Vector3 value) { }

}

