using System;
using UnityEngine;

namespace RLD
{
	// Token: 0x020000D8 RID: 216
	public interface IGizmoSlider
	{
		// Token: 0x170002E0 RID: 736
		// (get) Token: 0x060008FC RID: 2300
		Gizmo Gizmo { get; }

		// Token: 0x170002E1 RID: 737
		// (get) Token: 0x060008FD RID: 2301
		int HandleId { get; }

		// Token: 0x170002E2 RID: 738
		// (get) Token: 0x060008FE RID: 2302
		Priority HoverPriority3D { get; }

		// Token: 0x170002E3 RID: 739
		// (get) Token: 0x060008FF RID: 2303
		Priority HoverPriority2D { get; }

		// Token: 0x170002E4 RID: 740
		// (get) Token: 0x06000900 RID: 2304
		Priority GenericHoverPriority { get; }

		// Token: 0x06000901 RID: 2305
		void SetHoverable(bool isHoverable);

		// Token: 0x06000902 RID: 2306
		void SetVisible(bool isVisible);

		// Token: 0x06000903 RID: 2307
		void SetSnapEnabled(bool isEnabled);

		// Token: 0x06000904 RID: 2308
		void Render(Camera camera);
	}
}
