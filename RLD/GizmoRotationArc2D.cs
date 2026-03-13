using System;
using UnityEngine;

namespace RLD
{
	// Token: 0x020000D2 RID: 210
	public class GizmoRotationArc2D
	{
		// Token: 0x170002C9 RID: 713
		// (get) Token: 0x060008C8 RID: 2248 RVA: 0x00017508 File Offset: 0x00015708
		// (set) Token: 0x060008C9 RID: 2249 RVA: 0x0001750F File Offset: 0x0001570F
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

		// Token: 0x170002CA RID: 714
		// (get) Token: 0x060008CA RID: 2250 RVA: 0x0001F47C File Offset: 0x0001D67C
		// (set) Token: 0x060008CB RID: 2251 RVA: 0x00017511 File Offset: 0x00015711
		public GizmoRotationArc2D.ArcType Type
		{
			get
			{
				return GizmoRotationArc2D.ArcType.Standard;
			}
			set
			{
			}
		}

		// Token: 0x170002CB RID: 715
		// (get) Token: 0x060008CC RID: 2252 RVA: 0x00017513 File Offset: 0x00015713
		// (set) Token: 0x060008CD RID: 2253 RVA: 0x00017516 File Offset: 0x00015716
		public PolygonShape2D ProjectionPoly
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x170002CC RID: 716
		// (get) Token: 0x060008CE RID: 2254 RVA: 0x00017518 File Offset: 0x00015718
		// (set) Token: 0x060008CF RID: 2255 RVA: 0x0001751B File Offset: 0x0001571B
		public int NumProjectedPoints
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x060008D0 RID: 2256 RVA: 0x0001751D File Offset: 0x0001571D
		public void SetArcData(Vector2 arcOrigin, Vector2 arcStart, float radius)
		{
		}

		// Token: 0x060008D1 RID: 2257 RVA: 0x0001751F File Offset: 0x0001571F
		public void Render(GizmoRotationArc2DLookAndFeel lookAndFeel, Camera camera)
		{
		}

		// Token: 0x0400039B RID: 923
		private ArcShape2D _arc;

		// Token: 0x0400039C RID: 924
		private GizmoRotationArc2D.ArcType _type;

		// Token: 0x0400039D RID: 925
		private PolygonShape2D _projectionPoly;

		// Token: 0x0400039E RID: 926
		private int _numProjectedPoints;

		// Token: 0x0200036E RID: 878
		public enum ArcType
		{
			// Token: 0x04000EEB RID: 3819
			Standard,
			// Token: 0x04000EEC RID: 3820
			PolyProjected
		}
	}
}
