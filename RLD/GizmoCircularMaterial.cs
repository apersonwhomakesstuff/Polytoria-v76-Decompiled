namespace RLD;

public class GizmoCircularMaterial : Singleton<GizmoCircularMaterial>
{
	internal enum Type : int
	{
		Circle = 0,
		Torus = 1,
		CylindricalTorus = 2,
	}

	private Type _circularType; //Field offset: 0x10
	private Material _circleMaterial; //Field offset: 0x18
	private Material _torusMaterial; //Field offset: 0x20
	private Material _cylindricalTorusMaterial; //Field offset: 0x28

	public Material CircleMaterial
	{
		 get { } //Length: 191
	}

	public Type CircularType
	{
		 get { } //Length: 4
		 set { } //Length: 4
	}

	public Material CylindricalTorusMaterial
	{
		 get { } //Length: 191
	}

	public bool IsLit
	{
		 get { } //Length: 87
	}

	public float LightIntensity
	{
		 get { } //Length: 80
	}

	public Material Material
	{
		 get { } //Length: 565
	}

	public Material TorusMaterial
	{
		 get { } //Length: 191
	}

	public GizmoCircularMaterial() { }

	public Material get_CircleMaterial() { }

	public Type get_CircularType() { }

	public Material get_CylindricalTorusMaterial() { }

	public bool get_IsLit() { }

	public float get_LightIntensity() { }

	public Material get_Material() { }

	public Material get_TorusMaterial() { }

	public void ResetValuesToSensibleDefaults() { }

	public void set_CircularType(Type value) { }

	public void SetCamera(Camera camera) { }

	public void SetColor(Color color) { }

	public void SetCullAlphaScale(float scale) { }

	public void SetCullModeBack() { }

	public void SetCullModeFront() { }

	public void SetCullModeOff() { }

	public void SetCylindricalTorusRadii(float hrzRadius, float vertRadius) { }

	public void SetLightDirection(Vector3 lightDir) { }

	public void SetLightIntensity(float intensity) { }

	public void SetLit(bool isLit) { }

	public void SetPass(int passIndex) { }

	public void SetShapeCenter(Vector3 center) { }

	public void SetTorusCoreRadius(float radius) { }

	public void SetTorusTubeRadius(float radius) { }

	public void SetZTestAlways() { }

	public void SetZTestEnabled(bool isEnabled) { }

	public void SetZTestLess() { }

	public void SetZWriteEnabled(bool isEnabled) { }

}

