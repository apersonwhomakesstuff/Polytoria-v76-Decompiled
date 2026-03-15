namespace RLD;

public class ObjectSelectionRotationSettings : Settings
{
	[SerializeField]
	private ObjectRotationPivot _rotationPivot; //Field offset: 0x28
	[SerializeField]
	private ObjectKeyRotationSettings _keyRotationSettings; //Field offset: 0x30

	public ObjectKeyRotationSettings KeyRotationSettings
	{
		 get { } //Length: 95
	}

	public ObjectRotationPivot RotationPivot
	{
		 get { } //Length: 4
		 set { } //Length: 4
	}

	public ObjectSelectionRotationSettings() { }

	public ObjectKeyRotationSettings get_KeyRotationSettings() { }

	public ObjectRotationPivot get_RotationPivot() { }

	public void set_RotationPivot(ObjectRotationPivot value) { }

}

