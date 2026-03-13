using System;
using System.Runtime.InteropServices;
using Mirror;
using UnityEngine;

namespace Polytoria.Datamodel
{
	// Token: 0x020002A4 RID: 676
	public class PointLight : DynamicInstance
	{
		// Token: 0x06002086 RID: 8326 RVA: 0x0001B5D3 File Offset: 0x000197D3
		protected override void OnHide()
		{
		}

		// Token: 0x06002087 RID: 8327 RVA: 0x0001B5D5 File Offset: 0x000197D5
		protected override void OnShow()
		{
		}

		// Token: 0x17000A0C RID: 2572
		// (get) Token: 0x06002088 RID: 8328 RVA: 0x0001B5D7 File Offset: 0x000197D7
		// (set) Token: 0x06002089 RID: 8329 RVA: 0x0001B5DE File Offset: 0x000197DE
		public float Range
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x17000A0D RID: 2573
		// (get) Token: 0x0600208A RID: 8330 RVA: 0x0001B5E0 File Offset: 0x000197E0
		// (set) Token: 0x0600208B RID: 8331 RVA: 0x0001B5E7 File Offset: 0x000197E7
		public float Brightness
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x17000A0E RID: 2574
		// (get) Token: 0x0600208C RID: 8332 RVA: 0x00024DF0 File Offset: 0x00022FF0
		// (set) Token: 0x0600208D RID: 8333 RVA: 0x0001B5E9 File Offset: 0x000197E9
		public Color Color
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		// Token: 0x17000A0F RID: 2575
		// (get) Token: 0x0600208E RID: 8334 RVA: 0x0001B5EB File Offset: 0x000197EB
		// (set) Token: 0x0600208F RID: 8335 RVA: 0x0001B5EE File Offset: 0x000197EE
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

		// Token: 0x06002090 RID: 8336 RVA: 0x0001B5F0 File Offset: 0x000197F0
		protected override void Start()
		{
		}

		// Token: 0x06002091 RID: 8337 RVA: 0x0001B5F2 File Offset: 0x000197F2
		protected override void CopyProperties(Instance clone)
		{
		}

		// Token: 0x06002092 RID: 8338 RVA: 0x0001B5F4 File Offset: 0x000197F4
		private void RpcSetRange(float range)
		{
		}

		// Token: 0x06002093 RID: 8339 RVA: 0x0001B5F6 File Offset: 0x000197F6
		private void RpcSetBrightness(float brightness)
		{
		}

		// Token: 0x06002094 RID: 8340 RVA: 0x0001B5F8 File Offset: 0x000197F8
		private void RpcSetColor(Color color)
		{
		}

		// Token: 0x06002095 RID: 8341 RVA: 0x0001B5FA File Offset: 0x000197FA
		private void RpcSetShadowsEnabled(bool enabled)
		{
		}

		// Token: 0x06002098 RID: 8344 RVA: 0x0001B606 File Offset: 0x00019806
		public override bool Weaved()
		{
			return false;
		}

		// Token: 0x17000A10 RID: 2576
		// (get) Token: 0x06002099 RID: 8345 RVA: 0x0001B609 File Offset: 0x00019809
		// (set) Token: 0x0600209A RID: 8346 RVA: 0x0001B610 File Offset: 0x00019810
		public float Networkrange
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

		// Token: 0x17000A11 RID: 2577
		// (get) Token: 0x0600209B RID: 8347 RVA: 0x0001B612 File Offset: 0x00019812
		// (set) Token: 0x0600209C RID: 8348 RVA: 0x0001B619 File Offset: 0x00019819
		public float Networkbrightness
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

		// Token: 0x17000A12 RID: 2578
		// (get) Token: 0x0600209D RID: 8349 RVA: 0x00024E08 File Offset: 0x00023008
		// (set) Token: 0x0600209E RID: 8350 RVA: 0x0001B61B File Offset: 0x0001981B
		public Color Networkcolor
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

		// Token: 0x17000A13 RID: 2579
		// (get) Token: 0x0600209F RID: 8351 RVA: 0x0001B61D File Offset: 0x0001981D
		// (set) Token: 0x060020A0 RID: 8352 RVA: 0x0001B620 File Offset: 0x00019820
		public bool Networkshadows
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

		// Token: 0x060020A1 RID: 8353 RVA: 0x0001B622 File Offset: 0x00019822
		protected void UserCode_RpcSetRange__Single(float range)
		{
		}

		// Token: 0x060020A2 RID: 8354 RVA: 0x0001B624 File Offset: 0x00019824
		protected static void InvokeUserCode_RpcSetRange__Single(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		// Token: 0x060020A3 RID: 8355 RVA: 0x0001B626 File Offset: 0x00019826
		protected void UserCode_RpcSetBrightness__Single(float brightness)
		{
		}

		// Token: 0x060020A4 RID: 8356 RVA: 0x0001B628 File Offset: 0x00019828
		protected static void InvokeUserCode_RpcSetBrightness__Single(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		// Token: 0x060020A5 RID: 8357 RVA: 0x0001B62A File Offset: 0x0001982A
		protected void UserCode_RpcSetColor__Color(Color color)
		{
		}

		// Token: 0x060020A6 RID: 8358 RVA: 0x0001B62C File Offset: 0x0001982C
		protected static void InvokeUserCode_RpcSetColor__Color(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		// Token: 0x060020A7 RID: 8359 RVA: 0x0001B62E File Offset: 0x0001982E
		protected void UserCode_RpcSetShadowsEnabled__Boolean(bool enabled)
		{
		}

		// Token: 0x060020A8 RID: 8360 RVA: 0x0001B630 File Offset: 0x00019830
		protected static void InvokeUserCode_RpcSetShadowsEnabled__Boolean(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		// Token: 0x060020A9 RID: 8361 RVA: 0x0001B632 File Offset: 0x00019832
		public override void SerializeSyncVars(NetworkWriter writer, bool forceAll)
		{
		}

		// Token: 0x060020AA RID: 8362 RVA: 0x0001B634 File Offset: 0x00019834
		public override void DeserializeSyncVars(NetworkReader reader, bool initialState)
		{
		}

		// Token: 0x04000BD6 RID: 3030
		private static float intensityMultiplier;

		// Token: 0x04000BD7 RID: 3031
		private static float rangeMultiplier;

		// Token: 0x04000BD8 RID: 3032
		private float range;

		// Token: 0x04000BD9 RID: 3033
		private float brightness;

		// Token: 0x04000BDA RID: 3034
		private Color color;

		// Token: 0x04000BDB RID: 3035
		private bool shadows;
	}
}
