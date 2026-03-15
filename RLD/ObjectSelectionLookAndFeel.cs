namespace RLD;

public class ObjectSelectionLookAndFeel : Settings
{
	[SerializeField]
	private bool _drawHighlight; //Field offset: 0x28
	[SerializeField]
	private SelectionBoxBorderStyle _selectionBoxBorderStyle; //Field offset: 0x2C
	[SerializeField]
	private float _wireCornerLinePercentage; //Field offset: 0x30
	[SerializeField]
	private SelectionBoxRenderMode _selectionBoxRenderMode; //Field offset: 0x34
	[SerializeField]
	private Color _selectionBoxBorderColor; //Field offset: 0x38
	[SerializeField]
	private float _selectionBoxInflateAmount; //Field offset: 0x48
	[SerializeField]
	private Color _selectionRectBorderColor; //Field offset: 0x4C
	[SerializeField]
	private Color _selectionRectFillColor; //Field offset: 0x5C

	public bool DrawHighlight
	{
		 get { } //Length: 5
		 set { } //Length: 4
	}

	public SelectionBoxBorderStyle SelBoxBorderStyle
	{
		 get { } //Length: 4
		 set { } //Length: 4
	}

	public SelectionBoxRenderMode SelBoxRenderMode
	{
		 get { } //Length: 4
		 set { } //Length: 4
	}

	public Color SelectionBoxBorderColor
	{
		 get { } //Length: 11
		 set { } //Length: 8
	}

	public float SelectionBoxInflateAmount
	{
		 get { } //Length: 6
		 set { } //Length: 15
	}

	public Color SelectionRectBorderColor
	{
		 get { } //Length: 11
		 set { } //Length: 8
	}

	public Color SelectionRectFillColor
	{
		 get { } //Length: 11
		 set { } //Length: 8
	}

	public float WireCornerLinePercentage
	{
		 get { } //Length: 6
		 set { } //Length: 38
	}

	public ObjectSelectionLookAndFeel() { }

	public bool get_DrawHighlight() { }

	public SelectionBoxBorderStyle get_SelBoxBorderStyle() { }

	public SelectionBoxRenderMode get_SelBoxRenderMode() { }

	public Color get_SelectionBoxBorderColor() { }

	public float get_SelectionBoxInflateAmount() { }

	public Color get_SelectionRectBorderColor() { }

	public Color get_SelectionRectFillColor() { }

	public float get_WireCornerLinePercentage() { }

	public void set_DrawHighlight(bool value) { }

	public void set_SelBoxBorderStyle(SelectionBoxBorderStyle value) { }

	public void set_SelBoxRenderMode(SelectionBoxRenderMode value) { }

	public void set_SelectionBoxBorderColor(Color value) { }

	public void set_SelectionBoxInflateAmount(float value) { }

	public void set_SelectionRectBorderColor(Color value) { }

	public void set_SelectionRectFillColor(Color value) { }

	public void set_WireCornerLinePercentage(float value) { }

}

