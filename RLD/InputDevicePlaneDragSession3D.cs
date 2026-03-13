using System;
using UnityEngine;

namespace RLD
{
	// Token: 0x020001C1 RID: 449
	public class InputDevicePlaneDragSession3D
	{
		// Token: 0x1700065E RID: 1630
		// (get) Token: 0x0600139C RID: 5020 RVA: 0x00021C74 File Offset: 0x0001FE74
		// (set) Token: 0x0600139D RID: 5021 RVA: 0x0001945A File Offset: 0x0001765A
		public Plane Plane
		{
			get
			{
				return default(Plane);
			}
			set
			{
			}
		}

		// Token: 0x1700065F RID: 1631
		// (get) Token: 0x0600139E RID: 5022 RVA: 0x0001945C File Offset: 0x0001765C
		// (set) Token: 0x0600139F RID: 5023 RVA: 0x0001945F File Offset: 0x0001765F
		public Camera RaycastCamera
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x17000660 RID: 1632
		// (get) Token: 0x060013A0 RID: 5024 RVA: 0x00021C8C File Offset: 0x0001FE8C
		public Vector3 DragPoint
		{
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x17000661 RID: 1633
		// (get) Token: 0x060013A1 RID: 5025 RVA: 0x00021CA4 File Offset: 0x0001FEA4
		public Vector3 DragDelta
		{
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x17000662 RID: 1634
		// (get) Token: 0x060013A2 RID: 5026 RVA: 0x00021CBC File Offset: 0x0001FEBC
		public Vector3 AccumDrag
		{
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x17000663 RID: 1635
		// (get) Token: 0x060013A3 RID: 5027 RVA: 0x00019461 File Offset: 0x00017661
		public bool IsActive
		{
			get
			{
				return false;
			}
		}

		// Token: 0x060013A4 RID: 5028 RVA: 0x00019464 File Offset: 0x00017664
		public InputDevicePlaneDragSession3D(IInputDevice inputDevice, Camera raycastCamera)
		{
		}

		// Token: 0x060013A5 RID: 5029 RVA: 0x0001946C File Offset: 0x0001766C
		public bool Begin()
		{
			return false;
		}

		// Token: 0x060013A6 RID: 5030 RVA: 0x0001946F File Offset: 0x0001766F
		public void End()
		{
		}

		// Token: 0x060013A7 RID: 5031 RVA: 0x00019471 File Offset: 0x00017671
		public bool Update()
		{
			return false;
		}

		// Token: 0x060013A8 RID: 5032 RVA: 0x00019474 File Offset: 0x00017674
		private bool UpdateDragPoint()
		{
			return false;
		}

		// Token: 0x04000713 RID: 1811
		private Plane _plane;

		// Token: 0x04000714 RID: 1812
		private Camera _raycastCamera;

		// Token: 0x04000715 RID: 1813
		private Vector3 _dragPoint;

		// Token: 0x04000716 RID: 1814
		private Vector3 _dragDelta;

		// Token: 0x04000717 RID: 1815
		private Vector3 _accumDrag;

		// Token: 0x04000718 RID: 1816
		private IInputDevice _inputDevice;

		// Token: 0x04000719 RID: 1817
		private bool _isActive;
	}
}
