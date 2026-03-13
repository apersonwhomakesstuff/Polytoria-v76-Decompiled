using System;
using UnityEngine;

namespace RLD
{
	// Token: 0x020001E6 RID: 486
	public class SegmentShape2D : Shape2D
	{
		// Token: 0x170007B4 RID: 1972
		// (get) Token: 0x060016AE RID: 5806 RVA: 0x00019BE9 File Offset: 0x00017DE9
		// (set) Token: 0x060016AF RID: 5807 RVA: 0x00019BF0 File Offset: 0x00017DF0
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

		// Token: 0x170007B5 RID: 1973
		// (get) Token: 0x060016B0 RID: 5808 RVA: 0x000231D4 File Offset: 0x000213D4
		// (set) Token: 0x060016B1 RID: 5809 RVA: 0x00019BF2 File Offset: 0x00017DF2
		public Vector2 StartPoint
		{
			get
			{
				return default(Vector2);
			}
			set
			{
			}
		}

		// Token: 0x170007B6 RID: 1974
		// (get) Token: 0x060016B2 RID: 5810 RVA: 0x000231EC File Offset: 0x000213EC
		// (set) Token: 0x060016B3 RID: 5811 RVA: 0x00019BF4 File Offset: 0x00017DF4
		public Vector2 EndPoint
		{
			get
			{
				return default(Vector2);
			}
			set
			{
			}
		}

		// Token: 0x170007B7 RID: 1975
		// (get) Token: 0x060016B4 RID: 5812 RVA: 0x00023204 File Offset: 0x00021404
		// (set) Token: 0x060016B5 RID: 5813 RVA: 0x00019BF6 File Offset: 0x00017DF6
		public Vector2 Direction
		{
			get
			{
				return default(Vector2);
			}
			set
			{
			}
		}

		// Token: 0x170007B8 RID: 1976
		// (get) Token: 0x060016B6 RID: 5814 RVA: 0x0002321C File Offset: 0x0002141C
		// (set) Token: 0x060016B7 RID: 5815 RVA: 0x00019BF8 File Offset: 0x00017DF8
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

		// Token: 0x170007B9 RID: 1977
		// (get) Token: 0x060016B8 RID: 5816 RVA: 0x00019BFA File Offset: 0x00017DFA
		// (set) Token: 0x060016B9 RID: 5817 RVA: 0x00019C01 File Offset: 0x00017E01
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

		// Token: 0x170007BA RID: 1978
		// (get) Token: 0x060016BA RID: 5818 RVA: 0x00019C03 File Offset: 0x00017E03
		// (set) Token: 0x060016BB RID: 5819 RVA: 0x00019C0A File Offset: 0x00017E0A
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

		// Token: 0x060016BC RID: 5820 RVA: 0x00019C0C File Offset: 0x00017E0C
		public void SetEndPtFromStart(Vector2 dirDromStart, float offset)
		{
		}

		// Token: 0x060016BD RID: 5821 RVA: 0x00019C0E File Offset: 0x00017E0E
		public override void RenderBorder(Camera camera)
		{
		}

		// Token: 0x060016BE RID: 5822 RVA: 0x00019C10 File Offset: 0x00017E10
		public override void RenderArea(Camera camera)
		{
		}

		// Token: 0x060016BF RID: 5823 RVA: 0x00019C12 File Offset: 0x00017E12
		public override bool ContainsPoint(Vector2 point)
		{
			return false;
		}

		// Token: 0x060016C0 RID: 5824 RVA: 0x00023234 File Offset: 0x00021434
		public override Rect GetEncapsulatingRect()
		{
			return default(Rect);
		}

		// Token: 0x040007EA RID: 2026
		private Vector2 _startPoint;

		// Token: 0x040007EB RID: 2027
		private Vector2 _endPoint;

		// Token: 0x040007EC RID: 2028
		private Vector2 _direction;

		// Token: 0x040007ED RID: 2029
		private float _length;

		// Token: 0x040007EE RID: 2030
		private SegmentEpsilon _epsilon;
	}
}
