namespace RLD;

public class ObjectLayerGrabSettings
{
	[SerializeField]
	private int _layer; //Field offset: 0x10
	[SerializeField]
	private bool _isActive; //Field offset: 0x14
	[SerializeField]
	private bool _alignAxis; //Field offset: 0x15
	[SerializeField]
	private TransformAxis _alignmentAxis; //Field offset: 0x18
	[SerializeField]
	private float _defaultOffsetFromSurface; //Field offset: 0x1C

	public bool AlignAxis
	{
		 get { } //Length: 5
		 set { } //Length: 4
	}

	public TransformAxis AlignmentAxis
	{
		 get { } //Length: 4
		 set { } //Length: 4
	}

	public float DefaultOffsetFromSurface
	{
		 get { } //Length: 6
		 set { } //Length: 6
	}

	public bool IsActive
	{
		 get { } //Length: 5
		 set { } //Length: 4
	}

	public int Layer
	{
		 get { } //Length: 4
	}

	public ObjectLayerGrabSettings(int layer) { }

	public bool get_AlignAxis() { }

	public TransformAxis get_AlignmentAxis() { }

	public float get_DefaultOffsetFromSurface() { }

	public bool get_IsActive() { }

	public int get_Layer() { }

	public void set_AlignAxis(bool value) { }

	public void set_AlignmentAxis(TransformAxis value) { }

	public void set_DefaultOffsetFromSurface(float value) { }

	public void set_IsActive(bool value) { }

}

