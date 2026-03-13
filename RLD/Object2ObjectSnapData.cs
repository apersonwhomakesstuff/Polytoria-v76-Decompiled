using System;
using System.Collections.Generic;
using UnityEngine;

namespace RLD
{
	// Token: 0x02000205 RID: 517
	public class Object2ObjectSnapData
	{
		// Token: 0x060017A2 RID: 6050 RVA: 0x00019E09 File Offset: 0x00018009
		public bool Initialize(GameObject gameObject)
		{
			return false;
		}

		// Token: 0x060017A3 RID: 6051 RVA: 0x00023774 File Offset: 0x00021974
		public BoxFaceAreaDesc GetWorldSnapAreaDesc(BoxFace boxFace)
		{
			return default(BoxFaceAreaDesc);
		}

		// Token: 0x060017A4 RID: 6052 RVA: 0x00019E0C File Offset: 0x0001800C
		public List<OBB> GetAllWorldSnapAreaBounds()
		{
			return null;
		}

		// Token: 0x060017A5 RID: 6053 RVA: 0x0002378C File Offset: 0x0002198C
		public OBB GetWorldSnapAreaBounds(BoxFace boxFace)
		{
			return default(OBB);
		}

		// Token: 0x060017A6 RID: 6054 RVA: 0x00019E0F File Offset: 0x0001800F
		private List<AABB> BuildVertOverlapAABBs(GameObject gameObject, Sprite sprite, RTMesh rtMesh)
		{
			return null;
		}

		// Token: 0x04000843 RID: 2115
		private GameObject _gameObject;

		// Token: 0x04000844 RID: 2116
		private AABB[] _snapAreaBounds;

		// Token: 0x04000845 RID: 2117
		private BoxFaceAreaDesc[] _snapAreaDesc;

		// Token: 0x04000846 RID: 2118
		private List<Vector3> _vertsBuffer;
	}
}
