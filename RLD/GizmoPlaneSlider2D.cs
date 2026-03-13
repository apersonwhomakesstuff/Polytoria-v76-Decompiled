using System;
using System.Collections.Generic;
using UnityEngine;

namespace RLD
{
	// Token: 0x0200008F RID: 143
	public class GizmoPlaneSlider2D : GizmoSlider
	{
		// Token: 0x17000204 RID: 516
		// (get) Token: 0x06000645 RID: 1605 RVA: 0x00016D52 File Offset: 0x00014F52
		public GizmoPlaneSlider2DSettings Settings
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000205 RID: 517
		// (get) Token: 0x06000646 RID: 1606 RVA: 0x00016D55 File Offset: 0x00014F55
		// (set) Token: 0x06000647 RID: 1607 RVA: 0x00016D58 File Offset: 0x00014F58
		public GizmoPlaneSlider2DSettings SharedSettings
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x17000206 RID: 518
		// (get) Token: 0x06000648 RID: 1608 RVA: 0x00016D5A File Offset: 0x00014F5A
		public GizmoPlaneSlider2DLookAndFeel LookAndFeel
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000207 RID: 519
		// (get) Token: 0x06000649 RID: 1609 RVA: 0x00016D5D File Offset: 0x00014F5D
		// (set) Token: 0x0600064A RID: 1610 RVA: 0x00016D60 File Offset: 0x00014F60
		public GizmoPlaneSlider2DLookAndFeel SharedLookAndFeel
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x17000208 RID: 520
		// (get) Token: 0x0600064B RID: 1611 RVA: 0x0001EE64 File Offset: 0x0001D064
		// (set) Token: 0x0600064C RID: 1612 RVA: 0x00016D62 File Offset: 0x00014F62
		public Vector2 Position
		{
			get
			{
				return default(Vector2);
			}
			set
			{
			}
		}

		// Token: 0x17000209 RID: 521
		// (get) Token: 0x0600064D RID: 1613 RVA: 0x0001EE7C File Offset: 0x0001D07C
		public Vector2 PolyCenter
		{
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x1700020A RID: 522
		// (get) Token: 0x0600064E RID: 1614 RVA: 0x0001EE94 File Offset: 0x0001D094
		public Quaternion Rotation
		{
			get
			{
				return default(Quaternion);
			}
		}

		// Token: 0x1700020B RID: 523
		// (get) Token: 0x0600064F RID: 1615 RVA: 0x00016D64 File Offset: 0x00014F64
		// (set) Token: 0x06000650 RID: 1616 RVA: 0x00016D6B File Offset: 0x00014F6B
		public float RotationDegrees
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x1700020C RID: 524
		// (get) Token: 0x06000651 RID: 1617 RVA: 0x0001EEAC File Offset: 0x0001D0AC
		public Vector2 Right
		{
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x1700020D RID: 525
		// (get) Token: 0x06000652 RID: 1618 RVA: 0x0001EEC4 File Offset: 0x0001D0C4
		public Vector2 Up
		{
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x1700020E RID: 526
		// (get) Token: 0x06000653 RID: 1619 RVA: 0x0001EEDC File Offset: 0x0001D0DC
		// (set) Token: 0x06000654 RID: 1620 RVA: 0x00016D6D File Offset: 0x00014F6D
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

		// Token: 0x1700020F RID: 527
		// (get) Token: 0x06000655 RID: 1621 RVA: 0x0001EEF4 File Offset: 0x0001D0F4
		public GizmoDragChannel DragChannel
		{
			get
			{
				return GizmoDragChannel.None;
			}
		}

		// Token: 0x17000210 RID: 528
		// (get) Token: 0x06000656 RID: 1622 RVA: 0x0001EF0C File Offset: 0x0001D10C
		// (set) Token: 0x06000657 RID: 1623 RVA: 0x00016D6F File Offset: 0x00014F6F
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

		// Token: 0x17000211 RID: 529
		// (get) Token: 0x06000658 RID: 1624 RVA: 0x00016D71 File Offset: 0x00014F71
		// (set) Token: 0x06000659 RID: 1625 RVA: 0x00016D74 File Offset: 0x00014F74
		public int ScaleDragAxisIndexRight
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x17000212 RID: 530
		// (get) Token: 0x0600065A RID: 1626 RVA: 0x00016D76 File Offset: 0x00014F76
		// (set) Token: 0x0600065B RID: 1627 RVA: 0x00016D79 File Offset: 0x00014F79
		public int ScaleDragAxisIndexUp
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x17000213 RID: 531
		// (get) Token: 0x0600065C RID: 1628 RVA: 0x0001EF24 File Offset: 0x0001D124
		public Vector3 TotalDragOffset
		{
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x17000214 RID: 532
		// (get) Token: 0x0600065D RID: 1629 RVA: 0x0001EF3C File Offset: 0x0001D13C
		public Vector3 RelativeDragOffset
		{
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x17000215 RID: 533
		// (get) Token: 0x0600065E RID: 1630 RVA: 0x00016D7B File Offset: 0x00014F7B
		public float TotalDragRotation
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000216 RID: 534
		// (get) Token: 0x0600065F RID: 1631 RVA: 0x00016D82 File Offset: 0x00014F82
		public float RelativeDragRotation
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000217 RID: 535
		// (get) Token: 0x06000660 RID: 1632 RVA: 0x00016D89 File Offset: 0x00014F89
		public float TotalDragScaleRight
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000218 RID: 536
		// (get) Token: 0x06000661 RID: 1633 RVA: 0x00016D90 File Offset: 0x00014F90
		public float RelativeDragScaleRight
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000219 RID: 537
		// (get) Token: 0x06000662 RID: 1634 RVA: 0x00016D97 File Offset: 0x00014F97
		public float TotalDragScaleUp
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700021A RID: 538
		// (get) Token: 0x06000663 RID: 1635 RVA: 0x00016D9E File Offset: 0x00014F9E
		public float RelativeDragScaleUp
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700021B RID: 539
		// (get) Token: 0x06000664 RID: 1636 RVA: 0x00016DA5 File Offset: 0x00014FA5
		public bool IsBorderVisible
		{
			get
			{
				return false;
			}
		}

		// Token: 0x1700021C RID: 540
		// (get) Token: 0x06000665 RID: 1637 RVA: 0x00016DA8 File Offset: 0x00014FA8
		public bool IsBorderHoverable
		{
			get
			{
				return false;
			}
		}

		// Token: 0x1700021D RID: 541
		// (get) Token: 0x06000666 RID: 1638 RVA: 0x00016DAB File Offset: 0x00014FAB
		public bool IsDragged
		{
			get
			{
				return false;
			}
		}

		// Token: 0x1700021E RID: 542
		// (get) Token: 0x06000667 RID: 1639 RVA: 0x00016DAE File Offset: 0x00014FAE
		public bool IsMoving
		{
			get
			{
				return false;
			}
		}

		// Token: 0x1700021F RID: 543
		// (get) Token: 0x06000668 RID: 1640 RVA: 0x00016DB1 File Offset: 0x00014FB1
		public bool IsRotating
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000220 RID: 544
		// (get) Token: 0x06000669 RID: 1641 RVA: 0x00016DB4 File Offset: 0x00014FB4
		public bool IsScaling
		{
			get
			{
				return false;
			}
		}

		// Token: 0x0600066A RID: 1642 RVA: 0x00016DB7 File Offset: 0x00014FB7
		public GizmoPlaneSlider2D(Gizmo gizmo, int handleId) : base(null, 0)
		{
		}

		// Token: 0x0600066B RID: 1643 RVA: 0x00016DC1 File Offset: 0x00014FC1
		public void SetBorderVisible(bool isVisible)
		{
		}

		// Token: 0x0600066C RID: 1644 RVA: 0x00016DC3 File Offset: 0x00014FC3
		public void SetBorderHoverable(bool isHoverable)
		{
		}

		// Token: 0x0600066D RID: 1645 RVA: 0x00016DC5 File Offset: 0x00014FC5
		public override void SetSnapEnabled(bool isEnabled)
		{
		}

		// Token: 0x0600066E RID: 1646 RVA: 0x00016DC7 File Offset: 0x00014FC7
		public void SetPolyCwPoints(List<Vector2> cwPoints, bool isClosed)
		{
		}

		// Token: 0x0600066F RID: 1647 RVA: 0x00016DC9 File Offset: 0x00014FC9
		public void MakePolySphereBorder(Vector3 sphereCenter, float sphereRadius, int numPoints, Camera camera)
		{
		}

		// Token: 0x06000670 RID: 1648 RVA: 0x00016DCB File Offset: 0x00014FCB
		public float GetRealQuadWidth()
		{
			return 0f;
		}

		// Token: 0x06000671 RID: 1649 RVA: 0x00016DD2 File Offset: 0x00014FD2
		public float GetRealQuadHeight()
		{
			return 0f;
		}

		// Token: 0x06000672 RID: 1650 RVA: 0x0001EF54 File Offset: 0x0001D154
		public Vector2 GetRealQuadSize()
		{
			return default(Vector2);
		}

		// Token: 0x06000673 RID: 1651 RVA: 0x00016DD9 File Offset: 0x00014FD9
		public float GetRealCircleRadius()
		{
			return 0f;
		}

		// Token: 0x06000674 RID: 1652 RVA: 0x0001EF6C File Offset: 0x0001D16C
		public Vector2 GetRealExtentPoint(Shape2DExtentPoint extentPt)
		{
			return default(Vector2);
		}

		// Token: 0x06000675 RID: 1653 RVA: 0x00016DE0 File Offset: 0x00014FE0
		public void SetDragChannel(GizmoDragChannel dragChannel)
		{
		}

		// Token: 0x06000676 RID: 1654 RVA: 0x00016DE2 File Offset: 0x00014FE2
		public void AddTargetTransform(GizmoTransform transform)
		{
		}

		// Token: 0x06000677 RID: 1655 RVA: 0x00016DE4 File Offset: 0x00014FE4
		public void AddTargetTransform(GizmoTransform transform, GizmoDragChannel dragChannel)
		{
		}

		// Token: 0x06000678 RID: 1656 RVA: 0x00016DE6 File Offset: 0x00014FE6
		public void RemoveTargetTransform(GizmoTransform transform)
		{
		}

		// Token: 0x06000679 RID: 1657 RVA: 0x00016DE8 File Offset: 0x00014FE8
		public void RemoveTargetTransform(GizmoTransform transform, GizmoDragChannel dragChannel)
		{
		}

		// Token: 0x0600067A RID: 1658 RVA: 0x00016DEA File Offset: 0x00014FEA
		public override void Render(Camera camera)
		{
		}

		// Token: 0x0600067B RID: 1659 RVA: 0x00016DEC File Offset: 0x00014FEC
		public void Refresh()
		{
		}

		// Token: 0x0600067C RID: 1660 RVA: 0x00016DEE File Offset: 0x00014FEE
		protected override void OnVisibilityStateChanged()
		{
		}

		// Token: 0x0600067D RID: 1661 RVA: 0x00016DF0 File Offset: 0x00014FF0
		protected override void OnHoverableStateChanged()
		{
		}

		// Token: 0x0600067E RID: 1662 RVA: 0x00016DF2 File Offset: 0x00014FF2
		private void OnGizmoPreUpdateBegin(Gizmo gizmo)
		{
		}

		// Token: 0x0600067F RID: 1663 RVA: 0x00016DF4 File Offset: 0x00014FF4
		private void OnTransformChanged(GizmoTransform transform, GizmoTransform.ChangeData changeData)
		{
		}

		// Token: 0x06000680 RID: 1664 RVA: 0x00016DF6 File Offset: 0x00014FF6
		private void OnGizmoAttemptHandleDragBegin(Gizmo gizmo, int handleId)
		{
		}

		// Token: 0x06000681 RID: 1665 RVA: 0x00016DF8 File Offset: 0x00014FF8
		private void OnGizmoHandleDragUpdate(Gizmo gizmo, int handleId)
		{
		}

		// Token: 0x06000682 RID: 1666 RVA: 0x00016DFA File Offset: 0x00014FFA
		private void OnGizmoPostEnabled(Gizmo gizmo)
		{
		}

		// Token: 0x04000221 RID: 545
		private int _quadIndex;

		// Token: 0x04000222 RID: 546
		private int _circleIndex;

		// Token: 0x04000223 RID: 547
		private int _polygonIndex;

		// Token: 0x04000224 RID: 548
		private QuadShape2D _quad;

		// Token: 0x04000225 RID: 549
		private CircleShape2D _circle;

		// Token: 0x04000226 RID: 550
		private PolygonShape2D _polygon;

		// Token: 0x04000227 RID: 551
		private GizmoQuad2DBorder _quadBorder;

		// Token: 0x04000228 RID: 552
		private GizmoCircle2DBorder _circleBorder;

		// Token: 0x04000229 RID: 553
		private GizmoPolygon2DBorder _polygonBorder;

		// Token: 0x0400022A RID: 554
		private bool _isBorderVisible;

		// Token: 0x0400022B RID: 555
		private bool _isBorderHoverable;

		// Token: 0x0400022C RID: 556
		private GizmoTransform _transform;

		// Token: 0x0400022D RID: 557
		private GizmoDragChannel _dragChannel;

		// Token: 0x0400022E RID: 558
		private IGizmoDragSession _selectedDragSession;

		// Token: 0x0400022F RID: 559
		private GizmoDblAxisOffsetDrag3D _offsetDrag;

		// Token: 0x04000230 RID: 560
		private Vector3 _offsetDragOrigin;

		// Token: 0x04000231 RID: 561
		private GizmoSglAxisRotationDrag3D _rotationDrag;

		// Token: 0x04000232 RID: 562
		private GizmoRotationArc2D _rotationArc;

		// Token: 0x04000233 RID: 563
		private GizmoDblAxisScaleDrag3D _scaleDrag;

		// Token: 0x04000234 RID: 564
		private Vector3 _scaleDragOrigin;

		// Token: 0x04000235 RID: 565
		private Vector3 _scaleAxisRight;

		// Token: 0x04000236 RID: 566
		private Vector3 _scaleAxisUp;

		// Token: 0x04000237 RID: 567
		private int _scaleDragAxisIndexRight;

		// Token: 0x04000238 RID: 568
		private int _scaleDragAxisIndexUp;

		// Token: 0x04000239 RID: 569
		private GizmoPlaneSlider2DControllerData _controllerData;

		// Token: 0x0400023A RID: 570
		private IGizmoPlaneSlider2DController[] _controllers;

		// Token: 0x0400023B RID: 571
		private GizmoPlaneSlider2DSettings _settings;

		// Token: 0x0400023C RID: 572
		private GizmoPlaneSlider2DSettings _sharedSettings;

		// Token: 0x0400023D RID: 573
		private GizmoPlaneSlider2DLookAndFeel _lookAndFeel;

		// Token: 0x0400023E RID: 574
		private GizmoPlaneSlider2DLookAndFeel _sharedLookAndFeel;
	}
}
