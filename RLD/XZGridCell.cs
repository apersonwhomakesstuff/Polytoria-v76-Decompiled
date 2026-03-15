namespace RLD;

public class XZGridCell
{
	private IXZGrid _parentGrid; //Field offset: 0x10
	private int _xIndex; //Field offset: 0x18
	private int _zIndex; //Field offset: 0x1C
	private Vector3 _min; //Field offset: 0x20
	private Vector3 _max; //Field offset: 0x2C

	public Vector3 Center
	{
		 get { } //Length: 84
	}

	public Vector3 Max
	{
		 get { } //Length: 19
	}

	public Vector3 Min
	{
		 get { } //Length: 19
	}

	public IXZGrid ParentGrid
	{
		 get { } //Length: 5
	}

	public int XIndex
	{
		 get { } //Length: 4
	}

	public int ZIndex
	{
		 get { } //Length: 4
	}

	public XZGridCell(int xIndex, int zIndex, Vector3 min, Vector3 max, IXZGrid parentGrid) { }

	public static XZGridCell FromPoint(Vector3 point, float cellSizeX, float cellSizeZ, IXZGrid parentGrid) { }

	public Vector3 get_Center() { }

	public Vector3 get_Max() { }

	public Vector3 get_Min() { }

	public IXZGrid get_ParentGrid() { }

	public int get_XIndex() { }

	public int get_ZIndex() { }

	public List<Vector3> GetCenterAndCorners() { }

}

