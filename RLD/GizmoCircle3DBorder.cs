using System;
using UnityEngine;

namespace RLD
{
	// Token: 0x020000C0 RID: 192
	public class GizmoCircle3DBorder
	{
		// Token: 0x170002C0 RID: 704
		// (get) Token: 0x06000873 RID: 2163 RVA: 0x000173E7 File Offset: 0x000155E7
		public bool IsVisible
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170002C1 RID: 705
		// (get) Token: 0x06000874 RID: 2164 RVA: 0x000173EA File Offset: 0x000155EA
		public bool IsHoverable
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170002C2 RID: 706
		// (get) Token: 0x06000875 RID: 2165 RVA: 0x000173ED File Offset: 0x000155ED
		public Gizmo Gizmo
		{
			get
			{
				return null;
			}
		}

		// Token: 0x06000876 RID: 2166 RVA: 0x000173F0 File Offset: 0x000155F0
		public GizmoCircle3DBorder(GizmoPlaneSlider3D planeSlider, GizmoHandle targetHandle, CircleShape3D targetCircle)
		{
		}

		// Token: 0x06000877 RID: 2167 RVA: 0x000173F8 File Offset: 0x000155F8
		public void SetVisible(bool isVisible)
		{
		}

		// Token: 0x06000878 RID: 2168 RVA: 0x000173FA File Offset: 0x000155FA
		public void SetHoverable(bool isHoverable)
		{
		}

		// Token: 0x06000879 RID: 2169 RVA: 0x000173FC File Offset: 0x000155FC
		public float GetZoomFactor(Camera camera)
		{
			return 0f;
		}

		// Token: 0x0600087A RID: 2170 RVA: 0x00017403 File Offset: 0x00015603
		public float GetRealTorusThickness(float zoomFactor)
		{
			return 0f;
		}

		// Token: 0x0600087B RID: 2171 RVA: 0x0001740A File Offset: 0x0001560A
		public float GetRealCylTorusWidth(float zoomFactor)
		{
			return 0f;
		}

		// Token: 0x0600087C RID: 2172 RVA: 0x00017411 File Offset: 0x00015611
		public float GetRealCylTorusHeight(float zoomFactor)
		{
			return 0f;
		}

		// Token: 0x0600087D RID: 2173 RVA: 0x00017418 File Offset: 0x00015618
		public void OnCircleShapeChanged()
		{
		}

		// Token: 0x0600087E RID: 2174 RVA: 0x0001741A File Offset: 0x0001561A
		public void Render(Camera camera)
		{
		}

		// Token: 0x0600087F RID: 2175 RVA: 0x0001741C File Offset: 0x0001561C
		private void OnGizmoPreUpdateBegin(Gizmo gizmo)
		{
		}

		// Token: 0x0400033F RID: 831
		private GizmoPlaneSlider3D _planeSlider;

		// Token: 0x04000340 RID: 832
		private GizmoHandle _targetHandle;

		// Token: 0x04000341 RID: 833
		private CircleShape3D _targetCircle;

		// Token: 0x04000342 RID: 834
		private bool _isVisible;

		// Token: 0x04000343 RID: 835
		private bool _isHoverable;

		// Token: 0x04000344 RID: 836
		private int _borderCircleIndex;

		// Token: 0x04000345 RID: 837
		private int _borderTorusIndex;

		// Token: 0x04000346 RID: 838
		private int _borderCylTorusIndex;

		// Token: 0x04000347 RID: 839
		private CircleShape3D _borderCircle;

		// Token: 0x04000348 RID: 840
		private TorusShape3D _borderTorus;

		// Token: 0x04000349 RID: 841
		private CylTorusShape3D _borderCylTorus;

		// Token: 0x0400034A RID: 842
		private GizmoCircle3DBorderControllerData _controllerData;

		// Token: 0x0400034B RID: 843
		private IGizmoCircle3DBorderController[] _controllers;
	}
}
