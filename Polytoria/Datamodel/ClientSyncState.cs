using System;
using UnityEngine;

namespace Polytoria.Datamodel
{
	// Token: 0x02000277 RID: 631
	public struct ClientSyncState
	{
		// Token: 0x04000A1A RID: 2586
		public float nextSyncTime;

		// Token: 0x04000A1B RID: 2587
		public Vector3 velocity;

		// Token: 0x04000A1C RID: 2588
		public Vector3 angularVelocity;

		// Token: 0x04000A1D RID: 2589
		public bool isKinematic;

		// Token: 0x04000A1E RID: 2590
		public bool useGravity;

		// Token: 0x04000A1F RID: 2591
		public float drag;

		// Token: 0x04000A20 RID: 2592
		public float angularDrag;
	}
}
