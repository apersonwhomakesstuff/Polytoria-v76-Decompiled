using System;
using UnityEngine;

namespace RLD
{
	// Token: 0x0200016D RID: 365
	public static class SegmentMath
	{
		// Token: 0x06001142 RID: 4418 RVA: 0x00018D54 File Offset: 0x00016F54
		public static bool Raycast(Ray ray, out float t, Vector3 startPoint, Vector3 endPoint, SegmentEpsilon epsilon = default(SegmentEpsilon))
		{
			t = 0f;
			return false;
		}

		// Token: 0x06001143 RID: 4419 RVA: 0x00018D5E File Offset: 0x00016F5E
		public static bool Is3DPointOnSegment(Vector3 point, Vector3 startPoint, Vector3 endPoint, SegmentEpsilon epsilon = default(SegmentEpsilon))
		{
			return false;
		}

		// Token: 0x06001144 RID: 4420 RVA: 0x00018D61 File Offset: 0x00016F61
		public static bool Is2DPointOnSegment(Vector2 point, Vector2 startPoint, Vector2 endPoint, SegmentEpsilon epsilon = default(SegmentEpsilon))
		{
			return false;
		}

		// Token: 0x06001145 RID: 4421 RVA: 0x000216A4 File Offset: 0x0001F8A4
		public static Vector3 ProjectPtOnSegment(Vector3 point, Vector3 startPoint, Vector3 endPoint)
		{
			return default(Vector3);
		}
	}
}
