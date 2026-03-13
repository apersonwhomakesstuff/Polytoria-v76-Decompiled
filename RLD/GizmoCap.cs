using System;
using UnityEngine;

namespace RLD
{
	// Token: 0x02000022 RID: 34
	public abstract class GizmoCap : IGizmoCap
	{
		// Token: 0x17000040 RID: 64
		// (get) Token: 0x06000135 RID: 309 RVA: 0x00016195 File Offset: 0x00014395
		protected GizmoHandle Handle
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x06000136 RID: 310 RVA: 0x00016198 File Offset: 0x00014398
		public Gizmo Gizmo
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x06000137 RID: 311 RVA: 0x0001619B File Offset: 0x0001439B
		public int HandleId
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x06000138 RID: 312 RVA: 0x0001619E File Offset: 0x0001439E
		public bool IsVisible
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x06000139 RID: 313 RVA: 0x000161A1 File Offset: 0x000143A1
		public bool IsHoverable
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x0600013A RID: 314 RVA: 0x000161A4 File Offset: 0x000143A4
		public bool IsHovered
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x0600013B RID: 315 RVA: 0x000161A7 File Offset: 0x000143A7
		public Priority HoverPriority3D
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x0600013C RID: 316 RVA: 0x000161AA File Offset: 0x000143AA
		public Priority HoverPriority2D
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x0600013D RID: 317 RVA: 0x000161AD File Offset: 0x000143AD
		public Priority GenericHoverPriority
		{
			get
			{
				return null;
			}
		}

		// Token: 0x0600013E RID: 318 RVA: 0x000161B0 File Offset: 0x000143B0
		public GizmoCap(Gizmo gizmo, int handleId)
		{
		}

		// Token: 0x0600013F RID: 319 RVA: 0x000161B8 File Offset: 0x000143B8
		public void SetVisible(bool isVisible)
		{
		}

		// Token: 0x06000140 RID: 320 RVA: 0x000161BA File Offset: 0x000143BA
		public void SetHoverable(bool isHoverable)
		{
		}

		// Token: 0x06000141 RID: 321
		public abstract void Render(Camera camera);

		// Token: 0x06000142 RID: 322
		protected abstract void OnVisibilityStateChanged();

		// Token: 0x06000143 RID: 323
		protected abstract void OnHoverableStateChanged();

		// Token: 0x0400007B RID: 123
		private Gizmo _gizmo;

		// Token: 0x0400007C RID: 124
		private GizmoHandle _handle;

		// Token: 0x0400007D RID: 125
		private bool _isVisible;

		// Token: 0x0400007E RID: 126
		private bool _isHoverable;
	}
}
