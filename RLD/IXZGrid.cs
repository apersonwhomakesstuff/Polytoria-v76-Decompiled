using System;
using UnityEngine;

namespace RLD
{
	// Token: 0x020001AC RID: 428
	public interface IXZGrid
	{
		// Token: 0x1700061C RID: 1564
		// (get) Token: 0x060012F0 RID: 4848
		Plane WorldPlane { get; }

		// Token: 0x1700061D RID: 1565
		// (get) Token: 0x060012F1 RID: 4849
		Matrix4x4 WorldMatrix { get; }

		// Token: 0x060012F2 RID: 4850
		XZGridCell CellFromWorldPoint(Vector3 worldPoint);

		// Token: 0x060012F3 RID: 4851
		bool Raycast(Ray ray, out float t);
	}
}
