using System;
using UnityEngine;

namespace RLD
{
	// Token: 0x0200003E RID: 62
	public abstract class GizmoPlaneDrag3D : GizmoDragSession
	{
		// Token: 0x1700009D RID: 157
		// (get) Token: 0x0600022F RID: 559 RVA: 0x0001639C File Offset: 0x0001459C
		// (set) Token: 0x06000230 RID: 560 RVA: 0x0001639F File Offset: 0x0001459F
		public bool IsSnapEnabled
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x06000231 RID: 561 RVA: 0x000163A1 File Offset: 0x000145A1
		// (set) Token: 0x06000232 RID: 562 RVA: 0x000163A8 File Offset: 0x000145A8
		public float Sensitivity
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x06000233 RID: 563 RVA: 0x000163AA File Offset: 0x000145AA
		public override bool IsActive
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06000234 RID: 564 RVA: 0x000163AD File Offset: 0x000145AD
		protected override bool DoBeginSession()
		{
			return false;
		}

		// Token: 0x06000235 RID: 565 RVA: 0x000163B0 File Offset: 0x000145B0
		protected override bool DoUpdateSession()
		{
			return false;
		}

		// Token: 0x06000236 RID: 566 RVA: 0x000163B3 File Offset: 0x000145B3
		protected override void DoEndSession()
		{
		}

		// Token: 0x06000237 RID: 567 RVA: 0x000163B5 File Offset: 0x000145B5
		protected bool CanSnap()
		{
			return false;
		}

		// Token: 0x06000238 RID: 568
		protected abstract Plane CalculateDragPlane();

		// Token: 0x040000FD RID: 253
		private bool _isSnapEnabled;

		// Token: 0x040000FE RID: 254
		private float _sensitivity;

		// Token: 0x040000FF RID: 255
		protected InputDevicePlaneDragSession3D _planeDragSession;
	}
}
