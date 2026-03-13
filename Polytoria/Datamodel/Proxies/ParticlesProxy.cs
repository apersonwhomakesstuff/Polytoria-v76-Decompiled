using System;
using Polytoria.Controllers;
using Polytoria.Types;
using UnityEngine;

namespace Polytoria.Datamodel.Proxies
{
	// Token: 0x020002E9 RID: 745
	public class ParticlesProxy : DynamicInstanceProxy
	{
		// Token: 0x0600256F RID: 9583 RVA: 0x0001C32C File Offset: 0x0001A52C
		public ParticlesProxy(Particles target) : base(null)
		{
		}

		// Token: 0x17000B5F RID: 2911
		// (get) Token: 0x06002570 RID: 9584 RVA: 0x0001C335 File Offset: 0x0001A535
		// (set) Token: 0x06002571 RID: 9585 RVA: 0x0001C338 File Offset: 0x0001A538
		public string ImageID
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x17000B60 RID: 2912
		// (get) Token: 0x06002572 RID: 9586 RVA: 0x00025978 File Offset: 0x00023B78
		// (set) Token: 0x06002573 RID: 9587 RVA: 0x0001C33A File Offset: 0x0001A53A
		public ImageType ImageType
		{
			get
			{
				return ImageType.Asset;
			}
			set
			{
			}
		}

		// Token: 0x17000B61 RID: 2913
		// (get) Token: 0x06002574 RID: 9588 RVA: 0x00025990 File Offset: 0x00023B90
		// (set) Token: 0x06002575 RID: 9589 RVA: 0x0001C33C File Offset: 0x0001A53C
		public ColorRange Color
		{
			get
			{
				return default(ColorRange);
			}
			set
			{
			}
		}

		// Token: 0x17000B62 RID: 2914
		// (get) Token: 0x06002576 RID: 9590 RVA: 0x000259A8 File Offset: 0x00023BA8
		// (set) Token: 0x06002577 RID: 9591 RVA: 0x0001C33E File Offset: 0x0001A53E
		public ParticleColorMode ColorMode
		{
			get
			{
				return ParticleColorMode.Multiply;
			}
			set
			{
			}
		}

		// Token: 0x17000B63 RID: 2915
		// (get) Token: 0x06002578 RID: 9592 RVA: 0x000259C0 File Offset: 0x00023BC0
		// (set) Token: 0x06002579 RID: 9593 RVA: 0x0001C340 File Offset: 0x0001A540
		public NumberRange Lifetime
		{
			get
			{
				return default(NumberRange);
			}
			set
			{
			}
		}

		// Token: 0x17000B64 RID: 2916
		// (get) Token: 0x0600257A RID: 9594 RVA: 0x000259D8 File Offset: 0x00023BD8
		// (set) Token: 0x0600257B RID: 9595 RVA: 0x0001C342 File Offset: 0x0001A542
		public NumberRange SizeOverLifetime
		{
			get
			{
				return default(NumberRange);
			}
			set
			{
			}
		}

		// Token: 0x17000B65 RID: 2917
		// (get) Token: 0x0600257C RID: 9596 RVA: 0x000259F0 File Offset: 0x00023BF0
		// (set) Token: 0x0600257D RID: 9597 RVA: 0x0001C344 File Offset: 0x0001A544
		public NumberRange Speed
		{
			get
			{
				return default(NumberRange);
			}
			set
			{
			}
		}

		// Token: 0x17000B66 RID: 2918
		// (get) Token: 0x0600257E RID: 9598 RVA: 0x0001C346 File Offset: 0x0001A546
		// (set) Token: 0x0600257F RID: 9599 RVA: 0x0001C349 File Offset: 0x0001A549
		public int EmissionRate
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x17000B67 RID: 2919
		// (get) Token: 0x06002580 RID: 9600 RVA: 0x0001C34B File Offset: 0x0001A54B
		// (set) Token: 0x06002581 RID: 9601 RVA: 0x0001C34E File Offset: 0x0001A54E
		public int MaxParticles
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x17000B68 RID: 2920
		// (get) Token: 0x06002582 RID: 9602 RVA: 0x0001C350 File Offset: 0x0001A550
		// (set) Token: 0x06002583 RID: 9603 RVA: 0x0001C357 File Offset: 0x0001A557
		public float Gravity
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x17000B69 RID: 2921
		// (get) Token: 0x06002584 RID: 9604 RVA: 0x00025A08 File Offset: 0x00023C08
		// (set) Token: 0x06002585 RID: 9605 RVA: 0x0001C359 File Offset: 0x0001A559
		public ParticleSimulationSpace SimulationSpace
		{
			get
			{
				return ParticleSimulationSpace.Local;
			}
			set
			{
			}
		}

		// Token: 0x17000B6A RID: 2922
		// (get) Token: 0x06002586 RID: 9606 RVA: 0x00025A20 File Offset: 0x00023C20
		// (set) Token: 0x06002587 RID: 9607 RVA: 0x0001C35B File Offset: 0x0001A55B
		public NumberRange StartRotation
		{
			get
			{
				return default(NumberRange);
			}
			set
			{
			}
		}

		// Token: 0x17000B6B RID: 2923
		// (get) Token: 0x06002588 RID: 9608 RVA: 0x00025A38 File Offset: 0x00023C38
		// (set) Token: 0x06002589 RID: 9609 RVA: 0x0001C35D File Offset: 0x0001A55D
		public NumberRange AngularVelocity
		{
			get
			{
				return default(NumberRange);
			}
			set
			{
			}
		}

		// Token: 0x17000B6C RID: 2924
		// (get) Token: 0x0600258A RID: 9610 RVA: 0x0001C35F File Offset: 0x0001A55F
		// (set) Token: 0x0600258B RID: 9611 RVA: 0x0001C362 File Offset: 0x0001A562
		public bool Autoplay
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x17000B6D RID: 2925
		// (get) Token: 0x0600258C RID: 9612 RVA: 0x0001C364 File Offset: 0x0001A564
		// (set) Token: 0x0600258D RID: 9613 RVA: 0x0001C367 File Offset: 0x0001A567
		public bool Loop
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x17000B6E RID: 2926
		// (get) Token: 0x0600258E RID: 9614 RVA: 0x0001C369 File Offset: 0x0001A569
		// (set) Token: 0x0600258F RID: 9615 RVA: 0x0001C370 File Offset: 0x0001A570
		public float Duration
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x17000B6F RID: 2927
		// (get) Token: 0x06002590 RID: 9616 RVA: 0x00025A50 File Offset: 0x00023C50
		// (set) Token: 0x06002591 RID: 9617 RVA: 0x0001C372 File Offset: 0x0001A572
		public ParticleShape Shape
		{
			get
			{
				return ParticleShape.Sphere;
			}
			set
			{
			}
		}

		// Token: 0x17000B70 RID: 2928
		// (get) Token: 0x06002592 RID: 9618 RVA: 0x0001C374 File Offset: 0x0001A574
		// (set) Token: 0x06002593 RID: 9619 RVA: 0x0001C37B File Offset: 0x0001A57B
		public float ShapeRadius
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x17000B71 RID: 2929
		// (get) Token: 0x06002594 RID: 9620 RVA: 0x0001C37D File Offset: 0x0001A57D
		// (set) Token: 0x06002595 RID: 9621 RVA: 0x0001C384 File Offset: 0x0001A584
		public float ShapeAngle
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x17000B72 RID: 2930
		// (get) Token: 0x06002596 RID: 9622 RVA: 0x00025A68 File Offset: 0x00023C68
		// (set) Token: 0x06002597 RID: 9623 RVA: 0x0001C386 File Offset: 0x0001A586
		public Vector3 ShapeScale
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		// Token: 0x17000B73 RID: 2931
		// (get) Token: 0x06002598 RID: 9624 RVA: 0x0001C388 File Offset: 0x0001A588
		public bool IsPlaying
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000B74 RID: 2932
		// (get) Token: 0x06002599 RID: 9625 RVA: 0x0001C38B File Offset: 0x0001A58B
		public bool IsPaused
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000B75 RID: 2933
		// (get) Token: 0x0600259A RID: 9626 RVA: 0x0001C38E File Offset: 0x0001A58E
		public bool IsStopped
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000B76 RID: 2934
		// (get) Token: 0x0600259B RID: 9627 RVA: 0x0001C391 File Offset: 0x0001A591
		public int ParticleCount
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x17000B77 RID: 2935
		// (get) Token: 0x0600259C RID: 9628 RVA: 0x0001C394 File Offset: 0x0001A594
		public float Time
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000B78 RID: 2936
		// (get) Token: 0x0600259D RID: 9629 RVA: 0x0001C39B File Offset: 0x0001A59B
		public float TotalTime
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x0600259E RID: 9630 RVA: 0x0001C3A2 File Offset: 0x0001A5A2
		public void Play()
		{
		}

		// Token: 0x0600259F RID: 9631 RVA: 0x0001C3A4 File Offset: 0x0001A5A4
		public void Pause()
		{
		}

		// Token: 0x060025A0 RID: 9632 RVA: 0x0001C3A6 File Offset: 0x0001A5A6
		public void Stop()
		{
		}

		// Token: 0x060025A1 RID: 9633 RVA: 0x0001C3A8 File Offset: 0x0001A5A8
		public void Clear()
		{
		}

		// Token: 0x060025A2 RID: 9634 RVA: 0x0001C3AA File Offset: 0x0001A5AA
		public void Emit(int count)
		{
		}

		// Token: 0x060025A3 RID: 9635 RVA: 0x0001C3AC File Offset: 0x0001A5AC
		public void Simulate(float time)
		{
		}

		// Token: 0x04000D15 RID: 3349
		private readonly Particles particles;
	}
}
