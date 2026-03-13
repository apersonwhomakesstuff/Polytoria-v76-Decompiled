using System;
using System.Collections.Generic;
using UnityEngine;

namespace RLD
{
	// Token: 0x02000209 RID: 521
	public static class ObjectCloning
	{
		// Token: 0x17000802 RID: 2050
		// (get) Token: 0x060017C0 RID: 6080 RVA: 0x0002396C File Offset: 0x00021B6C
		public static ObjectCloning.Config DefaultConfig
		{
			get
			{
				return default(ObjectCloning.Config);
			}
		}

		// Token: 0x060017C1 RID: 6081 RVA: 0x00019E2B File Offset: 0x0001802B
		public static List<GameObject> CloneHierarchies(List<GameObject> roots, ObjectCloning.Config cloneConfig)
		{
			return null;
		}

		// Token: 0x060017C2 RID: 6082 RVA: 0x00019E2E File Offset: 0x0001802E
		public static GameObject CloneHierarchy(GameObject root, ObjectCloning.Config cloneConfig)
		{
			return null;
		}

		// Token: 0x04000849 RID: 2121
		private static ObjectCloning.Config _defaultConfig;

		// Token: 0x020003C4 RID: 964
		public enum TransformFlags
		{
			// Token: 0x04001011 RID: 4113
			None,
			// Token: 0x04001012 RID: 4114
			Position,
			// Token: 0x04001013 RID: 4115
			Rotation,
			// Token: 0x04001014 RID: 4116
			Scale = 4,
			// Token: 0x04001015 RID: 4117
			All = 7
		}

		// Token: 0x020003C5 RID: 965
		public struct Config
		{
			// Token: 0x04001016 RID: 4118
			public Transform Parent;

			// Token: 0x04001017 RID: 4119
			public ObjectCloning.TransformFlags TransformFlags;

			// Token: 0x04001018 RID: 4120
			public int Layer;
		}
	}
}
