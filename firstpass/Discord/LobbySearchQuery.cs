using System;

namespace Discord
{
	// Token: 0x02000157 RID: 343
	public struct LobbySearchQuery
	{
		// Token: 0x170001C2 RID: 450
		// (get) Token: 0x06000D67 RID: 3431 RVA: 0x000106E8 File Offset: 0x0000E8E8
		private LobbySearchQuery.FFIMethods Methods
		{
			get
			{
				return default(LobbySearchQuery.FFIMethods);
			}
		}

		// Token: 0x06000D68 RID: 3432 RVA: 0x0000EF64 File Offset: 0x0000D164
		public void Filter(string key, LobbySearchComparison comparison, LobbySearchCast cast, string value)
		{
		}

		// Token: 0x06000D69 RID: 3433 RVA: 0x0000EF66 File Offset: 0x0000D166
		public void Sort(string key, LobbySearchCast cast, string value)
		{
		}

		// Token: 0x06000D6A RID: 3434 RVA: 0x0000EF68 File Offset: 0x0000D168
		public void Limit(uint limit)
		{
		}

		// Token: 0x06000D6B RID: 3435 RVA: 0x0000EF6A File Offset: 0x0000D16A
		public void Distance(LobbySearchDistance distance)
		{
		}

		// Token: 0x04000596 RID: 1430
		internal IntPtr MethodsPtr;

		// Token: 0x04000597 RID: 1431
		internal object MethodsStructure;

		// Token: 0x020001E6 RID: 486
		internal struct FFIMethods
		{
			// Token: 0x0400076D RID: 1901
			internal LobbySearchQuery.FFIMethods.FilterMethod Filter;

			// Token: 0x0400076E RID: 1902
			internal LobbySearchQuery.FFIMethods.SortMethod Sort;

			// Token: 0x0400076F RID: 1903
			internal LobbySearchQuery.FFIMethods.LimitMethod Limit;

			// Token: 0x04000770 RID: 1904
			internal LobbySearchQuery.FFIMethods.DistanceMethod Distance;

			// Token: 0x02000250 RID: 592
			// (Invoke) Token: 0x060011B7 RID: 4535
			internal delegate Result FilterMethod(IntPtr methodsPtr, string key, LobbySearchComparison comparison, LobbySearchCast cast, string value);

			// Token: 0x02000251 RID: 593
			// (Invoke) Token: 0x060011BB RID: 4539
			internal delegate Result SortMethod(IntPtr methodsPtr, string key, LobbySearchCast cast, string value);

			// Token: 0x02000252 RID: 594
			// (Invoke) Token: 0x060011BF RID: 4543
			internal delegate Result LimitMethod(IntPtr methodsPtr, uint limit);

			// Token: 0x02000253 RID: 595
			// (Invoke) Token: 0x060011C3 RID: 4547
			internal delegate Result DistanceMethod(IntPtr methodsPtr, LobbySearchDistance distance);
		}
	}
}
