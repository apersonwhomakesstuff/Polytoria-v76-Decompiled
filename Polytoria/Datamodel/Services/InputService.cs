namespace Polytoria.Datamodel.Services;

public class InputService
{
	public static LuaEvent KeyDown; //Field offset: 0x0
	public static LuaEvent KeyUp; //Field offset: 0x8

	public static bool AnyKey
	{
		 get { } //Length: 7
	}

	public static bool AnyKeyDown
	{
		 get { } //Length: 7
	}

	public static bool CursorLocked
	{
		 get { } //Length: 22
		 set { } //Length: 12
	}

	public static bool CursorVisible
	{
		 get { } //Length: 7
		 set { } //Length: 7
	}

	public static bool IsInputFocused
	{
		 get { } //Length: 336
	}

	public static Vector3 MousePosition
	{
		 get { } //Length: 44
	}

	public static int ScreenHeight
	{
		 get { } //Length: 7
	}

	public static int ScreenWidth
	{
		 get { } //Length: 7
	}

	private static InputService() { }

	public InputService() { }

	public static bool get_AnyKey() { }

	public static bool get_AnyKeyDown() { }

	public static bool get_CursorLocked() { }

	public static bool get_CursorVisible() { }

	public static bool get_IsInputFocused() { }

	public static Vector3 get_MousePosition() { }

	public static int get_ScreenHeight() { }

	public static int get_ScreenWidth() { }

	public static float GetAxis(string axisName) { }

	public static float GetAxisRaw(string axisName) { }

	public static bool GetButton(string buttonName) { }

	public static bool GetButtonDown(string buttonName) { }

	public static bool GetButtonUp(string buttonName) { }

	public static bool GetKey(KeyCode key) { }

	public static bool GetKeyDown(KeyCode key) { }

	public static bool GetKeyUp(KeyCode key) { }

	public static bool GetMouseButton(int button) { }

	public static bool GetMouseButtonDown(int button) { }

	public static bool GetMouseButtonUp(int button) { }

	public static Vector3 GetMouseWorldPoint() { }

	public static Vector3 GetMouseWorldPosition() { }

	public static Nullable<RayResult> ScreenPointToRay(Vector3 pos, List<Instance> ignoreList = null) { }

	public static Vector3 ScreenToViewportPoint(Vector3 pos) { }

	public static Vector3 ScreenToWorldPoint(Vector3 pos) { }

	public static void set_CursorLocked(bool value) { }

	public static void set_CursorVisible(bool value) { }

	public static Nullable<RayResult> ViewportPointToRay(Vector3 pos, List<Instance> ignoreList = null) { }

	public static Vector3 ViewportToScreenPoint(Vector3 pos) { }

	public static Vector3 ViewportToWorldPoint(Vector3 pos) { }

	public static Vector3 WorldToScreenPoint(Vector3 pos) { }

	public static Vector3 WorldToViewportPoint(Vector3 pos) { }

}

