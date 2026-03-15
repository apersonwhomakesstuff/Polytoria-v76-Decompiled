namespace Polytoria.Lua;

public class LuaVector3
{

	public LuaVector3() { }

	public static float Angle(Vector3 from, Vector3 to) { }

	public static Vector3 ClampMagnitude(Vector3 vector, float maxLength) { }

	public static Vector3 Cross(Vector3 lhs, Vector3 rhs) { }

	public static float Distance(Vector3 a, Vector3 b) { }

	public static float Dot(Vector3 lhs, Vector3 rhs) { }

	public static Vector3 Lerp(Vector3 a, Vector3 b, float t) { }

	public static Vector3 Max(Vector3 lhs, Vector3 rhs) { }

	public static Vector3 Min(Vector3 lhs, Vector3 rhs) { }

	public static Vector3 MoveTowards(Vector3 current, Vector3 target, float maxDistanceDelta) { }

	public static Vector3 New(float x, float y, float z) { }

	public static Vector3 New(float x, float y) { }

	public static Vector3 New(float d) { }

	public static Vector3 New(Vector2 v) { }

	public static Vector3 New() { }

	public static Vector3 Normalize(Vector3 value) { }

	public static Vector3 Project(Vector3 vector, Vector3 onNormal) { }

	public static Vector3 ProjectOnPlane(Vector3 vector, Vector3 planeNormal) { }

	public static Vector3 Reflect(Vector3 inDirection, Vector3 inNormal) { }

	public static Vector3 RotateTowards(Vector3 current, Vector3 target, float maxRadiansDelta, float maxMagnitudeDelta) { }

	public static Vector3 Scale(Vector3 a, Vector3 b) { }

	public static float SignedAngle(Vector3 from, Vector3 to, Vector3 axis) { }

	public static Vector3 Slerp(Vector3 a, Vector3 b, float t) { }

	public static Vector3 SlerpUnclamped(Vector3 a, Vector3 b, float t) { }

	public static Vector3 SmoothDamp(Vector3 current, Vector3 target, ref Vector3 currentVelocity, float smoothTime, float maxSpeed, float deltaTime) { }

}

