using System;
using UnityEngine;

namespace RLD
{
	// Token: 0x02000199 RID: 409
	[Serializable]
	public class RTPrefab
	{
		// Token: 0x170005C9 RID: 1481
		// (get) Token: 0x06001213 RID: 4627 RVA: 0x0001901B File Offset: 0x0001721B
		// (set) Token: 0x06001214 RID: 4628 RVA: 0x0001901E File Offset: 0x0001721E
		public GameObject UnityPrefab
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x170005CA RID: 1482
		// (get) Token: 0x06001215 RID: 4629 RVA: 0x00019020 File Offset: 0x00017220
		// (set) Token: 0x06001216 RID: 4630 RVA: 0x00019023 File Offset: 0x00017223
		public Texture2D PreviewTexture
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x170005CB RID: 1483
		// (get) Token: 0x06001217 RID: 4631 RVA: 0x00019025 File Offset: 0x00017225
		public Sprite PreviewSprite
		{
			get
			{
				return null;
			}
		}

		// Token: 0x06001218 RID: 4632 RVA: 0x00019028 File Offset: 0x00017228
		public GameObject Instantiate()
		{
			return null;
		}

		// Token: 0x06001219 RID: 4633 RVA: 0x0001902B File Offset: 0x0001722B
		public GameObject Instantiate(Vector3 worldPos, Quaternion worldRotation)
		{
			return null;
		}

		// Token: 0x0600121A RID: 4634 RVA: 0x0001902E File Offset: 0x0001722E
		public GameObject Instantiate(Vector3 worldPos, Quaternion worldRotation, Vector3 worldScale)
		{
			return null;
		}

		// Token: 0x0400066C RID: 1644
		private GameObject _unityPrefab;

		// Token: 0x0400066D RID: 1645
		private Texture2D _previewTexture;

		// Token: 0x0400066E RID: 1646
		[NonSerialized]
		private Sprite _previewSprite;
	}
}
