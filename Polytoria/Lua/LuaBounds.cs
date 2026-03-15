namespace Polytoria.Lua;

public class LuaBounds
{

	public LuaBounds() { }

	public static Vector3 ClosestPoint(Bounds bounds, Vector3 point) { }

	public static bool Contains(Bounds bounds, Vector3 point) { }

	public static void Encapsulate(Bounds bounds, Vector3 point) { }

	public static void Encapsulate(Bounds bounds, Bounds other) { }

	public static Tuple<Boolean, Single> IntersectRay(Bounds bounds, Vector3 origin, Vector3 direction) { }

	public static bool Intersects(Bounds bounds, Bounds other) { }

	public static Bounds New() { }

	public static Bounds New(Vector3 center, Vector3 size) { }

	public static void SetMinMax(Bounds bounds, Vector3 min, Vector3 max) { }

	public static float SqrDistance(Bounds bounds, Vector3 point) { }

}

