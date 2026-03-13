using System;
using System.Collections.Generic;
using UnityEngine;

namespace RLD
{
	// Token: 0x020000EA RID: 234
	[Serializable]
	public class UniversalGizmo : GizmoBehaviour
	{
		// Token: 0x170003D2 RID: 978
		// (get) Token: 0x06000B78 RID: 2936 RVA: 0x00017CD0 File Offset: 0x00015ED0
		public UniversalGizmoSettings2D Settings2D
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170003D3 RID: 979
		// (get) Token: 0x06000B79 RID: 2937 RVA: 0x00017CD3 File Offset: 0x00015ED3
		// (set) Token: 0x06000B7A RID: 2938 RVA: 0x00017CD6 File Offset: 0x00015ED6
		public UniversalGizmoSettings2D SharedSettings2D
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x170003D4 RID: 980
		// (get) Token: 0x06000B7B RID: 2939 RVA: 0x00017CD8 File Offset: 0x00015ED8
		public UniversalGizmoSettings3D Settings3D
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170003D5 RID: 981
		// (get) Token: 0x06000B7C RID: 2940 RVA: 0x00017CDB File Offset: 0x00015EDB
		// (set) Token: 0x06000B7D RID: 2941 RVA: 0x00017CDE File Offset: 0x00015EDE
		public UniversalGizmoSettings3D SharedSettings3D
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x170003D6 RID: 982
		// (get) Token: 0x06000B7E RID: 2942 RVA: 0x00017CE0 File Offset: 0x00015EE0
		public UniversalGizmoLookAndFeel2D LookAndFeel2D
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170003D7 RID: 983
		// (get) Token: 0x06000B7F RID: 2943 RVA: 0x00017CE3 File Offset: 0x00015EE3
		// (set) Token: 0x06000B80 RID: 2944 RVA: 0x00017CE6 File Offset: 0x00015EE6
		public UniversalGizmoLookAndFeel2D SharedLookAndFeel2D
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x170003D8 RID: 984
		// (get) Token: 0x06000B81 RID: 2945 RVA: 0x00017CE8 File Offset: 0x00015EE8
		public UniversalGizmoLookAndFeel3D LookAndFeel3D
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170003D9 RID: 985
		// (get) Token: 0x06000B82 RID: 2946 RVA: 0x00017CEB File Offset: 0x00015EEB
		// (set) Token: 0x06000B83 RID: 2947 RVA: 0x00017CEE File Offset: 0x00015EEE
		public UniversalGizmoLookAndFeel3D SharedLookAndFeel3D
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x170003DA RID: 986
		// (get) Token: 0x06000B84 RID: 2948 RVA: 0x00017CF0 File Offset: 0x00015EF0
		public UniversalGizmoHotkeys Hotkeys
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170003DB RID: 987
		// (get) Token: 0x06000B85 RID: 2949 RVA: 0x00017CF3 File Offset: 0x00015EF3
		// (set) Token: 0x06000B86 RID: 2950 RVA: 0x00017CF6 File Offset: 0x00015EF6
		public UniversalGizmoHotkeys SharedHotkeys
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x170003DC RID: 988
		// (get) Token: 0x06000B87 RID: 2951 RVA: 0x00017CF8 File Offset: 0x00015EF8
		// (set) Token: 0x06000B88 RID: 2952 RVA: 0x00017CFB File Offset: 0x00015EFB
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

		// Token: 0x170003DD RID: 989
		// (get) Token: 0x06000B89 RID: 2953 RVA: 0x00017CFD File Offset: 0x00015EFD
		// (set) Token: 0x06000B8A RID: 2954 RVA: 0x00017D00 File Offset: 0x00015F00
		public bool UseVertSnapEnableHotkey
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x170003DE RID: 990
		// (get) Token: 0x06000B8B RID: 2955 RVA: 0x00017D02 File Offset: 0x00015F02
		// (set) Token: 0x06000B8C RID: 2956 RVA: 0x00017D05 File Offset: 0x00015F05
		public bool Use2DModeEnableHotkey
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x06000B8D RID: 2957 RVA: 0x0001FC8C File Offset: 0x0001DE8C
		public UniversalGizmo.MvVertexSnapState GetMvVertexSnapState()
		{
			return UniversalGizmo.MvVertexSnapState.SelectingPivot;
		}

		// Token: 0x06000B8E RID: 2958 RVA: 0x00017D07 File Offset: 0x00015F07
		public float GetMvZoomFactor(Vector3 position)
		{
			return 0f;
		}

		// Token: 0x06000B8F RID: 2959 RVA: 0x00017D0E File Offset: 0x00015F0E
		public float GetMvZoomFactor(Vector3 position, Camera camera)
		{
			return 0f;
		}

		// Token: 0x06000B90 RID: 2960 RVA: 0x00017D15 File Offset: 0x00015F15
		public float GetRtZoomFactor(Vector3 position)
		{
			return 0f;
		}

		// Token: 0x06000B91 RID: 2961 RVA: 0x00017D1C File Offset: 0x00015F1C
		public float GetRtZoomFactor(Vector3 position, Camera camera)
		{
			return 0f;
		}

		// Token: 0x06000B92 RID: 2962 RVA: 0x00017D23 File Offset: 0x00015F23
		public float GetScZoomFactor(Vector3 position)
		{
			return 0f;
		}

		// Token: 0x06000B93 RID: 2963 RVA: 0x00017D2A File Offset: 0x00015F2A
		public float GetScZoomFactor(Vector3 position, Camera camera)
		{
			return 0f;
		}

		// Token: 0x06000B94 RID: 2964 RVA: 0x00017D31 File Offset: 0x00015F31
		public bool IsDraggingMoveHandle()
		{
			return false;
		}

		// Token: 0x06000B95 RID: 2965 RVA: 0x00017D34 File Offset: 0x00015F34
		public bool IsDraggingRotationHandle()
		{
			return false;
		}

		// Token: 0x06000B96 RID: 2966 RVA: 0x00017D37 File Offset: 0x00015F37
		public bool IsDraggingScaleHandle()
		{
			return false;
		}

		// Token: 0x06000B97 RID: 2967 RVA: 0x00017D3A File Offset: 0x00015F3A
		public bool IsMoveHandle(int handleId)
		{
			return false;
		}

		// Token: 0x06000B98 RID: 2968 RVA: 0x00017D3D File Offset: 0x00015F3D
		public bool IsRotationHandle(int handleId)
		{
			return false;
		}

		// Token: 0x06000B99 RID: 2969 RVA: 0x00017D40 File Offset: 0x00015F40
		public bool IsScaleHandle(int handleId)
		{
			return false;
		}

		// Token: 0x06000B9A RID: 2970 RVA: 0x00017D43 File Offset: 0x00015F43
		public bool OwnsHandle(int handleId)
		{
			return false;
		}

		// Token: 0x06000B9B RID: 2971 RVA: 0x00017D46 File Offset: 0x00015F46
		public void SetSnapEnabled(bool isEnabled)
		{
		}

		// Token: 0x06000B9C RID: 2972 RVA: 0x00017D48 File Offset: 0x00015F48
		public void SetMvVertexSnapEnabled(bool isEnabled)
		{
		}

		// Token: 0x06000B9D RID: 2973 RVA: 0x00017D4A File Offset: 0x00015F4A
		public void Set2DModeEnabled(bool isEnabled)
		{
		}

		// Token: 0x06000B9E RID: 2974 RVA: 0x00017D4C File Offset: 0x00015F4C
		public void SetMvVertexSnapTargetObjects(IEnumerable<GameObject> targetObjects)
		{
		}

		// Token: 0x06000B9F RID: 2975 RVA: 0x00017D4E File Offset: 0x00015F4E
		public void SetMvAxesLinesHoverable(bool hoverable)
		{
		}

		// Token: 0x06000BA0 RID: 2976 RVA: 0x00017D50 File Offset: 0x00015F50
		public void SetRtMidCapHoverable(bool hoverable)
		{
		}

		// Token: 0x06000BA1 RID: 2977 RVA: 0x00017D52 File Offset: 0x00015F52
		public void SetScaleGuideTargetObjects(IEnumerable<GameObject> targetObjects)
		{
		}

		// Token: 0x06000BA2 RID: 2978 RVA: 0x00017D54 File Offset: 0x00015F54
		public override void OnAttached()
		{
		}

		// Token: 0x06000BA3 RID: 2979 RVA: 0x00017D56 File Offset: 0x00015F56
		public override void OnDetached()
		{
		}

		// Token: 0x06000BA4 RID: 2980 RVA: 0x00017D58 File Offset: 0x00015F58
		public override void OnEnabled()
		{
		}

		// Token: 0x06000BA5 RID: 2981 RVA: 0x00017D5A File Offset: 0x00015F5A
		public override void OnDisabled()
		{
		}

		// Token: 0x06000BA6 RID: 2982 RVA: 0x00017D5C File Offset: 0x00015F5C
		public override void OnGizmoEnabled()
		{
		}

		// Token: 0x06000BA7 RID: 2983 RVA: 0x00017D5E File Offset: 0x00015F5E
		public override void OnGizmoUpdateBegin()
		{
		}

		// Token: 0x06000BA8 RID: 2984 RVA: 0x00017D60 File Offset: 0x00015F60
		public override void OnGizmoRender(Camera camera)
		{
		}

		// Token: 0x06000BA9 RID: 2985 RVA: 0x00017D62 File Offset: 0x00015F62
		public override void OnGizmoDragUpdate(int handleId)
		{
		}

		// Token: 0x06000BAA RID: 2986 RVA: 0x00017D64 File Offset: 0x00015F64
		public override void OnGizmoDragBegin(int handleId)
		{
		}

		// Token: 0x06000BAB RID: 2987 RVA: 0x00017D66 File Offset: 0x00015F66
		public override void OnGizmoDragEnd(int handleId)
		{
		}

		// Token: 0x06000BAC RID: 2988 RVA: 0x00017D68 File Offset: 0x00015F68
		public override void OnGizmoAttemptHandleDragBegin(int handleId)
		{
		}

		// Token: 0x06000BAD RID: 2989 RVA: 0x00017D6A File Offset: 0x00015F6A
		private void PlaceMvDblSlidersInSliderPlanes(Camera camera)
		{
		}

		// Token: 0x06000BAE RID: 2990 RVA: 0x00017D6C File Offset: 0x00015F6C
		private void SetupSharedLookAndFeel()
		{
		}

		// Token: 0x06000BAF RID: 2991 RVA: 0x00017D6E File Offset: 0x00015F6E
		private void SetupSharedSettings()
		{
		}

		// Token: 0x06000BB0 RID: 2992 RVA: 0x00017D70 File Offset: 0x00015F70
		private void Update2DGizmoPosition()
		{
		}

		// Token: 0x06000BB1 RID: 2993 RVA: 0x00017D72 File Offset: 0x00015F72
		private void Update2DModeHandlePositions()
		{
		}

		// Token: 0x06000BB2 RID: 2994 RVA: 0x00017D74 File Offset: 0x00015F74
		private void OnGizmoTransformChanged(GizmoTransform transform, GizmoTransform.ChangeData changeData)
		{
		}

		// Token: 0x06000BB3 RID: 2995 RVA: 0x00017D76 File Offset: 0x00015F76
		private void Hide2DModeHandles()
		{
		}

		// Token: 0x06000BB4 RID: 2996 RVA: 0x00017D78 File Offset: 0x00015F78
		private void UpdateRtCamLookSlider(Camera camera)
		{
		}

		// Token: 0x06000BB5 RID: 2997 RVA: 0x00017D7A File Offset: 0x00015F7A
		private void SetMoveHandlesVisible(bool visible)
		{
		}

		// Token: 0x06000BB6 RID: 2998 RVA: 0x00017D7C File Offset: 0x00015F7C
		private void SetRotationHandlesVisible(bool visible)
		{
		}

		// Token: 0x06000BB7 RID: 2999 RVA: 0x00017D7E File Offset: 0x00015F7E
		private void SetScaleHandlesVisible(bool visible)
		{
		}

		// Token: 0x04000444 RID: 1092
		private GizmoLineSlider3D _mvPXSlider;

		// Token: 0x04000445 RID: 1093
		private GizmoLineSlider3D _mvPYSlider;

		// Token: 0x04000446 RID: 1094
		private GizmoLineSlider3D _mvPZSlider;

		// Token: 0x04000447 RID: 1095
		private GizmoLineSlider3D _mvNXSlider;

		// Token: 0x04000448 RID: 1096
		private GizmoLineSlider3D _mvNYSlider;

		// Token: 0x04000449 RID: 1097
		private GizmoLineSlider3D _mvNZSlider;

		// Token: 0x0400044A RID: 1098
		private GizmoLineSlider3DCollection _mvAxesSliders;

		// Token: 0x0400044B RID: 1099
		private GizmoPlaneSlider3D _mvXYSlider;

		// Token: 0x0400044C RID: 1100
		private GizmoPlaneSlider3D _mvYZSlider;

		// Token: 0x0400044D RID: 1101
		private GizmoPlaneSlider3D _mvZXSlider;

		// Token: 0x0400044E RID: 1102
		private GizmoPlaneSlider3DCollection _mvDblSliders;

		// Token: 0x0400044F RID: 1103
		private bool _isMvVertexSnapEnabled;

		// Token: 0x04000450 RID: 1104
		private GizmoCap2D _mvVertSnapCap;

		// Token: 0x04000451 RID: 1105
		private GizmoObjectVertexSnapDrag3D _mvVertexSnapDrag;

		// Token: 0x04000452 RID: 1106
		private Vector3 _mvPostVSnapPosRestore;

		// Token: 0x04000453 RID: 1107
		private GizmoLineSlider2D _mvP2DModeXSlider;

		// Token: 0x04000454 RID: 1108
		private GizmoLineSlider2D _mvP2DModeYSlider;

		// Token: 0x04000455 RID: 1109
		private GizmoLineSlider2D _mvN2DModeXSlider;

		// Token: 0x04000456 RID: 1110
		private GizmoLineSlider2D _mvN2DModeYSlider;

		// Token: 0x04000457 RID: 1111
		private GizmoLineSlider2DCollection _mv2DModeSliders;

		// Token: 0x04000458 RID: 1112
		private GizmoPlaneSlider2D _mv2DModeDblSlider;

		// Token: 0x04000459 RID: 1113
		private GizmoPlaneSlider3D _rtXSlider;

		// Token: 0x0400045A RID: 1114
		private GizmoPlaneSlider3D _rtYSlider;

		// Token: 0x0400045B RID: 1115
		private GizmoPlaneSlider3D _rtZSlider;

		// Token: 0x0400045C RID: 1116
		private GizmoPlaneSlider3DCollection _rtAxesSliders;

		// Token: 0x0400045D RID: 1117
		private GizmoCap3D _rtMidCap;

		// Token: 0x0400045E RID: 1118
		private GizmoDblAxisRotationDrag3D _rtCamXYRotationDrag;

		// Token: 0x0400045F RID: 1119
		private GizmoPlaneSlider2D _rtCamLookSlider;

		// Token: 0x04000460 RID: 1120
		private GizmoCap3D _scMidCap;

		// Token: 0x04000461 RID: 1121
		private GizmoUniformScaleDrag3D _scUnformScaleDrag;

		// Token: 0x04000462 RID: 1122
		private GizmoScaleGuide _scScaleGuide;

		// Token: 0x04000463 RID: 1123
		private IEnumerable<GameObject> _scScaleGuideTargetObjects;

		// Token: 0x04000464 RID: 1124
		private bool _is2DModeEnabled;

		// Token: 0x04000465 RID: 1125
		private UniversalGizmoSettings2D _settings2D;

		// Token: 0x04000466 RID: 1126
		private UniversalGizmoSettings2D _sharedSettings2D;

		// Token: 0x04000467 RID: 1127
		private UniversalGizmoSettings3D _settings3D;

		// Token: 0x04000468 RID: 1128
		private UniversalGizmoSettings3D _sharedSettings3D;

		// Token: 0x04000469 RID: 1129
		private UniversalGizmoLookAndFeel2D _lookAndFeel2D;

		// Token: 0x0400046A RID: 1130
		private UniversalGizmoLookAndFeel2D _sharedLookAndFeel2D;

		// Token: 0x0400046B RID: 1131
		private UniversalGizmoLookAndFeel3D _lookAndFeel3D;

		// Token: 0x0400046C RID: 1132
		private UniversalGizmoLookAndFeel3D _sharedLookAndFeel3D;

		// Token: 0x0400046D RID: 1133
		private UniversalGizmoHotkeys _hotkeys;

		// Token: 0x0400046E RID: 1134
		private UniversalGizmoHotkeys _sharedHotkeys;

		// Token: 0x0400046F RID: 1135
		private bool _useSnapEnableHotkey;

		// Token: 0x04000470 RID: 1136
		private bool _useVertSnapEnableHotkey;

		// Token: 0x04000471 RID: 1137
		private bool _use2DModeEnableHotkey;

		// Token: 0x02000373 RID: 883
		public enum MvVertexSnapState
		{
			// Token: 0x04000EFE RID: 3838
			SelectingPivot,
			// Token: 0x04000EFF RID: 3839
			Snapping,
			// Token: 0x04000F00 RID: 3840
			Inactive
		}
	}
}
