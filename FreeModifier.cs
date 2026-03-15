//Type is in global namespace

[ModifierID("Free")]
public class FreeModifier : ProceduralImageModifier
{
	[SerializeField]
	private Vector4 radius; //Field offset: 0x28

	public Vector4 Radius
	{
		 get { } //Length: 11
		 set { } //Length: 55
	}

	public FreeModifier() { }

	public virtual Vector4 CalculateRadius(Rect imageRect) { }

	public Vector4 get_Radius() { }

	protected void OnValidate() { }

	public void set_Radius(Vector4 value) { }

}

