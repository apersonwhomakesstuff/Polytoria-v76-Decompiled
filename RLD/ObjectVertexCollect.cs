using System;
using System.Collections.Generic;
using UnityEngine;

namespace RLD
{
	// Token: 0x0200020E RID: 526
	public static class ObjectVertexCollect
	{
		// Token: 0x060017D0 RID: 6096 RVA: 0x00019E47 File Offset: 0x00018047
		public static List<Vector3> CollectModelSpriteVerts(Sprite sprite, AABB collectAABB)
		{
			return null;
		}

		// Token: 0x060017D1 RID: 6097 RVA: 0x00019E4A File Offset: 0x0001804A
		public static List<Vector3> CollectWorldSpriteVerts(Sprite sprite, Transform spriteTransform, OBB collectOBB)
		{
			return null;
		}

		// Token: 0x060017D2 RID: 6098 RVA: 0x00019E4D File Offset: 0x0001804D
		public static List<Vector3> CollectHierarchyVerts(GameObject root, BoxFace collectFace, float collectBoxScale, float collectEps)
		{
			return null;
		}

		// Token: 0x0400084C RID: 2124
		private static List<Vector3> _hierarchyVertsCollectBuffer;
	}
}
