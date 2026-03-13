using System;
using UnityEngine;

namespace RLD
{
	// Token: 0x0200006E RID: 110
	[Serializable]
	public class ObjectExtrudeGizmoLookAndFeel3D : Settings
	{
		// Token: 0x17000162 RID: 354
		// (get) Token: 0x06000491 RID: 1169 RVA: 0x00016879 File Offset: 0x00014A79
		public bool UseZoomFactor
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000163 RID: 355
		// (get) Token: 0x06000492 RID: 1170 RVA: 0x0001E8C4 File Offset: 0x0001CAC4
		public Color BoxWireColor
		{
			get
			{
				return default(Color);
			}
		}

		// Token: 0x17000164 RID: 356
		// (get) Token: 0x06000493 RID: 1171 RVA: 0x0001E8DC File Offset: 0x0001CADC
		public GizmoCap3DType SliderCapType
		{
			get
			{
				return GizmoCap3DType.Cone;
			}
		}

		// Token: 0x17000165 RID: 357
		// (get) Token: 0x06000494 RID: 1172 RVA: 0x0001E8F4 File Offset: 0x0001CAF4
		public GizmoShadeMode SliderCapShadeMode
		{
			get
			{
				return GizmoShadeMode.Lit;
			}
		}

		// Token: 0x17000166 RID: 358
		// (get) Token: 0x06000495 RID: 1173 RVA: 0x0001E90C File Offset: 0x0001CB0C
		public GizmoFillMode3D SliderCapFillMode
		{
			get
			{
				return GizmoFillMode3D.Filled;
			}
		}

		// Token: 0x17000167 RID: 359
		// (get) Token: 0x06000496 RID: 1174 RVA: 0x0001E924 File Offset: 0x0001CB24
		public Color XColor
		{
			get
			{
				return default(Color);
			}
		}

		// Token: 0x17000168 RID: 360
		// (get) Token: 0x06000497 RID: 1175 RVA: 0x0001E93C File Offset: 0x0001CB3C
		public Color YColor
		{
			get
			{
				return default(Color);
			}
		}

		// Token: 0x17000169 RID: 361
		// (get) Token: 0x06000498 RID: 1176 RVA: 0x0001E954 File Offset: 0x0001CB54
		public Color ZColor
		{
			get
			{
				return default(Color);
			}
		}

		// Token: 0x1700016A RID: 362
		// (get) Token: 0x06000499 RID: 1177 RVA: 0x0001E96C File Offset: 0x0001CB6C
		public Color HoveredColor
		{
			get
			{
				return default(Color);
			}
		}

		// Token: 0x1700016B RID: 363
		// (get) Token: 0x0600049A RID: 1178 RVA: 0x0001687C File Offset: 0x00014A7C
		public float SliderBoxCapWidth
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700016C RID: 364
		// (get) Token: 0x0600049B RID: 1179 RVA: 0x00016883 File Offset: 0x00014A83
		public float SliderBoxCapHeight
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700016D RID: 365
		// (get) Token: 0x0600049C RID: 1180 RVA: 0x0001688A File Offset: 0x00014A8A
		public float SliderBoxCapDepth
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700016E RID: 366
		// (get) Token: 0x0600049D RID: 1181 RVA: 0x00016891 File Offset: 0x00014A91
		public float SliderConeCapHeight
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700016F RID: 367
		// (get) Token: 0x0600049E RID: 1182 RVA: 0x00016898 File Offset: 0x00014A98
		public float SliderConeCapBaseRadius
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000170 RID: 368
		// (get) Token: 0x0600049F RID: 1183 RVA: 0x0001689F File Offset: 0x00014A9F
		public float SliderPyramidCapWidth
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000171 RID: 369
		// (get) Token: 0x060004A0 RID: 1184 RVA: 0x000168A6 File Offset: 0x00014AA6
		public float SliderPyramidCapHeight
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000172 RID: 370
		// (get) Token: 0x060004A1 RID: 1185 RVA: 0x000168AD File Offset: 0x00014AAD
		public float SliderPyramidCapDepth
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000173 RID: 371
		// (get) Token: 0x060004A2 RID: 1186 RVA: 0x000168B4 File Offset: 0x00014AB4
		public float SliderTriPrismCapWidth
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000174 RID: 372
		// (get) Token: 0x060004A3 RID: 1187 RVA: 0x000168BB File Offset: 0x00014ABB
		public float SliderTriPrismCapHeight
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000175 RID: 373
		// (get) Token: 0x060004A4 RID: 1188 RVA: 0x000168C2 File Offset: 0x00014AC2
		public float SliderTriPrismCapDepth
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000176 RID: 374
		// (get) Token: 0x060004A5 RID: 1189 RVA: 0x000168C9 File Offset: 0x00014AC9
		public float SliderSphereCapRadius
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x060004A7 RID: 1191 RVA: 0x000168D8 File Offset: 0x00014AD8
		public bool IsExtrudeSliderVisible(int axisIndex, AxisSign axisSign)
		{
			return false;
		}

		// Token: 0x060004A8 RID: 1192 RVA: 0x000168DB File Offset: 0x00014ADB
		public void SetExtrudeSliderVisible(int axisIndex, AxisSign axisSign, bool isVisible)
		{
		}

		// Token: 0x060004A9 RID: 1193 RVA: 0x000168DD File Offset: 0x00014ADD
		public void SetBoxWireColor(Color color)
		{
		}

		// Token: 0x060004AA RID: 1194 RVA: 0x000168DF File Offset: 0x00014ADF
		public void SetSliderCapType(GizmoCap3DType capType)
		{
		}

		// Token: 0x060004AB RID: 1195 RVA: 0x000168E1 File Offset: 0x00014AE1
		public void SetSliderBoxCapWidth(float width)
		{
		}

		// Token: 0x060004AC RID: 1196 RVA: 0x000168E3 File Offset: 0x00014AE3
		public void SetSliderBoxCapHeight(float height)
		{
		}

		// Token: 0x060004AD RID: 1197 RVA: 0x000168E5 File Offset: 0x00014AE5
		public void SetSliderBoxCapDepth(float depth)
		{
		}

		// Token: 0x060004AE RID: 1198 RVA: 0x000168E7 File Offset: 0x00014AE7
		public void SetSliderConeCapHeight(float height)
		{
		}

		// Token: 0x060004AF RID: 1199 RVA: 0x000168E9 File Offset: 0x00014AE9
		public void SetSliderConeCapBaseRadius(float radius)
		{
		}

		// Token: 0x060004B0 RID: 1200 RVA: 0x000168EB File Offset: 0x00014AEB
		public void SetSliderPyramidCapWidth(float width)
		{
		}

		// Token: 0x060004B1 RID: 1201 RVA: 0x000168ED File Offset: 0x00014AED
		public void SetSliderPyramidCapHeight(float height)
		{
		}

		// Token: 0x060004B2 RID: 1202 RVA: 0x000168EF File Offset: 0x00014AEF
		public void SetSliderPyramidCapDepth(float depth)
		{
		}

		// Token: 0x060004B3 RID: 1203 RVA: 0x000168F1 File Offset: 0x00014AF1
		public void SetSliderTriPrismCapWidth(float width)
		{
		}

		// Token: 0x060004B4 RID: 1204 RVA: 0x000168F3 File Offset: 0x00014AF3
		public void SetSliderTriPrismCapHeight(float height)
		{
		}

		// Token: 0x060004B5 RID: 1205 RVA: 0x000168F5 File Offset: 0x00014AF5
		public void SetSliderTriPrismCapDepth(float depth)
		{
		}

		// Token: 0x060004B6 RID: 1206 RVA: 0x000168F7 File Offset: 0x00014AF7
		public void SetSliderSphereCapRadius(float radius)
		{
		}

		// Token: 0x060004B7 RID: 1207 RVA: 0x000168F9 File Offset: 0x00014AF9
		public void SetUseZoomFactor(bool useZoomFactor)
		{
		}

		// Token: 0x060004B8 RID: 1208 RVA: 0x000168FB File Offset: 0x00014AFB
		public void SetSliderCapShadeMode(GizmoShadeMode shadeMode)
		{
		}

		// Token: 0x060004B9 RID: 1209 RVA: 0x000168FD File Offset: 0x00014AFD
		public void SetSliderCapFillMode(GizmoFillMode3D fillMode)
		{
		}

		// Token: 0x060004BA RID: 1210 RVA: 0x000168FF File Offset: 0x00014AFF
		public void SetAxisColor(int axisIndex, Color color)
		{
		}

		// Token: 0x060004BB RID: 1211 RVA: 0x00016901 File Offset: 0x00014B01
		public void SetHoveredColor(Color hoveredColor)
		{
		}

		// Token: 0x060004BC RID: 1212 RVA: 0x00016903 File Offset: 0x00014B03
		public void ConnectSliderLookAndFeel(GizmoLineSlider3D slider, int axisIndex, AxisSign axisSign)
		{
		}

		// Token: 0x060004BD RID: 1213 RVA: 0x00016905 File Offset: 0x00014B05
		private GizmoLineSlider3DLookAndFeel GetSglSliderLookAndFeel(int axisIndex, AxisSign axisSign)
		{
			return null;
		}

		// Token: 0x0400017E RID: 382
		private Color _boxWireColor;

		// Token: 0x0400017F RID: 383
		private GizmoLineSlider3DLookAndFeel[] _sglSlidersLookAndFeel;

		// Token: 0x04000180 RID: 384
		private bool[] _extrudeSliderVis;
	}
}
