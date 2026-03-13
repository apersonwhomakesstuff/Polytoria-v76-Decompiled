using System;
using UnityEngine;

namespace RLD
{
	// Token: 0x020001C9 RID: 457
	[Serializable]
	public class ObjectGrabLookAndFeel : Settings
	{
		// Token: 0x1700067A RID: 1658
		// (get) Token: 0x060013E0 RID: 5088 RVA: 0x0001950A File Offset: 0x0001770A
		// (set) Token: 0x060013E1 RID: 5089 RVA: 0x0001950D File Offset: 0x0001770D
		public bool DrawAnchorLines
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x1700067B RID: 1659
		// (get) Token: 0x060013E2 RID: 5090 RVA: 0x00021D1C File Offset: 0x0001FF1C
		// (set) Token: 0x060013E3 RID: 5091 RVA: 0x0001950F File Offset: 0x0001770F
		public Color AnchorLineColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		// Token: 0x1700067C RID: 1660
		// (get) Token: 0x060013E4 RID: 5092 RVA: 0x00019511 File Offset: 0x00017711
		// (set) Token: 0x060013E5 RID: 5093 RVA: 0x00019514 File Offset: 0x00017714
		public bool DrawObjectPosTicks
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x1700067D RID: 1661
		// (get) Token: 0x060013E6 RID: 5094 RVA: 0x00019516 File Offset: 0x00017716
		// (set) Token: 0x060013E7 RID: 5095 RVA: 0x00019519 File Offset: 0x00017719
		public bool DrawAnchorPosTick
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x1700067E RID: 1662
		// (get) Token: 0x060013E8 RID: 5096 RVA: 0x00021D34 File Offset: 0x0001FF34
		// (set) Token: 0x060013E9 RID: 5097 RVA: 0x0001951B File Offset: 0x0001771B
		public Color ObjectPosTickColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		// Token: 0x1700067F RID: 1663
		// (get) Token: 0x060013EA RID: 5098 RVA: 0x0001951D File Offset: 0x0001771D
		// (set) Token: 0x060013EB RID: 5099 RVA: 0x00019524 File Offset: 0x00017724
		public float ObjectPosTickSize
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x17000680 RID: 1664
		// (get) Token: 0x060013EC RID: 5100 RVA: 0x00021D4C File Offset: 0x0001FF4C
		// (set) Token: 0x060013ED RID: 5101 RVA: 0x00019526 File Offset: 0x00017726
		public Color AnchorPosTickColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		// Token: 0x17000681 RID: 1665
		// (get) Token: 0x060013EE RID: 5102 RVA: 0x00019528 File Offset: 0x00017728
		// (set) Token: 0x060013EF RID: 5103 RVA: 0x0001952F File Offset: 0x0001772F
		public float AnchorPosTickSize
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x17000682 RID: 1666
		// (get) Token: 0x060013F0 RID: 5104 RVA: 0x00019531 File Offset: 0x00017731
		// (set) Token: 0x060013F1 RID: 5105 RVA: 0x00019534 File Offset: 0x00017734
		public bool DrawObjectBoxes
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x17000683 RID: 1667
		// (get) Token: 0x060013F2 RID: 5106 RVA: 0x00021D64 File Offset: 0x0001FF64
		// (set) Token: 0x060013F3 RID: 5107 RVA: 0x00019536 File Offset: 0x00017736
		public Color ObjectBoxWireColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		// Token: 0x04000739 RID: 1849
		private bool _drawAnchorLines;

		// Token: 0x0400073A RID: 1850
		private Color _anchorLineColor;

		// Token: 0x0400073B RID: 1851
		private bool _drawObjectPosTicks;

		// Token: 0x0400073C RID: 1852
		private bool _drawAnchorPosTick;

		// Token: 0x0400073D RID: 1853
		private Color _objectPosTickColor;

		// Token: 0x0400073E RID: 1854
		private Color _anchorPosTickColor;

		// Token: 0x0400073F RID: 1855
		private float _objectPosTickSize;

		// Token: 0x04000740 RID: 1856
		private float _anchorPosTickSize;

		// Token: 0x04000741 RID: 1857
		private bool _drawObjectBoxes;

		// Token: 0x04000742 RID: 1858
		private Color _objectBoxWireColor;
	}
}
