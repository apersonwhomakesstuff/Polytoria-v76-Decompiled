using System;
using System.Collections.Generic;
using UnityEngine;

namespace RLD
{
	// Token: 0x020001AB RID: 427
	public class GameObjectRayHit
	{
		// Token: 0x17000616 RID: 1558
		// (get) Token: 0x060012E4 RID: 4836 RVA: 0x00019227 File Offset: 0x00017427
		public GameObject HitObject
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000617 RID: 1559
		// (get) Token: 0x060012E5 RID: 4837 RVA: 0x00021A4C File Offset: 0x0001FC4C
		public Vector3 HitPoint
		{
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x17000618 RID: 1560
		// (get) Token: 0x060012E6 RID: 4838 RVA: 0x0001922A File Offset: 0x0001742A
		public float HitEnter
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000619 RID: 1561
		// (get) Token: 0x060012E7 RID: 4839 RVA: 0x00021A64 File Offset: 0x0001FC64
		public Vector3 HitNormal
		{
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x1700061A RID: 1562
		// (get) Token: 0x060012E8 RID: 4840 RVA: 0x00021A7C File Offset: 0x0001FC7C
		public Plane HitPlane
		{
			get
			{
				return default(Plane);
			}
		}

		// Token: 0x1700061B RID: 1563
		// (get) Token: 0x060012E9 RID: 4841 RVA: 0x00019231 File Offset: 0x00017431
		public MeshRayHit MeshRayHit
		{
			get
			{
				return null;
			}
		}

		// Token: 0x060012EA RID: 4842 RVA: 0x00019234 File Offset: 0x00017434
		public static void SortByHitDistance(List<GameObjectRayHit> hits)
		{
		}

		// Token: 0x060012EB RID: 4843 RVA: 0x00019236 File Offset: 0x00017436
		public static void Store(Ray hitRay, IEnumerable<RaycastHit2D> hits2D, IEnumerable<RaycastHit> hits3D, List<GameObjectRayHit> hits)
		{
		}

		// Token: 0x060012EC RID: 4844 RVA: 0x00019238 File Offset: 0x00017438
		public GameObjectRayHit(Ray hitRay, RaycastHit hit3D)
		{
		}

		// Token: 0x060012ED RID: 4845 RVA: 0x00019240 File Offset: 0x00017440
		public GameObjectRayHit(Ray hitRay, RaycastHit2D hit2D)
		{
		}

		// Token: 0x060012EE RID: 4846 RVA: 0x00019248 File Offset: 0x00017448
		public GameObjectRayHit(Ray hitRay, GameObject hitObject, Vector3 hitNormal, float hitEnter)
		{
		}

		// Token: 0x060012EF RID: 4847 RVA: 0x00019250 File Offset: 0x00017450
		public GameObjectRayHit(Ray ray, GameObject hitObject, MeshRayHit meshRayHit)
		{
		}

		// Token: 0x040006C1 RID: 1729
		private GameObject _hitObject;

		// Token: 0x040006C2 RID: 1730
		private Vector3 _hitPoint;

		// Token: 0x040006C3 RID: 1731
		private float _hitEnter;

		// Token: 0x040006C4 RID: 1732
		private Vector3 _hitNormal;

		// Token: 0x040006C5 RID: 1733
		private Plane _hitPlane;

		// Token: 0x040006C6 RID: 1734
		private MeshRayHit _meshRayHit;

		// Token: 0x0200039E RID: 926
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06002AE1 RID: 10977 RVA: 0x0001D392 File Offset: 0x0001B592
			internal int <SortByHitDistance>b__18_0(GameObjectRayHit h0, GameObjectRayHit h1)
			{
				return 0;
			}

			// Token: 0x04000F7D RID: 3965
			public static readonly GameObjectRayHit.<>c <>9;

			// Token: 0x04000F7E RID: 3966
			public static Comparison<GameObjectRayHit> <>9__18_0;
		}
	}
}
