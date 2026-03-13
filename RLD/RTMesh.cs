using System;
using System.Collections.Generic;
using UnityEngine;

namespace RLD
{
	// Token: 0x0200018B RID: 395
	public class RTMesh
	{
		// Token: 0x170005B9 RID: 1465
		// (get) Token: 0x060011BF RID: 4543 RVA: 0x00018F12 File Offset: 0x00017112
		public int NumTriangles
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x170005BA RID: 1466
		// (get) Token: 0x060011C0 RID: 4544 RVA: 0x00018F15 File Offset: 0x00017115
		public Mesh UnityMesh
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170005BB RID: 1467
		// (get) Token: 0x060011C1 RID: 4545 RVA: 0x00021914 File Offset: 0x0001FB14
		public AABB AABB
		{
			get
			{
				return default(AABB);
			}
		}

		// Token: 0x170005BC RID: 1468
		// (get) Token: 0x060011C2 RID: 4546 RVA: 0x00018F18 File Offset: 0x00017118
		public bool IsTreeBuilt
		{
			get
			{
				return false;
			}
		}

		// Token: 0x060011C3 RID: 4547 RVA: 0x00018F1B File Offset: 0x0001711B
		public RTMesh(Mesh unityMesh)
		{
		}

		// Token: 0x060011C4 RID: 4548 RVA: 0x00018F23 File Offset: 0x00017123
		public static RTMesh Create(Mesh unityMesh)
		{
			return null;
		}

		// Token: 0x060011C5 RID: 4549 RVA: 0x00018F26 File Offset: 0x00017126
		public void BuildTree()
		{
		}

		// Token: 0x060011C6 RID: 4550 RVA: 0x00018F28 File Offset: 0x00017128
		public MeshTriangle GetTriangle(int triangleIndex)
		{
			return null;
		}

		// Token: 0x060011C7 RID: 4551 RVA: 0x00018F2B File Offset: 0x0001712B
		public MeshRayHit Raycast(Ray ray, Matrix4x4 meshTransform)
		{
			return null;
		}

		// Token: 0x060011C8 RID: 4552 RVA: 0x00018F2E File Offset: 0x0001712E
		public bool OverlapVerts(OBB obb, Transform meshObjectTransform, List<Vector3> verts)
		{
			return false;
		}

		// Token: 0x060011C9 RID: 4553 RVA: 0x00018F31 File Offset: 0x00017131
		public bool OverlapModelVerts(OBB modelOBB, List<Vector3> verts)
		{
			return false;
		}

		// Token: 0x060011CA RID: 4554 RVA: 0x00018F34 File Offset: 0x00017134
		public bool OverlapModelVerts(AABB modelAABB, List<Vector3> verts)
		{
			return false;
		}

		// Token: 0x060011CB RID: 4555 RVA: 0x00018F37 File Offset: 0x00017137
		public void DebugDrawTree()
		{
		}

		// Token: 0x04000642 RID: 1602
		private Mesh _unityMesh;

		// Token: 0x04000643 RID: 1603
		private Vector3[] _vertices;

		// Token: 0x04000644 RID: 1604
		private int[] _vertIndices;

		// Token: 0x04000645 RID: 1605
		private int _numTriangles;

		// Token: 0x04000646 RID: 1606
		private AABB _aabb;

		// Token: 0x04000647 RID: 1607
		private MeshTree _meshTree;
	}
}
