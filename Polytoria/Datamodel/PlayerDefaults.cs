using System;
using System.Runtime.InteropServices;
using Mirror;
using UnityEngine;

namespace Polytoria.Datamodel
{
	// Token: 0x020002A1 RID: 673
	public class PlayerDefaults : Instance
	{
		// Token: 0x170009F1 RID: 2545
		// (get) Token: 0x06002027 RID: 8231 RVA: 0x0001B49F File Offset: 0x0001969F
		// (set) Token: 0x06002028 RID: 8232 RVA: 0x0001B4A6 File Offset: 0x000196A6
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

		// Token: 0x170009F2 RID: 2546
		// (get) Token: 0x06002029 RID: 8233 RVA: 0x0001B4A8 File Offset: 0x000196A8
		// (set) Token: 0x0600202A RID: 8234 RVA: 0x0001B4AF File Offset: 0x000196AF
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

		// Token: 0x170009F3 RID: 2547
		// (get) Token: 0x0600202B RID: 8235 RVA: 0x0001B4B1 File Offset: 0x000196B1
		// (set) Token: 0x0600202C RID: 8236 RVA: 0x0001B4B8 File Offset: 0x000196B8
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

		// Token: 0x170009F4 RID: 2548
		// (get) Token: 0x0600202D RID: 8237 RVA: 0x0001B4BA File Offset: 0x000196BA
		// (set) Token: 0x0600202E RID: 8238 RVA: 0x0001B4BD File Offset: 0x000196BD
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

		// Token: 0x170009F5 RID: 2549
		// (get) Token: 0x0600202F RID: 8239 RVA: 0x0001B4BF File Offset: 0x000196BF
		// (set) Token: 0x06002030 RID: 8240 RVA: 0x0001B4C6 File Offset: 0x000196C6
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

		// Token: 0x170009F6 RID: 2550
		// (get) Token: 0x06002031 RID: 8241 RVA: 0x0001B4C8 File Offset: 0x000196C8
		// (set) Token: 0x06002032 RID: 8242 RVA: 0x0001B4CF File Offset: 0x000196CF
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

		// Token: 0x170009F7 RID: 2551
		// (get) Token: 0x06002033 RID: 8243 RVA: 0x0001B4D1 File Offset: 0x000196D1
		// (set) Token: 0x06002034 RID: 8244 RVA: 0x0001B4D8 File Offset: 0x000196D8
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

		// Token: 0x170009F8 RID: 2552
		// (get) Token: 0x06002035 RID: 8245 RVA: 0x0001B4DA File Offset: 0x000196DA
		// (set) Token: 0x06002036 RID: 8246 RVA: 0x0001B4E1 File Offset: 0x000196E1
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

		// Token: 0x170009F9 RID: 2553
		// (get) Token: 0x06002037 RID: 8247 RVA: 0x0001B4E3 File Offset: 0x000196E3
		// (set) Token: 0x06002038 RID: 8248 RVA: 0x0001B4EA File Offset: 0x000196EA
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

		// Token: 0x170009FA RID: 2554
		// (get) Token: 0x06002039 RID: 8249 RVA: 0x00024DC0 File Offset: 0x00022FC0
		// (set) Token: 0x0600203A RID: 8250 RVA: 0x0001B4EC File Offset: 0x000196EC
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

		// Token: 0x0600203B RID: 8251 RVA: 0x0001B4EE File Offset: 0x000196EE
		protected override void Awake()
		{
		}

		// Token: 0x0600203C RID: 8252 RVA: 0x0001B4F0 File Offset: 0x000196F0
		protected override void Start()
		{
		}

		// Token: 0x0600203D RID: 8253 RVA: 0x0001B4F2 File Offset: 0x000196F2
		public void LoadDefaults(Player player)
		{
		}

		// Token: 0x0600203E RID: 8254 RVA: 0x0001B4F4 File Offset: 0x000196F4
		private void CmdLoadDefaults(Player player)
		{
		}

		// Token: 0x06002040 RID: 8256 RVA: 0x0001B4FE File Offset: 0x000196FE
		public override bool Weaved()
		{
			return false;
		}

		// Token: 0x170009FB RID: 2555
		// (get) Token: 0x06002041 RID: 8257 RVA: 0x0001B501 File Offset: 0x00019701
		// (set) Token: 0x06002042 RID: 8258 RVA: 0x0001B508 File Offset: 0x00019708
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

		// Token: 0x170009FC RID: 2556
		// (get) Token: 0x06002043 RID: 8259 RVA: 0x0001B50A File Offset: 0x0001970A
		// (set) Token: 0x06002044 RID: 8260 RVA: 0x0001B511 File Offset: 0x00019711
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

		// Token: 0x170009FD RID: 2557
		// (get) Token: 0x06002045 RID: 8261 RVA: 0x0001B513 File Offset: 0x00019713
		// (set) Token: 0x06002046 RID: 8262 RVA: 0x0001B51A File Offset: 0x0001971A
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

		// Token: 0x170009FE RID: 2558
		// (get) Token: 0x06002047 RID: 8263 RVA: 0x0001B51C File Offset: 0x0001971C
		// (set) Token: 0x06002048 RID: 8264 RVA: 0x0001B51F File Offset: 0x0001971F
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

		// Token: 0x170009FF RID: 2559
		// (get) Token: 0x06002049 RID: 8265 RVA: 0x0001B521 File Offset: 0x00019721
		// (set) Token: 0x0600204A RID: 8266 RVA: 0x0001B528 File Offset: 0x00019728
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

		// Token: 0x17000A00 RID: 2560
		// (get) Token: 0x0600204B RID: 8267 RVA: 0x0001B52A File Offset: 0x0001972A
		// (set) Token: 0x0600204C RID: 8268 RVA: 0x0001B531 File Offset: 0x00019731
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

		// Token: 0x17000A01 RID: 2561
		// (get) Token: 0x0600204D RID: 8269 RVA: 0x0001B533 File Offset: 0x00019733
		// (set) Token: 0x0600204E RID: 8270 RVA: 0x0001B53A File Offset: 0x0001973A
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

		// Token: 0x17000A02 RID: 2562
		// (get) Token: 0x0600204F RID: 8271 RVA: 0x0001B53C File Offset: 0x0001973C
		// (set) Token: 0x06002050 RID: 8272 RVA: 0x0001B543 File Offset: 0x00019743
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

		// Token: 0x17000A03 RID: 2563
		// (get) Token: 0x06002051 RID: 8273 RVA: 0x0001B545 File Offset: 0x00019745
		// (set) Token: 0x06002052 RID: 8274 RVA: 0x0001B54C File Offset: 0x0001974C
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

		// Token: 0x17000A04 RID: 2564
		// (get) Token: 0x06002053 RID: 8275 RVA: 0x00024DD8 File Offset: 0x00022FD8
		// (set) Token: 0x06002054 RID: 8276 RVA: 0x0001B54E File Offset: 0x0001974E
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

		// Token: 0x06002055 RID: 8277 RVA: 0x0001B550 File Offset: 0x00019750
		protected void UserCode_CmdLoadDefaults__Player(Player player)
		{
		}

		// Token: 0x06002056 RID: 8278 RVA: 0x0001B552 File Offset: 0x00019752
		protected static void InvokeUserCode_CmdLoadDefaults__Player(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		// Token: 0x06002058 RID: 8280 RVA: 0x0001B556 File Offset: 0x00019756
		public override void SerializeSyncVars(NetworkWriter writer, bool forceAll)
		{
		}

		// Token: 0x06002059 RID: 8281 RVA: 0x0001B558 File Offset: 0x00019758
		public override void DeserializeSyncVars(NetworkReader reader, bool initialState)
		{
		}

		// Token: 0x04000BC3 RID: 3011
		private float maxHealth;

		// Token: 0x04000BC4 RID: 3012
		private float walkSpeed;

		// Token: 0x04000BC5 RID: 3013
		private float sprintSpeed;

		// Token: 0x04000BC6 RID: 3014
		private bool staminaEnabled;

		// Token: 0x04000BC7 RID: 3015
		private float stamina;

		// Token: 0x04000BC8 RID: 3016
		private float maxStamina;

		// Token: 0x04000BC9 RID: 3017
		private float staminaRegen;

		// Token: 0x04000BCA RID: 3018
		private float jumpPower;

		// Token: 0x04000BCB RID: 3019
		private float respawnTime;

		// Token: 0x04000BCC RID: 3020
		private Color chatColor;
	}
}
