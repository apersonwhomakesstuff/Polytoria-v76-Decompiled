using System;

namespace RLD
{
	// Token: 0x020000E9 RID: 233
	[Serializable]
	public class ScaleGizmoSettings3D : Settings
	{
		// Token: 0x170003C7 RID: 967
		// (get) Token: 0x06000B5D RID: 2909 RVA: 0x00017C5B File Offset: 0x00015E5B
		public float LineSliderHoverEps
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x170003C8 RID: 968
		// (get) Token: 0x06000B5E RID: 2910 RVA: 0x00017C62 File Offset: 0x00015E62
		public float BoxSliderHoverEps
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x170003C9 RID: 969
		// (get) Token: 0x06000B5F RID: 2911 RVA: 0x00017C69 File Offset: 0x00015E69
		public float CylinderSliderHoverEps
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x170003CA RID: 970
		// (get) Token: 0x06000B60 RID: 2912 RVA: 0x00017C70 File Offset: 0x00015E70
		public float XSnapStep
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x170003CB RID: 971
		// (get) Token: 0x06000B61 RID: 2913 RVA: 0x00017C77 File Offset: 0x00015E77
		public float YSnapStep
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x170003CC RID: 972
		// (get) Token: 0x06000B62 RID: 2914 RVA: 0x00017C7E File Offset: 0x00015E7E
		public float ZSnapStep
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x170003CD RID: 973
		// (get) Token: 0x06000B63 RID: 2915 RVA: 0x00017C85 File Offset: 0x00015E85
		public float XYSnapStep
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x170003CE RID: 974
		// (get) Token: 0x06000B64 RID: 2916 RVA: 0x00017C8C File Offset: 0x00015E8C
		public float YZSnapStep
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x170003CF RID: 975
		// (get) Token: 0x06000B65 RID: 2917 RVA: 0x00017C93 File Offset: 0x00015E93
		public float ZXSnapStep
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x170003D0 RID: 976
		// (get) Token: 0x06000B66 RID: 2918 RVA: 0x00017C9A File Offset: 0x00015E9A
		public float UniformSnapStep
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x170003D1 RID: 977
		// (get) Token: 0x06000B67 RID: 2919 RVA: 0x00017CA1 File Offset: 0x00015EA1
		public float DragSensitivity
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x06000B69 RID: 2921 RVA: 0x00017CB0 File Offset: 0x00015EB0
		public void SetLineSliderHoverEps(float eps)
		{
		}

		// Token: 0x06000B6A RID: 2922 RVA: 0x00017CB2 File Offset: 0x00015EB2
		public void SetBoxSliderHoverEps(float eps)
		{
		}

		// Token: 0x06000B6B RID: 2923 RVA: 0x00017CB4 File Offset: 0x00015EB4
		public void SetCylinderSliderHoverEps(float eps)
		{
		}

		// Token: 0x06000B6C RID: 2924 RVA: 0x00017CB6 File Offset: 0x00015EB6
		public void SetXSnapStep(float snapStep)
		{
		}

		// Token: 0x06000B6D RID: 2925 RVA: 0x00017CB8 File Offset: 0x00015EB8
		public void SetYSnapStep(float snapStep)
		{
		}

		// Token: 0x06000B6E RID: 2926 RVA: 0x00017CBA File Offset: 0x00015EBA
		public void SetZSnapStep(float snapStep)
		{
		}

		// Token: 0x06000B6F RID: 2927 RVA: 0x00017CBC File Offset: 0x00015EBC
		public void SetXYSnapStep(float snapStep)
		{
		}

		// Token: 0x06000B70 RID: 2928 RVA: 0x00017CBE File Offset: 0x00015EBE
		public void SetYZSnapStep(float snapStep)
		{
		}

		// Token: 0x06000B71 RID: 2929 RVA: 0x00017CC0 File Offset: 0x00015EC0
		public void SetZXSnapStep(float snapStep)
		{
		}

		// Token: 0x06000B72 RID: 2930 RVA: 0x00017CC2 File Offset: 0x00015EC2
		public void SetUniformScaleSnapStep(float snapStep)
		{
		}

		// Token: 0x06000B73 RID: 2931 RVA: 0x00017CC4 File Offset: 0x00015EC4
		public void SetDragSensitivity(float sensitivity)
		{
		}

		// Token: 0x06000B74 RID: 2932 RVA: 0x00017CC6 File Offset: 0x00015EC6
		public void ConnectSliderSettings(GizmoLineSlider3D slider, int axisIndex, AxisSign axisSign)
		{
		}

		// Token: 0x06000B75 RID: 2933 RVA: 0x00017CC8 File Offset: 0x00015EC8
		public void ConnectDblSliderSettings(GizmoPlaneSlider3D dblSlider, PlaneId planeId)
		{
		}

		// Token: 0x06000B76 RID: 2934 RVA: 0x00017CCA File Offset: 0x00015ECA
		private GizmoLineSlider3DSettings GetSglSliderSettings(int axisIndex, AxisSign axisSign)
		{
			return null;
		}

		// Token: 0x06000B77 RID: 2935 RVA: 0x00017CCD File Offset: 0x00015ECD
		private GizmoPlaneSlider3DSettings GetDblSliderSettings(PlaneId planeId)
		{
			return null;
		}

		// Token: 0x04000441 RID: 1089
		private float _uniformSnapStep;

		// Token: 0x04000442 RID: 1090
		private GizmoLineSlider3DSettings[] _sglSliderSettings;

		// Token: 0x04000443 RID: 1091
		private GizmoPlaneSlider3DSettings[] _dblSliderSettings;
	}
}
