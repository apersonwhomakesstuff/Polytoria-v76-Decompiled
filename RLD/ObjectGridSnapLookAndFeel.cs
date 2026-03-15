namespace RLD;

public class ObjectGridSnapLookAndFeel : Settings
{
	[SerializeField]
	private PivotPointShapeType _pivotShapeType; //Field offset: 0x28
	[SerializeField]
	private Color _pivotPointFillColor; //Field offset: 0x2C
	[SerializeField]
	private Color _pivotPointBorderColor; //Field offset: 0x3C
	[SerializeField]
	private float _pivotCircleRadius; //Field offset: 0x4C
	[SerializeField]
	private float _pivotSquareSideLength; //Field offset: 0x50
	[SerializeField]
	private bool _drawPivotBorder; //Field offset: 0x54
	[SerializeField]
	private Color _boxLineColor; //Field offset: 0x58
	[SerializeField]
	private bool _drawBoxes; //Field offset: 0x68

	public Color BoxLineColor
	{
		 get { } //Length: 11
		 set { } //Length: 8
	}

	public bool DrawBoxes
	{
		 get { } //Length: 5
		 set { } //Length: 4
	}

	public bool DrawPivotBorder
	{
		 get { } //Length: 5
		 set { } //Length: 4
	}

	public float PivotCircleRadius
	{
		 get { } //Length: 6
		 set { } //Length: 20
	}

	public Color PivotPointBorderColor
	{
		 get { } //Length: 11
		 set { } //Length: 8
	}

	public Color PivotPointFillColor
	{
		 get { } //Length: 11
		 set { } //Length: 8
	}

	public PivotPointShapeType PivotShapeType
	{
		 get { } //Length: 4
		 set { } //Length: 4
	}

	public float PivotSquareSideLength
	{
		 get { } //Length: 6
		 set { } //Length: 20
	}

	public ObjectGridSnapLookAndFeel() { }

	public Color get_BoxLineColor() { }

	public bool get_DrawBoxes() { }

	public bool get_DrawPivotBorder() { }

	public float get_PivotCircleRadius() { }

	public Color get_PivotPointBorderColor() { }

	public Color get_PivotPointFillColor() { }

	public PivotPointShapeType get_PivotShapeType() { }

	public float get_PivotSquareSideLength() { }

	public void set_BoxLineColor(Color value) { }

	public void set_DrawBoxes(bool value) { }

	public void set_DrawPivotBorder(bool value) { }

	public void set_PivotCircleRadius(float value) { }

	public void set_PivotPointBorderColor(Color value) { }

	public void set_PivotPointFillColor(Color value) { }

	public void set_PivotShapeType(PivotPointShapeType value) { }

	public void set_PivotSquareSideLength(float value) { }

}

