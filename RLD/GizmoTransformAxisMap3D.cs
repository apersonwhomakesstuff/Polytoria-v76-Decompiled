using System;
using UnityEngine;

namespace RLD
{
	// Token: 0x02000035 RID: 53
	public class GizmoTransformAxisMap3D
	{
		// Token: 0x17000079 RID: 121
		// (get) Token: 0x060001D3 RID: 467 RVA: 0x00016298 File Offset: 0x00014498
		public AxisDescriptor MappedAxisDesc
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x060001D4 RID: 468 RVA: 0x0001629B File Offset: 0x0001449B
		public int MappedAxisIndex
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x060001D5 RID: 469 RVA: 0x0001E3E4 File Offset: 0x0001C5E4
		public AxisSign MappedAxisSign
		{
			get
			{
				return AxisSign.Positive;
			}
		}

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x060001D6 RID: 470 RVA: 0x0001629E File Offset: 0x0001449E
		public bool IsMapped
		{
			get
			{
				return false;
			}
		}

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x060001D7 RID: 471 RVA: 0x0001E3FC File Offset: 0x0001C5FC
		public Vector3 Axis
		{
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x060001D8 RID: 472 RVA: 0x000162A1 File Offset: 0x000144A1
		public GizmoTransform Transform
		{
			get
			{
				return null;
			}
		}

		// Token: 0x060001D9 RID: 473 RVA: 0x000162A4 File Offset: 0x000144A4
		public void Map(GizmoTransform transform, int axisIndex, AxisSign axisSign)
		{
		}

		// Token: 0x060001DA RID: 474 RVA: 0x000162A6 File Offset: 0x000144A6
		public void Unmap()
		{
		}

		// Token: 0x060001DB RID: 475 RVA: 0x000162A8 File Offset: 0x000144A8
		public void SetAxis(Vector3 axis)
		{
		}

		// Token: 0x060001DC RID: 476 RVA: 0x000162AA File Offset: 0x000144AA
		public void SetMappedAxis(Vector3 axis)
		{
		}

		// Token: 0x060001DD RID: 477 RVA: 0x000162AC File Offset: 0x000144AC
		public void SetFreeAxis(Vector3 axis)
		{
		}

		// Token: 0x040000CA RID: 202
		private Vector3 _freeAxis;

		// Token: 0x040000CB RID: 203
		private AxisDescriptor _mappedAxisDesc;

		// Token: 0x040000CC RID: 204
		private GizmoTransform _transform;
	}
}
