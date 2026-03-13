using System;
using System.Collections.Generic;
using UnityEngine;

namespace RLD
{
	// Token: 0x02000186 RID: 390
	public class MeshTree
	{
		// Token: 0x170005A5 RID: 1445
		// (get) Token: 0x06001194 RID: 4500 RVA: 0x00018E8F File Offset: 0x0001708F
		public bool IsBuilt
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06001195 RID: 4501 RVA: 0x00018E92 File Offset: 0x00017092
		public MeshTree(RTMesh mesh)
		{
		}

		// Token: 0x06001196 RID: 4502 RVA: 0x00018E9A File Offset: 0x0001709A
		public void Build()
		{
		}

		// Token: 0x06001197 RID: 4503 RVA: 0x00018E9C File Offset: 0x0001709C
		public bool OverlapVerts(OBB obb, MeshTransform meshTransform, List<Vector3> verts)
		{
			return false;
		}

		// Token: 0x06001198 RID: 4504 RVA: 0x00018E9F File Offset: 0x0001709F
		public bool OverlapModelVerts(OBB modelOBB, List<Vector3> verts)
		{
			return false;
		}

		// Token: 0x06001199 RID: 4505 RVA: 0x00018EA2 File Offset: 0x000170A2
		public MeshRayHit RaycastClosest(Ray ray, Matrix4x4 meshTransform)
		{
			return null;
		}

		// Token: 0x0600119A RID: 4506 RVA: 0x00018EA5 File Offset: 0x000170A5
		public void DebugDraw()
		{
		}

		// Token: 0x04000631 RID: 1585
		private RTMesh _mesh;

		// Token: 0x04000632 RID: 1586
		private SphereTree<MeshTriangle> _tree;

		// Token: 0x04000633 RID: 1587
		private List<SphereTreeNode<MeshTriangle>> _nodeBuffer;

		// Token: 0x04000634 RID: 1588
		private List<SphereTreeNodeRayHit<MeshTriangle>> _nodeHitBuffer;

		// Token: 0x04000635 RID: 1589
		private HashSet<int> _vertexIndexSet;

		// Token: 0x04000636 RID: 1590
		private bool _isBuilt;
	}
}
