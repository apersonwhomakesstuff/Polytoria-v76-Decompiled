using System;
using System.Collections.Generic;
using UnityEngine;

namespace RLD
{
	// Token: 0x020000DD RID: 221
	[Serializable]
	public class MoveGizmoLookAndFeel3D : Settings
	{
		// Token: 0x17000311 RID: 785
		// (get) Token: 0x0600097B RID: 2427 RVA: 0x000176CC File Offset: 0x000158CC
		public float Scale
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000312 RID: 786
		// (get) Token: 0x0600097C RID: 2428 RVA: 0x000176D3 File Offset: 0x000158D3
		public bool UseZoomFactor
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000313 RID: 787
		// (get) Token: 0x0600097D RID: 2429 RVA: 0x000176D6 File Offset: 0x000158D6
		public float SliderLength
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000314 RID: 788
		// (get) Token: 0x0600097E RID: 2430 RVA: 0x000176DD File Offset: 0x000158DD
		public float BoxSliderHeight
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000315 RID: 789
		// (get) Token: 0x0600097F RID: 2431 RVA: 0x000176E4 File Offset: 0x000158E4
		public float BoxSliderDepth
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000316 RID: 790
		// (get) Token: 0x06000980 RID: 2432 RVA: 0x000176EB File Offset: 0x000158EB
		public float CylinderSliderRadius
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000317 RID: 791
		// (get) Token: 0x06000981 RID: 2433 RVA: 0x000176F2 File Offset: 0x000158F2
		public float SliderBoxCapWidth
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000318 RID: 792
		// (get) Token: 0x06000982 RID: 2434 RVA: 0x000176F9 File Offset: 0x000158F9
		public float SliderBoxCapHeight
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000319 RID: 793
		// (get) Token: 0x06000983 RID: 2435 RVA: 0x00017700 File Offset: 0x00015900
		public float SliderBoxCapDepth
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700031A RID: 794
		// (get) Token: 0x06000984 RID: 2436 RVA: 0x00017707 File Offset: 0x00015907
		public float SliderConeCapHeight
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700031B RID: 795
		// (get) Token: 0x06000985 RID: 2437 RVA: 0x0001770E File Offset: 0x0001590E
		public float SliderConeCapBaseRadius
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700031C RID: 796
		// (get) Token: 0x06000986 RID: 2438 RVA: 0x00017715 File Offset: 0x00015915
		public float SliderPyramidCapWidth
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700031D RID: 797
		// (get) Token: 0x06000987 RID: 2439 RVA: 0x0001771C File Offset: 0x0001591C
		public float SliderPyramidCapHeight
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700031E RID: 798
		// (get) Token: 0x06000988 RID: 2440 RVA: 0x00017723 File Offset: 0x00015923
		public float SliderPyramidCapDepth
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700031F RID: 799
		// (get) Token: 0x06000989 RID: 2441 RVA: 0x0001772A File Offset: 0x0001592A
		public float SliderTriPrismCapWidth
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000320 RID: 800
		// (get) Token: 0x0600098A RID: 2442 RVA: 0x00017731 File Offset: 0x00015931
		public float SliderTriPrismCapHeight
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000321 RID: 801
		// (get) Token: 0x0600098B RID: 2443 RVA: 0x00017738 File Offset: 0x00015938
		public float SliderTriPrismCapDepth
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000322 RID: 802
		// (get) Token: 0x0600098C RID: 2444 RVA: 0x0001773F File Offset: 0x0001593F
		public float SliderSphereCapRadius
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000323 RID: 803
		// (get) Token: 0x0600098D RID: 2445 RVA: 0x0001F6BC File Offset: 0x0001D8BC
		public GizmoFillMode3D SliderFillMode
		{
			get
			{
				return GizmoFillMode3D.Filled;
			}
		}

		// Token: 0x17000324 RID: 804
		// (get) Token: 0x0600098E RID: 2446 RVA: 0x0001F6D4 File Offset: 0x0001D8D4
		public GizmoFillMode3D SliderCapFillMode
		{
			get
			{
				return GizmoFillMode3D.Filled;
			}
		}

		// Token: 0x17000325 RID: 805
		// (get) Token: 0x0600098F RID: 2447 RVA: 0x0001F6EC File Offset: 0x0001D8EC
		public GizmoCap3DType SliderCapType
		{
			get
			{
				return GizmoCap3DType.Cone;
			}
		}

		// Token: 0x17000326 RID: 806
		// (get) Token: 0x06000990 RID: 2448 RVA: 0x0001F704 File Offset: 0x0001D904
		public GizmoShadeMode SliderShadeMode
		{
			get
			{
				return GizmoShadeMode.Lit;
			}
		}

		// Token: 0x17000327 RID: 807
		// (get) Token: 0x06000991 RID: 2449 RVA: 0x0001F71C File Offset: 0x0001D91C
		public GizmoShadeMode SliderCapShadeMode
		{
			get
			{
				return GizmoShadeMode.Lit;
			}
		}

		// Token: 0x17000328 RID: 808
		// (get) Token: 0x06000992 RID: 2450 RVA: 0x0001F734 File Offset: 0x0001D934
		public GizmoLine3DType SliderLineType
		{
			get
			{
				return GizmoLine3DType.Thin;
			}
		}

		// Token: 0x17000329 RID: 809
		// (get) Token: 0x06000993 RID: 2451 RVA: 0x0001F74C File Offset: 0x0001D94C
		public Color XColor
		{
			get
			{
				return default(Color);
			}
		}

		// Token: 0x1700032A RID: 810
		// (get) Token: 0x06000994 RID: 2452 RVA: 0x0001F764 File Offset: 0x0001D964
		public Color YColor
		{
			get
			{
				return default(Color);
			}
		}

		// Token: 0x1700032B RID: 811
		// (get) Token: 0x06000995 RID: 2453 RVA: 0x0001F77C File Offset: 0x0001D97C
		public Color ZColor
		{
			get
			{
				return default(Color);
			}
		}

		// Token: 0x1700032C RID: 812
		// (get) Token: 0x06000996 RID: 2454 RVA: 0x00017746 File Offset: 0x00015946
		public float DblSliderSize
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700032D RID: 813
		// (get) Token: 0x06000997 RID: 2455 RVA: 0x0001774D File Offset: 0x0001594D
		public float DblSliderBorderBoxHeight
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700032E RID: 814
		// (get) Token: 0x06000998 RID: 2456 RVA: 0x00017754 File Offset: 0x00015954
		public float DblSliderBorderBoxDepth
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700032F RID: 815
		// (get) Token: 0x06000999 RID: 2457 RVA: 0x0001775B File Offset: 0x0001595B
		public float DblSliderFillAlpha
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000330 RID: 816
		// (get) Token: 0x0600099A RID: 2458 RVA: 0x0001F794 File Offset: 0x0001D994
		public GizmoShadeMode DblSliderBorderShadeMode
		{
			get
			{
				return GizmoShadeMode.Lit;
			}
		}

		// Token: 0x17000331 RID: 817
		// (get) Token: 0x0600099B RID: 2459 RVA: 0x0001F7AC File Offset: 0x0001D9AC
		public GizmoQuad3DBorderType DblSliderBorderType
		{
			get
			{
				return GizmoQuad3DBorderType.Thin;
			}
		}

		// Token: 0x17000332 RID: 818
		// (get) Token: 0x0600099C RID: 2460 RVA: 0x0001F7C4 File Offset: 0x0001D9C4
		public GizmoFillMode3D DblSliderBorderFillMode
		{
			get
			{
				return GizmoFillMode3D.Filled;
			}
		}

		// Token: 0x17000333 RID: 819
		// (get) Token: 0x0600099D RID: 2461 RVA: 0x00017762 File Offset: 0x00015962
		public float VertSnapCapQuadWidth
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000334 RID: 820
		// (get) Token: 0x0600099E RID: 2462 RVA: 0x00017769 File Offset: 0x00015969
		public float VertSnapCapQuadHeight
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000335 RID: 821
		// (get) Token: 0x0600099F RID: 2463 RVA: 0x00017770 File Offset: 0x00015970
		public float VertSnapCapCircleRadius
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000336 RID: 822
		// (get) Token: 0x060009A0 RID: 2464 RVA: 0x0001F7DC File Offset: 0x0001D9DC
		public Color VertSnapCapColor
		{
			get
			{
				return default(Color);
			}
		}

		// Token: 0x17000337 RID: 823
		// (get) Token: 0x060009A1 RID: 2465 RVA: 0x0001F7F4 File Offset: 0x0001D9F4
		public Color VertSnapCapBorderColor
		{
			get
			{
				return default(Color);
			}
		}

		// Token: 0x17000338 RID: 824
		// (get) Token: 0x060009A2 RID: 2466 RVA: 0x0001F80C File Offset: 0x0001DA0C
		public Color VertSnapCapHoveredColor
		{
			get
			{
				return default(Color);
			}
		}

		// Token: 0x17000339 RID: 825
		// (get) Token: 0x060009A3 RID: 2467 RVA: 0x0001F824 File Offset: 0x0001DA24
		public Color VertSnapCapHoveredBorderColor
		{
			get
			{
				return default(Color);
			}
		}

		// Token: 0x1700033A RID: 826
		// (get) Token: 0x060009A4 RID: 2468 RVA: 0x0001F83C File Offset: 0x0001DA3C
		public GizmoFillMode2D VertSnapCapFillMode
		{
			get
			{
				return GizmoFillMode2D.Filled;
			}
		}

		// Token: 0x1700033B RID: 827
		// (get) Token: 0x060009A5 RID: 2469 RVA: 0x0001F854 File Offset: 0x0001DA54
		public GizmoCap2DType VertSnapCapType
		{
			get
			{
				return GizmoCap2DType.Quad;
			}
		}

		// Token: 0x1700033C RID: 828
		// (get) Token: 0x060009A6 RID: 2470 RVA: 0x00017777 File Offset: 0x00015977
		// (set) Token: 0x060009A7 RID: 2471 RVA: 0x0001777A File Offset: 0x0001597A
		public bool IsMidCapVisible
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x1700033D RID: 829
		// (get) Token: 0x060009A8 RID: 2472 RVA: 0x0001777C File Offset: 0x0001597C
		public float MidCapBoxWidth
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700033E RID: 830
		// (get) Token: 0x060009A9 RID: 2473 RVA: 0x00017783 File Offset: 0x00015983
		public float MidCapBoxHeight
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700033F RID: 831
		// (get) Token: 0x060009AA RID: 2474 RVA: 0x0001778A File Offset: 0x0001598A
		public float MidCapBoxDepth
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000340 RID: 832
		// (get) Token: 0x060009AB RID: 2475 RVA: 0x00017791 File Offset: 0x00015991
		public float MidCapSphereRadius
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000341 RID: 833
		// (get) Token: 0x060009AC RID: 2476 RVA: 0x0001F86C File Offset: 0x0001DA6C
		public Color MidCapColor
		{
			get
			{
				return default(Color);
			}
		}

		// Token: 0x17000342 RID: 834
		// (get) Token: 0x060009AD RID: 2477 RVA: 0x0001F884 File Offset: 0x0001DA84
		public GizmoFillMode3D MidCapFillMode
		{
			get
			{
				return GizmoFillMode3D.Filled;
			}
		}

		// Token: 0x17000343 RID: 835
		// (get) Token: 0x060009AE RID: 2478 RVA: 0x0001F89C File Offset: 0x0001DA9C
		public GizmoShadeMode MidCapShadeMode
		{
			get
			{
				return GizmoShadeMode.Lit;
			}
		}

		// Token: 0x17000344 RID: 836
		// (get) Token: 0x060009AF RID: 2479 RVA: 0x0001F8B4 File Offset: 0x0001DAB4
		public GizmoCap3DType MidCapType
		{
			get
			{
				return GizmoCap3DType.Cone;
			}
		}

		// Token: 0x17000345 RID: 837
		// (get) Token: 0x060009B0 RID: 2480 RVA: 0x0001F8CC File Offset: 0x0001DACC
		public Color HoveredColor
		{
			get
			{
				return default(Color);
			}
		}

		// Token: 0x060009B2 RID: 2482 RVA: 0x000177A0 File Offset: 0x000159A0
		public bool IsVertSnapCapTypeAllowed(GizmoCap2DType capType)
		{
			return false;
		}

		// Token: 0x060009B3 RID: 2483 RVA: 0x000177A3 File Offset: 0x000159A3
		public List<Enum> GetAllowedVertSnapCapTypes()
		{
			return null;
		}

		// Token: 0x060009B4 RID: 2484 RVA: 0x000177A6 File Offset: 0x000159A6
		public void SetVertSnapCapType(GizmoCap2DType capType)
		{
		}

		// Token: 0x060009B5 RID: 2485 RVA: 0x000177A8 File Offset: 0x000159A8
		public void SetVertSnapCapQuadWidth(float width)
		{
		}

		// Token: 0x060009B6 RID: 2486 RVA: 0x000177AA File Offset: 0x000159AA
		public void SetVertSnapCapQuadHeight(float height)
		{
		}

		// Token: 0x060009B7 RID: 2487 RVA: 0x000177AC File Offset: 0x000159AC
		public void SetVertSnapCapCircleRadius(float radius)
		{
		}

		// Token: 0x060009B8 RID: 2488 RVA: 0x000177AE File Offset: 0x000159AE
		public void SetVertSnapCapFillMode(GizmoFillMode2D fillMode)
		{
		}

		// Token: 0x060009B9 RID: 2489 RVA: 0x000177B0 File Offset: 0x000159B0
		public void SetVertSnapCapColor(Color color)
		{
		}

		// Token: 0x060009BA RID: 2490 RVA: 0x000177B2 File Offset: 0x000159B2
		public void SetVertSnapCapBorderColor(Color color)
		{
		}

		// Token: 0x060009BB RID: 2491 RVA: 0x000177B4 File Offset: 0x000159B4
		public void SetVertSnapCapHoveredColor(Color color)
		{
		}

		// Token: 0x060009BC RID: 2492 RVA: 0x000177B6 File Offset: 0x000159B6
		public void SetVertSnapCapHoveredBorderColor(Color color)
		{
		}

		// Token: 0x060009BD RID: 2493 RVA: 0x000177B8 File Offset: 0x000159B8
		public bool IsMidCapTypeAllowed(GizmoCap3DType capType)
		{
			return false;
		}

		// Token: 0x060009BE RID: 2494 RVA: 0x000177BB File Offset: 0x000159BB
		public List<Enum> GetAllowedMidCapTypes()
		{
			return null;
		}

		// Token: 0x060009BF RID: 2495 RVA: 0x000177BE File Offset: 0x000159BE
		public void SetMidCapType(GizmoCap3DType capType)
		{
		}

		// Token: 0x060009C0 RID: 2496 RVA: 0x000177C0 File Offset: 0x000159C0
		public void SetMidCapBoxWidth(float width)
		{
		}

		// Token: 0x060009C1 RID: 2497 RVA: 0x000177C2 File Offset: 0x000159C2
		public void SetMidCapBoxHeight(float height)
		{
		}

		// Token: 0x060009C2 RID: 2498 RVA: 0x000177C4 File Offset: 0x000159C4
		public void SetMidCapBoxDepth(float depth)
		{
		}

		// Token: 0x060009C3 RID: 2499 RVA: 0x000177C6 File Offset: 0x000159C6
		public void SetMidCapSphereRadius(float radius)
		{
		}

		// Token: 0x060009C4 RID: 2500 RVA: 0x000177C8 File Offset: 0x000159C8
		public void SetMidCapColor(Color color)
		{
		}

		// Token: 0x060009C5 RID: 2501 RVA: 0x000177CA File Offset: 0x000159CA
		public bool IsSliderVisible(int axisIndex, AxisSign axisSign)
		{
			return false;
		}

		// Token: 0x060009C6 RID: 2502 RVA: 0x000177CD File Offset: 0x000159CD
		public bool IsDblSliderVisible(PlaneId planeId)
		{
			return false;
		}

		// Token: 0x060009C7 RID: 2503 RVA: 0x000177D0 File Offset: 0x000159D0
		public bool IsSliderCapVisible(int axisIndex, AxisSign axisSign)
		{
			return false;
		}

		// Token: 0x060009C8 RID: 2504 RVA: 0x000177D3 File Offset: 0x000159D3
		public bool IsPositiveSliderVisible(int axisIndex)
		{
			return false;
		}

		// Token: 0x060009C9 RID: 2505 RVA: 0x000177D6 File Offset: 0x000159D6
		public bool IsPositiveSliderCapVisible(int axisIndex)
		{
			return false;
		}

		// Token: 0x060009CA RID: 2506 RVA: 0x000177D9 File Offset: 0x000159D9
		public bool IsNegativeSliderVisible(int axisIndex)
		{
			return false;
		}

		// Token: 0x060009CB RID: 2507 RVA: 0x000177DC File Offset: 0x000159DC
		public bool IsNegativeSliderCapVisible(int axisIndex)
		{
			return false;
		}

		// Token: 0x060009CC RID: 2508 RVA: 0x000177DF File Offset: 0x000159DF
		public void SetSliderVisible(int axisIndex, AxisSign axisSign, bool isVisible)
		{
		}

		// Token: 0x060009CD RID: 2509 RVA: 0x000177E1 File Offset: 0x000159E1
		public void SetDblSliderVisible(PlaneId planeId, bool isVisible)
		{
		}

		// Token: 0x060009CE RID: 2510 RVA: 0x000177E3 File Offset: 0x000159E3
		public void SetSliderCapVisible(int axisIndex, AxisSign axisSign, bool isVisible)
		{
		}

		// Token: 0x060009CF RID: 2511 RVA: 0x000177E5 File Offset: 0x000159E5
		public void SetPositiveSliderVisible(int axisIndex, bool isVisible)
		{
		}

		// Token: 0x060009D0 RID: 2512 RVA: 0x000177E7 File Offset: 0x000159E7
		public void SetPositiveCapVisible(int axisIndex, bool isVisible)
		{
		}

		// Token: 0x060009D1 RID: 2513 RVA: 0x000177E9 File Offset: 0x000159E9
		public void SetNegativeSliderVisible(int axisIndex, bool isVisible)
		{
		}

		// Token: 0x060009D2 RID: 2514 RVA: 0x000177EB File Offset: 0x000159EB
		public void SetNegativeCapVisible(int axisIndex, bool isVisible)
		{
		}

		// Token: 0x060009D3 RID: 2515 RVA: 0x000177ED File Offset: 0x000159ED
		public void SetSliderLength(float axisLength)
		{
		}

		// Token: 0x060009D4 RID: 2516 RVA: 0x000177EF File Offset: 0x000159EF
		public void SetSliderLineType(GizmoLine3DType lineType)
		{
		}

		// Token: 0x060009D5 RID: 2517 RVA: 0x000177F1 File Offset: 0x000159F1
		public void SetDblSliderBorderType(GizmoQuad3DBorderType borderType)
		{
		}

		// Token: 0x060009D6 RID: 2518 RVA: 0x000177F3 File Offset: 0x000159F3
		public void SetDblSliderBorderBoxHeight(float height)
		{
		}

		// Token: 0x060009D7 RID: 2519 RVA: 0x000177F5 File Offset: 0x000159F5
		public void SetDblSliderBorderBoxDepth(float depth)
		{
		}

		// Token: 0x060009D8 RID: 2520 RVA: 0x000177F7 File Offset: 0x000159F7
		public void SetBoxSliderHeight(float height)
		{
		}

		// Token: 0x060009D9 RID: 2521 RVA: 0x000177F9 File Offset: 0x000159F9
		public void SetBoxSliderDepth(float depth)
		{
		}

		// Token: 0x060009DA RID: 2522 RVA: 0x000177FB File Offset: 0x000159FB
		public void SetCylinderSliderRadius(float radius)
		{
		}

		// Token: 0x060009DB RID: 2523 RVA: 0x000177FD File Offset: 0x000159FD
		public void SetDblSliderSize(float size)
		{
		}

		// Token: 0x060009DC RID: 2524 RVA: 0x000177FF File Offset: 0x000159FF
		public void SetScale(float scale)
		{
		}

		// Token: 0x060009DD RID: 2525 RVA: 0x00017801 File Offset: 0x00015A01
		public void SetUseZoomFactor(bool useZoomFactor)
		{
		}

		// Token: 0x060009DE RID: 2526 RVA: 0x00017803 File Offset: 0x00015A03
		public void SetAxisColor(int axisIndex, Color color)
		{
		}

		// Token: 0x060009DF RID: 2527 RVA: 0x00017805 File Offset: 0x00015A05
		public void SetDblSliderFillAlpha(float alpha)
		{
		}

		// Token: 0x060009E0 RID: 2528 RVA: 0x00017807 File Offset: 0x00015A07
		public void SetHoveredColor(Color hoveredColor)
		{
		}

		// Token: 0x060009E1 RID: 2529 RVA: 0x00017809 File Offset: 0x00015A09
		public void SetSliderShadeMode(GizmoShadeMode shadeMode)
		{
		}

		// Token: 0x060009E2 RID: 2530 RVA: 0x0001780B File Offset: 0x00015A0B
		public void SetSliderCapShadeMode(GizmoShadeMode shadeMode)
		{
		}

		// Token: 0x060009E3 RID: 2531 RVA: 0x0001780D File Offset: 0x00015A0D
		public void SetMidCapShadeMode(GizmoShadeMode shadeMode)
		{
		}

		// Token: 0x060009E4 RID: 2532 RVA: 0x0001780F File Offset: 0x00015A0F
		public void SetDblSliderBorderShadeMode(GizmoShadeMode shadeMode)
		{
		}

		// Token: 0x060009E5 RID: 2533 RVA: 0x00017811 File Offset: 0x00015A11
		public void SetSliderCapType(GizmoCap3DType capType)
		{
		}

		// Token: 0x060009E6 RID: 2534 RVA: 0x00017813 File Offset: 0x00015A13
		public void SetSliderFillMode(GizmoFillMode3D fillMode)
		{
		}

		// Token: 0x060009E7 RID: 2535 RVA: 0x00017815 File Offset: 0x00015A15
		public void SetSliderCapFillMode(GizmoFillMode3D fillMode)
		{
		}

		// Token: 0x060009E8 RID: 2536 RVA: 0x00017817 File Offset: 0x00015A17
		public void SetMidCapFillMode(GizmoFillMode3D fillMode)
		{
		}

		// Token: 0x060009E9 RID: 2537 RVA: 0x00017819 File Offset: 0x00015A19
		public void SetDblSliderBorderFillMode(GizmoFillMode3D fillMode)
		{
		}

		// Token: 0x060009EA RID: 2538 RVA: 0x0001781B File Offset: 0x00015A1B
		public void SetSliderBoxCapWidth(float width)
		{
		}

		// Token: 0x060009EB RID: 2539 RVA: 0x0001781D File Offset: 0x00015A1D
		public void SetSliderBoxCapHeight(float height)
		{
		}

		// Token: 0x060009EC RID: 2540 RVA: 0x0001781F File Offset: 0x00015A1F
		public void SetSliderBoxCapDepth(float depth)
		{
		}

		// Token: 0x060009ED RID: 2541 RVA: 0x00017821 File Offset: 0x00015A21
		public void SetSliderConeCapHeight(float height)
		{
		}

		// Token: 0x060009EE RID: 2542 RVA: 0x00017823 File Offset: 0x00015A23
		public void SetSliderConeCapBaseRadius(float radius)
		{
		}

		// Token: 0x060009EF RID: 2543 RVA: 0x00017825 File Offset: 0x00015A25
		public void SetSliderPyramidCapWidth(float width)
		{
		}

		// Token: 0x060009F0 RID: 2544 RVA: 0x00017827 File Offset: 0x00015A27
		public void SetSliderPyramidCapHeight(float height)
		{
		}

		// Token: 0x060009F1 RID: 2545 RVA: 0x00017829 File Offset: 0x00015A29
		public void SetSliderPyramidCapDepth(float depth)
		{
		}

		// Token: 0x060009F2 RID: 2546 RVA: 0x0001782B File Offset: 0x00015A2B
		public void SetSliderTriPrismCapWidth(float width)
		{
		}

		// Token: 0x060009F3 RID: 2547 RVA: 0x0001782D File Offset: 0x00015A2D
		public void SetSliderTriPrismCapHeight(float height)
		{
		}

		// Token: 0x060009F4 RID: 2548 RVA: 0x0001782F File Offset: 0x00015A2F
		public void SetSliderTriPrismCapDepth(float depth)
		{
		}

		// Token: 0x060009F5 RID: 2549 RVA: 0x00017831 File Offset: 0x00015A31
		public void SetSliderSphereCapRadius(float radius)
		{
		}

		// Token: 0x060009F6 RID: 2550 RVA: 0x00017833 File Offset: 0x00015A33
		public void ConnectSliderLookAndFeel(GizmoLineSlider3D slider, int axisIndex, AxisSign axisSign)
		{
		}

		// Token: 0x060009F7 RID: 2551 RVA: 0x00017835 File Offset: 0x00015A35
		public void ConnectDblSliderLookAndFeel(GizmoPlaneSlider3D dblSlider, PlaneId planeId)
		{
		}

		// Token: 0x060009F8 RID: 2552 RVA: 0x00017837 File Offset: 0x00015A37
		public void ConnectMidCapLookAndFeel(GizmoCap3D midCap)
		{
		}

		// Token: 0x060009F9 RID: 2553 RVA: 0x00017839 File Offset: 0x00015A39
		public void ConnectVertSnapCapLookAndFeel(GizmoCap2D vertSnapCap)
		{
		}

		// Token: 0x060009FA RID: 2554 RVA: 0x0001783B File Offset: 0x00015A3B
		private GizmoLineSlider3DLookAndFeel GetSglSliderLookAndFeel(int axisIndex, AxisSign axisSign)
		{
			return null;
		}

		// Token: 0x060009FB RID: 2555 RVA: 0x0001783E File Offset: 0x00015A3E
		private GizmoPlaneSlider3DLookAndFeel GetDblSliderLookAndFeel(PlaneId planeId)
		{
			return null;
		}

		// Token: 0x040003E4 RID: 996
		private bool _isMidCapVisible;

		// Token: 0x040003E5 RID: 997
		private GizmoCap3DLookAndFeel _midCapLookAndFeel;

		// Token: 0x040003E6 RID: 998
		private GizmoCap2DLookAndFeel _vertSnapCapLookAndFeel;

		// Token: 0x040003E7 RID: 999
		private bool[] _sglSliderVis;

		// Token: 0x040003E8 RID: 1000
		private bool[] _sglSliderCapVis;

		// Token: 0x040003E9 RID: 1001
		private bool[] _dblSliderVis;

		// Token: 0x040003EA RID: 1002
		private GizmoLineSlider3DLookAndFeel[] _sglSlidersLookAndFeel;

		// Token: 0x040003EB RID: 1003
		private GizmoPlaneSlider3DLookAndFeel[] _dblSlidersLookAndFeel;
	}
}
