using System;
using UnityEngine;

namespace RLD
{
	// Token: 0x02000077 RID: 119
	public class RTSceneGizmoCamera : MonoBehaviour
	{
		// Token: 0x1700018C RID: 396
		// (get) Token: 0x06000503 RID: 1283 RVA: 0x000169BA File Offset: 0x00014BBA
		public Camera Camera
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700018D RID: 397
		// (get) Token: 0x06000504 RID: 1284 RVA: 0x000169BD File Offset: 0x00014BBD
		// (set) Token: 0x06000505 RID: 1285 RVA: 0x000169C0 File Offset: 0x00014BC0
		public Camera SceneCamera
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x1700018E RID: 398
		// (get) Token: 0x06000506 RID: 1286 RVA: 0x000169C2 File Offset: 0x00014BC2
		// (set) Token: 0x06000507 RID: 1287 RVA: 0x000169C5 File Offset: 0x00014BC5
		public ISceneGizmoCamViewportUpdater ViewportUpdater
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x1700018F RID: 399
		// (get) Token: 0x06000508 RID: 1288 RVA: 0x0001E9E4 File Offset: 0x0001CBE4
		// (set) Token: 0x06000509 RID: 1289 RVA: 0x000169C7 File Offset: 0x00014BC7
		public Vector3 WorldPosition
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		// Token: 0x17000190 RID: 400
		// (get) Token: 0x0600050A RID: 1290 RVA: 0x0001E9FC File Offset: 0x0001CBFC
		// (set) Token: 0x0600050B RID: 1291 RVA: 0x000169C9 File Offset: 0x00014BC9
		public Quaternion WorldRotation
		{
			get
			{
				return default(Quaternion);
			}
			set
			{
			}
		}

		// Token: 0x17000191 RID: 401
		// (get) Token: 0x0600050C RID: 1292 RVA: 0x0001EA14 File Offset: 0x0001CC14
		public Vector3 Right
		{
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x17000192 RID: 402
		// (get) Token: 0x0600050D RID: 1293 RVA: 0x0001EA2C File Offset: 0x0001CC2C
		public Vector3 Up
		{
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x17000193 RID: 403
		// (get) Token: 0x0600050E RID: 1294 RVA: 0x0001EA44 File Offset: 0x0001CC44
		public Vector3 Look
		{
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x17000194 RID: 404
		// (get) Token: 0x0600050F RID: 1295 RVA: 0x0001EA5C File Offset: 0x0001CC5C
		public Vector3 LookAtPoint
		{
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x06000510 RID: 1296 RVA: 0x000169CB File Offset: 0x00014BCB
		public void Update_SystemCall()
		{
		}

		// Token: 0x06000511 RID: 1297 RVA: 0x000169CD File Offset: 0x00014BCD
		private void Awake()
		{
		}

		// Token: 0x06000512 RID: 1298 RVA: 0x000169CF File Offset: 0x00014BCF
		private void Start()
		{
		}

		// Token: 0x0400019E RID: 414
		private Camera _camera;

		// Token: 0x0400019F RID: 415
		private Transform _transform;

		// Token: 0x040001A0 RID: 416
		private Vector3 _lookAtPoint;

		// Token: 0x040001A1 RID: 417
		private float _fieldOfView;

		// Token: 0x040001A2 RID: 418
		private float _orthoSize;

		// Token: 0x040001A3 RID: 419
		private float _offsetFromFocusPt;

		// Token: 0x040001A4 RID: 420
		private Camera _sceneCamera;

		// Token: 0x040001A5 RID: 421
		private ISceneGizmoCamViewportUpdater _viewportUpdater;
	}
}
