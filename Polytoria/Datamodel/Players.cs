using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Mirror;
using Polytoria.Lua;

namespace Polytoria.Datamodel
{
	// Token: 0x020002A3 RID: 675
	public class Players : Instance
	{
		// Token: 0x17000A09 RID: 2569
		// (get) Token: 0x0600206A RID: 8298 RVA: 0x0001B58D File Offset: 0x0001978D
		public Player LocalPlayer
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000A0A RID: 2570
		// (get) Token: 0x0600206B RID: 8299 RVA: 0x0001B590 File Offset: 0x00019790
		// (set) Token: 0x0600206C RID: 8300 RVA: 0x0001B593 File Offset: 0x00019793
		public bool PlayerCollisionEnabled
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x0600206D RID: 8301 RVA: 0x0001B595 File Offset: 0x00019795
		protected override void Awake()
		{
		}

		// Token: 0x0600206E RID: 8302 RVA: 0x0001B597 File Offset: 0x00019797
		protected override void Start()
		{
		}

		// Token: 0x0600206F RID: 8303 RVA: 0x0001B599 File Offset: 0x00019799
		public Player[] GetPlayers()
		{
			return null;
		}

		// Token: 0x06002070 RID: 8304 RVA: 0x0001B59C File Offset: 0x0001979C
		public Player GetPlayer(string username)
		{
			return null;
		}

		// Token: 0x06002071 RID: 8305 RVA: 0x0001B59F File Offset: 0x0001979F
		public Player GetPlayerByID(int id)
		{
			return null;
		}

		// Token: 0x06002072 RID: 8306 RVA: 0x0001B5A2 File Offset: 0x000197A2
		public void AddPlayer(Player player)
		{
		}

		// Token: 0x06002073 RID: 8307 RVA: 0x0001B5A4 File Offset: 0x000197A4
		private IEnumerator DelayedPlayerAddEvent(Player player)
		{
			return null;
		}

		// Token: 0x06002074 RID: 8308 RVA: 0x0001B5A7 File Offset: 0x000197A7
		public void NotifyPlayerDestroyed(Player player)
		{
		}

		// Token: 0x06002075 RID: 8309 RVA: 0x0001B5A9 File Offset: 0x000197A9
		private void PlayerAddedClientRpc(Player p)
		{
		}

		// Token: 0x06002076 RID: 8310 RVA: 0x0001B5AB File Offset: 0x000197AB
		private void PlayerRemovedClientRpc(string name)
		{
		}

		// Token: 0x06002077 RID: 8311 RVA: 0x0001B5AD File Offset: 0x000197AD
		private void RpcSetPlayerCollisions(bool enabled)
		{
		}

		// Token: 0x06002078 RID: 8312 RVA: 0x0001B5AF File Offset: 0x000197AF
		public void SetLocalPlayer(Player player)
		{
		}

		// Token: 0x0600207A RID: 8314 RVA: 0x0001B5B9 File Offset: 0x000197B9
		public override bool Weaved()
		{
			return false;
		}

		// Token: 0x17000A0B RID: 2571
		// (get) Token: 0x0600207B RID: 8315 RVA: 0x0001B5BC File Offset: 0x000197BC
		// (set) Token: 0x0600207C RID: 8316 RVA: 0x0001B5BF File Offset: 0x000197BF
		public bool NetworkplayerCollisions
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

		// Token: 0x0600207D RID: 8317 RVA: 0x0001B5C1 File Offset: 0x000197C1
		protected void UserCode_PlayerAddedClientRpc__Player(Player p)
		{
		}

		// Token: 0x0600207E RID: 8318 RVA: 0x0001B5C3 File Offset: 0x000197C3
		protected static void InvokeUserCode_PlayerAddedClientRpc__Player(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		// Token: 0x0600207F RID: 8319 RVA: 0x0001B5C5 File Offset: 0x000197C5
		protected void UserCode_PlayerRemovedClientRpc__String(string name)
		{
		}

		// Token: 0x06002080 RID: 8320 RVA: 0x0001B5C7 File Offset: 0x000197C7
		protected static void InvokeUserCode_PlayerRemovedClientRpc__String(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		// Token: 0x06002081 RID: 8321 RVA: 0x0001B5C9 File Offset: 0x000197C9
		protected void UserCode_RpcSetPlayerCollisions__Boolean(bool enabled)
		{
		}

		// Token: 0x06002082 RID: 8322 RVA: 0x0001B5CB File Offset: 0x000197CB
		protected static void InvokeUserCode_RpcSetPlayerCollisions__Boolean(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		// Token: 0x06002084 RID: 8324 RVA: 0x0001B5CF File Offset: 0x000197CF
		public override void SerializeSyncVars(NetworkWriter writer, bool forceAll)
		{
		}

		// Token: 0x06002085 RID: 8325 RVA: 0x0001B5D1 File Offset: 0x000197D1
		public override void DeserializeSyncVars(NetworkReader reader, bool initialState)
		{
		}

		// Token: 0x04000BD2 RID: 3026
		public LuaEvent PlayerAdded;

		// Token: 0x04000BD3 RID: 3027
		public LuaEvent PlayerRemoved;

		// Token: 0x04000BD4 RID: 3028
		private Player _localPlayer;

		// Token: 0x04000BD5 RID: 3029
		private bool playerCollisions;

		// Token: 0x020003F6 RID: 1014
		private sealed class <DelayedPlayerAddEvent>d__15 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x06002BD3 RID: 11219 RVA: 0x0001D6FD File Offset: 0x0001B8FD
			public <DelayedPlayerAddEvent>d__15(int <>1__state)
			{
			}

			// Token: 0x06002BD4 RID: 11220 RVA: 0x0001D705 File Offset: 0x0001B905
			void IDisposable.Dispose()
			{
			}

			// Token: 0x06002BD5 RID: 11221 RVA: 0x0001D707 File Offset: 0x0001B907
			bool IEnumerator.MoveNext()
			{
				return false;
			}

			// Token: 0x17000CDC RID: 3292
			// (get) Token: 0x06002BD6 RID: 11222 RVA: 0x0001D70A File Offset: 0x0001B90A
			object IEnumerator<object>.Current
			{
				get
				{
					return null;
				}
			}

			// Token: 0x06002BD7 RID: 11223 RVA: 0x0001D70D File Offset: 0x0001B90D
			void IEnumerator.Reset()
			{
			}

			// Token: 0x17000CDD RID: 3293
			// (get) Token: 0x06002BD8 RID: 11224 RVA: 0x0001D70F File Offset: 0x0001B90F
			object IEnumerator.Current
			{
				get
				{
					return null;
				}
			}

			// Token: 0x040010BE RID: 4286
			private int <>1__state;

			// Token: 0x040010BF RID: 4287
			private object <>2__current;

			// Token: 0x040010C0 RID: 4288
			public Players <>4__this;

			// Token: 0x040010C1 RID: 4289
			public Player player;
		}
	}
}
