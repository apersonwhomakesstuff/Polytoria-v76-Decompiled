using System;
using System.Collections.Generic;
using UnityEngine;

namespace RLD
{
	// Token: 0x02000157 RID: 343
	public static class PolygonMath
	{
		// Token: 0x060010DB RID: 4315 RVA: 0x00018B95 File Offset: 0x00016D95
		public static bool Raycast(Ray ray, out float t, List<Vector3> cwPolyPoints, bool isClosed, Vector3 polyNormal, PolygonEpsilon epsilon = default(PolygonEpsilon))
		{
			t = 0f;
			return false;
		}

		// Token: 0x060010DC RID: 4316 RVA: 0x00018B9F File Offset: 0x00016D9F
		public static bool Contains3DPoint(Vector3 point, bool checkOnPlane, List<Vector3> cwPolyPoints, bool isClosed, Vector3 polyNormal, PolygonEpsilon epsilon = default(PolygonEpsilon))
		{
			return false;
		}

		// Token: 0x060010DD RID: 4317 RVA: 0x00018BA2 File Offset: 0x00016DA2
		public static bool Contains2DPoint(Vector2 point, List<Vector2> polyPoints, bool isClosed, PolygonEpsilon epsilon = default(PolygonEpsilon))
		{
			return false;
		}

		// Token: 0x060010DE RID: 4318 RVA: 0x00018BA5 File Offset: 0x00016DA5
		public static bool Is3DPointOnBorder(Vector3 point, bool checkOnPlane, List<Vector3> cwPolyPoints, bool isClosed, Vector3 polyNormal, PolygonEpsilon epsilon = default(PolygonEpsilon))
		{
			return false;
		}

		// Token: 0x060010DF RID: 4319 RVA: 0x00018BA8 File Offset: 0x00016DA8
		public static bool Is2DPointOnBorder(Vector2 point, List<Vector2> polyPoints, bool isClosed, PolygonEpsilon epsilon = default(PolygonEpsilon))
		{
			return false;
		}

		// Token: 0x060010E0 RID: 4320 RVA: 0x00018BAB File Offset: 0x00016DAB
		public static bool Is2DPointOnThickBorder(Vector2 point, List<Vector2> polyPoints, List<Vector2> thickBorderPoints, bool isClosed, PolygonEpsilon epsilon = default(PolygonEpsilon))
		{
			return false;
		}
	}
}
