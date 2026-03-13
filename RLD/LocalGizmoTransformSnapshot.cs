using System;
using System.Collections.Generic;
using UnityEngine;

namespace RLD
{
	// Token: 0x02000036 RID: 54
	public class LocalGizmoTransformSnapshot
	{
		// Token: 0x1700007F RID: 127
		// (get) Token: 0x060001DF RID: 479 RVA: 0x000162B6 File Offset: 0x000144B6
		public GizmoTransform Transform
		{
			get
			{
				return null;
			}
		}

		// Token: 0x060001E0 RID: 480 RVA: 0x000162B9 File Offset: 0x000144B9
		public static List<LocalGizmoTransformSnapshot> GetSnapshotCollection(IEnumerable<Gizmo> gizmos)
		{
			return null;
		}

		// Token: 0x060001E1 RID: 481 RVA: 0x000162BC File Offset: 0x000144BC
		public void Snapshot(GizmoTransform transform)
		{
		}

		// Token: 0x060001E2 RID: 482 RVA: 0x000162BE File Offset: 0x000144BE
		public void Apply()
		{
		}

		// Token: 0x040000CD RID: 205
		private GizmoTransform _transform;

		// Token: 0x040000CE RID: 206
		private GizmoTransform _parentTransform;

		// Token: 0x040000CF RID: 207
		private Vector3 _localPosition3D;

		// Token: 0x040000D0 RID: 208
		private Quaternion _localRotation3D;

		// Token: 0x040000D1 RID: 209
		private Vector2 _localPosition2D;

		// Token: 0x040000D2 RID: 210
		private float _localRotation2D_Degrees;
	}
}
