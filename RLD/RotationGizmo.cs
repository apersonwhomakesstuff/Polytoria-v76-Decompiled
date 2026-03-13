using System;
using UnityEngine;

namespace RLD
{
	// Token: 0x020000E2 RID: 226
	[Serializable]
	public class RotationGizmo : GizmoBehaviour
	{
		// Token: 0x17000361 RID: 865
		// (get) Token: 0x06000A5D RID: 2653 RVA: 0x0001795A File Offset: 0x00015B5A
		public RotationGizmoSettings3D Settings3D
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000362 RID: 866
		// (get) Token: 0x06000A5E RID: 2654 RVA: 0x0001795D File Offset: 0x00015B5D
		public RotationGizmoLookAndFeel3D LookAndFeel3D
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000363 RID: 867
		// (get) Token: 0x06000A5F RID: 2655 RVA: 0x00017960 File Offset: 0x00015B60
		public RotationGizmoHotkeys Hotkeys
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000364 RID: 868
		// (get) Token: 0x06000A60 RID: 2656 RVA: 0x00017963 File Offset: 0x00015B63
		// (set) Token: 0x06000A61 RID: 2657 RVA: 0x00017966 File Offset: 0x00015B66
		public RotationGizmoSettings3D SharedSettings3D
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x17000365 RID: 869
		// (get) Token: 0x06000A62 RID: 2658 RVA: 0x00017968 File Offset: 0x00015B68
		// (set) Token: 0x06000A63 RID: 2659 RVA: 0x0001796B File Offset: 0x00015B6B
		public RotationGizmoLookAndFeel3D SharedLookAndFeel3D
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x17000366 RID: 870
		// (get) Token: 0x06000A64 RID: 2660 RVA: 0x0001796D File Offset: 0x00015B6D
		// (set) Token: 0x06000A65 RID: 2661 RVA: 0x00017970 File Offset: 0x00015B70
		public RotationGizmoHotkeys SharedHotkeys
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x17000367 RID: 871
		// (get) Token: 0x06000A66 RID: 2662 RVA: 0x00017972 File Offset: 0x00015B72
		// (set) Token: 0x06000A67 RID: 2663 RVA: 0x00017975 File Offset: 0x00015B75
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

		// Token: 0x06000A68 RID: 2664 RVA: 0x00017977 File Offset: 0x00015B77
		public float GetZoomFactor(Vector3 position)
		{
			return 0f;
		}

		// Token: 0x06000A69 RID: 2665 RVA: 0x0001797E File Offset: 0x00015B7E
		public float GetZoomFactor(Vector3 position, Camera camera)
		{
			return 0f;
		}

		// Token: 0x06000A6A RID: 2666 RVA: 0x00017985 File Offset: 0x00015B85
		public bool OwnsHandle(int handleId)
		{
			return false;
		}

		// Token: 0x06000A6B RID: 2667 RVA: 0x00017988 File Offset: 0x00015B88
		public void SetMidCapHoverable(bool hoverable)
		{
		}

		// Token: 0x06000A6C RID: 2668 RVA: 0x0001798A File Offset: 0x00015B8A
		public void SetSnapEnabled(bool isEnabled)
		{
		}

		// Token: 0x06000A6D RID: 2669 RVA: 0x0001798C File Offset: 0x00015B8C
		public override void OnGizmoEnabled()
		{
		}

		// Token: 0x06000A6E RID: 2670 RVA: 0x0001798E File Offset: 0x00015B8E
		public override void OnDetached()
		{
		}

		// Token: 0x06000A6F RID: 2671 RVA: 0x00017990 File Offset: 0x00015B90
		public override void OnEnabled()
		{
		}

		// Token: 0x06000A70 RID: 2672 RVA: 0x00017992 File Offset: 0x00015B92
		public override void OnDisabled()
		{
		}

		// Token: 0x06000A71 RID: 2673 RVA: 0x00017994 File Offset: 0x00015B94
		public override void OnAttached()
		{
		}

		// Token: 0x06000A72 RID: 2674 RVA: 0x00017996 File Offset: 0x00015B96
		public override void OnGizmoUpdateBegin()
		{
		}

		// Token: 0x06000A73 RID: 2675 RVA: 0x00017998 File Offset: 0x00015B98
		public override void OnGizmoRender(Camera camera)
		{
		}

		// Token: 0x06000A74 RID: 2676 RVA: 0x0001799A File Offset: 0x00015B9A
		public override void OnGizmoAttemptHandleDragBegin(int handleId)
		{
		}

		// Token: 0x06000A75 RID: 2677 RVA: 0x0001799C File Offset: 0x00015B9C
		private void UpdateCamLookSlider(Camera camera)
		{
		}

		// Token: 0x06000A76 RID: 2678 RVA: 0x0001799E File Offset: 0x00015B9E
		private void SetupSharedLookAndFeel()
		{
		}

		// Token: 0x06000A77 RID: 2679 RVA: 0x000179A0 File Offset: 0x00015BA0
		private void SetupSharedSettings()
		{
		}

		// Token: 0x06000A78 RID: 2680 RVA: 0x000179A2 File Offset: 0x00015BA2
		private void OnGizmoTransformChanged(GizmoTransform gizmoTransform, GizmoTransform.ChangeData changeData)
		{
		}

		// Token: 0x04000405 RID: 1029
		private GizmoPlaneSlider3D _xSlider;

		// Token: 0x04000406 RID: 1030
		private GizmoPlaneSlider3D _ySlider;

		// Token: 0x04000407 RID: 1031
		private GizmoPlaneSlider3D _zSlider;

		// Token: 0x04000408 RID: 1032
		private GizmoPlaneSlider3DCollection _axesSliders;

		// Token: 0x04000409 RID: 1033
		private GizmoCap3D _midCap;

		// Token: 0x0400040A RID: 1034
		private GizmoDblAxisRotationDrag3D _camXYRotationDrag;

		// Token: 0x0400040B RID: 1035
		private GizmoPlaneSlider2D _camLookSlider;

		// Token: 0x0400040C RID: 1036
		private RotationGizmoHotkeys _hotkeys;

		// Token: 0x0400040D RID: 1037
		private RotationGizmoSettings3D _settings3D;

		// Token: 0x0400040E RID: 1038
		private RotationGizmoLookAndFeel3D _lookAndFeel3D;

		// Token: 0x0400040F RID: 1039
		private bool _useSnapEnableHotkey;

		// Token: 0x04000410 RID: 1040
		private RotationGizmoHotkeys _sharedHotkeys;

		// Token: 0x04000411 RID: 1041
		private RotationGizmoSettings3D _sharedSettings3D;

		// Token: 0x04000412 RID: 1042
		private RotationGizmoLookAndFeel3D _sharedLookAndFeel3D;
	}
}
