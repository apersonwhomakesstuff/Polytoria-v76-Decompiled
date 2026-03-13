using System;
using Polytoria.Datamodel.Services;

namespace Polytoria.Datamodel.Proxies.Services
{
	// Token: 0x0200030A RID: 778
	public class ChatServiceProxy
	{
		// Token: 0x06002732 RID: 10034 RVA: 0x0001C878 File Offset: 0x0001AA78
		public ChatServiceProxy(ChatService target)
		{
		}

		// Token: 0x06002733 RID: 10035 RVA: 0x0001C880 File Offset: 0x0001AA80
		public void BroadcastMessage(string message)
		{
		}

		// Token: 0x06002734 RID: 10036 RVA: 0x0001C882 File Offset: 0x0001AA82
		public void UnicastMessage(string message, Player player)
		{
		}

		// Token: 0x04000D36 RID: 3382
		private readonly ChatService chatService;
	}
}
