using System;
using UnityEngine;

namespace Polytoria.Lua
{
	// Token: 0x02000263 RID: 611
	public class LuaBounds
	{
		// Token: 0x06001A44 RID: 6724 RVA: 0x00023CC8 File Offset: 0x00021EC8
		public static Bounds New()
		{
			return default(Bounds);
		}

		// Token: 0x06001A45 RID: 6725 RVA: 0x00023CE0 File Offset: 0x00021EE0
		public static Bounds New(Vector3 center, Vector3 size)
		{
			return default(Bounds);
		}

		// Token: 0x06001A46 RID: 6726 RVA: 0x00023CF8 File Offset: 0x00021EF8
		public static Vector3 ClosestPoint(Bounds bounds, Vector3 point)
		{
			return default(Vector3);
		}

		// Token: 0x06001A47 RID: 6727 RVA: 0x0001A52A File Offset: 0x0001872A
		public static bool Contains(Bounds bounds, Vector3 point)
		{
			return false;
		}

		// Token: 0x06001A48 RID: 6728 RVA: 0x0001A52D File Offset: 0x0001872D
		public static void Encapsulate(Bounds bounds, Vector3 point)
		{
		}

		// Token: 0x06001A49 RID: 6729 RVA: 0x0001A52F File Offset: 0x0001872F
		public static void Encapsulate(Bounds bounds, Bounds other)
		{
		}

		// Token: 0x06001A4A RID: 6730 RVA: 0x0001A531 File Offset: 0x00018731
		public static bool Intersects(Bounds bounds, Bounds other)
		{
			return false;
		}

		// Token: 0x06001A4B RID: 6731 RVA: 0x0001A534 File Offset: 0x00018734
		public static void SetMinMax(Bounds bounds, Vector3 min, Vector3 max)
		{
		}

		// Token: 0x06001A4C RID: 6732 RVA: 0x0001A536 File Offset: 0x00018736
		public static float SqrDistance(Bounds bounds, Vector3 point)
		{
			return 0f;
		}

		// Token: 0x06001A4D RID: 6733 RVA: 0x0001A53D File Offset: 0x0001873D
		public static Tuple<bool, float> IntersectRay(Bounds bounds, Vector3 origin, Vector3 direction)
		{
			return null;
		}
	}
}
