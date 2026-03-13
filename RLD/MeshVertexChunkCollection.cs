using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RLD
{
	// Token: 0x02000188 RID: 392
	public class MeshVertexChunkCollection : IEnumerable<MeshVertexChunk>, IEnumerable
	{
		// Token: 0x170005AA RID: 1450
		// (get) Token: 0x060011A3 RID: 4515 RVA: 0x00018EBB File Offset: 0x000170BB
		public MeshVertexChunk Item
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170005AB RID: 1451
		// (get) Token: 0x060011A4 RID: 4516 RVA: 0x00018EBE File Offset: 0x000170BE
		public int Count
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x060011A5 RID: 4517 RVA: 0x00018EC1 File Offset: 0x000170C1
		public IEnumerator<MeshVertexChunk> GetEnumerator()
		{
			return null;
		}

		// Token: 0x060011A6 RID: 4518 RVA: 0x00018EC4 File Offset: 0x000170C4
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		// Token: 0x060011A7 RID: 4519 RVA: 0x00018EC7 File Offset: 0x000170C7
		public List<MeshVertexChunk> GetWorldChunksHoveredByPoint(Vector3 hoverPoint, Matrix4x4 worldMtx, Camera camera)
		{
			return null;
		}

		// Token: 0x060011A8 RID: 4520 RVA: 0x00018ECA File Offset: 0x000170CA
		public MeshVertexChunk GetWorldVertChunkClosestToScreenPt(Vector2 screenPoint, Matrix4x4 worldMtx, Camera camera)
		{
			return null;
		}

		// Token: 0x060011A9 RID: 4521 RVA: 0x00018ECD File Offset: 0x000170CD
		public bool FromMesh(Mesh mesh)
		{
			return false;
		}

		// Token: 0x0400063A RID: 1594
		private Mesh _mesh;

		// Token: 0x0400063B RID: 1595
		private List<MeshVertexChunk> _vertexChunks;

		// Token: 0x02000390 RID: 912
		private struct VertexChunkIndices
		{
			// Token: 0x17000C93 RID: 3219
			// (get) Token: 0x06002AB7 RID: 10935 RVA: 0x0001D317 File Offset: 0x0001B517
			public int XIndex
			{
				get
				{
					return 0;
				}
			}

			// Token: 0x17000C94 RID: 3220
			// (get) Token: 0x06002AB8 RID: 10936 RVA: 0x0001D31A File Offset: 0x0001B51A
			public int YIndex
			{
				get
				{
					return 0;
				}
			}

			// Token: 0x17000C95 RID: 3221
			// (get) Token: 0x06002AB9 RID: 10937 RVA: 0x0001D31D File Offset: 0x0001B51D
			public int ZIndex
			{
				get
				{
					return 0;
				}
			}

			// Token: 0x06002ABA RID: 10938 RVA: 0x0001D320 File Offset: 0x0001B520
			public VertexChunkIndices(int xIndex, int yIndex, int zIndex)
			{
				this._XIndex = 0;
				this._YIndex = 0;
				this._ZIndex = 0;
			}

			// Token: 0x04000F6D RID: 3949
			private int _XIndex;

			// Token: 0x04000F6E RID: 3950
			private int _YIndex;

			// Token: 0x04000F6F RID: 3951
			private int _ZIndex;
		}
	}
}
