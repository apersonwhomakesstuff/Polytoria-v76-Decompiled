using System;
using UnityEngine;

namespace RLD
{
	// Token: 0x020001E7 RID: 487
	public class SegmentShape3D : Shape3D
	{
		// Token: 0x170007BB RID: 1979
		// (get) Token: 0x060016C2 RID: 5826 RVA: 0x00019C1D File Offset: 0x00017E1D
		// (set) Token: 0x060016C3 RID: 5827 RVA: 0x00019C24 File Offset: 0x00017E24
		public float Length
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x170007BC RID: 1980
		// (get) Token: 0x060016C4 RID: 5828 RVA: 0x0002324C File Offset: 0x0002144C
		// (set) Token: 0x060016C5 RID: 5829 RVA: 0x00019C26 File Offset: 0x00017E26
		public Vector3 StartPoint
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		// Token: 0x170007BD RID: 1981
		// (get) Token: 0x060016C6 RID: 5830 RVA: 0x00023264 File Offset: 0x00021464
		// (set) Token: 0x060016C7 RID: 5831 RVA: 0x00019C28 File Offset: 0x00017E28
		public Vector3 EndPoint
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		// Token: 0x170007BE RID: 1982
		// (get) Token: 0x060016C8 RID: 5832 RVA: 0x0002327C File Offset: 0x0002147C
		// (set) Token: 0x060016C9 RID: 5833 RVA: 0x00019C2A File Offset: 0x00017E2A
		public Vector3 Direction
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		// Token: 0x170007BF RID: 1983
		// (get) Token: 0x060016CA RID: 5834 RVA: 0x00023294 File Offset: 0x00021494
		// (set) Token: 0x060016CB RID: 5835 RVA: 0x00019C2C File Offset: 0x00017E2C
		public SegmentEpsilon Epsilon
		{
			get
			{
				return default(SegmentEpsilon);
			}
			set
			{
			}
		}

		// Token: 0x170007C0 RID: 1984
		// (get) Token: 0x060016CC RID: 5836 RVA: 0x00019C2E File Offset: 0x00017E2E
		// (set) Token: 0x060016CD RID: 5837 RVA: 0x00019C35 File Offset: 0x00017E35
		public float RaycastEps
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x170007C1 RID: 1985
		// (get) Token: 0x060016CE RID: 5838 RVA: 0x00019C37 File Offset: 0x00017E37
		// (set) Token: 0x060016CF RID: 5839 RVA: 0x00019C3E File Offset: 0x00017E3E
		public float PtOnSegmentEps
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x060016D0 RID: 5840 RVA: 0x00019C40 File Offset: 0x00017E40
		public void SetEndPtFromStart(Vector3 dirDromStart, float offset)
		{
		}

		// Token: 0x060016D1 RID: 5841 RVA: 0x00019C42 File Offset: 0x00017E42
		public override void RenderSolid()
		{
		}

		// Token: 0x060016D2 RID: 5842 RVA: 0x00019C44 File Offset: 0x00017E44
		public override void RenderWire()
		{
		}

		// Token: 0x060016D3 RID: 5843 RVA: 0x00019C46 File Offset: 0x00017E46
		public override bool Raycast(Ray ray, out float t)
		{
			t = 0f;
			return false;
		}

		// Token: 0x060016D4 RID: 5844 RVA: 0x000232AC File Offset: 0x000214AC
		public override AABB GetAABB()
		{
			return default(AABB);
		}

		// Token: 0x040007EF RID: 2031
		private Vector3 _startPoint;

		// Token: 0x040007F0 RID: 2032
		private Vector3 _endPoint;

		// Token: 0x040007F1 RID: 2033
		private Vector3 _direction;

		// Token: 0x040007F2 RID: 2034
		private float _length;

		// Token: 0x040007F3 RID: 2035
		private SegmentEpsilon _epsilon;
	}
}
