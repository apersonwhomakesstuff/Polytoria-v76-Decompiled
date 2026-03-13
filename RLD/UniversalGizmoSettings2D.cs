using System;

namespace RLD
{
	// Token: 0x020000EE RID: 238
	[Serializable]
	public class UniversalGizmoSettings2D : Settings
	{
		// Token: 0x17000478 RID: 1144
		// (get) Token: 0x06000D1D RID: 3357 RVA: 0x00018150 File Offset: 0x00016350
		public float MvLineSliderHoverEps
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000479 RID: 1145
		// (get) Token: 0x06000D1E RID: 3358 RVA: 0x00018157 File Offset: 0x00016357
		public float MvBoxSliderHoverEps
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700047A RID: 1146
		// (get) Token: 0x06000D1F RID: 3359 RVA: 0x0001815E File Offset: 0x0001635E
		public float MvXSnapStep
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700047B RID: 1147
		// (get) Token: 0x06000D20 RID: 3360 RVA: 0x00018165 File Offset: 0x00016365
		public float MvYSnapStep
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700047C RID: 1148
		// (get) Token: 0x06000D21 RID: 3361 RVA: 0x0001816C File Offset: 0x0001636C
		public float MvDragSensitivity
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700047D RID: 1149
		// (get) Token: 0x06000D22 RID: 3362 RVA: 0x0002034C File Offset: 0x0001E54C
		// (set) Token: 0x06000D23 RID: 3363 RVA: 0x00018173 File Offset: 0x00016373
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

		// Token: 0x06000D25 RID: 3365 RVA: 0x0001817D File Offset: 0x0001637D
		public void SetMvLineSliderHoverEps(float eps)
		{
		}

		// Token: 0x06000D26 RID: 3366 RVA: 0x0001817F File Offset: 0x0001637F
		public void SetMvBoxSliderHoverEps(float eps)
		{
		}

		// Token: 0x06000D27 RID: 3367 RVA: 0x00018181 File Offset: 0x00016381
		public void SetMvXSnapStep(float snapStep)
		{
		}

		// Token: 0x06000D28 RID: 3368 RVA: 0x00018183 File Offset: 0x00016383
		public void SetMvYSnapStep(float snapStep)
		{
		}

		// Token: 0x06000D29 RID: 3369 RVA: 0x00018185 File Offset: 0x00016385
		public void SetMvDragSensitivity(float sensitivity)
		{
		}

		// Token: 0x06000D2A RID: 3370 RVA: 0x00018187 File Offset: 0x00016387
		public void ConnectMvSliderSettings(GizmoLineSlider2D slider, int axisIndex, AxisSign axisSign)
		{
		}

		// Token: 0x06000D2B RID: 3371 RVA: 0x00018189 File Offset: 0x00016389
		public void ConnectMvDblSliderSettings(GizmoPlaneSlider2D slider)
		{
		}

		// Token: 0x06000D2C RID: 3372 RVA: 0x0001818B File Offset: 0x0001638B
		public void Inherit(MoveGizmoSettings2D settings)
		{
		}

		// Token: 0x06000D2D RID: 3373 RVA: 0x0001818D File Offset: 0x0001638D
		private GizmoLineSlider2DSettings GetMvSliderSettings(int axisIndex, AxisSign axisSign)
		{
			return null;
		}

		// Token: 0x04000492 RID: 1170
		private UniversalGizmoSettingsCategory _displayCategory;

		// Token: 0x04000493 RID: 1171
		private GizmoPlaneSlider2DSettings _mvDblSliderSettings;

		// Token: 0x04000494 RID: 1172
		private GizmoLineSlider2DSettings[] _mvSglSliderSettings;
	}
}
