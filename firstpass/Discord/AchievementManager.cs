using System;

namespace Discord
{
	// Token: 0x02000165 RID: 357
	public class AchievementManager
	{
		// Token: 0x170001CE RID: 462
		// (get) Token: 0x06000E64 RID: 3684 RVA: 0x000109B8 File Offset: 0x0000EBB8
		private AchievementManager.FFIMethods Methods
		{
			get
			{
				return default(AchievementManager.FFIMethods);
			}
		}

		// Token: 0x14000016 RID: 22
		// (add) Token: 0x06000E65 RID: 3685 RVA: 0x0000F1A2 File Offset: 0x0000D3A2
		// (remove) Token: 0x06000E66 RID: 3686 RVA: 0x0000F1A4 File Offset: 0x0000D3A4
		public event AchievementManager.UserAchievementUpdateHandler OnUserAchievementUpdate
		{
			add
			{
			}
			remove
			{
			}
		}

		// Token: 0x06000E67 RID: 3687 RVA: 0x0000F1A6 File Offset: 0x0000D3A6
		internal AchievementManager(IntPtr ptr, IntPtr eventsPtr, ref AchievementManager.FFIEvents events)
		{
		}

		// Token: 0x06000E68 RID: 3688 RVA: 0x0000F1AE File Offset: 0x0000D3AE
		private void InitEvents(IntPtr eventsPtr, ref AchievementManager.FFIEvents events)
		{
		}

		// Token: 0x06000E69 RID: 3689 RVA: 0x0000F1B0 File Offset: 0x0000D3B0
		private static void SetUserAchievementCallbackImpl(IntPtr ptr, Result result)
		{
		}

		// Token: 0x06000E6A RID: 3690 RVA: 0x0000F1B2 File Offset: 0x0000D3B2
		public void SetUserAchievement(long achievementId, byte percentComplete, AchievementManager.SetUserAchievementHandler callback)
		{
		}

		// Token: 0x06000E6B RID: 3691 RVA: 0x0000F1B4 File Offset: 0x0000D3B4
		private static void FetchUserAchievementsCallbackImpl(IntPtr ptr, Result result)
		{
		}

		// Token: 0x06000E6C RID: 3692 RVA: 0x0000F1B6 File Offset: 0x0000D3B6
		public void FetchUserAchievements(AchievementManager.FetchUserAchievementsHandler callback)
		{
		}

		// Token: 0x06000E6D RID: 3693 RVA: 0x0000F1B8 File Offset: 0x0000D3B8
		public int CountUserAchievements()
		{
			return 0;
		}

		// Token: 0x06000E6E RID: 3694 RVA: 0x000109D0 File Offset: 0x0000EBD0
		public UserAchievement GetUserAchievement(long userAchievementId)
		{
			return default(UserAchievement);
		}

		// Token: 0x06000E6F RID: 3695 RVA: 0x000109E8 File Offset: 0x0000EBE8
		public UserAchievement GetUserAchievementAt(int index)
		{
			return default(UserAchievement);
		}

		// Token: 0x06000E70 RID: 3696 RVA: 0x0000F1BB File Offset: 0x0000D3BB
		private static void OnUserAchievementUpdateImpl(IntPtr ptr, ref UserAchievement userAchievement)
		{
		}

		// Token: 0x040005E8 RID: 1512
		private IntPtr MethodsPtr;

		// Token: 0x040005E9 RID: 1513
		private object MethodsStructure;

		// Token: 0x0200022E RID: 558
		internal struct FFIEvents
		{
			// Token: 0x04000818 RID: 2072
			internal AchievementManager.FFIEvents.UserAchievementUpdateHandler OnUserAchievementUpdate;

			// Token: 0x020002FE RID: 766
			// (Invoke) Token: 0x0600146F RID: 5231
			internal delegate void UserAchievementUpdateHandler(IntPtr ptr, ref UserAchievement userAchievement);
		}

		// Token: 0x0200022F RID: 559
		internal struct FFIMethods
		{
			// Token: 0x04000819 RID: 2073
			internal AchievementManager.FFIMethods.SetUserAchievementMethod SetUserAchievement;

			// Token: 0x0400081A RID: 2074
			internal AchievementManager.FFIMethods.FetchUserAchievementsMethod FetchUserAchievements;

			// Token: 0x0400081B RID: 2075
			internal AchievementManager.FFIMethods.CountUserAchievementsMethod CountUserAchievements;

			// Token: 0x0400081C RID: 2076
			internal AchievementManager.FFIMethods.GetUserAchievementMethod GetUserAchievement;

			// Token: 0x0400081D RID: 2077
			internal AchievementManager.FFIMethods.GetUserAchievementAtMethod GetUserAchievementAt;

			// Token: 0x020002FF RID: 767
			// (Invoke) Token: 0x06001473 RID: 5235
			internal delegate void SetUserAchievementCallback(IntPtr ptr, Result result);

			// Token: 0x02000300 RID: 768
			// (Invoke) Token: 0x06001477 RID: 5239
			internal delegate void SetUserAchievementMethod(IntPtr methodsPtr, long achievementId, byte percentComplete, IntPtr callbackData, AchievementManager.FFIMethods.SetUserAchievementCallback callback);

			// Token: 0x02000301 RID: 769
			// (Invoke) Token: 0x0600147B RID: 5243
			internal delegate void FetchUserAchievementsCallback(IntPtr ptr, Result result);

			// Token: 0x02000302 RID: 770
			// (Invoke) Token: 0x0600147F RID: 5247
			internal delegate void FetchUserAchievementsMethod(IntPtr methodsPtr, IntPtr callbackData, AchievementManager.FFIMethods.FetchUserAchievementsCallback callback);

			// Token: 0x02000303 RID: 771
			// (Invoke) Token: 0x06001483 RID: 5251
			internal delegate void CountUserAchievementsMethod(IntPtr methodsPtr, ref int count);

			// Token: 0x02000304 RID: 772
			// (Invoke) Token: 0x06001487 RID: 5255
			internal delegate Result GetUserAchievementMethod(IntPtr methodsPtr, long userAchievementId, ref UserAchievement userAchievement);

			// Token: 0x02000305 RID: 773
			// (Invoke) Token: 0x0600148B RID: 5259
			internal delegate Result GetUserAchievementAtMethod(IntPtr methodsPtr, int index, ref UserAchievement userAchievement);
		}

		// Token: 0x02000230 RID: 560
		// (Invoke) Token: 0x0600114A RID: 4426
		public delegate void SetUserAchievementHandler(Result result);

		// Token: 0x02000231 RID: 561
		// (Invoke) Token: 0x0600114E RID: 4430
		public delegate void FetchUserAchievementsHandler(Result result);

		// Token: 0x02000232 RID: 562
		// (Invoke) Token: 0x06001152 RID: 4434
		public delegate void UserAchievementUpdateHandler(ref UserAchievement userAchievement);
	}
}
