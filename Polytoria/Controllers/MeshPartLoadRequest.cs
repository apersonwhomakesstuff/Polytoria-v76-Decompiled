using System;
using Polytoria.Datamodel;

namespace Polytoria.Controllers
{
	// Token: 0x02000333 RID: 819
	public struct MeshPartLoadRequest
	{
		// Token: 0x0600288F RID: 10383 RVA: 0x0001CC65 File Offset: 0x0001AE65
		public MeshPartLoadRequest(int assetID, MeshPart meshPart, Action onLoadComplete = null)
		{
			this.assetID = 0;
			this.meshPart = null;
			this.onComplete = null;
		}

		// Token: 0x04000DD8 RID: 3544
		public int assetID;

		// Token: 0x04000DD9 RID: 3545
		public MeshPart meshPart;

		// Token: 0x04000DDA RID: 3546
		public Action onComplete;
	}
}
