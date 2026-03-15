namespace Polytoria.Datamodel;

public struct RayResult
{
	[CompilerGenerated]
	private Vector3 <Origin>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private Vector3 <Direction>k__BackingField; //Field offset: 0xC
	[CompilerGenerated]
	private Vector3 <Position>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private Vector3 <Normal>k__BackingField; //Field offset: 0x24
	[CompilerGenerated]
	private float <Distance>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	private Instance <Instance>k__BackingField; //Field offset: 0x38

	public Vector3 Direction
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 19
		[CompilerGenerated]
		 set { } //Length: 16
	}

	public float Distance
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 6
		[CompilerGenerated]
		 set { } //Length: 6
	}

	public Instance Instance
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 13
	}

	public Vector3 Normal
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 19
		[CompilerGenerated]
		 set { } //Length: 16
	}

	public Vector3 Origin
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 18
		[CompilerGenerated]
		 set { } //Length: 15
	}

	public Vector3 Position
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 19
		[CompilerGenerated]
		 set { } //Length: 16
	}

	[CompilerGenerated]
	[IsReadOnly]
	public Vector3 get_Direction() { }

	[CompilerGenerated]
	[IsReadOnly]
	public float get_Distance() { }

	[CompilerGenerated]
	[IsReadOnly]
	public Instance get_Instance() { }

	[CompilerGenerated]
	[IsReadOnly]
	public Vector3 get_Normal() { }

	[CompilerGenerated]
	[IsReadOnly]
	public Vector3 get_Origin() { }

	[CompilerGenerated]
	[IsReadOnly]
	public Vector3 get_Position() { }

	[CompilerGenerated]
	public void set_Direction(Vector3 value) { }

	[CompilerGenerated]
	public void set_Distance(float value) { }

	[CompilerGenerated]
	public void set_Instance(Instance value) { }

	[CompilerGenerated]
	public void set_Normal(Vector3 value) { }

	[CompilerGenerated]
	public void set_Origin(Vector3 value) { }

	[CompilerGenerated]
	public void set_Position(Vector3 value) { }

}

