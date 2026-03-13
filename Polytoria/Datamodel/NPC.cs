using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Mirror;
using Polytoria.Controllers;
using Polytoria.Lua;
using UnityEngine;
using UnityEngine.AI;

namespace Polytoria.Datamodel
{
	// Token: 0x02000295 RID: 661
	public class NPC : DynamicInstance, IToolHolder
	{
		// Token: 0x17000946 RID: 2374
		// (get) Token: 0x06001D8C RID: 7564 RVA: 0x0001AE2D File Offset: 0x0001902D
		public Transform ToolAttachmentPoint
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000947 RID: 2375
		// (get) Token: 0x06001D8D RID: 7565 RVA: 0x0001AE30 File Offset: 0x00019030
		// (set) Token: 0x06001D8E RID: 7566 RVA: 0x0001AE33 File Offset: 0x00019033
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

		// Token: 0x17000948 RID: 2376
		// (get) Token: 0x06001D8F RID: 7567 RVA: 0x000247F0 File Offset: 0x000229F0
		// (set) Token: 0x06001D90 RID: 7568 RVA: 0x0001AE35 File Offset: 0x00019035
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

		// Token: 0x17000949 RID: 2377
		// (get) Token: 0x06001D91 RID: 7569 RVA: 0x00024808 File Offset: 0x00022A08
		// (set) Token: 0x06001D92 RID: 7570 RVA: 0x0001AE37 File Offset: 0x00019037
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

		// Token: 0x1700094A RID: 2378
		// (get) Token: 0x06001D93 RID: 7571 RVA: 0x00024820 File Offset: 0x00022A20
		// (set) Token: 0x06001D94 RID: 7572 RVA: 0x0001AE39 File Offset: 0x00019039
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

		// Token: 0x1700094B RID: 2379
		// (get) Token: 0x06001D95 RID: 7573 RVA: 0x00024838 File Offset: 0x00022A38
		// (set) Token: 0x06001D96 RID: 7574 RVA: 0x0001AE3B File Offset: 0x0001903B
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

		// Token: 0x1700094C RID: 2380
		// (get) Token: 0x06001D97 RID: 7575 RVA: 0x00024850 File Offset: 0x00022A50
		// (set) Token: 0x06001D98 RID: 7576 RVA: 0x0001AE3D File Offset: 0x0001903D
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

		// Token: 0x1700094D RID: 2381
		// (get) Token: 0x06001D99 RID: 7577 RVA: 0x00024868 File Offset: 0x00022A68
		// (set) Token: 0x06001D9A RID: 7578 RVA: 0x0001AE3F File Offset: 0x0001903F
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

		// Token: 0x1700094E RID: 2382
		// (get) Token: 0x06001D9B RID: 7579 RVA: 0x0001AE41 File Offset: 0x00019041
		// (set) Token: 0x06001D9C RID: 7580 RVA: 0x0001AE44 File Offset: 0x00019044
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

		// Token: 0x1700094F RID: 2383
		// (get) Token: 0x06001D9D RID: 7581 RVA: 0x0001AE46 File Offset: 0x00019046
		public float NavDestinationDistance
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000950 RID: 2384
		// (get) Token: 0x06001D9E RID: 7582 RVA: 0x0001AE4D File Offset: 0x0001904D
		public bool NavDestinationReached
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000951 RID: 2385
		// (get) Token: 0x06001D9F RID: 7583 RVA: 0x0001AE50 File Offset: 0x00019050
		public bool NavDestinationValid
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000952 RID: 2386
		// (get) Token: 0x06001DA0 RID: 7584 RVA: 0x0001AE53 File Offset: 0x00019053
		// (set) Token: 0x06001DA1 RID: 7585 RVA: 0x0001AE5A File Offset: 0x0001905A
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

		// Token: 0x17000953 RID: 2387
		// (get) Token: 0x06001DA2 RID: 7586 RVA: 0x0001AE5C File Offset: 0x0001905C
		// (set) Token: 0x06001DA3 RID: 7587 RVA: 0x0001AE63 File Offset: 0x00019063
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

		// Token: 0x17000954 RID: 2388
		// (get) Token: 0x06001DA4 RID: 7588 RVA: 0x0001AE65 File Offset: 0x00019065
		// (set) Token: 0x06001DA5 RID: 7589 RVA: 0x0001AE6C File Offset: 0x0001906C
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

		// Token: 0x17000955 RID: 2389
		// (get) Token: 0x06001DA6 RID: 7590 RVA: 0x0001AE6E File Offset: 0x0001906E
		// (set) Token: 0x06001DA7 RID: 7591 RVA: 0x0001AE75 File Offset: 0x00019075
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

		// Token: 0x17000956 RID: 2390
		// (get) Token: 0x06001DA8 RID: 7592 RVA: 0x0001AE77 File Offset: 0x00019077
		// (set) Token: 0x06001DA9 RID: 7593 RVA: 0x0001AE7A File Offset: 0x0001907A
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

		// Token: 0x17000957 RID: 2391
		// (get) Token: 0x06001DAA RID: 7594 RVA: 0x0001AE7C File Offset: 0x0001907C
		// (set) Token: 0x06001DAB RID: 7595 RVA: 0x0001AE7F File Offset: 0x0001907F
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

		// Token: 0x17000958 RID: 2392
		// (get) Token: 0x06001DAC RID: 7596 RVA: 0x0001AE81 File Offset: 0x00019081
		// (set) Token: 0x06001DAD RID: 7597 RVA: 0x0001AE84 File Offset: 0x00019084
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

		// Token: 0x17000959 RID: 2393
		// (get) Token: 0x06001DAE RID: 7598 RVA: 0x00024880 File Offset: 0x00022A80
		// (set) Token: 0x06001DAF RID: 7599 RVA: 0x0001AE86 File Offset: 0x00019086
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

		// Token: 0x06001DB0 RID: 7600 RVA: 0x0001AE88 File Offset: 0x00019088
		private void RpcSetWalkSpeed(float walkSpeed)
		{
		}

		// Token: 0x1700095A RID: 2394
		// (get) Token: 0x06001DB1 RID: 7601 RVA: 0x0001AE8A File Offset: 0x0001908A
		public bool Grounded
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06001DB2 RID: 7602 RVA: 0x0001AE8D File Offset: 0x0001908D
		protected override void Awake()
		{
		}

		// Token: 0x06001DB3 RID: 7603 RVA: 0x0001AE8F File Offset: 0x0001908F
		protected override void OnNetworkStart()
		{
		}

		// Token: 0x06001DB4 RID: 7604 RVA: 0x0001AE91 File Offset: 0x00019091
		protected override void Start()
		{
		}

		// Token: 0x06001DB5 RID: 7605 RVA: 0x0001AE93 File Offset: 0x00019093
		public override void OnStartClient()
		{
		}

		// Token: 0x06001DB6 RID: 7606 RVA: 0x0001AE95 File Offset: 0x00019095
		protected override void Update()
		{
		}

		// Token: 0x06001DB7 RID: 7607 RVA: 0x0001AE97 File Offset: 0x00019097
		public void SetNavDestination(Vector3 pos)
		{
		}

		// Token: 0x06001DB8 RID: 7608 RVA: 0x0001AE99 File Offset: 0x00019099
		private void Die()
		{
		}

		// Token: 0x06001DB9 RID: 7609 RVA: 0x0001AE9B File Offset: 0x0001909B
		private void RpcSetAnimatorActive(bool active)
		{
		}

		// Token: 0x06001DBA RID: 7610 RVA: 0x0001AE9D File Offset: 0x0001909D
		private void SetAnimatorActive(bool active)
		{
		}

		// Token: 0x06001DBB RID: 7611 RVA: 0x0001AE9F File Offset: 0x0001909F
		public void Respawn()
		{
		}

		// Token: 0x06001DBC RID: 7612 RVA: 0x0001AEA1 File Offset: 0x000190A1
		private void FixedUpdate()
		{
		}

		// Token: 0x06001DBD RID: 7613 RVA: 0x0001AEA3 File Offset: 0x000190A3
		private void MoveDirection(Vector3 dir)
		{
		}

		// Token: 0x06001DBE RID: 7614 RVA: 0x0001AEA5 File Offset: 0x000190A5
		private void OnCollisionStay(Collision col)
		{
		}

		// Token: 0x06001DBF RID: 7615 RVA: 0x0001AEA7 File Offset: 0x000190A7
		private bool FindGround(out ContactPoint groundCP, List<ContactPoint> allCPs)
		{
			groundCP = default(ContactPoint);
			return false;
		}

		// Token: 0x06001DC0 RID: 7616 RVA: 0x0001AEB1 File Offset: 0x000190B1
		private bool FindStep(out Vector3 stepUpOffset, List<ContactPoint> allCPs, ContactPoint groundCP, Vector3 currVelocity)
		{
			stepUpOffset = default(Vector3);
			return false;
		}

		// Token: 0x06001DC1 RID: 7617 RVA: 0x0001AEBB File Offset: 0x000190BB
		private bool ResolveStepUp(out Vector3 stepUpOffset, ContactPoint stepTestCP, ContactPoint groundCP)
		{
			stepUpOffset = default(Vector3);
			return false;
		}

		// Token: 0x06001DC2 RID: 7618 RVA: 0x0001AEC5 File Offset: 0x000190C5
		private bool IsGrounded()
		{
			return false;
		}

		// Token: 0x06001DC3 RID: 7619 RVA: 0x0001AEC8 File Offset: 0x000190C8
		public void Jump()
		{
		}

		// Token: 0x06001DC4 RID: 7620 RVA: 0x0001AECA File Offset: 0x000190CA
		public void LoadAppearance(int userID)
		{
		}

		// Token: 0x06001DC5 RID: 7621 RVA: 0x0001AECC File Offset: 0x000190CC
		public void ClearAppearance()
		{
		}

		// Token: 0x06001DC6 RID: 7622 RVA: 0x0001AECE File Offset: 0x000190CE
		public Tool GetEquippedTool()
		{
			return null;
		}

		// Token: 0x06001DC7 RID: 7623 RVA: 0x0001AED1 File Offset: 0x000190D1
		public void EquipTool(Tool tool)
		{
		}

		// Token: 0x06001DC8 RID: 7624 RVA: 0x0001AED3 File Offset: 0x000190D3
		public void DropTool()
		{
		}

		// Token: 0x06001DC9 RID: 7625 RVA: 0x0001AED5 File Offset: 0x000190D5
		public void PlayAnim(string _anim)
		{
		}

		// Token: 0x06001DCA RID: 7626 RVA: 0x0001AED7 File Offset: 0x000190D7
		public void PlayAnimTargetRpc(string _anim)
		{
		}

		// Token: 0x06001DCB RID: 7627 RVA: 0x0001AED9 File Offset: 0x000190D9
		private void RpcJumpSound()
		{
		}

		// Token: 0x06001DCC RID: 7628 RVA: 0x0001AEDB File Offset: 0x000190DB
		protected override void CopyProperties(Instance clone)
		{
		}

		// Token: 0x06001DCD RID: 7629 RVA: 0x0001AEDD File Offset: 0x000190DD
		private void RpcSetAnchored(bool a)
		{
		}

		// Token: 0x06001DCE RID: 7630 RVA: 0x0001AEDF File Offset: 0x000190DF
		protected override void OnHide()
		{
		}

		// Token: 0x06001DCF RID: 7631 RVA: 0x0001AEE1 File Offset: 0x000190E1
		protected override void OnShow()
		{
		}

		// Token: 0x06001DD1 RID: 7633 RVA: 0x0001AEEB File Offset: 0x000190EB
		private void <set_ShirtID>b__79_0(ImageCacheKey key, ImageCacheEntry entry)
		{
		}

		// Token: 0x06001DD2 RID: 7634 RVA: 0x0001AEED File Offset: 0x000190ED
		private void <set_PantsID>b__82_0(ImageCacheKey key, ImageCacheEntry entry)
		{
		}

		// Token: 0x06001DD3 RID: 7635 RVA: 0x0001AEEF File Offset: 0x000190EF
		private void <set_FaceID>b__85_0(ImageCacheKey key, ImageCacheEntry entry)
		{
		}

		// Token: 0x06001DD4 RID: 7636 RVA: 0x0001AEF1 File Offset: 0x000190F1
		private void <OnNetworkStart>g__onLoad|95_0()
		{
		}

		// Token: 0x06001DD5 RID: 7637 RVA: 0x0001AEF3 File Offset: 0x000190F3
		public override bool Weaved()
		{
			return false;
		}

		// Token: 0x1700095B RID: 2395
		// (get) Token: 0x06001DD6 RID: 7638 RVA: 0x0001AEF6 File Offset: 0x000190F6
		// (set) Token: 0x06001DD7 RID: 7639 RVA: 0x0001AEFD File Offset: 0x000190FD
		public float NetworkmaxHealth
		{
			get
			{
				return 0f;
			}
			[param: In]
			set
			{
			}
		}

		// Token: 0x1700095C RID: 2396
		// (get) Token: 0x06001DD8 RID: 7640 RVA: 0x0001AEFF File Offset: 0x000190FF
		// (set) Token: 0x06001DD9 RID: 7641 RVA: 0x0001AF06 File Offset: 0x00019106
		public float Networkhealth
		{
			get
			{
				return 0f;
			}
			[param: In]
			set
			{
			}
		}

		// Token: 0x1700095D RID: 2397
		// (get) Token: 0x06001DDA RID: 7642 RVA: 0x0001AF08 File Offset: 0x00019108
		// (set) Token: 0x06001DDB RID: 7643 RVA: 0x0001AF0F File Offset: 0x0001910F
		public float NetworkwalkSpeed
		{
			get
			{
				return 0f;
			}
			[param: In]
			set
			{
			}
		}

		// Token: 0x1700095E RID: 2398
		// (get) Token: 0x06001DDC RID: 7644 RVA: 0x0001AF11 File Offset: 0x00019111
		// (set) Token: 0x06001DDD RID: 7645 RVA: 0x0001AF18 File Offset: 0x00019118
		public float NetworkjumpPower
		{
			get
			{
				return 0f;
			}
			[param: In]
			set
			{
			}
		}

		// Token: 0x1700095F RID: 2399
		// (get) Token: 0x06001DDE RID: 7646 RVA: 0x0001AF1A File Offset: 0x0001911A
		// (set) Token: 0x06001DDF RID: 7647 RVA: 0x0001AF1D File Offset: 0x0001911D
		public bool Networkanchored
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

		// Token: 0x17000960 RID: 2400
		// (get) Token: 0x06001DE0 RID: 7648 RVA: 0x0001AF1F File Offset: 0x0001911F
		// (set) Token: 0x06001DE1 RID: 7649 RVA: 0x0001AF22 File Offset: 0x00019122
		public bool Networkgrounded
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

		// Token: 0x06001DE2 RID: 7650 RVA: 0x0001AF24 File Offset: 0x00019124
		protected void UserCode_RpcSetWalkSpeed__Single(float walkSpeed)
		{
		}

		// Token: 0x06001DE3 RID: 7651 RVA: 0x0001AF26 File Offset: 0x00019126
		protected static void InvokeUserCode_RpcSetWalkSpeed__Single(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		// Token: 0x06001DE4 RID: 7652 RVA: 0x0001AF28 File Offset: 0x00019128
		protected void UserCode_RpcSetAnimatorActive__Boolean(bool active)
		{
		}

		// Token: 0x06001DE5 RID: 7653 RVA: 0x0001AF2A File Offset: 0x0001912A
		protected static void InvokeUserCode_RpcSetAnimatorActive__Boolean(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		// Token: 0x06001DE6 RID: 7654 RVA: 0x0001AF2C File Offset: 0x0001912C
		protected void UserCode_PlayAnimTargetRpc__String(string _anim)
		{
		}

		// Token: 0x06001DE7 RID: 7655 RVA: 0x0001AF2E File Offset: 0x0001912E
		protected static void InvokeUserCode_PlayAnimTargetRpc__String(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		// Token: 0x06001DE8 RID: 7656 RVA: 0x0001AF30 File Offset: 0x00019130
		protected void UserCode_RpcJumpSound()
		{
		}

		// Token: 0x06001DE9 RID: 7657 RVA: 0x0001AF32 File Offset: 0x00019132
		protected static void InvokeUserCode_RpcJumpSound(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		// Token: 0x06001DEA RID: 7658 RVA: 0x0001AF34 File Offset: 0x00019134
		protected void UserCode_RpcSetAnchored__Boolean(bool a)
		{
		}

		// Token: 0x06001DEB RID: 7659 RVA: 0x0001AF36 File Offset: 0x00019136
		protected static void InvokeUserCode_RpcSetAnchored__Boolean(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		// Token: 0x06001DED RID: 7661 RVA: 0x0001AF3A File Offset: 0x0001913A
		public override void SerializeSyncVars(NetworkWriter writer, bool forceAll)
		{
		}

		// Token: 0x06001DEE RID: 7662 RVA: 0x0001AF3C File Offset: 0x0001913C
		public override void DeserializeSyncVars(NetworkReader reader, bool initialState)
		{
		}

		// Token: 0x04000ABC RID: 2748
		private LayerMask ignoreLayer;

		// Token: 0x04000ABD RID: 2749
		private GameObject head;

		// Token: 0x04000ABE RID: 2750
		private GameObject torso;

		// Token: 0x04000ABF RID: 2751
		private GameObject leftArm;

		// Token: 0x04000AC0 RID: 2752
		private GameObject rightArm;

		// Token: 0x04000AC1 RID: 2753
		private GameObject leftLeg;

		// Token: 0x04000AC2 RID: 2754
		private GameObject rightLeg;

		// Token: 0x04000AC3 RID: 2755
		private List<Rigidbody> deathBodyParts;

		// Token: 0x04000AC4 RID: 2756
		private Transform toolAttachPoint;

		// Token: 0x04000AC5 RID: 2757
		private float maxHealth;

		// Token: 0x04000AC6 RID: 2758
		private float health;

		// Token: 0x04000AC7 RID: 2759
		private float walkSpeed;

		// Token: 0x04000AC8 RID: 2760
		private float jumpPower;

		// Token: 0x04000AC9 RID: 2761
		private int shirtID;

		// Token: 0x04000ACA RID: 2762
		private int pantsID;

		// Token: 0x04000ACB RID: 2763
		private int faceID;

		// Token: 0x04000ACC RID: 2764
		private bool anchored;

		// Token: 0x04000ACD RID: 2765
		private bool grounded;

		// Token: 0x04000ACE RID: 2766
		private Rigidbody rb;

		// Token: 0x04000ACF RID: 2767
		private Collider col;

		// Token: 0x04000AD0 RID: 2768
		private Animator anim;

		// Token: 0x04000AD1 RID: 2769
		private NetworkAnimator netAnim;

		// Token: 0x04000AD2 RID: 2770
		private NPCAppearance appearance;

		// Token: 0x04000AD3 RID: 2771
		private NavMeshAgent agent;

		// Token: 0x04000AD4 RID: 2772
		public float maxStepHeight;

		// Token: 0x04000AD5 RID: 2773
		public float stepSearchOvershoot;

		// Token: 0x04000AD6 RID: 2774
		private PhysicsMaterial airMaterial;

		// Token: 0x04000AD7 RID: 2775
		private PhysicsMaterial groundMaterial;

		// Token: 0x04000AD8 RID: 2776
		private float jumpCooldown;

		// Token: 0x04000AD9 RID: 2777
		private List<ContactPoint> allCPs;

		// Token: 0x04000ADA RID: 2778
		private Vector3 lastVelocity;

		// Token: 0x04000ADB RID: 2779
		private Dictionary<Rigidbody, Vector3> defaultBodyPartPos;

		// Token: 0x04000ADC RID: 2780
		private Instance moveTarget;

		// Token: 0x04000ADD RID: 2781
		public LuaEvent Died;

		// Token: 0x04000ADE RID: 2782
		private bool isDead;

		// Token: 0x020003ED RID: 1005
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06002BA1 RID: 11169 RVA: 0x0001D650 File Offset: 0x0001B850
			internal bool <IsGrounded>b__110_0(Collider i)
			{
				return false;
			}

			// Token: 0x0400109E RID: 4254
			public static readonly NPC.<>c <>9;

			// Token: 0x0400109F RID: 4255
			public static Func<Collider, bool> <>9__110_0;
		}
	}
}
