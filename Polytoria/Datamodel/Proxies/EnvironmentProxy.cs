using System;
using System.Collections.Generic;
using MoonSharp.Interpreter;
using UnityEngine;

namespace Polytoria.Datamodel.Proxies
{
	// Token: 0x020002D7 RID: 727
	public class EnvironmentProxy : InstanceProxy
	{
		// Token: 0x060024B0 RID: 9392 RVA: 0x0001C0CB File Offset: 0x0001A2CB
		public EnvironmentProxy(Environment target) : base(null)
		{
		}

		// Token: 0x17000B0D RID: 2829
		// (get) Token: 0x060024B1 RID: 9393 RVA: 0x00025768 File Offset: 0x00023968
		// (set) Token: 0x060024B2 RID: 9394 RVA: 0x0001C0D4 File Offset: 0x0001A2D4
		public SkyboxPreset Skybox
		{
			get
			{
				return SkyboxPreset.Day1;
			}
			set
			{
			}
		}

		// Token: 0x17000B0E RID: 2830
		// (get) Token: 0x060024B3 RID: 9395 RVA: 0x00025780 File Offset: 0x00023980
		// (set) Token: 0x060024B4 RID: 9396 RVA: 0x0001C0D6 File Offset: 0x0001A2D6
		public Vector3 Gravity
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		// Token: 0x17000B0F RID: 2831
		// (get) Token: 0x060024B5 RID: 9397 RVA: 0x0001C0D8 File Offset: 0x0001A2D8
		// (set) Token: 0x060024B6 RID: 9398 RVA: 0x0001C0DB File Offset: 0x0001A2DB
		public bool FogEnabled
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x17000B10 RID: 2832
		// (get) Token: 0x060024B7 RID: 9399 RVA: 0x0001C0DD File Offset: 0x0001A2DD
		// (set) Token: 0x060024B8 RID: 9400 RVA: 0x0001C0E4 File Offset: 0x0001A2E4
		public float FogStartDistance
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x17000B11 RID: 2833
		// (get) Token: 0x060024B9 RID: 9401 RVA: 0x0001C0E6 File Offset: 0x0001A2E6
		// (set) Token: 0x060024BA RID: 9402 RVA: 0x0001C0ED File Offset: 0x0001A2ED
		public float FogEndDistance
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x17000B12 RID: 2834
		// (get) Token: 0x060024BB RID: 9403 RVA: 0x00025798 File Offset: 0x00023998
		// (set) Token: 0x060024BC RID: 9404 RVA: 0x0001C0EF File Offset: 0x0001A2EF
		public Color FogColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		// Token: 0x17000B13 RID: 2835
		// (get) Token: 0x060024BD RID: 9405 RVA: 0x0001C0F1 File Offset: 0x0001A2F1
		// (set) Token: 0x060024BE RID: 9406 RVA: 0x0001C0F8 File Offset: 0x0001A2F8
		public float PartDestroyHeight
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x17000B14 RID: 2836
		// (get) Token: 0x060024BF RID: 9407 RVA: 0x0001C0FA File Offset: 0x0001A2FA
		// (set) Token: 0x060024C0 RID: 9408 RVA: 0x0001C0FD File Offset: 0x0001A2FD
		public bool AutoGenerateNavMesh
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x060024C1 RID: 9409 RVA: 0x0001C0FF File Offset: 0x0001A2FF
		public void CreateExplosion(Vector3 position, float radius = 10f, float force = 5000f, bool affectKinematic = true, DynValue callback = null, float damage = 10000f)
		{
		}

		// Token: 0x060024C2 RID: 9410 RVA: 0x000257B0 File Offset: 0x000239B0
		public RayResult? Raycast(Vector3 origin, Vector3 direction, float maxDistance = float.PositiveInfinity, List<Instance> ignoreList = null)
		{
			return null;
		}

		// Token: 0x060024C3 RID: 9411 RVA: 0x0001C101 File Offset: 0x0001A301
		public RayResult[] RaycastAll(Vector3 origin, Vector3 direction, float maxDistance = float.PositiveInfinity, List<Instance> ignoreList = null)
		{
			return null;
		}

		// Token: 0x060024C4 RID: 9412 RVA: 0x0001C104 File Offset: 0x0001A304
		public Instance[] OverlapSphere(Vector3 position, float radius, List<Instance> ignoreList = null)
		{
			return null;
		}

		// Token: 0x060024C5 RID: 9413 RVA: 0x0001C107 File Offset: 0x0001A307
		public Instance[] OverlapBox(Vector3 center, Vector3 halfExtents, Vector3 rotation, List<Instance> ignoreList = null)
		{
			return null;
		}

		// Token: 0x060024C6 RID: 9414 RVA: 0x0001C10A File Offset: 0x0001A30A
		public void RebuildNavMesh(Instance root)
		{
		}

		// Token: 0x060024C7 RID: 9415 RVA: 0x000257C8 File Offset: 0x000239C8
		public Vector3 GetPointOnNavMesh(Vector3 position, float maxDistance = 100f)
		{
			return default(Vector3);
		}

		// Token: 0x04000D03 RID: 3331
		private readonly Environment environment;
	}
}
