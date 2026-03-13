using System;
using System.Collections.Generic;
using UnityEngine;

namespace RLD
{
	// Token: 0x02000206 RID: 518
	public class Object2ObjectSnapDataDb : Singleton<Object2ObjectSnapDataDb>
	{
		// Token: 0x060017A8 RID: 6056 RVA: 0x00019E1A File Offset: 0x0001801A
		public Object2ObjectSnapData GetObject2ObjectSnapData(GameObject gameObject)
		{
			return null;
		}

		// Token: 0x04000847 RID: 2119
		private Dictionary<GameObject, Object2ObjectSnapData> _objectToSnapData;
	}
}
