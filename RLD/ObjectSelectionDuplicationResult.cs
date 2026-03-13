using System;
using System.Collections.Generic;
using UnityEngine;

namespace RLD
{
	// Token: 0x0200022B RID: 555
	public class ObjectSelectionDuplicationResult
	{
		// Token: 0x1700084C RID: 2124
		// (get) Token: 0x06001878 RID: 6264 RVA: 0x0001A03E File Offset: 0x0001823E
		public List<GameObject> DuplicateParents
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700084D RID: 2125
		// (get) Token: 0x06001879 RID: 6265 RVA: 0x0001A041 File Offset: 0x00018241
		public int NumDuplicateParents
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x0600187A RID: 6266 RVA: 0x0001A044 File Offset: 0x00018244
		public ObjectSelectionDuplicationResult(List<GameObject> duplicatedParents)
		{
		}

		// Token: 0x0600187B RID: 6267 RVA: 0x0001A04C File Offset: 0x0001824C
		public GameObject GetParentByIndex(int index)
		{
			return null;
		}

		// Token: 0x040008B8 RID: 2232
		private List<GameObject> _duplicateParents;
	}
}
