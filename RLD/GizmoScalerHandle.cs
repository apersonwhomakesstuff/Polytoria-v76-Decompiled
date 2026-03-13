using System;
using System.Collections.Generic;

namespace RLD
{
	// Token: 0x02000074 RID: 116
	public class GizmoScalerHandle
	{
		// Token: 0x17000188 RID: 392
		// (get) Token: 0x060004FC RID: 1276 RVA: 0x000169A9 File Offset: 0x00014BA9
		public int HandleId
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x17000189 RID: 393
		// (get) Token: 0x060004FD RID: 1277 RVA: 0x000169AC File Offset: 0x00014BAC
		public List<int> ScaleDragAxisIndices
		{
			get
			{
				return null;
			}
		}

		// Token: 0x060004FE RID: 1278 RVA: 0x000169AF File Offset: 0x00014BAF
		public GizmoScalerHandle(int handleId, IEnumerable<int> scaleDragAxisIndices)
		{
		}

		// Token: 0x060004FF RID: 1279 RVA: 0x000169B7 File Offset: 0x00014BB7
		public bool ContainsScaleDragAxisIndex(int scaleDragAxisIndex)
		{
			return false;
		}

		// Token: 0x0400019C RID: 412
		private int _handleId;

		// Token: 0x0400019D RID: 413
		private List<int> _scaleDragAxisIndices;
	}
}
