using System;
using System.Collections.Generic;
using UnityEngine;

namespace RLD
{
	// Token: 0x0200005B RID: 91
	[Serializable]
	public class Gizmo
	{
		// Token: 0x14000002 RID: 2
		// (add) Token: 0x060002F5 RID: 757 RVA: 0x000164A9 File Offset: 0x000146A9
		// (remove) Token: 0x060002F6 RID: 758 RVA: 0x000164AB File Offset: 0x000146AB
		public event GizmoPostEnabledHandler PostEnabled
		{
			add
			{
			}
			remove
			{
			}
		}

		// Token: 0x14000003 RID: 3
		// (add) Token: 0x060002F7 RID: 759 RVA: 0x000164AD File Offset: 0x000146AD
		// (remove) Token: 0x060002F8 RID: 760 RVA: 0x000164AF File Offset: 0x000146AF
		public event GizmoPostDisabledHandler PostDisabled
		{
			add
			{
			}
			remove
			{
			}
		}

		// Token: 0x14000004 RID: 4
		// (add) Token: 0x060002F9 RID: 761 RVA: 0x000164B1 File Offset: 0x000146B1
		// (remove) Token: 0x060002FA RID: 762 RVA: 0x000164B3 File Offset: 0x000146B3
		public event GizmoPreUpdateBeginHandler PreUpdateBegin
		{
			add
			{
			}
			remove
			{
			}
		}

		// Token: 0x14000005 RID: 5
		// (add) Token: 0x060002FB RID: 763 RVA: 0x000164B5 File Offset: 0x000146B5
		// (remove) Token: 0x060002FC RID: 764 RVA: 0x000164B7 File Offset: 0x000146B7
		public event GizmoPostUpdateEndHandler PostUpdateEnd
		{
			add
			{
			}
			remove
			{
			}
		}

		// Token: 0x14000006 RID: 6
		// (add) Token: 0x060002FD RID: 765 RVA: 0x000164B9 File Offset: 0x000146B9
		// (remove) Token: 0x060002FE RID: 766 RVA: 0x000164BB File Offset: 0x000146BB
		public event GizmoPreHoverEnterHandler PreHoverEnter
		{
			add
			{
			}
			remove
			{
			}
		}

		// Token: 0x14000007 RID: 7
		// (add) Token: 0x060002FF RID: 767 RVA: 0x000164BD File Offset: 0x000146BD
		// (remove) Token: 0x06000300 RID: 768 RVA: 0x000164BF File Offset: 0x000146BF
		public event GizmoPostHoverEnterHandler PostHoverEnter
		{
			add
			{
			}
			remove
			{
			}
		}

		// Token: 0x14000008 RID: 8
		// (add) Token: 0x06000301 RID: 769 RVA: 0x000164C1 File Offset: 0x000146C1
		// (remove) Token: 0x06000302 RID: 770 RVA: 0x000164C3 File Offset: 0x000146C3
		public event GizmoPreHoverExitHandler PreHoverExit
		{
			add
			{
			}
			remove
			{
			}
		}

		// Token: 0x14000009 RID: 9
		// (add) Token: 0x06000303 RID: 771 RVA: 0x000164C5 File Offset: 0x000146C5
		// (remove) Token: 0x06000304 RID: 772 RVA: 0x000164C7 File Offset: 0x000146C7
		public event GizmoPostHoverExitHandler PostHoverExit
		{
			add
			{
			}
			remove
			{
			}
		}

		// Token: 0x1400000A RID: 10
		// (add) Token: 0x06000305 RID: 773 RVA: 0x000164C9 File Offset: 0x000146C9
		// (remove) Token: 0x06000306 RID: 774 RVA: 0x000164CB File Offset: 0x000146CB
		public event GizmoPreDragBeginHandler PreDragBegin
		{
			add
			{
			}
			remove
			{
			}
		}

		// Token: 0x1400000B RID: 11
		// (add) Token: 0x06000307 RID: 775 RVA: 0x000164CD File Offset: 0x000146CD
		// (remove) Token: 0x06000308 RID: 776 RVA: 0x000164CF File Offset: 0x000146CF
		public event GizmoPostDragBeginHandler PostDragBegin
		{
			add
			{
			}
			remove
			{
			}
		}

		// Token: 0x1400000C RID: 12
		// (add) Token: 0x06000309 RID: 777 RVA: 0x000164D1 File Offset: 0x000146D1
		// (remove) Token: 0x0600030A RID: 778 RVA: 0x000164D3 File Offset: 0x000146D3
		public event GizmoPreDragEndHandler PreDragEnd
		{
			add
			{
			}
			remove
			{
			}
		}

		// Token: 0x1400000D RID: 13
		// (add) Token: 0x0600030B RID: 779 RVA: 0x000164D5 File Offset: 0x000146D5
		// (remove) Token: 0x0600030C RID: 780 RVA: 0x000164D7 File Offset: 0x000146D7
		public event GizmoPostDragEndHandler PostDragEnd
		{
			add
			{
			}
			remove
			{
			}
		}

		// Token: 0x1400000E RID: 14
		// (add) Token: 0x0600030D RID: 781 RVA: 0x000164D9 File Offset: 0x000146D9
		// (remove) Token: 0x0600030E RID: 782 RVA: 0x000164DB File Offset: 0x000146DB
		public event GizmoPreDragUpdateHandler PreDragUpdate
		{
			add
			{
			}
			remove
			{
			}
		}

		// Token: 0x1400000F RID: 15
		// (add) Token: 0x0600030F RID: 783 RVA: 0x000164DD File Offset: 0x000146DD
		// (remove) Token: 0x06000310 RID: 784 RVA: 0x000164DF File Offset: 0x000146DF
		public event GizmoPostDragUpdateHandler PostDragUpdate
		{
			add
			{
			}
			remove
			{
			}
		}

		// Token: 0x14000010 RID: 16
		// (add) Token: 0x06000311 RID: 785 RVA: 0x000164E1 File Offset: 0x000146E1
		// (remove) Token: 0x06000312 RID: 786 RVA: 0x000164E3 File Offset: 0x000146E3
		public event GizmoPreHandlePickedHandler PreHandlePicked
		{
			add
			{
			}
			remove
			{
			}
		}

		// Token: 0x14000011 RID: 17
		// (add) Token: 0x06000313 RID: 787 RVA: 0x000164E5 File Offset: 0x000146E5
		// (remove) Token: 0x06000314 RID: 788 RVA: 0x000164E7 File Offset: 0x000146E7
		public event GizmoPostHandlePickedHandler PostHandlePicked
		{
			add
			{
			}
			remove
			{
			}
		}

		// Token: 0x14000012 RID: 18
		// (add) Token: 0x06000315 RID: 789 RVA: 0x000164E9 File Offset: 0x000146E9
		// (remove) Token: 0x06000316 RID: 790 RVA: 0x000164EB File Offset: 0x000146EB
		public event GizmoPreDragBeginAttemptHandler PreDragBeginAttempt
		{
			add
			{
			}
			remove
			{
			}
		}

		// Token: 0x14000013 RID: 19
		// (add) Token: 0x06000317 RID: 791 RVA: 0x000164ED File Offset: 0x000146ED
		// (remove) Token: 0x06000318 RID: 792 RVA: 0x000164EF File Offset: 0x000146EF
		public event GizmoPostDragBeginAttemptHandler PostDragBeginAttempt
		{
			add
			{
			}
			remove
			{
			}
		}

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x06000319 RID: 793 RVA: 0x000164F1 File Offset: 0x000146F1
		public static int InputDeviceDragButtonIndex
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x170000BE RID: 190
		// (get) Token: 0x0600031A RID: 794 RVA: 0x000164F4 File Offset: 0x000146F4
		public int NumHandles
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x170000BF RID: 191
		// (get) Token: 0x0600031B RID: 795 RVA: 0x000164F7 File Offset: 0x000146F7
		public Camera FocusCamera
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x0600031C RID: 796 RVA: 0x000164FA File Offset: 0x000146FA
		public bool IsEnabled
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x0600031D RID: 797 RVA: 0x000164FD File Offset: 0x000146FD
		public Priority GenericHoverPriority
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x0600031E RID: 798 RVA: 0x00016500 File Offset: 0x00014700
		public Priority HoverPriority3D
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x0600031F RID: 799 RVA: 0x00016503 File Offset: 0x00014703
		public Priority HoverPriority2D
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x06000320 RID: 800 RVA: 0x00016506 File Offset: 0x00014706
		public GizmoTransform Transform
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x06000321 RID: 801 RVA: 0x0001E63C File Offset: 0x0001C83C
		public GizmoHoverInfo HoverInfo
		{
			get
			{
				return default(GizmoHoverInfo);
			}
		}

		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x06000322 RID: 802 RVA: 0x00016509 File Offset: 0x00014709
		public bool IsHovered
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x06000323 RID: 803 RVA: 0x0001650C File Offset: 0x0001470C
		public int HoverHandleId
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x06000324 RID: 804 RVA: 0x0001E654 File Offset: 0x0001C854
		public GizmoDimension HoverHandleDimension
		{
			get
			{
				return GizmoDimension.None;
			}
		}

		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x06000325 RID: 805 RVA: 0x0001E66C File Offset: 0x0001C86C
		public Vector3 HoverPoint
		{
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x170000CA RID: 202
		// (get) Token: 0x06000326 RID: 806 RVA: 0x0001E684 File Offset: 0x0001C884
		public GizmoDragInfo DragInfo
		{
			get
			{
				return default(GizmoDragInfo);
			}
		}

		// Token: 0x170000CB RID: 203
		// (get) Token: 0x06000327 RID: 807 RVA: 0x0001650F File Offset: 0x0001470F
		public bool IsDragged
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170000CC RID: 204
		// (get) Token: 0x06000328 RID: 808 RVA: 0x0001E69C File Offset: 0x0001C89C
		public GizmoDragChannel ActiveDragChannel
		{
			get
			{
				return GizmoDragChannel.None;
			}
		}

		// Token: 0x170000CD RID: 205
		// (get) Token: 0x06000329 RID: 809 RVA: 0x00016512 File Offset: 0x00014712
		public int DragHandleId
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x170000CE RID: 206
		// (get) Token: 0x0600032A RID: 810 RVA: 0x0001E6B4 File Offset: 0x0001C8B4
		public Vector3 DragBeginPoint
		{
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x170000CF RID: 207
		// (get) Token: 0x0600032B RID: 811 RVA: 0x0001E6CC File Offset: 0x0001C8CC
		public GizmoDimension DragHandleDimension
		{
			get
			{
				return GizmoDimension.None;
			}
		}

		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x0600032C RID: 812 RVA: 0x0001E6E4 File Offset: 0x0001C8E4
		public Vector3 TotalDragOffset
		{
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x0600032D RID: 813 RVA: 0x0001E6FC File Offset: 0x0001C8FC
		public Quaternion TotalDragRotation
		{
			get
			{
				return default(Quaternion);
			}
		}

		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x0600032E RID: 814 RVA: 0x0001E714 File Offset: 0x0001C914
		public Vector3 TotalDragScale
		{
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x0600032F RID: 815 RVA: 0x0001E72C File Offset: 0x0001C92C
		public Vector3 RelativeDragOffset
		{
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x06000330 RID: 816 RVA: 0x0001E744 File Offset: 0x0001C944
		public Quaternion RelativeDragRotation
		{
			get
			{
				return default(Quaternion);
			}
		}

		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x06000331 RID: 817 RVA: 0x0001E75C File Offset: 0x0001C95C
		public Vector3 RelativeDragScale
		{
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x06000332 RID: 818 RVA: 0x00016515 File Offset: 0x00014715
		public MoveGizmo MoveGizmo
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x06000333 RID: 819 RVA: 0x00016518 File Offset: 0x00014718
		public RotationGizmo RotationGizmo
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x06000334 RID: 820 RVA: 0x0001651B File Offset: 0x0001471B
		public ScaleGizmo ScaleGizmo
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x06000335 RID: 821 RVA: 0x0001651E File Offset: 0x0001471E
		public UniversalGizmo UniversalGizmo
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170000DA RID: 218
		// (get) Token: 0x06000336 RID: 822 RVA: 0x00016521 File Offset: 0x00014721
		public ObjectTransformGizmo ObjectTransformGizmo
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170000DB RID: 219
		// (get) Token: 0x06000337 RID: 823 RVA: 0x00016524 File Offset: 0x00014724
		public BoxGizmo BoxGizmo
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170000DC RID: 220
		// (get) Token: 0x06000338 RID: 824 RVA: 0x00016527 File Offset: 0x00014727
		public ObjectExtrudeGizmo ObjectExtrudeGizmo
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170000DD RID: 221
		// (get) Token: 0x06000339 RID: 825 RVA: 0x0001652A File Offset: 0x0001472A
		public SceneGizmo SceneGizmo
		{
			get
			{
				return null;
			}
		}

		// Token: 0x0600033B RID: 827 RVA: 0x00016535 File Offset: 0x00014735
		public Camera GetWorkCamera()
		{
			return null;
		}

		// Token: 0x0600033C RID: 828 RVA: 0x00016538 File Offset: 0x00014738
		public GizmoHandle CreateHandle(int id)
		{
			return null;
		}

		// Token: 0x0600033D RID: 829 RVA: 0x0001653B File Offset: 0x0001473B
		public void SetEnabled(bool enabled)
		{
		}

		// Token: 0x0600033E RID: 830 RVA: 0x0001E774 File Offset: 0x0001C974
		public BehaviourType AddBehaviour<BehaviourType>() where BehaviourType : class, IGizmoBehaviour, new()
		{
			return default(BehaviourType);
		}

		// Token: 0x0600033F RID: 831 RVA: 0x0001653D File Offset: 0x0001473D
		public bool AddBehaviour(IGizmoBehaviour behaviour)
		{
			return false;
		}

		// Token: 0x06000340 RID: 832 RVA: 0x00016540 File Offset: 0x00014740
		public bool RemoveBehaviour(IGizmoBehaviour behaviour)
		{
			return false;
		}

		// Token: 0x06000341 RID: 833 RVA: 0x00016543 File Offset: 0x00014743
		public List<BehaviourType> GetBehavioursOfType<BehaviourType>() where BehaviourType : class, IGizmoBehaviour
		{
			return null;
		}

		// Token: 0x06000342 RID: 834 RVA: 0x0001E78C File Offset: 0x0001C98C
		public BehaviourType GetFirstBehaviourOfType<BehaviourType>() where BehaviourType : class, IGizmoBehaviour
		{
			return default(BehaviourType);
		}

		// Token: 0x06000343 RID: 835 RVA: 0x00016546 File Offset: 0x00014746
		public IGizmoBehaviour GetFirstBehaviourOfType(Type behaviourType)
		{
			return null;
		}

		// Token: 0x06000344 RID: 836 RVA: 0x00016549 File Offset: 0x00014749
		public List<GizmoHandleHoverData> GetAllHandlesHoverData(Ray hoverRay)
		{
			return null;
		}

		// Token: 0x06000345 RID: 837 RVA: 0x0001654C File Offset: 0x0001474C
		public IGizmoHandle GetHandleById_SystemCall(int handleId)
		{
			return null;
		}

		// Token: 0x06000346 RID: 838 RVA: 0x0001654F File Offset: 0x0001474F
		public void OnGUI_SystemCall()
		{
		}

		// Token: 0x06000347 RID: 839 RVA: 0x00016551 File Offset: 0x00014751
		public void OnUpdateBegin_SystemCall()
		{
		}

		// Token: 0x06000348 RID: 840 RVA: 0x00016553 File Offset: 0x00014753
		public void OnUpdateEnd_SystemCall()
		{
		}

		// Token: 0x06000349 RID: 841 RVA: 0x00016555 File Offset: 0x00014755
		public void UpdateHandleHoverInfo_SystemCall(GizmoHoverInfo hoverInfo)
		{
		}

		// Token: 0x0600034A RID: 842 RVA: 0x00016557 File Offset: 0x00014757
		public void Render_SystemCall(Camera camera, Plane[] worldFrustumPlanes)
		{
		}

		// Token: 0x0600034B RID: 843 RVA: 0x00016559 File Offset: 0x00014759
		public void HandleInputDeviceEvents_SystemCall()
		{
		}

		// Token: 0x0600034C RID: 844 RVA: 0x0001655B File Offset: 0x0001475B
		private void OnInputDevicePickButtonDown()
		{
		}

		// Token: 0x0600034D RID: 845 RVA: 0x0001655D File Offset: 0x0001475D
		private void OnInputDevicePickButtonUp()
		{
		}

		// Token: 0x0600034E RID: 846 RVA: 0x0001655F File Offset: 0x0001475F
		private void EndDragSession()
		{
		}

		// Token: 0x0600034F RID: 847 RVA: 0x00016561 File Offset: 0x00014761
		private void OnInputDeviceMoved()
		{
		}

		// Token: 0x06000350 RID: 848 RVA: 0x00016563 File Offset: 0x00014763
		private void TryActivateDragSession()
		{
		}

		// Token: 0x0400012F RID: 303
		private bool _isEnabled;

		// Token: 0x04000130 RID: 304
		private GizmoHandleCollection _handles;

		// Token: 0x04000131 RID: 305
		private GizmoBehaviourCollection _behaviours;

		// Token: 0x04000132 RID: 306
		private GizmoHoverInfo _hoverInfo;

		// Token: 0x04000133 RID: 307
		private GizmoDragInfo _dragInfo;

		// Token: 0x04000134 RID: 308
		private IGizmoHandle _hoveredHandle;

		// Token: 0x04000135 RID: 309
		private Priority _genericHoverPriority;

		// Token: 0x04000136 RID: 310
		private Priority _hoverPriority3D;

		// Token: 0x04000137 RID: 311
		private Priority _hoverPriority2D;

		// Token: 0x04000138 RID: 312
		private IGizmoDragSession _activeDragSession;

		// Token: 0x04000139 RID: 313
		private GizmoTransform _transform;

		// Token: 0x0400013A RID: 314
		[NonSerialized]
		private MoveGizmo _moveGizmo;

		// Token: 0x0400013B RID: 315
		[NonSerialized]
		private RotationGizmo _rotationGizmo;

		// Token: 0x0400013C RID: 316
		[NonSerialized]
		private ScaleGizmo _scaleGizmo;

		// Token: 0x0400013D RID: 317
		[NonSerialized]
		private UniversalGizmo _universalGizmo;

		// Token: 0x0400013E RID: 318
		[NonSerialized]
		private ObjectTransformGizmo _objectTransformGizmo;

		// Token: 0x0400013F RID: 319
		[NonSerialized]
		private BoxGizmo _boxGizmo;

		// Token: 0x04000140 RID: 320
		[NonSerialized]
		private ObjectExtrudeGizmo _objectExtrudeGizmo;

		// Token: 0x04000141 RID: 321
		[NonSerialized]
		private SceneGizmo _sceneGizmo;
	}
}
