using System;
using System.Collections.Generic;
using UnityEngine;

namespace RLD
{
	// Token: 0x0200009C RID: 156
	public class GizmoLineSlider3DCollection
	{
		// Token: 0x17000256 RID: 598
		// (get) Token: 0x06000722 RID: 1826 RVA: 0x00016FE4 File Offset: 0x000151E4
		public int Count
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x17000257 RID: 599
		// (get) Token: 0x06000723 RID: 1827 RVA: 0x00016FE7 File Offset: 0x000151E7
		public GizmoLineSlider3D Item
		{
			get
			{
				return null;
			}
		}

		// Token: 0x06000724 RID: 1828 RVA: 0x00016FEA File Offset: 0x000151EA
		public bool Contains(GizmoLineSlider3D slider)
		{
			return false;
		}

		// Token: 0x06000725 RID: 1829 RVA: 0x00016FED File Offset: 0x000151ED
		public bool Contains(int sliderHandleId)
		{
			return false;
		}

		// Token: 0x06000726 RID: 1830 RVA: 0x00016FF0 File Offset: 0x000151F0
		public bool ContainsCapId(int capHandleId)
		{
			return false;
		}

		// Token: 0x06000727 RID: 1831 RVA: 0x00016FF3 File Offset: 0x000151F3
		public void Add(GizmoLineSlider3D slider)
		{
		}

		// Token: 0x06000728 RID: 1832 RVA: 0x00016FF5 File Offset: 0x000151F5
		public void Remove(GizmoLineSlider3D slider)
		{
		}

		// Token: 0x06000729 RID: 1833 RVA: 0x00016FF7 File Offset: 0x000151F7
		public void ApplyZoomFactor(Camera camera)
		{
		}

		// Token: 0x0600072A RID: 1834 RVA: 0x00016FF9 File Offset: 0x000151F9
		public void SetZoomFactorTransform(GizmoTransform zoomFactorTransform)
		{
		}

		// Token: 0x0600072B RID: 1835 RVA: 0x00016FFB File Offset: 0x000151FB
		public void Make3DHoverPriorityLowerThan(Priority priority)
		{
		}

		// Token: 0x0600072C RID: 1836 RVA: 0x00016FFD File Offset: 0x000151FD
		public void Make3DHoverPriorityHigherThan(Priority priority)
		{
		}

		// Token: 0x0600072D RID: 1837 RVA: 0x00016FFF File Offset: 0x000151FF
		public void SetSnapEnabled(bool isEnabled)
		{
		}

		// Token: 0x0600072E RID: 1838 RVA: 0x00017001 File Offset: 0x00015201
		public void SetVisible(bool visible)
		{
		}

		// Token: 0x0600072F RID: 1839 RVA: 0x00017003 File Offset: 0x00015203
		public void Set3DCapsVisible(bool visible)
		{
		}

		// Token: 0x06000730 RID: 1840 RVA: 0x00017005 File Offset: 0x00015205
		public void SetDragChannel(GizmoDragChannel dragChannel)
		{
		}

		// Token: 0x06000731 RID: 1841 RVA: 0x00017007 File Offset: 0x00015207
		public void RegisterScalerHandle(int handleId, IEnumerable<int> scaleDragAxisIndices)
		{
		}

		// Token: 0x06000732 RID: 1842 RVA: 0x00017009 File Offset: 0x00015209
		public List<GizmoLineSlider3D> GetRenderSortedSliders(Camera renderCamera)
		{
			return null;
		}

		// Token: 0x04000287 RID: 647
		private List<GizmoLineSlider3D> _sliders;

		// Token: 0x04000288 RID: 648
		private Dictionary<int, GizmoLineSlider3D> _handleIdToSlider;

		// Token: 0x0200036A RID: 874
		private sealed class <>c__DisplayClass20_0
		{
			// Token: 0x06002A4B RID: 10827 RVA: 0x0001D1CF File Offset: 0x0001B3CF
			internal int <GetRenderSortedSliders>b__0(GizmoLineSlider3D s0, GizmoLineSlider3D s1)
			{
				return 0;
			}

			// Token: 0x04000EE4 RID: 3812
			public Camera renderCamera;

			// Token: 0x04000EE5 RID: 3813
			public Vector3 cameraPos;
		}

		// Token: 0x0200036B RID: 875
		private sealed class <>c__DisplayClass8_0
		{
			// Token: 0x06002A4D RID: 10829 RVA: 0x0001D1DA File Offset: 0x0001B3DA
			internal bool <ContainsCapId>b__0(GizmoLineSlider3D item)
			{
				return false;
			}

			// Token: 0x04000EE6 RID: 3814
			public int capHandleId;
		}
	}
}
