using System;
using UnityEngine;

namespace RLD
{
	// Token: 0x02000034 RID: 52
	public class GizmoTransformAxisMap2D
	{
		// Token: 0x17000073 RID: 115
		// (get) Token: 0x060001C7 RID: 455 RVA: 0x0001627A File Offset: 0x0001447A
		public AxisDescriptor MappedAxisDesc
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x060001C8 RID: 456 RVA: 0x0001627D File Offset: 0x0001447D
		public int MappedAxisIndex
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x060001C9 RID: 457 RVA: 0x0001E3B4 File Offset: 0x0001C5B4
		public AxisSign MappedAxisSign
		{
			get
			{
				return AxisSign.Positive;
			}
		}

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x060001CA RID: 458 RVA: 0x00016280 File Offset: 0x00014480
		public bool IsMapped
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x060001CB RID: 459 RVA: 0x0001E3CC File Offset: 0x0001C5CC
		public Vector2 Axis
		{
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x060001CC RID: 460 RVA: 0x00016283 File Offset: 0x00014483
		public GizmoTransform Transform
		{
			get
			{
				return null;
			}
		}

		// Token: 0x060001CD RID: 461 RVA: 0x00016286 File Offset: 0x00014486
		public void Map(GizmoTransform transform, int axisIndex, AxisSign axisSign)
		{
		}

		// Token: 0x060001CE RID: 462 RVA: 0x00016288 File Offset: 0x00014488
		public void Unmap()
		{
		}

		// Token: 0x060001CF RID: 463 RVA: 0x0001628A File Offset: 0x0001448A
		public void SetAxis(Vector2 axis)
		{
		}

		// Token: 0x060001D0 RID: 464 RVA: 0x0001628C File Offset: 0x0001448C
		public void SetMappedAxis(Vector2 axis)
		{
		}

		// Token: 0x060001D1 RID: 465 RVA: 0x0001628E File Offset: 0x0001448E
		public void SetFreeAxis(Vector2 axis)
		{
		}

		// Token: 0x040000C7 RID: 199
		private Vector2 _freeAxis;

		// Token: 0x040000C8 RID: 200
		private AxisDescriptor _mappedAxisDesc;

		// Token: 0x040000C9 RID: 201
		private GizmoTransform _transform;
	}
}
