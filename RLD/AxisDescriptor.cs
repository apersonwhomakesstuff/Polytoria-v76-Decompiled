namespace RLD;

public class AxisDescriptor
{
	private AxisSign _sign; //Field offset: 0x10
	private int _index; //Field offset: 0x14

	public int Index
	{
		 get { } //Length: 4
	}

	public bool IsNegative
	{
		 get { } //Length: 8
	}

	public bool IsPositive
	{
		 get { } //Length: 8
	}

	public AxisSign Sign
	{
		 get { } //Length: 4
	}

	public AxisDescriptor(int axisIndex, AxisSign axisSign) { }

	public AxisDescriptor(int axisIndex, bool isNegative) { }

	public int get_Index() { }

	public bool get_IsNegative() { }

	public bool get_IsPositive() { }

	public AxisSign get_Sign() { }

	public BoxFace GetAssociatedBoxFace() { }

}

