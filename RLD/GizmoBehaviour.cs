using System;
using System.Collections.Generic;
using UnityEngine;

namespace RLD
{
	// Token: 0x02000045 RID: 69
	[Serializable]
	public abstract class GizmoBehaviour : IGizmoBehaviour
	{
		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x06000273 RID: 627 RVA: 0x0001644B File Offset: 0x0001464B
		public Gizmo Gizmo
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x06000274 RID: 628 RVA: 0x0001644E File Offset: 0x0001464E
		public bool IsEnabled
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06000275 RID: 629 RVA: 0x00016451 File Offset: 0x00014651
		public void Init_SystemCall(GizmoBehaviorInitParams initParams)
		{
		}

		// Token: 0x06000276 RID: 630 RVA: 0x00016453 File Offset: 0x00014653
		public void SetEnabled(bool enabled)
		{
		}

		// Token: 0x06000277 RID: 631 RVA: 0x00016455 File Offset: 0x00014655
		public virtual void OnAttached()
		{
		}

		// Token: 0x06000278 RID: 632 RVA: 0x00016457 File Offset: 0x00014657
		public virtual void OnDetached()
		{
		}

		// Token: 0x06000279 RID: 633 RVA: 0x00016459 File Offset: 0x00014659
		public virtual void OnGizmoEnabled()
		{
		}

		// Token: 0x0600027A RID: 634 RVA: 0x0001645B File Offset: 0x0001465B
		public virtual void OnGizmoDisabled()
		{
		}

		// Token: 0x0600027B RID: 635 RVA: 0x0001645D File Offset: 0x0001465D
		public virtual void OnEnabled()
		{
		}

		// Token: 0x0600027C RID: 636 RVA: 0x0001645F File Offset: 0x0001465F
		public virtual void OnDisabled()
		{
		}

		// Token: 0x0600027D RID: 637 RVA: 0x00016461 File Offset: 0x00014661
		public virtual void OnGizmoHandlePicked(int handleId)
		{
		}

		// Token: 0x0600027E RID: 638 RVA: 0x00016463 File Offset: 0x00014663
		public virtual bool OnGizmoCanBeginDrag(int handleId)
		{
			return false;
		}

		// Token: 0x0600027F RID: 639 RVA: 0x00016466 File Offset: 0x00014666
		public virtual void OnGizmoAttemptHandleDragBegin(int handleId)
		{
		}

		// Token: 0x06000280 RID: 640 RVA: 0x00016468 File Offset: 0x00014668
		public virtual void OnGizmoDragBegin(int handleId)
		{
		}

		// Token: 0x06000281 RID: 641 RVA: 0x0001646A File Offset: 0x0001466A
		public virtual void OnGizmoDragUpdate(int handleId)
		{
		}

		// Token: 0x06000282 RID: 642 RVA: 0x0001646C File Offset: 0x0001466C
		public virtual void OnGizmoDragEnd(int handleId)
		{
		}

		// Token: 0x06000283 RID: 643 RVA: 0x0001646E File Offset: 0x0001466E
		public virtual void OnGizmoHoverEnter(int handleId)
		{
		}

		// Token: 0x06000284 RID: 644 RVA: 0x00016470 File Offset: 0x00014670
		public virtual void OnGizmoHoverExit(int handleId)
		{
		}

		// Token: 0x06000285 RID: 645 RVA: 0x00016472 File Offset: 0x00014672
		public virtual void OnGizmoUpdateBegin()
		{
		}

		// Token: 0x06000286 RID: 646 RVA: 0x00016474 File Offset: 0x00014674
		public virtual void OnGizmoUpdateEnd()
		{
		}

		// Token: 0x06000287 RID: 647 RVA: 0x00016476 File Offset: 0x00014676
		public virtual void OnGUI()
		{
		}

		// Token: 0x06000288 RID: 648 RVA: 0x00016478 File Offset: 0x00014678
		public virtual void OnGizmoRender(Camera camera)
		{
		}

		// Token: 0x06000289 RID: 649 RVA: 0x0001647A File Offset: 0x0001467A
		protected void CheckRequiredBehaviours(List<Type> reqBehaviourTypes)
		{
		}

		// Token: 0x0600028A RID: 650 RVA: 0x0001647C File Offset: 0x0001467C
		private void ThrowReqBehaviourExeception(Type reqBehaviorType)
		{
		}

		// Token: 0x04000119 RID: 281
		protected Gizmo _gizmo;

		// Token: 0x0400011A RID: 282
		protected bool _isEnabled;
	}
}
