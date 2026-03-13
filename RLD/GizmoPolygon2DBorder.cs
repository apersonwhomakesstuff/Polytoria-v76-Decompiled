using System;
using UnityEngine;

namespace RLD
{
	// Token: 0x020000B5 RID: 181
	public class GizmoPolygon2DBorder
	{
		// Token: 0x170002BC RID: 700
		// (get) Token: 0x06000847 RID: 2119 RVA: 0x0001736A File Offset: 0x0001556A
		public bool IsVisible
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170002BD RID: 701
		// (get) Token: 0x06000848 RID: 2120 RVA: 0x0001736D File Offset: 0x0001556D
		public bool IsHoverable
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06000849 RID: 2121 RVA: 0x00017370 File Offset: 0x00015570
		public GizmoPolygon2DBorder(GizmoPlaneSlider2D planeSlider, GizmoHandle targetHandle, PolygonShape2D targetPolygon)
		{
		}

		// Token: 0x0600084A RID: 2122 RVA: 0x00017378 File Offset: 0x00015578
		public void SetVisible(bool isVisible)
		{
		}

		// Token: 0x0600084B RID: 2123 RVA: 0x0001737A File Offset: 0x0001557A
		public void SetHoverable(bool isHoverable)
		{
		}

		// Token: 0x0600084C RID: 2124 RVA: 0x0001737C File Offset: 0x0001557C
		public void OnPolygonShapeChanged()
		{
		}

		// Token: 0x0600084D RID: 2125 RVA: 0x0001737E File Offset: 0x0001557E
		public void Render(Camera camera)
		{
		}

		// Token: 0x0600084E RID: 2126 RVA: 0x00017380 File Offset: 0x00015580
		private void OnGizmoPreUpdateBegin(Gizmo gizmo)
		{
		}

		// Token: 0x04000319 RID: 793
		private GizmoPlaneSlider2D _planeSlider;

		// Token: 0x0400031A RID: 794
		private GizmoHandle _targetHandle;

		// Token: 0x0400031B RID: 795
		private PolygonShape2D _targetPolygon;

		// Token: 0x0400031C RID: 796
		private bool _isVisible;

		// Token: 0x0400031D RID: 797
		private bool _isHoverable;

		// Token: 0x0400031E RID: 798
		private int _borderPolygonIndex;

		// Token: 0x0400031F RID: 799
		private int _thickBorderPolygonIndex;

		// Token: 0x04000320 RID: 800
		private PolygonShape2D _borderPolygon;

		// Token: 0x04000321 RID: 801
		private PolygonShape2D _thickBorderPolygon;

		// Token: 0x04000322 RID: 802
		private GizmoPolygon2DBorderControllerData _controllerData;

		// Token: 0x04000323 RID: 803
		private IGizmoPolygon2DBorderController[] _controllers;
	}
}
