namespace RLD;

public class GizmoLineSlider3DSettings
{
	[SerializeField]
	private float _lineHoverEps; //Field offset: 0x10
	[SerializeField]
	private float _boxHoverEps; //Field offset: 0x14
	[SerializeField]
	private float _cylinderHoverEps; //Field offset: 0x18
	[SerializeField]
	private float _offsetSnapStep; //Field offset: 0x1C
	[SerializeField]
	private float _rotationSnapStep; //Field offset: 0x20
	[SerializeField]
	private GizmoSnapMode _rotationSnapMode; //Field offset: 0x24
	[SerializeField]
	private float _scaleSnapStep; //Field offset: 0x28
	[SerializeField]
	private float _offsetSensitivity; //Field offset: 0x2C
	[SerializeField]
	private float _rotationSensitivity; //Field offset: 0x30
	[SerializeField]
	private float _scaleSensitivity; //Field offset: 0x34

	public float BoxHoverEps
	{
		 get { } //Length: 6
		 set { } //Length: 15
	}

	public float CylinderHoverEps
	{
		 get { } //Length: 6
		 set { } //Length: 15
	}

	public float LineHoverEps
	{
		 get { } //Length: 6
		 set { } //Length: 15
	}

	public float OffsetSensitivity
	{
		 get { } //Length: 6
		 set { } //Length: 20
	}

	public float OffsetSnapStep
	{
		 get { } //Length: 6
		 set { } //Length: 20
	}

	public float RotationSensitivity
	{
		 get { } //Length: 6
		 set { } //Length: 20
	}

	public GizmoSnapMode RotationSnapMode
	{
		 get { } //Length: 4
		 set { } //Length: 4
	}

	public float RotationSnapStep
	{
		 get { } //Length: 6
		 set { } //Length: 20
	}

	public float ScaleSensitivity
	{
		 get { } //Length: 6
		 set { } //Length: 20
	}

	public float ScaleSnapStep
	{
		 get { } //Length: 6
		 set { } //Length: 20
	}

	public GizmoLineSlider3DSettings() { }

	public float get_BoxHoverEps() { }

	public float get_CylinderHoverEps() { }

	public float get_LineHoverEps() { }

	public float get_OffsetSensitivity() { }

	public float get_OffsetSnapStep() { }

	public float get_RotationSensitivity() { }

	public GizmoSnapMode get_RotationSnapMode() { }

	public float get_RotationSnapStep() { }

	public float get_ScaleSensitivity() { }

	public float get_ScaleSnapStep() { }

	public void set_BoxHoverEps(float value) { }

	public void set_CylinderHoverEps(float value) { }

	public void set_LineHoverEps(float value) { }

	public void set_OffsetSensitivity(float value) { }

	public void set_OffsetSnapStep(float value) { }

	public void set_RotationSensitivity(float value) { }

	public void set_RotationSnapMode(GizmoSnapMode value) { }

	public void set_RotationSnapStep(float value) { }

	public void set_ScaleSensitivity(float value) { }

	public void set_ScaleSnapStep(float value) { }

}

