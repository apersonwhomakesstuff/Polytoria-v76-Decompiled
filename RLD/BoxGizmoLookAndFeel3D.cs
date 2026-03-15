namespace RLD;

public class BoxGizmoLookAndFeel3D : Settings
{
	[SerializeField]
	private Color _boxWireColor; //Field offset: 0x28
	[SerializeField]
	private GizmoCap2DLookAndFeel[] _tickLookAndFeel; //Field offset: 0x38

	public Color BoxWireColor
	{
		 get { } //Length: 11
	}

	public Color TickBorderColor
	{
		 get { } //Length: 58
	}

	public float TickCircleRadius
	{
		 get { } //Length: 49
	}

	public Color TickHoveredBorderColor
	{
		 get { } //Length: 58
	}

	public Color TickHoveredColor
	{
		 get { } //Length: 58
	}

	public float TickQuadHeight
	{
		 get { } //Length: 49
	}

	public float TickQuadWidth
	{
		 get { } //Length: 49
	}

	public GizmoCap2DType TickType
	{
		 get { } //Length: 47
	}

	public Color XTickColor
	{
		 get { } //Length: 58
	}

	public Color YTickColor
	{
		 get { } //Length: 58
	}

	public Color ZTickColor
	{
		 get { } //Length: 58
	}

	public BoxGizmoLookAndFeel3D() { }

	public void ConnectTickLookAndFeel(GizmoCap2D tick, int axisIndex, AxisSign axisSign) { }

	public Color get_BoxWireColor() { }

	public Color get_TickBorderColor() { }

	public float get_TickCircleRadius() { }

	public Color get_TickHoveredBorderColor() { }

	public Color get_TickHoveredColor() { }

	public float get_TickQuadHeight() { }

	public float get_TickQuadWidth() { }

	public GizmoCap2DType get_TickType() { }

	public Color get_XTickColor() { }

	public Color get_YTickColor() { }

	public Color get_ZTickColor() { }

	public List<Enum> GetAllowedTickTypes() { }

	private GizmoCap2DLookAndFeel GetTickLookAndFeel(int axisIndex, AxisSign axisSign) { }

	public bool IsTickTypeAllowed(GizmoCap2DType tickType) { }

	public void SetAxisTickColor(int axisIndex, Color color) { }

	public void SetBoxWireColor(Color color) { }

	public void SetTickBorderColor(Color color) { }

	public void SetTickCircleRadius(float radius) { }

	public void SetTickHoveredBorderColor(Color color) { }

	public void SetTickHoveredColor(Color color) { }

	public void SetTickQuadHeight(float height) { }

	public void SetTickQuadWidth(float width) { }

	public void SetTickType(GizmoCap2DType tickType) { }

}

