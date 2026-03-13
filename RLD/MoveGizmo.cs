using System;
using System.Collections.Generic;
using UnityEngine;

namespace RLD
{
	// Token: 0x020000DA RID: 218
	[Serializable]
	public class MoveGizmo : GizmoBehaviour
	{
		// Token: 0x170002E5 RID: 741
		// (get) Token: 0x06000905 RID: 2309 RVA: 0x00017594 File Offset: 0x00015794
		public MoveGizmoSettings2D Settings2D
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170002E6 RID: 742
		// (get) Token: 0x06000906 RID: 2310 RVA: 0x00017597 File Offset: 0x00015797
		public MoveGizmoSettings3D Settings3D
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170002E7 RID: 743
		// (get) Token: 0x06000907 RID: 2311 RVA: 0x0001759A File Offset: 0x0001579A
		public MoveGizmoLookAndFeel2D LookAndFeel2D
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170002E8 RID: 744
		// (get) Token: 0x06000908 RID: 2312 RVA: 0x0001759D File Offset: 0x0001579D
		public MoveGizmoLookAndFeel3D LookAndFeel3D
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170002E9 RID: 745
		// (get) Token: 0x06000909 RID: 2313 RVA: 0x000175A0 File Offset: 0x000157A0
		public MoveGizmoHotkeys Hotkeys
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170002EA RID: 746
		// (get) Token: 0x0600090A RID: 2314 RVA: 0x000175A3 File Offset: 0x000157A3
		// (set) Token: 0x0600090B RID: 2315 RVA: 0x000175A6 File Offset: 0x000157A6
		public MoveGizmoSettings2D SharedSettings2D
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x170002EB RID: 747
		// (get) Token: 0x0600090C RID: 2316 RVA: 0x000175A8 File Offset: 0x000157A8
		// (set) Token: 0x0600090D RID: 2317 RVA: 0x000175AB File Offset: 0x000157AB
		public MoveGizmoSettings3D SharedSettings3D
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x170002EC RID: 748
		// (get) Token: 0x0600090E RID: 2318 RVA: 0x000175AD File Offset: 0x000157AD
		// (set) Token: 0x0600090F RID: 2319 RVA: 0x000175B0 File Offset: 0x000157B0
		public MoveGizmoLookAndFeel2D SharedLookAndFeel2D
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x170002ED RID: 749
		// (get) Token: 0x06000910 RID: 2320 RVA: 0x000175B2 File Offset: 0x000157B2
		// (set) Token: 0x06000911 RID: 2321 RVA: 0x000175B5 File Offset: 0x000157B5
		public MoveGizmoLookAndFeel3D SharedLookAndFeel3D
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x170002EE RID: 750
		// (get) Token: 0x06000912 RID: 2322 RVA: 0x000175B7 File Offset: 0x000157B7
		// (set) Token: 0x06000913 RID: 2323 RVA: 0x000175BA File Offset: 0x000157BA
		public MoveGizmoHotkeys SharedHotkeys
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x170002EF RID: 751
		// (get) Token: 0x06000914 RID: 2324 RVA: 0x000175BC File Offset: 0x000157BC
		// (set) Token: 0x06000915 RID: 2325 RVA: 0x000175BF File Offset: 0x000157BF
		public bool UseSnapEnableHotkey
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x170002F0 RID: 752
		// (get) Token: 0x06000916 RID: 2326 RVA: 0x000175C1 File Offset: 0x000157C1
		// (set) Token: 0x06000917 RID: 2327 RVA: 0x000175C4 File Offset: 0x000157C4
		public bool UseVertSnapEnableHotkey
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x170002F1 RID: 753
		// (get) Token: 0x06000918 RID: 2328 RVA: 0x000175C6 File Offset: 0x000157C6
		// (set) Token: 0x06000919 RID: 2329 RVA: 0x000175C9 File Offset: 0x000157C9
		public bool Use2DModeEnableHotkey
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x0600091A RID: 2330 RVA: 0x0001F524 File Offset: 0x0001D724
		public MoveGizmo.VertexSnapState GetVertexSnapState()
		{
			return MoveGizmo.VertexSnapState.SelectingPivot;
		}

		// Token: 0x0600091B RID: 2331 RVA: 0x000175CB File Offset: 0x000157CB
		public float GetZoomFactor(Vector3 position)
		{
			return 0f;
		}

		// Token: 0x0600091C RID: 2332 RVA: 0x000175D2 File Offset: 0x000157D2
		public float GetZoomFactor(Vector3 position, Camera camera)
		{
			return 0f;
		}

		// Token: 0x0600091D RID: 2333 RVA: 0x000175D9 File Offset: 0x000157D9
		public bool OwnsHandle(int handleId)
		{
			return false;
		}

		// Token: 0x0600091E RID: 2334 RVA: 0x000175DC File Offset: 0x000157DC
		public void SetAxesLinesHoverable(bool hoverable)
		{
		}

		// Token: 0x0600091F RID: 2335 RVA: 0x000175DE File Offset: 0x000157DE
		public void SetSnapEnabled(bool isEnabled)
		{
		}

		// Token: 0x06000920 RID: 2336 RVA: 0x000175E0 File Offset: 0x000157E0
		public void SetVertexSnapEnabled(bool isEnabled)
		{
		}

		// Token: 0x06000921 RID: 2337 RVA: 0x000175E2 File Offset: 0x000157E2
		public void Set2DModeEnabled(bool isEnabled)
		{
		}

		// Token: 0x06000922 RID: 2338 RVA: 0x000175E4 File Offset: 0x000157E4
		public void SetVertexSnapTargetObjects(IEnumerable<GameObject> targetObjects)
		{
		}

		// Token: 0x06000923 RID: 2339 RVA: 0x000175E6 File Offset: 0x000157E6
		public override void OnAttached()
		{
		}

		// Token: 0x06000924 RID: 2340 RVA: 0x000175E8 File Offset: 0x000157E8
		public override void OnDetached()
		{
		}

		// Token: 0x06000925 RID: 2341 RVA: 0x000175EA File Offset: 0x000157EA
		public override void OnEnabled()
		{
		}

		// Token: 0x06000926 RID: 2342 RVA: 0x000175EC File Offset: 0x000157EC
		public override void OnDisabled()
		{
		}

		// Token: 0x06000927 RID: 2343 RVA: 0x000175EE File Offset: 0x000157EE
		public override void OnGizmoEnabled()
		{
		}

		// Token: 0x06000928 RID: 2344 RVA: 0x000175F0 File Offset: 0x000157F0
		public override void OnGizmoUpdateBegin()
		{
		}

		// Token: 0x06000929 RID: 2345 RVA: 0x000175F2 File Offset: 0x000157F2
		public override void OnGizmoRender(Camera camera)
		{
		}

		// Token: 0x0600092A RID: 2346 RVA: 0x000175F4 File Offset: 0x000157F4
		public override void OnGizmoDragUpdate(int handleId)
		{
		}

		// Token: 0x0600092B RID: 2347 RVA: 0x000175F6 File Offset: 0x000157F6
		private void PlaceDblSlidersInSliderPlanes(Camera camera)
		{
		}

		// Token: 0x0600092C RID: 2348 RVA: 0x000175F8 File Offset: 0x000157F8
		private void SetupSharedLookAndFeel()
		{
		}

		// Token: 0x0600092D RID: 2349 RVA: 0x000175FA File Offset: 0x000157FA
		private void SetupSharedSettings()
		{
		}

		// Token: 0x0600092E RID: 2350 RVA: 0x000175FC File Offset: 0x000157FC
		private void Update2DGizmoPosition()
		{
		}

		// Token: 0x0600092F RID: 2351 RVA: 0x000175FE File Offset: 0x000157FE
		private void Update2DModeHandlePositions()
		{
		}

		// Token: 0x06000930 RID: 2352 RVA: 0x00017600 File Offset: 0x00015800
		private void OnGizmoTransformChanged(GizmoTransform transform, GizmoTransform.ChangeData changeData)
		{
		}

		// Token: 0x06000931 RID: 2353 RVA: 0x00017602 File Offset: 0x00015802
		private void Hide2DModeHandles()
		{
		}

		// Token: 0x040003B8 RID: 952
		private GizmoLineSlider3D _pXSlider;

		// Token: 0x040003B9 RID: 953
		private GizmoLineSlider3D _pYSlider;

		// Token: 0x040003BA RID: 954
		private GizmoLineSlider3D _pZSlider;

		// Token: 0x040003BB RID: 955
		private GizmoLineSlider3D _nXSlider;

		// Token: 0x040003BC RID: 956
		private GizmoLineSlider3D _nYSlider;

		// Token: 0x040003BD RID: 957
		private GizmoLineSlider3D _nZSlider;

		// Token: 0x040003BE RID: 958
		private GizmoLineSlider3DCollection _axesSliders;

		// Token: 0x040003BF RID: 959
		private GizmoPlaneSlider3D _xySlider;

		// Token: 0x040003C0 RID: 960
		private GizmoPlaneSlider3D _yzSlider;

		// Token: 0x040003C1 RID: 961
		private GizmoPlaneSlider3D _zxSlider;

		// Token: 0x040003C2 RID: 962
		private GizmoPlaneSlider3DCollection _dblSliders;

		// Token: 0x040003C3 RID: 963
		private GizmoCap3D _midCap;

		// Token: 0x040003C4 RID: 964
		private bool _isVertexSnapEnabled;

		// Token: 0x040003C5 RID: 965
		private GizmoCap2D _vertSnapCap;

		// Token: 0x040003C6 RID: 966
		private GizmoObjectVertexSnapDrag3D _vertexSnapDrag;

		// Token: 0x040003C7 RID: 967
		private Vector3 _postVSnapPosRestore;

		// Token: 0x040003C8 RID: 968
		private bool _is2DModeEnabled;

		// Token: 0x040003C9 RID: 969
		private GizmoLineSlider2D _p2DModeXSlider;

		// Token: 0x040003CA RID: 970
		private GizmoLineSlider2D _p2DModeYSlider;

		// Token: 0x040003CB RID: 971
		private GizmoLineSlider2D _n2DModeXSlider;

		// Token: 0x040003CC RID: 972
		private GizmoLineSlider2D _n2DModeYSlider;

		// Token: 0x040003CD RID: 973
		private GizmoLineSlider2DCollection _2DModeSliders;

		// Token: 0x040003CE RID: 974
		private GizmoPlaneSlider2D _2DModeDblSlider;

		// Token: 0x040003CF RID: 975
		private bool _useSnapEnableHotkey;

		// Token: 0x040003D0 RID: 976
		private bool _useVertSnapEnableHotkey;

		// Token: 0x040003D1 RID: 977
		private bool _use2DModeEnableHotkey;

		// Token: 0x040003D2 RID: 978
		private MoveGizmoHotkeys _hotkeys;

		// Token: 0x040003D3 RID: 979
		private MoveGizmoSettings2D _settings2D;

		// Token: 0x040003D4 RID: 980
		private MoveGizmoSettings3D _settings3D;

		// Token: 0x040003D5 RID: 981
		private MoveGizmoLookAndFeel2D _lookAndFeel2D;

		// Token: 0x040003D6 RID: 982
		private MoveGizmoLookAndFeel3D _lookAndFeel3D;

		// Token: 0x040003D7 RID: 983
		private MoveGizmoHotkeys _sharedHotkeys;

		// Token: 0x040003D8 RID: 984
		private MoveGizmoSettings2D _sharedSettings2D;

		// Token: 0x040003D9 RID: 985
		private MoveGizmoSettings3D _sharedSettings3D;

		// Token: 0x040003DA RID: 986
		private MoveGizmoLookAndFeel2D _sharedLookAndFeel2D;

		// Token: 0x040003DB RID: 987
		private MoveGizmoLookAndFeel3D _sharedLookAndFeel3D;

		// Token: 0x0200036F RID: 879
		public enum VertexSnapState
		{
			// Token: 0x04000EEE RID: 3822
			SelectingPivot,
			// Token: 0x04000EEF RID: 3823
			Snapping,
			// Token: 0x04000EF0 RID: 3824
			Inactive
		}
	}
}
