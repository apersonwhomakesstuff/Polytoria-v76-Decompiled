namespace RLD;

public class GizmoLineMaterial : Singleton<GizmoLineMaterial>
{
	private Material _material; //Field offset: 0x10

	public Material Material
	{
		 get { } //Length: 191
	}

	public GizmoLineMaterial() { }

	public Material get_Material() { }

	public void ResetValuesToSensibleDefaults() { }

	public void SetColor(Color color) { }

	public void SetPass(int passIndex) { }

	public void SetZTestAlways() { }

	public void SetZTestLess() { }

	public void SetZTestLessEqual() { }

	public void SetZWriteEnabled(bool isEnabled) { }

}

