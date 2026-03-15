namespace Polytoria.Types;

public struct NumberRange
{
	public float min; //Field offset: 0x0
	public float max; //Field offset: 0x4

	public NumberRange(float min, float max) { }

	public float Lerp(float t) { }

	public static NumberRange New(float min, float max) { }

}

