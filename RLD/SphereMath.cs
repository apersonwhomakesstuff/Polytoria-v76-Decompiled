using System;
using System.Collections.Generic;
using UnityEngine;

namespace RLD
{
	// Token: 0x0200016F RID: 367
	public static class SphereMath
	{
		// Token: 0x06001146 RID: 4422 RVA: 0x00018D64 File Offset: 0x00016F64
		public static List<Vector3> CalcRightUpExtents(Vector3 sphereCenter, float sphereRadius, Vector3 right, Vector3 up)
		{
			return null;
		}

		// Token: 0x06001147 RID: 4423 RVA: 0x00018D67 File Offset: 0x00016F67
		public static bool Raycast(Ray ray, Vector3 sphereCenter, float sphereRadius, SphereEpsilon epsilon = default(SphereEpsilon))
		{
			return false;
		}

		// Token: 0x06001148 RID: 4424 RVA: 0x00018D6A File Offset: 0x00016F6A
		public static bool Raycast(Ray ray, out float t, Vector3 sphereCenter, float sphereRadius, SphereEpsilon epsilon = default(SphereEpsilon))
		{
			t = 0f;
			return false;
		}

		// Token: 0x06001149 RID: 4425 RVA: 0x00018D74 File Offset: 0x00016F74
		public static bool Raycast(Ray ray, out float t0, out float t1, Vector3 sphereCenter, float sphereRadius, SphereEpsilon epsilon = default(SphereEpsilon))
		{
			t0 = 0f;
			t1 = 0f;
			return false;
		}

		// Token: 0x0600114A RID: 4426 RVA: 0x00018D85 File Offset: 0x00016F85
		public static bool ContainsPoint(Vector3 point, Vector3 sphereCenter, float sphereRadius, SphereEpsilon epsilon = default(SphereEpsilon))
		{
			return false;
		}
	}
}
