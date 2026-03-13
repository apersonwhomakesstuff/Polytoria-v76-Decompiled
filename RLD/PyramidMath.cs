using System;
using System.Collections.Generic;
using UnityEngine;

namespace RLD
{
	// Token: 0x0200016A RID: 362
	public static class PyramidMath
	{
		// Token: 0x06001132 RID: 4402 RVA: 0x00018D08 File Offset: 0x00016F08
		public static List<Vector3> CalcBaseCornerPoints(Vector3 baseCenter, float baseWidth, float baseDepth, Quaternion rotation)
		{
			return null;
		}

		// Token: 0x06001133 RID: 4403 RVA: 0x00018D0B File Offset: 0x00016F0B
		public static bool Raycast(Ray ray, out float t, Vector3 baseCenter, float baseWidth, float baseDepth, float height, Quaternion rotation)
		{
			t = 0f;
			return false;
		}

		// Token: 0x06001134 RID: 4404 RVA: 0x00018D15 File Offset: 0x00016F15
		public static bool ContainsPoint(Vector3 point, Vector3 baseCenter, float baseWidth, float baseDepth, float height, Quaternion rotation, PyramidEpsilon epsilon = default(PyramidEpsilon))
		{
			return false;
		}

		// Token: 0x0200038F RID: 911
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06002AB6 RID: 10934 RVA: 0x0001D314 File Offset: 0x0001B514
			internal int <Raycast>b__1_0(float t0, float t1)
			{
				return 0;
			}

			// Token: 0x04000F6B RID: 3947
			public static readonly PyramidMath.<>c <>9;

			// Token: 0x04000F6C RID: 3948
			public static Comparison<float> <>9__1_0;
		}
	}
}
