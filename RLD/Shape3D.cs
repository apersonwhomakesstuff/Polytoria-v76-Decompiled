using System;
using UnityEngine;

namespace RLD
{
	// Token: 0x020001ED RID: 493
	public abstract class Shape3D
	{
		// Token: 0x060016DB RID: 5851 RVA: 0x00019C60 File Offset: 0x00017E60
		public bool Raycast(Ray ray)
		{
			return false;
		}

		// Token: 0x060016DC RID: 5852 RVA: 0x00019C63 File Offset: 0x00017E63
		public bool RaycastWire(Ray ray)
		{
			return false;
		}

		// Token: 0x060016DD RID: 5853 RVA: 0x00019C66 File Offset: 0x00017E66
		public virtual bool RaycastWire(Ray ray, out float t)
		{
			t = 0f;
			return false;
		}

		// Token: 0x060016DE RID: 5854
		public abstract void RenderSolid();

		// Token: 0x060016DF RID: 5855
		public abstract void RenderWire();

		// Token: 0x060016E0 RID: 5856
		public abstract bool Raycast(Ray ray, out float t);

		// Token: 0x060016E1 RID: 5857
		public abstract AABB GetAABB();
	}
}
