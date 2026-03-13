using System;
using Polytoria.Lua;
using UnityEngine;

namespace Polytoria.Datamodel.Proxies
{
	// Token: 0x020002E7 RID: 743
	public class NPCProxy : DynamicInstanceProxy
	{
		// Token: 0x0600253F RID: 9535 RVA: 0x0001C2A5 File Offset: 0x0001A4A5
		public NPCProxy(NPC target) : base(null)
		{
		}

		// Token: 0x17000B49 RID: 2889
		// (get) Token: 0x06002540 RID: 9536 RVA: 0x0001C2AE File Offset: 0x0001A4AE
		public LuaEvent Died
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000B4A RID: 2890
		// (get) Token: 0x06002541 RID: 9537 RVA: 0x0001C2B1 File Offset: 0x0001A4B1
		// (set) Token: 0x06002542 RID: 9538 RVA: 0x0001C2B4 File Offset: 0x0001A4B4
		public Instance MoveTarget
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x17000B4B RID: 2891
		// (get) Token: 0x06002543 RID: 9539 RVA: 0x000258D0 File Offset: 0x00023AD0
		// (set) Token: 0x06002544 RID: 9540 RVA: 0x0001C2B6 File Offset: 0x0001A4B6
		public Color HeadColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		// Token: 0x17000B4C RID: 2892
		// (get) Token: 0x06002545 RID: 9541 RVA: 0x000258E8 File Offset: 0x00023AE8
		// (set) Token: 0x06002546 RID: 9542 RVA: 0x0001C2B8 File Offset: 0x0001A4B8
		public Color TorsoColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		// Token: 0x17000B4D RID: 2893
		// (get) Token: 0x06002547 RID: 9543 RVA: 0x00025900 File Offset: 0x00023B00
		// (set) Token: 0x06002548 RID: 9544 RVA: 0x0001C2BA File Offset: 0x0001A4BA
		public Color LeftArmColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		// Token: 0x17000B4E RID: 2894
		// (get) Token: 0x06002549 RID: 9545 RVA: 0x00025918 File Offset: 0x00023B18
		// (set) Token: 0x0600254A RID: 9546 RVA: 0x0001C2BC File Offset: 0x0001A4BC
		public Color RightArmColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		// Token: 0x17000B4F RID: 2895
		// (get) Token: 0x0600254B RID: 9547 RVA: 0x00025930 File Offset: 0x00023B30
		// (set) Token: 0x0600254C RID: 9548 RVA: 0x0001C2BE File Offset: 0x0001A4BE
		public Color LeftLegColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		// Token: 0x17000B50 RID: 2896
		// (get) Token: 0x0600254D RID: 9549 RVA: 0x00025948 File Offset: 0x00023B48
		// (set) Token: 0x0600254E RID: 9550 RVA: 0x0001C2C0 File Offset: 0x0001A4C0
		public Color RightLegColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		// Token: 0x17000B51 RID: 2897
		// (get) Token: 0x0600254F RID: 9551 RVA: 0x0001C2C2 File Offset: 0x0001A4C2
		// (set) Token: 0x06002550 RID: 9552 RVA: 0x0001C2C5 File Offset: 0x0001A4C5
		public bool Anchored
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x17000B52 RID: 2898
		// (get) Token: 0x06002551 RID: 9553 RVA: 0x0001C2C7 File Offset: 0x0001A4C7
		// (set) Token: 0x06002552 RID: 9554 RVA: 0x0001C2CE File Offset: 0x0001A4CE
		public float Health
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x17000B53 RID: 2899
		// (get) Token: 0x06002553 RID: 9555 RVA: 0x0001C2D0 File Offset: 0x0001A4D0
		// (set) Token: 0x06002554 RID: 9556 RVA: 0x0001C2D7 File Offset: 0x0001A4D7
		public float MaxHealth
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x17000B54 RID: 2900
		// (get) Token: 0x06002555 RID: 9557 RVA: 0x0001C2D9 File Offset: 0x0001A4D9
		// (set) Token: 0x06002556 RID: 9558 RVA: 0x0001C2DC File Offset: 0x0001A4DC
		public int ShirtID
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x17000B55 RID: 2901
		// (get) Token: 0x06002557 RID: 9559 RVA: 0x0001C2DE File Offset: 0x0001A4DE
		// (set) Token: 0x06002558 RID: 9560 RVA: 0x0001C2E1 File Offset: 0x0001A4E1
		public int PantsID
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x17000B56 RID: 2902
		// (get) Token: 0x06002559 RID: 9561 RVA: 0x0001C2E3 File Offset: 0x0001A4E3
		// (set) Token: 0x0600255A RID: 9562 RVA: 0x0001C2E6 File Offset: 0x0001A4E6
		public int FaceID
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x17000B57 RID: 2903
		// (get) Token: 0x0600255B RID: 9563 RVA: 0x0001C2E8 File Offset: 0x0001A4E8
		// (set) Token: 0x0600255C RID: 9564 RVA: 0x0001C2EF File Offset: 0x0001A4EF
		public float WalkSpeed
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x17000B58 RID: 2904
		// (get) Token: 0x0600255D RID: 9565 RVA: 0x0001C2F1 File Offset: 0x0001A4F1
		// (set) Token: 0x0600255E RID: 9566 RVA: 0x0001C2F8 File Offset: 0x0001A4F8
		public float JumpPower
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x17000B59 RID: 2905
		// (get) Token: 0x0600255F RID: 9567 RVA: 0x00025960 File Offset: 0x00023B60
		// (set) Token: 0x06002560 RID: 9568 RVA: 0x0001C2FA File Offset: 0x0001A4FA
		public Vector3 Velocity
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		// Token: 0x17000B5A RID: 2906
		// (get) Token: 0x06002561 RID: 9569 RVA: 0x0001C2FC File Offset: 0x0001A4FC
		public float NavDestinationDistance
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000B5B RID: 2907
		// (get) Token: 0x06002562 RID: 9570 RVA: 0x0001C303 File Offset: 0x0001A503
		public bool NavDestinationReached
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000B5C RID: 2908
		// (get) Token: 0x06002563 RID: 9571 RVA: 0x0001C306 File Offset: 0x0001A506
		public bool NavDestinationValid
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000B5D RID: 2909
		// (get) Token: 0x06002564 RID: 9572 RVA: 0x0001C309 File Offset: 0x0001A509
		public bool Grounded
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06002565 RID: 9573 RVA: 0x0001C30C File Offset: 0x0001A50C
		public void Respawn()
		{
		}

		// Token: 0x06002566 RID: 9574 RVA: 0x0001C30E File Offset: 0x0001A50E
		public void Jump()
		{
		}

		// Token: 0x06002567 RID: 9575 RVA: 0x0001C310 File Offset: 0x0001A510
		public void LoadAppearance(int userID)
		{
		}

		// Token: 0x06002568 RID: 9576 RVA: 0x0001C312 File Offset: 0x0001A512
		public void ClearAppearance()
		{
		}

		// Token: 0x06002569 RID: 9577 RVA: 0x0001C314 File Offset: 0x0001A514
		public void SetNavDestination(Vector3 destination)
		{
		}

		// Token: 0x0600256A RID: 9578 RVA: 0x0001C316 File Offset: 0x0001A516
		public void EquipTool(Tool tool)
		{
		}

		// Token: 0x0600256B RID: 9579 RVA: 0x0001C318 File Offset: 0x0001A518
		public void DropTool()
		{
		}

		// Token: 0x04000D13 RID: 3347
		private readonly NPC npc;
	}
}
