using System;
using System.Collections.Generic;
using UnityEngine;

namespace RLD
{
	// Token: 0x0200013E RID: 318
	public struct AABB
	{
		// Token: 0x1700055B RID: 1371
		// (get) Token: 0x06001046 RID: 4166 RVA: 0x00018A0C File Offset: 0x00016C0C
		public bool IsValid
		{
			get
			{
				return false;
			}
		}

		// Token: 0x1700055C RID: 1372
		// (get) Token: 0x06001047 RID: 4167 RVA: 0x00020E5C File Offset: 0x0001F05C
		// (set) Token: 0x06001048 RID: 4168 RVA: 0x00018A0F File Offset: 0x00016C0F
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

		// Token: 0x1700055D RID: 1373
		// (get) Token: 0x06001049 RID: 4169 RVA: 0x00020E74 File Offset: 0x0001F074
		// (set) Token: 0x0600104A RID: 4170 RVA: 0x00018A11 File Offset: 0x00016C11
		public Vector3 Size
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		// Token: 0x1700055E RID: 1374
		// (get) Token: 0x0600104B RID: 4171 RVA: 0x00020E8C File Offset: 0x0001F08C
		public Vector3 Extents
		{
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x1700055F RID: 1375
		// (get) Token: 0x0600104C RID: 4172 RVA: 0x00020EA4 File Offset: 0x0001F0A4
		// (set) Token: 0x0600104D RID: 4173 RVA: 0x00018A13 File Offset: 0x00016C13
		public Vector3 Min
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		// Token: 0x17000560 RID: 1376
		// (get) Token: 0x0600104E RID: 4174 RVA: 0x00020EBC File Offset: 0x0001F0BC
		// (set) Token: 0x0600104F RID: 4175 RVA: 0x00018A15 File Offset: 0x00016C15
		public Vector3 Max
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		// Token: 0x06001050 RID: 4176 RVA: 0x00020ED4 File Offset: 0x0001F0D4
		public AABB(Vector3 center, Vector3 size)
		{
			this._size = default(Vector3);
			this._center = default(Vector3);
			this._isValid = false;
		}

		// Token: 0x06001051 RID: 4177 RVA: 0x00020F08 File Offset: 0x0001F108
		public AABB(Bounds bounds)
		{
			this._size = default(Vector3);
			this._center = default(Vector3);
			this._isValid = false;
		}

		// Token: 0x06001052 RID: 4178 RVA: 0x00020F3C File Offset: 0x0001F13C
		public AABB(IEnumerable<Vector3> pointCloud)
		{
			this._size = default(Vector3);
			this._center = default(Vector3);
			this._isValid = false;
		}

		// Token: 0x06001053 RID: 4179 RVA: 0x00020F70 File Offset: 0x0001F170
		public AABB(IEnumerable<Vector2> pointCloud)
		{
			this._size = default(Vector3);
			this._center = default(Vector3);
			this._isValid = false;
		}

		// Token: 0x06001054 RID: 4180 RVA: 0x00020FA4 File Offset: 0x0001F1A4
		public static AABB GetInvalid()
		{
			return default(AABB);
		}

		// Token: 0x06001055 RID: 4181 RVA: 0x00018A17 File Offset: 0x00016C17
		public void Inflate(float amount)
		{
		}

		// Token: 0x06001056 RID: 4182 RVA: 0x00018A19 File Offset: 0x00016C19
		public void Inflate(Vector3 amount)
		{
		}

		// Token: 0x06001057 RID: 4183 RVA: 0x00018A1B File Offset: 0x00016C1B
		public void Encapsulate(Vector3 point)
		{
		}

		// Token: 0x06001058 RID: 4184 RVA: 0x00018A1D File Offset: 0x00016C1D
		public void Encapsulate(IEnumerable<Vector3> points)
		{
		}

		// Token: 0x06001059 RID: 4185 RVA: 0x00018A1F File Offset: 0x00016C1F
		public void Encapsulate(AABB aabb)
		{
		}

		// Token: 0x0600105A RID: 4186 RVA: 0x00018A21 File Offset: 0x00016C21
		public void Transform(Matrix4x4 transformMatrix)
		{
		}

		// Token: 0x0600105B RID: 4187 RVA: 0x00018A23 File Offset: 0x00016C23
		public bool ContainsPoint(Vector3 point)
		{
			return false;
		}

		// Token: 0x0600105C RID: 4188 RVA: 0x00018A26 File Offset: 0x00016C26
		public List<Vector3> GetCornerPoints()
		{
			return null;
		}

		// Token: 0x0600105D RID: 4189 RVA: 0x00018A29 File Offset: 0x00016C29
		public List<Vector3> GetCenterAndCornerPoints()
		{
			return null;
		}

		// Token: 0x0600105E RID: 4190 RVA: 0x00018A2C File Offset: 0x00016C2C
		public List<Vector2> GetScreenCornerPoints(Camera camera)
		{
			return null;
		}

		// Token: 0x0600105F RID: 4191 RVA: 0x00018A2F File Offset: 0x00016C2F
		public List<Vector2> GetScreenCenterAndCornerPoints(Camera camera)
		{
			return null;
		}

		// Token: 0x06001060 RID: 4192 RVA: 0x00020FBC File Offset: 0x0001F1BC
		public Rect GetScreenRectangle(Camera camera)
		{
			return default(Rect);
		}

		// Token: 0x06001061 RID: 4193 RVA: 0x00020FD4 File Offset: 0x0001F1D4
		public Matrix4x4 GetUnitBoxTransform()
		{
			return default(Matrix4x4);
		}

		// Token: 0x06001062 RID: 4194 RVA: 0x00020FEC File Offset: 0x0001F1EC
		public Bounds ToBounds()
		{
			return default(Bounds);
		}

		// Token: 0x06001063 RID: 4195 RVA: 0x00018A32 File Offset: 0x00016C32
		private void RecalculateCenterAndSize(Vector3 min, Vector3 max)
		{
		}

		// Token: 0x04000592 RID: 1426
		private Vector3 _size;

		// Token: 0x04000593 RID: 1427
		private Vector3 _center;

		// Token: 0x04000594 RID: 1428
		private bool _isValid;
	}
}
