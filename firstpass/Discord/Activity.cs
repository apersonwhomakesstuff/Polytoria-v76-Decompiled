using System;

namespace Discord
{
	// Token: 0x02000149 RID: 329
	public struct Activity
	{
		// Token: 0x04000562 RID: 1378
		public ActivityType Type;

		// Token: 0x04000563 RID: 1379
		public long ApplicationId;

		// Token: 0x04000564 RID: 1380
		public string Name;

		// Token: 0x04000565 RID: 1381
		public string State;

		// Token: 0x04000566 RID: 1382
		public string Details;

		// Token: 0x04000567 RID: 1383
		public ActivityTimestamps Timestamps;

		// Token: 0x04000568 RID: 1384
		public ActivityAssets Assets;

		// Token: 0x04000569 RID: 1385
		public ActivityParty Party;

		// Token: 0x0400056A RID: 1386
		public ActivitySecrets Secrets;

		// Token: 0x0400056B RID: 1387
		public bool Instance;
	}
}
