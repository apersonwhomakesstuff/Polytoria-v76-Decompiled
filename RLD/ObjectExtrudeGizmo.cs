using System;
using System.Collections.Generic;
using UnityEngine;

namespace RLD
{
	// Token: 0x0200006C RID: 108
	[Serializable]
	public class ObjectExtrudeGizmo : GizmoBehaviour
	{
		// Token: 0x14000014 RID: 20
		// (add) Token: 0x06000460 RID: 1120 RVA: 0x0001680E File Offset: 0x00014A0E
		// (remove) Token: 0x06000461 RID: 1121 RVA: 0x00016810 File Offset: 0x00014A10
		public event ObjectExtrudeGizmoExtrudeUpdateHandler ExtrudeUpdate
		{
			add
			{
			}
			remove
			{
			}
		}

		// Token: 0x17000154 RID: 340
		// (get) Token: 0x06000462 RID: 1122 RVA: 0x00016812 File Offset: 0x00014A12
		public ObjectExtrudeGizmoLookAndFeel3D LookAndFeel3D
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000155 RID: 341
		// (get) Token: 0x06000463 RID: 1123 RVA: 0x00016815 File Offset: 0x00014A15
		// (set) Token: 0x06000464 RID: 1124 RVA: 0x00016818 File Offset: 0x00014A18
		public ObjectExtrudeGizmoLookAndFeel3D SharedLookAndFeel3D
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x17000156 RID: 342
		// (get) Token: 0x06000465 RID: 1125 RVA: 0x0001681A File Offset: 0x00014A1A
		public ObjectExtrudeGizmoHotkeys Hotkeys
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000157 RID: 343
		// (get) Token: 0x06000466 RID: 1126 RVA: 0x0001681D File Offset: 0x00014A1D
		// (set) Token: 0x06000467 RID: 1127 RVA: 0x00016820 File Offset: 0x00014A20
		public ObjectExtrudeGizmoHotkeys SharedHotkeys
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x17000158 RID: 344
		// (get) Token: 0x06000468 RID: 1128 RVA: 0x0001E804 File Offset: 0x0001CA04
		public Vector3 BoxCenter
		{
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x17000159 RID: 345
		// (get) Token: 0x06000469 RID: 1129 RVA: 0x0001E81C File Offset: 0x0001CA1C
		public Quaternion BoxRotation
		{
			get
			{
				return default(Quaternion);
			}
		}

		// Token: 0x1700015A RID: 346
		// (get) Token: 0x0600046A RID: 1130 RVA: 0x0001E834 File Offset: 0x0001CA34
		public Vector3 BoxSize
		{
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x1700015B RID: 347
		// (get) Token: 0x0600046B RID: 1131 RVA: 0x0001E84C File Offset: 0x0001CA4C
		public Vector3 BoxRight
		{
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x1700015C RID: 348
		// (get) Token: 0x0600046C RID: 1132 RVA: 0x0001E864 File Offset: 0x0001CA64
		public Vector3 BoxUp
		{
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x1700015D RID: 349
		// (get) Token: 0x0600046D RID: 1133 RVA: 0x0001E87C File Offset: 0x0001CA7C
		public Vector3 BoxLook
		{
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x1700015E RID: 350
		// (get) Token: 0x0600046E RID: 1134 RVA: 0x0001E894 File Offset: 0x0001CA94
		public OBB OBB
		{
			get
			{
				return default(OBB);
			}
		}

		// Token: 0x1700015F RID: 351
		// (get) Token: 0x0600046F RID: 1135 RVA: 0x0001E8AC File Offset: 0x0001CAAC
		public GizmoSpace ExtrudeSpace
		{
			get
			{
				return GizmoSpace.Global;
			}
		}

		// Token: 0x17000160 RID: 352
		// (get) Token: 0x06000470 RID: 1136 RVA: 0x00016822 File Offset: 0x00014A22
		public int NumTargetParents
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x06000471 RID: 1137 RVA: 0x00016825 File Offset: 0x00014A25
		public bool OwnsHandle(int handleId)
		{
			return false;
		}

		// Token: 0x06000472 RID: 1138 RVA: 0x00016828 File Offset: 0x00014A28
		public bool IsRightExtrudeHandle(int handleId)
		{
			return false;
		}

		// Token: 0x06000473 RID: 1139 RVA: 0x0001682B File Offset: 0x00014A2B
		public bool IsLeftExtrudeHandle(int handleId)
		{
			return false;
		}

		// Token: 0x06000474 RID: 1140 RVA: 0x0001682E File Offset: 0x00014A2E
		public bool IsTopExtrudeHandle(int handleId)
		{
			return false;
		}

		// Token: 0x06000475 RID: 1141 RVA: 0x00016831 File Offset: 0x00014A31
		public bool IsBottomExtrudeHandle(int handleId)
		{
			return false;
		}

		// Token: 0x06000476 RID: 1142 RVA: 0x00016834 File Offset: 0x00014A34
		public bool IsFrontExtrudeHandle(int handleId)
		{
			return false;
		}

		// Token: 0x06000477 RID: 1143 RVA: 0x00016837 File Offset: 0x00014A37
		public bool IsBackExtrudeHandle(int handleId)
		{
			return false;
		}

		// Token: 0x06000478 RID: 1144 RVA: 0x0001683A File Offset: 0x00014A3A
		public void SetIgnoredParentObjects(IEnumerable<GameObject> ignoredParentObjects)
		{
		}

		// Token: 0x06000479 RID: 1145 RVA: 0x0001683C File Offset: 0x00014A3C
		public void SetExtrudeSpace(GizmoSpace extrudeSpace)
		{
		}

		// Token: 0x0600047A RID: 1146 RVA: 0x0001683E File Offset: 0x00014A3E
		public void SetExtrudeTargets(IEnumerable<GameObject> extrudeTargets)
		{
		}

		// Token: 0x0600047B RID: 1147 RVA: 0x00016840 File Offset: 0x00014A40
		public void FitBoxToTargets()
		{
		}

		// Token: 0x0600047C RID: 1148 RVA: 0x00016842 File Offset: 0x00014A42
		public override void OnDetached()
		{
		}

		// Token: 0x0600047D RID: 1149 RVA: 0x00016844 File Offset: 0x00014A44
		public override void OnEnabled()
		{
		}

		// Token: 0x0600047E RID: 1150 RVA: 0x00016846 File Offset: 0x00014A46
		public override void OnDisabled()
		{
		}

		// Token: 0x0600047F RID: 1151 RVA: 0x00016848 File Offset: 0x00014A48
		public override void OnGizmoEnabled()
		{
		}

		// Token: 0x06000480 RID: 1152 RVA: 0x0001684A File Offset: 0x00014A4A
		public override void OnAttached()
		{
		}

		// Token: 0x06000481 RID: 1153 RVA: 0x0001684C File Offset: 0x00014A4C
		public override void OnGizmoUpdateBegin()
		{
		}

		// Token: 0x06000482 RID: 1154 RVA: 0x0001684E File Offset: 0x00014A4E
		public override void OnGizmoRender(Camera camera)
		{
		}

		// Token: 0x06000483 RID: 1155 RVA: 0x00016850 File Offset: 0x00014A50
		public override void OnGizmoDragBegin(int handleId)
		{
		}

		// Token: 0x06000484 RID: 1156 RVA: 0x00016852 File Offset: 0x00014A52
		public override void OnGizmoDragUpdate(int handleId)
		{
		}

		// Token: 0x06000485 RID: 1157 RVA: 0x00016854 File Offset: 0x00014A54
		public override void OnGizmoDragEnd(int handleId)
		{
		}

		// Token: 0x06000486 RID: 1158 RVA: 0x00016856 File Offset: 0x00014A56
		private void UpdateExtrudeSliderTransforms()
		{
		}

		// Token: 0x06000487 RID: 1159 RVA: 0x00016858 File Offset: 0x00014A58
		private void OnGizmoTransformChanged(GizmoTransform gizmoTransform, GizmoTransform.ChangeData changeData)
		{
		}

		// Token: 0x06000488 RID: 1160 RVA: 0x0001685A File Offset: 0x00014A5A
		private void SetAABB(AABB aabb)
		{
		}

		// Token: 0x06000489 RID: 1161 RVA: 0x0001685C File Offset: 0x00014A5C
		private void SetOBB(OBB obb)
		{
		}

		// Token: 0x0600048A RID: 1162 RVA: 0x0001685E File Offset: 0x00014A5E
		private void UpdateSnapSteps()
		{
		}

		// Token: 0x0600048B RID: 1163 RVA: 0x00016860 File Offset: 0x00014A60
		private void ValidateBoxSize()
		{
		}

		// Token: 0x0600048C RID: 1164 RVA: 0x00016862 File Offset: 0x00014A62
		private void SetupSharedLookAndFeel()
		{
		}

		// Token: 0x0600048D RID: 1165 RVA: 0x00016864 File Offset: 0x00014A64
		private void OnUndoRedoEnd(IUndoRedoAction action)
		{
		}

		// Token: 0x04000169 RID: 361
		private List<GameObject> _objectBuffer;

		// Token: 0x0400016A RID: 362
		private Vector3 _boxSize;

		// Token: 0x0400016B RID: 363
		private GizmoSpace _extrudeSpace;

		// Token: 0x0400016C RID: 364
		private List<GameObject> _targetParents;

		// Token: 0x0400016D RID: 365
		private HashSet<GameObject> _ignoredParentObjects;

		// Token: 0x0400016E RID: 366
		private ObjectBounds.QueryConfig _boundsQConfig;

		// Token: 0x0400016F RID: 367
		private SceneOverlapFilter _sceneOverlapFilter;

		// Token: 0x04000170 RID: 368
		private ObjectExtrudeGizmoDragEnd _dragEndAction;

		// Token: 0x04000171 RID: 369
		private ObjectExtrudeGizmo.HandleDragExtrudeData _handleDragExtrData;

		// Token: 0x04000172 RID: 370
		private GizmoLineSlider3D _rightExtrude;

		// Token: 0x04000173 RID: 371
		private GizmoLineSlider3D _upExtrude;

		// Token: 0x04000174 RID: 372
		private GizmoLineSlider3D _frontExtrude;

		// Token: 0x04000175 RID: 373
		private GizmoLineSlider3D _leftExtrude;

		// Token: 0x04000176 RID: 374
		private GizmoLineSlider3D _bottomExtrude;

		// Token: 0x04000177 RID: 375
		private GizmoLineSlider3D _backExtrude;

		// Token: 0x04000178 RID: 376
		private GizmoLineSlider3DCollection _extrudeSliders;

		// Token: 0x04000179 RID: 377
		private ObjectExtrudeGizmoLookAndFeel3D _lookAndFeel3D;

		// Token: 0x0400017A RID: 378
		private ObjectExtrudeGizmoLookAndFeel3D _sharedLookAndFeel3D;

		// Token: 0x0400017B RID: 379
		private ObjectExtrudeGizmoHotkeys _hotkeys;

		// Token: 0x0400017C RID: 380
		private ObjectExtrudeGizmoHotkeys _sharedHotkeys;

		// Token: 0x0200035F RID: 863
		private struct HandleDragExtrudeData
		{
			// Token: 0x04000ED2 RID: 3794
			public Vector3 ExtrudeDir;

			// Token: 0x04000ED3 RID: 3795
			public Vector3 ExtrudeCenter;

			// Token: 0x04000ED4 RID: 3796
			public int AxisIndex;
		}

		// Token: 0x02000360 RID: 864
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06002A39 RID: 10809 RVA: 0x0001D16C File Offset: 0x0001B36C
			internal bool <SetExtrudeTargets>b__61_0(GameObject item)
			{
				return false;
			}

			// Token: 0x04000ED5 RID: 3797
			public static readonly ObjectExtrudeGizmo.<>c <>9;

			// Token: 0x04000ED6 RID: 3798
			public static Predicate<GameObject> <>9__61_0;
		}
	}
}
