using System;
using System.Collections.Generic;
using UnityEngine;

namespace RLD
{
	// Token: 0x020001D6 RID: 470
	public class ArcShape3D : Shape3D
	{
		// Token: 0x170006AF RID: 1711
		// (get) Token: 0x06001484 RID: 5252 RVA: 0x000196A4 File Offset: 0x000178A4
		// (set) Token: 0x06001485 RID: 5253 RVA: 0x000196AB File Offset: 0x000178AB
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

		// Token: 0x170006B0 RID: 1712
		// (get) Token: 0x06001486 RID: 5254 RVA: 0x000196AD File Offset: 0x000178AD
		// (set) Token: 0x06001487 RID: 5255 RVA: 0x000196B0 File Offset: 0x000178B0
		public bool ForceShortestArc
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x170006B1 RID: 1713
		// (get) Token: 0x06001488 RID: 5256 RVA: 0x000196B2 File Offset: 0x000178B2
		// (set) Token: 0x06001489 RID: 5257 RVA: 0x000196B9 File Offset: 0x000178B9
		public float DegreeAngleFromStart
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x170006B2 RID: 1714
		// (get) Token: 0x0600148A RID: 5258 RVA: 0x000196BB File Offset: 0x000178BB
		public float AbsDegreeAngleFromStart
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x170006B3 RID: 1715
		// (get) Token: 0x0600148B RID: 5259 RVA: 0x000196C2 File Offset: 0x000178C2
		// (set) Token: 0x0600148C RID: 5260 RVA: 0x000196C5 File Offset: 0x000178C5
		public int NumBorderPoints
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x170006B4 RID: 1716
		// (get) Token: 0x0600148D RID: 5261 RVA: 0x00021ECC File Offset: 0x000200CC
		// (set) Token: 0x0600148E RID: 5262 RVA: 0x000196C7 File Offset: 0x000178C7
		public Vector3 Origin
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		// Token: 0x170006B5 RID: 1717
		// (get) Token: 0x0600148F RID: 5263 RVA: 0x00021EE4 File Offset: 0x000200E4
		public Vector3 StartPoint
		{
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x170006B6 RID: 1718
		// (get) Token: 0x06001490 RID: 5264 RVA: 0x00021EFC File Offset: 0x000200FC
		public Vector3 EndPoint
		{
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x170006B7 RID: 1719
		// (get) Token: 0x06001491 RID: 5265 RVA: 0x00021F14 File Offset: 0x00020114
		public Plane Plane
		{
			get
			{
				return default(Plane);
			}
		}

		// Token: 0x170006B8 RID: 1720
		// (get) Token: 0x06001492 RID: 5266 RVA: 0x00021F2C File Offset: 0x0002012C
		public Vector3 Normal
		{
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x170006B9 RID: 1721
		// (get) Token: 0x06001493 RID: 5267 RVA: 0x00021F44 File Offset: 0x00020144
		// (set) Token: 0x06001494 RID: 5268 RVA: 0x000196C9 File Offset: 0x000178C9
		public ArcEpsilon Epsilon
		{
			get
			{
				return default(ArcEpsilon);
			}
			set
			{
			}
		}

		// Token: 0x170006BA RID: 1722
		// (get) Token: 0x06001495 RID: 5269 RVA: 0x000196CB File Offset: 0x000178CB
		// (set) Token: 0x06001496 RID: 5270 RVA: 0x000196D2 File Offset: 0x000178D2
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

		// Token: 0x170006BB RID: 1723
		// (get) Token: 0x06001497 RID: 5271 RVA: 0x000196D4 File Offset: 0x000178D4
		// (set) Token: 0x06001498 RID: 5272 RVA: 0x000196DB File Offset: 0x000178DB
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

		// Token: 0x170006BC RID: 1724
		// (get) Token: 0x06001499 RID: 5273 RVA: 0x000196DD File Offset: 0x000178DD
		// (set) Token: 0x0600149A RID: 5274 RVA: 0x000196E4 File Offset: 0x000178E4
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

		// Token: 0x170006BD RID: 1725
		// (get) Token: 0x0600149B RID: 5275 RVA: 0x000196E6 File Offset: 0x000178E6
		public ArcShape3D.WireRenderDescriptor WireRenderDesc
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170006BE RID: 1726
		// (get) Token: 0x0600149C RID: 5276 RVA: 0x00021F5C File Offset: 0x0002015C
		// (set) Token: 0x0600149D RID: 5277 RVA: 0x000196E9 File Offset: 0x000178E9
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

		// Token: 0x0600149E RID: 5278 RVA: 0x000196EB File Offset: 0x000178EB
		public override void RenderSolid()
		{
		}

		// Token: 0x0600149F RID: 5279 RVA: 0x000196ED File Offset: 0x000178ED
		public override void RenderWire()
		{
		}

		// Token: 0x060014A0 RID: 5280 RVA: 0x000196EF File Offset: 0x000178EF
		public void SetArcData(Plane plane, Vector3 origin, Vector3 startPoint, float radius)
		{
		}

		// Token: 0x060014A1 RID: 5281 RVA: 0x000196F1 File Offset: 0x000178F1
		public override bool Raycast(Ray ray, out float t)
		{
			t = 0f;
			return false;
		}

		// Token: 0x060014A2 RID: 5282 RVA: 0x000196FB File Offset: 0x000178FB
		public override bool RaycastWire(Ray ray, out float t)
		{
			t = 0f;
			return false;
		}

		// Token: 0x060014A3 RID: 5283 RVA: 0x00019705 File Offset: 0x00017905
		public bool ContainsPoint(Vector3 point, bool checkOnPlane)
		{
			return false;
		}

		// Token: 0x060014A4 RID: 5284 RVA: 0x00021F74 File Offset: 0x00020174
		public override AABB GetAABB()
		{
			return default(AABB);
		}

		// Token: 0x060014A5 RID: 5285 RVA: 0x00019708 File Offset: 0x00017908
		private void OnBorderPointsFoundDirty()
		{
		}

		// Token: 0x060014A6 RID: 5286 RVA: 0x0001970A File Offset: 0x0001790A
		private void CalculateEndPoint()
		{
		}

		// Token: 0x04000782 RID: 1922
		private ArcShape3D.WireRenderDescriptor _wireRenderDesc;

		// Token: 0x04000783 RID: 1923
		private Vector3 _startPoint;

		// Token: 0x04000784 RID: 1924
		private Vector3 _endPoint;

		// Token: 0x04000785 RID: 1925
		private Vector3 _origin;

		// Token: 0x04000786 RID: 1926
		private Plane _plane;

		// Token: 0x04000787 RID: 1927
		private float _radius;

		// Token: 0x04000788 RID: 1928
		private AABB _aabb;

		// Token: 0x04000789 RID: 1929
		private float _degreeAngleFromStart;

		// Token: 0x0400078A RID: 1930
		private bool _forceShortestArc;

		// Token: 0x0400078B RID: 1931
		private List<Vector3> _borderPoints;

		// Token: 0x0400078C RID: 1932
		private int _numBorderPoints;

		// Token: 0x0400078D RID: 1933
		private bool _areBorderPointsDirty;

		// Token: 0x0400078E RID: 1934
		private ArcEpsilon _epsilon;

		// Token: 0x0400078F RID: 1935
		private Shape3DRaycastMode _raycastMode;

		// Token: 0x020003AC RID: 940
		public enum WireRenderFlags
		{
			// Token: 0x04000FBA RID: 4026
			None,
			// Token: 0x04000FBB RID: 4027
			ExtremitiesBorder,
			// Token: 0x04000FBC RID: 4028
			ArcBorder,
			// Token: 0x04000FBD RID: 4029
			All
		}

		// Token: 0x020003AD RID: 941
		public class WireRenderDescriptor
		{
			// Token: 0x17000C99 RID: 3225
			// (get) Token: 0x06002AF0 RID: 10992 RVA: 0x00026820 File Offset: 0x00024A20
			// (set) Token: 0x06002AF1 RID: 10993 RVA: 0x0001D3C7 File Offset: 0x0001B5C7
			public ArcShape3D.WireRenderFlags WireFlags
			{
				get
				{
					return ArcShape3D.WireRenderFlags.None;
				}
				set
				{
				}
			}

			// Token: 0x04000FBE RID: 4030
			private ArcShape3D.WireRenderFlags _wireFlags;
		}
	}
}
