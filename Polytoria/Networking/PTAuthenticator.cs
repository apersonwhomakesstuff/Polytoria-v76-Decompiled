using System;
using System.Collections;
using System.Collections.Generic;
using Mirror;
using SimpleJSON;
using UnityEngine.Networking;

namespace Polytoria.Networking
{
	// Token: 0x0200025E RID: 606
	public class PTAuthenticator : NetworkAuthenticator
	{
		// Token: 0x06001A09 RID: 6665 RVA: 0x0001A434 File Offset: 0x00018634
		public override void OnStartServer()
		{
		}

		// Token: 0x06001A0A RID: 6666 RVA: 0x0001A436 File Offset: 0x00018636
		public override void OnServerAuthenticate(NetworkConnectionToClient conn)
		{
		}

		// Token: 0x06001A0B RID: 6667 RVA: 0x0001A438 File Offset: 0x00018638
		public void OnAuthRequestMessage(NetworkConnectionToClient conn, PTAuthenticator.AuthRequestMessage msg)
		{
		}

		// Token: 0x06001A0C RID: 6668 RVA: 0x0001A43A File Offset: 0x0001863A
		public IEnumerator ValidateToken(NetworkConnectionToClient conn, PTAuthenticator.AuthRequestMessage msg)
		{
			return null;
		}

		// Token: 0x06001A0D RID: 6669 RVA: 0x0001A43D File Offset: 0x0001863D
		public IEnumerator DelayedDisconnect(NetworkConnectionToClient conn, float waitTime)
		{
			return null;
		}

		// Token: 0x06001A0E RID: 6670 RVA: 0x0001A440 File Offset: 0x00018640
		public override void OnStartClient()
		{
		}

		// Token: 0x06001A0F RID: 6671 RVA: 0x0001A442 File Offset: 0x00018642
		public override void OnClientAuthenticate()
		{
		}

		// Token: 0x06001A10 RID: 6672 RVA: 0x0001A444 File Offset: 0x00018644
		public void OnAuthResponseMessage(PTAuthenticator.AuthResponseMessage msg)
		{
		}

		// Token: 0x020003DF RID: 991
		public struct AuthRequestMessage : NetworkMessage
		{
			// Token: 0x0400105F RID: 4191
			public string clientToken;

			// Token: 0x04001060 RID: 4192
			public int localUserId;
		}

		// Token: 0x020003E0 RID: 992
		public struct AuthResponseMessage : NetworkMessage
		{
			// Token: 0x04001061 RID: 4193
			public byte code;

			// Token: 0x04001062 RID: 4194
			public string message;

			// Token: 0x04001063 RID: 4195
			public int instanceCount;
		}

		// Token: 0x020003E1 RID: 993
		private sealed class <DelayedDisconnect>d__6 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x06002B63 RID: 11107 RVA: 0x0001D565 File Offset: 0x0001B765
			public <DelayedDisconnect>d__6(int <>1__state)
			{
			}

			// Token: 0x06002B64 RID: 11108 RVA: 0x0001D56D File Offset: 0x0001B76D
			void IDisposable.Dispose()
			{
			}

			// Token: 0x06002B65 RID: 11109 RVA: 0x0001D56F File Offset: 0x0001B76F
			bool IEnumerator.MoveNext()
			{
				return false;
			}

			// Token: 0x17000CBC RID: 3260
			// (get) Token: 0x06002B66 RID: 11110 RVA: 0x0001D572 File Offset: 0x0001B772
			object IEnumerator<object>.Current
			{
				get
				{
					return null;
				}
			}

			// Token: 0x06002B67 RID: 11111 RVA: 0x0001D575 File Offset: 0x0001B775
			void IEnumerator.Reset()
			{
			}

			// Token: 0x17000CBD RID: 3261
			// (get) Token: 0x06002B68 RID: 11112 RVA: 0x0001D577 File Offset: 0x0001B777
			object IEnumerator.Current
			{
				get
				{
					return null;
				}
			}

			// Token: 0x04001064 RID: 4196
			private int <>1__state;

			// Token: 0x04001065 RID: 4197
			private object <>2__current;

			// Token: 0x04001066 RID: 4198
			public float waitTime;

			// Token: 0x04001067 RID: 4199
			public NetworkConnectionToClient conn;
		}

		// Token: 0x020003E2 RID: 994
		private sealed class <ValidateToken>d__5 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x06002B69 RID: 11113 RVA: 0x0001D57A File Offset: 0x0001B77A
			public <ValidateToken>d__5(int <>1__state)
			{
			}

			// Token: 0x06002B6A RID: 11114 RVA: 0x0001D582 File Offset: 0x0001B782
			void IDisposable.Dispose()
			{
			}

			// Token: 0x06002B6B RID: 11115 RVA: 0x0001D584 File Offset: 0x0001B784
			bool IEnumerator.MoveNext()
			{
				return false;
			}

			// Token: 0x06002B6C RID: 11116 RVA: 0x0001D587 File Offset: 0x0001B787
			private void <>m__Finally1()
			{
			}

			// Token: 0x06002B6D RID: 11117 RVA: 0x0001D589 File Offset: 0x0001B789
			private void <>m__Finally2()
			{
			}

			// Token: 0x17000CBE RID: 3262
			// (get) Token: 0x06002B6E RID: 11118 RVA: 0x0001D58B File Offset: 0x0001B78B
			object IEnumerator<object>.Current
			{
				get
				{
					return null;
				}
			}

			// Token: 0x06002B6F RID: 11119 RVA: 0x0001D58E File Offset: 0x0001B78E
			void IEnumerator.Reset()
			{
			}

			// Token: 0x17000CBF RID: 3263
			// (get) Token: 0x06002B70 RID: 11120 RVA: 0x0001D590 File Offset: 0x0001B790
			object IEnumerator.Current
			{
				get
				{
					return null;
				}
			}

			// Token: 0x04001068 RID: 4200
			private int <>1__state;

			// Token: 0x04001069 RID: 4201
			private object <>2__current;

			// Token: 0x0400106A RID: 4202
			public PTAuthenticator.AuthRequestMessage msg;

			// Token: 0x0400106B RID: 4203
			public NetworkConnectionToClient conn;

			// Token: 0x0400106C RID: 4204
			public PTAuthenticator <>4__this;

			// Token: 0x0400106D RID: 4205
			private PTAuthenticator.AuthResponseMessage <authResponseMessage>5__2;

			// Token: 0x0400106E RID: 4206
			private bool <approve>5__3;

			// Token: 0x0400106F RID: 4207
			private JSONNode <tokenData>5__4;

			// Token: 0x04001070 RID: 4208
			private UnityWebRequest <uwr>5__5;
		}
	}
}
