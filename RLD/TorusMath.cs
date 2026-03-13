using System;
using System.Collections.Generic;
using UnityEngine;

namespace RLD
{
	// Token: 0x02000171 RID: 369
	public static class TorusMath
	{
		// Token: 0x0600114B RID: 4427 RVA: 0x00018D88 File Offset: 0x00016F88
		public static float CalcSphereRadius(float torusCoreRadius, float torusTubeRadius)
		{
			return 0f;
		}

		// Token: 0x0600114C RID: 4428 RVA: 0x000216BC File Offset: 0x0001F8BC
		public static AABB CalcCylModelAABB(float torusCoreRadius, float torusHrzRadius, float torusVertRadius)
		{
			return default(AABB);
		}

		// Token: 0x0600114D RID: 4429 RVA: 0x000216D4 File Offset: 0x0001F8D4
		public static AABB CalcCylAABB(Vector3 torusCenter, float torusCoreRadius, float torusHrzRadius, float torusVertRadius, Quaternion torusRotation)
		{
			return default(AABB);
		}

		// Token: 0x0600114E RID: 4430 RVA: 0x00018D8F File Offset: 0x00016F8F
		public static List<Vector3> Calc3DHrzExtentPoints(Vector3 torusCenter, float torusCoreRadius, float torusTubeRadius, Quaternion torusRotation)
		{
			return null;
		}

		// Token: 0x0600114F RID: 4431 RVA: 0x00018D92 File Offset: 0x00016F92
		public static bool Raycast(Ray ray, out float t, Vector3 torusCenter, float torusCoreRadius, float torusTubeRadius, Quaternion torusRotation, TorusEpsilon epsilon = default(TorusEpsilon))
		{
			t = 0f;
			return false;
		}

		// Token: 0x06001150 RID: 4432 RVA: 0x00018D9C File Offset: 0x00016F9C
		public static bool RaycastCylindrical(Ray ray, out float t, Vector3 torusCenter, float torusCoreRadius, float torusHrzRadius, float torusVertRadius, Quaternion torusRotation, TorusEpsilon epsilon = default(TorusEpsilon))
		{
			t = 0f;
			return false;
		}
	}
}
