using System;
using System.Collections.Generic;
using UnityEngine;

namespace RLD
{
	// Token: 0x02000018 RID: 24
	public class GizmoCap3DCollection
	{
		// Token: 0x17000023 RID: 35
		// (get) Token: 0x060000D2 RID: 210 RVA: 0x00016045 File Offset: 0x00014245
		public int Count
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x060000D3 RID: 211 RVA: 0x00016048 File Offset: 0x00014248
		public GizmoCap3D Item
		{
			get
			{
				return null;
			}
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x0001604B File Offset: 0x0001424B
		public bool Contains(GizmoCap3D cap)
		{
			return false;
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x0001604E File Offset: 0x0001424E
		public bool Contains(int capHandleId)
		{
			return false;
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x00016051 File Offset: 0x00014251
		public void Add(GizmoCap3D cap)
		{
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x00016053 File Offset: 0x00014253
		public void Remove(GizmoCap3D cap)
		{
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x00016055 File Offset: 0x00014255
		public void ApplyZoomFactor(Camera camera)
		{
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x00016057 File Offset: 0x00014257
		public void SetZoomFactorTransform(GizmoTransform zoomFactorTransform)
		{
		}

		// Token: 0x060000DA RID: 218 RVA: 0x00016059 File Offset: 0x00014259
		public void Make3DHoverPriorityLowerThan(Priority priority)
		{
		}

		// Token: 0x060000DB RID: 219 RVA: 0x0001605B File Offset: 0x0001425B
		public void Make3DHoverPriorityHigherThan(Priority priority)
		{
		}

		// Token: 0x060000DC RID: 220 RVA: 0x0001605D File Offset: 0x0001425D
		public void SetVisible(bool visible)
		{
		}

		// Token: 0x060000DD RID: 221 RVA: 0x0001605F File Offset: 0x0001425F
		public List<GizmoCap3D> GetRenderSortedCaps(Camera renderCamera)
		{
			return null;
		}

		// Token: 0x0400004F RID: 79
		private List<GizmoCap3D> _caps;

		// Token: 0x04000050 RID: 80
		private Dictionary<int, GizmoCap3D> _handleIdToCap;

		// Token: 0x0200034E RID: 846
		private sealed class <>c__DisplayClass15_0
		{
			// Token: 0x06002A29 RID: 10793 RVA: 0x0001D11D File Offset: 0x0001B31D
			internal int <GetRenderSortedCaps>b__0(GizmoCap3D c0, GizmoCap3D c1)
			{
				return 0;
			}

			// Token: 0x04000E9D RID: 3741
			public Vector3 cameraPos;
		}
	}
}
