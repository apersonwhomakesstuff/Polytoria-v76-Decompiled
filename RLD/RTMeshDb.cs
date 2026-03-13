using System;
using System.Collections.Generic;
using UnityEngine;

namespace RLD
{
	// Token: 0x0200018D RID: 397
	public class RTMeshDb : Singleton<RTMeshDb>
	{
		// Token: 0x060011CE RID: 4558 RVA: 0x00018F3E File Offset: 0x0001713E
		public bool Contains(RTMesh rtMesh)
		{
			return false;
		}

		// Token: 0x060011CF RID: 4559 RVA: 0x00018F41 File Offset: 0x00017141
		public bool Contains(Mesh unityMesh)
		{
			return false;
		}

		// Token: 0x060011D0 RID: 4560 RVA: 0x00018F44 File Offset: 0x00017144
		public RTMesh GetRTMesh(Mesh unityMesh)
		{
			return null;
		}

		// Token: 0x060011D1 RID: 4561 RVA: 0x00018F47 File Offset: 0x00017147
		public void OnMeshWillBeDestroyed(Mesh unityMesh)
		{
		}

		// Token: 0x060011D2 RID: 4562 RVA: 0x00018F49 File Offset: 0x00017149
		private RTMesh CreateRTMesh(Mesh unityMesh)
		{
			return null;
		}

		// Token: 0x04000648 RID: 1608
		private Dictionary<Mesh, RTMesh> _meshes;
	}
}
