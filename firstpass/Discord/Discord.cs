using System;
using System.Runtime.InteropServices;

namespace Discord
{
	// Token: 0x02000159 RID: 345
	public class Discord : IDisposable
	{
		// Token: 0x06000D6D RID: 3437
		[PreserveSig]
		private static extern Result DiscordCreate(uint version, ref Discord.FFICreateParams createParams, out IntPtr manager);

		// Token: 0x170001C3 RID: 451
		// (get) Token: 0x06000D6E RID: 3438 RVA: 0x00010700 File Offset: 0x0000E900
		private Discord.FFIMethods Methods
		{
			get
			{
				return default(Discord.FFIMethods);
			}
		}

		// Token: 0x06000D6F RID: 3439 RVA: 0x0000EF74 File Offset: 0x0000D174
		public Discord(long clientId, ulong flags)
		{
		}

		// Token: 0x06000D70 RID: 3440 RVA: 0x0000EF7C File Offset: 0x0000D17C
		private void InitEvents(IntPtr eventsPtr, ref Discord.FFIEvents events)
		{
		}

		// Token: 0x06000D71 RID: 3441 RVA: 0x0000EF7E File Offset: 0x0000D17E
		public void Dispose()
		{
		}

		// Token: 0x06000D72 RID: 3442 RVA: 0x0000EF80 File Offset: 0x0000D180
		public void RunCallbacks()
		{
		}

		// Token: 0x06000D73 RID: 3443 RVA: 0x0000EF82 File Offset: 0x0000D182
		private static void SetLogHookCallbackImpl(IntPtr ptr, LogLevel level, string message)
		{
		}

		// Token: 0x06000D74 RID: 3444 RVA: 0x0000EF84 File Offset: 0x0000D184
		public void SetLogHook(LogLevel minLevel, Discord.SetLogHookHandler callback)
		{
		}

		// Token: 0x06000D75 RID: 3445 RVA: 0x0000EF86 File Offset: 0x0000D186
		public ApplicationManager GetApplicationManager()
		{
			return null;
		}

		// Token: 0x06000D76 RID: 3446 RVA: 0x0000EF89 File Offset: 0x0000D189
		public UserManager GetUserManager()
		{
			return null;
		}

		// Token: 0x06000D77 RID: 3447 RVA: 0x0000EF8C File Offset: 0x0000D18C
		public ImageManager GetImageManager()
		{
			return null;
		}

		// Token: 0x06000D78 RID: 3448 RVA: 0x0000EF8F File Offset: 0x0000D18F
		public ActivityManager GetActivityManager()
		{
			return null;
		}

		// Token: 0x06000D79 RID: 3449 RVA: 0x0000EF92 File Offset: 0x0000D192
		public RelationshipManager GetRelationshipManager()
		{
			return null;
		}

		// Token: 0x06000D7A RID: 3450 RVA: 0x0000EF95 File Offset: 0x0000D195
		public LobbyManager GetLobbyManager()
		{
			return null;
		}

		// Token: 0x06000D7B RID: 3451 RVA: 0x0000EF98 File Offset: 0x0000D198
		public NetworkManager GetNetworkManager()
		{
			return null;
		}

		// Token: 0x06000D7C RID: 3452 RVA: 0x0000EF9B File Offset: 0x0000D19B
		public OverlayManager GetOverlayManager()
		{
			return null;
		}

		// Token: 0x06000D7D RID: 3453 RVA: 0x0000EF9E File Offset: 0x0000D19E
		public StorageManager GetStorageManager()
		{
			return null;
		}

		// Token: 0x06000D7E RID: 3454 RVA: 0x0000EFA1 File Offset: 0x0000D1A1
		public StoreManager GetStoreManager()
		{
			return null;
		}

		// Token: 0x06000D7F RID: 3455 RVA: 0x0000EFA4 File Offset: 0x0000D1A4
		public VoiceManager GetVoiceManager()
		{
			return null;
		}

		// Token: 0x06000D80 RID: 3456 RVA: 0x0000EFA7 File Offset: 0x0000D1A7
		public AchievementManager GetAchievementManager()
		{
			return null;
		}

		// Token: 0x04000599 RID: 1433
		private GCHandle SelfHandle;

		// Token: 0x0400059A RID: 1434
		private IntPtr EventsPtr;

		// Token: 0x0400059B RID: 1435
		private Discord.FFIEvents Events;

		// Token: 0x0400059C RID: 1436
		private IntPtr ApplicationEventsPtr;

		// Token: 0x0400059D RID: 1437
		private ApplicationManager.FFIEvents ApplicationEvents;

		// Token: 0x0400059E RID: 1438
		internal ApplicationManager ApplicationManagerInstance;

		// Token: 0x0400059F RID: 1439
		private IntPtr UserEventsPtr;

		// Token: 0x040005A0 RID: 1440
		private UserManager.FFIEvents UserEvents;

		// Token: 0x040005A1 RID: 1441
		internal UserManager UserManagerInstance;

		// Token: 0x040005A2 RID: 1442
		private IntPtr ImageEventsPtr;

		// Token: 0x040005A3 RID: 1443
		private ImageManager.FFIEvents ImageEvents;

		// Token: 0x040005A4 RID: 1444
		internal ImageManager ImageManagerInstance;

		// Token: 0x040005A5 RID: 1445
		private IntPtr ActivityEventsPtr;

		// Token: 0x040005A6 RID: 1446
		private ActivityManager.FFIEvents ActivityEvents;

		// Token: 0x040005A7 RID: 1447
		internal ActivityManager ActivityManagerInstance;

		// Token: 0x040005A8 RID: 1448
		private IntPtr RelationshipEventsPtr;

		// Token: 0x040005A9 RID: 1449
		private RelationshipManager.FFIEvents RelationshipEvents;

		// Token: 0x040005AA RID: 1450
		internal RelationshipManager RelationshipManagerInstance;

		// Token: 0x040005AB RID: 1451
		private IntPtr LobbyEventsPtr;

		// Token: 0x040005AC RID: 1452
		private LobbyManager.FFIEvents LobbyEvents;

		// Token: 0x040005AD RID: 1453
		internal LobbyManager LobbyManagerInstance;

		// Token: 0x040005AE RID: 1454
		private IntPtr NetworkEventsPtr;

		// Token: 0x040005AF RID: 1455
		private NetworkManager.FFIEvents NetworkEvents;

		// Token: 0x040005B0 RID: 1456
		internal NetworkManager NetworkManagerInstance;

		// Token: 0x040005B1 RID: 1457
		private IntPtr OverlayEventsPtr;

		// Token: 0x040005B2 RID: 1458
		private OverlayManager.FFIEvents OverlayEvents;

		// Token: 0x040005B3 RID: 1459
		internal OverlayManager OverlayManagerInstance;

		// Token: 0x040005B4 RID: 1460
		private IntPtr StorageEventsPtr;

		// Token: 0x040005B5 RID: 1461
		private StorageManager.FFIEvents StorageEvents;

		// Token: 0x040005B6 RID: 1462
		internal StorageManager StorageManagerInstance;

		// Token: 0x040005B7 RID: 1463
		private IntPtr StoreEventsPtr;

		// Token: 0x040005B8 RID: 1464
		private StoreManager.FFIEvents StoreEvents;

		// Token: 0x040005B9 RID: 1465
		internal StoreManager StoreManagerInstance;

		// Token: 0x040005BA RID: 1466
		private IntPtr VoiceEventsPtr;

		// Token: 0x040005BB RID: 1467
		private VoiceManager.FFIEvents VoiceEvents;

		// Token: 0x040005BC RID: 1468
		internal VoiceManager VoiceManagerInstance;

		// Token: 0x040005BD RID: 1469
		private IntPtr AchievementEventsPtr;

		// Token: 0x040005BE RID: 1470
		private AchievementManager.FFIEvents AchievementEvents;

		// Token: 0x040005BF RID: 1471
		internal AchievementManager AchievementManagerInstance;

		// Token: 0x040005C0 RID: 1472
		private IntPtr MethodsPtr;

		// Token: 0x040005C1 RID: 1473
		private object MethodsStructure;

		// Token: 0x040005C2 RID: 1474
		private GCHandle? setLogHook;

		// Token: 0x020001E7 RID: 487
		internal struct FFIEvents
		{
		}

		// Token: 0x020001E8 RID: 488
		internal struct FFIMethods
		{
			// Token: 0x04000771 RID: 1905
			internal Discord.FFIMethods.DestroyHandler Destroy;

			// Token: 0x04000772 RID: 1906
			internal Discord.FFIMethods.RunCallbacksMethod RunCallbacks;

			// Token: 0x04000773 RID: 1907
			internal Discord.FFIMethods.SetLogHookMethod SetLogHook;

			// Token: 0x04000774 RID: 1908
			internal Discord.FFIMethods.GetApplicationManagerMethod GetApplicationManager;

			// Token: 0x04000775 RID: 1909
			internal Discord.FFIMethods.GetUserManagerMethod GetUserManager;

			// Token: 0x04000776 RID: 1910
			internal Discord.FFIMethods.GetImageManagerMethod GetImageManager;

			// Token: 0x04000777 RID: 1911
			internal Discord.FFIMethods.GetActivityManagerMethod GetActivityManager;

			// Token: 0x04000778 RID: 1912
			internal Discord.FFIMethods.GetRelationshipManagerMethod GetRelationshipManager;

			// Token: 0x04000779 RID: 1913
			internal Discord.FFIMethods.GetLobbyManagerMethod GetLobbyManager;

			// Token: 0x0400077A RID: 1914
			internal Discord.FFIMethods.GetNetworkManagerMethod GetNetworkManager;

			// Token: 0x0400077B RID: 1915
			internal Discord.FFIMethods.GetOverlayManagerMethod GetOverlayManager;

			// Token: 0x0400077C RID: 1916
			internal Discord.FFIMethods.GetStorageManagerMethod GetStorageManager;

			// Token: 0x0400077D RID: 1917
			internal Discord.FFIMethods.GetStoreManagerMethod GetStoreManager;

			// Token: 0x0400077E RID: 1918
			internal Discord.FFIMethods.GetVoiceManagerMethod GetVoiceManager;

			// Token: 0x0400077F RID: 1919
			internal Discord.FFIMethods.GetAchievementManagerMethod GetAchievementManager;

			// Token: 0x02000254 RID: 596
			// (Invoke) Token: 0x060011C7 RID: 4551
			internal delegate void DestroyHandler(IntPtr MethodsPtr);

			// Token: 0x02000255 RID: 597
			// (Invoke) Token: 0x060011CB RID: 4555
			internal delegate Result RunCallbacksMethod(IntPtr methodsPtr);

			// Token: 0x02000256 RID: 598
			// (Invoke) Token: 0x060011CF RID: 4559
			internal delegate void SetLogHookCallback(IntPtr ptr, LogLevel level, string message);

			// Token: 0x02000257 RID: 599
			// (Invoke) Token: 0x060011D3 RID: 4563
			internal delegate void SetLogHookMethod(IntPtr methodsPtr, LogLevel minLevel, IntPtr callbackData, Discord.FFIMethods.SetLogHookCallback callback);

			// Token: 0x02000258 RID: 600
			// (Invoke) Token: 0x060011D7 RID: 4567
			internal delegate IntPtr GetApplicationManagerMethod(IntPtr discordPtr);

			// Token: 0x02000259 RID: 601
			// (Invoke) Token: 0x060011DB RID: 4571
			internal delegate IntPtr GetUserManagerMethod(IntPtr discordPtr);

			// Token: 0x0200025A RID: 602
			// (Invoke) Token: 0x060011DF RID: 4575
			internal delegate IntPtr GetImageManagerMethod(IntPtr discordPtr);

			// Token: 0x0200025B RID: 603
			// (Invoke) Token: 0x060011E3 RID: 4579
			internal delegate IntPtr GetActivityManagerMethod(IntPtr discordPtr);

			// Token: 0x0200025C RID: 604
			// (Invoke) Token: 0x060011E7 RID: 4583
			internal delegate IntPtr GetRelationshipManagerMethod(IntPtr discordPtr);

			// Token: 0x0200025D RID: 605
			// (Invoke) Token: 0x060011EB RID: 4587
			internal delegate IntPtr GetLobbyManagerMethod(IntPtr discordPtr);

			// Token: 0x0200025E RID: 606
			// (Invoke) Token: 0x060011EF RID: 4591
			internal delegate IntPtr GetNetworkManagerMethod(IntPtr discordPtr);

			// Token: 0x0200025F RID: 607
			// (Invoke) Token: 0x060011F3 RID: 4595
			internal delegate IntPtr GetOverlayManagerMethod(IntPtr discordPtr);

			// Token: 0x02000260 RID: 608
			// (Invoke) Token: 0x060011F7 RID: 4599
			internal delegate IntPtr GetStorageManagerMethod(IntPtr discordPtr);

			// Token: 0x02000261 RID: 609
			// (Invoke) Token: 0x060011FB RID: 4603
			internal delegate IntPtr GetStoreManagerMethod(IntPtr discordPtr);

			// Token: 0x02000262 RID: 610
			// (Invoke) Token: 0x060011FF RID: 4607
			internal delegate IntPtr GetVoiceManagerMethod(IntPtr discordPtr);

			// Token: 0x02000263 RID: 611
			// (Invoke) Token: 0x06001203 RID: 4611
			internal delegate IntPtr GetAchievementManagerMethod(IntPtr discordPtr);
		}

		// Token: 0x020001E9 RID: 489
		internal struct FFICreateParams
		{
			// Token: 0x04000780 RID: 1920
			internal long ClientId;

			// Token: 0x04000781 RID: 1921
			internal ulong Flags;

			// Token: 0x04000782 RID: 1922
			internal IntPtr Events;

			// Token: 0x04000783 RID: 1923
			internal IntPtr EventData;

			// Token: 0x04000784 RID: 1924
			internal IntPtr ApplicationEvents;

			// Token: 0x04000785 RID: 1925
			internal uint ApplicationVersion;

			// Token: 0x04000786 RID: 1926
			internal IntPtr UserEvents;

			// Token: 0x04000787 RID: 1927
			internal uint UserVersion;

			// Token: 0x04000788 RID: 1928
			internal IntPtr ImageEvents;

			// Token: 0x04000789 RID: 1929
			internal uint ImageVersion;

			// Token: 0x0400078A RID: 1930
			internal IntPtr ActivityEvents;

			// Token: 0x0400078B RID: 1931
			internal uint ActivityVersion;

			// Token: 0x0400078C RID: 1932
			internal IntPtr RelationshipEvents;

			// Token: 0x0400078D RID: 1933
			internal uint RelationshipVersion;

			// Token: 0x0400078E RID: 1934
			internal IntPtr LobbyEvents;

			// Token: 0x0400078F RID: 1935
			internal uint LobbyVersion;

			// Token: 0x04000790 RID: 1936
			internal IntPtr NetworkEvents;

			// Token: 0x04000791 RID: 1937
			internal uint NetworkVersion;

			// Token: 0x04000792 RID: 1938
			internal IntPtr OverlayEvents;

			// Token: 0x04000793 RID: 1939
			internal uint OverlayVersion;

			// Token: 0x04000794 RID: 1940
			internal IntPtr StorageEvents;

			// Token: 0x04000795 RID: 1941
			internal uint StorageVersion;

			// Token: 0x04000796 RID: 1942
			internal IntPtr StoreEvents;

			// Token: 0x04000797 RID: 1943
			internal uint StoreVersion;

			// Token: 0x04000798 RID: 1944
			internal IntPtr VoiceEvents;

			// Token: 0x04000799 RID: 1945
			internal uint VoiceVersion;

			// Token: 0x0400079A RID: 1946
			internal IntPtr AchievementEvents;

			// Token: 0x0400079B RID: 1947
			internal uint AchievementVersion;
		}

		// Token: 0x020001EA RID: 490
		// (Invoke) Token: 0x0600108A RID: 4234
		public delegate void SetLogHookHandler(LogLevel level, string message);
	}
}
