using System;
using System.Collections;
using System.Collections.Generic;
using Mirror;
using UnityEngine;
using UnityEngine.Networking;

namespace Polytoria.Datamodel.Services
{
	// Token: 0x020002C2 RID: 706
	public class ChatService : NetworkBehaviour
	{
		// Token: 0x0600239B RID: 9115 RVA: 0x0001BD8B File Offset: 0x00019F8B
		private void Awake()
		{
		}

		// Token: 0x0600239C RID: 9116 RVA: 0x0001BD8D File Offset: 0x00019F8D
		public void BroadcastMessage(string message)
		{
		}

		// Token: 0x0600239D RID: 9117 RVA: 0x0001BD8F File Offset: 0x00019F8F
		public void UnicastMessage(string message, Player player)
		{
		}

		// Token: 0x0600239E RID: 9118 RVA: 0x0001BD91 File Offset: 0x00019F91
		public void SendChat(string message)
		{
		}

		// Token: 0x0600239F RID: 9119 RVA: 0x0001BD93 File Offset: 0x00019F93
		private string FilterChatExploits(string message)
		{
			return null;
		}

		// Token: 0x060023A0 RID: 9120 RVA: 0x0001BD96 File Offset: 0x00019F96
		private void DoSendChat(string message, Color color, Player player)
		{
		}

		// Token: 0x060023A1 RID: 9121 RVA: 0x0001BD98 File Offset: 0x00019F98
		private IEnumerator LogChatMessage(int userId, string message)
		{
			return null;
		}

		// Token: 0x060023A2 RID: 9122 RVA: 0x0001BD9B File Offset: 0x00019F9B
		private void CmdSendChat(string message, NetworkConnectionToClient sender = null)
		{
		}

		// Token: 0x060023A3 RID: 9123 RVA: 0x0001BD9D File Offset: 0x00019F9D
		private void SendChatClientRpc(string message, string username, Color color, Player player)
		{
		}

		// Token: 0x060023A4 RID: 9124 RVA: 0x0001BD9F File Offset: 0x00019F9F
		private void SendChatTargetRpc(NetworkConnection target, string message, string username, Color color)
		{
		}

		// Token: 0x060023A5 RID: 9125 RVA: 0x0001BDA1 File Offset: 0x00019FA1
		public new void Invoke(string methodName, float time)
		{
		}

		// Token: 0x060023A6 RID: 9126 RVA: 0x0001BDA3 File Offset: 0x00019FA3
		public new void InvokeRepeating(string methodName, float time, float repeatRate)
		{
		}

		// Token: 0x060023A8 RID: 9128 RVA: 0x0001BDAD File Offset: 0x00019FAD
		public override bool Weaved()
		{
			return false;
		}

		// Token: 0x060023A9 RID: 9129 RVA: 0x0001BDB0 File Offset: 0x00019FB0
		protected void UserCode_CmdSendChat__String__NetworkConnectionToClient(string message, NetworkConnectionToClient sender)
		{
		}

		// Token: 0x060023AA RID: 9130 RVA: 0x0001BDB2 File Offset: 0x00019FB2
		protected static void InvokeUserCode_CmdSendChat__String__NetworkConnectionToClient(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		// Token: 0x060023AB RID: 9131 RVA: 0x0001BDB4 File Offset: 0x00019FB4
		protected void UserCode_SendChatClientRpc__String__String__Color__Player(string message, string username, Color color, Player player)
		{
		}

		// Token: 0x060023AC RID: 9132 RVA: 0x0001BDB6 File Offset: 0x00019FB6
		protected static void InvokeUserCode_SendChatClientRpc__String__String__Color__Player(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		// Token: 0x060023AD RID: 9133 RVA: 0x0001BDB8 File Offset: 0x00019FB8
		protected void UserCode_SendChatTargetRpc__NetworkConnection__String__String__Color(NetworkConnection target, string message, string username, Color color)
		{
		}

		// Token: 0x060023AE RID: 9134 RVA: 0x0001BDBA File Offset: 0x00019FBA
		protected static void InvokeUserCode_SendChatTargetRpc__NetworkConnection__String__String__Color(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		// Token: 0x04000CC2 RID: 3266
		public const int MaxMessageLength = 128;

		// Token: 0x04000CC3 RID: 3267
		public static ChatService Instance;

		// Token: 0x04000CC4 RID: 3268
		private Players _players;

		// Token: 0x020003FD RID: 1021
		private sealed class <LogChatMessage>d__9 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x06002BF5 RID: 11253 RVA: 0x0001D775 File Offset: 0x0001B975
			public <LogChatMessage>d__9(int <>1__state)
			{
			}

			// Token: 0x06002BF6 RID: 11254 RVA: 0x0001D77D File Offset: 0x0001B97D
			void IDisposable.Dispose()
			{
			}

			// Token: 0x06002BF7 RID: 11255 RVA: 0x0001D77F File Offset: 0x0001B97F
			bool IEnumerator.MoveNext()
			{
				return false;
			}

			// Token: 0x06002BF8 RID: 11256 RVA: 0x0001D782 File Offset: 0x0001B982
			private void <>m__Finally1()
			{
			}

			// Token: 0x17000CE6 RID: 3302
			// (get) Token: 0x06002BF9 RID: 11257 RVA: 0x0001D784 File Offset: 0x0001B984
			object IEnumerator<object>.Current
			{
				get
				{
					return null;
				}
			}

			// Token: 0x06002BFA RID: 11258 RVA: 0x0001D787 File Offset: 0x0001B987
			void IEnumerator.Reset()
			{
			}

			// Token: 0x17000CE7 RID: 3303
			// (get) Token: 0x06002BFB RID: 11259 RVA: 0x0001D789 File Offset: 0x0001B989
			object IEnumerator.Current
			{
				get
				{
					return null;
				}
			}

			// Token: 0x040010DD RID: 4317
			private int <>1__state;

			// Token: 0x040010DE RID: 4318
			private object <>2__current;

			// Token: 0x040010DF RID: 4319
			public ChatService <>4__this;

			// Token: 0x040010E0 RID: 4320
			public int userId;

			// Token: 0x040010E1 RID: 4321
			public string message;

			// Token: 0x040010E2 RID: 4322
			private UnityWebRequest <uwr>5__2;
		}
	}
}
