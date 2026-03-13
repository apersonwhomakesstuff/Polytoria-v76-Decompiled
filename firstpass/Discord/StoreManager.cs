using System;
using System.Collections.Generic;

namespace Discord
{
	// Token: 0x02000163 RID: 355
	public class StoreManager
	{
		// Token: 0x170001CC RID: 460
		// (get) Token: 0x06000E3B RID: 3643 RVA: 0x00010910 File Offset: 0x0000EB10
		private StoreManager.FFIMethods Methods
		{
			get
			{
				return default(StoreManager.FFIMethods);
			}
		}

		// Token: 0x14000013 RID: 19
		// (add) Token: 0x06000E3C RID: 3644 RVA: 0x0000F149 File Offset: 0x0000D349
		// (remove) Token: 0x06000E3D RID: 3645 RVA: 0x0000F14B File Offset: 0x0000D34B
		public event StoreManager.EntitlementCreateHandler OnEntitlementCreate
		{
			add
			{
			}
			remove
			{
			}
		}

		// Token: 0x14000014 RID: 20
		// (add) Token: 0x06000E3E RID: 3646 RVA: 0x0000F14D File Offset: 0x0000D34D
		// (remove) Token: 0x06000E3F RID: 3647 RVA: 0x0000F14F File Offset: 0x0000D34F
		public event StoreManager.EntitlementDeleteHandler OnEntitlementDelete
		{
			add
			{
			}
			remove
			{
			}
		}

		// Token: 0x06000E40 RID: 3648 RVA: 0x0000F151 File Offset: 0x0000D351
		internal StoreManager(IntPtr ptr, IntPtr eventsPtr, ref StoreManager.FFIEvents events)
		{
		}

		// Token: 0x06000E41 RID: 3649 RVA: 0x0000F159 File Offset: 0x0000D359
		private void InitEvents(IntPtr eventsPtr, ref StoreManager.FFIEvents events)
		{
		}

		// Token: 0x06000E42 RID: 3650 RVA: 0x0000F15B File Offset: 0x0000D35B
		private static void FetchSkusCallbackImpl(IntPtr ptr, Result result)
		{
		}

		// Token: 0x06000E43 RID: 3651 RVA: 0x0000F15D File Offset: 0x0000D35D
		public void FetchSkus(StoreManager.FetchSkusHandler callback)
		{
		}

		// Token: 0x06000E44 RID: 3652 RVA: 0x0000F15F File Offset: 0x0000D35F
		public int CountSkus()
		{
			return 0;
		}

		// Token: 0x06000E45 RID: 3653 RVA: 0x00010928 File Offset: 0x0000EB28
		public Sku GetSku(long skuId)
		{
			return default(Sku);
		}

		// Token: 0x06000E46 RID: 3654 RVA: 0x00010940 File Offset: 0x0000EB40
		public Sku GetSkuAt(int index)
		{
			return default(Sku);
		}

		// Token: 0x06000E47 RID: 3655 RVA: 0x0000F162 File Offset: 0x0000D362
		private static void FetchEntitlementsCallbackImpl(IntPtr ptr, Result result)
		{
		}

		// Token: 0x06000E48 RID: 3656 RVA: 0x0000F164 File Offset: 0x0000D364
		public void FetchEntitlements(StoreManager.FetchEntitlementsHandler callback)
		{
		}

		// Token: 0x06000E49 RID: 3657 RVA: 0x0000F166 File Offset: 0x0000D366
		public int CountEntitlements()
		{
			return 0;
		}

		// Token: 0x06000E4A RID: 3658 RVA: 0x00010958 File Offset: 0x0000EB58
		public Entitlement GetEntitlement(long entitlementId)
		{
			return default(Entitlement);
		}

		// Token: 0x06000E4B RID: 3659 RVA: 0x00010970 File Offset: 0x0000EB70
		public Entitlement GetEntitlementAt(int index)
		{
			return default(Entitlement);
		}

		// Token: 0x06000E4C RID: 3660 RVA: 0x0000F169 File Offset: 0x0000D369
		public bool HasSkuEntitlement(long skuId)
		{
			return false;
		}

		// Token: 0x06000E4D RID: 3661 RVA: 0x0000F16C File Offset: 0x0000D36C
		private static void StartPurchaseCallbackImpl(IntPtr ptr, Result result)
		{
		}

		// Token: 0x06000E4E RID: 3662 RVA: 0x0000F16E File Offset: 0x0000D36E
		public void StartPurchase(long skuId, StoreManager.StartPurchaseHandler callback)
		{
		}

		// Token: 0x06000E4F RID: 3663 RVA: 0x0000F170 File Offset: 0x0000D370
		private static void OnEntitlementCreateImpl(IntPtr ptr, ref Entitlement entitlement)
		{
		}

		// Token: 0x06000E50 RID: 3664 RVA: 0x0000F172 File Offset: 0x0000D372
		private static void OnEntitlementDeleteImpl(IntPtr ptr, ref Entitlement entitlement)
		{
		}

		// Token: 0x06000E51 RID: 3665 RVA: 0x0000F174 File Offset: 0x0000D374
		public IEnumerable<Entitlement> GetEntitlements()
		{
			return null;
		}

		// Token: 0x06000E52 RID: 3666 RVA: 0x0000F177 File Offset: 0x0000D377
		public IEnumerable<Sku> GetSkus()
		{
			return null;
		}

		// Token: 0x040005E1 RID: 1505
		private IntPtr MethodsPtr;

		// Token: 0x040005E2 RID: 1506
		private object MethodsStructure;

		// Token: 0x02000223 RID: 547
		internal struct FFIEvents
		{
			// Token: 0x04000801 RID: 2049
			internal StoreManager.FFIEvents.EntitlementCreateHandler OnEntitlementCreate;

			// Token: 0x04000802 RID: 2050
			internal StoreManager.FFIEvents.EntitlementDeleteHandler OnEntitlementDelete;

			// Token: 0x020002E3 RID: 739
			// (Invoke) Token: 0x06001403 RID: 5123
			internal delegate void EntitlementCreateHandler(IntPtr ptr, ref Entitlement entitlement);

			// Token: 0x020002E4 RID: 740
			// (Invoke) Token: 0x06001407 RID: 5127
			internal delegate void EntitlementDeleteHandler(IntPtr ptr, ref Entitlement entitlement);
		}

		// Token: 0x02000224 RID: 548
		internal struct FFIMethods
		{
			// Token: 0x04000803 RID: 2051
			internal StoreManager.FFIMethods.FetchSkusMethod FetchSkus;

			// Token: 0x04000804 RID: 2052
			internal StoreManager.FFIMethods.CountSkusMethod CountSkus;

			// Token: 0x04000805 RID: 2053
			internal StoreManager.FFIMethods.GetSkuMethod GetSku;

			// Token: 0x04000806 RID: 2054
			internal StoreManager.FFIMethods.GetSkuAtMethod GetSkuAt;

			// Token: 0x04000807 RID: 2055
			internal StoreManager.FFIMethods.FetchEntitlementsMethod FetchEntitlements;

			// Token: 0x04000808 RID: 2056
			internal StoreManager.FFIMethods.CountEntitlementsMethod CountEntitlements;

			// Token: 0x04000809 RID: 2057
			internal StoreManager.FFIMethods.GetEntitlementMethod GetEntitlement;

			// Token: 0x0400080A RID: 2058
			internal StoreManager.FFIMethods.GetEntitlementAtMethod GetEntitlementAt;

			// Token: 0x0400080B RID: 2059
			internal StoreManager.FFIMethods.HasSkuEntitlementMethod HasSkuEntitlement;

			// Token: 0x0400080C RID: 2060
			internal StoreManager.FFIMethods.StartPurchaseMethod StartPurchase;

			// Token: 0x020002E5 RID: 741
			// (Invoke) Token: 0x0600140B RID: 5131
			internal delegate void FetchSkusCallback(IntPtr ptr, Result result);

			// Token: 0x020002E6 RID: 742
			// (Invoke) Token: 0x0600140F RID: 5135
			internal delegate void FetchSkusMethod(IntPtr methodsPtr, IntPtr callbackData, StoreManager.FFIMethods.FetchSkusCallback callback);

			// Token: 0x020002E7 RID: 743
			// (Invoke) Token: 0x06001413 RID: 5139
			internal delegate void CountSkusMethod(IntPtr methodsPtr, ref int count);

			// Token: 0x020002E8 RID: 744
			// (Invoke) Token: 0x06001417 RID: 5143
			internal delegate Result GetSkuMethod(IntPtr methodsPtr, long skuId, ref Sku sku);

			// Token: 0x020002E9 RID: 745
			// (Invoke) Token: 0x0600141B RID: 5147
			internal delegate Result GetSkuAtMethod(IntPtr methodsPtr, int index, ref Sku sku);

			// Token: 0x020002EA RID: 746
			// (Invoke) Token: 0x0600141F RID: 5151
			internal delegate void FetchEntitlementsCallback(IntPtr ptr, Result result);

			// Token: 0x020002EB RID: 747
			// (Invoke) Token: 0x06001423 RID: 5155
			internal delegate void FetchEntitlementsMethod(IntPtr methodsPtr, IntPtr callbackData, StoreManager.FFIMethods.FetchEntitlementsCallback callback);

			// Token: 0x020002EC RID: 748
			// (Invoke) Token: 0x06001427 RID: 5159
			internal delegate void CountEntitlementsMethod(IntPtr methodsPtr, ref int count);

			// Token: 0x020002ED RID: 749
			// (Invoke) Token: 0x0600142B RID: 5163
			internal delegate Result GetEntitlementMethod(IntPtr methodsPtr, long entitlementId, ref Entitlement entitlement);

			// Token: 0x020002EE RID: 750
			// (Invoke) Token: 0x0600142F RID: 5167
			internal delegate Result GetEntitlementAtMethod(IntPtr methodsPtr, int index, ref Entitlement entitlement);

			// Token: 0x020002EF RID: 751
			// (Invoke) Token: 0x06001433 RID: 5171
			internal delegate Result HasSkuEntitlementMethod(IntPtr methodsPtr, long skuId, ref bool hasEntitlement);

			// Token: 0x020002F0 RID: 752
			// (Invoke) Token: 0x06001437 RID: 5175
			internal delegate void StartPurchaseCallback(IntPtr ptr, Result result);

			// Token: 0x020002F1 RID: 753
			// (Invoke) Token: 0x0600143B RID: 5179
			internal delegate void StartPurchaseMethod(IntPtr methodsPtr, long skuId, IntPtr callbackData, StoreManager.FFIMethods.StartPurchaseCallback callback);
		}

		// Token: 0x02000225 RID: 549
		// (Invoke) Token: 0x0600112E RID: 4398
		public delegate void FetchSkusHandler(Result result);

		// Token: 0x02000226 RID: 550
		// (Invoke) Token: 0x06001132 RID: 4402
		public delegate void FetchEntitlementsHandler(Result result);

		// Token: 0x02000227 RID: 551
		// (Invoke) Token: 0x06001136 RID: 4406
		public delegate void StartPurchaseHandler(Result result);

		// Token: 0x02000228 RID: 552
		// (Invoke) Token: 0x0600113A RID: 4410
		public delegate void EntitlementCreateHandler(ref Entitlement entitlement);

		// Token: 0x02000229 RID: 553
		// (Invoke) Token: 0x0600113E RID: 4414
		public delegate void EntitlementDeleteHandler(ref Entitlement entitlement);
	}
}
