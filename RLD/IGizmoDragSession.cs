using System;
using UnityEngine;

namespace RLD
{
	// Token: 0x02000044 RID: 68
	public interface IGizmoDragSession
	{
		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x06000265 RID: 613
		bool IsActive { get; }

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x06000266 RID: 614
		GizmoDragChannel DragChannel { get; }

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x06000267 RID: 615
		Vector3 TotalDragOffset { get; }

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x06000268 RID: 616
		Quaternion TotalDragRotation { get; }

		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x06000269 RID: 617
		Vector3 TotalDragScale { get; }

		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x0600026A RID: 618
		Vector3 RelativeDragOffset { get; }

		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x0600026B RID: 619
		Quaternion RelativeDragRotation { get; }

		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x0600026C RID: 620
		Vector3 RelativeDragScale { get; }

		// Token: 0x0600026D RID: 621
		bool ContainsTargetTransform(GizmoTransform transform);

		// Token: 0x0600026E RID: 622
		void AddTargetTransform(GizmoTransform transform);

		// Token: 0x0600026F RID: 623
		void RemoveTargetTransform(GizmoTransform transform);

		// Token: 0x06000270 RID: 624
		bool Begin();

		// Token: 0x06000271 RID: 625
		bool Update();

		// Token: 0x06000272 RID: 626
		void End();
	}
}
