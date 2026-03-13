using System;
using UnityEngine;

namespace RLD
{
	// Token: 0x0200002C RID: 44
	public class GizmoOverrideColor
	{
		// Token: 0x1700005D RID: 93
		// (get) Token: 0x0600016C RID: 364 RVA: 0x000161EA File Offset: 0x000143EA
		// (set) Token: 0x0600016D RID: 365 RVA: 0x000161ED File Offset: 0x000143ED
		public bool IsActive
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x0600016E RID: 366 RVA: 0x0001E0CC File Offset: 0x0001C2CC
		// (set) Token: 0x0600016F RID: 367 RVA: 0x000161EF File Offset: 0x000143EF
		public Color Color
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		// Token: 0x040000A3 RID: 163
		private bool _isActive;

		// Token: 0x040000A4 RID: 164
		private Color _color;
	}
}
