using System;

namespace Discord
{
	// Token: 0x0200015E RID: 350
	public class RelationshipManager
	{
		// Token: 0x170001C7 RID: 455
		// (get) Token: 0x06000DA2 RID: 3490 RVA: 0x000107A8 File Offset: 0x0000E9A8
		private RelationshipManager.FFIMethods Methods
		{
			get
			{
				return default(RelationshipManager.FFIMethods);
			}
		}

		// Token: 0x14000006 RID: 6
		// (add) Token: 0x06000DA3 RID: 3491 RVA: 0x0000EFFD File Offset: 0x0000D1FD
		// (remove) Token: 0x06000DA4 RID: 3492 RVA: 0x0000EFFF File Offset: 0x0000D1FF
		public event RelationshipManager.RefreshHandler OnRefresh
		{
			add
			{
			}
			remove
			{
			}
		}

		// Token: 0x14000007 RID: 7
		// (add) Token: 0x06000DA5 RID: 3493 RVA: 0x0000F001 File Offset: 0x0000D201
		// (remove) Token: 0x06000DA6 RID: 3494 RVA: 0x0000F003 File Offset: 0x0000D203
		public event RelationshipManager.RelationshipUpdateHandler OnRelationshipUpdate
		{
			add
			{
			}
			remove
			{
			}
		}

		// Token: 0x06000DA7 RID: 3495 RVA: 0x0000F005 File Offset: 0x0000D205
		internal RelationshipManager(IntPtr ptr, IntPtr eventsPtr, ref RelationshipManager.FFIEvents events)
		{
		}

		// Token: 0x06000DA8 RID: 3496 RVA: 0x0000F00D File Offset: 0x0000D20D
		private void InitEvents(IntPtr eventsPtr, ref RelationshipManager.FFIEvents events)
		{
		}

		// Token: 0x06000DA9 RID: 3497 RVA: 0x0000F00F File Offset: 0x0000D20F
		private static bool FilterCallbackImpl(IntPtr ptr, ref Relationship relationship)
		{
			return false;
		}

		// Token: 0x06000DAA RID: 3498 RVA: 0x0000F012 File Offset: 0x0000D212
		public void Filter(RelationshipManager.FilterHandler callback)
		{
		}

		// Token: 0x06000DAB RID: 3499 RVA: 0x0000F014 File Offset: 0x0000D214
		public int Count()
		{
			return 0;
		}

		// Token: 0x06000DAC RID: 3500 RVA: 0x000107C0 File Offset: 0x0000E9C0
		public Relationship Get(long userId)
		{
			return default(Relationship);
		}

		// Token: 0x06000DAD RID: 3501 RVA: 0x000107D8 File Offset: 0x0000E9D8
		public Relationship GetAt(uint index)
		{
			return default(Relationship);
		}

		// Token: 0x06000DAE RID: 3502 RVA: 0x0000F017 File Offset: 0x0000D217
		private static void OnRefreshImpl(IntPtr ptr)
		{
		}

		// Token: 0x06000DAF RID: 3503 RVA: 0x0000F019 File Offset: 0x0000D219
		private static void OnRelationshipUpdateImpl(IntPtr ptr, ref Relationship relationship)
		{
		}

		// Token: 0x040005CA RID: 1482
		private IntPtr MethodsPtr;

		// Token: 0x040005CB RID: 1483
		private object MethodsStructure;

		// Token: 0x020001F7 RID: 503
		internal struct FFIEvents
		{
			// Token: 0x040007A9 RID: 1961
			internal RelationshipManager.FFIEvents.RefreshHandler OnRefresh;

			// Token: 0x040007AA RID: 1962
			internal RelationshipManager.FFIEvents.RelationshipUpdateHandler OnRelationshipUpdate;

			// Token: 0x02000276 RID: 630
			// (Invoke) Token: 0x0600124F RID: 4687
			internal delegate void RefreshHandler(IntPtr ptr);

			// Token: 0x02000277 RID: 631
			// (Invoke) Token: 0x06001253 RID: 4691
			internal delegate void RelationshipUpdateHandler(IntPtr ptr, ref Relationship relationship);
		}

		// Token: 0x020001F8 RID: 504
		internal struct FFIMethods
		{
			// Token: 0x040007AB RID: 1963
			internal RelationshipManager.FFIMethods.FilterMethod Filter;

			// Token: 0x040007AC RID: 1964
			internal RelationshipManager.FFIMethods.CountMethod Count;

			// Token: 0x040007AD RID: 1965
			internal RelationshipManager.FFIMethods.GetMethod Get;

			// Token: 0x040007AE RID: 1966
			internal RelationshipManager.FFIMethods.GetAtMethod GetAt;

			// Token: 0x02000278 RID: 632
			// (Invoke) Token: 0x06001257 RID: 4695
			internal delegate bool FilterCallback(IntPtr ptr, ref Relationship relationship);

			// Token: 0x02000279 RID: 633
			// (Invoke) Token: 0x0600125B RID: 4699
			internal delegate void FilterMethod(IntPtr methodsPtr, IntPtr callbackData, RelationshipManager.FFIMethods.FilterCallback callback);

			// Token: 0x0200027A RID: 634
			// (Invoke) Token: 0x0600125F RID: 4703
			internal delegate Result CountMethod(IntPtr methodsPtr, ref int count);

			// Token: 0x0200027B RID: 635
			// (Invoke) Token: 0x06001263 RID: 4707
			internal delegate Result GetMethod(IntPtr methodsPtr, long userId, ref Relationship relationship);

			// Token: 0x0200027C RID: 636
			// (Invoke) Token: 0x06001267 RID: 4711
			internal delegate Result GetAtMethod(IntPtr methodsPtr, uint index, ref Relationship relationship);
		}

		// Token: 0x020001F9 RID: 505
		// (Invoke) Token: 0x060010A6 RID: 4262
		public delegate bool FilterHandler(ref Relationship relationship);

		// Token: 0x020001FA RID: 506
		// (Invoke) Token: 0x060010AA RID: 4266
		public delegate void RefreshHandler();

		// Token: 0x020001FB RID: 507
		// (Invoke) Token: 0x060010AE RID: 4270
		public delegate void RelationshipUpdateHandler(ref Relationship relationship);
	}
}
