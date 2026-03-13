using System;
using System.Collections.Generic;
using UnityEngine;

namespace RLD
{
	// Token: 0x02000229 RID: 553
	public class ObjectSelectionSnapshot
	{
		// Token: 0x17000848 RID: 2120
		// (get) Token: 0x0600186E RID: 6254 RVA: 0x0001A00E File Offset: 0x0001820E
		public int NumObjects
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x17000849 RID: 2121
		// (get) Token: 0x0600186F RID: 6255 RVA: 0x0001A011 File Offset: 0x00018211
		public List<GameObject> SnapshotObjects
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700084A RID: 2122
		// (get) Token: 0x06001870 RID: 6256 RVA: 0x0001A014 File Offset: 0x00018214
		public ObjectSelectionGizmosSnapshot GizmosSnapshot
		{
			get
			{
				return null;
			}
		}

		// Token: 0x06001871 RID: 6257 RVA: 0x0001A017 File Offset: 0x00018217
		public ObjectSelectionSnapshot()
		{
		}

		// Token: 0x06001872 RID: 6258 RVA: 0x0001A01F File Offset: 0x0001821F
		public ObjectSelectionSnapshot(ObjectSelectionSnapshot copy)
		{
		}

		// Token: 0x06001873 RID: 6259 RVA: 0x0001A027 File Offset: 0x00018227
		public void Snapshot()
		{
		}

		// Token: 0x040008B5 RID: 2229
		private List<GameObject> _snapshotObjects;

		// Token: 0x040008B6 RID: 2230
		private ObjectSelectionGizmosSnapshot _gizmosSnapshot;
	}
}
