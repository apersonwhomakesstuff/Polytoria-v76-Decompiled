using System;

namespace Polytoria.Datamodel.Proxies
{
	// Token: 0x020002E3 RID: 739
	public class MeshPartProxy : PartProxy
	{
		// Token: 0x06002529 RID: 9513 RVA: 0x0001C256 File Offset: 0x0001A456
		public MeshPartProxy(MeshPart target) : base(null)
		{
		}

		// Token: 0x17000B42 RID: 2882
		// (get) Token: 0x0600252A RID: 9514 RVA: 0x0001C25F File Offset: 0x0001A45F
		// (set) Token: 0x0600252B RID: 9515 RVA: 0x0001C262 File Offset: 0x0001A462
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

		// Token: 0x17000B43 RID: 2883
		// (get) Token: 0x0600252C RID: 9516 RVA: 0x0001C264 File Offset: 0x0001A464
		public string CurrentAnimation
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000B44 RID: 2884
		// (get) Token: 0x0600252D RID: 9517 RVA: 0x0001C267 File Offset: 0x0001A467
		public bool IsAnimationPlaying
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000B45 RID: 2885
		// (get) Token: 0x0600252E RID: 9518 RVA: 0x0001C26A File Offset: 0x0001A46A
		// (set) Token: 0x0600252F RID: 9519 RVA: 0x0001C26D File Offset: 0x0001A46D
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

		// Token: 0x06002530 RID: 9520 RVA: 0x0001C26F File Offset: 0x0001A46F
		public void PlayAnimation(string animationName, string objectPath, float speed = 1f, bool loop = true)
		{
		}

		// Token: 0x06002531 RID: 9521 RVA: 0x0001C271 File Offset: 0x0001A471
		public void StopAnimation(string name = null)
		{
		}

		// Token: 0x06002532 RID: 9522 RVA: 0x0001C273 File Offset: 0x0001A473
		public string[] GetAnimations()
		{
			return null;
		}

		// Token: 0x06002533 RID: 9523 RVA: 0x0001C276 File Offset: 0x0001A476
		public string[] GetAnimationSources(string animationName)
		{
			return null;
		}

		// Token: 0x06002534 RID: 9524 RVA: 0x0001C279 File Offset: 0x0001A479
		public AnimationInfo[] GetAnimationInfo()
		{
			return null;
		}

		// Token: 0x17000B46 RID: 2886
		// (get) Token: 0x06002535 RID: 9525 RVA: 0x000258B8 File Offset: 0x00023AB8
		// (set) Token: 0x06002536 RID: 9526 RVA: 0x0001C27C File Offset: 0x0001A47C
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

		// Token: 0x04000D0F RID: 3343
		private readonly MeshPart meshPart;
	}
}
