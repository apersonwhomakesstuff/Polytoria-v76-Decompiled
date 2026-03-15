namespace RLD;

public class ObjectGrabSettings : Settings
{
	[SerializeField]
	private bool _alignAxis; //Field offset: 0x28
	[SerializeField]
	private TransformAxis _alignmentAxis; //Field offset: 0x2C
	[SerializeField]
	private float _rotationSensitivity; //Field offset: 0x30
	[SerializeField]
	private float _scaleSensitivity; //Field offset: 0x34
	[SerializeField]
	private float _offsetFromSurfaceSensitivity; //Field offset: 0x38
	[SerializeField]
	private float _offsetFromAnchorSensitivity; //Field offset: 0x3C
	[SerializeField]
	private ObjectGrabSurfaceFlags _surfaceFlags; //Field offset: 0x40
	[SerializeField]
	private float _defaultOffsetFromSurface; //Field offset: 0x44
	[SerializeField]
	private int _surfaceLayers; //Field offset: 0x48
	[SerializeField]
	private ObjectLayerGrabSettings[] _layerGrabSettings; //Field offset: 0x50
	[SerializeField]
	private int _sphericalMeshLayers; //Field offset: 0x58
	[SerializeField]
	private int _terrainMeshLayers; //Field offset: 0x5C

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

	public float OffsetFromAnchorSensitivity
	{
		 get { } //Length: 6
		 set { } //Length: 38
	}

	public float OffsetFromSurfaceSensitivity
	{
		 get { } //Length: 6
		 set { } //Length: 38
	}

	public float RotationSensitivity
	{
		 get { } //Length: 6
		 set { } //Length: 38
	}

	public float ScaleSensitivity
	{
		 get { } //Length: 6
		 set { } //Length: 38
	}

	public int SphericalMeshLayers
	{
		 get { } //Length: 4
		 set { } //Length: 4
	}

	public ObjectGrabSurfaceFlags SurfaceFlags
	{
		 get { } //Length: 4
		 set { } //Length: 4
	}

	public int SurfaceLayers
	{
		 get { } //Length: 4
		 set { } //Length: 4
	}

	public int TerrainMeshLayers
	{
		 get { } //Length: 4
		 set { } //Length: 4
	}

	public ObjectGrabSettings() { }

	public bool get_AlignAxis() { }

	public TransformAxis get_AlignmentAxis() { }

	public float get_DefaultOffsetFromSurface() { }

	public float get_OffsetFromAnchorSensitivity() { }

	public float get_OffsetFromSurfaceSensitivity() { }

	public float get_RotationSensitivity() { }

	public float get_ScaleSensitivity() { }

	public int get_SphericalMeshLayers() { }

	public ObjectGrabSurfaceFlags get_SurfaceFlags() { }

	public int get_SurfaceLayers() { }

	public int get_TerrainMeshLayers() { }

	public ObjectLayerGrabSettings GetLayerGrabSettings(int layer) { }

	public void set_AlignAxis(bool value) { }

	public void set_AlignmentAxis(TransformAxis value) { }

	public void set_DefaultOffsetFromSurface(float value) { }

	public void set_OffsetFromAnchorSensitivity(float value) { }

	public void set_OffsetFromSurfaceSensitivity(float value) { }

	public void set_RotationSensitivity(float value) { }

	public void set_ScaleSensitivity(float value) { }

	public void set_SphericalMeshLayers(int value) { }

	public void set_SurfaceFlags(ObjectGrabSurfaceFlags value) { }

	public void set_SurfaceLayers(int value) { }

	public void set_TerrainMeshLayers(int value) { }

}

