using System;
using System.Collections.Generic;
using UnityEngine;

namespace RLD
{
	// Token: 0x020001AD RID: 429
	[Serializable]
	public class RTSceneGrid : MonoSingleton<RTSceneGrid>, IXZGrid
	{
		// Token: 0x1700061E RID: 1566
		// (get) Token: 0x060012F4 RID: 4852 RVA: 0x00021A94 File Offset: 0x0001FC94
		public Quaternion Rotation
		{
			get
			{
				return default(Quaternion);
			}
		}

		// Token: 0x1700061F RID: 1567
		// (get) Token: 0x060012F5 RID: 4853 RVA: 0x00021AAC File Offset: 0x0001FCAC
		public Vector3 Right
		{
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x17000620 RID: 1568
		// (get) Token: 0x060012F6 RID: 4854 RVA: 0x00021AC4 File Offset: 0x0001FCC4
		public Vector3 Look
		{
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x17000621 RID: 1569
		// (get) Token: 0x060012F7 RID: 4855 RVA: 0x00021ADC File Offset: 0x0001FCDC
		public Vector3 Normal
		{
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x17000622 RID: 1570
		// (get) Token: 0x060012F8 RID: 4856 RVA: 0x00021AF4 File Offset: 0x0001FCF4
		public Plane WorldPlane
		{
			get
			{
				return default(Plane);
			}
		}

		// Token: 0x17000623 RID: 1571
		// (get) Token: 0x060012F9 RID: 4857 RVA: 0x00021B0C File Offset: 0x0001FD0C
		public Matrix4x4 WorldMatrix
		{
			get
			{
				return default(Matrix4x4);
			}
		}

		// Token: 0x17000624 RID: 1572
		// (get) Token: 0x060012FA RID: 4858 RVA: 0x00019258 File Offset: 0x00017458
		// (set) Token: 0x060012FB RID: 4859 RVA: 0x0001925F File Offset: 0x0001745F
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

		// Token: 0x17000625 RID: 1573
		// (get) Token: 0x060012FC RID: 4860 RVA: 0x00019261 File Offset: 0x00017461
		public SceneGridHotkeys Hotkeys
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000626 RID: 1574
		// (get) Token: 0x060012FD RID: 4861 RVA: 0x00019264 File Offset: 0x00017464
		public XZGridSettings Settings
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000627 RID: 1575
		// (get) Token: 0x060012FE RID: 4862 RVA: 0x00019267 File Offset: 0x00017467
		public XZGridLookAndFeel LookAndFeel
		{
			get
			{
				return null;
			}
		}

		// Token: 0x060012FF RID: 4863 RVA: 0x0001926A File Offset: 0x0001746A
		public void Initialize_SystemCall()
		{
		}

		// Token: 0x06001300 RID: 4864 RVA: 0x0001926C File Offset: 0x0001746C
		public bool IsRenderIgnoreCamera(Camera camera)
		{
			return false;
		}

		// Token: 0x06001301 RID: 4865 RVA: 0x0001926F File Offset: 0x0001746F
		public void AddRenderIgnoreCamera(Camera camera)
		{
		}

		// Token: 0x06001302 RID: 4866 RVA: 0x00019271 File Offset: 0x00017471
		public void RemoveRenderIgnoreCamera(Camera camera)
		{
		}

		// Token: 0x06001303 RID: 4867 RVA: 0x00019273 File Offset: 0x00017473
		public XZGridCell CellFromWorldPoint(Vector3 worldPoint)
		{
			return null;
		}

		// Token: 0x06001304 RID: 4868 RVA: 0x00019276 File Offset: 0x00017476
		public bool Raycast(Ray ray, out float t)
		{
			t = 0f;
			return false;
		}

		// Token: 0x06001305 RID: 4869 RVA: 0x00019280 File Offset: 0x00017480
		public void Update_SystemCall()
		{
		}

		// Token: 0x06001306 RID: 4870 RVA: 0x00019282 File Offset: 0x00017482
		public void Render_SystemCall(Camera renderCamera)
		{
		}

		// Token: 0x06001307 RID: 4871 RVA: 0x00019284 File Offset: 0x00017484
		private void MoveUp()
		{
		}

		// Token: 0x06001308 RID: 4872 RVA: 0x00019286 File Offset: 0x00017486
		private void MoveDown()
		{
		}

		// Token: 0x06001309 RID: 4873 RVA: 0x00019288 File Offset: 0x00017488
		private float CalculateCellFadeZoom(Camera camera)
		{
			return 0f;
		}

		// Token: 0x0600130A RID: 4874 RVA: 0x0001928F File Offset: 0x0001748F
		private SceneRaycastHit GetSceneHitForGridSnap()
		{
			return null;
		}

		// Token: 0x0600130B RID: 4875 RVA: 0x00019292 File Offset: 0x00017492
		private void OnInputDeviceDoubleTap(IInputDevice inputDevice, Vector2 position)
		{
		}

		// Token: 0x0600130C RID: 4876 RVA: 0x00019294 File Offset: 0x00017494
		private void SnapToObjectHitPoint(GameObjectRayHit objectHit, RTSceneGrid.SnapToPointMode snapMode)
		{
		}

		// Token: 0x040006C7 RID: 1735
		private SceneGridHotkeys _hotkeys;

		// Token: 0x040006C8 RID: 1736
		private XZGridSettings _settings;

		// Token: 0x040006C9 RID: 1737
		private XZGridLookAndFeel _lookAndFeel;

		// Token: 0x040006CA RID: 1738
		private List<Camera> _renderIgnoreCameras;

		// Token: 0x0200039F RID: 927
		private enum SnapToPointMode
		{
			// Token: 0x04000F80 RID: 3968
			Exact,
			// Token: 0x04000F81 RID: 3969
			ClosestExtremity
		}
	}
}
