using System;
using System.Collections.Generic;
using UnityEngine;

namespace RLD
{
	// Token: 0x02000168 RID: 360
	public static class PrismMath
	{
		// Token: 0x0600112F RID: 4399 RVA: 0x00018CF8 File Offset: 0x00016EF8
		public static List<Vector3> CalcTriangPrismCornerPoints(Vector3 baseCenter, float baseWidth, float baseDepth, float topWidth, float topDepth, float height, Quaternion prismRotation)
		{
			return null;
		}

		// Token: 0x06001130 RID: 4400 RVA: 0x00018CFB File Offset: 0x00016EFB
		public static bool RaycastTriangular(Ray ray, out float t, Vector3 baseCenter, float baseWidth, float baseDepth, float topWidth, float topDepth, float height, Quaternion prismRotation)
		{
			t = 0f;
			return false;
		}

		// Token: 0x06001131 RID: 4401 RVA: 0x00018D05 File Offset: 0x00016F05
		public static bool ContainsPoint(Vector3 point, Vector3 baseCenter, float baseWidth, float baseDepth, float topWidth, float topDepth, float height, Quaternion prismRotation, PrismEpsilon epsilon = default(PrismEpsilon))
		{
			return false;
		}

		// Token: 0x0200038E RID: 910
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06002AB3 RID: 10931 RVA: 0x0001D307 File Offset: 0x0001B507
			internal int <RaycastTriangular>b__1_0(float t0, float t1)
			{
				return 0;
			}

			// Token: 0x04000F69 RID: 3945
			public static readonly PrismMath.<>c <>9;

			// Token: 0x04000F6A RID: 3946
			public static Comparison<float> <>9__1_0;
		}
	}
}
