using System;
using System.Collections;
using System.Collections.Generic;
using Mirror;
using MoonSharp.Interpreter;
using UnityEngine.Networking;

namespace Polytoria.Datamodel.Services
{
	// Token: 0x020002C1 RID: 705
	public class AchievementService : NetworkBehaviour
	{
		// Token: 0x17000AC9 RID: 2761
		// (get) Token: 0x06002391 RID: 9105 RVA: 0x0001BD62 File Offset: 0x00019F62
		// (set) Token: 0x06002392 RID: 9106 RVA: 0x0001BD69 File Offset: 0x00019F69
		public static AchievementService Instance
		{
			get
			{
				return AchievementService.<Instance>k__BackingField;
			}
			private set
			{
				AchievementService.<Instance>k__BackingField = value;
			}
		}

		// Token: 0x06002393 RID: 9107 RVA: 0x0001BD71 File Offset: 0x00019F71
		private void Awake()
		{
		}

		// Token: 0x06002394 RID: 9108 RVA: 0x0001BD73 File Offset: 0x00019F73
		public bool UseRequest()
		{
			return false;
		}

		// Token: 0x06002395 RID: 9109 RVA: 0x0001BD76 File Offset: 0x00019F76
		public void Award(int userID, int achievementID, DynValue callback)
		{
		}

		// Token: 0x06002396 RID: 9110 RVA: 0x0001BD78 File Offset: 0x00019F78
		private IEnumerator DoAward(int userID, int achievementID, DynValue callback)
		{
			return null;
		}

		// Token: 0x06002397 RID: 9111 RVA: 0x0001BD7B File Offset: 0x00019F7B
		public void HasAchievement(int userID, int achievementID, DynValue callback)
		{
		}

		// Token: 0x06002398 RID: 9112 RVA: 0x0001BD7D File Offset: 0x00019F7D
		private IEnumerator DoHasAchievement(int userID, int achievementID, DynValue callback)
		{
			return null;
		}

		// Token: 0x0600239A RID: 9114 RVA: 0x0001BD88 File Offset: 0x00019F88
		public override bool Weaved()
		{
			return false;
		}

		// Token: 0x04000CBD RID: 3261
		private static AchievementService <Instance>k__BackingField;

		// Token: 0x04000CBE RID: 3262
		public int MaxRequestsPerMinute;

		// Token: 0x04000CBF RID: 3263
		public int RequestsPerPlayerModifier;

		// Token: 0x04000CC0 RID: 3264
		private int requestsThisMinute;

		// Token: 0x04000CC1 RID: 3265
		private int currentMinute;

		// Token: 0x020003FB RID: 1019
		private sealed class <DoAward>d__11 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x06002BE9 RID: 11241 RVA: 0x0001D74B File Offset: 0x0001B94B
			public <DoAward>d__11(int <>1__state)
			{
			}

			// Token: 0x06002BEA RID: 11242 RVA: 0x0001D753 File Offset: 0x0001B953
			void IDisposable.Dispose()
			{
			}

			// Token: 0x06002BEB RID: 11243 RVA: 0x0001D755 File Offset: 0x0001B955
			bool IEnumerator.MoveNext()
			{
				return false;
			}

			// Token: 0x17000CE2 RID: 3298
			// (get) Token: 0x06002BEC RID: 11244 RVA: 0x0001D758 File Offset: 0x0001B958
			object IEnumerator<object>.Current
			{
				get
				{
					return null;
				}
			}

			// Token: 0x06002BED RID: 11245 RVA: 0x0001D75B File Offset: 0x0001B95B
			void IEnumerator.Reset()
			{
			}

			// Token: 0x17000CE3 RID: 3299
			// (get) Token: 0x06002BEE RID: 11246 RVA: 0x0001D75D File Offset: 0x0001B95D
			object IEnumerator.Current
			{
				get
				{
					return null;
				}
			}

			// Token: 0x040010D1 RID: 4305
			private int <>1__state;

			// Token: 0x040010D2 RID: 4306
			private object <>2__current;

			// Token: 0x040010D3 RID: 4307
			public int achievementID;

			// Token: 0x040010D4 RID: 4308
			public int userID;

			// Token: 0x040010D5 RID: 4309
			public DynValue callback;

			// Token: 0x040010D6 RID: 4310
			private UnityWebRequest <uwr>5__2;
		}

		// Token: 0x020003FC RID: 1020
		private sealed class <DoHasAchievement>d__13 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x06002BEF RID: 11247 RVA: 0x0001D760 File Offset: 0x0001B960
			public <DoHasAchievement>d__13(int <>1__state)
			{
			}

			// Token: 0x06002BF0 RID: 11248 RVA: 0x0001D768 File Offset: 0x0001B968
			void IDisposable.Dispose()
			{
			}

			// Token: 0x06002BF1 RID: 11249 RVA: 0x0001D76A File Offset: 0x0001B96A
			bool IEnumerator.MoveNext()
			{
				return false;
			}

			// Token: 0x17000CE4 RID: 3300
			// (get) Token: 0x06002BF2 RID: 11250 RVA: 0x0001D76D File Offset: 0x0001B96D
			object IEnumerator<object>.Current
			{
				get
				{
					return null;
				}
			}

			// Token: 0x06002BF3 RID: 11251 RVA: 0x0001D770 File Offset: 0x0001B970
			void IEnumerator.Reset()
			{
			}

			// Token: 0x17000CE5 RID: 3301
			// (get) Token: 0x06002BF4 RID: 11252 RVA: 0x0001D772 File Offset: 0x0001B972
			object IEnumerator.Current
			{
				get
				{
					return null;
				}
			}

			// Token: 0x040010D7 RID: 4311
			private int <>1__state;

			// Token: 0x040010D8 RID: 4312
			private object <>2__current;

			// Token: 0x040010D9 RID: 4313
			public int userID;

			// Token: 0x040010DA RID: 4314
			public int achievementID;

			// Token: 0x040010DB RID: 4315
			public DynValue callback;

			// Token: 0x040010DC RID: 4316
			private UnityWebRequest <uwr>5__2;
		}
	}
}
