using System;

namespace RLD
{
	// Token: 0x02000064 RID: 100
	public class GizmoHandleShape3D
	{
		// Token: 0x17000137 RID: 311
		// (get) Token: 0x060003E4 RID: 996 RVA: 0x00016750 File Offset: 0x00014950
		public Shape3D Shape
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000138 RID: 312
		// (get) Token: 0x060003E5 RID: 997 RVA: 0x00016753 File Offset: 0x00014953
		// (set) Token: 0x060003E6 RID: 998 RVA: 0x00016756 File Offset: 0x00014956
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

		// Token: 0x17000139 RID: 313
		// (get) Token: 0x060003E7 RID: 999 RVA: 0x00016758 File Offset: 0x00014958
		// (set) Token: 0x060003E8 RID: 1000 RVA: 0x0001675B File Offset: 0x0001495B
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

		// Token: 0x060003E9 RID: 1001 RVA: 0x0001675D File Offset: 0x0001495D
		public GizmoHandleShape3D(Shape3D shape)
		{
		}

		// Token: 0x0400015E RID: 350
		private bool _isVisible;

		// Token: 0x0400015F RID: 351
		private bool _isHoverable;

		// Token: 0x04000160 RID: 352
		private Shape3D _shape;
	}
}
