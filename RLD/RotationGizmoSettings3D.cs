using System;

namespace RLD
{
	// Token: 0x020000E5 RID: 229
	[Serializable]
	public class RotationGizmoSettings3D : Settings
	{
		// Token: 0x17000387 RID: 903
		// (get) Token: 0x06000ABC RID: 2748 RVA: 0x00017A4F File Offset: 0x00015C4F
		public float AxisLineHoverEps
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000388 RID: 904
		// (get) Token: 0x06000ABD RID: 2749 RVA: 0x00017A56 File Offset: 0x00015C56
		public float AxisTorusHoverEps
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000389 RID: 905
		// (get) Token: 0x06000ABE RID: 2750 RVA: 0x00017A5D File Offset: 0x00015C5D
		public float CamLookLineHoverEps
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700038A RID: 906
		// (get) Token: 0x06000ABF RID: 2751 RVA: 0x00017A64 File Offset: 0x00015C64
		public float CamLookThickHoverEps
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700038B RID: 907
		// (get) Token: 0x06000AC0 RID: 2752 RVA: 0x00017A6B File Offset: 0x00015C6B
		public bool CanHoverCulledPixels
		{
			get
			{
				return false;
			}
		}

		// Token: 0x1700038C RID: 908
		// (get) Token: 0x06000AC1 RID: 2753 RVA: 0x0001FB0C File Offset: 0x0001DD0C
		public GizmoSnapMode SnapMode
		{
			get
			{
				return GizmoSnapMode.Relative;
			}
		}

		// Token: 0x1700038D RID: 909
		// (get) Token: 0x06000AC2 RID: 2754 RVA: 0x00017A6E File Offset: 0x00015C6E
		public float XSnapStep
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700038E RID: 910
		// (get) Token: 0x06000AC3 RID: 2755 RVA: 0x00017A75 File Offset: 0x00015C75
		public float YSnapStep
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700038F RID: 911
		// (get) Token: 0x06000AC4 RID: 2756 RVA: 0x00017A7C File Offset: 0x00015C7C
		public float ZSnapStep
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000390 RID: 912
		// (get) Token: 0x06000AC5 RID: 2757 RVA: 0x00017A83 File Offset: 0x00015C83
		public float CamRightSnapStep
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000391 RID: 913
		// (get) Token: 0x06000AC6 RID: 2758 RVA: 0x00017A8A File Offset: 0x00015C8A
		public float CamUpSnapStep
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000392 RID: 914
		// (get) Token: 0x06000AC7 RID: 2759 RVA: 0x00017A91 File Offset: 0x00015C91
		public float CamLookSnapStep
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000393 RID: 915
		// (get) Token: 0x06000AC8 RID: 2760 RVA: 0x00017A98 File Offset: 0x00015C98
		public float DragSensitivity
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x06000ACA RID: 2762 RVA: 0x00017AA7 File Offset: 0x00015CA7
		public void SetCanHoverCulledPixels(bool canHover)
		{
		}

		// Token: 0x06000ACB RID: 2763 RVA: 0x00017AA9 File Offset: 0x00015CA9
		public void SetAxisLineHoverEps(float eps)
		{
		}

		// Token: 0x06000ACC RID: 2764 RVA: 0x00017AAB File Offset: 0x00015CAB
		public void SetAxisTorusHoverEps(float eps)
		{
		}

		// Token: 0x06000ACD RID: 2765 RVA: 0x00017AAD File Offset: 0x00015CAD
		public void SetCamLookLineHoverEps(float eps)
		{
		}

		// Token: 0x06000ACE RID: 2766 RVA: 0x00017AAF File Offset: 0x00015CAF
		public void SetCamLookThickHoverEps(float eps)
		{
		}

		// Token: 0x06000ACF RID: 2767 RVA: 0x00017AB1 File Offset: 0x00015CB1
		public void SetAxisSnapStep(int axisIndex, float snapStep)
		{
		}

		// Token: 0x06000AD0 RID: 2768 RVA: 0x00017AB3 File Offset: 0x00015CB3
		public void SetCamRightSnapStep(float snapStep)
		{
		}

		// Token: 0x06000AD1 RID: 2769 RVA: 0x00017AB5 File Offset: 0x00015CB5
		public void SetCamUpSnapStep(float snapStep)
		{
		}

		// Token: 0x06000AD2 RID: 2770 RVA: 0x00017AB7 File Offset: 0x00015CB7
		public void SetCamLookSnapStep(float snapStep)
		{
		}

		// Token: 0x06000AD3 RID: 2771 RVA: 0x00017AB9 File Offset: 0x00015CB9
		public void SetSnapMode(GizmoSnapMode snapMode)
		{
		}

		// Token: 0x06000AD4 RID: 2772 RVA: 0x00017ABB File Offset: 0x00015CBB
		public void SetDragSensitivity(float sensitivity)
		{
		}

		// Token: 0x06000AD5 RID: 2773 RVA: 0x00017ABD File Offset: 0x00015CBD
		public void ConnectSliderSettings(GizmoPlaneSlider3D slider, int axisIndex)
		{
		}

		// Token: 0x06000AD6 RID: 2774 RVA: 0x00017ABF File Offset: 0x00015CBF
		public void ConnectCamLookSliderSettings(GizmoPlaneSlider2D slider)
		{
		}

		// Token: 0x0400041B RID: 1051
		private float _camRightSnapStep;

		// Token: 0x0400041C RID: 1052
		private float _camUpSnapStep;

		// Token: 0x0400041D RID: 1053
		private GizmoPlaneSlider3DSettings[] _sliderSettings;

		// Token: 0x0400041E RID: 1054
		private GizmoPlaneSlider2DSettings _camLookSliderSettings;
	}
}
