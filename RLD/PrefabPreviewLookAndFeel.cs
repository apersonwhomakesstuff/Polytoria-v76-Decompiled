namespace RLD;

public class PrefabPreviewLookAndFeel : Settings
{
	private static readonly float _minBkAlpha; //Field offset: 0x0
	[SerializeField]
	private Color _bkColor; //Field offset: 0x28
	[SerializeField]
	private int _previewWidth; //Field offset: 0x38
	[SerializeField]
	private int _previewHeight; //Field offset: 0x3C
	[SerializeField]
	private float _lightIntensity; //Field offset: 0x40

	public Color BkColor
	{
		 get { } //Length: 11
		 set { } //Length: 114
	}

	public float LightIntensity
	{
		 get { } //Length: 6
		 set { } //Length: 20
	}

	public int PreviewHeight
	{
		 get { } //Length: 4
		 set { } //Length: 16
	}

	public int PreviewWidth
	{
		 get { } //Length: 4
		 set { } //Length: 16
	}

	private static PrefabPreviewLookAndFeel() { }

	public PrefabPreviewLookAndFeel() { }

	public Color get_BkColor() { }

	public float get_LightIntensity() { }

	public int get_PreviewHeight() { }

	public int get_PreviewWidth() { }

	public void set_BkColor(Color value) { }

	public void set_LightIntensity(float value) { }

	public void set_PreviewHeight(int value) { }

	public void set_PreviewWidth(int value) { }

}

