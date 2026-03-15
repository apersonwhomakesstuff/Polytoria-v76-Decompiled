namespace RLD;

public class ObjectGrabLookAndFeel : Settings
{
	[SerializeField]
	private bool _drawAnchorLines; //Field offset: 0x28
	[SerializeField]
	private Color _anchorLineColor; //Field offset: 0x2C
	[SerializeField]
	private bool _drawObjectPosTicks; //Field offset: 0x3C
	[SerializeField]
	private bool _drawAnchorPosTick; //Field offset: 0x3D
	[SerializeField]
	private Color _objectPosTickColor; //Field offset: 0x40
	[SerializeField]
	private Color _anchorPosTickColor; //Field offset: 0x50
	[SerializeField]
	private float _objectPosTickSize; //Field offset: 0x60
	[SerializeField]
	private float _anchorPosTickSize; //Field offset: 0x64
	[SerializeField]
	private bool _drawObjectBoxes; //Field offset: 0x68
	[SerializeField]
	private Color _objectBoxWireColor; //Field offset: 0x6C

	public Color AnchorLineColor
	{
		 get { } //Length: 11
		 set { } //Length: 8
	}

	public Color AnchorPosTickColor
	{
		 get { } //Length: 11
		 set { } //Length: 8
	}

	public float AnchorPosTickSize
	{
		 get { } //Length: 6
		 set { } //Length: 20
	}

	public bool DrawAnchorLines
	{
		 get { } //Length: 5
		 set { } //Length: 4
	}

	public bool DrawAnchorPosTick
	{
		 get { } //Length: 5
		 set { } //Length: 4
	}

	public bool DrawObjectBoxes
	{
		 get { } //Length: 5
		 set { } //Length: 4
	}

	public bool DrawObjectPosTicks
	{
		 get { } //Length: 5
		 set { } //Length: 4
	}

	public Color ObjectBoxWireColor
	{
		 get { } //Length: 11
		 set { } //Length: 8
	}

	public Color ObjectPosTickColor
	{
		 get { } //Length: 11
		 set { } //Length: 8
	}

	public float ObjectPosTickSize
	{
		 get { } //Length: 6
		 set { } //Length: 20
	}

	public ObjectGrabLookAndFeel() { }

	public Color get_AnchorLineColor() { }

	public Color get_AnchorPosTickColor() { }

	public float get_AnchorPosTickSize() { }

	public bool get_DrawAnchorLines() { }

	public bool get_DrawAnchorPosTick() { }

	public bool get_DrawObjectBoxes() { }

	public bool get_DrawObjectPosTicks() { }

	public Color get_ObjectBoxWireColor() { }

	public Color get_ObjectPosTickColor() { }

	public float get_ObjectPosTickSize() { }

	public void set_AnchorLineColor(Color value) { }

	public void set_AnchorPosTickColor(Color value) { }

	public void set_AnchorPosTickSize(float value) { }

	public void set_DrawAnchorLines(bool value) { }

	public void set_DrawAnchorPosTick(bool value) { }

	public void set_DrawObjectBoxes(bool value) { }

	public void set_DrawObjectPosTicks(bool value) { }

	public void set_ObjectBoxWireColor(Color value) { }

	public void set_ObjectPosTickColor(Color value) { }

	public void set_ObjectPosTickSize(float value) { }

}

