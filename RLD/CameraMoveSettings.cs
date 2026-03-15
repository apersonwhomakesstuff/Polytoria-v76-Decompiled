namespace RLD;

public class CameraMoveSettings : Settings
{
	private static readonly float _minMoveSpeed; //Field offset: 0x0
	[SerializeField]
	private float _moveSpeed; //Field offset: 0x28
	[SerializeField]
	private float _alternateMoveSpeed; //Field offset: 0x2C
	[SerializeField]
	private float _accelerationRate; //Field offset: 0x30

	public float AccelerationRate
	{
		 get { } //Length: 6
		 set { } //Length: 15
	}

	public float AlternateMoveSpeed
	{
		 get { } //Length: 6
		 set { } //Length: 107
	}

	public float MoveSpeed
	{
		 get { } //Length: 6
		 set { } //Length: 107
	}

	private static CameraMoveSettings() { }

	public CameraMoveSettings() { }

	public float get_AccelerationRate() { }

	public float get_AlternateMoveSpeed() { }

	public float get_MoveSpeed() { }

	public void set_AccelerationRate(float value) { }

	public void set_AlternateMoveSpeed(float value) { }

	public void set_MoveSpeed(float value) { }

}

