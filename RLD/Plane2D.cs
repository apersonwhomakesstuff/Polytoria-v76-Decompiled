using System;
using UnityEngine;

namespace RLD
{
	// Token: 0x02000144 RID: 324
	public class Plane2D
	{
		// Token: 0x1700056E RID: 1390
		// (get) Token: 0x0600108C RID: 4236 RVA: 0x000213E8 File Offset: 0x0001F5E8
		// (set) Token: 0x0600108D RID: 4237 RVA: 0x00018A66 File Offset: 0x00016C66
		public Vector2 Normal
		{
			get
			{
				return default(Vector2);
			}
			set
			{
			}
		}

		// Token: 0x1700056F RID: 1391
		// (get) Token: 0x0600108E RID: 4238 RVA: 0x00018A68 File Offset: 0x00016C68
		// (set) Token: 0x0600108F RID: 4239 RVA: 0x00018A6F File Offset: 0x00016C6F
		public float Distance
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x06001090 RID: 4240 RVA: 0x00018A71 File Offset: 0x00016C71
		public Plane2D(Vector2 normal, float distance)
		{
		}

		// Token: 0x06001091 RID: 4241 RVA: 0x00018A79 File Offset: 0x00016C79
		public Plane2D(Vector2 normal, Vector2 pointOnPlane)
		{
		}

		// Token: 0x06001092 RID: 4242 RVA: 0x00018A81 File Offset: 0x00016C81
		public float GetDistanceToPoint(Vector2 point)
		{
			return 0f;
		}

		// Token: 0x06001093 RID: 4243 RVA: 0x00018A88 File Offset: 0x00016C88
		public bool Raycast(Vector2 rayOrigin, Vector2 rayDir, out float t)
		{
			t = 0f;
			return false;
		}

		// Token: 0x040005A2 RID: 1442
		private Vector2 _normal;

		// Token: 0x040005A3 RID: 1443
		private float _distance;
	}
}
