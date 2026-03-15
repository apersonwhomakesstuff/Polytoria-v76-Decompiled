namespace Polytoria.Controllers;

public class LaunchController : MonoBehaviour
{
	public static LaunchController singleton; //Field offset: 0x0
	public static NetworkType launchType; //Field offset: 0x8
	public static string clientToken; //Field offset: 0x10
	public static string serverToken; //Field offset: 0x18
	public static bool isSolo; //Field offset: 0x20
	public static string soloMapPath; //Field offset: 0x28
	public static string soloUserName; //Field offset: 0x30
	public static int soloUserID; //Field offset: 0x38
	public static int soloID; //Field offset: 0x3C
	public static bool isLocal; //Field offset: 0x40
	public static int localGameId; //Field offset: 0x44
	public static int localUserId; //Field offset: 0x48
	public static string localMapPath; //Field offset: 0x50
	[SerializeField]
	private NetworkType editorLaunchType; //Field offset: 0x20
	[SerializeField]
	private string testToken; //Field offset: 0x28
	[SerializeField]
	private bool doPlaySolo; //Field offset: 0x30
	[SerializeField]
	private string playSoloTestMap; //Field offset: 0x38
	[SerializeField]
	private string playSoloTestUserName; //Field offset: 0x40
	[SerializeField]
	private int playSoloTestUserID; //Field offset: 0x48
	[SerializeField]
	private bool doLocal; //Field offset: 0x4C
	[SerializeField]
	private int testLocalUserId; //Field offset: 0x50
	[SerializeField]
	private int testLocalGameId; //Field offset: 0x54
	[SerializeField]
	private string testLocalMapPath; //Field offset: 0x58
	[SerializeField]
	private string testMobileLaunchURI; //Field offset: 0x60

	private static LaunchController() { }

	public LaunchController() { }

	public static string GetActiveToken() { }

	private Dictionary<String, String> GetCommandLineArgs() { }

	public void LaunchAs(NetworkType netType, string token) { }

	private void OnDeepLinkActivated(string uri) { }

	private void Start() { }

}

