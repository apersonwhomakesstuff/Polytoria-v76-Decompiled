using System;
using System.Collections.Generic;
using UnityEngine;

namespace RLD
{
	// Token: 0x020000E8 RID: 232
	[Serializable]
	public class ScaleGizmoLookAndFeel3D : Settings
	{
		// Token: 0x1700039F RID: 927
		// (get) Token: 0x06000AF8 RID: 2808 RVA: 0x00017B22 File Offset: 0x00015D22
		public float Scale
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x170003A0 RID: 928
		// (get) Token: 0x06000AF9 RID: 2809 RVA: 0x00017B29 File Offset: 0x00015D29
		public bool UseZoomFactor
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170003A1 RID: 929
		// (get) Token: 0x06000AFA RID: 2810 RVA: 0x00017B2C File Offset: 0x00015D2C
		public float SliderLength
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x170003A2 RID: 930
		// (get) Token: 0x06000AFB RID: 2811 RVA: 0x00017B33 File Offset: 0x00015D33
		public float BoxSliderHeight
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x170003A3 RID: 931
		// (get) Token: 0x06000AFC RID: 2812 RVA: 0x00017B3A File Offset: 0x00015D3A
		public float BoxSliderDepth
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x170003A4 RID: 932
		// (get) Token: 0x06000AFD RID: 2813 RVA: 0x00017B41 File Offset: 0x00015D41
		public float CylinderSliderRadius
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x170003A5 RID: 933
		// (get) Token: 0x06000AFE RID: 2814 RVA: 0x00017B48 File Offset: 0x00015D48
		public float SliderBoxCapWidth
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x170003A6 RID: 934
		// (get) Token: 0x06000AFF RID: 2815 RVA: 0x00017B4F File Offset: 0x00015D4F
		public float SliderBoxCapHeight
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x170003A7 RID: 935
		// (get) Token: 0x06000B00 RID: 2816 RVA: 0x00017B56 File Offset: 0x00015D56
		public float SliderBoxCapDepth
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x170003A8 RID: 936
		// (get) Token: 0x06000B01 RID: 2817 RVA: 0x00017B5D File Offset: 0x00015D5D
		public float SliderConeCapHeight
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x170003A9 RID: 937
		// (get) Token: 0x06000B02 RID: 2818 RVA: 0x00017B64 File Offset: 0x00015D64
		public float SliderConeCapBaseRadius
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x170003AA RID: 938
		// (get) Token: 0x06000B03 RID: 2819 RVA: 0x00017B6B File Offset: 0x00015D6B
		public float SliderPyramidCapWidth
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x170003AB RID: 939
		// (get) Token: 0x06000B04 RID: 2820 RVA: 0x00017B72 File Offset: 0x00015D72
		public float SliderPyramidCapHeight
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x170003AC RID: 940
		// (get) Token: 0x06000B05 RID: 2821 RVA: 0x00017B79 File Offset: 0x00015D79
		public float SliderPyramidCapDepth
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x170003AD RID: 941
		// (get) Token: 0x06000B06 RID: 2822 RVA: 0x00017B80 File Offset: 0x00015D80
		public float SliderTriPrismCapWidth
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x170003AE RID: 942
		// (get) Token: 0x06000B07 RID: 2823 RVA: 0x00017B87 File Offset: 0x00015D87
		public float SliderTriPrismCapHeight
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x170003AF RID: 943
		// (get) Token: 0x06000B08 RID: 2824 RVA: 0x00017B8E File Offset: 0x00015D8E
		public float SliderTriPrismCapDepth
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x170003B0 RID: 944
		// (get) Token: 0x06000B09 RID: 2825 RVA: 0x00017B95 File Offset: 0x00015D95
		public float SliderSphereCapRadius
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x170003B1 RID: 945
		// (get) Token: 0x06000B0A RID: 2826 RVA: 0x0001FB3C File Offset: 0x0001DD3C
		public GizmoFillMode3D SliderFillMode
		{
			get
			{
				return GizmoFillMode3D.Filled;
			}
		}

		// Token: 0x170003B2 RID: 946
		// (get) Token: 0x06000B0B RID: 2827 RVA: 0x0001FB54 File Offset: 0x0001DD54
		public GizmoFillMode3D SliderCapFillMode
		{
			get
			{
				return GizmoFillMode3D.Filled;
			}
		}

		// Token: 0x170003B3 RID: 947
		// (get) Token: 0x06000B0C RID: 2828 RVA: 0x0001FB6C File Offset: 0x0001DD6C
		public GizmoCap3DType SliderCapType
		{
			get
			{
				return GizmoCap3DType.Cone;
			}
		}

		// Token: 0x170003B4 RID: 948
		// (get) Token: 0x06000B0D RID: 2829 RVA: 0x0001FB84 File Offset: 0x0001DD84
		public GizmoShadeMode SliderShadeMode
		{
			get
			{
				return GizmoShadeMode.Lit;
			}
		}

		// Token: 0x170003B5 RID: 949
		// (get) Token: 0x06000B0E RID: 2830 RVA: 0x0001FB9C File Offset: 0x0001DD9C
		public GizmoShadeMode SliderCapShadeMode
		{
			get
			{
				return GizmoShadeMode.Lit;
			}
		}

		// Token: 0x170003B6 RID: 950
		// (get) Token: 0x06000B0F RID: 2831 RVA: 0x0001FBB4 File Offset: 0x0001DDB4
		public GizmoLine3DType SliderLineType
		{
			get
			{
				return GizmoLine3DType.Thin;
			}
		}

		// Token: 0x170003B7 RID: 951
		// (get) Token: 0x06000B10 RID: 2832 RVA: 0x0001FBCC File Offset: 0x0001DDCC
		public Color XColor
		{
			get
			{
				return default(Color);
			}
		}

		// Token: 0x170003B8 RID: 952
		// (get) Token: 0x06000B11 RID: 2833 RVA: 0x0001FBE4 File Offset: 0x0001DDE4
		public Color YColor
		{
			get
			{
				return default(Color);
			}
		}

		// Token: 0x170003B9 RID: 953
		// (get) Token: 0x06000B12 RID: 2834 RVA: 0x0001FBFC File Offset: 0x0001DDFC
		public Color ZColor
		{
			get
			{
				return default(Color);
			}
		}

		// Token: 0x170003BA RID: 954
		// (get) Token: 0x06000B13 RID: 2835 RVA: 0x00017B9C File Offset: 0x00015D9C
		public float DblSliderSize
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x170003BB RID: 955
		// (get) Token: 0x06000B14 RID: 2836 RVA: 0x00017BA3 File Offset: 0x00015DA3
		public float DblSliderFillAlpha
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x170003BC RID: 956
		// (get) Token: 0x06000B15 RID: 2837 RVA: 0x00017BAA File Offset: 0x00015DAA
		public float MidCapBoxWidth
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x170003BD RID: 957
		// (get) Token: 0x06000B16 RID: 2838 RVA: 0x00017BB1 File Offset: 0x00015DB1
		public float MidCapBoxHeight
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x170003BE RID: 958
		// (get) Token: 0x06000B17 RID: 2839 RVA: 0x00017BB8 File Offset: 0x00015DB8
		public float MidCapBoxDepth
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x170003BF RID: 959
		// (get) Token: 0x06000B18 RID: 2840 RVA: 0x00017BBF File Offset: 0x00015DBF
		public float MidCapSphereRadius
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x170003C0 RID: 960
		// (get) Token: 0x06000B19 RID: 2841 RVA: 0x0001FC14 File Offset: 0x0001DE14
		public GizmoCap3DType MidCapType
		{
			get
			{
				return GizmoCap3DType.Cone;
			}
		}

		// Token: 0x170003C1 RID: 961
		// (get) Token: 0x06000B1A RID: 2842 RVA: 0x0001FC2C File Offset: 0x0001DE2C
		public GizmoShadeMode MidCapShadeMode
		{
			get
			{
				return GizmoShadeMode.Lit;
			}
		}

		// Token: 0x170003C2 RID: 962
		// (get) Token: 0x06000B1B RID: 2843 RVA: 0x0001FC44 File Offset: 0x0001DE44
		public GizmoFillMode3D MidCapFillMode
		{
			get
			{
				return GizmoFillMode3D.Filled;
			}
		}

		// Token: 0x170003C3 RID: 963
		// (get) Token: 0x06000B1C RID: 2844 RVA: 0x0001FC5C File Offset: 0x0001DE5C
		public Color MidCapColor
		{
			get
			{
				return default(Color);
			}
		}

		// Token: 0x170003C4 RID: 964
		// (get) Token: 0x06000B1D RID: 2845 RVA: 0x0001FC74 File Offset: 0x0001DE74
		public Color HoveredColor
		{
			get
			{
				return default(Color);
			}
		}

		// Token: 0x170003C5 RID: 965
		// (get) Token: 0x06000B1E RID: 2846 RVA: 0x00017BC6 File Offset: 0x00015DC6
		public bool IsScaleGuideVisible
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170003C6 RID: 966
		// (get) Token: 0x06000B1F RID: 2847 RVA: 0x00017BC9 File Offset: 0x00015DC9
		public float ScaleGuideAxisLength
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x06000B21 RID: 2849 RVA: 0x00017BD8 File Offset: 0x00015DD8
		public void SetScaleGuideVisible(bool isVisible)
		{
		}

		// Token: 0x06000B22 RID: 2850 RVA: 0x00017BDA File Offset: 0x00015DDA
		public bool IsDblSliderVisible(PlaneId planeId)
		{
			return false;
		}

		// Token: 0x06000B23 RID: 2851 RVA: 0x00017BDD File Offset: 0x00015DDD
		public void SetDblSliderVisible(PlaneId planeId, bool isVisible)
		{
		}

		// Token: 0x06000B24 RID: 2852 RVA: 0x00017BDF File Offset: 0x00015DDF
		public bool IsSliderVisible(int axisIndex, AxisSign axisSign)
		{
			return false;
		}

		// Token: 0x06000B25 RID: 2853 RVA: 0x00017BE2 File Offset: 0x00015DE2
		public bool IsSliderCapVisible(int axisIndex, AxisSign axisSign)
		{
			return false;
		}

		// Token: 0x06000B26 RID: 2854 RVA: 0x00017BE5 File Offset: 0x00015DE5
		public bool IsPositiveSliderVisible(int axisIndex)
		{
			return false;
		}

		// Token: 0x06000B27 RID: 2855 RVA: 0x00017BE8 File Offset: 0x00015DE8
		public bool IsPositiveSliderCapVisible(int axisIndex)
		{
			return false;
		}

		// Token: 0x06000B28 RID: 2856 RVA: 0x00017BEB File Offset: 0x00015DEB
		public bool IsNegativeSliderVisible(int axisIndex)
		{
			return false;
		}

		// Token: 0x06000B29 RID: 2857 RVA: 0x00017BEE File Offset: 0x00015DEE
		public bool IsNegativeSliderCapVisible(int axisIndex)
		{
			return false;
		}

		// Token: 0x06000B2A RID: 2858 RVA: 0x00017BF1 File Offset: 0x00015DF1
		public void SetSliderVisible(int axisIndex, AxisSign axisSign, bool isVisible)
		{
		}

		// Token: 0x06000B2B RID: 2859 RVA: 0x00017BF3 File Offset: 0x00015DF3
		public void SetSliderCapVisible(int axisIndex, AxisSign axisSign, bool isVisible)
		{
		}

		// Token: 0x06000B2C RID: 2860 RVA: 0x00017BF5 File Offset: 0x00015DF5
		public void SetPositiveSliderVisible(int axisIndex, bool isVisible)
		{
		}

		// Token: 0x06000B2D RID: 2861 RVA: 0x00017BF7 File Offset: 0x00015DF7
		public void SetPositiveCapVisible(int axisIndex, bool isVisible)
		{
		}

		// Token: 0x06000B2E RID: 2862 RVA: 0x00017BF9 File Offset: 0x00015DF9
		public void SetNegativeSliderVisible(int axisIndex, bool isVisible)
		{
		}

		// Token: 0x06000B2F RID: 2863 RVA: 0x00017BFB File Offset: 0x00015DFB
		public void SetNegativeCapVisible(int axisIndex, bool isVisible)
		{
		}

		// Token: 0x06000B30 RID: 2864 RVA: 0x00017BFD File Offset: 0x00015DFD
		public void SetSliderLength(float axisLength)
		{
		}

		// Token: 0x06000B31 RID: 2865 RVA: 0x00017BFF File Offset: 0x00015DFF
		public void SetSliderLineType(GizmoLine3DType lineType)
		{
		}

		// Token: 0x06000B32 RID: 2866 RVA: 0x00017C01 File Offset: 0x00015E01
		public void SetBoxSliderHeight(float height)
		{
		}

		// Token: 0x06000B33 RID: 2867 RVA: 0x00017C03 File Offset: 0x00015E03
		public void SetBoxSliderDepth(float depth)
		{
		}

		// Token: 0x06000B34 RID: 2868 RVA: 0x00017C05 File Offset: 0x00015E05
		public void SetCylinderSliderRadius(float radius)
		{
		}

		// Token: 0x06000B35 RID: 2869 RVA: 0x00017C07 File Offset: 0x00015E07
		public void SetScale(float scale)
		{
		}

		// Token: 0x06000B36 RID: 2870 RVA: 0x00017C09 File Offset: 0x00015E09
		public void SetUseZoomFactor(bool useZoomFactor)
		{
		}

		// Token: 0x06000B37 RID: 2871 RVA: 0x00017C0B File Offset: 0x00015E0B
		public void SetScaleGuideAxisLength(float length)
		{
		}

		// Token: 0x06000B38 RID: 2872 RVA: 0x00017C0D File Offset: 0x00015E0D
		public void SetAxisColor(int axisIndex, Color color)
		{
		}

		// Token: 0x06000B39 RID: 2873 RVA: 0x00017C0F File Offset: 0x00015E0F
		public void SetDblSliderFillAlpha(float alpha)
		{
		}

		// Token: 0x06000B3A RID: 2874 RVA: 0x00017C11 File Offset: 0x00015E11
		public void SetMidCapColor(Color color)
		{
		}

		// Token: 0x06000B3B RID: 2875 RVA: 0x00017C13 File Offset: 0x00015E13
		public void SetHoveredColor(Color hoveredColor)
		{
		}

		// Token: 0x06000B3C RID: 2876 RVA: 0x00017C15 File Offset: 0x00015E15
		public void SetSliderShadeMode(GizmoShadeMode shadeMode)
		{
		}

		// Token: 0x06000B3D RID: 2877 RVA: 0x00017C17 File Offset: 0x00015E17
		public void SetSliderCapShadeMode(GizmoShadeMode shadeMode)
		{
		}

		// Token: 0x06000B3E RID: 2878 RVA: 0x00017C19 File Offset: 0x00015E19
		public void SetMidCapShadeMode(GizmoShadeMode shadeMode)
		{
		}

		// Token: 0x06000B3F RID: 2879 RVA: 0x00017C1B File Offset: 0x00015E1B
		public void SetSliderCapType(GizmoCap3DType capType)
		{
		}

		// Token: 0x06000B40 RID: 2880 RVA: 0x00017C1D File Offset: 0x00015E1D
		public void SetMidCapType(GizmoCap3DType capType)
		{
		}

		// Token: 0x06000B41 RID: 2881 RVA: 0x00017C1F File Offset: 0x00015E1F
		public bool IsMidCapTypeAllowed(GizmoCap3DType capType)
		{
			return false;
		}

		// Token: 0x06000B42 RID: 2882 RVA: 0x00017C22 File Offset: 0x00015E22
		public List<Enum> GetAllowedMidCapTypes()
		{
			return null;
		}

		// Token: 0x06000B43 RID: 2883 RVA: 0x00017C25 File Offset: 0x00015E25
		public void SetSliderFillMode(GizmoFillMode3D fillMode)
		{
		}

		// Token: 0x06000B44 RID: 2884 RVA: 0x00017C27 File Offset: 0x00015E27
		public void SetSliderCapFillMode(GizmoFillMode3D fillMode)
		{
		}

		// Token: 0x06000B45 RID: 2885 RVA: 0x00017C29 File Offset: 0x00015E29
		public void SetMidCapFillMode(GizmoFillMode3D fillMode)
		{
		}

		// Token: 0x06000B46 RID: 2886 RVA: 0x00017C2B File Offset: 0x00015E2B
		public void SetSliderBoxCapWidth(float width)
		{
		}

		// Token: 0x06000B47 RID: 2887 RVA: 0x00017C2D File Offset: 0x00015E2D
		public void SetSliderBoxCapHeight(float height)
		{
		}

		// Token: 0x06000B48 RID: 2888 RVA: 0x00017C2F File Offset: 0x00015E2F
		public void SetSliderBoxCapDepth(float depth)
		{
		}

		// Token: 0x06000B49 RID: 2889 RVA: 0x00017C31 File Offset: 0x00015E31
		public void SetSliderConeCapHeight(float height)
		{
		}

		// Token: 0x06000B4A RID: 2890 RVA: 0x00017C33 File Offset: 0x00015E33
		public void SetSliderConeCapBaseRadius(float radius)
		{
		}

		// Token: 0x06000B4B RID: 2891 RVA: 0x00017C35 File Offset: 0x00015E35
		public void SetSliderPyramidCapWidth(float width)
		{
		}

		// Token: 0x06000B4C RID: 2892 RVA: 0x00017C37 File Offset: 0x00015E37
		public void SetSliderPyramidCapHeight(float height)
		{
		}

		// Token: 0x06000B4D RID: 2893 RVA: 0x00017C39 File Offset: 0x00015E39
		public void SetSliderPyramidCapDepth(float depth)
		{
		}

		// Token: 0x06000B4E RID: 2894 RVA: 0x00017C3B File Offset: 0x00015E3B
		public void SetSliderTriPrismCapWidth(float width)
		{
		}

		// Token: 0x06000B4F RID: 2895 RVA: 0x00017C3D File Offset: 0x00015E3D
		public void SetSliderTriPrismCapHeight(float height)
		{
		}

		// Token: 0x06000B50 RID: 2896 RVA: 0x00017C3F File Offset: 0x00015E3F
		public void SetSliderTriPrismCapDepth(float depth)
		{
		}

		// Token: 0x06000B51 RID: 2897 RVA: 0x00017C41 File Offset: 0x00015E41
		public void SetSliderSphereCapRadius(float radius)
		{
		}

		// Token: 0x06000B52 RID: 2898 RVA: 0x00017C43 File Offset: 0x00015E43
		public void SetMidCapBoxWidth(float width)
		{
		}

		// Token: 0x06000B53 RID: 2899 RVA: 0x00017C45 File Offset: 0x00015E45
		public void SetMidCapBoxHeight(float height)
		{
		}

		// Token: 0x06000B54 RID: 2900 RVA: 0x00017C47 File Offset: 0x00015E47
		public void SetMidCapBoxDepth(float depth)
		{
		}

		// Token: 0x06000B55 RID: 2901 RVA: 0x00017C49 File Offset: 0x00015E49
		public void SetMidCapSphereRadius(float radius)
		{
		}

		// Token: 0x06000B56 RID: 2902 RVA: 0x00017C4B File Offset: 0x00015E4B
		public void SetDblSliderSize(float size)
		{
		}

		// Token: 0x06000B57 RID: 2903 RVA: 0x00017C4D File Offset: 0x00015E4D
		public void ConnectSliderLookAndFeel(GizmoLineSlider3D slider, int axisIndex, AxisSign axisSign)
		{
		}

		// Token: 0x06000B58 RID: 2904 RVA: 0x00017C4F File Offset: 0x00015E4F
		public void ConnectMidCapLookAndFeel(GizmoCap3D cap)
		{
		}

		// Token: 0x06000B59 RID: 2905 RVA: 0x00017C51 File Offset: 0x00015E51
		public void ConnectDblSliderLookAndFeel(GizmoPlaneSlider3D slider, PlaneId planeId)
		{
		}

		// Token: 0x06000B5A RID: 2906 RVA: 0x00017C53 File Offset: 0x00015E53
		public void ConnectGizmoScaleGuideLookAndFeel(GizmoScaleGuide scaleGuide)
		{
		}

		// Token: 0x06000B5B RID: 2907 RVA: 0x00017C55 File Offset: 0x00015E55
		private GizmoLineSlider3DLookAndFeel GetSglSliderLookAndFeel(int axisIndex, AxisSign axisSign)
		{
			return null;
		}

		// Token: 0x06000B5C RID: 2908 RVA: 0x00017C58 File Offset: 0x00015E58
		private GizmoPlaneSlider3DLookAndFeel GetDblSliderLookAndFeel(PlaneId planeId)
		{
			return null;
		}

		// Token: 0x04000439 RID: 1081
		private GizmoCap3DLookAndFeel _midCapLookAndFeel;

		// Token: 0x0400043A RID: 1082
		private bool[] _sglSliderVis;

		// Token: 0x0400043B RID: 1083
		private bool[] _sglSliderCapVis;

		// Token: 0x0400043C RID: 1084
		private bool[] _dblSliderVis;

		// Token: 0x0400043D RID: 1085
		private GizmoScaleGuideLookAndFeel _scaleGuideLookAndFeel;

		// Token: 0x0400043E RID: 1086
		private bool _isScaleGuideVisible;

		// Token: 0x0400043F RID: 1087
		private GizmoLineSlider3DLookAndFeel[] _sglSlidersLookAndFeel;

		// Token: 0x04000440 RID: 1088
		private GizmoPlaneSlider3DLookAndFeel[] _dblSlidersLookAndFeel;
	}
}
