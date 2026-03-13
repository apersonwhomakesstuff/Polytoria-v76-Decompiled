using System;

namespace Discord
{
	// Token: 0x0200014C RID: 332
	public struct Lobby
	{
		// Token: 0x04000571 RID: 1393
		public long Id;

		// Token: 0x04000572 RID: 1394
		public LobbyType Type;

		// Token: 0x04000573 RID: 1395
		public long OwnerId;

		// Token: 0x04000574 RID: 1396
		public string Secret;

		// Token: 0x04000575 RID: 1397
		public uint Capacity;

		// Token: 0x04000576 RID: 1398
		public bool Locked;
	}
}
