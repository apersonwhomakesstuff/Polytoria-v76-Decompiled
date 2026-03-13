using System;
using System.Runtime.InteropServices;
using Mirror;
using UnityEngine;

namespace Polytoria.Datamodel
{
	// Token: 0x020002AD RID: 685
	public class Spotlight : DynamicInstance
	{
		// Token: 0x06002163 RID: 8547 RVA: 0x0001B836 File Offset: 0x00019A36
		protected override void OnHide()
		{
		}

		// Token: 0x06002164 RID: 8548 RVA: 0x0001B838 File Offset: 0x00019A38
		protected override void OnShow()
		{
		}

		// Token: 0x17000A38 RID: 2616
		// (get) Token: 0x06002165 RID: 8549 RVA: 0x0001B83A File Offset: 0x00019A3A
		// (set) Token: 0x06002166 RID: 8550 RVA: 0x0001B841 File Offset: 0x00019A41
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

		// Token: 0x17000A39 RID: 2617
		// (get) Token: 0x06002167 RID: 8551 RVA: 0x0001B843 File Offset: 0x00019A43
		// (set) Token: 0x06002168 RID: 8552 RVA: 0x0001B84A File Offset: 0x00019A4A
		public float Angle
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x17000A3A RID: 2618
		// (get) Token: 0x06002169 RID: 8553 RVA: 0x0001B84C File Offset: 0x00019A4C
		// (set) Token: 0x0600216A RID: 8554 RVA: 0x0001B853 File Offset: 0x00019A53
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

		// Token: 0x17000A3B RID: 2619
		// (get) Token: 0x0600216B RID: 8555 RVA: 0x00024EB0 File Offset: 0x000230B0
		// (set) Token: 0x0600216C RID: 8556 RVA: 0x0001B855 File Offset: 0x00019A55
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

		// Token: 0x17000A3C RID: 2620
		// (get) Token: 0x0600216D RID: 8557 RVA: 0x0001B857 File Offset: 0x00019A57
		// (set) Token: 0x0600216E RID: 8558 RVA: 0x0001B85A File Offset: 0x00019A5A
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

		// Token: 0x0600216F RID: 8559 RVA: 0x0001B85C File Offset: 0x00019A5C
		protected override void Start()
		{
		}

		// Token: 0x06002170 RID: 8560 RVA: 0x0001B85E File Offset: 0x00019A5E
		protected override void CopyProperties(Instance clone)
		{
		}

		// Token: 0x06002171 RID: 8561 RVA: 0x0001B860 File Offset: 0x00019A60
		private void RpcSetRange(float range)
		{
		}

		// Token: 0x06002172 RID: 8562 RVA: 0x0001B862 File Offset: 0x00019A62
		private void RpcSetAngle(float angle)
		{
		}

		// Token: 0x06002173 RID: 8563 RVA: 0x0001B864 File Offset: 0x00019A64
		private void RpcSetBrightness(float brightness)
		{
		}

		// Token: 0x06002174 RID: 8564 RVA: 0x0001B866 File Offset: 0x00019A66
		private void RpcSetColor(Color color)
		{
		}

		// Token: 0x06002175 RID: 8565 RVA: 0x0001B868 File Offset: 0x00019A68
		private void RpcSetShadowsEnabled(bool enabled)
		{
		}

		// Token: 0x06002178 RID: 8568 RVA: 0x0001B874 File Offset: 0x00019A74
		public override bool Weaved()
		{
			return false;
		}

		// Token: 0x17000A3D RID: 2621
		// (get) Token: 0x06002179 RID: 8569 RVA: 0x0001B877 File Offset: 0x00019A77
		// (set) Token: 0x0600217A RID: 8570 RVA: 0x0001B87E File Offset: 0x00019A7E
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

		// Token: 0x17000A3E RID: 2622
		// (get) Token: 0x0600217B RID: 8571 RVA: 0x0001B880 File Offset: 0x00019A80
		// (set) Token: 0x0600217C RID: 8572 RVA: 0x0001B887 File Offset: 0x00019A87
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

		// Token: 0x17000A3F RID: 2623
		// (get) Token: 0x0600217D RID: 8573 RVA: 0x00024EC8 File Offset: 0x000230C8
		// (set) Token: 0x0600217E RID: 8574 RVA: 0x0001B889 File Offset: 0x00019A89
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

		// Token: 0x17000A40 RID: 2624
		// (get) Token: 0x0600217F RID: 8575 RVA: 0x0001B88B File Offset: 0x00019A8B
		// (set) Token: 0x06002180 RID: 8576 RVA: 0x0001B892 File Offset: 0x00019A92
		public float Networkangle
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

		// Token: 0x17000A41 RID: 2625
		// (get) Token: 0x06002181 RID: 8577 RVA: 0x0001B894 File Offset: 0x00019A94
		// (set) Token: 0x06002182 RID: 8578 RVA: 0x0001B897 File Offset: 0x00019A97
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

		// Token: 0x06002183 RID: 8579 RVA: 0x0001B899 File Offset: 0x00019A99
		protected void UserCode_RpcSetRange__Single(float range)
		{
		}

		// Token: 0x06002184 RID: 8580 RVA: 0x0001B89B File Offset: 0x00019A9B
		protected static void InvokeUserCode_RpcSetRange__Single(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		// Token: 0x06002185 RID: 8581 RVA: 0x0001B89D File Offset: 0x00019A9D
		protected void UserCode_RpcSetAngle__Single(float angle)
		{
		}

		// Token: 0x06002186 RID: 8582 RVA: 0x0001B89F File Offset: 0x00019A9F
		protected static void InvokeUserCode_RpcSetAngle__Single(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		// Token: 0x06002187 RID: 8583 RVA: 0x0001B8A1 File Offset: 0x00019AA1
		protected void UserCode_RpcSetBrightness__Single(float brightness)
		{
		}

		// Token: 0x06002188 RID: 8584 RVA: 0x0001B8A3 File Offset: 0x00019AA3
		protected static void InvokeUserCode_RpcSetBrightness__Single(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		// Token: 0x06002189 RID: 8585 RVA: 0x0001B8A5 File Offset: 0x00019AA5
		protected void UserCode_RpcSetColor__Color(Color color)
		{
		}

		// Token: 0x0600218A RID: 8586 RVA: 0x0001B8A7 File Offset: 0x00019AA7
		protected static void InvokeUserCode_RpcSetColor__Color(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		// Token: 0x0600218B RID: 8587 RVA: 0x0001B8A9 File Offset: 0x00019AA9
		protected void UserCode_RpcSetShadowsEnabled__Boolean(bool enabled)
		{
		}

		// Token: 0x0600218C RID: 8588 RVA: 0x0001B8AB File Offset: 0x00019AAB
		protected static void InvokeUserCode_RpcSetShadowsEnabled__Boolean(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		// Token: 0x0600218D RID: 8589 RVA: 0x0001B8AD File Offset: 0x00019AAD
		public override void SerializeSyncVars(NetworkWriter writer, bool forceAll)
		{
		}

		// Token: 0x0600218E RID: 8590 RVA: 0x0001B8AF File Offset: 0x00019AAF
		public override void DeserializeSyncVars(NetworkReader reader, bool initialState)
		{
		}

		// Token: 0x04000C00 RID: 3072
		private static float intensityMultiplier;

		// Token: 0x04000C01 RID: 3073
		private static float rangeMultiplier;

		// Token: 0x04000C02 RID: 3074
		private float range;

		// Token: 0x04000C03 RID: 3075
		private float brightness;

		// Token: 0x04000C04 RID: 3076
		private Color color;

		// Token: 0x04000C05 RID: 3077
		private float angle;

		// Token: 0x04000C06 RID: 3078
		private bool shadows;
	}
}
