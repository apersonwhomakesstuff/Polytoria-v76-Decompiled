using System;
using System.Text;

namespace Discord
{
	// Token: 0x0200015B RID: 347
	public class ApplicationManager
	{
		// Token: 0x170001C4 RID: 452
		// (get) Token: 0x06000D82 RID: 3458 RVA: 0x00010718 File Offset: 0x0000E918
		private ApplicationManager.FFIMethods Methods
		{
			get
			{
				return default(ApplicationManager.FFIMethods);
			}
		}

		// Token: 0x06000D83 RID: 3459 RVA: 0x0000EFB2 File Offset: 0x0000D1B2
		internal ApplicationManager(IntPtr ptr, IntPtr eventsPtr, ref ApplicationManager.FFIEvents events)
		{
		}

		// Token: 0x06000D84 RID: 3460 RVA: 0x0000EFBA File Offset: 0x0000D1BA
		private void InitEvents(IntPtr eventsPtr, ref ApplicationManager.FFIEvents events)
		{
		}

		// Token: 0x06000D85 RID: 3461 RVA: 0x0000EFBC File Offset: 0x0000D1BC
		private static void ValidateOrExitCallbackImpl(IntPtr ptr, Result result)
		{
		}

		// Token: 0x06000D86 RID: 3462 RVA: 0x0000EFBE File Offset: 0x0000D1BE
		public void ValidateOrExit(ApplicationManager.ValidateOrExitHandler callback)
		{
		}

		// Token: 0x06000D87 RID: 3463 RVA: 0x0000EFC0 File Offset: 0x0000D1C0
		public string GetCurrentLocale()
		{
			return null;
		}

		// Token: 0x06000D88 RID: 3464 RVA: 0x0000EFC3 File Offset: 0x0000D1C3
		public string GetCurrentBranch()
		{
			return null;
		}

		// Token: 0x06000D89 RID: 3465 RVA: 0x0000EFC6 File Offset: 0x0000D1C6
		private static void GetOAuth2TokenCallbackImpl(IntPtr ptr, Result result, ref OAuth2Token oauth2Token)
		{
		}

		// Token: 0x06000D8A RID: 3466 RVA: 0x0000EFC8 File Offset: 0x0000D1C8
		public void GetOAuth2Token(ApplicationManager.GetOAuth2TokenHandler callback)
		{
		}

		// Token: 0x06000D8B RID: 3467 RVA: 0x0000EFCA File Offset: 0x0000D1CA
		private static void GetTicketCallbackImpl(IntPtr ptr, Result result, ref string data)
		{
		}

		// Token: 0x06000D8C RID: 3468 RVA: 0x0000EFCC File Offset: 0x0000D1CC
		public void GetTicket(ApplicationManager.GetTicketHandler callback)
		{
		}

		// Token: 0x040005C3 RID: 1475
		private IntPtr MethodsPtr;

		// Token: 0x040005C4 RID: 1476
		private object MethodsStructure;

		// Token: 0x020001EB RID: 491
		internal struct FFIEvents
		{
		}

		// Token: 0x020001EC RID: 492
		internal struct FFIMethods
		{
			// Token: 0x0400079C RID: 1948
			internal ApplicationManager.FFIMethods.ValidateOrExitMethod ValidateOrExit;

			// Token: 0x0400079D RID: 1949
			internal ApplicationManager.FFIMethods.GetCurrentLocaleMethod GetCurrentLocale;

			// Token: 0x0400079E RID: 1950
			internal ApplicationManager.FFIMethods.GetCurrentBranchMethod GetCurrentBranch;

			// Token: 0x0400079F RID: 1951
			internal ApplicationManager.FFIMethods.GetOAuth2TokenMethod GetOAuth2Token;

			// Token: 0x040007A0 RID: 1952
			internal ApplicationManager.FFIMethods.GetTicketMethod GetTicket;

			// Token: 0x02000264 RID: 612
			// (Invoke) Token: 0x06001207 RID: 4615
			internal delegate void ValidateOrExitCallback(IntPtr ptr, Result result);

			// Token: 0x02000265 RID: 613
			// (Invoke) Token: 0x0600120B RID: 4619
			internal delegate void ValidateOrExitMethod(IntPtr methodsPtr, IntPtr callbackData, ApplicationManager.FFIMethods.ValidateOrExitCallback callback);

			// Token: 0x02000266 RID: 614
			// (Invoke) Token: 0x0600120F RID: 4623
			internal delegate void GetCurrentLocaleMethod(IntPtr methodsPtr, StringBuilder locale);

			// Token: 0x02000267 RID: 615
			// (Invoke) Token: 0x06001213 RID: 4627
			internal delegate void GetCurrentBranchMethod(IntPtr methodsPtr, StringBuilder branch);

			// Token: 0x02000268 RID: 616
			// (Invoke) Token: 0x06001217 RID: 4631
			internal delegate void GetOAuth2TokenCallback(IntPtr ptr, Result result, ref OAuth2Token oauth2Token);

			// Token: 0x02000269 RID: 617
			// (Invoke) Token: 0x0600121B RID: 4635
			internal delegate void GetOAuth2TokenMethod(IntPtr methodsPtr, IntPtr callbackData, ApplicationManager.FFIMethods.GetOAuth2TokenCallback callback);

			// Token: 0x0200026A RID: 618
			// (Invoke) Token: 0x0600121F RID: 4639
			internal delegate void GetTicketCallback(IntPtr ptr, Result result, ref string data);

			// Token: 0x0200026B RID: 619
			// (Invoke) Token: 0x06001223 RID: 4643
			internal delegate void GetTicketMethod(IntPtr methodsPtr, IntPtr callbackData, ApplicationManager.FFIMethods.GetTicketCallback callback);
		}

		// Token: 0x020001ED RID: 493
		// (Invoke) Token: 0x0600108E RID: 4238
		public delegate void ValidateOrExitHandler(Result result);

		// Token: 0x020001EE RID: 494
		// (Invoke) Token: 0x06001092 RID: 4242
		public delegate void GetOAuth2TokenHandler(Result result, ref OAuth2Token oauth2Token);

		// Token: 0x020001EF RID: 495
		// (Invoke) Token: 0x06001096 RID: 4246
		public delegate void GetTicketHandler(Result result, ref string data);
	}
}
