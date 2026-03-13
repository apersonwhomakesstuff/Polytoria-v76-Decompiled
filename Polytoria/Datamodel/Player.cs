using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Mirror;
using MoonSharp.Interpreter;
using Polytoria.Controllers;
using Polytoria.Datamodel.Services;
using Polytoria.Lua;
using Polytoria.Types;
using TMPro;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.Networking;

namespace Polytoria.Datamodel
{
	// Token: 0x0200029E RID: 670
	public class Player : Instance, IToolHolder
	{
		// Token: 0x170009B2 RID: 2482
		// (get) Token: 0x06001F11 RID: 7953 RVA: 0x0001B1D7 File Offset: 0x000193D7
		public bool IsLocalPlayer
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170009B3 RID: 2483
		// (get) Token: 0x06001F12 RID: 7954 RVA: 0x0001B1DA File Offset: 0x000193DA
		public bool IsLoaded
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170009B4 RID: 2484
		// (get) Token: 0x06001F13 RID: 7955 RVA: 0x0001B1DD File Offset: 0x000193DD
		// (set) Token: 0x06001F14 RID: 7956 RVA: 0x0001B1E4 File Offset: 0x000193E4
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

		// Token: 0x170009B5 RID: 2485
		// (get) Token: 0x06001F15 RID: 7957 RVA: 0x00024BE0 File Offset: 0x00022DE0
		// (set) Token: 0x06001F16 RID: 7958 RVA: 0x0001B1E6 File Offset: 0x000193E6
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

		// Token: 0x170009B6 RID: 2486
		// (get) Token: 0x06001F17 RID: 7959 RVA: 0x0001B1E8 File Offset: 0x000193E8
		// (set) Token: 0x06001F18 RID: 7960 RVA: 0x0001B1EF File Offset: 0x000193EF
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

		// Token: 0x170009B7 RID: 2487
		// (get) Token: 0x06001F19 RID: 7961 RVA: 0x0001B1F1 File Offset: 0x000193F1
		// (set) Token: 0x06001F1A RID: 7962 RVA: 0x0001B1F8 File Offset: 0x000193F8
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

		// Token: 0x170009B8 RID: 2488
		// (get) Token: 0x06001F1B RID: 7963 RVA: 0x0001B1FA File Offset: 0x000193FA
		// (set) Token: 0x06001F1C RID: 7964 RVA: 0x0001B201 File Offset: 0x00019401
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

		// Token: 0x170009B9 RID: 2489
		// (get) Token: 0x06001F1D RID: 7965 RVA: 0x0001B203 File Offset: 0x00019403
		// (set) Token: 0x06001F1E RID: 7966 RVA: 0x0001B20A File Offset: 0x0001940A
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

		// Token: 0x170009BA RID: 2490
		// (get) Token: 0x06001F1F RID: 7967 RVA: 0x0001B20C File Offset: 0x0001940C
		// (set) Token: 0x06001F20 RID: 7968 RVA: 0x0001B20F File Offset: 0x0001940F
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

		// Token: 0x170009BB RID: 2491
		// (get) Token: 0x06001F21 RID: 7969 RVA: 0x0001B211 File Offset: 0x00019411
		// (set) Token: 0x06001F22 RID: 7970 RVA: 0x0001B218 File Offset: 0x00019418
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

		// Token: 0x170009BC RID: 2492
		// (get) Token: 0x06001F23 RID: 7971 RVA: 0x0001B21A File Offset: 0x0001941A
		// (set) Token: 0x06001F24 RID: 7972 RVA: 0x0001B221 File Offset: 0x00019421
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

		// Token: 0x170009BD RID: 2493
		// (get) Token: 0x06001F25 RID: 7973 RVA: 0x0001B223 File Offset: 0x00019423
		// (set) Token: 0x06001F26 RID: 7974 RVA: 0x0001B22A File Offset: 0x0001942A
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

		// Token: 0x170009BE RID: 2494
		// (get) Token: 0x06001F27 RID: 7975 RVA: 0x0001B22C File Offset: 0x0001942C
		// (set) Token: 0x06001F28 RID: 7976 RVA: 0x0001B233 File Offset: 0x00019433
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

		// Token: 0x170009BF RID: 2495
		// (get) Token: 0x06001F29 RID: 7977 RVA: 0x00024BF8 File Offset: 0x00022DF8
		// (set) Token: 0x06001F2A RID: 7978 RVA: 0x0001B235 File Offset: 0x00019435
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

		// Token: 0x170009C0 RID: 2496
		// (get) Token: 0x06001F2B RID: 7979 RVA: 0x00024C10 File Offset: 0x00022E10
		// (set) Token: 0x06001F2C RID: 7980 RVA: 0x0001B237 File Offset: 0x00019437
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

		// Token: 0x170009C1 RID: 2497
		// (get) Token: 0x06001F2D RID: 7981 RVA: 0x00024C28 File Offset: 0x00022E28
		// (set) Token: 0x06001F2E RID: 7982 RVA: 0x0001B239 File Offset: 0x00019439
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

		// Token: 0x170009C2 RID: 2498
		// (get) Token: 0x06001F2F RID: 7983 RVA: 0x00024C40 File Offset: 0x00022E40
		// (set) Token: 0x06001F30 RID: 7984 RVA: 0x0001B23B File Offset: 0x0001943B
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

		// Token: 0x170009C3 RID: 2499
		// (get) Token: 0x06001F31 RID: 7985 RVA: 0x0001B23D File Offset: 0x0001943D
		// (set) Token: 0x06001F32 RID: 7986 RVA: 0x0001B240 File Offset: 0x00019440
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

		// Token: 0x170009C4 RID: 2500
		// (get) Token: 0x06001F33 RID: 7987 RVA: 0x0001B242 File Offset: 0x00019442
		// (set) Token: 0x06001F34 RID: 7988 RVA: 0x0001B245 File Offset: 0x00019445
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

		// Token: 0x170009C5 RID: 2501
		// (get) Token: 0x06001F35 RID: 7989 RVA: 0x0001B247 File Offset: 0x00019447
		public bool IsInputFocused
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170009C6 RID: 2502
		// (get) Token: 0x06001F36 RID: 7990 RVA: 0x0001B24A File Offset: 0x0001944A
		public string AvatarHash
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170009C7 RID: 2503
		// (get) Token: 0x06001F37 RID: 7991 RVA: 0x0001B24D File Offset: 0x0001944D
		public Seat SittingIn
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170009C8 RID: 2504
		// (get) Token: 0x06001F38 RID: 7992 RVA: 0x00024C58 File Offset: 0x00022E58
		public Vector3 Forward
		{
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x170009C9 RID: 2505
		// (get) Token: 0x06001F39 RID: 7993 RVA: 0x00024C70 File Offset: 0x00022E70
		public Vector3 Right
		{
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x170009CA RID: 2506
		// (get) Token: 0x06001F3A RID: 7994 RVA: 0x0001B250 File Offset: 0x00019450
		public bool IsAdmin
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170009CB RID: 2507
		// (get) Token: 0x06001F3B RID: 7995 RVA: 0x0001B253 File Offset: 0x00019453
		public bool IsCreator
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170009CC RID: 2508
		// (get) Token: 0x06001F3C RID: 7996 RVA: 0x0001B256 File Offset: 0x00019456
		private bool IsSitting
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170009CD RID: 2509
		// (get) Token: 0x06001F3D RID: 7997 RVA: 0x0001B259 File Offset: 0x00019459
		private bool IsMovementAllowed
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170009CE RID: 2510
		// (get) Token: 0x06001F3E RID: 7998 RVA: 0x0001B25C File Offset: 0x0001945C
		// (set) Token: 0x06001F3F RID: 7999 RVA: 0x0001B25F File Offset: 0x0001945F
		public int UserID
		{
			get
			{
				return 0;
			}
			private set
			{
			}
		}

		// Token: 0x170009CF RID: 2511
		// (get) Token: 0x06001F40 RID: 8000 RVA: 0x00024C88 File Offset: 0x00022E88
		// (set) Token: 0x06001F41 RID: 8001 RVA: 0x0001B261 File Offset: 0x00019461
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

		// Token: 0x170009D0 RID: 2512
		// (get) Token: 0x06001F42 RID: 8002 RVA: 0x00024CA0 File Offset: 0x00022EA0
		// (set) Token: 0x06001F43 RID: 8003 RVA: 0x0001B263 File Offset: 0x00019463
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

		// Token: 0x170009D1 RID: 2513
		// (get) Token: 0x06001F44 RID: 8004 RVA: 0x00024CB8 File Offset: 0x00022EB8
		// (set) Token: 0x06001F45 RID: 8005 RVA: 0x0001B265 File Offset: 0x00019465
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

		// Token: 0x170009D2 RID: 2514
		// (get) Token: 0x06001F46 RID: 8006 RVA: 0x00024CD0 File Offset: 0x00022ED0
		// (set) Token: 0x06001F47 RID: 8007 RVA: 0x0001B267 File Offset: 0x00019467
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

		// Token: 0x170009D3 RID: 2515
		// (get) Token: 0x06001F48 RID: 8008 RVA: 0x00024CE8 File Offset: 0x00022EE8
		// (set) Token: 0x06001F49 RID: 8009 RVA: 0x0001B269 File Offset: 0x00019469
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

		// Token: 0x170009D4 RID: 2516
		// (get) Token: 0x06001F4A RID: 8010 RVA: 0x00024D00 File Offset: 0x00022F00
		// (set) Token: 0x06001F4B RID: 8011 RVA: 0x0001B26B File Offset: 0x0001946B
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

		// Token: 0x170009D5 RID: 2517
		// (get) Token: 0x06001F4C RID: 8012 RVA: 0x0001B26D File Offset: 0x0001946D
		// (set) Token: 0x06001F4D RID: 8013 RVA: 0x0001B270 File Offset: 0x00019470
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

		// Token: 0x170009D6 RID: 2518
		// (get) Token: 0x06001F4E RID: 8014 RVA: 0x0001B272 File Offset: 0x00019472
		// (set) Token: 0x06001F4F RID: 8015 RVA: 0x0001B275 File Offset: 0x00019475
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

		// Token: 0x170009D7 RID: 2519
		// (get) Token: 0x06001F50 RID: 8016 RVA: 0x0001B277 File Offset: 0x00019477
		// (set) Token: 0x06001F51 RID: 8017 RVA: 0x0001B27A File Offset: 0x0001947A
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

		// Token: 0x170009D8 RID: 2520
		// (get) Token: 0x06001F52 RID: 8018 RVA: 0x0001B27C File Offset: 0x0001947C
		public Transform ToolAttachmentPoint
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170009D9 RID: 2521
		// (get) Token: 0x06001F53 RID: 8019 RVA: 0x0001B27F File Offset: 0x0001947F
		// (set) Token: 0x06001F54 RID: 8020 RVA: 0x0001B282 File Offset: 0x00019482
		private Camera Camera
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x06001F55 RID: 8021 RVA: 0x0001B284 File Offset: 0x00019484
		protected override void Awake()
		{
		}

		// Token: 0x06001F56 RID: 8022 RVA: 0x0001B286 File Offset: 0x00019486
		protected override void Start()
		{
		}

		// Token: 0x06001F57 RID: 8023 RVA: 0x0001B288 File Offset: 0x00019488
		private void Update()
		{
		}

		// Token: 0x06001F58 RID: 8024 RVA: 0x0001B28A File Offset: 0x0001948A
		private void FixedUpdate()
		{
		}

		// Token: 0x06001F59 RID: 8025 RVA: 0x0001B28C File Offset: 0x0001948C
		private void Move(float hor, float ver)
		{
		}

		// Token: 0x06001F5A RID: 8026 RVA: 0x0001B28E File Offset: 0x0001948E
		public void PlayAnim(string _anim)
		{
		}

		// Token: 0x06001F5B RID: 8027 RVA: 0x0001B290 File Offset: 0x00019490
		public void PlayAnimTargetRpc(string _anim)
		{
		}

		// Token: 0x06001F5C RID: 8028 RVA: 0x0001B292 File Offset: 0x00019492
		private void SetChildLayers(Transform root, LayerMask layer)
		{
		}

		// Token: 0x06001F5D RID: 8029 RVA: 0x0001B294 File Offset: 0x00019494
		private IEnumerator PostPlayerLoad()
		{
			return null;
		}

		// Token: 0x06001F5E RID: 8030 RVA: 0x0001B297 File Offset: 0x00019497
		private IEnumerator DiscordLoop()
		{
			return null;
		}

		// Token: 0x06001F5F RID: 8031 RVA: 0x0001B29A File Offset: 0x0001949A
		private void NotifyJoin()
		{
		}

		// Token: 0x06001F60 RID: 8032 RVA: 0x0001B29C File Offset: 0x0001949C
		public void OwnsItem(int assetId, DynValue callback)
		{
		}

		// Token: 0x06001F61 RID: 8033 RVA: 0x0001B29E File Offset: 0x0001949E
		private void OnCollisionStay(Collision col)
		{
		}

		// Token: 0x06001F62 RID: 8034 RVA: 0x0001B2A0 File Offset: 0x000194A0
		protected override void OnCollisionExit(Collision col)
		{
		}

		// Token: 0x06001F63 RID: 8035 RVA: 0x0001B2A2 File Offset: 0x000194A2
		private bool FindGround(out ContactPoint groundCP, List<ContactPoint> allCPs)
		{
			groundCP = default(ContactPoint);
			return false;
		}

		// Token: 0x06001F64 RID: 8036 RVA: 0x0001B2AC File Offset: 0x000194AC
		private bool FindStep(out Vector3 stepUpOffset, List<ContactPoint> allCPs, ContactPoint groundCP, Vector3 currVelocity)
		{
			stepUpOffset = default(Vector3);
			return false;
		}

		// Token: 0x06001F65 RID: 8037 RVA: 0x0001B2B6 File Offset: 0x000194B6
		private bool ResolveStepUp(out Vector3 stepUpOffset, ContactPoint stepTestCP, ContactPoint groundCP)
		{
			stepUpOffset = default(Vector3);
			return false;
		}

		// Token: 0x06001F66 RID: 8038 RVA: 0x0001B2C0 File Offset: 0x000194C0
		public void SetLoaded(string authToken)
		{
		}

		// Token: 0x06001F67 RID: 8039 RVA: 0x0001B2C2 File Offset: 0x000194C2
		private IEnumerator LoadMetadata(string authToken)
		{
			return null;
		}

		// Token: 0x06001F68 RID: 8040 RVA: 0x0001B2C5 File Offset: 0x000194C5
		private IEnumerator CheckOwnsItemFromAPI(int assetId, DynValue callback)
		{
			return null;
		}

		// Token: 0x06001F69 RID: 8041 RVA: 0x0001B2C8 File Offset: 0x000194C8
		private void SendChat()
		{
		}

		// Token: 0x06001F6A RID: 8042 RVA: 0x0001B2CA File Offset: 0x000194CA
		private IEnumerator StopScream()
		{
			return null;
		}

		// Token: 0x06001F6B RID: 8043 RVA: 0x0001B2CD File Offset: 0x000194CD
		private void UpdateFootsteps()
		{
		}

		// Token: 0x06001F6C RID: 8044 RVA: 0x0001B2CF File Offset: 0x000194CF
		private void DoFootstep()
		{
		}

		// Token: 0x06001F6D RID: 8045 RVA: 0x0001B2D1 File Offset: 0x000194D1
		private void Die()
		{
		}

		// Token: 0x06001F6E RID: 8046 RVA: 0x0001B2D3 File Offset: 0x000194D3
		private void CmdDied()
		{
		}

		// Token: 0x06001F6F RID: 8047 RVA: 0x0001B2D5 File Offset: 0x000194D5
		private void DropTools()
		{
		}

		// Token: 0x06001F70 RID: 8048 RVA: 0x0001B2D7 File Offset: 0x000194D7
		private void CmdDropTools()
		{
		}

		// Token: 0x06001F71 RID: 8049 RVA: 0x0001B2D9 File Offset: 0x000194D9
		private void DoDropTools()
		{
		}

		// Token: 0x06001F72 RID: 8050 RVA: 0x0001B2DB File Offset: 0x000194DB
		public void EquipTool(Tool tool)
		{
		}

		// Token: 0x06001F73 RID: 8051 RVA: 0x0001B2DD File Offset: 0x000194DD
		private void RpcSetAnimatorActive(bool active)
		{
		}

		// Token: 0x06001F74 RID: 8052 RVA: 0x0001B2DF File Offset: 0x000194DF
		public void SetTransformAttrTargetRpc(string attr, Vector3 value)
		{
		}

		// Token: 0x06001F75 RID: 8053 RVA: 0x0001B2E1 File Offset: 0x000194E1
		private IEnumerator DoDie()
		{
			return null;
		}

		// Token: 0x06001F76 RID: 8054 RVA: 0x0001B2E4 File Offset: 0x000194E4
		public void SetUserID(int userID)
		{
		}

		// Token: 0x06001F77 RID: 8055 RVA: 0x0001B2E6 File Offset: 0x000194E6
		public void LoadAppearance(int userID)
		{
		}

		// Token: 0x06001F78 RID: 8056 RVA: 0x0001B2E8 File Offset: 0x000194E8
		public void ClearAppearance()
		{
		}

		// Token: 0x06001F79 RID: 8057 RVA: 0x0001B2EA File Offset: 0x000194EA
		public void ResetAppearance()
		{
		}

		// Token: 0x06001F7A RID: 8058 RVA: 0x0001B2EC File Offset: 0x000194EC
		private bool IsGrounded()
		{
			return false;
		}

		// Token: 0x06001F7B RID: 8059 RVA: 0x0001B2EF File Offset: 0x000194EF
		protected override void OnCollisionEnter(Collision collision)
		{
		}

		// Token: 0x06001F7C RID: 8060 RVA: 0x0001B2F1 File Offset: 0x000194F1
		protected override void OnTriggerEnter(Collider collider)
		{
		}

		// Token: 0x06001F7D RID: 8061 RVA: 0x0001B2F3 File Offset: 0x000194F3
		protected override void OnTriggerExit(Collider collider)
		{
		}

		// Token: 0x06001F7E RID: 8062 RVA: 0x0001B2F5 File Offset: 0x000194F5
		private void CmdTouched(GameObject other)
		{
		}

		// Token: 0x06001F7F RID: 8063 RVA: 0x0001B2F7 File Offset: 0x000194F7
		private void CmdTouchEnded(GameObject other)
		{
		}

		// Token: 0x06001F80 RID: 8064 RVA: 0x0001B2F9 File Offset: 0x000194F9
		private bool PressingMovementKeys()
		{
			return false;
		}

		// Token: 0x06001F81 RID: 8065 RVA: 0x0001B2FC File Offset: 0x000194FC
		private void UpdateFov(bool sprinting)
		{
		}

		// Token: 0x06001F82 RID: 8066 RVA: 0x0001B2FE File Offset: 0x000194FE
		private void CmdJumpSound()
		{
		}

		// Token: 0x06001F83 RID: 8067 RVA: 0x0001B300 File Offset: 0x00019500
		private void RpcJumpSound()
		{
		}

		// Token: 0x06001F84 RID: 8068 RVA: 0x0001B302 File Offset: 0x00019502
		private void DoJumpSound()
		{
		}

		// Token: 0x06001F85 RID: 8069 RVA: 0x0001B304 File Offset: 0x00019504
		public void Kick(string reason = "You have been kicked from the server.")
		{
		}

		// Token: 0x06001F86 RID: 8070 RVA: 0x0001B306 File Offset: 0x00019506
		private IEnumerator DelayedDisconnect()
		{
			return null;
		}

		// Token: 0x06001F87 RID: 8071 RVA: 0x0001B309 File Offset: 0x00019509
		private void SendDisconnectMessageTargetRpc(string message)
		{
		}

		// Token: 0x06001F88 RID: 8072 RVA: 0x0001B30B File Offset: 0x0001950B
		public void Sit(Seat seat)
		{
		}

		// Token: 0x06001F89 RID: 8073 RVA: 0x0001B30D File Offset: 0x0001950D
		private void UnsitTargetRpc(bool addForce)
		{
		}

		// Token: 0x06001F8A RID: 8074 RVA: 0x0001B30F File Offset: 0x0001950F
		public void Unsit(bool addForce = true)
		{
		}

		// Token: 0x06001F8B RID: 8075 RVA: 0x0001B311 File Offset: 0x00019511
		public void CmdSetSittingIn(Seat seat)
		{
		}

		// Token: 0x06001F8C RID: 8076 RVA: 0x0001B313 File Offset: 0x00019513
		private void SetSittingIn(Seat seat)
		{
		}

		// Token: 0x06001F8D RID: 8077 RVA: 0x0001B315 File Offset: 0x00019515
		private void CmdNotifyRespawn()
		{
		}

		// Token: 0x06001F8E RID: 8078 RVA: 0x0001B317 File Offset: 0x00019517
		private void ServerRespawn()
		{
		}

		// Token: 0x06001F8F RID: 8079 RVA: 0x0001B319 File Offset: 0x00019519
		public void Respawn()
		{
		}

		// Token: 0x06001F90 RID: 8080 RVA: 0x0001B31B File Offset: 0x0001951B
		public void LookAt(Vector3 target, Vector3 worldUp)
		{
		}

		// Token: 0x06001F91 RID: 8081 RVA: 0x0001B31D File Offset: 0x0001951D
		public void LookAt(Vector3 target)
		{
		}

		// Token: 0x06001F92 RID: 8082 RVA: 0x0001B31F File Offset: 0x0001951F
		public void LookAt(DynamicInstance target)
		{
		}

		// Token: 0x06001F93 RID: 8083 RVA: 0x0001B321 File Offset: 0x00019521
		public void Translate(Vector3 translation)
		{
		}

		// Token: 0x06001F94 RID: 8084 RVA: 0x0001B323 File Offset: 0x00019523
		public void RotateAround(Vector3 point, Vector3 axis, float angle)
		{
		}

		// Token: 0x06001F95 RID: 8085 RVA: 0x0001B325 File Offset: 0x00019525
		public void Rotate(Vector3 eulerAngles)
		{
		}

		// Token: 0x06001F96 RID: 8086 RVA: 0x00024D18 File Offset: 0x00022F18
		public Vector3 InverseTransformPoint(Vector3 point)
		{
			return default(Vector3);
		}

		// Token: 0x06001F97 RID: 8087 RVA: 0x00024D30 File Offset: 0x00022F30
		public Vector3 TransformPoint(Vector3 point)
		{
			return default(Vector3);
		}

		// Token: 0x06001F98 RID: 8088 RVA: 0x00024D48 File Offset: 0x00022F48
		public Vector3 InverseTransformDirection(Vector3 direction)
		{
			return default(Vector3);
		}

		// Token: 0x06001F99 RID: 8089 RVA: 0x00024D60 File Offset: 0x00022F60
		public Vector3 TransformDirection(Vector3 direction)
		{
			return default(Vector3);
		}

		// Token: 0x06001F9A RID: 8090 RVA: 0x00024D78 File Offset: 0x00022F78
		public Vector3 InverseTransformVector(Vector3 vector)
		{
			return default(Vector3);
		}

		// Token: 0x06001F9B RID: 8091 RVA: 0x00024D90 File Offset: 0x00022F90
		public Vector3 TransformVector(Vector3 vector)
		{
			return default(Vector3);
		}

		// Token: 0x06001F9C RID: 8092 RVA: 0x0001B327 File Offset: 0x00019527
		public void TargetSetPosition(Vector3 pos)
		{
		}

		// Token: 0x06001F9D RID: 8093 RVA: 0x0001B329 File Offset: 0x00019529
		private void RpcSetRespawnTime(float time)
		{
		}

		// Token: 0x06001F9E RID: 8094 RVA: 0x0001B32B File Offset: 0x0001952B
		private void RpcSetMaxHealth(float maxHealth)
		{
		}

		// Token: 0x06001F9F RID: 8095 RVA: 0x0001B32D File Offset: 0x0001952D
		private void RpcSetHealth(float health)
		{
		}

		// Token: 0x06001FA0 RID: 8096 RVA: 0x0001B32F File Offset: 0x0001952F
		private void CmdSetHealth(float health)
		{
		}

		// Token: 0x06001FA1 RID: 8097 RVA: 0x0001B331 File Offset: 0x00019531
		private void RpcSetWalkSpeed(float walkSpeed)
		{
		}

		// Token: 0x06001FA2 RID: 8098 RVA: 0x0001B333 File Offset: 0x00019533
		private void RpcSetSprintSpeed(float sprintSpeed)
		{
		}

		// Token: 0x06001FA3 RID: 8099 RVA: 0x0001B335 File Offset: 0x00019535
		private void RpcSetMaxStamina(float val)
		{
		}

		// Token: 0x06001FA4 RID: 8100 RVA: 0x0001B337 File Offset: 0x00019537
		private void RpcSetStamina(float val)
		{
		}

		// Token: 0x06001FA5 RID: 8101 RVA: 0x0001B339 File Offset: 0x00019539
		private void RpcSetStaminaRegen(float val)
		{
		}

		// Token: 0x06001FA6 RID: 8102 RVA: 0x0001B33B File Offset: 0x0001953B
		private void RpcSetStaminaEnabled(bool val)
		{
		}

		// Token: 0x06001FA7 RID: 8103 RVA: 0x0001B33D File Offset: 0x0001953D
		private void RpcSetJumpPower(float jumpPower)
		{
		}

		// Token: 0x06001FA8 RID: 8104 RVA: 0x0001B33F File Offset: 0x0001953F
		private void RpcSetChatColor(Color col)
		{
		}

		// Token: 0x06001FA9 RID: 8105 RVA: 0x0001B341 File Offset: 0x00019541
		private void RpcSetCanMove(bool canMove)
		{
		}

		// Token: 0x06001FAA RID: 8106 RVA: 0x0001B343 File Offset: 0x00019543
		private void RpcSetAnchored(bool anchored)
		{
		}

		// Token: 0x06001FAB RID: 8107 RVA: 0x0001B345 File Offset: 0x00019545
		private void RpcSetColor(BodyPart bodyPart, Color color)
		{
		}

		// Token: 0x06001FAE RID: 8110 RVA: 0x0001B351 File Offset: 0x00019551
		private void <set_ShirtID>b__165_0(ImageCacheKey key, ImageCacheEntry entry)
		{
		}

		// Token: 0x06001FAF RID: 8111 RVA: 0x0001B353 File Offset: 0x00019553
		private void <set_PantsID>b__168_0(ImageCacheKey key, ImageCacheEntry entry)
		{
		}

		// Token: 0x06001FB0 RID: 8112 RVA: 0x0001B355 File Offset: 0x00019555
		private void <set_FaceID>b__171_0(ImageCacheKey key, ImageCacheEntry entry)
		{
		}

		// Token: 0x06001FB1 RID: 8113 RVA: 0x0001B357 File Offset: 0x00019557
		private void <Start>b__189_0()
		{
		}

		// Token: 0x06001FB2 RID: 8114 RVA: 0x0001B359 File Offset: 0x00019559
		private void <Start>b__189_1(string <p0>)
		{
		}

		// Token: 0x06001FB3 RID: 8115 RVA: 0x0001B35B File Offset: 0x0001955B
		private void <Start>b__189_2()
		{
		}

		// Token: 0x06001FB4 RID: 8116 RVA: 0x0001B35D File Offset: 0x0001955D
		private bool <IsGrounded>b__227_1(Collider i)
		{
			return false;
		}

		// Token: 0x06001FB5 RID: 8117 RVA: 0x0001B360 File Offset: 0x00019560
		private void <UpdateFov>b__234_0(float fov)
		{
		}

		// Token: 0x06001FB6 RID: 8118 RVA: 0x0001B362 File Offset: 0x00019562
		private void <UpdateFov>b__234_1(float fov)
		{
		}

		// Token: 0x06001FB7 RID: 8119 RVA: 0x0001B364 File Offset: 0x00019564
		public override bool Weaved()
		{
			return false;
		}

		// Token: 0x170009DA RID: 2522
		// (get) Token: 0x06001FB8 RID: 8120 RVA: 0x0001B367 File Offset: 0x00019567
		// (set) Token: 0x06001FB9 RID: 8121 RVA: 0x0001B36E File Offset: 0x0001956E
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

		// Token: 0x170009DB RID: 2523
		// (get) Token: 0x06001FBA RID: 8122 RVA: 0x0001B370 File Offset: 0x00019570
		// (set) Token: 0x06001FBB RID: 8123 RVA: 0x0001B377 File Offset: 0x00019577
		public float NetworksprintSpeed
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

		// Token: 0x170009DC RID: 2524
		// (get) Token: 0x06001FBC RID: 8124 RVA: 0x0001B379 File Offset: 0x00019579
		// (set) Token: 0x06001FBD RID: 8125 RVA: 0x0001B380 File Offset: 0x00019580
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

		// Token: 0x170009DD RID: 2525
		// (get) Token: 0x06001FBE RID: 8126 RVA: 0x0001B382 File Offset: 0x00019582
		// (set) Token: 0x06001FBF RID: 8127 RVA: 0x0001B385 File Offset: 0x00019585
		public bool NetworkstaminaEnabled
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

		// Token: 0x170009DE RID: 2526
		// (get) Token: 0x06001FC0 RID: 8128 RVA: 0x0001B387 File Offset: 0x00019587
		// (set) Token: 0x06001FC1 RID: 8129 RVA: 0x0001B38E File Offset: 0x0001958E
		public float Networkstamina
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

		// Token: 0x170009DF RID: 2527
		// (get) Token: 0x06001FC2 RID: 8130 RVA: 0x0001B390 File Offset: 0x00019590
		// (set) Token: 0x06001FC3 RID: 8131 RVA: 0x0001B397 File Offset: 0x00019597
		public float NetworkmaxStamina
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

		// Token: 0x170009E0 RID: 2528
		// (get) Token: 0x06001FC4 RID: 8132 RVA: 0x0001B399 File Offset: 0x00019599
		// (set) Token: 0x06001FC5 RID: 8133 RVA: 0x0001B3A0 File Offset: 0x000195A0
		public float NetworkstaminaRegen
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

		// Token: 0x170009E1 RID: 2529
		// (get) Token: 0x06001FC6 RID: 8134 RVA: 0x0001B3A2 File Offset: 0x000195A2
		// (set) Token: 0x06001FC7 RID: 8135 RVA: 0x0001B3A9 File Offset: 0x000195A9
		public float NetworkrespawnTime
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

		// Token: 0x170009E2 RID: 2530
		// (get) Token: 0x06001FC8 RID: 8136 RVA: 0x0001B3AB File Offset: 0x000195AB
		// (set) Token: 0x06001FC9 RID: 8137 RVA: 0x0001B3AE File Offset: 0x000195AE
		public int NetworkuserID
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

		// Token: 0x170009E3 RID: 2531
		// (get) Token: 0x06001FCA RID: 8138 RVA: 0x0001B3B0 File Offset: 0x000195B0
		// (set) Token: 0x06001FCB RID: 8139 RVA: 0x0001B3B3 File Offset: 0x000195B3
		public bool Networkloaded
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

		// Token: 0x170009E4 RID: 2532
		// (get) Token: 0x06001FCC RID: 8140 RVA: 0x0001B3B5 File Offset: 0x000195B5
		// (set) Token: 0x06001FCD RID: 8141 RVA: 0x0001B3B8 File Offset: 0x000195B8
		public bool NetworkisCreator
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

		// Token: 0x170009E5 RID: 2533
		// (get) Token: 0x06001FCE RID: 8142 RVA: 0x0001B3BA File Offset: 0x000195BA
		// (set) Token: 0x06001FCF RID: 8143 RVA: 0x0001B3BD File Offset: 0x000195BD
		public bool NetworkisAdmin
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

		// Token: 0x170009E6 RID: 2534
		// (get) Token: 0x06001FD0 RID: 8144 RVA: 0x00024DA8 File Offset: 0x00022FA8
		// (set) Token: 0x06001FD1 RID: 8145 RVA: 0x0001B3BF File Offset: 0x000195BF
		public Color NetworkchatColor
		{
			get
			{
				return default(Color);
			}
			[param: In]
			set
			{
			}
		}

		// Token: 0x170009E7 RID: 2535
		// (get) Token: 0x06001FD2 RID: 8146 RVA: 0x0001B3C1 File Offset: 0x000195C1
		// (set) Token: 0x06001FD3 RID: 8147 RVA: 0x0001B3C4 File Offset: 0x000195C4
		public string NetworkavatarHash
		{
			get
			{
				return null;
			}
			[param: In]
			set
			{
			}
		}

		// Token: 0x170009E8 RID: 2536
		// (get) Token: 0x06001FD4 RID: 8148 RVA: 0x0001B3C6 File Offset: 0x000195C6
		// (set) Token: 0x06001FD5 RID: 8149 RVA: 0x0001B3C9 File Offset: 0x000195C9
		public bool NetworkcanMove
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

		// Token: 0x170009E9 RID: 2537
		// (get) Token: 0x06001FD6 RID: 8150 RVA: 0x0001B3CB File Offset: 0x000195CB
		// (set) Token: 0x06001FD7 RID: 8151 RVA: 0x0001B3CE File Offset: 0x000195CE
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

		// Token: 0x170009EA RID: 2538
		// (get) Token: 0x06001FD8 RID: 8152 RVA: 0x0001B3D0 File Offset: 0x000195D0
		// (set) Token: 0x06001FD9 RID: 8153 RVA: 0x0001B3D3 File Offset: 0x000195D3
		public string NetworkLeaderboardBadgeId
		{
			get
			{
				return null;
			}
			[param: In]
			set
			{
			}
		}

		// Token: 0x170009EB RID: 2539
		// (get) Token: 0x06001FDA RID: 8154 RVA: 0x0001B3D5 File Offset: 0x000195D5
		// (set) Token: 0x06001FDB RID: 8155 RVA: 0x0001B3D8 File Offset: 0x000195D8
		public bool NetworkcanChat
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

		// Token: 0x170009EC RID: 2540
		// (get) Token: 0x06001FDC RID: 8156 RVA: 0x0001B3DA File Offset: 0x000195DA
		// (set) Token: 0x06001FDD RID: 8157 RVA: 0x0001B3DD File Offset: 0x000195DD
		public bool NetworkisAgeRestricted
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

		// Token: 0x170009ED RID: 2541
		// (get) Token: 0x06001FDE RID: 8158 RVA: 0x0001B3DF File Offset: 0x000195DF
		// (set) Token: 0x06001FDF RID: 8159 RVA: 0x0001B3E2 File Offset: 0x000195E2
		public Seat NetworksittingIn
		{
			get
			{
				return null;
			}
			[param: In]
			set
			{
			}
		}

		// Token: 0x06001FE0 RID: 8160 RVA: 0x0001B3E4 File Offset: 0x000195E4
		protected void UserCode_PlayAnimTargetRpc__String(string _anim)
		{
		}

		// Token: 0x06001FE1 RID: 8161 RVA: 0x0001B3E6 File Offset: 0x000195E6
		protected static void InvokeUserCode_PlayAnimTargetRpc__String(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		// Token: 0x06001FE2 RID: 8162 RVA: 0x0001B3E8 File Offset: 0x000195E8
		protected void UserCode_NotifyJoin()
		{
		}

		// Token: 0x06001FE3 RID: 8163 RVA: 0x0001B3EA File Offset: 0x000195EA
		protected static void InvokeUserCode_NotifyJoin(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		// Token: 0x06001FE4 RID: 8164 RVA: 0x0001B3EC File Offset: 0x000195EC
		protected void UserCode_CmdDied()
		{
		}

		// Token: 0x06001FE5 RID: 8165 RVA: 0x0001B3EE File Offset: 0x000195EE
		protected static void InvokeUserCode_CmdDied(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		// Token: 0x06001FE6 RID: 8166 RVA: 0x0001B3F0 File Offset: 0x000195F0
		protected void UserCode_CmdDropTools()
		{
		}

		// Token: 0x06001FE7 RID: 8167 RVA: 0x0001B3F2 File Offset: 0x000195F2
		protected static void InvokeUserCode_CmdDropTools(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		// Token: 0x06001FE8 RID: 8168 RVA: 0x0001B3F4 File Offset: 0x000195F4
		protected void UserCode_EquipTool__Tool(Tool tool)
		{
		}

		// Token: 0x06001FE9 RID: 8169 RVA: 0x0001B3F6 File Offset: 0x000195F6
		protected static void InvokeUserCode_EquipTool__Tool(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		// Token: 0x06001FEA RID: 8170 RVA: 0x0001B3F8 File Offset: 0x000195F8
		protected void UserCode_RpcSetAnimatorActive__Boolean(bool active)
		{
		}

		// Token: 0x06001FEB RID: 8171 RVA: 0x0001B3FA File Offset: 0x000195FA
		protected static void InvokeUserCode_RpcSetAnimatorActive__Boolean(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		// Token: 0x06001FEC RID: 8172 RVA: 0x0001B3FC File Offset: 0x000195FC
		protected void UserCode_SetTransformAttrTargetRpc__String__Vector3(string attr, Vector3 value)
		{
		}

		// Token: 0x06001FED RID: 8173 RVA: 0x0001B3FE File Offset: 0x000195FE
		protected static void InvokeUserCode_SetTransformAttrTargetRpc__String__Vector3(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		// Token: 0x06001FEE RID: 8174 RVA: 0x0001B400 File Offset: 0x00019600
		protected void UserCode_CmdTouched__GameObject(GameObject other)
		{
		}

		// Token: 0x06001FEF RID: 8175 RVA: 0x0001B402 File Offset: 0x00019602
		protected static void InvokeUserCode_CmdTouched__GameObject(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		// Token: 0x06001FF0 RID: 8176 RVA: 0x0001B404 File Offset: 0x00019604
		protected void UserCode_CmdTouchEnded__GameObject(GameObject other)
		{
		}

		// Token: 0x06001FF1 RID: 8177 RVA: 0x0001B406 File Offset: 0x00019606
		protected static void InvokeUserCode_CmdTouchEnded__GameObject(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		// Token: 0x06001FF2 RID: 8178 RVA: 0x0001B408 File Offset: 0x00019608
		protected void UserCode_CmdJumpSound()
		{
		}

		// Token: 0x06001FF3 RID: 8179 RVA: 0x0001B40A File Offset: 0x0001960A
		protected static void InvokeUserCode_CmdJumpSound(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		// Token: 0x06001FF4 RID: 8180 RVA: 0x0001B40C File Offset: 0x0001960C
		protected void UserCode_RpcJumpSound()
		{
		}

		// Token: 0x06001FF5 RID: 8181 RVA: 0x0001B40E File Offset: 0x0001960E
		protected static void InvokeUserCode_RpcJumpSound(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		// Token: 0x06001FF6 RID: 8182 RVA: 0x0001B410 File Offset: 0x00019610
		protected void UserCode_SendDisconnectMessageTargetRpc__String(string message)
		{
		}

		// Token: 0x06001FF7 RID: 8183 RVA: 0x0001B412 File Offset: 0x00019612
		protected static void InvokeUserCode_SendDisconnectMessageTargetRpc__String(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		// Token: 0x06001FF8 RID: 8184 RVA: 0x0001B414 File Offset: 0x00019614
		protected void UserCode_UnsitTargetRpc__Boolean(bool addForce)
		{
		}

		// Token: 0x06001FF9 RID: 8185 RVA: 0x0001B416 File Offset: 0x00019616
		protected static void InvokeUserCode_UnsitTargetRpc__Boolean(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		// Token: 0x06001FFA RID: 8186 RVA: 0x0001B418 File Offset: 0x00019618
		protected void UserCode_CmdSetSittingIn__Seat(Seat seat)
		{
		}

		// Token: 0x06001FFB RID: 8187 RVA: 0x0001B41A File Offset: 0x0001961A
		protected static void InvokeUserCode_CmdSetSittingIn__Seat(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		// Token: 0x06001FFC RID: 8188 RVA: 0x0001B41C File Offset: 0x0001961C
		protected void UserCode_CmdNotifyRespawn()
		{
		}

		// Token: 0x06001FFD RID: 8189 RVA: 0x0001B41E File Offset: 0x0001961E
		protected static void InvokeUserCode_CmdNotifyRespawn(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		// Token: 0x06001FFE RID: 8190 RVA: 0x0001B420 File Offset: 0x00019620
		protected void UserCode_TargetSetPosition__Vector3(Vector3 pos)
		{
		}

		// Token: 0x06001FFF RID: 8191 RVA: 0x0001B422 File Offset: 0x00019622
		protected static void InvokeUserCode_TargetSetPosition__Vector3(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		// Token: 0x06002000 RID: 8192 RVA: 0x0001B424 File Offset: 0x00019624
		protected void UserCode_RpcSetRespawnTime__Single(float time)
		{
		}

		// Token: 0x06002001 RID: 8193 RVA: 0x0001B426 File Offset: 0x00019626
		protected static void InvokeUserCode_RpcSetRespawnTime__Single(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		// Token: 0x06002002 RID: 8194 RVA: 0x0001B428 File Offset: 0x00019628
		protected void UserCode_RpcSetMaxHealth__Single(float maxHealth)
		{
		}

		// Token: 0x06002003 RID: 8195 RVA: 0x0001B42A File Offset: 0x0001962A
		protected static void InvokeUserCode_RpcSetMaxHealth__Single(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		// Token: 0x06002004 RID: 8196 RVA: 0x0001B42C File Offset: 0x0001962C
		protected void UserCode_RpcSetHealth__Single(float health)
		{
		}

		// Token: 0x06002005 RID: 8197 RVA: 0x0001B42E File Offset: 0x0001962E
		protected static void InvokeUserCode_RpcSetHealth__Single(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		// Token: 0x06002006 RID: 8198 RVA: 0x0001B430 File Offset: 0x00019630
		protected void UserCode_CmdSetHealth__Single(float health)
		{
		}

		// Token: 0x06002007 RID: 8199 RVA: 0x0001B432 File Offset: 0x00019632
		protected static void InvokeUserCode_CmdSetHealth__Single(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		// Token: 0x06002008 RID: 8200 RVA: 0x0001B434 File Offset: 0x00019634
		protected void UserCode_RpcSetWalkSpeed__Single(float walkSpeed)
		{
		}

		// Token: 0x06002009 RID: 8201 RVA: 0x0001B436 File Offset: 0x00019636
		protected static void InvokeUserCode_RpcSetWalkSpeed__Single(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		// Token: 0x0600200A RID: 8202 RVA: 0x0001B438 File Offset: 0x00019638
		protected void UserCode_RpcSetSprintSpeed__Single(float sprintSpeed)
		{
		}

		// Token: 0x0600200B RID: 8203 RVA: 0x0001B43A File Offset: 0x0001963A
		protected static void InvokeUserCode_RpcSetSprintSpeed__Single(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		// Token: 0x0600200C RID: 8204 RVA: 0x0001B43C File Offset: 0x0001963C
		protected void UserCode_RpcSetMaxStamina__Single(float val)
		{
		}

		// Token: 0x0600200D RID: 8205 RVA: 0x0001B43E File Offset: 0x0001963E
		protected static void InvokeUserCode_RpcSetMaxStamina__Single(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		// Token: 0x0600200E RID: 8206 RVA: 0x0001B440 File Offset: 0x00019640
		protected void UserCode_RpcSetStamina__Single(float val)
		{
		}

		// Token: 0x0600200F RID: 8207 RVA: 0x0001B442 File Offset: 0x00019642
		protected static void InvokeUserCode_RpcSetStamina__Single(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		// Token: 0x06002010 RID: 8208 RVA: 0x0001B444 File Offset: 0x00019644
		protected void UserCode_RpcSetStaminaRegen__Single(float val)
		{
		}

		// Token: 0x06002011 RID: 8209 RVA: 0x0001B446 File Offset: 0x00019646
		protected static void InvokeUserCode_RpcSetStaminaRegen__Single(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		// Token: 0x06002012 RID: 8210 RVA: 0x0001B448 File Offset: 0x00019648
		protected void UserCode_RpcSetStaminaEnabled__Boolean(bool val)
		{
		}

		// Token: 0x06002013 RID: 8211 RVA: 0x0001B44A File Offset: 0x0001964A
		protected static void InvokeUserCode_RpcSetStaminaEnabled__Boolean(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		// Token: 0x06002014 RID: 8212 RVA: 0x0001B44C File Offset: 0x0001964C
		protected void UserCode_RpcSetJumpPower__Single(float jumpPower)
		{
		}

		// Token: 0x06002015 RID: 8213 RVA: 0x0001B44E File Offset: 0x0001964E
		protected static void InvokeUserCode_RpcSetJumpPower__Single(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		// Token: 0x06002016 RID: 8214 RVA: 0x0001B450 File Offset: 0x00019650
		protected void UserCode_RpcSetChatColor__Color(Color col)
		{
		}

		// Token: 0x06002017 RID: 8215 RVA: 0x0001B452 File Offset: 0x00019652
		protected static void InvokeUserCode_RpcSetChatColor__Color(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		// Token: 0x06002018 RID: 8216 RVA: 0x0001B454 File Offset: 0x00019654
		protected void UserCode_RpcSetCanMove__Boolean(bool canMove)
		{
		}

		// Token: 0x06002019 RID: 8217 RVA: 0x0001B456 File Offset: 0x00019656
		protected static void InvokeUserCode_RpcSetCanMove__Boolean(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		// Token: 0x0600201A RID: 8218 RVA: 0x0001B458 File Offset: 0x00019658
		protected void UserCode_RpcSetAnchored__Boolean(bool anchored)
		{
		}

		// Token: 0x0600201B RID: 8219 RVA: 0x0001B45A File Offset: 0x0001965A
		protected static void InvokeUserCode_RpcSetAnchored__Boolean(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		// Token: 0x0600201C RID: 8220 RVA: 0x0001B45C File Offset: 0x0001965C
		protected void UserCode_RpcSetColor__BodyPart__Color(BodyPart bodyPart, Color color)
		{
		}

		// Token: 0x0600201D RID: 8221 RVA: 0x0001B45E File Offset: 0x0001965E
		protected static void InvokeUserCode_RpcSetColor__BodyPart__Color(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		// Token: 0x0600201E RID: 8222 RVA: 0x0001B460 File Offset: 0x00019660
		public override void SerializeSyncVars(NetworkWriter writer, bool forceAll)
		{
		}

		// Token: 0x0600201F RID: 8223 RVA: 0x0001B462 File Offset: 0x00019662
		public override void DeserializeSyncVars(NetworkReader reader, bool initialState)
		{
		}

		// Token: 0x04000B66 RID: 2918
		public static bool kicked;

		// Token: 0x04000B67 RID: 2919
		private static readonly int maxRequestsPerMin;

		// Token: 0x04000B68 RID: 2920
		private static readonly int hatCheckCacheLength;

		// Token: 0x04000B69 RID: 2921
		private readonly Array keyCodes;

		// Token: 0x04000B6A RID: 2922
		private static FootstepCollection footstepSounds;

		// Token: 0x04000B6B RID: 2923
		private const float footstepInterval = 0.3f;

		// Token: 0x04000B6C RID: 2924
		private float footstepTimer;

		// Token: 0x04000B6D RID: 2925
		private int footstepIndex;

		// Token: 0x04000B6E RID: 2926
		private AudioSource footstepPlayer;

		// Token: 0x04000B6F RID: 2927
		private ParentConstraint parentConstraint;

		// Token: 0x04000B70 RID: 2928
		private float maxHealth;

		// Token: 0x04000B71 RID: 2929
		private float walkSpeed;

		// Token: 0x04000B72 RID: 2930
		private float sprintSpeed;

		// Token: 0x04000B73 RID: 2931
		private float health;

		// Token: 0x04000B74 RID: 2932
		private bool isSprinting;

		// Token: 0x04000B75 RID: 2933
		private bool sprintExhausted;

		// Token: 0x04000B76 RID: 2934
		private bool staminaEnabled;

		// Token: 0x04000B77 RID: 2935
		private float stamina;

		// Token: 0x04000B78 RID: 2936
		private float maxStamina;

		// Token: 0x04000B79 RID: 2937
		private float staminaRegen;

		// Token: 0x04000B7A RID: 2938
		private float jumpPower;

		// Token: 0x04000B7B RID: 2939
		private float respawnTime;

		// Token: 0x04000B7C RID: 2940
		private int userID;

		// Token: 0x04000B7D RID: 2941
		private bool loaded;

		// Token: 0x04000B7E RID: 2942
		private bool isCreator;

		// Token: 0x04000B7F RID: 2943
		private bool isAdmin;

		// Token: 0x04000B80 RID: 2944
		private Color chatColor;

		// Token: 0x04000B81 RID: 2945
		private string avatarHash;

		// Token: 0x04000B82 RID: 2946
		private bool canMove;

		// Token: 0x04000B83 RID: 2947
		private bool anchored;

		// Token: 0x04000B84 RID: 2948
		public string LeaderboardBadgeId;

		// Token: 0x04000B85 RID: 2949
		public bool canChat;

		// Token: 0x04000B86 RID: 2950
		public bool isAgeRestricted;

		// Token: 0x04000B87 RID: 2951
		private float turnSmoothing;

		// Token: 0x04000B88 RID: 2952
		private LayerMask ignoreLayer;

		// Token: 0x04000B89 RID: 2953
		private Animator anim;

		// Token: 0x04000B8A RID: 2954
		private Rigidbody rb;

		// Token: 0x04000B8B RID: 2955
		private List<MeshRenderer> disableOnFP;

		// Token: 0x04000B8C RID: 2956
		private List<Rigidbody> deathBodyParts;

		// Token: 0x04000B8D RID: 2957
		private Transform toolAttachPoint;

		// Token: 0x04000B8E RID: 2958
		private Transform camAttachment;

		// Token: 0x04000B8F RID: 2959
		private int shirtID;

		// Token: 0x04000B90 RID: 2960
		private int pantsID;

		// Token: 0x04000B91 RID: 2961
		private int faceID;

		// Token: 0x04000B92 RID: 2962
		private float coyoteTime;

		// Token: 0x04000B93 RID: 2963
		private float coyoteTimer;

		// Token: 0x04000B94 RID: 2964
		private Collider col;

		// Token: 0x04000B95 RID: 2965
		private PhysicsMaterial airMaterial;

		// Token: 0x04000B96 RID: 2966
		private PhysicsMaterial groundMaterial;

		// Token: 0x04000B97 RID: 2967
		private Dictionary<Rigidbody, Vector3> defaultBodyPartPos;

		// Token: 0x04000B98 RID: 2968
		private Transform head;

		// Token: 0x04000B99 RID: 2969
		private Transform leftArm;

		// Token: 0x04000B9A RID: 2970
		private Transform rightArm;

		// Token: 0x04000B9B RID: 2971
		private Transform torso;

		// Token: 0x04000B9C RID: 2972
		private Transform leftLeg;

		// Token: 0x04000B9D RID: 2973
		private Transform rightLeg;

		// Token: 0x04000B9E RID: 2974
		private NetworkAnimator netAnim;

		// Token: 0x04000B9F RID: 2975
		public float maxStepHeight;

		// Token: 0x04000BA0 RID: 2976
		public float stepSearchOvershoot;

		// Token: 0x04000BA1 RID: 2977
		private List<ContactPoint> allCPs;

		// Token: 0x04000BA2 RID: 2978
		private Vector3 lastVelocity;

		// Token: 0x04000BA3 RID: 2979
		private float afkTimer;

		// Token: 0x04000BA4 RID: 2980
		private float maxAfkTime;

		// Token: 0x04000BA5 RID: 2981
		private bool isDead;

		// Token: 0x04000BA6 RID: 2982
		private float jumpCooldown;

		// Token: 0x04000BA7 RID: 2983
		private float currentSpeed;

		// Token: 0x04000BA8 RID: 2984
		private TMP_Text nametag;

		// Token: 0x04000BA9 RID: 2985
		private Vector3 oldPos;

		// Token: 0x04000BAA RID: 2986
		private Seat sittingIn;

		// Token: 0x04000BAB RID: 2987
		public LuaEvent Chatted;

		// Token: 0x04000BAC RID: 2988
		public LuaEvent Died;

		// Token: 0x04000BAD RID: 2989
		public LuaEvent Respawned;

		// Token: 0x04000BAE RID: 2990
		private Environment _env;

		// Token: 0x04000BAF RID: 2991
		private Dictionary<int, bool> assetOwnCache;

		// Token: 0x04000BB0 RID: 2992
		private Dictionary<int, int> assetCacheCheckTimes;

		// Token: 0x04000BB1 RID: 2993
		private static Dictionary<int, int> assetCheckCounts;

		// Token: 0x04000BB2 RID: 2994
		private float defaultFov;

		// Token: 0x04000BB3 RID: 2995
		private float sprintFov;

		// Token: 0x04000BB4 RID: 2996
		private AppearanceLoaderBase appearance;

		// Token: 0x04000BB5 RID: 2997
		private Camera cam;

		// Token: 0x04000BB6 RID: 2998
		private bool climbing;

		// Token: 0x04000BB7 RID: 2999
		private bool isEmote;

		// Token: 0x04000BB8 RID: 3000
		protected NetworkBehaviourSyncVar ___sittingInNetId;

		// Token: 0x020003EE RID: 1006
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06002BA4 RID: 11172 RVA: 0x0001D65D File Offset: 0x0001B85D
			internal bool <DoFootstep>b__213_0(Collider i)
			{
				return false;
			}

			// Token: 0x06002BA5 RID: 11173 RVA: 0x0001D660 File Offset: 0x0001B860
			internal Instance <DoFootstep>b__213_1(Collider i)
			{
				return null;
			}

			// Token: 0x06002BA6 RID: 11174 RVA: 0x0001D663 File Offset: 0x0001B863
			internal bool <IsGrounded>b__227_0(Collider i)
			{
				return false;
			}

			// Token: 0x040010A0 RID: 4256
			public static readonly Player.<>c <>9;

			// Token: 0x040010A1 RID: 4257
			public static Func<Collider, bool> <>9__213_0;

			// Token: 0x040010A2 RID: 4258
			public static Func<Collider, Instance> <>9__213_1;

			// Token: 0x040010A3 RID: 4259
			public static Func<Collider, bool> <>9__227_0;
		}

		// Token: 0x020003EF RID: 1007
		private sealed class <CheckOwnsItemFromAPI>d__208 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x06002BA7 RID: 11175 RVA: 0x0001D666 File Offset: 0x0001B866
			public <CheckOwnsItemFromAPI>d__208(int <>1__state)
			{
			}

			// Token: 0x06002BA8 RID: 11176 RVA: 0x0001D66E File Offset: 0x0001B86E
			void IDisposable.Dispose()
			{
			}

			// Token: 0x06002BA9 RID: 11177 RVA: 0x0001D670 File Offset: 0x0001B870
			bool IEnumerator.MoveNext()
			{
				return false;
			}

			// Token: 0x06002BAA RID: 11178 RVA: 0x0001D673 File Offset: 0x0001B873
			private void <>m__Finally1()
			{
			}

			// Token: 0x17000CCE RID: 3278
			// (get) Token: 0x06002BAB RID: 11179 RVA: 0x0001D675 File Offset: 0x0001B875
			object IEnumerator<object>.Current
			{
				get
				{
					return null;
				}
			}

			// Token: 0x06002BAC RID: 11180 RVA: 0x0001D678 File Offset: 0x0001B878
			void IEnumerator.Reset()
			{
			}

			// Token: 0x17000CCF RID: 3279
			// (get) Token: 0x06002BAD RID: 11181 RVA: 0x0001D67A File Offset: 0x0001B87A
			object IEnumerator.Current
			{
				get
				{
					return null;
				}
			}

			// Token: 0x040010A4 RID: 4260
			private int <>1__state;

			// Token: 0x040010A5 RID: 4261
			private object <>2__current;

			// Token: 0x040010A6 RID: 4262
			public DynValue callback;

			// Token: 0x040010A7 RID: 4263
			public int assetId;

			// Token: 0x040010A8 RID: 4264
			public Player <>4__this;

			// Token: 0x040010A9 RID: 4265
			private ScriptService <ss>5__2;

			// Token: 0x040010AA RID: 4266
			private UnityWebRequest <uwr>5__3;
		}

		// Token: 0x020003F0 RID: 1008
		private sealed class <DelayedDisconnect>d__239 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x06002BAE RID: 11182 RVA: 0x0001D67D File Offset: 0x0001B87D
			public <DelayedDisconnect>d__239(int <>1__state)
			{
			}

			// Token: 0x06002BAF RID: 11183 RVA: 0x0001D685 File Offset: 0x0001B885
			void IDisposable.Dispose()
			{
			}

			// Token: 0x06002BB0 RID: 11184 RVA: 0x0001D687 File Offset: 0x0001B887
			bool IEnumerator.MoveNext()
			{
				return false;
			}

			// Token: 0x17000CD0 RID: 3280
			// (get) Token: 0x06002BB1 RID: 11185 RVA: 0x0001D68A File Offset: 0x0001B88A
			object IEnumerator<object>.Current
			{
				get
				{
					return null;
				}
			}

			// Token: 0x06002BB2 RID: 11186 RVA: 0x0001D68D File Offset: 0x0001B88D
			void IEnumerator.Reset()
			{
			}

			// Token: 0x17000CD1 RID: 3281
			// (get) Token: 0x06002BB3 RID: 11187 RVA: 0x0001D68F File Offset: 0x0001B88F
			object IEnumerator.Current
			{
				get
				{
					return null;
				}
			}

			// Token: 0x040010AB RID: 4267
			private int <>1__state;

			// Token: 0x040010AC RID: 4268
			private object <>2__current;

			// Token: 0x040010AD RID: 4269
			public Player <>4__this;
		}

		// Token: 0x020003F1 RID: 1009
		private sealed class <DiscordLoop>d__197 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x06002BB4 RID: 11188 RVA: 0x0001D692 File Offset: 0x0001B892
			public <DiscordLoop>d__197(int <>1__state)
			{
			}

			// Token: 0x06002BB5 RID: 11189 RVA: 0x0001D69A File Offset: 0x0001B89A
			void IDisposable.Dispose()
			{
			}

			// Token: 0x06002BB6 RID: 11190 RVA: 0x0001D69C File Offset: 0x0001B89C
			bool IEnumerator.MoveNext()
			{
				return false;
			}

			// Token: 0x17000CD2 RID: 3282
			// (get) Token: 0x06002BB7 RID: 11191 RVA: 0x0001D69F File Offset: 0x0001B89F
			object IEnumerator<object>.Current
			{
				get
				{
					return null;
				}
			}

			// Token: 0x06002BB8 RID: 11192 RVA: 0x0001D6A2 File Offset: 0x0001B8A2
			void IEnumerator.Reset()
			{
			}

			// Token: 0x17000CD3 RID: 3283
			// (get) Token: 0x06002BB9 RID: 11193 RVA: 0x0001D6A4 File Offset: 0x0001B8A4
			object IEnumerator.Current
			{
				get
				{
					return null;
				}
			}

			// Token: 0x040010AE RID: 4270
			private int <>1__state;

			// Token: 0x040010AF RID: 4271
			private object <>2__current;
		}

		// Token: 0x020003F2 RID: 1010
		private sealed class <DoDie>d__222 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x06002BBA RID: 11194 RVA: 0x0001D6A7 File Offset: 0x0001B8A7
			public <DoDie>d__222(int <>1__state)
			{
			}

			// Token: 0x06002BBB RID: 11195 RVA: 0x0001D6AF File Offset: 0x0001B8AF
			void IDisposable.Dispose()
			{
			}

			// Token: 0x06002BBC RID: 11196 RVA: 0x0001D6B1 File Offset: 0x0001B8B1
			bool IEnumerator.MoveNext()
			{
				return false;
			}

			// Token: 0x17000CD4 RID: 3284
			// (get) Token: 0x06002BBD RID: 11197 RVA: 0x0001D6B4 File Offset: 0x0001B8B4
			object IEnumerator<object>.Current
			{
				get
				{
					return null;
				}
			}

			// Token: 0x06002BBE RID: 11198 RVA: 0x0001D6B7 File Offset: 0x0001B8B7
			void IEnumerator.Reset()
			{
			}

			// Token: 0x17000CD5 RID: 3285
			// (get) Token: 0x06002BBF RID: 11199 RVA: 0x0001D6B9 File Offset: 0x0001B8B9
			object IEnumerator.Current
			{
				get
				{
					return null;
				}
			}

			// Token: 0x040010B0 RID: 4272
			private int <>1__state;

			// Token: 0x040010B1 RID: 4273
			private object <>2__current;

			// Token: 0x040010B2 RID: 4274
			public Player <>4__this;
		}

		// Token: 0x020003F3 RID: 1011
		private sealed class <LoadMetadata>d__207 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x06002BC0 RID: 11200 RVA: 0x0001D6BC File Offset: 0x0001B8BC
			public <LoadMetadata>d__207(int <>1__state)
			{
			}

			// Token: 0x06002BC1 RID: 11201 RVA: 0x0001D6C4 File Offset: 0x0001B8C4
			void IDisposable.Dispose()
			{
			}

			// Token: 0x06002BC2 RID: 11202 RVA: 0x0001D6C6 File Offset: 0x0001B8C6
			bool IEnumerator.MoveNext()
			{
				return false;
			}

			// Token: 0x06002BC3 RID: 11203 RVA: 0x0001D6C9 File Offset: 0x0001B8C9
			private void <>m__Finally1()
			{
			}

			// Token: 0x17000CD6 RID: 3286
			// (get) Token: 0x06002BC4 RID: 11204 RVA: 0x0001D6CB File Offset: 0x0001B8CB
			object IEnumerator<object>.Current
			{
				get
				{
					return null;
				}
			}

			// Token: 0x06002BC5 RID: 11205 RVA: 0x0001D6CE File Offset: 0x0001B8CE
			void IEnumerator.Reset()
			{
			}

			// Token: 0x17000CD7 RID: 3287
			// (get) Token: 0x06002BC6 RID: 11206 RVA: 0x0001D6D0 File Offset: 0x0001B8D0
			object IEnumerator.Current
			{
				get
				{
					return null;
				}
			}

			// Token: 0x040010B3 RID: 4275
			private int <>1__state;

			// Token: 0x040010B4 RID: 4276
			private object <>2__current;

			// Token: 0x040010B5 RID: 4277
			public Player <>4__this;

			// Token: 0x040010B6 RID: 4278
			public string authToken;

			// Token: 0x040010B7 RID: 4279
			private UnityWebRequest <uwr>5__2;
		}

		// Token: 0x020003F4 RID: 1012
		private sealed class <PostPlayerLoad>d__196 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x06002BC7 RID: 11207 RVA: 0x0001D6D3 File Offset: 0x0001B8D3
			public <PostPlayerLoad>d__196(int <>1__state)
			{
			}

			// Token: 0x06002BC8 RID: 11208 RVA: 0x0001D6DB File Offset: 0x0001B8DB
			void IDisposable.Dispose()
			{
			}

			// Token: 0x06002BC9 RID: 11209 RVA: 0x0001D6DD File Offset: 0x0001B8DD
			bool IEnumerator.MoveNext()
			{
				return false;
			}

			// Token: 0x17000CD8 RID: 3288
			// (get) Token: 0x06002BCA RID: 11210 RVA: 0x0001D6E0 File Offset: 0x0001B8E0
			object IEnumerator<object>.Current
			{
				get
				{
					return null;
				}
			}

			// Token: 0x06002BCB RID: 11211 RVA: 0x0001D6E3 File Offset: 0x0001B8E3
			void IEnumerator.Reset()
			{
			}

			// Token: 0x17000CD9 RID: 3289
			// (get) Token: 0x06002BCC RID: 11212 RVA: 0x0001D6E5 File Offset: 0x0001B8E5
			object IEnumerator.Current
			{
				get
				{
					return null;
				}
			}

			// Token: 0x040010B8 RID: 4280
			private int <>1__state;

			// Token: 0x040010B9 RID: 4281
			private object <>2__current;

			// Token: 0x040010BA RID: 4282
			public Player <>4__this;
		}

		// Token: 0x020003F5 RID: 1013
		private sealed class <StopScream>d__211 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x06002BCD RID: 11213 RVA: 0x0001D6E8 File Offset: 0x0001B8E8
			public <StopScream>d__211(int <>1__state)
			{
			}

			// Token: 0x06002BCE RID: 11214 RVA: 0x0001D6F0 File Offset: 0x0001B8F0
			void IDisposable.Dispose()
			{
			}

			// Token: 0x06002BCF RID: 11215 RVA: 0x0001D6F2 File Offset: 0x0001B8F2
			bool IEnumerator.MoveNext()
			{
				return false;
			}

			// Token: 0x17000CDA RID: 3290
			// (get) Token: 0x06002BD0 RID: 11216 RVA: 0x0001D6F5 File Offset: 0x0001B8F5
			object IEnumerator<object>.Current
			{
				get
				{
					return null;
				}
			}

			// Token: 0x06002BD1 RID: 11217 RVA: 0x0001D6F8 File Offset: 0x0001B8F8
			void IEnumerator.Reset()
			{
			}

			// Token: 0x17000CDB RID: 3291
			// (get) Token: 0x06002BD2 RID: 11218 RVA: 0x0001D6FA File Offset: 0x0001B8FA
			object IEnumerator.Current
			{
				get
				{
					return null;
				}
			}

			// Token: 0x040010BB RID: 4283
			private int <>1__state;

			// Token: 0x040010BC RID: 4284
			private object <>2__current;

			// Token: 0x040010BD RID: 4285
			public Player <>4__this;
		}
	}
}
