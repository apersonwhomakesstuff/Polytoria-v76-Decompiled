using System;
using UnityEngine;

namespace RLD
{
	// Token: 0x0200018A RID: 394
	public class MeshTriangle
	{
		// Token: 0x170005AF RID: 1455
		// (get) Token: 0x060011B3 RID: 4531 RVA: 0x00018EF5 File Offset: 0x000170F5
		public int TriangleIndex
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x170005B0 RID: 1456
		// (get) Token: 0x060011B4 RID: 4532 RVA: 0x00018EF8 File Offset: 0x000170F8
		public Vector3[] Vertices
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170005B1 RID: 1457
		// (get) Token: 0x060011B5 RID: 4533 RVA: 0x000218B4 File Offset: 0x0001FAB4
		public Vector3 Vertex0
		{
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x170005B2 RID: 1458
		// (get) Token: 0x060011B6 RID: 4534 RVA: 0x000218CC File Offset: 0x0001FACC
		public Vector3 Vertex1
		{
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x170005B3 RID: 1459
		// (get) Token: 0x060011B7 RID: 4535 RVA: 0x000218E4 File Offset: 0x0001FAE4
		public Vector3 Vertex2
		{
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x170005B4 RID: 1460
		// (get) Token: 0x060011B8 RID: 4536 RVA: 0x000218FC File Offset: 0x0001FAFC
		public Vector3 Normal
		{
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x170005B5 RID: 1461
		// (get) Token: 0x060011B9 RID: 4537 RVA: 0x00018EFB File Offset: 0x000170FB
		public int[] VertIndices
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170005B6 RID: 1462
		// (get) Token: 0x060011BA RID: 4538 RVA: 0x00018EFE File Offset: 0x000170FE
		public int VertIndex0
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x170005B7 RID: 1463
		// (get) Token: 0x060011BB RID: 4539 RVA: 0x00018F01 File Offset: 0x00017101
		public int VertIndex1
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x170005B8 RID: 1464
		// (get) Token: 0x060011BC RID: 4540 RVA: 0x00018F04 File Offset: 0x00017104
		public int VertIndex2
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x060011BD RID: 4541 RVA: 0x00018F07 File Offset: 0x00017107
		public MeshTriangle(Vector3[] vertices, int triangleIndex, int vertIndex0, int vertIndex1, int vertIndex2)
		{
		}

		// Token: 0x060011BE RID: 4542 RVA: 0x00018F0F File Offset: 0x0001710F
		public int GetVertIndex(int arrayIndex)
		{
			return 0;
		}

		// Token: 0x0400063E RID: 1598
		private Vector3[] _vertices;

		// Token: 0x0400063F RID: 1599
		private Vector3 _normal;

		// Token: 0x04000640 RID: 1600
		private int _triangleIndex;

		// Token: 0x04000641 RID: 1601
		private int[] _vertIndices;
	}
}
