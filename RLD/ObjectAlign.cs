using System;
using System.Collections.Generic;
using UnityEngine;

namespace RLD
{
	// Token: 0x02000207 RID: 519
	public static class ObjectAlign
	{
		// Token: 0x060017AA RID: 6058 RVA: 0x000237A4 File Offset: 0x000219A4
		public static ObjectAlign.Result AlignToWorldAxis(IEnumerable<GameObject> gameObjects, Axis axis, Vector3 alignmentPlaneOrigin)
		{
			return ObjectAlign.Result.Err_NoObjects;
		}

		// Token: 0x060017AB RID: 6059 RVA: 0x000237BC File Offset: 0x000219BC
		public static ObjectAlign.Result AlignToWorldPlane(IEnumerable<GameObject> gameObjects, Plane alignmentPlane)
		{
			return ObjectAlign.Result.Err_NoObjects;
		}

		// Token: 0x060017AC RID: 6060 RVA: 0x00019E25 File Offset: 0x00018025
		private static void AlignRootsToPlane(List<GameObject> roots, Plane alignmentPlane)
		{
		}

		// Token: 0x020003C2 RID: 962
		public enum Result
		{
			// Token: 0x0400100C RID: 4108
			Err_NoObjects,
			// Token: 0x0400100D RID: 4109
			Success
		}
	}
}
