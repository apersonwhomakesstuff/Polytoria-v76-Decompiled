using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Mirror;
using UnityEngine;

namespace Polytoria.Datamodel
{
	// Token: 0x0200028D RID: 653
	public class MeshPart : Part
	{
		// Token: 0x17000937 RID: 2359
		// (get) Token: 0x06001D2A RID: 7466 RVA: 0x0001ACFE File Offset: 0x00018EFE
		// (set) Token: 0x06001D2B RID: 7467 RVA: 0x0001AD01 File Offset: 0x00018F01
		public int AssetID
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x17000938 RID: 2360
		// (get) Token: 0x06001D2C RID: 7468 RVA: 0x00024748 File Offset: 0x00022948
		// (set) Token: 0x06001D2D RID: 7469 RVA: 0x0001AD03 File Offset: 0x00018F03
		public CollisionType CollisionType
		{
			get
			{
				return CollisionType.Bounds;
			}
			set
			{
			}
		}

		// Token: 0x17000939 RID: 2361
		// (get) Token: 0x06001D2E RID: 7470 RVA: 0x00024760 File Offset: 0x00022960
		public new PartShape Shape
		{
			get
			{
				return PartShape.Brick;
			}
		}

		// Token: 0x1700093A RID: 2362
		// (get) Token: 0x06001D2F RID: 7471 RVA: 0x00024778 File Offset: 0x00022978
		public new PartMaterial Material
		{
			get
			{
				return PartMaterial.SmoothPlastic;
			}
		}

		// Token: 0x1700093B RID: 2363
		// (get) Token: 0x06001D30 RID: 7472 RVA: 0x0001AD05 File Offset: 0x00018F05
		public string CurrentAnimation
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700093C RID: 2364
		// (get) Token: 0x06001D31 RID: 7473 RVA: 0x0001AD08 File Offset: 0x00018F08
		public bool IsAnimationPlaying
		{
			get
			{
				return false;
			}
		}

		// Token: 0x1700093D RID: 2365
		// (get) Token: 0x06001D32 RID: 7474 RVA: 0x0001AD0B File Offset: 0x00018F0B
		// (set) Token: 0x06001D33 RID: 7475 RVA: 0x0001AD0E File Offset: 0x00018F0E
		public bool PlayAnimationOnStart
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x1700093E RID: 2366
		// (get) Token: 0x06001D34 RID: 7476 RVA: 0x0001AD10 File Offset: 0x00018F10
		// (set) Token: 0x06001D35 RID: 7477 RVA: 0x0001AD13 File Offset: 0x00018F13
		public new bool CanCollide
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x06001D36 RID: 7478 RVA: 0x0001AD15 File Offset: 0x00018F15
		public void UpdateColliders()
		{
		}

		// Token: 0x06001D37 RID: 7479 RVA: 0x0001AD17 File Offset: 0x00018F17
		protected override void Awake()
		{
		}

		// Token: 0x06001D38 RID: 7480 RVA: 0x0001AD19 File Offset: 0x00018F19
		private void LoadMesh()
		{
		}

		// Token: 0x06001D39 RID: 7481 RVA: 0x0001AD1B File Offset: 0x00018F1B
		public void Hide()
		{
		}

		// Token: 0x06001D3A RID: 7482 RVA: 0x0001AD1D File Offset: 0x00018F1D
		private void RefreshAnimationComponents()
		{
		}

		// Token: 0x06001D3B RID: 7483 RVA: 0x0001AD1F File Offset: 0x00018F1F
		public void PlayAnimation(string name, string objectPath = "", float speed = 1f, bool loop = true)
		{
		}

		// Token: 0x06001D3C RID: 7484 RVA: 0x0001AD21 File Offset: 0x00018F21
		public void StopAnimation(string name = null)
		{
		}

		// Token: 0x06001D3D RID: 7485 RVA: 0x0001AD23 File Offset: 0x00018F23
		private void StopAllAnimations()
		{
		}

		// Token: 0x06001D3E RID: 7486 RVA: 0x0001AD25 File Offset: 0x00018F25
		public string[] GetAnimations()
		{
			return null;
		}

		// Token: 0x06001D3F RID: 7487 RVA: 0x0001AD28 File Offset: 0x00018F28
		public string[] GetAnimationSources(string animationName)
		{
			return null;
		}

		// Token: 0x06001D40 RID: 7488 RVA: 0x0001AD2B File Offset: 0x00018F2B
		public AnimationInfo[] GetAnimationInfo()
		{
			return null;
		}

		// Token: 0x06001D41 RID: 7489 RVA: 0x0001AD2E File Offset: 0x00018F2E
		private string GetRelativePath(Transform root, Transform target)
		{
			return null;
		}

		// Token: 0x06001D42 RID: 7490 RVA: 0x0001AD31 File Offset: 0x00018F31
		protected override void OnHide()
		{
		}

		// Token: 0x06001D43 RID: 7491 RVA: 0x0001AD33 File Offset: 0x00018F33
		protected override void OnShow()
		{
		}

		// Token: 0x06001D44 RID: 7492 RVA: 0x0001AD35 File Offset: 0x00018F35
		protected override void CopyProperties(Instance clone)
		{
		}

		// Token: 0x06001D45 RID: 7493 RVA: 0x0001AD37 File Offset: 0x00018F37
		private void RpcSetAssetID(int id)
		{
		}

		// Token: 0x06001D46 RID: 7494 RVA: 0x0001AD39 File Offset: 0x00018F39
		private void PlayAnimationOnStartChanged(bool oldValue, bool newValue)
		{
		}

		// Token: 0x06001D47 RID: 7495 RVA: 0x0001AD3B File Offset: 0x00018F3B
		private void CollisionTypeChanged(CollisionType oldValue, CollisionType newValue)
		{
		}

		// Token: 0x06001D48 RID: 7496 RVA: 0x0001AD3D File Offset: 0x00018F3D
		private void AssetIDChanged(int oldValue, int newValue)
		{
		}

		// Token: 0x06001D4A RID: 7498 RVA: 0x0001AD47 File Offset: 0x00018F47
		private void <LoadMesh>b__28_0()
		{
		}

		// Token: 0x06001D4B RID: 7499 RVA: 0x0001AD49 File Offset: 0x00018F49
		public override bool Weaved()
		{
			return false;
		}

		// Token: 0x1700093F RID: 2367
		// (get) Token: 0x06001D4C RID: 7500 RVA: 0x0001AD4C File Offset: 0x00018F4C
		// (set) Token: 0x06001D4D RID: 7501 RVA: 0x0001AD4F File Offset: 0x00018F4F
		public int NetworkassetID
		{
			get
			{
				return 0;
			}
			[param: In]
			set
			{
			}
		}

		// Token: 0x17000940 RID: 2368
		// (get) Token: 0x06001D4E RID: 7502 RVA: 0x0001AD51 File Offset: 0x00018F51
		// (set) Token: 0x06001D4F RID: 7503 RVA: 0x0001AD54 File Offset: 0x00018F54
		public bool NetworkplayAnimationOnStart
		{
			get
			{
				return false;
			}
			[param: In]
			set
			{
			}
		}

		// Token: 0x17000941 RID: 2369
		// (get) Token: 0x06001D50 RID: 7504 RVA: 0x00024790 File Offset: 0x00022990
		// (set) Token: 0x06001D51 RID: 7505 RVA: 0x0001AD56 File Offset: 0x00018F56
		public CollisionType NetworkcollisionType
		{
			get
			{
				return CollisionType.Bounds;
			}
			[param: In]
			set
			{
			}
		}

		// Token: 0x06001D52 RID: 7506 RVA: 0x0001AD58 File Offset: 0x00018F58
		protected void UserCode_RpcSetAssetID__Int32(int id)
		{
		}

		// Token: 0x06001D53 RID: 7507 RVA: 0x0001AD5A File Offset: 0x00018F5A
		protected static void InvokeUserCode_RpcSetAssetID__Int32(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		// Token: 0x06001D55 RID: 7509 RVA: 0x0001AD5E File Offset: 0x00018F5E
		public override void SerializeSyncVars(NetworkWriter writer, bool forceAll)
		{
		}

		// Token: 0x06001D56 RID: 7510 RVA: 0x0001AD60 File Offset: 0x00018F60
		public override void DeserializeSyncVars(NetworkReader reader, bool initialState)
		{
		}

		// Token: 0x04000AA1 RID: 2721
		protected int assetID;

		// Token: 0x04000AA2 RID: 2722
		private bool playAnimationOnStart;

		// Token: 0x04000AA3 RID: 2723
		private CollisionType collisionType;

		// Token: 0x04000AA4 RID: 2724
		private Animation anim;

		// Token: 0x04000AA5 RID: 2725
		private Dictionary<string, List<Animation>> animationsByName;

		// Token: 0x04000AA6 RID: 2726
		public Bounds defaultBounds;

		// Token: 0x04000AA7 RID: 2727
		public Action<int, int> _Mirror_SyncVarHookDelegate_assetID;

		// Token: 0x04000AA8 RID: 2728
		public Action<bool, bool> _Mirror_SyncVarHookDelegate_playAnimationOnStart;

		// Token: 0x04000AA9 RID: 2729
		public Action<CollisionType, CollisionType> _Mirror_SyncVarHookDelegate_collisionType;
	}
}
