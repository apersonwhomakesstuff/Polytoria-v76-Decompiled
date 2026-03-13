using System;
using UnityEngine;

namespace RLD
{
	// Token: 0x020001F6 RID: 502
	public class WorldTransformSnapshot
	{
		// Token: 0x170007F5 RID: 2037
		// (get) Token: 0x0600174B RID: 5963 RVA: 0x0002369C File Offset: 0x0002189C
		public Vector3 WorldPosition
		{
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x170007F6 RID: 2038
		// (get) Token: 0x0600174C RID: 5964 RVA: 0x000236B4 File Offset: 0x000218B4
		public Quaternion WorldRotation
		{
			get
			{
				return default(Quaternion);
			}
		}

		// Token: 0x170007F7 RID: 2039
		// (get) Token: 0x0600174D RID: 5965 RVA: 0x000236CC File Offset: 0x000218CC
		public Vector3 WorldScale
		{
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x0600174E RID: 5966 RVA: 0x00019D6C File Offset: 0x00017F6C
		public void Snaphot(Transform transform)
		{
		}

		// Token: 0x0600174F RID: 5967 RVA: 0x00019D6E File Offset: 0x00017F6E
		public bool SameAs(Transform transform)
		{
			return false;
		}

		// Token: 0x04000825 RID: 2085
		private Vector3 _worldPosition;

		// Token: 0x04000826 RID: 2086
		private Quaternion _worldRotation;

		// Token: 0x04000827 RID: 2087
		private Vector3 _worldScale;
	}
}
