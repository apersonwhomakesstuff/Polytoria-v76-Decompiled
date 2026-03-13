using System;
using UnityEngine;

namespace RLD
{
	// Token: 0x020000F9 RID: 249
	public static class CameraFocus
	{
		// Token: 0x06000DBF RID: 3519 RVA: 0x00018377 File Offset: 0x00016577
		public static CameraFocus.Data CalculateFocusData(Camera camera, AABB focusAABB, CameraFocusSettings focusSettings)
		{
			return null;
		}

		// Token: 0x02000374 RID: 884
		public class Data
		{
			// Token: 0x17000C7E RID: 3198
			// (get) Token: 0x06002A5D RID: 10845 RVA: 0x000267A8 File Offset: 0x000249A8
			public Vector3 CameraWorldPosition
			{
				get
				{
					return default(Vector3);
				}
			}

			// Token: 0x17000C7F RID: 3199
			// (get) Token: 0x06002A5E RID: 10846 RVA: 0x000267C0 File Offset: 0x000249C0
			public Vector3 FocusPoint
			{
				get
				{
					return default(Vector3);
				}
			}

			// Token: 0x17000C80 RID: 3200
			// (get) Token: 0x06002A5F RID: 10847 RVA: 0x0001D210 File Offset: 0x0001B410
			public float FocusPointOffset
			{
				get
				{
					return 0f;
				}
			}

			// Token: 0x06002A60 RID: 10848 RVA: 0x0001D217 File Offset: 0x0001B417
			public Data(Vector3 cameraWorldPosition, Vector3 focusPoint)
			{
			}

			// Token: 0x04000F01 RID: 3841
			private Vector3 _cameraWorldPosition;

			// Token: 0x04000F02 RID: 3842
			private Vector3 _focusPoint;

			// Token: 0x04000F03 RID: 3843
			private float _focusPointOffset;
		}
	}
}
