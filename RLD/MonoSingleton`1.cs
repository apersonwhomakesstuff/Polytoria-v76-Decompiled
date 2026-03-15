namespace RLD;

public class MonoSingleton : MonoBehaviour
{
	private static object _singletonLock; //Field offset: 0x0
	private static T _instance; //Field offset: 0x0

	public static T Get
	{
		 get { } //Length: 1177
	}

	private static MonoSingleton`1() { }

	public MonoSingleton`1() { }

	public static T get_Get() { }

}

