namespace Polytoria.Lua;

public class LuaQuaternion
{

	public static Quaternion Identity
	{
		 get { } //Length: 663
	}

	public LuaQuaternion() { }

	public static float Angle(Quaternion a, Quaternion b) { }

	public static Quaternion AngleAxis(float angle, Vector3 axis) { }

	public float Dot(Quaternion a, Quaternion b) { }

	public static Quaternion Euler(float x, float y, float z) { }

	public static Quaternion Euler(Vector3 euler) { }

	public static Quaternion FromToRotation(Vector3 fromDirection, Vector3 toDirection) { }

	public static Quaternion get_Identity() { }

	public static Quaternion Inverse(Quaternion rotation) { }

	public static Quaternion Lerp(Quaternion a, Quaternion b, float t) { }

	public static Quaternion LerpUnclamped(Quaternion a, Quaternion b, float t) { }

	public static Quaternion LookRotation(Vector3 forward) { }

	public static Quaternion LookRotation(Vector3 forward, Vector3 upwards) { }

	public static Quaternion New(float d) { }

	public static Quaternion New(float x, float y, float z, float w) { }

	public static Quaternion New() { }

	public static Quaternion Normalize(Quaternion q) { }

	public static Quaternion RotateTowards(Quaternion from, Quaternion to, float maxDegreesDelta) { }

	public static Quaternion Slerp(Quaternion a, Quaternion b, float t) { }

	public static Quaternion SlerpUnclamped(Quaternion a, Quaternion b, float t) { }

}

