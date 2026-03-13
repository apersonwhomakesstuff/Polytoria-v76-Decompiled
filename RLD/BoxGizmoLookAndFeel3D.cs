using System;
using System.Collections.Generic;
using UnityEngine;

namespace RLD
{
	// Token: 0x02000082 RID: 130
	[Serializable]
	public class BoxGizmoLookAndFeel3D : Settings
	{
		// Token: 0x170001C4 RID: 452
		// (get) Token: 0x0600059A RID: 1434 RVA: 0x0001EC0C File Offset: 0x0001CE0C
		public Color BoxWireColor
		{
			get
			{
				return default(Color);
			}
		}

		// Token: 0x170001C5 RID: 453
		// (get) Token: 0x0600059B RID: 1435 RVA: 0x0001EC24 File Offset: 0x0001CE24
		public Color XTickColor
		{
			get
			{
				return default(Color);
			}
		}

		// Token: 0x170001C6 RID: 454
		// (get) Token: 0x0600059C RID: 1436 RVA: 0x0001EC3C File Offset: 0x0001CE3C
		public Color YTickColor
		{
			get
			{
				return default(Color);
			}
		}

		// Token: 0x170001C7 RID: 455
		// (get) Token: 0x0600059D RID: 1437 RVA: 0x0001EC54 File Offset: 0x0001CE54
		public Color ZTickColor
		{
			get
			{
				return default(Color);
			}
		}

		// Token: 0x170001C8 RID: 456
		// (get) Token: 0x0600059E RID: 1438 RVA: 0x0001EC6C File Offset: 0x0001CE6C
		public Color TickBorderColor
		{
			get
			{
				return default(Color);
			}
		}

		// Token: 0x170001C9 RID: 457
		// (get) Token: 0x0600059F RID: 1439 RVA: 0x0001EC84 File Offset: 0x0001CE84
		public Color TickHoveredColor
		{
			get
			{
				return default(Color);
			}
		}

		// Token: 0x170001CA RID: 458
		// (get) Token: 0x060005A0 RID: 1440 RVA: 0x0001EC9C File Offset: 0x0001CE9C
		public Color TickHoveredBorderColor
		{
			get
			{
				return default(Color);
			}
		}

		// Token: 0x170001CB RID: 459
		// (get) Token: 0x060005A1 RID: 1441 RVA: 0x0001ECB4 File Offset: 0x0001CEB4
		public GizmoCap2DType TickType
		{
			get
			{
				return GizmoCap2DType.Quad;
			}
		}

		// Token: 0x170001CC RID: 460
		// (get) Token: 0x060005A2 RID: 1442 RVA: 0x00016B5D File Offset: 0x00014D5D
		public float TickQuadWidth
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x170001CD RID: 461
		// (get) Token: 0x060005A3 RID: 1443 RVA: 0x00016B64 File Offset: 0x00014D64
		public float TickQuadHeight
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x170001CE RID: 462
		// (get) Token: 0x060005A4 RID: 1444 RVA: 0x00016B6B File Offset: 0x00014D6B
		public float TickCircleRadius
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x060005A6 RID: 1446 RVA: 0x00016B7A File Offset: 0x00014D7A
		public List<Enum> GetAllowedTickTypes()
		{
			return null;
		}

		// Token: 0x060005A7 RID: 1447 RVA: 0x00016B7D File Offset: 0x00014D7D
		public bool IsTickTypeAllowed(GizmoCap2DType tickType)
		{
			return false;
		}

		// Token: 0x060005A8 RID: 1448 RVA: 0x00016B80 File Offset: 0x00014D80
		public void SetBoxWireColor(Color color)
		{
		}

		// Token: 0x060005A9 RID: 1449 RVA: 0x00016B82 File Offset: 0x00014D82
		public void SetAxisTickColor(int axisIndex, Color color)
		{
		}

		// Token: 0x060005AA RID: 1450 RVA: 0x00016B84 File Offset: 0x00014D84
		public void SetTickBorderColor(Color color)
		{
		}

		// Token: 0x060005AB RID: 1451 RVA: 0x00016B86 File Offset: 0x00014D86
		public void SetTickHoveredColor(Color color)
		{
		}

		// Token: 0x060005AC RID: 1452 RVA: 0x00016B88 File Offset: 0x00014D88
		public void SetTickHoveredBorderColor(Color color)
		{
		}

		// Token: 0x060005AD RID: 1453 RVA: 0x00016B8A File Offset: 0x00014D8A
		public void SetTickType(GizmoCap2DType tickType)
		{
		}

		// Token: 0x060005AE RID: 1454 RVA: 0x00016B8C File Offset: 0x00014D8C
		public void SetTickQuadWidth(float width)
		{
		}

		// Token: 0x060005AF RID: 1455 RVA: 0x00016B8E File Offset: 0x00014D8E
		public void SetTickQuadHeight(float height)
		{
		}

		// Token: 0x060005B0 RID: 1456 RVA: 0x00016B90 File Offset: 0x00014D90
		public void SetTickCircleRadius(float radius)
		{
		}

		// Token: 0x060005B1 RID: 1457 RVA: 0x00016B92 File Offset: 0x00014D92
		public void ConnectTickLookAndFeel(GizmoCap2D tick, int axisIndex, AxisSign axisSign)
		{
		}

		// Token: 0x060005B2 RID: 1458 RVA: 0x00016B94 File Offset: 0x00014D94
		private GizmoCap2DLookAndFeel GetTickLookAndFeel(int axisIndex, AxisSign axisSign)
		{
			return null;
		}

		// Token: 0x040001E1 RID: 481
		private Color _boxWireColor;

		// Token: 0x040001E2 RID: 482
		private GizmoCap2DLookAndFeel[] _tickLookAndFeel;
	}
}
