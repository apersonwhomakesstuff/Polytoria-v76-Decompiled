using System;
using System.Collections.Generic;
using UnityEngine;

namespace RLD
{
	// Token: 0x02000033 RID: 51
	public class GizmoTransform
	{
		// Token: 0x14000001 RID: 1
		// (add) Token: 0x06000175 RID: 373 RVA: 0x000161F9 File Offset: 0x000143F9
		// (remove) Token: 0x06000176 RID: 374 RVA: 0x000161FB File Offset: 0x000143FB
		public event GizmoEntityTransformChangedHandler Changed
		{
			add
			{
			}
			remove
			{
			}
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x06000177 RID: 375 RVA: 0x000161FD File Offset: 0x000143FD
		public bool CanChange3D
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x06000178 RID: 376 RVA: 0x00016200 File Offset: 0x00014400
		public bool CanChange2D
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x06000179 RID: 377 RVA: 0x00016203 File Offset: 0x00014403
		public GizmoTransform Parent
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x0600017A RID: 378 RVA: 0x00016206 File Offset: 0x00014406
		public int NumChildren
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x0600017B RID: 379 RVA: 0x00016209 File Offset: 0x00014409
		public List<GizmoTransform> Children
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x0600017C RID: 380 RVA: 0x0001E0E4 File Offset: 0x0001C2E4
		public Vector3 Right3D
		{
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x0600017D RID: 381 RVA: 0x0001E0FC File Offset: 0x0001C2FC
		public Vector3 Up3D
		{
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x0600017E RID: 382 RVA: 0x0001E114 File Offset: 0x0001C314
		public Vector3 Look3D
		{
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x0600017F RID: 383 RVA: 0x0001E12C File Offset: 0x0001C32C
		public Vector2 Right2D
		{
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x06000180 RID: 384 RVA: 0x0001E144 File Offset: 0x0001C344
		public Vector2 Up2D
		{
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x06000181 RID: 385 RVA: 0x0001E15C File Offset: 0x0001C35C
		// (set) Token: 0x06000182 RID: 386 RVA: 0x0001620C File Offset: 0x0001440C
		public Vector3 Position3D
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x06000183 RID: 387 RVA: 0x0001E174 File Offset: 0x0001C374
		// (set) Token: 0x06000184 RID: 388 RVA: 0x0001620E File Offset: 0x0001440E
		public Vector2 Position2D
		{
			get
			{
				return default(Vector2);
			}
			set
			{
			}
		}

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x06000185 RID: 389 RVA: 0x0001E18C File Offset: 0x0001C38C
		// (set) Token: 0x06000186 RID: 390 RVA: 0x00016210 File Offset: 0x00014410
		public Quaternion Rotation3D
		{
			get
			{
				return default(Quaternion);
			}
			set
			{
			}
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x06000187 RID: 391 RVA: 0x0001E1A4 File Offset: 0x0001C3A4
		public Quaternion Rotation2D
		{
			get
			{
				return default(Quaternion);
			}
		}

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x06000188 RID: 392 RVA: 0x00016212 File Offset: 0x00014412
		// (set) Token: 0x06000189 RID: 393 RVA: 0x00016219 File Offset: 0x00014419
		public float Rotation2DDegrees
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x0600018A RID: 394 RVA: 0x0001E1BC File Offset: 0x0001C3BC
		// (set) Token: 0x0600018B RID: 395 RVA: 0x0001621B File Offset: 0x0001441B
		public Vector3 LocalPosition3D
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x0600018C RID: 396 RVA: 0x0001E1D4 File Offset: 0x0001C3D4
		// (set) Token: 0x0600018D RID: 397 RVA: 0x0001621D File Offset: 0x0001441D
		public Vector2 LocalPosition2D
		{
			get
			{
				return default(Vector2);
			}
			set
			{
			}
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x0600018E RID: 398 RVA: 0x0001E1EC File Offset: 0x0001C3EC
		// (set) Token: 0x0600018F RID: 399 RVA: 0x0001621F File Offset: 0x0001441F
		public Quaternion LocalRotation3D
		{
			get
			{
				return default(Quaternion);
			}
			set
			{
			}
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x06000190 RID: 400 RVA: 0x0001E204 File Offset: 0x0001C404
		public Quaternion LocalRotation2D
		{
			get
			{
				return default(Quaternion);
			}
		}

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x06000191 RID: 401 RVA: 0x00016221 File Offset: 0x00014421
		// (set) Token: 0x06000192 RID: 402 RVA: 0x00016228 File Offset: 0x00014428
		public float LocalRotation2DDegrees
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x06000194 RID: 404 RVA: 0x00016232 File Offset: 0x00014432
		public static List<GizmoTransform> FilterParentsOnly(IEnumerable<GizmoTransform> transforms)
		{
			return null;
		}

		// Token: 0x06000195 RID: 405 RVA: 0x0001E21C File Offset: 0x0001C41C
		public PlaneQuadrantId Get3DQuadrantFacingCamera(PlaneId planeId, Camera camera)
		{
			return PlaneQuadrantId.First;
		}

		// Token: 0x06000196 RID: 406 RVA: 0x00016235 File Offset: 0x00014435
		public void Rotate3D(Quaternion rotation)
		{
		}

		// Token: 0x06000197 RID: 407 RVA: 0x00016237 File Offset: 0x00014437
		public void Rotate2D(float rotation)
		{
		}

		// Token: 0x06000198 RID: 408 RVA: 0x00016239 File Offset: 0x00014439
		public void Rotate2D(Quaternion rotation)
		{
		}

		// Token: 0x06000199 RID: 409 RVA: 0x0001E234 File Offset: 0x0001C434
		public Vector3 TransformVector3D(Vector3 vec)
		{
			return default(Vector3);
		}

		// Token: 0x0600019A RID: 410 RVA: 0x0001E24C File Offset: 0x0001C44C
		public Vector2 TransformVector2D(Vector2 vec)
		{
			return default(Vector2);
		}

		// Token: 0x0600019B RID: 411 RVA: 0x0001E264 File Offset: 0x0001C464
		public Vector3 TransformNormal3D(Vector3 normal)
		{
			return default(Vector3);
		}

		// Token: 0x0600019C RID: 412 RVA: 0x0001E27C File Offset: 0x0001C47C
		public Vector2 TransformNormal2D(Vector2 normal)
		{
			return default(Vector2);
		}

		// Token: 0x0600019D RID: 413 RVA: 0x0001E294 File Offset: 0x0001C494
		public Vector3 InverseTransformNormal3D(Vector3 normal)
		{
			return default(Vector3);
		}

		// Token: 0x0600019E RID: 414 RVA: 0x0001E2AC File Offset: 0x0001C4AC
		public Vector2 InverseTransformNormal2D(Vector2 normal)
		{
			return default(Vector2);
		}

		// Token: 0x0600019F RID: 415 RVA: 0x0001E2C4 File Offset: 0x0001C4C4
		public Vector3 TransformPoint3D(Vector3 point)
		{
			return default(Vector3);
		}

		// Token: 0x060001A0 RID: 416 RVA: 0x0001E2DC File Offset: 0x0001C4DC
		public Vector2 TransformPoint2D(Vector2 point)
		{
			return default(Vector2);
		}

		// Token: 0x060001A1 RID: 417 RVA: 0x0001E2F4 File Offset: 0x0001C4F4
		public Vector3 InverseTransformPoint3D(Vector3 point)
		{
			return default(Vector3);
		}

		// Token: 0x060001A2 RID: 418 RVA: 0x0001E30C File Offset: 0x0001C50C
		public Vector2 InverseTransformPoint2D(Vector2 point)
		{
			return default(Vector2);
		}

		// Token: 0x060001A3 RID: 419 RVA: 0x0001623B File Offset: 0x0001443B
		public void AlignAxis3D(int axisIndex, AxisSign axisSign, Vector3 axis)
		{
		}

		// Token: 0x060001A4 RID: 420 RVA: 0x0001623D File Offset: 0x0001443D
		public void AlignAxis2D(int axisIndex, AxisSign axisSign, Vector2 axis)
		{
		}

		// Token: 0x060001A5 RID: 421 RVA: 0x0001623F File Offset: 0x0001443F
		public bool IsChildOf(GizmoTransform transform)
		{
			return false;
		}

		// Token: 0x060001A6 RID: 422 RVA: 0x00016242 File Offset: 0x00014442
		public void SetParent(GizmoTransform newParent)
		{
		}

		// Token: 0x060001A7 RID: 423 RVA: 0x0001E324 File Offset: 0x0001C524
		public Vector3 GetAxis3D(AxisDescriptor axisDesc)
		{
			return default(Vector3);
		}

		// Token: 0x060001A8 RID: 424 RVA: 0x0001E33C File Offset: 0x0001C53C
		public Vector3 GetAxis3D(int axisIndex, AxisSign axisSign)
		{
			return default(Vector3);
		}

		// Token: 0x060001A9 RID: 425 RVA: 0x0001E354 File Offset: 0x0001C554
		public Vector2 GetAxis2D(AxisDescriptor axisDesc)
		{
			return default(Vector2);
		}

		// Token: 0x060001AA RID: 426 RVA: 0x0001E36C File Offset: 0x0001C56C
		public Vector2 GetAxis2D(int axisIndex, AxisSign axisSign)
		{
			return default(Vector2);
		}

		// Token: 0x060001AB RID: 427 RVA: 0x00016244 File Offset: 0x00014444
		public Vector3[] GetAxes3D()
		{
			return null;
		}

		// Token: 0x060001AC RID: 428 RVA: 0x00016247 File Offset: 0x00014447
		public Vector2[] GetAxes2D()
		{
			return null;
		}

		// Token: 0x060001AD RID: 429 RVA: 0x0001E384 File Offset: 0x0001C584
		public Plane GetPlane3D(PlaneId planeId, PlaneQuadrantId planeQuadrantId)
		{
			return default(Plane);
		}

		// Token: 0x060001AE RID: 430 RVA: 0x0001E39C File Offset: 0x0001C59C
		public Plane GetPlane3D(PlaneDescriptor planeDesc)
		{
			return default(Plane);
		}

		// Token: 0x060001AF RID: 431 RVA: 0x0001624A File Offset: 0x0001444A
		private void ChangePosition3D(Vector3 position)
		{
		}

		// Token: 0x060001B0 RID: 432 RVA: 0x0001624C File Offset: 0x0001444C
		private void ChangePosition2D(Vector2 position)
		{
		}

		// Token: 0x060001B1 RID: 433 RVA: 0x0001624E File Offset: 0x0001444E
		private void ChangeRotation3D(Quaternion rotation)
		{
		}

		// Token: 0x060001B2 RID: 434 RVA: 0x00016250 File Offset: 0x00014450
		private void ChangeRotation2D(float rotation)
		{
		}

		// Token: 0x060001B3 RID: 435 RVA: 0x00016252 File Offset: 0x00014452
		private void ChangeRotation2D(Quaternion rotation)
		{
		}

		// Token: 0x060001B4 RID: 436 RVA: 0x00016254 File Offset: 0x00014454
		private void ChangeLocalPosition3D(Vector3 localPosition)
		{
		}

		// Token: 0x060001B5 RID: 437 RVA: 0x00016256 File Offset: 0x00014456
		private void ChangeLocalPosition2D(Vector2 localPosition)
		{
		}

		// Token: 0x060001B6 RID: 438 RVA: 0x00016258 File Offset: 0x00014458
		private void ChangeLocalRotation3D(Quaternion localRotation)
		{
		}

		// Token: 0x060001B7 RID: 439 RVA: 0x0001625A File Offset: 0x0001445A
		private void ChangeLocalRotation2D(float localRotation)
		{
		}

		// Token: 0x060001B8 RID: 440 RVA: 0x0001625C File Offset: 0x0001445C
		private void ChangeLocalRotation2D(Quaternion localRotation)
		{
		}

		// Token: 0x060001B9 RID: 441 RVA: 0x0001625E File Offset: 0x0001445E
		private void OnParentChanged()
		{
		}

		// Token: 0x060001BA RID: 442 RVA: 0x00016260 File Offset: 0x00014460
		private void OnPosition3DChanged()
		{
		}

		// Token: 0x060001BB RID: 443 RVA: 0x00016262 File Offset: 0x00014462
		private void OnPosition2DChanged()
		{
		}

		// Token: 0x060001BC RID: 444 RVA: 0x00016264 File Offset: 0x00014464
		private void OnLocalPosition3DChanged()
		{
		}

		// Token: 0x060001BD RID: 445 RVA: 0x00016266 File Offset: 0x00014466
		private void OnLocalPosition2DChanged()
		{
		}

		// Token: 0x060001BE RID: 446 RVA: 0x00016268 File Offset: 0x00014468
		private void OnRotation3DChanged()
		{
		}

		// Token: 0x060001BF RID: 447 RVA: 0x0001626A File Offset: 0x0001446A
		private void OnRotation2DChanged()
		{
		}

		// Token: 0x060001C0 RID: 448 RVA: 0x0001626C File Offset: 0x0001446C
		private void OnLocalRotation3DChanged()
		{
		}

		// Token: 0x060001C1 RID: 449 RVA: 0x0001626E File Offset: 0x0001446E
		private void OnLocalRotation2DChanged()
		{
		}

		// Token: 0x060001C2 RID: 450 RVA: 0x00016270 File Offset: 0x00014470
		private void UpdateChildTransforms3D()
		{
		}

		// Token: 0x060001C3 RID: 451 RVA: 0x00016272 File Offset: 0x00014472
		private void UpdateChildTransforms2D()
		{
		}

		// Token: 0x060001C4 RID: 452 RVA: 0x00016274 File Offset: 0x00014474
		private void OnChanged(GizmoTransform.ChangeData changeData)
		{
		}

		// Token: 0x060001C5 RID: 453 RVA: 0x00016276 File Offset: 0x00014476
		private void Update3DAxes()
		{
		}

		// Token: 0x060001C6 RID: 454 RVA: 0x00016278 File Offset: 0x00014478
		private void Update2DAxes()
		{
		}

		// Token: 0x040000B7 RID: 183
		private bool _firingChanged3DEvent;

		// Token: 0x040000B8 RID: 184
		private bool _firingChanged2DEvent;

		// Token: 0x040000B9 RID: 185
		private Vector3 _position3D;

		// Token: 0x040000BA RID: 186
		private Vector3 _localPosition3D;

		// Token: 0x040000BB RID: 187
		private Quaternion _rotation3D;

		// Token: 0x040000BC RID: 188
		private Quaternion _localRotation3D;

		// Token: 0x040000BD RID: 189
		private Vector2 _position2D;

		// Token: 0x040000BE RID: 190
		private Vector2 _localPosition2D;

		// Token: 0x040000BF RID: 191
		private float _rotation2DDegrees;

		// Token: 0x040000C0 RID: 192
		private Quaternion _rotation2D;

		// Token: 0x040000C1 RID: 193
		private float _localRotation2DDegrees;

		// Token: 0x040000C2 RID: 194
		private Quaternion _localRotation2D;

		// Token: 0x040000C3 RID: 195
		private Vector3[] _axes3D;

		// Token: 0x040000C4 RID: 196
		private Vector2[] _axes2D;

		// Token: 0x040000C5 RID: 197
		private GizmoTransform _parent;

		// Token: 0x040000C6 RID: 198
		private List<GizmoTransform> _children;

		// Token: 0x0200034F RID: 847
		public enum ChangeReason
		{
			// Token: 0x04000E9F RID: 3743
			TRSChange,
			// Token: 0x04000EA0 RID: 3744
			ParentChange
		}

		// Token: 0x02000350 RID: 848
		public struct ChangeData
		{
			// Token: 0x06002A2A RID: 10794 RVA: 0x0002674C File Offset: 0x0002494C
			public ChangeData(GizmoTransform.ChangeReason changeReason, GizmoDimension trsDimension)
			{
				this.ChangeReason = GizmoTransform.ChangeReason.TRSChange;
				this.TRSDimension = GizmoDimension.None;
			}

			// Token: 0x04000EA1 RID: 3745
			public GizmoTransform.ChangeReason ChangeReason;

			// Token: 0x04000EA2 RID: 3746
			public GizmoDimension TRSDimension;
		}
	}
}
