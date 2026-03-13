using System;
using MoonSharp.Interpreter;
using Polytoria.Datamodel.Services;

namespace Polytoria.Datamodel.Proxies.Services
{
	// Token: 0x02000309 RID: 777
	public class AchievementServiceProxy
	{
		// Token: 0x0600272F RID: 10031 RVA: 0x0001C86C File Offset: 0x0001AA6C
		public AchievementServiceProxy(AchievementService target)
		{
		}

		// Token: 0x06002730 RID: 10032 RVA: 0x0001C874 File Offset: 0x0001AA74
		public void Award(int userID, int achievementID, DynValue callback)
		{
		}

		// Token: 0x06002731 RID: 10033 RVA: 0x0001C876 File Offset: 0x0001AA76
		public void HasAchievement(int userID, int achievementID, DynValue callback)
		{
		}

		// Token: 0x04000D35 RID: 3381
		private readonly AchievementService achievementService;
	}
}
