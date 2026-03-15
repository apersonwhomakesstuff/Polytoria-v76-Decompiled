namespace Polytoria.Datamodel.Proxies;

public class PartProxy : DynamicInstanceProxy
{
	private readonly Part part; //Field offset: 0x20

	public bool Anchored
	{
		 get { } //Length: 30
		 set { } //Length: 30
	}

	public float AngularDrag
	{
		 get { } //Length: 29
		 set { } //Length: 30
	}

	public Vector3 AngularVelocity
	{
		 get { } //Length: 59
		 set { } //Length: 53
	}

	public float Bounciness
	{
		 get { } //Length: 29
		 set { } //Length: 30
	}

	public bool CanCollide
	{
		 get { } //Length: 30
		 set { } //Length: 30
	}

	public bool CastShadows
	{
		 get { } //Length: 30
		 set { } //Length: 30
	}

	public Color Color
	{
		 get { } //Length: 36
		 set { } //Length: 44
	}

	public float Drag
	{
		 get { } //Length: 29
		 set { } //Length: 30
	}

	public float Friction
	{
		 get { } //Length: 29
		 set { } //Length: 30
	}

	public bool IsSpawn
	{
		 get { } //Length: 30
		 set { } //Length: 30
	}

	public float Mass
	{
		 get { } //Length: 29
		 set { } //Length: 30
	}

	public PartMaterial Material
	{
		 get { } //Length: 29
		 set { } //Length: 30
	}

	public PartShape Shape
	{
		 get { } //Length: 29
		 set { } //Length: 30
	}

	public bool UseGravity
	{
		 get { } //Length: 30
		 set { } //Length: 30
	}

	public Vector3 Velocity
	{
		 get { } //Length: 59
		 set { } //Length: 53
	}

	[MoonSharpHidden]
	public PartProxy(Part target) { }

	public void AddForce(Vector3 force, ForceMode mode = 0) { }

	public void AddForceAtPosition(Vector3 force, Vector3 position, ForceMode mode = 0) { }

	public void AddRelativeForce(Vector3 force, ForceMode mode = 0) { }

	public void AddRelativeTorque(Vector3 torque, ForceMode mode = 0) { }

	public void AddTorque(Vector3 torque, ForceMode mode = 0) { }

	public bool get_Anchored() { }

	public float get_AngularDrag() { }

	public Vector3 get_AngularVelocity() { }

	public float get_Bounciness() { }

	public bool get_CanCollide() { }

	public bool get_CastShadows() { }

	public Color get_Color() { }

	public float get_Drag() { }

	public float get_Friction() { }

	public bool get_IsSpawn() { }

	public float get_Mass() { }

	public PartMaterial get_Material() { }

	public PartShape get_Shape() { }

	public bool get_UseGravity() { }

	public Vector3 get_Velocity() { }

	public void MovePosition(Vector3 pos) { }

	public void MoveRotation(Vector3 rot) { }

	public void set_Anchored(bool value) { }

	public void set_AngularDrag(float value) { }

	public void set_AngularVelocity(Vector3 value) { }

	public void set_Bounciness(float value) { }

	public void set_CanCollide(bool value) { }

	public void set_CastShadows(bool value) { }

	public void set_Color(Color value) { }

	public void set_Drag(float value) { }

	public void set_Friction(float value) { }

	public void set_IsSpawn(bool value) { }

	public void set_Mass(float value) { }

	public void set_Material(PartMaterial value) { }

	public void set_Shape(PartShape value) { }

	public void set_UseGravity(bool value) { }

	public void set_Velocity(Vector3 value) { }

}

