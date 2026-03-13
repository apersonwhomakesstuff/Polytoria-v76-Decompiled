using System;
using System.Collections.Generic;
using UnityEngine;

namespace RLD
{
	// Token: 0x02000155 RID: 341
	public static class CylinderMath
	{
		// Token: 0x060010D3 RID: 4307 RVA: 0x00018B59 File Offset: 0x00016D59
		public static List<Vector3> CalcExtentPoints(Vector3 center, float cylinderRadius, Quaternion cylinderRotation)
		{
			return null;
		}

		// Token: 0x060010D4 RID: 4308 RVA: 0x00018B5C File Offset: 0x00016D5C
		public static bool Raycast(Ray ray, out float t, Vector3 cylinderAxisPt0, Vector3 cylinderAxisPt1, float cylinderRadius, CylinderEpsilon epsilon = default(CylinderEpsilon))
		{
			t = 0f;
			return false;
		}

		// Token: 0x060010D5 RID: 4309 RVA: 0x00018B66 File Offset: 0x00016D66
		public static bool Raycast(Ray ray, out float t, Vector3 cylinderAxisPt0, Vector3 cylinderAxisPt1, float cylinderRadius, float cylinderHeight, CylinderEpsilon epsilon = default(CylinderEpsilon))
		{
			t = 0f;
			return false;
		}

		// Token: 0x060010D6 RID: 4310 RVA: 0x00018B70 File Offset: 0x00016D70
		public static bool RaycastNoCaps(Ray ray, out float t, Vector3 cylinderAxisPt0, Vector3 cylinderAxisPt1, float cylinderRadius, CylinderEpsilon epsilon = default(CylinderEpsilon))
		{
			t = 0f;
			return false;
		}

		// Token: 0x060010D7 RID: 4311 RVA: 0x00018B7A File Offset: 0x00016D7A
		public static bool RaycastNoCaps(Ray ray, out float t, Vector3 cylinderAxisPt0, Vector3 cylinderAxisPt1, float cylinderRadius, float cylinderHeight, CylinderEpsilon epsilon = default(CylinderEpsilon))
		{
			t = 0f;
			return false;
		}

		// Token: 0x060010D8 RID: 4312 RVA: 0x00018B84 File Offset: 0x00016D84
		public static bool ContainsPoint(Vector3 point, Vector3 cylinderAxisPt0, Vector3 cylinderAxisPt1, float cylinderRadius, CylinderEpsilon epsilon = default(CylinderEpsilon))
		{
			return false;
		}

		// Token: 0x060010D9 RID: 4313 RVA: 0x00018B87 File Offset: 0x00016D87
		public static bool ContainsPoint(Vector3 point, Vector3 cylinderAxisPt0, Vector3 cylinderAxisPt1, float cylinderRadius, float cylinderHeight, CylinderEpsilon epsilon = default(CylinderEpsilon))
		{
			return false;
		}
	}
}
