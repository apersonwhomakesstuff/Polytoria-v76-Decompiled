using System;
using Mirror;
using Polytoria.Lua;

namespace Polytoria.Datamodel
{
	// Token: 0x02000292 RID: 658
	public class NetworkEvent : Instance
	{
		// Token: 0x06001D66 RID: 7526 RVA: 0x0001ADC8 File Offset: 0x00018FC8
		public void InvokeServer(NetMessage msg)
		{
		}

		// Token: 0x06001D67 RID: 7527 RVA: 0x0001ADCA File Offset: 0x00018FCA
		public void InvokeClient(NetMessage msg, Player player)
		{
		}

		// Token: 0x06001D68 RID: 7528 RVA: 0x0001ADCC File Offset: 0x00018FCC
		public void InvokeClients(NetMessage msg)
		{
		}

		// Token: 0x06001D69 RID: 7529 RVA: 0x0001ADCE File Offset: 0x00018FCE
		private void InvokeCmd(NetMessage msg, NetworkConnectionToClient sender = null)
		{
		}

		// Token: 0x06001D6A RID: 7530 RVA: 0x0001ADD0 File Offset: 0x00018FD0
		private void InvokeTargetRpc(NetworkConnection target, NetMessage msg)
		{
		}

		// Token: 0x06001D6B RID: 7531 RVA: 0x0001ADD2 File Offset: 0x00018FD2
		private void InvokeClientRpc(NetMessage msg)
		{
		}

		// Token: 0x06001D6D RID: 7533 RVA: 0x0001ADDC File Offset: 0x00018FDC
		public override bool Weaved()
		{
			return false;
		}

		// Token: 0x06001D6E RID: 7534 RVA: 0x0001ADDF File Offset: 0x00018FDF
		protected void UserCode_InvokeCmd__NetMessage__NetworkConnectionToClient(NetMessage msg, NetworkConnectionToClient sender)
		{
		}

		// Token: 0x06001D6F RID: 7535 RVA: 0x0001ADE1 File Offset: 0x00018FE1
		protected static void InvokeUserCode_InvokeCmd__NetMessage__NetworkConnectionToClient(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		// Token: 0x06001D70 RID: 7536 RVA: 0x0001ADE3 File Offset: 0x00018FE3
		protected void UserCode_InvokeTargetRpc__NetworkConnection__NetMessage(NetworkConnection target, NetMessage msg)
		{
		}

		// Token: 0x06001D71 RID: 7537 RVA: 0x0001ADE5 File Offset: 0x00018FE5
		protected static void InvokeUserCode_InvokeTargetRpc__NetworkConnection__NetMessage(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		// Token: 0x06001D72 RID: 7538 RVA: 0x0001ADE7 File Offset: 0x00018FE7
		protected void UserCode_InvokeClientRpc__NetMessage(NetMessage msg)
		{
		}

		// Token: 0x06001D73 RID: 7539 RVA: 0x0001ADE9 File Offset: 0x00018FE9
		protected static void InvokeUserCode_InvokeClientRpc__NetMessage(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		// Token: 0x04000AB2 RID: 2738
		public LuaEvent InvokedServer;

		// Token: 0x04000AB3 RID: 2739
		public LuaEvent InvokedClient;
	}
}
