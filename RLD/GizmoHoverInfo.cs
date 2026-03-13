using System;
using UnityEngine;

namespace RLD
{
	// Token: 0x02000028 RID: 40
	public struct GizmoHoverInfo
	{
		// Token: 0x17000059 RID: 89
		// (get) Token: 0x06000163 RID: 355 RVA: 0x000161DA File Offset: 0x000143DA
		// (set) Token: 0x06000164 RID: 356 RVA: 0x000161DD File Offset: 0x000143DD
		public bool IsHovered
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x06000165 RID: 357 RVA: 0x000161DF File Offset: 0x000143DF
		// (set) Token: 0x06000166 RID: 358 RVA: 0x000161E2 File Offset: 0x000143E2
		public int HandleId
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x06000167 RID: 359 RVA: 0x0001E09C File Offset: 0x0001C29C
		// (set) Token: 0x06000168 RID: 360 RVA: 0x000161E4 File Offset: 0x000143E4
		public GizmoDimension HandleDimension
		{
			get
			{
				return GizmoDimension.None;
			}
			set
			{
			}
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x06000169 RID: 361 RVA: 0x0001E0B4 File Offset: 0x0001C2B4
		// (set) Token: 0x0600016A RID: 362 RVA: 0x000161E6 File Offset: 0x000143E6
		public Vector3 HoverPoint
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		// Token: 0x0600016B RID: 363 RVA: 0x000161E8 File Offset: 0x000143E8
		public void Reset()
		{
		}

		// Token: 0x04000095 RID: 149
		private bool _isHovered;

		// Token: 0x04000096 RID: 150
		private int _handleId;

		// Token: 0x04000097 RID: 151
		private GizmoDimension _handleDimension;

		// Token: 0x04000098 RID: 152
		private Vector3 _hoverPoint;
	}
}
