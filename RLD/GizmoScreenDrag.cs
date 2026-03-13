using System;

namespace RLD
{
	// Token: 0x0200003F RID: 63
	public abstract class GizmoScreenDrag : GizmoDragSession
	{
		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x0600023A RID: 570 RVA: 0x000163C0 File Offset: 0x000145C0
		// (set) Token: 0x0600023B RID: 571 RVA: 0x000163C3 File Offset: 0x000145C3
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

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x0600023C RID: 572 RVA: 0x000163C5 File Offset: 0x000145C5
		// (set) Token: 0x0600023D RID: 573 RVA: 0x000163CC File Offset: 0x000145CC
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

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x0600023E RID: 574 RVA: 0x000163CE File Offset: 0x000145CE
		public override bool IsActive
		{
			get
			{
				return false;
			}
		}

		// Token: 0x0600023F RID: 575 RVA: 0x000163D1 File Offset: 0x000145D1
		protected override bool DoBeginSession()
		{
			return false;
		}

		// Token: 0x06000240 RID: 576 RVA: 0x000163D4 File Offset: 0x000145D4
		protected override bool DoUpdateSession()
		{
			return false;
		}

		// Token: 0x06000241 RID: 577 RVA: 0x000163D7 File Offset: 0x000145D7
		protected override void DoEndSession()
		{
		}

		// Token: 0x06000242 RID: 578 RVA: 0x000163D9 File Offset: 0x000145D9
		protected bool CanSnap()
		{
			return false;
		}

		// Token: 0x04000100 RID: 256
		private bool _isSnapEnabled;

		// Token: 0x04000101 RID: 257
		private float _sensitivity;

		// Token: 0x04000102 RID: 258
		protected InputDeviceScreenDragSession _screenDragSession;
	}
}
