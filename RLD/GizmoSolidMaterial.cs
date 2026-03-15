namespace RLD;

public class GizmoSolidMaterial : Singleton<GizmoSolidMaterial>
{
	private Material _material; //Field offset: 0x10

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
		 get { } //Length: 191
	}

	public GizmoSolidMaterial() { }

	public bool get_IsLit() { }

	public float get_LightIntensity() { }

	public Material get_Material() { }

	public void ResetValuesToSensibleDefaults() { }

	public void SetColor(Color color) { }

	public void SetCullModeBack() { }

	public void SetCullModeFront() { }

	public void SetCullModeOff() { }

	public void SetLightDirection(Vector3 lightDir) { }

	public void SetLightIntensity(float intensity) { }

	public void SetLit(bool isLit) { }

	public void SetPass(int passIndex) { }

	public void SetZTestAlways() { }

	public void SetZTestEnabled(bool isEnabled) { }

	public void SetZTestLess() { }

	public void SetZWriteEnabled(bool isEnabled) { }

}

