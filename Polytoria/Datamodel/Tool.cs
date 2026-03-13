using System;
using System.Runtime.InteropServices;
using Mirror;
using Polytoria.Lua;
using UnityEngine;
using UnityEngine.Animations;

namespace Polytoria.Datamodel
{
	// Token: 0x020002B1 RID: 689
	public class Tool : DynamicInstance
	{
		// Token: 0x17000A5A RID: 2650
		// (get) Token: 0x060021E8 RID: 8680 RVA: 0x0001B97C File Offset: 0x00019B7C
		// (set) Token: 0x060021E9 RID: 8681 RVA: 0x0001B97F File Offset: 0x00019B7F
		public bool Droppable
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x17000A5B RID: 2651
		// (get) Token: 0x060021EA RID: 8682 RVA: 0x0001B981 File Offset: 0x00019B81
		protected override bool DoTransformSync
		{
			get
			{
				return false;
			}
		}

		// Token: 0x060021EB RID: 8683 RVA: 0x0001B984 File Offset: 0x00019B84
		protected override void Awake()
		{
		}

		// Token: 0x060021EC RID: 8684 RVA: 0x0001B986 File Offset: 0x00019B86
		protected override void Start()
		{
		}

		// Token: 0x060021ED RID: 8685 RVA: 0x0001B988 File Offset: 0x00019B88
		public void Play(string anim)
		{
		}

		// Token: 0x060021EE RID: 8686 RVA: 0x0001B98A File Offset: 0x00019B8A
		private void OnParentChange()
		{
		}

		// Token: 0x060021EF RID: 8687 RVA: 0x0001B98C File Offset: 0x00019B8C
		private void FixChildTransforms(DynamicInstance i)
		{
		}

		// Token: 0x060021F0 RID: 8688 RVA: 0x0001B98E File Offset: 0x00019B8E
		private void RpcUpdateChildTransform(DynamicInstance i, Vector3 pos, Quaternion rot, Vector3 size)
		{
		}

		// Token: 0x060021F1 RID: 8689 RVA: 0x0001B990 File Offset: 0x00019B90
		protected override void Update()
		{
		}

		// Token: 0x060021F2 RID: 8690 RVA: 0x0001B992 File Offset: 0x00019B92
		private void OnTouched(Instance obj)
		{
		}

		// Token: 0x060021F3 RID: 8691 RVA: 0x0001B994 File Offset: 0x00019B94
		private void CollectTool(IToolHolder holder)
		{
		}

		// Token: 0x060021F4 RID: 8692 RVA: 0x0001B996 File Offset: 0x00019B96
		private void RpcLinkTool(Instance par)
		{
		}

		// Token: 0x060021F5 RID: 8693 RVA: 0x0001B998 File Offset: 0x00019B98
		private void DoLinkTool(Instance par)
		{
		}

		// Token: 0x060021F6 RID: 8694 RVA: 0x0001B99A File Offset: 0x00019B9A
		private void OnDescendantAdded(Instance obj)
		{
		}

		// Token: 0x060021F7 RID: 8695 RVA: 0x0001B99C File Offset: 0x00019B9C
		private void RecalculateBounds()
		{
		}

		// Token: 0x060021F8 RID: 8696 RVA: 0x0001B99E File Offset: 0x00019B9E
		public void InvokeActivate()
		{
		}

		// Token: 0x060021F9 RID: 8697 RVA: 0x0001B9A0 File Offset: 0x00019BA0
		private void CmdActivate()
		{
		}

		// Token: 0x060021FA RID: 8698 RVA: 0x0001B9A2 File Offset: 0x00019BA2
		private void DoActivate()
		{
		}

		// Token: 0x060021FB RID: 8699 RVA: 0x0001B9A4 File Offset: 0x00019BA4
		private void RpcActivate()
		{
		}

		// Token: 0x060021FC RID: 8700 RVA: 0x0001B9A6 File Offset: 0x00019BA6
		public void InvokeDeactivate()
		{
		}

		// Token: 0x060021FD RID: 8701 RVA: 0x0001B9A8 File Offset: 0x00019BA8
		private void CmdDeactivate()
		{
		}

		// Token: 0x060021FE RID: 8702 RVA: 0x0001B9AA File Offset: 0x00019BAA
		private void DoDeactivate()
		{
		}

		// Token: 0x060021FF RID: 8703 RVA: 0x0001B9AC File Offset: 0x00019BAC
		private void RpcDeactivate()
		{
		}

		// Token: 0x06002200 RID: 8704 RVA: 0x0001B9AE File Offset: 0x00019BAE
		public void InvokeEquip()
		{
		}

		// Token: 0x06002201 RID: 8705 RVA: 0x0001B9B0 File Offset: 0x00019BB0
		private void CmdEquip()
		{
		}

		// Token: 0x06002202 RID: 8706 RVA: 0x0001B9B2 File Offset: 0x00019BB2
		private void DoEquip()
		{
		}

		// Token: 0x06002203 RID: 8707 RVA: 0x0001B9B4 File Offset: 0x00019BB4
		private void RpcEquip()
		{
		}

		// Token: 0x06002204 RID: 8708 RVA: 0x0001B9B6 File Offset: 0x00019BB6
		public void InvokeUnequip()
		{
		}

		// Token: 0x06002205 RID: 8709 RVA: 0x0001B9B8 File Offset: 0x00019BB8
		private void CmdUnequip()
		{
		}

		// Token: 0x06002206 RID: 8710 RVA: 0x0001B9BA File Offset: 0x00019BBA
		private void DoUnequip()
		{
		}

		// Token: 0x06002207 RID: 8711 RVA: 0x0001B9BC File Offset: 0x00019BBC
		private void RpcUnequip()
		{
		}

		// Token: 0x06002208 RID: 8712 RVA: 0x0001B9BE File Offset: 0x00019BBE
		protected override void CopyProperties(Instance clone)
		{
		}

		// Token: 0x06002209 RID: 8713 RVA: 0x0001B9C0 File Offset: 0x00019BC0
		protected override void OnHide()
		{
		}

		// Token: 0x0600220A RID: 8714 RVA: 0x0001B9C2 File Offset: 0x00019BC2
		protected override void OnShow()
		{
		}

		// Token: 0x0600220C RID: 8716 RVA: 0x0001B9CC File Offset: 0x00019BCC
		public override bool Weaved()
		{
			return false;
		}

		// Token: 0x17000A5C RID: 2652
		// (get) Token: 0x0600220D RID: 8717 RVA: 0x0001B9CF File Offset: 0x00019BCF
		// (set) Token: 0x0600220E RID: 8718 RVA: 0x0001B9D2 File Offset: 0x00019BD2
		public bool Networkdroppable
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

		// Token: 0x0600220F RID: 8719 RVA: 0x0001B9D4 File Offset: 0x00019BD4
		protected void UserCode_RpcUpdateChildTransform__DynamicInstance__Vector3__Quaternion__Vector3(DynamicInstance i, Vector3 pos, Quaternion rot, Vector3 size)
		{
		}

		// Token: 0x06002210 RID: 8720 RVA: 0x0001B9D6 File Offset: 0x00019BD6
		protected static void InvokeUserCode_RpcUpdateChildTransform__DynamicInstance__Vector3__Quaternion__Vector3(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		// Token: 0x06002211 RID: 8721 RVA: 0x0001B9D8 File Offset: 0x00019BD8
		protected void UserCode_RpcLinkTool__Instance(Instance par)
		{
		}

		// Token: 0x06002212 RID: 8722 RVA: 0x0001B9DA File Offset: 0x00019BDA
		protected static void InvokeUserCode_RpcLinkTool__Instance(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		// Token: 0x06002213 RID: 8723 RVA: 0x0001B9DC File Offset: 0x00019BDC
		protected void UserCode_CmdActivate()
		{
		}

		// Token: 0x06002214 RID: 8724 RVA: 0x0001B9DE File Offset: 0x00019BDE
		protected static void InvokeUserCode_CmdActivate(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		// Token: 0x06002215 RID: 8725 RVA: 0x0001B9E0 File Offset: 0x00019BE0
		protected void UserCode_RpcActivate()
		{
		}

		// Token: 0x06002216 RID: 8726 RVA: 0x0001B9E2 File Offset: 0x00019BE2
		protected static void InvokeUserCode_RpcActivate(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		// Token: 0x06002217 RID: 8727 RVA: 0x0001B9E4 File Offset: 0x00019BE4
		protected void UserCode_CmdDeactivate()
		{
		}

		// Token: 0x06002218 RID: 8728 RVA: 0x0001B9E6 File Offset: 0x00019BE6
		protected static void InvokeUserCode_CmdDeactivate(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		// Token: 0x06002219 RID: 8729 RVA: 0x0001B9E8 File Offset: 0x00019BE8
		protected void UserCode_RpcDeactivate()
		{
		}

		// Token: 0x0600221A RID: 8730 RVA: 0x0001B9EA File Offset: 0x00019BEA
		protected static void InvokeUserCode_RpcDeactivate(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		// Token: 0x0600221B RID: 8731 RVA: 0x0001B9EC File Offset: 0x00019BEC
		protected void UserCode_CmdEquip()
		{
		}

		// Token: 0x0600221C RID: 8732 RVA: 0x0001B9EE File Offset: 0x00019BEE
		protected static void InvokeUserCode_CmdEquip(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		// Token: 0x0600221D RID: 8733 RVA: 0x0001B9F0 File Offset: 0x00019BF0
		protected void UserCode_RpcEquip()
		{
		}

		// Token: 0x0600221E RID: 8734 RVA: 0x0001B9F2 File Offset: 0x00019BF2
		protected static void InvokeUserCode_RpcEquip(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		// Token: 0x0600221F RID: 8735 RVA: 0x0001B9F4 File Offset: 0x00019BF4
		protected void UserCode_CmdUnequip()
		{
		}

		// Token: 0x06002220 RID: 8736 RVA: 0x0001B9F6 File Offset: 0x00019BF6
		protected static void InvokeUserCode_CmdUnequip(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		// Token: 0x06002221 RID: 8737 RVA: 0x0001B9F8 File Offset: 0x00019BF8
		protected void UserCode_RpcUnequip()
		{
		}

		// Token: 0x06002222 RID: 8738 RVA: 0x0001B9FA File Offset: 0x00019BFA
		protected static void InvokeUserCode_RpcUnequip(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		// Token: 0x06002224 RID: 8740 RVA: 0x0001B9FE File Offset: 0x00019BFE
		public override void SerializeSyncVars(NetworkWriter writer, bool forceAll)
		{
		}

		// Token: 0x06002225 RID: 8741 RVA: 0x0001BA00 File Offset: 0x00019C00
		public override void DeserializeSyncVars(NetworkReader reader, bool initialState)
		{
		}

		// Token: 0x04000C1C RID: 3100
		private Renderer _renderer;

		// Token: 0x04000C1D RID: 3101
		private BoxCollider col;

		// Token: 0x04000C1E RID: 3102
		private Rigidbody rb;

		// Token: 0x04000C1F RID: 3103
		private ParentConstraint parentConstraint;

		// Token: 0x04000C20 RID: 3104
		public LuaEvent Activated;

		// Token: 0x04000C21 RID: 3105
		public LuaEvent Deactivated;

		// Token: 0x04000C22 RID: 3106
		public LuaEvent Equipped;

		// Token: 0x04000C23 RID: 3107
		public LuaEvent Unequipped;

		// Token: 0x04000C24 RID: 3108
		private float pickupCooldown;

		// Token: 0x04000C25 RID: 3109
		private bool droppable;
	}
}
