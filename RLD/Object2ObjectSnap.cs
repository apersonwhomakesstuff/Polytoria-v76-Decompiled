using System;
using System.Collections.Generic;
using UnityEngine;

namespace RLD
{
	// Token: 0x02000204 RID: 516
	public static class Object2ObjectSnap
	{
		// Token: 0x170007FF RID: 2047
		// (get) Token: 0x0600179C RID: 6044 RVA: 0x00019E04 File Offset: 0x00018004
		public static int MaxSourceObjects
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x17000800 RID: 2048
		// (get) Token: 0x0600179E RID: 6046 RVA: 0x00023714 File Offset: 0x00021914
		public static Object2ObjectSnap.Config DefaultConfig
		{
			get
			{
				return default(Object2ObjectSnap.Config);
			}
		}

		// Token: 0x0600179F RID: 6047 RVA: 0x0002372C File Offset: 0x0002192C
		public static Object2ObjectSnap.SnapResult Snap(List<GameObject> roots, Object2ObjectSnap.Config snapConfig)
		{
			return default(Object2ObjectSnap.SnapResult);
		}

		// Token: 0x060017A0 RID: 6048 RVA: 0x00023744 File Offset: 0x00021944
		public static Object2ObjectSnap.SnapResult Snap(GameObject root, Object2ObjectSnap.Config snapConfig)
		{
			return default(Object2ObjectSnap.SnapResult);
		}

		// Token: 0x060017A1 RID: 6049 RVA: 0x0002375C File Offset: 0x0002195C
		public static Object2ObjectSnap.SnapResult CalculateSnapResult(GameObject root, Object2ObjectSnap.Config snapConfig)
		{
			return default(Object2ObjectSnap.SnapResult);
		}

		// Token: 0x04000841 RID: 2113
		private static List<GameObject> _nearbyObjectBuffer;

		// Token: 0x04000842 RID: 2114
		private static Object2ObjectSnap.Config _defaultConfig;

		// Token: 0x020003BB RID: 955
		public enum Prefs
		{
			// Token: 0x04000FEA RID: 4074
			None,
			// Token: 0x04000FEB RID: 4075
			TryMatchArea,
			// Token: 0x04000FEC RID: 4076
			All = 1
		}

		// Token: 0x020003BC RID: 956
		public enum SnapFailReson
		{
			// Token: 0x04000FEE RID: 4078
			None,
			// Token: 0x04000FEF RID: 4079
			MaxObjectsExceeded,
			// Token: 0x04000FF0 RID: 4080
			InvalidSourceObjects,
			// Token: 0x04000FF1 RID: 4081
			NoDestinationFound
		}

		// Token: 0x020003BD RID: 957
		public struct SnapResult
		{
			// Token: 0x17000CAB RID: 3243
			// (get) Token: 0x06002B1C RID: 11036 RVA: 0x0001D452 File Offset: 0x0001B652
			public bool Success
			{
				get
				{
					return false;
				}
			}

			// Token: 0x17000CAC RID: 3244
			// (get) Token: 0x06002B1D RID: 11037 RVA: 0x000268F8 File Offset: 0x00024AF8
			public Vector3 SnapPivot
			{
				get
				{
					return default(Vector3);
				}
			}

			// Token: 0x17000CAD RID: 3245
			// (get) Token: 0x06002B1E RID: 11038 RVA: 0x00026910 File Offset: 0x00024B10
			public Vector3 SnapDestination
			{
				get
				{
					return default(Vector3);
				}
			}

			// Token: 0x17000CAE RID: 3246
			// (get) Token: 0x06002B1F RID: 11039 RVA: 0x0001D455 File Offset: 0x0001B655
			public float SnapDistance
			{
				get
				{
					return 0f;
				}
			}

			// Token: 0x17000CAF RID: 3247
			// (get) Token: 0x06002B20 RID: 11040 RVA: 0x00026928 File Offset: 0x00024B28
			public Object2ObjectSnap.SnapFailReson FailReason
			{
				get
				{
					return Object2ObjectSnap.SnapFailReson.None;
				}
			}

			// Token: 0x06002B21 RID: 11041 RVA: 0x00026940 File Offset: 0x00024B40
			public SnapResult(Object2ObjectSnap.SnapFailReson failReson)
			{
				this._success = false;
				this._snapPivot = default(Vector3);
				this._snapDestination = default(Vector3);
				this._snapDistance = 0f;
				this._failReason = Object2ObjectSnap.SnapFailReson.None;
			}

			// Token: 0x06002B22 RID: 11042 RVA: 0x0002698C File Offset: 0x00024B8C
			public SnapResult(Vector3 snapPivot, Vector3 snapDestination, float snapDistance)
			{
				this._success = false;
				this._snapPivot = default(Vector3);
				this._snapDestination = default(Vector3);
				this._snapDistance = 0f;
				this._failReason = Object2ObjectSnap.SnapFailReson.None;
			}

			// Token: 0x04000FF2 RID: 4082
			private bool _success;

			// Token: 0x04000FF3 RID: 4083
			private Vector3 _snapPivot;

			// Token: 0x04000FF4 RID: 4084
			private Vector3 _snapDestination;

			// Token: 0x04000FF5 RID: 4085
			private float _snapDistance;

			// Token: 0x04000FF6 RID: 4086
			private Object2ObjectSnap.SnapFailReson _failReason;
		}

		// Token: 0x020003BE RID: 958
		public struct Config
		{
			// Token: 0x17000CB0 RID: 3248
			// (get) Token: 0x06002B23 RID: 11043 RVA: 0x0001D45C File Offset: 0x0001B65C
			// (set) Token: 0x06002B24 RID: 11044 RVA: 0x0001D463 File Offset: 0x0001B663
			public float AreaMatchEps
			{
				get
				{
					return 0f;
				}
				set
				{
				}
			}

			// Token: 0x04000FF7 RID: 4087
			private float _areaMatchEps;

			// Token: 0x04000FF8 RID: 4088
			public List<GameObject> IgnoreDestObjects;

			// Token: 0x04000FF9 RID: 4089
			public int DestinationLayers;

			// Token: 0x04000FFA RID: 4090
			public float SnapRadius;

			// Token: 0x04000FFB RID: 4091
			public Object2ObjectSnap.Prefs Prefs;
		}

		// Token: 0x020003BF RID: 959
		private struct SnapSortData
		{
			// Token: 0x04000FFC RID: 4092
			public GameObject SrcObject;

			// Token: 0x04000FFD RID: 4093
			public GameObject DestObject;

			// Token: 0x04000FFE RID: 4094
			public BoxFace SrcSnapFace;

			// Token: 0x04000FFF RID: 4095
			public BoxFace DestSnapFace;

			// Token: 0x04001000 RID: 4096
			public bool FaceAreasMatch;

			// Token: 0x04001001 RID: 4097
			public float FaceAreaDiff;

			// Token: 0x04001002 RID: 4098
			public Vector3 SnapPivot;

			// Token: 0x04001003 RID: 4099
			public Vector3 SnapDest;

			// Token: 0x04001004 RID: 4100
			public float SnapDistance;
		}

		// Token: 0x020003C0 RID: 960
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06002B27 RID: 11047 RVA: 0x0001D46F File Offset: 0x0001B66F
			internal int <CalculateSnapResult>b__14_0(Object2ObjectSnap.SnapSortData s0, Object2ObjectSnap.SnapSortData s1)
			{
				return 0;
			}

			// Token: 0x06002B28 RID: 11048 RVA: 0x0001D472 File Offset: 0x0001B672
			internal int <CalculateSnapResult>b__14_1(Object2ObjectSnap.SnapSortData s0, Object2ObjectSnap.SnapSortData s1)
			{
				return 0;
			}

			// Token: 0x04001005 RID: 4101
			public static readonly Object2ObjectSnap.<>c <>9;

			// Token: 0x04001006 RID: 4102
			public static Comparison<Object2ObjectSnap.SnapSortData> <>9__14_0;

			// Token: 0x04001007 RID: 4103
			public static Comparison<Object2ObjectSnap.SnapSortData> <>9__14_1;
		}

		// Token: 0x020003C1 RID: 961
		private sealed class <>c__DisplayClass14_0
		{
			// Token: 0x06002B2A RID: 11050 RVA: 0x0001D47D File Offset: 0x0001B67D
			internal bool <CalculateSnapResult>b__2(GameObject item)
			{
				return false;
			}

			// Token: 0x04001008 RID: 4104
			public GameObject root;

			// Token: 0x04001009 RID: 4105
			public Object2ObjectSnap.Config snapConfig;

			// Token: 0x0400100A RID: 4106
			public Predicate<GameObject> <>9__2;
		}
	}
}
