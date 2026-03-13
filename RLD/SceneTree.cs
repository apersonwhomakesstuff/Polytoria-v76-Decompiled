using System;
using System.Collections.Generic;
using UnityEngine;

namespace RLD
{
	// Token: 0x020001BF RID: 447
	public class SceneTree
	{
		// Token: 0x06001385 RID: 4997 RVA: 0x00019418 File Offset: 0x00017618
		public GameObjectRayHit RaycastMeshObject(Ray ray, GameObject gameObject)
		{
			return null;
		}

		// Token: 0x06001386 RID: 4998 RVA: 0x0001941B File Offset: 0x0001761B
		public GameObjectRayHit RaycastSpriteObject(Ray ray, GameObject gameObject)
		{
			return null;
		}

		// Token: 0x06001387 RID: 4999 RVA: 0x0001941E File Offset: 0x0001761E
		public bool RaycastAll(Ray ray, SceneRaycastPrecision raycastPresicion, List<GameObjectRayHit> hits)
		{
			return false;
		}

		// Token: 0x06001388 RID: 5000 RVA: 0x00019421 File Offset: 0x00017621
		public bool OverlapBox(OBB obb, List<GameObject> gameObjects)
		{
			return false;
		}

		// Token: 0x06001389 RID: 5001 RVA: 0x00019424 File Offset: 0x00017624
		public bool IsObjectRegistered(GameObject gameObject)
		{
			return false;
		}

		// Token: 0x0600138A RID: 5002 RVA: 0x00019427 File Offset: 0x00017627
		public bool RegisterObject(GameObject gameObject)
		{
			return false;
		}

		// Token: 0x0600138B RID: 5003 RVA: 0x0001942A File Offset: 0x0001762A
		public bool UnregisterObject(GameObject gameObject)
		{
			return false;
		}

		// Token: 0x0600138C RID: 5004 RVA: 0x0001942D File Offset: 0x0001762D
		public void OnObjectTransformChanged(Transform objectTransform)
		{
		}

		// Token: 0x0600138D RID: 5005 RVA: 0x0001942F File Offset: 0x0001762F
		public void RemoveNodesWithNullObjects()
		{
		}

		// Token: 0x0600138E RID: 5006 RVA: 0x00019431 File Offset: 0x00017631
		public void DebugDraw()
		{
		}

		// Token: 0x0600138F RID: 5007 RVA: 0x00019433 File Offset: 0x00017633
		private bool CanRegisterObject(GameObject gameObject)
		{
			return false;
		}

		// Token: 0x0400070C RID: 1804
		private SphereTree<GameObject> _objectTree;

		// Token: 0x0400070D RID: 1805
		private Dictionary<GameObject, SphereTreeNode<GameObject>> _objectToNode;

		// Token: 0x0400070E RID: 1806
		private List<SphereTreeNodeRayHit<GameObject>> _nodeHitBuffer;

		// Token: 0x0400070F RID: 1807
		private List<SphereTreeNode<GameObject>> _nodeBuffer;
	}
}
