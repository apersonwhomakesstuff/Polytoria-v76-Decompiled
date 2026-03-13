using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Mirror;
using UnityEngine.Networking;

namespace Polytoria.Datamodel
{
	// Token: 0x02000281 RID: 641
	public class ImageSky : SkyBase
	{
		// Token: 0x17000914 RID: 2324
		// (get) Token: 0x06001C83 RID: 7299 RVA: 0x0001AB5A File Offset: 0x00018D5A
		// (set) Token: 0x06001C84 RID: 7300 RVA: 0x0001AB5D File Offset: 0x00018D5D
		public int TopId
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x17000915 RID: 2325
		// (get) Token: 0x06001C85 RID: 7301 RVA: 0x0001AB5F File Offset: 0x00018D5F
		// (set) Token: 0x06001C86 RID: 7302 RVA: 0x0001AB62 File Offset: 0x00018D62
		public int BottomId
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x17000916 RID: 2326
		// (get) Token: 0x06001C87 RID: 7303 RVA: 0x0001AB64 File Offset: 0x00018D64
		// (set) Token: 0x06001C88 RID: 7304 RVA: 0x0001AB67 File Offset: 0x00018D67
		public int LeftId
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x17000917 RID: 2327
		// (get) Token: 0x06001C89 RID: 7305 RVA: 0x0001AB69 File Offset: 0x00018D69
		// (set) Token: 0x06001C8A RID: 7306 RVA: 0x0001AB6C File Offset: 0x00018D6C
		public int RightId
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x17000918 RID: 2328
		// (get) Token: 0x06001C8B RID: 7307 RVA: 0x0001AB6E File Offset: 0x00018D6E
		// (set) Token: 0x06001C8C RID: 7308 RVA: 0x0001AB71 File Offset: 0x00018D71
		public int FrontId
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x17000919 RID: 2329
		// (get) Token: 0x06001C8D RID: 7309 RVA: 0x0001AB73 File Offset: 0x00018D73
		// (set) Token: 0x06001C8E RID: 7310 RVA: 0x0001AB76 File Offset: 0x00018D76
		public int BackId
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x06001C8F RID: 7311 RVA: 0x0001AB78 File Offset: 0x00018D78
		protected override void Start()
		{
		}

		// Token: 0x06001C90 RID: 7312 RVA: 0x0001AB7A File Offset: 0x00018D7A
		protected override void Apply()
		{
		}

		// Token: 0x06001C91 RID: 7313 RVA: 0x0001AB7C File Offset: 0x00018D7C
		private void Update()
		{
		}

		// Token: 0x06001C92 RID: 7314 RVA: 0x0001AB7E File Offset: 0x00018D7E
		private IEnumerator LoadSkyboxImage(ImageSky.ImageLoadQueueEntry entry)
		{
			return null;
		}

		// Token: 0x06001C93 RID: 7315 RVA: 0x0001AB81 File Offset: 0x00018D81
		protected override void CopyProperties(Instance clone)
		{
		}

		// Token: 0x06001C94 RID: 7316 RVA: 0x0001AB83 File Offset: 0x00018D83
		private void RpcSetImageId(ImageSky.SkyboxSide side, int id)
		{
		}

		// Token: 0x06001C97 RID: 7319 RVA: 0x0001AB8F File Offset: 0x00018D8F
		public override bool Weaved()
		{
			return false;
		}

		// Token: 0x1700091A RID: 2330
		// (get) Token: 0x06001C98 RID: 7320 RVA: 0x0001AB92 File Offset: 0x00018D92
		// (set) Token: 0x06001C99 RID: 7321 RVA: 0x0001AB95 File Offset: 0x00018D95
		public int NetworktopId
		{
			get
			{
				return 0;
			}
			[param: In]
			set
			{
			}
		}

		// Token: 0x1700091B RID: 2331
		// (get) Token: 0x06001C9A RID: 7322 RVA: 0x0001AB97 File Offset: 0x00018D97
		// (set) Token: 0x06001C9B RID: 7323 RVA: 0x0001AB9A File Offset: 0x00018D9A
		public int NetworkbottomId
		{
			get
			{
				return 0;
			}
			[param: In]
			set
			{
			}
		}

		// Token: 0x1700091C RID: 2332
		// (get) Token: 0x06001C9C RID: 7324 RVA: 0x0001AB9C File Offset: 0x00018D9C
		// (set) Token: 0x06001C9D RID: 7325 RVA: 0x0001AB9F File Offset: 0x00018D9F
		public int NetworkleftId
		{
			get
			{
				return 0;
			}
			[param: In]
			set
			{
			}
		}

		// Token: 0x1700091D RID: 2333
		// (get) Token: 0x06001C9E RID: 7326 RVA: 0x0001ABA1 File Offset: 0x00018DA1
		// (set) Token: 0x06001C9F RID: 7327 RVA: 0x0001ABA4 File Offset: 0x00018DA4
		public int NetworkrightId
		{
			get
			{
				return 0;
			}
			[param: In]
			set
			{
			}
		}

		// Token: 0x1700091E RID: 2334
		// (get) Token: 0x06001CA0 RID: 7328 RVA: 0x0001ABA6 File Offset: 0x00018DA6
		// (set) Token: 0x06001CA1 RID: 7329 RVA: 0x0001ABA9 File Offset: 0x00018DA9
		public int NetworkfrontId
		{
			get
			{
				return 0;
			}
			[param: In]
			set
			{
			}
		}

		// Token: 0x1700091F RID: 2335
		// (get) Token: 0x06001CA2 RID: 7330 RVA: 0x0001ABAB File Offset: 0x00018DAB
		// (set) Token: 0x06001CA3 RID: 7331 RVA: 0x0001ABAE File Offset: 0x00018DAE
		public int NetworkbackId
		{
			get
			{
				return 0;
			}
			[param: In]
			set
			{
			}
		}

		// Token: 0x06001CA4 RID: 7332 RVA: 0x0001ABB0 File Offset: 0x00018DB0
		protected void UserCode_RpcSetImageId__SkyboxSide__Int32(ImageSky.SkyboxSide side, int id)
		{
		}

		// Token: 0x06001CA5 RID: 7333 RVA: 0x0001ABB2 File Offset: 0x00018DB2
		protected static void InvokeUserCode_RpcSetImageId__SkyboxSide__Int32(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		// Token: 0x06001CA6 RID: 7334 RVA: 0x0001ABB4 File Offset: 0x00018DB4
		public override void SerializeSyncVars(NetworkWriter writer, bool forceAll)
		{
		}

		// Token: 0x06001CA7 RID: 7335 RVA: 0x0001ABB6 File Offset: 0x00018DB6
		public override void DeserializeSyncVars(NetworkReader reader, bool initialState)
		{
		}

		// Token: 0x04000A70 RID: 2672
		private static readonly string topTextureName;

		// Token: 0x04000A71 RID: 2673
		private static readonly string bottomTextureName;

		// Token: 0x04000A72 RID: 2674
		private static readonly string leftTextureName;

		// Token: 0x04000A73 RID: 2675
		private static readonly string rightTextureName;

		// Token: 0x04000A74 RID: 2676
		private static readonly string frontTextureName;

		// Token: 0x04000A75 RID: 2677
		private static readonly string backTextureName;

		// Token: 0x04000A76 RID: 2678
		private bool processing;

		// Token: 0x04000A77 RID: 2679
		private int topId;

		// Token: 0x04000A78 RID: 2680
		private int bottomId;

		// Token: 0x04000A79 RID: 2681
		private int leftId;

		// Token: 0x04000A7A RID: 2682
		private int rightId;

		// Token: 0x04000A7B RID: 2683
		private int frontId;

		// Token: 0x04000A7C RID: 2684
		private int backId;

		// Token: 0x04000A7D RID: 2685
		private Queue<ImageSky.ImageLoadQueueEntry> queue;

		// Token: 0x020003EA RID: 1002
		private struct ImageLoadQueueEntry
		{
			// Token: 0x17000CCA RID: 3274
			// (get) Token: 0x06002B93 RID: 11155 RVA: 0x0001D60B File Offset: 0x0001B80B
			// (set) Token: 0x06002B94 RID: 11156 RVA: 0x0001D613 File Offset: 0x0001B813
			public string TextureName
			{
				get
				{
					return this.<TextureName>k__BackingField;
				}
				set
				{
					this.<TextureName>k__BackingField = value;
				}
			}

			// Token: 0x17000CCB RID: 3275
			// (get) Token: 0x06002B95 RID: 11157 RVA: 0x0001D61C File Offset: 0x0001B81C
			// (set) Token: 0x06002B96 RID: 11158 RVA: 0x0001D624 File Offset: 0x0001B824
			public int ImageId
			{
				get
				{
					return this.<ImageId>k__BackingField;
				}
				set
				{
					this.<ImageId>k__BackingField = value;
				}
			}

			// Token: 0x0400108F RID: 4239
			private string <TextureName>k__BackingField;

			// Token: 0x04001090 RID: 4240
			private int <ImageId>k__BackingField;
		}

		// Token: 0x020003EB RID: 1003
		private enum SkyboxSide
		{
			// Token: 0x04001092 RID: 4242
			Top,
			// Token: 0x04001093 RID: 4243
			Bottom,
			// Token: 0x04001094 RID: 4244
			Left,
			// Token: 0x04001095 RID: 4245
			Right,
			// Token: 0x04001096 RID: 4246
			Front,
			// Token: 0x04001097 RID: 4247
			Back
		}

		// Token: 0x020003EC RID: 1004
		private sealed class <LoadSkyboxImage>d__35 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x06002B97 RID: 11159 RVA: 0x0001D62D File Offset: 0x0001B82D
			public <LoadSkyboxImage>d__35(int <>1__state)
			{
			}

			// Token: 0x06002B98 RID: 11160 RVA: 0x0001D635 File Offset: 0x0001B835
			void IDisposable.Dispose()
			{
			}

			// Token: 0x06002B99 RID: 11161 RVA: 0x0001D637 File Offset: 0x0001B837
			bool IEnumerator.MoveNext()
			{
				return false;
			}

			// Token: 0x06002B9A RID: 11162 RVA: 0x0001D63A File Offset: 0x0001B83A
			private void <>m__Finally1()
			{
			}

			// Token: 0x06002B9B RID: 11163 RVA: 0x0001D63C File Offset: 0x0001B83C
			private void <>m__Finally2()
			{
			}

			// Token: 0x17000CCC RID: 3276
			// (get) Token: 0x06002B9C RID: 11164 RVA: 0x0001D63E File Offset: 0x0001B83E
			object IEnumerator<object>.Current
			{
				get
				{
					return null;
				}
			}

			// Token: 0x06002B9D RID: 11165 RVA: 0x0001D641 File Offset: 0x0001B841
			void IEnumerator.Reset()
			{
			}

			// Token: 0x17000CCD RID: 3277
			// (get) Token: 0x06002B9E RID: 11166 RVA: 0x0001D643 File Offset: 0x0001B843
			object IEnumerator.Current
			{
				get
				{
					return null;
				}
			}

			// Token: 0x04001098 RID: 4248
			private int <>1__state;

			// Token: 0x04001099 RID: 4249
			private object <>2__current;

			// Token: 0x0400109A RID: 4250
			public ImageSky <>4__this;

			// Token: 0x0400109B RID: 4251
			public ImageSky.ImageLoadQueueEntry entry;

			// Token: 0x0400109C RID: 4252
			private UnityWebRequest <uwr>5__2;

			// Token: 0x0400109D RID: 4253
			private UnityWebRequest <twr>5__3;
		}
	}
}
