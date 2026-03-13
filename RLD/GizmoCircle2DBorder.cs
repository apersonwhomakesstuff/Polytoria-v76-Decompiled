using System;
using UnityEngine;

namespace RLD
{
	// Token: 0x020000B0 RID: 176
	public class GizmoCircle2DBorder
	{
		// Token: 0x170002BA RID: 698
		// (get) Token: 0x06000833 RID: 2099 RVA: 0x00017333 File Offset: 0x00015533
		public bool IsVisible
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170002BB RID: 699
		// (get) Token: 0x06000834 RID: 2100 RVA: 0x00017336 File Offset: 0x00015536
		public bool IsHoverable
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06000835 RID: 2101 RVA: 0x00017339 File Offset: 0x00015539
		public GizmoCircle2DBorder(GizmoPlaneSlider2D planeSlider, GizmoHandle targetHandle, CircleShape2D targetCircle)
		{
		}

		// Token: 0x06000836 RID: 2102 RVA: 0x00017341 File Offset: 0x00015541
		public void SetVisible(bool isVisible)
		{
		}

		// Token: 0x06000837 RID: 2103 RVA: 0x00017343 File Offset: 0x00015543
		public void SetHoverable(bool isHoverable)
		{
		}

		// Token: 0x06000838 RID: 2104 RVA: 0x00017345 File Offset: 0x00015545
		public void OnCircleShapeChanged()
		{
		}

		// Token: 0x06000839 RID: 2105 RVA: 0x00017347 File Offset: 0x00015547
		public void Render(Camera camera)
		{
		}

		// Token: 0x0600083A RID: 2106 RVA: 0x00017349 File Offset: 0x00015549
		private void OnGizmoPreUpdateBegin(Gizmo gizmo)
		{
		}

		// Token: 0x04000308 RID: 776
		private GizmoPlaneSlider2D _planeSlider;

		// Token: 0x04000309 RID: 777
		private GizmoHandle _targetHandle;

		// Token: 0x0400030A RID: 778
		private CircleShape2D _targetCircle;

		// Token: 0x0400030B RID: 779
		private bool _isVisible;

		// Token: 0x0400030C RID: 780
		private bool _isHoverable;

		// Token: 0x0400030D RID: 781
		private int _borderCircleIndex;

		// Token: 0x0400030E RID: 782
		private CircleShape2D _borderCircle;

		// Token: 0x0400030F RID: 783
		private GizmoCircle2DBorderControllerData _controllerData;

		// Token: 0x04000310 RID: 784
		private IGizmoCircle2DBorderController[] _controllers;
	}
}
