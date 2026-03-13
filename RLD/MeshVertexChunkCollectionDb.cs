using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RLD
{
	// Token: 0x02000189 RID: 393
	public class MeshVertexChunkCollectionDb : Singleton<MeshVertexChunkCollectionDb>, IEnumerable<MeshVertexChunkCollection>, IEnumerable
	{
		// Token: 0x170005AC RID: 1452
		// (get) Token: 0x060011AB RID: 4523 RVA: 0x00018ED8 File Offset: 0x000170D8
		public int Count
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x170005AD RID: 1453
		// (get) Token: 0x060011AC RID: 4524 RVA: 0x00018EDB File Offset: 0x000170DB
		public MeshVertexChunkCollection Item
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170005AE RID: 1454
		// (get) Token: 0x060011AD RID: 4525 RVA: 0x00018EDE File Offset: 0x000170DE
		public MeshVertexChunkCollection Item
		{
			get
			{
				return null;
			}
		}

		// Token: 0x060011AE RID: 4526 RVA: 0x00018EE1 File Offset: 0x000170E1
		public IEnumerator<MeshVertexChunkCollection> GetEnumerator()
		{
			return null;
		}

		// Token: 0x060011AF RID: 4527 RVA: 0x00018EE4 File Offset: 0x000170E4
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		// Token: 0x060011B0 RID: 4528 RVA: 0x00018EE7 File Offset: 0x000170E7
		public bool HasChunkCollectionForMesh(Mesh mesh)
		{
			return false;
		}

		// Token: 0x060011B1 RID: 4529 RVA: 0x00018EEA File Offset: 0x000170EA
		private bool CreateMeshVertChunkCollection(Mesh mesh)
		{
			return false;
		}

		// Token: 0x0400063C RID: 1596
		private List<MeshVertexChunkCollection> _vertexChunkCollections;

		// Token: 0x0400063D RID: 1597
		private Dictionary<Mesh, MeshVertexChunkCollection> _meshToVChunkCollection;
	}
}
