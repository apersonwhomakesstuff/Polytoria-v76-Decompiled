using System;
using System.Collections.Generic;
using UnityEngine;

namespace RLD
{
	// Token: 0x020001F5 RID: 501
	public class LocalTransformSnapshot
	{
		// Token: 0x170007F4 RID: 2036
		// (get) Token: 0x06001745 RID: 5957 RVA: 0x00019D57 File Offset: 0x00017F57
		public Transform Transform
		{
			get
			{
				return null;
			}
		}

		// Token: 0x06001746 RID: 5958 RVA: 0x00019D5A File Offset: 0x00017F5A
		public static List<LocalTransformSnapshot> GetSnapshotCollection(IEnumerable<GameObject> gameObjects)
		{
			return null;
		}

		// Token: 0x06001747 RID: 5959 RVA: 0x00019D5D File Offset: 0x00017F5D
		public void Snapshot(Transform transform)
		{
		}

		// Token: 0x06001748 RID: 5960 RVA: 0x00019D5F File Offset: 0x00017F5F
		public bool SameAs(Transform transform)
		{
			return false;
		}

		// Token: 0x06001749 RID: 5961 RVA: 0x00019D62 File Offset: 0x00017F62
		public void Apply()
		{
		}

		// Token: 0x04000820 RID: 2080
		private Transform _transform;

		// Token: 0x04000821 RID: 2081
		private Transform _parentTransform;

		// Token: 0x04000822 RID: 2082
		private Vector3 _localPosition;

		// Token: 0x04000823 RID: 2083
		private Quaternion _localRotation;

		// Token: 0x04000824 RID: 2084
		private Vector3 _localScale;
	}
}
