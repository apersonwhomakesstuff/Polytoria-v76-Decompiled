using System;
using UnityEngine;

namespace RLD
{
	// Token: 0x02000185 RID: 389
	public class MeshTransform
	{
		// Token: 0x170005A2 RID: 1442
		// (get) Token: 0x0600118C RID: 4492 RVA: 0x000217DC File Offset: 0x0001F9DC
		public Vector3 Position
		{
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x170005A3 RID: 1443
		// (get) Token: 0x0600118D RID: 4493 RVA: 0x000217F4 File Offset: 0x0001F9F4
		public Quaternion Rotation
		{
			get
			{
				return default(Quaternion);
			}
		}

		// Token: 0x170005A4 RID: 1444
		// (get) Token: 0x0600118E RID: 4494 RVA: 0x0002180C File Offset: 0x0001FA0C
		public Vector3 Scale
		{
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x0600118F RID: 4495 RVA: 0x00018E7F File Offset: 0x0001707F
		public MeshTransform(Vector3 position, Quaternion rotation, Vector3 scale)
		{
		}

		// Token: 0x06001190 RID: 4496 RVA: 0x00018E87 File Offset: 0x00017087
		public MeshTransform(Transform transform)
		{
		}

		// Token: 0x06001191 RID: 4497 RVA: 0x00021824 File Offset: 0x0001FA24
		public OBB InverseTransformOBB(OBB obb)
		{
			return default(OBB);
		}

		// Token: 0x06001192 RID: 4498 RVA: 0x0002183C File Offset: 0x0001FA3C
		public Vector3 TransformPoint(Vector3 point)
		{
			return default(Vector3);
		}

		// Token: 0x06001193 RID: 4499 RVA: 0x00021854 File Offset: 0x0001FA54
		public Vector3 InverseTransformPoint(Vector3 point)
		{
			return default(Vector3);
		}

		// Token: 0x0400062E RID: 1582
		private Vector3 _position;

		// Token: 0x0400062F RID: 1583
		private Quaternion _rotation;

		// Token: 0x04000630 RID: 1584
		private Vector3 _scale;
	}
}
