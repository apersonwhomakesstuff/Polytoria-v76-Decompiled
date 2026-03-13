using System;
using UnityEngine;

namespace RLD
{
	// Token: 0x020000D4 RID: 212
	public class GizmoRotationArc3D
	{
		// Token: 0x170002D1 RID: 721
		// (get) Token: 0x060008DC RID: 2268 RVA: 0x0001753C File Offset: 0x0001573C
		// (set) Token: 0x060008DD RID: 2269 RVA: 0x00017543 File Offset: 0x00015743
		public float RotationAngle
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x170002D2 RID: 722
		// (get) Token: 0x060008DE RID: 2270 RVA: 0x00017545 File Offset: 0x00015745
		// (set) Token: 0x060008DF RID: 2271 RVA: 0x0001754C File Offset: 0x0001574C
		public float Radius
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x060008E0 RID: 2272 RVA: 0x0001754E File Offset: 0x0001574E
		public void SetArcData(Vector3 rotationAxis, Vector3 arcOrigin, Vector3 arcStart, float radius)
		{
		}

		// Token: 0x060008E1 RID: 2273 RVA: 0x00017550 File Offset: 0x00015750
		public void Render(GizmoRotationArc3DLookAndFeel lookAndFeel)
		{
		}

		// Token: 0x040003A3 RID: 931
		private ArcShape3D _arc;
	}
}
