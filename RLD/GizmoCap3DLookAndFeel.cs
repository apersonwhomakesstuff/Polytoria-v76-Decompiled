namespace RLD;

public class GizmoCap3DLookAndFeel
{
	[SerializeField]
	private GizmoCap3DType _capType; //Field offset: 0x10
	[SerializeField]
	private GizmoFillMode3D _fillMode; //Field offset: 0x14
	[SerializeField]
	private GizmoShadeMode _shadeMode; //Field offset: 0x18
	[SerializeField]
	private float _scale; //Field offset: 0x1C
	[SerializeField]
	private bool _useZoomFactor; //Field offset: 0x20
	[SerializeField]
	private float _coneHeight; //Field offset: 0x24
	[SerializeField]
	private float _coneRadius; //Field offset: 0x28
	[SerializeField]
	private float _pyramidHeight; //Field offset: 0x2C
	[SerializeField]
	private float _pyramidWidth; //Field offset: 0x30
	[SerializeField]
	private float _pyramidDepth; //Field offset: 0x34
	[SerializeField]
	private float _boxWidth; //Field offset: 0x38
	[SerializeField]
	private float _boxHeight; //Field offset: 0x3C
	[SerializeField]
	private float _boxDepth; //Field offset: 0x40
	[SerializeField]
	private float _sphereRadius; //Field offset: 0x44
	[SerializeField]
	private float _trPrismWidth; //Field offset: 0x48
	[SerializeField]
	private float _trPrismHeight; //Field offset: 0x4C
	[SerializeField]
	private float _trPrismDepth; //Field offset: 0x50
	[SerializeField]
	private bool _isSphereBorderVisible; //Field offset: 0x54
	[SerializeField]
	private Color _sphereBorderColor; //Field offset: 0x58
	[SerializeField]
	private int _numSphereBorderPoints; //Field offset: 0x68
	[SerializeField]
	private Color _color; //Field offset: 0x6C
	[SerializeField]
	private Color _hoveredColor; //Field offset: 0x7C

	public float BoxDepth
	{
		 get { } //Length: 6
		 set { } //Length: 20
	}

	public float BoxHeight
	{
		 get { } //Length: 6
		 set { } //Length: 20
	}

	public float BoxWidth
	{
		 get { } //Length: 6
		 set { } //Length: 20
	}

	public GizmoCap3DType CapType
	{
		 get { } //Length: 4
		 set { } //Length: 4
	}

	public Color Color
	{
		 get { } //Length: 11
		 set { } //Length: 8
	}

	public float ConeHeight
	{
		 get { } //Length: 6
		 set { } //Length: 20
	}

	public float ConeRadius
	{
		 get { } //Length: 6
		 set { } //Length: 20
	}

	public static float DefaultConeHeight
	{
		 get { } //Length: 9
	}

	public static float DefaultConeRadius
	{
		 get { } //Length: 9
	}

	public static float DefaultPyramidDepth
	{
		 get { } //Length: 9
	}

	public static float DefaultPyramidHeight
	{
		 get { } //Length: 9
	}

	public static float DefaultPyramidWidth
	{
		 get { } //Length: 9
	}

	public GizmoFillMode3D FillMode
	{
		 get { } //Length: 4
		 set { } //Length: 4
	}

	public Color HoveredColor
	{
		 get { } //Length: 11
		 set { } //Length: 8
	}

	public bool IsSphereBorderVisible
	{
		 get { } //Length: 5
		 set { } //Length: 4
	}

	public int NumSphereBorderPoints
	{
		 get { } //Length: 4
		 set { } //Length: 16
	}

	public float PyramidDepth
	{
		 get { } //Length: 6
		 set { } //Length: 20
	}

	public float PyramidHeight
	{
		 get { } //Length: 6
		 set { } //Length: 20
	}

	public float PyramidWidth
	{
		 get { } //Length: 6
		 set { } //Length: 20
	}

	public float Scale
	{
		 get { } //Length: 6
		 set { } //Length: 15
	}

	public GizmoShadeMode ShadeMode
	{
		 get { } //Length: 4
		 set { } //Length: 4
	}

	public Color SphereBorderColor
	{
		 get { } //Length: 11
		 set { } //Length: 8
	}

	public float SphereRadius
	{
		 get { } //Length: 6
		 set { } //Length: 20
	}

	public float TrPrismDepth
	{
		 get { } //Length: 6
		 set { } //Length: 20
	}

	public float TrPrismHeight
	{
		 get { } //Length: 6
		 set { } //Length: 20
	}

	public float TrPrismWidth
	{
		 get { } //Length: 6
		 set { } //Length: 20
	}

	public bool UseZoomFactor
	{
		 get { } //Length: 5
		 set { } //Length: 4
	}

	public GizmoCap3DLookAndFeel() { }

	public float get_BoxDepth() { }

	public float get_BoxHeight() { }

	public float get_BoxWidth() { }

	public GizmoCap3DType get_CapType() { }

	public Color get_Color() { }

	public float get_ConeHeight() { }

	public float get_ConeRadius() { }

	public static float get_DefaultConeHeight() { }

	public static float get_DefaultConeRadius() { }

	public static float get_DefaultPyramidDepth() { }

	public static float get_DefaultPyramidHeight() { }

	public static float get_DefaultPyramidWidth() { }

	public GizmoFillMode3D get_FillMode() { }

	public Color get_HoveredColor() { }

	public bool get_IsSphereBorderVisible() { }

	public int get_NumSphereBorderPoints() { }

	public float get_PyramidDepth() { }

	public float get_PyramidHeight() { }

	public float get_PyramidWidth() { }

	public float get_Scale() { }

	public GizmoShadeMode get_ShadeMode() { }

	public Color get_SphereBorderColor() { }

	public float get_SphereRadius() { }

	public float get_TrPrismDepth() { }

	public float get_TrPrismHeight() { }

	public float get_TrPrismWidth() { }

	public bool get_UseZoomFactor() { }

	public void set_BoxDepth(float value) { }

	public void set_BoxHeight(float value) { }

	public void set_BoxWidth(float value) { }

	public void set_CapType(GizmoCap3DType value) { }

	public void set_Color(Color value) { }

	public void set_ConeHeight(float value) { }

	public void set_ConeRadius(float value) { }

	public void set_FillMode(GizmoFillMode3D value) { }

	public void set_HoveredColor(Color value) { }

	public void set_IsSphereBorderVisible(bool value) { }

	public void set_NumSphereBorderPoints(int value) { }

	public void set_PyramidDepth(float value) { }

	public void set_PyramidHeight(float value) { }

	public void set_PyramidWidth(float value) { }

	public void set_Scale(float value) { }

	public void set_ShadeMode(GizmoShadeMode value) { }

	public void set_SphereBorderColor(Color value) { }

	public void set_SphereRadius(float value) { }

	public void set_TrPrismDepth(float value) { }

	public void set_TrPrismHeight(float value) { }

	public void set_TrPrismWidth(float value) { }

	public void set_UseZoomFactor(bool value) { }

}

