using System;
using System.Collections;
using System.Collections.Generic;
using Mirror;
using Polytoria.Datamodel;
using UnityEngine.Networking;

namespace Polytoria.Networking
{
	// Token: 0x0200025F RID: 607
	public class PTNetworkManager : NetworkManager
	{
		// Token: 0x06001A12 RID: 6674 RVA: 0x0001A44E File Offset: 0x0001864E
		public override void Awake()
		{
		}

		// Token: 0x06001A13 RID: 6675 RVA: 0x0001A450 File Offset: 0x00018650
		public override void OnValidate()
		{
		}

		// Token: 0x06001A14 RID: 6676 RVA: 0x0001A452 File Offset: 0x00018652
		public override void Start()
		{
		}

		// Token: 0x06001A15 RID: 6677 RVA: 0x0001A454 File Offset: 0x00018654
		public override void LateUpdate()
		{
		}

		// Token: 0x06001A16 RID: 6678 RVA: 0x0001A456 File Offset: 0x00018656
		public override void OnDestroy()
		{
		}

		// Token: 0x06001A17 RID: 6679 RVA: 0x0001A458 File Offset: 0x00018658
		public override void ConfigureHeadlessFrameRate()
		{
		}

		// Token: 0x06001A18 RID: 6680 RVA: 0x0001A45A File Offset: 0x0001865A
		public override void OnApplicationQuit()
		{
		}

		// Token: 0x06001A19 RID: 6681 RVA: 0x0001A45C File Offset: 0x0001865C
		public override void ServerChangeScene(string newSceneName)
		{
		}

		// Token: 0x06001A1A RID: 6682 RVA: 0x0001A45E File Offset: 0x0001865E
		public override void OnServerChangeScene(string newSceneName)
		{
		}

		// Token: 0x06001A1B RID: 6683 RVA: 0x0001A460 File Offset: 0x00018660
		public override void OnServerSceneChanged(string sceneName)
		{
		}

		// Token: 0x06001A1C RID: 6684 RVA: 0x0001A462 File Offset: 0x00018662
		public override void OnClientChangeScene(string newSceneName, SceneOperation sceneOperation, bool customHandling)
		{
		}

		// Token: 0x06001A1D RID: 6685 RVA: 0x0001A464 File Offset: 0x00018664
		public override void OnClientSceneChanged()
		{
		}

		// Token: 0x06001A1E RID: 6686 RVA: 0x0001A466 File Offset: 0x00018666
		public override void OnServerConnect(NetworkConnectionToClient conn)
		{
		}

		// Token: 0x06001A1F RID: 6687 RVA: 0x0001A468 File Offset: 0x00018668
		public override void OnServerReady(NetworkConnectionToClient conn)
		{
		}

		// Token: 0x06001A20 RID: 6688 RVA: 0x0001A46A File Offset: 0x0001866A
		public override void OnServerAddPlayer(NetworkConnectionToClient conn)
		{
		}

		// Token: 0x06001A21 RID: 6689 RVA: 0x0001A46C File Offset: 0x0001866C
		public override void OnServerDisconnect(NetworkConnectionToClient conn)
		{
		}

		// Token: 0x06001A22 RID: 6690 RVA: 0x0001A46E File Offset: 0x0001866E
		public override void OnServerError(NetworkConnectionToClient conn, TransportError transportError, string message)
		{
		}

		// Token: 0x06001A23 RID: 6691 RVA: 0x0001A470 File Offset: 0x00018670
		public override void OnClientConnect()
		{
		}

		// Token: 0x06001A24 RID: 6692 RVA: 0x0001A472 File Offset: 0x00018672
		public override void OnClientDisconnect()
		{
		}

		// Token: 0x06001A25 RID: 6693 RVA: 0x0001A474 File Offset: 0x00018674
		public override void OnClientNotReady()
		{
		}

		// Token: 0x06001A26 RID: 6694 RVA: 0x0001A476 File Offset: 0x00018676
		public override void OnClientError(TransportError transportError, string message)
		{
		}

		// Token: 0x06001A27 RID: 6695 RVA: 0x0001A478 File Offset: 0x00018678
		public override void OnStartHost()
		{
		}

		// Token: 0x06001A28 RID: 6696 RVA: 0x0001A47A File Offset: 0x0001867A
		public override void OnStartServer()
		{
		}

		// Token: 0x06001A29 RID: 6697 RVA: 0x0001A47C File Offset: 0x0001867C
		public void ClientConnected(int userID)
		{
		}

		// Token: 0x06001A2A RID: 6698 RVA: 0x0001A47E File Offset: 0x0001867E
		public void ClientDisconnected(int userID)
		{
		}

		// Token: 0x06001A2B RID: 6699 RVA: 0x0001A480 File Offset: 0x00018680
		public void ShutdownServer()
		{
		}

		// Token: 0x06001A2C RID: 6700 RVA: 0x0001A482 File Offset: 0x00018682
		private IEnumerator LogEvent(PTNetworkManager.ServerEventType eventType, Dictionary<string, string> data = null, bool shutdownOnComplete = false)
		{
			return null;
		}

		// Token: 0x06001A2D RID: 6701 RVA: 0x0001A485 File Offset: 0x00018685
		private IEnumerator HeartbeatLoop()
		{
			return null;
		}

		// Token: 0x06001A2E RID: 6702 RVA: 0x0001A488 File Offset: 0x00018688
		public override void OnStartClient()
		{
		}

		// Token: 0x06001A2F RID: 6703 RVA: 0x0001A48A File Offset: 0x0001868A
		public override void OnStopHost()
		{
		}

		// Token: 0x06001A30 RID: 6704 RVA: 0x0001A48C File Offset: 0x0001868C
		public override void OnStopServer()
		{
		}

		// Token: 0x06001A31 RID: 6705 RVA: 0x0001A48E File Offset: 0x0001868E
		public override void OnStopClient()
		{
		}

		// Token: 0x06001A32 RID: 6706 RVA: 0x0001A490 File Offset: 0x00018690
		public Player GetPlayerPrefab(int connId)
		{
			return null;
		}

		// Token: 0x06001A33 RID: 6707 RVA: 0x0001A493 File Offset: 0x00018693
		public void AddUserForConnID(int connId, AuthUserData userData)
		{
		}

		// Token: 0x06001A34 RID: 6708 RVA: 0x00023CB0 File Offset: 0x00021EB0
		public AuthUserData GetUserDataFromConnID(int connId)
		{
			return default(AuthUserData);
		}

		// Token: 0x06001A35 RID: 6709 RVA: 0x0001A495 File Offset: 0x00018695
		public List<int> GetConnectedUserIDs()
		{
			return null;
		}

		// Token: 0x0400099C RID: 2460
		private Dictionary<int, AuthUserData> playerConnData;

		// Token: 0x0400099D RID: 2461
		private Dictionary<int, Player> playerPrefabs;

		// Token: 0x0400099E RID: 2462
		public static PTNetworkManager instance;

		// Token: 0x0400099F RID: 2463
		private float serverHeartbeatRate;

		// Token: 0x040009A0 RID: 2464
		private int maxServerTimeout;

		// Token: 0x040009A1 RID: 2465
		private int emptyServerPings;

		// Token: 0x020003E3 RID: 995
		private enum ServerEventType
		{
			// Token: 0x04001072 RID: 4210
			ServerStarted,
			// Token: 0x04001073 RID: 4211
			ServerStopped,
			// Token: 0x04001074 RID: 4212
			ClientConnected,
			// Token: 0x04001075 RID: 4213
			ClientDisconnected
		}

		// Token: 0x020003E4 RID: 996
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06002B73 RID: 11123 RVA: 0x0001D59D File Offset: 0x0001B79D
			internal int <GetConnectedUserIDs>b__42_0(AuthUserData i)
			{
				return 0;
			}

			// Token: 0x04001076 RID: 4214
			public static readonly PTNetworkManager.<>c <>9;

			// Token: 0x04001077 RID: 4215
			public static Func<AuthUserData, int> <>9__42_0;
		}

		// Token: 0x020003E5 RID: 997
		private sealed class <HeartbeatLoop>d__33 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x06002B74 RID: 11124 RVA: 0x0001D5A0 File Offset: 0x0001B7A0
			public <HeartbeatLoop>d__33(int <>1__state)
			{
			}

			// Token: 0x06002B75 RID: 11125 RVA: 0x0001D5A8 File Offset: 0x0001B7A8
			void IDisposable.Dispose()
			{
			}

			// Token: 0x06002B76 RID: 11126 RVA: 0x0001D5AA File Offset: 0x0001B7AA
			bool IEnumerator.MoveNext()
			{
				return false;
			}

			// Token: 0x06002B77 RID: 11127 RVA: 0x0001D5AD File Offset: 0x0001B7AD
			private void <>m__Finally1()
			{
			}

			// Token: 0x17000CC0 RID: 3264
			// (get) Token: 0x06002B78 RID: 11128 RVA: 0x0001D5AF File Offset: 0x0001B7AF
			object IEnumerator<object>.Current
			{
				get
				{
					return null;
				}
			}

			// Token: 0x06002B79 RID: 11129 RVA: 0x0001D5B2 File Offset: 0x0001B7B2
			void IEnumerator.Reset()
			{
			}

			// Token: 0x17000CC1 RID: 3265
			// (get) Token: 0x06002B7A RID: 11130 RVA: 0x0001D5B4 File Offset: 0x0001B7B4
			object IEnumerator.Current
			{
				get
				{
					return null;
				}
			}

			// Token: 0x04001078 RID: 4216
			private int <>1__state;

			// Token: 0x04001079 RID: 4217
			private object <>2__current;

			// Token: 0x0400107A RID: 4218
			public PTNetworkManager <>4__this;

			// Token: 0x0400107B RID: 4219
			private UnityWebRequest <uwr>5__2;
		}

		// Token: 0x020003E6 RID: 998
		private sealed class <LogEvent>d__32 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x06002B7B RID: 11131 RVA: 0x0001D5B7 File Offset: 0x0001B7B7
			public <LogEvent>d__32(int <>1__state)
			{
			}

			// Token: 0x06002B7C RID: 11132 RVA: 0x0001D5BF File Offset: 0x0001B7BF
			void IDisposable.Dispose()
			{
			}

			// Token: 0x06002B7D RID: 11133 RVA: 0x0001D5C1 File Offset: 0x0001B7C1
			bool IEnumerator.MoveNext()
			{
				return false;
			}

			// Token: 0x17000CC2 RID: 3266
			// (get) Token: 0x06002B7E RID: 11134 RVA: 0x0001D5C4 File Offset: 0x0001B7C4
			object IEnumerator<object>.Current
			{
				get
				{
					return null;
				}
			}

			// Token: 0x06002B7F RID: 11135 RVA: 0x0001D5C7 File Offset: 0x0001B7C7
			void IEnumerator.Reset()
			{
			}

			// Token: 0x17000CC3 RID: 3267
			// (get) Token: 0x06002B80 RID: 11136 RVA: 0x0001D5C9 File Offset: 0x0001B7C9
			object IEnumerator.Current
			{
				get
				{
					return null;
				}
			}

			// Token: 0x0400107C RID: 4220
			private int <>1__state;

			// Token: 0x0400107D RID: 4221
			private object <>2__current;
		}
	}
}
