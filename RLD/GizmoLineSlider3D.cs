using System;
using System.Collections.Generic;
using UnityEngine;

namespace RLD
{
	// Token: 0x0200009B RID: 155
	public class GizmoLineSlider3D : GizmoSlider
	{
		// Token: 0x1700023E RID: 574
		// (get) Token: 0x060006DC RID: 1756 RVA: 0x0001F0A4 File Offset: 0x0001D2A4
		public Vector3 Direction
		{
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x1700023F RID: 575
		// (get) Token: 0x060006DD RID: 1757 RVA: 0x0001F0BC File Offset: 0x0001D2BC
		public Vector3 DragRotationAxis
		{
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x17000240 RID: 576
		// (get) Token: 0x060006DE RID: 1758 RVA: 0x00016F1B File Offset: 0x0001511B
		// (set) Token: 0x060006DF RID: 1759 RVA: 0x00016F1E File Offset: 0x0001511E
		public int ScaleDragAxisIndex
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x17000241 RID: 577
		// (get) Token: 0x060006E0 RID: 1760 RVA: 0x0001F0D4 File Offset: 0x0001D2D4
		// (set) Token: 0x060006E1 RID: 1761 RVA: 0x00016F20 File Offset: 0x00015120
		public Vector3 StartPosition
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		// Token: 0x17000242 RID: 578
		// (get) Token: 0x060006E2 RID: 1762 RVA: 0x0001F0EC File Offset: 0x0001D2EC
		public GizmoDragChannel DragChannel
		{
			get
			{
				return GizmoDragChannel.None;
			}
		}

		// Token: 0x17000243 RID: 579
		// (get) Token: 0x060006E3 RID: 1763 RVA: 0x00016F22 File Offset: 0x00015122
		public bool IsDragged
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000244 RID: 580
		// (get) Token: 0x060006E4 RID: 1764 RVA: 0x00016F25 File Offset: 0x00015125
		public bool IsMoving
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000245 RID: 581
		// (get) Token: 0x060006E5 RID: 1765 RVA: 0x00016F28 File Offset: 0x00015128
		public bool IsRotating
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000246 RID: 582
		// (get) Token: 0x060006E6 RID: 1766 RVA: 0x00016F2B File Offset: 0x0001512B
		public bool IsScaling
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000247 RID: 583
		// (get) Token: 0x060006E7 RID: 1767 RVA: 0x00016F2E File Offset: 0x0001512E
		public bool Is3DCapVisible
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000248 RID: 584
		// (get) Token: 0x060006E8 RID: 1768 RVA: 0x00016F31 File Offset: 0x00015131
		public bool Is3DCapHoverable
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000249 RID: 585
		// (get) Token: 0x060006E9 RID: 1769 RVA: 0x00016F34 File Offset: 0x00015134
		public int Cap3DHandleId
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x1700024A RID: 586
		// (get) Token: 0x060006EA RID: 1770 RVA: 0x0001F104 File Offset: 0x0001D304
		public Vector3 TotalDragOffset
		{
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x1700024B RID: 587
		// (get) Token: 0x060006EB RID: 1771 RVA: 0x0001F11C File Offset: 0x0001D31C
		public Vector3 RelativeDragOffset
		{
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x1700024C RID: 588
		// (get) Token: 0x060006EC RID: 1772 RVA: 0x00016F37 File Offset: 0x00015137
		public float TotalDragRotation
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700024D RID: 589
		// (get) Token: 0x060006ED RID: 1773 RVA: 0x00016F3E File Offset: 0x0001513E
		public float RelativeDragRotation
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700024E RID: 590
		// (get) Token: 0x060006EE RID: 1774 RVA: 0x00016F45 File Offset: 0x00015145
		public float TotalDragScale
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700024F RID: 591
		// (get) Token: 0x060006EF RID: 1775 RVA: 0x00016F4C File Offset: 0x0001514C
		public float RelativeDragScale
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000250 RID: 592
		// (get) Token: 0x060006F0 RID: 1776 RVA: 0x00016F53 File Offset: 0x00015153
		public GizmoOverrideColor OverrideColor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000251 RID: 593
		// (get) Token: 0x060006F1 RID: 1777 RVA: 0x00016F56 File Offset: 0x00015156
		public GizmoOverrideColor Cap3DOverrideColor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000252 RID: 594
		// (get) Token: 0x060006F2 RID: 1778 RVA: 0x00016F59 File Offset: 0x00015159
		public GizmoLineSlider3DSettings Settings
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000253 RID: 595
		// (get) Token: 0x060006F3 RID: 1779 RVA: 0x00016F5C File Offset: 0x0001515C
		// (set) Token: 0x060006F4 RID: 1780 RVA: 0x00016F5F File Offset: 0x0001515F
		public GizmoLineSlider3DSettings SharedSettings
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x17000254 RID: 596
		// (get) Token: 0x060006F5 RID: 1781 RVA: 0x00016F61 File Offset: 0x00015161
		public GizmoLineSlider3DLookAndFeel LookAndFeel
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000255 RID: 597
		// (get) Token: 0x060006F6 RID: 1782 RVA: 0x00016F64 File Offset: 0x00015164
		// (set) Token: 0x060006F7 RID: 1783 RVA: 0x00016F67 File Offset: 0x00015167
		public GizmoLineSlider3DLookAndFeel SharedLookAndFeel
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x060006F8 RID: 1784 RVA: 0x00016F69 File Offset: 0x00015169
		public GizmoLineSlider3D(Gizmo gizmo, int handleId, int capHandleId) : base(null, 0)
		{
		}

		// Token: 0x060006F9 RID: 1785 RVA: 0x00016F73 File Offset: 0x00015173
		public bool IsScalerHandleRegistered(int handleId)
		{
			return false;
		}

		// Token: 0x060006FA RID: 1786 RVA: 0x00016F76 File Offset: 0x00015176
		public bool IsScalerHandleRegistered(int handleId, int scaleDragAxisIndex)
		{
			return false;
		}

		// Token: 0x060006FB RID: 1787 RVA: 0x00016F79 File Offset: 0x00015179
		public void RegisterScalerHandle(int handleId, IEnumerable<int> scaleDragAxisIndices)
		{
		}

		// Token: 0x060006FC RID: 1788 RVA: 0x00016F7B File Offset: 0x0001517B
		public void UnregisterScalerHandle(int handleId)
		{
		}

		// Token: 0x060006FD RID: 1789 RVA: 0x00016F7D File Offset: 0x0001517D
		public override void SetSnapEnabled(bool isEnabled)
		{
		}

		// Token: 0x060006FE RID: 1790 RVA: 0x00016F7F File Offset: 0x0001517F
		public void Set3DCapVisible(bool isVisible)
		{
		}

		// Token: 0x060006FF RID: 1791 RVA: 0x00016F81 File Offset: 0x00015181
		public void Set3DCapHoverable(bool isHoverable)
		{
		}

		// Token: 0x06000700 RID: 1792 RVA: 0x00016F83 File Offset: 0x00015183
		public void SetZoomFactorTransform(GizmoTransform transform)
		{
		}

		// Token: 0x06000701 RID: 1793 RVA: 0x00016F85 File Offset: 0x00015185
		public float GetZoomFactor(Camera camera)
		{
			return 0f;
		}

		// Token: 0x06000702 RID: 1794 RVA: 0x0001F134 File Offset: 0x0001D334
		public Vector3 GetRealDirection()
		{
			return default(Vector3);
		}

		// Token: 0x06000703 RID: 1795 RVA: 0x00016F8C File Offset: 0x0001518C
		public float GetRealSizeAlongDirection(Camera camera, Vector3 direction)
		{
			return 0f;
		}

		// Token: 0x06000704 RID: 1796 RVA: 0x00016F93 File Offset: 0x00015193
		public float GetRealLength(float zoomFactor)
		{
			return 0f;
		}

		// Token: 0x06000705 RID: 1797 RVA: 0x00016F9A File Offset: 0x0001519A
		public float GetRealLengthWith3DCap(float zoomFactor)
		{
			return 0f;
		}

		// Token: 0x06000706 RID: 1798 RVA: 0x0001F14C File Offset: 0x0001D34C
		public Vector3 GetRealEndPosition(float zoomFactor)
		{
			return default(Vector3);
		}

		// Token: 0x06000707 RID: 1799 RVA: 0x0001F164 File Offset: 0x0001D364
		public Vector3 GetRealEndPositionWith3DCap(float zoomFactor)
		{
			return default(Vector3);
		}

		// Token: 0x06000708 RID: 1800 RVA: 0x00016FA1 File Offset: 0x000151A1
		public float GetRealBoxHeight(float zoomFactor)
		{
			return 0f;
		}

		// Token: 0x06000709 RID: 1801 RVA: 0x00016FA8 File Offset: 0x000151A8
		public float GetRealBoxDepth(float zoomFactor)
		{
			return 0f;
		}

		// Token: 0x0600070A RID: 1802 RVA: 0x00016FAF File Offset: 0x000151AF
		public float GetRealCylinderRadius(float zoomFactor)
		{
			return 0f;
		}

		// Token: 0x0600070B RID: 1803 RVA: 0x00016FB6 File Offset: 0x000151B6
		public void MapDirection(int axisIndex, AxisSign axisSign)
		{
		}

		// Token: 0x0600070C RID: 1804 RVA: 0x00016FB8 File Offset: 0x000151B8
		public void MapDragRotationAxis(GizmoTransform mapTransform, int axisIndex, AxisSign axisSign)
		{
		}

		// Token: 0x0600070D RID: 1805 RVA: 0x00016FBA File Offset: 0x000151BA
		public void UnmapDragRotationAxis()
		{
		}

		// Token: 0x0600070E RID: 1806 RVA: 0x00016FBC File Offset: 0x000151BC
		public void SetDirection(Vector3 directionAxis)
		{
		}

		// Token: 0x0600070F RID: 1807 RVA: 0x00016FBE File Offset: 0x000151BE
		public void SetDragRotationAxis(Vector3 rotationAxis)
		{
		}

		// Token: 0x06000710 RID: 1808 RVA: 0x00016FC0 File Offset: 0x000151C0
		public void AddTargetTransform(GizmoTransform transform)
		{
		}

		// Token: 0x06000711 RID: 1809 RVA: 0x00016FC2 File Offset: 0x000151C2
		public void AddTargetTransform(GizmoTransform transform, GizmoDragChannel dragChannel)
		{
		}

		// Token: 0x06000712 RID: 1810 RVA: 0x00016FC4 File Offset: 0x000151C4
		public void RemoveTargetTransform(GizmoTransform transform)
		{
		}

		// Token: 0x06000713 RID: 1811 RVA: 0x00016FC6 File Offset: 0x000151C6
		public void RemoveTargetTransform(GizmoTransform transform, GizmoDragChannel dragChannel)
		{
		}

		// Token: 0x06000714 RID: 1812 RVA: 0x00016FC8 File Offset: 0x000151C8
		public void SetDragChannel(GizmoDragChannel dragChannel)
		{
		}

		// Token: 0x06000715 RID: 1813 RVA: 0x00016FCA File Offset: 0x000151CA
		public void ApplyZoomFactor(Camera camera)
		{
		}

		// Token: 0x06000716 RID: 1814 RVA: 0x00016FCC File Offset: 0x000151CC
		public override void Render(Camera camera)
		{
		}

		// Token: 0x06000717 RID: 1815 RVA: 0x00016FCE File Offset: 0x000151CE
		public void Refresh()
		{
		}

		// Token: 0x06000718 RID: 1816 RVA: 0x00016FD0 File Offset: 0x000151D0
		protected override void OnVisibilityStateChanged()
		{
		}

		// Token: 0x06000719 RID: 1817 RVA: 0x00016FD2 File Offset: 0x000151D2
		protected override void OnHoverableStateChanged()
		{
		}

		// Token: 0x0600071A RID: 1818 RVA: 0x00016FD4 File Offset: 0x000151D4
		private void OnGizmoPreUpdateBegin(Gizmo gizmo)
		{
		}

		// Token: 0x0600071B RID: 1819 RVA: 0x00016FD6 File Offset: 0x000151D6
		private void OnGizmoAttemptHandleDragBegin(Gizmo gizmo, int handleId)
		{
		}

		// Token: 0x0600071C RID: 1820 RVA: 0x00016FD8 File Offset: 0x000151D8
		private void OnTransformChanged(GizmoTransform transform, GizmoTransform.ChangeData changeData)
		{
		}

		// Token: 0x0600071D RID: 1821 RVA: 0x00016FDA File Offset: 0x000151DA
		private void OnGizmoHandleHoverEnter(Gizmo gizmo, int handleId)
		{
		}

		// Token: 0x0600071E RID: 1822 RVA: 0x00016FDC File Offset: 0x000151DC
		private void OnGizmoPostEnabled(Gizmo gizmo)
		{
		}

		// Token: 0x0600071F RID: 1823 RVA: 0x00016FDE File Offset: 0x000151DE
		private void OnGizmoPostDisabled(Gizmo gizmo)
		{
		}

		// Token: 0x06000720 RID: 1824 RVA: 0x00016FE0 File Offset: 0x000151E0
		private void OnGizmoHandleHoverExit(Gizmo gizmo, int handleId)
		{
		}

		// Token: 0x06000721 RID: 1825 RVA: 0x00016FE2 File Offset: 0x000151E2
		private void SetupSharedLookAndFeel()
		{
		}

		// Token: 0x0400026E RID: 622
		private SegmentShape3D _segment;

		// Token: 0x0400026F RID: 623
		private BoxShape3D _box;

		// Token: 0x04000270 RID: 624
		private CylinderShape3D _cylinder;

		// Token: 0x04000271 RID: 625
		private int _segmentIndex;

		// Token: 0x04000272 RID: 626
		private int _boxIndex;

		// Token: 0x04000273 RID: 627
		private int _cylinderIndex;

		// Token: 0x04000274 RID: 628
		private IGizmoLineSlider3DController[] _controllers;

		// Token: 0x04000275 RID: 629
		private GizmoLineSlider3DControllerData _controllerData;

		// Token: 0x04000276 RID: 630
		private GizmoDragChannel _dragChannel;

		// Token: 0x04000277 RID: 631
		private GizmoSglAxisOffsetDrag3D _offsetDrag;

		// Token: 0x04000278 RID: 632
		private GizmoSglAxisRotationDrag3D _rotationDrag;

		// Token: 0x04000279 RID: 633
		private GizmoRotationArc3D _rotationArc;

		// Token: 0x0400027A RID: 634
		private GizmoSglAxisScaleDrag3D _scaleDrag;

		// Token: 0x0400027B RID: 635
		private int _scaleDragAxisIndex;

		// Token: 0x0400027C RID: 636
		private List<GizmoScalerHandle> _scalerHandles;

		// Token: 0x0400027D RID: 637
		private IGizmoDragSession _selectedDragSession;

		// Token: 0x0400027E RID: 638
		private GizmoCap3D _cap3D;

		// Token: 0x0400027F RID: 639
		private GizmoTransform _transform;

		// Token: 0x04000280 RID: 640
		private GizmoTransformAxisMap3D _directionAxisMap;

		// Token: 0x04000281 RID: 641
		private GizmoTransformAxisMap3D _dragRotationAxisMap;

		// Token: 0x04000282 RID: 642
		private GizmoOverrideColor _overrideColor;

		// Token: 0x04000283 RID: 643
		private GizmoLineSlider3DSettings _settings;

		// Token: 0x04000284 RID: 644
		private GizmoLineSlider3DSettings _sharedSettings;

		// Token: 0x04000285 RID: 645
		private GizmoLineSlider3DLookAndFeel _lookAndFeel;

		// Token: 0x04000286 RID: 646
		private GizmoLineSlider3DLookAndFeel _sharedLookAndFeel;

		// Token: 0x02000367 RID: 871
		private sealed class <>c__DisplayClass78_0
		{
			// Token: 0x06002A45 RID: 10821 RVA: 0x0001D1AE File Offset: 0x0001B3AE
			internal bool <IsScalerHandleRegistered>b__0(GizmoScalerHandle item)
			{
				return false;
			}

			// Token: 0x04000EE1 RID: 3809
			public int handleId;
		}

		// Token: 0x02000368 RID: 872
		private sealed class <>c__DisplayClass79_0
		{
			// Token: 0x06002A47 RID: 10823 RVA: 0x0001D1B9 File Offset: 0x0001B3B9
			internal bool <IsScalerHandleRegistered>b__0(GizmoScalerHandle item)
			{
				return false;
			}

			// Token: 0x04000EE2 RID: 3810
			public int handleId;
		}

		// Token: 0x02000369 RID: 873
		private sealed class <>c__DisplayClass81_0
		{
			// Token: 0x06002A49 RID: 10825 RVA: 0x0001D1C4 File Offset: 0x0001B3C4
			internal bool <UnregisterScalerHandle>b__0(GizmoScalerHandle item)
			{
				return false;
			}

			// Token: 0x04000EE3 RID: 3811
			public int handleId;
		}
	}
}
