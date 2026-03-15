namespace RLD;

public static class PyramidMath
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Comparison<Single> <>9__1_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal int <Raycast>b__1_0(float t0, float t1) { }

	}


	public static List<Vector3> CalcBaseCornerPoints(Vector3 baseCenter, float baseWidth, float baseDepth, Quaternion rotation) { }

	public static bool ContainsPoint(Vector3 point, Vector3 baseCenter, float baseWidth, float baseDepth, float height, Quaternion rotation, PyramidEpsilon epsilon = null) { }

	public static bool Raycast(Ray ray, out float t, Vector3 baseCenter, float baseWidth, float baseDepth, float height, Quaternion rotation) { }

}

