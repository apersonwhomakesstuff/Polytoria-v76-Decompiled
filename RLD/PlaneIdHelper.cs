namespace RLD;

public static class PlaneIdHelper
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass10_0
	{
		public PlaneQuadrantId planeQuadrant; //Field offset: 0x10

		public <>c__DisplayClass10_0() { }

		internal bool <GetSecondAxisSign>b__0(PlaneQuadrantInfo item) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass11_0
	{
		public AxisSign firstAxisSign; //Field offset: 0x10
		public AxisSign secondAxisSign; //Field offset: 0x14

		public <>c__DisplayClass11_0() { }

		internal bool <GetQuadrantFromAxesSigns>b__0(PlaneQuadrantInfo item) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass9_0
	{
		public PlaneQuadrantId planeQuadrant; //Field offset: 0x10

		public <>c__DisplayClass9_0() { }

		internal bool <GetFirstAxisSign>b__0(PlaneQuadrantInfo item) { }

	}

	private struct PlaneInfo
	{
		public PlaneId PlaneId; //Field offset: 0x0
		public List<PlaneQuadrantInfo> QuadrantInfo; //Field offset: 0x8

	}

	private struct PlaneQuadrantInfo
	{
		public PlaneQuadrantId Quadrant; //Field offset: 0x0
		public AxisSign FirstAxisSign; //Field offset: 0x4
		public AxisSign SecondAxisSign; //Field offset: 0x8

	}

	private static List<PlaneInfo> _planeInfo; //Field offset: 0x0
	private static PlaneId[] _allPlaneIds; //Field offset: 0x8

	public static PlaneId[] AllPlaneIds
	{
		 get { } //Length: 122
	}

	private static PlaneIdHelper() { }

	public static PlaneId[] get_AllPlaneIds() { }

	public static AxisDescriptor GetFirstAxisDescriptor(PlaneId planeId, PlaneQuadrantId planeQuadrant) { }

	public static AxisSign GetFirstAxisSign(PlaneId planeId, PlaneQuadrantId planeQuadrant) { }

	public static PlaneQuadrantId GetQuadrantFromAxesSigns(PlaneId planeId, AxisSign firstAxisSign, AxisSign secondAxisSign) { }

	public static AxisDescriptor GetSecondAxisDescriptor(PlaneId planeId, PlaneQuadrantId planeQuadrant) { }

	public static AxisSign GetSecondAxisSign(PlaneId planeId, PlaneQuadrantId planeQuadrant) { }

	public static PlaneId NormalAxisIndexToPlaneId(int axisIndex) { }

	public static int PlaneIdToFirstAxisIndex(PlaneId planeId) { }

	public static int PlaneIdToSecondAxisIndex(PlaneId planeId) { }

}

