namespace Polytoria.Datamodel.Proxies.Services;

public class AchievementServiceProxy
{
	private readonly AchievementService achievementService; //Field offset: 0x10

	[MoonSharpHidden]
	public AchievementServiceProxy(AchievementService target) { }

	[LuaCallbackParameter("callback", typeof(bool), "success", False)]
	[LuaCallbackParameter("callback", typeof(string), "error", True)]
	public void Award(int userID, int achievementID, DynValue callback) { }

	[LuaCallbackParameter("callback", typeof(bool), "owned", False)]
	[LuaCallbackParameter("callback", typeof(bool), "success", False)]
	[LuaCallbackParameter("callback", typeof(string), "error", True)]
	public void HasAchievement(int userID, int achievementID, DynValue callback) { }

}

