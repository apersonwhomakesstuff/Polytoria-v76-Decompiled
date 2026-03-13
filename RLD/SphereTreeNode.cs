using System;
using UnityEngine;

namespace RLD
{
	// Token: 0x020000F6 RID: 246
	public class SphereTreeNode<T>
	{
		// Token: 0x170004A2 RID: 1186
		// (get) Token: 0x06000D9C RID: 3484 RVA: 0x0001830C File Offset: 0x0001650C
		public SphereTreeNode<T>[] Children
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170004A3 RID: 1187
		// (get) Token: 0x06000D9D RID: 3485 RVA: 0x0001830F File Offset: 0x0001650F
		public int NumChildren
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x170004A4 RID: 1188
		// (get) Token: 0x06000D9E RID: 3486 RVA: 0x00018312 File Offset: 0x00016512
		public bool IsLeaf
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06000D9F RID: 3487 RVA: 0x00018315 File Offset: 0x00016515
		public SphereTreeNode()
		{
		}

		// Token: 0x06000DA0 RID: 3488 RVA: 0x0001831D File Offset: 0x0001651D
		public SphereTreeNode(T data, Sphere sphere)
		{
		}

		// Token: 0x170004A5 RID: 1189
		// (get) Token: 0x06000DA1 RID: 3489 RVA: 0x000203AC File Offset: 0x0001E5AC
		// (set) Token: 0x06000DA2 RID: 3490 RVA: 0x00018325 File Offset: 0x00016525
		public Sphere Sphere
		{
			get
			{
				return default(Sphere);
			}
			set
			{
			}
		}

		// Token: 0x170004A6 RID: 1190
		// (get) Token: 0x06000DA3 RID: 3491 RVA: 0x000203C4 File Offset: 0x0001E5C4
		// (set) Token: 0x06000DA4 RID: 3492 RVA: 0x00018327 File Offset: 0x00016527
		public Vector3 Center
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		// Token: 0x170004A7 RID: 1191
		// (get) Token: 0x06000DA5 RID: 3493 RVA: 0x00018329 File Offset: 0x00016529
		// (set) Token: 0x06000DA6 RID: 3494 RVA: 0x00018330 File Offset: 0x00016530
		public float Radius
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x170004A8 RID: 1192
		// (get) Token: 0x06000DA7 RID: 3495 RVA: 0x00018332 File Offset: 0x00016532
		public SphereTreeNode<T> Parent
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170004A9 RID: 1193
		// (get) Token: 0x06000DA8 RID: 3496 RVA: 0x000203DC File Offset: 0x0001E5DC
		// (set) Token: 0x06000DA9 RID: 3497 RVA: 0x00018335 File Offset: 0x00016535
		public T Data
		{
			get
			{
				return default(T);
			}
			set
			{
			}
		}

		// Token: 0x170004AA RID: 1194
		// (get) Token: 0x06000DAA RID: 3498 RVA: 0x00018337 File Offset: 0x00016537
		public SphereTreeNode<T> StackTop
		{
			get
			{
				return null;
			}
		}

		// Token: 0x06000DAB RID: 3499 RVA: 0x0001833A File Offset: 0x0001653A
		public void StackPush(SphereTreeNode<T> node)
		{
		}

		// Token: 0x06000DAC RID: 3500 RVA: 0x0001833C File Offset: 0x0001653C
		public SphereTreeNode<T> StackPop()
		{
			return null;
		}

		// Token: 0x06000DAD RID: 3501 RVA: 0x0001833F File Offset: 0x0001653F
		public bool IsOutsideParent()
		{
			return false;
		}

		// Token: 0x06000DAE RID: 3502 RVA: 0x00018342 File Offset: 0x00016542
		public SphereTreeNode<T> ClosestChild(SphereTreeNode<T> node)
		{
			return null;
		}

		// Token: 0x06000DAF RID: 3503 RVA: 0x00018345 File Offset: 0x00016545
		public void SetParent(SphereTreeNode<T> newParent)
		{
		}

		// Token: 0x06000DB0 RID: 3504 RVA: 0x00018347 File Offset: 0x00016547
		public void EncapsulateChildrenBottomUp()
		{
		}

		// Token: 0x06000DB1 RID: 3505 RVA: 0x00018349 File Offset: 0x00016549
		public void DebugDraw()
		{
		}

		// Token: 0x040004AE RID: 1198
		private SphereTreeNode<T> _stackTop;

		// Token: 0x040004AF RID: 1199
		private SphereTreeNode<T> _stackPrevious;

		// Token: 0x040004B0 RID: 1200
		private Sphere _sphere;

		// Token: 0x040004B1 RID: 1201
		private T _data;

		// Token: 0x040004B2 RID: 1202
		private SphereTreeNode<T> _parent;

		// Token: 0x040004B3 RID: 1203
		private SphereTreeNode<T>[] _children;

		// Token: 0x040004B4 RID: 1204
		private int _numChildren;
	}
}
