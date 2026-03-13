using System;
using UnityEngine;

namespace RLD
{
	// Token: 0x020000F8 RID: 248
	[Serializable]
	public class CameraBackgroundSettings : Settings
	{
		// Token: 0x170004AE RID: 1198
		// (get) Token: 0x06000DB6 RID: 3510 RVA: 0x0002040C File Offset: 0x0001E60C
		// (set) Token: 0x06000DB7 RID: 3511 RVA: 0x0001835D File Offset: 0x0001655D
		public Color FirstColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		// Token: 0x170004AF RID: 1199
		// (get) Token: 0x06000DB8 RID: 3512 RVA: 0x00020424 File Offset: 0x0001E624
		// (set) Token: 0x06000DB9 RID: 3513 RVA: 0x0001835F File Offset: 0x0001655F
		public Color SecondColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		// Token: 0x170004B0 RID: 1200
		// (get) Token: 0x06000DBA RID: 3514 RVA: 0x00018361 File Offset: 0x00016561
		// (set) Token: 0x06000DBB RID: 3515 RVA: 0x00018368 File Offset: 0x00016568
		public float GradientOffset
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x170004B1 RID: 1201
		// (get) Token: 0x06000DBC RID: 3516 RVA: 0x0001836A File Offset: 0x0001656A
		// (set) Token: 0x06000DBD RID: 3517 RVA: 0x0001836D File Offset: 0x0001656D
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

		// Token: 0x040004B8 RID: 1208
		private Color _firstColor;

		// Token: 0x040004B9 RID: 1209
		private Color _secondColor;

		// Token: 0x040004BA RID: 1210
		private float _gradientOffset;

		// Token: 0x040004BB RID: 1211
		private bool _isVisible;
	}
}
