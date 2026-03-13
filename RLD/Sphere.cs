using System;
using System.Collections.Generic;
using UnityEngine;

namespace RLD
{
	// Token: 0x02000179 RID: 377
	public struct Sphere
	{
		// Token: 0x1700059F RID: 1439
		// (get) Token: 0x06001169 RID: 4457 RVA: 0x00021734 File Offset: 0x0001F934
		// (set) Token: 0x0600116A RID: 4458 RVA: 0x00018E1B File Offset: 0x0001701B
		public Vector3 Center
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		// Token: 0x170005A0 RID: 1440
		// (get) Token: 0x0600116B RID: 4459 RVA: 0x00018E1D File Offset: 0x0001701D
		// (set) Token: 0x0600116C RID: 4460 RVA: 0x00018E24 File Offset: 0x00017024
		public float Radius
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x0600116D RID: 4461 RVA: 0x0002174C File Offset: 0x0001F94C
		public Sphere(Vector3 center, float radius)
		{
			this._center = default(Vector3);
			this._radius = 0f;
		}

		// Token: 0x0600116E RID: 4462 RVA: 0x00021774 File Offset: 0x0001F974
		public Sphere(AABB aabb)
		{
			this._center = default(Vector3);
			this._radius = 0f;
		}

		// Token: 0x0600116F RID: 4463 RVA: 0x0002179C File Offset: 0x0001F99C
		public Sphere(IEnumerable<Vector3> pointCloud)
		{
			this._center = default(Vector3);
			this._radius = 0f;
		}

		// Token: 0x06001170 RID: 4464 RVA: 0x00018E26 File Offset: 0x00017026
		public bool ContainsPoint(Vector3 point)
		{
			return false;
		}

		// Token: 0x06001171 RID: 4465 RVA: 0x00018E29 File Offset: 0x00017029
		public List<Vector3> GetRightUpExtents(Vector3 right, Vector3 up)
		{
			return null;
		}

		// Token: 0x06001172 RID: 4466 RVA: 0x00018E2C File Offset: 0x0001702C
		public void Encapsulate(Sphere sphere)
		{
		}

		// Token: 0x0400062B RID: 1579
		private Vector3 _center;

		// Token: 0x0400062C RID: 1580
		private float _radius;
	}
}
