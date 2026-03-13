using System;
using System.Collections.Generic;
using UnityEngine;

namespace RLD
{
	// Token: 0x0200020D RID: 525
	public class ObjectSurfaceSnap
	{
		// Token: 0x060017CA RID: 6090 RVA: 0x000239B4 File Offset: 0x00021BB4
		public static ObjectSurfaceSnap.SnapResult SnapHierarchy(GameObject root, ObjectSurfaceSnap.SnapConfig snapConfig)
		{
			return default(ObjectSurfaceSnap.SnapResult);
		}

		// Token: 0x060017CB RID: 6091 RVA: 0x000239CC File Offset: 0x00021BCC
		public static Vector3 CalculateSitOnSurfaceOffset(OBB obb, Plane surfacePlane, float offsetFromSurface)
		{
			return default(Vector3);
		}

		// Token: 0x060017CC RID: 6092 RVA: 0x000239E4 File Offset: 0x00021BE4
		public static Vector3 CalculateSitOnSurfaceOffset(AABB aabb, Plane surfacePlane, float offsetFromSurface)
		{
			return default(Vector3);
		}

		// Token: 0x060017CD RID: 6093 RVA: 0x000239FC File Offset: 0x00021BFC
		public static Vector3 CalculateEmbedVector(List<Vector3> embedPoints, GameObject embedSurface, Vector3 embedDirection, ObjectSurfaceSnap.Type surfaceType)
		{
			return default(Vector3);
		}

		// Token: 0x060017CE RID: 6094 RVA: 0x00019E3C File Offset: 0x0001803C
		private static ObjectSurfaceSnap.SurfaceRaycaster CreateSurfaceRaycaster(ObjectSurfaceSnap.Type surfaceType, GameObject surfaceObject, bool raycastReverse)
		{
			return null;
		}

		// Token: 0x020003C7 RID: 967
		public enum Type
		{
			// Token: 0x0400101B RID: 4123
			UnityTerrain,
			// Token: 0x0400101C RID: 4124
			Mesh,
			// Token: 0x0400101D RID: 4125
			TerrainMesh,
			// Token: 0x0400101E RID: 4126
			SphericalMesh,
			// Token: 0x0400101F RID: 4127
			SceneGrid
		}

		// Token: 0x020003C8 RID: 968
		public struct SnapConfig
		{
			// Token: 0x06002B2B RID: 11051 RVA: 0x0001D480 File Offset: 0x0001B680
			public bool IsSurfaceMesh()
			{
				return false;
			}

			// Token: 0x04001020 RID: 4128
			public bool AlignAxis;

			// Token: 0x04001021 RID: 4129
			public TransformAxis AlignmentAxis;

			// Token: 0x04001022 RID: 4130
			public ObjectSurfaceSnap.Type SurfaceType;

			// Token: 0x04001023 RID: 4131
			public float OffsetFromSurface;

			// Token: 0x04001024 RID: 4132
			public Vector3 SurfaceHitPoint;

			// Token: 0x04001025 RID: 4133
			public Vector3 SurfaceHitNormal;

			// Token: 0x04001026 RID: 4134
			public Plane SurfaceHitPlane;

			// Token: 0x04001027 RID: 4135
			public GameObject SurfaceObject;
		}

		// Token: 0x020003C9 RID: 969
		public struct SnapResult
		{
			// Token: 0x06002B2C RID: 11052 RVA: 0x000269D8 File Offset: 0x00024BD8
			public SnapResult(Plane sittingPlane, Vector3 sittingPoint)
			{
				this.Success = false;
				this.SittingPlane = default(Plane);
				this.SittingPoint = default(Vector3);
			}

			// Token: 0x04001028 RID: 4136
			public bool Success;

			// Token: 0x04001029 RID: 4137
			public Plane SittingPlane;

			// Token: 0x0400102A RID: 4138
			public Vector3 SittingPoint;
		}

		// Token: 0x020003CA RID: 970
		private abstract class SurfaceRaycaster
		{
			// Token: 0x06002B2D RID: 11053 RVA: 0x0001D483 File Offset: 0x0001B683
			public SurfaceRaycaster(GameObject surfaceObject, bool raycastReverse)
			{
			}

			// Token: 0x06002B2E RID: 11054
			public abstract GameObjectRayHit Raycast(Ray ray);

			// Token: 0x0400102B RID: 4139
			protected GameObject _surfaceObject;

			// Token: 0x0400102C RID: 4140
			protected bool _raycastReverse;
		}

		// Token: 0x020003CB RID: 971
		private class MeshSurfaceRaycaster : ObjectSurfaceSnap.SurfaceRaycaster
		{
			// Token: 0x06002B2F RID: 11055 RVA: 0x0001D48B File Offset: 0x0001B68B
			public MeshSurfaceRaycaster(GameObject surfaceObject, bool raycastReverse)
			{
			}

			// Token: 0x06002B30 RID: 11056 RVA: 0x0001D48D File Offset: 0x0001B68D
			public override GameObjectRayHit Raycast(Ray ray)
			{
				return null;
			}
		}
	}
}
