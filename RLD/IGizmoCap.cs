using System;
using UnityEngine;

namespace RLD
{
	// Token: 0x02000023 RID: 35
	public interface IGizmoCap
	{
		// Token: 0x17000049 RID: 73
		// (get) Token: 0x06000144 RID: 324
		Gizmo Gizmo { get; }

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x06000145 RID: 325
		int HandleId { get; }

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x06000146 RID: 326
		Priority HoverPriority3D { get; }

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x06000147 RID: 327
		Priority HoverPriority2D { get; }

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x06000148 RID: 328
		Priority GenericHoverPriority { get; }

		// Token: 0x06000149 RID: 329
		void SetHoverable(bool isHoverable);

		// Token: 0x0600014A RID: 330
		void SetVisible(bool isVisible);

		// Token: 0x0600014B RID: 331
		void Render(Camera camera);
	}
}
