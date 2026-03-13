using System;
using Polytoria.Lua;

namespace Polytoria.Datamodel.Proxies
{
	// Token: 0x020002E6 RID: 742
	public class NetworkEventProxy : InstanceProxy
	{
		// Token: 0x06002539 RID: 9529 RVA: 0x0001C290 File Offset: 0x0001A490
		public NetworkEventProxy(NetworkEvent target) : base(null)
		{
		}

		// Token: 0x17000B47 RID: 2887
		// (get) Token: 0x0600253A RID: 9530 RVA: 0x0001C299 File Offset: 0x0001A499
		public LuaEvent InvokedServer
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000B48 RID: 2888
		// (get) Token: 0x0600253B RID: 9531 RVA: 0x0001C29C File Offset: 0x0001A49C
		public LuaEvent InvokedClient
		{
			get
			{
				return null;
			}
		}

		// Token: 0x0600253C RID: 9532 RVA: 0x0001C29F File Offset: 0x0001A49F
		public void InvokeServer(NetMessage msg)
		{
		}

		// Token: 0x0600253D RID: 9533 RVA: 0x0001C2A1 File Offset: 0x0001A4A1
		public void InvokeClient(NetMessage msg, Player player)
		{
		}

		// Token: 0x0600253E RID: 9534 RVA: 0x0001C2A3 File Offset: 0x0001A4A3
		public void InvokeClients(NetMessage msg)
		{
		}

		// Token: 0x04000D12 RID: 3346
		private readonly NetworkEvent networkEvent;
	}
}
