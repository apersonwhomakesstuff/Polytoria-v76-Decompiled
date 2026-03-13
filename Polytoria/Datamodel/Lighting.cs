using System;
using System.Runtime.InteropServices;
using Mirror;
using UnityEngine;

namespace Polytoria.Datamodel
{
	// Token: 0x0200028A RID: 650
	public class Lighting : Instance
	{
		// Token: 0x17000930 RID: 2352
		// (get) Token: 0x06001D0D RID: 7437 RVA: 0x000246D0 File Offset: 0x000228D0
		// (set) Token: 0x06001D0E RID: 7438 RVA: 0x0001ACBA File Offset: 0x00018EBA
		public Color AmbientColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		// Token: 0x17000931 RID: 2353
		// (get) Token: 0x06001D0F RID: 7439 RVA: 0x000246E8 File Offset: 0x000228E8
		// (set) Token: 0x06001D10 RID: 7440 RVA: 0x0001ACBC File Offset: 0x00018EBC
		public AmbientSource AmbientSource
		{
			get
			{
				return AmbientSource.Skybox;
			}
			set
			{
			}
		}

		// Token: 0x17000932 RID: 2354
		// (get) Token: 0x06001D11 RID: 7441 RVA: 0x0001ACBE File Offset: 0x00018EBE
		// (set) Token: 0x06001D12 RID: 7442 RVA: 0x0001ACC1 File Offset: 0x00018EC1
		public bool Shadows
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x17000933 RID: 2355
		// (get) Token: 0x06001D13 RID: 7443 RVA: 0x0001ACC3 File Offset: 0x00018EC3
		// (set) Token: 0x06001D14 RID: 7444 RVA: 0x0001ACCA File Offset: 0x00018ECA
		public float SunBrightness
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x17000934 RID: 2356
		// (get) Token: 0x06001D15 RID: 7445 RVA: 0x00024700 File Offset: 0x00022900
		// (set) Token: 0x06001D16 RID: 7446 RVA: 0x0001ACCC File Offset: 0x00018ECC
		public Color SunColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		// Token: 0x06001D17 RID: 7447 RVA: 0x0001ACCE File Offset: 0x00018ECE
		protected override void Awake()
		{
		}

		// Token: 0x06001D18 RID: 7448 RVA: 0x0001ACD0 File Offset: 0x00018ED0
		protected override void Start()
		{
		}

		// Token: 0x06001D19 RID: 7449 RVA: 0x0001ACD2 File Offset: 0x00018ED2
		private void RpcSetAmbientColor(Color c)
		{
		}

		// Token: 0x06001D1A RID: 7450 RVA: 0x0001ACD4 File Offset: 0x00018ED4
		private void RpcSetAmbientSource(AmbientSource source)
		{
		}

		// Token: 0x06001D1C RID: 7452 RVA: 0x0001ACDE File Offset: 0x00018EDE
		public override bool Weaved()
		{
			return false;
		}

		// Token: 0x17000935 RID: 2357
		// (get) Token: 0x06001D1D RID: 7453 RVA: 0x00024718 File Offset: 0x00022918
		// (set) Token: 0x06001D1E RID: 7454 RVA: 0x0001ACE1 File Offset: 0x00018EE1
		public Color NetworkambientColor
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

		// Token: 0x17000936 RID: 2358
		// (get) Token: 0x06001D1F RID: 7455 RVA: 0x00024730 File Offset: 0x00022930
		// (set) Token: 0x06001D20 RID: 7456 RVA: 0x0001ACE3 File Offset: 0x00018EE3
		public AmbientSource NetworkambientSource
		{
			get
			{
				return AmbientSource.Skybox;
			}
			[param: In]
			set
			{
			}
		}

		// Token: 0x06001D21 RID: 7457 RVA: 0x0001ACE5 File Offset: 0x00018EE5
		protected void UserCode_RpcSetAmbientColor__Color(Color c)
		{
		}

		// Token: 0x06001D22 RID: 7458 RVA: 0x0001ACE7 File Offset: 0x00018EE7
		protected static void InvokeUserCode_RpcSetAmbientColor__Color(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		// Token: 0x06001D23 RID: 7459 RVA: 0x0001ACE9 File Offset: 0x00018EE9
		protected void UserCode_RpcSetAmbientSource__AmbientSource(AmbientSource source)
		{
		}

		// Token: 0x06001D24 RID: 7460 RVA: 0x0001ACEB File Offset: 0x00018EEB
		protected static void InvokeUserCode_RpcSetAmbientSource__AmbientSource(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		// Token: 0x06001D26 RID: 7462 RVA: 0x0001ACEF File Offset: 0x00018EEF
		public override void SerializeSyncVars(NetworkWriter writer, bool forceAll)
		{
		}

		// Token: 0x06001D27 RID: 7463 RVA: 0x0001ACF1 File Offset: 0x00018EF1
		public override void DeserializeSyncVars(NetworkReader reader, bool initialState)
		{
		}

		// Token: 0x04000A9B RID: 2715
		private Color ambientColor;

		// Token: 0x04000A9C RID: 2716
		private AmbientSource ambientSource;

		// Token: 0x04000A9D RID: 2717
		private SunLight sun;
	}
}
