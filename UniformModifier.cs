//Type is in global namespace

[ModifierID("Uniform")]
public class UniformModifier : ProceduralImageModifier
{
	[SerializeField]
	private float radius; //Field offset: 0x28

	public float Radius
	{
		 get { } //Length: 6
		 set { } //Length: 53
	}

	public UniformModifier() { }

	public virtual Vector4 CalculateRadius(Rect imageRect) { }

	public float get_Radius() { }

	public void set_Radius(float value) { }

}

