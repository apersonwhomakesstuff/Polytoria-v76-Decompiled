using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RLD
{
	// Token: 0x02000187 RID: 391
	public class MeshVertexChunk : IEnumerable<Vector3>, IEnumerable
	{
		// Token: 0x170005A6 RID: 1446
		// (get) Token: 0x0600119B RID: 4507 RVA: 0x0002186C File Offset: 0x0001FA6C
		public Vector3 Item
		{
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x170005A7 RID: 1447
		// (get) Token: 0x0600119C RID: 4508 RVA: 0x00018EA7 File Offset: 0x000170A7
		public Mesh Mesh
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170005A8 RID: 1448
		// (get) Token: 0x0600119D RID: 4509 RVA: 0x00018EAA File Offset: 0x000170AA
		public int VertexCount
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x170005A9 RID: 1449
		// (get) Token: 0x0600119E RID: 4510 RVA: 0x00021884 File Offset: 0x0001FA84
		public AABB ModelSpaceAABB
		{
			get
			{
				return default(AABB);
			}
		}

		// Token: 0x0600119F RID: 4511 RVA: 0x00018EAD File Offset: 0x000170AD
		public MeshVertexChunk(List<Vector3> modelSpaceVerts, Mesh mesh)
		{
		}

		// Token: 0x060011A0 RID: 4512 RVA: 0x00018EB5 File Offset: 0x000170B5
		public IEnumerator<Vector3> GetEnumerator()
		{
			return null;
		}

		// Token: 0x060011A1 RID: 4513 RVA: 0x00018EB8 File Offset: 0x000170B8
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		// Token: 0x060011A2 RID: 4514 RVA: 0x0002189C File Offset: 0x0001FA9C
		public Vector3 GetWorldVertClosestToScreenPt(Vector2 screenPoint, Matrix4x4 worldMtx, Camera camera)
		{
			return default(Vector3);
		}

		// Token: 0x04000637 RID: 1591
		private List<Vector3> _modelSpaceVerts;

		// Token: 0x04000638 RID: 1592
		private AABB _modelSpaceAABB;

		// Token: 0x04000639 RID: 1593
		private Mesh _mesh;
	}
}
