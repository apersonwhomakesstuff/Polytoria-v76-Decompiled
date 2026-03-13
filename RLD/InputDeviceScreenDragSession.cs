using System;
using UnityEngine;

namespace RLD
{
	// Token: 0x020001C2 RID: 450
	public class InputDeviceScreenDragSession
	{
		// Token: 0x17000664 RID: 1636
		// (get) Token: 0x060013A9 RID: 5033 RVA: 0x00021CD4 File Offset: 0x0001FED4
		public Vector2 DragPoint
		{
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x17000665 RID: 1637
		// (get) Token: 0x060013AA RID: 5034 RVA: 0x00021CEC File Offset: 0x0001FEEC
		public Vector2 DragDelta
		{
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x17000666 RID: 1638
		// (get) Token: 0x060013AB RID: 5035 RVA: 0x00021D04 File Offset: 0x0001FF04
		public Vector2 AccumDrag
		{
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x17000667 RID: 1639
		// (get) Token: 0x060013AC RID: 5036 RVA: 0x00019477 File Offset: 0x00017677
		public bool IsActive
		{
			get
			{
				return false;
			}
		}

		// Token: 0x060013AD RID: 5037 RVA: 0x0001947A File Offset: 0x0001767A
		public InputDeviceScreenDragSession(IInputDevice inputDevice)
		{
		}

		// Token: 0x060013AE RID: 5038 RVA: 0x00019482 File Offset: 0x00017682
		public bool Begin()
		{
			return false;
		}

		// Token: 0x060013AF RID: 5039 RVA: 0x00019485 File Offset: 0x00017685
		public void End()
		{
		}

		// Token: 0x060013B0 RID: 5040 RVA: 0x00019487 File Offset: 0x00017687
		public bool Update()
		{
			return false;
		}

		// Token: 0x060013B1 RID: 5041 RVA: 0x0001948A File Offset: 0x0001768A
		private bool UpdateDragPoint()
		{
			return false;
		}

		// Token: 0x0400071A RID: 1818
		private Vector2 _dragPoint;

		// Token: 0x0400071B RID: 1819
		private Vector2 _dragDelta;

		// Token: 0x0400071C RID: 1820
		private Vector2 _accumDrag;

		// Token: 0x0400071D RID: 1821
		private IInputDevice _inputDevice;

		// Token: 0x0400071E RID: 1822
		private bool _isActive;
	}
}
