using System;
using UnityEngine;

namespace RLD
{
	// Token: 0x02000073 RID: 115
	[Serializable]
	public class GizmoScaleGuideLookAndFeel
	{
		// Token: 0x17000183 RID: 387
		// (get) Token: 0x060004F1 RID: 1265 RVA: 0x0001698D File Offset: 0x00014B8D
		// (set) Token: 0x060004F2 RID: 1266 RVA: 0x00016990 File Offset: 0x00014B90
		public bool UseZoomFactor
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x17000184 RID: 388
		// (get) Token: 0x060004F3 RID: 1267 RVA: 0x0001E99C File Offset: 0x0001CB9C
		// (set) Token: 0x060004F4 RID: 1268 RVA: 0x00016992 File Offset: 0x00014B92
		public Color XAxisColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		// Token: 0x17000185 RID: 389
		// (get) Token: 0x060004F5 RID: 1269 RVA: 0x0001E9B4 File Offset: 0x0001CBB4
		// (set) Token: 0x060004F6 RID: 1270 RVA: 0x00016994 File Offset: 0x00014B94
		public Color YAxisColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		// Token: 0x17000186 RID: 390
		// (get) Token: 0x060004F7 RID: 1271 RVA: 0x0001E9CC File Offset: 0x0001CBCC
		// (set) Token: 0x060004F8 RID: 1272 RVA: 0x00016996 File Offset: 0x00014B96
		public Color ZAxisColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		// Token: 0x17000187 RID: 391
		// (get) Token: 0x060004F9 RID: 1273 RVA: 0x00016998 File Offset: 0x00014B98
		// (set) Token: 0x060004FA RID: 1274 RVA: 0x0001699F File Offset: 0x00014B9F
		public float AxisLength
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x04000197 RID: 407
		private bool _useZoomFactor;

		// Token: 0x04000198 RID: 408
		private Color _xAxisColor;

		// Token: 0x04000199 RID: 409
		private Color _yAxisColor;

		// Token: 0x0400019A RID: 410
		private Color _zAxisColor;

		// Token: 0x0400019B RID: 411
		private float _axisLength;
	}
}
