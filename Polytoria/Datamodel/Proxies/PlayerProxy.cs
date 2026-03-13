using System;
using MoonSharp.Interpreter;
using Polytoria.Lua;
using UnityEngine;

namespace Polytoria.Datamodel.Proxies
{
	// Token: 0x020002ED RID: 749
	public class PlayerProxy : InstanceProxy
	{
		// Token: 0x060025E4 RID: 9700 RVA: 0x0001C484 File Offset: 0x0001A684
		public PlayerProxy(Player target) : base(null)
		{
		}

		// Token: 0x17000B94 RID: 2964
		// (get) Token: 0x060025E5 RID: 9701 RVA: 0x0001C48D File Offset: 0x0001A68D
		// (set) Token: 0x060025E6 RID: 9702 RVA: 0x0001C494 File Offset: 0x0001A694
		public float RespawnTime
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x17000B95 RID: 2965
		// (get) Token: 0x060025E7 RID: 9703 RVA: 0x00025B10 File Offset: 0x00023D10
		// (set) Token: 0x060025E8 RID: 9704 RVA: 0x0001C496 File Offset: 0x0001A696
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

		// Token: 0x17000B96 RID: 2966
		// (get) Token: 0x060025E9 RID: 9705 RVA: 0x0001C498 File Offset: 0x0001A698
		// (set) Token: 0x060025EA RID: 9706 RVA: 0x0001C49F File Offset: 0x0001A69F
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

		// Token: 0x17000B97 RID: 2967
		// (get) Token: 0x060025EB RID: 9707 RVA: 0x0001C4A1 File Offset: 0x0001A6A1
		// (set) Token: 0x060025EC RID: 9708 RVA: 0x0001C4A8 File Offset: 0x0001A6A8
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

		// Token: 0x17000B98 RID: 2968
		// (get) Token: 0x060025ED RID: 9709 RVA: 0x0001C4AA File Offset: 0x0001A6AA
		// (set) Token: 0x060025EE RID: 9710 RVA: 0x0001C4B1 File Offset: 0x0001A6B1
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

		// Token: 0x17000B99 RID: 2969
		// (get) Token: 0x060025EF RID: 9711 RVA: 0x0001C4B3 File Offset: 0x0001A6B3
		// (set) Token: 0x060025F0 RID: 9712 RVA: 0x0001C4BA File Offset: 0x0001A6BA
		public float SprintSpeed
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x17000B9A RID: 2970
		// (get) Token: 0x060025F1 RID: 9713 RVA: 0x0001C4BC File Offset: 0x0001A6BC
		// (set) Token: 0x060025F2 RID: 9714 RVA: 0x0001C4BF File Offset: 0x0001A6BF
		public bool StaminaEnabled
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x17000B9B RID: 2971
		// (get) Token: 0x060025F3 RID: 9715 RVA: 0x0001C4C1 File Offset: 0x0001A6C1
		// (set) Token: 0x060025F4 RID: 9716 RVA: 0x0001C4C8 File Offset: 0x0001A6C8
		public float Stamina
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x17000B9C RID: 2972
		// (get) Token: 0x060025F5 RID: 9717 RVA: 0x0001C4CA File Offset: 0x0001A6CA
		// (set) Token: 0x060025F6 RID: 9718 RVA: 0x0001C4D1 File Offset: 0x0001A6D1
		public float MaxStamina
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x17000B9D RID: 2973
		// (get) Token: 0x060025F7 RID: 9719 RVA: 0x0001C4D3 File Offset: 0x0001A6D3
		// (set) Token: 0x060025F8 RID: 9720 RVA: 0x0001C4DA File Offset: 0x0001A6DA
		public float StaminaRegen
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x17000B9E RID: 2974
		// (get) Token: 0x060025F9 RID: 9721 RVA: 0x0001C4DC File Offset: 0x0001A6DC
		// (set) Token: 0x060025FA RID: 9722 RVA: 0x0001C4E3 File Offset: 0x0001A6E3
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

		// Token: 0x17000B9F RID: 2975
		// (get) Token: 0x060025FB RID: 9723 RVA: 0x00025B28 File Offset: 0x00023D28
		// (set) Token: 0x060025FC RID: 9724 RVA: 0x0001C4E5 File Offset: 0x0001A6E5
		public Vector3 Position
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		// Token: 0x17000BA0 RID: 2976
		// (get) Token: 0x060025FD RID: 9725 RVA: 0x00025B40 File Offset: 0x00023D40
		// (set) Token: 0x060025FE RID: 9726 RVA: 0x0001C4E7 File Offset: 0x0001A6E7
		public Vector3 Rotation
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		// Token: 0x17000BA1 RID: 2977
		// (get) Token: 0x060025FF RID: 9727 RVA: 0x00025B58 File Offset: 0x00023D58
		// (set) Token: 0x06002600 RID: 9728 RVA: 0x0001C4E9 File Offset: 0x0001A6E9
		public Vector3 Size
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		// Token: 0x17000BA2 RID: 2978
		// (get) Token: 0x06002601 RID: 9729 RVA: 0x00025B70 File Offset: 0x00023D70
		// (set) Token: 0x06002602 RID: 9730 RVA: 0x0001C4EB File Offset: 0x0001A6EB
		public Color ChatColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		// Token: 0x17000BA3 RID: 2979
		// (get) Token: 0x06002603 RID: 9731 RVA: 0x0001C4ED File Offset: 0x0001A6ED
		// (set) Token: 0x06002604 RID: 9732 RVA: 0x0001C4F0 File Offset: 0x0001A6F0
		public bool CanMove
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x17000BA4 RID: 2980
		// (get) Token: 0x06002605 RID: 9733 RVA: 0x0001C4F2 File Offset: 0x0001A6F2
		// (set) Token: 0x06002606 RID: 9734 RVA: 0x0001C4F5 File Offset: 0x0001A6F5
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

		// Token: 0x17000BA5 RID: 2981
		// (get) Token: 0x06002607 RID: 9735 RVA: 0x00025B88 File Offset: 0x00023D88
		// (set) Token: 0x06002608 RID: 9736 RVA: 0x0001C4F7 File Offset: 0x0001A6F7
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

		// Token: 0x17000BA6 RID: 2982
		// (get) Token: 0x06002609 RID: 9737 RVA: 0x00025BA0 File Offset: 0x00023DA0
		// (set) Token: 0x0600260A RID: 9738 RVA: 0x0001C4F9 File Offset: 0x0001A6F9
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

		// Token: 0x17000BA7 RID: 2983
		// (get) Token: 0x0600260B RID: 9739 RVA: 0x00025BB8 File Offset: 0x00023DB8
		// (set) Token: 0x0600260C RID: 9740 RVA: 0x0001C4FB File Offset: 0x0001A6FB
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

		// Token: 0x17000BA8 RID: 2984
		// (get) Token: 0x0600260D RID: 9741 RVA: 0x00025BD0 File Offset: 0x00023DD0
		// (set) Token: 0x0600260E RID: 9742 RVA: 0x0001C4FD File Offset: 0x0001A6FD
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

		// Token: 0x17000BA9 RID: 2985
		// (get) Token: 0x0600260F RID: 9743 RVA: 0x00025BE8 File Offset: 0x00023DE8
		// (set) Token: 0x06002610 RID: 9744 RVA: 0x0001C4FF File Offset: 0x0001A6FF
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

		// Token: 0x17000BAA RID: 2986
		// (get) Token: 0x06002611 RID: 9745 RVA: 0x00025C00 File Offset: 0x00023E00
		// (set) Token: 0x06002612 RID: 9746 RVA: 0x0001C501 File Offset: 0x0001A701
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

		// Token: 0x17000BAB RID: 2987
		// (get) Token: 0x06002613 RID: 9747 RVA: 0x0001C503 File Offset: 0x0001A703
		// (set) Token: 0x06002614 RID: 9748 RVA: 0x0001C506 File Offset: 0x0001A706
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

		// Token: 0x17000BAC RID: 2988
		// (get) Token: 0x06002615 RID: 9749 RVA: 0x0001C508 File Offset: 0x0001A708
		// (set) Token: 0x06002616 RID: 9750 RVA: 0x0001C50B File Offset: 0x0001A70B
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

		// Token: 0x17000BAD RID: 2989
		// (get) Token: 0x06002617 RID: 9751 RVA: 0x0001C50D File Offset: 0x0001A70D
		// (set) Token: 0x06002618 RID: 9752 RVA: 0x0001C510 File Offset: 0x0001A710
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

		// Token: 0x17000BAE RID: 2990
		// (get) Token: 0x06002619 RID: 9753 RVA: 0x0001C512 File Offset: 0x0001A712
		public bool IsInputFocused
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000BAF RID: 2991
		// (get) Token: 0x0600261A RID: 9754 RVA: 0x0001C515 File Offset: 0x0001A715
		public Seat SittingIn
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000BB0 RID: 2992
		// (get) Token: 0x0600261B RID: 9755 RVA: 0x00025C18 File Offset: 0x00023E18
		public Vector3 Forward
		{
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x17000BB1 RID: 2993
		// (get) Token: 0x0600261C RID: 9756 RVA: 0x00025C30 File Offset: 0x00023E30
		public Vector3 Right
		{
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x17000BB2 RID: 2994
		// (get) Token: 0x0600261D RID: 9757 RVA: 0x0001C518 File Offset: 0x0001A718
		public bool IsAdmin
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000BB3 RID: 2995
		// (get) Token: 0x0600261E RID: 9758 RVA: 0x0001C51B File Offset: 0x0001A71B
		public bool IsCreator
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000BB4 RID: 2996
		// (get) Token: 0x0600261F RID: 9759 RVA: 0x0001C51E File Offset: 0x0001A71E
		public int UserID
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x17000BB5 RID: 2997
		// (get) Token: 0x06002620 RID: 9760 RVA: 0x0001C521 File Offset: 0x0001A721
		public LuaEvent Chatted
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000BB6 RID: 2998
		// (get) Token: 0x06002621 RID: 9761 RVA: 0x0001C524 File Offset: 0x0001A724
		public LuaEvent Died
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000BB7 RID: 2999
		// (get) Token: 0x06002622 RID: 9762 RVA: 0x0001C527 File Offset: 0x0001A727
		public LuaEvent Respawned
		{
			get
			{
				return null;
			}
		}

		// Token: 0x06002623 RID: 9763 RVA: 0x0001C52A File Offset: 0x0001A72A
		public void OwnsItem(int assetId, DynValue callback)
		{
		}

		// Token: 0x06002624 RID: 9764 RVA: 0x0001C52C File Offset: 0x0001A72C
		public void Kick(string reason = "You have been kicked from the server.")
		{
		}

		// Token: 0x06002625 RID: 9765 RVA: 0x0001C52E File Offset: 0x0001A72E
		public void Sit(Seat seat)
		{
		}

		// Token: 0x06002626 RID: 9766 RVA: 0x0001C530 File Offset: 0x0001A730
		public void Unsit(bool addForce = true)
		{
		}

		// Token: 0x06002627 RID: 9767 RVA: 0x0001C532 File Offset: 0x0001A732
		public void Respawn()
		{
		}

		// Token: 0x06002628 RID: 9768 RVA: 0x0001C534 File Offset: 0x0001A734
		public void LoadAppearance(int userID)
		{
		}

		// Token: 0x06002629 RID: 9769 RVA: 0x0001C536 File Offset: 0x0001A736
		public void ClearAppearance()
		{
		}

		// Token: 0x0600262A RID: 9770 RVA: 0x0001C538 File Offset: 0x0001A738
		public void ResetAppearance()
		{
		}

		// Token: 0x0600262B RID: 9771 RVA: 0x0001C53A File Offset: 0x0001A73A
		public void LookAt(Vector3 lookTarget, Vector3 worldUp)
		{
		}

		// Token: 0x0600262C RID: 9772 RVA: 0x0001C53C File Offset: 0x0001A73C
		public void LookAt(Vector3 lookTarget)
		{
		}

		// Token: 0x0600262D RID: 9773 RVA: 0x0001C53E File Offset: 0x0001A73E
		public void LookAt(DynamicInstance instance)
		{
		}

		// Token: 0x0600262E RID: 9774 RVA: 0x0001C540 File Offset: 0x0001A740
		public void Translate(Vector3 translation)
		{
		}

		// Token: 0x0600262F RID: 9775 RVA: 0x0001C542 File Offset: 0x0001A742
		public void RotateAround(Vector3 point, Vector3 axis, float angle)
		{
		}

		// Token: 0x06002630 RID: 9776 RVA: 0x0001C544 File Offset: 0x0001A744
		public void Rotate(Vector3 eulerAngles)
		{
		}

		// Token: 0x06002631 RID: 9777 RVA: 0x00025C48 File Offset: 0x00023E48
		public Vector3 InverseTransformPoint(Vector3 point)
		{
			return default(Vector3);
		}

		// Token: 0x06002632 RID: 9778 RVA: 0x00025C60 File Offset: 0x00023E60
		public Vector3 TransformPoint(Vector3 point)
		{
			return default(Vector3);
		}

		// Token: 0x06002633 RID: 9779 RVA: 0x00025C78 File Offset: 0x00023E78
		public Vector3 InverseTransformDirection(Vector3 direction)
		{
			return default(Vector3);
		}

		// Token: 0x06002634 RID: 9780 RVA: 0x00025C90 File Offset: 0x00023E90
		public Vector3 TransformDirection(Vector3 direction)
		{
			return default(Vector3);
		}

		// Token: 0x06002635 RID: 9781 RVA: 0x00025CA8 File Offset: 0x00023EA8
		public Vector3 InverseTransformVector(Vector3 vector)
		{
			return default(Vector3);
		}

		// Token: 0x06002636 RID: 9782 RVA: 0x00025CC0 File Offset: 0x00023EC0
		public Vector3 TransformVector(Vector3 vector)
		{
			return default(Vector3);
		}

		// Token: 0x04000D19 RID: 3353
		private readonly Player player;
	}
}
