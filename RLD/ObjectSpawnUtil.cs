using System;
using UnityEngine;

namespace RLD
{
	// Token: 0x0200020C RID: 524
	public static class ObjectSpawnUtil
	{
		// Token: 0x17000803 RID: 2051
		// (get) Token: 0x060017C7 RID: 6087 RVA: 0x0002399C File Offset: 0x00021B9C
		public static ObjectSpawnUtil.Config DefaultConfig
		{
			get
			{
				return default(ObjectSpawnUtil.Config);
			}
		}

		// Token: 0x060017C8 RID: 6088 RVA: 0x00019E37 File Offset: 0x00018037
		public static GameObject SpawnInFrontOfCamera(GameObject sourceObject, Camera camera, ObjectSpawnUtil.Config config)
		{
			return null;
		}

		// Token: 0x0400084B RID: 2123
		private static ObjectSpawnUtil.Config _defaultConfig;

		// Token: 0x020003C6 RID: 966
		public struct Config
		{
			// Token: 0x04001019 RID: 4121
			public float ObjectSize;
		}
	}
}
