using System;
using UnityEngine;

namespace RLD
{
	// Token: 0x020001B2 RID: 434
	[Serializable]
	public class XZGridSettings : Settings
	{
		// Token: 0x17000638 RID: 1592
		// (get) Token: 0x06001326 RID: 4902 RVA: 0x000192E7 File Offset: 0x000174E7
		// (set) Token: 0x06001327 RID: 4903 RVA: 0x000192EA File Offset: 0x000174EA
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

		// Token: 0x17000639 RID: 1593
		// (get) Token: 0x06001328 RID: 4904 RVA: 0x000192EC File Offset: 0x000174EC
		// (set) Token: 0x06001329 RID: 4905 RVA: 0x000192F3 File Offset: 0x000174F3
		public float CellSizeX
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x1700063A RID: 1594
		// (get) Token: 0x0600132A RID: 4906 RVA: 0x000192F5 File Offset: 0x000174F5
		// (set) Token: 0x0600132B RID: 4907 RVA: 0x000192FC File Offset: 0x000174FC
		public float CellSizeZ
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x1700063B RID: 1595
		// (get) Token: 0x0600132C RID: 4908 RVA: 0x00021BCC File Offset: 0x0001FDCC
		// (set) Token: 0x0600132D RID: 4909 RVA: 0x000192FE File Offset: 0x000174FE
		public Vector3 RotationAngles
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		// Token: 0x1700063C RID: 1596
		// (get) Token: 0x0600132E RID: 4910 RVA: 0x00019300 File Offset: 0x00017500
		// (set) Token: 0x0600132F RID: 4911 RVA: 0x00019307 File Offset: 0x00017507
		public float YOffset
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x1700063D RID: 1597
		// (get) Token: 0x06001330 RID: 4912 RVA: 0x00019309 File Offset: 0x00017509
		// (set) Token: 0x06001331 RID: 4913 RVA: 0x00019310 File Offset: 0x00017510
		public float UpDownStep
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x040006DA RID: 1754
		private bool _isVisible;

		// Token: 0x040006DB RID: 1755
		private float _cellSizeX;

		// Token: 0x040006DC RID: 1756
		private float _cellSizeZ;

		// Token: 0x040006DD RID: 1757
		private float _yOffset;

		// Token: 0x040006DE RID: 1758
		private Vector3 _rotationAngles;

		// Token: 0x040006DF RID: 1759
		private float _upDownStep;
	}
}
