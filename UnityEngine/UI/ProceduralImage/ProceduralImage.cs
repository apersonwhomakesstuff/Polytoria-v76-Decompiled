namespace UnityEngine.UI.ProceduralImage;

[AddComponentMenu("UI/Procedural Image")]
[ExecuteInEditMode]
public class ProceduralImage : Image
{
	private static Material materialInstance; //Field offset: 0x0
	[SerializeField]
	private float borderWidth; //Field offset: 0x120
	private ProceduralImageModifier modifier; //Field offset: 0x128
	[SerializeField]
	private float falloffDistance; //Field offset: 0x130

	public float BorderWidth
	{
		 get { } //Length: 9
		 set { } //Length: 28
	}

	private static Material DefaultProceduralImageMaterial
	{
		private get { } //Length: 243
		private set { } //Length: 81
	}

	public float FalloffDistance
	{
		 get { } //Length: 9
		 set { } //Length: 28
	}

	public virtual Material material
	{
		 get { } //Length: 335
		 set { } //Length: 8
	}

	protected ProceduralImageModifier Modifier
	{
		 get { } //Length: 266
		 set { } //Length: 19
	}

	public Type ModifierType
	{
		 get { } //Length: 35
		 set { } //Length: 447
	}

	public ProceduralImage() { }

	private ProceduralImageInfo CalculateInfo() { }

	private void EncodeAllInfoIntoVertices(VertexHelper vh, ProceduralImageInfo info) { }

	private float EncodeFloats_0_1_16_16(float a, float b) { }

	private Vector4 FixRadius(Vector4 vec) { }

	protected void FixTexCoordsInCanvas(Canvas c) { }

	protected void FixTexCoordsInCanvas() { }

	public float get_BorderWidth() { }

	private static Material get_DefaultProceduralImageMaterial() { }

	public float get_FalloffDistance() { }

	public virtual Material get_material() { }

	protected ProceduralImageModifier get_Modifier() { }

	public Type get_ModifierType() { }

	private void Init() { }

	protected virtual void OnDisable() { }

	protected virtual void OnEnable() { }

	protected virtual void OnPopulateMesh(VertexHelper toFill) { }

	protected virtual void OnTransformParentChanged() { }

	protected void OnVerticesDirty() { }

	public void set_BorderWidth(float value) { }

	private static void set_DefaultProceduralImageMaterial(Material value) { }

	public void set_FalloffDistance(float value) { }

	public virtual void set_material(Material value) { }

	protected void set_Modifier(ProceduralImageModifier value) { }

	public void set_ModifierType(Type value) { }

}

