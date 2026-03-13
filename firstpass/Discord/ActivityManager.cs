using System;

namespace Discord
{
	// Token: 0x02000129 RID: 297
	public class ActivityManager
	{
		// Token: 0x06000D3F RID: 3391 RVA: 0x0000EF18 File Offset: 0x0000D118
		public void RegisterCommand()
		{
		}

		// Token: 0x170001BF RID: 447
		// (get) Token: 0x06000D40 RID: 3392 RVA: 0x00010670 File Offset: 0x0000E870
		private ActivityManager.FFIMethods Methods
		{
			get
			{
				return default(ActivityManager.FFIMethods);
			}
		}

		// Token: 0x14000001 RID: 1
		// (add) Token: 0x06000D41 RID: 3393 RVA: 0x0000EF1A File Offset: 0x0000D11A
		// (remove) Token: 0x06000D42 RID: 3394 RVA: 0x0000EF1C File Offset: 0x0000D11C
		public event ActivityManager.ActivityJoinHandler OnActivityJoin
		{
			add
			{
			}
			remove
			{
			}
		}

		// Token: 0x14000002 RID: 2
		// (add) Token: 0x06000D43 RID: 3395 RVA: 0x0000EF1E File Offset: 0x0000D11E
		// (remove) Token: 0x06000D44 RID: 3396 RVA: 0x0000EF20 File Offset: 0x0000D120
		public event ActivityManager.ActivitySpectateHandler OnActivitySpectate
		{
			add
			{
			}
			remove
			{
			}
		}

		// Token: 0x14000003 RID: 3
		// (add) Token: 0x06000D45 RID: 3397 RVA: 0x0000EF22 File Offset: 0x0000D122
		// (remove) Token: 0x06000D46 RID: 3398 RVA: 0x0000EF24 File Offset: 0x0000D124
		public event ActivityManager.ActivityJoinRequestHandler OnActivityJoinRequest
		{
			add
			{
			}
			remove
			{
			}
		}

		// Token: 0x14000004 RID: 4
		// (add) Token: 0x06000D47 RID: 3399 RVA: 0x0000EF26 File Offset: 0x0000D126
		// (remove) Token: 0x06000D48 RID: 3400 RVA: 0x0000EF28 File Offset: 0x0000D128
		public event ActivityManager.ActivityInviteHandler OnActivityInvite
		{
			add
			{
			}
			remove
			{
			}
		}

		// Token: 0x06000D49 RID: 3401 RVA: 0x0000EF2A File Offset: 0x0000D12A
		internal ActivityManager(IntPtr ptr, IntPtr eventsPtr, ref ActivityManager.FFIEvents events)
		{
		}

		// Token: 0x06000D4A RID: 3402 RVA: 0x0000EF32 File Offset: 0x0000D132
		private void InitEvents(IntPtr eventsPtr, ref ActivityManager.FFIEvents events)
		{
		}

		// Token: 0x06000D4B RID: 3403 RVA: 0x0000EF34 File Offset: 0x0000D134
		public void RegisterCommand(string command)
		{
		}

		// Token: 0x06000D4C RID: 3404 RVA: 0x0000EF36 File Offset: 0x0000D136
		public void RegisterSteam(uint steamId)
		{
		}

		// Token: 0x06000D4D RID: 3405 RVA: 0x0000EF38 File Offset: 0x0000D138
		private static void UpdateActivityCallbackImpl(IntPtr ptr, Result result)
		{
		}

		// Token: 0x06000D4E RID: 3406 RVA: 0x0000EF3A File Offset: 0x0000D13A
		public void UpdateActivity(Activity activity, ActivityManager.UpdateActivityHandler callback)
		{
		}

		// Token: 0x06000D4F RID: 3407 RVA: 0x0000EF3C File Offset: 0x0000D13C
		private static void ClearActivityCallbackImpl(IntPtr ptr, Result result)
		{
		}

		// Token: 0x06000D50 RID: 3408 RVA: 0x0000EF3E File Offset: 0x0000D13E
		public void ClearActivity(ActivityManager.ClearActivityHandler callback)
		{
		}

		// Token: 0x06000D51 RID: 3409 RVA: 0x0000EF40 File Offset: 0x0000D140
		private static void SendRequestReplyCallbackImpl(IntPtr ptr, Result result)
		{
		}

		// Token: 0x06000D52 RID: 3410 RVA: 0x0000EF42 File Offset: 0x0000D142
		public void SendRequestReply(long userId, ActivityJoinRequestReply reply, ActivityManager.SendRequestReplyHandler callback)
		{
		}

		// Token: 0x06000D53 RID: 3411 RVA: 0x0000EF44 File Offset: 0x0000D144
		private static void SendInviteCallbackImpl(IntPtr ptr, Result result)
		{
		}

		// Token: 0x06000D54 RID: 3412 RVA: 0x0000EF46 File Offset: 0x0000D146
		public void SendInvite(long userId, ActivityActionType type, string content, ActivityManager.SendInviteHandler callback)
		{
		}

		// Token: 0x06000D55 RID: 3413 RVA: 0x0000EF48 File Offset: 0x0000D148
		private static void AcceptInviteCallbackImpl(IntPtr ptr, Result result)
		{
		}

		// Token: 0x06000D56 RID: 3414 RVA: 0x0000EF4A File Offset: 0x0000D14A
		public void AcceptInvite(long userId, ActivityManager.AcceptInviteHandler callback)
		{
		}

		// Token: 0x06000D57 RID: 3415 RVA: 0x0000EF4C File Offset: 0x0000D14C
		private static void OnActivityJoinImpl(IntPtr ptr, string secret)
		{
		}

		// Token: 0x06000D58 RID: 3416 RVA: 0x0000EF4E File Offset: 0x0000D14E
		private static void OnActivitySpectateImpl(IntPtr ptr, string secret)
		{
		}

		// Token: 0x06000D59 RID: 3417 RVA: 0x0000EF50 File Offset: 0x0000D150
		private static void OnActivityJoinRequestImpl(IntPtr ptr, ref User user)
		{
		}

		// Token: 0x06000D5A RID: 3418 RVA: 0x0000EF52 File Offset: 0x0000D152
		private static void OnActivityInviteImpl(IntPtr ptr, ActivityActionType type, ref User user, ref Activity activity)
		{
		}

		// Token: 0x040004B9 RID: 1209
		private IntPtr MethodsPtr;

		// Token: 0x040004BA RID: 1210
		private object MethodsStructure;

		// Token: 0x020001D9 RID: 473
		internal struct FFIEvents
		{
			// Token: 0x0400075A RID: 1882
			internal ActivityManager.FFIEvents.ActivityJoinHandler OnActivityJoin;

			// Token: 0x0400075B RID: 1883
			internal ActivityManager.FFIEvents.ActivitySpectateHandler OnActivitySpectate;

			// Token: 0x0400075C RID: 1884
			internal ActivityManager.FFIEvents.ActivityJoinRequestHandler OnActivityJoinRequest;

			// Token: 0x0400075D RID: 1885
			internal ActivityManager.FFIEvents.ActivityInviteHandler OnActivityInvite;

			// Token: 0x02000238 RID: 568
			// (Invoke) Token: 0x06001157 RID: 4439
			internal delegate void ActivityJoinHandler(IntPtr ptr, string secret);

			// Token: 0x02000239 RID: 569
			// (Invoke) Token: 0x0600115B RID: 4443
			internal delegate void ActivitySpectateHandler(IntPtr ptr, string secret);

			// Token: 0x0200023A RID: 570
			// (Invoke) Token: 0x0600115F RID: 4447
			internal delegate void ActivityJoinRequestHandler(IntPtr ptr, ref User user);

			// Token: 0x0200023B RID: 571
			// (Invoke) Token: 0x06001163 RID: 4451
			internal delegate void ActivityInviteHandler(IntPtr ptr, ActivityActionType type, ref User user, ref Activity activity);
		}

		// Token: 0x020001DA RID: 474
		internal struct FFIMethods
		{
			// Token: 0x0400075E RID: 1886
			internal ActivityManager.FFIMethods.RegisterCommandMethod RegisterCommand;

			// Token: 0x0400075F RID: 1887
			internal ActivityManager.FFIMethods.RegisterSteamMethod RegisterSteam;

			// Token: 0x04000760 RID: 1888
			internal ActivityManager.FFIMethods.UpdateActivityMethod UpdateActivity;

			// Token: 0x04000761 RID: 1889
			internal ActivityManager.FFIMethods.ClearActivityMethod ClearActivity;

			// Token: 0x04000762 RID: 1890
			internal ActivityManager.FFIMethods.SendRequestReplyMethod SendRequestReply;

			// Token: 0x04000763 RID: 1891
			internal ActivityManager.FFIMethods.SendInviteMethod SendInvite;

			// Token: 0x04000764 RID: 1892
			internal ActivityManager.FFIMethods.AcceptInviteMethod AcceptInvite;

			// Token: 0x0200023C RID: 572
			// (Invoke) Token: 0x06001167 RID: 4455
			internal delegate Result RegisterCommandMethod(IntPtr methodsPtr, string command);

			// Token: 0x0200023D RID: 573
			// (Invoke) Token: 0x0600116B RID: 4459
			internal delegate Result RegisterSteamMethod(IntPtr methodsPtr, uint steamId);

			// Token: 0x0200023E RID: 574
			// (Invoke) Token: 0x0600116F RID: 4463
			internal delegate void UpdateActivityCallback(IntPtr ptr, Result result);

			// Token: 0x0200023F RID: 575
			// (Invoke) Token: 0x06001173 RID: 4467
			internal delegate void UpdateActivityMethod(IntPtr methodsPtr, ref Activity activity, IntPtr callbackData, ActivityManager.FFIMethods.UpdateActivityCallback callback);

			// Token: 0x02000240 RID: 576
			// (Invoke) Token: 0x06001177 RID: 4471
			internal delegate void ClearActivityCallback(IntPtr ptr, Result result);

			// Token: 0x02000241 RID: 577
			// (Invoke) Token: 0x0600117B RID: 4475
			internal delegate void ClearActivityMethod(IntPtr methodsPtr, IntPtr callbackData, ActivityManager.FFIMethods.ClearActivityCallback callback);

			// Token: 0x02000242 RID: 578
			// (Invoke) Token: 0x0600117F RID: 4479
			internal delegate void SendRequestReplyCallback(IntPtr ptr, Result result);

			// Token: 0x02000243 RID: 579
			// (Invoke) Token: 0x06001183 RID: 4483
			internal delegate void SendRequestReplyMethod(IntPtr methodsPtr, long userId, ActivityJoinRequestReply reply, IntPtr callbackData, ActivityManager.FFIMethods.SendRequestReplyCallback callback);

			// Token: 0x02000244 RID: 580
			// (Invoke) Token: 0x06001187 RID: 4487
			internal delegate void SendInviteCallback(IntPtr ptr, Result result);

			// Token: 0x02000245 RID: 581
			// (Invoke) Token: 0x0600118B RID: 4491
			internal delegate void SendInviteMethod(IntPtr methodsPtr, long userId, ActivityActionType type, string content, IntPtr callbackData, ActivityManager.FFIMethods.SendInviteCallback callback);

			// Token: 0x02000246 RID: 582
			// (Invoke) Token: 0x0600118F RID: 4495
			internal delegate void AcceptInviteCallback(IntPtr ptr, Result result);

			// Token: 0x02000247 RID: 583
			// (Invoke) Token: 0x06001193 RID: 4499
			internal delegate void AcceptInviteMethod(IntPtr methodsPtr, long userId, IntPtr callbackData, ActivityManager.FFIMethods.AcceptInviteCallback callback);
		}

		// Token: 0x020001DB RID: 475
		// (Invoke) Token: 0x06001066 RID: 4198
		public delegate void UpdateActivityHandler(Result result);

		// Token: 0x020001DC RID: 476
		// (Invoke) Token: 0x0600106A RID: 4202
		public delegate void ClearActivityHandler(Result result);

		// Token: 0x020001DD RID: 477
		// (Invoke) Token: 0x0600106E RID: 4206
		public delegate void SendRequestReplyHandler(Result result);

		// Token: 0x020001DE RID: 478
		// (Invoke) Token: 0x06001072 RID: 4210
		public delegate void SendInviteHandler(Result result);

		// Token: 0x020001DF RID: 479
		// (Invoke) Token: 0x06001076 RID: 4214
		public delegate void AcceptInviteHandler(Result result);

		// Token: 0x020001E0 RID: 480
		// (Invoke) Token: 0x0600107A RID: 4218
		public delegate void ActivityJoinHandler(string secret);

		// Token: 0x020001E1 RID: 481
		// (Invoke) Token: 0x0600107E RID: 4222
		public delegate void ActivitySpectateHandler(string secret);

		// Token: 0x020001E2 RID: 482
		// (Invoke) Token: 0x06001082 RID: 4226
		public delegate void ActivityJoinRequestHandler(ref User user);

		// Token: 0x020001E3 RID: 483
		// (Invoke) Token: 0x06001086 RID: 4230
		public delegate void ActivityInviteHandler(ActivityActionType type, ref User user, ref Activity activity);
	}
}
