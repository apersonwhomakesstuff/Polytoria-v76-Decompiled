using System;
using System.Collections.Generic;
using UnityEngine;

namespace RLD
{
	// Token: 0x020001E5 RID: 485
	public class RightAngTriangle3D : Shape3D
	{
		// Token: 0x1700079D RID: 1949
		// (get) Token: 0x06001681 RID: 5761 RVA: 0x0002303C File Offset: 0x0002123C
		// (set) Token: 0x06001682 RID: 5762 RVA: 0x00019B76 File Offset: 0x00017D76
		public Vector3 RightAngleCorner
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		// Token: 0x1700079E RID: 1950
		// (get) Token: 0x06001683 RID: 5763 RVA: 0x00019B78 File Offset: 0x00017D78
		// (set) Token: 0x06001684 RID: 5764 RVA: 0x00019B7F File Offset: 0x00017D7F
		public float XLength
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x1700079F RID: 1951
		// (get) Token: 0x06001685 RID: 5765 RVA: 0x00019B81 File Offset: 0x00017D81
		// (set) Token: 0x06001686 RID: 5766 RVA: 0x00019B88 File Offset: 0x00017D88
		public float YLength
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x170007A0 RID: 1952
		// (get) Token: 0x06001687 RID: 5767 RVA: 0x00019B8A File Offset: 0x00017D8A
		public float RealXLength
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x170007A1 RID: 1953
		// (get) Token: 0x06001688 RID: 5768 RVA: 0x00019B91 File Offset: 0x00017D91
		public float RealYLength
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x170007A2 RID: 1954
		// (get) Token: 0x06001689 RID: 5769 RVA: 0x00023054 File Offset: 0x00021254
		// (set) Token: 0x0600168A RID: 5770 RVA: 0x00019B98 File Offset: 0x00017D98
		public AxisSign XLengthSign
		{
			get
			{
				return AxisSign.Positive;
			}
			set
			{
			}
		}

		// Token: 0x170007A3 RID: 1955
		// (get) Token: 0x0600168B RID: 5771 RVA: 0x0002306C File Offset: 0x0002126C
		// (set) Token: 0x0600168C RID: 5772 RVA: 0x00019B9A File Offset: 0x00017D9A
		public AxisSign YLengthSign
		{
			get
			{
				return AxisSign.Positive;
			}
			set
			{
			}
		}

		// Token: 0x170007A4 RID: 1956
		// (get) Token: 0x0600168D RID: 5773 RVA: 0x00023084 File Offset: 0x00021284
		// (set) Token: 0x0600168E RID: 5774 RVA: 0x00019B9C File Offset: 0x00017D9C
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

		// Token: 0x170007A5 RID: 1957
		// (get) Token: 0x0600168F RID: 5775 RVA: 0x0002309C File Offset: 0x0002129C
		public Vector3 Right
		{
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x170007A6 RID: 1958
		// (get) Token: 0x06001690 RID: 5776 RVA: 0x000230B4 File Offset: 0x000212B4
		public Vector3 Up
		{
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x170007A7 RID: 1959
		// (get) Token: 0x06001691 RID: 5777 RVA: 0x000230CC File Offset: 0x000212CC
		public Vector3 Look
		{
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x170007A8 RID: 1960
		// (get) Token: 0x06001692 RID: 5778 RVA: 0x000230E4 File Offset: 0x000212E4
		public Vector3 Normal
		{
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x170007A9 RID: 1961
		// (get) Token: 0x06001693 RID: 5779 RVA: 0x000230FC File Offset: 0x000212FC
		public Plane Plane
		{
			get
			{
				return default(Plane);
			}
		}

		// Token: 0x170007AA RID: 1962
		// (get) Token: 0x06001694 RID: 5780 RVA: 0x00023114 File Offset: 0x00021314
		// (set) Token: 0x06001695 RID: 5781 RVA: 0x00019B9E File Offset: 0x00017D9E
		public TriangleEpsilon Epsilon
		{
			get
			{
				return default(TriangleEpsilon);
			}
			set
			{
			}
		}

		// Token: 0x170007AB RID: 1963
		// (get) Token: 0x06001696 RID: 5782 RVA: 0x00019BA0 File Offset: 0x00017DA0
		// (set) Token: 0x06001697 RID: 5783 RVA: 0x00019BA7 File Offset: 0x00017DA7
		public float AreaEps
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x170007AC RID: 1964
		// (get) Token: 0x06001698 RID: 5784 RVA: 0x00019BA9 File Offset: 0x00017DA9
		// (set) Token: 0x06001699 RID: 5785 RVA: 0x00019BB0 File Offset: 0x00017DB0
		public float ExtrudeEps
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x170007AD RID: 1965
		// (get) Token: 0x0600169A RID: 5786 RVA: 0x00019BB2 File Offset: 0x00017DB2
		// (set) Token: 0x0600169B RID: 5787 RVA: 0x00019BB9 File Offset: 0x00017DB9
		public float WireEps
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x170007AE RID: 1966
		// (get) Token: 0x0600169C RID: 5788 RVA: 0x0002312C File Offset: 0x0002132C
		// (set) Token: 0x0600169D RID: 5789 RVA: 0x00019BBB File Offset: 0x00017DBB
		public Shape3DRaycastMode RaycastMode
		{
			get
			{
				return Shape3DRaycastMode.Solid;
			}
			set
			{
			}
		}

		// Token: 0x170007AF RID: 1967
		// (get) Token: 0x0600169E RID: 5790 RVA: 0x00023144 File Offset: 0x00021344
		public static Vector3 ModelRight
		{
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x170007B0 RID: 1968
		// (get) Token: 0x0600169F RID: 5791 RVA: 0x0002315C File Offset: 0x0002135C
		public static Vector3 ModelUp
		{
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x170007B1 RID: 1969
		// (get) Token: 0x060016A0 RID: 5792 RVA: 0x00023174 File Offset: 0x00021374
		public static Vector3 ModelLook
		{
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x170007B2 RID: 1970
		// (get) Token: 0x060016A1 RID: 5793 RVA: 0x0002318C File Offset: 0x0002138C
		public static Vector3 ModelRightAngleCorner
		{
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x170007B3 RID: 1971
		// (get) Token: 0x060016A2 RID: 5794 RVA: 0x000231A4 File Offset: 0x000213A4
		public static Vector3 ModelNormal
		{
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x060016A3 RID: 5795 RVA: 0x00019BBD File Offset: 0x00017DBD
		public void AlignNormal(Vector3 axis)
		{
		}

		// Token: 0x060016A4 RID: 5796 RVA: 0x00019BBF File Offset: 0x00017DBF
		public void AlignRight(Vector3 axis)
		{
		}

		// Token: 0x060016A5 RID: 5797 RVA: 0x00019BC1 File Offset: 0x00017DC1
		public void AlignUp(Vector3 axis)
		{
		}

		// Token: 0x060016A6 RID: 5798 RVA: 0x00019BC3 File Offset: 0x00017DC3
		public override bool Raycast(Ray ray, out float t)
		{
			t = 0f;
			return false;
		}

		// Token: 0x060016A7 RID: 5799 RVA: 0x00019BCD File Offset: 0x00017DCD
		public override bool RaycastWire(Ray ray, out float t)
		{
			t = 0f;
			return false;
		}

		// Token: 0x060016A8 RID: 5800 RVA: 0x00019BD7 File Offset: 0x00017DD7
		public override void RenderSolid()
		{
		}

		// Token: 0x060016A9 RID: 5801 RVA: 0x00019BD9 File Offset: 0x00017DD9
		public override void RenderWire()
		{
		}

		// Token: 0x060016AA RID: 5802 RVA: 0x00019BDB File Offset: 0x00017DDB
		public List<Vector3> GetPoints()
		{
			return null;
		}

		// Token: 0x060016AB RID: 5803 RVA: 0x000231BC File Offset: 0x000213BC
		public override AABB GetAABB()
		{
			return default(AABB);
		}

		// Token: 0x060016AC RID: 5804 RVA: 0x00019BDE File Offset: 0x00017DDE
		public bool ContainsPoint(Vector3 point, bool checkOnPlane)
		{
			return false;
		}

		// Token: 0x040007E2 RID: 2018
		private Vector3 _rightAngleCorner;

		// Token: 0x040007E3 RID: 2019
		private float _XLength;

		// Token: 0x040007E4 RID: 2020
		private float _YLength;

		// Token: 0x040007E5 RID: 2021
		private AxisSign _XLengthSign;

		// Token: 0x040007E6 RID: 2022
		private AxisSign _YLengthSign;

		// Token: 0x040007E7 RID: 2023
		private Quaternion _rotation;

		// Token: 0x040007E8 RID: 2024
		private TriangleEpsilon _epsilon;

		// Token: 0x040007E9 RID: 2025
		private Shape3DRaycastMode _raycastMode;
	}
}
