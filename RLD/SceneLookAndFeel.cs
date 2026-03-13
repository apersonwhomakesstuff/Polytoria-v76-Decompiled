using System;
using UnityEngine;

namespace RLD
{
	// Token: 0x020001B8 RID: 440
	[Serializable]
	public class SceneLookAndFeel : Settings
	{
		// Token: 0x17000646 RID: 1606
		// (get) Token: 0x06001359 RID: 4953 RVA: 0x0001937D File Offset: 0x0001757D
		// (set) Token: 0x0600135A RID: 4954 RVA: 0x00019380 File Offset: 0x00017580
		public bool DrawLightIcons
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x17000647 RID: 1607
		// (get) Token: 0x0600135B RID: 4955 RVA: 0x00019382 File Offset: 0x00017582
		// (set) Token: 0x0600135C RID: 4956 RVA: 0x00019385 File Offset: 0x00017585
		public bool DrawParticleSystemIcons
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x17000648 RID: 1608
		// (get) Token: 0x0600135D RID: 4957 RVA: 0x00019387 File Offset: 0x00017587
		// (set) Token: 0x0600135E RID: 4958 RVA: 0x0001938A File Offset: 0x0001758A
		public bool DrawCameraIcons
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x17000649 RID: 1609
		// (get) Token: 0x0600135F RID: 4959 RVA: 0x0001938C File Offset: 0x0001758C
		// (set) Token: 0x06001360 RID: 4960 RVA: 0x00019393 File Offset: 0x00017593
		public float LightIconAlpha
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x1700064A RID: 1610
		// (get) Token: 0x06001361 RID: 4961 RVA: 0x00019395 File Offset: 0x00017595
		// (set) Token: 0x06001362 RID: 4962 RVA: 0x0001939C File Offset: 0x0001759C
		public float ParticleSystemIconAlpha
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x1700064B RID: 1611
		// (get) Token: 0x06001363 RID: 4963 RVA: 0x0001939E File Offset: 0x0001759E
		// (set) Token: 0x06001364 RID: 4964 RVA: 0x000193A5 File Offset: 0x000175A5
		public float CameraIconAlpha
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x1700064C RID: 1612
		// (get) Token: 0x06001365 RID: 4965 RVA: 0x000193A7 File Offset: 0x000175A7
		// (set) Token: 0x06001366 RID: 4966 RVA: 0x000193AA File Offset: 0x000175AA
		public Texture2D LightIcon
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x1700064D RID: 1613
		// (get) Token: 0x06001367 RID: 4967 RVA: 0x000193AC File Offset: 0x000175AC
		// (set) Token: 0x06001368 RID: 4968 RVA: 0x000193AF File Offset: 0x000175AF
		public Texture2D ParticleSystemIcon
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x1700064E RID: 1614
		// (get) Token: 0x06001369 RID: 4969 RVA: 0x000193B1 File Offset: 0x000175B1
		// (set) Token: 0x0600136A RID: 4970 RVA: 0x000193B4 File Offset: 0x000175B4
		public Texture2D CameraIcon
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x040006F3 RID: 1779
		private bool _drawLightIcons;

		// Token: 0x040006F4 RID: 1780
		private bool _drawParticleSystemIcons;

		// Token: 0x040006F5 RID: 1781
		private bool _drawCameraIcons;

		// Token: 0x040006F6 RID: 1782
		private float _lightIconAlpha;

		// Token: 0x040006F7 RID: 1783
		private float _particleSystemIconAlpha;

		// Token: 0x040006F8 RID: 1784
		private float _cameraIconAlpha;

		// Token: 0x040006F9 RID: 1785
		private Texture2D _lightIcon;

		// Token: 0x040006FA RID: 1786
		private Texture2D _particleSystemIcon;

		// Token: 0x040006FB RID: 1787
		private Texture2D _cameraIcon;
	}
}
