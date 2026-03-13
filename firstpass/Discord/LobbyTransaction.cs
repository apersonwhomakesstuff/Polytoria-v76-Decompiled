using System;

namespace Discord
{
	// Token: 0x02000155 RID: 341
	public struct LobbyTransaction
	{
		// Token: 0x170001C0 RID: 448
		// (get) Token: 0x06000D5D RID: 3421 RVA: 0x000106B8 File Offset: 0x0000E8B8
		private LobbyTransaction.FFIMethods Methods
		{
			get
			{
				return default(LobbyTransaction.FFIMethods);
			}
		}

		// Token: 0x06000D5E RID: 3422 RVA: 0x0000EF54 File Offset: 0x0000D154
		public void SetType(LobbyType type)
		{
		}

		// Token: 0x06000D5F RID: 3423 RVA: 0x0000EF56 File Offset: 0x0000D156
		public void SetOwner(long ownerId)
		{
		}

		// Token: 0x06000D60 RID: 3424 RVA: 0x0000EF58 File Offset: 0x0000D158
		public void SetCapacity(uint capacity)
		{
		}

		// Token: 0x06000D61 RID: 3425 RVA: 0x0000EF5A File Offset: 0x0000D15A
		public void SetMetadata(string key, string value)
		{
		}

		// Token: 0x06000D62 RID: 3426 RVA: 0x0000EF5C File Offset: 0x0000D15C
		public void DeleteMetadata(string key)
		{
		}

		// Token: 0x06000D63 RID: 3427 RVA: 0x0000EF5E File Offset: 0x0000D15E
		public void SetLocked(bool locked)
		{
		}

		// Token: 0x04000592 RID: 1426
		internal IntPtr MethodsPtr;

		// Token: 0x04000593 RID: 1427
		internal object MethodsStructure;

		// Token: 0x020001E4 RID: 484
		internal struct FFIMethods
		{
			// Token: 0x04000765 RID: 1893
			internal LobbyTransaction.FFIMethods.SetTypeMethod SetType;

			// Token: 0x04000766 RID: 1894
			internal LobbyTransaction.FFIMethods.SetOwnerMethod SetOwner;

			// Token: 0x04000767 RID: 1895
			internal LobbyTransaction.FFIMethods.SetCapacityMethod SetCapacity;

			// Token: 0x04000768 RID: 1896
			internal LobbyTransaction.FFIMethods.SetMetadataMethod SetMetadata;

			// Token: 0x04000769 RID: 1897
			internal LobbyTransaction.FFIMethods.DeleteMetadataMethod DeleteMetadata;

			// Token: 0x0400076A RID: 1898
			internal LobbyTransaction.FFIMethods.SetLockedMethod SetLocked;

			// Token: 0x02000248 RID: 584
			// (Invoke) Token: 0x06001197 RID: 4503
			internal delegate Result SetTypeMethod(IntPtr methodsPtr, LobbyType type);

			// Token: 0x02000249 RID: 585
			// (Invoke) Token: 0x0600119B RID: 4507
			internal delegate Result SetOwnerMethod(IntPtr methodsPtr, long ownerId);

			// Token: 0x0200024A RID: 586
			// (Invoke) Token: 0x0600119F RID: 4511
			internal delegate Result SetCapacityMethod(IntPtr methodsPtr, uint capacity);

			// Token: 0x0200024B RID: 587
			// (Invoke) Token: 0x060011A3 RID: 4515
			internal delegate Result SetMetadataMethod(IntPtr methodsPtr, string key, string value);

			// Token: 0x0200024C RID: 588
			// (Invoke) Token: 0x060011A7 RID: 4519
			internal delegate Result DeleteMetadataMethod(IntPtr methodsPtr, string key);

			// Token: 0x0200024D RID: 589
			// (Invoke) Token: 0x060011AB RID: 4523
			internal delegate Result SetLockedMethod(IntPtr methodsPtr, bool locked);
		}
	}
}
