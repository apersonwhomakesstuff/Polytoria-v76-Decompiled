using System;

namespace RLD
{
	// Token: 0x020000EF RID: 239
	[Serializable]
	public class UniversalGizmoSettings3D : Settings
	{
		// Token: 0x1700047E RID: 1150
		// (get) Token: 0x06000D2E RID: 3374 RVA: 0x00018190 File Offset: 0x00016390
		public GizmoObjectVertexSnapSettings VertexSnapSettings
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700047F RID: 1151
		// (get) Token: 0x06000D2F RID: 3375 RVA: 0x00018193 File Offset: 0x00016393
		public float MvLineSliderHoverEps
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000480 RID: 1152
		// (get) Token: 0x06000D30 RID: 3376 RVA: 0x0001819A File Offset: 0x0001639A
		public float MvBoxSliderHoverEps
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000481 RID: 1153
		// (get) Token: 0x06000D31 RID: 3377 RVA: 0x000181A1 File Offset: 0x000163A1
		public float MvCylinderSliderHoverEps
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000482 RID: 1154
		// (get) Token: 0x06000D32 RID: 3378 RVA: 0x000181A8 File Offset: 0x000163A8
		public float MvXSnapStep
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000483 RID: 1155
		// (get) Token: 0x06000D33 RID: 3379 RVA: 0x000181AF File Offset: 0x000163AF
		public float MvYSnapStep
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000484 RID: 1156
		// (get) Token: 0x06000D34 RID: 3380 RVA: 0x000181B6 File Offset: 0x000163B6
		public float MvZSnapStep
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000485 RID: 1157
		// (get) Token: 0x06000D35 RID: 3381 RVA: 0x000181BD File Offset: 0x000163BD
		public float MvDragSensitivity
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000486 RID: 1158
		// (get) Token: 0x06000D36 RID: 3382 RVA: 0x000181C4 File Offset: 0x000163C4
		public float RtAxisLineHoverEps
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000487 RID: 1159
		// (get) Token: 0x06000D37 RID: 3383 RVA: 0x000181CB File Offset: 0x000163CB
		public float RtAxisTorusHoverEps
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000488 RID: 1160
		// (get) Token: 0x06000D38 RID: 3384 RVA: 0x000181D2 File Offset: 0x000163D2
		public float RtCamLookLineHoverEps
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000489 RID: 1161
		// (get) Token: 0x06000D39 RID: 3385 RVA: 0x000181D9 File Offset: 0x000163D9
		public float RtCamLookThickHoverEps
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700048A RID: 1162
		// (get) Token: 0x06000D3A RID: 3386 RVA: 0x000181E0 File Offset: 0x000163E0
		public bool RtCanHoverCulledPixels
		{
			get
			{
				return false;
			}
		}

		// Token: 0x1700048B RID: 1163
		// (get) Token: 0x06000D3B RID: 3387 RVA: 0x00020364 File Offset: 0x0001E564
		public GizmoSnapMode RtSnapMode
		{
			get
			{
				return GizmoSnapMode.Relative;
			}
		}

		// Token: 0x1700048C RID: 1164
		// (get) Token: 0x06000D3C RID: 3388 RVA: 0x000181E3 File Offset: 0x000163E3
		public float RtXSnapStep
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700048D RID: 1165
		// (get) Token: 0x06000D3D RID: 3389 RVA: 0x000181EA File Offset: 0x000163EA
		public float RtYSnapStep
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700048E RID: 1166
		// (get) Token: 0x06000D3E RID: 3390 RVA: 0x000181F1 File Offset: 0x000163F1
		public float RtZSnapStep
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700048F RID: 1167
		// (get) Token: 0x06000D3F RID: 3391 RVA: 0x000181F8 File Offset: 0x000163F8
		public float RtCamRightSnapStep
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000490 RID: 1168
		// (get) Token: 0x06000D40 RID: 3392 RVA: 0x000181FF File Offset: 0x000163FF
		public float RtCamUpSnapStep
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000491 RID: 1169
		// (get) Token: 0x06000D41 RID: 3393 RVA: 0x00018206 File Offset: 0x00016406
		public float RtCamLookSnapStep
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000492 RID: 1170
		// (get) Token: 0x06000D42 RID: 3394 RVA: 0x0001820D File Offset: 0x0001640D
		public float RtDragSensitivity
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000493 RID: 1171
		// (get) Token: 0x06000D43 RID: 3395 RVA: 0x00018214 File Offset: 0x00016414
		public float ScLineSliderHoverEps
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000494 RID: 1172
		// (get) Token: 0x06000D44 RID: 3396 RVA: 0x0001821B File Offset: 0x0001641B
		public float ScBoxSliderHoverEps
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000495 RID: 1173
		// (get) Token: 0x06000D45 RID: 3397 RVA: 0x00018222 File Offset: 0x00016422
		public float ScCylinderSliderHoverEps
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000496 RID: 1174
		// (get) Token: 0x06000D46 RID: 3398 RVA: 0x00018229 File Offset: 0x00016429
		public float ScXSnapStep
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000497 RID: 1175
		// (get) Token: 0x06000D47 RID: 3399 RVA: 0x00018230 File Offset: 0x00016430
		public float ScYSnapStep
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000498 RID: 1176
		// (get) Token: 0x06000D48 RID: 3400 RVA: 0x00018237 File Offset: 0x00016437
		public float ScZSnapStep
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000499 RID: 1177
		// (get) Token: 0x06000D49 RID: 3401 RVA: 0x0001823E File Offset: 0x0001643E
		public float ScXYSnapStep
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700049A RID: 1178
		// (get) Token: 0x06000D4A RID: 3402 RVA: 0x00018245 File Offset: 0x00016445
		public float ScYZSnapStep
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700049B RID: 1179
		// (get) Token: 0x06000D4B RID: 3403 RVA: 0x0001824C File Offset: 0x0001644C
		public float ScZXSnapStep
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700049C RID: 1180
		// (get) Token: 0x06000D4C RID: 3404 RVA: 0x00018253 File Offset: 0x00016453
		public float ScUniformSnapStep
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700049D RID: 1181
		// (get) Token: 0x06000D4D RID: 3405 RVA: 0x0001825A File Offset: 0x0001645A
		public float ScDragSensitivity
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700049E RID: 1182
		// (get) Token: 0x06000D4E RID: 3406 RVA: 0x0002037C File Offset: 0x0001E57C
		// (set) Token: 0x06000D4F RID: 3407 RVA: 0x00018261 File Offset: 0x00016461
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

		// Token: 0x06000D51 RID: 3409 RVA: 0x0001826B File Offset: 0x0001646B
		public void SetMvLineSliderHoverEps(float eps)
		{
		}

		// Token: 0x06000D52 RID: 3410 RVA: 0x0001826D File Offset: 0x0001646D
		public void SetMvBoxSliderHoverEps(float eps)
		{
		}

		// Token: 0x06000D53 RID: 3411 RVA: 0x0001826F File Offset: 0x0001646F
		public void SetMvCylinderSliderHoverEps(float eps)
		{
		}

		// Token: 0x06000D54 RID: 3412 RVA: 0x00018271 File Offset: 0x00016471
		public void SetMvXSnapStep(float snapStep)
		{
		}

		// Token: 0x06000D55 RID: 3413 RVA: 0x00018273 File Offset: 0x00016473
		public void SetMvYSnapStep(float snapStep)
		{
		}

		// Token: 0x06000D56 RID: 3414 RVA: 0x00018275 File Offset: 0x00016475
		public void SetMvZSnapStep(float snapStep)
		{
		}

		// Token: 0x06000D57 RID: 3415 RVA: 0x00018277 File Offset: 0x00016477
		public void SetMvDragSensitivity(float sensitivity)
		{
		}

		// Token: 0x06000D58 RID: 3416 RVA: 0x00018279 File Offset: 0x00016479
		public void ConnectMvSliderSettings(GizmoLineSlider3D slider, int axisIndex, AxisSign axisSign)
		{
		}

		// Token: 0x06000D59 RID: 3417 RVA: 0x0001827B File Offset: 0x0001647B
		public void ConnectMvDblSliderSettings(GizmoPlaneSlider3D dblSlider, PlaneId planeId)
		{
		}

		// Token: 0x06000D5A RID: 3418 RVA: 0x0001827D File Offset: 0x0001647D
		public void Inherit(MoveGizmoSettings3D settings)
		{
		}

		// Token: 0x06000D5B RID: 3419 RVA: 0x0001827F File Offset: 0x0001647F
		private GizmoLineSlider3DSettings GetMvSglSliderSettings(int axisIndex, AxisSign axisSign)
		{
			return null;
		}

		// Token: 0x06000D5C RID: 3420 RVA: 0x00018282 File Offset: 0x00016482
		private GizmoPlaneSlider3DSettings GetMvDblSliderSettings(PlaneId planeId)
		{
			return null;
		}

		// Token: 0x06000D5D RID: 3421 RVA: 0x00018285 File Offset: 0x00016485
		public void SetRtCanHoverCulledPixels(bool canHover)
		{
		}

		// Token: 0x06000D5E RID: 3422 RVA: 0x00018287 File Offset: 0x00016487
		public void SetRtAxisLineHoverEps(float eps)
		{
		}

		// Token: 0x06000D5F RID: 3423 RVA: 0x00018289 File Offset: 0x00016489
		public void SetRtAxisTorusHoverEps(float eps)
		{
		}

		// Token: 0x06000D60 RID: 3424 RVA: 0x0001828B File Offset: 0x0001648B
		public void SetRtCamLookLineHoverEps(float eps)
		{
		}

		// Token: 0x06000D61 RID: 3425 RVA: 0x0001828D File Offset: 0x0001648D
		public void SetRtCamLookThickHoverEps(float eps)
		{
		}

		// Token: 0x06000D62 RID: 3426 RVA: 0x0001828F File Offset: 0x0001648F
		public void SetRtAxisSnapStep(int axisIndex, float snapStep)
		{
		}

		// Token: 0x06000D63 RID: 3427 RVA: 0x00018291 File Offset: 0x00016491
		public void SetRtCamRightSnapStep(float snapStep)
		{
		}

		// Token: 0x06000D64 RID: 3428 RVA: 0x00018293 File Offset: 0x00016493
		public void SetRtCamUpSnapStep(float snapStep)
		{
		}

		// Token: 0x06000D65 RID: 3429 RVA: 0x00018295 File Offset: 0x00016495
		public void SetRtCamLookSnapStep(float snapStep)
		{
		}

		// Token: 0x06000D66 RID: 3430 RVA: 0x00018297 File Offset: 0x00016497
		public void SetRtSnapMode(GizmoSnapMode snapMode)
		{
		}

		// Token: 0x06000D67 RID: 3431 RVA: 0x00018299 File Offset: 0x00016499
		public void SetRtDragSensitivity(float sensitivity)
		{
		}

		// Token: 0x06000D68 RID: 3432 RVA: 0x0001829B File Offset: 0x0001649B
		public void ConnectRtSliderSettings(GizmoPlaneSlider3D slider, int axisIndex)
		{
		}

		// Token: 0x06000D69 RID: 3433 RVA: 0x0001829D File Offset: 0x0001649D
		public void ConnectRtCamLookSliderSettings(GizmoPlaneSlider2D slider)
		{
		}

		// Token: 0x06000D6A RID: 3434 RVA: 0x0001829F File Offset: 0x0001649F
		public void Inherit(RotationGizmoSettings3D settings)
		{
		}

		// Token: 0x06000D6B RID: 3435 RVA: 0x000182A1 File Offset: 0x000164A1
		public void SetScLineSliderHoverEps(float eps)
		{
		}

		// Token: 0x06000D6C RID: 3436 RVA: 0x000182A3 File Offset: 0x000164A3
		public void SetScBoxSliderHoverEps(float eps)
		{
		}

		// Token: 0x06000D6D RID: 3437 RVA: 0x000182A5 File Offset: 0x000164A5
		public void SetScCylinderSliderHoverEps(float eps)
		{
		}

		// Token: 0x06000D6E RID: 3438 RVA: 0x000182A7 File Offset: 0x000164A7
		public void SetScXSnapStep(float snapStep)
		{
		}

		// Token: 0x06000D6F RID: 3439 RVA: 0x000182A9 File Offset: 0x000164A9
		public void SetScYSnapStep(float snapStep)
		{
		}

		// Token: 0x06000D70 RID: 3440 RVA: 0x000182AB File Offset: 0x000164AB
		public void SetScZSnapStep(float snapStep)
		{
		}

		// Token: 0x06000D71 RID: 3441 RVA: 0x000182AD File Offset: 0x000164AD
		public void SetScXYSnapStep(float snapStep)
		{
		}

		// Token: 0x06000D72 RID: 3442 RVA: 0x000182AF File Offset: 0x000164AF
		public void SetScYZSnapStep(float snapStep)
		{
		}

		// Token: 0x06000D73 RID: 3443 RVA: 0x000182B1 File Offset: 0x000164B1
		public void SetScZXSnapStep(float snapStep)
		{
		}

		// Token: 0x06000D74 RID: 3444 RVA: 0x000182B3 File Offset: 0x000164B3
		public void SetScUniformScaleSnapStep(float snapStep)
		{
		}

		// Token: 0x06000D75 RID: 3445 RVA: 0x000182B5 File Offset: 0x000164B5
		public void SetScDragSensitivity(float sensitivity)
		{
		}

		// Token: 0x06000D76 RID: 3446 RVA: 0x000182B7 File Offset: 0x000164B7
		public void ConnectScSliderSettings(GizmoLineSlider3D slider, int axisIndex, AxisSign axisSign)
		{
		}

		// Token: 0x06000D77 RID: 3447 RVA: 0x000182B9 File Offset: 0x000164B9
		public void ConnectScDblSliderSettings(GizmoPlaneSlider3D dblSlider, PlaneId planeId)
		{
		}

		// Token: 0x06000D78 RID: 3448 RVA: 0x000182BB File Offset: 0x000164BB
		public void Inherit(ScaleGizmoSettings3D settings)
		{
		}

		// Token: 0x06000D79 RID: 3449 RVA: 0x000182BD File Offset: 0x000164BD
		private GizmoLineSlider3DSettings GetScSglSliderSettings(int axisIndex, AxisSign axisSign)
		{
			return null;
		}

		// Token: 0x06000D7A RID: 3450 RVA: 0x000182C0 File Offset: 0x000164C0
		private GizmoPlaneSlider3DSettings GetScDblSliderSettings(PlaneId planeId)
		{
			return null;
		}

		// Token: 0x04000495 RID: 1173
		private UniversalGizmoSettingsCategory _displayCategory;

		// Token: 0x04000496 RID: 1174
		private GizmoObjectVertexSnapSettings _mvVertexSnapSettings;

		// Token: 0x04000497 RID: 1175
		private GizmoLineSlider3DSettings[] _mvSglSliderSettings;

		// Token: 0x04000498 RID: 1176
		private GizmoPlaneSlider3DSettings[] _mvDblSliderSettings;

		// Token: 0x04000499 RID: 1177
		private float _rtCamRightSnapStep;

		// Token: 0x0400049A RID: 1178
		private float _rtCamUpSnapStep;

		// Token: 0x0400049B RID: 1179
		private GizmoPlaneSlider3DSettings[] _rtSliderSettings;

		// Token: 0x0400049C RID: 1180
		private GizmoPlaneSlider2DSettings _rtCamLookSliderSettings;

		// Token: 0x0400049D RID: 1181
		private float _scUniformSnapStep;

		// Token: 0x0400049E RID: 1182
		private GizmoLineSlider3DSettings[] _scSglSliderSettings;

		// Token: 0x0400049F RID: 1183
		private GizmoPlaneSlider3DSettings[] _scDblSliderSettings;
	}
}
