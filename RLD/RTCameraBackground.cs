using System;
using System.Collections.Generic;
using UnityEngine;

namespace RLD
{
	// Token: 0x02000110 RID: 272
	public class RTCameraBackground : MonoSingleton<RTCameraBackground>
	{
		// Token: 0x17000504 RID: 1284
		// (get) Token: 0x06000E6E RID: 3694 RVA: 0x00018595 File Offset: 0x00016795
		public CameraBackgroundSettings Settings
		{
			get
			{
				return null;
			}
		}

		// Token: 0x06000E6F RID: 3695 RVA: 0x00018598 File Offset: 0x00016798
		public void SetCameraBkSettings(Camera camera, CameraBackgroundSettings bkSettings)
		{
		}

		// Token: 0x06000E70 RID: 3696 RVA: 0x0001859A File Offset: 0x0001679A
		public List<Camera> GetAllRenderIgnoreCameras()
		{
			return null;
		}

		// Token: 0x06000E71 RID: 3697 RVA: 0x0001859D File Offset: 0x0001679D
		public bool IsRenderIgnoreCamera(Camera camera)
		{
			return false;
		}

		// Token: 0x06000E72 RID: 3698 RVA: 0x000185A0 File Offset: 0x000167A0
		public void AddRenderIgnoreCamera(Camera camera)
		{
		}

		// Token: 0x06000E73 RID: 3699 RVA: 0x000185A2 File Offset: 0x000167A2
		public void RemoveRenderIgnoreCamera(Camera camera)
		{
		}

		// Token: 0x06000E74 RID: 3700 RVA: 0x000185A4 File Offset: 0x000167A4
		public void Render_SystemCall(Camera renderCamera)
		{
		}

		// Token: 0x0400051E RID: 1310
		private CameraBackgroundSettings _bkSettings;

		// Token: 0x0400051F RID: 1311
		private List<Camera> _renderIgnoreCameras;

		// Token: 0x04000520 RID: 1312
		private Dictionary<Camera, CameraBackgroundSettings> _cameraToBkSettings;
	}
}
