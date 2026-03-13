using System;
using System.Collections.Generic;
using UnityEngine;

namespace RLD
{
	// Token: 0x020000C8 RID: 200
	public class GizmoQuad3DBorder
	{
		// Token: 0x170002C3 RID: 707
		// (get) Token: 0x0600089A RID: 2202 RVA: 0x00017478 File Offset: 0x00015678
		public bool IsVisible
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170002C4 RID: 708
		// (get) Token: 0x0600089B RID: 2203 RVA: 0x0001747B File Offset: 0x0001567B
		public bool IsHoverable
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170002C5 RID: 709
		// (get) Token: 0x0600089C RID: 2204 RVA: 0x0001747E File Offset: 0x0001567E
		public Gizmo Gizmo
		{
			get
			{
				return null;
			}
		}

		// Token: 0x0600089D RID: 2205 RVA: 0x00017481 File Offset: 0x00015681
		public GizmoQuad3DBorder(GizmoPlaneSlider3D planeSlider, GizmoHandle targetHandle, QuadShape3D targetQuad)
		{
		}

		// Token: 0x0600089E RID: 2206 RVA: 0x00017489 File Offset: 0x00015689
		public void SetVisible(bool isVisible)
		{
		}

		// Token: 0x0600089F RID: 2207 RVA: 0x0001748B File Offset: 0x0001568B
		public void SetHoverable(bool isHoverable)
		{
		}

		// Token: 0x060008A0 RID: 2208 RVA: 0x0001748D File Offset: 0x0001568D
		public float GetZoomFactor(Camera camera)
		{
			return 0f;
		}

		// Token: 0x060008A1 RID: 2209 RVA: 0x00017494 File Offset: 0x00015694
		public float GetRealBoxHeight(float zoomFactor)
		{
			return 0f;
		}

		// Token: 0x060008A2 RID: 2210 RVA: 0x0001749B File Offset: 0x0001569B
		public float GetRealBoxDepth(float zoomFactor)
		{
			return 0f;
		}

		// Token: 0x060008A3 RID: 2211 RVA: 0x000174A2 File Offset: 0x000156A2
		public void OnQuadShapeChanged()
		{
		}

		// Token: 0x060008A4 RID: 2212 RVA: 0x000174A4 File Offset: 0x000156A4
		public void Render(Camera camera)
		{
		}

		// Token: 0x060008A5 RID: 2213 RVA: 0x000174A6 File Offset: 0x000156A6
		private void OnGizmoPreUpdateBegin(Gizmo gizmo)
		{
		}

		// Token: 0x04000358 RID: 856
		private GizmoPlaneSlider3D _planeSlider;

		// Token: 0x04000359 RID: 857
		private GizmoHandle _targetHandle;

		// Token: 0x0400035A RID: 858
		private QuadShape3D _targetQuad;

		// Token: 0x0400035B RID: 859
		private bool _isVisible;

		// Token: 0x0400035C RID: 860
		private bool _isHoverable;

		// Token: 0x0400035D RID: 861
		private int _borderQuadIndex;

		// Token: 0x0400035E RID: 862
		private QuadShape3D _borderQuad;

		// Token: 0x0400035F RID: 863
		private int _topBoxIndex;

		// Token: 0x04000360 RID: 864
		private BoxShape3D _topBox;

		// Token: 0x04000361 RID: 865
		private int _rightBoxIndex;

		// Token: 0x04000362 RID: 866
		private BoxShape3D _rightBox;

		// Token: 0x04000363 RID: 867
		private int _bottomBoxIndex;

		// Token: 0x04000364 RID: 868
		private BoxShape3D _bottomBox;

		// Token: 0x04000365 RID: 869
		private int _leftBoxIndex;

		// Token: 0x04000366 RID: 870
		private BoxShape3D _leftBox;

		// Token: 0x04000367 RID: 871
		private int _topLeftBoxIndex;

		// Token: 0x04000368 RID: 872
		private BoxShape3D _topLeftBox;

		// Token: 0x04000369 RID: 873
		private int _topRightBoxIndex;

		// Token: 0x0400036A RID: 874
		private BoxShape3D _topRightBox;

		// Token: 0x0400036B RID: 875
		private int _bottomRightBoxIndex;

		// Token: 0x0400036C RID: 876
		private BoxShape3D _bottomRightBox;

		// Token: 0x0400036D RID: 877
		private int _bottomLeftBoxIndex;

		// Token: 0x0400036E RID: 878
		private BoxShape3D _bottomLeftBox;

		// Token: 0x0400036F RID: 879
		private List<int> _sortedBoxIndices;

		// Token: 0x04000370 RID: 880
		private GizmoQuad3DBorderControllerData _controllerData;

		// Token: 0x04000371 RID: 881
		private IGizmoQuad3DBorderController[] _controllers;

		// Token: 0x0200036D RID: 877
		private sealed class <>c__DisplayClass39_0
		{
			// Token: 0x06002A51 RID: 10833 RVA: 0x0001D1F0 File Offset: 0x0001B3F0
			internal int <Render>b__0(int i0, int i1)
			{
				return 0;
			}

			// Token: 0x04000EE8 RID: 3816
			public GizmoQuad3DBorder <>4__this;

			// Token: 0x04000EE9 RID: 3817
			public Vector3 camPos;
		}
	}
}
