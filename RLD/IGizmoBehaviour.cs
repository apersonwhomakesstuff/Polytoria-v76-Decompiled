using System;
using UnityEngine;

namespace RLD
{
	// Token: 0x02000048 RID: 72
	public interface IGizmoBehaviour
	{
		// Token: 0x170000BB RID: 187
		// (get) Token: 0x06000297 RID: 663
		Gizmo Gizmo { get; }

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x06000298 RID: 664
		bool IsEnabled { get; }

		// Token: 0x06000299 RID: 665
		void Init_SystemCall(GizmoBehaviorInitParams initParams);

		// Token: 0x0600029A RID: 666
		void SetEnabled(bool enabled);

		// Token: 0x0600029B RID: 667
		void OnAttached();

		// Token: 0x0600029C RID: 668
		void OnDetached();

		// Token: 0x0600029D RID: 669
		void OnEnabled();

		// Token: 0x0600029E RID: 670
		void OnDisabled();

		// Token: 0x0600029F RID: 671
		void OnGizmoEnabled();

		// Token: 0x060002A0 RID: 672
		void OnGizmoDisabled();

		// Token: 0x060002A1 RID: 673
		void OnGizmoHandlePicked(int handleId);

		// Token: 0x060002A2 RID: 674
		bool OnGizmoCanBeginDrag(int handleId);

		// Token: 0x060002A3 RID: 675
		void OnGizmoAttemptHandleDragBegin(int handleId);

		// Token: 0x060002A4 RID: 676
		void OnGizmoHoverEnter(int handleId);

		// Token: 0x060002A5 RID: 677
		void OnGizmoHoverExit(int handleId);

		// Token: 0x060002A6 RID: 678
		void OnGizmoDragBegin(int handleId);

		// Token: 0x060002A7 RID: 679
		void OnGizmoDragUpdate(int handleId);

		// Token: 0x060002A8 RID: 680
		void OnGizmoDragEnd(int handleId);

		// Token: 0x060002A9 RID: 681
		void OnGizmoUpdateBegin();

		// Token: 0x060002AA RID: 682
		void OnGizmoUpdateEnd();

		// Token: 0x060002AB RID: 683
		void OnGUI();

		// Token: 0x060002AC RID: 684
		void OnGizmoRender(Camera camera);
	}
}
