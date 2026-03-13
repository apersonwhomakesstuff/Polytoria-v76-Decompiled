using System;
using System.Collections.Generic;
using UnityEngine;

namespace RLD
{
	// Token: 0x0200003B RID: 59
	public abstract class GizmoDragSession : IGizmoDragSession
	{
		// Token: 0x1700008D RID: 141
		// (get) Token: 0x060001FF RID: 511 RVA: 0x00016330 File Offset: 0x00014530
		public int NumTargetTransforms
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x06000200 RID: 512 RVA: 0x0001E48C File Offset: 0x0001C68C
		public Vector3 TotalDragOffset
		{
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x06000201 RID: 513 RVA: 0x0001E4A4 File Offset: 0x0001C6A4
		public Quaternion TotalDragRotation
		{
			get
			{
				return default(Quaternion);
			}
		}

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x06000202 RID: 514 RVA: 0x0001E4BC File Offset: 0x0001C6BC
		public Vector3 TotalDragScale
		{
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x06000203 RID: 515 RVA: 0x0001E4D4 File Offset: 0x0001C6D4
		public Vector3 RelativeDragOffset
		{
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x06000204 RID: 516 RVA: 0x0001E4EC File Offset: 0x0001C6EC
		public Quaternion RelativeDragRotation
		{
			get
			{
				return default(Quaternion);
			}
		}

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x06000205 RID: 517 RVA: 0x0001E504 File Offset: 0x0001C704
		public Vector3 RelativeDragScale
		{
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x06000206 RID: 518
		public abstract bool IsActive { get; }

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x06000207 RID: 519
		public abstract GizmoDragChannel DragChannel { get; }

		// Token: 0x06000208 RID: 520 RVA: 0x00016333 File Offset: 0x00014533
		public bool ContainsTargetTransform(GizmoTransform transform)
		{
			return false;
		}

		// Token: 0x06000209 RID: 521 RVA: 0x00016336 File Offset: 0x00014536
		public void AddTargetTransform(GizmoTransform transform)
		{
		}

		// Token: 0x0600020A RID: 522 RVA: 0x00016338 File Offset: 0x00014538
		public void RemoveTargetTransform(GizmoTransform transform)
		{
		}

		// Token: 0x0600020B RID: 523 RVA: 0x0001633A File Offset: 0x0001453A
		public bool Begin()
		{
			return false;
		}

		// Token: 0x0600020C RID: 524 RVA: 0x0001633D File Offset: 0x0001453D
		public bool Update()
		{
			return false;
		}

		// Token: 0x0600020D RID: 525 RVA: 0x00016340 File Offset: 0x00014540
		public void End()
		{
		}

		// Token: 0x0600020E RID: 526
		protected abstract bool DoBeginSession();

		// Token: 0x0600020F RID: 527
		protected abstract bool DoUpdateSession();

		// Token: 0x06000210 RID: 528
		protected abstract void DoEndSession();

		// Token: 0x06000211 RID: 529
		protected abstract void CalculateDragValues();

		// Token: 0x06000212 RID: 530 RVA: 0x00016342 File Offset: 0x00014542
		protected void ApplyDrag()
		{
		}

		// Token: 0x06000213 RID: 531 RVA: 0x00016344 File Offset: 0x00014544
		protected virtual bool CanBegin()
		{
			return false;
		}

		// Token: 0x06000214 RID: 532 RVA: 0x00016347 File Offset: 0x00014547
		protected virtual void OnSessionBegin()
		{
		}

		// Token: 0x06000215 RID: 533 RVA: 0x00016349 File Offset: 0x00014549
		protected virtual void OnSessionEnd()
		{
		}

		// Token: 0x040000ED RID: 237
		private List<GizmoTransform> _targetTransforms;

		// Token: 0x040000EE RID: 238
		protected Vector3 _totalDragOffset;

		// Token: 0x040000EF RID: 239
		protected Quaternion _totalDragRotation;

		// Token: 0x040000F0 RID: 240
		protected Vector3 _totalDragScale;

		// Token: 0x040000F1 RID: 241
		protected Vector3 _relativeDragOffset;

		// Token: 0x040000F2 RID: 242
		protected Quaternion _relativeDragRotation;

		// Token: 0x040000F3 RID: 243
		protected Vector3 _relativeDragScale;
	}
}
