using System;
using System.Collections.Generic;

namespace RLD
{
	// Token: 0x0200005C RID: 92
	public class GizmoCollectionEnabledStateSnapshot
	{
		// Token: 0x06000351 RID: 849 RVA: 0x00016565 File Offset: 0x00014765
		public void Snapshot(IEnumerable<Gizmo> gizmos)
		{
		}

		// Token: 0x06000352 RID: 850 RVA: 0x00016567 File Offset: 0x00014767
		public void Apply()
		{
		}

		// Token: 0x04000142 RID: 322
		private Dictionary<Gizmo, bool> _gizmoToState;
	}
}
