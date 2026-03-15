namespace RLD;

public class Priority
{
	private int _priority; //Field offset: 0x10

	public static int Highest
	{
		 get { } //Length: 6
	}

	public static int Lowest
	{
		 get { } //Length: 6
	}

	public int Value
	{
		 get { } //Length: 4
		 set { } //Length: 4
	}

	public Priority() { }

	public int CompareTo(Priority other) { }

	public virtual bool Equals(object obj) { }

	public static int get_Highest() { }

	public static int get_Lowest() { }

	public int get_Value() { }

	public virtual int GetHashCode() { }

	public void MakeHigherThan(Priority priority) { }

	public void MakeHighest() { }

	public void MakeLowerThan(Priority priority) { }

	public void MakeLowest() { }

	public static bool op_Equality(Priority firstPriority, Priority secondPriority) { }

	public static bool op_GreaterThan(Priority firstPriority, Priority secondPriority) { }

	public static bool op_GreaterThanOrEqual(Priority firstPriority, Priority secondPriority) { }

	public static bool op_Inequality(Priority firstPriority, Priority secondPriority) { }

	public static bool op_LessThan(Priority firstPriority, Priority secondPriority) { }

	public static bool op_LessThanOrEqual(Priority firstPriority, Priority secondPriority) { }

	public void set_Value(int value) { }

}

