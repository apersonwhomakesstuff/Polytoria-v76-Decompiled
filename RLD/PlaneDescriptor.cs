namespace RLD;

public struct PlaneDescriptor
{
	private PlaneId _id; //Field offset: 0x0
	private PlaneQuadrantId _quadrant; //Field offset: 0x4
	private AxisDescriptor _firstAxisDescriptor; //Field offset: 0x8
	private AxisDescriptor _secondAxisDescriptor; //Field offset: 0x10

	public AxisDescriptor FirstAxisDescriptor
	{
		 get { } //Length: 5
	}

	public int FirstAxisIndex
	{
		 get { } //Length: 26
	}

	public AxisSign FirstAxisSign
	{
		 get { } //Length: 26
	}

	public PlaneId Id
	{
		 get { } //Length: 3
	}

	public PlaneQuadrantId Quadrant
	{
		 get { } //Length: 4
	}

	public AxisDescriptor SecondAxisDescriptor
	{
		 get { } //Length: 5
	}

	public int SecondAxisIndex
	{
		 get { } //Length: 26
	}

	public AxisSign SecondAxisSign
	{
		 get { } //Length: 26
	}

	public PlaneDescriptor(PlaneId planeId, PlaneQuadrantId planeQuadrant) { }

	public AxisDescriptor get_FirstAxisDescriptor() { }

	public int get_FirstAxisIndex() { }

	public AxisSign get_FirstAxisSign() { }

	public PlaneId get_Id() { }

	public PlaneQuadrantId get_Quadrant() { }

	public AxisDescriptor get_SecondAxisDescriptor() { }

	public int get_SecondAxisIndex() { }

	public AxisSign get_SecondAxisSign() { }

}

