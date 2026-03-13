using System;
using Discord;
using UnityEngine;

namespace Polytoria.Controllers
{
	// Token: 0x02000326 RID: 806
	public class DiscordController : MonoBehaviour
	{
		// Token: 0x17000C53 RID: 3155
		// (get) Token: 0x0600282A RID: 10282 RVA: 0x0001CB1C File Offset: 0x0001AD1C
		// (set) Token: 0x0600282B RID: 10283 RVA: 0x0001CB23 File Offset: 0x0001AD23
		public static DiscordController Instance
		{
			get
			{
				return DiscordController.<Instance>k__BackingField;
			}
			private set
			{
				DiscordController.<Instance>k__BackingField = value;
			}
		}

		// Token: 0x17000C54 RID: 3156
		// (get) Token: 0x0600282C RID: 10284 RVA: 0x00026200 File Offset: 0x00024400
		public Activity Activity
		{
			get
			{
				return default(Activity);
			}
		}

		// Token: 0x0600282D RID: 10285 RVA: 0x0001CB2B File Offset: 0x0001AD2B
		private void Awake()
		{
		}

		// Token: 0x0600282E RID: 10286 RVA: 0x0001CB2D File Offset: 0x0001AD2D
		private void Start()
		{
		}

		// Token: 0x0600282F RID: 10287 RVA: 0x0001CB2F File Offset: 0x0001AD2F
		public void UpdateActivity(Activity activity)
		{
		}

		// Token: 0x06002830 RID: 10288 RVA: 0x0001CB31 File Offset: 0x0001AD31
		private void Update()
		{
		}

		// Token: 0x06002831 RID: 10289 RVA: 0x0001CB33 File Offset: 0x0001AD33
		private void OnDestroy()
		{
		}

		// Token: 0x04000D8D RID: 3469
		private static DiscordController <Instance>k__BackingField;

		// Token: 0x04000D8E RID: 3470
		private Discord discord;

		// Token: 0x04000D8F RID: 3471
		private ActivityManager activityManager;

		// Token: 0x04000D90 RID: 3472
		private Activity currentActivity;

		// Token: 0x0200041C RID: 1052
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06002CBF RID: 11455 RVA: 0x0001DA33 File Offset: 0x0001BC33
			internal void <UpdateActivity>b__11_0(Result res)
			{
			}

			// Token: 0x040011AA RID: 4522
			public static readonly DiscordController.<>c <>9;

			// Token: 0x040011AB RID: 4523
			public static ActivityManager.UpdateActivityHandler <>9__11_0;
		}
	}
}
