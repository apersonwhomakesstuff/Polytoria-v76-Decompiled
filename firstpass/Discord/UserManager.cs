using System;

namespace Discord
{
	// Token: 0x0200015C RID: 348
	public class UserManager
	{
		// Token: 0x170001C5 RID: 453
		// (get) Token: 0x06000D8D RID: 3469 RVA: 0x00010730 File Offset: 0x0000E930
		private UserManager.FFIMethods Methods
		{
			get
			{
				return default(UserManager.FFIMethods);
			}
		}

		// Token: 0x14000005 RID: 5
		// (add) Token: 0x06000D8E RID: 3470 RVA: 0x0000EFCE File Offset: 0x0000D1CE
		// (remove) Token: 0x06000D8F RID: 3471 RVA: 0x0000EFD0 File Offset: 0x0000D1D0
		public event UserManager.CurrentUserUpdateHandler OnCurrentUserUpdate
		{
			add
			{
			}
			remove
			{
			}
		}

		// Token: 0x06000D90 RID: 3472 RVA: 0x0000EFD2 File Offset: 0x0000D1D2
		internal UserManager(IntPtr ptr, IntPtr eventsPtr, ref UserManager.FFIEvents events)
		{
		}

		// Token: 0x06000D91 RID: 3473 RVA: 0x0000EFDA File Offset: 0x0000D1DA
		private void InitEvents(IntPtr eventsPtr, ref UserManager.FFIEvents events)
		{
		}

		// Token: 0x06000D92 RID: 3474 RVA: 0x00010748 File Offset: 0x0000E948
		public User GetCurrentUser()
		{
			return default(User);
		}

		// Token: 0x06000D93 RID: 3475 RVA: 0x0000EFDC File Offset: 0x0000D1DC
		private static void GetUserCallbackImpl(IntPtr ptr, Result result, ref User user)
		{
		}

		// Token: 0x06000D94 RID: 3476 RVA: 0x0000EFDE File Offset: 0x0000D1DE
		public void GetUser(long userId, UserManager.GetUserHandler callback)
		{
		}

		// Token: 0x06000D95 RID: 3477 RVA: 0x00010760 File Offset: 0x0000E960
		public PremiumType GetCurrentUserPremiumType()
		{
			return PremiumType.None;
		}

		// Token: 0x06000D96 RID: 3478 RVA: 0x0000EFE0 File Offset: 0x0000D1E0
		public bool CurrentUserHasFlag(UserFlag flag)
		{
			return false;
		}

		// Token: 0x06000D97 RID: 3479 RVA: 0x0000EFE3 File Offset: 0x0000D1E3
		private static void OnCurrentUserUpdateImpl(IntPtr ptr)
		{
		}

		// Token: 0x040005C5 RID: 1477
		private IntPtr MethodsPtr;

		// Token: 0x040005C6 RID: 1478
		private object MethodsStructure;

		// Token: 0x020001F0 RID: 496
		internal struct FFIEvents
		{
			// Token: 0x040007A1 RID: 1953
			internal UserManager.FFIEvents.CurrentUserUpdateHandler OnCurrentUserUpdate;

			// Token: 0x0200026C RID: 620
			// (Invoke) Token: 0x06001227 RID: 4647
			internal delegate void CurrentUserUpdateHandler(IntPtr ptr);
		}

		// Token: 0x020001F1 RID: 497
		internal struct FFIMethods
		{
			// Token: 0x040007A2 RID: 1954
			internal UserManager.FFIMethods.GetCurrentUserMethod GetCurrentUser;

			// Token: 0x040007A3 RID: 1955
			internal UserManager.FFIMethods.GetUserMethod GetUser;

			// Token: 0x040007A4 RID: 1956
			internal UserManager.FFIMethods.GetCurrentUserPremiumTypeMethod GetCurrentUserPremiumType;

			// Token: 0x040007A5 RID: 1957
			internal UserManager.FFIMethods.CurrentUserHasFlagMethod CurrentUserHasFlag;

			// Token: 0x0200026D RID: 621
			// (Invoke) Token: 0x0600122B RID: 4651
			internal delegate Result GetCurrentUserMethod(IntPtr methodsPtr, ref User currentUser);

			// Token: 0x0200026E RID: 622
			// (Invoke) Token: 0x0600122F RID: 4655
			internal delegate void GetUserCallback(IntPtr ptr, Result result, ref User user);

			// Token: 0x0200026F RID: 623
			// (Invoke) Token: 0x06001233 RID: 4659
			internal delegate void GetUserMethod(IntPtr methodsPtr, long userId, IntPtr callbackData, UserManager.FFIMethods.GetUserCallback callback);

			// Token: 0x02000270 RID: 624
			// (Invoke) Token: 0x06001237 RID: 4663
			internal delegate Result GetCurrentUserPremiumTypeMethod(IntPtr methodsPtr, ref PremiumType premiumType);

			// Token: 0x02000271 RID: 625
			// (Invoke) Token: 0x0600123B RID: 4667
			internal delegate Result CurrentUserHasFlagMethod(IntPtr methodsPtr, UserFlag flag, ref bool hasFlag);
		}

		// Token: 0x020001F2 RID: 498
		// (Invoke) Token: 0x0600109A RID: 4250
		public delegate void GetUserHandler(Result result, ref User user);

		// Token: 0x020001F3 RID: 499
		// (Invoke) Token: 0x0600109E RID: 4254
		public delegate void CurrentUserUpdateHandler();
	}
}
