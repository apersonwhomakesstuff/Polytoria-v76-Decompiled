using System;
using UnityEngine;

namespace RLD
{
	// Token: 0x020001F1 RID: 497
	public class TriangPrismShape3D : Shape3D
	{
		// Token: 0x170007DF RID: 2015
		// (get) Token: 0x06001717 RID: 5911 RVA: 0x000234EC File Offset: 0x000216EC
		// (set) Token: 0x06001718 RID: 5912 RVA: 0x00019CF0 File Offset: 0x00017EF0
		public Vector3 BaseCenter
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		// Token: 0x170007E0 RID: 2016
		// (get) Token: 0x06001719 RID: 5913 RVA: 0x00023504 File Offset: 0x00021704
		// (set) Token: 0x0600171A RID: 5914 RVA: 0x00019CF2 File Offset: 0x00017EF2
		public Vector3 TopCenter
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		// Token: 0x170007E1 RID: 2017
		// (get) Token: 0x0600171B RID: 5915 RVA: 0x0002351C File Offset: 0x0002171C
		// (set) Token: 0x0600171C RID: 5916 RVA: 0x00019CF4 File Offset: 0x00017EF4
		public Vector3 FrontCenter
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		// Token: 0x170007E2 RID: 2018
		// (get) Token: 0x0600171D RID: 5917 RVA: 0x00023534 File Offset: 0x00021734
		// (set) Token: 0x0600171E RID: 5918 RVA: 0x00019CF6 File Offset: 0x00017EF6
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

		// Token: 0x170007E3 RID: 2019
		// (get) Token: 0x0600171F RID: 5919 RVA: 0x0002354C File Offset: 0x0002174C
		// (set) Token: 0x06001720 RID: 5920 RVA: 0x00019CF8 File Offset: 0x00017EF8
		public Vector3 MidTip
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		// Token: 0x170007E4 RID: 2020
		// (get) Token: 0x06001721 RID: 5921 RVA: 0x00019CFA File Offset: 0x00017EFA
		// (set) Token: 0x06001722 RID: 5922 RVA: 0x00019D01 File Offset: 0x00017F01
		public float Width
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x170007E5 RID: 2021
		// (get) Token: 0x06001723 RID: 5923 RVA: 0x00019D03 File Offset: 0x00017F03
		// (set) Token: 0x06001724 RID: 5924 RVA: 0x00019D0A File Offset: 0x00017F0A
		public float Height
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x170007E6 RID: 2022
		// (get) Token: 0x06001725 RID: 5925 RVA: 0x00019D0C File Offset: 0x00017F0C
		// (set) Token: 0x06001726 RID: 5926 RVA: 0x00019D13 File Offset: 0x00017F13
		public float Depth
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x170007E7 RID: 2023
		// (get) Token: 0x06001727 RID: 5927 RVA: 0x00023564 File Offset: 0x00021764
		// (set) Token: 0x06001728 RID: 5928 RVA: 0x00019D15 File Offset: 0x00017F15
		public PrismEpsilon Epsilon
		{
			get
			{
				return default(PrismEpsilon);
			}
			set
			{
			}
		}

		// Token: 0x170007E8 RID: 2024
		// (get) Token: 0x06001729 RID: 5929 RVA: 0x00019D17 File Offset: 0x00017F17
		// (set) Token: 0x0600172A RID: 5930 RVA: 0x00019D1E File Offset: 0x00017F1E
		public float PtContainEps
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x170007E9 RID: 2025
		// (get) Token: 0x0600172B RID: 5931 RVA: 0x0002357C File Offset: 0x0002177C
		// (set) Token: 0x0600172C RID: 5932 RVA: 0x00019D20 File Offset: 0x00017F20
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

		// Token: 0x170007EA RID: 2026
		// (get) Token: 0x0600172D RID: 5933 RVA: 0x00023594 File Offset: 0x00021794
		public Vector3 CentralAxis
		{
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x170007EB RID: 2027
		// (get) Token: 0x0600172E RID: 5934 RVA: 0x000235AC File Offset: 0x000217AC
		public Vector3 Right
		{
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x170007EC RID: 2028
		// (get) Token: 0x0600172F RID: 5935 RVA: 0x000235C4 File Offset: 0x000217C4
		public Vector3 Up
		{
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x170007ED RID: 2029
		// (get) Token: 0x06001730 RID: 5936 RVA: 0x000235DC File Offset: 0x000217DC
		public Vector3 Look
		{
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x170007EE RID: 2030
		// (get) Token: 0x06001731 RID: 5937 RVA: 0x000235F4 File Offset: 0x000217F4
		public static Vector3 ModelRight
		{
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x170007EF RID: 2031
		// (get) Token: 0x06001732 RID: 5938 RVA: 0x0002360C File Offset: 0x0002180C
		public static Vector3 ModelUp
		{
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x170007F0 RID: 2032
		// (get) Token: 0x06001733 RID: 5939 RVA: 0x00023624 File Offset: 0x00021824
		public static Vector3 ModelLook
		{
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x170007F1 RID: 2033
		// (get) Token: 0x06001734 RID: 5940 RVA: 0x0002363C File Offset: 0x0002183C
		public static Vector3 ModelBaseCenter
		{
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x06001735 RID: 5941 RVA: 0x00019D22 File Offset: 0x00017F22
		public void AlignWidth(Vector3 axis)
		{
		}

		// Token: 0x06001736 RID: 5942 RVA: 0x00019D24 File Offset: 0x00017F24
		public void AlignHeight(Vector3 axis)
		{
		}

		// Token: 0x06001737 RID: 5943 RVA: 0x00019D26 File Offset: 0x00017F26
		public void AlignDepth(Vector3 axis)
		{
		}

		// Token: 0x06001738 RID: 5944 RVA: 0x00019D28 File Offset: 0x00017F28
		public override void RenderSolid()
		{
		}

		// Token: 0x06001739 RID: 5945 RVA: 0x00019D2A File Offset: 0x00017F2A
		public override void RenderWire()
		{
		}

		// Token: 0x0600173A RID: 5946 RVA: 0x00019D2C File Offset: 0x00017F2C
		public void MakeEquilateral(float sideLength)
		{
		}

		// Token: 0x0600173B RID: 5947 RVA: 0x00019D2E File Offset: 0x00017F2E
		public override bool Raycast(Ray ray, out float t)
		{
			t = 0f;
			return false;
		}

		// Token: 0x0600173C RID: 5948 RVA: 0x00019D38 File Offset: 0x00017F38
		public bool ContainsPoint(Vector3 point)
		{
			return false;
		}

		// Token: 0x0600173D RID: 5949 RVA: 0x00023654 File Offset: 0x00021854
		public override AABB GetAABB()
		{
			return default(AABB);
		}

		// Token: 0x04000810 RID: 2064
		private Vector3 _baseCenter;

		// Token: 0x04000811 RID: 2065
		private float _width;

		// Token: 0x04000812 RID: 2066
		private float _height;

		// Token: 0x04000813 RID: 2067
		private float _depth;

		// Token: 0x04000814 RID: 2068
		private Quaternion _rotation;

		// Token: 0x04000815 RID: 2069
		private PrismEpsilon _epsilon;
	}
}
