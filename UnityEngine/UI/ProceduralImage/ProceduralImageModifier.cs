namespace UnityEngine.UI.ProceduralImage;

[DisallowMultipleComponent]
public abstract class ProceduralImageModifier : MonoBehaviour
{
	protected Graphic graphic; //Field offset: 0x20

	protected Graphic _Graphic
	{
		 get { } //Length: 141
	}

	protected ProceduralImageModifier() { }

	public abstract Vector4 CalculateRadius(Rect imageRect) { }

	protected Graphic get__Graphic() { }

}

