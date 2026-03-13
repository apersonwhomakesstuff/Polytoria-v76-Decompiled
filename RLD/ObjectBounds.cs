using System;
using System.Collections.Generic;
using UnityEngine;

namespace RLD
{
	// Token: 0x02000208 RID: 520
	public static class ObjectBounds
	{
		// Token: 0x17000801 RID: 2049
		// (get) Token: 0x060017AE RID: 6062 RVA: 0x000237D4 File Offset: 0x000219D4
		public static ObjectBounds.QueryConfig DefaultQConfig
		{
			get
			{
				return default(ObjectBounds.QueryConfig);
			}
		}

		// Token: 0x060017AF RID: 6063 RVA: 0x000237EC File Offset: 0x000219EC
		public static Rect CalcScreenRect(GameObject gameObject, Camera camera, ObjectBounds.QueryConfig queryConfig)
		{
			return default(Rect);
		}

		// Token: 0x060017B0 RID: 6064 RVA: 0x00023804 File Offset: 0x00021A04
		public static OBB CalcSpriteWorldOBB(GameObject gameObject)
		{
			return default(OBB);
		}

		// Token: 0x060017B1 RID: 6065 RVA: 0x0002381C File Offset: 0x00021A1C
		public static AABB CalcSpriteWorldAABB(GameObject gameObject)
		{
			return default(AABB);
		}

		// Token: 0x060017B2 RID: 6066 RVA: 0x00023834 File Offset: 0x00021A34
		public static AABB CalcSpriteModelAABB(GameObject spriteObject)
		{
			return default(AABB);
		}

		// Token: 0x060017B3 RID: 6067 RVA: 0x0002384C File Offset: 0x00021A4C
		public static OBB GetMeshWorldOBB(GameObject gameObject)
		{
			return default(OBB);
		}

		// Token: 0x060017B4 RID: 6068 RVA: 0x00023864 File Offset: 0x00021A64
		public static AABB GetMeshWorldAABB(GameObject gameObject)
		{
			return default(AABB);
		}

		// Token: 0x060017B5 RID: 6069 RVA: 0x0002387C File Offset: 0x00021A7C
		public static AABB CalcObjectCollectionWorldAABB(IEnumerable<GameObject> gameObjectCollection, ObjectBounds.QueryConfig queryConfig)
		{
			return default(AABB);
		}

		// Token: 0x060017B6 RID: 6070 RVA: 0x00023894 File Offset: 0x00021A94
		public static AABB CalcHierarchyCollectionWorldAABB(List<GameObject> roots, ObjectBounds.QueryConfig queryConfig)
		{
			return default(AABB);
		}

		// Token: 0x060017B7 RID: 6071 RVA: 0x000238AC File Offset: 0x00021AAC
		public static OBB CalcHierarchyWorldOBB(GameObject root, ObjectBounds.QueryConfig queryConfig)
		{
			return default(OBB);
		}

		// Token: 0x060017B8 RID: 6072 RVA: 0x000238C4 File Offset: 0x00021AC4
		public static AABB CalcHierarchyWorldAABB(GameObject root, ObjectBounds.QueryConfig queryConfig)
		{
			return default(AABB);
		}

		// Token: 0x060017B9 RID: 6073 RVA: 0x000238DC File Offset: 0x00021ADC
		public static OBB CalcWorldOBB(GameObject gameObject, ObjectBounds.QueryConfig queryConfig)
		{
			return default(OBB);
		}

		// Token: 0x060017BA RID: 6074 RVA: 0x000238F4 File Offset: 0x00021AF4
		public static AABB CalcWorldAABB(GameObject gameObject, ObjectBounds.QueryConfig queryConfig)
		{
			return default(AABB);
		}

		// Token: 0x060017BB RID: 6075 RVA: 0x0002390C File Offset: 0x00021B0C
		public static AABB CalcMeshWorldAABB(GameObject gameObject)
		{
			return default(AABB);
		}

		// Token: 0x060017BC RID: 6076 RVA: 0x00023924 File Offset: 0x00021B24
		public static AABB CalcHierarchyModelAABB(GameObject root, ObjectBounds.QueryConfig queryConfig)
		{
			return default(AABB);
		}

		// Token: 0x060017BD RID: 6077 RVA: 0x0002393C File Offset: 0x00021B3C
		public static AABB CalcMeshModelAABB(GameObject gameObject)
		{
			return default(AABB);
		}

		// Token: 0x060017BE RID: 6078 RVA: 0x00023954 File Offset: 0x00021B54
		public static AABB CalcModelAABB(GameObject gameObject, ObjectBounds.QueryConfig queryConfig, GameObjectType objectType)
		{
			return default(AABB);
		}

		// Token: 0x04000848 RID: 2120
		private static ObjectBounds.QueryConfig _defaultQConfig;

		// Token: 0x020003C3 RID: 963
		public struct QueryConfig
		{
			// Token: 0x0400100E RID: 4110
			public GameObjectType ObjectTypes;

			// Token: 0x0400100F RID: 4111
			public Vector3 NoVolumeSize;
		}
	}
}
