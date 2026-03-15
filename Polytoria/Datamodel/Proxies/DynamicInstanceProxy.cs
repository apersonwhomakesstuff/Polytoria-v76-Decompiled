namespace Polytoria.Datamodel.Proxies;

public class DynamicInstanceProxy : InstanceProxy
{
	private readonly DynamicInstance dynamicInstance; //Field offset: 0x18

	public Vector3 Forward
	{
		 get { } //Length: 59
	}

	public Vector3 LocalPosition
	{
		 get { } //Length: 59
		 set { } //Length: 53
	}

	public Quaternion LocalQuaternion
	{
		 get { } //Length: 51
		 set { } //Length: 44
	}

	public Vector3 LocalRotation
	{
		 get { } //Length: 59
		 set { } //Length: 53
	}

	public Vector3 LocalSize
	{
		 get { } //Length: 59
		 set { } //Length: 53
	}

	public Vector3 Position
	{
		 get { } //Length: 59
		 set { } //Length: 53
	}

	public Quaternion Quaternion
	{
		 get { } //Length: 51
		 set { } //Length: 44
	}

	public Vector3 Right
	{
		 get { } //Length: 59
	}

	public Vector3 Rotation
	{
		 get { } //Length: 59
		 set { } //Length: 53
	}

	public Vector3 Size
	{
		 get { } //Length: 59
		 set { } //Length: 53
	}

	public Vector3 Up
	{
		 get { } //Length: 59
	}

	[MoonSharpHidden]
	public DynamicInstanceProxy(DynamicInstance target) { }

	public Vector3 get_Forward() { }

	public Vector3 get_LocalPosition() { }

	public Quaternion get_LocalQuaternion() { }

	public Vector3 get_LocalRotation() { }

	public Vector3 get_LocalSize() { }

	public Vector3 get_Position() { }

	public Quaternion get_Quaternion() { }

	public Vector3 get_Right() { }

	public Vector3 get_Rotation() { }

	public Vector3 get_Size() { }

	public Vector3 get_Up() { }

	public Vector3 InverseTransformDirection(Vector3 direction) { }

	public Vector3 InverseTransformPoint(Vector3 point) { }

	public Vector3 InverseTransformVector(Vector3 vector) { }

	public void LookAt(DynamicInstance dynamicInstance) { }

	public void LookAt(Vector3 lookTarget) { }

	public void LookAt(Vector3 lookTarget, Vector3 worldUp) { }

	public void Rotate(Vector3 eulerAngles) { }

	public void RotateAround(Vector3 point, Vector3 axis, float angle) { }

	public void set_LocalPosition(Vector3 value) { }

	public void set_LocalQuaternion(Quaternion value) { }

	public void set_LocalRotation(Vector3 value) { }

	public void set_LocalSize(Vector3 value) { }

	public void set_Position(Vector3 value) { }

	public void set_Quaternion(Quaternion value) { }

	public void set_Rotation(Vector3 value) { }

	public void set_Size(Vector3 value) { }

	public Vector3 TransformDirection(Vector3 direction) { }

	public Vector3 TransformPoint(Vector3 point) { }

	public Vector3 TransformVector(Vector3 vector) { }

	public void Translate(Vector3 translation) { }

}

