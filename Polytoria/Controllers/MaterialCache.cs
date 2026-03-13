using System;
using System.Collections.Generic;
using Polytoria.Datamodel;
using UnityEngine;

namespace Polytoria.Controllers
{
	// Token: 0x02000331 RID: 817
	public class MaterialCache : MonoBehaviour
	{
		// Token: 0x17000C57 RID: 3159
		// (get) Token: 0x06002879 RID: 10361 RVA: 0x0001CC10 File Offset: 0x0001AE10
		// (set) Token: 0x0600287A RID: 10362 RVA: 0x0001CC17 File Offset: 0x0001AE17
		public static MaterialCache Instance
		{
			get
			{
				return MaterialCache.<Instance>k__BackingField;
			}
			private set
			{
				MaterialCache.<Instance>k__BackingField = value;
			}
		}

		// Token: 0x0600287B RID: 10363 RVA: 0x0001CC1F File Offset: 0x0001AE1F
		private void Awake()
		{
		}

		// Token: 0x0600287C RID: 10364 RVA: 0x0001CC21 File Offset: 0x0001AE21
		public Material GetMaterial(PartMaterial material, bool isTransparent = false)
		{
			return null;
		}

		// Token: 0x04000DCE RID: 3534
		private static MaterialCache <Instance>k__BackingField;

		// Token: 0x04000DCF RID: 3535
		private Dictionary<PartMaterial, MaterialCache.MaterialCacheEntry> materials;

		// Token: 0x02000424 RID: 1060
		private struct MaterialCacheEntry
		{
			// Token: 0x040011CD RID: 4557
			public Material Opaque;

			// Token: 0x040011CE RID: 4558
			public Material Transparent;
		}
	}
}
