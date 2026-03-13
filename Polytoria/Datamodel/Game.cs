using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Mirror;
using Polytoria.Lua;

namespace Polytoria.Datamodel
{
	// Token: 0x0200027D RID: 637
	public class Game : Instance
	{
		// Token: 0x1400004B RID: 75
		// (add) Token: 0x06001C10 RID: 7184 RVA: 0x0001AA1C File Offset: 0x00018C1C
		// (remove) Token: 0x06001C11 RID: 7185 RVA: 0x0001AA1E File Offset: 0x00018C1E
		public event Action Loaded
		{
			add
			{
			}
			remove
			{
			}
		}

		// Token: 0x170008F3 RID: 2291
		// (get) Token: 0x06001C12 RID: 7186 RVA: 0x0001AA20 File Offset: 0x00018C20
		public int GameID
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x170008F4 RID: 2292
		// (get) Token: 0x06001C13 RID: 7187 RVA: 0x0001AA23 File Offset: 0x00018C23
		public int PlayersConnected
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x170008F5 RID: 2293
		// (get) Token: 0x06001C14 RID: 7188 RVA: 0x0001AA26 File Offset: 0x00018C26
		public int InstanceCount
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x170008F6 RID: 2294
		// (get) Token: 0x06001C15 RID: 7189 RVA: 0x0001AA29 File Offset: 0x00018C29
		public int LocalInstanceCount
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x1400004C RID: 76
		// (add) Token: 0x06001C16 RID: 7190 RVA: 0x0001AA2C File Offset: 0x00018C2C
		// (remove) Token: 0x06001C17 RID: 7191 RVA: 0x0001AA2E File Offset: 0x00018C2E
		public static event Action GameLoadedLocally
		{
			add
			{
			}
			remove
			{
			}
		}

		// Token: 0x06001C18 RID: 7192 RVA: 0x0001AA30 File Offset: 0x00018C30
		protected override void Awake()
		{
		}

		// Token: 0x06001C19 RID: 7193 RVA: 0x0001AA32 File Offset: 0x00018C32
		public override void OnStartServer()
		{
		}

		// Token: 0x06001C1A RID: 7194 RVA: 0x0001AA34 File Offset: 0x00018C34
		public void InvokeLoaded()
		{
		}

		// Token: 0x06001C1B RID: 7195 RVA: 0x0001AA36 File Offset: 0x00018C36
		public void InvokeLoadedLocal()
		{
		}

		// Token: 0x06001C1C RID: 7196 RVA: 0x0001AA38 File Offset: 0x00018C38
		public void SetGameID(int id)
		{
		}

		// Token: 0x06001C1D RID: 7197 RVA: 0x0001AA3A File Offset: 0x00018C3A
		public void BuildNavMesh()
		{
		}

		// Token: 0x06001C1E RID: 7198 RVA: 0x0001AA3C File Offset: 0x00018C3C
		protected override void Start()
		{
		}

		// Token: 0x06001C1F RID: 7199 RVA: 0x0001AA3E File Offset: 0x00018C3E
		public IEnumerator WaitForGameLoad()
		{
			return null;
		}

		// Token: 0x06001C20 RID: 7200 RVA: 0x0001AA41 File Offset: 0x00018C41
		private void Update()
		{
		}

		// Token: 0x06001C21 RID: 7201 RVA: 0x0001AA43 File Offset: 0x00018C43
		public void InstanceAdded()
		{
		}

		// Token: 0x06001C22 RID: 7202 RVA: 0x0001AA45 File Offset: 0x00018C45
		public void InstanceRemoved()
		{
		}

		// Token: 0x06001C24 RID: 7204 RVA: 0x0001AA4F File Offset: 0x00018C4F
		public override bool Weaved()
		{
			return false;
		}

		// Token: 0x170008F7 RID: 2295
		// (get) Token: 0x06001C25 RID: 7205 RVA: 0x0001AA52 File Offset: 0x00018C52
		// (set) Token: 0x06001C26 RID: 7206 RVA: 0x0001AA55 File Offset: 0x00018C55
		public int NetworkgameID
		{
			get
			{
				return 0;
			}
			[param: In]
			set
			{
			}
		}

		// Token: 0x170008F8 RID: 2296
		// (get) Token: 0x06001C27 RID: 7207 RVA: 0x0001AA57 File Offset: 0x00018C57
		// (set) Token: 0x06001C28 RID: 7208 RVA: 0x0001AA5A File Offset: 0x00018C5A
		public int NetworkplayersConnected
		{
			get
			{
				return 0;
			}
			[param: In]
			set
			{
			}
		}

		// Token: 0x170008F9 RID: 2297
		// (get) Token: 0x06001C29 RID: 7209 RVA: 0x0001AA5C File Offset: 0x00018C5C
		// (set) Token: 0x06001C2A RID: 7210 RVA: 0x0001AA5F File Offset: 0x00018C5F
		public int NetworkinstanceCount
		{
			get
			{
				return 0;
			}
			[param: In]
			set
			{
			}
		}

		// Token: 0x06001C2B RID: 7211 RVA: 0x0001AA61 File Offset: 0x00018C61
		public override void SerializeSyncVars(NetworkWriter writer, bool forceAll)
		{
		}

		// Token: 0x06001C2C RID: 7212 RVA: 0x0001AA63 File Offset: 0x00018C63
		public override void DeserializeSyncVars(NetworkReader reader, bool initialState)
		{
		}

		// Token: 0x04000A4B RID: 2635
		public static Game singleton;

		// Token: 0x04000A4D RID: 2637
		public LuaEvent Rendered;

		// Token: 0x04000A4E RID: 2638
		private int gameID;

		// Token: 0x04000A4F RID: 2639
		private int playersConnected;

		// Token: 0x04000A50 RID: 2640
		public static string GameName;

		// Token: 0x04000A51 RID: 2641
		public int instanceCount;

		// Token: 0x04000A52 RID: 2642
		private int localInstanceCount;

		// Token: 0x04000A54 RID: 2644
		public bool isGameLoaded;

		// Token: 0x020003E9 RID: 1001
		private sealed class <WaitForGameLoad>d__29 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x06002B8D RID: 11149 RVA: 0x0001D5F6 File Offset: 0x0001B7F6
			public <WaitForGameLoad>d__29(int <>1__state)
			{
			}

			// Token: 0x06002B8E RID: 11150 RVA: 0x0001D5FE File Offset: 0x0001B7FE
			void IDisposable.Dispose()
			{
			}

			// Token: 0x06002B8F RID: 11151 RVA: 0x0001D600 File Offset: 0x0001B800
			bool IEnumerator.MoveNext()
			{
				return false;
			}

			// Token: 0x17000CC8 RID: 3272
			// (get) Token: 0x06002B90 RID: 11152 RVA: 0x0001D603 File Offset: 0x0001B803
			object IEnumerator<object>.Current
			{
				get
				{
					return null;
				}
			}

			// Token: 0x06002B91 RID: 11153 RVA: 0x0001D606 File Offset: 0x0001B806
			void IEnumerator.Reset()
			{
			}

			// Token: 0x17000CC9 RID: 3273
			// (get) Token: 0x06002B92 RID: 11154 RVA: 0x0001D608 File Offset: 0x0001B808
			object IEnumerator.Current
			{
				get
				{
					return null;
				}
			}

			// Token: 0x04001087 RID: 4231
			private int <>1__state;

			// Token: 0x04001088 RID: 4232
			private object <>2__current;

			// Token: 0x04001089 RID: 4233
			public Game <>4__this;

			// Token: 0x0400108A RID: 4234
			private float <startTime>5__2;

			// Token: 0x0400108B RID: 4235
			private float <timeout>5__3;

			// Token: 0x0400108C RID: 4236
			private int <lastInstances>5__4;

			// Token: 0x0400108D RID: 4237
			private float <timeSinceChange>5__5;

			// Token: 0x0400108E RID: 4238
			private float <minimumTime>5__6;
		}
	}
}
