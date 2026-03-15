namespace RLD;

public class XZGridSettings : Settings
{
	[SerializeField]
	private bool _isVisible; //Field offset: 0x28
	[SerializeField]
	private float _cellSizeX; //Field offset: 0x2C
	[SerializeField]
	private float _cellSizeZ; //Field offset: 0x30
	[SerializeField]
	private float _yOffset; //Field offset: 0x34
	[SerializeField]
	private Vector3 _rotationAngles; //Field offset: 0x38
	[SerializeField]
	private float _upDownStep; //Field offset: 0x44

	public float CellSizeX
	{
		 get { } //Length: 6
		 set { } //Length: 16
	}

	public float CellSizeZ
	{
		 get { } //Length: 6
		 set { } //Length: 16
	}

	public bool IsVisible
	{
		 get { } //Length: 5
		 set { } //Length: 4
	}

	public Vector3 RotationAngles
	{
		 get { } //Length: 19
		 set { } //Length: 16
	}

	public float UpDownStep
	{
		 get { } //Length: 6
		 set { } //Length: 20
	}

	public float YOffset
	{
		 get { } //Length: 6
		 set { } //Length: 6
	}

	public XZGridSettings() { }

	public float get_CellSizeX() { }

	public float get_CellSizeZ() { }

	public bool get_IsVisible() { }

	public Vector3 get_RotationAngles() { }

	public float get_UpDownStep() { }

	public float get_YOffset() { }

	public void set_CellSizeX(float value) { }

	public void set_CellSizeZ(float value) { }

	public void set_IsVisible(bool value) { }

	public void set_RotationAngles(Vector3 value) { }

	public void set_UpDownStep(float value) { }

	public void set_YOffset(float value) { }

}

