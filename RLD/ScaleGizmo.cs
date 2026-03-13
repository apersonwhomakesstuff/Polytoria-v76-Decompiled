using System;
using System.Collections.Generic;
using UnityEngine;

namespace RLD
{
	// Token: 0x020000E6 RID: 230
	[Serializable]
	public class ScaleGizmo : GizmoBehaviour
	{
		// Token: 0x17000394 RID: 916
		// (get) Token: 0x06000AD7 RID: 2775 RVA: 0x0001FB24 File Offset: 0x0001DD24
		public GizmoMultiAxisScaleMode MultiAxisScaleMode
		{
			get
			{
				return GizmoMultiAxisScaleMode.DoubleAxis;
			}
		}

		// Token: 0x17000395 RID: 917
		// (get) Token: 0x06000AD8 RID: 2776 RVA: 0x00017AC1 File Offset: 0x00015CC1
		public ScaleGizmoLookAndFeel3D LookAndFeel3D
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000396 RID: 918
		// (get) Token: 0x06000AD9 RID: 2777 RVA: 0x00017AC4 File Offset: 0x00015CC4
		public ScaleGizmoSettings3D Settings3D
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000397 RID: 919
		// (get) Token: 0x06000ADA RID: 2778 RVA: 0x00017AC7 File Offset: 0x00015CC7
		public ScaleGizmoHotkeys Hotkeys
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000398 RID: 920
		// (get) Token: 0x06000ADB RID: 2779 RVA: 0x00017ACA File Offset: 0x00015CCA
		// (set) Token: 0x06000ADC RID: 2780 RVA: 0x00017ACD File Offset: 0x00015CCD
		public ScaleGizmoHotkeys SharedHotkeys
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x17000399 RID: 921
		// (get) Token: 0x06000ADD RID: 2781 RVA: 0x00017ACF File Offset: 0x00015CCF
		// (set) Token: 0x06000ADE RID: 2782 RVA: 0x00017AD2 File Offset: 0x00015CD2
		public ScaleGizmoSettings3D SharedSettings3D
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x1700039A RID: 922
		// (get) Token: 0x06000ADF RID: 2783 RVA: 0x00017AD4 File Offset: 0x00015CD4
		// (set) Token: 0x06000AE0 RID: 2784 RVA: 0x00017AD7 File Offset: 0x00015CD7
		public ScaleGizmoLookAndFeel3D SharedLookAndFeel3D
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x1700039B RID: 923
		// (get) Token: 0x06000AE1 RID: 2785 RVA: 0x00017AD9 File Offset: 0x00015CD9
		// (set) Token: 0x06000AE2 RID: 2786 RVA: 0x00017ADC File Offset: 0x00015CDC
		public bool UseSnapEnableHotkey
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x1700039C RID: 924
		// (get) Token: 0x06000AE3 RID: 2787 RVA: 0x00017ADE File Offset: 0x00015CDE
		// (set) Token: 0x06000AE4 RID: 2788 RVA: 0x00017AE1 File Offset: 0x00015CE1
		public bool UseMultiAxisScaleModeHotkey
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x06000AE5 RID: 2789 RVA: 0x00017AE3 File Offset: 0x00015CE3
		public float GetZoomFactor(Vector3 position)
		{
			return 0f;
		}

		// Token: 0x06000AE6 RID: 2790 RVA: 0x00017AEA File Offset: 0x00015CEA
		public float GetZoomFactor(Vector3 position, Camera camera)
		{
			return 0f;
		}

		// Token: 0x06000AE7 RID: 2791 RVA: 0x00017AF1 File Offset: 0x00015CF1
		public bool OwnsHandle(int handleId)
		{
			return false;
		}

		// Token: 0x06000AE8 RID: 2792 RVA: 0x00017AF4 File Offset: 0x00015CF4
		public void SetAxesLinesHoverable(bool hoverable)
		{
		}

		// Token: 0x06000AE9 RID: 2793 RVA: 0x00017AF6 File Offset: 0x00015CF6
		public void SetSnapEnabled(bool isEnabled)
		{
		}

		// Token: 0x06000AEA RID: 2794 RVA: 0x00017AF8 File Offset: 0x00015CF8
		public void SetMultiAxisScaleMode(GizmoMultiAxisScaleMode scaleMode)
		{
		}

		// Token: 0x06000AEB RID: 2795 RVA: 0x00017AFA File Offset: 0x00015CFA
		public void SetScaleGuideTargetObjects(IEnumerable<GameObject> targetObjects)
		{
		}

		// Token: 0x06000AEC RID: 2796 RVA: 0x00017AFC File Offset: 0x00015CFC
		public override void OnGizmoEnabled()
		{
		}

		// Token: 0x06000AED RID: 2797 RVA: 0x00017AFE File Offset: 0x00015CFE
		public override void OnAttached()
		{
		}

		// Token: 0x06000AEE RID: 2798 RVA: 0x00017B00 File Offset: 0x00015D00
		public override void OnGizmoUpdateBegin()
		{
		}

		// Token: 0x06000AEF RID: 2799 RVA: 0x00017B02 File Offset: 0x00015D02
		public override void OnGizmoRender(Camera camera)
		{
		}

		// Token: 0x06000AF0 RID: 2800 RVA: 0x00017B04 File Offset: 0x00015D04
		public override void OnGizmoAttemptHandleDragBegin(int handleId)
		{
		}

		// Token: 0x06000AF1 RID: 2801 RVA: 0x00017B06 File Offset: 0x00015D06
		private void PlaceDblSlidersInSliderPlanes(Camera camera)
		{
		}

		// Token: 0x06000AF2 RID: 2802 RVA: 0x00017B08 File Offset: 0x00015D08
		private void SetupSharedLookAndFeel()
		{
		}

		// Token: 0x06000AF3 RID: 2803 RVA: 0x00017B0A File Offset: 0x00015D0A
		private void SetupSharedSettings()
		{
		}

		// Token: 0x0400041F RID: 1055
		private GizmoLineSlider3D _pstvXSlider;

		// Token: 0x04000420 RID: 1056
		private GizmoLineSlider3D _pstvYSlider;

		// Token: 0x04000421 RID: 1057
		private GizmoLineSlider3D _pstvZSlider;

		// Token: 0x04000422 RID: 1058
		private GizmoLineSlider3D _negXSlider;

		// Token: 0x04000423 RID: 1059
		private GizmoLineSlider3D _negYSlider;

		// Token: 0x04000424 RID: 1060
		private GizmoLineSlider3D _negZSlider;

		// Token: 0x04000425 RID: 1061
		private GizmoLineSlider3DCollection _axesSliders;

		// Token: 0x04000426 RID: 1062
		private GizmoMultiAxisScaleMode _multiAxisScaleMode;

		// Token: 0x04000427 RID: 1063
		private GizmoPlaneSlider3D _xySlider;

		// Token: 0x04000428 RID: 1064
		private GizmoPlaneSlider3D _yzSlider;

		// Token: 0x04000429 RID: 1065
		private GizmoPlaneSlider3D _zxSlider;

		// Token: 0x0400042A RID: 1066
		private GizmoPlaneSlider3DCollection _dblSliders;

		// Token: 0x0400042B RID: 1067
		private GizmoCap3D _midCap;

		// Token: 0x0400042C RID: 1068
		private GizmoUniformScaleDrag3D _unformScaleDrag;

		// Token: 0x0400042D RID: 1069
		private GizmoScaleGuide _scaleGuide;

		// Token: 0x0400042E RID: 1070
		private IEnumerable<GameObject> _scaleGuideTargetObjects;

		// Token: 0x0400042F RID: 1071
		private ScaleGizmoLookAndFeel3D _lookAndFeel3D;

		// Token: 0x04000430 RID: 1072
		private ScaleGizmoSettings3D _settings3D;

		// Token: 0x04000431 RID: 1073
		private ScaleGizmoHotkeys _hotkeys;

		// Token: 0x04000432 RID: 1074
		private bool _useSnapEnableHotkey;

		// Token: 0x04000433 RID: 1075
		private bool _useMultiAxisScaleModeHotkey;

		// Token: 0x04000434 RID: 1076
		private ScaleGizmoLookAndFeel3D _sharedLookAndFeel3D;

		// Token: 0x04000435 RID: 1077
		private ScaleGizmoSettings3D _sharedSettings3D;

		// Token: 0x04000436 RID: 1078
		private ScaleGizmoHotkeys _sharedHotkeys;
	}
}
