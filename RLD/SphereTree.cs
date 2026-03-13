using System;
using System.Collections.Generic;
using UnityEngine;

namespace RLD
{
	// Token: 0x020000F5 RID: 245
	public class SphereTree<T>
	{
		// Token: 0x06000D95 RID: 3477 RVA: 0x000182FB File Offset: 0x000164FB
		public void DebugDraw()
		{
		}

		// Token: 0x06000D96 RID: 3478 RVA: 0x000182FD File Offset: 0x000164FD
		public SphereTreeNode<T> AddNode(T nodeData, Sphere sphere)
		{
			return null;
		}

		// Token: 0x06000D97 RID: 3479 RVA: 0x00018300 File Offset: 0x00016500
		public void RemoveNode(SphereTreeNode<T> node)
		{
		}

		// Token: 0x06000D98 RID: 3480 RVA: 0x00018302 File Offset: 0x00016502
		public void OnNodeSphereUpdated(SphereTreeNode<T> node)
		{
		}

		// Token: 0x06000D99 RID: 3481 RVA: 0x00018304 File Offset: 0x00016504
		public bool RaycastAll(Ray ray, List<SphereTreeNodeRayHit<T>> hits)
		{
			return false;
		}

		// Token: 0x06000D9A RID: 3482 RVA: 0x00018307 File Offset: 0x00016507
		public bool OverlapBox(OBB box, List<SphereTreeNode<T>> nodes)
		{
			return false;
		}

		// Token: 0x06000D9B RID: 3483 RVA: 0x0001830A File Offset: 0x0001650A
		private void InsertNode(SphereTreeNode<T> node)
		{
		}

		// Token: 0x040004AD RID: 1197
		private SphereTreeNode<T> _root;
	}
}
