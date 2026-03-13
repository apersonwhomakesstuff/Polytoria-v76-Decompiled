using System;

namespace Discord
{
	// Token: 0x02000156 RID: 342
	public struct LobbyMemberTransaction
	{
		// Token: 0x170001C1 RID: 449
		// (get) Token: 0x06000D64 RID: 3428 RVA: 0x000106D0 File Offset: 0x0000E8D0
		private LobbyMemberTransaction.FFIMethods Methods
		{
			get
			{
				return default(LobbyMemberTransaction.FFIMethods);
			}
		}

		// Token: 0x06000D65 RID: 3429 RVA: 0x0000EF60 File Offset: 0x0000D160
		public void SetMetadata(string key, string value)
		{
		}

		// Token: 0x06000D66 RID: 3430 RVA: 0x0000EF62 File Offset: 0x0000D162
		public void DeleteMetadata(string key)
		{
		}

		// Token: 0x04000594 RID: 1428
		internal IntPtr MethodsPtr;

		// Token: 0x04000595 RID: 1429
		internal object MethodsStructure;

		// Token: 0x020001E5 RID: 485
		internal struct FFIMethods
		{
			// Token: 0x0400076B RID: 1899
			internal LobbyMemberTransaction.FFIMethods.SetMetadataMethod SetMetadata;

			// Token: 0x0400076C RID: 1900
			internal LobbyMemberTransaction.FFIMethods.DeleteMetadataMethod DeleteMetadata;

			// Token: 0x0200024E RID: 590
			// (Invoke) Token: 0x060011AF RID: 4527
			internal delegate Result SetMetadataMethod(IntPtr methodsPtr, string key, string value);

			// Token: 0x0200024F RID: 591
			// (Invoke) Token: 0x060011B3 RID: 4531
			internal delegate Result DeleteMetadataMethod(IntPtr methodsPtr, string key);
		}
	}
}
