using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Mirror;
using Polytoria.Datamodel;
using UnityEngine;
using UnityEngine.Networking;

namespace Polytoria.Networking
{
    public class PTNetworkManager : NetworkManager
    {
        private enum ServerEventType
        {
            ServerStarted = 0,
            ServerStopped = 1,
            ClientConnected = 2,
            ClientDisconnected = 3
        }

        [Serializable]
        private sealed class <>c
        {
            public static readonly <>c <>9 = new <>c();
            public static Func<AuthUserData, int> <>9__42_0;

            static <>c() { }
            public <>c() { }

            internal int <GetConnectedUserIDs>b__42_0(AuthUserData i)
            {
                return i.userID;
            }
        }

        private sealed class <HeartbeatLoop>d__33 : IEnumerator<object>, IEnumerator, IDisposable
        {
            private int <>1__state;
            private object <>2__current;
            public PTNetworkManager <>4__this;
            private UnityWebRequest <uwr>5__2;

            object IEnumerator<object>.Current => <>2__current;
            object IEnumerator.Current => <>2__current;

            public <HeartbeatLoop>d__33(int <>1__state)
            {
                this.<>1__state = <>1__state;
            }

            void IDisposable.Dispose() { }
            void IEnumerator.Reset() { }
            private void <>m__Finally1() { }
            private bool MoveNext() { return false; }
        }

        private sealed class <LogEvent>d__32 : IEnumerator<object>, IEnumerator, IDisposable
        {
            private int <>1__state;
            private object <>2__current;

            object IEnumerator<object>.Current => <>2__current;
            object IEnumerator.Current => <>2__current;

            public <LogEvent>d__32(int <>1__state)
            {
                this.<>1__state = <>1__state;
            }

            void IDisposable.Dispose() { }
            void IEnumerator.Reset() { }
            private bool MoveNext() { return false; }
        }

        public static PTNetworkManager instance;

        private Dictionary<int, AuthUserData> playerConnData;
        private Dictionary<int, Player> playerPrefabs;

        [Range(1f, 60f)]
        [SerializeField]
        private float serverHeartbeatRate = 10f;

        [Range(1, 100)]
        [SerializeField]
        private int maxServerTimeout = 10;

        private int emptyServerPings;

        public PTNetworkManager() { }

        public override void Awake()
        {
            if (instance != null && instance != this)
            {
                Destroy(gameObject);
                return;
            }

            instance = this;
            DontDestroyOnLoad(gameObject);

            playerConnData = new Dictionary<int, AuthUserData>();
            playerPrefabs = new Dictionary<int, Player>();
        }

        public override void OnValidate()
        {
            serverHeartbeatRate = Mathf.Clamp(serverHeartbeatRate, 1f, 60f);
            maxServerTimeout = Mathf.Clamp(maxServerTimeout, 1, 100);
        }

        public override void Start() { base.Start(); }
        public override void LateUpdate() { base.LateUpdate(); }

        public override void OnDestroy()
        {
            if (instance == this) instance = null;
            StopAllCoroutines();
            base.OnDestroy();
        }

        public override void ConfigureHeadlessFrameRate()
        {
            if (!Application.isBatchMode) return;
            Application.targetFrameRate = Mathf.RoundToInt(1f / Time.fixedDeltaTime);
        }

        public override void OnApplicationQuit()
        {
            if (NetworkServer.active) ShutdownServer();
            base.OnApplicationQuit();
        }

        public override void OnStartServer()
        {
            base.OnStartServer();
            StartCoroutine(HeartbeatLoop());
            StartCoroutine(LogEvent(ServerEventType.ServerStarted, null, false));
        }

        public override void OnStartHost() { base.OnStartHost(); }
        public override void OnStopHost() { base.OnStopHost(); }

        public override void OnStopServer()
        {
            StartCoroutine(LogEvent(ServerEventType.ServerStopped, null, false));
            playerConnData.Clear();
            playerPrefabs.Clear();
            emptyServerPings = 0;
            base.OnStopServer();
        }

        public void ShutdownServer()
        {
            if (!NetworkServer.active) return;
            foreach (var conn in NetworkServer.connections.Values) conn.Disconnect();
            StopServer();
        }

        public override void OnStartClient() { base.OnStartClient(); }
        public override void OnStopClient() { base.OnStopClient(); }
        public override void OnClientConnect() { base.OnClientConnect(); }
        public override void OnClientDisconnect() { base.OnClientDisconnect(); }
        public override void OnClientNotReady() { base.OnClientNotReady(); }

        public override void OnClientError(TransportError transportError, string message)
        {
            base.OnClientError(transportError, message);
        }

        public override void OnClientChangeScene(string newSceneName, SceneOperation sceneOperation, bool customHandling)
        {
            base.OnClientChangeScene(newSceneName, sceneOperation, customHandling);
        }

        public override void OnClientSceneChanged() { base.OnClientSceneChanged(); }

        public override void OnServerConnect(NetworkConnectionToClient conn)
        {
            if (!playerConnData.ContainsKey(conn.connectionId))
                playerConnData.Add(conn.connectionId, default);
            base.OnServerConnect(conn);
        }

        public override void OnServerReady(NetworkConnectionToClient conn)
        {
            base.OnServerReady(conn);
        }

        public override void OnServerAddPlayer(NetworkConnectionToClient conn)
        {
            playerConnData.TryGetValue(conn.connectionId, out AuthUserData userData);

            Vector3 spawnPosition = GetStartPosition().position;
            GameObject playerObj = Instantiate(playerPrefab, spawnPosition, Quaternion.identity);
            NetworkServer.AddPlayerForConnection(conn, playerObj);

            Player player = playerObj.GetComponent<Player>();
            if (player != null && !playerPrefabs.ContainsKey(conn.connectionId))
            {
                playerPrefabs.Add(conn.connectionId, player);
                player.SetupPlayer(userData);
            }

            if (userData.userID > 0)
            {
                StartCoroutine(LogEvent(ServerEventType.ClientConnected, new Dictionary<string, string>
                {
                    { "user_id", userData.userID.ToString() },
                    { "username", userData.username },
                    { "conn_id", conn.connectionId.ToString() }
                }, false));
            }

            emptyServerPings = 0;
        }

        public override void OnServerDisconnect(NetworkConnectionToClient conn)
        {
            if (playerConnData.TryGetValue(conn.connectionId, out AuthUserData userData) && userData.userID > 0)
            {
                StartCoroutine(LogEvent(ServerEventType.ClientDisconnected, new Dictionary<string, string>
                {
                    { "user_id", userData.userID.ToString() },
                    { "username", userData.username },
                    { "conn_id", conn.connectionId.ToString() }
                }, false));
            }

            playerConnData.Remove(conn.connectionId);
            playerPrefabs.Remove(conn.connectionId);
            base.OnServerDisconnect(conn);
        }

        public override void OnServerError(NetworkConnectionToClient conn, TransportError transportError, string message)
        {
            base.OnServerError(conn, transportError, message);
        }

        public override void ServerChangeScene(string newSceneName)
        {
            base.ServerChangeScene(newSceneName);
        }

        public override void OnServerChangeScene(string newSceneName)
        {
            base.OnServerChangeScene(newSceneName);
        }

        public override void OnServerSceneChanged(string sceneName)
        {
            base.OnServerSceneChanged(sceneName);
        }

        public void ClientConnected(int userID) { }
        public void ClientDisconnected(int userID) { }

        public Player GetPlayerPrefab(int connId)
        {
            playerPrefabs.TryGetValue(connId, out Player player);
            return player;
        }

        public void AddUserForConnID(int connId, AuthUserData userData)
        {
            if (playerConnData.ContainsKey(connId))
                playerConnData[connId] = userData;
            else
                playerConnData.Add(connId, userData);
        }

        public AuthUserData GetUserDataFromConnID(int connId)
        {
            playerConnData.TryGetValue(connId, out AuthUserData userData);
            return userData;
        }

        public List<int> GetConnectedUserIDs()
        {
            return playerConnData.Values
                .Where(x => x.userID > 0)
                .Select(x => x.userID)
                .ToList();
        }

        [IteratorStateMachine(typeof(<HeartbeatLoop>d__33))]
        private IEnumerator HeartbeatLoop()
        {
            yield return null;
        }

        [IteratorStateMachine(typeof(<LogEvent>d__32))]
        private IEnumerator LogEvent(ServerEventType eventType, Dictionary<string, string> data = null, bool shutdownOnComplete = false)
        {
            yield return null;
        }
    }
}
