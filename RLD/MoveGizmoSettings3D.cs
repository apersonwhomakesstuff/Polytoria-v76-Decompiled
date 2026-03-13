using System;

namespace RLD
{
	// Token: 0x020000DF RID: 223
	[Serializable]
	public class MoveGizmoSettings3D : Settings
	{
		// Token: 0x1700034B RID: 843
		// (get) Token: 0x06000A0A RID: 2570 RVA: 0x0001787D File Offset: 0x00015A7D
		public GizmoObjectVertexSnapSettings VertexSnapSettings
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700034C RID: 844
		// (get) Token: 0x06000A0B RID: 2571 RVA: 0x00017880 File Offset: 0x00015A80
		public float LineSliderHoverEps
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700034D RID: 845
		// (get) Token: 0x06000A0C RID: 2572 RVA: 0x00017887 File Offset: 0x00015A87
		public float BoxSliderHoverEps
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700034E RID: 846
		// (get) Token: 0x06000A0D RID: 2573 RVA: 0x0001788E File Offset: 0x00015A8E
		public float CylinderSliderHoverEps
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700034F RID: 847
		// (get) Token: 0x06000A0E RID: 2574 RVA: 0x00017895 File Offset: 0x00015A95
		public float XSnapStep
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000350 RID: 848
		// (get) Token: 0x06000A0F RID: 2575 RVA: 0x0001789C File Offset: 0x00015A9C
		public float YSnapStep
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000351 RID: 849
		// (get) Token: 0x06000A10 RID: 2576 RVA: 0x000178A3 File Offset: 0x00015AA3
		public float ZSnapStep
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000352 RID: 850
		// (get) Token: 0x06000A11 RID: 2577 RVA: 0x000178AA File Offset: 0x00015AAA
		public float DragSensitivity
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x06000A13 RID: 2579 RVA: 0x000178B9 File Offset: 0x00015AB9
		public void SetLineSliderHoverEps(float eps)
		{
		}

		// Token: 0x06000A14 RID: 2580 RVA: 0x000178BB File Offset: 0x00015ABB
		public void SetBoxSliderHoverEps(float eps)
		{
		}

		// Token: 0x06000A15 RID: 2581 RVA: 0x000178BD File Offset: 0x00015ABD
		public void SetCylinderSliderHoverEps(float eps)
		{
		}

		// Token: 0x06000A16 RID: 2582 RVA: 0x000178BF File Offset: 0x00015ABF
		public void SetXSnapStep(float snapStep)
		{
		}

		// Token: 0x06000A17 RID: 2583 RVA: 0x000178C1 File Offset: 0x00015AC1
		public void SetYSnapStep(float snapStep)
		{
		}

		// Token: 0x06000A18 RID: 2584 RVA: 0x000178C3 File Offset: 0x00015AC3
		public void SetZSnapStep(float snapStep)
		{
		}

		// Token: 0x06000A19 RID: 2585 RVA: 0x000178C5 File Offset: 0x00015AC5
		public void SetDragSensitivity(float sensitivity)
		{
		}

		// Token: 0x06000A1A RID: 2586 RVA: 0x000178C7 File Offset: 0x00015AC7
		public void ConnectSliderSettings(GizmoLineSlider3D slider, int axisIndex, AxisSign axisSign)
		{
		}

		// Token: 0x06000A1B RID: 2587 RVA: 0x000178C9 File Offset: 0x00015AC9
		public void ConnectDblSliderSettings(GizmoPlaneSlider3D dblSlider, PlaneId planeId)
		{
		}

		// Token: 0x06000A1C RID: 2588 RVA: 0x000178CB File Offset: 0x00015ACB
		private GizmoLineSlider3DSettings GetSglSliderSettings(int axisIndex, AxisSign axisSign)
		{
			return null;
		}

		// Token: 0x06000A1D RID: 2589 RVA: 0x000178CE File Offset: 0x00015ACE
		private GizmoPlaneSlider3DSettings GetDblSliderSettings(PlaneId planeId)
		{
			return null;
		}

		// Token: 0x040003EE RID: 1006
		private GizmoObjectVertexSnapSettings _vertexSnapSettings;

		// Token: 0x040003EF RID: 1007
		private GizmoLineSlider3DSettings[] _sglSliderSettings;

		// Token: 0x040003F0 RID: 1008
		private GizmoPlaneSlider3DSettings[] _dblSliderSettings;
	}
}
