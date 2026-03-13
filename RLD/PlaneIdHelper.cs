using System;
using System.Collections.Generic;

namespace RLD
{
	// Token: 0x02000147 RID: 327
	public static class PlaneIdHelper
	{
		// Token: 0x17000578 RID: 1400
		// (get) Token: 0x0600109E RID: 4254 RVA: 0x00018AA0 File Offset: 0x00016CA0
		public static PlaneId[] AllPlaneIds
		{
			get
			{
				return null;
			}
		}

		// Token: 0x0600109F RID: 4255 RVA: 0x00018AA3 File Offset: 0x00016CA3
		public static AxisDescriptor GetFirstAxisDescriptor(PlaneId planeId, PlaneQuadrantId planeQuadrant)
		{
			return null;
		}

		// Token: 0x060010A0 RID: 4256 RVA: 0x00018AA6 File Offset: 0x00016CA6
		public static AxisDescriptor GetSecondAxisDescriptor(PlaneId planeId, PlaneQuadrantId planeQuadrant)
		{
			return null;
		}

		// Token: 0x060010A1 RID: 4257 RVA: 0x0002149C File Offset: 0x0001F69C
		public static AxisSign GetFirstAxisSign(PlaneId planeId, PlaneQuadrantId planeQuadrant)
		{
			return AxisSign.Positive;
		}

		// Token: 0x060010A2 RID: 4258 RVA: 0x000214B4 File Offset: 0x0001F6B4
		public static AxisSign GetSecondAxisSign(PlaneId planeId, PlaneQuadrantId planeQuadrant)
		{
			return AxisSign.Positive;
		}

		// Token: 0x060010A3 RID: 4259 RVA: 0x000214CC File Offset: 0x0001F6CC
		public static PlaneQuadrantId GetQuadrantFromAxesSigns(PlaneId planeId, AxisSign firstAxisSign, AxisSign secondAxisSign)
		{
			return PlaneQuadrantId.First;
		}

		// Token: 0x060010A4 RID: 4260 RVA: 0x00018AA9 File Offset: 0x00016CA9
		public static int PlaneIdToFirstAxisIndex(PlaneId planeId)
		{
			return 0;
		}

		// Token: 0x060010A5 RID: 4261 RVA: 0x00018AAC File Offset: 0x00016CAC
		public static int PlaneIdToSecondAxisIndex(PlaneId planeId)
		{
			return 0;
		}

		// Token: 0x060010A6 RID: 4262 RVA: 0x000214E4 File Offset: 0x0001F6E4
		public static PlaneId NormalAxisIndexToPlaneId(int axisIndex)
		{
			return PlaneId.XY;
		}

		// Token: 0x040005AC RID: 1452
		private static List<PlaneIdHelper.PlaneInfo> _planeInfo;

		// Token: 0x040005AD RID: 1453
		private static PlaneId[] _allPlaneIds;

		// Token: 0x02000388 RID: 904
		private struct PlaneQuadrantInfo
		{
			// Token: 0x04000F5D RID: 3933
			public PlaneQuadrantId Quadrant;

			// Token: 0x04000F5E RID: 3934
			public AxisSign FirstAxisSign;

			// Token: 0x04000F5F RID: 3935
			public AxisSign SecondAxisSign;
		}

		// Token: 0x02000389 RID: 905
		private struct PlaneInfo
		{
			// Token: 0x04000F60 RID: 3936
			public PlaneId PlaneId;

			// Token: 0x04000F61 RID: 3937
			public List<PlaneIdHelper.PlaneQuadrantInfo> QuadrantInfo;
		}

		// Token: 0x0200038A RID: 906
		private sealed class <>c__DisplayClass10_0
		{
			// Token: 0x06002AAC RID: 10924 RVA: 0x0001D2E4 File Offset: 0x0001B4E4
			internal bool <GetSecondAxisSign>b__0(PlaneIdHelper.PlaneQuadrantInfo item)
			{
				return false;
			}

			// Token: 0x04000F62 RID: 3938
			public PlaneQuadrantId planeQuadrant;
		}

		// Token: 0x0200038B RID: 907
		private sealed class <>c__DisplayClass11_0
		{
			// Token: 0x06002AAE RID: 10926 RVA: 0x0001D2EF File Offset: 0x0001B4EF
			internal bool <GetQuadrantFromAxesSigns>b__0(PlaneIdHelper.PlaneQuadrantInfo item)
			{
				return false;
			}

			// Token: 0x04000F63 RID: 3939
			public AxisSign firstAxisSign;

			// Token: 0x04000F64 RID: 3940
			public AxisSign secondAxisSign;
		}

		// Token: 0x0200038C RID: 908
		private sealed class <>c__DisplayClass9_0
		{
			// Token: 0x06002AB0 RID: 10928 RVA: 0x0001D2FA File Offset: 0x0001B4FA
			internal bool <GetFirstAxisSign>b__0(PlaneIdHelper.PlaneQuadrantInfo item)
			{
				return false;
			}

			// Token: 0x04000F65 RID: 3941
			public PlaneQuadrantId planeQuadrant;
		}
	}
}
