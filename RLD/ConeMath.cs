using System;
using System.Collections.Generic;
using UnityEngine;

namespace RLD
{
	// Token: 0x02000153 RID: 339
	public static class ConeMath
	{
		// Token: 0x060010D0 RID: 4304 RVA: 0x00018B49 File Offset: 0x00016D49
		public static List<Vector3> CalcConeBaseExtentPoints(Vector3 coneBaseCenter, float coneBaseRadius, Quaternion coneRotation)
		{
			return null;
		}

		// Token: 0x060010D1 RID: 4305 RVA: 0x00018B4C File Offset: 0x00016D4C
		public static bool Raycast(Ray ray, out float t, Vector3 coneBaseCenter, float coneBaseRadius, float coneHeight, Quaternion coneRotation, ConeEpsilon epsilon = default(ConeEpsilon))
		{
			t = 0f;
			return false;
		}

		// Token: 0x060010D2 RID: 4306 RVA: 0x00018B56 File Offset: 0x00016D56
		public static bool ContainsPoint(Vector3 point, Vector3 coneBaseCenter, float coneBaseRadius, float coneHeight, Quaternion coneRotation, ConeEpsilon epsilon = default(ConeEpsilon))
		{
			return false;
		}
	}
}
