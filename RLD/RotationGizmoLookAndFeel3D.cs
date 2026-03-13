using System;
using UnityEngine;

namespace RLD
{
	// Token: 0x020000E4 RID: 228
	[Serializable]
	public class RotationGizmoLookAndFeel3D : Settings
	{
		// Token: 0x17000369 RID: 873
		// (get) Token: 0x06000A7C RID: 2684 RVA: 0x000179B7 File Offset: 0x00015BB7
		public float Scale
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700036A RID: 874
		// (get) Token: 0x06000A7D RID: 2685 RVA: 0x000179BE File Offset: 0x00015BBE
		public float Radius
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700036B RID: 875
		// (get) Token: 0x06000A7E RID: 2686 RVA: 0x000179C5 File Offset: 0x00015BC5
		public bool UseZoomFactor
		{
			get
			{
				return false;
			}
		}

		// Token: 0x1700036C RID: 876
		// (get) Token: 0x06000A7F RID: 2687 RVA: 0x0001F9A4 File Offset: 0x0001DBA4
		public Color XBorderColor
		{
			get
			{
				return default(Color);
			}
		}

		// Token: 0x1700036D RID: 877
		// (get) Token: 0x06000A80 RID: 2688 RVA: 0x0001F9BC File Offset: 0x0001DBBC
		public Color YBorderColor
		{
			get
			{
				return default(Color);
			}
		}

		// Token: 0x1700036E RID: 878
		// (get) Token: 0x06000A81 RID: 2689 RVA: 0x0001F9D4 File Offset: 0x0001DBD4
		public Color ZBorderColor
		{
			get
			{
				return default(Color);
			}
		}

		// Token: 0x1700036F RID: 879
		// (get) Token: 0x06000A82 RID: 2690 RVA: 0x0001F9EC File Offset: 0x0001DBEC
		public Color HoveredColor
		{
			get
			{
				return default(Color);
			}
		}

		// Token: 0x17000370 RID: 880
		// (get) Token: 0x06000A83 RID: 2691 RVA: 0x000179C8 File Offset: 0x00015BC8
		public float AxisTorusThickness
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000371 RID: 881
		// (get) Token: 0x06000A84 RID: 2692 RVA: 0x000179CF File Offset: 0x00015BCF
		public float AxisCylTorusWidth
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000372 RID: 882
		// (get) Token: 0x06000A85 RID: 2693 RVA: 0x000179D6 File Offset: 0x00015BD6
		public float AxisCylTorusHeight
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000373 RID: 883
		// (get) Token: 0x06000A86 RID: 2694 RVA: 0x000179DD File Offset: 0x00015BDD
		public float AxisCullAlphaScale
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000374 RID: 884
		// (get) Token: 0x06000A87 RID: 2695 RVA: 0x0001FA04 File Offset: 0x0001DC04
		public GizmoShadeMode ShadeMode
		{
			get
			{
				return GizmoShadeMode.Lit;
			}
		}

		// Token: 0x17000375 RID: 885
		// (get) Token: 0x06000A88 RID: 2696 RVA: 0x0001FA1C File Offset: 0x0001DC1C
		public GizmoCircle3DBorderType AxisBorderType
		{
			get
			{
				return GizmoCircle3DBorderType.Thin;
			}
		}

		// Token: 0x17000376 RID: 886
		// (get) Token: 0x06000A89 RID: 2697 RVA: 0x0001FA34 File Offset: 0x0001DC34
		public GizmoFillMode3D AxisBorderFillMode
		{
			get
			{
				return GizmoFillMode3D.Filled;
			}
		}

		// Token: 0x17000377 RID: 887
		// (get) Token: 0x06000A8A RID: 2698 RVA: 0x000179E4 File Offset: 0x00015BE4
		public int NumAxisTorusWireAxialSlices
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x17000378 RID: 888
		// (get) Token: 0x06000A8B RID: 2699 RVA: 0x0001FA4C File Offset: 0x0001DC4C
		public Color RotationArcColor
		{
			get
			{
				return default(Color);
			}
		}

		// Token: 0x17000379 RID: 889
		// (get) Token: 0x06000A8C RID: 2700 RVA: 0x0001FA64 File Offset: 0x0001DC64
		public Color RotationArcBorderColor
		{
			get
			{
				return default(Color);
			}
		}

		// Token: 0x1700037A RID: 890
		// (get) Token: 0x06000A8D RID: 2701 RVA: 0x000179E7 File Offset: 0x00015BE7
		public bool UseShortestRotationArc
		{
			get
			{
				return false;
			}
		}

		// Token: 0x1700037B RID: 891
		// (get) Token: 0x06000A8E RID: 2702 RVA: 0x000179EA File Offset: 0x00015BEA
		public bool IsRotationArcVisible
		{
			get
			{
				return false;
			}
		}

		// Token: 0x1700037C RID: 892
		// (get) Token: 0x06000A8F RID: 2703 RVA: 0x0001FA7C File Offset: 0x0001DC7C
		public Color MidCapColor
		{
			get
			{
				return default(Color);
			}
		}

		// Token: 0x1700037D RID: 893
		// (get) Token: 0x06000A90 RID: 2704 RVA: 0x0001FA94 File Offset: 0x0001DC94
		public Color MidCapBorderColor
		{
			get
			{
				return default(Color);
			}
		}

		// Token: 0x1700037E RID: 894
		// (get) Token: 0x06000A91 RID: 2705 RVA: 0x0001FAAC File Offset: 0x0001DCAC
		public Color HoveredMidCapColor
		{
			get
			{
				return default(Color);
			}
		}

		// Token: 0x1700037F RID: 895
		// (get) Token: 0x06000A92 RID: 2706 RVA: 0x000179ED File Offset: 0x00015BED
		public bool IsMidCapVisible
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000380 RID: 896
		// (get) Token: 0x06000A93 RID: 2707 RVA: 0x000179F0 File Offset: 0x00015BF0
		public bool IsMidCapBorderVisible
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000381 RID: 897
		// (get) Token: 0x06000A94 RID: 2708 RVA: 0x000179F3 File Offset: 0x00015BF3
		public float CamLookSliderRadiusOffset
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000382 RID: 898
		// (get) Token: 0x06000A95 RID: 2709 RVA: 0x0001FAC4 File Offset: 0x0001DCC4
		public Color CamLookSliderBorderColor
		{
			get
			{
				return default(Color);
			}
		}

		// Token: 0x17000383 RID: 899
		// (get) Token: 0x06000A96 RID: 2710 RVA: 0x0001FADC File Offset: 0x0001DCDC
		public Color CamLookSliderHoveredBorderColor
		{
			get
			{
				return default(Color);
			}
		}

		// Token: 0x17000384 RID: 900
		// (get) Token: 0x06000A97 RID: 2711 RVA: 0x0001FAF4 File Offset: 0x0001DCF4
		public GizmoPolygon2DBorderType CamLookSliderPolyBorderType
		{
			get
			{
				return GizmoPolygon2DBorderType.Thin;
			}
		}

		// Token: 0x17000385 RID: 901
		// (get) Token: 0x06000A98 RID: 2712 RVA: 0x000179FA File Offset: 0x00015BFA
		public float CamLookSliderPolyBorderThickness
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000386 RID: 902
		// (get) Token: 0x06000A99 RID: 2713 RVA: 0x00017A01 File Offset: 0x00015C01
		public bool IsCamLookSliderVisible
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06000A9B RID: 2715 RVA: 0x00017A0C File Offset: 0x00015C0C
		public bool IsAxisVisible(int axisIndex)
		{
			return false;
		}

		// Token: 0x06000A9C RID: 2716 RVA: 0x00017A0F File Offset: 0x00015C0F
		public void SetAxisVisible(int axisIndex, bool isVisible)
		{
		}

		// Token: 0x06000A9D RID: 2717 RVA: 0x00017A11 File Offset: 0x00015C11
		public void SetShadeMode(GizmoShadeMode shadeMode)
		{
		}

		// Token: 0x06000A9E RID: 2718 RVA: 0x00017A13 File Offset: 0x00015C13
		public void SetAxisBorderFillMode(GizmoFillMode3D fillMode)
		{
		}

		// Token: 0x06000A9F RID: 2719 RVA: 0x00017A15 File Offset: 0x00015C15
		public void SetNumAxisTorusWireAxialSlices(int numSlices)
		{
		}

		// Token: 0x06000AA0 RID: 2720 RVA: 0x00017A17 File Offset: 0x00015C17
		public void SetUseZoomFactor(bool useZoomFactor)
		{
		}

		// Token: 0x06000AA1 RID: 2721 RVA: 0x00017A19 File Offset: 0x00015C19
		public void SetScale(float scale)
		{
		}

		// Token: 0x06000AA2 RID: 2722 RVA: 0x00017A1B File Offset: 0x00015C1B
		public void SetRadius(float radius)
		{
		}

		// Token: 0x06000AA3 RID: 2723 RVA: 0x00017A1D File Offset: 0x00015C1D
		public void SetAxisBorderCullAlphaScale(float scale)
		{
		}

		// Token: 0x06000AA4 RID: 2724 RVA: 0x00017A1F File Offset: 0x00015C1F
		public void SetAxisBorderType(GizmoCircle3DBorderType borderType)
		{
		}

		// Token: 0x06000AA5 RID: 2725 RVA: 0x00017A21 File Offset: 0x00015C21
		public void SetAxisTorusThickness(float thickness)
		{
		}

		// Token: 0x06000AA6 RID: 2726 RVA: 0x00017A23 File Offset: 0x00015C23
		public void SetAxisCylTorusWidth(float width)
		{
		}

		// Token: 0x06000AA7 RID: 2727 RVA: 0x00017A25 File Offset: 0x00015C25
		public void SetAxisCylTorusHeight(float height)
		{
		}

		// Token: 0x06000AA8 RID: 2728 RVA: 0x00017A27 File Offset: 0x00015C27
		public void SetMidCapVisible(bool isVisible)
		{
		}

		// Token: 0x06000AA9 RID: 2729 RVA: 0x00017A29 File Offset: 0x00015C29
		public void SetMidCapColor(Color color)
		{
		}

		// Token: 0x06000AAA RID: 2730 RVA: 0x00017A2B File Offset: 0x00015C2B
		public void SetHoveredMidCapColor(Color color)
		{
		}

		// Token: 0x06000AAB RID: 2731 RVA: 0x00017A2D File Offset: 0x00015C2D
		public void SetMidCapBorderVisible(bool isVisible)
		{
		}

		// Token: 0x06000AAC RID: 2732 RVA: 0x00017A2F File Offset: 0x00015C2F
		public void SetMidCapBorderColor(Color color)
		{
		}

		// Token: 0x06000AAD RID: 2733 RVA: 0x00017A31 File Offset: 0x00015C31
		public void SetAxisBorderColor(int axisIndex, Color color)
		{
		}

		// Token: 0x06000AAE RID: 2734 RVA: 0x00017A33 File Offset: 0x00015C33
		public void SetHoveredColor(Color hoveredColor)
		{
		}

		// Token: 0x06000AAF RID: 2735 RVA: 0x00017A35 File Offset: 0x00015C35
		public void SetRotationArcColor(Color color)
		{
		}

		// Token: 0x06000AB0 RID: 2736 RVA: 0x00017A37 File Offset: 0x00015C37
		public void SetRotationArcBorderColor(Color color)
		{
		}

		// Token: 0x06000AB1 RID: 2737 RVA: 0x00017A39 File Offset: 0x00015C39
		public void SetUseShortestRotationArc(bool useShortest)
		{
		}

		// Token: 0x06000AB2 RID: 2738 RVA: 0x00017A3B File Offset: 0x00015C3B
		public void SetRotationArcVisible(bool isVisible)
		{
		}

		// Token: 0x06000AB3 RID: 2739 RVA: 0x00017A3D File Offset: 0x00015C3D
		public void SetCamLookSliderRadiusOffset(float offset)
		{
		}

		// Token: 0x06000AB4 RID: 2740 RVA: 0x00017A3F File Offset: 0x00015C3F
		public void SetCamLookSliderBorderColor(Color color)
		{
		}

		// Token: 0x06000AB5 RID: 2741 RVA: 0x00017A41 File Offset: 0x00015C41
		public void SetCamLookSliderHoveredBorderColor(Color color)
		{
		}

		// Token: 0x06000AB6 RID: 2742 RVA: 0x00017A43 File Offset: 0x00015C43
		public void SetCamLookSliderVisible(bool isVisible)
		{
		}

		// Token: 0x06000AB7 RID: 2743 RVA: 0x00017A45 File Offset: 0x00015C45
		public void SetCamLookSliderPolyBorderType(GizmoPolygon2DBorderType polyBorderType)
		{
		}

		// Token: 0x06000AB8 RID: 2744 RVA: 0x00017A47 File Offset: 0x00015C47
		public void SetCamLookSliderPolyBorderThickness(float thickness)
		{
		}

		// Token: 0x06000AB9 RID: 2745 RVA: 0x00017A49 File Offset: 0x00015C49
		public void ConnectSliderLookAndFeel(GizmoPlaneSlider3D slider, int axisIndex)
		{
		}

		// Token: 0x06000ABA RID: 2746 RVA: 0x00017A4B File Offset: 0x00015C4B
		public void ConnectMidCapLookAndFeel(GizmoCap3D cap)
		{
		}

		// Token: 0x06000ABB RID: 2747 RVA: 0x00017A4D File Offset: 0x00015C4D
		public void ConnectCamLookSliderLookAndFeel(GizmoPlaneSlider2D slider)
		{
		}

		// Token: 0x04000414 RID: 1044
		private bool _isMidCapVisible;

		// Token: 0x04000415 RID: 1045
		private GizmoCap3DLookAndFeel _midCapLookAndFeel;

		// Token: 0x04000416 RID: 1046
		private bool[] _axesVis;

		// Token: 0x04000417 RID: 1047
		private GizmoPlaneSlider3DLookAndFeel[] _axesLookAndFeel;

		// Token: 0x04000418 RID: 1048
		private bool _isCamLookSliderVisible;

		// Token: 0x04000419 RID: 1049
		private float _camLookSliderRadiusOffset;

		// Token: 0x0400041A RID: 1050
		private GizmoPlaneSlider2DLookAndFeel _camLookSliderLookAndFeel;
	}
}
