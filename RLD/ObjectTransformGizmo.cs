using System;
using System.Collections.Generic;
using UnityEngine;

namespace RLD
{
	// Token: 0x020000E0 RID: 224
	[Serializable]
	public class ObjectTransformGizmo : GizmoBehaviour
	{
		// Token: 0x17000353 RID: 851
		// (get) Token: 0x06000A1E RID: 2590 RVA: 0x0001F8E4 File Offset: 0x0001DAE4
		public GizmoObjectTransformPivot TransformPivot
		{
			get
			{
				return GizmoObjectTransformPivot.ObjectGroupCenter;
			}
		}

		// Token: 0x17000354 RID: 852
		// (get) Token: 0x06000A1F RID: 2591 RVA: 0x000178D1 File Offset: 0x00015AD1
		public bool IsTransformPivotPermanent
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000355 RID: 853
		// (get) Token: 0x06000A20 RID: 2592 RVA: 0x0001F8FC File Offset: 0x0001DAFC
		public GizmoSpace TransformSpace
		{
			get
			{
				return GizmoSpace.Global;
			}
		}

		// Token: 0x17000356 RID: 854
		// (get) Token: 0x06000A21 RID: 2593 RVA: 0x000178D4 File Offset: 0x00015AD4
		public bool IsTransformSpacePermanent
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000357 RID: 855
		// (get) Token: 0x06000A22 RID: 2594 RVA: 0x0001F914 File Offset: 0x0001DB14
		public ObjectTransformGizmo.Channels TransformChannelFlags
		{
			get
			{
				return ObjectTransformGizmo.Channels.None;
			}
		}

		// Token: 0x17000358 RID: 856
		// (get) Token: 0x06000A23 RID: 2595 RVA: 0x000178D7 File Offset: 0x00015AD7
		public bool CanAffectPosition
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000359 RID: 857
		// (get) Token: 0x06000A24 RID: 2596 RVA: 0x000178DA File Offset: 0x00015ADA
		public bool CanAffectRotation
		{
			get
			{
				return false;
			}
		}

		// Token: 0x1700035A RID: 858
		// (get) Token: 0x06000A25 RID: 2597 RVA: 0x000178DD File Offset: 0x00015ADD
		public bool CanAffectScale
		{
			get
			{
				return false;
			}
		}

		// Token: 0x1700035B RID: 859
		// (get) Token: 0x06000A26 RID: 2598 RVA: 0x0001F92C File Offset: 0x0001DB2C
		public Vector3 CustomWorldPivot
		{
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x1700035C RID: 860
		// (get) Token: 0x06000A27 RID: 2599 RVA: 0x000178E0 File Offset: 0x00015AE0
		public ObjectTransformGizmoSettings Settings
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700035D RID: 861
		// (get) Token: 0x06000A28 RID: 2600 RVA: 0x000178E3 File Offset: 0x00015AE3
		// (set) Token: 0x06000A29 RID: 2601 RVA: 0x000178E6 File Offset: 0x00015AE6
		public ObjectTransformGizmoSettings SharedSettings
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x1700035E RID: 862
		// (get) Token: 0x06000A2A RID: 2602 RVA: 0x000178E8 File Offset: 0x00015AE8
		// (set) Token: 0x06000A2B RID: 2603 RVA: 0x000178EB File Offset: 0x00015AEB
		public bool ScaleConstraintEnabled
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x1700035F RID: 863
		// (get) Token: 0x06000A2C RID: 2604 RVA: 0x0001F944 File Offset: 0x0001DB44
		// (set) Token: 0x06000A2D RID: 2605 RVA: 0x000178ED File Offset: 0x00015AED
		public Vector3 MinPositiveScale
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		// Token: 0x06000A2E RID: 2606 RVA: 0x000178EF File Offset: 0x00015AEF
		public override void OnAttached()
		{
		}

		// Token: 0x06000A2F RID: 2607 RVA: 0x000178F1 File Offset: 0x00015AF1
		public override void OnDetached()
		{
		}

		// Token: 0x06000A30 RID: 2608 RVA: 0x000178F3 File Offset: 0x00015AF3
		public void MakeTransformSpacePermanent()
		{
		}

		// Token: 0x06000A31 RID: 2609 RVA: 0x000178F5 File Offset: 0x00015AF5
		public void MakeTransformPivotPermanent()
		{
		}

		// Token: 0x06000A32 RID: 2610 RVA: 0x000178F7 File Offset: 0x00015AF7
		public bool ContainsRestrictionsForObject(GameObject targetObject)
		{
			return false;
		}

		// Token: 0x06000A33 RID: 2611 RVA: 0x000178FA File Offset: 0x00015AFA
		public void RegisterObjectRestrictions(GameObject targetObject, ObjectTransformGizmo.ObjectRestrictions restrictions)
		{
		}

		// Token: 0x06000A34 RID: 2612 RVA: 0x000178FC File Offset: 0x00015AFC
		public void RegisterObjectRestrictions(List<GameObject> targetObjects, ObjectTransformGizmo.ObjectRestrictions restrictions)
		{
		}

		// Token: 0x06000A35 RID: 2613 RVA: 0x000178FE File Offset: 0x00015AFE
		public void UnregisterObjectRestrictions(GameObject targetObject)
		{
		}

		// Token: 0x06000A36 RID: 2614 RVA: 0x00017900 File Offset: 0x00015B00
		public ObjectTransformGizmo.ObjectRestrictions GetObjectRestrictions(GameObject targetObject)
		{
			return null;
		}

		// Token: 0x06000A37 RID: 2615 RVA: 0x00017903 File Offset: 0x00015B03
		public void SetTransformChannelFlags(ObjectTransformGizmo.Channels flags)
		{
		}

		// Token: 0x06000A38 RID: 2616 RVA: 0x00017905 File Offset: 0x00015B05
		public void SetCanAffectPosition(bool affectPosition)
		{
		}

		// Token: 0x06000A39 RID: 2617 RVA: 0x00017907 File Offset: 0x00015B07
		public void SetCanAffectRotation(bool affectRotation)
		{
		}

		// Token: 0x06000A3A RID: 2618 RVA: 0x00017909 File Offset: 0x00015B09
		public void SetCanAffectScale(bool affectScale)
		{
		}

		// Token: 0x06000A3B RID: 2619 RVA: 0x0001790B File Offset: 0x00015B0B
		public void SetTargetPivotObject(GameObject targetPivotObject)
		{
		}

		// Token: 0x06000A3C RID: 2620 RVA: 0x0001790D File Offset: 0x00015B0D
		public void SetTargetObjects(IEnumerable<GameObject> targetObjects)
		{
		}

		// Token: 0x06000A3D RID: 2621 RVA: 0x0001790F File Offset: 0x00015B0F
		public void SetTargetObject(GameObject targetObject)
		{
		}

		// Token: 0x06000A3E RID: 2622 RVA: 0x00017911 File Offset: 0x00015B11
		public void SetTransformPivot(GizmoObjectTransformPivot transformPivot)
		{
		}

		// Token: 0x06000A3F RID: 2623 RVA: 0x00017913 File Offset: 0x00015B13
		public void SetCustomWorldPivot(Vector3 pivot)
		{
		}

		// Token: 0x06000A40 RID: 2624 RVA: 0x00017915 File Offset: 0x00015B15
		public void SetObjectCustomLocalPivot(GameObject gameObj, Vector3 pivot)
		{
		}

		// Token: 0x06000A41 RID: 2625 RVA: 0x0001F95C File Offset: 0x0001DB5C
		public Vector3 GetObjectCustomLocalPivot(GameObject gameObj)
		{
			return default(Vector3);
		}

		// Token: 0x06000A42 RID: 2626 RVA: 0x00017917 File Offset: 0x00015B17
		public void SetTransformSpace(GizmoSpace transformSpace)
		{
		}

		// Token: 0x06000A43 RID: 2627 RVA: 0x0001F974 File Offset: 0x0001DB74
		public AABB GetTargetObjectGroupWorldAABB()
		{
			return default(AABB);
		}

		// Token: 0x06000A44 RID: 2628 RVA: 0x00017919 File Offset: 0x00015B19
		public int GetNumTransformableParentObjects()
		{
			return 0;
		}

		// Token: 0x06000A45 RID: 2629 RVA: 0x0001791C File Offset: 0x00015B1C
		public void RefreshPosition()
		{
		}

		// Token: 0x06000A46 RID: 2630 RVA: 0x0001791E File Offset: 0x00015B1E
		public void RefreshRotation()
		{
		}

		// Token: 0x06000A47 RID: 2631 RVA: 0x00017920 File Offset: 0x00015B20
		public void RefreshPositionAndRotation()
		{
		}

		// Token: 0x06000A48 RID: 2632 RVA: 0x00017922 File Offset: 0x00015B22
		public override void OnGizmoDragBegin(int handleId)
		{
		}

		// Token: 0x06000A49 RID: 2633 RVA: 0x00017924 File Offset: 0x00015B24
		public override void OnGizmoDragUpdate(int handleId)
		{
		}

		// Token: 0x06000A4A RID: 2634 RVA: 0x00017926 File Offset: 0x00015B26
		public override void OnGizmoDragEnd(int handleId)
		{
		}

		// Token: 0x06000A4B RID: 2635 RVA: 0x00017928 File Offset: 0x00015B28
		private List<GameObject> GetTransformableParentObjects()
		{
			return null;
		}

		// Token: 0x06000A4C RID: 2636 RVA: 0x0001792B File Offset: 0x00015B2B
		private void OnUndoRedoEnd(IUndoRedoAction action)
		{
		}

		// Token: 0x06000A4D RID: 2637 RVA: 0x0001792D File Offset: 0x00015B2D
		private void MoveObjects(Vector3 moveVector)
		{
		}

		// Token: 0x06000A4E RID: 2638 RVA: 0x0001792F File Offset: 0x00015B2F
		private void MoveObject(GameObject gameObject, Vector3 moveVector)
		{
		}

		// Token: 0x06000A4F RID: 2639 RVA: 0x00017931 File Offset: 0x00015B31
		private void RotateObjects(Quaternion rotation)
		{
		}

		// Token: 0x06000A50 RID: 2640 RVA: 0x00017933 File Offset: 0x00015B33
		private void RotateObject(GameObject gameObject, Quaternion rotation, Vector3 rotationPivot)
		{
		}

		// Token: 0x06000A51 RID: 2641 RVA: 0x00017935 File Offset: 0x00015B35
		private void ScaleObjects()
		{
		}

		// Token: 0x06000A52 RID: 2642 RVA: 0x00017937 File Offset: 0x00015B37
		private void ScaleObject(GameObject gameObject, Vector3 scalePivot)
		{
		}

		// Token: 0x06000A53 RID: 2643 RVA: 0x0001F98C File Offset: 0x0001DB8C
		private ObjectBounds.QueryConfig GetObjectBoundsQConfig()
		{
			return default(ObjectBounds.QueryConfig);
		}

		// Token: 0x040003F1 RID: 1009
		private ObjectTransformGizmo.TargetObjectMode _targetObjectMode;

		// Token: 0x040003F2 RID: 1010
		private ObjectTransformGizmo.Channels _transformChannelFlags;

		// Token: 0x040003F3 RID: 1011
		private IEnumerable<GameObject> _targetObjects;

		// Token: 0x040003F4 RID: 1012
		private GameObject _targetPivotObject;

		// Token: 0x040003F5 RID: 1013
		private List<LocalTransformSnapshot> _preTransformSnapshots;

		// Token: 0x040003F6 RID: 1014
		private List<GameObject> _transformableParents;

		// Token: 0x040003F7 RID: 1015
		private AABB _targetGroupAABBOnDragBegin;

		// Token: 0x040003F8 RID: 1016
		private GizmoSpace _transformSpace;

		// Token: 0x040003F9 RID: 1017
		private bool _isTransformSpacePermanent;

		// Token: 0x040003FA RID: 1018
		private GizmoObjectTransformPivot _transformPivot;

		// Token: 0x040003FB RID: 1019
		private bool _isTransformPivotPermanent;

		// Token: 0x040003FC RID: 1020
		private bool _scaleConstraintEnabled;

		// Token: 0x040003FD RID: 1021
		private Vector3 _minPositiveScale;

		// Token: 0x040003FE RID: 1022
		private Vector3 _customWorldPivot;

		// Token: 0x040003FF RID: 1023
		private Dictionary<GameObject, Vector3> _objectToCustomLocalPivot;

		// Token: 0x04000400 RID: 1024
		private Dictionary<GameObject, ObjectTransformGizmo.ObjectRestrictions> _objectToRestrictions;

		// Token: 0x04000401 RID: 1025
		private ObjectTransformGizmoSettings _settings;

		// Token: 0x04000402 RID: 1026
		private ObjectTransformGizmoSettings _sharedSettings;

		// Token: 0x02000370 RID: 880
		public class ObjectRestrictions
		{
			// Token: 0x06002A52 RID: 10834 RVA: 0x0001D1F3 File Offset: 0x0001B3F3
			public bool CanMoveAlongAllAxes()
			{
				return false;
			}

			// Token: 0x06002A53 RID: 10835 RVA: 0x0001D1F6 File Offset: 0x0001B3F6
			public bool CanScaleAlongAllAxes()
			{
				return false;
			}

			// Token: 0x06002A54 RID: 10836 RVA: 0x0001D1F9 File Offset: 0x0001B3F9
			public bool CanMoveAlongAxis(int axisIndex)
			{
				return false;
			}

			// Token: 0x06002A55 RID: 10837 RVA: 0x0001D1FC File Offset: 0x0001B3FC
			public bool CanScaleAlongAxis(int axisIndex)
			{
				return false;
			}

			// Token: 0x06002A56 RID: 10838 RVA: 0x0001D1FF File Offset: 0x0001B3FF
			public void SetCanMoveAlongAxis(int axisIndex, bool canMove)
			{
			}

			// Token: 0x06002A57 RID: 10839 RVA: 0x0001D201 File Offset: 0x0001B401
			public void SetCanScaleAlongAxis(int axisIndex, bool canScale)
			{
			}

			// Token: 0x06002A58 RID: 10840 RVA: 0x0001D203 File Offset: 0x0001B403
			public bool IsAffectedByHandle(int handleId)
			{
				return false;
			}

			// Token: 0x06002A59 RID: 10841 RVA: 0x0001D206 File Offset: 0x0001B406
			public void SetIsAffectedByHandle(int handleId, bool isAffected)
			{
			}

			// Token: 0x06002A5A RID: 10842 RVA: 0x00026778 File Offset: 0x00024978
			public Vector3 AdjustMoveVector(Vector3 moveVector)
			{
				return default(Vector3);
			}

			// Token: 0x06002A5B RID: 10843 RVA: 0x00026790 File Offset: 0x00024990
			public Vector3 AdjustScaleVector(Vector3 scaleVector)
			{
				return default(Vector3);
			}

			// Token: 0x04000EF1 RID: 3825
			private bool[] _moveAxesMask;

			// Token: 0x04000EF2 RID: 3826
			private bool[] _scaleAxesMask;

			// Token: 0x04000EF3 RID: 3827
			private HashSet<int> _handleMask;
		}

		// Token: 0x02000371 RID: 881
		public enum Channels
		{
			// Token: 0x04000EF5 RID: 3829
			None,
			// Token: 0x04000EF6 RID: 3830
			Position,
			// Token: 0x04000EF7 RID: 3831
			Rotation,
			// Token: 0x04000EF8 RID: 3832
			Scale = 4,
			// Token: 0x04000EF9 RID: 3833
			All = 7
		}

		// Token: 0x02000372 RID: 882
		private enum TargetObjectMode
		{
			// Token: 0x04000EFB RID: 3835
			Multiple,
			// Token: 0x04000EFC RID: 3836
			Single
		}
	}
}
