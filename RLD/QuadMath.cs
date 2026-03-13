using System;
using System.Collections.Generic;
using UnityEngine;

namespace RLD
{
	// Token: 0x0200016C RID: 364
	public static class QuadMath
	{
		// Token: 0x06001135 RID: 4405 RVA: 0x00018D18 File Offset: 0x00016F18
		public static void Calc2DQuadRightUp(float degreeRotation, out Vector2 right, out Vector2 up)
		{
			right = default(Vector2);
			up = default(Vector2);
		}

		// Token: 0x06001136 RID: 4406 RVA: 0x00018D28 File Offset: 0x00016F28
		public static List<Vector2> Calc2DQuadCornerPoints(Vector2 quadCenter, Vector2 quadSize, float degreeRotation)
		{
			return null;
		}

		// Token: 0x06001137 RID: 4407 RVA: 0x00018D2B File Offset: 0x00016F2B
		public static List<Vector2> Calc2DQuadCornerPoints(Vector2 quadCenter, Vector2 quadSize, Vector2 right, Vector2 up)
		{
			return null;
		}

		// Token: 0x06001138 RID: 4408 RVA: 0x00018D2E File Offset: 0x00016F2E
		public static List<Vector3> Calc3DQuadCornerPoints(Vector3 quadCenter, Vector2 quadSize, Quaternion quadRotation)
		{
			return null;
		}

		// Token: 0x06001139 RID: 4409 RVA: 0x00021674 File Offset: 0x0001F874
		public static Vector3 Calc3DQuadCorner(Vector3 quadCenter, Vector2 quadSize, Quaternion quadRotation, QuadCorner quadCorner)
		{
			return default(Vector3);
		}

		// Token: 0x0600113A RID: 4410 RVA: 0x0002168C File Offset: 0x0001F88C
		public static OBB Calc3DQuadOBB(Vector3 quadCenter, Vector2 quadSize, Quaternion quadRotation, QuadEpsilon epsilon = default(QuadEpsilon))
		{
			return default(OBB);
		}

		// Token: 0x0600113B RID: 4411 RVA: 0x00018D31 File Offset: 0x00016F31
		public static bool Raycast(Ray ray, out float t, Vector3 quadCenter, float quadWidth, float quadHeight, Vector3 quadRight, Vector3 quadUp, QuadEpsilon epsilon = default(QuadEpsilon))
		{
			t = 0f;
			return false;
		}

		// Token: 0x0600113C RID: 4412 RVA: 0x00018D3B File Offset: 0x00016F3B
		public static bool RaycastWire(Ray ray, out float t, Vector3 quadCenter, float quadWidth, float quadHeight, Vector3 quadRight, Vector3 quadUp, QuadEpsilon epsilon = default(QuadEpsilon))
		{
			t = 0f;
			return false;
		}

		// Token: 0x0600113D RID: 4413 RVA: 0x00018D45 File Offset: 0x00016F45
		public static bool Contains3DPoint(Vector3 point, bool checkOnPlane, Vector3 quadCenter, float quadWidth, float quadHeight, Vector3 quadRight, Vector3 quadUp, QuadEpsilon epsilon = default(QuadEpsilon))
		{
			return false;
		}

		// Token: 0x0600113E RID: 4414 RVA: 0x00018D48 File Offset: 0x00016F48
		public static bool Contains2DPoint(Vector2 point, Vector2 quadCenter, float quadWidth, float quadHeight, float degreeRotation, QuadEpsilon epsilon = default(QuadEpsilon))
		{
			return false;
		}

		// Token: 0x0600113F RID: 4415 RVA: 0x00018D4B File Offset: 0x00016F4B
		public static bool Contains2DPoint(Vector2 point, Vector2 quadCenter, float quadWidth, float quadHeight, Vector2 quadRight, Vector2 quadUp, QuadEpsilon epsilon = default(QuadEpsilon))
		{
			return false;
		}

		// Token: 0x06001140 RID: 4416 RVA: 0x00018D4E File Offset: 0x00016F4E
		public static bool Is2DPointOnBorder(Vector2 point, Vector2 quadCenter, float quadWidth, float quadHeight, float degreeRotation, QuadEpsilon epsilon = default(QuadEpsilon))
		{
			return false;
		}

		// Token: 0x06001141 RID: 4417 RVA: 0x00018D51 File Offset: 0x00016F51
		public static bool Is2DPointOnBorder(Vector2 point, Vector2 quadCenter, float quadWidth, float quadHeight, Vector2 quadRight, Vector2 quadUp, QuadEpsilon epsilon = default(QuadEpsilon))
		{
			return false;
		}
	}
}
