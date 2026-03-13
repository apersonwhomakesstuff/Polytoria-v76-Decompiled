using System;
using System.Collections.Generic;
using UnityEngine;

namespace RLD
{
	// Token: 0x020000A6 RID: 166
	public class GizmoPlaneSlider3DCollection
	{
		// Token: 0x1700028D RID: 653
		// (get) Token: 0x060007BB RID: 1979 RVA: 0x000171AF File Offset: 0x000153AF
		public int Count
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x1700028E RID: 654
		// (get) Token: 0x060007BC RID: 1980 RVA: 0x000171B2 File Offset: 0x000153B2
		public GizmoPlaneSlider3D Item
		{
			get
			{
				return null;
			}
		}

		// Token: 0x060007BD RID: 1981 RVA: 0x000171B5 File Offset: 0x000153B5
		public bool Contains(GizmoPlaneSlider3D slider)
		{
			return false;
		}

		// Token: 0x060007BE RID: 1982 RVA: 0x000171B8 File Offset: 0x000153B8
		public bool Contains(int sliderHandleId)
		{
			return false;
		}

		// Token: 0x060007BF RID: 1983 RVA: 0x000171BB File Offset: 0x000153BB
		public void Add(GizmoPlaneSlider3D slider)
		{
		}

		// Token: 0x060007C0 RID: 1984 RVA: 0x000171BD File Offset: 0x000153BD
		public void Remove(GizmoPlaneSlider3D slider)
		{
		}

		// Token: 0x060007C1 RID: 1985 RVA: 0x000171BF File Offset: 0x000153BF
		public void ApplyZoomFactor(Camera camera)
		{
		}

		// Token: 0x060007C2 RID: 1986 RVA: 0x000171C1 File Offset: 0x000153C1
		public void SetZoomFactorTransform(GizmoTransform zoomFactorTransform)
		{
		}

		// Token: 0x060007C3 RID: 1987 RVA: 0x000171C3 File Offset: 0x000153C3
		public void Make3DHoverPriorityLowerThan(Priority priority)
		{
		}

		// Token: 0x060007C4 RID: 1988 RVA: 0x000171C5 File Offset: 0x000153C5
		public void Make3DHoverPriorityHigherThan(Priority priority)
		{
		}

		// Token: 0x060007C5 RID: 1989 RVA: 0x000171C7 File Offset: 0x000153C7
		public void SetSnapEnabled(bool isEnabled)
		{
		}

		// Token: 0x060007C6 RID: 1990 RVA: 0x000171C9 File Offset: 0x000153C9
		public void SetVisible(bool isVisible, bool includeBorder)
		{
		}

		// Token: 0x060007C7 RID: 1991 RVA: 0x000171CB File Offset: 0x000153CB
		public void SetBorderVisible(bool isVisible)
		{
		}

		// Token: 0x060007C8 RID: 1992 RVA: 0x000171CD File Offset: 0x000153CD
		public void SetHoverable(bool isHoverable, bool includeBorder)
		{
		}

		// Token: 0x060007C9 RID: 1993 RVA: 0x000171CF File Offset: 0x000153CF
		public void SetBorderHoverable(bool isHoverable)
		{
		}

		// Token: 0x060007CA RID: 1994 RVA: 0x000171D1 File Offset: 0x000153D1
		public List<GizmoPlaneSlider3D> GetRenderSortedSliders(Camera renderCamera)
		{
			return null;
		}

		// Token: 0x040002C9 RID: 713
		private List<GizmoPlaneSlider3D> _sliders;

		// Token: 0x040002CA RID: 714
		private Dictionary<int, GizmoPlaneSlider3D> _handleIdToSlider;

		// Token: 0x0200036C RID: 876
		private sealed class <>c__DisplayClass19_0
		{
			// Token: 0x06002A4F RID: 10831 RVA: 0x0001D1E5 File Offset: 0x0001B3E5
			internal int <GetRenderSortedSliders>b__0(GizmoPlaneSlider3D s0, GizmoPlaneSlider3D s1)
			{
				return 0;
			}

			// Token: 0x04000EE7 RID: 3815
			public Vector3 cameraPos;
		}
	}
}
