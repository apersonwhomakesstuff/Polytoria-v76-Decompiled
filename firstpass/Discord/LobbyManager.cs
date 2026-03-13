using System;
using System.Collections.Generic;
using System.Text;

namespace Discord
{
	// Token: 0x0200015F RID: 351
	public class LobbyManager
	{
		// Token: 0x170001C8 RID: 456
		// (get) Token: 0x06000DB0 RID: 3504 RVA: 0x000107F0 File Offset: 0x0000E9F0
		private LobbyManager.FFIMethods Methods
		{
			get
			{
				return default(LobbyManager.FFIMethods);
			}
		}

		// Token: 0x14000008 RID: 8
		// (add) Token: 0x06000DB1 RID: 3505 RVA: 0x0000F01B File Offset: 0x0000D21B
		// (remove) Token: 0x06000DB2 RID: 3506 RVA: 0x0000F01D File Offset: 0x0000D21D
		public event LobbyManager.LobbyUpdateHandler OnLobbyUpdate
		{
			add
			{
			}
			remove
			{
			}
		}

		// Token: 0x14000009 RID: 9
		// (add) Token: 0x06000DB3 RID: 3507 RVA: 0x0000F01F File Offset: 0x0000D21F
		// (remove) Token: 0x06000DB4 RID: 3508 RVA: 0x0000F021 File Offset: 0x0000D221
		public event LobbyManager.LobbyDeleteHandler OnLobbyDelete
		{
			add
			{
			}
			remove
			{
			}
		}

		// Token: 0x1400000A RID: 10
		// (add) Token: 0x06000DB5 RID: 3509 RVA: 0x0000F023 File Offset: 0x0000D223
		// (remove) Token: 0x06000DB6 RID: 3510 RVA: 0x0000F025 File Offset: 0x0000D225
		public event LobbyManager.MemberConnectHandler OnMemberConnect
		{
			add
			{
			}
			remove
			{
			}
		}

		// Token: 0x1400000B RID: 11
		// (add) Token: 0x06000DB7 RID: 3511 RVA: 0x0000F027 File Offset: 0x0000D227
		// (remove) Token: 0x06000DB8 RID: 3512 RVA: 0x0000F029 File Offset: 0x0000D229
		public event LobbyManager.MemberUpdateHandler OnMemberUpdate
		{
			add
			{
			}
			remove
			{
			}
		}

		// Token: 0x1400000C RID: 12
		// (add) Token: 0x06000DB9 RID: 3513 RVA: 0x0000F02B File Offset: 0x0000D22B
		// (remove) Token: 0x06000DBA RID: 3514 RVA: 0x0000F02D File Offset: 0x0000D22D
		public event LobbyManager.MemberDisconnectHandler OnMemberDisconnect
		{
			add
			{
			}
			remove
			{
			}
		}

		// Token: 0x1400000D RID: 13
		// (add) Token: 0x06000DBB RID: 3515 RVA: 0x0000F02F File Offset: 0x0000D22F
		// (remove) Token: 0x06000DBC RID: 3516 RVA: 0x0000F031 File Offset: 0x0000D231
		public event LobbyManager.LobbyMessageHandler OnLobbyMessage
		{
			add
			{
			}
			remove
			{
			}
		}

		// Token: 0x1400000E RID: 14
		// (add) Token: 0x06000DBD RID: 3517 RVA: 0x0000F033 File Offset: 0x0000D233
		// (remove) Token: 0x06000DBE RID: 3518 RVA: 0x0000F035 File Offset: 0x0000D235
		public event LobbyManager.SpeakingHandler OnSpeaking
		{
			add
			{
			}
			remove
			{
			}
		}

		// Token: 0x1400000F RID: 15
		// (add) Token: 0x06000DBF RID: 3519 RVA: 0x0000F037 File Offset: 0x0000D237
		// (remove) Token: 0x06000DC0 RID: 3520 RVA: 0x0000F039 File Offset: 0x0000D239
		public event LobbyManager.NetworkMessageHandler OnNetworkMessage
		{
			add
			{
			}
			remove
			{
			}
		}

		// Token: 0x06000DC1 RID: 3521 RVA: 0x0000F03B File Offset: 0x0000D23B
		internal LobbyManager(IntPtr ptr, IntPtr eventsPtr, ref LobbyManager.FFIEvents events)
		{
		}

		// Token: 0x06000DC2 RID: 3522 RVA: 0x0000F043 File Offset: 0x0000D243
		private void InitEvents(IntPtr eventsPtr, ref LobbyManager.FFIEvents events)
		{
		}

		// Token: 0x06000DC3 RID: 3523 RVA: 0x00010808 File Offset: 0x0000EA08
		public LobbyTransaction GetLobbyCreateTransaction()
		{
			return default(LobbyTransaction);
		}

		// Token: 0x06000DC4 RID: 3524 RVA: 0x00010820 File Offset: 0x0000EA20
		public LobbyTransaction GetLobbyUpdateTransaction(long lobbyId)
		{
			return default(LobbyTransaction);
		}

		// Token: 0x06000DC5 RID: 3525 RVA: 0x00010838 File Offset: 0x0000EA38
		public LobbyMemberTransaction GetMemberUpdateTransaction(long lobbyId, long userId)
		{
			return default(LobbyMemberTransaction);
		}

		// Token: 0x06000DC6 RID: 3526 RVA: 0x0000F045 File Offset: 0x0000D245
		private static void CreateLobbyCallbackImpl(IntPtr ptr, Result result, ref Lobby lobby)
		{
		}

		// Token: 0x06000DC7 RID: 3527 RVA: 0x0000F047 File Offset: 0x0000D247
		public void CreateLobby(LobbyTransaction transaction, LobbyManager.CreateLobbyHandler callback)
		{
		}

		// Token: 0x06000DC8 RID: 3528 RVA: 0x0000F049 File Offset: 0x0000D249
		private static void UpdateLobbyCallbackImpl(IntPtr ptr, Result result)
		{
		}

		// Token: 0x06000DC9 RID: 3529 RVA: 0x0000F04B File Offset: 0x0000D24B
		public void UpdateLobby(long lobbyId, LobbyTransaction transaction, LobbyManager.UpdateLobbyHandler callback)
		{
		}

		// Token: 0x06000DCA RID: 3530 RVA: 0x0000F04D File Offset: 0x0000D24D
		private static void DeleteLobbyCallbackImpl(IntPtr ptr, Result result)
		{
		}

		// Token: 0x06000DCB RID: 3531 RVA: 0x0000F04F File Offset: 0x0000D24F
		public void DeleteLobby(long lobbyId, LobbyManager.DeleteLobbyHandler callback)
		{
		}

		// Token: 0x06000DCC RID: 3532 RVA: 0x0000F051 File Offset: 0x0000D251
		private static void ConnectLobbyCallbackImpl(IntPtr ptr, Result result, ref Lobby lobby)
		{
		}

		// Token: 0x06000DCD RID: 3533 RVA: 0x0000F053 File Offset: 0x0000D253
		public void ConnectLobby(long lobbyId, string secret, LobbyManager.ConnectLobbyHandler callback)
		{
		}

		// Token: 0x06000DCE RID: 3534 RVA: 0x0000F055 File Offset: 0x0000D255
		private static void ConnectLobbyWithActivitySecretCallbackImpl(IntPtr ptr, Result result, ref Lobby lobby)
		{
		}

		// Token: 0x06000DCF RID: 3535 RVA: 0x0000F057 File Offset: 0x0000D257
		public void ConnectLobbyWithActivitySecret(string activitySecret, LobbyManager.ConnectLobbyWithActivitySecretHandler callback)
		{
		}

		// Token: 0x06000DD0 RID: 3536 RVA: 0x0000F059 File Offset: 0x0000D259
		private static void DisconnectLobbyCallbackImpl(IntPtr ptr, Result result)
		{
		}

		// Token: 0x06000DD1 RID: 3537 RVA: 0x0000F05B File Offset: 0x0000D25B
		public void DisconnectLobby(long lobbyId, LobbyManager.DisconnectLobbyHandler callback)
		{
		}

		// Token: 0x06000DD2 RID: 3538 RVA: 0x00010850 File Offset: 0x0000EA50
		public Lobby GetLobby(long lobbyId)
		{
			return default(Lobby);
		}

		// Token: 0x06000DD3 RID: 3539 RVA: 0x0000F05D File Offset: 0x0000D25D
		public string GetLobbyActivitySecret(long lobbyId)
		{
			return null;
		}

		// Token: 0x06000DD4 RID: 3540 RVA: 0x0000F060 File Offset: 0x0000D260
		public string GetLobbyMetadataValue(long lobbyId, string key)
		{
			return null;
		}

		// Token: 0x06000DD5 RID: 3541 RVA: 0x0000F063 File Offset: 0x0000D263
		public string GetLobbyMetadataKey(long lobbyId, int index)
		{
			return null;
		}

		// Token: 0x06000DD6 RID: 3542 RVA: 0x0000F066 File Offset: 0x0000D266
		public int LobbyMetadataCount(long lobbyId)
		{
			return 0;
		}

		// Token: 0x06000DD7 RID: 3543 RVA: 0x0000F069 File Offset: 0x0000D269
		public int MemberCount(long lobbyId)
		{
			return 0;
		}

		// Token: 0x06000DD8 RID: 3544 RVA: 0x0000F06C File Offset: 0x0000D26C
		public long GetMemberUserId(long lobbyId, int index)
		{
			return 0L;
		}

		// Token: 0x06000DD9 RID: 3545 RVA: 0x00010868 File Offset: 0x0000EA68
		public User GetMemberUser(long lobbyId, long userId)
		{
			return default(User);
		}

		// Token: 0x06000DDA RID: 3546 RVA: 0x0000F070 File Offset: 0x0000D270
		public string GetMemberMetadataValue(long lobbyId, long userId, string key)
		{
			return null;
		}

		// Token: 0x06000DDB RID: 3547 RVA: 0x0000F073 File Offset: 0x0000D273
		public string GetMemberMetadataKey(long lobbyId, long userId, int index)
		{
			return null;
		}

		// Token: 0x06000DDC RID: 3548 RVA: 0x0000F076 File Offset: 0x0000D276
		public int MemberMetadataCount(long lobbyId, long userId)
		{
			return 0;
		}

		// Token: 0x06000DDD RID: 3549 RVA: 0x0000F079 File Offset: 0x0000D279
		private static void UpdateMemberCallbackImpl(IntPtr ptr, Result result)
		{
		}

		// Token: 0x06000DDE RID: 3550 RVA: 0x0000F07B File Offset: 0x0000D27B
		public void UpdateMember(long lobbyId, long userId, LobbyMemberTransaction transaction, LobbyManager.UpdateMemberHandler callback)
		{
		}

		// Token: 0x06000DDF RID: 3551 RVA: 0x0000F07D File Offset: 0x0000D27D
		private static void SendLobbyMessageCallbackImpl(IntPtr ptr, Result result)
		{
		}

		// Token: 0x06000DE0 RID: 3552 RVA: 0x0000F07F File Offset: 0x0000D27F
		public void SendLobbyMessage(long lobbyId, byte[] data, LobbyManager.SendLobbyMessageHandler callback)
		{
		}

		// Token: 0x06000DE1 RID: 3553 RVA: 0x00010880 File Offset: 0x0000EA80
		public LobbySearchQuery GetSearchQuery()
		{
			return default(LobbySearchQuery);
		}

		// Token: 0x06000DE2 RID: 3554 RVA: 0x0000F081 File Offset: 0x0000D281
		private static void SearchCallbackImpl(IntPtr ptr, Result result)
		{
		}

		// Token: 0x06000DE3 RID: 3555 RVA: 0x0000F083 File Offset: 0x0000D283
		public void Search(LobbySearchQuery query, LobbyManager.SearchHandler callback)
		{
		}

		// Token: 0x06000DE4 RID: 3556 RVA: 0x0000F085 File Offset: 0x0000D285
		public int LobbyCount()
		{
			return 0;
		}

		// Token: 0x06000DE5 RID: 3557 RVA: 0x0000F088 File Offset: 0x0000D288
		public long GetLobbyId(int index)
		{
			return 0L;
		}

		// Token: 0x06000DE6 RID: 3558 RVA: 0x0000F08C File Offset: 0x0000D28C
		private static void ConnectVoiceCallbackImpl(IntPtr ptr, Result result)
		{
		}

		// Token: 0x06000DE7 RID: 3559 RVA: 0x0000F08E File Offset: 0x0000D28E
		public void ConnectVoice(long lobbyId, LobbyManager.ConnectVoiceHandler callback)
		{
		}

		// Token: 0x06000DE8 RID: 3560 RVA: 0x0000F090 File Offset: 0x0000D290
		private static void DisconnectVoiceCallbackImpl(IntPtr ptr, Result result)
		{
		}

		// Token: 0x06000DE9 RID: 3561 RVA: 0x0000F092 File Offset: 0x0000D292
		public void DisconnectVoice(long lobbyId, LobbyManager.DisconnectVoiceHandler callback)
		{
		}

		// Token: 0x06000DEA RID: 3562 RVA: 0x0000F094 File Offset: 0x0000D294
		public void ConnectNetwork(long lobbyId)
		{
		}

		// Token: 0x06000DEB RID: 3563 RVA: 0x0000F096 File Offset: 0x0000D296
		public void DisconnectNetwork(long lobbyId)
		{
		}

		// Token: 0x06000DEC RID: 3564 RVA: 0x0000F098 File Offset: 0x0000D298
		public void FlushNetwork()
		{
		}

		// Token: 0x06000DED RID: 3565 RVA: 0x0000F09A File Offset: 0x0000D29A
		public void OpenNetworkChannel(long lobbyId, byte channelId, bool reliable)
		{
		}

		// Token: 0x06000DEE RID: 3566 RVA: 0x0000F09C File Offset: 0x0000D29C
		public void SendNetworkMessage(long lobbyId, long userId, byte channelId, byte[] data)
		{
		}

		// Token: 0x06000DEF RID: 3567 RVA: 0x0000F09E File Offset: 0x0000D29E
		private static void OnLobbyUpdateImpl(IntPtr ptr, long lobbyId)
		{
		}

		// Token: 0x06000DF0 RID: 3568 RVA: 0x0000F0A0 File Offset: 0x0000D2A0
		private static void OnLobbyDeleteImpl(IntPtr ptr, long lobbyId, uint reason)
		{
		}

		// Token: 0x06000DF1 RID: 3569 RVA: 0x0000F0A2 File Offset: 0x0000D2A2
		private static void OnMemberConnectImpl(IntPtr ptr, long lobbyId, long userId)
		{
		}

		// Token: 0x06000DF2 RID: 3570 RVA: 0x0000F0A4 File Offset: 0x0000D2A4
		private static void OnMemberUpdateImpl(IntPtr ptr, long lobbyId, long userId)
		{
		}

		// Token: 0x06000DF3 RID: 3571 RVA: 0x0000F0A6 File Offset: 0x0000D2A6
		private static void OnMemberDisconnectImpl(IntPtr ptr, long lobbyId, long userId)
		{
		}

		// Token: 0x06000DF4 RID: 3572 RVA: 0x0000F0A8 File Offset: 0x0000D2A8
		private static void OnLobbyMessageImpl(IntPtr ptr, long lobbyId, long userId, IntPtr dataPtr, int dataLen)
		{
		}

		// Token: 0x06000DF5 RID: 3573 RVA: 0x0000F0AA File Offset: 0x0000D2AA
		private static void OnSpeakingImpl(IntPtr ptr, long lobbyId, long userId, bool speaking)
		{
		}

		// Token: 0x06000DF6 RID: 3574 RVA: 0x0000F0AC File Offset: 0x0000D2AC
		private static void OnNetworkMessageImpl(IntPtr ptr, long lobbyId, long userId, byte channelId, IntPtr dataPtr, int dataLen)
		{
		}

		// Token: 0x06000DF7 RID: 3575 RVA: 0x0000F0AE File Offset: 0x0000D2AE
		public IEnumerable<User> GetMemberUsers(long lobbyID)
		{
			return null;
		}

		// Token: 0x06000DF8 RID: 3576 RVA: 0x0000F0B1 File Offset: 0x0000D2B1
		public void SendLobbyMessage(long lobbyID, string data, LobbyManager.SendLobbyMessageHandler handler)
		{
		}

		// Token: 0x040005CE RID: 1486
		private IntPtr MethodsPtr;

		// Token: 0x040005CF RID: 1487
		private object MethodsStructure;

		// Token: 0x020001FC RID: 508
		internal struct FFIEvents
		{
			// Token: 0x040007AF RID: 1967
			internal LobbyManager.FFIEvents.LobbyUpdateHandler OnLobbyUpdate;

			// Token: 0x040007B0 RID: 1968
			internal LobbyManager.FFIEvents.LobbyDeleteHandler OnLobbyDelete;

			// Token: 0x040007B1 RID: 1969
			internal LobbyManager.FFIEvents.MemberConnectHandler OnMemberConnect;

			// Token: 0x040007B2 RID: 1970
			internal LobbyManager.FFIEvents.MemberUpdateHandler OnMemberUpdate;

			// Token: 0x040007B3 RID: 1971
			internal LobbyManager.FFIEvents.MemberDisconnectHandler OnMemberDisconnect;

			// Token: 0x040007B4 RID: 1972
			internal LobbyManager.FFIEvents.LobbyMessageHandler OnLobbyMessage;

			// Token: 0x040007B5 RID: 1973
			internal LobbyManager.FFIEvents.SpeakingHandler OnSpeaking;

			// Token: 0x040007B6 RID: 1974
			internal LobbyManager.FFIEvents.NetworkMessageHandler OnNetworkMessage;

			// Token: 0x0200027D RID: 637
			// (Invoke) Token: 0x0600126B RID: 4715
			internal delegate void LobbyUpdateHandler(IntPtr ptr, long lobbyId);

			// Token: 0x0200027E RID: 638
			// (Invoke) Token: 0x0600126F RID: 4719
			internal delegate void LobbyDeleteHandler(IntPtr ptr, long lobbyId, uint reason);

			// Token: 0x0200027F RID: 639
			// (Invoke) Token: 0x06001273 RID: 4723
			internal delegate void MemberConnectHandler(IntPtr ptr, long lobbyId, long userId);

			// Token: 0x02000280 RID: 640
			// (Invoke) Token: 0x06001277 RID: 4727
			internal delegate void MemberUpdateHandler(IntPtr ptr, long lobbyId, long userId);

			// Token: 0x02000281 RID: 641
			// (Invoke) Token: 0x0600127B RID: 4731
			internal delegate void MemberDisconnectHandler(IntPtr ptr, long lobbyId, long userId);

			// Token: 0x02000282 RID: 642
			// (Invoke) Token: 0x0600127F RID: 4735
			internal delegate void LobbyMessageHandler(IntPtr ptr, long lobbyId, long userId, IntPtr dataPtr, int dataLen);

			// Token: 0x02000283 RID: 643
			// (Invoke) Token: 0x06001283 RID: 4739
			internal delegate void SpeakingHandler(IntPtr ptr, long lobbyId, long userId, bool speaking);

			// Token: 0x02000284 RID: 644
			// (Invoke) Token: 0x06001287 RID: 4743
			internal delegate void NetworkMessageHandler(IntPtr ptr, long lobbyId, long userId, byte channelId, IntPtr dataPtr, int dataLen);
		}

		// Token: 0x020001FD RID: 509
		internal struct FFIMethods
		{
			// Token: 0x040007B7 RID: 1975
			internal LobbyManager.FFIMethods.GetLobbyCreateTransactionMethod GetLobbyCreateTransaction;

			// Token: 0x040007B8 RID: 1976
			internal LobbyManager.FFIMethods.GetLobbyUpdateTransactionMethod GetLobbyUpdateTransaction;

			// Token: 0x040007B9 RID: 1977
			internal LobbyManager.FFIMethods.GetMemberUpdateTransactionMethod GetMemberUpdateTransaction;

			// Token: 0x040007BA RID: 1978
			internal LobbyManager.FFIMethods.CreateLobbyMethod CreateLobby;

			// Token: 0x040007BB RID: 1979
			internal LobbyManager.FFIMethods.UpdateLobbyMethod UpdateLobby;

			// Token: 0x040007BC RID: 1980
			internal LobbyManager.FFIMethods.DeleteLobbyMethod DeleteLobby;

			// Token: 0x040007BD RID: 1981
			internal LobbyManager.FFIMethods.ConnectLobbyMethod ConnectLobby;

			// Token: 0x040007BE RID: 1982
			internal LobbyManager.FFIMethods.ConnectLobbyWithActivitySecretMethod ConnectLobbyWithActivitySecret;

			// Token: 0x040007BF RID: 1983
			internal LobbyManager.FFIMethods.DisconnectLobbyMethod DisconnectLobby;

			// Token: 0x040007C0 RID: 1984
			internal LobbyManager.FFIMethods.GetLobbyMethod GetLobby;

			// Token: 0x040007C1 RID: 1985
			internal LobbyManager.FFIMethods.GetLobbyActivitySecretMethod GetLobbyActivitySecret;

			// Token: 0x040007C2 RID: 1986
			internal LobbyManager.FFIMethods.GetLobbyMetadataValueMethod GetLobbyMetadataValue;

			// Token: 0x040007C3 RID: 1987
			internal LobbyManager.FFIMethods.GetLobbyMetadataKeyMethod GetLobbyMetadataKey;

			// Token: 0x040007C4 RID: 1988
			internal LobbyManager.FFIMethods.LobbyMetadataCountMethod LobbyMetadataCount;

			// Token: 0x040007C5 RID: 1989
			internal LobbyManager.FFIMethods.MemberCountMethod MemberCount;

			// Token: 0x040007C6 RID: 1990
			internal LobbyManager.FFIMethods.GetMemberUserIdMethod GetMemberUserId;

			// Token: 0x040007C7 RID: 1991
			internal LobbyManager.FFIMethods.GetMemberUserMethod GetMemberUser;

			// Token: 0x040007C8 RID: 1992
			internal LobbyManager.FFIMethods.GetMemberMetadataValueMethod GetMemberMetadataValue;

			// Token: 0x040007C9 RID: 1993
			internal LobbyManager.FFIMethods.GetMemberMetadataKeyMethod GetMemberMetadataKey;

			// Token: 0x040007CA RID: 1994
			internal LobbyManager.FFIMethods.MemberMetadataCountMethod MemberMetadataCount;

			// Token: 0x040007CB RID: 1995
			internal LobbyManager.FFIMethods.UpdateMemberMethod UpdateMember;

			// Token: 0x040007CC RID: 1996
			internal LobbyManager.FFIMethods.SendLobbyMessageMethod SendLobbyMessage;

			// Token: 0x040007CD RID: 1997
			internal LobbyManager.FFIMethods.GetSearchQueryMethod GetSearchQuery;

			// Token: 0x040007CE RID: 1998
			internal LobbyManager.FFIMethods.SearchMethod Search;

			// Token: 0x040007CF RID: 1999
			internal LobbyManager.FFIMethods.LobbyCountMethod LobbyCount;

			// Token: 0x040007D0 RID: 2000
			internal LobbyManager.FFIMethods.GetLobbyIdMethod GetLobbyId;

			// Token: 0x040007D1 RID: 2001
			internal LobbyManager.FFIMethods.ConnectVoiceMethod ConnectVoice;

			// Token: 0x040007D2 RID: 2002
			internal LobbyManager.FFIMethods.DisconnectVoiceMethod DisconnectVoice;

			// Token: 0x040007D3 RID: 2003
			internal LobbyManager.FFIMethods.ConnectNetworkMethod ConnectNetwork;

			// Token: 0x040007D4 RID: 2004
			internal LobbyManager.FFIMethods.DisconnectNetworkMethod DisconnectNetwork;

			// Token: 0x040007D5 RID: 2005
			internal LobbyManager.FFIMethods.FlushNetworkMethod FlushNetwork;

			// Token: 0x040007D6 RID: 2006
			internal LobbyManager.FFIMethods.OpenNetworkChannelMethod OpenNetworkChannel;

			// Token: 0x040007D7 RID: 2007
			internal LobbyManager.FFIMethods.SendNetworkMessageMethod SendNetworkMessage;

			// Token: 0x02000285 RID: 645
			// (Invoke) Token: 0x0600128B RID: 4747
			internal delegate Result GetLobbyCreateTransactionMethod(IntPtr methodsPtr, ref IntPtr transaction);

			// Token: 0x02000286 RID: 646
			// (Invoke) Token: 0x0600128F RID: 4751
			internal delegate Result GetLobbyUpdateTransactionMethod(IntPtr methodsPtr, long lobbyId, ref IntPtr transaction);

			// Token: 0x02000287 RID: 647
			// (Invoke) Token: 0x06001293 RID: 4755
			internal delegate Result GetMemberUpdateTransactionMethod(IntPtr methodsPtr, long lobbyId, long userId, ref IntPtr transaction);

			// Token: 0x02000288 RID: 648
			// (Invoke) Token: 0x06001297 RID: 4759
			internal delegate void CreateLobbyCallback(IntPtr ptr, Result result, ref Lobby lobby);

			// Token: 0x02000289 RID: 649
			// (Invoke) Token: 0x0600129B RID: 4763
			internal delegate void CreateLobbyMethod(IntPtr methodsPtr, IntPtr transaction, IntPtr callbackData, LobbyManager.FFIMethods.CreateLobbyCallback callback);

			// Token: 0x0200028A RID: 650
			// (Invoke) Token: 0x0600129F RID: 4767
			internal delegate void UpdateLobbyCallback(IntPtr ptr, Result result);

			// Token: 0x0200028B RID: 651
			// (Invoke) Token: 0x060012A3 RID: 4771
			internal delegate void UpdateLobbyMethod(IntPtr methodsPtr, long lobbyId, IntPtr transaction, IntPtr callbackData, LobbyManager.FFIMethods.UpdateLobbyCallback callback);

			// Token: 0x0200028C RID: 652
			// (Invoke) Token: 0x060012A7 RID: 4775
			internal delegate void DeleteLobbyCallback(IntPtr ptr, Result result);

			// Token: 0x0200028D RID: 653
			// (Invoke) Token: 0x060012AB RID: 4779
			internal delegate void DeleteLobbyMethod(IntPtr methodsPtr, long lobbyId, IntPtr callbackData, LobbyManager.FFIMethods.DeleteLobbyCallback callback);

			// Token: 0x0200028E RID: 654
			// (Invoke) Token: 0x060012AF RID: 4783
			internal delegate void ConnectLobbyCallback(IntPtr ptr, Result result, ref Lobby lobby);

			// Token: 0x0200028F RID: 655
			// (Invoke) Token: 0x060012B3 RID: 4787
			internal delegate void ConnectLobbyMethod(IntPtr methodsPtr, long lobbyId, string secret, IntPtr callbackData, LobbyManager.FFIMethods.ConnectLobbyCallback callback);

			// Token: 0x02000290 RID: 656
			// (Invoke) Token: 0x060012B7 RID: 4791
			internal delegate void ConnectLobbyWithActivitySecretCallback(IntPtr ptr, Result result, ref Lobby lobby);

			// Token: 0x02000291 RID: 657
			// (Invoke) Token: 0x060012BB RID: 4795
			internal delegate void ConnectLobbyWithActivitySecretMethod(IntPtr methodsPtr, string activitySecret, IntPtr callbackData, LobbyManager.FFIMethods.ConnectLobbyWithActivitySecretCallback callback);

			// Token: 0x02000292 RID: 658
			// (Invoke) Token: 0x060012BF RID: 4799
			internal delegate void DisconnectLobbyCallback(IntPtr ptr, Result result);

			// Token: 0x02000293 RID: 659
			// (Invoke) Token: 0x060012C3 RID: 4803
			internal delegate void DisconnectLobbyMethod(IntPtr methodsPtr, long lobbyId, IntPtr callbackData, LobbyManager.FFIMethods.DisconnectLobbyCallback callback);

			// Token: 0x02000294 RID: 660
			// (Invoke) Token: 0x060012C7 RID: 4807
			internal delegate Result GetLobbyMethod(IntPtr methodsPtr, long lobbyId, ref Lobby lobby);

			// Token: 0x02000295 RID: 661
			// (Invoke) Token: 0x060012CB RID: 4811
			internal delegate Result GetLobbyActivitySecretMethod(IntPtr methodsPtr, long lobbyId, StringBuilder secret);

			// Token: 0x02000296 RID: 662
			// (Invoke) Token: 0x060012CF RID: 4815
			internal delegate Result GetLobbyMetadataValueMethod(IntPtr methodsPtr, long lobbyId, string key, StringBuilder value);

			// Token: 0x02000297 RID: 663
			// (Invoke) Token: 0x060012D3 RID: 4819
			internal delegate Result GetLobbyMetadataKeyMethod(IntPtr methodsPtr, long lobbyId, int index, StringBuilder key);

			// Token: 0x02000298 RID: 664
			// (Invoke) Token: 0x060012D7 RID: 4823
			internal delegate Result LobbyMetadataCountMethod(IntPtr methodsPtr, long lobbyId, ref int count);

			// Token: 0x02000299 RID: 665
			// (Invoke) Token: 0x060012DB RID: 4827
			internal delegate Result MemberCountMethod(IntPtr methodsPtr, long lobbyId, ref int count);

			// Token: 0x0200029A RID: 666
			// (Invoke) Token: 0x060012DF RID: 4831
			internal delegate Result GetMemberUserIdMethod(IntPtr methodsPtr, long lobbyId, int index, ref long userId);

			// Token: 0x0200029B RID: 667
			// (Invoke) Token: 0x060012E3 RID: 4835
			internal delegate Result GetMemberUserMethod(IntPtr methodsPtr, long lobbyId, long userId, ref User user);

			// Token: 0x0200029C RID: 668
			// (Invoke) Token: 0x060012E7 RID: 4839
			internal delegate Result GetMemberMetadataValueMethod(IntPtr methodsPtr, long lobbyId, long userId, string key, StringBuilder value);

			// Token: 0x0200029D RID: 669
			// (Invoke) Token: 0x060012EB RID: 4843
			internal delegate Result GetMemberMetadataKeyMethod(IntPtr methodsPtr, long lobbyId, long userId, int index, StringBuilder key);

			// Token: 0x0200029E RID: 670
			// (Invoke) Token: 0x060012EF RID: 4847
			internal delegate Result MemberMetadataCountMethod(IntPtr methodsPtr, long lobbyId, long userId, ref int count);

			// Token: 0x0200029F RID: 671
			// (Invoke) Token: 0x060012F3 RID: 4851
			internal delegate void UpdateMemberCallback(IntPtr ptr, Result result);

			// Token: 0x020002A0 RID: 672
			// (Invoke) Token: 0x060012F7 RID: 4855
			internal delegate void UpdateMemberMethod(IntPtr methodsPtr, long lobbyId, long userId, IntPtr transaction, IntPtr callbackData, LobbyManager.FFIMethods.UpdateMemberCallback callback);

			// Token: 0x020002A1 RID: 673
			// (Invoke) Token: 0x060012FB RID: 4859
			internal delegate void SendLobbyMessageCallback(IntPtr ptr, Result result);

			// Token: 0x020002A2 RID: 674
			// (Invoke) Token: 0x060012FF RID: 4863
			internal delegate void SendLobbyMessageMethod(IntPtr methodsPtr, long lobbyId, byte[] data, int dataLen, IntPtr callbackData, LobbyManager.FFIMethods.SendLobbyMessageCallback callback);

			// Token: 0x020002A3 RID: 675
			// (Invoke) Token: 0x06001303 RID: 4867
			internal delegate Result GetSearchQueryMethod(IntPtr methodsPtr, ref IntPtr query);

			// Token: 0x020002A4 RID: 676
			// (Invoke) Token: 0x06001307 RID: 4871
			internal delegate void SearchCallback(IntPtr ptr, Result result);

			// Token: 0x020002A5 RID: 677
			// (Invoke) Token: 0x0600130B RID: 4875
			internal delegate void SearchMethod(IntPtr methodsPtr, IntPtr query, IntPtr callbackData, LobbyManager.FFIMethods.SearchCallback callback);

			// Token: 0x020002A6 RID: 678
			// (Invoke) Token: 0x0600130F RID: 4879
			internal delegate void LobbyCountMethod(IntPtr methodsPtr, ref int count);

			// Token: 0x020002A7 RID: 679
			// (Invoke) Token: 0x06001313 RID: 4883
			internal delegate Result GetLobbyIdMethod(IntPtr methodsPtr, int index, ref long lobbyId);

			// Token: 0x020002A8 RID: 680
			// (Invoke) Token: 0x06001317 RID: 4887
			internal delegate void ConnectVoiceCallback(IntPtr ptr, Result result);

			// Token: 0x020002A9 RID: 681
			// (Invoke) Token: 0x0600131B RID: 4891
			internal delegate void ConnectVoiceMethod(IntPtr methodsPtr, long lobbyId, IntPtr callbackData, LobbyManager.FFIMethods.ConnectVoiceCallback callback);

			// Token: 0x020002AA RID: 682
			// (Invoke) Token: 0x0600131F RID: 4895
			internal delegate void DisconnectVoiceCallback(IntPtr ptr, Result result);

			// Token: 0x020002AB RID: 683
			// (Invoke) Token: 0x06001323 RID: 4899
			internal delegate void DisconnectVoiceMethod(IntPtr methodsPtr, long lobbyId, IntPtr callbackData, LobbyManager.FFIMethods.DisconnectVoiceCallback callback);

			// Token: 0x020002AC RID: 684
			// (Invoke) Token: 0x06001327 RID: 4903
			internal delegate Result ConnectNetworkMethod(IntPtr methodsPtr, long lobbyId);

			// Token: 0x020002AD RID: 685
			// (Invoke) Token: 0x0600132B RID: 4907
			internal delegate Result DisconnectNetworkMethod(IntPtr methodsPtr, long lobbyId);

			// Token: 0x020002AE RID: 686
			// (Invoke) Token: 0x0600132F RID: 4911
			internal delegate Result FlushNetworkMethod(IntPtr methodsPtr);

			// Token: 0x020002AF RID: 687
			// (Invoke) Token: 0x06001333 RID: 4915
			internal delegate Result OpenNetworkChannelMethod(IntPtr methodsPtr, long lobbyId, byte channelId, bool reliable);

			// Token: 0x020002B0 RID: 688
			// (Invoke) Token: 0x06001337 RID: 4919
			internal delegate Result SendNetworkMessageMethod(IntPtr methodsPtr, long lobbyId, long userId, byte channelId, byte[] data, int dataLen);
		}

		// Token: 0x020001FE RID: 510
		// (Invoke) Token: 0x060010B2 RID: 4274
		public delegate void CreateLobbyHandler(Result result, ref Lobby lobby);

		// Token: 0x020001FF RID: 511
		// (Invoke) Token: 0x060010B6 RID: 4278
		public delegate void UpdateLobbyHandler(Result result);

		// Token: 0x02000200 RID: 512
		// (Invoke) Token: 0x060010BA RID: 4282
		public delegate void DeleteLobbyHandler(Result result);

		// Token: 0x02000201 RID: 513
		// (Invoke) Token: 0x060010BE RID: 4286
		public delegate void ConnectLobbyHandler(Result result, ref Lobby lobby);

		// Token: 0x02000202 RID: 514
		// (Invoke) Token: 0x060010C2 RID: 4290
		public delegate void ConnectLobbyWithActivitySecretHandler(Result result, ref Lobby lobby);

		// Token: 0x02000203 RID: 515
		// (Invoke) Token: 0x060010C6 RID: 4294
		public delegate void DisconnectLobbyHandler(Result result);

		// Token: 0x02000204 RID: 516
		// (Invoke) Token: 0x060010CA RID: 4298
		public delegate void UpdateMemberHandler(Result result);

		// Token: 0x02000205 RID: 517
		// (Invoke) Token: 0x060010CE RID: 4302
		public delegate void SendLobbyMessageHandler(Result result);

		// Token: 0x02000206 RID: 518
		// (Invoke) Token: 0x060010D2 RID: 4306
		public delegate void SearchHandler(Result result);

		// Token: 0x02000207 RID: 519
		// (Invoke) Token: 0x060010D6 RID: 4310
		public delegate void ConnectVoiceHandler(Result result);

		// Token: 0x02000208 RID: 520
		// (Invoke) Token: 0x060010DA RID: 4314
		public delegate void DisconnectVoiceHandler(Result result);

		// Token: 0x02000209 RID: 521
		// (Invoke) Token: 0x060010DE RID: 4318
		public delegate void LobbyUpdateHandler(long lobbyId);

		// Token: 0x0200020A RID: 522
		// (Invoke) Token: 0x060010E2 RID: 4322
		public delegate void LobbyDeleteHandler(long lobbyId, uint reason);

		// Token: 0x0200020B RID: 523
		// (Invoke) Token: 0x060010E6 RID: 4326
		public delegate void MemberConnectHandler(long lobbyId, long userId);

		// Token: 0x0200020C RID: 524
		// (Invoke) Token: 0x060010EA RID: 4330
		public delegate void MemberUpdateHandler(long lobbyId, long userId);

		// Token: 0x0200020D RID: 525
		// (Invoke) Token: 0x060010EE RID: 4334
		public delegate void MemberDisconnectHandler(long lobbyId, long userId);

		// Token: 0x0200020E RID: 526
		// (Invoke) Token: 0x060010F2 RID: 4338
		public delegate void LobbyMessageHandler(long lobbyId, long userId, byte[] data);

		// Token: 0x0200020F RID: 527
		// (Invoke) Token: 0x060010F6 RID: 4342
		public delegate void SpeakingHandler(long lobbyId, long userId, bool speaking);

		// Token: 0x02000210 RID: 528
		// (Invoke) Token: 0x060010FA RID: 4346
		public delegate void NetworkMessageHandler(long lobbyId, long userId, byte channelId, byte[] data);
	}
}
