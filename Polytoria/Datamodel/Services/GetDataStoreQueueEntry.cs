using System;

namespace Polytoria.Datamodel.Services
{
	// Token: 0x020002C6 RID: 710
	public class GetDataStoreQueueEntry
	{
		// Token: 0x060023D8 RID: 9176 RVA: 0x0001BE45 File Offset: 0x0001A045
		public GetDataStoreQueueEntry(Datastore datastore, Action<bool> callback)
		{
		}

		// Token: 0x04000CDF RID: 3295
		public Datastore datastore;

		// Token: 0x04000CE0 RID: 3296
		public Action<bool> callback;
	}
}
