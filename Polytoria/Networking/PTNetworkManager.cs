using System;
using System.Collections;
using System.Collections.Generic;
using Mirror;
using Polytoria.Datamodel;
using UnityEngine.Networking;

namespace Polytoria.Networking
{
	public class PTNetworkManager : NetworkManager
	{
		private Dictionary<int, AuthUserData> playerConnData;
		private Dictionary<int, Player> playerPrefabs;
		public static PTNetworkManager instance;
		private float serverHeartbeatRate;
		private int maxServerTimeout;
		private int emptyServerPings;

		public override void Awake()
		{
		}

		public override void OnValidate()
		{
		}

		public override void Start()
		{
		}

		public override void LateUpdate()
		{
		}

		public override void OnDestroy()
		{
		}

		public override void ConfigureHeadlessFrameRate()
		{
		}

		public override void OnApplicationQuit()
		{
		}

		public override void ServerChangeScene(string newSceneName)
		{
		}

		public override void OnServerChangeScene(string newSceneName)
		{
		}

		public override void OnServerSceneChanged(string sceneName)
		{
		}

		public override void OnClientChangeScene(string newSceneName, SceneOperation sceneOperation, bool customHandling)
		{
		}

		public override void OnClientSceneChanged()
		{
		}

		public override void OnServerConnect(NetworkConnectionToClient conn)
		{
		}

		public override void OnServerReady(NetworkConnectionToClient conn)
		{
		}

		public override void OnServerAddPlayer(NetworkConnectionToClient conn)
		{
		}

		public override void OnServerDisconnect(NetworkConnectionToClient conn)
		{
		}

		public override void OnServerError(NetworkConnectionToClient conn, TransportError transportError, string message)
		{
		}

		public override void OnClientConnect()
		{
		}

		public override void OnClientDisconnect()
		{
		}

		public override void OnClientNotReady()
		{
		}

		public override void OnClientError(TransportError transportError, string message)
		{
		}

		public override void OnStartHost()
		{
		}

		public override void OnStartServer()
		{
		}

		public void ClientConnected(int userID)
		{
		}

		public void ClientDisconnected(int userID)
		{
		}

		public void ShutdownServer()
		{
		}

		private IEnumerator LogEvent(PTNetworkManager.ServerEventType eventType, Dictionary<string, string> data = null, bool shutdownOnComplete = false)
		{
			return null;
		}

		private IEnumerator HeartbeatLoop()
		{
			return null;
		}

		public override void OnStartClient()
		{
		}

		public override void OnStopHost()
		{
		}

		public override void OnStopServer()
		{
		}

		public override void OnStopClient()
		{
		}

		public Player GetPlayerPrefab(int connId)
		{
			return null;
		}

		public void AddUserForConnID(int connId, AuthUserData userData)
		{
		}

		public AuthUserData GetUserDataFromConnID(int connId)
		{
			return default(AuthUserData);
		}

		public List<int> GetConnectedUserIDs()
		{
			return null;
		}

		private enum ServerEventType
		{
			ServerStarted,
			ServerStopped,
			ClientConnected,
			ClientDisconnected
		}

		[Serializable]
		private sealed class <>c
		{
			public static readonly PTNetworkManager.<>c <>9;
			public static Func<AuthUserData, int> <>9__42_0;

			internal int <GetConnectedUserIDs>b__42_0(AuthUserData i)
			{
				return 0;
			}
		}

		private sealed class <HeartbeatLoop>d__33 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int <>1__state;
			private object <>2__current;
			public PTNetworkManager <>4__this;
			private UnityWebRequest <uwr>5__2;

			public <HeartbeatLoop>d__33(int <>1__state)
			{
			}

			void IDisposable.Dispose()
			{
			}

			bool IEnumerator.MoveNext()
			{
				return false;
			}

			private void <>m__Finally1()
			{
			}

			object IEnumerator<object>.Current
			{
				get
				{
					return null;
				}
			}

			void IEnumerator.Reset()
			{
			}

			object IEnumerator.Current
			{
				get
				{
					return null;
				}
			}
		}

		private sealed class <LogEvent>d__32 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int <>1__state;
			private object <>2__current;

			public <LogEvent>d__32(int <>1__state)
			{
			}

			void IDisposable.Dispose()
			{
			}

			bool IEnumerator.MoveNext()
			{
				return false;
			}

			object IEnumerator<object>.Current
			{
				get
				{
					return null;
				}
			}

			void IEnumerator.Reset()
			{
			}

			object IEnumerator.Current
			{
				get
				{
					return null;
				}
			}
		}
	}
}
