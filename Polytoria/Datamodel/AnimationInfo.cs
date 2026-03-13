using System;

namespace Polytoria.Datamodel
{
	// Token: 0x0200028F RID: 655
	public class AnimationInfo
	{
		// Token: 0x17000942 RID: 2370
		// (get) Token: 0x06001D57 RID: 7511 RVA: 0x0001AD62 File Offset: 0x00018F62
		// (set) Token: 0x06001D58 RID: 7512 RVA: 0x0001AD6A File Offset: 0x00018F6A
		public string Name
		{
			get
			{
				return this.<Name>k__BackingField;
			}
			set
			{
				this.<Name>k__BackingField = value;
			}
		}

		// Token: 0x17000943 RID: 2371
		// (get) Token: 0x06001D59 RID: 7513 RVA: 0x0001AD73 File Offset: 0x00018F73
		// (set) Token: 0x06001D5A RID: 7514 RVA: 0x0001AD7B File Offset: 0x00018F7B
		public string Path
		{
			get
			{
				return this.<Path>k__BackingField;
			}
			set
			{
				this.<Path>k__BackingField = value;
			}
		}

		// Token: 0x17000944 RID: 2372
		// (get) Token: 0x06001D5B RID: 7515 RVA: 0x0001AD84 File Offset: 0x00018F84
		// (set) Token: 0x06001D5C RID: 7516 RVA: 0x0001AD8C File Offset: 0x00018F8C
		public float Length
		{
			get
			{
				return this.<Length>k__BackingField;
			}
			set
			{
				this.<Length>k__BackingField = value;
			}
		}

		// Token: 0x17000945 RID: 2373
		// (get) Token: 0x06001D5D RID: 7517 RVA: 0x0001AD95 File Offset: 0x00018F95
		// (set) Token: 0x06001D5E RID: 7518 RVA: 0x0001AD9D File Offset: 0x00018F9D
		public bool IsPlaying
		{
			get
			{
				return this.<IsPlaying>k__BackingField;
			}
			set
			{
				this.<IsPlaying>k__BackingField = value;
			}
		}

		// Token: 0x04000AAE RID: 2734
		private string <Name>k__BackingField;

		// Token: 0x04000AAF RID: 2735
		private string <Path>k__BackingField;

		// Token: 0x04000AB0 RID: 2736
		private float <Length>k__BackingField;

		// Token: 0x04000AB1 RID: 2737
		private bool <IsPlaying>k__BackingField;
	}
}
