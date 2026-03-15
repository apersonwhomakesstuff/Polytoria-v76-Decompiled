namespace RLD;

public static class Object2ObjectSnap
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Comparison<SnapSortData> <>9__14_0; //Field offset: 0x8
		public static Comparison<SnapSortData> <>9__14_1; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal int <CalculateSnapResult>b__14_0(SnapSortData s0, SnapSortData s1) { }

		internal int <CalculateSnapResult>b__14_1(SnapSortData s0, SnapSortData s1) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass14_0
	{
		public GameObject root; //Field offset: 0x10
		public Config snapConfig; //Field offset: 0x18
		public Predicate<GameObject> <>9__2; //Field offset: 0x38

		public <>c__DisplayClass14_0() { }

		internal bool <CalculateSnapResult>b__2(GameObject item) { }

	}

	internal struct Config
	{
		private float _areaMatchEps; //Field offset: 0x0
		public List<GameObject> IgnoreDestObjects; //Field offset: 0x8
		public int DestinationLayers; //Field offset: 0x10
		public float SnapRadius; //Field offset: 0x14
		public Prefs Prefs; //Field offset: 0x18

		public float AreaMatchEps
		{
			 get { } //Length: 5
			 set { } //Length: 12
		}

		public float get_AreaMatchEps() { }

		public void set_AreaMatchEps(float value) { }

	}

	[Flags]
	internal enum Prefs : int
	{
		None = 0,
		TryMatchArea = 1,
		All = 1,
	}

	internal enum SnapFailReson : int
	{
		None = 0,
		MaxObjectsExceeded = 1,
		InvalidSourceObjects = 2,
		NoDestinationFound = 3,
	}

	internal struct SnapResult
	{
		private bool _success; //Field offset: 0x0
		private Vector3 _snapPivot; //Field offset: 0x4
		private Vector3 _snapDestination; //Field offset: 0x10
		private float _snapDistance; //Field offset: 0x1C
		private SnapFailReson _failReason; //Field offset: 0x20

		public SnapFailReson FailReason
		{
			 get { } //Length: 4
		}

		public Vector3 SnapDestination
		{
			 get { } //Length: 19
		}

		public float SnapDistance
		{
			 get { } //Length: 6
		}

		public Vector3 SnapPivot
		{
			 get { } //Length: 19
		}

		public bool Success
		{
			 get { } //Length: 4
		}

		public SnapResult(SnapFailReson failReson) { }

		public SnapResult(Vector3 snapPivot, Vector3 snapDestination, float snapDistance) { }

		public SnapFailReson get_FailReason() { }

		public Vector3 get_SnapDestination() { }

		public float get_SnapDistance() { }

		public Vector3 get_SnapPivot() { }

		public bool get_Success() { }

	}

	private struct SnapSortData
	{
		public GameObject SrcObject; //Field offset: 0x0
		public GameObject DestObject; //Field offset: 0x8
		public BoxFace SrcSnapFace; //Field offset: 0x10
		public BoxFace DestSnapFace; //Field offset: 0x14
		public bool FaceAreasMatch; //Field offset: 0x18
		public float FaceAreaDiff; //Field offset: 0x1C
		public Vector3 SnapPivot; //Field offset: 0x20
		public Vector3 SnapDest; //Field offset: 0x2C
		public float SnapDistance; //Field offset: 0x38

	}

	private static List<GameObject> _nearbyObjectBuffer; //Field offset: 0x0
	private static Config _defaultConfig; //Field offset: 0x8

	public static Config DefaultConfig
	{
		 get { } //Length: 99
	}

	public static int MaxSourceObjects
	{
		 get { } //Length: 6
	}

	private static Object2ObjectSnap() { }

	public static SnapResult CalculateSnapResult(GameObject root, Config snapConfig) { }

	public static Config get_DefaultConfig() { }

	public static int get_MaxSourceObjects() { }

	public static SnapResult Snap(List<GameObject> roots, Config snapConfig) { }

	public static SnapResult Snap(GameObject root, Config snapConfig) { }

}

