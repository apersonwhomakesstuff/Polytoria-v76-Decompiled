using System;
using System.Collections.Generic;
using UnityEngine;

namespace RLD
{
	// Token: 0x02000086 RID: 134
	public class GizmoLineSlider2DCollection
	{
		// Token: 0x170001ED RID: 493
		// (get) Token: 0x060005FB RID: 1531 RVA: 0x00016C6F File Offset: 0x00014E6F
		public int Count
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x170001EE RID: 494
		// (get) Token: 0x060005FC RID: 1532 RVA: 0x00016C72 File Offset: 0x00014E72
		public GizmoLineSlider2D Item
		{
			get
			{
				return null;
			}
		}

		// Token: 0x060005FD RID: 1533 RVA: 0x00016C75 File Offset: 0x00014E75
		public bool Contains(GizmoLineSlider2D slider)
		{
			return false;
		}

		// Token: 0x060005FE RID: 1534 RVA: 0x00016C78 File Offset: 0x00014E78
		public bool Contains(int sliderHandleId)
		{
			return false;
		}

		// Token: 0x060005FF RID: 1535 RVA: 0x00016C7B File Offset: 0x00014E7B
		public bool ContainsCapId(int capHandleId)
		{
			return false;
		}

		// Token: 0x06000600 RID: 1536 RVA: 0x00016C7E File Offset: 0x00014E7E
		public void Add(GizmoLineSlider2D slider)
		{
		}

		// Token: 0x06000601 RID: 1537 RVA: 0x00016C80 File Offset: 0x00014E80
		public void Remove(GizmoLineSlider2D slider)
		{
		}

		// Token: 0x06000602 RID: 1538 RVA: 0x00016C82 File Offset: 0x00014E82
		public void Make2DHoverPriorityLowerThan(Priority priority)
		{
		}

		// Token: 0x06000603 RID: 1539 RVA: 0x00016C84 File Offset: 0x00014E84
		public void Make2DHoverPriorityHigherThan(Priority priority)
		{
		}

		// Token: 0x06000604 RID: 1540 RVA: 0x00016C86 File Offset: 0x00014E86
		public void SetSnapEnabled(bool isEnabled)
		{
		}

		// Token: 0x06000605 RID: 1541 RVA: 0x00016C88 File Offset: 0x00014E88
		public void SetVisible(bool visible)
		{
		}

		// Token: 0x06000606 RID: 1542 RVA: 0x00016C8A File Offset: 0x00014E8A
		public void Set2DCapsVisible(bool visible)
		{
		}

		// Token: 0x06000607 RID: 1543 RVA: 0x00016C8C File Offset: 0x00014E8C
		public void SetOffsetDragOrigin(Vector3 dragOrigin)
		{
		}

		// Token: 0x06000608 RID: 1544 RVA: 0x00016C8E File Offset: 0x00014E8E
		public void Render(Camera camera)
		{
		}

		// Token: 0x04000200 RID: 512
		private List<GizmoLineSlider2D> _sliders;

		// Token: 0x04000201 RID: 513
		private Dictionary<int, GizmoLineSlider2D> _handleIdToSlider;

		// Token: 0x02000366 RID: 870
		private sealed class <>c__DisplayClass8_0
		{
			// Token: 0x06002A43 RID: 10819 RVA: 0x0001D1A3 File Offset: 0x0001B3A3
			internal bool <ContainsCapId>b__0(GizmoLineSlider2D item)
			{
				return false;
			}

			// Token: 0x04000EE0 RID: 3808
			public int capHandleId;
		}
	}
}
