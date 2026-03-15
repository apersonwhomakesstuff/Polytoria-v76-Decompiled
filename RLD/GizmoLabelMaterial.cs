namespace RLD;

public class GizmoLabelMaterial : Singleton<GizmoLabelMaterial>
{
	private Material _material; //Field offset: 0x10

	public Material Material
	{
		 get { } //Length: 191
	}

	public GizmoLabelMaterial() { }

	public Material get_Material() { }

	public void ResetValuesToSensibleDefaults() { }

	public void SetColor(Color color) { }

	public void SetPass(int passIndex) { }

	public void SetTexture(Texture2D texture) { }

	public void SetZTestAlways() { }

	public void SetZTestLess() { }

	public void SetZTestLessEqual() { }

	public void SetZWriteEnabled(bool isEnabled) { }

}

