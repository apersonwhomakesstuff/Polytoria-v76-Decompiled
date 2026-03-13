using System;

namespace RLD
{
	// Token: 0x02000063 RID: 99
	public class GizmoHandleShape2D
	{
		// Token: 0x17000134 RID: 308
		// (get) Token: 0x060003DE RID: 990 RVA: 0x0001673B File Offset: 0x0001493B
		public Shape2D Shape
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000135 RID: 309
		// (get) Token: 0x060003DF RID: 991 RVA: 0x0001673E File Offset: 0x0001493E
		// (set) Token: 0x060003E0 RID: 992 RVA: 0x00016741 File Offset: 0x00014941
		public bool IsVisible
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x17000136 RID: 310
		// (get) Token: 0x060003E1 RID: 993 RVA: 0x00016743 File Offset: 0x00014943
		// (set) Token: 0x060003E2 RID: 994 RVA: 0x00016746 File Offset: 0x00014946
		public bool IsHoverable
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x060003E3 RID: 995 RVA: 0x00016748 File Offset: 0x00014948
		public GizmoHandleShape2D(Shape2D shape)
		{
		}

		// Token: 0x0400015B RID: 347
		private bool _isVisible;

		// Token: 0x0400015C RID: 348
		private bool _isHoverable;

		// Token: 0x0400015D RID: 349
		private Shape2D _shape;
	}
}
