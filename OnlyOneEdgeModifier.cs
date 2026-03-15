//Type is in global namespace

[ModifierID("Only One Edge")]
public class OnlyOneEdgeModifier : ProceduralImageModifier
{
	internal enum ProceduralImageEdge : int
	{
		Top = 0,
		Bottom = 1,
		Left = 2,
		Right = 3,
	}

	[SerializeField]
	private float radius; //Field offset: 0x28
	[SerializeField]
	private ProceduralImageEdge side; //Field offset: 0x2C

	public float Radius
	{
		 get { } //Length: 6
		 set { } //Length: 53
	}

	public ProceduralImageEdge Side
	{
		 get { } //Length: 4
		 set { } //Length: 4
	}

	public OnlyOneEdgeModifier() { }

	public virtual Vector4 CalculateRadius(Rect imageRect) { }

	public float get_Radius() { }

	public ProceduralImageEdge get_Side() { }

	public void set_Radius(float value) { }

	public void set_Side(ProceduralImageEdge value) { }

}

