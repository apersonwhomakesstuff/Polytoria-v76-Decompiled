using System;
using System.Collections.Generic;
using Polytoria.Datamodel;
using UnityEngine;
using UnityEngine.UI;

namespace Polytoria.Controllers
{
	// Token: 0x02000341 RID: 833
	public class CreatorThumbnailGenerator : MonoBehaviour
	{
		// Token: 0x06002998 RID: 10648 RVA: 0x0001CFFC File Offset: 0x0001B1FC
		public Texture2D GenerateThumbnail(Instance instance)
		{
			return null;
		}

		// Token: 0x06002999 RID: 10649 RVA: 0x0001CFFF File Offset: 0x0001B1FF
		private void SetLayer(Instance i, int layer)
		{
		}

		// Token: 0x0600299A RID: 10650 RVA: 0x0001D001 File Offset: 0x0001B201
		public void PositionCamera(UnityEngine.Camera camera, Bounds bounds, float padding = 0f)
		{
		}

		// Token: 0x0600299B RID: 10651 RVA: 0x0001D003 File Offset: 0x0001B203
		private static void FindClosestPointsOnTwoLines(Ray line1, Ray line2, out Vector3 closestPointLine1, out Vector3 closestPointLine2)
		{
			closestPointLine1 = default(Vector3);
			closestPointLine2 = default(Vector3);
		}

		// Token: 0x0600299C RID: 10652 RVA: 0x000262C0 File Offset: 0x000244C0
		private static Ray GetPlanesIntersection(Plane p1, Plane p2)
		{
			return default(Ray);
		}

		// Token: 0x0600299D RID: 10653 RVA: 0x0001D013 File Offset: 0x0001B213
		private static bool IsOutermostPointInDirection(int pointIndex, Vector3 direction, Vector3[] boundingBoxPoints)
		{
			return false;
		}

		// Token: 0x0600299E RID: 10654 RVA: 0x0001D016 File Offset: 0x0001B216
		public void TestRender()
		{
		}

		// Token: 0x04000E5B RID: 3675
		private RawImage preview;

		// Token: 0x04000E5C RID: 3676
		private int width;

		// Token: 0x04000E5D RID: 3677
		private int height;

		// Token: 0x04000E5E RID: 3678
		private float _padding;

		// Token: 0x04000E5F RID: 3679
		private UnityEngine.Camera thumbnailCamera;

		// Token: 0x04000E60 RID: 3680
		private Dictionary<GameObject, int> oldLayers;
	}
}
