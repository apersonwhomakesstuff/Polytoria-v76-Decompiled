using System;

namespace RLD
{
	// Token: 0x0200008A RID: 138
	[Serializable]
	public class GizmoLineSlider2DSettings
	{
		// Token: 0x170001FB RID: 507
		// (get) Token: 0x06000626 RID: 1574 RVA: 0x00016CE2 File Offset: 0x00014EE2
		// (set) Token: 0x06000627 RID: 1575 RVA: 0x00016CE9 File Offset: 0x00014EE9
		public float LineHoverEps
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x170001FC RID: 508
		// (get) Token: 0x06000628 RID: 1576 RVA: 0x00016CEB File Offset: 0x00014EEB
		// (set) Token: 0x06000629 RID: 1577 RVA: 0x00016CF2 File Offset: 0x00014EF2
		public float BoxHoverEps
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x170001FD RID: 509
		// (get) Token: 0x0600062A RID: 1578 RVA: 0x00016CF4 File Offset: 0x00014EF4
		// (set) Token: 0x0600062B RID: 1579 RVA: 0x00016CFB File Offset: 0x00014EFB
		public float OffsetSnapStep
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x170001FE RID: 510
		// (get) Token: 0x0600062C RID: 1580 RVA: 0x00016CFD File Offset: 0x00014EFD
		// (set) Token: 0x0600062D RID: 1581 RVA: 0x00016D04 File Offset: 0x00014F04
		public float RotationSnapStep
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x170001FF RID: 511
		// (get) Token: 0x0600062E RID: 1582 RVA: 0x0001EE34 File Offset: 0x0001D034
		// (set) Token: 0x0600062F RID: 1583 RVA: 0x00016D06 File Offset: 0x00014F06
		public GizmoSnapMode RotationSnapMode
		{
			get
			{
				return GizmoSnapMode.Relative;
			}
			set
			{
			}
		}

		// Token: 0x17000200 RID: 512
		// (get) Token: 0x06000630 RID: 1584 RVA: 0x00016D08 File Offset: 0x00014F08
		// (set) Token: 0x06000631 RID: 1585 RVA: 0x00016D0F File Offset: 0x00014F0F
		public float ScaleSnapStep
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x17000201 RID: 513
		// (get) Token: 0x06000632 RID: 1586 RVA: 0x00016D11 File Offset: 0x00014F11
		// (set) Token: 0x06000633 RID: 1587 RVA: 0x00016D18 File Offset: 0x00014F18
		public float OffsetSensitivity
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x17000202 RID: 514
		// (get) Token: 0x06000634 RID: 1588 RVA: 0x00016D1A File Offset: 0x00014F1A
		// (set) Token: 0x06000635 RID: 1589 RVA: 0x00016D21 File Offset: 0x00014F21
		public float RotationSensitivity
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x17000203 RID: 515
		// (get) Token: 0x06000636 RID: 1590 RVA: 0x00016D23 File Offset: 0x00014F23
		// (set) Token: 0x06000637 RID: 1591 RVA: 0x00016D2A File Offset: 0x00014F2A
		public float ScaleSensitivity
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x04000216 RID: 534
		private float _lineHoverEps;

		// Token: 0x04000217 RID: 535
		private float _boxHoverEps;

		// Token: 0x04000218 RID: 536
		private float _offsetSnapStep;

		// Token: 0x04000219 RID: 537
		private float _rotationSnapStep;

		// Token: 0x0400021A RID: 538
		private GizmoSnapMode _rotationSnapMode;

		// Token: 0x0400021B RID: 539
		private float _scaleSnapStep;

		// Token: 0x0400021C RID: 540
		private float _offsetSensitivity;

		// Token: 0x0400021D RID: 541
		private float _rotationSensitivity;

		// Token: 0x0400021E RID: 542
		private float _scaleSensitivity;
	}
}
