using System;
using System.Collections.Generic;
using Polytoria.Datamodel;
using UnityEngine;

namespace Polytoria.Controllers
{
	// Token: 0x0200033A RID: 826
	public static class SpawnpointController
	{
		// Token: 0x060028CF RID: 10447 RVA: 0x00026290 File Offset: 0x00024490
		public static Vector3 GetDefaultSpawnPosition()
		{
			return default(Vector3);
		}

		// Token: 0x060028D0 RID: 10448 RVA: 0x0001CD3D File Offset: 0x0001AF3D
		public static void AddSpawn(Part p)
		{
		}

		// Token: 0x060028D1 RID: 10449 RVA: 0x0001CD3F File Offset: 0x0001AF3F
		public static void RemoveSpawn(Part p)
		{
		}

		// Token: 0x060028D2 RID: 10450 RVA: 0x0001CD41 File Offset: 0x0001AF41
		public static Transform GetSpawnPosition()
		{
			return null;
		}

		// Token: 0x04000DF9 RID: 3577
		private static List<Part> spawns;
	}
}
