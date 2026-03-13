using System;
using System.Collections.Generic;
using UnityEngine;

namespace RLD
{
	// Token: 0x020001AF RID: 431
	public class XZGridCell
	{
		// Token: 0x1700062B RID: 1579
		// (get) Token: 0x06001312 RID: 4882 RVA: 0x000192AF File Offset: 0x000174AF
		public IXZGrid ParentGrid
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700062C RID: 1580
		// (get) Token: 0x06001313 RID: 4883 RVA: 0x000192B2 File Offset: 0x000174B2
		public int XIndex
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x1700062D RID: 1581
		// (get) Token: 0x06001314 RID: 4884 RVA: 0x000192B5 File Offset: 0x000174B5
		public int ZIndex
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x1700062E RID: 1582
		// (get) Token: 0x06001315 RID: 4885 RVA: 0x00021B24 File Offset: 0x0001FD24
		public Vector3 Min
		{
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x1700062F RID: 1583
		// (get) Token: 0x06001316 RID: 4886 RVA: 0x00021B3C File Offset: 0x0001FD3C
		public Vector3 Max
		{
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x17000630 RID: 1584
		// (get) Token: 0x06001317 RID: 4887 RVA: 0x00021B54 File Offset: 0x0001FD54
		public Vector3 Center
		{
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x06001318 RID: 4888 RVA: 0x000192B8 File Offset: 0x000174B8
		public XZGridCell(int xIndex, int zIndex, Vector3 min, Vector3 max, IXZGrid parentGrid)
		{
		}

		// Token: 0x06001319 RID: 4889 RVA: 0x000192C0 File Offset: 0x000174C0
		public static XZGridCell FromPoint(Vector3 point, float cellSizeX, float cellSizeZ, IXZGrid parentGrid)
		{
			return null;
		}

		// Token: 0x0600131A RID: 4890 RVA: 0x000192C3 File Offset: 0x000174C3
		public List<Vector3> GetCenterAndCorners()
		{
			return null;
		}

		// Token: 0x040006CE RID: 1742
		private IXZGrid _parentGrid;

		// Token: 0x040006CF RID: 1743
		private int _xIndex;

		// Token: 0x040006D0 RID: 1744
		private int _zIndex;

		// Token: 0x040006D1 RID: 1745
		private Vector3 _min;

		// Token: 0x040006D2 RID: 1746
		private Vector3 _max;
	}
}
