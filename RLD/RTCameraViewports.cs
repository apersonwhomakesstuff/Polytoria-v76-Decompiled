using System;
using System.Collections.Generic;
using UnityEngine;

namespace RLD
{
	// Token: 0x02000111 RID: 273
	public class RTCameraViewports : Singleton<RTCameraViewports>
	{
		// Token: 0x1400001A RID: 26
		// (add) Token: 0x06000E76 RID: 3702 RVA: 0x000185AE File Offset: 0x000167AE
		// (remove) Token: 0x06000E77 RID: 3703 RVA: 0x000185B0 File Offset: 0x000167B0
		public event RTCameraViewports.CameraAddedHandler CameraAdded
		{
			add
			{
			}
			remove
			{
			}
		}

		// Token: 0x1400001B RID: 27
		// (add) Token: 0x06000E78 RID: 3704 RVA: 0x000185B2 File Offset: 0x000167B2
		// (remove) Token: 0x06000E79 RID: 3705 RVA: 0x000185B4 File Offset: 0x000167B4
		public event RTCameraViewports.CameraRemovedHandler CameraRemoved
		{
			add
			{
			}
			remove
			{
			}
		}

		// Token: 0x1400001C RID: 28
		// (add) Token: 0x06000E7A RID: 3706 RVA: 0x000185B6 File Offset: 0x000167B6
		// (remove) Token: 0x06000E7B RID: 3707 RVA: 0x000185B8 File Offset: 0x000167B8
		public event RTCameraViewports.FocusCameraChangedHandler FocusCameraChanged
		{
			add
			{
			}
			remove
			{
			}
		}

		// Token: 0x17000505 RID: 1285
		// (get) Token: 0x06000E7C RID: 3708 RVA: 0x000185BA File Offset: 0x000167BA
		public Camera FocusCamera
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000506 RID: 1286
		// (get) Token: 0x06000E7D RID: 3709 RVA: 0x000185BD File Offset: 0x000167BD
		public int NumCameras
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x06000E7E RID: 3710 RVA: 0x000185C0 File Offset: 0x000167C0
		public bool ContainsCamera(Camera camera)
		{
			return false;
		}

		// Token: 0x06000E7F RID: 3711 RVA: 0x000185C3 File Offset: 0x000167C3
		public void AddCamera(Camera camera, Rect normViewRect)
		{
		}

		// Token: 0x06000E80 RID: 3712 RVA: 0x000185C5 File Offset: 0x000167C5
		public void AddCamera(Camera camera)
		{
		}

		// Token: 0x06000E81 RID: 3713 RVA: 0x000185C7 File Offset: 0x000167C7
		public void RemoveCamera(Camera camera)
		{
		}

		// Token: 0x06000E82 RID: 3714 RVA: 0x000185C9 File Offset: 0x000167C9
		public void SetFocusCamera(int cameraIndex)
		{
		}

		// Token: 0x06000E83 RID: 3715 RVA: 0x000185CB File Offset: 0x000167CB
		public void SetFocusCamera(Camera camera)
		{
		}

		// Token: 0x04000524 RID: 1316
		private List<Camera> _cameras;

		// Token: 0x02000379 RID: 889
		// (Invoke) Token: 0x06002A68 RID: 10856
		public delegate void CameraAddedHandler(Camera camera);

		// Token: 0x0200037A RID: 890
		// (Invoke) Token: 0x06002A6C RID: 10860
		public delegate void CameraRemovedHandler(Camera camera);

		// Token: 0x0200037B RID: 891
		// (Invoke) Token: 0x06002A70 RID: 10864
		public delegate void FocusCameraChangedHandler(Camera oldFocusCam, Camera newFocusCam);
	}
}
