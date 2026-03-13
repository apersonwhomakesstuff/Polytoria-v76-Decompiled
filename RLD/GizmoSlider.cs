using System;
using UnityEngine;

namespace RLD
{
	// Token: 0x020000D7 RID: 215
	public abstract class GizmoSlider : IGizmoSlider
	{
		// Token: 0x170002D7 RID: 727
		// (get) Token: 0x060008EC RID: 2284 RVA: 0x0001756D File Offset: 0x0001576D
		protected GizmoHandle Handle
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170002D8 RID: 728
		// (get) Token: 0x060008ED RID: 2285 RVA: 0x00017570 File Offset: 0x00015770
		public Gizmo Gizmo
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170002D9 RID: 729
		// (get) Token: 0x060008EE RID: 2286 RVA: 0x00017573 File Offset: 0x00015773
		public int HandleId
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x170002DA RID: 730
		// (get) Token: 0x060008EF RID: 2287 RVA: 0x00017576 File Offset: 0x00015776
		public bool IsVisible
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170002DB RID: 731
		// (get) Token: 0x060008F0 RID: 2288 RVA: 0x00017579 File Offset: 0x00015779
		public bool IsHoverable
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170002DC RID: 732
		// (get) Token: 0x060008F1 RID: 2289 RVA: 0x0001757C File Offset: 0x0001577C
		public bool IsHovered
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170002DD RID: 733
		// (get) Token: 0x060008F2 RID: 2290 RVA: 0x0001757F File Offset: 0x0001577F
		public Priority HoverPriority3D
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170002DE RID: 734
		// (get) Token: 0x060008F3 RID: 2291 RVA: 0x00017582 File Offset: 0x00015782
		public Priority HoverPriority2D
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170002DF RID: 735
		// (get) Token: 0x060008F4 RID: 2292 RVA: 0x00017585 File Offset: 0x00015785
		public Priority GenericHoverPriority
		{
			get
			{
				return null;
			}
		}

		// Token: 0x060008F5 RID: 2293 RVA: 0x00017588 File Offset: 0x00015788
		public GizmoSlider(Gizmo gizmo, int handleId)
		{
		}

		// Token: 0x060008F6 RID: 2294 RVA: 0x00017590 File Offset: 0x00015790
		public void SetVisible(bool isVisible)
		{
		}

		// Token: 0x060008F7 RID: 2295 RVA: 0x00017592 File Offset: 0x00015792
		public void SetHoverable(bool isHoverable)
		{
		}

		// Token: 0x060008F8 RID: 2296
		public abstract void SetSnapEnabled(bool isEnabled);

		// Token: 0x060008F9 RID: 2297
		public abstract void Render(Camera camera);

		// Token: 0x060008FA RID: 2298
		protected abstract void OnVisibilityStateChanged();

		// Token: 0x060008FB RID: 2299
		protected abstract void OnHoverableStateChanged();

		// Token: 0x040003AE RID: 942
		private GizmoHandle _handle;

		// Token: 0x040003AF RID: 943
		private Gizmo _gizmo;

		// Token: 0x040003B0 RID: 944
		private bool _isVisible;

		// Token: 0x040003B1 RID: 945
		private bool _isHoverable;
	}
}
