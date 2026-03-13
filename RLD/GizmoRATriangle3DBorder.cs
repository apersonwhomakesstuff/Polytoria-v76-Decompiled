using System;
using UnityEngine;

namespace RLD
{
	// Token: 0x020000CD RID: 205
	public class GizmoRATriangle3DBorder
	{
		// Token: 0x170002C6 RID: 710
		// (get) Token: 0x060008B2 RID: 2226 RVA: 0x000174C7 File Offset: 0x000156C7
		public bool IsVisible
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170002C7 RID: 711
		// (get) Token: 0x060008B3 RID: 2227 RVA: 0x000174CA File Offset: 0x000156CA
		public bool IsHoverable
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170002C8 RID: 712
		// (get) Token: 0x060008B4 RID: 2228 RVA: 0x000174CD File Offset: 0x000156CD
		public Gizmo Gizmo
		{
			get
			{
				return null;
			}
		}

		// Token: 0x060008B5 RID: 2229 RVA: 0x000174D0 File Offset: 0x000156D0
		public GizmoRATriangle3DBorder(GizmoPlaneSlider3D planeSlider, GizmoHandle targetHandle, RightAngTriangle3D targetRiangle)
		{
		}

		// Token: 0x060008B6 RID: 2230 RVA: 0x000174D8 File Offset: 0x000156D8
		public void SetVisible(bool isVisible)
		{
		}

		// Token: 0x060008B7 RID: 2231 RVA: 0x000174DA File Offset: 0x000156DA
		public void SetHoverable(bool isHoverable)
		{
		}

		// Token: 0x060008B8 RID: 2232 RVA: 0x000174DC File Offset: 0x000156DC
		public float GetZoomFactor(Camera camera)
		{
			return 0f;
		}

		// Token: 0x060008B9 RID: 2233 RVA: 0x000174E3 File Offset: 0x000156E3
		public void OnTriangleShapeChanged()
		{
		}

		// Token: 0x060008BA RID: 2234 RVA: 0x000174E5 File Offset: 0x000156E5
		public void Render(Camera camera)
		{
		}

		// Token: 0x060008BB RID: 2235 RVA: 0x000174E7 File Offset: 0x000156E7
		private void OnGizmoPreUpdateBegin(Gizmo gizmo)
		{
		}

		// Token: 0x0400038A RID: 906
		private GizmoPlaneSlider3D _planeSlider;

		// Token: 0x0400038B RID: 907
		private GizmoHandle _targetHandle;

		// Token: 0x0400038C RID: 908
		private RightAngTriangle3D _targetTriangle;

		// Token: 0x0400038D RID: 909
		private bool _isVisible;

		// Token: 0x0400038E RID: 910
		private bool _isHoverable;

		// Token: 0x0400038F RID: 911
		private int _borderTriangleIndex;

		// Token: 0x04000390 RID: 912
		private RightAngTriangle3D _borderTriangle;

		// Token: 0x04000391 RID: 913
		private GizmoRATriangle3DBorderControllerData _controllerData;

		// Token: 0x04000392 RID: 914
		private IGizmoRATriangle3DBorderController[] _controllers;
	}
}
