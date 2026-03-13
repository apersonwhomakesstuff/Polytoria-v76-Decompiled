using System;

namespace RLD
{
	// Token: 0x020001CD RID: 461
	[Serializable]
	public class ObjectGrabSettings : Settings
	{
		// Token: 0x17000688 RID: 1672
		// (get) Token: 0x0600141A RID: 5146 RVA: 0x00019585 File Offset: 0x00017785
		// (set) Token: 0x0600141B RID: 5147 RVA: 0x00019588 File Offset: 0x00017788
		public bool AlignAxis
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x17000689 RID: 1673
		// (get) Token: 0x0600141C RID: 5148 RVA: 0x00021D94 File Offset: 0x0001FF94
		// (set) Token: 0x0600141D RID: 5149 RVA: 0x0001958A File Offset: 0x0001778A
		public TransformAxis AlignmentAxis
		{
			get
			{
				return TransformAxis.PositiveX;
			}
			set
			{
			}
		}

		// Token: 0x1700068A RID: 1674
		// (get) Token: 0x0600141E RID: 5150 RVA: 0x0001958C File Offset: 0x0001778C
		// (set) Token: 0x0600141F RID: 5151 RVA: 0x00019593 File Offset: 0x00017793
		public float RotationSensitivity
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x1700068B RID: 1675
		// (get) Token: 0x06001420 RID: 5152 RVA: 0x00019595 File Offset: 0x00017795
		// (set) Token: 0x06001421 RID: 5153 RVA: 0x0001959C File Offset: 0x0001779C
		public float ScaleSensitivity
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x1700068C RID: 1676
		// (get) Token: 0x06001422 RID: 5154 RVA: 0x0001959E File Offset: 0x0001779E
		// (set) Token: 0x06001423 RID: 5155 RVA: 0x000195A5 File Offset: 0x000177A5
		public float OffsetFromSurfaceSensitivity
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x1700068D RID: 1677
		// (get) Token: 0x06001424 RID: 5156 RVA: 0x000195A7 File Offset: 0x000177A7
		// (set) Token: 0x06001425 RID: 5157 RVA: 0x000195AE File Offset: 0x000177AE
		public float OffsetFromAnchorSensitivity
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x1700068E RID: 1678
		// (get) Token: 0x06001426 RID: 5158 RVA: 0x00021DAC File Offset: 0x0001FFAC
		// (set) Token: 0x06001427 RID: 5159 RVA: 0x000195B0 File Offset: 0x000177B0
		public ObjectGrabSurfaceFlags SurfaceFlags
		{
			get
			{
				return (ObjectGrabSurfaceFlags)0;
			}
			set
			{
			}
		}

		// Token: 0x1700068F RID: 1679
		// (get) Token: 0x06001428 RID: 5160 RVA: 0x000195B2 File Offset: 0x000177B2
		// (set) Token: 0x06001429 RID: 5161 RVA: 0x000195B9 File Offset: 0x000177B9
		public float DefaultOffsetFromSurface
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x17000690 RID: 1680
		// (get) Token: 0x0600142A RID: 5162 RVA: 0x000195BB File Offset: 0x000177BB
		// (set) Token: 0x0600142B RID: 5163 RVA: 0x000195BE File Offset: 0x000177BE
		public int SurfaceLayers
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x17000691 RID: 1681
		// (get) Token: 0x0600142C RID: 5164 RVA: 0x000195C0 File Offset: 0x000177C0
		// (set) Token: 0x0600142D RID: 5165 RVA: 0x000195C3 File Offset: 0x000177C3
		public int SphericalMeshLayers
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x17000692 RID: 1682
		// (get) Token: 0x0600142E RID: 5166 RVA: 0x000195C5 File Offset: 0x000177C5
		// (set) Token: 0x0600142F RID: 5167 RVA: 0x000195C8 File Offset: 0x000177C8
		public int TerrainMeshLayers
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x06001431 RID: 5169 RVA: 0x000195D2 File Offset: 0x000177D2
		public ObjectLayerGrabSettings GetLayerGrabSettings(int layer)
		{
			return null;
		}

		// Token: 0x0400074F RID: 1871
		private bool _alignAxis;

		// Token: 0x04000750 RID: 1872
		private TransformAxis _alignmentAxis;

		// Token: 0x04000751 RID: 1873
		private float _rotationSensitivity;

		// Token: 0x04000752 RID: 1874
		private float _scaleSensitivity;

		// Token: 0x04000753 RID: 1875
		private float _offsetFromSurfaceSensitivity;

		// Token: 0x04000754 RID: 1876
		private float _offsetFromAnchorSensitivity;

		// Token: 0x04000755 RID: 1877
		private ObjectGrabSurfaceFlags _surfaceFlags;

		// Token: 0x04000756 RID: 1878
		private float _defaultOffsetFromSurface;

		// Token: 0x04000757 RID: 1879
		private int _surfaceLayers;

		// Token: 0x04000758 RID: 1880
		private ObjectLayerGrabSettings[] _layerGrabSettings;

		// Token: 0x04000759 RID: 1881
		private int _sphericalMeshLayers;

		// Token: 0x0400075A RID: 1882
		private int _terrainMeshLayers;
	}
}
