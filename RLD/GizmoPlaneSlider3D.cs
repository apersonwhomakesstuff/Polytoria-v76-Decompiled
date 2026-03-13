using System;
using UnityEngine;

namespace RLD
{
	// Token: 0x020000A5 RID: 165
	public class GizmoPlaneSlider3D : GizmoSlider
	{
		// Token: 0x17000270 RID: 624
		// (get) Token: 0x06000777 RID: 1911 RVA: 0x000170F3 File Offset: 0x000152F3
		public GizmoPlaneSlider3DSettings Settings
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000271 RID: 625
		// (get) Token: 0x06000778 RID: 1912 RVA: 0x000170F6 File Offset: 0x000152F6
		// (set) Token: 0x06000779 RID: 1913 RVA: 0x000170F9 File Offset: 0x000152F9
		public GizmoPlaneSlider3DSettings SharedSettings
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x17000272 RID: 626
		// (get) Token: 0x0600077A RID: 1914 RVA: 0x000170FB File Offset: 0x000152FB
		public GizmoPlaneSlider3DLookAndFeel LookAndFeel
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000273 RID: 627
		// (get) Token: 0x0600077B RID: 1915 RVA: 0x000170FE File Offset: 0x000152FE
		// (set) Token: 0x0600077C RID: 1916 RVA: 0x00017101 File Offset: 0x00015301
		public GizmoPlaneSlider3DLookAndFeel SharedLookAndFeel
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x17000274 RID: 628
		// (get) Token: 0x0600077D RID: 1917 RVA: 0x0001F20C File Offset: 0x0001D40C
		public Plane Plane
		{
			get
			{
				return default(Plane);
			}
		}

		// Token: 0x17000275 RID: 629
		// (get) Token: 0x0600077E RID: 1918 RVA: 0x0001F224 File Offset: 0x0001D424
		// (set) Token: 0x0600077F RID: 1919 RVA: 0x00017103 File Offset: 0x00015303
		public Vector3 Position
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		// Token: 0x17000276 RID: 630
		// (get) Token: 0x06000780 RID: 1920 RVA: 0x0001F23C File Offset: 0x0001D43C
		// (set) Token: 0x06000781 RID: 1921 RVA: 0x00017105 File Offset: 0x00015305
		public Quaternion Rotation
		{
			get
			{
				return default(Quaternion);
			}
			set
			{
			}
		}

		// Token: 0x17000277 RID: 631
		// (get) Token: 0x06000782 RID: 1922 RVA: 0x0001F254 File Offset: 0x0001D454
		// (set) Token: 0x06000783 RID: 1923 RVA: 0x00017107 File Offset: 0x00015307
		public Quaternion LocalRotation
		{
			get
			{
				return default(Quaternion);
			}
			set
			{
			}
		}

		// Token: 0x17000278 RID: 632
		// (get) Token: 0x06000784 RID: 1924 RVA: 0x0001F26C File Offset: 0x0001D46C
		public Vector3 Right
		{
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x17000279 RID: 633
		// (get) Token: 0x06000785 RID: 1925 RVA: 0x0001F284 File Offset: 0x0001D484
		public Vector3 Up
		{
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x1700027A RID: 634
		// (get) Token: 0x06000786 RID: 1926 RVA: 0x0001F29C File Offset: 0x0001D49C
		public Vector3 Look
		{
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x1700027B RID: 635
		// (get) Token: 0x06000787 RID: 1927 RVA: 0x0001F2B4 File Offset: 0x0001D4B4
		public Vector3 Normal
		{
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x1700027C RID: 636
		// (get) Token: 0x06000788 RID: 1928 RVA: 0x0001F2CC File Offset: 0x0001D4CC
		public GizmoDragChannel DragChannel
		{
			get
			{
				return GizmoDragChannel.None;
			}
		}

		// Token: 0x1700027D RID: 637
		// (get) Token: 0x06000789 RID: 1929 RVA: 0x00017109 File Offset: 0x00015309
		// (set) Token: 0x0600078A RID: 1930 RVA: 0x0001710C File Offset: 0x0001530C
		public int ScaleDragAxisIndexRight
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x1700027E RID: 638
		// (get) Token: 0x0600078B RID: 1931 RVA: 0x0001710E File Offset: 0x0001530E
		// (set) Token: 0x0600078C RID: 1932 RVA: 0x00017111 File Offset: 0x00015311
		public int ScaleDragAxisIndexUp
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x1700027F RID: 639
		// (get) Token: 0x0600078D RID: 1933 RVA: 0x0001F2E4 File Offset: 0x0001D4E4
		public Vector3 TotalDragOffset
		{
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x17000280 RID: 640
		// (get) Token: 0x0600078E RID: 1934 RVA: 0x0001F2FC File Offset: 0x0001D4FC
		public Vector3 RelativeDragOffset
		{
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x17000281 RID: 641
		// (get) Token: 0x0600078F RID: 1935 RVA: 0x00017113 File Offset: 0x00015313
		public float TotalDragRotation
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000282 RID: 642
		// (get) Token: 0x06000790 RID: 1936 RVA: 0x0001711A File Offset: 0x0001531A
		public float RelativeDragRotation
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000283 RID: 643
		// (get) Token: 0x06000791 RID: 1937 RVA: 0x00017121 File Offset: 0x00015321
		public float TotalDragScaleRight
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000284 RID: 644
		// (get) Token: 0x06000792 RID: 1938 RVA: 0x00017128 File Offset: 0x00015328
		public float RelativeDragScaleRight
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000285 RID: 645
		// (get) Token: 0x06000793 RID: 1939 RVA: 0x0001712F File Offset: 0x0001532F
		public float TotalDragScaleUp
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000286 RID: 646
		// (get) Token: 0x06000794 RID: 1940 RVA: 0x00017136 File Offset: 0x00015336
		public float RelativeDragScaleUp
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000287 RID: 647
		// (get) Token: 0x06000795 RID: 1941 RVA: 0x0001713D File Offset: 0x0001533D
		public bool IsBorderVisible
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000288 RID: 648
		// (get) Token: 0x06000796 RID: 1942 RVA: 0x00017140 File Offset: 0x00015340
		public bool IsBorderHoverable
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000289 RID: 649
		// (get) Token: 0x06000797 RID: 1943 RVA: 0x00017143 File Offset: 0x00015343
		public bool IsDragged
		{
			get
			{
				return false;
			}
		}

		// Token: 0x1700028A RID: 650
		// (get) Token: 0x06000798 RID: 1944 RVA: 0x00017146 File Offset: 0x00015346
		public bool IsMoving
		{
			get
			{
				return false;
			}
		}

		// Token: 0x1700028B RID: 651
		// (get) Token: 0x06000799 RID: 1945 RVA: 0x00017149 File Offset: 0x00015349
		public bool IsRotating
		{
			get
			{
				return false;
			}
		}

		// Token: 0x1700028C RID: 652
		// (get) Token: 0x0600079A RID: 1946 RVA: 0x0001714C File Offset: 0x0001534C
		public bool IsScaling
		{
			get
			{
				return false;
			}
		}

		// Token: 0x0600079B RID: 1947 RVA: 0x0001714F File Offset: 0x0001534F
		public GizmoPlaneSlider3D(Gizmo gizmo, int handleId) : base(null, 0)
		{
		}

		// Token: 0x0600079C RID: 1948 RVA: 0x00017159 File Offset: 0x00015359
		public void SetBorderVisible(bool isVisible)
		{
		}

		// Token: 0x0600079D RID: 1949 RVA: 0x0001715B File Offset: 0x0001535B
		public void SetBorderHoverable(bool isHoverable)
		{
		}

		// Token: 0x0600079E RID: 1950 RVA: 0x0001715D File Offset: 0x0001535D
		public override void SetSnapEnabled(bool isEnabled)
		{
		}

		// Token: 0x0600079F RID: 1951 RVA: 0x0001715F File Offset: 0x0001535F
		public void SetZoomFactorTransform(GizmoTransform transform)
		{
		}

		// Token: 0x060007A0 RID: 1952 RVA: 0x00017161 File Offset: 0x00015361
		public float GetZoomFactor(Camera camera)
		{
			return 0f;
		}

		// Token: 0x060007A1 RID: 1953 RVA: 0x00017168 File Offset: 0x00015368
		public float GetRealQuadWidth(float zoomFactor)
		{
			return 0f;
		}

		// Token: 0x060007A2 RID: 1954 RVA: 0x0001716F File Offset: 0x0001536F
		public float GetRealQuadHeight(float zoomFactor)
		{
			return 0f;
		}

		// Token: 0x060007A3 RID: 1955 RVA: 0x0001F314 File Offset: 0x0001D514
		public Vector2 GetRealQuadSize(float zoomFactor)
		{
			return default(Vector2);
		}

		// Token: 0x060007A4 RID: 1956 RVA: 0x00017176 File Offset: 0x00015376
		public float GetRealCircleRadius(float zoomFactor)
		{
			return 0f;
		}

		// Token: 0x060007A5 RID: 1957 RVA: 0x0001717D File Offset: 0x0001537D
		public float GetRealRATriXLength(float zoomFactor)
		{
			return 0f;
		}

		// Token: 0x060007A6 RID: 1958 RVA: 0x00017184 File Offset: 0x00015384
		public float GetRealRATriYLength(float zoomFactor)
		{
			return 0f;
		}

		// Token: 0x060007A7 RID: 1959 RVA: 0x0001F32C File Offset: 0x0001D52C
		public Vector2 GetRealRATriSize(float zoomFactor)
		{
			return default(Vector2);
		}

		// Token: 0x060007A8 RID: 1960 RVA: 0x0001718B File Offset: 0x0001538B
		public void AlignToQuadrant(GizmoTransform transform, PlaneId planeId, PlaneQuadrantId quadrantId, bool alignXToFirstAxis)
		{
		}

		// Token: 0x060007A9 RID: 1961 RVA: 0x0001718D File Offset: 0x0001538D
		public void MakeSliderPlane(GizmoTransform sliderPlaneTransform, PlaneId planeId, GizmoLineSlider3D firstAxisSlider, GizmoLineSlider3D secondAxisSlider, Camera camera)
		{
		}

		// Token: 0x060007AA RID: 1962 RVA: 0x0001F344 File Offset: 0x0001D544
		public Vector3 GetQuadCornerPosition(QuadCorner corner)
		{
			return default(Vector3);
		}

		// Token: 0x060007AB RID: 1963 RVA: 0x0001718F File Offset: 0x0001538F
		public void SetQuadCornerPosition(QuadCorner corner, Vector3 cornerPosition)
		{
		}

		// Token: 0x060007AC RID: 1964 RVA: 0x00017191 File Offset: 0x00015391
		public void ApplyZoomFactor(Camera camera)
		{
		}

		// Token: 0x060007AD RID: 1965 RVA: 0x00017193 File Offset: 0x00015393
		public void SetDragChannel(GizmoDragChannel dragChannel)
		{
		}

		// Token: 0x060007AE RID: 1966 RVA: 0x00017195 File Offset: 0x00015395
		public void AddTargetTransform(GizmoTransform transform)
		{
		}

		// Token: 0x060007AF RID: 1967 RVA: 0x00017197 File Offset: 0x00015397
		public void AddTargetTransform(GizmoTransform transform, GizmoDragChannel dragChannel)
		{
		}

		// Token: 0x060007B0 RID: 1968 RVA: 0x00017199 File Offset: 0x00015399
		public void RemoveTargetTransform(GizmoTransform transform)
		{
		}

		// Token: 0x060007B1 RID: 1969 RVA: 0x0001719B File Offset: 0x0001539B
		public void RemoveTargetTransform(GizmoTransform transform, GizmoDragChannel dragChannel)
		{
		}

		// Token: 0x060007B2 RID: 1970 RVA: 0x0001719D File Offset: 0x0001539D
		public override void Render(Camera camera)
		{
		}

		// Token: 0x060007B3 RID: 1971 RVA: 0x0001719F File Offset: 0x0001539F
		public void Refresh()
		{
		}

		// Token: 0x060007B4 RID: 1972 RVA: 0x000171A1 File Offset: 0x000153A1
		protected override void OnVisibilityStateChanged()
		{
		}

		// Token: 0x060007B5 RID: 1973 RVA: 0x000171A3 File Offset: 0x000153A3
		protected override void OnHoverableStateChanged()
		{
		}

		// Token: 0x060007B6 RID: 1974 RVA: 0x000171A5 File Offset: 0x000153A5
		private void OnGizmoPreUpdateBegin(Gizmo gizmo)
		{
		}

		// Token: 0x060007B7 RID: 1975 RVA: 0x000171A7 File Offset: 0x000153A7
		private void OnTransformChanged(GizmoTransform transform, GizmoTransform.ChangeData changeData)
		{
		}

		// Token: 0x060007B8 RID: 1976 RVA: 0x000171A9 File Offset: 0x000153A9
		private void OnGizmoAttemptHandleDragBegin(Gizmo gizmo, int handleId)
		{
		}

		// Token: 0x060007B9 RID: 1977 RVA: 0x000171AB File Offset: 0x000153AB
		private void OnCanHoverHandle(int handleId, Gizmo gizmo, GizmoHandleHoverData hoverData, YesNoAnswer answer)
		{
		}

		// Token: 0x060007BA RID: 1978 RVA: 0x000171AD File Offset: 0x000153AD
		private void OnGizmoPostEnabled(Gizmo gizmo)
		{
		}

		// Token: 0x040002AF RID: 687
		private int _quadIndex;

		// Token: 0x040002B0 RID: 688
		private int _raTriangleIndex;

		// Token: 0x040002B1 RID: 689
		private int _circleIndex;

		// Token: 0x040002B2 RID: 690
		private QuadShape3D _quad;

		// Token: 0x040002B3 RID: 691
		private RightAngTriangle3D _raTriangle;

		// Token: 0x040002B4 RID: 692
		private CircleShape3D _circle;

		// Token: 0x040002B5 RID: 693
		private GizmoQuad3DBorder _quadBorder;

		// Token: 0x040002B6 RID: 694
		private GizmoRATriangle3DBorder _raTriangleBorder;

		// Token: 0x040002B7 RID: 695
		private GizmoCircle3DBorder _circleBorder;

		// Token: 0x040002B8 RID: 696
		private bool _isBorderHoverable;

		// Token: 0x040002B9 RID: 697
		private bool _isBorderVisible;

		// Token: 0x040002BA RID: 698
		private GizmoTransform _transform;

		// Token: 0x040002BB RID: 699
		private GizmoDragChannel _dragChannel;

		// Token: 0x040002BC RID: 700
		private IGizmoDragSession _selectedDragSession;

		// Token: 0x040002BD RID: 701
		private GizmoDblAxisOffsetDrag3D _dblAxisOffsetDrag;

		// Token: 0x040002BE RID: 702
		private GizmoSglAxisRotationDrag3D _rotationDrag;

		// Token: 0x040002BF RID: 703
		private GizmoRotationArc3D _rotationArc;

		// Token: 0x040002C0 RID: 704
		private GizmoDblAxisScaleDrag3D _scaleDrag;

		// Token: 0x040002C1 RID: 705
		private int _scaleDragAxisIndexRight;

		// Token: 0x040002C2 RID: 706
		private int _scaleDragAxisIndexUp;

		// Token: 0x040002C3 RID: 707
		private GizmoPlaneSlider3DControllerData _controllerData;

		// Token: 0x040002C4 RID: 708
		private IGizmoPlaneSlider3DController[] _controllers;

		// Token: 0x040002C5 RID: 709
		private GizmoPlaneSlider3DSettings _settings;

		// Token: 0x040002C6 RID: 710
		private GizmoPlaneSlider3DSettings _sharedSettings;

		// Token: 0x040002C7 RID: 711
		private GizmoPlaneSlider3DLookAndFeel _lookAndFeel;

		// Token: 0x040002C8 RID: 712
		private GizmoPlaneSlider3DLookAndFeel _sharedLookAndFeel;
	}
}
