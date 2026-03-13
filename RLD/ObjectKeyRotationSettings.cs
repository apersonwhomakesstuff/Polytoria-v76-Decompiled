using System;

namespace RLD
{
	// Token: 0x02000190 RID: 400
	[Serializable]
	public class ObjectKeyRotationSettings : Settings
	{
		// Token: 0x170005C0 RID: 1472
		// (get) Token: 0x060011DE RID: 4574 RVA: 0x00018F6E File Offset: 0x0001716E
		// (set) Token: 0x060011DF RID: 4575 RVA: 0x00018F75 File Offset: 0x00017175
		public float XRotationStep
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x170005C1 RID: 1473
		// (get) Token: 0x060011E0 RID: 4576 RVA: 0x00018F77 File Offset: 0x00017177
		// (set) Token: 0x060011E1 RID: 4577 RVA: 0x00018F7E File Offset: 0x0001717E
		public float YRotationStep
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x170005C2 RID: 1474
		// (get) Token: 0x060011E2 RID: 4578 RVA: 0x00018F80 File Offset: 0x00017180
		// (set) Token: 0x060011E3 RID: 4579 RVA: 0x00018F87 File Offset: 0x00017187
		public float ZRotationStep
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x04000654 RID: 1620
		private float _xRotationStep;

		// Token: 0x04000655 RID: 1621
		private float _yRotationStep;

		// Token: 0x04000656 RID: 1622
		private float _zRotationStep;
	}
}
