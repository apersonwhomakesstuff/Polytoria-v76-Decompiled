using System;
using UnityEngine;

namespace RLD
{
	// Token: 0x02000061 RID: 97
	public class GizmoHandleHoverData
	{
		// Token: 0x170000F0 RID: 240
		// (get) Token: 0x06000398 RID: 920 RVA: 0x00016664 File Offset: 0x00014864
		public int HandleId
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x170000F1 RID: 241
		// (get) Token: 0x06000399 RID: 921 RVA: 0x00016667 File Offset: 0x00014867
		public Gizmo Gizmo
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170000F2 RID: 242
		// (get) Token: 0x0600039A RID: 922 RVA: 0x0001E7A4 File Offset: 0x0001C9A4
		public GizmoDimension HandleDimension
		{
			get
			{
				return GizmoDimension.None;
			}
		}

		// Token: 0x170000F3 RID: 243
		// (get) Token: 0x0600039B RID: 923 RVA: 0x0001E7BC File Offset: 0x0001C9BC
		public Ray HoverRay
		{
			get
			{
				return default(Ray);
			}
		}

		// Token: 0x170000F4 RID: 244
		// (get) Token: 0x0600039C RID: 924 RVA: 0x0001E7D4 File Offset: 0x0001C9D4
		public Vector3 HoverPoint
		{
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x170000F5 RID: 245
		// (get) Token: 0x0600039D RID: 925 RVA: 0x0001666A File Offset: 0x0001486A
		public float HoverEnter3D
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x0600039E RID: 926 RVA: 0x00016671 File Offset: 0x00014871
		public GizmoHandleHoverData(Ray hoverRay, IGizmoHandle gizmoHandle, float hoverEnter3D)
		{
		}

		// Token: 0x0600039F RID: 927 RVA: 0x00016679 File Offset: 0x00014879
		public GizmoHandleHoverData(Ray hoverRay, IGizmoHandle gizmoHandle, Vector2 hoverPt2D)
		{
		}

		// Token: 0x04000155 RID: 341
		private int _handleId;

		// Token: 0x04000156 RID: 342
		private Gizmo _gizmo;

		// Token: 0x04000157 RID: 343
		private GizmoDimension _handleDimension;

		// Token: 0x04000158 RID: 344
		private Ray _hoverRay;

		// Token: 0x04000159 RID: 345
		private Vector3 _hoverPoint;

		// Token: 0x0400015A RID: 346
		private float _hoverEnter3D;
	}
}
