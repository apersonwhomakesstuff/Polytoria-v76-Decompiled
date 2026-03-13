using System;
using UnityEngine;

namespace RLD
{
	// Token: 0x02000085 RID: 133
	public class GizmoLineSlider2D : GizmoSlider
	{
		// Token: 0x170001D3 RID: 467
		// (get) Token: 0x060005C0 RID: 1472 RVA: 0x0001ECCC File Offset: 0x0001CECC
		public Quaternion Rotation
		{
			get
			{
				return default(Quaternion);
			}
		}

		// Token: 0x170001D4 RID: 468
		// (get) Token: 0x060005C1 RID: 1473 RVA: 0x00016BD2 File Offset: 0x00014DD2
		public float RotationDegrees
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x170001D5 RID: 469
		// (get) Token: 0x060005C2 RID: 1474 RVA: 0x0001ECE4 File Offset: 0x0001CEE4
		// (set) Token: 0x060005C3 RID: 1475 RVA: 0x00016BD9 File Offset: 0x00014DD9
		public Vector2 StartPosition
		{
			get
			{
				return default(Vector2);
			}
			set
			{
			}
		}

		// Token: 0x170001D6 RID: 470
		// (get) Token: 0x060005C4 RID: 1476 RVA: 0x0001ECFC File Offset: 0x0001CEFC
		public Vector2 Direction
		{
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x170001D7 RID: 471
		// (get) Token: 0x060005C5 RID: 1477 RVA: 0x0001ED14 File Offset: 0x0001CF14
		// (set) Token: 0x060005C6 RID: 1478 RVA: 0x00016BDB File Offset: 0x00014DDB
		public Vector3 OffsetDragOrigin
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		// Token: 0x170001D8 RID: 472
		// (get) Token: 0x060005C7 RID: 1479 RVA: 0x0001ED2C File Offset: 0x0001CF2C
		// (set) Token: 0x060005C8 RID: 1480 RVA: 0x00016BDD File Offset: 0x00014DDD
		public Vector3 ScaleDragOrigin
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		// Token: 0x170001D9 RID: 473
		// (get) Token: 0x060005C9 RID: 1481 RVA: 0x00016BDF File Offset: 0x00014DDF
		// (set) Token: 0x060005CA RID: 1482 RVA: 0x00016BE2 File Offset: 0x00014DE2
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

		// Token: 0x170001DA RID: 474
		// (get) Token: 0x060005CB RID: 1483 RVA: 0x00016BE4 File Offset: 0x00014DE4
		public int Cap2DHandleId
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x170001DB RID: 475
		// (get) Token: 0x060005CC RID: 1484 RVA: 0x00016BE7 File Offset: 0x00014DE7
		public bool IsDragged
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170001DC RID: 476
		// (get) Token: 0x060005CD RID: 1485 RVA: 0x00016BEA File Offset: 0x00014DEA
		public bool IsMoving
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170001DD RID: 477
		// (get) Token: 0x060005CE RID: 1486 RVA: 0x00016BED File Offset: 0x00014DED
		public bool IsRotating
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170001DE RID: 478
		// (get) Token: 0x060005CF RID: 1487 RVA: 0x00016BF0 File Offset: 0x00014DF0
		public bool IsScaling
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170001DF RID: 479
		// (get) Token: 0x060005D0 RID: 1488 RVA: 0x00016BF3 File Offset: 0x00014DF3
		public bool Is2DCapVisible
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170001E0 RID: 480
		// (get) Token: 0x060005D1 RID: 1489 RVA: 0x00016BF6 File Offset: 0x00014DF6
		public bool Is2DCapHoverable
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170001E1 RID: 481
		// (get) Token: 0x060005D2 RID: 1490 RVA: 0x0001ED44 File Offset: 0x0001CF44
		public Vector3 TotalDragOffset
		{
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x170001E2 RID: 482
		// (get) Token: 0x060005D3 RID: 1491 RVA: 0x0001ED5C File Offset: 0x0001CF5C
		public Vector3 RelativeDragOffset
		{
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x170001E3 RID: 483
		// (get) Token: 0x060005D4 RID: 1492 RVA: 0x00016BF9 File Offset: 0x00014DF9
		public float TotalDragRotation
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x170001E4 RID: 484
		// (get) Token: 0x060005D5 RID: 1493 RVA: 0x00016C00 File Offset: 0x00014E00
		public float RelativeDragRotation
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x170001E5 RID: 485
		// (get) Token: 0x060005D6 RID: 1494 RVA: 0x00016C07 File Offset: 0x00014E07
		public float TotalDragScale
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x170001E6 RID: 486
		// (get) Token: 0x060005D7 RID: 1495 RVA: 0x00016C0E File Offset: 0x00014E0E
		public float RelativeDragScale
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x170001E7 RID: 487
		// (get) Token: 0x060005D8 RID: 1496 RVA: 0x00016C15 File Offset: 0x00014E15
		public GizmoOverrideColor OverrideFillColor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170001E8 RID: 488
		// (get) Token: 0x060005D9 RID: 1497 RVA: 0x00016C18 File Offset: 0x00014E18
		public GizmoOverrideColor OverrideBorderColor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170001E9 RID: 489
		// (get) Token: 0x060005DA RID: 1498 RVA: 0x00016C1B File Offset: 0x00014E1B
		public GizmoLineSlider2DSettings Settings
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170001EA RID: 490
		// (get) Token: 0x060005DB RID: 1499 RVA: 0x00016C1E File Offset: 0x00014E1E
		// (set) Token: 0x060005DC RID: 1500 RVA: 0x00016C21 File Offset: 0x00014E21
		public GizmoLineSlider2DSettings SharedSettings
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x170001EB RID: 491
		// (get) Token: 0x060005DD RID: 1501 RVA: 0x00016C23 File Offset: 0x00014E23
		public GizmoLineSlider2DLookAndFeel LookAndFeel
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170001EC RID: 492
		// (get) Token: 0x060005DE RID: 1502 RVA: 0x00016C26 File Offset: 0x00014E26
		// (set) Token: 0x060005DF RID: 1503 RVA: 0x00016C29 File Offset: 0x00014E29
		public GizmoLineSlider2DLookAndFeel SharedLookAndFeel
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x060005E0 RID: 1504 RVA: 0x00016C2B File Offset: 0x00014E2B
		public GizmoLineSlider2D(Gizmo gizmo, int handleId, int capHandleId) : base(null, 0)
		{
		}

		// Token: 0x060005E1 RID: 1505 RVA: 0x00016C35 File Offset: 0x00014E35
		public override void SetSnapEnabled(bool isEnabled)
		{
		}

		// Token: 0x060005E2 RID: 1506 RVA: 0x00016C37 File Offset: 0x00014E37
		public void Set2DCapVisible(bool isVisible)
		{
		}

		// Token: 0x060005E3 RID: 1507 RVA: 0x00016C39 File Offset: 0x00014E39
		public void Set2DCapHoverable(bool isHoverable)
		{
		}

		// Token: 0x060005E4 RID: 1508 RVA: 0x0001ED74 File Offset: 0x0001CF74
		public Vector2 GetRealDirection()
		{
			return default(Vector2);
		}

		// Token: 0x060005E5 RID: 1509 RVA: 0x00016C3B File Offset: 0x00014E3B
		public float GetRealLength()
		{
			return 0f;
		}

		// Token: 0x060005E6 RID: 1510 RVA: 0x0001ED8C File Offset: 0x0001CF8C
		public Vector2 GetRealEndPosition()
		{
			return default(Vector2);
		}

		// Token: 0x060005E7 RID: 1511 RVA: 0x00016C42 File Offset: 0x00014E42
		public float GetRealBoxThickness()
		{
			return 0f;
		}

		// Token: 0x060005E8 RID: 1512 RVA: 0x00016C49 File Offset: 0x00014E49
		public void MapDirection(int axisIndex, AxisSign axisSign)
		{
		}

		// Token: 0x060005E9 RID: 1513 RVA: 0x00016C4B File Offset: 0x00014E4B
		public void SetDirection(Vector2 directionAxis)
		{
		}

		// Token: 0x060005EA RID: 1514 RVA: 0x00016C4D File Offset: 0x00014E4D
		public void AddTargetTransform(GizmoTransform transform)
		{
		}

		// Token: 0x060005EB RID: 1515 RVA: 0x00016C4F File Offset: 0x00014E4F
		public void AddTargetTransform(GizmoTransform transform, GizmoDragChannel dragChannel)
		{
		}

		// Token: 0x060005EC RID: 1516 RVA: 0x00016C51 File Offset: 0x00014E51
		public void RemoveTargetTransform(GizmoTransform transform)
		{
		}

		// Token: 0x060005ED RID: 1517 RVA: 0x00016C53 File Offset: 0x00014E53
		public void RemoveTargetTransform(GizmoTransform transform, GizmoDragChannel dragChannel)
		{
		}

		// Token: 0x060005EE RID: 1518 RVA: 0x00016C55 File Offset: 0x00014E55
		public void SetDragChannel(GizmoDragChannel dragChannel)
		{
		}

		// Token: 0x060005EF RID: 1519 RVA: 0x00016C57 File Offset: 0x00014E57
		public override void Render(Camera camera)
		{
		}

		// Token: 0x060005F0 RID: 1520 RVA: 0x00016C59 File Offset: 0x00014E59
		public void Refresh()
		{
		}

		// Token: 0x060005F1 RID: 1521 RVA: 0x00016C5B File Offset: 0x00014E5B
		protected override void OnVisibilityStateChanged()
		{
		}

		// Token: 0x060005F2 RID: 1522 RVA: 0x00016C5D File Offset: 0x00014E5D
		protected override void OnHoverableStateChanged()
		{
		}

		// Token: 0x060005F3 RID: 1523 RVA: 0x00016C5F File Offset: 0x00014E5F
		private void OnGizmoPreUpdateBegin(Gizmo gizmo)
		{
		}

		// Token: 0x060005F4 RID: 1524 RVA: 0x00016C61 File Offset: 0x00014E61
		private void OnGizmoAttemptHandleDragBegin(Gizmo gizmo, int handleId)
		{
		}

		// Token: 0x060005F5 RID: 1525 RVA: 0x00016C63 File Offset: 0x00014E63
		private void OnTransformChanged(GizmoTransform transform, GizmoTransform.ChangeData changeData)
		{
		}

		// Token: 0x060005F6 RID: 1526 RVA: 0x00016C65 File Offset: 0x00014E65
		private void OnGizmoHandleHoverEnter(Gizmo gizmo, int handleId)
		{
		}

		// Token: 0x060005F7 RID: 1527 RVA: 0x00016C67 File Offset: 0x00014E67
		private void OnGizmoHandleHoverExit(Gizmo gizmo, int handleId)
		{
		}

		// Token: 0x060005F8 RID: 1528 RVA: 0x00016C69 File Offset: 0x00014E69
		private void OnGizmoHandleDragUpdate(Gizmo gizmo, int handleId)
		{
		}

		// Token: 0x060005F9 RID: 1529 RVA: 0x00016C6B File Offset: 0x00014E6B
		private void SetupSharedLookAndFeel()
		{
		}

		// Token: 0x060005FA RID: 1530 RVA: 0x00016C6D File Offset: 0x00014E6D
		private void OnGizmoPostEnabled(Gizmo gizmo)
		{
		}

		// Token: 0x040001E7 RID: 487
		private SegmentShape2D _segment;

		// Token: 0x040001E8 RID: 488
		private QuadShape2D _quad;

		// Token: 0x040001E9 RID: 489
		private int _segmentIndex;

		// Token: 0x040001EA RID: 490
		private int _quadIndex;

		// Token: 0x040001EB RID: 491
		private GizmoDragChannel _dragChannel;

		// Token: 0x040001EC RID: 492
		private GizmoSglAxisOffsetDrag3D _offsetDrag;

		// Token: 0x040001ED RID: 493
		private Vector3 _offsetDragOrigin;

		// Token: 0x040001EE RID: 494
		private GizmoSglAxisRotationDrag3D _rotationDrag;

		// Token: 0x040001EF RID: 495
		private GizmoRotationArc2D _rotationArc;

		// Token: 0x040001F0 RID: 496
		private GizmoSglAxisScaleDrag3D _scaleDrag;

		// Token: 0x040001F1 RID: 497
		private Vector3 _scaleDragOrigin;

		// Token: 0x040001F2 RID: 498
		private Vector3 _scaleAxis;

		// Token: 0x040001F3 RID: 499
		private int _scaleDragAxisIndex;

		// Token: 0x040001F4 RID: 500
		private IGizmoDragSession _selectedDragSession;

		// Token: 0x040001F5 RID: 501
		private GizmoCap2D _cap2D;

		// Token: 0x040001F6 RID: 502
		private GizmoTransform _transform;

		// Token: 0x040001F7 RID: 503
		private GizmoTransformAxisMap2D _directionAxisMap;

		// Token: 0x040001F8 RID: 504
		private GizmoOverrideColor _overrideFillColor;

		// Token: 0x040001F9 RID: 505
		private GizmoOverrideColor _overrideBorderColor;

		// Token: 0x040001FA RID: 506
		private GizmoLineSlider2DControllerData _controllerData;

		// Token: 0x040001FB RID: 507
		private IGizmoLineSlider2DController[] _controllers;

		// Token: 0x040001FC RID: 508
		private GizmoLineSlider2DSettings _settings;

		// Token: 0x040001FD RID: 509
		private GizmoLineSlider2DSettings _sharedSettings;

		// Token: 0x040001FE RID: 510
		private GizmoLineSlider2DLookAndFeel _lookAndFeel;

		// Token: 0x040001FF RID: 511
		private GizmoLineSlider2DLookAndFeel _sharedLookAndFeel;
	}
}
