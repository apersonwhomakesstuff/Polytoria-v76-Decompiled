using System;
using System.Collections.Generic;
using UnityEngine;

namespace RLD
{
	// Token: 0x020001CC RID: 460
	public class DeviceObjectGrabSession
	{
		// Token: 0x14000031 RID: 49
		// (add) Token: 0x060013FD RID: 5117 RVA: 0x00019540 File Offset: 0x00017740
		// (remove) Token: 0x060013FE RID: 5118 RVA: 0x00019542 File Offset: 0x00017742
		public event ObjectGrabSessionBeginHandler SessionBegin
		{
			add
			{
			}
			remove
			{
			}
		}

		// Token: 0x14000032 RID: 50
		// (add) Token: 0x060013FF RID: 5119 RVA: 0x00019544 File Offset: 0x00017744
		// (remove) Token: 0x06001400 RID: 5120 RVA: 0x00019546 File Offset: 0x00017746
		public event ObjectGrabSessionEndHandler SessionEnd
		{
			add
			{
			}
			remove
			{
			}
		}

		// Token: 0x17000684 RID: 1668
		// (get) Token: 0x06001401 RID: 5121 RVA: 0x00019548 File Offset: 0x00017748
		// (set) Token: 0x06001402 RID: 5122 RVA: 0x0001954B File Offset: 0x0001774B
		public ObjectGrabSettings SharedSettings
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x17000685 RID: 1669
		// (get) Token: 0x06001403 RID: 5123 RVA: 0x0001954D File Offset: 0x0001774D
		// (set) Token: 0x06001404 RID: 5124 RVA: 0x00019550 File Offset: 0x00017750
		public ObjectGrabHotkeys SharedHotkeys
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x17000686 RID: 1670
		// (get) Token: 0x06001405 RID: 5125 RVA: 0x00019552 File Offset: 0x00017752
		// (set) Token: 0x06001406 RID: 5126 RVA: 0x00019555 File Offset: 0x00017755
		public ObjectGrabLookAndFeel SharedLookAndFeel
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x17000687 RID: 1671
		// (get) Token: 0x06001407 RID: 5127 RVA: 0x00019557 File Offset: 0x00017757
		public bool IsActive
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06001408 RID: 5128 RVA: 0x0001955A File Offset: 0x0001775A
		public void Render(Camera renderCamera)
		{
		}

		// Token: 0x06001409 RID: 5129 RVA: 0x0001955C File Offset: 0x0001775C
		public void Update(IEnumerable<GameObject> targetObjects)
		{
		}

		// Token: 0x0600140A RID: 5130 RVA: 0x0001955E File Offset: 0x0001775E
		public void End()
		{
		}

		// Token: 0x0600140B RID: 5131 RVA: 0x00019560 File Offset: 0x00017760
		private bool Begin(IEnumerable<GameObject> targetObjects)
		{
			return false;
		}

		// Token: 0x0600140C RID: 5132 RVA: 0x00019563 File Offset: 0x00017763
		private void SnapTargetsToSurface()
		{
		}

		// Token: 0x0600140D RID: 5133 RVA: 0x00019565 File Offset: 0x00017765
		private void RotateTargets()
		{
		}

		// Token: 0x0600140E RID: 5134 RVA: 0x00019567 File Offset: 0x00017767
		private void RotateTargetsAroundAnchor()
		{
		}

		// Token: 0x0600140F RID: 5135 RVA: 0x00019569 File Offset: 0x00017769
		private void ScaleTargets()
		{
		}

		// Token: 0x06001410 RID: 5136 RVA: 0x0001956B File Offset: 0x0001776B
		private void OffsetTargetsFromSurface()
		{
		}

		// Token: 0x06001411 RID: 5137 RVA: 0x0001956D File Offset: 0x0001776D
		private void OffsetTargetsFromAnchor()
		{
		}

		// Token: 0x06001412 RID: 5138 RVA: 0x0001956F File Offset: 0x0001776F
		private bool IdentifyGrabTargets(IEnumerable<GameObject> targetObjects)
		{
			return false;
		}

		// Token: 0x06001413 RID: 5139 RVA: 0x00019572 File Offset: 0x00017772
		private void CalculateGrabTargetsAnchorVectors()
		{
		}

		// Token: 0x06001414 RID: 5140 RVA: 0x00019574 File Offset: 0x00017774
		private void StoreGrabTargetsWorldScaleSnapshots()
		{
		}

		// Token: 0x06001415 RID: 5141 RVA: 0x00019576 File Offset: 0x00017776
		private void StoreGrabTargetsAnchorVectorSnapshots()
		{
		}

		// Token: 0x06001416 RID: 5142 RVA: 0x00019578 File Offset: 0x00017778
		private bool IdentifyGrabSurface()
		{
			return false;
		}

		// Token: 0x06001417 RID: 5143 RVA: 0x0001957B File Offset: 0x0001777B
		private void SwitchToNextAlignmentAxis()
		{
		}

		// Token: 0x06001418 RID: 5144 RVA: 0x00021D7C File Offset: 0x0001FF7C
		private ObjectBounds.QueryConfig GetObjectBoundsQConfig()
		{
			return default(ObjectBounds.QueryConfig);
		}

		// Token: 0x04000745 RID: 1861
		private DeviceObjectGrabSession.State _state;

		// Token: 0x04000746 RID: 1862
		private ObjectGrabSettings _sharedSettings;

		// Token: 0x04000747 RID: 1863
		private ObjectGrabHotkeys _sharedHotkeys;

		// Token: 0x04000748 RID: 1864
		private ObjectGrabLookAndFeel _sharedLookAndFeel;

		// Token: 0x04000749 RID: 1865
		private List<GameObject> _targetParents;

		// Token: 0x0400074A RID: 1866
		private List<DeviceObjectGrabSession.GrabTarget> _grabTargets;

		// Token: 0x0400074B RID: 1867
		private DeviceObjectGrabSession.GrabSurfaceInfo _grabSurfaceInfo;

		// Token: 0x0400074C RID: 1868
		private int _deltaCaptureId;

		// Token: 0x0400074D RID: 1869
		private TransformAxis[] _possibleAlignmentAxes;

		// Token: 0x0400074E RID: 1870
		private List<LocalTransformSnapshot> _preTargetTransformSnapshots;

		// Token: 0x020003A5 RID: 933
		private enum State
		{
			// Token: 0x04000F93 RID: 3987
			Inactive,
			// Token: 0x04000F94 RID: 3988
			ActiveSnapToSurface,
			// Token: 0x04000F95 RID: 3989
			ActiveRotate,
			// Token: 0x04000F96 RID: 3990
			ActiveRotateAroundAnchor,
			// Token: 0x04000F97 RID: 3991
			ActiveScale,
			// Token: 0x04000F98 RID: 3992
			ActiveOffsetFromSurface,
			// Token: 0x04000F99 RID: 3993
			ActiveAnchorAdjust,
			// Token: 0x04000F9A RID: 3994
			ActiveOffsetFromAnchor
		}

		// Token: 0x020003A6 RID: 934
		public enum GrabSurfaceType
		{
			// Token: 0x04000F9C RID: 3996
			Invalid,
			// Token: 0x04000F9D RID: 3997
			Mesh,
			// Token: 0x04000F9E RID: 3998
			SphericalMesh,
			// Token: 0x04000F9F RID: 3999
			UnityTerrain,
			// Token: 0x04000FA0 RID: 4000
			TerrainMesh,
			// Token: 0x04000FA1 RID: 4001
			Grid
		}

		// Token: 0x020003A7 RID: 935
		private struct GrabSurfaceInfo
		{
			// Token: 0x04000FA2 RID: 4002
			public DeviceObjectGrabSession.GrabSurfaceType SurfaceType;

			// Token: 0x04000FA3 RID: 4003
			public Vector3 AnchorPoint;

			// Token: 0x04000FA4 RID: 4004
			public Vector3 AnchorNormal;

			// Token: 0x04000FA5 RID: 4005
			public Plane AnchorPlane;

			// Token: 0x04000FA6 RID: 4006
			public SceneRaycastHit SceneRaycastHit;
		}

		// Token: 0x020003A8 RID: 936
		private class GrabTarget
		{
			// Token: 0x17000C96 RID: 3222
			// (get) Token: 0x06002AEA RID: 10986 RVA: 0x0001D3AF File Offset: 0x0001B5AF
			public GameObject GameObject
			{
				get
				{
					return null;
				}
			}

			// Token: 0x17000C97 RID: 3223
			// (get) Token: 0x06002AEB RID: 10987 RVA: 0x0001D3B2 File Offset: 0x0001B5B2
			public Transform Transform
			{
				get
				{
					return null;
				}
			}

			// Token: 0x06002AEC RID: 10988 RVA: 0x0001D3B5 File Offset: 0x0001B5B5
			public GrabTarget(GameObject parentObject)
			{
			}

			// Token: 0x04000FA7 RID: 4007
			private GameObject _gameObject;

			// Token: 0x04000FA8 RID: 4008
			private Transform _transform;

			// Token: 0x04000FA9 RID: 4009
			public Vector3 AnchorVector;

			// Token: 0x04000FAA RID: 4010
			public Vector3 WorldScaleSnapshot;

			// Token: 0x04000FAB RID: 4011
			public Vector3 AnchorVectorSnapshot;

			// Token: 0x04000FAC RID: 4012
			public Plane SittingPlane;

			// Token: 0x04000FAD RID: 4013
			public Vector3 SittingPoint;

			// Token: 0x04000FAE RID: 4014
			public float OffsetFromSurface;
		}
	}
}
