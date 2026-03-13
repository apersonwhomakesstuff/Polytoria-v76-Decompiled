using System;
using System.Collections.Generic;
using UnityEngine;

namespace RLD
{
	// Token: 0x020000ED RID: 237
	[Serializable]
	public class UniversalGizmoLookAndFeel3D : Settings
	{
		// Token: 0x170003FF RID: 1023
		// (get) Token: 0x06000C02 RID: 3074 RVA: 0x00017E46 File Offset: 0x00016046
		public float MvScale
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000400 RID: 1024
		// (get) Token: 0x06000C03 RID: 3075 RVA: 0x00017E4D File Offset: 0x0001604D
		public bool MvUseZoomFactor
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000401 RID: 1025
		// (get) Token: 0x06000C04 RID: 3076 RVA: 0x00017E50 File Offset: 0x00016050
		public float MvSliderLength
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000402 RID: 1026
		// (get) Token: 0x06000C05 RID: 3077 RVA: 0x00017E57 File Offset: 0x00016057
		public float MvBoxSliderHeight
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000403 RID: 1027
		// (get) Token: 0x06000C06 RID: 3078 RVA: 0x00017E5E File Offset: 0x0001605E
		public float MvBoxSliderDepth
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000404 RID: 1028
		// (get) Token: 0x06000C07 RID: 3079 RVA: 0x00017E65 File Offset: 0x00016065
		public float MvCylinderSliderRadius
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000405 RID: 1029
		// (get) Token: 0x06000C08 RID: 3080 RVA: 0x00017E6C File Offset: 0x0001606C
		public float MvSliderBoxCapWidth
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000406 RID: 1030
		// (get) Token: 0x06000C09 RID: 3081 RVA: 0x00017E73 File Offset: 0x00016073
		public float MvSliderBoxCapHeight
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000407 RID: 1031
		// (get) Token: 0x06000C0A RID: 3082 RVA: 0x00017E7A File Offset: 0x0001607A
		public float MvSliderBoxCapDepth
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000408 RID: 1032
		// (get) Token: 0x06000C0B RID: 3083 RVA: 0x00017E81 File Offset: 0x00016081
		public float MvSliderConeCapHeight
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000409 RID: 1033
		// (get) Token: 0x06000C0C RID: 3084 RVA: 0x00017E88 File Offset: 0x00016088
		public float MvSliderConeCapBaseRadius
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700040A RID: 1034
		// (get) Token: 0x06000C0D RID: 3085 RVA: 0x00017E8F File Offset: 0x0001608F
		public float MvSliderPyramidCapWidth
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700040B RID: 1035
		// (get) Token: 0x06000C0E RID: 3086 RVA: 0x00017E96 File Offset: 0x00016096
		public float MvSliderPyramidCapHeight
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700040C RID: 1036
		// (get) Token: 0x06000C0F RID: 3087 RVA: 0x00017E9D File Offset: 0x0001609D
		public float MvSliderPyramidCapDepth
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700040D RID: 1037
		// (get) Token: 0x06000C10 RID: 3088 RVA: 0x00017EA4 File Offset: 0x000160A4
		public float MvSliderTriPrismCapWidth
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700040E RID: 1038
		// (get) Token: 0x06000C11 RID: 3089 RVA: 0x00017EAB File Offset: 0x000160AB
		public float MvSliderTriPrismCapHeight
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700040F RID: 1039
		// (get) Token: 0x06000C12 RID: 3090 RVA: 0x00017EB2 File Offset: 0x000160B2
		public float MvSliderTriPrismCapDepth
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000410 RID: 1040
		// (get) Token: 0x06000C13 RID: 3091 RVA: 0x00017EB9 File Offset: 0x000160B9
		public float MvSliderSphereCapRadius
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000411 RID: 1041
		// (get) Token: 0x06000C14 RID: 3092 RVA: 0x0001FE3C File Offset: 0x0001E03C
		public GizmoFillMode3D MvSliderFillMode
		{
			get
			{
				return GizmoFillMode3D.Filled;
			}
		}

		// Token: 0x17000412 RID: 1042
		// (get) Token: 0x06000C15 RID: 3093 RVA: 0x0001FE54 File Offset: 0x0001E054
		public GizmoFillMode3D MvSliderCapFillMode
		{
			get
			{
				return GizmoFillMode3D.Filled;
			}
		}

		// Token: 0x17000413 RID: 1043
		// (get) Token: 0x06000C16 RID: 3094 RVA: 0x0001FE6C File Offset: 0x0001E06C
		public GizmoCap3DType MvSliderCapType
		{
			get
			{
				return GizmoCap3DType.Cone;
			}
		}

		// Token: 0x17000414 RID: 1044
		// (get) Token: 0x06000C17 RID: 3095 RVA: 0x0001FE84 File Offset: 0x0001E084
		public GizmoShadeMode MvSliderShadeMode
		{
			get
			{
				return GizmoShadeMode.Lit;
			}
		}

		// Token: 0x17000415 RID: 1045
		// (get) Token: 0x06000C18 RID: 3096 RVA: 0x0001FE9C File Offset: 0x0001E09C
		public GizmoShadeMode MvSliderCapShadeMode
		{
			get
			{
				return GizmoShadeMode.Lit;
			}
		}

		// Token: 0x17000416 RID: 1046
		// (get) Token: 0x06000C19 RID: 3097 RVA: 0x0001FEB4 File Offset: 0x0001E0B4
		public GizmoLine3DType MvSliderLineType
		{
			get
			{
				return GizmoLine3DType.Thin;
			}
		}

		// Token: 0x17000417 RID: 1047
		// (get) Token: 0x06000C1A RID: 3098 RVA: 0x0001FECC File Offset: 0x0001E0CC
		public Color MvPXColor
		{
			get
			{
				return default(Color);
			}
		}

		// Token: 0x17000418 RID: 1048
		// (get) Token: 0x06000C1B RID: 3099 RVA: 0x0001FEE4 File Offset: 0x0001E0E4
		public Color MvNXColor
		{
			get
			{
				return default(Color);
			}
		}

		// Token: 0x17000419 RID: 1049
		// (get) Token: 0x06000C1C RID: 3100 RVA: 0x0001FEFC File Offset: 0x0001E0FC
		public Color MvPYColor
		{
			get
			{
				return default(Color);
			}
		}

		// Token: 0x1700041A RID: 1050
		// (get) Token: 0x06000C1D RID: 3101 RVA: 0x0001FF14 File Offset: 0x0001E114
		public Color MvNYColor
		{
			get
			{
				return default(Color);
			}
		}

		// Token: 0x1700041B RID: 1051
		// (get) Token: 0x06000C1E RID: 3102 RVA: 0x0001FF2C File Offset: 0x0001E12C
		public Color MvPZColor
		{
			get
			{
				return default(Color);
			}
		}

		// Token: 0x1700041C RID: 1052
		// (get) Token: 0x06000C1F RID: 3103 RVA: 0x0001FF44 File Offset: 0x0001E144
		public Color MvNZColor
		{
			get
			{
				return default(Color);
			}
		}

		// Token: 0x1700041D RID: 1053
		// (get) Token: 0x06000C20 RID: 3104 RVA: 0x00017EC0 File Offset: 0x000160C0
		public float MvDblSliderSize
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700041E RID: 1054
		// (get) Token: 0x06000C21 RID: 3105 RVA: 0x00017EC7 File Offset: 0x000160C7
		public float MvDblSliderBorderBoxHeight
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700041F RID: 1055
		// (get) Token: 0x06000C22 RID: 3106 RVA: 0x00017ECE File Offset: 0x000160CE
		public float MvDblSliderBorderBoxDepth
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000420 RID: 1056
		// (get) Token: 0x06000C23 RID: 3107 RVA: 0x00017ED5 File Offset: 0x000160D5
		public float MvDblSliderFillAlpha
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000421 RID: 1057
		// (get) Token: 0x06000C24 RID: 3108 RVA: 0x0001FF5C File Offset: 0x0001E15C
		public GizmoShadeMode MvDblSliderBorderShadeMode
		{
			get
			{
				return GizmoShadeMode.Lit;
			}
		}

		// Token: 0x17000422 RID: 1058
		// (get) Token: 0x06000C25 RID: 3109 RVA: 0x0001FF74 File Offset: 0x0001E174
		public GizmoQuad3DBorderType MvDblSliderBorderType
		{
			get
			{
				return GizmoQuad3DBorderType.Thin;
			}
		}

		// Token: 0x17000423 RID: 1059
		// (get) Token: 0x06000C26 RID: 3110 RVA: 0x0001FF8C File Offset: 0x0001E18C
		public GizmoFillMode3D MvDblSliderBorderFillMode
		{
			get
			{
				return GizmoFillMode3D.Filled;
			}
		}

		// Token: 0x17000424 RID: 1060
		// (get) Token: 0x06000C27 RID: 3111 RVA: 0x00017EDC File Offset: 0x000160DC
		public float MvVertSnapCapQuadWidth
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000425 RID: 1061
		// (get) Token: 0x06000C28 RID: 3112 RVA: 0x00017EE3 File Offset: 0x000160E3
		public float MvVertSnapCapQuadHeight
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000426 RID: 1062
		// (get) Token: 0x06000C29 RID: 3113 RVA: 0x00017EEA File Offset: 0x000160EA
		public float MvVertSnapCapCircleRadius
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000427 RID: 1063
		// (get) Token: 0x06000C2A RID: 3114 RVA: 0x0001FFA4 File Offset: 0x0001E1A4
		public Color MvVertSnapCapColor
		{
			get
			{
				return default(Color);
			}
		}

		// Token: 0x17000428 RID: 1064
		// (get) Token: 0x06000C2B RID: 3115 RVA: 0x0001FFBC File Offset: 0x0001E1BC
		public Color MvVertSnapCapBorderColor
		{
			get
			{
				return default(Color);
			}
		}

		// Token: 0x17000429 RID: 1065
		// (get) Token: 0x06000C2C RID: 3116 RVA: 0x0001FFD4 File Offset: 0x0001E1D4
		public Color MvVertSnapCapHoveredColor
		{
			get
			{
				return default(Color);
			}
		}

		// Token: 0x1700042A RID: 1066
		// (get) Token: 0x06000C2D RID: 3117 RVA: 0x0001FFEC File Offset: 0x0001E1EC
		public Color MvVertSnapCapHoveredBorderColor
		{
			get
			{
				return default(Color);
			}
		}

		// Token: 0x1700042B RID: 1067
		// (get) Token: 0x06000C2E RID: 3118 RVA: 0x00020004 File Offset: 0x0001E204
		public GizmoFillMode2D MvVertSnapCapFillMode
		{
			get
			{
				return GizmoFillMode2D.Filled;
			}
		}

		// Token: 0x1700042C RID: 1068
		// (get) Token: 0x06000C2F RID: 3119 RVA: 0x0002001C File Offset: 0x0001E21C
		public GizmoCap2DType MvVertSnapCapType
		{
			get
			{
				return GizmoCap2DType.Quad;
			}
		}

		// Token: 0x1700042D RID: 1069
		// (get) Token: 0x06000C30 RID: 3120 RVA: 0x00020034 File Offset: 0x0001E234
		public Color MvHoveredColor
		{
			get
			{
				return default(Color);
			}
		}

		// Token: 0x1700042E RID: 1070
		// (get) Token: 0x06000C31 RID: 3121 RVA: 0x00017EF1 File Offset: 0x000160F1
		public float RtScale
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700042F RID: 1071
		// (get) Token: 0x06000C32 RID: 3122 RVA: 0x00017EF8 File Offset: 0x000160F8
		public float RtRadius
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000430 RID: 1072
		// (get) Token: 0x06000C33 RID: 3123 RVA: 0x00017EFF File Offset: 0x000160FF
		public bool RtUseZoomFactor
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000431 RID: 1073
		// (get) Token: 0x06000C34 RID: 3124 RVA: 0x0002004C File Offset: 0x0001E24C
		public Color RtXBorderColor
		{
			get
			{
				return default(Color);
			}
		}

		// Token: 0x17000432 RID: 1074
		// (get) Token: 0x06000C35 RID: 3125 RVA: 0x00020064 File Offset: 0x0001E264
		public Color RtYBorderColor
		{
			get
			{
				return default(Color);
			}
		}

		// Token: 0x17000433 RID: 1075
		// (get) Token: 0x06000C36 RID: 3126 RVA: 0x0002007C File Offset: 0x0001E27C
		public Color RtZBorderColor
		{
			get
			{
				return default(Color);
			}
		}

		// Token: 0x17000434 RID: 1076
		// (get) Token: 0x06000C37 RID: 3127 RVA: 0x00020094 File Offset: 0x0001E294
		public Color RtHoveredColor
		{
			get
			{
				return default(Color);
			}
		}

		// Token: 0x17000435 RID: 1077
		// (get) Token: 0x06000C38 RID: 3128 RVA: 0x00017F02 File Offset: 0x00016102
		public float RtAxisTorusThickness
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000436 RID: 1078
		// (get) Token: 0x06000C39 RID: 3129 RVA: 0x00017F09 File Offset: 0x00016109
		public float RtAxisCylTorusWidth
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000437 RID: 1079
		// (get) Token: 0x06000C3A RID: 3130 RVA: 0x00017F10 File Offset: 0x00016110
		public float RtAxisCylTorusHeight
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000438 RID: 1080
		// (get) Token: 0x06000C3B RID: 3131 RVA: 0x00017F17 File Offset: 0x00016117
		public float RtAxisCullAlphaScale
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000439 RID: 1081
		// (get) Token: 0x06000C3C RID: 3132 RVA: 0x000200AC File Offset: 0x0001E2AC
		public GizmoShadeMode RtShadeMode
		{
			get
			{
				return GizmoShadeMode.Lit;
			}
		}

		// Token: 0x1700043A RID: 1082
		// (get) Token: 0x06000C3D RID: 3133 RVA: 0x000200C4 File Offset: 0x0001E2C4
		public GizmoCircle3DBorderType RtAxisBorderType
		{
			get
			{
				return GizmoCircle3DBorderType.Thin;
			}
		}

		// Token: 0x1700043B RID: 1083
		// (get) Token: 0x06000C3E RID: 3134 RVA: 0x000200DC File Offset: 0x0001E2DC
		public GizmoFillMode3D RtAxisBorderFillMode
		{
			get
			{
				return GizmoFillMode3D.Filled;
			}
		}

		// Token: 0x1700043C RID: 1084
		// (get) Token: 0x06000C3F RID: 3135 RVA: 0x00017F1E File Offset: 0x0001611E
		public int RtNumAxisTorusWireAxialSlices
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x1700043D RID: 1085
		// (get) Token: 0x06000C40 RID: 3136 RVA: 0x000200F4 File Offset: 0x0001E2F4
		public Color RtRotationArcColor
		{
			get
			{
				return default(Color);
			}
		}

		// Token: 0x1700043E RID: 1086
		// (get) Token: 0x06000C41 RID: 3137 RVA: 0x0002010C File Offset: 0x0001E30C
		public Color RtRotationArcBorderColor
		{
			get
			{
				return default(Color);
			}
		}

		// Token: 0x1700043F RID: 1087
		// (get) Token: 0x06000C42 RID: 3138 RVA: 0x00017F21 File Offset: 0x00016121
		public bool RtUseShortestRotationArc
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000440 RID: 1088
		// (get) Token: 0x06000C43 RID: 3139 RVA: 0x00017F24 File Offset: 0x00016124
		public bool IsRtRotationArcVisible
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000441 RID: 1089
		// (get) Token: 0x06000C44 RID: 3140 RVA: 0x00020124 File Offset: 0x0001E324
		public Color RtMidCapColor
		{
			get
			{
				return default(Color);
			}
		}

		// Token: 0x17000442 RID: 1090
		// (get) Token: 0x06000C45 RID: 3141 RVA: 0x0002013C File Offset: 0x0001E33C
		public Color RtHoveredMidCapColor
		{
			get
			{
				return default(Color);
			}
		}

		// Token: 0x17000443 RID: 1091
		// (get) Token: 0x06000C46 RID: 3142 RVA: 0x00017F27 File Offset: 0x00016127
		public bool IsRtMidCapVisible
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000444 RID: 1092
		// (get) Token: 0x06000C47 RID: 3143 RVA: 0x00017F2A File Offset: 0x0001612A
		public bool IsRtMidCapBorderVisible
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000445 RID: 1093
		// (get) Token: 0x06000C48 RID: 3144 RVA: 0x00017F2D File Offset: 0x0001612D
		public float RtCamLookSliderRadiusOffset
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000446 RID: 1094
		// (get) Token: 0x06000C49 RID: 3145 RVA: 0x00020154 File Offset: 0x0001E354
		public Color RtCamLookSliderBorderColor
		{
			get
			{
				return default(Color);
			}
		}

		// Token: 0x17000447 RID: 1095
		// (get) Token: 0x06000C4A RID: 3146 RVA: 0x0002016C File Offset: 0x0001E36C
		public Color RtCamLookSliderHoveredBorderColor
		{
			get
			{
				return default(Color);
			}
		}

		// Token: 0x17000448 RID: 1096
		// (get) Token: 0x06000C4B RID: 3147 RVA: 0x00020184 File Offset: 0x0001E384
		public GizmoPolygon2DBorderType RtCamLookSliderPolyBorderType
		{
			get
			{
				return GizmoPolygon2DBorderType.Thin;
			}
		}

		// Token: 0x17000449 RID: 1097
		// (get) Token: 0x06000C4C RID: 3148 RVA: 0x00017F34 File Offset: 0x00016134
		public float RtCamLookSliderPolyBorderThickness
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700044A RID: 1098
		// (get) Token: 0x06000C4D RID: 3149 RVA: 0x00017F3B File Offset: 0x0001613B
		public bool IsRtCamLookSliderVisible
		{
			get
			{
				return false;
			}
		}

		// Token: 0x1700044B RID: 1099
		// (get) Token: 0x06000C4E RID: 3150 RVA: 0x00017F3E File Offset: 0x0001613E
		public float ScScale
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700044C RID: 1100
		// (get) Token: 0x06000C4F RID: 3151 RVA: 0x00017F45 File Offset: 0x00016145
		public bool ScUseZoomFactor
		{
			get
			{
				return false;
			}
		}

		// Token: 0x1700044D RID: 1101
		// (get) Token: 0x06000C50 RID: 3152 RVA: 0x00017F48 File Offset: 0x00016148
		public float ScSliderLength
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700044E RID: 1102
		// (get) Token: 0x06000C51 RID: 3153 RVA: 0x00017F4F File Offset: 0x0001614F
		public float ScBoxSliderHeight
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700044F RID: 1103
		// (get) Token: 0x06000C52 RID: 3154 RVA: 0x00017F56 File Offset: 0x00016156
		public float ScBoxSliderDepth
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000450 RID: 1104
		// (get) Token: 0x06000C53 RID: 3155 RVA: 0x00017F5D File Offset: 0x0001615D
		public float ScCylinderSliderRadius
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000451 RID: 1105
		// (get) Token: 0x06000C54 RID: 3156 RVA: 0x00017F64 File Offset: 0x00016164
		public float ScSliderBoxCapWidth
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000452 RID: 1106
		// (get) Token: 0x06000C55 RID: 3157 RVA: 0x00017F6B File Offset: 0x0001616B
		public float ScSliderBoxCapHeight
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000453 RID: 1107
		// (get) Token: 0x06000C56 RID: 3158 RVA: 0x00017F72 File Offset: 0x00016172
		public float ScSliderBoxCapDepth
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000454 RID: 1108
		// (get) Token: 0x06000C57 RID: 3159 RVA: 0x00017F79 File Offset: 0x00016179
		public float ScSliderConeCapHeight
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000455 RID: 1109
		// (get) Token: 0x06000C58 RID: 3160 RVA: 0x00017F80 File Offset: 0x00016180
		public float ScSliderConeCapBaseRadius
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000456 RID: 1110
		// (get) Token: 0x06000C59 RID: 3161 RVA: 0x00017F87 File Offset: 0x00016187
		public float ScSliderPyramidCapWidth
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000457 RID: 1111
		// (get) Token: 0x06000C5A RID: 3162 RVA: 0x00017F8E File Offset: 0x0001618E
		public float ScSliderPyramidCapHeight
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000458 RID: 1112
		// (get) Token: 0x06000C5B RID: 3163 RVA: 0x00017F95 File Offset: 0x00016195
		public float ScSliderPyramidCapDepth
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000459 RID: 1113
		// (get) Token: 0x06000C5C RID: 3164 RVA: 0x00017F9C File Offset: 0x0001619C
		public float ScSliderTriPrismCapWidth
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700045A RID: 1114
		// (get) Token: 0x06000C5D RID: 3165 RVA: 0x00017FA3 File Offset: 0x000161A3
		public float ScSliderTriPrismCapHeight
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700045B RID: 1115
		// (get) Token: 0x06000C5E RID: 3166 RVA: 0x00017FAA File Offset: 0x000161AA
		public float ScSliderTriPrismCapDepth
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700045C RID: 1116
		// (get) Token: 0x06000C5F RID: 3167 RVA: 0x00017FB1 File Offset: 0x000161B1
		public float ScSliderSphereCapRadius
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700045D RID: 1117
		// (get) Token: 0x06000C60 RID: 3168 RVA: 0x0002019C File Offset: 0x0001E39C
		public GizmoFillMode3D ScSliderFillMode
		{
			get
			{
				return GizmoFillMode3D.Filled;
			}
		}

		// Token: 0x1700045E RID: 1118
		// (get) Token: 0x06000C61 RID: 3169 RVA: 0x000201B4 File Offset: 0x0001E3B4
		public GizmoFillMode3D ScSliderCapFillMode
		{
			get
			{
				return GizmoFillMode3D.Filled;
			}
		}

		// Token: 0x1700045F RID: 1119
		// (get) Token: 0x06000C62 RID: 3170 RVA: 0x000201CC File Offset: 0x0001E3CC
		public GizmoCap3DType ScSliderCapType
		{
			get
			{
				return GizmoCap3DType.Cone;
			}
		}

		// Token: 0x17000460 RID: 1120
		// (get) Token: 0x06000C63 RID: 3171 RVA: 0x000201E4 File Offset: 0x0001E3E4
		public GizmoShadeMode ScSliderShadeMode
		{
			get
			{
				return GizmoShadeMode.Lit;
			}
		}

		// Token: 0x17000461 RID: 1121
		// (get) Token: 0x06000C64 RID: 3172 RVA: 0x000201FC File Offset: 0x0001E3FC
		public GizmoShadeMode ScSliderCapShadeMode
		{
			get
			{
				return GizmoShadeMode.Lit;
			}
		}

		// Token: 0x17000462 RID: 1122
		// (get) Token: 0x06000C65 RID: 3173 RVA: 0x00020214 File Offset: 0x0001E414
		public GizmoLine3DType ScSliderLineType
		{
			get
			{
				return GizmoLine3DType.Thin;
			}
		}

		// Token: 0x17000463 RID: 1123
		// (get) Token: 0x06000C66 RID: 3174 RVA: 0x0002022C File Offset: 0x0001E42C
		public Color ScPXColor
		{
			get
			{
				return default(Color);
			}
		}

		// Token: 0x17000464 RID: 1124
		// (get) Token: 0x06000C67 RID: 3175 RVA: 0x00020244 File Offset: 0x0001E444
		public Color ScNXColor
		{
			get
			{
				return default(Color);
			}
		}

		// Token: 0x17000465 RID: 1125
		// (get) Token: 0x06000C68 RID: 3176 RVA: 0x0002025C File Offset: 0x0001E45C
		public Color ScPYColor
		{
			get
			{
				return default(Color);
			}
		}

		// Token: 0x17000466 RID: 1126
		// (get) Token: 0x06000C69 RID: 3177 RVA: 0x00020274 File Offset: 0x0001E474
		public Color ScNYColor
		{
			get
			{
				return default(Color);
			}
		}

		// Token: 0x17000467 RID: 1127
		// (get) Token: 0x06000C6A RID: 3178 RVA: 0x0002028C File Offset: 0x0001E48C
		public Color ScPZColor
		{
			get
			{
				return default(Color);
			}
		}

		// Token: 0x17000468 RID: 1128
		// (get) Token: 0x06000C6B RID: 3179 RVA: 0x000202A4 File Offset: 0x0001E4A4
		public Color ScNZColor
		{
			get
			{
				return default(Color);
			}
		}

		// Token: 0x17000469 RID: 1129
		// (get) Token: 0x06000C6C RID: 3180 RVA: 0x00017FB8 File Offset: 0x000161B8
		public float ScDblSliderSize
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700046A RID: 1130
		// (get) Token: 0x06000C6D RID: 3181 RVA: 0x00017FBF File Offset: 0x000161BF
		public float ScDblSliderFillAlpha
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700046B RID: 1131
		// (get) Token: 0x06000C6E RID: 3182 RVA: 0x00017FC6 File Offset: 0x000161C6
		public float ScMidCapBoxWidth
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700046C RID: 1132
		// (get) Token: 0x06000C6F RID: 3183 RVA: 0x00017FCD File Offset: 0x000161CD
		public float ScMidCapBoxHeight
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700046D RID: 1133
		// (get) Token: 0x06000C70 RID: 3184 RVA: 0x00017FD4 File Offset: 0x000161D4
		public float ScMidCapBoxDepth
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700046E RID: 1134
		// (get) Token: 0x06000C71 RID: 3185 RVA: 0x00017FDB File Offset: 0x000161DB
		public float ScMidCapSphereRadius
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700046F RID: 1135
		// (get) Token: 0x06000C72 RID: 3186 RVA: 0x000202BC File Offset: 0x0001E4BC
		public GizmoCap3DType ScMidCapType
		{
			get
			{
				return GizmoCap3DType.Cone;
			}
		}

		// Token: 0x17000470 RID: 1136
		// (get) Token: 0x06000C73 RID: 3187 RVA: 0x000202D4 File Offset: 0x0001E4D4
		public GizmoShadeMode ScMidCapShadeMode
		{
			get
			{
				return GizmoShadeMode.Lit;
			}
		}

		// Token: 0x17000471 RID: 1137
		// (get) Token: 0x06000C74 RID: 3188 RVA: 0x000202EC File Offset: 0x0001E4EC
		public GizmoFillMode3D ScMidCapFillMode
		{
			get
			{
				return GizmoFillMode3D.Filled;
			}
		}

		// Token: 0x17000472 RID: 1138
		// (get) Token: 0x06000C75 RID: 3189 RVA: 0x00017FE2 File Offset: 0x000161E2
		public bool IsScMidCapVisible
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000473 RID: 1139
		// (get) Token: 0x06000C76 RID: 3190 RVA: 0x00020304 File Offset: 0x0001E504
		public Color ScMidCapColor
		{
			get
			{
				return default(Color);
			}
		}

		// Token: 0x17000474 RID: 1140
		// (get) Token: 0x06000C77 RID: 3191 RVA: 0x0002031C File Offset: 0x0001E51C
		public Color ScHoveredColor
		{
			get
			{
				return default(Color);
			}
		}

		// Token: 0x17000475 RID: 1141
		// (get) Token: 0x06000C78 RID: 3192 RVA: 0x00017FE5 File Offset: 0x000161E5
		public bool IsScScaleGuideVisible
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000476 RID: 1142
		// (get) Token: 0x06000C79 RID: 3193 RVA: 0x00017FE8 File Offset: 0x000161E8
		public float ScScaleGuideAxisLength
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000477 RID: 1143
		// (get) Token: 0x06000C7A RID: 3194 RVA: 0x00020334 File Offset: 0x0001E534
		// (set) Token: 0x06000C7B RID: 3195 RVA: 0x00017FEF File Offset: 0x000161EF
		public UniversalGizmoSettingsCategory DisplayCategory
		{
			get
			{
				return UniversalGizmoSettingsCategory.Move;
			}
			set
			{
			}
		}

		// Token: 0x06000C7D RID: 3197 RVA: 0x00017FF9 File Offset: 0x000161F9
		public bool IsMvVertSnapCapTypeAllowed(GizmoCap2DType capType)
		{
			return false;
		}

		// Token: 0x06000C7E RID: 3198 RVA: 0x00017FFC File Offset: 0x000161FC
		public List<Enum> GetAllowedMvVertSnapCapTypes()
		{
			return null;
		}

		// Token: 0x06000C7F RID: 3199 RVA: 0x00017FFF File Offset: 0x000161FF
		public void SetMvVertSnapCapType(GizmoCap2DType capType)
		{
		}

		// Token: 0x06000C80 RID: 3200 RVA: 0x00018001 File Offset: 0x00016201
		public void SetMvVertSnapCapQuadWidth(float width)
		{
		}

		// Token: 0x06000C81 RID: 3201 RVA: 0x00018003 File Offset: 0x00016203
		public void SetMvVertSnapCapQuadHeight(float height)
		{
		}

		// Token: 0x06000C82 RID: 3202 RVA: 0x00018005 File Offset: 0x00016205
		public void SetMvVertSnapCapCircleRadius(float radius)
		{
		}

		// Token: 0x06000C83 RID: 3203 RVA: 0x00018007 File Offset: 0x00016207
		public void SetMvVertSnapCapFillMode(GizmoFillMode2D fillMode)
		{
		}

		// Token: 0x06000C84 RID: 3204 RVA: 0x00018009 File Offset: 0x00016209
		public void SetMvVertSnapCapColor(Color color)
		{
		}

		// Token: 0x06000C85 RID: 3205 RVA: 0x0001800B File Offset: 0x0001620B
		public void SetMvVertSnapCapBorderColor(Color color)
		{
		}

		// Token: 0x06000C86 RID: 3206 RVA: 0x0001800D File Offset: 0x0001620D
		public void SetMvVertSnapCapHoveredColor(Color color)
		{
		}

		// Token: 0x06000C87 RID: 3207 RVA: 0x0001800F File Offset: 0x0001620F
		public void SetMvVertSnapCapHoveredBorderColor(Color color)
		{
		}

		// Token: 0x06000C88 RID: 3208 RVA: 0x00018011 File Offset: 0x00016211
		public bool IsMvSliderVisible(int axisIndex, AxisSign axisSign)
		{
			return false;
		}

		// Token: 0x06000C89 RID: 3209 RVA: 0x00018014 File Offset: 0x00016214
		public bool IsMvDblSliderVisible(PlaneId planeId)
		{
			return false;
		}

		// Token: 0x06000C8A RID: 3210 RVA: 0x00018017 File Offset: 0x00016217
		public bool IsMvSliderCapVisible(int axisIndex, AxisSign axisSign)
		{
			return false;
		}

		// Token: 0x06000C8B RID: 3211 RVA: 0x0001801A File Offset: 0x0001621A
		public bool IsMvPositiveSliderVisible(int axisIndex)
		{
			return false;
		}

		// Token: 0x06000C8C RID: 3212 RVA: 0x0001801D File Offset: 0x0001621D
		public bool IsMvPositiveSliderCapVisible(int axisIndex)
		{
			return false;
		}

		// Token: 0x06000C8D RID: 3213 RVA: 0x00018020 File Offset: 0x00016220
		public bool IsMvNegativeSliderVisible(int axisIndex)
		{
			return false;
		}

		// Token: 0x06000C8E RID: 3214 RVA: 0x00018023 File Offset: 0x00016223
		public bool IsMvNegativeSliderCapVisible(int axisIndex)
		{
			return false;
		}

		// Token: 0x06000C8F RID: 3215 RVA: 0x00018026 File Offset: 0x00016226
		public void SetMvSliderVisible(int axisIndex, AxisSign axisSign, bool isVisible)
		{
		}

		// Token: 0x06000C90 RID: 3216 RVA: 0x00018028 File Offset: 0x00016228
		public void SetMvDblSliderVisible(PlaneId planeId, bool isVisible)
		{
		}

		// Token: 0x06000C91 RID: 3217 RVA: 0x0001802A File Offset: 0x0001622A
		public void SetMvSliderCapVisible(int axisIndex, AxisSign axisSign, bool isVisible)
		{
		}

		// Token: 0x06000C92 RID: 3218 RVA: 0x0001802C File Offset: 0x0001622C
		public void SetMvPositiveSliderVisible(int axisIndex, bool isVisible)
		{
		}

		// Token: 0x06000C93 RID: 3219 RVA: 0x0001802E File Offset: 0x0001622E
		public void SetMvPositiveSliderCapVisible(int axisIndex, bool isVisible)
		{
		}

		// Token: 0x06000C94 RID: 3220 RVA: 0x00018030 File Offset: 0x00016230
		public void SetMvNegativeSliderVisible(int axisIndex, bool isVisible)
		{
		}

		// Token: 0x06000C95 RID: 3221 RVA: 0x00018032 File Offset: 0x00016232
		public void SetMvNegativeSliderCapVisible(int axisIndex, bool isVisible)
		{
		}

		// Token: 0x06000C96 RID: 3222 RVA: 0x00018034 File Offset: 0x00016234
		public void SetMvSliderLength(float axisLength)
		{
		}

		// Token: 0x06000C97 RID: 3223 RVA: 0x00018036 File Offset: 0x00016236
		public void SetMvSliderLineType(GizmoLine3DType lineType)
		{
		}

		// Token: 0x06000C98 RID: 3224 RVA: 0x00018038 File Offset: 0x00016238
		public void SetMvDblSliderBorderType(GizmoQuad3DBorderType borderType)
		{
		}

		// Token: 0x06000C99 RID: 3225 RVA: 0x0001803A File Offset: 0x0001623A
		public void SetMvDblSliderBorderBoxHeight(float height)
		{
		}

		// Token: 0x06000C9A RID: 3226 RVA: 0x0001803C File Offset: 0x0001623C
		public void SetMvDblSliderBorderBoxDepth(float depth)
		{
		}

		// Token: 0x06000C9B RID: 3227 RVA: 0x0001803E File Offset: 0x0001623E
		public void SetMvBoxSliderHeight(float height)
		{
		}

		// Token: 0x06000C9C RID: 3228 RVA: 0x00018040 File Offset: 0x00016240
		public void SetMvBoxSliderDepth(float depth)
		{
		}

		// Token: 0x06000C9D RID: 3229 RVA: 0x00018042 File Offset: 0x00016242
		public void SetMvCylinderSliderRadius(float radius)
		{
		}

		// Token: 0x06000C9E RID: 3230 RVA: 0x00018044 File Offset: 0x00016244
		public void SetMvDblSliderSize(float size)
		{
		}

		// Token: 0x06000C9F RID: 3231 RVA: 0x00018046 File Offset: 0x00016246
		public void SetMvScale(float scale)
		{
		}

		// Token: 0x06000CA0 RID: 3232 RVA: 0x00018048 File Offset: 0x00016248
		public void SetMvUseZoomFactor(bool useZoomFactor)
		{
		}

		// Token: 0x06000CA1 RID: 3233 RVA: 0x0001804A File Offset: 0x0001624A
		public void SetMvAxisColor(int axisIndex, Color color)
		{
		}

		// Token: 0x06000CA2 RID: 3234 RVA: 0x0001804C File Offset: 0x0001624C
		public void SetMvDblSliderFillAlpha(float alpha)
		{
		}

		// Token: 0x06000CA3 RID: 3235 RVA: 0x0001804E File Offset: 0x0001624E
		public void SetMvHoveredColor(Color hoveredColor)
		{
		}

		// Token: 0x06000CA4 RID: 3236 RVA: 0x00018050 File Offset: 0x00016250
		public void SetMvSliderShadeMode(GizmoShadeMode shadeMode)
		{
		}

		// Token: 0x06000CA5 RID: 3237 RVA: 0x00018052 File Offset: 0x00016252
		public void SetMvSliderCapShadeMode(GizmoShadeMode shadeMode)
		{
		}

		// Token: 0x06000CA6 RID: 3238 RVA: 0x00018054 File Offset: 0x00016254
		public void SetMvDblSliderBorderShadeMode(GizmoShadeMode shadeMode)
		{
		}

		// Token: 0x06000CA7 RID: 3239 RVA: 0x00018056 File Offset: 0x00016256
		public void SetMvSliderCapType(GizmoCap3DType capType)
		{
		}

		// Token: 0x06000CA8 RID: 3240 RVA: 0x00018058 File Offset: 0x00016258
		public void SetMvSliderFillMode(GizmoFillMode3D fillMode)
		{
		}

		// Token: 0x06000CA9 RID: 3241 RVA: 0x0001805A File Offset: 0x0001625A
		public void SetMvSliderCapFillMode(GizmoFillMode3D fillMode)
		{
		}

		// Token: 0x06000CAA RID: 3242 RVA: 0x0001805C File Offset: 0x0001625C
		public void SetMvDblSliderBorderFillMode(GizmoFillMode3D fillMode)
		{
		}

		// Token: 0x06000CAB RID: 3243 RVA: 0x0001805E File Offset: 0x0001625E
		public void SetMvSliderBoxCapWidth(float width)
		{
		}

		// Token: 0x06000CAC RID: 3244 RVA: 0x00018060 File Offset: 0x00016260
		public void SetMvSliderBoxCapHeight(float height)
		{
		}

		// Token: 0x06000CAD RID: 3245 RVA: 0x00018062 File Offset: 0x00016262
		public void SetMvSliderBoxCapDepth(float depth)
		{
		}

		// Token: 0x06000CAE RID: 3246 RVA: 0x00018064 File Offset: 0x00016264
		public void SetMvSliderConeCapHeight(float height)
		{
		}

		// Token: 0x06000CAF RID: 3247 RVA: 0x00018066 File Offset: 0x00016266
		public void SetMvSliderConeCapBaseRadius(float radius)
		{
		}

		// Token: 0x06000CB0 RID: 3248 RVA: 0x00018068 File Offset: 0x00016268
		public void SetMvSliderPyramidCapWidth(float width)
		{
		}

		// Token: 0x06000CB1 RID: 3249 RVA: 0x0001806A File Offset: 0x0001626A
		public void SetMvSliderPyramidCapHeight(float height)
		{
		}

		// Token: 0x06000CB2 RID: 3250 RVA: 0x0001806C File Offset: 0x0001626C
		public void SetMvSliderPyramidCapDepth(float depth)
		{
		}

		// Token: 0x06000CB3 RID: 3251 RVA: 0x0001806E File Offset: 0x0001626E
		public void SetMvSliderTriPrismCapWidth(float width)
		{
		}

		// Token: 0x06000CB4 RID: 3252 RVA: 0x00018070 File Offset: 0x00016270
		public void SetMvSliderTriPrismCapHeight(float height)
		{
		}

		// Token: 0x06000CB5 RID: 3253 RVA: 0x00018072 File Offset: 0x00016272
		public void SetMvSliderTriPrismCapDepth(float depth)
		{
		}

		// Token: 0x06000CB6 RID: 3254 RVA: 0x00018074 File Offset: 0x00016274
		public void SetMvSliderSphereCapRadius(float radius)
		{
		}

		// Token: 0x06000CB7 RID: 3255 RVA: 0x00018076 File Offset: 0x00016276
		public void ConnectMvSliderLookAndFeel(GizmoLineSlider3D slider, int axisIndex, AxisSign axisSign)
		{
		}

		// Token: 0x06000CB8 RID: 3256 RVA: 0x00018078 File Offset: 0x00016278
		public void ConnectMvDblSliderLookAndFeel(GizmoPlaneSlider3D dblSlider, PlaneId planeId)
		{
		}

		// Token: 0x06000CB9 RID: 3257 RVA: 0x0001807A File Offset: 0x0001627A
		public void ConnectMvVertSnapCapLookAndFeel(GizmoCap2D vertSnapCap)
		{
		}

		// Token: 0x06000CBA RID: 3258 RVA: 0x0001807C File Offset: 0x0001627C
		public void Inherit(MoveGizmoLookAndFeel3D lookAndFeel)
		{
		}

		// Token: 0x06000CBB RID: 3259 RVA: 0x0001807E File Offset: 0x0001627E
		private GizmoLineSlider3DLookAndFeel GetMvSglSliderLookAndFeel(int axisIndex, AxisSign axisSign)
		{
			return null;
		}

		// Token: 0x06000CBC RID: 3260 RVA: 0x00018081 File Offset: 0x00016281
		private GizmoPlaneSlider3DLookAndFeel GetMvDblSliderLookAndFeel(PlaneId planeId)
		{
			return null;
		}

		// Token: 0x06000CBD RID: 3261 RVA: 0x00018084 File Offset: 0x00016284
		public bool IsRtAxisVisible(int axisIndex)
		{
			return false;
		}

		// Token: 0x06000CBE RID: 3262 RVA: 0x00018087 File Offset: 0x00016287
		public void SetRtAxisVisible(int axisIndex, bool isVisible)
		{
		}

		// Token: 0x06000CBF RID: 3263 RVA: 0x00018089 File Offset: 0x00016289
		public void SetRtShadeMode(GizmoShadeMode shadeMode)
		{
		}

		// Token: 0x06000CC0 RID: 3264 RVA: 0x0001808B File Offset: 0x0001628B
		public void SetRtAxisBorderFillMode(GizmoFillMode3D fillMode)
		{
		}

		// Token: 0x06000CC1 RID: 3265 RVA: 0x0001808D File Offset: 0x0001628D
		public void SetRtNumAxisTorusWireAxialSlices(int numSlices)
		{
		}

		// Token: 0x06000CC2 RID: 3266 RVA: 0x0001808F File Offset: 0x0001628F
		public void SetRtUseZoomFactor(bool useZoomFactor)
		{
		}

		// Token: 0x06000CC3 RID: 3267 RVA: 0x00018091 File Offset: 0x00016291
		public void SetRtScale(float scale)
		{
		}

		// Token: 0x06000CC4 RID: 3268 RVA: 0x00018093 File Offset: 0x00016293
		public void SetRtRadius(float radius)
		{
		}

		// Token: 0x06000CC5 RID: 3269 RVA: 0x00018095 File Offset: 0x00016295
		public void SetRtAxisBorderCullAlphaScale(float scale)
		{
		}

		// Token: 0x06000CC6 RID: 3270 RVA: 0x00018097 File Offset: 0x00016297
		public void SetRtAxisBorderType(GizmoCircle3DBorderType borderType)
		{
		}

		// Token: 0x06000CC7 RID: 3271 RVA: 0x00018099 File Offset: 0x00016299
		public void SetRtAxisTorusThickness(float thickness)
		{
		}

		// Token: 0x06000CC8 RID: 3272 RVA: 0x0001809B File Offset: 0x0001629B
		public void SetRtAxisCylTorusWidth(float width)
		{
		}

		// Token: 0x06000CC9 RID: 3273 RVA: 0x0001809D File Offset: 0x0001629D
		public void SetRtAxisCylTorusHeight(float height)
		{
		}

		// Token: 0x06000CCA RID: 3274 RVA: 0x0001809F File Offset: 0x0001629F
		public void SetRtMidCapVisible(bool isVisible)
		{
		}

		// Token: 0x06000CCB RID: 3275 RVA: 0x000180A1 File Offset: 0x000162A1
		public void SetRtMidCapColor(Color color)
		{
		}

		// Token: 0x06000CCC RID: 3276 RVA: 0x000180A3 File Offset: 0x000162A3
		public void SetRtHoveredMidCapColor(Color color)
		{
		}

		// Token: 0x06000CCD RID: 3277 RVA: 0x000180A5 File Offset: 0x000162A5
		public void SetRtMidCapBorderVisible(bool isVisible)
		{
		}

		// Token: 0x06000CCE RID: 3278 RVA: 0x000180A7 File Offset: 0x000162A7
		public void SetRtMidCapBorderColor(Color color)
		{
		}

		// Token: 0x06000CCF RID: 3279 RVA: 0x000180A9 File Offset: 0x000162A9
		public void SetRtAxisBorderColor(int axisIndex, Color color)
		{
		}

		// Token: 0x06000CD0 RID: 3280 RVA: 0x000180AB File Offset: 0x000162AB
		public void SetRtHoveredColor(Color hoveredColor)
		{
		}

		// Token: 0x06000CD1 RID: 3281 RVA: 0x000180AD File Offset: 0x000162AD
		public void SetRtRotationArcColor(Color color)
		{
		}

		// Token: 0x06000CD2 RID: 3282 RVA: 0x000180AF File Offset: 0x000162AF
		public void SetRtRotationArcBorderColor(Color color)
		{
		}

		// Token: 0x06000CD3 RID: 3283 RVA: 0x000180B1 File Offset: 0x000162B1
		public void SetRtUseShortestRotationArc(bool useShortest)
		{
		}

		// Token: 0x06000CD4 RID: 3284 RVA: 0x000180B3 File Offset: 0x000162B3
		public void SetRtRotationArcVisible(bool isVisible)
		{
		}

		// Token: 0x06000CD5 RID: 3285 RVA: 0x000180B5 File Offset: 0x000162B5
		public void SetRtCamLookSliderRadiusOffset(float offset)
		{
		}

		// Token: 0x06000CD6 RID: 3286 RVA: 0x000180B7 File Offset: 0x000162B7
		public void SetRtCamLookSliderBorderColor(Color color)
		{
		}

		// Token: 0x06000CD7 RID: 3287 RVA: 0x000180B9 File Offset: 0x000162B9
		public void SetRtCamLookSliderHoveredBorderColor(Color color)
		{
		}

		// Token: 0x06000CD8 RID: 3288 RVA: 0x000180BB File Offset: 0x000162BB
		public void SetRtCamLookSliderVisible(bool isVisible)
		{
		}

		// Token: 0x06000CD9 RID: 3289 RVA: 0x000180BD File Offset: 0x000162BD
		public void SetRtCamLookSliderPolyBorderType(GizmoPolygon2DBorderType polyBorderType)
		{
		}

		// Token: 0x06000CDA RID: 3290 RVA: 0x000180BF File Offset: 0x000162BF
		public void SetRtCamLookSliderPolyBorderThickness(float thickness)
		{
		}

		// Token: 0x06000CDB RID: 3291 RVA: 0x000180C1 File Offset: 0x000162C1
		public void ConnectRtSliderLookAndFeel(GizmoPlaneSlider3D slider, int axisIndex)
		{
		}

		// Token: 0x06000CDC RID: 3292 RVA: 0x000180C3 File Offset: 0x000162C3
		public void ConnectRtMidCapLookAndFeel(GizmoCap3D cap)
		{
		}

		// Token: 0x06000CDD RID: 3293 RVA: 0x000180C5 File Offset: 0x000162C5
		public void ConnectRtCamLookSliderLookAndFeel(GizmoPlaneSlider2D slider)
		{
		}

		// Token: 0x06000CDE RID: 3294 RVA: 0x000180C7 File Offset: 0x000162C7
		public void Inherit(RotationGizmoLookAndFeel3D lookAndFeel)
		{
		}

		// Token: 0x06000CDF RID: 3295 RVA: 0x000180C9 File Offset: 0x000162C9
		public void SetScScaleGuideVisible(bool isVisible)
		{
		}

		// Token: 0x06000CE0 RID: 3296 RVA: 0x000180CB File Offset: 0x000162CB
		public bool IsScDblSliderVisible(PlaneId planeId)
		{
			return false;
		}

		// Token: 0x06000CE1 RID: 3297 RVA: 0x000180CE File Offset: 0x000162CE
		public void SetScDblSliderVisible(PlaneId planeId, bool isVisible)
		{
		}

		// Token: 0x06000CE2 RID: 3298 RVA: 0x000180D0 File Offset: 0x000162D0
		public bool IsScSliderVisible(int axisIndex, AxisSign axisSign)
		{
			return false;
		}

		// Token: 0x06000CE3 RID: 3299 RVA: 0x000180D3 File Offset: 0x000162D3
		public bool IsScSliderCapVisible(int axisIndex, AxisSign axisSign)
		{
			return false;
		}

		// Token: 0x06000CE4 RID: 3300 RVA: 0x000180D6 File Offset: 0x000162D6
		public bool IsScPositiveSliderVisible(int axisIndex)
		{
			return false;
		}

		// Token: 0x06000CE5 RID: 3301 RVA: 0x000180D9 File Offset: 0x000162D9
		public bool IsScPositiveSliderCapVisible(int axisIndex)
		{
			return false;
		}

		// Token: 0x06000CE6 RID: 3302 RVA: 0x000180DC File Offset: 0x000162DC
		public bool IsScNegativeSliderVisible(int axisIndex)
		{
			return false;
		}

		// Token: 0x06000CE7 RID: 3303 RVA: 0x000180DF File Offset: 0x000162DF
		public bool IsScNegativeSliderCapVisible(int axisIndex)
		{
			return false;
		}

		// Token: 0x06000CE8 RID: 3304 RVA: 0x000180E2 File Offset: 0x000162E2
		public void SetScSliderVisible(int axisIndex, AxisSign axisSign, bool isVisible)
		{
		}

		// Token: 0x06000CE9 RID: 3305 RVA: 0x000180E4 File Offset: 0x000162E4
		public void SetScSliderCapVisible(int axisIndex, AxisSign axisSign, bool isVisible)
		{
		}

		// Token: 0x06000CEA RID: 3306 RVA: 0x000180E6 File Offset: 0x000162E6
		public void SetScPositiveSliderVisible(int axisIndex, bool isVisible)
		{
		}

		// Token: 0x06000CEB RID: 3307 RVA: 0x000180E8 File Offset: 0x000162E8
		public void SetScPositiveSliderCapVisible(int axisIndex, bool isVisible)
		{
		}

		// Token: 0x06000CEC RID: 3308 RVA: 0x000180EA File Offset: 0x000162EA
		public void SetScNegativeSliderVisible(int axisIndex, bool isVisible)
		{
		}

		// Token: 0x06000CED RID: 3309 RVA: 0x000180EC File Offset: 0x000162EC
		public void SetScNegativeSliderCapVisible(int axisIndex, bool isVisible)
		{
		}

		// Token: 0x06000CEE RID: 3310 RVA: 0x000180EE File Offset: 0x000162EE
		public void SetScSliderLength(float axisLength)
		{
		}

		// Token: 0x06000CEF RID: 3311 RVA: 0x000180F0 File Offset: 0x000162F0
		public void SetScSliderLineType(GizmoLine3DType lineType)
		{
		}

		// Token: 0x06000CF0 RID: 3312 RVA: 0x000180F2 File Offset: 0x000162F2
		public void SetScBoxSliderHeight(float height)
		{
		}

		// Token: 0x06000CF1 RID: 3313 RVA: 0x000180F4 File Offset: 0x000162F4
		public void SetScBoxSliderDepth(float depth)
		{
		}

		// Token: 0x06000CF2 RID: 3314 RVA: 0x000180F6 File Offset: 0x000162F6
		public void SetScCylinderSliderRadius(float radius)
		{
		}

		// Token: 0x06000CF3 RID: 3315 RVA: 0x000180F8 File Offset: 0x000162F8
		public void SetScScale(float scale)
		{
		}

		// Token: 0x06000CF4 RID: 3316 RVA: 0x000180FA File Offset: 0x000162FA
		public void SetScUseZoomFactor(bool useZoomFactor)
		{
		}

		// Token: 0x06000CF5 RID: 3317 RVA: 0x000180FC File Offset: 0x000162FC
		public void SetScScaleGuideAxisLength(float length)
		{
		}

		// Token: 0x06000CF6 RID: 3318 RVA: 0x000180FE File Offset: 0x000162FE
		public void SetScAxisColor(int axisIndex, Color color)
		{
		}

		// Token: 0x06000CF7 RID: 3319 RVA: 0x00018100 File Offset: 0x00016300
		public void SetScDblSliderFillAlpha(float alpha)
		{
		}

		// Token: 0x06000CF8 RID: 3320 RVA: 0x00018102 File Offset: 0x00016302
		public void SetScMidCapColor(Color color)
		{
		}

		// Token: 0x06000CF9 RID: 3321 RVA: 0x00018104 File Offset: 0x00016304
		public void SetScMidCapVisible(bool visible)
		{
		}

		// Token: 0x06000CFA RID: 3322 RVA: 0x00018106 File Offset: 0x00016306
		public void SetScHoveredColor(Color hoveredColor)
		{
		}

		// Token: 0x06000CFB RID: 3323 RVA: 0x00018108 File Offset: 0x00016308
		public void SetScSliderShadeMode(GizmoShadeMode shadeMode)
		{
		}

		// Token: 0x06000CFC RID: 3324 RVA: 0x0001810A File Offset: 0x0001630A
		public void SetScSliderCapShadeMode(GizmoShadeMode shadeMode)
		{
		}

		// Token: 0x06000CFD RID: 3325 RVA: 0x0001810C File Offset: 0x0001630C
		public void SetScMidCapShadeMode(GizmoShadeMode shadeMode)
		{
		}

		// Token: 0x06000CFE RID: 3326 RVA: 0x0001810E File Offset: 0x0001630E
		public void SetScSliderCapType(GizmoCap3DType capType)
		{
		}

		// Token: 0x06000CFF RID: 3327 RVA: 0x00018110 File Offset: 0x00016310
		public void SetScMidCapType(GizmoCap3DType capType)
		{
		}

		// Token: 0x06000D00 RID: 3328 RVA: 0x00018112 File Offset: 0x00016312
		public bool IsScMidCapTypeAllowed(GizmoCap3DType capType)
		{
			return false;
		}

		// Token: 0x06000D01 RID: 3329 RVA: 0x00018115 File Offset: 0x00016315
		public List<Enum> GetAllowedScMidCapTypes()
		{
			return null;
		}

		// Token: 0x06000D02 RID: 3330 RVA: 0x00018118 File Offset: 0x00016318
		public void SetScSliderFillMode(GizmoFillMode3D fillMode)
		{
		}

		// Token: 0x06000D03 RID: 3331 RVA: 0x0001811A File Offset: 0x0001631A
		public void SetScSliderCapFillMode(GizmoFillMode3D fillMode)
		{
		}

		// Token: 0x06000D04 RID: 3332 RVA: 0x0001811C File Offset: 0x0001631C
		public void SetScMidCapFillMode(GizmoFillMode3D fillMode)
		{
		}

		// Token: 0x06000D05 RID: 3333 RVA: 0x0001811E File Offset: 0x0001631E
		public void SetScSliderBoxCapWidth(float width)
		{
		}

		// Token: 0x06000D06 RID: 3334 RVA: 0x00018120 File Offset: 0x00016320
		public void SetScSliderBoxCapHeight(float height)
		{
		}

		// Token: 0x06000D07 RID: 3335 RVA: 0x00018122 File Offset: 0x00016322
		public void SetScSliderBoxCapDepth(float depth)
		{
		}

		// Token: 0x06000D08 RID: 3336 RVA: 0x00018124 File Offset: 0x00016324
		public void SetScSliderConeCapHeight(float height)
		{
		}

		// Token: 0x06000D09 RID: 3337 RVA: 0x00018126 File Offset: 0x00016326
		public void SetScSliderConeCapBaseRadius(float radius)
		{
		}

		// Token: 0x06000D0A RID: 3338 RVA: 0x00018128 File Offset: 0x00016328
		public void SetScSliderPyramidCapWidth(float width)
		{
		}

		// Token: 0x06000D0B RID: 3339 RVA: 0x0001812A File Offset: 0x0001632A
		public void SetScSliderPyramidCapHeight(float height)
		{
		}

		// Token: 0x06000D0C RID: 3340 RVA: 0x0001812C File Offset: 0x0001632C
		public void SetScSliderPyramidCapDepth(float depth)
		{
		}

		// Token: 0x06000D0D RID: 3341 RVA: 0x0001812E File Offset: 0x0001632E
		public void SetScSliderTriPrismCapWidth(float width)
		{
		}

		// Token: 0x06000D0E RID: 3342 RVA: 0x00018130 File Offset: 0x00016330
		public void SetScSliderTriPrismCapHeight(float height)
		{
		}

		// Token: 0x06000D0F RID: 3343 RVA: 0x00018132 File Offset: 0x00016332
		public void SetScSliderTriPrismCapDepth(float depth)
		{
		}

		// Token: 0x06000D10 RID: 3344 RVA: 0x00018134 File Offset: 0x00016334
		public void SetScSliderSphereCapRadius(float radius)
		{
		}

		// Token: 0x06000D11 RID: 3345 RVA: 0x00018136 File Offset: 0x00016336
		public void SetScMidCapBoxWidth(float width)
		{
		}

		// Token: 0x06000D12 RID: 3346 RVA: 0x00018138 File Offset: 0x00016338
		public void SetScMidCapBoxHeight(float height)
		{
		}

		// Token: 0x06000D13 RID: 3347 RVA: 0x0001813A File Offset: 0x0001633A
		public void SetScMidCapBoxDepth(float depth)
		{
		}

		// Token: 0x06000D14 RID: 3348 RVA: 0x0001813C File Offset: 0x0001633C
		public void SetScMidCapSphereRadius(float radius)
		{
		}

		// Token: 0x06000D15 RID: 3349 RVA: 0x0001813E File Offset: 0x0001633E
		public void SetScDblSliderSize(float size)
		{
		}

		// Token: 0x06000D16 RID: 3350 RVA: 0x00018140 File Offset: 0x00016340
		public void ConnectScSliderLookAndFeel(GizmoLineSlider3D slider, int axisIndex, AxisSign axisSign)
		{
		}

		// Token: 0x06000D17 RID: 3351 RVA: 0x00018142 File Offset: 0x00016342
		public void ConnectScMidCapLookAndFeel(GizmoCap3D cap)
		{
		}

		// Token: 0x06000D18 RID: 3352 RVA: 0x00018144 File Offset: 0x00016344
		public void ConnectScDblSliderLookAndFeel(GizmoPlaneSlider3D slider, PlaneId planeId)
		{
		}

		// Token: 0x06000D19 RID: 3353 RVA: 0x00018146 File Offset: 0x00016346
		public void ConnectScGizmoScaleGuideLookAndFeel(GizmoScaleGuide scaleGuide)
		{
		}

		// Token: 0x06000D1A RID: 3354 RVA: 0x00018148 File Offset: 0x00016348
		public void Inherit(ScaleGizmoLookAndFeel3D lookAndFeel)
		{
		}

		// Token: 0x06000D1B RID: 3355 RVA: 0x0001814A File Offset: 0x0001634A
		private GizmoLineSlider3DLookAndFeel GetScSglSliderLookAndFeel(int axisIndex, AxisSign axisSign)
		{
			return null;
		}

		// Token: 0x06000D1C RID: 3356 RVA: 0x0001814D File Offset: 0x0001634D
		private GizmoPlaneSlider3DLookAndFeel GetScDblSliderLookAndFeel(PlaneId planeId)
		{
			return null;
		}

		// Token: 0x0400047B RID: 1147
		private UniversalGizmoSettingsCategory _displayCategory;

		// Token: 0x0400047C RID: 1148
		private GizmoCap2DLookAndFeel _mvVertSnapCapLookAndFeel;

		// Token: 0x0400047D RID: 1149
		private bool[] _mvSglSliderVis;

		// Token: 0x0400047E RID: 1150
		private bool[] _mvSglSliderCapVis;

		// Token: 0x0400047F RID: 1151
		private bool[] _mvDblSliderVis;

		// Token: 0x04000480 RID: 1152
		private GizmoLineSlider3DLookAndFeel[] _mvSglSlidersLookAndFeel;

		// Token: 0x04000481 RID: 1153
		private GizmoPlaneSlider3DLookAndFeel[] _mvDblSlidersLookAndFeel;

		// Token: 0x04000482 RID: 1154
		private bool _isRtMidCapVisible;

		// Token: 0x04000483 RID: 1155
		private GizmoCap3DLookAndFeel _rtMidCapLookAndFeel;

		// Token: 0x04000484 RID: 1156
		private bool[] _rtAxesVis;

		// Token: 0x04000485 RID: 1157
		private GizmoPlaneSlider3DLookAndFeel[] _rtAxesLookAndFeel;

		// Token: 0x04000486 RID: 1158
		private bool _isRtCamLookSliderVisible;

		// Token: 0x04000487 RID: 1159
		private float _rtCamLookSliderRadiusOffset;

		// Token: 0x04000488 RID: 1160
		private GizmoPlaneSlider2DLookAndFeel _rtCamLookSliderLookAndFeel;

		// Token: 0x04000489 RID: 1161
		private GizmoCap3DLookAndFeel _scMidCapLookAndFeel;

		// Token: 0x0400048A RID: 1162
		private bool[] _scSglSliderVis;

		// Token: 0x0400048B RID: 1163
		private bool[] _scSglSliderCapVis;

		// Token: 0x0400048C RID: 1164
		private bool[] _scDblSliderVis;

		// Token: 0x0400048D RID: 1165
		private bool _isScMidCapVisible;

		// Token: 0x0400048E RID: 1166
		private GizmoScaleGuideLookAndFeel _scScaleGuideLookAndFeel;

		// Token: 0x0400048F RID: 1167
		private bool _isScScaleGuideVisible;

		// Token: 0x04000490 RID: 1168
		private GizmoLineSlider3DLookAndFeel[] _scSglSlidersLookAndFeel;

		// Token: 0x04000491 RID: 1169
		private GizmoPlaneSlider3DLookAndFeel[] _scDblSlidersLookAndFeel;
	}
}
