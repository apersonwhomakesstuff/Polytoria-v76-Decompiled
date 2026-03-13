using System;

namespace RLD
{
	// Token: 0x020000DE RID: 222
	[Serializable]
	public class MoveGizmoSettings2D : Settings
	{
		// Token: 0x17000346 RID: 838
		// (get) Token: 0x060009FC RID: 2556 RVA: 0x00017841 File Offset: 0x00015A41
		public float LineSliderHoverEps
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000347 RID: 839
		// (get) Token: 0x060009FD RID: 2557 RVA: 0x00017848 File Offset: 0x00015A48
		public float BoxSliderHoverEps
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000348 RID: 840
		// (get) Token: 0x060009FE RID: 2558 RVA: 0x0001784F File Offset: 0x00015A4F
		public float XSnapStep
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000349 RID: 841
		// (get) Token: 0x060009FF RID: 2559 RVA: 0x00017856 File Offset: 0x00015A56
		public float YSnapStep
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700034A RID: 842
		// (get) Token: 0x06000A00 RID: 2560 RVA: 0x0001785D File Offset: 0x00015A5D
		public float DragSensitivity
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x06000A02 RID: 2562 RVA: 0x0001786C File Offset: 0x00015A6C
		public void SetLineSliderHoverEps(float eps)
		{
		}

		// Token: 0x06000A03 RID: 2563 RVA: 0x0001786E File Offset: 0x00015A6E
		public void SetBoxSliderHoverEps(float eps)
		{
		}

		// Token: 0x06000A04 RID: 2564 RVA: 0x00017870 File Offset: 0x00015A70
		public void SetXSnapStep(float snapStep)
		{
		}

		// Token: 0x06000A05 RID: 2565 RVA: 0x00017872 File Offset: 0x00015A72
		public void SetYSnapStep(float snapStep)
		{
		}

		// Token: 0x06000A06 RID: 2566 RVA: 0x00017874 File Offset: 0x00015A74
		public void SetDragSensitivity(float sensitivity)
		{
		}

		// Token: 0x06000A07 RID: 2567 RVA: 0x00017876 File Offset: 0x00015A76
		public void ConnectSliderSettings(GizmoLineSlider2D slider, int axisIndex, AxisSign axisSign)
		{
		}

		// Token: 0x06000A08 RID: 2568 RVA: 0x00017878 File Offset: 0x00015A78
		public void ConnectDblSliderSettings(GizmoPlaneSlider2D slider)
		{
		}

		// Token: 0x06000A09 RID: 2569 RVA: 0x0001787A File Offset: 0x00015A7A
		private GizmoLineSlider2DSettings GetSliderSettings(int axisIndex, AxisSign axisSign)
		{
			return null;
		}

		// Token: 0x040003EC RID: 1004
		private GizmoPlaneSlider2DSettings _dblSliderSettings;

		// Token: 0x040003ED RID: 1005
		private GizmoLineSlider2DSettings[] _sglSliderSettings;
	}
}
