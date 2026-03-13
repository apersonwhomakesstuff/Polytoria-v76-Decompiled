using System;
using UnityEngine;

namespace RLD
{
	// Token: 0x02000080 RID: 128
	[Serializable]
	public class BoxGizmo : GizmoBehaviour
	{
		// Token: 0x170001B5 RID: 437
		// (get) Token: 0x0600056A RID: 1386 RVA: 0x00016AEF File Offset: 0x00014CEF
		public BoxGizmoSettings3D Settings3D
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170001B6 RID: 438
		// (get) Token: 0x0600056B RID: 1387 RVA: 0x00016AF2 File Offset: 0x00014CF2
		// (set) Token: 0x0600056C RID: 1388 RVA: 0x00016AF5 File Offset: 0x00014CF5
		public BoxGizmoSettings3D SharedSettings3D
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x170001B7 RID: 439
		// (get) Token: 0x0600056D RID: 1389 RVA: 0x00016AF7 File Offset: 0x00014CF7
		public BoxGizmoLookAndFeel3D LookAndFeel3D
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170001B8 RID: 440
		// (get) Token: 0x0600056E RID: 1390 RVA: 0x00016AFA File Offset: 0x00014CFA
		// (set) Token: 0x0600056F RID: 1391 RVA: 0x00016AFD File Offset: 0x00014CFD
		public BoxGizmoLookAndFeel3D SharedLookAndFeel3D
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x170001B9 RID: 441
		// (get) Token: 0x06000570 RID: 1392 RVA: 0x00016AFF File Offset: 0x00014CFF
		public BoxGizmoHotkeys Hotkeys
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170001BA RID: 442
		// (get) Token: 0x06000571 RID: 1393 RVA: 0x00016B02 File Offset: 0x00014D02
		// (set) Token: 0x06000572 RID: 1394 RVA: 0x00016B05 File Offset: 0x00014D05
		public BoxGizmoHotkeys SharedHotkeys
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x170001BB RID: 443
		// (get) Token: 0x06000573 RID: 1395 RVA: 0x0001EB64 File Offset: 0x0001CD64
		public BoxGizmo.Usage BoxUsage
		{
			get
			{
				return BoxGizmo.Usage.Generic;
			}
		}

		// Token: 0x170001BC RID: 444
		// (get) Token: 0x06000574 RID: 1396 RVA: 0x00016B07 File Offset: 0x00014D07
		public bool IsUsagePermanent
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170001BD RID: 445
		// (get) Token: 0x06000575 RID: 1397 RVA: 0x0001EB7C File Offset: 0x0001CD7C
		public Vector3 BoxCenter
		{
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x170001BE RID: 446
		// (get) Token: 0x06000576 RID: 1398 RVA: 0x0001EB94 File Offset: 0x0001CD94
		public Quaternion BoxRotation
		{
			get
			{
				return default(Quaternion);
			}
		}

		// Token: 0x170001BF RID: 447
		// (get) Token: 0x06000577 RID: 1399 RVA: 0x0001EBAC File Offset: 0x0001CDAC
		public Vector3 BoxRight
		{
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x170001C0 RID: 448
		// (get) Token: 0x06000578 RID: 1400 RVA: 0x0001EBC4 File Offset: 0x0001CDC4
		public Vector3 BoxUp
		{
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x170001C1 RID: 449
		// (get) Token: 0x06000579 RID: 1401 RVA: 0x0001EBDC File Offset: 0x0001CDDC
		public Vector3 BoxLook
		{
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x0600057A RID: 1402 RVA: 0x00016B0A File Offset: 0x00014D0A
		public override void OnDetached()
		{
		}

		// Token: 0x0600057B RID: 1403 RVA: 0x00016B0C File Offset: 0x00014D0C
		public override void OnEnabled()
		{
		}

		// Token: 0x0600057C RID: 1404 RVA: 0x00016B0E File Offset: 0x00014D0E
		public override void OnDisabled()
		{
		}

		// Token: 0x0600057D RID: 1405 RVA: 0x00016B10 File Offset: 0x00014D10
		public override void OnGizmoEnabled()
		{
		}

		// Token: 0x0600057E RID: 1406 RVA: 0x00016B12 File Offset: 0x00014D12
		public void MakeUsagePermanent()
		{
		}

		// Token: 0x0600057F RID: 1407 RVA: 0x00016B14 File Offset: 0x00014D14
		public bool OwnsHandle(int handleId)
		{
			return false;
		}

		// Token: 0x06000580 RID: 1408 RVA: 0x00016B17 File Offset: 0x00014D17
		public bool IsXTick(int handleId)
		{
			return false;
		}

		// Token: 0x06000581 RID: 1409 RVA: 0x00016B1A File Offset: 0x00014D1A
		public bool IsYTick(int handleId)
		{
			return false;
		}

		// Token: 0x06000582 RID: 1410 RVA: 0x00016B1D File Offset: 0x00014D1D
		public bool IsZTick(int handleId)
		{
			return false;
		}

		// Token: 0x06000583 RID: 1411 RVA: 0x00016B20 File Offset: 0x00014D20
		public void SetSnapEnabled(bool isEnabled)
		{
		}

		// Token: 0x06000584 RID: 1412 RVA: 0x00016B22 File Offset: 0x00014D22
		public void SetSize(Vector3 size)
		{
		}

		// Token: 0x06000585 RID: 1413 RVA: 0x00016B24 File Offset: 0x00014D24
		public void SetUsage(BoxGizmo.Usage usage)
		{
		}

		// Token: 0x06000586 RID: 1414 RVA: 0x00016B26 File Offset: 0x00014D26
		public bool SetTargetHierarchy(GameObject targetHierarchy)
		{
			return false;
		}

		// Token: 0x06000587 RID: 1415 RVA: 0x00016B29 File Offset: 0x00014D29
		public bool FitBoxToTargetHierarchy()
		{
			return false;
		}

		// Token: 0x06000588 RID: 1416 RVA: 0x00016B2C File Offset: 0x00014D2C
		public override void OnAttached()
		{
		}

		// Token: 0x06000589 RID: 1417 RVA: 0x00016B2E File Offset: 0x00014D2E
		public override bool OnGizmoCanBeginDrag(int handleId)
		{
			return false;
		}

		// Token: 0x0600058A RID: 1418 RVA: 0x00016B31 File Offset: 0x00014D31
		public override void OnGizmoUpdateBegin()
		{
		}

		// Token: 0x0600058B RID: 1419 RVA: 0x00016B33 File Offset: 0x00014D33
		public override void OnGizmoRender(Camera camera)
		{
		}

		// Token: 0x0600058C RID: 1420 RVA: 0x00016B35 File Offset: 0x00014D35
		public override void OnGizmoAttemptHandleDragBegin(int handleId)
		{
		}

		// Token: 0x0600058D RID: 1421 RVA: 0x00016B37 File Offset: 0x00014D37
		public override void OnGizmoDragUpdate(int handleId)
		{
		}

		// Token: 0x0600058E RID: 1422 RVA: 0x00016B39 File Offset: 0x00014D39
		public override void OnGizmoDragEnd(int handleId)
		{
		}

		// Token: 0x0600058F RID: 1423 RVA: 0x00016B3B File Offset: 0x00014D3B
		private void OnUndoRedoEnd(IUndoRedoAction action)
		{
		}

		// Token: 0x06000590 RID: 1424 RVA: 0x00016B3D File Offset: 0x00014D3D
		private void UpdateTickPositions()
		{
		}

		// Token: 0x06000591 RID: 1425 RVA: 0x00016B3F File Offset: 0x00014D3F
		private void ValidateBoxSize()
		{
		}

		// Token: 0x06000592 RID: 1426 RVA: 0x00016B41 File Offset: 0x00014D41
		private void SetupSharedLookAndFeel()
		{
		}

		// Token: 0x06000593 RID: 1427 RVA: 0x00016B43 File Offset: 0x00014D43
		private void SetupSharedSettings()
		{
		}

		// Token: 0x06000594 RID: 1428 RVA: 0x00016B45 File Offset: 0x00014D45
		private void OnGizmoTransformChanged(GizmoTransform gizmoTransform, GizmoTransform.ChangeData changeData)
		{
		}

		// Token: 0x06000595 RID: 1429 RVA: 0x0001EBF4 File Offset: 0x0001CDF4
		private OBB CalcTargetRootOBB(GameObject targetRoot)
		{
			return default(OBB);
		}

		// Token: 0x040001C8 RID: 456
		private BoxGizmo.Usage _usage;

		// Token: 0x040001C9 RID: 457
		private bool _isUsagePermanent;

		// Token: 0x040001CA RID: 458
		private Vector3 _boxSize;

		// Token: 0x040001CB RID: 459
		private GameObject _targetHierarchy;

		// Token: 0x040001CC RID: 460
		private Transform _targetHierarchyTransform;

		// Token: 0x040001CD RID: 461
		private LocalTransformSnapshot _dragBeginTargetTransformSnapshot;

		// Token: 0x040001CE RID: 462
		private GizmoCap2D _rightTick;

		// Token: 0x040001CF RID: 463
		private GizmoCap2D _topTick;

		// Token: 0x040001D0 RID: 464
		private GizmoCap2D _backTick;

		// Token: 0x040001D1 RID: 465
		private GizmoCap2D _leftTick;

		// Token: 0x040001D2 RID: 466
		private GizmoCap2D _bottomTick;

		// Token: 0x040001D3 RID: 467
		private GizmoCap2D _frontTick;

		// Token: 0x040001D4 RID: 468
		private GizmoCap2DCollection _ticks;

		// Token: 0x040001D5 RID: 469
		private bool _scaleFromCenter;

		// Token: 0x040001D6 RID: 470
		private Vector3 _scalePivot;

		// Token: 0x040001D7 RID: 471
		private GizmoSglAxisScaleDrag3D.WorkData _scaleDragWorkData;

		// Token: 0x040001D8 RID: 472
		private GizmoSglAxisScaleDrag3D _scaleDrag;

		// Token: 0x040001D9 RID: 473
		private BoxGizmoSettings3D _settings3D;

		// Token: 0x040001DA RID: 474
		private BoxGizmoSettings3D _sharedSettings3D;

		// Token: 0x040001DB RID: 475
		private BoxGizmoLookAndFeel3D _lookAndFeel3D;

		// Token: 0x040001DC RID: 476
		private BoxGizmoLookAndFeel3D _sharedLookAndFeel3D;

		// Token: 0x040001DD RID: 477
		private BoxGizmoHotkeys _hotkeys;

		// Token: 0x040001DE RID: 478
		private BoxGizmoHotkeys _sharedHotkeys;

		// Token: 0x02000365 RID: 869
		public enum Usage
		{
			// Token: 0x04000EDE RID: 3806
			Generic,
			// Token: 0x04000EDF RID: 3807
			ObjectScale
		}
	}
}
