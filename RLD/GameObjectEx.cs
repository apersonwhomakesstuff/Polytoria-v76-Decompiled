using System;
using System.Collections.Generic;
using UnityEngine;

namespace RLD
{
	// Token: 0x02000120 RID: 288
	public static class GameObjectEx
	{
		// Token: 0x06000F45 RID: 3909 RVA: 0x000187E2 File Offset: 0x000169E2
		public static void InheritHierarchyLayers(GameObject hierarchy, GameObject sourceHierarchy)
		{
		}

		// Token: 0x06000F46 RID: 3910 RVA: 0x000187E4 File Offset: 0x000169E4
		public static void SetStatic(GameObject gameObject, bool isStatic, bool affectChildren)
		{
		}

		// Token: 0x06000F47 RID: 3911 RVA: 0x000187E6 File Offset: 0x000169E6
		public static bool IsRLDAppObject(GameObject gameObject)
		{
			return false;
		}

		// Token: 0x06000F48 RID: 3912 RVA: 0x00020904 File Offset: 0x0001EB04
		public static GameObjectType GetGameObjectType(GameObject gameObject)
		{
			return (GameObjectType)0;
		}

		// Token: 0x06000F49 RID: 3913 RVA: 0x000187E9 File Offset: 0x000169E9
		public static bool HierarchyHasMesh(GameObject root)
		{
			return false;
		}

		// Token: 0x06000F4A RID: 3914 RVA: 0x000187EC File Offset: 0x000169EC
		public static bool HierarchyHasSprite(GameObject root)
		{
			return false;
		}

		// Token: 0x06000F4B RID: 3915 RVA: 0x000187EF File Offset: 0x000169EF
		public static bool HierarchyHasObjectsOfType(GameObject root, GameObjectType typeFlags)
		{
			return false;
		}

		// Token: 0x06000F4C RID: 3916 RVA: 0x000187F2 File Offset: 0x000169F2
		public static List<GameObject> GetMeshObjectsInHierarchy(GameObject root)
		{
			return null;
		}

		// Token: 0x06000F4D RID: 3917 RVA: 0x000187F5 File Offset: 0x000169F5
		public static List<GameObject> GetSpriteObjectsInHierarchy(GameObject root)
		{
			return null;
		}

		// Token: 0x06000F4E RID: 3918 RVA: 0x000187F8 File Offset: 0x000169F8
		public static void SetHierarchyWorldScaleByPivot(GameObject root, Vector3 worldScale, Vector3 pivotPoint)
		{
		}

		// Token: 0x06000F4F RID: 3919 RVA: 0x000187FA File Offset: 0x000169FA
		public static List<GameObject> GetAllChildren(GameObject gameObject)
		{
			return null;
		}

		// Token: 0x06000F50 RID: 3920 RVA: 0x000187FD File Offset: 0x000169FD
		public static List<GameObject> GetAllChildrenAndSelf(GameObject gameObject)
		{
			return null;
		}

		// Token: 0x06000F51 RID: 3921 RVA: 0x00018800 File Offset: 0x00016A00
		public static void GetAllChildrenAndSelf(GameObject gameObject, List<GameObject> childrenAndSelf)
		{
		}

		// Token: 0x06000F52 RID: 3922 RVA: 0x00018802 File Offset: 0x00016A02
		public static Mesh GetMesh(GameObject gameObject)
		{
			return null;
		}

		// Token: 0x06000F53 RID: 3923 RVA: 0x00018805 File Offset: 0x00016A05
		public static Renderer GetMeshRenderer(GameObject gameObject)
		{
			return null;
		}

		// Token: 0x06000F54 RID: 3924 RVA: 0x00018808 File Offset: 0x00016A08
		public static Sprite GetSprite(GameObject gameObject)
		{
			return null;
		}

		// Token: 0x06000F55 RID: 3925 RVA: 0x0001880B File Offset: 0x00016A0B
		public static List<GameObject> GetRoots(IEnumerable<GameObject> gameObjects)
		{
			return null;
		}

		// Token: 0x06000F56 RID: 3926 RVA: 0x0001880E File Offset: 0x00016A0E
		public static List<GameObject> FilterParentsOnly(IEnumerable<GameObject> gameObjects)
		{
			return null;
		}

		// Token: 0x04000563 RID: 1379
		private static List<Transform> _transformsChildren;
	}
}
