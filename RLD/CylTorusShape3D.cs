using System;
using System.Collections.Generic;
using UnityEngine;

namespace RLD
{
	// Token: 0x020001DD RID: 477
	public class CylTorusShape3D : Shape3D
	{
		// Token: 0x17000723 RID: 1827
		// (get) Token: 0x06001579 RID: 5497 RVA: 0x000198EE File Offset: 0x00017AEE
		// (set) Token: 0x0600157A RID: 5498 RVA: 0x000198F5 File Offset: 0x00017AF5
		public float CoreRadius
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x17000724 RID: 1828
		// (get) Token: 0x0600157B RID: 5499 RVA: 0x000198F7 File Offset: 0x00017AF7
		// (set) Token: 0x0600157C RID: 5500 RVA: 0x000198FE File Offset: 0x00017AFE
		public float HrzRadius
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x17000725 RID: 1829
		// (get) Token: 0x0600157D RID: 5501 RVA: 0x00019900 File Offset: 0x00017B00
		// (set) Token: 0x0600157E RID: 5502 RVA: 0x00019907 File Offset: 0x00017B07
		public float VertRadius
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x17000726 RID: 1830
		// (get) Token: 0x0600157F RID: 5503 RVA: 0x0002273C File Offset: 0x0002093C
		// (set) Token: 0x06001580 RID: 5504 RVA: 0x00019909 File Offset: 0x00017B09
		public Vector3 Bottom
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		// Token: 0x17000727 RID: 1831
		// (get) Token: 0x06001581 RID: 5505 RVA: 0x00022754 File Offset: 0x00020954
		// (set) Token: 0x06001582 RID: 5506 RVA: 0x0001990B File Offset: 0x00017B0B
		public Vector3 Top
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		// Token: 0x17000728 RID: 1832
		// (get) Token: 0x06001583 RID: 5507 RVA: 0x0002276C File Offset: 0x0002096C
		// (set) Token: 0x06001584 RID: 5508 RVA: 0x0001990D File Offset: 0x00017B0D
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

		// Token: 0x17000729 RID: 1833
		// (get) Token: 0x06001585 RID: 5509 RVA: 0x00022784 File Offset: 0x00020984
		// (set) Token: 0x06001586 RID: 5510 RVA: 0x0001990F File Offset: 0x00017B0F
		public Quaternion Rotation
		{
			get
			{
				return default(Quaternion);
			}
			set
			{
			}
		}

		// Token: 0x1700072A RID: 1834
		// (get) Token: 0x06001587 RID: 5511 RVA: 0x0002279C File Offset: 0x0002099C
		public Vector3 Right
		{
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x1700072B RID: 1835
		// (get) Token: 0x06001588 RID: 5512 RVA: 0x000227B4 File Offset: 0x000209B4
		public Vector3 Up
		{
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x1700072C RID: 1836
		// (get) Token: 0x06001589 RID: 5513 RVA: 0x000227CC File Offset: 0x000209CC
		public Vector3 Look
		{
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x1700072D RID: 1837
		// (get) Token: 0x0600158A RID: 5514 RVA: 0x000227E4 File Offset: 0x000209E4
		// (set) Token: 0x0600158B RID: 5515 RVA: 0x00019911 File Offset: 0x00017B11
		public TorusEpsilon Epsilon
		{
			get
			{
				return default(TorusEpsilon);
			}
			set
			{
			}
		}

		// Token: 0x1700072E RID: 1838
		// (get) Token: 0x0600158C RID: 5516 RVA: 0x00019913 File Offset: 0x00017B13
		// (set) Token: 0x0600158D RID: 5517 RVA: 0x0001991A File Offset: 0x00017B1A
		public float CylHrzRadiusEps
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x1700072F RID: 1839
		// (get) Token: 0x0600158E RID: 5518 RVA: 0x0001991C File Offset: 0x00017B1C
		// (set) Token: 0x0600158F RID: 5519 RVA: 0x00019923 File Offset: 0x00017B23
		public float CylVertRadiusEps
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x17000730 RID: 1840
		// (get) Token: 0x06001590 RID: 5520 RVA: 0x000227FC File Offset: 0x000209FC
		public static Vector3 ModelRight
		{
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x17000731 RID: 1841
		// (get) Token: 0x06001591 RID: 5521 RVA: 0x00022814 File Offset: 0x00020A14
		public static Vector3 ModelUp
		{
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x17000732 RID: 1842
		// (get) Token: 0x06001592 RID: 5522 RVA: 0x0002282C File Offset: 0x00020A2C
		public static Vector3 ModelLook
		{
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x17000733 RID: 1843
		// (get) Token: 0x06001593 RID: 5523 RVA: 0x00022844 File Offset: 0x00020A44
		public static Vector3 ModelCenter
		{
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x06001594 RID: 5524 RVA: 0x00019925 File Offset: 0x00017B25
		public override bool Raycast(Ray ray, out float t)
		{
			t = 0f;
			return false;
		}

		// Token: 0x06001595 RID: 5525 RVA: 0x0001992F File Offset: 0x00017B2F
		public override void RenderSolid()
		{
		}

		// Token: 0x06001596 RID: 5526 RVA: 0x00019931 File Offset: 0x00017B31
		public override void RenderWire()
		{
		}

		// Token: 0x06001597 RID: 5527 RVA: 0x00019933 File Offset: 0x00017B33
		public List<Vector3> GetHrzExtents()
		{
			return null;
		}

		// Token: 0x06001598 RID: 5528 RVA: 0x0002285C File Offset: 0x00020A5C
		public override AABB GetAABB()
		{
			return default(AABB);
		}

		// Token: 0x040007B1 RID: 1969
		private float _coreRadius;

		// Token: 0x040007B2 RID: 1970
		private float _hrzRadius;

		// Token: 0x040007B3 RID: 1971
		private float _vertRadius;

		// Token: 0x040007B4 RID: 1972
		private Vector3 _center;

		// Token: 0x040007B5 RID: 1973
		private Quaternion _rotation;

		// Token: 0x040007B6 RID: 1974
		private TorusEpsilon _epsilon;
	}
}
