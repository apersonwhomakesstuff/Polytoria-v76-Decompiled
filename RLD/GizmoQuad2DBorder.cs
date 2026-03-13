using System;
using UnityEngine;

namespace RLD
{
	// Token: 0x020000BB RID: 187
	public class GizmoQuad2DBorder
	{
		// Token: 0x170002BE RID: 702
		// (get) Token: 0x0600085F RID: 2143 RVA: 0x000173B0 File Offset: 0x000155B0
		public bool IsVisible
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170002BF RID: 703
		// (get) Token: 0x06000860 RID: 2144 RVA: 0x000173B3 File Offset: 0x000155B3
		public bool IsHoverable
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06000861 RID: 2145 RVA: 0x000173B6 File Offset: 0x000155B6
		public GizmoQuad2DBorder(GizmoPlaneSlider2D planeSlider, GizmoHandle targetHandle, QuadShape2D targetQuad)
		{
		}

		// Token: 0x06000862 RID: 2146 RVA: 0x000173BE File Offset: 0x000155BE
		public void SetVisible(bool isVisible)
		{
		}

		// Token: 0x06000863 RID: 2147 RVA: 0x000173C0 File Offset: 0x000155C0
		public void SetHoverable(bool isHoverable)
		{
		}

		// Token: 0x06000864 RID: 2148 RVA: 0x000173C2 File Offset: 0x000155C2
		public void OnQuadShapeChanged()
		{
		}

		// Token: 0x06000865 RID: 2149 RVA: 0x000173C4 File Offset: 0x000155C4
		public void Render(Camera camera)
		{
		}

		// Token: 0x06000866 RID: 2150 RVA: 0x000173C6 File Offset: 0x000155C6
		private void OnGizmoPreUpdateBegin(Gizmo gizmo)
		{
		}

		// Token: 0x0400032E RID: 814
		private GizmoPlaneSlider2D _planeSlider;

		// Token: 0x0400032F RID: 815
		private GizmoHandle _targetHandle;

		// Token: 0x04000330 RID: 816
		private QuadShape2D _targetQuad;

		// Token: 0x04000331 RID: 817
		private bool _isVisible;

		// Token: 0x04000332 RID: 818
		private bool _isHoverable;

		// Token: 0x04000333 RID: 819
		private int _borderQuadIndex;

		// Token: 0x04000334 RID: 820
		private QuadShape2D _borderQuad;

		// Token: 0x04000335 RID: 821
		private GizmoQuad2DBorderControllerData _controllerData;

		// Token: 0x04000336 RID: 822
		private IGizmoQuad2DBorderController[] _controllers;
	}
}
