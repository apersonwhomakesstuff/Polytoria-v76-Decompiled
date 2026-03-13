using System;
using System.Collections.Generic;
using UnityEngine;

namespace RLD
{
	// Token: 0x0200020F RID: 527
	public class EditorPrefabPreviewGen
	{
		// Token: 0x060017D5 RID: 6101 RVA: 0x00019E5A File Offset: 0x0001805A
		public bool BeginGenSession(PrefabPreviewLookAndFeel previewLookAndFeel)
		{
			return false;
		}

		// Token: 0x060017D6 RID: 6102 RVA: 0x00019E5D File Offset: 0x0001805D
		public void EndGenSession()
		{
		}

		// Token: 0x060017D7 RID: 6103 RVA: 0x00019E5F File Offset: 0x0001805F
		public Texture2D Generate(GameObject unityPrefab)
		{
			return null;
		}

		// Token: 0x060017D8 RID: 6104 RVA: 0x00019E62 File Offset: 0x00018062
		private bool CreateRenderCamera()
		{
			return false;
		}

		// Token: 0x060017D9 RID: 6105 RVA: 0x00019E65 File Offset: 0x00018065
		private bool CreatePreviewLight()
		{
			return false;
		}

		// Token: 0x060017DA RID: 6106 RVA: 0x00019E68 File Offset: 0x00018068
		private void CreateNonMeshPreviewObject()
		{
		}

		// Token: 0x060017DB RID: 6107 RVA: 0x00019E6A File Offset: 0x0001806A
		private void DisableSceneLights()
		{
		}

		// Token: 0x060017DC RID: 6108 RVA: 0x00019E6C File Offset: 0x0001806C
		private void RestoreSceneLights()
		{
		}

		// Token: 0x0400084D RID: 2125
		private PrefabPreviewLookAndFeel _previewLookAndFeel;

		// Token: 0x0400084E RID: 2126
		private ObjectBounds.QueryConfig _boundsQConfig;

		// Token: 0x0400084F RID: 2127
		private Light _previewLight;

		// Token: 0x04000850 RID: 2128
		private Camera _renderCamera;

		// Token: 0x04000851 RID: 2129
		private bool _isGenSessionActive;

		// Token: 0x04000852 RID: 2130
		private Dictionary<Light, bool> _lightToState;

		// Token: 0x04000853 RID: 2131
		private GameObject _nonMeshPreviewObject;

		// Token: 0x020003CC RID: 972
		private enum PreviewObjectType
		{
			// Token: 0x0400102E RID: 4142
			Mesh = 1,
			// Token: 0x0400102F RID: 4143
			Sprite,
			// Token: 0x04001030 RID: 4144
			Light,
			// Token: 0x04001031 RID: 4145
			ParticleSystem,
			// Token: 0x04001032 RID: 4146
			Other
		}
	}
}
