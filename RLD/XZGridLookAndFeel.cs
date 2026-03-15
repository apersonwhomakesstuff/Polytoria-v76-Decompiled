namespace RLD;

public class XZGridLookAndFeel : Settings
{
	[SerializeField]
	private Color _lineColor; //Field offset: 0x28
	[SerializeField]
	private bool _useCellFading; //Field offset: 0x38

	public Color LineColor
	{
		 get { } //Length: 11
		 set { } //Length: 8
	}

	public bool UseCellFading
	{
		 get { } //Length: 5
		 set { } //Length: 4
	}

	public XZGridLookAndFeel() { }

	public Color get_LineColor() { }

	public bool get_UseCellFading() { }

	public void set_LineColor(Color value) { }

	public void set_UseCellFading(bool value) { }

}

