using System;
using System.Collections.Generic;
using UnityEngine;

namespace RLD
{
	// Token: 0x020001F0 RID: 496
	public class TorusShape3D : Shape3D
	{
		// Token: 0x170007D1 RID: 2001
		// (get) Token: 0x060016FD RID: 5885 RVA: 0x00019CB3 File Offset: 0x00017EB3
		// (set) Token: 0x060016FE RID: 5886 RVA: 0x00019CBA File Offset: 0x00017EBA
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

		// Token: 0x170007D2 RID: 2002
		// (get) Token: 0x060016FF RID: 5887 RVA: 0x00019CBC File Offset: 0x00017EBC
		// (set) Token: 0x06001700 RID: 5888 RVA: 0x00019CC3 File Offset: 0x00017EC3
		public float TubeRadius
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x170007D3 RID: 2003
		// (get) Token: 0x06001701 RID: 5889 RVA: 0x000233E4 File Offset: 0x000215E4
		// (set) Token: 0x06001702 RID: 5890 RVA: 0x00019CC5 File Offset: 0x00017EC5
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

		// Token: 0x170007D4 RID: 2004
		// (get) Token: 0x06001703 RID: 5891 RVA: 0x000233FC File Offset: 0x000215FC
		// (set) Token: 0x06001704 RID: 5892 RVA: 0x00019CC7 File Offset: 0x00017EC7
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

		// Token: 0x170007D5 RID: 2005
		// (get) Token: 0x06001705 RID: 5893 RVA: 0x00023414 File Offset: 0x00021614
		public Vector3 Right
		{
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x170007D6 RID: 2006
		// (get) Token: 0x06001706 RID: 5894 RVA: 0x0002342C File Offset: 0x0002162C
		public Vector3 Up
		{
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x170007D7 RID: 2007
		// (get) Token: 0x06001707 RID: 5895 RVA: 0x00023444 File Offset: 0x00021644
		public Vector3 Look
		{
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x170007D8 RID: 2008
		// (get) Token: 0x06001708 RID: 5896 RVA: 0x0002345C File Offset: 0x0002165C
		// (set) Token: 0x06001709 RID: 5897 RVA: 0x00019CC9 File Offset: 0x00017EC9
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

		// Token: 0x170007D9 RID: 2009
		// (get) Token: 0x0600170A RID: 5898 RVA: 0x00019CCB File Offset: 0x00017ECB
		// (set) Token: 0x0600170B RID: 5899 RVA: 0x00019CD2 File Offset: 0x00017ED2
		public float TubeRadiusEps
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x170007DA RID: 2010
		// (get) Token: 0x0600170C RID: 5900 RVA: 0x00019CD4 File Offset: 0x00017ED4
		public TorusShape3D.WireRenderDescriptor WireRenderDesc
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170007DB RID: 2011
		// (get) Token: 0x0600170D RID: 5901 RVA: 0x00023474 File Offset: 0x00021674
		public static Vector3 ModelRight
		{
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x170007DC RID: 2012
		// (get) Token: 0x0600170E RID: 5902 RVA: 0x0002348C File Offset: 0x0002168C
		public static Vector3 ModelUp
		{
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x170007DD RID: 2013
		// (get) Token: 0x0600170F RID: 5903 RVA: 0x000234A4 File Offset: 0x000216A4
		public static Vector3 ModelLook
		{
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x170007DE RID: 2014
		// (get) Token: 0x06001710 RID: 5904 RVA: 0x000234BC File Offset: 0x000216BC
		public static Vector3 ModelCenter
		{
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x06001711 RID: 5905 RVA: 0x00019CD7 File Offset: 0x00017ED7
		public override bool Raycast(Ray ray, out float t)
		{
			t = 0f;
			return false;
		}

		// Token: 0x06001712 RID: 5906 RVA: 0x00019CE1 File Offset: 0x00017EE1
		public override void RenderSolid()
		{
		}

		// Token: 0x06001713 RID: 5907 RVA: 0x00019CE3 File Offset: 0x00017EE3
		public override void RenderWire()
		{
		}

		// Token: 0x06001714 RID: 5908 RVA: 0x00019CE5 File Offset: 0x00017EE5
		public List<Vector3> GetHrzExtents()
		{
			return null;
		}

		// Token: 0x06001715 RID: 5909 RVA: 0x000234D4 File Offset: 0x000216D4
		public override AABB GetAABB()
		{
			return default(AABB);
		}

		// Token: 0x0400080A RID: 2058
		private float _coreRadius;

		// Token: 0x0400080B RID: 2059
		private float _tubeRadius;

		// Token: 0x0400080C RID: 2060
		private Vector3 _center;

		// Token: 0x0400080D RID: 2061
		private Quaternion _rotation;

		// Token: 0x0400080E RID: 2062
		private TorusEpsilon _epsilon;

		// Token: 0x0400080F RID: 2063
		private TorusShape3D.WireRenderDescriptor _wireRenderDesc;

		// Token: 0x020003B8 RID: 952
		public enum WireRenderFlags
		{
			// Token: 0x04000FE1 RID: 4065
			None,
			// Token: 0x04000FE2 RID: 4066
			TubeSlices,
			// Token: 0x04000FE3 RID: 4067
			AxialSlices,
			// Token: 0x04000FE4 RID: 4068
			All
		}

		// Token: 0x020003B9 RID: 953
		public class WireRenderDescriptor
		{
			// Token: 0x17000CA8 RID: 3240
			// (get) Token: 0x06002B14 RID: 11028 RVA: 0x0001D436 File Offset: 0x0001B636
			// (set) Token: 0x06002B15 RID: 11029 RVA: 0x0001D439 File Offset: 0x0001B639
			public int NumTubeSlices
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			// Token: 0x17000CA9 RID: 3241
			// (get) Token: 0x06002B16 RID: 11030 RVA: 0x0001D43B File Offset: 0x0001B63B
			// (set) Token: 0x06002B17 RID: 11031 RVA: 0x0001D43E File Offset: 0x0001B63E
			public int NumAxialSlices
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			// Token: 0x17000CAA RID: 3242
			// (get) Token: 0x06002B18 RID: 11032 RVA: 0x000268E0 File Offset: 0x00024AE0
			// (set) Token: 0x06002B19 RID: 11033 RVA: 0x0001D440 File Offset: 0x0001B640
			public TorusShape3D.WireRenderFlags WireFlags
			{
				get
				{
					return TorusShape3D.WireRenderFlags.None;
				}
				set
				{
				}
			}

			// Token: 0x04000FE5 RID: 4069
			private TorusShape3D.WireRenderFlags _wireFlags;

			// Token: 0x04000FE6 RID: 4070
			private int _numTubeSlices;

			// Token: 0x04000FE7 RID: 4071
			private int _numAxialSlices;
		}
	}
}
