using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

namespace RLD
{
	// Token: 0x020001B7 RID: 439
	public class RTScene : MonoSingleton<RTScene>
	{
		// Token: 0x17000644 RID: 1604
		// (get) Token: 0x06001340 RID: 4928 RVA: 0x00019336 File Offset: 0x00017536
		public SceneSettings Settings
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000645 RID: 1605
		// (get) Token: 0x06001341 RID: 4929 RVA: 0x00019339 File Offset: 0x00017539
		public SceneLookAndFeel LookAndFeel
		{
			get
			{
				return null;
			}
		}

		// Token: 0x06001342 RID: 4930 RVA: 0x0001933C File Offset: 0x0001753C
		public void SetRootObjectIgnored(GameObject root, bool ignored)
		{
		}

		// Token: 0x06001343 RID: 4931 RVA: 0x0001933E File Offset: 0x0001753E
		public void OnGameObjectWillBeDestroyed(GameObject gameObject)
		{
		}

		// Token: 0x06001344 RID: 4932 RVA: 0x00019340 File Offset: 0x00017540
		public void AddIconRenderIgnoreCamera(Camera camera)
		{
		}

		// Token: 0x06001345 RID: 4933 RVA: 0x00019342 File Offset: 0x00017542
		public bool IsIconRenderIgnoreCamera(Camera camera)
		{
			return false;
		}

		// Token: 0x06001346 RID: 4934 RVA: 0x00021C2C File Offset: 0x0001FE2C
		public AABB CalculateBounds()
		{
			return default(AABB);
		}

		// Token: 0x06001347 RID: 4935 RVA: 0x00019345 File Offset: 0x00017545
		public bool IsAnySceneEntityHovered()
		{
			return false;
		}

		// Token: 0x06001348 RID: 4936 RVA: 0x00019348 File Offset: 0x00017548
		public void RegisterHoverableSceneEntityContainer(IHoverableSceneEntityContainer container)
		{
		}

		// Token: 0x06001349 RID: 4937 RVA: 0x0001934A File Offset: 0x0001754A
		public bool IsAnyUIElementHovered()
		{
			return false;
		}

		// Token: 0x0600134A RID: 4938 RVA: 0x0001934D File Offset: 0x0001754D
		public List<RaycastResult> GetHoveredUIElements()
		{
			return null;
		}

		// Token: 0x0600134B RID: 4939 RVA: 0x00019350 File Offset: 0x00017550
		public GameObject[] GetSceneObjects()
		{
			return null;
		}

		// Token: 0x0600134C RID: 4940 RVA: 0x00019353 File Offset: 0x00017553
		public bool OverlapBox(OBB obb, List<GameObject> gameObjects)
		{
			return false;
		}

		// Token: 0x0600134D RID: 4941 RVA: 0x00019356 File Offset: 0x00017556
		public bool OverlapBox(OBB obb, SceneOverlapFilter overlapFilter, List<GameObject> gameObjects)
		{
			return false;
		}

		// Token: 0x0600134E RID: 4942 RVA: 0x00019359 File Offset: 0x00017559
		public SceneRaycastHit Raycast(Ray ray, SceneRaycastPrecision rtRaycastPrecision, SceneRaycastFilter raycastFilter)
		{
			return null;
		}

		// Token: 0x0600134F RID: 4943 RVA: 0x0001935C File Offset: 0x0001755C
		public bool RaycastAllObjects(Ray ray, SceneRaycastPrecision rtRaycastPrecision, List<GameObjectRayHit> hits)
		{
			return false;
		}

		// Token: 0x06001350 RID: 4944 RVA: 0x0001935F File Offset: 0x0001755F
		public bool RaycastAllObjectsSorted(Ray ray, SceneRaycastPrecision raycastPresicion, List<GameObjectRayHit> hits)
		{
			return false;
		}

		// Token: 0x06001351 RID: 4945 RVA: 0x00019362 File Offset: 0x00017562
		public bool RaycastAllObjectsSorted(Ray ray, SceneRaycastPrecision rtRaycastPrecision, SceneRaycastFilter raycastFilter, List<GameObjectRayHit> hits)
		{
			return false;
		}

		// Token: 0x06001352 RID: 4946 RVA: 0x00019365 File Offset: 0x00017565
		public GameObjectRayHit RaycastMeshObject(Ray ray, GameObject meshObject)
		{
			return null;
		}

		// Token: 0x06001353 RID: 4947 RVA: 0x00019368 File Offset: 0x00017568
		public GameObjectRayHit RaycastMeshObjectReverseIfFail(Ray ray, GameObject meshObject)
		{
			return null;
		}

		// Token: 0x06001354 RID: 4948 RVA: 0x0001936B File Offset: 0x0001756B
		public GameObjectRayHit RaycastSpriteObject(Ray ray, GameObject spriteObject)
		{
			return null;
		}

		// Token: 0x06001355 RID: 4949 RVA: 0x0001936E File Offset: 0x0001756E
		public XZGridRayHit RaycastSceneGridIfVisible(Ray ray)
		{
			return null;
		}

		// Token: 0x06001356 RID: 4950 RVA: 0x00019371 File Offset: 0x00017571
		public void Update_SystemCall()
		{
		}

		// Token: 0x06001357 RID: 4951 RVA: 0x00019373 File Offset: 0x00017573
		public void Render_SystemCall(Camera renderCamera)
		{
		}

		// Token: 0x040006E5 RID: 1765
		public SceneCanRenderCameraIconHandler CanRenderCameraIcon;

		// Token: 0x040006E6 RID: 1766
		private YesNoAnswer _yesNoAnswer;

		// Token: 0x040006E7 RID: 1767
		private SceneSettings _settings;

		// Token: 0x040006E8 RID: 1768
		private SceneLookAndFeel _lookAndFeel;

		// Token: 0x040006E9 RID: 1769
		private List<Camera> _iconRenderIgnoreCamera;

		// Token: 0x040006EA RID: 1770
		private HashSet<GameObject> _ignoredRootObjects;

		// Token: 0x040006EB RID: 1771
		private List<IHoverableSceneEntityContainer> _hoverableSceneEntityContainers;

		// Token: 0x040006EC RID: 1772
		private SceneTree _sceneTree;

		// Token: 0x040006ED RID: 1773
		private List<GameObject> _rootGameObjects;

		// Token: 0x040006EE RID: 1774
		private List<Light> _lights;

		// Token: 0x040006EF RID: 1775
		private List<ParticleSystem> _particleSystems;

		// Token: 0x040006F0 RID: 1776
		private List<Camera> _cameras;

		// Token: 0x040006F1 RID: 1777
		private List<GameObject> _childrenAndSelfBuffer;

		// Token: 0x040006F2 RID: 1778
		private List<GameObjectRayHit> _objectHitBuffer;

		// Token: 0x020003A0 RID: 928
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06002AE4 RID: 10980 RVA: 0x0001D39F File Offset: 0x0001B59F
			internal bool <GetHoveredUIElements>b__26_0(RaycastResult item)
			{
				return false;
			}

			// Token: 0x04000F82 RID: 3970
			public static readonly RTScene.<>c <>9;

			// Token: 0x04000F83 RID: 3971
			public static Predicate<RaycastResult> <>9__26_0;
		}
	}
}
