using System;
using System.Collections.Generic;
using UnityEngine;

namespace RLD
{
	// Token: 0x02000143 RID: 323
	public struct OBB
	{
		// Token: 0x17000565 RID: 1381
		// (get) Token: 0x0600106D RID: 4205 RVA: 0x00018A4D File Offset: 0x00016C4D
		public bool IsValid
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000566 RID: 1382
		// (get) Token: 0x0600106E RID: 4206 RVA: 0x00021064 File Offset: 0x0001F264
		// (set) Token: 0x0600106F RID: 4207 RVA: 0x00018A50 File Offset: 0x00016C50
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

		// Token: 0x17000567 RID: 1383
		// (get) Token: 0x06001070 RID: 4208 RVA: 0x0002107C File Offset: 0x0001F27C
		// (set) Token: 0x06001071 RID: 4209 RVA: 0x00018A52 File Offset: 0x00016C52
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

		// Token: 0x17000568 RID: 1384
		// (get) Token: 0x06001072 RID: 4210 RVA: 0x00021094 File Offset: 0x0001F294
		public Vector3 Extents
		{
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x17000569 RID: 1385
		// (get) Token: 0x06001073 RID: 4211 RVA: 0x000210AC File Offset: 0x0001F2AC
		// (set) Token: 0x06001074 RID: 4212 RVA: 0x00018A54 File Offset: 0x00016C54
		public Quaternion Rotation
		{
			get
			{
				return default(Quaternion);
			}
			set
			{
			}
		}

		// Token: 0x1700056A RID: 1386
		// (get) Token: 0x06001075 RID: 4213 RVA: 0x000210C4 File Offset: 0x0001F2C4
		public Matrix4x4 RotationMatrix
		{
			get
			{
				return default(Matrix4x4);
			}
		}

		// Token: 0x1700056B RID: 1387
		// (get) Token: 0x06001076 RID: 4214 RVA: 0x000210DC File Offset: 0x0001F2DC
		public Vector3 Right
		{
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x1700056C RID: 1388
		// (get) Token: 0x06001077 RID: 4215 RVA: 0x000210F4 File Offset: 0x0001F2F4
		public Vector3 Up
		{
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x1700056D RID: 1389
		// (get) Token: 0x06001078 RID: 4216 RVA: 0x0002110C File Offset: 0x0001F30C
		public Vector3 Look
		{
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x06001079 RID: 4217 RVA: 0x00021124 File Offset: 0x0001F324
		public OBB(Vector3 center, Vector3 size)
		{
			this._size = default(Vector3);
			this._center = default(Vector3);
			this._rotation = default(Quaternion);
			this._isValid = false;
		}

		// Token: 0x0600107A RID: 4218 RVA: 0x00021168 File Offset: 0x0001F368
		public OBB(Vector3 center, Vector3 size, Quaternion rotation)
		{
			this._size = default(Vector3);
			this._center = default(Vector3);
			this._rotation = default(Quaternion);
			this._isValid = false;
		}

		// Token: 0x0600107B RID: 4219 RVA: 0x000211AC File Offset: 0x0001F3AC
		public OBB(Vector3 center, Quaternion rotation)
		{
			this._size = default(Vector3);
			this._center = default(Vector3);
			this._rotation = default(Quaternion);
			this._isValid = false;
		}

		// Token: 0x0600107C RID: 4220 RVA: 0x000211F0 File Offset: 0x0001F3F0
		public OBB(Quaternion rotation)
		{
			this._size = default(Vector3);
			this._center = default(Vector3);
			this._rotation = default(Quaternion);
			this._isValid = false;
		}

		// Token: 0x0600107D RID: 4221 RVA: 0x00021234 File Offset: 0x0001F434
		public OBB(Bounds bounds, Quaternion rotation)
		{
			this._size = default(Vector3);
			this._center = default(Vector3);
			this._rotation = default(Quaternion);
			this._isValid = false;
		}

		// Token: 0x0600107E RID: 4222 RVA: 0x00021278 File Offset: 0x0001F478
		public OBB(AABB aabb)
		{
			this._size = default(Vector3);
			this._center = default(Vector3);
			this._rotation = default(Quaternion);
			this._isValid = false;
		}

		// Token: 0x0600107F RID: 4223 RVA: 0x000212BC File Offset: 0x0001F4BC
		public OBB(AABB aabb, Quaternion rotation)
		{
			this._size = default(Vector3);
			this._center = default(Vector3);
			this._rotation = default(Quaternion);
			this._isValid = false;
		}

		// Token: 0x06001080 RID: 4224 RVA: 0x00021300 File Offset: 0x0001F500
		public OBB(AABB modelSpaceAABB, Transform worldTransform)
		{
			this._size = default(Vector3);
			this._center = default(Vector3);
			this._rotation = default(Quaternion);
			this._isValid = false;
		}

		// Token: 0x06001081 RID: 4225 RVA: 0x00021344 File Offset: 0x0001F544
		public OBB(OBB copy)
		{
			this._size = default(Vector3);
			this._center = default(Vector3);
			this._rotation = default(Quaternion);
			this._isValid = false;
		}

		// Token: 0x06001082 RID: 4226 RVA: 0x00021388 File Offset: 0x0001F588
		public static OBB GetInvalid()
		{
			return default(OBB);
		}

		// Token: 0x06001083 RID: 4227 RVA: 0x00018A56 File Offset: 0x00016C56
		public void Inflate(float amount)
		{
		}

		// Token: 0x06001084 RID: 4228 RVA: 0x000213A0 File Offset: 0x0001F5A0
		public Matrix4x4 GetUnitBoxTransform()
		{
			return default(Matrix4x4);
		}

		// Token: 0x06001085 RID: 4229 RVA: 0x00018A58 File Offset: 0x00016C58
		public List<Vector3> GetCornerPoints()
		{
			return null;
		}

		// Token: 0x06001086 RID: 4230 RVA: 0x00018A5B File Offset: 0x00016C5B
		public List<Vector3> GetCenterAndCornerPoints()
		{
			return null;
		}

		// Token: 0x06001087 RID: 4231 RVA: 0x00018A5E File Offset: 0x00016C5E
		public void Encapsulate(OBB otherOBB)
		{
		}

		// Token: 0x06001088 RID: 4232 RVA: 0x000213B8 File Offset: 0x0001F5B8
		public Vector3 GetPointFaceNormal(Vector3 pointOnFace)
		{
			return default(Vector3);
		}

		// Token: 0x06001089 RID: 4233 RVA: 0x00018A60 File Offset: 0x00016C60
		public bool IntersectsOBB(OBB otherOBB)
		{
			return false;
		}

		// Token: 0x0600108A RID: 4234 RVA: 0x000213D0 File Offset: 0x0001F5D0
		public Vector3 GetClosestPoint(Vector3 point)
		{
			return default(Vector3);
		}

		// Token: 0x0600108B RID: 4235 RVA: 0x00018A63 File Offset: 0x00016C63
		public bool IntersectsSphere(Sphere sphere)
		{
			return false;
		}

		// Token: 0x0400059E RID: 1438
		private Vector3 _size;

		// Token: 0x0400059F RID: 1439
		private Vector3 _center;

		// Token: 0x040005A0 RID: 1440
		private Quaternion _rotation;

		// Token: 0x040005A1 RID: 1441
		private bool _isValid;
	}
}
